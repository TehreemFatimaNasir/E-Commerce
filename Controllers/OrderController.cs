using ecommercestore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

public class OrderController : Controller
{
    private readonly EcommerceDbContext _context;

    public OrderController(EcommerceDbContext context)
    {
        _context = context;
    }
    
    [HttpPost]
    public IActionResult PlaceOrder()
    {
        ViewBag.OrderSuccess = "Your order has been confirmed!";
        return View();
    }



}
