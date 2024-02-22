namespace CodeWars.Kata
{
    public class ConsecutiveItems
    {
        public static bool Consecutive(int[] arr, int a, int b)
        {
            for (int arrayIndex = 0; arrayIndex < arr.Length -1; arrayIndex++)
            {
                if ((arr[arrayIndex] == a) && (arr[arrayIndex + 1] == b))
                {
                    return true;
                }
                if ((arr[arrayIndex] == b) && (arr[arrayIndex + 1] == a))
                {
                    return true;
                }

                //if(arrayIndex > 0)
                //{
                //    if ((arr[arrayIndex] == a) && (arr[arrayIndex -1] == b))
                //    {
                //        return true;
                //    }
                //}
            }
            
            return false;
        }
    }
}
