using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace IBAS_menu.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public List<MenuItem> MenuItems { get {return _menuItems; } }

    public static readonly List<MenuItem> _menuItems =
    [
        new MenuItem { Day = "Monday", WarmDish = "Spaghetti Bolognese", ColdDish = "Greek Salad" },
        new MenuItem { Day = "Tuesday", WarmDish = "Chicken Curry", ColdDish = "Coleslaw" },
        new MenuItem { Day = "Wednesday", WarmDish = "Beef Stroganoff", ColdDish = "Potato Salad" },
        new MenuItem { Day = "Thursday", WarmDish = "Fish & Chips", ColdDish = "Cucumber Salad" },
        new MenuItem { Day = "Friday", WarmDish = "Pizza", ColdDish = "Tomato Salad" },
    ];

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }

    public record MenuItem
    {
        public string? Day { get; set; }
        public string? WarmDish { get; set; }
        public string? ColdDish { get; set; }
    }
}
