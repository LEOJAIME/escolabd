using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaEscolar
{
    public partial class BuscarProva : Form
    {
        List<Provas> prova;
        Notas cadastroprova;
        Provas novaprova;

        public BuscarProva(Provas novaprova, List<Provas> prova, Notas formpai)
        {
            InitializeComponent();
            this.prova = prova;
            cadastroprova = formpai;
            this.novaprova = novaprova;
        }

        private void BuscarProva_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cadastroprova.textBox2.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            novaprova.setDescricao(cadastroprova.textBox2.Text);
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            List<Provas> buscaprovas = new List<Provas>();
            groupresultprova.Visible = true;

            foreach (Provas pr in prova)
            {
                if (pr.getDescricao().Contains(textBox1.Text))
                {
                    buscaprovas.Add(pr);
                }
            }
            foreach (Provas pr in buscaprovas)
            {
                dataGridView1.Rows.Add(pr.getDescricao());
            }
        }
    }
}
