

namespace Padaria_UI
{
    static class Altenticar
    {
        private static bool autenticado = false;

        public static void Autenticar()
        {
            autenticado = true;
        }
        public static void Desautenticar()
        {
            autenticado = false;
        }
        public static bool EstaAutenticado()
        {
            return autenticado;
        }

    }

    static class realizarPedido
    {
        private static int realizar = 0;

        public static void Realizar(int x)
        {
            realizar = x;
        }

        public static int RealizouPedido()
        {
            return realizar;
        }
    }

    static class retornaIdPedido
    {
        private static int id = 0;

        public static void Id(int x)
        {
            id = x;
        }

        public static int RetornarId()
        {
            return id;
        }
    }

    static class retornaNomeBairro
    {
        private static string nomebairro = "";

        public static void NomeBairro(string Nomebairro)
        {
            nomebairro = Nomebairro;
        }

        public static string RetornaNomeBairro()
        {
            string retorno = string.Empty;
            retorno = nomebairro;
            return retorno;
        }
    }

    static class DiaDaEntrega
    {
        private static string diaentrega = "";

        public static void DiaEntraga(string diaEntrega)
        {
            diaentrega = diaEntrega;
        }

        public static string RetornaDiaEntrega()
        {
            string retorno = string.Empty;
            retorno = diaentrega;
            return retorno;
        }
    }
}
