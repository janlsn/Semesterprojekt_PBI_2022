
namespace ProCommerce
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.cmbButik = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.rdbUdvalgt = new System.Windows.Forms.RadioButton();
            this.rdbAlle = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tspButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.lstvButik = new System.Windows.Forms.ListView();
            this.imgBilleder = new System.Windows.Forms.ImageList(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.lblPostnrby = new System.Windows.Forms.Label();
            this.lblAdresse = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.nudButik = new System.Windows.Forms.NumericUpDown();
            this.lblHyldenr = new System.Windows.Forms.Label();
            this.lblReolnr = new System.Windows.Forms.Label();
            this.lblLokation = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblPris = new System.Windows.Forms.Label();
            this.lblAntal = new System.Windows.Forms.Label();
            this.lblVarenr = new System.Windows.Forms.Label();
            this.btnKurv = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblSamletpris = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lstvKurv = new System.Windows.Forms.ListView();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSletvare = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudButik)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbButik
            // 
            this.cmbButik.FormattingEnabled = true;
            resources.ApplyResources(this.cmbButik, "cmbButik");
            this.cmbButik.Name = "cmbButik";
            // 
            // txtSearch
            // 
            resources.ApplyResources(this.txtSearch, "txtSearch");
            this.txtSearch.Name = "txtSearch";
            // 
            // rdbUdvalgt
            // 
            resources.ApplyResources(this.rdbUdvalgt, "rdbUdvalgt");
            this.rdbUdvalgt.Name = "rdbUdvalgt";
            this.rdbUdvalgt.TabStop = true;
            this.rdbUdvalgt.UseVisualStyleBackColor = true;
            // 
            // rdbAlle
            // 
            resources.ApplyResources(this.rdbAlle, "rdbAlle");
            this.rdbAlle.Name = "rdbAlle";
            this.rdbAlle.TabStop = true;
            this.rdbAlle.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tspButton,
            this.toolStripButton2});
            resources.ApplyResources(this.toolStrip1, "toolStrip1");
            this.toolStrip1.Name = "toolStrip1";
            // 
            // tspButton
            // 
            this.tspButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.tspButton, "tspButton");
            this.tspButton.Name = "tspButton";
            this.tspButton.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.toolStripButton2, "toolStripButton2");
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click_1);
            // 
            // lstvButik
            // 
            resources.ApplyResources(this.lstvButik, "lstvButik");
            this.lstvButik.HideSelection = false;
            this.lstvButik.LargeImageList = this.imgBilleder;
            this.lstvButik.Name = "lstvButik";
            this.lstvButik.ShowGroups = false;
            this.lstvButik.UseCompatibleStateImageBehavior = false;
            this.lstvButik.View = System.Windows.Forms.View.Tile;
            this.lstvButik.SelectedIndexChanged += new System.EventHandler(this.lstvButik_SelectedIndexChanged);
            // 
            // imgBilleder
            // 
            this.imgBilleder.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgBilleder.ImageStream")));
            this.imgBilleder.TransparentColor = System.Drawing.Color.Transparent;
            this.imgBilleder.Images.SetKeyName(0, "1281345.png");
            this.imgBilleder.Images.SetKeyName(1, "1521026.png");
            this.imgBilleder.Images.SetKeyName(2, "1675321.png");
            this.imgBilleder.Images.SetKeyName(3, "1721060.jpg");
            this.imgBilleder.Images.SetKeyName(4, "1938299.png");
            this.imgBilleder.Images.SetKeyName(5, "2002369.png");
            this.imgBilleder.Images.SetKeyName(6, "2017043.png");
            this.imgBilleder.Images.SetKeyName(7, "3447448.png");
            this.imgBilleder.Images.SetKeyName(8, "5186000.png");
            this.imgBilleder.Images.SetKeyName(9, "5890383.png");
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Yellow;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Name = "label2";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTelefon);
            this.groupBox1.Controls.Add(this.lblPostnrby);
            this.groupBox1.Controls.Add(this.lblAdresse);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // lblTelefon
            // 
            resources.ApplyResources(this.lblTelefon, "lblTelefon");
            this.lblTelefon.Name = "lblTelefon";
            // 
            // lblPostnrby
            // 
            resources.ApplyResources(this.lblPostnrby, "lblPostnrby");
            this.lblPostnrby.Name = "lblPostnrby";
            // 
            // lblAdresse
            // 
            resources.ApplyResources(this.lblAdresse, "lblAdresse");
            this.lblAdresse.Name = "lblAdresse";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.nudButik);
            this.tabPage1.Controls.Add(this.lblHyldenr);
            this.tabPage1.Controls.Add(this.lblReolnr);
            this.tabPage1.Controls.Add(this.lblLokation);
            this.tabPage1.Controls.Add(this.lblStatus);
            this.tabPage1.Controls.Add(this.lblPris);
            this.tabPage1.Controls.Add(this.lblAntal);
            this.tabPage1.Controls.Add(this.lblVarenr);
            this.tabPage1.Controls.Add(this.btnKurv);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label3);
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // nudButik
            // 
            resources.ApplyResources(this.nudButik, "nudButik");
            this.nudButik.Name = "nudButik";
            this.nudButik.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudButik.ValueChanged += new System.EventHandler(this.nudButik_ValueChanged);
            // 
            // lblHyldenr
            // 
            resources.ApplyResources(this.lblHyldenr, "lblHyldenr");
            this.lblHyldenr.Name = "lblHyldenr";
            // 
            // lblReolnr
            // 
            resources.ApplyResources(this.lblReolnr, "lblReolnr");
            this.lblReolnr.Name = "lblReolnr";
            // 
            // lblLokation
            // 
            resources.ApplyResources(this.lblLokation, "lblLokation");
            this.lblLokation.Name = "lblLokation";
            // 
            // lblStatus
            // 
            resources.ApplyResources(this.lblStatus, "lblStatus");
            this.lblStatus.Name = "lblStatus";
            // 
            // lblPris
            // 
            resources.ApplyResources(this.lblPris, "lblPris");
            this.lblPris.Name = "lblPris";
            // 
            // lblAntal
            // 
            resources.ApplyResources(this.lblAntal, "lblAntal");
            this.lblAntal.Name = "lblAntal";
            // 
            // lblVarenr
            // 
            resources.ApplyResources(this.lblVarenr, "lblVarenr");
            this.lblVarenr.Name = "lblVarenr";
            // 
            // btnKurv
            // 
            resources.ApplyResources(this.btnKurv, "btnKurv");
            this.btnKurv.Name = "btnKurv";
            this.btnKurv.UseVisualStyleBackColor = true;
            this.btnKurv.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblSamletpris);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.lstvKurv);
            resources.ApplyResources(this.tabPage2, "tabPage2");
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblSamletpris
            // 
            resources.ApplyResources(this.lblSamletpris, "lblSamletpris");
            this.lblSamletpris.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSamletpris.Name = "lblSamletpris";
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            // 
            // lstvKurv
            // 
            this.lstvKurv.FullRowSelect = true;
            this.lstvKurv.HideSelection = false;
            resources.ApplyResources(this.lstvKurv, "lstvKurv");
            this.lstvKurv.Name = "lstvKurv";
            this.lstvKurv.UseCompatibleStateImageBehavior = false;
            this.lstvKurv.SelectedIndexChanged += new System.EventHandler(this.lstvKurv_SelectedIndexChanged);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // btnSletvare
            // 
            resources.ApplyResources(this.btnSletvare, "btnSletvare");
            this.btnSletvare.Name = "btnSletvare";
            this.btnSletvare.UseVisualStyleBackColor = true;
            this.btnSletvare.Click += new System.EventHandler(this.btnSletvare_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSletvare);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstvButik);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rdbAlle);
            this.Controls.Add(this.rdbUdvalgt);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.cmbButik);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudButik)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbButik;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.RadioButton rdbUdvalgt;
        private System.Windows.Forms.RadioButton rdbAlle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ListView lstvButik;
        private System.Windows.Forms.ImageList imgBilleder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblAdresse;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Label lblPostnrby;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnKurv;
        private System.Windows.Forms.Label lblVarenr;
        private System.Windows.Forms.Label lblHyldenr;
        private System.Windows.Forms.Label lblReolnr;
        private System.Windows.Forms.Label lblLokation;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblPris;
        private System.Windows.Forms.Label lblAntal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripButton tspButton;
        private System.Windows.Forms.ListView lstvKurv;
        private System.Windows.Forms.NumericUpDown nudButik;
        private System.Windows.Forms.Button btnSletvare;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblSamletpris;
    }
}

