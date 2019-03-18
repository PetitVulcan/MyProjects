using System;
using System.Collections.Generic;
using FicheRecette.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.IO;

namespace FicheRecette.Controllers
{
    public class UtilisateurController : Controller
    {
        public IActionResult Index()
        {
            UserConnect(ViewBag);
            return View(viewName: "Index");
        }

        [Route("Utilisateur")]
        public IActionResult ListeUtilisateurs()
        {
            UserConnect(ViewBag);
            List<Utilisateur> liste = Utilisateur.AvoirListeUtilisateur();
            return View("ListeUtilisateur", liste);
        }
       
        [HttpPost]
        [Route("Utilisateur/Add")]
        public IActionResult AjouterUtilisateur(string Nom, string Prenom, string NomUtilisateur, string EMail, int NbRecettecree,string Mdp,string cMdp,string Admin)
        {
            List<string> errors = new List<string>();
            Utilisateur u = new Utilisateur { Nom = Nom, Prenom = Prenom, NomUtilisateur = NomUtilisateur,EMail = EMail, Mdp = Mdp, Admin = Admin};
            if (Nom == null)
            {
                errors.Add("Merci de saisir un Nom");
            }
            if (Prenom == null)
            {
                errors.Add("Merci de saisir un prénom");
            }
            if (NomUtilisateur == null)
            {
                errors.Add("Merci de saisir un nom d'utilisateur");
            }
            if (EMail == null)
            {
                errors.Add("Merci de saisir un numéro de téléphone");
            }
            if (Mdp == null)
            {
                errors.Add("Merci de saisir un mot de passe");
            }
            if (Mdp != cMdp )
            {
                errors.Add("Merci de saisir le même mot de passe");
            }
            if (u.Exist())
            {
                errors.Add("Cette adresse email est déjà utilisée");
            }
            ViewBag.errors = errors;
            if (errors.Count > 0)
            {

            }
            else
            {
                u.AjouterUtilisateur();
                ViewBag.Inscription = true;
                ViewBag.Message = "Inscription reussie merci de vous connecter";
            }
            return View("Connection", u);        
        }

        [Route("Utilisateur/Supprimer")]
        public IActionResult SupprimerUtilsateur(int id)
        {
            Utilisateur u = new Utilisateur { Id = id };
            u.SupprimerUtilisateur();
            return RedirectToAction("ListeUtilisateurs");
        }

        [Route("[Controller]/Login")]
        public IActionResult Connection()
        {
            Utilisateur u = new Utilisateur();
            return View(u);
        }

        public IActionResult LogOut()
        {
            HttpContext.Session.Clear();
            return View("Index");
        }

        [HttpPost]
        public IActionResult ConnectionMdp(string nomUtilisateur, string mdp)
        {
            Utilisateur u = new Utilisateur { NomUtilisateur = nomUtilisateur, Mdp = mdp };
            List<string> errors = new List<string>();
            if (nomUtilisateur == null)
            {
                errors.Add("Merci de saisir un email");
            }
            if (mdp == null)
            {
                errors.Add("Merci de saisir un mot de passe");
            }
            if (!u.ExistWithPassword())
            {
                errors.Add("Aucun utilisateur avec cette email et mot de passe");
            }
            if (errors.Count > 0)
            {
                ViewBag.errors = errors;
                return View("Connection", u);
            }
            else
            {
                if (!u.UserAdmin() == true)
                {
                    HttpContext.Session.SetString("Admin", "true");
                }
                HttpContext.Session.SetString("logged", "true");
                HttpContext.Session.SetString("nom", u.NomUtilisateur);
                return RedirectToRoute(new { controller = "Recette", action = "ListeRecette" });
            }
        }
        public void UserConnect(dynamic v)
        {
            bool? logged = Convert.ToBoolean(HttpContext.Session.GetString("logged"));
            bool? admin = Convert.ToBoolean(HttpContext.Session.GetString("Admin"));
            if (logged == true)
            {
                v.Logged = logged;
                v.Admin = admin;
                v.Nom = HttpContext.Session.GetString("nom");

            }
        }
    }
}