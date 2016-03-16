using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgoritmoAestrela
{
    public partial class ConfigCustos : Form
    {
        Mapa mapa;
        double custoVertical;
        double custoHorizontal;
        double custoDiagonal;
        public ConfigCustos(Mapa mapa)
        {
            InitializeComponent();
            this.mapa = mapa;
            custoVertical = mapa.custoVertical;
            custoHorizontal = mapa.custoHorizontal;
            custoDiagonal = mapa.custoDiagonal;

            txtBoxCustoVertical.Text = custoVertical.ToString();
            txtBoxCustoHorizontal.Text = custoHorizontal.ToString();
            txtBoxCustoDiagonal.Text = Math.Sqrt(custoHorizontal * custoHorizontal + custoVertical * custoVertical).ToString();

            txtBoxCustoVertical.TextChanged += new EventHandler(verticalChanged);
            txtBoxCustoHorizontal.TextChanged += new EventHandler(horizontalChanged);
        }

        private void verticalChanged(object sender, EventArgs e)
        {
            if (txtBoxCustoVertical.Text != "")
            {
                custoVertical = System.Convert.ToDouble(txtBoxCustoVertical.Text);
            }
            if(radionBtnDistEuclidiana.Checked)
            {
                custoDiagonal = Math.Sqrt(custoHorizontal * custoHorizontal + custoVertical * custoVertical);
                txtBoxCustoDiagonal.Text = custoDiagonal.ToString();
            }           
        }

        private void horizontalChanged(object sender, EventArgs e)
        {
            if(txtBoxCustoHorizontal.Text != "")
            {
                custoHorizontal = System.Convert.ToDouble(txtBoxCustoHorizontal.Text);
            }
            if (radionBtnDistEuclidiana.Checked)
            {
                custoDiagonal = Math.Sqrt(custoHorizontal * custoHorizontal + custoVertical * custoVertical);
                txtBoxCustoDiagonal.Text = custoDiagonal.ToString();
            }
        }

        private void btnAtualizarCustos_Click(object sender, EventArgs e)
        {
            double ver = System.Convert.ToDouble(txtBoxCustoVertical.Text);
            double hor = System.Convert.ToDouble(txtBoxCustoHorizontal.Text);
            double dia = System.Convert.ToDouble(txtBoxCustoDiagonal.Text);
            mapa.SetCustos(ver, hor, dia);
        }

        private void radionBtnDistEuclidiana_CheckedChanged(object sender, EventArgs e)
        {
            txtBoxCustoDiagonal.Enabled = false;
            custoDiagonal = (double)Math.Sqrt(custoHorizontal * custoHorizontal + custoVertical * custoVertical);
            txtBoxCustoDiagonal.Text = custoDiagonal.ToString();
        }

        private void radionBtnDistManual_CheckedChanged(object sender, EventArgs e)
        {
            txtBoxCustoDiagonal.Enabled = true;
        }
    }
}
