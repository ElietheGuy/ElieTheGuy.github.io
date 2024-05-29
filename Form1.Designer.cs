namespace MOBGAMEBLOG
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            label6 = new Label();
            label5 = new Label();
            login_showPass = new CheckBox();
            login_btn = new Button();
            login_password = new TextBox();
            label4 = new Label();
            login_username = new TextBox();
            label3 = new Label();
            label2 = new Label();
            exit = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 102, 0);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(222, 400);
            panel1.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(35, 61);
            label6.Name = "label6";
            label6.Size = new Size(148, 18);
            label6.TabIndex = 3;
            label6.Text = "ADMINISTRATION";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(35, 90);
            label5.Name = "label5";
            label5.Size = new Size(107, 18);
            label5.TabIndex = 2;
            label5.Text = "MOBGAMING";
            // 
            // login_showPass
            // 
            login_showPass.AutoSize = true;
            login_showPass.Cursor = Cursors.Hand;
            login_showPass.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login_showPass.ForeColor = Color.White;
            login_showPass.Location = new Point(398, 250);
            login_showPass.Name = "login_showPass";
            login_showPass.Size = new Size(146, 18);
            login_showPass.TabIndex = 15;
            login_showPass.Text = "Afficher mot de passe";
            login_showPass.UseVisualStyleBackColor = true;
            login_showPass.CheckedChanged += login_showPass_CheckedChanged;
            // 
            // login_btn
            // 
            login_btn.BackColor = Color.FromArgb(255, 102, 0);
            login_btn.Cursor = Cursors.Hand;
            login_btn.FlatAppearance.BorderSize = 0;
            login_btn.FlatAppearance.MouseDownBackColor = Color.Silver;
            login_btn.FlatAppearance.MouseOverBackColor = Color.Silver;
            login_btn.FlatStyle = FlatStyle.Flat;
            login_btn.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login_btn.ForeColor = Color.AliceBlue;
            login_btn.Location = new Point(278, 295);
            login_btn.Name = "login_btn";
            login_btn.Size = new Size(96, 36);
            login_btn.TabIndex = 14;
            login_btn.Text = "Connexion ";
            login_btn.UseVisualStyleBackColor = false;
            login_btn.Click += login_btn_Click;
            // 
            // login_password
            // 
            login_password.Location = new Point(278, 214);
            login_password.Multiline = true;
            login_password.Name = "login_password";
            login_password.PasswordChar = '*';
            login_password.Size = new Size(261, 30);
            login_password.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(278, 195);
            label4.Name = "label4";
            label4.Size = new Size(96, 16);
            label4.TabIndex = 12;
            label4.Text = "Mot de passe : ";
            // 
            // login_username
            // 
            login_username.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login_username.Location = new Point(278, 144);
            login_username.Multiline = true;
            login_username.Name = "login_username";
            login_username.Size = new Size(261, 30);
            login_username.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(278, 125);
            label3.Name = "label3";
            label3.Size = new Size(112, 16);
            label3.TabIndex = 10;
            label3.Text = "Nom d'utilisateur :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(278, 62);
            label2.Name = "label2";
            label2.Size = new Size(105, 22);
            label2.TabIndex = 9;
            label2.Text = "Connexion";
            // 
            // exit
            // 
            exit.AutoSize = true;
            exit.Cursor = Cursors.Hand;
            exit.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            exit.ForeColor = Color.White;
            exit.Location = new Point(546, 9);
            exit.Name = "exit";
            exit.Size = new Size(17, 18);
            exit.TabIndex = 16;
            exit.Text = "X";
            exit.Click += exit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(575, 400);
            Controls.Add(exit);
            Controls.Add(login_showPass);
            Controls.Add(login_btn);
            Controls.Add(login_password);
            Controls.Add(label4);
            Controls.Add(login_username);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label6;
        private Label label5;
        private CheckBox login_showPass;
        private Button login_btn;
        private TextBox login_password;
        private Label label4;
        private TextBox login_username;
        private Label label3;
        private Label label2;
        private Label exit;
    }
}
