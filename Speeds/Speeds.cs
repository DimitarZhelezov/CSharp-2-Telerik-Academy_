using System;
using System.Collections.Generic;

namespace Speeds
{
    class Speeds
    {
        
        static void Main()
        {


             List<short> currentGroup = new List<short>();
            List<short> speedOfCars = new List<short>();
             
             short maxSpeed = 0;
        int numberOfCars = int.Parse(Console.ReadLine());
            
            for (short i = 0; i < numberOfCars; i++)
            {
                speedOfCars.Add(short.Parse(Console.ReadLine()));
            }
            



            for (int i = 0; i < speedOfCars.Count - 1; i++)
            {
                if (speedOfCars[i] < speedOfCars[i + 1])
                {
                    for (int j = i + 2; j < speedOfCars.Count; j++)
                    {
                        if (speedOfCars[i] < speedOfCars[j])
                        {
                            if (speedOfCars[j] == speedOfCars.Count - 1)
                            {
                                maxSpeed = saveInDataBase(i, j, currentGroup,speedOfCars,maxSpeed);
                            }
                        }
                        else
                        {

                            maxSpeed = saveInDataBase(i, j -1, currentGroup, speedOfCars, maxSpeed);
                            break;
                        }

                    }

                }



            }
            Console.WriteLine(maxSpeed);
        }

        private static short saveInDataBase(int i, int j, List<short> currentGroup, 
            List<short> speedOfCars,short maxSpeed)

        {
            short currentSpeed = 0;
            for (int z = i; z <= j; z++)
            {
                currentGroup.Add(speedOfCars[z]);
            }
            for (int k = 0; k < currentGroup.Count; k++)
            {
                currentSpeed += currentGroup[k];
            }
            if (currentSpeed > maxSpeed)
            {
                maxSpeed = currentSpeed;
            }
            currentSpeed = 0;
            currentGroup.Clear();

            return maxSpeed;
        }
    }

    
}