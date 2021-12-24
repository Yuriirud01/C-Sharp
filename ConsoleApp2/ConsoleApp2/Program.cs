using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace MyApp // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public enum Season
        {
            Winter,
            Spring,
            Summer,
            Autumn
        }
        public static void Main(string[] args)
        {
            /*            byte number = 128;
                        int otherNum = 10;
                        float myFloat = 20.5f;
                        char character = 'D';
                        string name = "George";
                        bool isTrue = false;
                        Console.WriteLine(number);
                        Console.WriteLine(otherNum);
                        Console.WriteLine(myFloat);
                        Console.WriteLine(character);
                        Console.WriteLine(name);
                        Console.WriteLine(isTrue); 
                        int i = number;
                        byte b = (byte)i;


                        try
                        {
                            string num = "1234";
                            int c = Convert.ToInt32(num);
                            byte z = Convert.ToByte(num);
                            Console.WriteLine(c);
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Can't Convert");
                        }

                        var x = 10;
                        var y = 3;
                        Console.WriteLine(x / y);
                        Console.WriteLine((float)x / (float)y);
                        Console.WriteLine(x + y * number);
                        Console.WriteLine((x != y)); 

            var George = new Person();
            George.FirstName = "George";
            George.LastName = "Malkovich";
            George.Introduce();

            int[] numbers = new int[3] { 1, 2, 3 };

            var seas = Season.Winter;

            string num = Console.ReadLine();

            if (Convert.ToInt32(num) > 0 && Convert.ToInt32(num) <= 10)
                Console.WriteLine("Your number is valid.");
            else
                Console.WriteLine("Number is incorrect.");

            string a = Console.ReadLine();
            string b = Console.ReadLine();

            if (Convert.ToInt32(a) > Convert.ToInt32(b))
                Console.WriteLine(a);
            else if (Convert.ToInt32(a) == Convert.ToInt32(b))
                Console.WriteLine("They are equal.");
            else
                Console.WriteLine(b);

            int limit = 120;
            string strspeed = Console.ReadLine();
            int speed = Convert.ToInt32(strspeed);
            if (speed > limit)
                if ((speed - limit) / 5 > 12)
                    Console.WriteLine("License Suspended.");
                else
                    Console.WriteLine("You speed is higher then allowed. Please, slow down.");
            else
                Console.WriteLine("speed is OK."); 

            int counter = 0;
            for (var i = 1; i < 100; i++)
                if (i % 3 == 0)
                    counter++;
                    Console.WriteLine(counter);

            int counter2 = 0;
            while(true)
            {
                Console.WriteLine("Please enter a number (Enter ok to exit).");
                string n = Console.ReadLine();
                counter2++;
                if (n == "ok") {
                    counter2--;
                    Console.WriteLine(counter2);
                    break; 
                }
                    
            }

            string factor = Console.ReadLine();
            int res = 1;
            for (var i = Convert.ToInt32(factor); i > 1; i--)
                res *= i;
            Console.WriteLine(res); 


            var rand = new Random();
            int guess = rand.Next(1, 10);
            int counter3 = 0;
            while (counter3 < 5) {
                if (counter3 == 4) {
                    Console.WriteLine("You lost(");
                    break;
                }
                string userTry = Console.ReadLine();
                counter3++;
                if (Convert.ToInt32(userTry) == guess) {
                    Console.WriteLine("You won!");
                    break;
                }  

            string list = Console.ReadLine();
            string[] list2 = list.Split(',');
            int biggest = 0;
            foreach (string s in list2)
            {
                if (Convert.ToInt32(s) > biggest) {
                    biggest = Convert.ToInt32(s);
                }
            }
            Console.WriteLine(biggest);

            var numbers = new List<int>();
            numbers.Add(15);
            Console.WriteLine(numbers); 

            var names = new List<string>();
            while (true)
            {
                string name = Console.ReadLine();
                if (name == "")
                {
                    Console.WriteLine("Program stopped");
                    break;
                }
                else
                {
                    names.Add(name);
                    if (names.Count == 1)
                    {
                        Console.WriteLine(names[0] + " likes your post");
                    }
                    else if (names.Count == 2)
                    {
                        Console.WriteLine(names[0] + " and " + names[1] + " like your post");
                    }
                    else
                    {

                        Console.WriteLine(names[0] + ", " + names[1] + " and " + (names.Count - 2) + " others like your post");
                    }
                }
            } 


            string name = Console.ReadLine();
            char[] nameArr = new char[name.Length];
            for (var i = 0; i < name.Length; i++)
            {
                nameArr[i] = name[i];
            }
            Array.Reverse(nameArr);
            string res = string.Join("", nameArr);
            Console.WriteLine(res); 


            int counter = 0;
            int[] myArr = new int[5];
            while (counter < 5)
            {
                int num = Convert.ToInt32(Console.ReadLine());
                if (myArr.Contains(num))
                {
                    Console.WriteLine("You already have this number in array, please enter another one.");
                    continue;
                }
                else
                {
                    myArr[counter] = num;
                    counter++;
                }  
            }
            Array.Sort(myArr);
            Console.WriteLine(String.Join(", ", myArr)); 

            var nums = new List<int>();
            while (true)
            {
                var num = Console.ReadLine();
                if (num == "quit")
                {
                    Console.WriteLine(String.Join(", ", nums.Distinct()));
                    break;
                }
                else
                {
                    nums.Add(Convert.ToInt32(num));
                }
            } 


            var nums = new List<int>();
            while (true)
            {
                string numbers = Console.ReadLine();
                string[] charnums = numbers.Split(",");
                for (var i = 0; i < charnums.Length; i++)
                {
                    nums.Add(Convert.ToInt32(charnums[i]));
                }
                if (nums.Count >= 5)
                {
                    break;
                }
                else
                {
                    nums.Clear();
                    Console.WriteLine("List is too short. Enter it again.It will work only if it has 5 or more numbers.");
                }   
            }

            var smallnums = new List<int>();
            int smallnum = nums[0];
            while (smallnums.Count < 3)
            {
                smallnums.Add(nums.Min());
                nums.Remove(nums.Min());
            }
            Console.WriteLine(String.Join(", ", smallnums)); 

            var numbers = "5-4-3-2-2";
            string[] numList = numbers.Split("-");
            int[] numIntList = Array.ConvertAll(numList, int.Parse);
            for (int i = 0; i < numIntList.Length; i++)
            {   
                if (i + 1 == numIntList.Length)
                {
                    Console.WriteLine("Consecutive");   
                    break;
                }
                if (numIntList[i] - numIntList[i + 1] == 1 || numIntList[i] - numIntList[i + 1] == -1)
                    continue;
                else
                {
                    Console.WriteLine("Non Consecutive");
                    break;
                }
            }  

            var numbers = "5-5-4-8-2-2-3-4-8-3";
            string[] numList = numbers.Split("-");
            int[] numIntList = Array.ConvertAll(numList, int.Parse);
            for(var i = 0; i < numIntList.Length; i++)
            {
                for (var j = i + 1; j < numIntList.Length; j++)
                {
                    if (numIntList[i] == numIntList[j])
                    {
                        Console.WriteLine(numIntList[i]);
                    }
                }
            } 

            var time = "20:30";
            int[] intTime = Array.ConvertAll(time.Split(":"), int.Parse);
            if (0 <= intTime[0] && intTime[0] <= 23)
            {
                if (intTime[1] >= 0 && intTime[1] <= 59)
                {
                    Console.WriteLine("Correct Format");
                }
                else
                {
                    Console.WriteLine("Incorrect Format");
                }
            }
            else
            {
                Console.WriteLine("Incorrect Format");
            } 

            string words = Console.ReadLine();
            string[] wordsSplit = words.Split(" ");
            for (var i = 0; i < wordsSplit.Length; i++)
            {
                Console.Write(char.ToUpper(wordsSplit[i][0]) + wordsSplit[i].Substring(1));
            } */

            string word = Console.ReadLine();
            char[] chars = word.ToCharArray();
            int counter = 0;
            var vowels = new List<char>() { 'a', 'e', 'i', 'o', 'u' };
            foreach (char ch in chars)
            {
                foreach(char ch2 in vowels)
                {
                    if (ch == ch2)
                    {
                        counter++;
                    }
                }
            }
            Console.WriteLine(counter);


        }


    }
    }
