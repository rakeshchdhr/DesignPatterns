using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPattern.Composite.VirtualDirectoryExample
{
    public class FileSystemBuilder
    {
        public DirectoryItem RootDirectory { get; }
        private DirectoryItem currentDirectory;

        public FileSystemBuilder(string rootDirectory)
        {
            RootDirectory = new DirectoryItem(rootDirectory);
            currentDirectory = RootDirectory;
        }

        public DirectoryItem AddDirectory(string name)
        {
            var dir = new DirectoryItem(name);
            currentDirectory.Add(dir);
            currentDirectory = dir;
            return dir;
        }

        public FileItem AddFile(string name, long sizeInBytes)
        {
            var file = new FileItem(name, sizeInBytes);
            currentDirectory.Add(file);
            return file;
        }

        public DirectoryItem SetCurrentDirectory(string name)
        {
            var dirStack = new Stack<DirectoryItem>();
            dirStack.Push(RootDirectory);
            while (dirStack.Any())
            {
                var current = dirStack.Pop();
                if (current.Name == name)
                {
                    currentDirectory = current;
                    return current;
                }
                foreach (var item in current.FSItems.OfType<DirectoryItem>())
                {
                    dirStack.Push(item);
                }
            }
            throw new InvalidOperationException($"Directory name - '{name}' not found !");
        }
    }
}
