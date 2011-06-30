using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace ModelBindingTest.InputModels
{
    public class ShapeListInputModel
    {
        public string SelectedItemId { get; set; }

        public static List<string> Shapes
        {
            get
            {
                return new List<string>
                           {
                               "Rectangle", "Circle", "Bank of chairs", "Custom shape"
                           };
            }
        }

        public List<SelectListItem> Items
        {
            get
            {
                return new List<SelectListItem>(Shapes.Select(x => new SelectListItem { Value = x, Text = x }));
            }
        }

        public override string ToString()
        {
            return this.SelectedItemId;
        }
    }
}