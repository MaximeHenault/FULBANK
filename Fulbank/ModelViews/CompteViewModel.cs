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
    public class CompteViewModel
    {
        public ObservableCollection<Compte> Comptes { get; set; } = new();

        private CompteService _service = new CompteService();

        public CompteViewModel()
        {
            LoadComptes();
        }

        private void LoadComptes()
        {
            var listes = _service.GetComptes();
            Comptes.Clear();

            foreach (var element in listes)
            {
                Comptes.Add(element);
            }
        }
    }
}
