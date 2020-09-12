using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Lab1_API.Helpers;
using Lab1_Arbol_Multicamino;
using System.Text.Json;

namespace Lab1_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            string mensaje = "Laboratorio 1 - Inicio Exitoso...\n * Cree su arbol - Mande un numero para crear el grado del arbol \n * Mande sus inserciones en desde postman por medio de una lista de peliculas agregando a la url '/populate'\n * Verifique la información por medio de modificar la url con los recorridos /InOrder  /PostOrder /PreOrder \n";
            return mensaje;
        }

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
        public string Add([FromBody]List<Pelicula> value)
        {
            try
            {
                if (Data.Instance.g != 0)
                {
                    for (int i = 0; i < value.Count; i++)
                    {
                        Data.Instance.Arbol_Pelis.Insertar(value[i], Data.Instance.g);
                    }
                    return "OK";
                }
                else
                {
                    return "Debe de crear su arbol primero";
                }
            }
            catch (InvalidCastException e)
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
