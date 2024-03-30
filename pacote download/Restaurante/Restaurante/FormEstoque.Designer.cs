namespace Restaurante
{
    partial class FormEstoque
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEstoque));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.Estoque = new System.Windows.Forms.Panel();
            this.dados = new System.Windows.Forms.DataGridView();
            this.voltar = new System.Windows.Forms.PictureBox();
            this.saida = new System.Windows.Forms.Label();
            this.entrada = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.total_vendido = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.dadosProduto = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.totalSaidas = new System.Windows.Forms.Label();
            this.Estoque.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.voltar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dadosProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // Estoque
            // 
            this.Estoque.BackColor = System.Drawing.Color.BlueViolet;
            this.Estoque.Controls.Add(this.totalSaidas);
            this.Estoque.Controls.Add(this.label3);
            this.Estoque.Controls.Add(this.label2);
            this.Estoque.Controls.Add(this.label1);
            this.Estoque.Controls.Add(this.dadosProduto);
            this.Estoque.Controls.Add(this.dados);
            this.Estoque.Controls.Add(this.voltar);
            this.Estoque.Controls.Add(this.saida);
            this.Estoque.Controls.Add(this.entrada);
            this.Estoque.Controls.Add(this.label34);
            this.Estoque.Controls.Add(this.label33);
            this.Estoque.Controls.Add(this.total_vendido);
            this.Estoque.Controls.Add(this.label32);
            this.Estoque.Location = new System.Drawing.Point(0, 0);
            this.Estoque.Name = "Estoque";
            this.Estoque.Size = new System.Drawing.Size(1163, 820);
            this.Estoque.TabIndex = 51;
            this.Estoque.Paint += new System.Windows.Forms.PaintEventHandler(this.Estoque_Paint);
            // 
            // dados
            // 
            this.dados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dados.BackgroundColor = System.Drawing.Color.White;
            this.dados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dados.Location = new System.Drawing.Point(34, 138);
            this.dados.Name = "dados";
            this.dados.RowTemplate.Height = 33;
            this.dados.Size = new System.Drawing.Size(476, 355);
            this.dados.TabIndex = 13;
            // 
            // voltar
            // 
            this.voltar.BackColor = System.Drawing.Color.BlueViolet;
            this.voltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.voltar.Image = ((System.Drawing.Image)(resources.GetObject("voltar.Image")));
            this.voltar.Location = new System.Drawing.Point(66, 657);
            this.voltar.Name = "voltar";
            this.voltar.Size = new System.Drawing.Size(55, 57);
            this.voltar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.voltar.TabIndex = 12;
            this.voltar.TabStop = false;
            this.voltar.Click += new System.EventHandler(this.voltar_Click);
            // 
            // saida
            // 
            this.saida.AutoSize = true;
            this.saida.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saida.ForeColor = System.Drawing.Color.Black;
            this.saida.Location = new System.Drawing.Point(154, 566);
            this.saida.Name = "saida";
            this.saida.Size = new System.Drawing.Size(58, 64);
            this.saida.TabIndex = 5;
            this.saida.Text = "0";
            // 
            // entrada
            // 
            this.entrada.AutoSize = true;
            this.entrada.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entrada.ForeColor = System.Drawing.Color.Black;
            this.entrada.Location = new System.Drawing.Point(693, 566);
            this.entrada.Name = "entrada";
            this.entrada.Size = new System.Drawing.Size(58, 64);
            this.entrada.TabIndex = 4;
            this.entrada.Text = "0";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.ForeColor = System.Drawing.Color.White;
            this.label34.Location = new System.Drawing.Point(103, 510);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(178, 56);
            this.label34.TabIndex = 3;
            this.label34.Text = "Saídas";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.ForeColor = System.Drawing.Color.White;
            this.label33.Location = new System.Drawing.Point(621, 510);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(224, 56);
            this.label33.TabIndex = 2;
            this.label33.Text = "Entradas";
            // 
            // total_vendido
            // 
            this.total_vendido.AutoSize = true;
            this.total_vendido.Location = new System.Drawing.Point(241, 165);
            this.total_vendido.Name = "total_vendido";
            this.total_vendido.Size = new System.Drawing.Size(0, 25);
            this.total_vendido.TabIndex = 1;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.ForeColor = System.Drawing.Color.White;
            this.label32.Location = new System.Drawing.Point(236, 9);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(484, 56);
            this.label32.TabIndex = 0;
            this.label32.Text = "Estoque Controlado";
            // 
            // dadosProduto
            // 
            this.dadosProduto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dadosProduto.BackgroundColor = System.Drawing.Color.White;
            this.dadosProduto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dadosProduto.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dadosProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dadosProduto.GridColor = System.Drawing.Color.DarkGray;
            this.dadosProduto.Location = new System.Drawing.Point(556, 138);
            this.dadosProduto.Name = "dadosProduto";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.BlueViolet;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dadosProduto.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dadosProduto.RowTemplate.Height = 33;
            this.dadosProduto.Size = new System.Drawing.Size(511, 355);
            this.dadosProduto.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(296, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 49);
            this.label1.TabIndex = 39;
            this.label1.Text = "Vendas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(654, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 49);
            this.label2.TabIndex = 40;
            this.label2.Text = "Produtos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(278, 574);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(376, 56);
            this.label3.TabIndex = 41;
            this.label3.Text = "Total de Saídas";
            // 
            // totalSaidas
            // 
            this.totalSaidas.AutoSize = true;
            this.totalSaidas.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalSaidas.ForeColor = System.Drawing.Color.Black;
            this.totalSaidas.Location = new System.Drawing.Point(924, 566);
            this.totalSaidas.Name = "totalSaidas";
            this.totalSaidas.Size = new System.Drawing.Size(58, 64);
            this.totalSaidas.TabIndex = 42;
            this.totalSaidas.Text = "0";
            // 
            // FormEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1164, 821);
            this.Controls.Add(this.Estoque);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormEstoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormEstoque";
            this.Load += new System.EventHandler(this.FormEstoque_Load);
            this.Estoque.ResumeLayout(false);
            this.Estoque.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.voltar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dadosProduto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Panel Estoque;
        private System.Windows.Forms.Label saida;
        private System.Windows.Forms.Label entrada;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label total_vendido;
        private System.Windows.Forms.PictureBox voltar;
        private System.Windows.Forms.DataGridView dados;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dadosProduto;
        private System.Windows.Forms.Label totalSaidas;
        private System.Windows.Forms.Label label3;
    }
}