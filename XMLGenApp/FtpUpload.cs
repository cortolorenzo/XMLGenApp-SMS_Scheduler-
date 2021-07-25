using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace XMLGenApp
{
    public class FtpUpload
    {
        private static string value;
        Form1 MainForm;
        
        public FtpUpload(Form1 form1)
        {
            MainForm = form1;
        }

        

        public async Task UploadXMLToFTP(string filenameonftp, string fileinfopath, CancellationToken cancellationToken)
        {

            
            await Task.Run(async () =>
            {


                MainForm.taskStatus = true;
                MainForm.pbUploadFTP.Invoke(
                           (MethodInvoker)delegate { MainForm.SetSize(987, 633); });

                if (cancellationToken.IsCancellationRequested)
                    throw new OperationCanceledException(cancellationToken);

                string CompleteDPath = "ftp://mmiszkur@mmiszkurka.pl/domains/mmiszkurka.pl/public_html/";
                string FileName = filenameonftp;

                FtpWebRequest ftpClient = (FtpWebRequest)FtpWebRequest.Create(CompleteDPath + FileName);
                ftpClient.Credentials = new System.Net.NetworkCredential("mmiszkur", "Itjestnajlepsze777");
                ftpClient.Method = System.Net.WebRequestMethods.Ftp.UploadFile;
                ftpClient.UseBinary = true;
                ftpClient.KeepAlive = true;
                System.IO.FileInfo fi = new System.IO.FileInfo(fileinfopath);
                ftpClient.ContentLength = fi.Length;
                byte[] buffer = new byte[7000];
                int bytes = 0;
                int total_bytes = (int)fi.Length;
                System.IO.FileStream fs = fi.OpenRead();
                var stopwatch = new Stopwatch();
                stopwatch.Start();
                double percent;

                if (cancellationToken.IsCancellationRequested)
                    throw new OperationCanceledException(cancellationToken);


                try
                {
                    System.IO.Stream rs = await ftpClient.GetRequestStreamAsync();
                    MainForm.pbUploadFTP.Invoke(
                    (MethodInvoker)delegate { MainForm.pbUploadFTP.Maximum = (int)fs.Length; });

                    while ((bytes = fs.Read(buffer, 0, buffer.Length)) > 0)
                    {

                        //(total_bytes > 0)
                        //bytes = fs.Read(buffer, 0, buffer.Length);
                        rs.Write(buffer, 0, bytes);
                        //total_bytes = total_bytes - bytes;

                        if (cancellationToken.IsCancellationRequested)
                            throw new OperationCanceledException(cancellationToken);


                        MainForm.pbUploadFTP.Invoke(
                           (MethodInvoker)delegate { MainForm.pbUploadFTP.Value = (int)fs.Position; });
                        
                        percent = Math.Round((((double)MainForm.pbUploadFTP.Value / (double)MainForm.pbUploadFTP.Maximum) * 100), MidpointRounding.AwayFromZero);
                        MainForm.pbUploadFTP.Invoke(
                           (MethodInvoker)delegate { MainForm.lblProgressBar.Text = percent + " %"; });


                        
                        




                    }
                    fs.Close();
                    rs.Close();
                    FtpWebResponse uploadResponse = (FtpWebResponse)ftpClient.GetResponse();
                    value = uploadResponse.StatusDescription;
                    uploadResponse.Close();
                    stopwatch.Stop();
                    string time = (stopwatch.Elapsed.TotalSeconds.ToString());
                    MessageBox.Show("Upload Succesfull! Time: " + time + " sec", "Success");
                    MainForm.pbUploadFTP.Invoke(
                           (MethodInvoker)delegate { MainForm.pbUploadFTP.Value = 0; });
                    MainForm.pbUploadFTP.Invoke(
                           (MethodInvoker)delegate { MainForm.lblProgressBar.Text =  "0 %"; });

                    MainForm.pbUploadFTP.Invoke(
                           (MethodInvoker)delegate { MainForm.SetSize(987, 511); });

                }
                catch (OperationCanceledException oc)
                {
                    MessageBox.Show("Operacja anulowana przez użytkownika", "Status");

                    MainForm.pbUploadFTP.Invoke(
                           (MethodInvoker)delegate { MainForm.pbUploadFTP.Value = 0; });
                    MainForm.pbUploadFTP.Invoke(
                           (MethodInvoker)delegate { MainForm.lblProgressBar.Text = "0 %"; });
                    
                    MainForm.pbUploadFTP.Invoke(
                           (MethodInvoker)delegate { MainForm.SetSize(987, 511); });
                }
                catch (Exception ex)
                {

                    MainForm.pbUploadFTP.Invoke(
                           (MethodInvoker)delegate { MainForm.pbUploadFTP.Value = 0; });
                    MainForm.pbUploadFTP.Invoke(
                           (MethodInvoker)delegate { MainForm.lblProgressBar.Text = "0 %"; });
                    MessageBox.Show("Error : " + ex.Message, "Error");
                    MainForm.pbUploadFTP.Invoke(
                           (MethodInvoker)delegate { MainForm.SetSize(987, 511); });
                }
                finally
                {
                    MainForm.taskStatus = false;
                }
               
            }, cancellationToken);

               
            
               
           
                //fs.Flush();
                
             
               

            




        }

    }

}
