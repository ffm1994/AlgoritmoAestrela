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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxNumeroColunas = new System.Windows.Forms.TextBox();
            this.txtBoxNumeroLinhas = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
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
            this.radionBtnConfigManual.TabIndex = 0;
            this.radionBtnConfigManual.TabStop = true;
            this.radionBtnConfigManual.Text = "Configurar mapa manualmente.";
            this.radionBtnConfigManual.UseVisualStyleBackColor = true;
            // 
            // radionBtnConfigAutomatico
            // 
            this.radionBtnConfigAutomatico.AutoSize = true;
            this.radionBtnConfigAutomatico.Location = new System.Drawing.Point(13, 88);
            this.radionBtnConfigAutomatico.Name = "radionBtnConfigAutomatico";
            this.radionBtnConfigAutomatico.Size = new System.Drawing.Size(161, 17);
            this.radionBtnConfigAutomatico.TabIndex = 1;
            this.radionBtnConfigAutomatico.TabStop = true;
            this.radionBtnConfigAutomatico.Text = "Configurar mapa por arquivo.";
            this.radionBtnConfigAutomatico.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Número de linhas:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Número de colunas:";
            // 
            // txtBoxNumeroColunas
            // 
            this.txtBoxNumeroColunas.Location = new System.Drawing.Point(121, 56);
            this.txtBoxNumeroColunas.Name = "txtBoxNumeroColunas";
            this.txtBoxNumeroColunas.Size = new System.Drawing.Size(161, 20);
            this.txtBoxNumeroColunas.TabIndex = 4;
            // 
            // txtBoxNumeroLinhas
            // 
            this.txtBoxNumeroLinhas.Location = new System.Drawing.Point(121, 34);
            this.txtBoxNumeroLinhas.Name = "txtBoxNumeroLinhas";
            this.txtBoxNumeroLinhas.Size = new System.Drawing.Size(161, 20);
            this.txtBoxNumeroLinhas.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Endereço:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(79, 112);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(203, 20);
            this.textBox1.TabIndex = 7;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(206, 139);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnCriarMapa
            // 
            this.btnCriarMapa.Location = new System.Drawing.Point(121, 139);
            this.btnCriarMapa.Name = "btnCriarMapa";
            this.btnCriarMapa.Size = new System.Drawing.Size(75, 23);
            this.btnCriarMapa.TabIndex = 9;
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
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBoxNumeroLinhas);
            this.Controls.Add(this.txtBoxNumeroColunas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radionBtnConfigAutomatico);
            this.Controls.Add(this.radionBtnConfigManual);
            this.MaximumSize = new System.Drawing.Size(310, 208);
            this.MinimumSize = new System.Drawing.Size(310, 208);
            this.Name = "FormConfig";
            this.Text = "Configurações";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radionBtnConfigManual;
        private System.Windows.Forms.RadioButton radionBtnConfigAutomatico;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxNumeroColunas;
        private System.Windows.Forms.TextBox txtBoxNumeroLinhas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnCriarMapa;
    }
}