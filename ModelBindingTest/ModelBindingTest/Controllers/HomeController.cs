using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ModelBindingTest.Attributes;
using ModelBindingTest.InputModels;

namespace ModelBindingTest.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View(new HomeInputModel { NewTable = new TableInputModel() });
        }

        [HttpPost]
        [ActionName("Index")]
        [AcceptParameter(Action = "SelectShape")]
        public ActionResult Index_SelectShape(HomeInputModel inputModel)
        {
            switch (inputModel.NewTable.Shape.SelectedItemId)
            {
                case "Rectangle":
                    inputModel.NewTable = new RectangleTableInputModel();
                    break;
                case "Circle":
                    inputModel.NewTable = new CircleTableInputModel();
                    break;
            }

            return View(inputModel);
        }

        [HttpPost]
        [ActionName("Index")]
        [AcceptParameter(Action = "AddAnother")]
        public ActionResult Index_AddAnother(HomeInputModel inputModel)
        {
            inputModel.ConfiguredTables.Add(inputModel.NewTable);
            inputModel.NewTable = new TableInputModel();
            return View(inputModel);
        }
    }
}
