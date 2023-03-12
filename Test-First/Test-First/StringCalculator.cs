using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Test_First
{
    public class StringCalculator
    {
        public int Add(string numbers)
        {
            char[] delimiters = new char[] { ',', '\n' };
            string[] numberArray = null;
            int sum = 0;
            List<int> negativeNumbers = new List<int>();

            // Prüfe, ob ein neuer Delimiter in der Eingabe enthalten ist
            if (numbers.StartsWith("//"))
            {
                int delimiterEndIndex = numbers.IndexOf('\n');
                string delimiterString = numbers.Substring(2, delimiterEndIndex - 2);
                delimiters = new char[] { delimiterString[0] };

                // Entferne die erste Zeile mit dem Delimiter aus dem Eingabestring
                numbers = numbers.Substring(delimiterEndIndex + 1);
            }

            numberArray = numbers.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < numberArray.Length; i++)
            {
                if (int.TryParse(numberArray[i], out int number))
                {
                    if (number < 0)
                    {
                        negativeNumbers.Add(number);
                    }
                    else
                    {
                        sum += number;
                    }
                }
                else
                {
                    throw new ArgumentException($"Ungültige Zahl gefunden: {numberArray[i]}");
                }
            }

            if (negativeNumbers.Count > 0)
            {
                throw new InvalidOperationException($"negatives not allowed {string.Join(", ", negativeNumbers)}");
            }

            return sum;
        }







    }
}

