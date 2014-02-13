using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD
{
    public class User
    {
        public string Username;
        public string Password;
        //...
        //...
        public List<Item> CheckedOut;
        public List<Item> WaitingList;
        public List<Item> checkOutHistory;
        public List<Note> note;
        public UserRole role;

        public void Readbook(int itemID);
        public Item CheckOutItem(int itemID);
        public void ReturnItem(int itemID);
    }

    public enum UserRole
    {
        supperuser,
        normaluser,
        lowuser,
        inactiveuser,
    }

    public class Item
    {
        public int itemId;
        public int Id;
        public string title;
        public string Detals;
        public object content;
        public object categories;
        public string publisher;
        public User CheckOutUser;
        public bool IsAvailable;
        public UserRole Requiredrole;
    }

    public class Book : Item
    {
        public string author;
    }

    public class CD : Item
    {
    }

    public class Note
    {
        public int ItemID;
    }

    public class HighlightNote : Note
    {
        public ConsoleColor Color;
        public int startIndex;
        public int endIndex;
    }

    public class TextNote : Note
    {
    }

    class Library
    {
        public List<User> Users;
        public List<Item> Itesm;

        public User Getuser(string userName, string passowrd);
        public bool Verifyuser(string username, string password);
        public bool AuthenticateUser(string username);

        public List<Item> SearchItem(object query);
        public List<User> SearchUser(object query);

        public bool checkOutbook(int userId, int itmeId);
        public bool returnBook(int userId, int itemId);
    }
}
