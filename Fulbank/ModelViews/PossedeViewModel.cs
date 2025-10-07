using Fulbank.Models;
using Fulbank.Services;
using MonProjetWPF.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fulbank.ModelViews
{
    public class PossedeViewModel
    {
        public ObservableCollection<Possede> Possedes { get; set; } = new();

        private PossedeService _service = new PossedeService();

        public PossedeViewModel()
        {
            LoadPossedes();
        }

        private void LoadPossedes()
        {
            var listes = _service.GetPossedes();
            Possedes.Clear();

            foreach (var element in listes)
            {
                Possedes.Add(element);
            }
        }
    }
}
