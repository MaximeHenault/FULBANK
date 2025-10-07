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
    public class OperationViewModel
    {
        public ObservableCollection<Operation> Operations { get; set; } = new();

        private OperationService _service = new OperationService();

        public OperationViewModel()
        {
            LoadOperations();
        }

        private void LoadOperations()
        {
            var listes = _service.GetOperations();
            Operations.Clear();

            foreach (var element in listes)
            {
                Operations.Add(element);
            }
        }
    }
}
