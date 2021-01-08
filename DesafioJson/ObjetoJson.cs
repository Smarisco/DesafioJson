using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioJson
{
    public class ObjetoJson
    {
        public int codigo { get; set; }
        public string nome { get; set; }
        public string nome_reduzido { get; set; }
        public string data_Criacao { get; set; }
        public string cnpj { get; set; }
        public string integracao_compras { get; set; }
        public int emite_pre_empenho_integrado { get; set; }
        public Unidadeorcamentaria unidadeOrcamentaria { get; set; }
        public Contadore[] contadores { get; set; }
    }

    public class Unidadeorcamentaria
    {
        public int codigo { get; set; }
        public string nome { get; set; }
        public string usuario_inclusao_registro { get; set; }
        public string data_inclusao_registro { get; set; }
    }

    public class Contadore
    {
        public string nome { get; set; }
        public string data_nascimento { get; set; }
        public string endereco { get; set; }
        public string numero { get; set; }
        public string bairro { get; set; }
        public string ativo { get; set; }
    }
}
