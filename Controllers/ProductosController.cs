using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Tarea3.Models;

namespace Tarea3.Controllers
{
    public class ProductosController : Controller
    {
         public IActionResult Lista()
        {
            var lista = new List<producto>
            {
                new producto { nombre = "Collar", tipo = "Accesorio", precio = 15.50m },
                new producto { nombre = "Comida Perro", tipo = "Alimento", precio = 25.00m },
                new producto { nombre= "Pelota", tipo = "Juguete", precio = 8.75m }
            };

            return View(lista);
        }
    }
}