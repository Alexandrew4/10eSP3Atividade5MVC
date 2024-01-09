using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LHPet.Models;

namespace LHPet.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        Cliente cliente1 = new Cliente(01,"Arthur Ferreira","888.777.666-55","arthur.ferreira@senai.br","Madruga");
        Cliente Cliente2 =  new Cliente(02, "William Gates","777.666.555.-02","gates@senai.br","Bug");
        Cliente cliente3 = new Cliente(03,"Ada Lovelace","666.555.444-03","ada@senai.br","Byron");

        List<Cliente> listaClientes = new List<Cliente>();
        listaClientes.Add(cliente1);
        listaClientes.Add(Cliente2);
        listaClientes.Add(cliente3);

        ViewBag.listaClientes = listaClientes;



        Fornecedor fornecedor1 = new Fornecedor(01,"C# PET S/A","14.182.102/0001-80","c-sharp@peg.org");
        Fornecedor fornecedor2 = new Fornecedor(02,"Crtl Alt Dog","15.836.698/0001-57","crtl@alt.org");
        Fornecedor fornecedor3 = new Fornecedor(03,"BootsPet INC","40.810.224/0001-83","boots.pet@inc.br");

        

        List<Fornecedor> listaFornecedores = new List<Fornecedor>();
        listaFornecedores.Add(fornecedor1);
        listaFornecedores.Add(fornecedor2);
        listaFornecedores.Add(fornecedor3);
        
     
        ViewBag.listaFornecedores = listaFornecedores;


        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
