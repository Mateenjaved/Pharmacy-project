namespace Pharmacy_project
{
    partial class Form1
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            btnExit = new Guna.UI2.WinForms.Guna2Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel3 = new Panel();
            label2 = new Label();
            label3 = new Label();
            txtusername = new Guna.UI2.WinForms.Guna2TextBox();
            txtpassword = new Guna.UI2.WinForms.Guna2TextBox();
            btnSignIn = new Guna.UI2.WinForms.Guna2Button();
            btnReset = new Guna.UI2.WinForms.Guna2Button();
            label4 = new Label();
            pictureBox2 = new PictureBox();
            panel4 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MistyRose;
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1521, 324);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // btnExit
            // 
            btnExit.CustomizableEdges = customizableEdges1;
            btnExit.DisabledState.BorderColor = Color.DarkGray;
            btnExit.DisabledState.CustomBorderColor = Color.DarkGray;
            btnExit.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnExit.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnExit.FillColor = Color.MistyRose;
            btnExit.Font = new Font("Segoe UI", 9F);
            btnExit.ForeColor = Color.White;
            btnExit.Image = (Image)resources.GetObject("btnExit.Image");
            btnExit.ImageSize = new Size(30, 30);
            btnExit.Location = new Point(1468, 0);
            btnExit.Name = "btnExit";
            btnExit.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnExit.Size = new Size(50, 50);
            btnExit.TabIndex = 2;
            btnExit.Click += guna2Button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.pngtree_medical_cross_and_health_pharmacy_logo_vector_template_png_image_4296557_removebg_preview;
            pictureBox1.Location = new Point(302, 54);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(249, 216);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 19F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(557, 139);
            label1.Name = "label1";
            label1.Size = new Size(456, 30);
            label1.TabIndex = 0;
            label1.Text = "PHARMACY MANAGEMENT SYSTEM";
            label1.Click += label1_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(255, 224, 192);
            panel3.Location = new Point(-2, 328);
            panel3.Name = "panel3";
            panel3.Size = new Size(1518, 4);
            panel3.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(234, 641);
            label2.Name = "label2";
            label2.Size = new Size(84, 30);
            label2.TabIndex = 2;
            label2.Text = "Sign In";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 14F, FontStyle.Italic);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(701, 485);
            label3.Name = "label3";
            label3.Size = new Size(95, 23);
            label3.TabIndex = 3;
            label3.Text = "User Name";
            // 
            // txtusername
            // 
            txtusername.CustomizableEdges = customizableEdges3;
            txtusername.DefaultText = "";
            txtusername.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtusername.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtusername.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtusername.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtusername.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtusername.Font = new Font("Segoe UI", 11F);
            txtusername.ForeColor = Color.Black;
            txtusername.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtusername.Location = new Point(868, 485);
            txtusername.Margin = new Padding(5, 6, 5, 6);
            txtusername.Name = "txtusername";
            txtusername.PasswordChar = '\0';
            txtusername.PlaceholderText = "";
            txtusername.SelectedText = "";
            txtusername.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtusername.Size = new Size(344, 36);
            txtusername.TabIndex = 4;
            txtusername.TextChanged += guna2TextBox1_TextChanged;
            // 
            // txtpassword
            // 
            txtpassword.CustomizableEdges = customizableEdges5;
            txtpassword.DefaultText = "";
            txtpassword.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtpassword.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtpassword.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtpassword.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtpassword.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtpassword.Font = new Font("Segoe UI", 11F);
            txtpassword.ForeColor = Color.Black;
            txtpassword.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtpassword.Location = new Point(868, 576);
            txtpassword.Margin = new Padding(5, 6, 5, 6);
            txtpassword.Name = "txtpassword";
            txtpassword.PasswordChar = '*';
            txtpassword.PlaceholderText = "";
            txtpassword.SelectedText = "";
            txtpassword.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtpassword.Size = new Size(344, 36);
            txtpassword.TabIndex = 5;
            // 
            // btnSignIn
            // 
            btnSignIn.BorderRadius = 20;
            btnSignIn.BorderThickness = 1;
            btnSignIn.CustomizableEdges = customizableEdges7;
            btnSignIn.DisabledState.BorderColor = Color.DarkGray;
            btnSignIn.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSignIn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSignIn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSignIn.FillColor = Color.FromArgb(0, 118, 225);
            btnSignIn.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnSignIn.ForeColor = Color.White;
            btnSignIn.HoverState.BorderColor = Color.Black;
            btnSignIn.HoverState.FillColor = Color.White;
            btnSignIn.HoverState.ForeColor = Color.FromArgb(0, 118, 225);
            btnSignIn.Image = (Image)resources.GetObject("btnSignIn.Image");
            btnSignIn.ImageSize = new Size(40, 40);
            btnSignIn.Location = new Point(870, 664);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnSignIn.Size = new Size(167, 44);
            btnSignIn.TabIndex = 6;
            btnSignIn.Text = "Sign In";
            btnSignIn.Click += btnSignIn_Click;
            // 
            // btnReset
            // 
            btnReset.BorderRadius = 20;
            btnReset.BorderThickness = 1;
            btnReset.CustomizableEdges = customizableEdges9;
            btnReset.DisabledState.BorderColor = Color.DarkGray;
            btnReset.DisabledState.CustomBorderColor = Color.DarkGray;
            btnReset.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnReset.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnReset.FillColor = Color.FromArgb(0, 118, 225);
            btnReset.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnReset.ForeColor = Color.White;
            btnReset.HoverState.BorderColor = Color.Black;
            btnReset.HoverState.FillColor = Color.White;
            btnReset.HoverState.ForeColor = Color.FromArgb(0, 118, 225);
            btnReset.Image = (Image)resources.GetObject("btnReset.Image");
            btnReset.ImageSize = new Size(30, 30);
            btnReset.Location = new Point(1059, 664);
            btnReset.Name = "btnReset";
            btnReset.ShadowDecoration.CustomizableEdges = customizableEdges10;
            btnReset.Size = new Size(167, 44);
            btnReset.TabIndex = 7;
            btnReset.Text = "Reset";
            btnReset.Click += btnReset_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 14F, FontStyle.Italic);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(701, 567);
            label4.Name = "label4";
            label4.Size = new Size(85, 23);
            label4.TabIndex = 8;
            label4.Text = "Password";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(209, 467);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(182, 171);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(128, 128, 255);
            panel4.Location = new Point(548, 403);
            panel4.Name = "panel4";
            panel4.Size = new Size(3, 350);
            panel4.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1366, 768);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Controls.Add(pictureBox2);
            Controls.Add(label4);
            Controls.Add(btnReset);
            Controls.Add(btnSignIn);
            Controls.Add(txtpassword);
            Controls.Add(txtusername);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Font = new Font("Calibri", 11F, FontStyle.Italic);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button btnExit;
        private Label label2;
        private Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtusername;
        private Guna.UI2.WinForms.Guna2TextBox txtpassword;
        private Guna.UI2.WinForms.Guna2Button btnSignIn;
        private Guna.UI2.WinForms.Guna2Button btnReset;
        private Label label4;
        private PictureBox pictureBox2;
        private Panel panel3;
        private Panel panel4;
    }
}
