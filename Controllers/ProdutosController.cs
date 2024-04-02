using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using trabalho.Models;

namespace trabalho.Controllers;

public class ProdutosController : Controller
{
    private readonly ILogger<Controller> _logger;

    public ProdutosController(ILogger<ProdutosController> logger)
    {
        _logger = logger;
    }

    public IActionResult Produto()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Produto(Produto model)
    {
        Console.WriteLine(model.Descricao);
        Console.WriteLine(model.Preco);
        Console.WriteLine(model.NCM);
        Console.WriteLine(model.Quantidade);

        return RedirectToAction("Index", "Home");
    }
}
