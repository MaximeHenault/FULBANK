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
    public class CourantViewModel
    {
        public ObservableCollection<Courant> Courants { get; set; } = new();

        private CourantService _service = new CourantService();

        public CourantViewModel()
        {
            LoadCourants();
        }

        private void LoadCourants()
        {
            var listes = _service.GetCourants();
            Courants.Clear();

            foreach (var element in listes)
            {
                Courants.Add(element);
            }
        }
    }
}
