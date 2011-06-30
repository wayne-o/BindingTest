using System.Collections.Generic;
using System.Web.Mvc;

namespace ModelBindingTest.InputModels
{
    public class ListInputModel
    {
        public string SelectedItemId { get; set; }
        public List<SelectListItem> Items { get; set; }

        public override string ToString()
        {
            return this.SelectedItemId;
        }
    }
}