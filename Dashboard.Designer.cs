namespace MOBGAMEBLOG
{
    partial class Dashboard
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
            panel4 = new Panel();
            panel6 = new Panel();
            label5 = new Label();
            label6 = new Label();
            panel7 = new Panel();
            label7 = new Label();
            label8 = new Label();
            panel5 = new Panel();
            label4 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            panel4.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel4
            // 
            panel4.BackColor = Color.Black;
            panel4.Controls.Add(panel6);
            panel4.Controls.Add(panel7);
            panel4.Controls.Add(panel5);
            panel4.Location = new Point(83, 39);
            panel4.Name = "panel4";
            panel4.Size = new Size(709, 146);
            panel4.TabIndex = 3;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(255, 102, 0);
            panel6.Controls.Add(label5);
            panel6.Controls.Add(label6);
            panel6.Cursor = Cursors.Hand;
            panel6.Location = new Point(474, 18);
            panel6.Name = "panel6";
            panel6.Size = new Size(200, 100);
            panel6.TabIndex = 2;
            panel6.Click += panel6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(84, 39);
            label5.Name = "label5";
            label5.Size = new Size(23, 25);
            label5.TabIndex = 1;
            label5.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(18, 12);
            label6.Name = "label6";
            label6.Size = new Size(85, 15);
            label6.TabIndex = 0;
            label6.Text = "Commentaires";
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(255, 102, 0);
            panel7.Controls.Add(label7);
            panel7.Controls.Add(label8);
            panel7.Cursor = Cursors.Hand;
            panel7.Location = new Point(248, 18);
            panel7.Name = "panel7";
            panel7.Size = new Size(200, 100);
            panel7.TabIndex = 2;
            panel7.Click += panel7_Click;
            panel7.Paint += panel7_Paint;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(84, 39);
            label7.Name = "label7";
            label7.Size = new Size(23, 25);
            label7.TabIndex = 1;
            label7.Text = "0";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(18, 12);
            label8.Name = "label8";
            label8.Size = new Size(46, 15);
            label8.TabIndex = 0;
            label8.Text = "Articles";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(255, 102, 0);
            panel5.Controls.Add(label4);
            panel5.Controls.Add(label1);
            panel5.Cursor = Cursors.Hand;
            panel5.Location = new Point(31, 18);
            panel5.Name = "panel5";
            panel5.Size = new Size(200, 100);
            panel5.TabIndex = 0;
            panel5.Click += panel5_Click;
            panel5.Paint += panel5_Paint;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(84, 39);
            label4.Name = "label4";
            label4.Size = new Size(23, 25);
            label4.TabIndex = 1;
            label4.Text = "0";
            label4.Click += label4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 12);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 0;
            label1.Text = "Utilisateurs";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 102, 0);
            dataGridViewCellStyle1.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(31, 41);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Size = new Size(643, 172);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(83, 213);
            panel1.Name = "panel1";
            panel1.Size = new Size(709, 268);
            panel1.TabIndex = 4;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(panel4);
            Name = "Dashboard";
            Size = new Size(875, 565);
            Load += Dashboard_Load;
            panel4.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel4;
        private Panel panel6;
        private Label label5;
        private Label label6;
        private Panel panel7;
        private Label label7;
        private Label label8;
        private Panel panel5;
        private Label label4;
        private Label label1;
        private DataGridView dataGridView1;
        private Panel panel1;
    }
}
