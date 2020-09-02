using Padaria_DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Padaria_DAL
{
    public static class Conexao
    {
        private static string stringcon = "Data Source=wksgbti2;Initial Catalog=Padaria;Integrated Security=True";
        public static string Stringcon { get { return stringcon; } }
    }
    public class LoginDAL
    {
        
        private SqlCommand CM = new SqlCommand();
        SqlConnection CON = new SqlConnection(Conexao.Stringcon);
        public bool VerificaLogin(string user, string password)
        {
            bool result = false;
            using (CON)
            {
                //CON.ConnectionString = Properties.Settings.Default.CST;

                try
                {
                    CM.CommandType = System.Data.CommandType.Text;
                    CM.CommandText = ("select * from tb_login where usuario = '" + user + "' and senha = '" + password + "';");
                    CM.Connection = CON;
                    CON.Open();
                    SqlDataReader ER;
                    ER = CM.ExecuteReader();
                    result = ER.HasRows;
                }
                catch (SqlException e)
                {
                    throw new Exception(e.Message);
                }
            }
            return result;
        }
    }
    public class ClienteDAL
    {
        private SqlCommand CM = new SqlCommand();
        SqlConnection CON = new SqlConnection(Conexao.Stringcon);

        private IList<Cliente_DTO> listClienteDTO = new List<Cliente_DTO>();
        private IList<Taxa_DTO> listTaxa_DTO = new List<Taxa_DTO>();

        public IList<Cliente_DTO> Listar()
        {
            try
            {
                //CON.ConnectionString = Properties.Settings.Default.CST;
                CM.CommandType = System.Data.CommandType.Text;
                CM.CommandText = "SELECT Id, Nome,"
                               + "'(' + substring(Telefone, 1, 2) + ')' + substring(Telefone, 3, 5) + '-' + substring(Telefone, 8, 4) "
                               + "as telefone, Rua, CEP, NumeroCasa, Complemento, DataCadastro, IdTaxa "
                               + "FROM tb_cliente order by Nome";
                CM.Connection = CON;
                CON.Open();

                SqlDataReader ER;
                ER = CM.ExecuteReader();

                if (ER.HasRows)
                {
                    while (ER.Read())
                    {
                        Cliente_DTO cli = new Cliente_DTO();

                        cli.Id = Convert.ToInt32(ER["Id"]);
                        cli.Nome = Convert.ToString(ER["Nome"]);
                        cli.Telefone = Convert.ToString(ER["Telefone"]);
                        cli.Rua = Convert.ToString(ER["Rua"]);
                        cli.NumeroCasa = Convert.ToInt16(ER["NumeroCasa"]);
                        cli.CEP = Convert.ToString(ER["CEP"]);
                        cli.Complemento = Convert.ToString(ER["Complemento"]);
                        cli.DataCadastro = Convert.ToDateTime(ER["DataCadastro"]);
                        cli.IdTaxa = Convert.ToInt32(ER["IdTaxa"]);
                        listClienteDTO.Add(cli);
                    }
                }
                return listClienteDTO;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IList<Cliente_DTO> Listar(string tel)
        {
           // CON.ConnectionString = Properties.Settings.Default.CST;
            CM.CommandType = System.Data.CommandType.Text;
            CM.CommandText = "SELECT Id, Nome,"
                               + "'(' + substring(Telefone, 1, 2) + ')' + substring(Telefone, 3, 5) + '-' + substring(Telefone, 8, 4) "
                               + "as telefone, Rua, CEP, NumeroCasa, Complemento, DataCadastro, IdTaxa "
                               + "FROM tb_cliente WHERE Telefone LIKE '%" + tel + "%'";
            CM.Connection = CON;
            CON.Open();

            SqlDataReader ER;
            ER = CM.ExecuteReader();

            if (ER.HasRows)
            {
                while (ER.Read())
                {

                    Cliente_DTO cli = new Cliente_DTO();
                    cli.Id = Convert.ToInt32(ER["Id"]);
                    cli.Nome = Convert.ToString(ER["Nome"]);
                    cli.Telefone = Convert.ToString(ER["Telefone"]);
                    cli.Rua = Convert.ToString(ER["Rua"]);
                    cli.NumeroCasa = Convert.ToInt16(ER["NumeroCasa"]);
                    cli.CEP = Convert.ToString(ER["CEP"]);
                    cli.Complemento = Convert.ToString(ER["Complemento"]);
                    cli.DataCadastro = Convert.ToDateTime(ER["DataCadastro"]);
                    cli.IdTaxa = Convert.ToInt32(ER["IdTaxa"]);
                    listClienteDTO.Add(cli);
                }
            }
            return listClienteDTO;
        }

        public IList<Taxa_DTO> ListarTaxa()
        {
            try
            {
                //CON.ConnectionString = Properties.Settings.Default.CST;
                CM.CommandType = System.Data.CommandType.Text;
                CM.CommandText = "SELECT * FROM tb_taxa";
                CM.Connection = CON;
                CON.Open();

                SqlDataReader ER;
                ER = CM.ExecuteReader();

                if (ER.HasRows)
                {
                    while (ER.Read())
                    {
                        Taxa_DTO taxa = new Taxa_DTO();

                        taxa.Id = Convert.ToInt32(ER["Id"]);
                        taxa.NomeBairro = Convert.ToString(ER["NomeBairro"]);
                        taxa.Valor = Convert.ToDecimal(ER["Valor"]);
                        listTaxa_DTO.Add(taxa);
                    }
                }
                return listTaxa_DTO;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int IdTaxa(string nomeBairro)
        {
           // CON.ConnectionString = Properties.Settings.Default.CST;
            CM.CommandType = System.Data.CommandType.Text;
            CM.CommandText = "SELECT Id FROM tb_taxa WHERE NomeBairro=@NomeBairro";
            CM.Parameters.Add("NomeBairro", System.Data.SqlDbType.VarChar).Value = nomeBairro;

            CM.Connection = CON;
            CON.Open();

            SqlDataReader ER;
            ER = CM.ExecuteReader();

            int ClienteDTO = 0;

            if (ER.HasRows)
            {
                while (ER.Read())
                {

                    int Id = 0;
                    Id = Convert.ToInt32(ER["Id"]);

                    ClienteDTO = Id;
                }
            }
            return ClienteDTO;
        }

        public int insereCliente(Cliente_DTO CLI)
        {
            try
            {
                /*Conexão com BD Inserindo dados na tb_clientes*/
                //CON.ConnectionString = Properties.Settings.Default.CST;
                CM.CommandType = System.Data.CommandType.Text;
                CM.CommandText = "INSERT INTO tb_cliente (IdTaxa, Nome, Telefone, Rua," +
                    " CEP, NumeroCasa, Complemento, DataCadastro, HorarioEntrega)" + "   VALUES   (@IdTaxa, @Nome, @Telefone," +
                    "@Rua, @CEP, @NumeroCasa, @Complemento, @DataCadastro, @HorarioEntrega)";

                /*Parameters irá substituir os valores dentro do campo*/
                CM.Parameters.Add("Nome", System.Data.SqlDbType.VarChar).Value = CLI.Nome;
                CM.Parameters.Add("Telefone", System.Data.SqlDbType.VarChar).Value = CLI.Telefone;
                CM.Parameters.Add("Rua", System.Data.SqlDbType.VarChar).Value = CLI.Rua;
                CM.Parameters.Add("CEP", System.Data.SqlDbType.VarChar).Value = CLI.CEP;
                CM.Parameters.Add("NumeroCasa", System.Data.SqlDbType.Int).Value = CLI.NumeroCasa;
                CM.Parameters.Add("Complemento", System.Data.SqlDbType.VarChar).Value = CLI.Complemento;
                CM.Parameters.Add("DataCadastro", System.Data.SqlDbType.DateTime).Value = CLI.DataCadastro;
                CM.Parameters.Add("HorarioEntrega", System.Data.SqlDbType.VarChar).Value = CLI.HorarioEntrega;
                CM.Parameters.Add("IdTaxa", System.Data.SqlDbType.Int).Value = CLI.IdTaxa;
                CM.Connection = CON;
                CON.Open();

                int qtd = CM.ExecuteNonQuery();
                return qtd;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int alteraCliente(Cliente_DTO CLI)
        {
            try
            {
                //CON.ConnectionString = Properties.Settings.Default.CST;
                CM.CommandType = System.Data.CommandType.Text;
                /*Atenção ao nome dos campos que deve ser igual ao Banco de Dados*/
                CM.CommandText = "UPDATE tb_cliente SET Nome=@Nome, " + "Telefone=@Telefone, " +
                    "Rua=@Rua, " + "CEP=@CEP, " + "NumeroCasa=@NumeroCasa, " +
                    "Complemento=@Complemento, " + " IdTaxa=@IdTaxa " + "WHERE Id=@Id";

                /*Parameters irá substituir os valores dentro do campo*/
                CM.Parameters.Add("Nome", System.Data.SqlDbType.VarChar).Value = CLI.Nome;
                CM.Parameters.Add("Telefone", System.Data.SqlDbType.VarChar).Value = CLI.Telefone;
                CM.Parameters.Add("Rua", System.Data.SqlDbType.VarChar).Value = CLI.Rua;
                CM.Parameters.Add("CEP", System.Data.SqlDbType.VarChar).Value = CLI.CEP;
                CM.Parameters.Add("NumeroCasa", System.Data.SqlDbType.Int).Value = CLI.NumeroCasa;
                CM.Parameters.Add("Complemento", System.Data.SqlDbType.VarChar).Value = CLI.Complemento;
                CM.Parameters.Add("Id", System.Data.SqlDbType.Int).Value = CLI.Id;
                CM.Parameters.Add("IdTaxa", System.Data.SqlDbType.Int).Value = CLI.IdTaxa;
                CM.Connection = CON;

                /*Abre conexão*/
                CON.Open();

                int qtd = CM.ExecuteNonQuery();
                return qtd;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool buscaIdTaxa(string nomebairro)
        {
           // CON.ConnectionString = Properties.Settings.Default.CST;
            CM.CommandType = System.Data.CommandType.Text;
            CM.CommandText = "SELECT Id FROM tb_taxa WHERE NomeBairro LIKE '" + nomebairro + "'";
            CM.Connection = CON;
            CON.Open();

            SqlDataReader ER;
            ER = CM.ExecuteReader();

            if (ER.HasRows)
                return true;
            else
                return false;
        }

        public int excluiCliente(Cliente_DTO CLI)
        {
            try
            {
                /*Excluindo dados na tb_clientes*/
               // CON.ConnectionString = Properties.Settings.Default.CST;
                CM.CommandType = System.Data.CommandType.Text;
                CM.CommandText = "delete tb_itens where IdPedido in (Select Id from tb_pedido"
                               + " where IdCliente = @Id)"
                               + " delete tb_pedido where IdCliente = @Id"
                               + " delete tb_cliente where Id = @Id";

                /*tem um unico parametro que será o código do usuario, só existe um*/
                CM.Parameters.Add("Id", System.Data.SqlDbType.Int).Value = CLI.Id;
                CM.Connection = CON;
                CON.Open();
                int qtd = CM.ExecuteNonQuery();
                /*retorna registros afetados*/
                return qtd;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }

    public class ProdutoDAL
    {
        private SqlCommand CM = new SqlCommand();
        SqlConnection CON = new SqlConnection(Conexao.Stringcon);

        IList<Produto_DTO> listProdutoDTO = new List<Produto_DTO>();

        public IList<Produto_DTO> Listar_Produto()
        {
            try
            {
               // CON.ConnectionString = Properties.Settings.Default.CST;
                CM.CommandType = System.Data.CommandType.Text;
                CM.CommandText = "SELECT * FROM tb_produto order by Quantidade";
                CM.Connection = CON;
                CON.Open();

                SqlDataReader ER;
                ER = CM.ExecuteReader();

                if (ER.HasRows)
                {
                    while (ER.Read())
                    {
                        Produto_DTO prod = new Produto_DTO();

                        prod.Id = Convert.ToInt32(ER["Id"]);
                        prod.NomeProduto = Convert.ToString(ER["NomeProduto"]);
                        prod.Preco = Convert.ToDecimal(ER["Preco"]);
                        prod.Quantidade = Convert.ToInt32(ER["Quantidade"]);
                        listProdutoDTO.Add(prod);
                    }
                }
                return listProdutoDTO;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IList<Produto_DTO> Listar_Produto(string nome_produto)
        {
            //CON.ConnectionString = Properties.Settings.Default.CST;
            CM.CommandType = System.Data.CommandType.Text;
            CM.CommandText = "SELECT * FROM dbo.tb_produto WHERE NomeProduto like '%" + nome_produto + "%'" +
                "order by Quantidade";
            CM.Parameters.Add("NomeProduto", System.Data.SqlDbType.VarChar).Value = nome_produto;

            CM.Connection = CON;
            CON.Open();

            SqlDataReader ER;
            ER = CM.ExecuteReader();

            if (ER.HasRows)
            {
                while (ER.Read())
                {

                    Produto_DTO pro = new Produto_DTO();
                    pro.Id = Convert.ToInt32(ER["Id"]);
                    pro.NomeProduto = Convert.ToString(ER["NomeProduto"]);
                    pro.Preco = Convert.ToDecimal(ER["Preco"]);

                    listProdutoDTO.Add(pro);
                }
            }
            return listProdutoDTO;
        }

        public int insereProduto(Produto_DTO PRO)
        {
            try
            {
                //CON.ConnectionString = Properties.Settings.Default.CST;
                CM.CommandType = System.Data.CommandType.Text;
                CM.CommandText = "INSERT INTO tb_produto (NomeProduto, Preco, Quantidade)"
                    + " VALUES (@NomeProduto, @Preco, @Quantidade)";

                /*Para cada campo citado acima são colocados os valores*/
                /*Parameters irá substituir os valores dentro do campo*/
                CM.Parameters.Add("NomeProduto", System.Data.SqlDbType.VarChar).Value = PRO.NomeProduto;
                CM.Parameters.Add("Preco", System.Data.SqlDbType.Decimal).Value = PRO.Preco;
                if (PRO.Quantidade > 0)
                {
                    CM.Parameters.Add("Quantidade", System.Data.SqlDbType.Int).Value = PRO.Quantidade;
                }
                else
                {
                    CM.Parameters.Add("Quantidade", System.Data.SqlDbType.Int).Value = 0;
                }

                CM.Connection = CON;
                CON.Open();

                int qtd = CM.ExecuteNonQuery();
                return qtd;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int alteraProduto(Produto_DTO PRO)
        {
            try
            {
                //CON.ConnectionString = Properties.Settings.Default.CST;
                CM.CommandType = System.Data.CommandType.Text;
                /*Atenção ao nome dos campos que deve ser igual ao Banco de Dados*/
                CM.CommandText = "UPDATE tb_produto SET NomeProduto=@NomeProduto, " +
                    "Preco=@Preco, Quantidade=Quantidade + @Quantidade" + " WHERE Id=@Id";

                /*Parameters irá substituir os valores dentro do campo*/
                CM.Parameters.Add("NomeProduto", System.Data.SqlDbType.VarChar).Value = PRO.NomeProduto;
                CM.Parameters.Add("Preco", System.Data.SqlDbType.Decimal).Value = PRO.Preco;
                CM.Parameters.Add("Quantidade", System.Data.SqlDbType.Int).Value = PRO.Quantidade;
                CM.Parameters.Add("Id", System.Data.SqlDbType.Int).Value = PRO.Id;
                CM.Connection = CON;

                /*Abre conexão*/
                CON.Open();

                int qtd = CM.ExecuteNonQuery();
                return qtd;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int excluiProduto(Produto_DTO PRO)
        {
            try
            {
                //CON.ConnectionString = Properties.Settings.Default.CST;
                CM.CommandType = System.Data.CommandType.Text;
                CM.CommandText = "delete from tb_itens where IdProduto = @Id "
                                + "DELETE tb_produto WHERE Id = @Id";

                /*tem um unico parametro que será o código do usuario, só existe um*/
                CM.Parameters.Add("Id", System.Data.SqlDbType.Int).Value = PRO.Id;
                CM.Connection = CON;
                CON.Open();
                int qtd = CM.ExecuteNonQuery();
                /*retorna registros afetados*/
                return qtd;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int ControleEstoque(int IdProduto, int Qnt)
        {
            try
            {
               // CON.ConnectionString = Properties.Settings.Default.CST;
                CM.CommandType = System.Data.CommandType.Text;
                /*Atenção ao nome dos campos que deve ser igual ao Banco de Dados*/
                CM.CommandText = "UPDATE tb_produto SET Quantidade = Quantidade - @Quantidade where Id = @Id";

                /*Parameters irá substituir os valores dentro do campo*/
                CM.Parameters.Add("Quantidade", System.Data.SqlDbType.VarChar).Value = Qnt;
                CM.Parameters.Add("Id", System.Data.SqlDbType.Decimal).Value = IdProduto;
                CM.Connection = CON;

                /*Abre conexão*/
                CON.Open();

                int qtd = CM.ExecuteNonQuery();
                return qtd;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }

    public class ItensDAL
    {
        private int[] Id = new int[50];
        private int[] qnt = new int[50];
        private int i;
        private SqlCommand CM = new SqlCommand();
        SqlConnection CON = new SqlConnection(Conexao.Stringcon);

        private IList<Itens_DTO> listItensDTO = new List<Itens_DTO>();

        public IList<Itens_DTO> Listar_Itens()
        {
            try
            {
               // CON.ConnectionString = Properties.Settings.Default.CST;
                CM.CommandType = System.Data.CommandType.Text;
                CM.CommandText = "SELECT * FROM tb_pedido";
                CM.Connection = CON;
                CON.Open();

                SqlDataReader ER;
                ER = CM.ExecuteReader();

                if (ER.HasRows)
                {
                    while (ER.Read())
                    {
                        Itens_DTO item = new Itens_DTO();
                        item.IdPedido = Convert.ToInt32(ER["Id"]);
                        item.IdProduto = Convert.ToInt32(ER["IdProduto"]);
                        item.Observacao = Convert.ToString(ER["Observacao"]);
                        item.PrecoProduto = Convert.ToDecimal(ER["PrecoProduto"]);
                        item.Quantidade = Convert.ToInt16(ER["Quantidade"]);
                        listItensDTO.Add(item);
                    }
                }
                return listItensDTO;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IList<Itens_DTO> Listar_Item_Abertos(int id)
        {
            //CON.ConnectionString = Properties.Settings.Default.CST;
            CM.CommandType = System.Data.CommandType.Text;
            CM.CommandText = "SELECT * FROM tb_itens WHERE IdPedido=@IdPedido";
            CM.Parameters.Add("IdPedido", System.Data.SqlDbType.Int).Value = id;
            CM.Connection = CON;
            CON.Open();

            SqlDataReader ER;
            ER = CM.ExecuteReader();

            if (ER.HasRows)
            {
                while (ER.Read())
                {
                    Itens_DTO item = new Itens_DTO();
                    item.IdProduto = Convert.ToInt32(ER["IdProduto"]);
                    item.NomeProduto = Convert.ToString(ER["NomeProduto"]);
                    item.Observacao = Convert.ToString(ER["Observacao"]);
                    item.PrecoProduto = Convert.ToDecimal(ER["PrecoProduto"]);
                    item.Quantidade = Convert.ToInt32(ER["Quantidade"]);
                    listItensDTO.Add(item);
                }
            }
            return listItensDTO;
        }

        public int insereItens(Itens_DTO item)
        {
            try
            {
               // CON.ConnectionString = Properties.Settings.Default.CST;
                CM.CommandType = System.Data.CommandType.Text;
                CM.CommandText = "INSERT INTO tb_itens (IdPedido, IdProduto, NomeProduto, Quantidade, PrecoProduto, Observacao)" +
                    " VALUES (@IdPedido, @IdProduto, @NomeProduto, @Quantidade, @PrecoProduto, @Observacao)";

                //Para cada campo citado acima são colocados os valores
                //Parameters irá substituir os valores dentro do campo
                CM.Parameters.Add("IdPedido", System.Data.SqlDbType.Int).Value = item.IdPedido;
                CM.Parameters.Add("IdProduto", System.Data.SqlDbType.Int).Value = item.IdProduto;
                CM.Parameters.Add("NomeProduto", System.Data.SqlDbType.VarChar).Value = item.NomeProduto;
                CM.Parameters.Add("Observacao", System.Data.SqlDbType.VarChar).Value = item.Observacao;
                CM.Parameters.Add("PrecoProduto", System.Data.SqlDbType.Decimal).Value = item.PrecoProduto;
                CM.Parameters.Add("Quantidade", System.Data.SqlDbType.Int).Value = item.Quantidade;

                CM.Connection = CON;
                CON.Open();

                int qtd = CM.ExecuteNonQuery();
                return qtd;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void AdicionaEstoque(int i)
        {
           // CON.ConnectionString = Properties.Settings.Default.CST;
            CM.CommandType = System.Data.CommandType.Text;
            int id = Retornar.RetornoaId(i);
            int qnt = Retornar.RetornaQnt(i);
            CM.CommandText = "UPDATE tb_produto SET Quantidade = Quantidade + @Quantidade where Id = @Id";
            CM.Parameters.Add("Quantidade", System.Data.SqlDbType.Int).Value = qnt;
            CM.Parameters.Add("Id", System.Data.SqlDbType.Int).Value = id;
            CM.Connection = CON;

            /*Abre conexão*/
            CON.Open();

            int qtd = CM.ExecuteNonQuery();

        }

        public int excluiItem(int id)
        {
            try
            {
                //CON.ConnectionString = Properties.Settings.Default.CST;
                CM.CommandType = System.Data.CommandType.Text;
                CM.CommandText = "SELECT * FROM tb_itens WHERE IdPedido=@IdPedido";
                CM.Parameters.Add("IdPedido", System.Data.SqlDbType.Int).Value = id;
                CM.Connection = CON;

                CON.Open();

                SqlDataReader ER;
                ER = CM.ExecuteReader();
                i = 0;
                if (ER.HasRows)
                {
                    while (ER.Read())
                    {
                        Id[i] = Convert.ToInt32(ER["IdProduto"]);
                        qnt[i] = Convert.ToInt32(ER["Quantidade"]);
                        Retornar.Retorna(Id[i], qnt[i], i);
                        i++;
                    }
                }
                CON.Close();

                CM.CommandType = System.Data.CommandType.Text;
                CM.CommandText = "DELETE tb_itens WHERE IdPedido = @Id";

                /*tem um unico parametro que será o código do usuario, só existe um*/
                CM.Parameters.Add("Id", System.Data.SqlDbType.Int).Value = id;
                CM.Connection = CON;
                CON.Open();
                int qtd = CM.ExecuteNonQuery();
                /*retorna registros afetados*/
                return i;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }

    public class PedidoDAL
    {
        decimal Total;
        private SqlCommand CM = new SqlCommand();
        SqlConnection CON = new SqlConnection(Conexao.Stringcon);

        private IList<Itens_DTO> listItemDTO = new List<Itens_DTO>();
        private IList<Pedido_DTO> listPedidoDTO = new List<Pedido_DTO>();

        public IList<Pedido_DTO> Listar_Pedido()
        {
            try
            {
                //CON.ConnectionString = Properties.Settings.Default.CST;
                CM.CommandType = System.Data.CommandType.Text;
                CM.CommandText = "SELECT A.Nome, A.Telefone, A.Rua, A.CEP, A.NumeroCasa, A.Complemento, A.IdTaxa, B.IdPedido, substring(HorarioEntrega, 1,2)+':'+substring(HorarioEntrega,3,2)+'/'+substring(HorarioEntrega, 5,2)+':'+substring(HorarioEntrega, 7,2)"
                                + " as Horario"
                                + " FROM tb_cliente AS A, tb_pedido AS B Where B.Estado > 0 AND A.Id = B.IdCliente";
                CM.Connection = CON;
                CON.Open();

                SqlDataReader ER;
                ER = CM.ExecuteReader();

                if (ER.HasRows)
                {
                    while (ER.Read())
                    {
                        Pedido_DTO ped = new Pedido_DTO();
                        ped.IdPedido = Convert.ToInt32(ER["IdPedido"]);
                        ped.Nome = Convert.ToString(ER["Nome"]);
                        ped.NumeroCasa = Convert.ToInt16(ER["NumeroCasa"]);
                        ped.Rua = Convert.ToString(ER["Rua"]);
                        ped.Telefone = Convert.ToString(ER["Telefone"]);
                        ped.CEP = Convert.ToString(ER["CEP"]);
                        ped.Complemento = Convert.ToString(ER["Complemento"]);
                        ped.HorarioEntrega = Convert.ToString(ER["Horario"]);
                        ped.IdTaxa = Convert.ToInt32(ER["IdTaxa"]);

                        listPedidoDTO.Add(ped);
                    }
                }
                return listPedidoDTO;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IList<Pedido_DTO> Listar_Pedido_Fechado()
        {
            try
            {
              //  CON.ConnectionString = Properties.Settings.Default.CST;
                CM.CommandType = System.Data.CommandType.Text;
                CM.CommandText = "SELECT A.Nome, A.Telefone, B.IdPedido, B.DataAbertura, B.MetodoPagamento"
                                  + " FROM tb_cliente AS A, tb_pedido AS B"
                                  + " Where B.Estado = 0 AND A.Id = B.IdCliente";
                CM.Connection = CON;
                CON.Open();

                SqlDataReader ER;
                ER = CM.ExecuteReader();

                if (ER.HasRows)
                {
                    while (ER.Read())
                    {
                        Pedido_DTO ped = new Pedido_DTO();
                        ped.IdPedido = Convert.ToInt32(ER["IdPedido"]);
                        ped.NomeCliente = Convert.ToString(ER["Nome"]);
                        ped.Telefone = Convert.ToString(ER["Telefone"]);
                        ped.DataAbertura = Convert.ToDateTime(ER["DataAbertura"]);
                        ped.MetodoPagamento = Convert.ToString(ER["MetodoPagamento"]);

                        listPedidoDTO.Add(ped);
                    }
                }
                return listPedidoDTO;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IList<Pedido_DTO> Listar_Pedido_Fechado(string nome)
        {
            try
            {
             //   CON.ConnectionString = Properties.Settings.Default.CST;
                CM.CommandType = System.Data.CommandType.Text;
                CM.CommandText = "SELECT A.Nome, A.Telefone, B.IdPedido, B.DataAbertura"
                                  + " FROM tb_cliente AS A, tb_pedido AS B"
                                  + " Where B.Estado = 0 AND A.Id = B.IdCliente AND A.Nome like '%" + nome + "%'"
                                  + " order by Nome";
                CM.Connection = CON;
                CON.Open();

                SqlDataReader ER;
                ER = CM.ExecuteReader();

                if (ER.HasRows)
                {
                    while (ER.Read())
                    {
                        Pedido_DTO ped = new Pedido_DTO();
                        ped.IdPedido = Convert.ToInt32(ER["IdPedido"]);
                        ped.NomeCliente = Convert.ToString(ER["Nome"]);
                        ped.Telefone = Convert.ToString(ER["Telefone"]);
                        ped.DataAbertura = Convert.ToDateTime(ER["DataAbertura"]);

                        listPedidoDTO.Add(ped);
                    }
                }
                return listPedidoDTO;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IList<Pedido_DTO> Listar_Pedido_Dias_Seguintes()
        {
            try
            {
                DateTime dataHoje = Convert.ToDateTime(System.DateTime.Now);
               // CON.ConnectionString = Properties.Settings.Default.CST;
                CM.CommandType = System.Data.CommandType.Text;
                CM.CommandText = "SELECT A.Nome, A.Telefone, B.IdPedido, B.DataAbertura"
                                    + " FROM tb_cliente AS A, tb_pedido AS B"
                                    + " Where B.Estado = 1 AND DataAbertura > @Data AND A.Id = B.IdCliente";
                CM.Parameters.Add("Data", System.Data.SqlDbType.Date).Value = dataHoje;
                CM.Connection = CON;
                CON.Open();

                SqlDataReader ER;
                ER = CM.ExecuteReader();

                if (ER.HasRows)
                {
                    while (ER.Read())
                    {
                        Pedido_DTO ped = new Pedido_DTO();
                        ped.Nome = Convert.ToString(ER["Nome"]);
                        ped.Telefone = Convert.ToString(ER["Telefone"]);
                        ped.DataAbertura = Convert.ToDateTime(ER["DataAbertura"]);
                        ped.IdPedido = Convert.ToInt32(ER["IdPedido"]);

                        listPedidoDTO.Add(ped);
                    }
                }
                return listPedidoDTO;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IList<Pedido_DTO> Listar_Pedido_Filtro(DateTime i, DateTime f)
        {
            try
            {
               // CON.ConnectionString = Properties.Settings.Default.CST;
                CM.CommandType = System.Data.CommandType.Text;
                CM.CommandText = "SELECT A.Nome, A.Telefone, B.IdPedido, B.DataAbertura"
                                  + " FROM tb_cliente AS A, tb_pedido AS B"
                                  + " Where B.Estado = 0 AND DataAbertura BETWEEN @inicio AND @final AND A.Id = B.IdCliente";
                CM.Parameters.Add("inicio", System.Data.SqlDbType.Date).Value = i;
                CM.Parameters.Add("final", System.Data.SqlDbType.Date).Value = f;

                CM.Connection = CON;
                CON.Open();

                SqlDataReader ER;
                ER = CM.ExecuteReader();

                if (ER.HasRows)
                {
                    while (ER.Read())
                    {
                        Pedido_DTO ped = new Pedido_DTO();
                        ped.IdPedido = Convert.ToInt32(ER["IdPedido"]);
                        ped.NomeCliente = Convert.ToString(ER["Nome"]);
                        ped.Telefone = Convert.ToString(ER["Telefone"]);
                        ped.DataAbertura = Convert.ToDateTime(ER["DataAbertura"]);

                        listPedidoDTO.Add(ped);
                    }
                }
                return listPedidoDTO;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IList<Pedido_DTO> Listar_Pedido_Filtro(DateTime i, DateTime f, string nome)
        {
            try
            {
               // CON.ConnectionString = Properties.Settings.Default.CST;
                CM.CommandType = System.Data.CommandType.Text;
                CM.CommandText = "SELECT A.Nome, A.Telefone, B.IdPedido, B.DataAbertura"
                                  + " FROM tb_cliente AS A, tb_pedido AS B"
                                  + " Where B.Estado = 0 AND DataAbertura BETWEEN @inicio AND @final AND A.Id = B.IdCliente"
                                  + " AND A.Nome LIKE '%" + nome + "%'";
                CM.Parameters.Add("inicio", System.Data.SqlDbType.Date).Value = i;
                CM.Parameters.Add("final", System.Data.SqlDbType.Date).Value = f;

                CM.Connection = CON;
                CON.Open();

                SqlDataReader ER;
                ER = CM.ExecuteReader();

                if (ER.HasRows)
                {
                    while (ER.Read())
                    {
                        Pedido_DTO ped = new Pedido_DTO();
                        ped.IdPedido = Convert.ToInt32(ER["IdPedido"]);
                        ped.NomeCliente = Convert.ToString(ER["Nome"]);
                        ped.Telefone = Convert.ToString(ER["Telefone"]);
                        ped.DataAbertura = Convert.ToDateTime(ER["DataAbertura"]);

                        listPedidoDTO.Add(ped);
                    }
                }
                return listPedidoDTO;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IList<Itens_DTO> Listar_Item_Pedido(int idPedido, decimal taxa)
        {
            try
            {
                SomarTotal.Somar(0, 0, 0);
              //  CON.ConnectionString = Properties.Settings.Default.CST;
                CM.CommandType = System.Data.CommandType.Text;

                CM.CommandText = "SELECT * "
                               + "FROM tb_itens "
                               + "WHERE IdPedido = " + idPedido + "";

                CM.Connection = CON;
                CON.Open();

                SqlDataReader ER;
                ER = CM.ExecuteReader();

                if (ER.HasRows)
                {
                    int x = 0;
                    while (ER.Read())
                    {
                        Itens_DTO item = new Itens_DTO();
                        item.IdPedido = Convert.ToInt32(ER["IdPedido"]);
                        item.NomeProduto = Convert.ToString(ER["NomeProduto"]);
                        item.Observacao = Convert.ToString(ER["Observacao"]);
                        item.PrecoProduto = Convert.ToDecimal(ER["PrecoProduto"]);
                        item.Quantidade = Convert.ToInt16(ER["Quantidade"]);
                        item.Total = (item.PrecoProduto * item.Quantidade);
                        Total = (item.Total);
                        SomarTotal.Somar(Total, 0, 0);
                        listItemDTO.Add(item);
                        x = 1;
                    }
                    SomarTotal.Somar(0, taxa, x);
                }

                return listItemDTO;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public decimal valorTaxa(int id)
        {
            //CON.ConnectionString = Properties.Settings.Default.CST;
            CM.CommandType = System.Data.CommandType.Text;
            CM.CommandText = "SELECT Valor "
                           + "FROM tb_taxa "
                           + "WHERE Id=@Id";
            CM.Parameters.Add("Id", System.Data.SqlDbType.Int).Value = id;

            CM.Connection = CON;
            CON.Open();

            SqlDataReader ER;
            ER = CM.ExecuteReader();

            Taxa_DTO TaxaDTO = new Taxa_DTO();
            if (ER.HasRows)
            {
                while (ER.Read())
                {
                    TaxaDTO.Valor = Convert.ToDecimal(ER["Valor"]);
                }
            }
            return TaxaDTO.Valor;
        }

        public decimal valorBrutoData(DateTime i, DateTime f)
        {
            try
            {
        //        CON.ConnectionString = Properties.Settings.Default.CST;
                CM.CommandType = System.Data.CommandType.Text;
                CM.CommandText = "select sum(PrecoProduto * i.Quantidade) AS Total"
                                  + " from tb_itens AS i, tb_pedido AS p"
                                  + " where DataAbertura BETWEEN @inicio AND @fim AND i.IdPedido = p.IdPedido AND p.Estado = 0";

                /*Para cada campo citado acima são colocados os valores*/
                /*Parameters irá substituir os valores dentro do campo*/
                CM.Parameters.Add("inicio", System.Data.SqlDbType.Date).Value = i;
                CM.Parameters.Add("fim", System.Data.SqlDbType.Date).Value = f;

                CM.Connection = CON;
                CON.Open();

                SqlDataReader ER;
                ER = CM.ExecuteReader();

                decimal total = 0;
                if (ER.HasRows)
                {
                    while (ER.Read())
                    {
                        total = Convert.ToDecimal(ER["Total"]);
                    }
                }
                return total;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public decimal valorBrutoNome(string nome)
        {
            try
            {
               // CON.ConnectionString = Properties.Settings.Default.CST;
                CM.CommandType = System.Data.CommandType.Text;
                CM.CommandText = "select sum(PrecoProduto * i.Quantidade) AS Total "
                                    + "from tb_itens AS i, tb_pedido AS p "
                                    + "where i.IdPedido = p.IdPedido AND p.Estado = 0 "
                                    + "and p.IdCliente = (SELECT Id FROM tb_cliente where Nome LIKE '%" + nome + "%') ";


                CM.Connection = CON;
                CON.Open();

                SqlDataReader ER;
                ER = CM.ExecuteReader();

                decimal total = 0;
                if (ER.HasRows)
                {
                    while (ER.Read())
                    {
                        total = Convert.ToDecimal(ER["Total"]);
                    }
                }
                return total;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public decimal SomaTotal()
        {
            return SomarTotal.SomouTotal();
        }

        public int inserePedido(Pedido_DTO PED)
        {
            try
            {
               // CON.ConnectionString = Properties.Settings.Default.CST;
                CM.CommandType = System.Data.CommandType.Text;
                CM.CommandText = "INSERT INTO tb_pedido (IdCliente, DataAbertura, Estado, MetodoPagamento)" +
                    " VALUES (@IdCliente, @DataAbertura, @Estado, '')";

                /*Para cada campo citado acima são colocados os valores*/
                /*Parameters irá substituir os valores dentro do campo*/
                CM.Parameters.Add("IdCliente", System.Data.SqlDbType.Int).Value = PED.IdCliente;
                CM.Parameters.Add("DataAbertura", System.Data.SqlDbType.DateTime).Value = PED.DataAbertura;
                CM.Parameters.Add("Estado", System.Data.SqlDbType.Int).Value = PED.Estado;

                CM.Connection = CON;
                CON.Open();

                int qtd = CM.ExecuteNonQuery();
                return qtd;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int IDPedido()
        {
           // CON.ConnectionString = Properties.Settings.Default.CST;
            CM.CommandType = System.Data.CommandType.Text;
            CM.Connection = CON;
            CON.Open();
            int id;
            CM.CommandText = "SELECT max(IdPedido) as id from tb_pedido";
            SqlDataReader ER;
            ER = CM.ExecuteReader();
            ER.Read();
            id = Convert.ToInt16(ER["IdPedido"]);

            return id;
        }

        public int IDCliente(string nome_cliente)
        {
           // CON.ConnectionString = Properties.Settings.Default.CST;
            CM.CommandType = System.Data.CommandType.Text;
            CM.CommandText = "SELECT Id FROM tb_cliente WHERE Nome=@Nome";
            CM.Parameters.Add("Nome", System.Data.SqlDbType.VarChar).Value = nome_cliente;

            int id = 0;

            CM.Connection = CON;
            CON.Open();
            SqlDataReader ER;
            ER = CM.ExecuteReader();

            if (ER.HasRows)
            {
                ER.Read();
                id = Convert.ToInt32(ER["Id"]);
            }
            return id;
        }

        public void inserePagamento(string metodo, int id)
        {
            try
            {
              //  CON.ConnectionString = Properties.Settings.Default.CST;
                CM.CommandType = System.Data.CommandType.Text;
                CM.CommandText = "UPDATE tb_pedido SET MetodoPagamento = " +
                    "'" + metodo + "' where IdPedido = " + id + "";

                CM.Connection = CON;
                CON.Open();
                CM.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int fecharPedido(int id)
        {
            try
            {
             //   CON.ConnectionString = Properties.Settings.Default.CST;
                CM.CommandType = System.Data.CommandType.Text;

                /*Atenção ao nome dos campos que deve ser igual ao Banco de Dados*/
                CM.CommandText = "UPDATE tb_pedido SET Estado = 0 WHERE IdPedido = '" + id + "'";
                CM.Connection = CON;

                /*Abre conexão*/
                CON.Open();

                int qtd = CM.ExecuteNonQuery();
                return qtd;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
    public class TaxaDAL
    {
        private SqlCommand CM = new SqlCommand();
        SqlConnection CON = new SqlConnection(Conexao.Stringcon);
        public int insereTaxa(Taxa_DTO taxa)
        {
            try
            {
               // CON.ConnectionString = Properties.Settings.Default.CST;
                CM.CommandType = System.Data.CommandType.Text;
                CM.CommandText = "INSERT INTO tb_taxa (NomeBairro, Valor)" + "   VALUES   (@NomeBairro, @Valor)";

                /*Para cada campo citado acima são colocados os valores*/
                /*Parameters irá substituir os valores dentro do campo*/
                CM.Parameters.Add("NomeBairro", System.Data.SqlDbType.VarChar).Value = taxa.NomeBairro;
                CM.Parameters.Add("Valor", System.Data.SqlDbType.Decimal).Value = taxa.Valor;

                CM.Connection = CON;
                CON.Open();

                int qtd = CM.ExecuteNonQuery();
                return qtd;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int alteraTaxa(Taxa_DTO taxa)
        {
            try
            {
               // CON.ConnectionString = Properties.Settings.Default.CST;
                CM.CommandType = System.Data.CommandType.Text;

                CM.CommandText = "UPDATE tb_taxa SET NomeBairro=@NomeBairro, " +
                    "Valor=@Valor " + "WHERE Id=@Id";

                /*Parameters irá substituir os valores dentro do campo*/
                CM.Parameters.Add("NomeBairro", System.Data.SqlDbType.VarChar).Value = taxa.NomeBairro;
                CM.Parameters.Add("Valor", System.Data.SqlDbType.Decimal).Value = taxa.Valor;
                CM.Parameters.Add("Id", System.Data.SqlDbType.Int).Value = taxa.Id;
                CM.Connection = CON;

                /*Abre conexão*/
                CON.Open();

                int qtd = CM.ExecuteNonQuery();
                return qtd;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public int excluirTaxa(int id)
        {
            try
            {
               // CON.ConnectionString = Properties.Settings.Default.CST;
                CM.CommandType = System.Data.CommandType.Text;
                CM.CommandText = "DELETE tb_taxa WHERE Id = " + id + "" +
                    "UPDATE tb_cliente SET IdTaxa = 0 where IdTaxa = " + id + "";

                CM.Connection = CON;
                CON.Open();
                int qtd = CM.ExecuteNonQuery();

                return qtd;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
