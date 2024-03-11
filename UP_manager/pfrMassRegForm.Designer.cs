namespace UP_manager
{
    partial class pfrMassRegForm
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
            this.pathBox = new System.Windows.Forms.TextBox();
            this.ubNameLabel = new System.Windows.Forms.Label();
            this.goButton = new System.Windows.Forms.Button();
            this.importGridView = new System.Windows.Forms.DataGridView();
            this.pfr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pfrcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.importGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Выбор файла";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pathBox
            // 
            this.pathBox.Location = new System.Drawing.Point(12, 41);
            this.pathBox.Name = "pathBox";
            this.pathBox.ReadOnly = true;
            this.pathBox.Size = new System.Drawing.Size(463, 20);
            this.pathBox.TabIndex = 3;
            // 
            // ubNameLabel
            // 
            this.ubNameLabel.AutoSize = true;
            this.ubNameLabel.Location = new System.Drawing.Point(166, 17);
            this.ubNameLabel.Name = "ubNameLabel";
            this.ubNameLabel.Size = new System.Drawing.Size(73, 13);
            this.ubNameLabel.TabIndex = 6;
            this.ubNameLabel.Text = "ubNameLabel";
            // 
            // goButton
            // 
            this.goButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.goButton.Location = new System.Drawing.Point(675, 14);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(84, 47);
            this.goButton.TabIndex = 7;
            this.goButton.Text = "Поехали";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // importGridView
            // 
            this.importGridView.AllowUserToAddRows = false;
            this.importGridView.AllowUserToDeleteRows = false;
            this.importGridView.AllowUserToResizeColumns = false;
            this.importGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.importGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.importGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.importGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pfr,
            this.name,
            this.pfrcode});
            this.importGridView.Location = new System.Drawing.Point(1, 67);
            this.importGridView.MultiSelect = false;
            this.importGridView.Name = "importGridView";
            this.importGridView.ReadOnly = true;
            this.importGridView.Size = new System.Drawing.Size(799, 290);
            this.importGridView.TabIndex = 8;
            // 
            // pfr
            // 
            this.pfr.HeaderText = "Код страхователя";
            this.pfr.Name = "pfr";
            this.pfr.ReadOnly = true;
            this.pfr.Width = 113;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.HeaderText = "Наименование страхователя";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // pfrcode
            // 
            this.pfrcode.HeaderText = "Код участка ПФР";
            this.pfrcode.Name = "pfrcode";
            this.pfrcode.ReadOnly = true;
            this.pfrcode.Width = 112;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(1, 363);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(799, 108);
            this.listBox1.TabIndex = 9;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // pfrMassRegForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 471);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.importGridView);
            this.Controls.Add(this.goButton);
            this.Controls.Add(this.ubNameLabel);
            this.Controls.Add(this.pathBox);
            this.Controls.Add(this.button1);
            this.Name = "pfrMassRegForm";
            this.Text = "pfrMassRegForm";
            this.Load += new System.EventHandler(this.pfrMassRegForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.importGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox pathBox;
        private System.Windows.Forms.Label ubNameLabel;
        private System.Windows.Forms.Button goButton;
        private System.Windows.Forms.DataGridView importGridView;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private string up_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn pfr;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn pfrcode;
    }
}