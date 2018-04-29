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
    public partial class CadastrarProva : Form
    {
        List<Provas> provas;
        List<Alunos> alunos;
        public CadastrarProva(List<Provas> provas, List<Alunos> alunos)
        {
            InitializeComponent();
            this.provas = provas;
            this.alunos = alunos;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void CadastrarProva_Load(object sender, EventArgs e)
        {

        }
        public void limparcampos()
        {
            textBoxDesc.Text = "";
            textBoxData_rea.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Provas pr = new Provas();
            pr.setData_realizacao(textBoxData_rea.Text);
            pr.setDescricao(textBoxDesc.Text);
            MessageBox.Show("Prova salva com sucesso", "Sucesso", MessageBoxButtons.OK);
            limparcampos();
            provas.Add(pr);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            limparcampos();
        }
    }
}
