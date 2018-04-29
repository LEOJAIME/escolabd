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
    public partial class Form1 : Form
    {
        List<Alunos> alunos;
        List<Provas> provas;
        List<NotasAluno> nota;
        public Form1()
        {
            InitializeComponent();
            alunos = new List<Alunos>();
            provas = new List<Provas>();
            nota = new List<NotasAluno>();
            Conexao c = new Conexao();
            c.conecta();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CadastrarAluno cadastroaluno = new CadastrarAluno(alunos);
            cadastroaluno.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            CadastrarProva cadastroprova = new CadastrarProva(provas, alunos);
            cadastroprova.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Notas notas = new Notas(alunos, provas, nota);
            notas.Show();
        }
    }
}
