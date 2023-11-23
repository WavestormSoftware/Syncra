namespace Syncra
{
    partial class Register
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            LoginContainer = new Panel();
            panel8 = new Panel();
            LoginButton = new Controls.WSButton();
            panel1 = new Panel();
            PasswordTB = new Controls.WSTextBox();
            Credits = new Label();
            panel7 = new Panel();
            UsernameTB = new Controls.WSTextBox();
            panel6 = new Panel();
            EmailTB = new Controls.WSTextBox();
            panel5 = new Panel();
            label1 = new Label();
            panel4 = new Panel();
            Title = new Label();
            TopSepPanel = new Panel();
            LeftSepPanel = new Panel();
            RightSepPanel = new Panel();
            CloseApp = new Label();
            LoginContainer.SuspendLayout();
            RightSepPanel.SuspendLayout();
            SuspendLayout();
            // 
            // LoginContainer
            // 
            LoginContainer.BackColor = Color.White;
            LoginContainer.Controls.Add(panel8);
            LoginContainer.Controls.Add(LoginButton);
            LoginContainer.Controls.Add(panel1);
            LoginContainer.Controls.Add(PasswordTB);
            LoginContainer.Controls.Add(Credits);
            LoginContainer.Controls.Add(panel7);
            LoginContainer.Controls.Add(UsernameTB);
            LoginContainer.Controls.Add(panel6);
            LoginContainer.Controls.Add(EmailTB);
            LoginContainer.Controls.Add(panel5);
            LoginContainer.Controls.Add(label1);
            LoginContainer.Controls.Add(panel4);
            LoginContainer.Controls.Add(Title);
            LoginContainer.Controls.Add(TopSepPanel);
            LoginContainer.Controls.Add(LeftSepPanel);
            LoginContainer.Controls.Add(RightSepPanel);
            LoginContainer.Dock = DockStyle.Fill;
            LoginContainer.Location = new Point(0, 0);
            LoginContainer.Name = "LoginContainer";
            LoginContainer.Size = new Size(325, 400);
            LoginContainer.TabIndex = 0;
            LoginContainer.MouseMove += DragWindow;
            // 
            // panel8
            // 
            panel8.Dock = DockStyle.Top;
            panel8.Location = new Point(40, 297);
            panel8.Name = "panel8";
            panel8.Size = new Size(245, 28);
            panel8.TabIndex = 13;
            // 
            // LoginButton
            // 
            LoginButton.BackColor = Color.FromArgb(50, 78, 205);
            LoginButton.BackgroundColor = Color.FromArgb(50, 78, 205);
            LoginButton.BorderColor = Color.PaleVioletRed;
            LoginButton.BorderRadius = 12;
            LoginButton.BorderSize = 0;
            LoginButton.Dock = DockStyle.Top;
            LoginButton.FlatAppearance.BorderSize = 0;
            LoginButton.FlatStyle = FlatStyle.Flat;
            LoginButton.Font = new Font("Kollektif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            LoginButton.ForeColor = Color.White;
            LoginButton.Location = new Point(40, 257);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(245, 40);
            LoginButton.TabIndex = 12;
            LoginButton.Text = "Register";
            LoginButton.TextColor = Color.White;
            LoginButton.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(40, 247);
            panel1.Name = "panel1";
            panel1.Size = new Size(245, 10);
            panel1.TabIndex = 16;
            // 
            // PasswordTB
            // 
            PasswordTB.BackColor = SystemColors.Window;
            PasswordTB.BorderColor = Color.FromArgb(50, 78, 205);
            PasswordTB.BorderFocusColor = Color.FromArgb(60, 88, 215);
            PasswordTB.BorderRadius = 12;
            PasswordTB.BorderSize = 2;
            PasswordTB.Dock = DockStyle.Top;
            PasswordTB.Font = new Font("Kollektif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordTB.ForeColor = Color.FromArgb(64, 64, 64);
            PasswordTB.Location = new Point(40, 217);
            PasswordTB.Margin = new Padding(4);
            PasswordTB.Multiline = false;
            PasswordTB.Name = "PasswordTB";
            PasswordTB.Padding = new Padding(10, 7, 10, 7);
            PasswordTB.PasswordChar = true;
            PasswordTB.PlaceholderColor = Color.DarkGray;
            PasswordTB.PlaceholderText = "Password";
            PasswordTB.Size = new Size(245, 30);
            PasswordTB.TabIndex = 25;
            PasswordTB.Texts = "";
            PasswordTB.UnderlinedStyle = false;
            // 
            // Credits
            // 
            Credits.Dock = DockStyle.Bottom;
            Credits.Font = new Font("Kollektif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Credits.Location = new Point(40, 377);
            Credits.Name = "Credits";
            Credits.Size = new Size(245, 23);
            Credits.TabIndex = 14;
            Credits.Text = "Syncra © - A Wavestorm Software Tool";
            Credits.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel7
            // 
            panel7.Dock = DockStyle.Top;
            panel7.Location = new Point(40, 207);
            panel7.Name = "panel7";
            panel7.Size = new Size(245, 10);
            panel7.TabIndex = 10;
            // 
            // UsernameTB
            // 
            UsernameTB.BackColor = SystemColors.Window;
            UsernameTB.BorderColor = Color.FromArgb(50, 78, 205);
            UsernameTB.BorderFocusColor = Color.FromArgb(60, 88, 215);
            UsernameTB.BorderRadius = 12;
            UsernameTB.BorderSize = 2;
            UsernameTB.Dock = DockStyle.Top;
            UsernameTB.Font = new Font("Kollektif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            UsernameTB.ForeColor = Color.FromArgb(64, 64, 64);
            UsernameTB.Location = new Point(40, 177);
            UsernameTB.Margin = new Padding(4);
            UsernameTB.Multiline = false;
            UsernameTB.Name = "UsernameTB";
            UsernameTB.Padding = new Padding(10, 7, 10, 7);
            UsernameTB.PasswordChar = false;
            UsernameTB.PlaceholderColor = Color.DarkGray;
            UsernameTB.PlaceholderText = "Username";
            UsernameTB.Size = new Size(245, 30);
            UsernameTB.TabIndex = 24;
            UsernameTB.Texts = "";
            UsernameTB.UnderlinedStyle = false;
            // 
            // panel6
            // 
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(40, 167);
            panel6.Name = "panel6";
            panel6.Size = new Size(245, 10);
            panel6.TabIndex = 8;
            // 
            // EmailTB
            // 
            EmailTB.BackColor = SystemColors.Window;
            EmailTB.BorderColor = Color.FromArgb(50, 78, 205);
            EmailTB.BorderFocusColor = Color.FromArgb(60, 88, 215);
            EmailTB.BorderRadius = 12;
            EmailTB.BorderSize = 2;
            EmailTB.Dock = DockStyle.Top;
            EmailTB.Font = new Font("Kollektif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            EmailTB.ForeColor = Color.FromArgb(64, 64, 64);
            EmailTB.Location = new Point(40, 137);
            EmailTB.Margin = new Padding(4);
            EmailTB.Multiline = false;
            EmailTB.Name = "EmailTB";
            EmailTB.Padding = new Padding(10, 7, 10, 7);
            EmailTB.PasswordChar = false;
            EmailTB.PlaceholderColor = Color.DarkGray;
            EmailTB.PlaceholderText = "Email";
            EmailTB.Size = new Size(245, 30);
            EmailTB.TabIndex = 23;
            EmailTB.Texts = "";
            EmailTB.UnderlinedStyle = false;
            // 
            // panel5
            // 
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(40, 127);
            panel5.Name = "panel5";
            panel5.Size = new Size(245, 10);
            panel5.TabIndex = 6;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Kollektif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(40, 100);
            label1.Name = "label1";
            label1.Size = new Size(245, 27);
            label1.TabIndex = 5;
            label1.Text = "Register";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel4
            // 
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(40, 90);
            panel4.Name = "panel4";
            panel4.Size = new Size(245, 10);
            panel4.TabIndex = 4;
            // 
            // Title
            // 
            Title.Dock = DockStyle.Top;
            Title.Font = new Font("Kollektif", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            Title.Location = new Point(40, 50);
            Title.Name = "Title";
            Title.Size = new Size(245, 40);
            Title.TabIndex = 0;
            Title.Text = "Syncra";
            Title.TextAlign = ContentAlignment.MiddleCenter;
            Title.MouseMove += DragWindow;
            // 
            // TopSepPanel
            // 
            TopSepPanel.Dock = DockStyle.Top;
            TopSepPanel.Location = new Point(40, 0);
            TopSepPanel.Name = "TopSepPanel";
            TopSepPanel.Size = new Size(245, 50);
            TopSepPanel.TabIndex = 1;
            TopSepPanel.MouseMove += DragWindow;
            // 
            // LeftSepPanel
            // 
            LeftSepPanel.Dock = DockStyle.Left;
            LeftSepPanel.Location = new Point(0, 0);
            LeftSepPanel.Name = "LeftSepPanel";
            LeftSepPanel.Size = new Size(40, 400);
            LeftSepPanel.TabIndex = 2;
            LeftSepPanel.MouseMove += DragWindow;
            // 
            // RightSepPanel
            // 
            RightSepPanel.Controls.Add(CloseApp);
            RightSepPanel.Dock = DockStyle.Right;
            RightSepPanel.Location = new Point(285, 0);
            RightSepPanel.Name = "RightSepPanel";
            RightSepPanel.Size = new Size(40, 400);
            RightSepPanel.TabIndex = 3;
            RightSepPanel.MouseMove += DragWindow;
            // 
            // CloseApp
            // 
            CloseApp.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            CloseApp.AutoSize = true;
            CloseApp.Cursor = Cursors.Hand;
            CloseApp.Font = new Font("Kollektif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            CloseApp.Location = new Point(12, 7);
            CloseApp.Name = "CloseApp";
            CloseApp.Size = new Size(23, 21);
            CloseApp.TabIndex = 0;
            CloseApp.Text = "X";
            CloseApp.Click += CloseRegister;
            CloseApp.MouseEnter += CloseApp_MouseEnter;
            CloseApp.MouseLeave += CloseApp_MouseLeave;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(50, 78, 205);
            ClientSize = new Size(325, 400);
            Controls.Add(LoginContainer);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            LoginContainer.ResumeLayout(false);
            RightSepPanel.ResumeLayout(false);
            RightSepPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel LoginContainer;
        private Label Title;
        private Panel TopSepPanel;
        private Panel panel5;
        private Label label1;
        private Panel panel4;
        private Panel LeftSepPanel;
        private Panel RightSepPanel;
        private Controls.WSTextBox UsernameTB;
        private Panel panel6;
        private Controls.WSTextBox EmailTB;
        private Panel panel7;
        private Controls.WSButton LoginButton;
        private Panel panel8;
        private Label CloseApp;
        private Label Credits;
        private Panel panel1;
        private Controls.WSTextBox PasswordTB;
    }
}