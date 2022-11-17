using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceAutenticavel.Models
{
    public class Diretor : Funcionario, IAutenticavel
    {
         public bool Autenticar(int senha) {
            if (Senha == senha) {
                System.Console.WriteLine("Autenticação concluída.");
                return true;
            }    
            return false;    
        }
        
    }
}