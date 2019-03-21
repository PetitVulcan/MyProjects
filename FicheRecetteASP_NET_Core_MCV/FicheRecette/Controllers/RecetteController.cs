using System;
using System.IO;
using System.Collections.Generic;
using FicheRecette.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace FicheRecette.Controllers
{
    public class RecetteController : Controller
    {
        [ActionName("Index")]
        [HttpGet]
        public IActionResult ListeRecetteTri(string NomCategory)
        {
            UserConnect(ViewBag);
            ViewBag.categories = Category.GetCategories();
            List<Recette> liste = Recette.AvoirListeRecetteTri(NomCategory);
            return View("ListeRecette", model: liste);
        }

        [Route("Recette/Lister")]
        public IActionResult ListeRecette(int? IdCategory)
        {
            UserConnect(ViewBag);
            ViewBag.categories = Category.GetCategories();
            List<Recette> listeRecette = Recette.AvoirListeRecette(IdCategory);
            return View("ListeRecette", listeRecette);
        }

        
        public IActionResult Detail(int Id)
        {
            UserConnect(ViewBag);
            ViewBag.categories = Category.GetCategories();
            List<Recette> InfoRecette = Recette.GetRecette(Id);
            return View("Detail",InfoRecette);
        }

        [Route("[Controller]/Ajouter")]
        public IActionResult AjouterRecette()
        {
            UserConnect(ViewBag);
            bool connected = Convert.ToBoolean(HttpContext.Session.GetString("logged"));
            if (connected)
            {
                Recette r = new Recette();
                ViewBag.Liste = Category.GetCategories();
                return View("AjouterRecette", r);
            }
            else
            {
                return RedirectToRoute(new { controller = "Utilisateurs", action = "Login" });
            }
        }        

        [Route("[Controller]/AjouterRecettePost")]
        [HttpPost]
        public async Task<IActionResult> AjouterRecettePost(DateTime date, string NomUtilisateur, string NomRecette, int? NbPersonne, string Difficulte, string Ingredient, string Realisation, string NomCategory, List<IFormFile> images)
        {
            
            Recette r = new Recette { NomRecette = NomRecette, NbPersonne = (int?)NbPersonne, Difficulte = Difficulte, Ingredient = Ingredient, Realisation = Realisation , NomCategory = NomCategory};
            r.NomUtilisateur = HttpContext.Session.GetString("nom");
            List<string> errors = new List<string>();
            if (NomRecette == null)
            {
                errors.Add("Merci d'indiquer un nom de recette.");
            }
            if (NomCategory == null)
            {
                errors.Add("Merci d'indiquer une catégorie.");
            }            
            if (Ingredient == null)
            {
                errors.Add("Merci d'indiquer la liste d'ingrédients.");
            }
            if (Realisation == null)
            {
                errors.Add("Merci d'indiquer la réalisation de la recette.");
            }
            if (errors.Count > 0)
            {

                ViewBag.error = true;
                ViewBag.errors = errors;
                return View("AjouterRecette", r);
            }
            else
            {
                foreach (IFormFile f in images)
                {
                    if (f.FileName.Contains(".png") || f.FileName.Contains(".jpg"))
                    {

                        var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/recette", r.NomCategory.ToString() + "-" + f.FileName);
                        var stream = new FileStream(path, FileMode.Create);
                        await f.CopyToAsync(stream);
                        r.Images.Add(new ImageRecette { Url = "images/recette/" + r.NomCategory.ToString() + "-" + f.FileName });
                    }

                }
                r.AjouterRecette();
                return RedirectToAction("Detail",r);
            }
        }

        [Route("[Controller]/Modifier")]
        public IActionResult ModifierRecette(int Id)
        {
            UserConnect(ViewBag);
            ViewBag.categories = Category.GetCategories();
            List<Recette> InfoRecette = Recette.GetRecette(Id);
            return View("ModifierRecette", InfoRecette);
        }
        [Route("[Controller]/ModifierRecettePost")]
        [HttpPost]
        public async Task<IActionResult> ModifierRecettePost(DateTime date, string NomUtilisateur, string NomRecette, int? NbPersonne, string Difficulte, string Ingredient, string Realisation, string NomCategory, List<IFormFile> images)
        {

            Recette r = new Recette { NomRecette = NomRecette, NbPersonne = (int?)NbPersonne, Difficulte = Difficulte, Ingredient = Ingredient, Realisation = Realisation, NomCategory = NomCategory };
            r.NomUtilisateur = HttpContext.Session.GetString("nom");
            List<string> errors = new List<string>();
            if (NomRecette == null)
            {
                errors.Add("Merci d'indiquer un nom de recette.");
            }
            if (NomCategory == null)
            {
                errors.Add("Merci d'indiquer une catégorie.");
            }
            if (Ingredient == null)
            {
                errors.Add("Merci d'indiquer la liste d'ingrédients.");
            }
            if (Realisation == null)
            {
                errors.Add("Merci d'indiquer la réalisation de la recette.");
            }
            if (errors.Count > 0)
            {

                ViewBag.error = true;
                ViewBag.errors = errors;
                return View("ModifierRecette", r);
            }
            else
            {
                foreach (IFormFile f in images)
                {
                    if (f.FileName.Contains(".png") || f.FileName.Contains(".jpg"))
                    {

                        var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/recette", r.NomCategory.ToString() + "-" + f.FileName);
                        var stream = new FileStream(path, FileMode.Create);
                        await f.CopyToAsync(stream);
                        r.Images.Add(new ImageRecette { Url = "images/recette/" + r.NomCategory.ToString() + "-" + f.FileName });
                    }

                }
                r.ModifierRecette();
                return RedirectToAction("Detail", r);
            }
        }

        [Route("Recette/Supprimer")]
        public IActionResult SupprimerRecette(int id)
        {
            Recette r = new Recette { Id = id };
            r.SupprimerRecette();
            return RedirectToAction("ListeRecette");
        }      
        [Route("Categorie")]
        public IActionResult ListeCategories()
        {
            UserConnect(ViewBag);
            List<Category> liste = Category.GetCategories();
            return View("listecategory", liste);
        }
        [Route("Categorie/Add")]
        public IActionResult AjouterCategorie()
        {
            UserConnect(ViewBag);
            List<Category> liste = Category.GetCategories();
            return View("listecategory",liste);
        }

        [Route("Categorie/Register")]
        [HttpPost]
        public IActionResult RegisterCategory(string titre)
        {
            List<string> errors = new List<string>();
            Category c = new Category { Titre = titre };
            if (titre == null)
            {
                errors.Add("Merci de saisir un Nom de Catégorie");
            }
            ViewBag.errors = errors;
            if (errors.Count > 0)
            {
                UserConnect(ViewBag);
                List<Category> liste = Category.GetCategories();
                return View("listecategory", liste);

            }
            else
            {
                c.Add();
                ViewBag.Categories = true;
                ViewBag.Message = "Catégorie ajoutée";
                UserConnect(ViewBag);
                List<Category> liste = Category.GetCategories();
                return View("ListeCategory", liste);
            }
            
        }

        public IActionResult DeleteCategory(int id)
        {
            Category c = new Category { Id = id };
            c.Delete();
            ViewBag.Categories = true;
            ViewBag.Message = "Categorie Supprimée";
            UserConnect(ViewBag);
            List<Category> liste = Category.GetCategories();
            return View("ListeCategory", liste);
            
        }
        public void UserConnect(dynamic v)
        {
            bool? logged = Convert.ToBoolean(HttpContext.Session.GetString("logged"));
            bool? Admin = Convert.ToBoolean(HttpContext.Session.GetString("admin"));
            if (logged == true)
            {
                v.Logged = logged;
                v.Admin = Admin;
                v.Nom = HttpContext.Session.GetString("nom");

            }
        }
    }
}