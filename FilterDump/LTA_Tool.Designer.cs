namespace FilterDump
{
    partial class LTA_Tool
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.regionGroupBox = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.orderStatusCombo = new System.Windows.Forms.ComboBox();
            this.languageCombo = new System.Windows.Forms.ComboBox();
            this.chassisText = new System.Windows.Forms.TextBox();
            this.brandText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.catelogText = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.numOfRecInputtedTxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.numOfRecDelTxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.numOfRecLeftTxt = new System.Windows.Forms.TextBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.regionGroupBox.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(635, 139);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(258, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "EXTRACT AND CLEAN";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 222);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1877, 758);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Catelog ID";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.regionGroupBox);
            this.panel1.Controls.Add(this.orderStatusCombo);
            this.panel1.Controls.Add(this.languageCombo);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.chassisText);
            this.panel1.Controls.Add(this.brandText);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.catelogText);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(16, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1129, 195);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // regionGroupBox
            // 
            this.regionGroupBox.Controls.Add(this.radioButton2);
            this.regionGroupBox.Controls.Add(this.radioButton1);
            this.regionGroupBox.Location = new System.Drawing.Point(635, 45);
            this.regionGroupBox.Name = "regionGroupBox";
            this.regionGroupBox.Size = new System.Drawing.Size(258, 63);
            this.regionGroupBox.TabIndex = 14;
            this.regionGroupBox.TabStop = false;
            this.regionGroupBox.Text = "Region";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(171, 25);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(81, 24);
            this.radioButton2.TabIndex = 13;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "AMER";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 25);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(144, 24);
            this.radioButton1.TabIndex = 12;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "EMEA and APJ";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // orderStatusCombo
            // 
            this.orderStatusCombo.FormattingEnabled = true;
            this.orderStatusCombo.Location = new System.Drawing.Point(190, 146);
            this.orderStatusCombo.Name = "orderStatusCombo";
            this.orderStatusCombo.Size = new System.Drawing.Size(361, 28);
            this.orderStatusCombo.TabIndex = 11;
            // 
            // languageCombo
            // 
            this.languageCombo.FormattingEnabled = true;
            this.languageCombo.Location = new System.Drawing.Point(190, 111);
            this.languageCombo.Name = "languageCombo";
            this.languageCombo.Size = new System.Drawing.Size(361, 28);
            this.languageCombo.TabIndex = 10;
            // 
            // chassisText
            // 
            this.chassisText.Location = new System.Drawing.Point(190, 78);
            this.chassisText.Name = "chassisText";
            this.chassisText.Size = new System.Drawing.Size(361, 26);
            this.chassisText.TabIndex = 9;
            // 
            // brandText
            // 
            this.brandText.Location = new System.Drawing.Point(190, 45);
            this.brandText.Name = "brandText";
            this.brandText.Size = new System.Drawing.Size(361, 26);
            this.brandText.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Order Status Code";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Language";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Chassis ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Brand ID";
            // 
            // catelogText
            // 
            this.catelogText.Location = new System.Drawing.Point(190, 12);
            this.catelogText.Name = "catelogText";
            this.catelogText.Size = new System.Drawing.Size(361, 26);
            this.catelogText.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.numOfRecInputtedTxt);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.numOfRecDelTxt);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.numOfRecLeftTxt);
            this.panel2.Controls.Add(this.btnExport);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(1173, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(717, 195);
            this.panel2.TabIndex = 16;
            // 
            // numOfRecInputtedTxt
            // 
            this.numOfRecInputtedTxt.Location = new System.Drawing.Point(231, 12);
            this.numOfRecInputtedTxt.Name = "numOfRecInputtedTxt";
            this.numOfRecInputtedTxt.Size = new System.Drawing.Size(152, 26);
            this.numOfRecInputtedTxt.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(177, 20);
            this.label8.TabIndex = 21;
            this.label8.Text = "No. of Records inputted";
            // 
            // numOfRecDelTxt
            // 
            this.numOfRecDelTxt.Location = new System.Drawing.Point(231, 80);
            this.numOfRecDelTxt.Name = "numOfRecDelTxt";
            this.numOfRecDelTxt.Size = new System.Drawing.Size(152, 26);
            this.numOfRecDelTxt.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(175, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "No. of Records Deleted";
            // 
            // numOfRecLeftTxt
            // 
            this.numOfRecLeftTxt.Location = new System.Drawing.Point(231, 46);
            this.numOfRecLeftTxt.Name = "numOfRecLeftTxt";
            this.numOfRecLeftTxt.Size = new System.Drawing.Size(152, 26);
            this.numOfRecLeftTxt.TabIndex = 18;
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(125, 148);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(258, 35);
            this.btnExport.TabIndex = 17;
            this.btnExport.Text = "EXPORT TO EXCEL";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Visible = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "No. of Records left";
            // 
            // LTA_Tool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 992);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "LTA_Tool";
            this.Text = "Language Translation";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.regionGroupBox.ResumeLayout(false);
            this.regionGroupBox.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.ComboBox orderStatusCombo;
        private System.Windows.Forms.ComboBox languageCombo;
        private System.Windows.Forms.TextBox chassisText;
        private System.Windows.Forms.TextBox brandText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox catelogText;
        private System.Windows.Forms.GroupBox regionGroupBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox numOfRecDelTxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox numOfRecLeftTxt;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox numOfRecInputtedTxt;
        private System.Windows.Forms.Label label8;
    }
}

