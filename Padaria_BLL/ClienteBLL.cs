using System;
using System.Collections.Generic;
using Padaria_DAL;
using Padaria_DTO;

namespace Padaria_BLL
{
    public class LoginBLL
    {
        public bool Buscar(string user, string password)
        {
            try
            {
                return new LoginDAL().VerificaLogin(user, password);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }

    public class ClienteBLL
    {

        public IList<Cliente_DTO> Listar()
        {
            try
            {
                return new ClienteDAL().Listar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IList<Cliente_DTO> Listar(string telefone)
        {
            try
            {
                return new ClienteDAL().Listar(telefone);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public IList<Taxa_DTO> ListarTaxa()
        {
            try
            {
                return new ClienteDAL().ListarTaxa();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int idTaxa(string nomeBairro)
        {
            try
            {
                return new ClienteDAL().IdTaxa(nomeBairro);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public int insereCliente(Cliente_DTO CLI)
        {
            /*Insere usuario será criado na DAL*/
            try
            {
                return new ClienteDAL().insereCliente(CLI);
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
                return new ClienteDAL().alteraCliente(CLI);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool buscaIdTaxa(string nomebairro)
        {
            return new ClienteDAL().buscaIdTaxa(nomebairro);
        }

        public int excluiCliente(Cliente_DTO CLI)
        {
            try
            {
                return new ClienteDAL().excluiCliente(CLI);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }

    public class ProdutoBLL
    {
        public IList<Produto_DTO> Listar_Produto()
        {
            try
            {
                return new ProdutoDAL().Listar_Produto();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IList<Produto_DTO> Listar_Produto(string nome_produto)
        {
            try
            {
                return new ProdutoDAL().Listar_Produto(nome_produto);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int insereProduto(Produto_DTO PRO)
        {
            try
            {
                return new ProdutoDAL().insereProduto(PRO);
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
                return new ProdutoDAL().alteraProduto(PRO);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int excluiProduto(Produto_DTO PRO)
        {
            try
            {
                return new ProdutoDAL().excluiProduto(PRO);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int ControleEstoque(int IdProduto, int Qnt)
        {
            try
            {
                return new ProdutoDAL().ControleEstoque(IdProduto, Qnt);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }

    public class ItensBLL
    {
        public IList<Itens_DTO> Listar_Itens()
        {
            try
            {
                return new ItensDAL().Listar_Itens();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public IList<Itens_DTO> Listar_Itens_Abertos(int id)
        {
            try
            {
                return new ItensDAL().Listar_Item_Abertos(id);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public int insereItens(Itens_DTO item)
        {
            try
            {
                return new ItensDAL().insereItens(item);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public int excluiItem(int id)
        {
            try
            {
                return new ItensDAL().excluiItem(id);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void adicionaEstoque(int i)
        {
            try
            {
                new ItensDAL().AdicionaEstoque(i);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }

    public class PedidoBLL
    {
        public IList<Pedido_DTO> Listar_Pedido()
        {
            try
            {
                return new PedidoDAL().Listar_Pedido();
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
                return new PedidoDAL().Listar_Pedido_Fechado();
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
                return new PedidoDAL().Listar_Pedido_Fechado(nome);
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
                return new PedidoDAL().Listar_Pedido_Dias_Seguintes();
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
                return new PedidoDAL().Listar_Item_Pedido(idPedido, taxa);
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
                return new PedidoDAL().Listar_Pedido_Filtro(i, f);
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
                return new PedidoDAL().Listar_Pedido_Filtro(i, f, nome);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public decimal valorBrutoData(DateTime i, DateTime f)
        {
            try
            {
                return new PedidoDAL().valorBrutoData(i, f);
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
                return new PedidoDAL().valorBrutoNome(nome);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int inserePedido(Pedido_DTO PED)
        {
            try
            {
                return new PedidoDAL().inserePedido(PED);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public decimal valorTaxa(int id)
        {
            try
            {
                return new PedidoDAL().valorTaxa(id);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public decimal somaTotal()
        {
            try
            {
                return new PedidoDAL().SomaTotal();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int IDPedido()
        {
            try
            {
                return new PedidoDAL().IDPedido();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int IDCliente(string nome_cliente)
        {
            try
            {
                return new PedidoDAL().IDCliente(nome_cliente);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void inserePagamento(string metodo, int id)
        {
            new PedidoDAL().inserePagamento(metodo, id);
        }

        public int fecharPedido(int id)
        {
            try
            {
                return new PedidoDAL().fecharPedido(id);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }

    public class TaxaBLL
    {
        public int insereTaxa(Taxa_DTO taxa)
        {
            /*Insere usuario será criado na DAL*/
            try
            {
                return new TaxaDAL().insereTaxa(taxa);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int editarTaxa(Taxa_DTO taxa)
        {
            try
            {
                return new TaxaDAL().alteraTaxa(taxa);
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
                return new TaxaDAL().excluirTaxa(id);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
