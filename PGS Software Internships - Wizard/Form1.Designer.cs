namespace PGS_Software_Internships___Wizard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TbCntrlMain = new System.Windows.Forms.TabControl();
            this.TbPgStart = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.BtnSTART = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TbPgFill = new System.Windows.Forms.TabPage();
            this.WizardPage = new PGS_Software_Internships___Wizard.WizardPageControl();
            this.TbPgSummary = new System.Windows.Forms.TabPage();
            this.BtnEXIT = new System.Windows.Forms.Button();
            this.BtnBACK = new System.Windows.Forms.Button();
            this.RtbxSummary = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.TbPgInfo = new System.Windows.Forms.TabPage();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.TbCntrlMain.SuspendLayout();
            this.TbPgStart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.TbPgFill.SuspendLayout();
            this.TbPgSummary.SuspendLayout();
            this.TbPgInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // TbCntrlMain
            // 
            this.TbCntrlMain.Controls.Add(this.TbPgStart);
            this.TbCntrlMain.Controls.Add(this.TbPgFill);
            this.TbCntrlMain.Controls.Add(this.TbPgSummary);
            this.TbCntrlMain.Controls.Add(this.TbPgInfo);
            this.TbCntrlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TbCntrlMain.Location = new System.Drawing.Point(0, 0);
            this.TbCntrlMain.Name = "TbCntrlMain";
            this.TbCntrlMain.SelectedIndex = 0;
            this.TbCntrlMain.Size = new System.Drawing.Size(644, 466);
            this.TbCntrlMain.TabIndex = 1;
            // 
            // TbPgStart
            // 
            this.TbPgStart.BackColor = System.Drawing.Color.Transparent;
            this.TbPgStart.Controls.Add(this.richTextBox1);
            this.TbPgStart.Controls.Add(this.BtnSTART);
            this.TbPgStart.Controls.Add(this.label2);
            this.TbPgStart.Controls.Add(this.label1);
            this.TbPgStart.Controls.Add(this.pictureBox1);
            this.TbPgStart.Location = new System.Drawing.Point(4, 25);
            this.TbPgStart.Name = "TbPgStart";
            this.TbPgStart.Padding = new System.Windows.Forms.Padding(3);
            this.TbPgStart.Size = new System.Drawing.Size(636, 437);
            this.TbPgStart.TabIndex = 0;
            this.TbPgStart.Text = "START";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(16, 128);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(578, 210);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // BtnSTART
            // 
            this.BtnSTART.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnSTART.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSTART.Location = new System.Drawing.Point(157, 363);
            this.BtnSTART.Name = "BtnSTART";
            this.BtnSTART.Size = new System.Drawing.Size(289, 56);
            this.BtnSTART.TabIndex = 3;
            this.BtnSTART.Text = "ROZPOCZNIJ";
            this.BtnSTART.UseVisualStyleBackColor = true;
            this.BtnSTART.Click += new System.EventHandler(this.BtnSTART_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 36);
            this.label2.TabIndex = 2;
            this.label2.Text = "C# / .NET";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(371, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Praktyki programistyczne";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::PGS_Software_Internships___Wizard.Properties.Resources.Logo_PGS_SOFTWARE;
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.InitialImage = global::PGS_Software_Internships___Wizard.Properties.Resources.Logo_PGS_SOFTWARE;
            this.pictureBox1.Location = new System.Drawing.Point(457, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // TbPgFill
            // 
            this.TbPgFill.Controls.Add(this.WizardPage);
            this.TbPgFill.Location = new System.Drawing.Point(4, 25);
            this.TbPgFill.Name = "TbPgFill";
            this.TbPgFill.Padding = new System.Windows.Forms.Padding(3);
            this.TbPgFill.Size = new System.Drawing.Size(636, 437);
            this.TbPgFill.TabIndex = 1;
            this.TbPgFill.Text = "UZUPEŁNIJ";
            this.TbPgFill.UseVisualStyleBackColor = true;
            // 
            // WizardPage
            // 
            this.WizardPage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.WizardPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WizardPage.Info = "{\\rtf1\\ansi\\ansicpg1252\\deff0\\deflang1033{\\fonttbl{\\f0\\fnil\\fcharset0 Microsoft S" +
    "ans Serif;}}\n\\viewkind4\\uc1\\pard\\f0\\fs20\\par\n}\n";
            this.WizardPage.Location = new System.Drawing.Point(3, 3);
            this.WizardPage.Name = "WizardPage";
            this.WizardPage.Page = "Strona X z Y";
            this.WizardPage.RegexPattern = null;
            this.WizardPage.Size = new System.Drawing.Size(630, 431);
            this.WizardPage.TabIndex = 0;
            this.WizardPage.Title = "Tytuł strony";
            // 
            // TbPgSummary
            // 
            this.TbPgSummary.Controls.Add(this.BtnEXIT);
            this.TbPgSummary.Controls.Add(this.BtnBACK);
            this.TbPgSummary.Controls.Add(this.RtbxSummary);
            this.TbPgSummary.Controls.Add(this.label3);
            this.TbPgSummary.Controls.Add(this.richTextBox2);
            this.TbPgSummary.Location = new System.Drawing.Point(4, 25);
            this.TbPgSummary.Name = "TbPgSummary";
            this.TbPgSummary.Size = new System.Drawing.Size(636, 437);
            this.TbPgSummary.TabIndex = 2;
            this.TbPgSummary.Text = "PODSUMOWANIE";
            this.TbPgSummary.UseVisualStyleBackColor = true;
            // 
            // BtnEXIT
            // 
            this.BtnEXIT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEXIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEXIT.Location = new System.Drawing.Point(444, 376);
            this.BtnEXIT.Name = "BtnEXIT";
            this.BtnEXIT.Size = new System.Drawing.Size(174, 48);
            this.BtnEXIT.TabIndex = 9;
            this.BtnEXIT.Text = "WYJŚCIE";
            this.BtnEXIT.UseVisualStyleBackColor = true;
            this.BtnEXIT.Click += new System.EventHandler(this.BtnEXIT_Click);
            // 
            // BtnBACK
            // 
            this.BtnBACK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnBACK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBACK.Location = new System.Drawing.Point(17, 376);
            this.BtnBACK.Name = "BtnBACK";
            this.BtnBACK.Size = new System.Drawing.Size(174, 48);
            this.BtnBACK.TabIndex = 8;
            this.BtnBACK.Text = "POWRÓT";
            this.BtnBACK.UseVisualStyleBackColor = true;
            this.BtnBACK.Click += new System.EventHandler(this.BtnBACK_Click);
            // 
            // RtbxSummary
            // 
            this.RtbxSummary.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RtbxSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RtbxSummary.Location = new System.Drawing.Point(17, 133);
            this.RtbxSummary.Name = "RtbxSummary";
            this.RtbxSummary.ReadOnly = true;
            this.RtbxSummary.Size = new System.Drawing.Size(601, 237);
            this.RtbxSummary.TabIndex = 7;
            this.RtbxSummary.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(115, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(370, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Dziękuję za skoztystanie z programu.";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox2.Location = new System.Drawing.Point(17, 38);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(601, 89);
            this.richTextBox2.TabIndex = 5;
            this.richTextBox2.Text = resources.GetString("richTextBox2.Text");
            // 
            // TbPgInfo
            // 
            this.TbPgInfo.Controls.Add(this.richTextBox3);
            this.TbPgInfo.Location = new System.Drawing.Point(4, 25);
            this.TbPgInfo.Name = "TbPgInfo";
            this.TbPgInfo.Size = new System.Drawing.Size(636, 437);
            this.TbPgInfo.TabIndex = 3;
            this.TbPgInfo.Text = "O PROGRAMIE";
            this.TbPgInfo.UseVisualStyleBackColor = true;
            // 
            // richTextBox3
            // 
            this.richTextBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox3.Location = new System.Drawing.Point(0, 0);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.ReadOnly = true;
            this.richTextBox3.Size = new System.Drawing.Size(636, 437);
            this.richTextBox3.TabIndex = 5;
            this.richTextBox3.Text = resources.GetString("richTextBox3.Text");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(644, 466);
            this.Controls.Add(this.TbCntrlMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "PGS Software Internsips - Wizard v1.0";
            this.TbCntrlMain.ResumeLayout(false);
            this.TbPgStart.ResumeLayout(false);
            this.TbPgStart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.TbPgFill.ResumeLayout(false);
            this.TbPgSummary.ResumeLayout(false);
            this.TbPgSummary.PerformLayout();
            this.TbPgInfo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private WizardPageControl WizardPage;
        private System.Windows.Forms.TabControl TbCntrlMain;
        private System.Windows.Forms.TabPage TbPgStart;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage TbPgFill;
        private System.Windows.Forms.TabPage TbPgSummary;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnSTART;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Button BtnEXIT;
        private System.Windows.Forms.Button BtnBACK;
        private System.Windows.Forms.RichTextBox RtbxSummary;
        private System.Windows.Forms.TabPage TbPgInfo;
        private System.Windows.Forms.RichTextBox richTextBox3;
    }
}

