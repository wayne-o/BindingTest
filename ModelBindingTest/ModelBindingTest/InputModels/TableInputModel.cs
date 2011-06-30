namespace ModelBindingTest.InputModels
{
    /// <summary>
    /// this is the base table input model. 
    /// it's initially displayed to offer the user the ability to select the
    ///  shape for the table they want to insert into the table plan
    /// </summary>
    public class TableInputModel
    {
        public TableInputModel()  // for the model binder
        {
            this.Shape = new ShapeListInputModel();
        }

        public TableInputModel(string shape)
            : this()
        {
            this.Shape.SelectedItemId = shape;
        }

        public string TableInputModelTypeName
        {
            get { return this.GetType().Name; }
        }

        public string Id { get; set; }
        public ShapeListInputModel Shape { get; set; }
    }
}