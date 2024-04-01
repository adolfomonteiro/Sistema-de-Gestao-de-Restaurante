namespace Restaurante
{
    partial class Pesquisar_Produtos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pesquisar_Produtos));
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new Guna.UI2.WinForms.Guna2TextBox();
            this.Pesquisar = new Guna.UI2.WinForms.Guna2Button();
            this.voltar = new System.Windows.Forms.PictureBox();
            this.dadosProduto = new System.Windows.Forms.DataGridView();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.voltar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dadosProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.BlueViolet;
            this.label1.Location = new System.Drawing.Point(218, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 45);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pesquisar Produto";
            // 
            // txtNome
            // 
            this.txtNome.BorderColor = System.Drawing.Color.BlueViolet;
            this.txtNome.BorderRadius = 20;
            this.txtNome.BorderThickness = 2;
            this.txtNome.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNome.DefaultText = "";
            this.txtNome.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNome.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNome.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNome.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNome.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.txtNome.ForeColor = System.Drawing.Color.Black;
            this.txtNome.HoverState.BorderColor = System.Drawing.Color.ForestGreen;
            this.txtNome.Location = new System.Drawing.Point(132, 114);
            this.txtNome.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.txtNome.Name = "txtNome";
            this.txtNome.PasswordChar = '\0';
            this.txtNome.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtNome.PlaceholderText = "Nome do Produto";
            this.txtNome.SelectedText = "";
            this.txtNome.Size = new System.Drawing.Size(476, 64);
            this.txtNome.TabIndex = 33;
            // 
            // Pesquisar
            // 
            this.Pesquisar.BackColor = System.Drawing.Color.Transparent;
            this.Pesquisar.BorderColor = System.Drawing.Color.Transparent;
            this.Pesquisar.BorderRadius = 20;
            this.Pesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Pesquisar.CustomBorderColor = System.Drawing.Color.Transparent;
            this.Pesquisar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Pesquisar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Pesquisar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Pesquisar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Pesquisar.FillColor = System.Drawing.Color.BlueViolet;
            this.Pesquisar.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.Pesquisar.ForeColor = System.Drawing.Color.White;
            this.Pesquisar.Image = ((System.Drawing.Image)(resources.GetObject("Pesquisar.Image")));
            this.Pesquisar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Pesquisar.ImageSize = new System.Drawing.Size(50, 50);
            this.Pesquisar.Location = new System.Drawing.Point(132, 190);
            this.Pesquisar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Pesquisar.Name = "Pesquisar";
            this.Pesquisar.Size = new System.Drawing.Size(476, 74);
            this.Pesquisar.TabIndex = 38;
            this.Pesquisar.Text = "Pesquisar";
            this.Pesquisar.Click += new System.EventHandler(this.Pesquisar_Click);
            // 
            // voltar
            // 
            this.voltar.BackColor = System.Drawing.Color.White;
            this.voltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.voltar.Image = ((System.Drawing.Image)(resources.GetObject("voltar.Image")));
            this.voltar.Location = new System.Drawing.Point(50, 551);
            this.voltar.Name = "voltar";
            this.voltar.Size = new System.Drawing.Size(55, 57);
            this.voltar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.voltar.TabIndex = 41;
            this.voltar.TabStop = false;
            this.voltar.Click += new System.EventHandler(this.voltar_Click);
            // 
            // dadosProduto
            // 
            this.dadosProduto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dadosProduto.BackgroundColor = System.Drawing.Color.White;
            this.dadosProduto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dadosProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dadosProduto.Location = new System.Drawing.Point(50, 293);
            this.dadosProduto.Name = "dadosProduto";
            this.dadosProduto.RowTemplate.Height = 33;
            this.dadosProduto.Size = new System.Drawing.Size(664, 233);
            this.dadosProduto.TabIndex = 40;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // Pesquisar_Produtos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(796, 649);
            this.Controls.Add(this.voltar);
            this.Controls.Add(this.dadosProduto);
            this.Controls.Add(this.Pesquisar);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Pesquisar_Produtos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisar_Produtos";
            this.Load += new System.EventHandler(this.Pesquisar_Produtos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.voltar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dadosProduto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtNome;
        private Guna.UI2.WinForms.Guna2Button Pesquisar;
        private System.Windows.Forms.PictureBox voltar;
        private System.Windows.Forms.DataGridView dadosProduto;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}