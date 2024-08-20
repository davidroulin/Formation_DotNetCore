using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication1.Pages
{
	public class IndexModel: PageModel
	{

		//// open bar
		//public string role;


		//      private string _role;

		//public string GetRole() {
		//	return _role;
		//}

		//public void SetRole(string valeur) {
		//	// VALIDATION
		//	_role = valeur;
		//}

		//public string Role { get; set; }




		//class Produit
		//{
		//	public float prix;
		//}

		//private Produit[] panier;

		//public float GetTotal()
		//{
		//	return // some du panier
		//}


		//public float Total
		//{
		//	get
		//	{
		//              return // some du panier

		//          }
		//}



		


		[BindProperty(Name = "usr", SupportsGet = true)]
		public string Username { get; set; }

		public string messageDAccueil = "Bien le bonjour";

		private readonly ILogger<IndexModel> _logger;

		public IndexModel(ILogger<IndexModel> logger)
		{
			_logger = logger;
		}

		public void OnGet()
		{

		}
	}
}
