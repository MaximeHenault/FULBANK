using Fulbank.Models;
using MonProjetWPF.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fulbank.ModelViews
{
    public class UtilisateurViewModel
    {
        public ObservableCollection<Utilisateur> Utilisateurs { get; set; } = new();

        private UtilisateurService _service = new UtilisateurService();

        public UtilisateurViewModel()
        {
            LoadUtilisateurs();
        }

        private void LoadUtilisateurs()
        {
            var listes = _service.GetUtilisateurs();
            Utilisateurs.Clear();

            foreach (var element in listes)
            {
                Utilisateurs.Add(element);
            }
        }
    }
}
