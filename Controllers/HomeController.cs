using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SP3044149.Models;

namespace SP3044149.Controllers;

public class UserRequest
{
    public string? Nome { get; set; }
    public string? Email { get; set; }    
}

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger) => _logger = logger;

    public IActionResult Index() => View();

    public IActionResult Privacy() => View();

    public IActionResult PrimeiraAction() => View();

    public IActionResult Form() => View();

    public string TesteQueryString([FromQuery] string q, [FromQuery] string nome) => $"Chegou aqui {q} e {nome}";

    public string TesteForm([FromForm] UserRequest userRequest) => $"Nome: {userRequest.Nome}, E-mail: {userRequest.Email}";

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error() => View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
}
