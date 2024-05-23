using Microsoft.AspNetCore.Mvc;
using ViewComponentsExample.Models;

namespace ViewComponentsExample.ViewComponents
{
    public class GridViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(PersonGridModel grid)
        {
            PersonGridModel personGridModel = new PersonGridModel()
            {
                GridTitle = "Perosn List",
                persons = new List<Person>() {
                    new Person {PersonName = "Hassan", JobTitle = "Manager"},
                    new Person {PersonName = "Hussien", JobTitle = "Senior"},
                    new Person {PersonName = "Mohamed", JobTitle = "Junior"},
                    new Person {PersonName = "Ahmed", JobTitle = "DAs"},
                    new Person {PersonName = "Abdallah", JobTitle = "Doctor"},

                }

            };
           // ViewData["Grid"] = model;

            return View("Sample",grid); // Invoked the partial view in Views/Shared/Components/Grid/Default.cshtml
        }
    }
}
