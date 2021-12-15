using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using MyToDoList.Models;

namespace MyToDoList.Pages
{
    public class IndexModel : PageModel
    {
        
       
        public List<Models.Movie> Movies { get; set; }

        
        
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            
            _logger = logger;
        }

        // default method to get all todo items from database
        public void OnGet()
        {

            Movies = new List<Movie>
{
    new Movie{  Title = "Monk", Description="Mank is an American biographical drama film directed by David Fincher. The film is based on the life of screenwriter Herman J. Mankiewicz and how he developed the screenplay of the 1941 film Citizen Kane. It had a theatrical release on November 13, 2020, and started streaming on Netflix on December 4.", Duration="2 Hrs 10 mins" },
    new Movie{ Title = "Taxi Driver", Description="Suffering from insomnia, disturbed loner Travis Bickle (Robert De Niro) takes a job as a New York City cabbie, haunting the streets nightly, growing increasingly detached from reality as he dreams of cleaning up the filthy city" , Duration="2 Hrs 45 mins"},
    new Movie{  Title = "3 Idiots", Description="After a group of friends graduate from CS University, they listlessly haunt their old campus, until a British filmmaker casts them in a film she's making about freedom fighters under British rule" , Duration = "2 Hrs 15 mins"},

};

        }
        // default OnPost method to create new record
        public void OnPost()
        {
           
            
        }

    }
}
