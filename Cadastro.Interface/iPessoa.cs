namespace Cadastro
{
    public interface iPessoa
    {
         string Cadastrar(string usuario, string nome, int idade);

         string Deletar(string usuario);

         string Pesquisar(string usuario);

        string Listar();
    }
}