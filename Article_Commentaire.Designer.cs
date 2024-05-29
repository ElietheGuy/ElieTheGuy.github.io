namespace MOBGAMEBLOG
{
    partial class Article_Commentaire
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            deleteArticle_btn = new Button();
            label2 = new Label();
            id_article = new TextBox();
            panel1 = new Panel();
            dataGridView2 = new DataGridView();
            label3 = new Label();
            deleteComm_btn = new Button();
            label4 = new Label();
            id_comment = new TextBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(deleteArticle_btn);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(id_article);
            panel2.Location = new Point(35, 32);
            panel2.Name = "panel2";
            panel2.Size = new Size(802, 235);
            panel2.TabIndex = 5;
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
            dataGridView1.Location = new Point(26, 59);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Size = new Size(632, 139);
            dataGridView1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(26, 15);
            label1.Name = "label1";
            label1.Size = new Size(69, 23);
            label1.TabIndex = 0;
            label1.Text = "Articles";
            // 
            // deleteArticle_btn
            // 
            deleteArticle_btn.BackColor = Color.FromArgb(255, 102, 0);
            deleteArticle_btn.FlatStyle = FlatStyle.Flat;
            deleteArticle_btn.ForeColor = Color.White;
            deleteArticle_btn.Location = new Point(680, 123);
            deleteArticle_btn.Name = "deleteArticle_btn";
            deleteArticle_btn.Size = new Size(102, 47);
            deleteArticle_btn.TabIndex = 10;
            deleteArticle_btn.Text = "Supprimer";
            deleteArticle_btn.UseVisualStyleBackColor = false;
            deleteArticle_btn.Click += deleteArticle_btn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(680, 59);
            label2.Name = "label2";
            label2.Size = new Size(19, 16);
            label2.TabIndex = 0;
            label2.Text = "ID";
            label2.Click += label2_Click;
            // 
            // id_article
            // 
            id_article.Location = new Point(680, 78);
            id_article.Name = "id_article";
            id_article.Size = new Size(37, 23);
            id_article.TabIndex = 1;
            id_article.TextChanged += id_article_TextChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(dataGridView2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(deleteComm_btn);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(id_comment);
            panel1.Location = new Point(35, 289);
            panel1.Name = "panel1";
            panel1.Size = new Size(802, 235);
            panel1.TabIndex = 11;
            // 
            // dataGridView2
            // 
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(255, 102, 0);
            dataGridViewCellStyle3.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(255, 102, 0);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.EnableHeadersVisualStyles = false;
            dataGridView2.Location = new Point(26, 59);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersVisible = false;
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridView2.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView2.Size = new Size(632, 139);
            dataGridView2.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(26, 18);
            label3.Name = "label3";
            label3.Size = new Size(129, 23);
            label3.TabIndex = 0;
            label3.Text = "Commentaires";
            // 
            // deleteComm_btn
            // 
            deleteComm_btn.BackColor = Color.FromArgb(255, 102, 0);
            deleteComm_btn.FlatStyle = FlatStyle.Flat;
            deleteComm_btn.ForeColor = Color.White;
            deleteComm_btn.Location = new Point(680, 123);
            deleteComm_btn.Name = "deleteComm_btn";
            deleteComm_btn.Size = new Size(102, 47);
            deleteComm_btn.TabIndex = 10;
            deleteComm_btn.Text = "Supprimer";
            deleteComm_btn.UseVisualStyleBackColor = false;
            deleteComm_btn.Click += deleteComm_btn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(680, 59);
            label4.Name = "label4";
            label4.Size = new Size(19, 16);
            label4.TabIndex = 0;
            label4.Text = "ID";
            // 
            // id_comment
            // 
            id_comment.Location = new Point(680, 78);
            id_comment.Name = "id_comment";
            id_comment.Size = new Size(37, 23);
            id_comment.TabIndex = 1;
            // 
            // Article_Commentaire
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "Article_Commentaire";
            Size = new Size(875, 565);
            Load += Article_Commentaire_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private DataGridView dataGridView1;
        private Label label1;
        private Button deleteArticle_btn;
        private Label label2;
        private TextBox id_article;
        private Panel panel1;
        private DataGridView dataGridView2;
        private Label label3;
        private Button deleteComm_btn;
        private Label label4;
        private TextBox id_comment;
    }
}
