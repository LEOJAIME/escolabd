using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEscolar
{
    public class Provas
    {
        public String data_realizacao;
        public String descricao;

        public void setData_realizacao( String data_realizacao)
        {
            this.data_realizacao = data_realizacao;
        }
        public String getData_realizacao()
        {
            return data_realizacao;
        }
        public void setDescricao(String descricao)
        {
            this.descricao = descricao;
        }
        public String getDescricao()
        {
            return descricao;
        }
    }
}
