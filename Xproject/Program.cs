using System.Text.RegularExpressions;

namespace MyNamespace


{
    class MyClass
    {

        static void Main()
        {
            try
            {
                StreamReader sr = new StreamReader("C:\\XX.txt");
                string line = sr.ReadLine();

                while (line !=null)
                {
                    string[] lines = line.Split('\n');

                    foreach (var lineItem in lines)
                    {
                        Match match = Regex.Match(lineItem, @"\(\w+\): ([\+0-9\-X ]+)");

                        if (match.Success)
                        {
                            string phoneNumber = match.Groups[1].Value;
                            phoneNumber = Regex.Replace(phoneNumber, "[^X ]", "");
                            Console.WriteLine(phoneNumber);
                        }
                    }
                    line = sr.ReadLine();
                }
                sr.Close();
                Console.ReadLine();
            }
            catch (Exception)
            {

            }
        }

    }
}