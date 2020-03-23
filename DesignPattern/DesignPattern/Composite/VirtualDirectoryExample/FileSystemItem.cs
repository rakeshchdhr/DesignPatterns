namespace DesignPattern.Composite.VirtualDirectoryExample
{
    public abstract class FileSystemItem
    {
        public string Name { get; }

        public FileSystemItem(string name)
        {
            this.Name = name;
        }

        public abstract decimal GetSizeInKb();
    }
}
