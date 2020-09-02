namespace Padaria_DAL
{
    public static class Retornar
    {
        private static int[] Id = new int[50];
        private static int[] Qnt = new int[50];
        private static int cont;

        public static void Retorna(int id, int qnt, int i)
        {
            Id[i] = id;
            Qnt[i] = qnt;
            cont = i;
        }

        public static int RetornoaId(int i)
        {
            return Id[i];
        }
        public static int RetornaQnt(int i)
        {
            return Qnt[i];
        }
        public static int RetornaCont()
        {
            return cont;
        }
    }
}
