using DesignPattern.Composite.VirtualDirectoryExample;
using DesignPattern.Facade.ShapeExample;
using Newtonsoft.Json;

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            CallVirtualDirExample();
        }

        private static void CallVirtualDirExample()
        {
            var builder = new FileSystemBuilder("root");
            builder.AddFile("file1.text", 1002);
            builder.AddFile("file2.text", 1002);
            builder.AddDirectory("folder1");
            builder.SetCurrentDirectory("folder1");
            builder.AddFile("fol1file1.text", 3432);
            builder.AddFile("fol1file2.text", 3432);
            builder.AddDirectory("folder2");

            System.Console.WriteLine("RootDir: " + builder.RootDirectory.Name + "-- Size: " + builder.RootDirectory.GetSizeInKb());
            System.Console.WriteLine(JsonConvert.SerializeObject(builder.RootDirectory, Formatting.Indented));
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
