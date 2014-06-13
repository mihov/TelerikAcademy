namespace Task02
{
    public class FirstStatement
    {
        public static void CookPotato()
        {
            Potato potato = new Potato();

            if (potato != null)
            {
                if (potato.HasBeenPeeled && potato.IsFresh)
                {
                    Cook(potato);
                }
            }
        }

        private static void Cook(Potato potato)
        {
            // Code
        }
    }
}