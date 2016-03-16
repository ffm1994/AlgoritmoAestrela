using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgoritmoAestrela
{
    public partial class FormConfig : Form
    {
        public FormConfig()
        {
            InitializeComponent();
            radionBtnConfigManual.Checked = true;
        }

        private void btnCriarMapa_Click(object sender, EventArgs e)
        {
            if (radionBtnConfigManual.Checked)
            {
                int linhas = System.Convert.ToInt32(txtBoxNumeroLinhas.Text);
                int colunas = System.Convert.ToInt32(txtBoxNumeroColunas.Text);
                if(linhas > 1 && colunas > 1)
                {
                    Mapa mapa = new Mapa(linhas, colunas);
                    mapa.Show();
                }
                else
                {
                    MessageBox.Show("Os dados tem que ser números inteiros maiores que um.");
                }                   
            }
            else
            {
                try
                {
                    string[] text = System.IO.File.ReadAllLines(txtBoxEndereco.Text);
                    Mapa mapa = new Mapa(text);
                    mapa.Show();
                }
                catch(Exception)
                {
                    MessageBox.Show("Erro na leitura do arquivo.");
                }
                
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radionBtnConfigManual_CheckedChanged(object sender, EventArgs e)
        {
            lblEndereco.Enabled = false;
            txtBoxEndereco.Enabled = false;

            lblLinhas.Enabled = true;
            lblColunas.Enabled = true;
            txtBoxNumeroColunas.Enabled = true;
            txtBoxNumeroLinhas.Enabled = true;
        }

        private void radionBtnConfigAutomatico_CheckedChanged(object sender, EventArgs e)
        {
            lblEndereco.Enabled = true;
            txtBoxEndereco.Enabled = true;

            lblLinhas.Enabled = false;
            lblColunas.Enabled = false;
            txtBoxNumeroColunas.Enabled = false;
            txtBoxNumeroLinhas.Enabled = false;
        }
    }
}
