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
    public class CarteViewModel
    {
        public ObservableCollection<Carte> Cartes { get; set; } = new();

        private CarteService _service = new CarteService();

        public CarteViewModel()
        {
            LoadCartes();
        }

        private void LoadCartes()
        {
            var listes = _service.GetCartes();
            Cartes.Clear();

            foreach (var element in listes)
            {
                Cartes.Add(element);
            }
        }
    }
}
