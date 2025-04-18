namespace ContadorMVC.Controllers;
using Microsoft.AspNetCore.Mvc;

public class ContadorController : Controller 
{
  public IActionResult Index(int? valor) 
  {
    int contador = valor ?? 0;
    return View(contador);
  }
}
