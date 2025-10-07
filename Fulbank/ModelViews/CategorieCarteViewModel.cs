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
    public class CategorieCarteViewModel
    {
        public ObservableCollection<CategorieCarte> CategorieCartes { get; set; } = new();

        private CategorieCarteService _service = new CategorieCarteService();

        public CategorieCarteViewModel()
        {
            LoadCategorieCarte();
        }

        private void LoadCategorieCarte()
        {
            var listes = _service.GetCategorieCartes();
            CategorieCartes.Clear();

            foreach (var element in listes)
            {
                CategorieCartes.Add(element);
            }
        }
    }
}
