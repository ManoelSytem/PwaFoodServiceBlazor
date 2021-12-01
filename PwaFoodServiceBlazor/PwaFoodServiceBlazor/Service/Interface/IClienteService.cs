using PwaFoodServiceBlazor.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace PwaFoodServiceBlazor.Service.Interface
{
   public interface IClienteService
    {
        public Task<ClienteModel> ObterCliente();
    }
}
