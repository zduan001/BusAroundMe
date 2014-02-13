using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD
{

    public abstract class Entry
    {
        public Directory parent;
        public string Name;
        public DateTime Created { get; }
        public DateTime LastUpated { get; }
        public DateTime LastAccessed { get; }
        public int Size { get; }

        protected DateTime created;
        protected DateTime lastAccess;
        protected DateTime lastUpdated;
        protected int size;

        public Entry(string n, Directory p)
        {
            parent = p;
            Name = n;

            created = DateTime.Now;
            lastAccess = DateTime.Now;
            lastUpdated = DateTime.Now;
        }

        public string Path()
        {
            if (parent == null) return Name;
            return parent.Path() + @"/" + Name;
        }

        public void Move()
        {
            //change parent;
            //update lastupdated
        }

    }

    public class File : Entry
    {
        public File(string name, string content, Directory p)
            : base(name, p)
        {
            this.Content = content;
            this.size = content.Length;
        }

        public string Content;
        // next three methods need to udpate acces time, update time, 
        public void Access();
        public void Update();
        public void Delete();

        public void UpdateParent(); // or have a event  and let directory listen to the event.
    }

    public class Directory : Entry
    {
        public List<Entry> Files;
        public List<Directory> Directories;

        public bool UpdateDirector(Action act, File file)
        {
            // up date time and content of the folder.
            // update size ....
            return true;
        }

        public int NumberOfFiles;

        public bool Delete(Entry e);
        public bool Add(Entry e);
    }

    class FileSystem
    {
    }
}
