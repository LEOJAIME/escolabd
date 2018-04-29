using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEscolar
{
    public class Alunos
    {
        public String nome;
        public String data_nasc;
        public String matricula;
        public String data_matric;

        public void setNome(String nome)
        {
            this.nome = nome;
        }
        public String getNome()
        {
            return nome;
        }
        public void setData_nasc(String data_nasc)
        {
            this.data_nasc = data_nasc;
        }
        public String getData_nasc()
        {
            return data_nasc;
        }
        public void setMatricula (String matricula)
        {
            this.matricula = matricula;
        }
        public String getMatricula()
        {
            return matricula;
        }
        public void setData_matric(String data_matric)
        {
            this.data_matric = data_matric;
        }
        public String getData_matric()
        {
            return data_matric;
        }
    }
}
