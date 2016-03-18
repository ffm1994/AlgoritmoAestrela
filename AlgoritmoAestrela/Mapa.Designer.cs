namespace AlgoritmoAestrela
{
    partial class Mapa
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnFinish = new System.Windows.Forms.Button();
            this.btnBarrer = new System.Windows.Forms.Button();
            this.btnWhite = new System.Windows.Forms.Button();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.radioBtnLimparQuadro = new System.Windows.Forms.RadioButton();
            this.radioBtnLimparTudo = new System.Windows.Forms.RadioButton();
            this.btnConfigurarCustos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Enabled = false;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 4;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(550, 550);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.EventCellMouseClick);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Green;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(569, 13);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(60, 60);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "S";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnFinish
            // 
            this.btnFinish.BackColor = System.Drawing.Color.Red;
            this.btnFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinish.Location = new System.Drawing.Point(636, 13);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(60, 60);
            this.btnFinish.TabIndex = 6;
            this.btnFinish.Text = "F";
            this.btnFinish.UseVisualStyleBackColor = false;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // btnBarrer
            // 
            this.btnBarrer.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnBarrer.Location = new System.Drawing.Point(702, 13);
            this.btnBarrer.Name = "btnBarrer";
            this.btnBarrer.Size = new System.Drawing.Size(60, 60);
            this.btnBarrer.TabIndex = 7;
            this.btnBarrer.UseVisualStyleBackColor = false;
            this.btnBarrer.Click += new System.EventHandler(this.btnBarrer_Click);
            // 
            // btnWhite
            // 
            this.btnWhite.BackColor = System.Drawing.Color.White;
            this.btnWhite.BackgroundImage = global::AlgoritmoAestrela.Properties.Resources.borracha1;
            this.btnWhite.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnWhite.Location = new System.Drawing.Point(569, 79);
            this.btnWhite.Name = "btnWhite";
            this.btnWhite.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnWhite.Size = new System.Drawing.Size(60, 60);
            this.btnWhite.TabIndex = 8;
            this.btnWhite.UseVisualStyleBackColor = false;
            this.btnWhite.Click += new System.EventHandler(this.btnWhite_Click);
            // 
            // btnIniciar
            // 
            this.btnIniciar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIniciar.Location = new System.Drawing.Point(569, 145);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(193, 31);
            this.btnIniciar.TabIndex = 9;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // radioBtnLimparQuadro
            // 
            this.radioBtnLimparQuadro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioBtnLimparQuadro.AutoSize = true;
            this.radioBtnLimparQuadro.Checked = true;
            this.radioBtnLimparQuadro.Location = new System.Drawing.Point(636, 79);
            this.radioBtnLimparQuadro.Name = "radioBtnLimparQuadro";
            this.radioBtnLimparQuadro.Size = new System.Drawing.Size(121, 17);
            this.radioBtnLimparQuadro.TabIndex = 10;
            this.radioBtnLimparQuadro.TabStop = true;
            this.radioBtnLimparQuadro.Text = "Limpar quadro único";
            this.radioBtnLimparQuadro.UseVisualStyleBackColor = true;
            // 
            // radioBtnLimparTudo
            // 
            this.radioBtnLimparTudo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioBtnLimparTudo.AutoSize = true;
            this.radioBtnLimparTudo.Location = new System.Drawing.Point(636, 103);
            this.radioBtnLimparTudo.Name = "radioBtnLimparTudo";
            this.radioBtnLimparTudo.Size = new System.Drawing.Size(80, 17);
            this.radioBtnLimparTudo.TabIndex = 11;
            this.radioBtnLimparTudo.Text = "Limpar tudo";
            this.radioBtnLimparTudo.UseVisualStyleBackColor = true;
            // 
            // btnConfigurarCustos
            // 
            this.btnConfigurarCustos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfigurarCustos.Location = new System.Drawing.Point(569, 182);
            this.btnConfigurarCustos.Name = "btnConfigurarCustos";
            this.btnConfigurarCustos.Size = new System.Drawing.Size(193, 30);
            this.btnConfigurarCustos.TabIndex = 18;
            this.btnConfigurarCustos.Text = "Configurar Custos";
            this.btnConfigurarCustos.UseVisualStyleBackColor = true;
            this.btnConfigurarCustos.Click += new System.EventHandler(this.btnConfigurarCustos_Click);
            // 
            // Mapa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 573);
            this.Controls.Add(this.btnConfigurarCustos);
            this.Controls.Add(this.radioBtnLimparTudo);
            this.Controls.Add(this.radioBtnLimparQuadro);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.btnWhite);
            this.Controls.Add(this.btnBarrer);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(785, 611);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(785, 611);
            this.Name = "Mapa";
            this.Text = "Mapa";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ClosedForm);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

      

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.Button btnBarrer;
        private System.Windows.Forms.Button btnWhite;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.RadioButton radioBtnLimparQuadro;
        private System.Windows.Forms.RadioButton radioBtnLimparTudo;
        private System.Windows.Forms.Button btnConfigurarCustos;
    }
}

