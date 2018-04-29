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
    public partial class Notas : Form
    {
        
        List<Alunos> alunos;
        List<Provas> provas;
        List<NotasAluno> notas;
        Alunos novoaluno = new Alunos();
        Provas novaprova = new Provas();

        public Notas(List<Alunos> alunos, List<Provas> provas, List<NotasAluno> notas)
        {
            InitializeComponent();
            this.alunos = alunos;
            this.provas = provas;
            this.notas = notas;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BuscaAluno buscaaluno = new BuscaAluno(novoaluno, alunos, this);
            buscaaluno.Show();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            NotasAluno nt = new NotasAluno();
            nt.setNota(Convert.ToDouble(textBoxnota.Text));
            MessageBox.Show("Nota Salva com sucesso", "Sucesso", MessageBoxButtons.OK);
            limparcampos();
            notas.Add(nt);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BuscarProva busca = new BuscarProva(novaprova, provas, this);
            busca.Show();
        }

        private void Notas_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            limparcampos();
        }
        public void limparcampos()
        {
            textBoxnome1.Text = "";
            textBox2.Text = "";
            textBoxnota.Text = "";
        }

        private void textBoxnome1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
