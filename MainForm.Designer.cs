namespace MOBGAMEBLOG
{
    partial class MainForm
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
            panel1 = new Panel();
            label2 = new Label();
            exit = new Label();
            panel2 = new Panel();
            logout_btn = new Button();
            addUser_btn = new Button();
            dashboard_btn = new Button();
            article_btn = new Button();
            greet_user = new Label();
            panel3 = new Panel();
            userControl1 = new UserControl1();
            article_Commentaire1 = new Article_Commentaire();
            dashboard1 = new Dashboard();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(exit);
            panel1.Dock = DockStyle.Top;
            panel1.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.ForeColor = SystemColors.ButtonHighlight;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1100, 63);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 20);
            label2.Name = "label2";
            label2.Size = new Size(151, 14);
            label2.TabIndex = 2;
            label2.Text = "Administration M0BGaming";
            label2.Click += label2_Click;
            // 
            // exit
            // 
            exit.AutoSize = true;
            exit.Cursor = Cursors.Hand;
            exit.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            exit.ForeColor = Color.White;
            exit.Location = new Point(1072, 20);
            exit.Name = "exit";
            exit.Size = new Size(15, 16);
            exit.TabIndex = 1;
            exit.Text = "X";
            exit.Click += exit_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 102, 0);
            panel2.Controls.Add(logout_btn);
            panel2.Controls.Add(addUser_btn);
            panel2.Controls.Add(dashboard_btn);
            panel2.Controls.Add(article_btn);
            panel2.Controls.Add(greet_user);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 63);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 577);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // logout_btn
            // 
            logout_btn.BackColor = Color.Black;
            logout_btn.Cursor = Cursors.Hand;
            logout_btn.FlatAppearance.MouseDownBackColor = Color.DimGray;
            logout_btn.FlatAppearance.MouseOverBackColor = Color.DimGray;
            logout_btn.FlatStyle = FlatStyle.Flat;
            logout_btn.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            logout_btn.ForeColor = Color.White;
            logout_btn.Location = new Point(13, 526);
            logout_btn.Name = "logout_btn";
            logout_btn.Size = new Size(103, 28);
            logout_btn.TabIndex = 13;
            logout_btn.Text = "Déconnexion";
            logout_btn.UseVisualStyleBackColor = false;
            logout_btn.Click += logout_btn_Click;
            // 
            // addUser_btn
            // 
            addUser_btn.BackColor = Color.Black;
            addUser_btn.Cursor = Cursors.Hand;
            addUser_btn.FlatAppearance.MouseDownBackColor = Color.DimGray;
            addUser_btn.FlatAppearance.MouseOverBackColor = Color.DimGray;
            addUser_btn.FlatStyle = FlatStyle.Flat;
            addUser_btn.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addUser_btn.ForeColor = Color.White;
            addUser_btn.Location = new Point(13, 213);
            addUser_btn.Name = "addUser_btn";
            addUser_btn.Size = new Size(171, 40);
            addUser_btn.TabIndex = 12;
            addUser_btn.Text = "Gestion Utilisateurs";
            addUser_btn.UseVisualStyleBackColor = false;
            addUser_btn.Click += addUser_btn_Click;
            // 
            // dashboard_btn
            // 
            dashboard_btn.BackColor = Color.Black;
            dashboard_btn.Cursor = Cursors.Hand;
            dashboard_btn.FlatAppearance.MouseDownBackColor = Color.DimGray;
            dashboard_btn.FlatAppearance.MouseOverBackColor = Color.DimGray;
            dashboard_btn.FlatStyle = FlatStyle.Flat;
            dashboard_btn.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dashboard_btn.ForeColor = Color.White;
            dashboard_btn.Location = new Point(12, 136);
            dashboard_btn.Name = "dashboard_btn";
            dashboard_btn.Size = new Size(171, 40);
            dashboard_btn.TabIndex = 11;
            dashboard_btn.Text = "Tableau de Bord";
            dashboard_btn.UseVisualStyleBackColor = false;
            dashboard_btn.Click += dashboard_btn_Click;
            // 
            // article_btn
            // 
            article_btn.BackColor = Color.Black;
            article_btn.Cursor = Cursors.Hand;
            article_btn.FlatAppearance.MouseDownBackColor = Color.DimGray;
            article_btn.FlatAppearance.MouseOverBackColor = Color.DimGray;
            article_btn.FlatStyle = FlatStyle.Flat;
            article_btn.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            article_btn.ForeColor = Color.White;
            article_btn.Location = new Point(12, 286);
            article_btn.Name = "article_btn";
            article_btn.Size = new Size(171, 40);
            article_btn.TabIndex = 10;
            article_btn.Text = "Gestion Articles et Commentaires";
            article_btn.UseVisualStyleBackColor = false;
            article_btn.Click += article_btn_Click;
            // 
            // greet_user
            // 
            greet_user.AutoSize = true;
            greet_user.ForeColor = Color.White;
            greet_user.Location = new Point(12, 59);
            greet_user.Name = "greet_user";
            greet_user.Size = new Size(135, 15);
            greet_user.TabIndex = 9;
            greet_user.Text = "Bienvenu Adminstrateur";
            // 
            // panel3
            // 
            panel3.Location = new Point(206, 63);
            panel3.Name = "panel3";
            panel3.Size = new Size(0, 0);
            panel3.TabIndex = 4;
            // 
            // userControl1
            // 
            userControl1.Location = new Point(213, 63);
            userControl1.Name = "userControl1";
            userControl1.Size = new Size(875, 565);
            userControl1.TabIndex = 6;
            // 
            // article_Commentaire1
            // 
            article_Commentaire1.Location = new Point(213, 63);
            article_Commentaire1.Name = "article_Commentaire1";
            article_Commentaire1.Size = new Size(875, 565);
            article_Commentaire1.TabIndex = 7;
            // 
            // dashboard1
            // 
            dashboard1.Location = new Point(212, 63);
            dashboard1.Name = "dashboard1";
            dashboard1.Size = new Size(875, 565);
            dashboard1.TabIndex = 9;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 640);
            Controls.Add(dashboard1);
            Controls.Add(article_Commentaire1);
            Controls.Add(userControl1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button addUser_btn;
        private Button dashboard_btn;
        private Button article_btn;
        private Label greet_user;
        private Label label2;
        private Label exit;
        private Button logout_btn;
        private Panel panel3;
        private UserControl1 userControl1;
        private Article_Commentaire article_Commentaire1;
        private Dashboard dashboard1;
    }
}