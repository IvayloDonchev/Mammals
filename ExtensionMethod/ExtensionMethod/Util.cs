namespace ExtensionMethod
{
    public static class Util
    {
        public static string ConvertToBase(this int i, int baseToConvertTo)
        {
            string result = "";
            do
            {
                int nextDigit = i % baseToConvertTo;
                i /= baseToConvertTo;
                if(nextDigit<10)
                    result = nextDigit.ToString() + result;
                else
                    result = (char)('A'+ (nextDigit-10)) + result;
            } while (i != 0);
            return result;
        }
    }
}
