using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04_LightTheTorches
{
    class LightTheTorches
    {
        static void Main(string[] args)
        {
            int numberOfRooms = int.Parse(Console.ReadLine());
            char[] lightInfo = Console.ReadLine().ToCharArray();
            string input = "";

            char[] rooms = LightSwitcher(numberOfRooms, lightInfo);

            int priestCurrPosition = rooms.Length / 2;
            string direction;
            int steps;
            bool isLast = false;
            int count = 0;

            while (input != "END")
            {
                input = Console.ReadLine();

                if (input == "END")
                {
                    break;
                }

                direction = input.Split(' ')[0];
                steps = int.Parse(input.Split(' ')[1]);


                if (isLast == true)
                {
                    count++;
                    if (count == 2)
                    {
                        isLast = false;
                        count = 0;
                    }
                }

                if (direction == "LEFT")
                {
                    priestCurrPosition = priestCurrPosition - steps - 1;
                    if (priestCurrPosition < 0)
                    {
                        priestCurrPosition = 0;
                        isLast = true;
                    }

                    if ((isLast == true) && (count == 1))
                    {

                    }
                    else
                    {
                        rooms[priestCurrPosition] = (rooms[priestCurrPosition] == 'L') ? 'D' : 'L';
                    }


                }
                else if (direction == "RIGHT")
                {
                    priestCurrPosition = priestCurrPosition + steps + 1;
                    if (priestCurrPosition > rooms.Length - 1)
                    {
                        priestCurrPosition = rooms.Length - 1;
                        isLast = true;
                    }

                    if ((isLast == true) && (count == 1))
                    {

                    }
                    else
                    {
                        rooms[priestCurrPosition] = (rooms[priestCurrPosition] == 'L') ? 'D' : 'L';
                    }
                }
            }

            Console.WriteLine(CalcPrays(rooms));
        }

        static char[] LightSwitcher(int numberOfRooms, char[] lightInfo)
        {
            char[] rooms = new char[numberOfRooms];
            int temp = 0;
            int count = 0;

            while (count != rooms.Length)
            {
                if ((count % lightInfo.Length) == 0)
                {
                    temp = 0;
                }

                rooms[count] = lightInfo[temp];
                temp++;
                count++;
            }

            return rooms;
        }

        static int CalcPrays(char[] rooms)
        {
            int prays = 0;

            foreach (char room in rooms)
            {
                if (room == 'D')
                {
                    prays++;
                }
            }

            return prays * 'D';
        }

    }
}
