using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WECPOFLogic;

namespace XMLGenApp
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }
        private BindingSource bd1 = new BindingSource();
        private BindingSource bd2 = new BindingSource();

        private void Form1_Load(object sender, EventArgs e)
        {

            selMsgGroup1TableAdapter.Fill(devDBDataSet1.SelMsgGroup1, 1);
            selMsgGroup2TableAdapter.Fill(devDBDataSet1.SelMsgGroup2, 2);
            selMsgGroup3TableAdapter.Fill(devDBDataSet1.SelMsgGroup3, 3);

            this.dataGridView1.Columns["ID"].Visible = false;
            this.dataGridView2.Columns["ID2"].Visible = false;
            this.dataGridView3.Columns["ID3"].Visible = false;

            dataGridView1.RowHeadersVisible = false;
            dataGridView2.RowHeadersVisible = false;
            dataGridView3.RowHeadersVisible = false;

            
            this.metroTabControl1.SelectTab(metroTabPage1);
            //this.lblProgressBar.Parent = this.pbUploadFTP;
            this.lblProgressBar.BackColor = Color.Transparent;
            this.Size = new Size(987, 511);

            MessageBoxManager.Yes = "Yes!";
            MessageBoxManager.No = "No!";
            MessageBoxManager.Register();
            

        }

        public void SetSize(int width, int height)
        {
            this.Size = new Size(width, height);
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {


            DevDBDataSetTableAdapters.SelMsgGroup1TableAdapter tableAdapter = new DevDBDataSetTableAdapters.SelMsgGroup1TableAdapter();
            DevDBDataSetTableAdapters.SelMsgGroup2TableAdapter tableAdapter2 = new DevDBDataSetTableAdapters.SelMsgGroup2TableAdapter();
            DevDBDataSetTableAdapters.SelMsgGroup3TableAdapter tableAdapter3 = new DevDBDataSetTableAdapters.SelMsgGroup3TableAdapter();

            try
            {
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {

                    int ID = Int32.Parse(dataGridView1.Rows[i].Cells[0].Value.ToString());
                    string msg = dataGridView1.Rows[i].Cells[1].Value.ToString();
                    int grpid = Int32.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString());


                    tableAdapter.Insert(ID, msg, grpid);
                    //MessageBox.Show(ID + msg + grpid, "test");
                }

                for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
                {

                    int ID = Int32.Parse(dataGridView2.Rows[i].Cells[0].Value.ToString());
                    string msg = dataGridView2.Rows[i].Cells[1].Value.ToString();
                    int grpid = Int32.Parse(dataGridView2.Rows[i].Cells[2].Value.ToString());


                    tableAdapter2.Insert(ID, msg, grpid);
                    //MessageBox.Show(ID + msg + grpid, "test");
                }

                for (int i = 0; i < dataGridView3.Rows.Count - 1; i++)
                {

                    int ID = Int32.Parse(dataGridView3.Rows[i].Cells[0].Value.ToString());
                    string msg = dataGridView3.Rows[i].Cells[1].Value.ToString();
                    int grpid = Int32.Parse(dataGridView3.Rows[i].Cells[2].Value.ToString());


                    tableAdapter3.Insert(ID, msg, grpid);
                    //MessageBox.Show(ID + msg + grpid, "test");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Błąd");
            }
            

            MessageBox.Show("Zmiany poprawnie wprowadzono do bazy SQL");
        }

        public bool taskStatus = false;
        private async void metroButton1_Click(object sender, EventArgs e)
        {

            try
            {
                CancellationTokenSource source = new CancellationTokenSource();
                CancellationToken token;

                string infodir;
                string ftpfilename;
                

                _source = source;

                token = source.Token;
                


                ExportToXML(out infodir, out ftpfilename);
                FtpUpload ftpUpload = new FtpUpload(this);
                taskStatus = false;

                //ftpfilename = @"test.mp3";
                //infodir = @"D:\Download\mp3\Woodkid - Iron.mp3";

                await ftpUpload.UploadXMLToFTP(ftpfilename, infodir, token);

                //if (errmessage != null)
                //{
                //    MessageBox.Show("Zapis na serwer nie udał się: " + errmessage, "Błąd");
                //}
                //else
                //{
                //    MessageBox.Show("Plik zapisano na serwerze FTP pod nazwą: " + ftpfilename, "FTP Server");
                //}   

            }

            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił błąd " + ex.Message);
            }
           


        }

        private void ExportToXML(out string infodir, out string ftpnamefile)
        {
            DataTable dtAll = new DataTable();

            DataTable dt1 = devDBDataSet1.SelMsgGroup1;
            DataTable dt2 = devDBDataSet1.SelMsgGroup2;
            DataTable dt3 = devDBDataSet1.SelMsgGroup3;

            dtAll.Merge(dt1);
            dtAll.Merge(dt2);
            dtAll.Merge(dt3);

            dtAll.TableName = "MsgList";

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.FileName = "MsgList";
            string dir = @"D:\Dev\Android\XMLAppGen";
            
            sfd.InitialDirectory = dir;
            sfd.Filter = "XML|*.xml";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    dtAll.WriteXml(sfd.FileName);
                    
                    MessageBox.Show("Plik XML został wygenerowany");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Wystąpił błąd " + ex.Message);
                }
            }
            infodir = dir + @"\" + Path.GetFileName(sfd.FileName) ;
            ftpnamefile = Path.GetFileName(infodir);





        }

        private void dataGridView1_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {

            DevDBDataSetTableAdapters.SelMsgGroup1TableAdapter tableAdapter = new DevDBDataSetTableAdapters.SelMsgGroup1TableAdapter();
            e.Row.Cells["ID"].Value = dataGridView1.Rows.Cast<DataGridViewRow>().Max(r => Convert.ToInt32(r.Cells["ID"].Value)) + 1;
                
               
            e.Row.Cells["GroupID"].Value = 1;
        }

        private void dataGridView2_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            DevDBDataSetTableAdapters.SelMsgGroup2TableAdapter tableAdapter = new DevDBDataSetTableAdapters.SelMsgGroup2TableAdapter();
            e.Row.Cells["ID2"].Value = dataGridView2.Rows.Cast<DataGridViewRow>().Max(r => Convert.ToInt32(r.Cells["ID2"].Value)) + 1;
            e.Row.Cells["GroupID2"].Value = 2;
        }

        private void dataGridView3_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            DevDBDataSetTableAdapters.SelMsgGroup3TableAdapter tableAdapter = new DevDBDataSetTableAdapters.SelMsgGroup3TableAdapter();
            e.Row.Cells["ID3"].Value = dataGridView3.Rows.Cast<DataGridViewRow>().Max(r => Convert.ToInt32(r.Cells["ID3"].Value)) + 1;
            e.Row.Cells["GroupID3"].Value = 3;
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            _source.Cancel();
        }

        CancellationTokenSource _source;

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (taskStatus == true)
            {
                if (MessageBox.Show("File is uploading, do you want to cancel and exit?", "XML2App", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
               // this.selMsgGroup2TableAdapter.Fill(this.devDBDataSet1.SelMsgGroup2, new System.Nullable<int>(((int)(System.Convert.ChangeType(groupidToolStripTextBox.Text, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
