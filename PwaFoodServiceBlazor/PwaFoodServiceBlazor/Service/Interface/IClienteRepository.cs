using PwaFoodServiceBlazor.Model;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace PwaFoodServiceBlazor.Service.Interface
{
    public interface IClienteRepository
    {
        [Get("/Cliente/ObterClientePorEmail")]
        Task<ClienteModel> ObterCliente(string email);
    }
}
