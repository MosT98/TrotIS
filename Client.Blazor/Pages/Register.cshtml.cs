using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using UserAPI.Data;


namespace Client.Blazor
{
    public class RegisterModel : PageModel
    {
        public static HttpClient client = new HttpClient();

        private readonly Context _context;

        public RegisterModel(Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public User User { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        static void Run()
        {
            // Update port # in the following line.
            client.BaseAddress = new Uri("http://localhost:44348/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Users.Add(User);
            await _context.SaveChangesAsync();
            //HttpResponseMessage response = await client.PostAsJsonAsync(
            //"https://localhost:5010/api/user", User);
            //response.EnsureSuccessStatusCode();

            return RedirectToPage("./Index");
        }
        
    }
}
