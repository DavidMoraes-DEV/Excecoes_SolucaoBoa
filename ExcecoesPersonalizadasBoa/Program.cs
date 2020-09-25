using ExcecoesPersonalizadas.Entities;
using ExcecoesPersonalizadasBoa.Entities.Exceptions;
using System;

namespace ExcecoesPersonalizadas
{
    class Program
    {
        static void Main(string[] args)
        {
            try //Possibilita executar o código de forma linear sem if e else e se tudo der certo sem ocorrer exceções, e caso ocorra irá será "capturado" e tratado pelo o catch
            {
                Console.Write("Room number: ");
                int number = int.Parse(Console.ReadLine());
                Console.WriteLine("Check-in date (dd//MM/yyyy): ");
                DateTime checkIn = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Check-Out date (dd/MM/yyyy): ");
                DateTime checkOut = DateTime.Parse(Console.ReadLine());

                /* SOLUÇÃO BOA:

                */
                Reservation reservation = new Reservation(number, checkIn, checkOut);
                Console.WriteLine("Reservation: " + reservation);

                Console.WriteLine();
                Console.WriteLine("Enter data to update the reservation:");
                Console.WriteLine("Check-in date (dd//MM/yyyy): ");
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Check-Out date (dd/MM/yyyy): ");
                checkOut = DateTime.Parse(Console.ReadLine());

                reservation.UpdateDates(checkIn, checkOut);

                Console.WriteLine("Reservation: " + reservation);
            }
            catch (DomainException e)
            {
                Console.WriteLine("Error in reservation: " + e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Format Error: " + e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine("Unexpected Error: " + e.Message);
            }
        }
    }
}
