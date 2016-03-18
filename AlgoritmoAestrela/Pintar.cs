using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgoritmoAestrela
{
    public class Pintar
    {
        public void PintarMapa(Mapa mapa)
        {
            string[] textoDoArquivo = mapa.GetTextoDoArquivo();
            for (int l = 1; l < textoDoArquivo.Length; l++)
            {
                for (int c = 0; c < textoDoArquivo[l].Length; c++)
                {
                    if (textoDoArquivo[l][c] == '0')
                    {
                        mapa.SetColorDataGrid(Color.White, l - 1, c / 2);                        
                    }
                    else if (textoDoArquivo[l][c] == '1')
                    {
                        mapa.SetColorDataGrid(Color.Gray, l - 1, c / 2);      
                    }
                    else if (textoDoArquivo[l][c] == '2')
                    {
                        mapa.SetCoordenadaInicial(l - 1, c / 2);
                        mapa.SetColorDataGrid(Color.Green, l - 1, c / 2);      
                    }
                    else if (textoDoArquivo[l][c] == '3')
                    {
                        mapa.SetCoordenadaFinal(l - 1, c / 2);
                        mapa.SetColorDataGrid(Color.Red, l - 1, c / 2);      
                    }
                }
            }
        }

        public void PintarBarreira(Mapa mapa)
        {           
            foreach (DataGridViewCell cell in mapa.getDataGridView().SelectedCells)
            {
                cell.Style.BackColor = Color.Gray;
            }    
            mapa.getDataGridView().ClearSelection();
        }

        public void Apagar(Mapa mapa)
        {
            foreach (DataGridViewCell cell in mapa.getDataGridView().SelectedCells)
            {
                cell.Style.BackColor = Color.White;
            }
            mapa.getDataGridView().ClearSelection();
        }

        public void PintarCelula(Color cor, CoordenadaMapa coordenada, Mapa mapa)
        {
            try
            {
                if (!(coordenada.getLinha() == -1 && coordenada.getColuna() == -1))
                {
                    mapa.getDataGridView().Rows[coordenada.getLinha()].Cells[coordenada.getColuna()].Style.BackColor = Color.White;
                }               
            }
            catch(ArgumentOutOfRangeException)
            {

            }
            coordenada.setLinha(mapa.getDataGridView().CurrentCell.RowIndex);
            coordenada.setColuna(mapa.getDataGridView().CurrentCell.ColumnIndex);
            mapa.getDataGridView().CurrentCell.Style.BackColor = cor;
            mapa.getDataGridView().ClearSelection();
        }

    }
}
