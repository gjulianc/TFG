using EFCore;
using EFData;
using System;
using System.Collections.Generic;

namespace ConsoleClientModelFirst
{
    class Program
    {
        static void Main(string[] args)
        {

            using (EFDbContext context = new EFDbContext())
            {
                Vehiculo student = new Vehiculo
                {
                    Matricula = "2387FJF",
                    Marca = "AUDI",
                    Modelo = "A4",
                    Transacciones = new List<Transaccion>
                    {
                        new Transaccion
                        {
                            Fecha = DateTime.Today,
                            Importe = 56.18m,
                            Litros = 80.35m,
                        },
                        new Transaccion
                        {
                            Fecha = DateTime.Today,
                            Importe = 60,
                            Litros = 90,
                        },
                    }
                };
                   
                context.Entry(student).State = System.Data.Entity.EntityState.Added;
                context.SaveChanges();
            }
            System.Console.ReadLine();
        }
    }
}
