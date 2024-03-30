namespace Restaurante
{
    partial class EditarProdutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarProdutos));
            this.label1 = new System.Windows.Forms.Label();
            this.txtId = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtQuantidade = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPreco = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtCategoria = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNome = new Guna.UI2.WinForms.Guna2TextBox();
            this.Editar = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.dadosProduto = new System.Windows.Forms.DataGridView();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dadosProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.BlueViolet;
            this.label1.Location = new System.Drawing.Point(882, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 45);
            this.label1.TabIndex = 2;
            this.label1.Text = "Editar Produto";
            // 
            // txtId
            // 
            this.txtId.BorderColor = System.Drawing.Color.BlueViolet;
            this.txtId.BorderRadius = 20;
            this.txtId.BorderThickness = 2;
            this.txtId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtId.DefaultText = "";
            this.txtId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtId.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtId.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.txtId.ForeColor = System.Drawing.Color.Black;
            this.txtId.HoverState.BorderColor = System.Drawing.Color.ForestGreen;
            this.txtId.Location = new System.Drawing.Point(21, 85);
            this.txtId.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.txtId.Name = "txtId";
            this.txtId.PasswordChar = '\0';
            this.txtId.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtId.PlaceholderText = "ID do Produto";
            this.txtId.SelectedText = "";
            this.txtId.Size = new System.Drawing.Size(300, 64);
            this.txtId.TabIndex = 33;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.BorderColor = System.Drawing.Color.BlueViolet;
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
            this.txtQuantidade.HoverState.BorderColor = System.Drawing.Color.ForestGreen;
            this.txtQuantidade.Location = new System.Drawing.Point(21, 241);
            this.txtQuantidade.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.PasswordChar = '\0';
            this.txtQuantidade.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtQuantidade.PlaceholderText = "Quantidade";
            this.txtQuantidade.SelectedText = "";
            this.txtQuantidade.Size = new System.Drawing.Size(300, 64);
            this.txtQuantidade.TabIndex = 40;
            // 
            // txtPreco
            // 
            this.txtPreco.BorderColor = System.Drawing.Color.BlueViolet;
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
            this.txtPreco.HoverState.BorderColor = System.Drawing.Color.ForestGreen;
            this.txtPreco.Location = new System.Drawing.Point(331, 163);
            this.txtPreco.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.PasswordChar = '\0';
            this.txtPreco.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtPreco.PlaceholderText = "Preço";
            this.txtPreco.SelectedText = "";
            this.txtPreco.Size = new System.Drawing.Size(312, 64);
            this.txtPreco.TabIndex = 39;
            // 
            // txtCategoria
            // 
            this.txtCategoria.BorderColor = System.Drawing.Color.BlueViolet;
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
            this.txtCategoria.HoverState.BorderColor = System.Drawing.Color.ForestGreen;
            this.txtCategoria.Location = new System.Drawing.Point(21, 163);
            this.txtCategoria.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.PasswordChar = '\0';
            this.txtCategoria.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtCategoria.PlaceholderText = "Categoria";
            this.txtCategoria.SelectedText = "";
            this.txtCategoria.Size = new System.Drawing.Size(300, 64);
            this.txtCategoria.TabIndex = 37;
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
            this.txtNome.Location = new System.Drawing.Point(331, 85);
            this.txtNome.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.txtNome.Name = "txtNome";
            this.txtNome.PasswordChar = '\0';
            this.txtNome.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtNome.PlaceholderText = "Nome do Produto";
            this.txtNome.SelectedText = "";
            this.txtNome.Size = new System.Drawing.Size(312, 64);
            this.txtNome.TabIndex = 36;
            // 
            // Editar
            // 
            this.Editar.BackColor = System.Drawing.Color.Transparent;
            this.Editar.BorderColor = System.Drawing.Color.Transparent;
            this.Editar.BorderRadius = 20;
            this.Editar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Editar.CustomBorderColor = System.Drawing.Color.Transparent;
            this.Editar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Editar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Editar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Editar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Editar.FillColor = System.Drawing.Color.BlueViolet;
            this.Editar.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.Editar.ForeColor = System.Drawing.Color.White;
            this.Editar.Image = ((System.Drawing.Image)(resources.GetObject("Editar.Image")));
            this.Editar.ImageSize = new System.Drawing.Size(50, 50);
            this.Editar.Location = new System.Drawing.Point(331, 239);
            this.Editar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Editar.Name = "Editar";
            this.Editar.Size = new System.Drawing.Size(312, 79);
            this.Editar.TabIndex = 41;
            this.Editar.Text = "Editar";
            this.Editar.Click += new System.EventHandler(this.Editar_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.White;
            this.pictureBox7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(21, 418);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(55, 50);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 42;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // dadosProduto
            // 
            this.dadosProduto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dadosProduto.BackgroundColor = System.Drawing.Color.White;
            this.dadosProduto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dadosProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dadosProduto.Location = new System.Drawing.Point(662, 85);
            this.dadosProduto.Name = "dadosProduto";
            this.dadosProduto.RowTemplate.Height = 33;
            this.dadosProduto.Size = new System.Drawing.Size(503, 233);
            this.dadosProduto.TabIndex = 43;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // EditarProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1205, 497);
            this.Controls.Add(this.dadosProduto);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.Editar);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.txtCategoria);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EditarProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditarProdutos";
            this.Load += new System.EventHandler(this.EditarProdutos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dadosProduto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtId;
        private Guna.UI2.WinForms.Guna2TextBox txtQuantidade;
        private Guna.UI2.WinForms.Guna2TextBox txtPreco;
        private Guna.UI2.WinForms.Guna2TextBox txtCategoria;
        private Guna.UI2.WinForms.Guna2TextBox txtNome;
        private Guna.UI2.WinForms.Guna2Button Editar;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.DataGridView dadosProduto;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}