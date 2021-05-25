
namespace Sudoku
{
    partial class StartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.Exitbutton = new System.Windows.Forms.Button();
            this.pictureBoxS = new System.Windows.Forms.PictureBox();
            this.sudokuLabel = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.loginLabel = new System.Windows.Forms.Label();
            this.userNameTextBox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.loginButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.rigthPanel = new System.Windows.Forms.Panel();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxS)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(36)))), ((int)(((byte)(44)))));
            this.panelHeader.Controls.Add(this.Exitbutton);
            this.panelHeader.Controls.Add(this.pictureBoxS);
            this.panelHeader.Controls.Add(this.sudokuLabel);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(846, 76);
            this.panelHeader.TabIndex = 237;
            // 
            // Exitbutton
            // 
            this.Exitbutton.FlatAppearance.BorderSize = 0;
            this.Exitbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exitbutton.Image = ((System.Drawing.Image)(resources.GetObject("Exitbutton.Image")));
            this.Exitbutton.Location = new System.Drawing.Point(777, 20);
            this.Exitbutton.Name = "Exitbutton";
            this.Exitbutton.Size = new System.Drawing.Size(47, 40);
            this.Exitbutton.TabIndex = 2;
            this.Exitbutton.UseVisualStyleBackColor = true;
            this.Exitbutton.Click += new System.EventHandler(this.Exitbutton_Click);
            // 
            // pictureBoxS
            // 
            this.pictureBoxS.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxS.Image")));
            this.pictureBoxS.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxS.Name = "pictureBoxS";
            this.pictureBoxS.Size = new System.Drawing.Size(42, 53);
            this.pictureBoxS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxS.TabIndex = 0;
            this.pictureBoxS.TabStop = false;
            // 
            // sudokuLabel
            // 
            this.sudokuLabel.AutoSize = true;
            this.sudokuLabel.Font = new System.Drawing.Font("Britannic Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sudokuLabel.ForeColor = System.Drawing.Color.Red;
            this.sudokuLabel.Location = new System.Drawing.Point(43, 20);
            this.sudokuLabel.Name = "sudokuLabel";
            this.sudokuLabel.Size = new System.Drawing.Size(154, 53);
            this.sudokuLabel.TabIndex = 1;
            this.sudokuLabel.Text = "udoku";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 45;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panelHeader;
            this.bunifuDragControl1.Vertical = true;
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Britannic Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLabel.ForeColor = System.Drawing.Color.Black;
            this.loginLabel.Location = new System.Drawing.Point(276, 216);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(243, 32);
            this.loginLabel.TabIndex = 3;
            this.loginLabel.Text = "Please Login First";
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(36)))), ((int)(((byte)(44)))));
            this.userNameTextBox.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(36)))), ((int)(((byte)(44)))));
            this.userNameTextBox.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(36)))), ((int)(((byte)(44)))));
            this.userNameTextBox.BorderThickness = 3;
            this.userNameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.userNameTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.userNameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.userNameTextBox.isPassword = false;
            this.userNameTextBox.Location = new System.Drawing.Point(215, 261);
            this.userNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(370, 44);
            this.userNameTextBox.TabIndex = 238;
            this.userNameTextBox.Tag = "";
            this.userNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // loginButton
            // 
            this.loginButton.ActiveBorderThickness = 1;
            this.loginButton.ActiveCornerRadius = 20;
            this.loginButton.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(36)))), ((int)(((byte)(44)))));
            this.loginButton.ActiveForecolor = System.Drawing.Color.White;
            this.loginButton.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(36)))), ((int)(((byte)(44)))));
            this.loginButton.BackColor = System.Drawing.SystemColors.Control;
            this.loginButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("loginButton.BackgroundImage")));
            this.loginButton.ButtonText = "Login";
            this.loginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.ForeColor = System.Drawing.Color.White;
            this.loginButton.IdleBorderThickness = 1;
            this.loginButton.IdleCornerRadius = 20;
            this.loginButton.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(36)))), ((int)(((byte)(44)))));
            this.loginButton.IdleForecolor = System.Drawing.Color.White;
            this.loginButton.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(36)))), ((int)(((byte)(44)))));
            this.loginButton.Location = new System.Drawing.Point(215, 314);
            this.loginButton.Margin = new System.Windows.Forms.Padding(5);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(370, 41);
            this.loginButton.TabIndex = 241;
            this.loginButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // rigthPanel
            // 
            this.rigthPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.rigthPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.rigthPanel.Location = new System.Drawing.Point(836, 76);
            this.rigthPanel.Name = "rigthPanel";
            this.rigthPanel.Size = new System.Drawing.Size(10, 488);
            this.rigthPanel.TabIndex = 329;
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 76);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(10, 488);
            this.leftPanel.TabIndex = 330;
            // 
            // bottomPanel
            // 
            this.bottomPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(10, 552);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(826, 12);
            this.bottomPanel.TabIndex = 331;
            // 
            // StartForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(846, 564);
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.leftPanel);
            this.Controls.Add(this.rigthPanel);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.userNameTextBox);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HardForm";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.PictureBox pictureBoxS;
        private System.Windows.Forms.Label sudokuLabel;
        private System.Windows.Forms.Button Exitbutton;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuThinButton2 loginButton;
        private Bunifu.Framework.UI.BunifuMetroTextbox userNameTextBox;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Panel rigthPanel;
        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.Panel leftPanel;
    }
}