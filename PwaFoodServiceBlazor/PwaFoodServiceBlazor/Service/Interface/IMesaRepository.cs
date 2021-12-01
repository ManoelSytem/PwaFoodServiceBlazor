using PwaFoodServiceBlazor.Model;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace PwaFoodServiceBlazor.Service.Interface
{
    public interface IMesaRepository
    {
        [Get("/Mesa/ObterListaMesa")]
        Task<List<MesaModel>> ObterListaMesa();
    }
}
