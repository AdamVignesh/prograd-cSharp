namespace ChangeLicensePlatw
{
    public class Program
    {
       // licensePlate("5F3Z-2e-9-w", 4) ➞ "5F3Z-2E9W"
        public static string ConvertToLicensePlate(string inputLicenseNumber, int groupLen)
        {
            string resultantLicenseNum = "";
            Stack<string> ChangePlate = new Stack<string>();
            int length = inputLicenseNumber.Length - 1;
            int j = 1;
            while (length >= 0)
            {
                if (inputLicenseNumber[length] != '-')
                {
                    ChangePlate.Push(inputLicenseNumber[length].ToString());
                    if (j < groupLen)
                    {
                        j++;
                    }
                    else if (j == groupLen && length - 1 >= 0)
                    {
                        ChangePlate.Push("-");
                        j = 1;
                    }
                }
                length--;
            }
            while (ChangePlate.Count > 0)
            {
                var item = ChangePlate.Pop();
                resultantLicenseNum += item.ToUpper();
            }
            return resultantLicenseNum;
        }
        static void Main(string[] args)
        {
            string inputLicenseNum = Console.ReadLine();
            int groupLen = int.Parse(Console.ReadLine());
            Console.WriteLine(ConvertToLicensePlate(inputLicenseNum,groupLen));
            //2-5g-3-J", 2
            //2-4A0r7-4k", 3
            //"nlj-206-fv", 3
        }
    }
}