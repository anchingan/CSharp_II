using System;


namespace csharp_II
{
    class MainClass
    {
		static int number, count = 0;
		static double total = 0, num;
        static string[] allStrings = new string[50];

        public static void Main(string[] args){
            string input;
            while (true){
                Console.WriteLine("a) Add, b) Output, c)Quit: ");
                input = Console.ReadLine();
                if (input == "a")
                    Add();
                else if (input == "b")
                {
                    Console.WriteLine("Sum:{0:f2}",total);
                    for (int i = 0; i < count; i++)
                        Console.WriteLine(allStrings[i]);
                }
                else if (input == "c")
                    break;
            }

        }

        public static void Add(){
            char[] space = { ' ', '\n', '\t', ',', ';', ':'};
            char[] comma = { '.' };
            int nums = 0;
            Console.WriteLine("Input a sentence:");
            string[] words = Console.ReadLine().Split(space);

            for (int i = 0; i < words.Length; i++)
            {
                if (Int32.TryParse(words[i], out number))
                {
                    total += System.Convert.ToDouble(number);
                    words[i] = null;
                }
                else if (Double.TryParse(words[i], out num))
                {
                    total += num;
                    words[i] = null;
                }
                if (words[i] != null && words[i] != "")
                {
                    if (count + 1 >= allStrings.Length)
                        Array.Copy(allStrings, allStrings, count * 2);
                    string[] temp = words[i].Split(comma);
                    if (temp.Length > 1)
                    {
                        if (temp[0] != null && temp[0] != "")
                        {
                            allStrings[count++] = temp[0];
                            nums++;
                        }
                        if (temp[1] != null && temp[1] != "")
                        {
                            allStrings[count++] = temp[1];
                            nums++;
                        }
                    }
                    else
                    {
                        allStrings[count++] = words[i];
                        nums++;
                    }
				}
			}
            if (nums != 0)
                Console.WriteLine("{0} words inserted!", nums);
            if (count != 0)
                allStrings = InsertionSort(allStrings, count - 1);
        }

        public static string[] InsertionSort(string[] strings, int numOfString){
            if (numOfString == 0)
            {
            }
            else {
                strings = InsertionSort(strings, numOfString - 1);
                for (int i = numOfString; i > 0; i--){
                    if (String.Compare(strings[i], strings[i - 1], true) < 0){
                        string temp = strings[i];
                        strings[i] = strings[i - 1];
                        strings[i - 1] = temp;
                    }
                }
            }
            return strings;
        }
    }
}
