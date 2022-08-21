namespace WepAppTDD.Models
{
    public class Sum
    {
        public int Execute(string numbers)
        {
            if (numbers == "" || numbers == "0")
            {
                return 0;
            }

            if (numbers.EndsWith(","))
            {
                numbers=numbers.Substring(0, numbers.Length - 1);
            }
            string[] stringsNumber = numbers.Split(",");
            int[] numberArray = Array.ConvertAll(stringsNumber, s => int.Parse(s));
            return numberArray.Sum();
        }
    }
}
