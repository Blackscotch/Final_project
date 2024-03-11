namespace UP_manager
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ubGridView = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.UPmenu = new System.Windows.Forms.ToolStripMenuItem();
            this.AddNewUPmenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangeUpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.DellUpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.RegClientMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.AllRegPFRmenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ClientUpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ReloadTab = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ubGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ubGridView
            // 
            this.ubGridView.AllowUserToAddRows = false;
            this.ubGridView.AllowUserToDeleteRows = false;
            this.ubGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ubGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.inn});
            this.ubGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ubGridView.Location = new System.Drawing.Point(0, 27);
            this.ubGridView.Name = "ubGridView";
            this.ubGridView.ReadOnly = true;
            this.ubGridView.Size = new System.Drawing.Size(774, 405);
            this.ubGridView.TabIndex = 2;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 40;
            // 
            // name
            // 
            this.name.HeaderText = "Наименование";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 591;
            // 
            // inn
            // 
            this.inn.HeaderText = "Инн";
            this.inn.Name = "inn";
            this.inn.ReadOnly = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UPmenu,
            this.RegClientMenu,
            this.ClientUpMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(774, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // UPmenu
            // 
            this.UPmenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddNewUPmenu,
            this.ChangeUpMenu,
            this.DellUpMenu});
            this.UPmenu.Name = "UPmenu";
            this.UPmenu.Size = new System.Drawing.Size(203, 20);
            this.UPmenu.Text = "Уполномоченный представитель";
            // 
            // AddNewUPmenu
            // 
            this.AddNewUPmenu.Name = "AddNewUPmenu";
            this.AddNewUPmenu.Size = new System.Drawing.Size(187, 22);
            this.AddNewUPmenu.Text = "Добавить нового УП";
            this.AddNewUPmenu.Click += new System.EventHandler(this.AddNewUPmenu_Click);
            // 
            // ChangeUpMenu
            // 
            this.ChangeUpMenu.Name = "ChangeUpMenu";
            this.ChangeUpMenu.Size = new System.Drawing.Size(187, 22);
            this.ChangeUpMenu.Text = "Редактировать УП";
            this.ChangeUpMenu.Click += new System.EventHandler(this.ChangeUpMenu_Click);
            // 
            // DellUpMenu
            // 
            this.DellUpMenu.Name = "DellUpMenu";
            this.DellUpMenu.Size = new System.Drawing.Size(187, 22);
            this.DellUpMenu.Text = "Удалить  УП";
            this.DellUpMenu.Click += new System.EventHandler(this.DellUpMenu_Click);
            // 
            // RegClientMenu
            // 
            this.RegClientMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AllRegPFRmenu});
            this.RegClientMenu.Name = "RegClientMenu";
            this.RegClientMenu.Size = new System.Drawing.Size(161, 20);
            this.RegClientMenu.Text = "Регистрация клиентов УП";
            // 
            // AllRegPFRmenu
            // 
            this.AllRegPFRmenu.Name = "AllRegPFRmenu";
            this.AllRegPFRmenu.Size = new System.Drawing.Size(223, 22);
            this.AllRegPFRmenu.Text = "Массовая регисрация ПФР";
            this.AllRegPFRmenu.Click += new System.EventHandler(this.AllRegPFRmenu_Click);
            // 
            // ClientUpMenu
            // 
            this.ClientUpMenu.Name = "ClientUpMenu";
            this.ClientUpMenu.Size = new System.Drawing.Size(86, 20);
            this.ClientUpMenu.Text = "Клиенты УП";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // ReloadTab
            // 
            this.ReloadTab.Location = new System.Drawing.Point(493, 1);
            this.ReloadTab.Name = "ReloadTab";
            this.ReloadTab.Size = new System.Drawing.Size(75, 23);
            this.ReloadTab.TabIndex = 4;
            this.ReloadTab.Text = "Обновить";
            this.ReloadTab.UseVisualStyleBackColor = true;
            this.ReloadTab.Click += new System.EventHandler(this.Main_Load);
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(774, 432);
            this.Controls.Add(this.ReloadTab);
            this.Controls.Add(this.ubGridView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Помошник регистратора";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ubGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.DataGridView ubGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn inn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem UPmenu;
        private System.Windows.Forms.ToolStripMenuItem AddNewUPmenu;
        private System.Windows.Forms.ToolStripMenuItem DellUpMenu;
        private System.Windows.Forms.ToolStripMenuItem RegClientMenu;
        private System.Windows.Forms.ToolStripMenuItem AllRegPFRmenu;
        private System.Windows.Forms.ToolStripMenuItem ClientUpMenu;
        private System.Windows.Forms.ToolStripMenuItem ChangeUpMenu;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button ReloadTab;
    }
}

