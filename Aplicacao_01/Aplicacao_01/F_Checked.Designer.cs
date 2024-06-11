namespace Aplicacao_01
{
    partial class F_Checked
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
            this.cb_transportes = new System.Windows.Forms.CheckedListBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btn_selecionados = new System.Windows.Forms.Button();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.btn_rst = new System.Windows.Forms.Button();
            this.txt_novo = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cb_transportes
            // 
            this.cb_transportes.FormattingEnabled = true;
            this.cb_transportes.Items.AddRange(new object[] {
            "Carro",
            "Avião ",
            "Navio ",
            "Ônibus",
            "Trem"});
            this.cb_transportes.Location = new System.Drawing.Point(34, 12);
            this.cb_transportes.Name = "cb_transportes";
            this.cb_transportes.Size = new System.Drawing.Size(217, 169);
            this.cb_transportes.TabIndex = 0;
            // 
            // btn_selecionados
            // 
            this.btn_selecionados.Location = new System.Drawing.Point(257, 12);
            this.btn_selecionados.Name = "btn_selecionados";
            this.btn_selecionados.Size = new System.Drawing.Size(81, 23);
            this.btn_selecionados.TabIndex = 1;
            this.btn_selecionados.Text = "Selecionados";
            this.btn_selecionados.UseVisualStyleBackColor = true;
            this.btn_selecionados.Click += new System.EventHandler(this.btn_selecionados_Click);
            // 
            // btn_limpar
            // 
            this.btn_limpar.Location = new System.Drawing.Point(257, 41);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(81, 23);
            this.btn_limpar.TabIndex = 1;
            this.btn_limpar.Text = "Limpar ";
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // btn_rst
            // 
            this.btn_rst.Location = new System.Drawing.Point(257, 70);
            this.btn_rst.Name = "btn_rst";
            this.btn_rst.Size = new System.Drawing.Size(81, 23);
            this.btn_rst.TabIndex = 1;
            this.btn_rst.Text = "Reset";
            this.btn_rst.UseVisualStyleBackColor = true;
            this.btn_rst.Click += new System.EventHandler(this.btn_rst_Click);
            // 
            // txt_novo
            // 
            this.txt_novo.Location = new System.Drawing.Point(31, 212);
            this.txt_novo.Multiline = true;
            this.txt_novo.Name = "txt_novo";
            this.txt_novo.Size = new System.Drawing.Size(220, 31);
            this.txt_novo.TabIndex = 2;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(257, 208);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(81, 35);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "Adicionar";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Digite novo transporte: ";
            // 
            // F_Checked
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 255);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_novo);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_rst);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.btn_selecionados);
            this.Controls.Add(this.cb_transportes);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_Checked";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_Checked";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox cb_transportes;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btn_selecionados;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Button btn_rst;
        private System.Windows.Forms.TextBox txt_novo;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label label1;
    }
}