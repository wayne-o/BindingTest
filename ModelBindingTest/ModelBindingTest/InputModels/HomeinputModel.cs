using System.Collections.Generic;

namespace ModelBindingTest.InputModels
{
    public class HomeInputModel
    {
        public HomeInputModel()
        {
            this.ConfiguredTables = new List<TableInputModel>();
        }

        public TableInputModel NewTable { get; set; }

        public List<TableInputModel> ConfiguredTables { get; set; }
    }
}