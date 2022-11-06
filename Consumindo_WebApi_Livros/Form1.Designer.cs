namespace Consumindo_WebApi_Produtos
{
    partial class Form1
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
            this.txtURI = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gdvDados = new System.Windows.Forms.DataGridView();
            this.btnDeletarLivro = new System.Windows.Forms.Button();
            this.btnAtualizaLivro = new System.Windows.Forms.Button();
            this.btnIncluirLivro = new System.Windows.Forms.Button();
            this.btnLivrosPorId = new System.Windows.Forms.Button();
            this.btnObterLivros = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gdvDados)).BeginInit();
            this.SuspendLayout();
            // 
            // txtURI
            // 
            this.txtURI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtURI.Location = new System.Drawing.Point(126, 19);
            this.txtURI.Name = "txtURI";
            this.txtURI.Size = new System.Drawing.Size(665, 22);
            this.txtURI.TabIndex = 11;
            this.txtURI.Text = "http://localhost:53557/api/livros";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "URI - Web API : ";
            // 
            // gdvDados
            // 
            this.gdvDados.BackgroundColor = System.Drawing.Color.White;
            this.gdvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdvDados.Location = new System.Drawing.Point(21, 53);
            this.gdvDados.Name = "gdvDados";
            this.gdvDados.Size = new System.Drawing.Size(770, 338);
            this.gdvDados.TabIndex = 9;
            // 
            // btnDeletarLivro
            // 
            this.btnDeletarLivro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDeletarLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletarLivro.Location = new System.Drawing.Point(642, 397);
            this.btnDeletarLivro.Name = "btnDeletarLivro";
            this.btnDeletarLivro.Size = new System.Drawing.Size(149, 44);
            this.btnDeletarLivro.TabIndex = 4;
            this.btnDeletarLivro.Text = "Deletar Livro";
            this.btnDeletarLivro.UseVisualStyleBackColor = false;
            this.btnDeletarLivro.Click += new System.EventHandler(this.btnDeletarLivro_Click);
            // 
            // btnAtualizaLivro
            // 
            this.btnAtualizaLivro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAtualizaLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizaLivro.Location = new System.Drawing.Point(487, 397);
            this.btnAtualizaLivro.Name = "btnAtualizaLivro";
            this.btnAtualizaLivro.Size = new System.Drawing.Size(149, 44);
            this.btnAtualizaLivro.TabIndex = 5;
            this.btnAtualizaLivro.Text = "Atualizar Livro";
            this.btnAtualizaLivro.UseVisualStyleBackColor = false;
            this.btnAtualizaLivro.Click += new System.EventHandler(this.btnAtualizaLivro_Click);
            // 
            // btnIncluirLivro
            // 
            this.btnIncluirLivro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnIncluirLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncluirLivro.Location = new System.Drawing.Point(332, 397);
            this.btnIncluirLivro.Name = "btnIncluirLivro";
            this.btnIncluirLivro.Size = new System.Drawing.Size(149, 44);
            this.btnIncluirLivro.TabIndex = 6;
            this.btnIncluirLivro.Text = "Incluir Livro";
            this.btnIncluirLivro.UseVisualStyleBackColor = false;
            this.btnIncluirLivro.Click += new System.EventHandler(this.btnIncluirLivro_Click);
            // 
            // btnLivrosPorId
            // 
            this.btnLivrosPorId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnLivrosPorId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLivrosPorId.Location = new System.Drawing.Point(177, 397);
            this.btnLivrosPorId.Name = "btnLivrosPorId";
            this.btnLivrosPorId.Size = new System.Drawing.Size(149, 44);
            this.btnLivrosPorId.TabIndex = 7;
            this.btnLivrosPorId.Text = "Obter Livro por ID";
            this.btnLivrosPorId.UseVisualStyleBackColor = false;
            this.btnLivrosPorId.Click += new System.EventHandler(this.btnLivrosPorId_Click);
            // 
            // btnObterLivros
            // 
            this.btnObterLivros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnObterLivros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObterLivros.Location = new System.Drawing.Point(22, 397);
            this.btnObterLivros.Name = "btnObterLivros";
            this.btnObterLivros.Size = new System.Drawing.Size(149, 44);
            this.btnObterLivros.TabIndex = 8;
            this.btnObterLivros.Text = "Retornar Livros";
            this.btnObterLivros.UseVisualStyleBackColor = false;
            this.btnObterLivros.Click += new System.EventHandler(this.btnObterLivros_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(813, 449);
            this.Controls.Add(this.txtURI);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gdvDados);
            this.Controls.Add(this.btnDeletarLivro);
            this.Controls.Add(this.btnAtualizaLivro);
            this.Controls.Add(this.btnIncluirLivro);
            this.Controls.Add(this.btnLivrosPorId);
            this.Controls.Add(this.btnObterLivros);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consumindo Web API";
            ((System.ComponentModel.ISupportInitialize)(this.gdvDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtURI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gdvDados;
        private System.Windows.Forms.Button btnDeletarLivro;
        private System.Windows.Forms.Button btnAtualizaLivro;
        private System.Windows.Forms.Button btnIncluirLivro;
        private System.Windows.Forms.Button btnLivrosPorId;
        private System.Windows.Forms.Button btnObterLivros;
    }
}

