using BookApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace BookApi.Filters
{
    public class PublishedYearValidationFilter : IActionFilter
    {
        public void OnActionExecuting(ActionExecutingContext context)
        {
            if (context.ActionArguments.Values.FirstOrDefault(v => v is Book) is Book book)
            {
                if (book.PublishedYear.HasValue && book.PublishedYear > DateTime.Now.Year)
                {
                    context.Result = new BadRequestObjectResult("Published year cannot be in the future.");
                }
            }
        }

        public void OnActionExecuted(ActionExecutedContext context) { }
    }
}
