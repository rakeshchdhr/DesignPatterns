using DesignPattern.Facade.ShapeExample.Shapes;

namespace DesignPattern.Facade.ShapeExample
{
    public class ShapeMakerFacade : IShapeMaker
    {
        private readonly Circle _circle;
        private readonly Triangle _triangle;
        private readonly Square _square;
        private readonly Rectangle _rectangle;
        public ShapeMakerFacade()
        {
            _circle = new Circle();
            _triangle = new Triangle();
            _square = new Square();
            _rectangle = new Rectangle();
        }

        public void DrawCircle()
        {
            _circle.Draw();
        }

        public void DrawRectangle()
        {
            _rectangle.Draw();
        }

        public void DrawSquare()
        {
            _square.Draw();
        }

        public void DrawTrangle()
        {
            _triangle.Draw();
        }
    }
}
