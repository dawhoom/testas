using System;
using System.Collections.Generic;

namespace testas
{
    class Program
    {

        public static void Main(string[] args)
        {
            string goOn = "taip";
            List<int> bilietai10 = new List<int>();
            List<int> bilietai20 = new List<int>();
            List<int> bilietai30 = new List<int>();
            int visoSukurta10 = bilietai10.Count;
            int visoSukurta20 = bilietai20.Count;
            int visoSukurta30 = bilietai30.Count;
          
            
            while (goOn == "taip")
            {
                Console.WriteLine("Sveiki atvykę į bilietų kūrimo programą!");
                
                Console.Write("Kurti bilietus [1]   ");
                Console.Write("Parduoti bilietus [2]   ");
                Console.WriteLine("Bilietu ataskaita [3]   ");

                int vartotojoIvestis = Int32.Parse(Console.ReadLine());
                if (vartotojoIvestis == 1)
                {
                    Console.WriteLine("Pasirinkite bilietu tipa: [1] - po 10 eur; [2] - po 20 eur; [3] - po 30 eur.");
                    int vartotojoIvestis2 = Int32.Parse(Console.ReadLine());
                    switch (vartotojoIvestis2)
                    {
                        case 1:
                            KurtiBilietus10(bilietai10);
                            break;
                        case 2:
                            KurtiBilietus20(bilietai20);
                            break;
                        case 3:
                            KurtiBilietus30(bilietai30);
                            break;
                        default:
                            Console.WriteLine("neteisinga ivestis");
                            break;
                    }
                }
                else if (vartotojoIvestis == 2)
                {
                    Console.WriteLine("Pasirinkite bilietu tipa: [1] - po 10 eur; [2] - po 20 eur; [3] - po 30 eur.");
                    int vartotojoIvestis3 = Int32.Parse(Console.ReadLine());
                    switch (vartotojoIvestis3)
                    {
                        case 1:
                            ParduotiBilietus10(bilietai10);
                            break;
                        case 2:
                            ParduotiBilietus20(bilietai20);
                            break;
                        case 3:
                            ParduotiBilietus30(bilietai30);
                            break;
                        default:
                            Console.WriteLine("neteisinga ivestis");
                            break;
                    }
                }
                else if (vartotojoIvestis == 3)
                {
                    Console.WriteLine($"Is viso sukurta {visoSukurta10} po 10 euru, {visoSukurta20} po 20 euru, {visoSukurta30} po 30 euru");
                    NepanaudotiBilietai(bilietai10, bilietai20, bilietai30);
                }
                else
                {
                    Console.WriteLine("Neteisingas pasirinkimas. Ar norite testi? [taip]/[ne]");
                    goOn = Console.ReadLine(); 
                }
                Console.WriteLine("Ar norite testi? [taip]/[ne]");
                goOn = Console.ReadLine();
            }

        }


        public static int KurtiBilietus10(List <int> bilietai10)
        {
             
             
            Console.WriteLine("Kiek bilietu po 10 euru noresite sukurti?");
            string naujibilietai10 = Console.ReadLine();
            
            if (int.TryParse(naujibilietai10, out int bilietai10skaicius))
            {
                for (int i = 0; i < bilietai10skaicius; i++)
                {
                    bilietai10.Add(i);
                }
            }
            else
            {
                Console.WriteLine("Ivedete netinkama skaiciu bilietu");
            }
            Console.WriteLine($"Sukurta {bilietai10skaicius} bilietu");
            return bilietai10skaicius;
        }

        static int KurtiBilietus20(List<int> bilietai20)
        {


            Console.WriteLine("Kiek bilietu po 20 euru noresite sukurti?");
            string naujibilietai20 = Console.ReadLine();

            if (int.TryParse(naujibilietai20, out int bilietai20skaicius))
            {
                for (int i = 0; i < bilietai20skaicius; i++)
                {
                    bilietai20.Add(i);
                }
            }
            else
            {
                Console.WriteLine("Ivedete netinkama skaiciu bilietu");
            }
            Console.WriteLine($"Sukurta {bilietai20skaicius} bilietu");
            return bilietai20skaicius;
        }

        static int KurtiBilietus30(List<int> bilietai30)
        {


            Console.WriteLine("Kiek bilietu po 30 euru noresite sukurti?");
            string naujibilietai30 = Console.ReadLine();

            if (int.TryParse(naujibilietai30, out int bilietai30skaicius))
            {
                for (int i = 0; i < bilietai30skaicius; i++)
                {
                    bilietai30.Add(i);
                }
            }
            else
            {
                Console.WriteLine("Ivedete netinkama skaiciu bilietu");
            }
            Console.WriteLine($"Sukurta {bilietai30skaicius} bilietu");
            return bilietai30skaicius;
        }

        static int ParduotiBilietus10(List<int> bilietai10)
        {
            Console.WriteLine("Kiek bilietu po 10 euru noresite parduoti?");
            string naujibilietai10 = Console.ReadLine();
            Console.WriteLine($"Parduota {naujibilietai10} bilietu");
            if (int.TryParse(naujibilietai10, out int bilietai10skaicius))
            {
                for (int i = bilietai10skaicius -1; i < bilietai10skaicius; i--)
                {
                    bilietai10.Remove(i);
                }
            }
            else
            {
                Console.WriteLine("Ivedete netinkama skaiciu bilietu");
            }
            Console.WriteLine($"Parduota {bilietai10skaicius} bilietu");
            return bilietai10skaicius;
        }

        static int ParduotiBilietus20(List<int> bilietai20)
        {
            Console.WriteLine("Kiek bilietu po 20 euru noresite parduoti?");
            string naujibilietai20 = Console.ReadLine();
            Console.WriteLine($"Parduota {naujibilietai20} bilietu");
            if (int.TryParse(naujibilietai20, out int bilietai20skaicius))
            {
                for (int i = bilietai20skaicius - 1; i < bilietai20skaicius; i--)
                {
                    bilietai20.Remove(i);
                }
            }
            else
            {
                Console.WriteLine("Ivedete netinkama skaiciu bilietu");
            }
           
            return bilietai20skaicius;
        }

        static int ParduotiBilietus30(List<int> bilietai30)
        {
            Console.WriteLine("Kiek bilietu po 20 euru noresite parduoti?");
            string naujibilietai30 = Console.ReadLine();
            Console.WriteLine($"Parduota {naujibilietai30} bilietu");
            if (int.TryParse(naujibilietai30, out int bilietai30skaicius))
            {
                for (int i = bilietai30skaicius - 1; i < bilietai30skaicius; i--)
                {
                    bilietai30.Remove(i);
                }
            }
            else
            {
                Console.WriteLine("Ivedete netinkama skaiciu bilietu");
            }
            
            return bilietai30skaicius;
        }

        static void NepanaudotiBilietai(List <int> bilietai10, List<int> bilietai20, List<int> bilietai30)
        {
            Console.WriteLine($"Uz 10 euru bilietu likutis {KurtiBilietus10(bilietai10)- ParduotiBilietus10(bilietai10)}");
            Console.WriteLine($"Uz 20 euru bilietu likutis {KurtiBilietus20(bilietai20) - ParduotiBilietus20(bilietai20)}");
            Console.WriteLine($"Uz 30 euru bilietu likutis {KurtiBilietus30(bilietai10) - ParduotiBilietus30(bilietai30)}");
        }



    }

}
