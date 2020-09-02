namespace Padaria_DAL
{
    public static class SomarTotal
    {
        private static decimal somar = 0;

        public static void Somar(decimal total, decimal taxa, int x)
        {
            if (total != 0)
                somar = total + somar;
            else if (x != 0)
                somar = somar + taxa;
            else
                somar = 0;
        }

        public static decimal SomouTotal()
        {
            return somar;
        }

    }
}
