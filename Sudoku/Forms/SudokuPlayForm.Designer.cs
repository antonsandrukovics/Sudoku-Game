
namespace Sudoku
{
    partial class SudokuPlayForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SudokuPlayForm));
            this.leftPanel = new System.Windows.Forms.Panel();
            this.topTenButton = new System.Windows.Forms.Button();
            this.rulesButton = new System.Windows.Forms.Button();
            this.playSudokuButton = new System.Windows.Forms.Button();
            this.pictureBoxS = new System.Windows.Forms.PictureBox();
            this.topPanel = new System.Windows.Forms.Panel();
            this.exitButton = new System.Windows.Forms.Button();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panelContainer = new System.Windows.Forms.Panel();
            this.rigthPanel2 = new System.Windows.Forms.Panel();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.rigthPanel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.topTenResultForm1 = new Sudoku.LevelControls.TopTenResultForm();
            this.rulesForm2 = new Sudoku.LevelControls.RulesForm();
            this.rulesForm1 = new Sudoku.LevelControls.RulesForm();
            this.hardSudoku1 = new Sudoku.LevelControls.HardSudoku();
            this.leftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxS)).BeginInit();
            this.panelContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(36)))), ((int)(((byte)(44)))));
            this.leftPanel.Controls.Add(this.topTenButton);
            this.leftPanel.Controls.Add(this.rulesButton);
            this.leftPanel.Controls.Add(this.playSudokuButton);
            this.leftPanel.Controls.Add(this.pictureBoxS);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(133, 550);
            this.leftPanel.TabIndex = 327;
            // 
            // topTenButton
            // 
            this.topTenButton.FlatAppearance.BorderSize = 0;
            this.topTenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.topTenButton.ForeColor = System.Drawing.Color.White;
            this.topTenButton.Image = ((System.Drawing.Image)(resources.GetObject("topTenButton.Image")));
            this.topTenButton.Location = new System.Drawing.Point(0, 209);
            this.topTenButton.Name = "topTenButton";
            this.topTenButton.Size = new System.Drawing.Size(133, 43);
            this.topTenButton.TabIndex = 3;
            this.topTenButton.Text = "TOP10";
            this.topTenButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.topTenButton.UseVisualStyleBackColor = true;
            this.topTenButton.Click += new System.EventHandler(this.topTenButton_Click);
            // 
            // rulesButton
            // 
            this.rulesButton.FlatAppearance.BorderSize = 0;
            this.rulesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rulesButton.ForeColor = System.Drawing.Color.White;
            this.rulesButton.Image = ((System.Drawing.Image)(resources.GetObject("rulesButton.Image")));
            this.rulesButton.Location = new System.Drawing.Point(0, 160);
            this.rulesButton.Name = "rulesButton";
            this.rulesButton.Size = new System.Drawing.Size(133, 43);
            this.rulesButton.TabIndex = 2;
            this.rulesButton.Text = "Rules";
            this.rulesButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rulesButton.UseVisualStyleBackColor = true;
            this.rulesButton.Click += new System.EventHandler(this.rulesButton_Click);
            // 
            // playSudokuButton
            // 
            this.playSudokuButton.FlatAppearance.BorderSize = 0;
            this.playSudokuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playSudokuButton.ForeColor = System.Drawing.Color.White;
            this.playSudokuButton.Image = ((System.Drawing.Image)(resources.GetObject("playSudokuButton.Image")));
            this.playSudokuButton.Location = new System.Drawing.Point(0, 111);
            this.playSudokuButton.Name = "playSudokuButton";
            this.playSudokuButton.Size = new System.Drawing.Size(133, 43);
            this.playSudokuButton.TabIndex = 1;
            this.playSudokuButton.Text = "Play Sudoku";
            this.playSudokuButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.playSudokuButton.UseVisualStyleBackColor = true;
            this.playSudokuButton.Click += new System.EventHandler(this.playSudokuButton_Click);
            // 
            // pictureBoxS
            // 
            this.pictureBoxS.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxS.Image")));
            this.pictureBoxS.Location = new System.Drawing.Point(15, 12);
            this.pictureBoxS.Name = "pictureBoxS";
            this.pictureBoxS.Size = new System.Drawing.Size(100, 81);
            this.pictureBoxS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxS.TabIndex = 0;
            this.pictureBoxS.TabStop = false;
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(133, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(667, 12);
            this.topPanel.TabIndex = 328;
            // 
            // exitButton
            // 
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.Image = ((System.Drawing.Image)(resources.GetObject("exitButton.Image")));
            this.exitButton.Location = new System.Drawing.Point(740, 12);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(48, 43);
            this.exitButton.TabIndex = 4;
            this.exitButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 25;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // panelContainer
            // 
            this.panelContainer.Controls.Add(this.rigthPanel2);
            this.panelContainer.Controls.Add(this.bottomPanel);
            this.panelContainer.Controls.Add(this.topTenResultForm1);
            this.panelContainer.Controls.Add(this.rulesForm2);
            this.panelContainer.Controls.Add(this.rulesForm1);
            this.panelContainer.Controls.Add(this.hardSudoku1);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelContainer.Location = new System.Drawing.Point(133, 61);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(667, 489);
            this.panelContainer.TabIndex = 329;
            // 
            // rigthPanel2
            // 
            this.rigthPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.rigthPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.rigthPanel2.Location = new System.Drawing.Point(657, 0);
            this.rigthPanel2.Name = "rigthPanel2";
            this.rigthPanel2.Size = new System.Drawing.Size(10, 477);
            this.rigthPanel2.TabIndex = 330;
            // 
            // bottomPanel
            // 
            this.bottomPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(0, 477);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(667, 12);
            this.bottomPanel.TabIndex = 329;
            // 
            // rigthPanel1
            // 
            this.rigthPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.rigthPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.rigthPanel1.Location = new System.Drawing.Point(790, 12);
            this.rigthPanel1.Name = "rigthPanel1";
            this.rigthPanel1.Size = new System.Drawing.Size(10, 49);
            this.rigthPanel1.TabIndex = 330;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Text", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(150, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 47);
            this.label1.TabIndex = 331;
            this.label1.Text = "Rules";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Text", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(371, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 47);
            this.label2.TabIndex = 332;
            // 
            // topTenResultForm1
            // 
            this.topTenResultForm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.topTenResultForm1.Location = new System.Drawing.Point(0, 0);
            this.topTenResultForm1.Name = "topTenResultForm1";
            this.topTenResultForm1.Size = new System.Drawing.Size(667, 489);
            this.topTenResultForm1.TabIndex = 3;
            // 
            // rulesForm2
            // 
            this.rulesForm2.Location = new System.Drawing.Point(92, 62);
            this.rulesForm2.Name = "rulesForm2";
            this.rulesForm2.Size = new System.Drawing.Size(8, 8);
            this.rulesForm2.TabIndex = 2;
            // 
            // rulesForm1
            // 
            this.rulesForm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rulesForm1.Location = new System.Drawing.Point(0, 0);
            this.rulesForm1.Name = "rulesForm1";
            this.rulesForm1.Size = new System.Drawing.Size(667, 489);
            this.rulesForm1.TabIndex = 1;
            // 
            // hardSudoku1
            // 
            this.hardSudoku1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hardSudoku1.Location = new System.Drawing.Point(0, 0);
            this.hardSudoku1.Name = "hardSudoku1";
            this.hardSudoku1.Size = new System.Drawing.Size(667, 489);
            this.hardSudoku1.TabIndex = 0;
            // 
            // SudokuPlayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 550);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rigthPanel1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.leftPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SudokuPlayForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SudokuPlayForm";
            this.leftPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxS)).EndInit();
            this.panelContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Button topTenButton;
        private System.Windows.Forms.Button rulesButton;
        private System.Windows.Forms.Button playSudokuButton;
        private System.Windows.Forms.PictureBox pictureBoxS;
        private System.Windows.Forms.Button exitButton;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panelContainer;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private LevelControls.HardSudoku hardSudoku1;
        private LevelControls.RulesForm rulesForm1;
        private LevelControls.RulesForm rulesForm2;
        private LevelControls.TopTenResultForm topTenResultForm1;
        private System.Windows.Forms.Panel rigthPanel1;
        private System.Windows.Forms.Panel rigthPanel2;
        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}