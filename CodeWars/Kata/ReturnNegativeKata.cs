namespace CodeWars.Kata
{
    public class ReturnNegativeKata
    {
        public static int MakeNegative(int number)
        {
            if(number <= 0)
            {
                return number;
            }

            return (number * -1);
        }
    }
}
