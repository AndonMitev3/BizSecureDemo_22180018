using BizSecureDemo_22180018.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace BizSecureDemo_22180018.Controllers;

[Authorize]
public class HomeController : Controller
{
    private readonly AppDbContext _db;

    public HomeController(AppDbContext db) => _db = db;

    //public async Task<IActionResult> Index()
    //{
    //    // Взимаме ID-то на текущо логнатия потребител от бисквитката (cookie)
    //    var uid = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)!);

    //    // Търсим в базата данни само неговите поръчки
    //    var orders = await _db.Orders
    //        .Where(o => o.UserId == uid)
    //        .OrderByDescending(o => o.Id)
    //        .ToListAsync();

    //    // Подаваме списъка с поръчки към изгледа (View-то)
    //    return View(orders);
    //}
    public async Task<IActionResult> Index()
    {
        // Взима ID-то на логнатия потребител
        var uid = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)!);

        // Чете поръчките от базата спрямо логнатия потребител
        var myOrders = await _db.Orders
            .Where(o => o.UserId == uid)
            .OrderByDescending(o => o.Id)
            .ToListAsync();

        // Чете всички поръчки от базата
        var allOrders = await _db.Orders
            .OrderByDescending(o => o.Id)
            .ToListAsync();

        // Подава всички поръчки към View-то през ViewBag. 
        // ViewBag е „чанта“ за допълнителни данни към View-то. 
        // Така View-то може да показва и публичен списък от поръчки.
        ViewBag.AllOrders = allOrders;

        return View(myOrders);
    }
}