using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmoAestrela
{
    public class CoordenadaMapa
    {
        private int linha;
        private int coluna;

        public int getLinha()
        {
            return linha;
        }

        public int getColuna()
        {
            return coluna;
        }

        public void setLinha(int linha)
        {
            this.linha = linha;
        }

        public void setColuna(int coluna)
        {
            this.coluna = coluna;
        }
    }
}
