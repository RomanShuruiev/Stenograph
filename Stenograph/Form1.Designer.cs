namespace Stenograph
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBoxIn = new System.Windows.Forms.PictureBox();
            this.pictureBoxOut = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tbOriginal = new System.Windows.Forms.TextBox();
            this.OpenText = new System.Windows.Forms.Button();
            this.Crypt = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.OpenImage = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.RusCheck = new System.Windows.Forms.RadioButton();
            this.EngCheck = new System.Windows.Forms.RadioButton();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOut)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(817, 381);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(809, 355);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Visual";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBoxIn, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBoxOut, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(806, 352);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pictureBoxIn
            // 
            this.pictureBoxIn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxIn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxIn.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxIn.Name = "pictureBoxIn";
            this.pictureBoxIn.Size = new System.Drawing.Size(800, 170);
            this.pictureBoxIn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxIn.TabIndex = 0;
            this.pictureBoxIn.TabStop = false;
            // 
            // pictureBoxOut
            // 
            this.pictureBoxOut.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxOut.Location = new System.Drawing.Point(3, 179);
            this.pictureBoxOut.Name = "pictureBoxOut";
            this.pictureBoxOut.Size = new System.Drawing.Size(800, 170);
            this.pictureBoxOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxOut.TabIndex = 1;
            this.pictureBoxOut.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.EngCheck);
            this.tabPage2.Controls.Add(this.RusCheck);
            this.tabPage2.Controls.Add(this.tbOriginal);
            this.tabPage2.Controls.Add(this.OpenText);
            this.tabPage2.Controls.Add(this.Crypt);
            this.tabPage2.Controls.Add(this.Save);
            this.tabPage2.Controls.Add(this.OpenImage);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(809, 355);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Properties";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tbOriginal
            // 
            this.tbOriginal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbOriginal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbOriginal.Location = new System.Drawing.Point(6, 3);
            this.tbOriginal.Multiline = true;
            this.tbOriginal.Name = "tbOriginal";
            this.tbOriginal.Size = new System.Drawing.Size(323, 346);
            this.tbOriginal.TabIndex = 4;
            // 
            // OpenText
            // 
            this.OpenText.Location = new System.Drawing.Point(367, 153);
            this.OpenText.Name = "OpenText";
            this.OpenText.Size = new System.Drawing.Size(270, 49);
            this.OpenText.TabIndex = 3;
            this.OpenText.Text = "Open Text";
            this.OpenText.UseVisualStyleBackColor = true;
            this.OpenText.Click += new System.EventHandler(this.OpenText_Click);
            // 
            // Crypt
            // 
            this.Crypt.Location = new System.Drawing.Point(367, 220);
            this.Crypt.Name = "Crypt";
            this.Crypt.Size = new System.Drawing.Size(270, 47);
            this.Crypt.TabIndex = 2;
            this.Crypt.Text = "Crypt";
            this.Crypt.UseVisualStyleBackColor = true;
            this.Crypt.Click += new System.EventHandler(this.Crypt_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(367, 85);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(270, 48);
            this.Save.TabIndex = 1;
            this.Save.Text = "Save Image";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // OpenImage
            // 
            this.OpenImage.Location = new System.Drawing.Point(367, 18);
            this.OpenImage.Name = "OpenImage";
            this.OpenImage.Size = new System.Drawing.Size(270, 49);
            this.OpenImage.TabIndex = 0;
            this.OpenImage.Text = "Open Image";
            this.OpenImage.UseVisualStyleBackColor = true;
            this.OpenImage.Click += new System.EventHandler(this.Open_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // RusCheck
            // 
            this.RusCheck.AutoSize = true;
            this.RusCheck.Location = new System.Drawing.Point(671, 101);
            this.RusCheck.Name = "RusCheck";
            this.RusCheck.Size = new System.Drawing.Size(44, 17);
            this.RusCheck.TabIndex = 5;
            this.RusCheck.TabStop = true;
            this.RusCheck.Text = "Rus";
            this.RusCheck.UseVisualStyleBackColor = true;
            // 
            // EngCheck
            // 
            this.EngCheck.AutoSize = true;
            this.EngCheck.Location = new System.Drawing.Point(671, 173);
            this.EngCheck.Name = "EngCheck";
            this.EngCheck.Size = new System.Drawing.Size(44, 17);
            this.EngCheck.TabIndex = 6;
            this.EngCheck.TabStop = true;
            this.EngCheck.Text = "Eng";
            this.EngCheck.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 379);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Steno";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOut)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBoxIn;
        private System.Windows.Forms.PictureBox pictureBoxOut;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button Crypt;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button OpenImage;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button OpenText;
        private System.Windows.Forms.TextBox tbOriginal;
        private System.Windows.Forms.RadioButton EngCheck;
        private System.Windows.Forms.RadioButton RusCheck;
    }
}

