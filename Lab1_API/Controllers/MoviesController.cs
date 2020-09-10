using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Lab1_API.Helpers;
using Lab1_Arbol_Multicamino;

namespace Lab1_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {

        [HttpPost]
        public string Grado([FromBody] int value)
        {
            Data.Instance.g = value;
            Arbol<Pelicula> temp = new Arbol<Pelicula>(value);
            Data.Instance.Arbol_Pelis = temp;
            return "Se ha creado el arbol de Grado: " + value.ToString();
        }

        [HttpPost]
        [Route("populate")]
        public string Add([FromBody]Pelicula value)
        {
            if (Data.Instance.g != 0)
            {
                Data.Instance.Arbol_Pelis.Insertar(value,Data.Instance.g);
                return "OK";
            }
            else
            {
                return "InternalServerError";
            }
        }

        [HttpGet]
        [Route("InOrder")]
        public IEnumerable<Pelicula> GetIn()
        {
            if(Data.Instance.g != 0)
            {
                Data.Instance.Lista_Pelis = Data.Instance.Arbol_Pelis.InOrder(Data.Instance.g);
                return Data.Instance.Lista_Pelis;
            }
            else
            {
                return Data.Instance.Lista_Pelis;
            }
        }
        [HttpGet]
        [Route("PostOrder")]
        public IEnumerable<Pelicula> GetPost()
        {
            if (Data.Instance.g != 0)
            {
                Data.Instance.Lista_Pelis = Data.Instance.Arbol_Pelis.PostOrder(Data.Instance.g);
                return Data.Instance.Lista_Pelis;
            }
            else
            {
                return Data.Instance.Lista_Pelis;
            }
        }
        [HttpGet]
        [Route("PreOrder")]
        public IEnumerable<Pelicula> GetPre()
        {
            if (Data.Instance.g != 0)
            {
                Data.Instance.Lista_Pelis = Data.Instance.Arbol_Pelis.PreOrder(Data.Instance.g);
                return Data.Instance.Lista_Pelis;
            }
            else
            {
                return Data.Instance.Lista_Pelis;
            }
        }

    }
}
