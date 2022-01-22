using System;
using Microsoft.EntityFrameworkCore;
using MySQL.Data.EntityFrameworkCore;

namespace ReadData
{
    class Program
    {
        static void Main(string[] args)
        {
           using(var db = new AppInstitutoContext()) {
               var profesores = db.Profesor.AsNoTracking(); // IQueryable
               foreach(var profesor in profesores) {
                   Console.WriteLine(profesor.dni+ " --- " +profesor.nombre + " ---- " + profesor.direccion );
               }
           } 
        }
    }
}
