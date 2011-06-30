namespace ModelBindingTest.InputModels
{
    public class ShapeInputModel2
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return this.Name;
        }
    }
}