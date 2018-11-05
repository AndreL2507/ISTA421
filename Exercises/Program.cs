using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VertexDistance
{
    class Program
    {
        public static double[] closest = new double[3];
        static void Main(string[] args)
        {
            /* 
             List<int> xvalues = new List<int>();
             List<int> yvalues = new List<int>();

             Random rndvalue = new Random();
             fillX(xvalues, rndvalue);
             fillY(yvalues, rndvalue);

             foreach (int x in xvalues)
             {
                 Console.WriteLine(x);
             }

             Console.WriteLine("Get distance method");
             getDistance(xvalues, yvalues);
             */
            int[,] vectors = new int [1000, 3];
            Random rnd = new Random();

            for(int i = 0; i < vectors.GetLength(0); i++)
            {
                
                for(int j = 0; j < vectors.GetLength(1); j++)
                {
                    vectors[i, j] = rnd.Next(1, 1001);
                   
                }
                
            }

            getDistance(vectors);
            Console.WriteLine($"The closest distance is between points: {closest[0]} and {closest[1]} , with a distance of {closest[2]}");
     
            

            


        }

        private static void getDistance(int[,] vectors)
        {
            double distance2 = double.PositiveInfinity;
            for (int i = 0; i < vectors.GetLength(0); i++)
            {
                for (int j = i + 1; j < vectors.GetLength(0); j++)
                {
                    double xdiff = (int)Math.Pow((vectors[i,0] - vectors[j,0]), 2);
                    double ydiff = (int)Math.Pow((vectors[i,1] - vectors[j,1]), 2);
                    double zdiff = (int)Math.Pow((vectors[i,2] - vectors[j,2]), 2);
                    double distance = Math.Sqrt(xdiff + ydiff + zdiff);

                    if (distance < distance2)
                    {
                        closest[0] = i;
                        closest[1] = j;
                        closest[2] = distance; 
                        distance2 = distance;
                        
                    }
                }
            }
        }


        /*
         private static void getDistance(List<int> xvalues, List<int> yvalues)
         {
               Console.WriteLine("in method");
               double distance = double.PositiveInfinity;
               double xdiff = 0;
               foreach(int x in xvalues)
               {
                       for(int i = 0; i < xvalues.Count; i++)
                       {
                            for(int j = i + 1; j < xvalues.Count; j++)
                            {
                                 xdiff = Math.Pow((j-i), 2);
                                if (xdiff < distance)
                                {
                                    distance = xdiff;
                                }
                                else
                                    continue;
                               
                            }
                    Console.WriteLine(xdiff);

                }
              
               }
              

         }

            private static void fillY(List<int> yvalues, Random rndvalue)
            {
               for (int i = 0; yvalues.Count < 100; i++)
               {
                   i = rndvalue.Next(1, 100);
                   yvalues.Add(i);
               }
            }

            private static void fillX(List<int> xvalues, Random rndvalue)
            {

                   for (int i = 0; xvalues.Count < 100; i++)
                   {
                       i = rndvalue.Next(1, 100);
                       xvalues.Add(i);
                   }

                }
                */
    }
}
