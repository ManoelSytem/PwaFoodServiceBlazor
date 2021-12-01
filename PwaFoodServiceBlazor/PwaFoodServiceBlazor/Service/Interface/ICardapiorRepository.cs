﻿using PwaFoodServiceBlazor.Model;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace PwaFoodServiceBlazor.Service.Interface
{
    public interface ICardapiorRepository
    {
        [Get("/Cardapio/GetCardapioPrincipalMenu")]
        Task<List<MenuModel>> GetCardapioPrincipalMenu();
        [Post("/Produto/GetListProdutoPorListaProduto")]
        Task<List<ProdutoModel>> GetListProdutoPorListProduto(List<int> listProduto);
        [Get("/Cardapio/GetMenuPorMenuSeq")]
        Task<List<MenuModel>> GetMenuPorMenuSeq(string codSeqMenu);
    }
}
