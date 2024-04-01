namespace Restaurante
{
    partial class EliminarProdutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EliminarProdutos));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txtId = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_Eliminar = new Guna.UI2.WinForms.Guna2Button();
            this.dadosProduto = new System.Windows.Forms.DataGridView();
            this.voltar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dadosProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.voltar)).BeginInit();
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
            this.label1.Location = new System.Drawing.Point(264, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Eliminar Produto";
            // 
            // txtId
            // 
            this.txtId.BorderColor = System.Drawing.Color.Gray;
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
            this.txtId.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtId.Location = new System.Drawing.Point(169, 96);
            this.txtId.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.txtId.Name = "txtId";
            this.txtId.PasswordChar = '\0';
            this.txtId.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtId.PlaceholderText = "ID do Produto";
            this.txtId.SelectedText = "";
            this.txtId.Size = new System.Drawing.Size(476, 64);
            this.txtId.TabIndex = 32;
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.BackColor = System.Drawing.Color.Transparent;
            this.btn_Eliminar.BorderColor = System.Drawing.Color.Transparent;
            this.btn_Eliminar.BorderRadius = 20;
            this.btn_Eliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Eliminar.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btn_Eliminar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Eliminar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Eliminar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Eliminar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Eliminar.FillColor = System.Drawing.Color.Red;
            this.btn_Eliminar.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btn_Eliminar.ForeColor = System.Drawing.Color.White;
            this.btn_Eliminar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Eliminar.Image")));
            this.btn_Eliminar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Eliminar.ImageSize = new System.Drawing.Size(50, 50);
            this.btn_Eliminar.Location = new System.Drawing.Point(169, 181);
            this.btn_Eliminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(476, 74);
            this.btn_Eliminar.TabIndex = 37;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // dadosProduto
            // 
            this.dadosProduto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dadosProduto.BackgroundColor = System.Drawing.Color.White;
            this.dadosProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dadosProduto.Location = new System.Drawing.Point(63, 263);
            this.dadosProduto.Name = "dadosProduto";
            this.dadosProduto.RowTemplate.Height = 33;
            this.dadosProduto.Size = new System.Drawing.Size(664, 274);
            this.dadosProduto.TabIndex = 38;
            // 
            // voltar
            // 
            this.voltar.BackColor = System.Drawing.Color.White;
            this.voltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.voltar.Image = ((System.Drawing.Image)(resources.GetObject("voltar.Image")));
            this.voltar.Location = new System.Drawing.Point(63, 562);
            this.voltar.Name = "voltar";
            this.voltar.Size = new System.Drawing.Size(55, 57);
            this.voltar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.voltar.TabIndex = 39;
            this.voltar.TabStop = false;
            this.voltar.Click += new System.EventHandler(this.voltar_Click);
            // 
            // EliminarProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(808, 649);
            this.Controls.Add(this.voltar);
            this.Controls.Add(this.dadosProduto);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EliminarProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EliminarProdutos";
            this.Load += new System.EventHandler(this.EliminarProdutos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dadosProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.voltar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtId;
        private Guna.UI2.WinForms.Guna2Button btn_Eliminar;
        private System.Windows.Forms.DataGridView dadosProduto;
        private System.Windows.Forms.PictureBox voltar;
    }
}