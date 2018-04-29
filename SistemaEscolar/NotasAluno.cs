using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEscolar
{
    public class NotasAluno
    {
        public Alunos aluno;
        public Provas prova;
        public double nota;


        public void setAluno(Alunos aluno)
        {
            this.aluno = aluno;
        }
        public Alunos getAluno()
        {
            return aluno;
        }
        public void setProva(Provas prova)
        {
            this.prova = prova;
        }
        public Provas getProva()
        {
            return prova;
        }
        public void setNota(double nota)
        {
            this.nota = nota;
        }
        public double getNota()
        {
            return nota;
        }
    }
}
