namespace AlgoritmoAestrela
{
    partial class FormConfig
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
            this.radionBtnConfigManual = new System.Windows.Forms.RadioButton();
            this.radionBtnConfigAutomatico = new System.Windows.Forms.RadioButton();
            this.lblLinhas = new System.Windows.Forms.Label();
            this.lblColunas = new System.Windows.Forms.Label();
            this.txtBoxNumeroColunas = new System.Windows.Forms.TextBox();
            this.txtBoxNumeroLinhas = new System.Windows.Forms.TextBox();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.txtBoxEndereco = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnCriarMapa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // radionBtnConfigManual
            // 
            this.radionBtnConfigManual.AutoSize = true;
            this.radionBtnConfigManual.Location = new System.Drawing.Point(13, 13);
            this.radionBtnConfigManual.Name = "radionBtnConfigManual";
            this.radionBtnConfigManual.Size = new System.Drawing.Size(171, 17);
            this.radionBtnConfigManual.TabIndex = 5;
            this.radionBtnConfigManual.TabStop = true;
            this.radionBtnConfigManual.Text = "Configurar mapa manualmente.";
            this.radionBtnConfigManual.UseVisualStyleBackColor = true;
            this.radionBtnConfigManual.CheckedChanged += new System.EventHandler(this.radionBtnConfigManual_CheckedChanged);
            // 
            // radionBtnConfigAutomatico
            // 
            this.radionBtnConfigAutomatico.AutoSize = true;
            this.radionBtnConfigAutomatico.Location = new System.Drawing.Point(13, 88);
            this.radionBtnConfigAutomatico.Name = "radionBtnConfigAutomatico";
            this.radionBtnConfigAutomatico.Size = new System.Drawing.Size(161, 17);
            this.radionBtnConfigAutomatico.TabIndex = 8;
            this.radionBtnConfigAutomatico.TabStop = true;
            this.radionBtnConfigAutomatico.Text = "Configurar mapa por arquivo.";
            this.radionBtnConfigAutomatico.UseVisualStyleBackColor = true;
            this.radionBtnConfigAutomatico.CheckedChanged += new System.EventHandler(this.radionBtnConfigAutomatico_CheckedChanged);
            // 
            // lblLinhas
            // 
            this.lblLinhas.AutoSize = true;
            this.lblLinhas.Location = new System.Drawing.Point(13, 37);
            this.lblLinhas.Name = "lblLinhas";
            this.lblLinhas.Size = new System.Drawing.Size(92, 13);
            this.lblLinhas.TabIndex = 6;
            this.lblLinhas.Text = "Número de linhas:";
            // 
            // lblColunas
            // 
            this.lblColunas.AutoSize = true;
            this.lblColunas.Location = new System.Drawing.Point(13, 59);
            this.lblColunas.Name = "lblColunas";
            this.lblColunas.Size = new System.Drawing.Size(102, 13);
            this.lblColunas.TabIndex = 7;
            this.lblColunas.Text = "Número de colunas:";
            // 
            // txtBoxNumeroColunas
            // 
            this.txtBoxNumeroColunas.Location = new System.Drawing.Point(121, 56);
            this.txtBoxNumeroColunas.Name = "txtBoxNumeroColunas";
            this.txtBoxNumeroColunas.Size = new System.Drawing.Size(161, 20);
            this.txtBoxNumeroColunas.TabIndex = 1;
            // 
            // txtBoxNumeroLinhas
            // 
            this.txtBoxNumeroLinhas.Location = new System.Drawing.Point(121, 34);
            this.txtBoxNumeroLinhas.Name = "txtBoxNumeroLinhas";
            this.txtBoxNumeroLinhas.Size = new System.Drawing.Size(161, 20);
            this.txtBoxNumeroLinhas.TabIndex = 0;
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(16, 112);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(56, 13);
            this.lblEndereco.TabIndex = 9;
            this.lblEndereco.Text = "Endereço:";
            // 
            // txtBoxEndereco
            // 
            this.txtBoxEndereco.Location = new System.Drawing.Point(79, 112);
            this.txtBoxEndereco.Name = "txtBoxEndereco";
            this.txtBoxEndereco.Size = new System.Drawing.Size(203, 20);
            this.txtBoxEndereco.TabIndex = 2;
            this.txtBoxEndereco.Text = "C:\\Users\\Felipe\\Desktop\\AlgoritmoAestrela-master\\mapa1.txt";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(206, 139);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnCriarMapa
            // 
            this.btnCriarMapa.Location = new System.Drawing.Point(121, 139);
            this.btnCriarMapa.Name = "btnCriarMapa";
            this.btnCriarMapa.Size = new System.Drawing.Size(75, 23);
            this.btnCriarMapa.TabIndex = 3;
            this.btnCriarMapa.Text = "Criar Mapa";
            this.btnCriarMapa.UseVisualStyleBackColor = true;
            this.btnCriarMapa.Click += new System.EventHandler(this.btnCriarMapa_Click);
            // 
            // FormConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 170);
            this.Controls.Add(this.btnCriarMapa);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtBoxEndereco);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.txtBoxNumeroLinhas);
            this.Controls.Add(this.txtBoxNumeroColunas);
            this.Controls.Add(this.lblColunas);
            this.Controls.Add(this.lblLinhas);
            this.Controls.Add(this.radionBtnConfigAutomatico);
            this.Controls.Add(this.radionBtnConfigManual);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(310, 208);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(310, 208);
            this.Name = "FormConfig";
            this.Text = "Configurações";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radionBtnConfigManual;
        private System.Windows.Forms.RadioButton radionBtnConfigAutomatico;
        private System.Windows.Forms.Label lblLinhas;
        private System.Windows.Forms.Label lblColunas;
        private System.Windows.Forms.TextBox txtBoxNumeroColunas;
        private System.Windows.Forms.TextBox txtBoxNumeroLinhas;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.TextBox txtBoxEndereco;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnCriarMapa;
    }
}