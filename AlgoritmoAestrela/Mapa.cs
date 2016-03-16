using Algoritmo;
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
    public partial class Mapa : Form
    {
        // 1 = start
        // 2 = finish
        // 3 = barrer
        // 4 = clear
        public int state = 0;
        public static CoordenadaMapa coordenadaStart = null;
        public static CoordenadaMapa coordenadaFinish = null;
        public Pintar pintar = new Pintar();
        public int linhas;
        public int colunas;
        public double custoVertical;
        public double custoHorizontal;
        public double custoDiagonal;
        public bool[,] map;
        public SearchParameters searchParameters;
        public string[] textoDoArquivo;

        public Mapa(int linhas, int colunas)
        {
            InitializeComponent();
            this.linhas = linhas;
            this.colunas = colunas;
            this.custoHorizontal = 1;
            this.custoVertical = 1;
            this.custoDiagonal = (double)Math.Sqrt(custoHorizontal * custoHorizontal + custoVertical * custoVertical);
            
            CriarCenario();
            dataGridView1.SelectionChanged += new EventHandler(SelectionChangedTable);     
        }  
        
        public Mapa(string[] text)
        {
            textoDoArquivo = text;
            InitializeComponent();
           
            this.linhas = (int)Decodificar(0, true);
            this.colunas = (int)Decodificar(0, true);
            this.custoHorizontal = (double)Decodificar(0, false);
            this.custoVertical = (double)Decodificar(0, false);
            this.custoDiagonal = (double)Math.Sqrt(custoHorizontal * custoHorizontal + custoVertical * custoVertical);
            
            CriarCenario();
            pintar.PintarMapa(this);            
            dataGridView1.SelectionChanged += new EventHandler(SelectionChangedTable);     
        }

        public dynamic Decodificar(int index, bool isInt)
        {
            string variavel = "";
            string text = textoDoArquivo[index];
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == ' ')
                {
                    text = text.Remove(i, 1);
                    break;
                }
                else
                {
                    variavel += text[i];
                    text = text.Remove(i, 1);
                    i--;
                }
            }
            textoDoArquivo[index] = text;
            if(isInt)
            {
                return System.Convert.ToInt32(variavel);
            }
            else
            {
                return System.Convert.ToDouble(variavel);
            }
        }

        public void SetColorDataGrid(Color color, int linha, int coluna)
        {
            dataGridView1.Rows[linha].Cells[coluna].Style.BackColor = color;
        }

        public void SetCustos(double ver, double hor, double dia)
        {
            this.custoVertical = ver;
            this.custoHorizontal = hor;
            this.custoDiagonal = dia;
        }

        public void SetCoordenadaInicial(int linha, int coluna)
        {
            coordenadaStart = new CoordenadaMapa();
            coordenadaStart.setLinha(linha);
            coordenadaStart.setColuna(coluna);
        }

        public void SetCoordenadaFinal(int linha, int coluna)
        {
            coordenadaFinish = new CoordenadaMapa();
            coordenadaFinish.setLinha(linha);
            coordenadaFinish.setColuna(coluna);
        }
               
        public string[] GetTextoDoArquivo()
        {
            return textoDoArquivo;
        }

        public void SetTextoDoArquivo(int linha,string novaLinha)
        {
            this.textoDoArquivo[linha] = novaLinha;
        }

        public void CriarCenario()
        {
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Enabled = false;            
            dataGridView1.ColumnHeadersVisible = false;
            dataGridView1.ScrollBars = ScrollBars.None;            
            for (int i = 0; i < colunas; i++)
            {
                DataGridViewColumn column = new DataGridViewColumn();                
                DataGridViewCell cell = new DataGridViewTextBoxCell();
                cell.Style.BackColor = Color.White;
                column.CellTemplate = cell;
                dataGridView1.Columns.Add(column);
                
            }
            int alturaTotalDasLinhas = 0;
            for (int j = 0; j < linhas; j++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.Height = (int) (dataGridView1.Height / linhas);
                alturaTotalDasLinhas += row.Height;
                dataGridView1.Rows.Add(row);
            }
            dataGridView1.Height = alturaTotalDasLinhas;
            dataGridView1.ClearSelection();
        }
        
        private void btnStart_Click(object sender, EventArgs e)
        {
            state = 1;
            dataGridView1.Enabled = true;
            dataGridView1.MultiSelect = false;
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            state = 2;
            dataGridView1.Enabled = true;
            dataGridView1.MultiSelect = false;
        }

        private void btnBarrer_Click(object sender, EventArgs e)
        {
            state = 3;
            dataGridView1.Enabled = true;
            dataGridView1.MultiSelect = true;            
        }

        private void btnWhite_Click(object sender, EventArgs e)
        {
            if(radioBtnLimparQuadro.Checked)
            {
                state = 4;
                dataGridView1.Enabled = true;
                dataGridView1.MultiSelect = true;
            }
            else if(radioBtnLimparTudo.Checked)
            {
                LimparTudo();
            }             
        }

        private void EventCellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if( coordenadaStart == null)
            {
                coordenadaStart = new CoordenadaMapa();
            }
            if( coordenadaFinish == null)
            {
                coordenadaFinish = new CoordenadaMapa();
            }
            if(state == 1)
            {
                pintar.PintarCelula(Color.Green, coordenadaStart, this);
            }
            else if(state == 2)
            {
                pintar.PintarCelula(Color.Red, coordenadaFinish, this);
            }            
        }           
       
        private void SelectionChangedTable(object sender, EventArgs e)
        {
            if(state == 3)
            {               
                pintar.PintarBarreira(this);             
            }      
            else if(state == 4)
            {
                pintar.Apagar(this);  
            }
        }    
   
        public DataGridView getDataGridView()
        {
            return dataGridView1;
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            try
            {
                LimparRota();
                InitializeMap();
                AddBlocks();
                PathFinder pathFinder = new PathFinder(searchParameters);
                List<Point> path = pathFinder.FindPath();
                MostrarRota(path);
            }
            catch(NullReferenceException)
            {

            }
            
        }
                     
        private void InitializeMap()
        {
            try
            {
                this.map = new bool[linhas, colunas];
                for (int i = 0; i < linhas; i++)
                    for (int j = 0; j < colunas; j++)
                        map[i, j] = true;

                var startLocation = new Point(coordenadaStart.getLinha(), coordenadaStart.getColuna());
                var endLocation = new Point(coordenadaFinish.getLinha(), coordenadaFinish.getColuna());
                this.searchParameters = new SearchParameters(startLocation, endLocation, map);
            }
            catch(NullReferenceException)
            {
                MessageBox.Show("Ponto de inicio ou fim não declarado.");
            }            
        }
        
        private void AddBlocks()
        {
            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    if(dataGridView1.Rows[i].Cells[j].Style.BackColor == Color.Gray)
                    {
                        this.map[i, j] = false;
                    }
                }
            }            
        }

        public void LimparRota()
        {
            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    if(dataGridView1.Rows[i].Cells[j].Style.BackColor == Color.Blue)
                    {
                        dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.White;
                    }
                }                
            }
        }

        public void LimparTudo()
        {
            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {                    
                    dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.White;                    
                }
            }
            coordenadaStart = null;
            coordenadaFinish = null;
        }

        private void MostrarRota(IEnumerable<Point> path)
        {

            for (int y = this.map.GetLength(1) - 1; y >= 0; y--) // Invert the Y-axis so that coordinate 0,0 is shown in the bottom-left
            {
                for (int x = 0; x < this.map.GetLength(0); x++)
                {
                    if (path.Where(p => p.X == x && p.Y == y).Any())
                    {
                        if (dataGridView1.Rows[x].Cells[y].Style.BackColor != Color.Red)
                        {
                            dataGridView1.Rows[x].Cells[y].Style.BackColor = Color.Blue;   
                        }                                            
                    }                                       
                }               
            }           
        }
        
        private void btnConfigurarCustos_Click(object sender, EventArgs e)
        {
            ConfigCustos configCustos = new ConfigCustos(this);
            configCustos.Show();
        }
    }
}
