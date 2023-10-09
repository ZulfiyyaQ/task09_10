using System.Text;

namespace task09_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Metn daxil edin");
            string Text = Console.ReadLine().Trim();

            string[] arr = Text.Split(' ');

            StringBuilder NewText = new StringBuilder();

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Trim().Length > 0)
                {
                    string capitalizedWord = Capitalize(arr[i]);
                    NewText.Append(capitalizedWord);

                    if (i < arr.Length - 1)
                    {
                        NewText.Append(' ');
                    }
                }
            }

            Console.WriteLine("Daxil edilmis metn: " + Text);
            Console.WriteLine("Formatlasdirilmis metn: " + NewText.ToString());
        }

        public static string Capitalize(string arr)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Char.ToUpper(arr[0]));

            for (int i = 1; i < arr.Length; i++)
            {
                sb.Append(Char.ToLower(arr[i]));
            }

            return sb.ToString();
        }
    }
}