﻿namespace Restaurante
{
    partial class AdicionarProdutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdicionarProdutos));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtCategoria = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSubcategoria = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPreco = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtQuantidade = new Guna.UI2.WinForms.Guna2TextBox();
            this.dadosProduto = new System.Windows.Forms.DataGridView();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.Adicionar = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dadosProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(548, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(373, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adicionar Produtos";
            // 
            // txtNome
            // 
            this.txtNome.BorderColor = System.Drawing.Color.Gray;
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
            this.txtNome.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNome.Location = new System.Drawing.Point(61, 109);
            this.txtNome.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.txtNome.Name = "txtNome";
            this.txtNome.PasswordChar = '\0';
            this.txtNome.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtNome.PlaceholderText = "Nome do Produto";
            this.txtNome.SelectedText = "";
            this.txtNome.Size = new System.Drawing.Size(420, 64);
            this.txtNome.TabIndex = 31;
            // 
            // txtCategoria
            // 
            this.txtCategoria.BorderColor = System.Drawing.Color.Gray;
            this.txtCategoria.BorderRadius = 20;
            this.txtCategoria.BorderThickness = 2;
            this.txtCategoria.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCategoria.DefaultText = "";
            this.txtCategoria.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCategoria.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCategoria.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCategoria.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCategoria.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCategoria.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.txtCategoria.ForeColor = System.Drawing.Color.Black;
            this.txtCategoria.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCategoria.Location = new System.Drawing.Point(61, 187);
            this.txtCategoria.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.PasswordChar = '\0';
            this.txtCategoria.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtCategoria.PlaceholderText = "Categoria";
            this.txtCategoria.SelectedText = "";
            this.txtCategoria.Size = new System.Drawing.Size(420, 71);
            this.txtCategoria.TabIndex = 32;
            // 
            // txtSubcategoria
            // 
            this.txtSubcategoria.BorderColor = System.Drawing.Color.Gray;
            this.txtSubcategoria.BorderRadius = 20;
            this.txtSubcategoria.BorderThickness = 2;
            this.txtSubcategoria.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSubcategoria.DefaultText = "";
            this.txtSubcategoria.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSubcategoria.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSubcategoria.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSubcategoria.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSubcategoria.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSubcategoria.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.txtSubcategoria.ForeColor = System.Drawing.Color.Black;
            this.txtSubcategoria.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSubcategoria.Location = new System.Drawing.Point(61, 265);
            this.txtSubcategoria.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.txtSubcategoria.Name = "txtSubcategoria";
            this.txtSubcategoria.PasswordChar = '\0';
            this.txtSubcategoria.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtSubcategoria.PlaceholderText = "SubCategoria";
            this.txtSubcategoria.SelectedText = "";
            this.txtSubcategoria.Size = new System.Drawing.Size(420, 64);
            this.txtSubcategoria.TabIndex = 33;
            // 
            // txtPreco
            // 
            this.txtPreco.BorderColor = System.Drawing.Color.Gray;
            this.txtPreco.BorderRadius = 20;
            this.txtPreco.BorderThickness = 2;
            this.txtPreco.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPreco.DefaultText = "";
            this.txtPreco.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPreco.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPreco.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPreco.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPreco.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPreco.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.txtPreco.ForeColor = System.Drawing.Color.Black;
            this.txtPreco.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPreco.Location = new System.Drawing.Point(61, 343);
            this.txtPreco.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.PasswordChar = '\0';
            this.txtPreco.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtPreco.PlaceholderText = "Preço";
            this.txtPreco.SelectedText = "";
            this.txtPreco.Size = new System.Drawing.Size(420, 64);
            this.txtPreco.TabIndex = 34;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.BorderColor = System.Drawing.Color.Gray;
            this.txtQuantidade.BorderRadius = 20;
            this.txtQuantidade.BorderThickness = 2;
            this.txtQuantidade.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQuantidade.DefaultText = "";
            this.txtQuantidade.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtQuantidade.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtQuantidade.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQuantidade.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQuantidade.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQuantidade.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.txtQuantidade.ForeColor = System.Drawing.Color.Black;
            this.txtQuantidade.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQuantidade.Location = new System.Drawing.Point(61, 421);
            this.txtQuantidade.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.PasswordChar = '\0';
            this.txtQuantidade.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtQuantidade.PlaceholderText = "Quantidade";
            this.txtQuantidade.SelectedText = "";
            this.txtQuantidade.Size = new System.Drawing.Size(420, 64);
            this.txtQuantidade.TabIndex = 35;
            // 
            // dadosProduto
            // 
            this.dadosProduto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dadosProduto.BackgroundColor = System.Drawing.Color.White;
            this.dadosProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dadosProduto.Location = new System.Drawing.Point(489, 109);
            this.dadosProduto.Name = "dadosProduto";
            this.dadosProduto.RowTemplate.Height = 33;
            this.dadosProduto.Size = new System.Drawing.Size(654, 552);
            this.dadosProduto.TabIndex = 37;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.White;
            this.pictureBox7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(61, 604);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(55, 57);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 38;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // Adicionar
            // 
            this.Adicionar.BackColor = System.Drawing.Color.Transparent;
            this.Adicionar.BorderColor = System.Drawing.Color.Transparent;
            this.Adicionar.BorderRadius = 20;
            this.Adicionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Adicionar.CustomBorderColor = System.Drawing.Color.Transparent;
            this.Adicionar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Adicionar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Adicionar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Adicionar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Adicionar.FillColor = System.Drawing.Color.Red;
            this.Adicionar.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.Adicionar.ForeColor = System.Drawing.Color.White;
            this.Adicionar.Image = ((System.Drawing.Image)(resources.GetObject("Adicionar.Image")));
            this.Adicionar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Adicionar.ImageSize = new System.Drawing.Size(50, 50);
            this.Adicionar.Location = new System.Drawing.Point(61, 497);
            this.Adicionar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Adicionar.Name = "Adicionar";
            this.Adicionar.Size = new System.Drawing.Size(420, 79);
            this.Adicionar.TabIndex = 36;
            this.Adicionar.Text = "Adicionar";
            this.Adicionar.Click += new System.EventHandler(this.Adicionar_Click);
            // 
            // AdicionarProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 39F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1202, 711);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.dadosProduto);
            this.Controls.Add(this.Adicionar);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.txtSubcategoria);
            this.Controls.Add(this.txtCategoria);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AdicionarProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdicionarProdutos";
            this.Load += new System.EventHandler(this.AdicionarProdutos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dadosProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtQuantidade;
        private Guna.UI2.WinForms.Guna2TextBox txtPreco;
        private Guna.UI2.WinForms.Guna2TextBox txtSubcategoria;
        private Guna.UI2.WinForms.Guna2TextBox txtCategoria;
        private Guna.UI2.WinForms.Guna2TextBox txtNome;
        private System.Windows.Forms.DataGridView dadosProduto;
        private Guna.UI2.WinForms.Guna2Button Adicionar;
        private System.Windows.Forms.PictureBox pictureBox7;
    }
}