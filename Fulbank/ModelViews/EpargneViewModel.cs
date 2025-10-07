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
    public class EpargneViewModel
    {
        public ObservableCollection<Epargne> Epargnes { get; set; } = new();

        private EpargneService _service = new EpargneService();

        public EpargneViewModel()
        {
            LoadEpargnes();
        }

        private void LoadEpargnes()
        {
            var listes = _service.GetEpargnes();
            Epargnes.Clear();

            foreach (var element in listes)
            {
                Epargnes.Add(element);
            }
        }
    }
}
