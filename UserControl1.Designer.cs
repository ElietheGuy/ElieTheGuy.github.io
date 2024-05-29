namespace MOBGAMEBLOG
{
    partial class UserControl1
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            panel1 = new Panel();
            addUser_role = new ComboBox();
            label4 = new Label();
            clear_btn = new Button();
            label3 = new Label();
            delete_btn = new Button();
            label2 = new Label();
            update_btn = new Button();
            label6 = new Label();
            add_btn = new Button();
            addUser_id = new TextBox();
            addUser_email = new TextBox();
            addUser_password = new TextBox();
            label5 = new Label();
            addUser_fullname = new TextBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(36, 36);
            panel2.Name = "panel2";
            panel2.Size = new Size(802, 252);
            panel2.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 102, 0);
            dataGridViewCellStyle1.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(255, 102, 0);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(49, 59);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Size = new Size(697, 165);
            dataGridView1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(49, 14);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 0;
            label1.Text = "Utilisateurs";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(addUser_role);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(clear_btn);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(delete_btn);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(update_btn);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(add_btn);
            panel1.Controls.Add(addUser_id);
            panel1.Controls.Add(addUser_email);
            panel1.Controls.Add(addUser_password);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(addUser_fullname);
            panel1.Location = new Point(36, 306);
            panel1.Name = "panel1";
            panel1.Size = new Size(802, 223);
            panel1.TabIndex = 2;
            // 
            // addUser_role
            // 
            addUser_role.FormattingEnabled = true;
            addUser_role.Items.AddRange(new object[] { "admin", "user" });
            addUser_role.Location = new Point(288, 156);
            addUser_role.Name = "addUser_role";
            addUser_role.Size = new Size(121, 23);
            addUser_role.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(288, 22);
            label4.Name = "label4";
            label4.Size = new Size(83, 16);
            label4.TabIndex = 4;
            label4.Text = "Mot de passe";
            // 
            // clear_btn
            // 
            clear_btn.BackColor = Color.FromArgb(255, 102, 0);
            clear_btn.ForeColor = Color.White;
            clear_btn.Location = new Point(667, 112);
            clear_btn.Name = "clear_btn";
            clear_btn.Size = new Size(102, 47);
            clear_btn.TabIndex = 11;
            clear_btn.Text = "Vider";
            clear_btn.UseVisualStyleBackColor = false;
            clear_btn.Click += clear_btn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(288, 76);
            label3.Name = "label3";
            label3.Size = new Size(38, 16);
            label3.TabIndex = 2;
            label3.Text = "Email";
            // 
            // delete_btn
            // 
            delete_btn.BackColor = Color.FromArgb(255, 102, 0);
            delete_btn.ForeColor = Color.White;
            delete_btn.Location = new Point(545, 112);
            delete_btn.Name = "delete_btn";
            delete_btn.Size = new Size(102, 47);
            delete_btn.TabIndex = 10;
            delete_btn.Text = "Supprimer";
            delete_btn.UseVisualStyleBackColor = false;
            delete_btn.Click += delete_btn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(21, 22);
            label2.Name = "label2";
            label2.Size = new Size(80, 16);
            label2.TabIndex = 0;
            label2.Text = "ID Utilisateur";
            // 
            // update_btn
            // 
            update_btn.BackColor = Color.FromArgb(255, 102, 0);
            update_btn.ForeColor = Color.White;
            update_btn.Location = new Point(667, 41);
            update_btn.Name = "update_btn";
            update_btn.Size = new Size(102, 47);
            update_btn.TabIndex = 9;
            update_btn.Text = "Modifier";
            update_btn.UseVisualStyleBackColor = false;
            update_btn.Click += update_btn_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(288, 137);
            label6.Name = "label6";
            label6.Size = new Size(38, 16);
            label6.TabIndex = 13;
            label6.Text = "Rôles";
            // 
            // add_btn
            // 
            add_btn.BackColor = Color.FromArgb(255, 102, 0);
            add_btn.ForeColor = Color.White;
            add_btn.Location = new Point(546, 41);
            add_btn.Name = "add_btn";
            add_btn.Size = new Size(102, 47);
            add_btn.TabIndex = 8;
            add_btn.Text = "Ajouter";
            add_btn.UseVisualStyleBackColor = false;
            add_btn.Click += add_btn_Click;
            // 
            // addUser_id
            // 
            addUser_id.Location = new Point(21, 41);
            addUser_id.Name = "addUser_id";
            addUser_id.Size = new Size(224, 23);
            addUser_id.TabIndex = 1;
            // 
            // addUser_email
            // 
            addUser_email.Location = new Point(288, 95);
            addUser_email.Name = "addUser_email";
            addUser_email.Size = new Size(224, 23);
            addUser_email.TabIndex = 3;
            // 
            // addUser_password
            // 
            addUser_password.Location = new Point(288, 41);
            addUser_password.Name = "addUser_password";
            addUser_password.Size = new Size(224, 23);
            addUser_password.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(20, 76);
            label5.Name = "label5";
            label5.Size = new Size(103, 16);
            label5.TabIndex = 6;
            label5.Text = "Nom d'utilisateur";
            // 
            // addUser_fullname
            // 
            addUser_fullname.Location = new Point(20, 95);
            addUser_fullname.Name = "addUser_fullname";
            addUser_fullname.Size = new Size(224, 23);
            addUser_fullname.TabIndex = 7;
            // 
            // UserControl1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "UserControl1";
            Size = new Size(875, 565);
            Load += UserControl1_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private DataGridView dataGridView1;
        private Label label1;
        private Panel panel1;
        private ComboBox addUser_role;
        private Label label4;
        private Button clear_btn;
        private Label label3;
        private Button delete_btn;
        private Label label2;
        private Button update_btn;
        private Label label6;
        private Button add_btn;
        private TextBox addUser_id;
        private TextBox addUser_email;
        private TextBox addUser_password;
        private Label label5;
        private TextBox addUser_fullname;
    }
}
