namespace UP_manager
{
    partial class ubAddForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.okpoTextBox = new System.Windows.Forms.TextBox();
            this.pfrTextBox = new System.Windows.Forms.TextBox();
            this.innTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.certOpenButton = new System.Windows.Forms.Button();
            this.certPathBox = new System.Windows.Forms.TextBox();
            this.certInfoBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.okpoTextBox);
            this.groupBox1.Controls.Add(this.pfrTextBox);
            this.groupBox1.Controls.Add(this.innTextBox);
            this.groupBox1.Controls.Add(this.nameTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox1.Size = new System.Drawing.Size(506, 215);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Сведения об УП";
            // 
            // okpoTextBox
            // 
            this.okpoTextBox.Location = new System.Drawing.Point(137, 166);
            this.okpoTextBox.Multiline = true;
            this.okpoTextBox.Name = "okpoTextBox";
            this.okpoTextBox.Size = new System.Drawing.Size(209, 28);
            this.okpoTextBox.TabIndex = 1;
            // 
            // pfrTextBox
            // 
            this.pfrTextBox.Location = new System.Drawing.Point(137, 125);
            this.pfrTextBox.Multiline = true;
            this.pfrTextBox.Name = "pfrTextBox";
            this.pfrTextBox.Size = new System.Drawing.Size(209, 28);
            this.pfrTextBox.TabIndex = 1;
            // 
            // innTextBox
            // 
            this.innTextBox.Location = new System.Drawing.Point(137, 84);
            this.innTextBox.Multiline = true;
            this.innTextBox.Name = "innTextBox";
            this.innTextBox.Size = new System.Drawing.Size(209, 28);
            this.innTextBox.TabIndex = 1;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(137, 43);
            this.nameTextBox.Multiline = true;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(343, 28);
            this.nameTextBox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "ОКПО";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "ПФР";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "ИНН";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Наименование";
            // 
            // certOpenButton
            // 
            this.certOpenButton.Location = new System.Drawing.Point(10, 252);
            this.certOpenButton.Name = "certOpenButton";
            this.certOpenButton.Size = new System.Drawing.Size(114, 23);
            this.certOpenButton.TabIndex = 1;
            this.certOpenButton.Text = "Файл сертификата";
            this.certOpenButton.UseVisualStyleBackColor = true;
            this.certOpenButton.Click += new System.EventHandler(this.certOpenButton_Click);
            // 
            // certPathBox
            // 
            this.certPathBox.Location = new System.Drawing.Point(147, 252);
            this.certPathBox.Multiline = true;
            this.certPathBox.Name = "certPathBox";
            this.certPathBox.Size = new System.Drawing.Size(369, 23);
            this.certPathBox.TabIndex = 2;
            // 
            // certInfoBox
            // 
            this.certInfoBox.Location = new System.Drawing.Point(10, 295);
            this.certInfoBox.Multiline = true;
            this.certInfoBox.Name = "certInfoBox";
            this.certInfoBox.Size = new System.Drawing.Size(506, 170);
            this.certInfoBox.TabIndex = 3;
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveButton.Location = new System.Drawing.Point(177, 502);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(179, 43);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // ubAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 575);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.certInfoBox);
            this.Controls.Add(this.certPathBox);
            this.Controls.Add(this.certOpenButton);
            this.Controls.Add(this.groupBox1);
            this.Name = "ubAddForm";
            this.Text = "Форма редактирования УП";
            this.Load += new System.EventHandler(this.ubAddForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox okpoTextBox;
        private System.Windows.Forms.TextBox pfrTextBox;
        private System.Windows.Forms.TextBox innTextBox;
        private System.Windows.Forms.Button certOpenButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox certPathBox;
        private System.Windows.Forms.TextBox certInfoBox;
        private System.Windows.Forms.Button saveButton;
        public string up_id;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}