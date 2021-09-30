using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProyectoCiclo3.App.Persistencia.AppRepositorios;
using ProyectoCiclo3.App.Dominio;
 
namespace ProyectoCiclo3.App.Frontend.Pages{

    public class ListEstacionesModel : PageModel{
        private readonly RepositorioEstaciones RepositorioEstaciones;
        public IEnumerable<Estaciones> Estaciones {get;set;}
 
    public ListEstacionesModel(RepositorioEstaciones RepositorioEstaciones){
        this.RepositorioEstaciones=RepositorioEstaciones;
    }
 
    public void OnGet(){
        Estaciones=RepositorioEstaciones.GetAll();
    }
    
    }
}
