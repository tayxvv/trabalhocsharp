using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using trabalho.Models;

namespace trabalho.Controllers;

public class PessoasController : Controller
{
    private readonly ILogger<Controller> _logger;

    public PessoasController(ILogger<PessoasController> logger)
    {
        _logger = logger;
    }

    public IActionResult Pessoa()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Pessoa(Pessoa model)
    {
        Console.WriteLine(model.Nome);
        Console.WriteLine(model.Sobrenome);
        Console.WriteLine(model.Endereco);
        Console.WriteLine(model.Cidade);
        Console.WriteLine(model.CEP);
        Console.WriteLine(model.Telefone);

        return RedirectToAction("Index", "Home");
    }
}
