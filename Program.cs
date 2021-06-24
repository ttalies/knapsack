using System;
using System.Collections.Generic;

namespace KnapsackProblem
{
    class Program {
        static int[] weights = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        static float[] price = { 0, 1, 5, 3, 5, 2, 4, 6, 2, 1 };
        static int maxWeight = 15;
        static List<string> combi = new List<string>();        

        static void fill() { 
            //TODO: recursive
            for (int i = 0; i < weights.Length; i++) {
                combi.Add(i.ToString());
                for (int j = i + 1; j < weights.Length; j++) {
                    combi.Add(i.ToString() + ";" + j.ToString());
                    for (int k = j + 1; k < weights.Length; k++) {
                        combi.Add(i.ToString() + ";" + j.ToString() + ";" + k.ToString());
                        for (int m = k + 1; m < weights.Length; m++) {
                            combi.Add(i.ToString() + ";" + j.ToString() + ";" + k.ToString() + ";" + m.ToString());
                            for (int h = m + 1; h < weights.Length; h++) {
                                combi.Add(i.ToString() + ";" + j.ToString() + ";" + k.ToString() + ";" + m.ToString() + ";" + h.ToString());
                                for (int b = h + 1; b < weights.Length; b++) {
                                    combi.Add(i.ToString() + ";" + j.ToString() + ";" + k.ToString() + ";" + m.ToString() + ";" + h.ToString() + ";" + b.ToString());
                                    for (int c = b + 1; c < weights.Length; c++) {
                                        combi.Add(i.ToString() + ";" + j.ToString() + ";" + k.ToString() + ";" + m.ToString() + ";" + h.ToString() + ";" + b.ToString() + ";" + c.ToString());
                                        for (int x = c + 1; x < weights.Length; x++) {
                                            combi.Add(i.ToString() + ";" + j.ToString() + ";" + k.ToString() + ";" + m.ToString() + ";" + h.ToString() + ";" + b.ToString() + ";" + c.ToString() + ";" + x.ToString());
                                            for (int y = x + 1; y < weights.Length; y++) {
                                                combi.Add(i.ToString() + ";" + j.ToString() + ";" + k.ToString() + ";" + m.ToString() + ";" + h.ToString() + ";" + b.ToString() + ";" + c.ToString() + ";" + x.ToString() + ";" + y.ToString());
                                                for (int z = y + 1; z < weights.Length; z++) {
                                                    combi.Add(i.ToString() + ";" + j.ToString() + ";" + k.ToString() + ";" + m.ToString() + ";" + h.ToString() + ";" + b.ToString() + ";" + c.ToString() + ";" + x.ToString() + ";" + y.ToString() + ";" + z.ToString());
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        static float calc(string combi) {
            float sum = 0;
            var list = combi.Split(";");
            foreach (var item in list) { sum += price[Int32.Parse(item)]; }
            return sum;
        }

        static void pack() {
            float maxPrice = 0;
            string bestCombi = "";
            fill();
            foreach (var item in combi) {
                if (calc(item.ToString()) <= maxWeight) {
                    if (calc(item.ToString()) > maxPrice)  {
                        maxPrice = calc(item.ToString());
                        bestCombi = item;
                    }
                }
            }
            Console.WriteLine("Found combination -> " + bestCombi.ToString());
            Console.WriteLine("Weight -> " + calc(bestCombi.ToString()));
            Console.WriteLine("Price -> " + maxPrice.ToString());            
            Console.WriteLine("_________________________");                
        }

        static void Main(string[] args) {
            Console.WriteLine("Rucksack/Knapsack Problem");
            Console.WriteLine("_________________________");
            pack();
        }
    }
}