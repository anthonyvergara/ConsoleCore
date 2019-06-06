using System.Collections;

namespace Cadastro.Lib
{
    public class Pessoa : iPessoa
    {
        private string _nome;
        private string _usuario;
        private int _idade;

        public ArrayList lista;

        public string Usuario { get{return _usuario;} set{_usuario = value;} }
        public string Nome { get{return _nome;} set{_nome = value;} }
        public int Idade { get{return _idade;} 
                            set{
                                if(value == 0){_idade = 18;}
                                else if(value == 1){_idade = 19;}
                                else{_idade = value;}
                            } }
        public Pessoa(string usuario, string nome, int idade)
        {
            this.Idade = idade;
            this.Nome = nome;
            this.Usuario = usuario;
            lista = new ArrayList();
        }
        public string Cadastrar(string usuario, string nome, int idade)
        {
            string alerta = "";
            if(idade < 18){
                alerta = $"\nA {nome} é menor de idade!";
            }
            lista.Add(usuario);
            return $"{usuario} cadastrado!"+ alerta;
        }

        public string Pesquisar(string usuario)
        {
            string nome = "";
            foreach(string nomes in lista){
                if(nomes.Equals(usuario)){
                    nome = nomes + " encontrado!";
                    break;
                }
                else{
                    nome = "Não encontrado!";
                }
            }
            return nome;
        }

        public string Deletar(string usuario)
        {
            string alerta = "";
            foreach(string user in lista){
                if (user.Equals(usuario)){
                    lista.Remove(usuario);
                    alerta = "usuário removido!";
                    break;
                }
                else{
                    alerta = "usuário não encontrado!";
                }
            }
            return alerta;
        }

        public string Listar()
        {
            string _nomes = "";
            foreach(string nomes in lista){
                _nomes = _nomes + nomes+"\n";
            }
            return _nomes;
        }
    }
}