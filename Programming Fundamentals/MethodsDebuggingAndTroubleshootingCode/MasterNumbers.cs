
namespace MethodsDebuggingAndTroubleshooting_Code
{
    public class MasterNumbers
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(System.Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                if (IsPolindrome(i) && SumOfDigits(i) && ContainsEvenDigit(i))
                {
                    System.Console.WriteLine(i);
                }
            }
        }   

        static bool IsPolindrome(int num)
        {
            string sNum = num.ToString();
            for (int i = 0; i<sNum.Length; i++) 
                if (sNum[i] != sNum[sNum.Length-1-i]) return false;

            return true;
        }

        static bool SumOfDigits(int num)
        {
            int sum = 0;
            while (num != 0) {
                sum += num % 10;
                num /= 10;
            }
            if (sum % 7 == 0)
            {
                return true;
            }else
            {
                return false;   
            }
        }

        static bool ContainsEvenDigit(int num)
        {
            char[] numberToCharArray = num.ToString().ToCharArray();
            bool found = false;
            for (int i = 0; i < numberToCharArray.Length; i++)
            {
                if ((numberToCharArray[i]-'0') % 2 ==0)
                {
                    found=true;
                    break;
                }
            }
            return found;
        }
    }
}