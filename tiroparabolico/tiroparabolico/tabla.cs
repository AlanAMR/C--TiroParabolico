using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tiroparabolico
{
    public partial class tabla : Form
    {

        public tabla(List<vector> lista)
        {
            InitializeComponent();

            foreach (vector vect in lista) {
                DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                row.Cells[0].Value = vect.getx();
                row.Cells[1].Value = vect.getY();
                row.Cells[2].Value = vect.getr();
                dataGridView1.Rows.Add(row);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
