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
    public partial class BuscaAluno : Form
    {
        List<Alunos> alunos;
        Notas cadastroaluno;
        Alunos novoaluno;

        public BuscaAluno(Alunos novoaluno, List<Alunos> alunos, Notas formpai)
        {
            InitializeComponent();
            this.alunos = alunos;
            cadastroaluno = formpai;
            this.novoaluno = novoaluno;
            gridResultadonome.ReadOnly = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            gridResultadonome.Rows.Clear();
            List<Alunos> buscaalunos = new List<Alunos>();
            groupBox1.Visible = true;

            foreach(Alunos al in alunos)
            {
                if (al.getNome().Contains(textBox1.Text))
                {
                    buscaalunos.Add(al);
                }
            }
            foreach(Alunos al in buscaalunos)
            {
                gridResultadonome.Rows.Add(al.getNome());
            }
        }

        private void BuscaAluno_Load(object sender, EventArgs e)
        {

        }

        public void gridResultadonome_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cadastroaluno.textBoxnome1.Text = gridResultadonome.CurrentRow.Cells[0].Value.ToString();
            novoaluno.setNome(cadastroaluno.textBoxnome1.Text);
            this.Close();

        }
    }
}
