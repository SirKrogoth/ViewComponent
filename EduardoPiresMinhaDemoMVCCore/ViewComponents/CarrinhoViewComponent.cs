using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduardoPiresMinhaDemoMVCCore.ViewComponents
{
    //Chamada
    [ViewComponent(Name = "Carrinho")]
    public class CarrinhoViewComponent : ViewComponent
    {
        public int ItemCarrinho { get; set; }

        public CarrinhoViewComponent()
        {
            ItemCarrinho = 3;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(ItemCarrinho);
        }
    }
}
