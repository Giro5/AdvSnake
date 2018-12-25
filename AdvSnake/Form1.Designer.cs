namespace AdvSnake
{
    partial class Form1
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
            this.FieldPnl = new System.Windows.Forms.Panel();
            this.PEOETELbl = new System.Windows.Forms.Label();
            this.PAKTCLbl = new System.Windows.Forms.Label();
            this.GameOverLbl = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.difficultyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.easyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mediumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showGridToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.themeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pauseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Tmr = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.TSSL1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.TSSL2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.FieldPnl.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FieldPnl
            // 
            this.FieldPnl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FieldPnl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.FieldPnl.Controls.Add(this.PEOETELbl);
            this.FieldPnl.Controls.Add(this.PAKTCLbl);
            this.FieldPnl.Controls.Add(this.GameOverLbl);
            this.FieldPnl.Location = new System.Drawing.Point(0, 24);
            this.FieldPnl.Margin = new System.Windows.Forms.Padding(0);
            this.FieldPnl.Name = "FieldPnl";
            this.FieldPnl.Size = new System.Drawing.Size(841, 440);
            this.FieldPnl.TabIndex = 1;
            this.FieldPnl.SizeChanged += new System.EventHandler(this.FieldPnl_SizeChanged);
            this.FieldPnl.Paint += new System.Windows.Forms.PaintEventHandler(this.FieldPnl_Paint);
            // 
            // PEOETELbl
            // 
            this.PEOETELbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PEOETELbl.AutoSize = true;
            this.PEOETELbl.BackColor = System.Drawing.Color.Transparent;
            this.PEOETELbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PEOETELbl.Location = new System.Drawing.Point(319, 224);
            this.PEOETELbl.Name = "PEOETELbl";
            this.PEOETELbl.Size = new System.Drawing.Size(203, 19);
            this.PEOETELbl.TabIndex = 2;
            this.PEOETELbl.Text = "Press Enter or Esc to Exit";
            this.PEOETELbl.Visible = false;
            // 
            // PAKTCLbl
            // 
            this.PAKTCLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PAKTCLbl.AutoSize = true;
            this.PAKTCLbl.BackColor = System.Drawing.Color.Transparent;
            this.PAKTCLbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PAKTCLbl.Location = new System.Drawing.Point(316, 195);
            this.PAKTCLbl.Name = "PAKTCLbl";
            this.PAKTCLbl.Size = new System.Drawing.Size(209, 19);
            this.PAKTCLbl.TabIndex = 1;
            this.PAKTCLbl.Text = "Press any key to Continue";
            this.PAKTCLbl.Visible = false;
            // 
            // GameOverLbl
            // 
            this.GameOverLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GameOverLbl.AutoSize = true;
            this.GameOverLbl.BackColor = System.Drawing.Color.Transparent;
            this.GameOverLbl.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GameOverLbl.Location = new System.Drawing.Point(318, 153);
            this.GameOverLbl.Name = "GameOverLbl";
            this.GameOverLbl.Size = new System.Drawing.Size(202, 41);
            this.GameOverLbl.TabIndex = 0;
            this.GameOverLbl.Text = "Game Over";
            this.GameOverLbl.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.difficultyToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.gameToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(841, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // difficultyToolStripMenuItem
            // 
            this.difficultyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.easyToolStripMenuItem,
            this.mediumToolStripMenuItem,
            this.hardToolStripMenuItem});
            this.difficultyToolStripMenuItem.Name = "difficultyToolStripMenuItem";
            this.difficultyToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.difficultyToolStripMenuItem.Text = "Difficulty";
            // 
            // easyToolStripMenuItem
            // 
            this.easyToolStripMenuItem.AccessibleDescription = "1";
            this.easyToolStripMenuItem.Name = "easyToolStripMenuItem";
            this.easyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.easyToolStripMenuItem.Text = "Easy";
            this.easyToolStripMenuItem.Click += new System.EventHandler(this.ChangeDifficultyTSMI_Click);
            // 
            // mediumToolStripMenuItem
            // 
            this.mediumToolStripMenuItem.AccessibleDescription = "2";
            this.mediumToolStripMenuItem.Checked = true;
            this.mediumToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mediumToolStripMenuItem.Name = "mediumToolStripMenuItem";
            this.mediumToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mediumToolStripMenuItem.Text = "Medium";
            this.mediumToolStripMenuItem.Click += new System.EventHandler(this.ChangeDifficultyTSMI_Click);
            // 
            // hardToolStripMenuItem
            // 
            this.hardToolStripMenuItem.AccessibleDescription = "3";
            this.hardToolStripMenuItem.Name = "hardToolStripMenuItem";
            this.hardToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.hardToolStripMenuItem.Text = "Hard";
            this.hardToolStripMenuItem.Click += new System.EventHandler(this.ChangeDifficultyTSMI_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showGridToolStripMenuItem,
            this.themeToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // showGridToolStripMenuItem
            // 
            this.showGridToolStripMenuItem.Name = "showGridToolStripMenuItem";
            this.showGridToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.showGridToolStripMenuItem.Text = "Show Grid";
            this.showGridToolStripMenuItem.Click += new System.EventHandler(this.showGridToolStripMenuItem_Click);
            // 
            // themeToolStripMenuItem
            // 
            this.themeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.brightToolStripMenuItem,
            this.darkToolStripMenuItem});
            this.themeToolStripMenuItem.Name = "themeToolStripMenuItem";
            this.themeToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.themeToolStripMenuItem.Text = "Theme";
            // 
            // brightToolStripMenuItem
            // 
            this.brightToolStripMenuItem.Checked = true;
            this.brightToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.brightToolStripMenuItem.Name = "brightToolStripMenuItem";
            this.brightToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.brightToolStripMenuItem.Text = "Bright";
            this.brightToolStripMenuItem.Click += new System.EventHandler(this.brightToolStripMenuItem_Click);
            // 
            // darkToolStripMenuItem
            // 
            this.darkToolStripMenuItem.Name = "darkToolStripMenuItem";
            this.darkToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.darkToolStripMenuItem.Text = "Dark";
            this.darkToolStripMenuItem.Click += new System.EventHandler(this.darkToolStripMenuItem_Click);
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.stopToolStripMenuItem,
            this.pauseToolStripMenuItem});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.gameToolStripMenuItem.Text = "Game";
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.startToolStripMenuItem.Text = "Start";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Enabled = false;
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.stopToolStripMenuItem.Text = "Stop";
            this.stopToolStripMenuItem.Click += new System.EventHandler(this.stopToolStripMenuItem_Click);
            // 
            // pauseToolStripMenuItem
            // 
            this.pauseToolStripMenuItem.Enabled = false;
            this.pauseToolStripMenuItem.Name = "pauseToolStripMenuItem";
            this.pauseToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.pauseToolStripMenuItem.Text = "Pause";
            this.pauseToolStripMenuItem.Click += new System.EventHandler(this.pauseToolStripMenuItem_Click);
            // 
            // Tmr
            // 
            this.Tmr.Tick += new System.EventHandler(this.Tmr_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSSL1,
            this.TSSL2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 464);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(841, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // TSSL1
            // 
            this.TSSL1.AutoSize = false;
            this.TSSL1.Name = "TSSL1";
            this.TSSL1.Size = new System.Drawing.Size(150, 17);
            this.TSSL1.Text = "Score";
            this.TSSL1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TSSL2
            // 
            this.TSSL2.Name = "TSSL2";
            this.TSSL2.Size = new System.Drawing.Size(27, 17);
            this.TSSL2.Text = "Size";
            this.TSSL2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 486);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.FieldPnl);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Snake";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.FieldPnl.ResumeLayout(false);
            this.FieldPnl.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel FieldPnl;
        private System.Windows.Forms.Timer Tmr;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem difficultyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showGridToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pauseToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel TSSL1;
        private System.Windows.Forms.Label GameOverLbl;
        private System.Windows.Forms.Label PAKTCLbl;
        private System.Windows.Forms.Label PEOETELbl;
        private System.Windows.Forms.ToolStripMenuItem themeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem darkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem easyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mediumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hardToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel TSSL2;
    }
}

