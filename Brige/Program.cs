namespace Bridge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IRender vector = new VectorRender();
            IRender raster = new RasterRender();

            Shape square = new Square(vector);
            Shape circle = new Circle(raster);
            Shape triangle = new Triangle(vector);

            square.Draw();
            circle.Draw();
            triangle.Draw();
        }
    }
}
