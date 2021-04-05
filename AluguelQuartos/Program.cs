using System;

namespace AluguelQuartos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many rooms will be rented? ");
            int qtdRooms = int.Parse(Console.ReadLine());

            Quartos[] vect = new Quartos[10];

            for(int i = 0; i < qtdRooms; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Rent #{i + 1}:");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Room: ");
                int numberRoom = int.Parse(Console.ReadLine());

                vect[numberRoom] = new Quartos { Name = name, Email = email, Room = numberRoom };
                
            }

            Console.WriteLine();
            Console.WriteLine("Busy rooms:");
            for (int i = 0; i < 10; i++)
            {
               
                if (vect[i] != null)
                {
                    
                    Console.WriteLine($"{vect[i].Room}: {vect[i].Name}, {vect[i].Email}");

                }
                
            }
        }
    }
}
