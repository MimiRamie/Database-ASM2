namespace LoginLibrary
{
    partial class login
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
            btnLogin = new Button();
            lbAcc = new Label();
            lbPass = new Label();
            txtAcc = new TextBox();
            txtPass = new TextBox();
            btnExit = new Button();
            lbError = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(193, 422);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 29);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // lbAcc
            // 
            lbAcc.AutoSize = true;
            lbAcc.Location = new Point(172, 276);
            lbAcc.Name = "lbAcc";
            lbAcc.Size = new Size(63, 20);
            lbAcc.TabIndex = 1;
            lbAcc.Text = "Account";
            lbAcc.Click += Account_Click;
            // 
            // lbPass
            // 
            lbPass.AutoSize = true;
            lbPass.Location = new Point(172, 351);
            lbPass.Name = "lbPass";
            lbPass.Size = new Size(70, 20);
            lbPass.TabIndex = 2;
            lbPass.Text = "Password";
            // 
            // txtAcc
            // 
            txtAcc.Location = new Point(287, 273);
            txtAcc.Name = "txtAcc";
            txtAcc.Size = new Size(323, 27);
            txtAcc.TabIndex = 3;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(287, 348);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(323, 27);
            txtPass.TabIndex = 4;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(567, 422);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 5;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // lbError
            // 
            lbError.AutoSize = true;
            lbError.Location = new Point(287, 273);
            lbError.Name = "lbError";
            lbError.Size = new Size(0, 20);
            lbError.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._1144760;
            pictureBox1.Location = new Point(330, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(202, 152);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(393, 199);
            label1.Name = "label1";
            label1.Size = new Size(90, 38);
            label1.TabIndex = 8;
            label1.Text = "Login";
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(861, 500);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(lbError);
            Controls.Add(btnExit);
            Controls.Add(txtPass);
            Controls.Add(txtAcc);
            Controls.Add(lbPass);
            Controls.Add(lbAcc);
            Controls.Add(btnLogin);
            Name = "login";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private Label lbAcc;
        private Label lbPass;
        private TextBox txtAcc;
        private TextBox txtPass;
        private Button btnExit;
        private Label lbError;
        private PictureBox pictureBox1;
        private Label label1;
    }
}
