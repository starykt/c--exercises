using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceAutenticavel.Models
{
    public interface IAutenticavel
    {
        bool Autenticar(int senha);
    }
}