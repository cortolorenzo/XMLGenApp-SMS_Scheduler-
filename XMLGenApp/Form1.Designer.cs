namespace XMLGenApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.msgTxtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.devDBDataSet1 = new XMLGenApp.DevDBDataSet();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.ID3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.msgTxtDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupID3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.ID2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.msgTxtDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupID2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.pbUploadFTP = new MetroFramework.Controls.MetroProgressBar();
            this.lblProgressBar = new System.Windows.Forms.Label();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.selMsgGroup1TableAdapter = new XMLGenApp.DevDBDataSetTableAdapters.SelMsgGroup1TableAdapter();
            this.selMsgGroup3TableAdapter = new XMLGenApp.DevDBDataSetTableAdapters.SelMsgGroup3TableAdapter();
            this.selMsgGroup2TableAdapter = new XMLGenApp.DevDBDataSetTableAdapters.SelMsgGroup2TableAdapter();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.devDBDataSet1)).BeginInit();
            this.metroTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource3)).BeginInit();
            this.metroTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Controls.Add(this.metroTabPage3);
            this.metroTabControl1.Location = new System.Drawing.Point(24, 76);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 1;
            this.metroTabControl1.Size = new System.Drawing.Size(940, 338);
            this.metroTabControl1.TabIndex = 2;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.AutoScroll = true;
            this.metroTabPage1.Controls.Add(this.dataGridView1);
            this.metroTabPage1.HorizontalScrollbar = true;
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 39);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(932, 295);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Morning";
            this.metroTabPage1.VerticalScrollbar = true;
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.msgTxtDataGridViewTextBoxColumn,
            this.GroupID});
            this.dataGridView1.DataSource = this.bindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(0, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(929, 278);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView1_DefaultValuesNeeded);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Visible = false;
            this.ID.Width = 125;
            // 
            // msgTxtDataGridViewTextBoxColumn
            // 
            this.msgTxtDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.msgTxtDataGridViewTextBoxColumn.DataPropertyName = "MsgTxt";
            this.msgTxtDataGridViewTextBoxColumn.HeaderText = "Message body";
            this.msgTxtDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.msgTxtDataGridViewTextBoxColumn.Name = "msgTxtDataGridViewTextBoxColumn";
            // 
            // GroupID
            // 
            this.GroupID.DataPropertyName = "GroupID";
            this.GroupID.HeaderText = "GroupID";
            this.GroupID.MinimumWidth = 6;
            this.GroupID.Name = "GroupID";
            this.GroupID.Visible = false;
            this.GroupID.Width = 125;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "SelMsgGroup1";
            this.bindingSource1.DataSource = this.devDBDataSet1;
            // 
            // devDBDataSet1
            // 
            this.devDBDataSet1.DataSetName = "DevDBDataSet";
            this.devDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.Controls.Add(this.dataGridView3);
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 39);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(932, 295);
            this.metroTabPage3.TabIndex = 2;
            this.metroTabPage3.Text = "Night";
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID3,
            this.msgTxtDataGridViewTextBoxColumn1,
            this.GroupID3});
            this.dataGridView3.DataSource = this.bindingSource3;
            this.dataGridView3.Location = new System.Drawing.Point(0, 13);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(929, 278);
            this.dataGridView3.TabIndex = 2;
            this.dataGridView3.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView3_DefaultValuesNeeded);
            // 
            // ID3
            // 
            this.ID3.DataPropertyName = "ID";
            this.ID3.HeaderText = "ID";
            this.ID3.MinimumWidth = 6;
            this.ID3.Name = "ID3";
            this.ID3.Visible = false;
            this.ID3.Width = 125;
            // 
            // msgTxtDataGridViewTextBoxColumn1
            // 
            this.msgTxtDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.msgTxtDataGridViewTextBoxColumn1.DataPropertyName = "MsgTxt";
            this.msgTxtDataGridViewTextBoxColumn1.HeaderText = "Message body";
            this.msgTxtDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.msgTxtDataGridViewTextBoxColumn1.Name = "msgTxtDataGridViewTextBoxColumn1";
            // 
            // GroupID3
            // 
            this.GroupID3.DataPropertyName = "GroupID";
            this.GroupID3.HeaderText = "GroupID";
            this.GroupID3.MinimumWidth = 6;
            this.GroupID3.Name = "GroupID3";
            this.GroupID3.Visible = false;
            this.GroupID3.Width = 125;
            // 
            // bindingSource3
            // 
            this.bindingSource3.DataMember = "SelMsgGroup3";
            this.bindingSource3.DataSource = this.devDBDataSet1;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.dataGridView2);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 39);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(932, 295);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Afternoon";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID2,
            this.msgTxtDataGridViewTextBoxColumn2,
            this.GroupID2});
            this.dataGridView2.DataSource = this.bindingSource2;
            this.dataGridView2.Location = new System.Drawing.Point(0, 13);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(929, 278);
            this.dataGridView2.TabIndex = 2;
            this.dataGridView2.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView2_DefaultValuesNeeded);
            // 
            // ID2
            // 
            this.ID2.DataPropertyName = "ID";
            this.ID2.HeaderText = "ID";
            this.ID2.MinimumWidth = 6;
            this.ID2.Name = "ID2";
            this.ID2.Visible = false;
            this.ID2.Width = 125;
            // 
            // msgTxtDataGridViewTextBoxColumn2
            // 
            this.msgTxtDataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.msgTxtDataGridViewTextBoxColumn2.DataPropertyName = "MsgTxt";
            this.msgTxtDataGridViewTextBoxColumn2.HeaderText = "Message body";
            this.msgTxtDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.msgTxtDataGridViewTextBoxColumn2.Name = "msgTxtDataGridViewTextBoxColumn2";
            // 
            // GroupID2
            // 
            this.GroupID2.DataPropertyName = "GroupID";
            this.GroupID2.HeaderText = "GroupID";
            this.GroupID2.MinimumWidth = 6;
            this.GroupID2.Name = "GroupID2";
            this.GroupID2.Visible = false;
            this.GroupID2.Width = 125;
            // 
            // bindingSource2
            // 
            this.bindingSource2.DataMember = "SelMsgGroup2";
            this.bindingSource2.DataSource = this.devDBDataSet1;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(498, 433);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(459, 51);
            this.metroButton1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroButton1.TabIndex = 1;
            this.metroButton1.Text = "XML + FTP";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(28, 433);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(459, 51);
            this.metroButton2.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroButton2.TabIndex = 3;
            this.metroButton2.Text = "SQL";
            this.metroButton2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // pbUploadFTP
            // 
            this.pbUploadFTP.Location = new System.Drawing.Point(23, 530);
            this.pbUploadFTP.Name = "pbUploadFTP";
            this.pbUploadFTP.Size = new System.Drawing.Size(930, 39);
            this.pbUploadFTP.Style = MetroFramework.MetroColorStyle.Green;
            this.pbUploadFTP.TabIndex = 4;
            // 
            // lblProgressBar
            // 
            this.lblProgressBar.AutoSize = true;
            this.lblProgressBar.Location = new System.Drawing.Point(921, 510);
            this.lblProgressBar.Name = "lblProgressBar";
            this.lblProgressBar.Size = new System.Drawing.Size(32, 17);
            this.lblProgressBar.TabIndex = 5;
            this.lblProgressBar.Text = "0 %";
            // 
            // metroButton3
            // 
            this.metroButton3.Location = new System.Drawing.Point(266, 580);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(477, 39);
            this.metroButton3.TabIndex = 6;
            this.metroButton3.Text = "Cancel";
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // selMsgGroup1TableAdapter
            // 
            this.selMsgGroup1TableAdapter.ClearBeforeFill = true;
            // 
            // selMsgGroup3TableAdapter
            // 
            this.selMsgGroup3TableAdapter.ClearBeforeFill = true;
            // 
            // selMsgGroup2TableAdapter
            // 
            this.selMsgGroup2TableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(987, 639);
            this.Controls.Add(this.metroButton3);
            this.Controls.Add(this.lblProgressBar);
            this.Controls.Add(this.pbUploadFTP);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroTabControl1);
            this.Name = "Form1";
            this.Text = "XML SMS Generator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.devDBDataSet1)).EndInit();
            this.metroTabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource3)).EndInit();
            this.metroTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DevDBDataSet devDBDataSet1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private DevDBDataSetTableAdapters.SelMsgGroup1TableAdapter selMsgGroup1TableAdapter;
        private System.Windows.Forms.BindingSource bindingSource2;
        private System.Windows.Forms.BindingSource bindingSource3;
        private DevDBDataSetTableAdapters.SelMsgGroup3TableAdapter selMsgGroup3TableAdapter;
        private MetroFramework.Controls.MetroButton metroButton2;
        public MetroFramework.Controls.MetroProgressBar pbUploadFTP;
        public System.Windows.Forms.Label lblProgressBar;
        private MetroFramework.Controls.MetroButton metroButton3;
        private DevDBDataSetTableAdapters.SelMsgGroup2TableAdapter selMsgGroup2TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn msgTxtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID3;
        private System.Windows.Forms.DataGridViewTextBoxColumn msgTxtDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupID3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID2;
        private System.Windows.Forms.DataGridViewTextBoxColumn msgTxtDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupID2;
    }
}

