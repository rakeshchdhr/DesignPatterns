namespace DesignPattern.Composite.VirtualDirectoryExample
{
    public class FileItem : FileSystemItem
    {
        public FileItem(string name, long fileBytes) : base(name)
        {
            this.FileBytes = fileBytes;
        }

        public long FileBytes { get; }

        public override decimal GetSizeInKb()
        {
            return decimal.Divide(FileBytes, 1000);
        }
    }
}
