using Project_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_MVC.Data
{
    public static class IESDbInitializer
    {
        public static void Initialize(IESContext context)
        {
            context.Database.EnsureCreated();
            if (context.Departamentos.Any() && context.Instituicoes.Any())
            {
                return;
            }

            var instituicoes = new Instituicao[]
            {
                new Instituicao { Nome = "Ufrj" , Endereco ="Cruz Vermelha"},
                new Instituicao { Nome = "Uff" , Endereco ="Cruz Azul"},
                new Instituicao { Nome = "Ufrj" , Endereco ="Cruz Vermelha"},
                new Instituicao { Nome = "Uff" , Endereco ="Cruz Azul"},
                new Instituicao { Nome = "Ufrj" , Endereco ="Cruz Vermelha"},
                new Instituicao { Nome = "Uff" , Endereco ="Cruz Azul"},
                new Instituicao { Nome = "Ufrj" , Endereco ="Cruz Vermelha"},
                new Instituicao { Nome = "Uff" , Endereco ="Cruz Azul"},
                new Instituicao { Nome = "Ufrj" , Endereco ="Cruz Vermelha"},
                new Instituicao { Nome = "Uff" , Endereco ="Cruz Azul"},
                new Instituicao { Nome = "Ufrj" , Endereco ="Cruz Vermelha"},
                new Instituicao { Nome = "Uff" , Endereco ="Cruz Azul"},
                new Instituicao { Nome = "Ufrj" , Endereco ="Cruz Vermelha"},
                new Instituicao { Nome = "Ufrj" , Endereco ="Cruz Vermelha"},
                new Instituicao { Nome = "Ufrj" , Endereco ="Cruz Vermelha"},
                new Instituicao { Nome = "Uff" , Endereco ="Cruz Azul"},
                new Instituicao { Nome = "Uff" , Endereco ="Cruz Azul"},
                new Instituicao { Nome = "Uff" , Endereco ="Cruz Azul"}
            };
            
            var departamentos = new Departamento[]
            {
                new Departamento { Nome="Ciência da Computação"},
                new Departamento { Nome="Ciência de Alimentos"}
            };
            
            foreach (Departamento d in departamentos)
            {
                context.Departamentos.Add(d);
            }
            context.SaveChanges();

            foreach(Instituicao i in instituicoes)
            {
                context.Instituicoes.Add(i);
            }
            context.SaveChanges();
        }
    }  
}
