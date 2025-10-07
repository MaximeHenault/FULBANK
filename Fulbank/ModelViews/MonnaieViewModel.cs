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
    public class MonnaieViewModel
    {
        public ObservableCollection<Monnaie> Monnaies { get; set; } = new();

        private MonnaieService _service = new MonnaieService();

        public MonnaieViewModel()
        {
            LoadMonnaies();
        }

        private void LoadMonnaies()
        {
            var listes = _service.GetMonnaies();
            Monnaies.Clear();

            foreach (var element in listes)
            {
                Monnaies.Add(element);
            }
        }
    }
}
