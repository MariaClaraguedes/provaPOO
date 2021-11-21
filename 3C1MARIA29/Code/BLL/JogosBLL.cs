using _3C1MARIA29.Code.DAL;
using _3C1MARIA29.Code.DTO;
using System.Data;

namespace _3C1MARIA29.Code.BLL
{
    class JogosBLL
    {
        AcessoBancoDados conexao = new AcessoBancoDados();
        string tabela = "produtos";
        //O método de inserir recebe os dados via DTO 
        //e envia para o banco de dados através da classe AcessoBancoDados
        public void Inserir(JogosDTO medDto)
        {
            //Antes de criar o comando aqui, teste no PhpMyAdmin ou Worckbench
            string inserir = $"insert into {tabela} values(null,'{medDto.Nome}','{medDto.Preco}','{medDto.Quantidade}');";
            conexao.ExecutarComando(inserir);
        }

        public void Editar(JogosDTO medDto)
        {
            string editar = $"update {tabela} set Nome = '{medDto.Nome}', Preco = '{medDto.Preco}', Quantidade = '{medDto.Quantidade}' where id = '{medDto.Id}';";
            conexao.ExecutarComando(editar);
        }
        public void Excluir(JogosDTO medDto)
        {
            string excluir = $"delete from {tabela} where id = '{medDto.Id}';";
            conexao.ExecutarComando(excluir);
        }
        public DataTable Listar()
        {
            string sql = $"select * from {tabela} order by id;";
            return conexao.ExecutarConsulta(sql);
        }
    }
}
