namespace Aplicacao
{
    partial class Home
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txb_inicial = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btn_add = new System.Windows.Forms.Button();
            this.txb_lista_nomes = new System.Windows.Forms.TextBox();
            this.btn_del = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txb_inicial
            // 
            this.txb_inicial.Location = new System.Drawing.Point(12, 12);
            this.txb_inicial.Name = "txb_inicial";
            this.txb_inicial.Size = new System.Drawing.Size(150, 20);
            this.txb_inicial.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(169, 12);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 3;
            this.btn_add.Text = "ADD";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_confirma_Click);
            // 
            // txb_lista_nomes
            // 
            this.txb_lista_nomes.Location = new System.Drawing.Point(12, 54);
            this.txb_lista_nomes.Multiline = true;
            this.txb_lista_nomes.Name = "txb_lista_nomes";
            this.txb_lista_nomes.Size = new System.Drawing.Size(250, 179);
            this.txb_lista_nomes.TabIndex = 4;
            // 
            // btn_del
            // 
            this.btn_del.Location = new System.Drawing.Point(250, 12);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(75, 23);
            this.btn_del.TabIndex = 3;
            this.btn_del.Text = "DEL";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_confirma_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 245);
            this.Controls.Add(this.txb_lista_nomes);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txb_inicial);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Click += new System.EventHandler(this.btn_confirma_Click);
            this.DoubleClick += new System.EventHandler(this.btn_confirma_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txb_inicial;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox txb_lista_nomes;
        private System.Windows.Forms.Button btn_del;
    }
}

