namespace CodeWars.Kata
{
    public class SameCaseKata
    {
        public static int SameCase(char a, char b)
        {
            //https://www.codewars.com/kata/5dd462a573ee6d0014ce715b/train/csharp

            if (!char.IsLetter(a) || !char.IsLetter(b))
            {
                return -1;
            }

            if ((char.IsLower(a) && char.IsLower(b)) || (char.IsUpper(a) && char.IsUpper(b)))
            {
                return 1;
            }

            return 0;
        }
    }
}
