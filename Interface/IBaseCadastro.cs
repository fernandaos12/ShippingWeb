using ShippingSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingSystem.Interface
{
    public interface IBaseCadastro
    {
        /// <summary>
        /// traz a lista de clientes 
        /// </summary>
        IEnumerable<Cliente> ClientesCadastroId { get; }
        //buscar ranking de clientes
        IEnumerable<Cliente> ClientesRanking { get; }
        //buscar clientes por id
        Cliente GetClientesById(int Id);

    
    }

}