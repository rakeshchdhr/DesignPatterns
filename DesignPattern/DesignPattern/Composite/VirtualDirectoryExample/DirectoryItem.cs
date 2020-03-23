using System.Collections.Generic;
using System.Linq;

namespace DesignPattern.Composite.VirtualDirectoryExample
{
    public class DirectoryItem : FileSystemItem
    {
        public List<FileSystemItem> FSItems { get; } = new List<FileSystemItem>();
        public DirectoryItem(string name) : base(name)
        {
        }
        public void Add(FileSystemItem item)
        {
            FSItems.Add(item);
        }
        public void Remove(FileSystemItem item)
        {
            FSItems.Remove(item);
        }
        public override decimal GetSizeInKb()
        {
            return FSItems.Sum(x => x.GetSizeInKb());
        }
    }
}
