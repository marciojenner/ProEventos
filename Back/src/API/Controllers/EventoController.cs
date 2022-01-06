using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Win32;

using API.Models;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase{
        public IEnumerable<Evento> eventos = new Evento[]{
            new Evento(){
                EvendoId =1,
                Tema = "Angular 11 e .Net 5",
                Local = "Brasilia",
                Lote = "1º Lote",
                QtdPessoas = 250,
                DataEvento  = DateTime.Now.AddDays(2).ToString(),
                ImageUrl = "foto.png"
            },
                new Evento(){
                EvendoId =2,
                Tema = "C# e .Net 5",
                Local = "Brasilia",
                Lote = "1º Lote",
                QtdPessoas = 100,
                DataEvento  = DateTime.Now.AddDays(5).ToString(),
                ImageUrl = "foto.png"
            }
        };

        public EventoController(){
          
        }

        [HttpGet]
        public IEnumerable<Evento> Get(){
            return  this.eventos;
        }

        [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id){
              return  this.eventos.Where(Eventos => Eventos.EvendoId == id);
        }

        [HttpPost]
        public string Post(){
            return "exemplo de post";
        }

        
        [HttpPut("{id}")]
        public string Put(int id){
            return $"exemplo de Put com id {id}";
        }

        [HttpDelete("{id}")]
        public string Delete(int id){
            return  $"exemplo de Delete com id {id}";
        }
    }
}
