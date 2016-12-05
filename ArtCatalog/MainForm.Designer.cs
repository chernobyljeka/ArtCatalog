namespace ArtCatalog
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.AboutProgramMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.SellTab = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SellPanel = new System.Windows.Forms.Panel();
            this.productTab = new System.Windows.Forms.TabPage();
            this.Grid = new System.Windows.Forms.TableLayoutPanel();
            this.ControlMenuPanel = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.DataGridPanel = new System.Windows.Forms.Panel();
            this.ControlTabs = new System.Windows.Forms.TabControl();
            this.menuStrip1.SuspendLayout();
            this.SellTab.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.productTab.SuspendLayout();
            this.Grid.SuspendLayout();
            this.ControlMenuPanel.SuspendLayout();
            this.ControlTabs.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutProgramMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(543, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // AboutProgramMenu
            // 
            this.AboutProgramMenu.Name = "AboutProgramMenu";
            this.AboutProgramMenu.Size = new System.Drawing.Size(94, 20);
            this.AboutProgramMenu.Text = "О программе";
            this.AboutProgramMenu.Click += new System.EventHandler(this.AboutProgramMenu_Click);
            // 
            // SellTab
            // 
            this.SellTab.Controls.Add(this.tableLayoutPanel1);
            this.SellTab.Location = new System.Drawing.Point(4, 22);
            this.SellTab.Name = "SellTab";
            this.SellTab.Padding = new System.Windows.Forms.Padding(3);
            this.SellTab.Size = new System.Drawing.Size(535, 211);
            this.SellTab.TabIndex = 1;
            this.SellTab.Text = "Продажа";
            this.SellTab.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.SellPanel, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(529, 205);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(523, 44);
            this.panel1.TabIndex = 0;
            // 
            // SellPanel
            // 
            this.SellPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SellPanel.Location = new System.Drawing.Point(3, 53);
            this.SellPanel.Name = "SellPanel";
            this.SellPanel.Size = new System.Drawing.Size(523, 149);
            this.SellPanel.TabIndex = 1;
            // 
            // productTab
            // 
            this.productTab.Controls.Add(this.Grid);
            this.productTab.Location = new System.Drawing.Point(4, 22);
            this.productTab.Name = "productTab";
            this.productTab.Padding = new System.Windows.Forms.Padding(3);
            this.productTab.Size = new System.Drawing.Size(535, 211);
            this.productTab.TabIndex = 0;
            this.productTab.Text = "Продукция";
            this.productTab.UseVisualStyleBackColor = true;
            // 
            // Grid
            // 
            this.Grid.ColumnCount = 1;
            this.Grid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Grid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.Grid.Controls.Add(this.ControlMenuPanel, 0, 0);
            this.Grid.Controls.Add(this.DataGridPanel, 0, 1);
            this.Grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grid.Location = new System.Drawing.Point(3, 3);
            this.Grid.Name = "Grid";
            this.Grid.RowCount = 2;
            this.Grid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.Grid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Grid.Size = new System.Drawing.Size(529, 205);
            this.Grid.TabIndex = 2;
            // 
            // ControlMenuPanel
            // 
            this.ControlMenuPanel.Controls.Add(this.button5);
            this.ControlMenuPanel.Controls.Add(this.button4);
            this.ControlMenuPanel.Controls.Add(this.button3);
            this.ControlMenuPanel.Controls.Add(this.button2);
            this.ControlMenuPanel.Controls.Add(this.button1);
            this.ControlMenuPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ControlMenuPanel.Location = new System.Drawing.Point(3, 3);
            this.ControlMenuPanel.Name = "ControlMenuPanel";
            this.ControlMenuPanel.Size = new System.Drawing.Size(523, 44);
            this.ControlMenuPanel.TabIndex = 0;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(329, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(74, 37);
            this.button5.TabIndex = 4;
            this.button5.Text = "Подробнее";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(249, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(74, 37);
            this.button4.TabIndex = 3;
            this.button4.Text = "Продать";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(169, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(74, 37);
            this.button3.TabIndex = 2;
            this.button3.Text = "Изменить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(90, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(74, 37);
            this.button2.TabIndex = 1;
            this.button2.Text = "Удалить";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 37);
            this.button1.TabIndex = 0;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // DataGridPanel
            // 
            this.DataGridPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridPanel.Location = new System.Drawing.Point(3, 53);
            this.DataGridPanel.Name = "DataGridPanel";
            this.DataGridPanel.Size = new System.Drawing.Size(523, 149);
            this.DataGridPanel.TabIndex = 1;
            // 
            // ControlTabs
            // 
            this.ControlTabs.Controls.Add(this.productTab);
            this.ControlTabs.Controls.Add(this.SellTab);
            this.ControlTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ControlTabs.Location = new System.Drawing.Point(0, 24);
            this.ControlTabs.Name = "ControlTabs";
            this.ControlTabs.SelectedIndex = 0;
            this.ControlTabs.Size = new System.Drawing.Size(543, 237);
            this.ControlTabs.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 261);
            this.Controls.Add(this.ControlTabs);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "АртКаталог";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.SellTab.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.productTab.ResumeLayout(false);
            this.Grid.ResumeLayout(false);
            this.ControlMenuPanel.ResumeLayout(false);
            this.ControlTabs.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem AboutProgramMenu;
        private System.Windows.Forms.TabPage SellTab;
        private System.Windows.Forms.TabPage productTab;
        private System.Windows.Forms.TableLayoutPanel Grid;
        private System.Windows.Forms.Panel ControlMenuPanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel DataGridPanel;
        private System.Windows.Forms.TabControl ControlTabs;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel SellPanel;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
    }
}

