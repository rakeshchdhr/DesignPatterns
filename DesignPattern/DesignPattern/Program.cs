using DesignPattern.Facade.ShapeExample;

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            CallShapeExample();
        }

        private static void CallShapeExample()
        {
            var shapeMaker = new ShapeMakerFacade();

            shapeMaker.DrawCircle();
            shapeMaker.DrawRectangle();
            shapeMaker.DrawSquare();
            shapeMaker.DrawTrangle();
        }
    }
}
