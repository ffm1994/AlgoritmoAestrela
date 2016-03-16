namespace AlgoritmoAestrela
{
    partial class ConfigCustos
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
            this.label3 = new System.Windows.Forms.Label();
            this.btnAtualizarCustos = new System.Windows.Forms.Button();
            this.txtBoxCustoDiagonal = new System.Windows.Forms.TextBox();
            this.txtBoxCustoVertical = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxCustoHorizontal = new System.Windows.Forms.TextBox();
            this.radionBtnDistEuclidiana = new System.Windows.Forms.RadioButton();
            this.radionBtnDistManual = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Custo Diagonal:";
            // 
            // btnAtualizarCustos
            // 
            this.btnAtualizarCustos.Location = new System.Drawing.Point(15, 177);
            this.btnAtualizarCustos.Name = "btnAtualizarCustos";
            this.btnAtualizarCustos.Size = new System.Drawing.Size(188, 28);
            this.btnAtualizarCustos.TabIndex = 26;
            this.btnAtualizarCustos.Text = "Atualizar Custos";
            this.btnAtualizarCustos.UseVisualStyleBackColor = true;
            this.btnAtualizarCustos.Click += new System.EventHandler(this.btnAtualizarCustos_Click);
            // 
            // txtBoxCustoDiagonal
            // 
            this.txtBoxCustoDiagonal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtBoxCustoDiagonal.Enabled = false;
            this.txtBoxCustoDiagonal.Location = new System.Drawing.Point(15, 151);
            this.txtBoxCustoDiagonal.Name = "txtBoxCustoDiagonal";
            this.txtBoxCustoDiagonal.Size = new System.Drawing.Size(188, 20);
            this.txtBoxCustoDiagonal.TabIndex = 25;
            // 
            // txtBoxCustoVertical
            // 
            this.txtBoxCustoVertical.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtBoxCustoVertical.Location = new System.Drawing.Point(15, 64);
            this.txtBoxCustoVertical.Name = "txtBoxCustoVertical";
            this.txtBoxCustoVertical.Size = new System.Drawing.Size(188, 20);
            this.txtBoxCustoVertical.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Custo Vertical:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Custo Horizontal:";
            // 
            // txtBoxCustoHorizontal
            // 
            this.txtBoxCustoHorizontal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtBoxCustoHorizontal.Location = new System.Drawing.Point(15, 25);
            this.txtBoxCustoHorizontal.Name = "txtBoxCustoHorizontal";
            this.txtBoxCustoHorizontal.Size = new System.Drawing.Size(188, 20);
            this.txtBoxCustoHorizontal.TabIndex = 21;
            // 
            // radionBtnDistEuclidiana
            // 
            this.radionBtnDistEuclidiana.AutoSize = true;
            this.radionBtnDistEuclidiana.Checked = true;
            this.radionBtnDistEuclidiana.Location = new System.Drawing.Point(15, 104);
            this.radionBtnDistEuclidiana.Name = "radionBtnDistEuclidiana";
            this.radionBtnDistEuclidiana.Size = new System.Drawing.Size(121, 17);
            this.radionBtnDistEuclidiana.TabIndex = 28;
            this.radionBtnDistEuclidiana.TabStop = true;
            this.radionBtnDistEuclidiana.Text = "Distância Euclidiana";
            this.radionBtnDistEuclidiana.UseVisualStyleBackColor = true;
            this.radionBtnDistEuclidiana.CheckedChanged += new System.EventHandler(this.radionBtnDistEuclidiana_CheckedChanged);
            // 
            // radionBtnDistManual
            // 
            this.radionBtnDistManual.AutoSize = true;
            this.radionBtnDistManual.Location = new System.Drawing.Point(15, 128);
            this.radionBtnDistManual.Name = "radionBtnDistManual";
            this.radionBtnDistManual.Size = new System.Drawing.Size(140, 17);
            this.radionBtnDistManual.TabIndex = 29;
            this.radionBtnDistManual.Text = "Configurar Manualmente";
            this.radionBtnDistManual.UseVisualStyleBackColor = true;
            this.radionBtnDistManual.CheckedChanged += new System.EventHandler(this.radionBtnDistManual_CheckedChanged);
            // 
            // ConfigCustos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(216, 213);
            this.Controls.Add(this.radionBtnDistManual);
            this.Controls.Add(this.radionBtnDistEuclidiana);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAtualizarCustos);
            this.Controls.Add(this.txtBoxCustoDiagonal);
            this.Controls.Add(this.txtBoxCustoVertical);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxCustoHorizontal);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(232, 251);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(232, 251);
            this.Name = "ConfigCustos";
            this.Text = "ConfigCustos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAtualizarCustos;
        private System.Windows.Forms.TextBox txtBoxCustoDiagonal;
        private System.Windows.Forms.TextBox txtBoxCustoVertical;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxCustoHorizontal;
        private System.Windows.Forms.RadioButton radionBtnDistEuclidiana;
        private System.Windows.Forms.RadioButton radionBtnDistManual;
    }
}