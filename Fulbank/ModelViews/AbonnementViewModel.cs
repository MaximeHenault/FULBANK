using Fulbank.Models;
using Fulbank.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fulbank.ModelViews
{
    public class AbonnementViewModel
    {
        public ObservableCollection<Abonnement> Abonnements { get; set; } = new();

        private AbonnementService _service = new AbonnementService();

        public AbonnementViewModel()
        {
            LoadAbonnements();
        }

        private void LoadAbonnements()
        {
            var listes = _service.GetAbonnements();
            Abonnements.Clear();

            foreach (var element in listes)
            {
                Abonnements.Add(element);
            }
        }
    }
}
