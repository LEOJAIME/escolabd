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
    public partial class CadastrarAluno : Form
    {
        List<Alunos> alunos;
        public CadastrarAluno(List<Alunos> alunos)
        {
            InitializeComponent();
            this.alunos = alunos;
        }

        private void CadastrarAluno_Load(object sender, EventArgs e)
        {

        }

        public void limparcampos()
        {
            textBoxnome1.Text = "";
            textBoxdata_nasc.Text = "";
            textBoxmatric.Text = "";
            textBoxdata_matric.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Alunos al = new Alunos();
            al.setNome(textBoxnome1.Text);
            al.setData_nasc(textBoxdata_nasc.Text);
            al.setMatricula(textBoxmatric.Text);
            al.setData_matric(textBoxdata_matric.Text);
            MessageBox.Show("Aluno salvo com sucesso", "Sucesso", MessageBoxButtons.OK);
            limparcampos();
            alunos.Add(al);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            limparcampos();
        }

        public void textBoxnome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
