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
        public Mapa()
        {
            InitializeComponent();            
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Enabled = false;            
            dataGridView1.ColumnHeadersVisible = false;
            dataGridView1.ScrollBars = ScrollBars.None;
            int n = 500;                   
            for (int i = 0; i < n; i++)
            {
                DataGridViewColumn column = new DataGridViewColumn();                
                DataGridViewCell cell = new DataGridViewTextBoxCell();
                cell.Style.BackColor = Color.White;
                column.CellTemplate = cell;
                dataGridView1.Columns.Add(column);
                
            }
                       
            int tamanho = dataGridView1.Columns[0].Width;           
            
            for (int j = 0; j < n; j++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.Height = (int)tamanho;
                dataGridView1.Rows.Add(row);
            }
            dataGridView1.ClearSelection();             
        }        
    }
}
