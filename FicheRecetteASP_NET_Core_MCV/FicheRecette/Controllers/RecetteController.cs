﻿using System;
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
        public IActionResult Index(int? idCategory)
        {
            UserConnect(ViewBag);
            ViewBag.categories = Category.GetCategories();
            List<Recette> liste = Recette.AvoirListeRecette(idCategory);
            return View(viewName: "ListeRecette", model: liste);
        }

        [Route("Recette/Lister")]
        public IActionResult ListeRecette(int? idCategory)
        {
            UserConnect(ViewBag);
            ViewBag.categories = Category.GetCategories();
            List<Recette> liste = Recette.AvoirListeRecette(idCategory);
            return View("ListeRecette", liste);
        }

        [Route("[Controller]/{id?}")]
        public IActionResult Detail(int? id)
        {
            UserConnect(ViewBag);
            return View();
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
                ViewBag.ListeNbPersonne = NbPersonne.GetNbPersonne();
                ViewBag.ListeDifficulte = Difficulte.GetDifficulte();
                return View("AjouterRecette", r);
            }
            else
            {
                return RedirectToRoute(new { controller = "Utilisateurs", action = "Login" });
            }
        }        

        [Route("[Controller]/AjouterRecettePost")]
        [HttpPost]
        public async Task<IActionResult>AjouterRecettes(DateTime date, string NomUtilisateur, string NomRecette, int? NbPersonne, string Difficulte, string Ingredient, string Realisation, List<IFormFile> images)
        {
            UserConnect(ViewBag);
            Recette r = new Recette { NomUtilisateur = HttpContext.Session.GetString("nom"), NomRecette = NomRecette, NbPersonne = NbPersonne, Difficulte = Difficulte, Ingredient = Ingredient, Realisation = Realisation };
            r.NomUtilisateur = HttpContext.Session.GetString("nom");
            List<string> errors = new List<string>();
            if (NomRecette == null)
            {
                errors.Add("Merci d'indiquer un nom de recette.");
            }
            if (NbPersonne == null)
            {
                errors.Add("Merci d'indiquer le nombre de personne(s) pour cette recette.");
            }
            if (Difficulte == null)
            {
                errors.Add("Merci d'indiquer le niveau de difficulté de cette recette.");
            }
            if (Ingredient == null)
            {
                errors.Add("Merci d'indiquer la liste d'ingrédients.");
            }
            if (Realisation == null)
            {
                errors.Add("Merci d'indiquer une catégorie d'annonce.");
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

                        var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/recette", r.Id.ToString() + "-" + f.FileName);
                        var stream = new FileStream(path, FileMode.Create);
                        await f.CopyToAsync(stream);
                        r.Images.Add(new ImageRecette { Url = "images/recette/" + r.Id.ToString() + "-" + f.FileName });
                    }

                }
                r.Ajouter();
                return RedirectToAction("ListeRecette");
            }
        }

        [Route("Recette/Supprimer")]
        public IActionResult SupprimerRecette(int id)
        {
            Recette r = new Recette { Id = id };
            r.Supprimer();
            return RedirectToAction("ListeRecette");
        }
       [Route("Difficulte")]
        public IActionResult ListeDifficulte()
        {
            UserConnect(ViewBag);
            List<Difficulte> liste = Difficulte.GetDifficulte();
            return View("ListeDifficulte", liste);
        }
        [Route("Difficulte/Add")]
        public IActionResult AjouterDifficulte()
        {
            UserConnect(ViewBag);
            return View("AddDifficulte");
        }

        [Route("Difficulte/Register")]
        [HttpPost]
        public IActionResult RegisterDifficulte(string titre)
        {
            List<string> errors = new List<string>();
            Difficulte d = new Difficulte { Titre = titre };
            if (titre == null)
            {
                errors.Add("Merci de saisir une Difficulté");
            }
            ViewBag.errors = errors;
            if (errors.Count > 0)
            {
                UserConnect(ViewBag);
                List<Difficulte> liste = Difficulte.GetDifficulte();
                return View("Listedifficulte", liste);

            }
            else
            {
                d.Add();
                ViewBag.Difficulte = true;
                ViewBag.Message = "Difficulté Ajoutée";
                UserConnect(ViewBag);
                List<Difficulte> liste = Difficulte.GetDifficulte();
                return View("Listedifficulte", liste);
            }           
        }

        public IActionResult DeleteDifficulte(int id)
        {
            Difficulte d = new Difficulte { Id = id };
            d.Delete();
            ViewBag.Difficulte = true;
            ViewBag.Message = "Difficulté Supprimée";
            UserConnect(ViewBag);
            List<Difficulte> liste = Difficulte.GetDifficulte();
            return View("Listedifficulte", liste);
        }

        //NbPersonne

        [Route("NbPersonne")]
        public IActionResult ListeNbPersonne()
        {
            UserConnect(ViewBag);
            List<NbPersonne> liste = NbPersonne.GetNbPersonne();
            return View("ListeNbPersonne", liste);
        }
        [Route("NbPersonne/Add")]
        public IActionResult AjouterNbPersonne()
        {
            UserConnect(ViewBag);
            return View("listenbpersonne");
        }

        [Route("NbPersonne/Register")]
        [HttpPost]
        public IActionResult RegisterNbPersonne(int ChoixNbPersonne)
        {
            NbPersonne n = new NbPersonne { ChoixNbPersonne = ChoixNbPersonne };
            n.Add();
            return RedirectToAction("listenbpersonne");
        }

        public IActionResult DeleteNbPersonne(int id)
        {
            NbPersonne n = new NbPersonne { Id = id };
            n.Delete();
            return RedirectToAction("listenbpersonne");
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
            if (logged == true)
            {
                v.Logged = logged;
                v.Nom = HttpContext.Session.GetString("nom");

            }
        }
    }
}