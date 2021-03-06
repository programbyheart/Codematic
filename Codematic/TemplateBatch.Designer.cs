﻿using Codematic.Properties;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using WiB.Pinkie.Controls;
namespace Codematic
{
    partial class TemplateBatch
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
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            TreeNode treeNode = new TreeNode("默认", 2, 2);
            TreeNode treeNode2 = new TreeNode("实体类", new TreeNode[]
			{
				treeNode
			});
            TreeNode treeNode3 = new TreeNode("C#代码");
            TreeNode treeNode4 = new TreeNode("VB代码");
            TreeNode treeNode5 = new TreeNode("页面");
            TreeNode treeNode6 = new TreeNode("代码模版", new TreeNode[]
			{
				treeNode2,
				treeNode3,
				treeNode4,
				treeNode5
			});
            ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(TemplateBatch));
            this.groupBox1 = new GroupBox();
            this.cmbDB = new ComboBox();
            this.lblServer = new Label();
            this.label1 = new Label();
            this.label3 = new Label();
            this.groupBox3 = new GroupBox();
            this.pictureBox1 = new PictureBox();
            this.txtTargetFolder = new TextBox();
            this.label2 = new Label();
            this.btn_TargetFold = new ButtonXP();
            this.btn_Addlist = new Button();
            this.btn_Add = new Button();
            this.btn_Dellist = new Button();
            this.btn_Export = new ButtonXP();
            this.btn_Del = new Button();
            this.listTable2 = new ListBox();
            this.groupBox2 = new GroupBox();
            this.btnInputTxt = new Button();
            this.listTable1 = new ListBox();
            this.btn_Cancle = new ButtonXP();
            this.labelNum = new Label();
            this.progressBar1 = new ProgressBar();
            this.groupBox4 = new GroupBox();
            this.listBoxTemplate = new ListBox();
            this.btnAddTemp = new Button();
            this.btnRemoveTemp = new Button();
            this.btnClearTemp = new Button();
            this.treeView1 = new TreeView();
            this.imageList1 = new ImageList(this.components);
            this.groupBox5 = new GroupBox();
            this.txtFolder = new TextBox();
            this.label4 = new Label();
            this.radbtn_TabTemp = new RadioButton();
            this.radbtn_TempMerger = new RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((ISupportInitialize)this.pictureBox1).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            base.SuspendLayout();
            this.groupBox1.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
            this.groupBox1.Controls.Add(this.cmbDB);
            this.groupBox1.Controls.Add(this.lblServer);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new Point(9, 5);
            this.groupBox1.Margin = new Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new Padding(2, 2, 2, 2);
            this.groupBox1.Size = new Size(587, 48);
            this.groupBox1.TabIndex = 53;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "选择数据库";
            this.cmbDB.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbDB.Location = new Point(391, 21);
            this.cmbDB.Margin = new Padding(2, 2, 2, 2);
            this.cmbDB.Name = "cmbDB";
            this.cmbDB.Size = new Size(153, 20);
            this.cmbDB.TabIndex = 2;
            this.cmbDB.SelectedIndexChanged += new EventHandler(this.cmbDB_SelectedIndexChanged);
            this.lblServer.AutoSize = true;
            this.lblServer.Location = new Point(104, 22);
            this.lblServer.Margin = new Padding(2, 0, 2, 0);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new Size(41, 12);
            this.lblServer.TabIndex = 1;
            this.lblServer.Text = "Server";
            this.label1.AutoSize = true;
            this.label1.Location = new Point(16, 22);
            this.label1.Margin = new Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new Size(77, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "当前服务器：";
            this.label3.AutoSize = true;
            this.label3.Location = new Point(311, 22);
            this.label3.Margin = new Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new Size(77, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "选择数据库：";
            this.groupBox3.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
            this.groupBox3.Controls.Add(this.radbtn_TempMerger);
            this.groupBox3.Controls.Add(this.radbtn_TabTemp);
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.Controls.Add(this.txtTargetFolder);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.btn_TargetFold);
            this.groupBox3.Location = new Point(9, 357);
            this.groupBox3.Margin = new Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new Padding(2, 2, 2, 2);
            this.groupBox3.Size = new Size(587, 81);
            this.groupBox3.TabIndex = 57;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "保存位置";
            this.pictureBox1.Image = Resources.Control;
            this.pictureBox1.Location = new Point(10, 15);
            this.pictureBox1.Margin = new Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new Size(28, 29);
            this.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 53;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            this.txtTargetFolder.BorderStyle = BorderStyle.FixedSingle;
            this.txtTargetFolder.Location = new Point(104, 18);
            this.txtTargetFolder.Margin = new Padding(2, 2, 2, 2);
            this.txtTargetFolder.Name = "txtTargetFolder";
            this.txtTargetFolder.Size = new Size(395, 21);
            this.txtTargetFolder.TabIndex = 45;
            this.label2.AutoSize = true;
            this.label2.Location = new Point(40, 22);
            this.label2.Margin = new Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new Size(65, 12);
            this.label2.TabIndex = 44;
            this.label2.Text = "输出目录：";
            this.btn_TargetFold._Image = null;
            this.btn_TargetFold.BackColor = Color.FromArgb(0, 240, 240, 240);
            this.btn_TargetFold.DefaultScheme = false;
            this.btn_TargetFold.DialogResult = 0;
            this.btn_TargetFold.Image = null;
            this.btn_TargetFold.Location = new Point(505, 18);
            this.btn_TargetFold.Margin = new Padding(2, 2, 2, 2);
            this.btn_TargetFold.Name = "btn_TargetFold";
            this.btn_TargetFold.Scheme = ButtonXP.Schemes.Blue;
            this.btn_TargetFold.Size = new Size(57, 23);
            this.btn_TargetFold.TabIndex = 46;
            this.btn_TargetFold.Text = "选择...";
            this.btn_TargetFold.Click += new EventHandler(this.btn_TargetFold_Click);
            this.btn_Addlist.Enabled = false;
            this.btn_Addlist.FlatStyle = FlatStyle.Popup;
            this.btn_Addlist.Location = new Point(275, 21);
            this.btn_Addlist.Margin = new Padding(2, 2, 2, 2);
            this.btn_Addlist.Name = "btn_Addlist";
            this.btn_Addlist.Size = new Size(40, 23);
            this.btn_Addlist.TabIndex = 7;
            this.btn_Addlist.Text = ">>";
            this.btn_Addlist.Click += new EventHandler(this.btn_Addlist_Click);
            this.btn_Add.Enabled = false;
            this.btn_Add.FlatStyle = FlatStyle.Popup;
            this.btn_Add.Location = new Point(275, 50);
            this.btn_Add.Margin = new Padding(2, 2, 2, 2);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new Size(40, 23);
            this.btn_Add.TabIndex = 8;
            this.btn_Add.Text = ">";
            this.btn_Add.Click += new EventHandler(this.btn_Add_Click);
            this.btn_Dellist.Enabled = false;
            this.btn_Dellist.FlatStyle = FlatStyle.Popup;
            this.btn_Dellist.Location = new Point(275, 107);
            this.btn_Dellist.Margin = new Padding(2, 2, 2, 2);
            this.btn_Dellist.Name = "btn_Dellist";
            this.btn_Dellist.Size = new Size(40, 23);
            this.btn_Dellist.TabIndex = 6;
            this.btn_Dellist.Text = "<<";
            this.btn_Dellist.Click += new EventHandler(this.btn_Dellist_Click);
            this.btn_Export._Image = null;
            this.btn_Export.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
            this.btn_Export.BackColor = Color.FromArgb(0, 240, 240, 240);
            this.btn_Export.DefaultScheme = false;
            this.btn_Export.DialogResult = 0;
            this.btn_Export.Image = null;
            this.btn_Export.Location = new Point(398, 451);
            this.btn_Export.Margin = new Padding(2, 2, 2, 2);
            this.btn_Export.Name = "btn_Export";
            this.btn_Export.Scheme = ButtonXP.Schemes.Blue;
            this.btn_Export.Size = new Size(75, 26);
            this.btn_Export.TabIndex = 56;
            this.btn_Export.Text = "导出";
            this.btn_Export.Click += new EventHandler(this.btn_Export_Click);
            this.btn_Del.Enabled = false;
            this.btn_Del.FlatStyle = FlatStyle.Popup;
            this.btn_Del.Location = new Point(275, 78);
            this.btn_Del.Margin = new Padding(2, 2, 2, 2);
            this.btn_Del.Name = "btn_Del";
            this.btn_Del.Size = new Size(40, 23);
            this.btn_Del.TabIndex = 5;
            this.btn_Del.Text = "<";
            this.btn_Del.Click += new EventHandler(this.btn_Del_Click);
            this.listTable2.ItemHeight = 12;
            this.listTable2.Location = new Point(356, 21);
            this.listTable2.Margin = new Padding(2, 2, 2, 2);
            this.listTable2.Name = "listTable2";
            this.listTable2.SelectionMode = SelectionMode.MultiExtended;
            this.listTable2.Size = new Size(218, 112);
            this.listTable2.TabIndex = 1;
            this.listTable2.DoubleClick += new EventHandler(this.listTable2_DoubleClick);
            this.groupBox2.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
            this.groupBox2.Controls.Add(this.btnInputTxt);
            this.groupBox2.Controls.Add(this.btn_Addlist);
            this.groupBox2.Controls.Add(this.btn_Add);
            this.groupBox2.Controls.Add(this.btn_Del);
            this.groupBox2.Controls.Add(this.btn_Dellist);
            this.groupBox2.Controls.Add(this.listTable2);
            this.groupBox2.Controls.Add(this.listTable1);
            this.groupBox2.Location = new Point(9, 55);
            this.groupBox2.Margin = new Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new Padding(2, 2, 2, 2);
            this.groupBox2.Size = new Size(587, 140);
            this.groupBox2.TabIndex = 54;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "选择表和视图";
            this.btnInputTxt.FlatStyle = FlatStyle.Popup;
            this.btnInputTxt.Location = new Point(334, 109);
            this.btnInputTxt.Margin = new Padding(2, 2, 2, 2);
            this.btnInputTxt.Name = "btnInputTxt";
            this.btnInputTxt.Size = new Size(19, 23);
            this.btnInputTxt.TabIndex = 10;
            this.btnInputTxt.Text = "Txt";
            this.btnInputTxt.UseVisualStyleBackColor = true;
            this.btnInputTxt.Click += new EventHandler(this.btnInputTxt_Click);
            this.listTable1.ItemHeight = 12;
            this.listTable1.Location = new Point(10, 21);
            this.listTable1.Margin = new Padding(2, 2, 2, 2);
            this.listTable1.Name = "listTable1";
            this.listTable1.SelectionMode = SelectionMode.MultiExtended;
            this.listTable1.Size = new Size(219, 112);
            this.listTable1.TabIndex = 0;
            this.listTable1.DoubleClick += new EventHandler(this.listTable1_DoubleClick);
            this.btn_Cancle._Image = null;
            this.btn_Cancle.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
            this.btn_Cancle.BackColor = Color.FromArgb(0, 240, 240, 240);
            this.btn_Cancle.DefaultScheme = false;
            this.btn_Cancle.DialogResult = DialogResult.No;
            this.btn_Cancle.Image = null;
            this.btn_Cancle.Location = new Point(502, 451);
            this.btn_Cancle.Margin = new Padding(2, 2, 2, 2);
            this.btn_Cancle.Name = "btn_Cancle";
            this.btn_Cancle.Scheme = ButtonXP.Schemes.Blue;
            this.btn_Cancle.Size = new Size(75, 26);
            this.btn_Cancle.TabIndex = 55;
            this.btn_Cancle.Text = "关闭";
            this.btn_Cancle.Click += new EventHandler(this.btn_Cancle_Click);
            this.labelNum.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
            this.labelNum.Location = new Point(7, 466);
            this.labelNum.Margin = new Padding(2, 0, 2, 0);
            this.labelNum.Name = "labelNum";
            this.labelNum.Size = new Size(90, 22);
            this.labelNum.TabIndex = 51;
            this.labelNum.TextAlign = ContentAlignment.MiddleCenter;
            this.progressBar1.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
            this.progressBar1.Location = new Point(2, 491);
            this.progressBar1.Margin = new Padding(2, 2, 2, 2);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new Size(600, 19);
            this.progressBar1.TabIndex = 52;
            this.groupBox4.Controls.Add(this.listBoxTemplate);
            this.groupBox4.Controls.Add(this.btnAddTemp);
            this.groupBox4.Controls.Add(this.btnRemoveTemp);
            this.groupBox4.Controls.Add(this.btnClearTemp);
            this.groupBox4.Controls.Add(this.treeView1);
            this.groupBox4.Location = new Point(9, 195);
            this.groupBox4.Margin = new Padding(2, 2, 2, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new Padding(2, 2, 2, 2);
            this.groupBox4.Size = new Size(587, 121);
            this.groupBox4.TabIndex = 58;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "选择模板";
            this.listBoxTemplate.ItemHeight = 12;
            this.listBoxTemplate.Location = new Point(356, 15);
            this.listBoxTemplate.Margin = new Padding(2, 2, 2, 2);
            this.listBoxTemplate.Name = "listBoxTemplate";
            this.listBoxTemplate.SelectionMode = SelectionMode.MultiExtended;
            this.listBoxTemplate.Size = new Size(218, 100);
            this.listBoxTemplate.TabIndex = 13;
            this.btnAddTemp.FlatStyle = FlatStyle.Popup;
            this.btnAddTemp.Location = new Point(276, 28);
            this.btnAddTemp.Margin = new Padding(2, 2, 2, 2);
            this.btnAddTemp.Name = "btnAddTemp";
            this.btnAddTemp.Size = new Size(40, 23);
            this.btnAddTemp.TabIndex = 12;
            this.btnAddTemp.Text = ">";
            this.btnAddTemp.Click += new EventHandler(this.btnAddTemp_Click);
            this.btnRemoveTemp.Enabled = false;
            this.btnRemoveTemp.FlatStyle = FlatStyle.Popup;
            this.btnRemoveTemp.Location = new Point(276, 54);
            this.btnRemoveTemp.Margin = new Padding(2, 2, 2, 2);
            this.btnRemoveTemp.Name = "btnRemoveTemp";
            this.btnRemoveTemp.Size = new Size(40, 23);
            this.btnRemoveTemp.TabIndex = 9;
            this.btnRemoveTemp.Text = "<";
            this.btnRemoveTemp.Click += new EventHandler(this.btnRemoveTemp_Click);
            this.btnClearTemp.Enabled = false;
            this.btnClearTemp.FlatStyle = FlatStyle.Popup;
            this.btnClearTemp.Location = new Point(276, 81);
            this.btnClearTemp.Margin = new Padding(2, 2, 2, 2);
            this.btnClearTemp.Name = "btnClearTemp";
            this.btnClearTemp.Size = new Size(40, 23);
            this.btnClearTemp.TabIndex = 10;
            this.btnClearTemp.Text = "<<";
            this.btnClearTemp.Click += new EventHandler(this.btnClearTemp_Click);
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.Location = new Point(10, 15);
            this.treeView1.Name = "treeView1";
            treeNode.ImageIndex = 2;
            treeNode.Name = "节点6";
            treeNode.SelectedImageIndex = 2;
            treeNode.Text = "默认";
            treeNode2.Name = "节点4";
            treeNode2.Text = "实体类";
            treeNode3.Name = "节点2";
            treeNode3.Text = "C#代码";
            treeNode4.Name = "节点5";
            treeNode4.Text = "VB代码";
            treeNode5.Name = "节点3";
            treeNode5.Text = "页面";
            treeNode6.Name = "节点0";
            treeNode6.Text = "代码模版";
            this.treeView1.Nodes.AddRange(new TreeNode[]
			{
				treeNode6
			});
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new Size(219, 100);
            this.treeView1.TabIndex = 2;
            this.treeView1.DoubleClick += new EventHandler(this.treeView1_DoubleClick);
            this.imageList1.ImageStream = (ImageListStreamer)componentResourceManager.GetObject("imageList1.ImageStream");
            this.imageList1.TransparentColor = Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Folderclose.gif");
            this.imageList1.Images.SetKeyName(1, "Folderopen.gif");
            this.imageList1.Images.SetKeyName(2, "temp.png");
            this.imageList1.Images.SetKeyName(3, "cs32.gif");
            this.imageList1.Images.SetKeyName(4, "vb.gif");
            this.imageList1.Images.SetKeyName(5, "aspx.png");
            this.groupBox5.Controls.Add(this.txtFolder);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Location = new Point(9, 316);
            this.groupBox5.Margin = new Padding(2, 2, 2, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new Padding(2, 2, 2, 2);
            this.groupBox5.Size = new Size(587, 38);
            this.groupBox5.TabIndex = 59;
            this.groupBox5.TabStop = false;
            this.txtFolder.Location = new Point(161, 13);
            this.txtFolder.Margin = new Padding(2, 2, 2, 2);
            this.txtFolder.Name = "txtFolder";
            this.txtFolder.Size = new Size(125, 21);
            this.txtFolder.TabIndex = 1;
            this.label4.AutoSize = true;
            this.label4.Location = new Point(62, 18);
            this.label4.Margin = new Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new Size(101, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "二级命名空间名：";
            this.radbtn_TabTemp.AutoSize = true;
            this.radbtn_TabTemp.Checked = true;
            this.radbtn_TabTemp.Location = new Point(104, 51);
            this.radbtn_TabTemp.Name = "radbtn_TabTemp";
            this.radbtn_TabTemp.Size = new Size(131, 16);
            this.radbtn_TabTemp.TabIndex = 54;
            this.radbtn_TabTemp.TabStop = true;
            this.radbtn_TabTemp.Text = "按模板和表独立保存";
            this.radbtn_TabTemp.UseVisualStyleBackColor = true;
            this.radbtn_TempMerger.AutoSize = true;
            this.radbtn_TempMerger.Location = new Point(264, 51);
            this.radbtn_TempMerger.Name = "radbtn_TempMerger";
            this.radbtn_TempMerger.Size = new Size(107, 16);
            this.radbtn_TempMerger.TabIndex = 54;
            this.radbtn_TempMerger.Text = "按模板合并保存";
            this.radbtn_TempMerger.UseVisualStyleBackColor = true;
            base.AutoScaleDimensions = new SizeF(6f, 12f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.CancelButton = this.btn_Cancle;
            base.ClientSize = new Size(608, 511);
            base.Controls.Add(this.groupBox5);
            base.Controls.Add(this.labelNum);
            base.Controls.Add(this.groupBox4);
            base.Controls.Add(this.groupBox1);
            base.Controls.Add(this.groupBox3);
            base.Controls.Add(this.btn_Export);
            base.Controls.Add(this.groupBox2);
            base.Controls.Add(this.btn_Cancle);
            base.Controls.Add(this.progressBar1);
            base.FormBorderStyle = FormBorderStyle.FixedSingle;
            base.Margin = new Padding(2, 2, 2, 2);
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "TemplateBatch";
            base.ShowInTaskbar = false;
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "模板代码批量生成";
            base.TopMost = true;
            base.Load += new EventHandler(this.TemplateBatch_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((ISupportInitialize)this.pictureBox1).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            base.ResumeLayout(false);
        }

        private GroupBox groupBox1;
        private ComboBox cmbDB;
        private Label lblServer;
        private Label label1;
        private Label label3;
        private PictureBox pictureBox1;
        private GroupBox groupBox3;
        private TextBox txtTargetFolder;
        private Label label2;
        private ButtonXP btn_TargetFold;
        private Button btn_Addlist;
        private Button btn_Add;
        private Button btn_Dellist;
        private ButtonXP btn_Export;
        private Button btn_Del;
        private ListBox listTable2;
        private GroupBox groupBox2;
        private ListBox listTable1;
        private ButtonXP btn_Cancle;
        private Label labelNum;
        private ProgressBar progressBar1;
        private GroupBox groupBox4;
        private TreeView treeView1;
        private Button btnAddTemp;
        private Button btnRemoveTemp;
        private Button btnClearTemp;
        private ListBox listBoxTemplate;
        private Button btnInputTxt;
        private ImageList imageList1;
        private GroupBox groupBox5;
        private TextBox txtFolder;
        private Label label4;
        private RadioButton radbtn_TabTemp;
        private RadioButton radbtn_TempMerger;
        #endregion
    }
}