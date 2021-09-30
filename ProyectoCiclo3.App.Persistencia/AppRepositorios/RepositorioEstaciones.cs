using System.Collections.Generic;
using ProyectoCiclo3.App.Dominio;
using System.Linq;
using System;
 
namespace ProyectoCiclo3.App.Persistencia.AppRepositorios
{
    public class RepositorioEstaciones
    {
        List<Estaciones> Estaciones;
 
    public RepositorioEstaciones()
        {
            Estaciones = new List<Estaciones>()
            {
                new Estaciones{id=1,nombre="Estacion # 1",direccion="Calle 1 # 2c -3",coordx= 10000,coordy= 200000,tipo= "tipo 1"},
                new Estaciones{id=2,nombre="Estacion # 2",direccion="Calle 4 # 5a -6",coordx= 30000,coordy= 400000,tipo= "tipo 2"},
                new Estaciones{id=3,nombre="Estacion # 3",direccion="Calle 7 # 8d -9",coordx= 50000,coordy= 600000,tipo= "tipo 3"}
            };
        }
 
        public IEnumerable<Estaciones> GetAll()
        {
            return Estaciones;
        }
 
        public Estaciones GetEstacionWithId(int id){
            return Estaciones.SingleOrDefault(e => e.id == id);
        }
    }
}
