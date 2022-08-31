using System;

namespace SRP
{
    public class Shelve
    {

        public int Capacidad { get; }
        private int Sector;
        private string Name;
        private Book[] Libros = new Book[0] { };
        public string GetName()
        {
            return this.Name;
        }

        public int GetCapacidad()
        {
            return this.Capacidad;
        }

        public int GetBooks()
        {
            return this.Libros.Length;
        }

        public Book[] GetBooksList()
        {
            return this.Libros;
        }

        public void SetBooks(Book[] books)
        {
            this.Libros = books;
        }

        public void ShelveBook(Book book)
        {
            if (this.GetBooks() + 1 < this.Capacidad)
            {
                Book[] lib = new Book[GetBooks() + 1];
                int len=this.GetBooks();
                this.GetBooksList().CopyTo(lib, 0);
                lib[len]=book;
                this.SetBooks(lib);
            }
        }

        public Shelve(String name, int capacidad, int sector)
        {
            this.Name = name;
            this.Sector = sector;
            this.Capacidad = capacidad;
        }
        public void PrintBooks()
        {
            foreach (var item in Libros)
            {
                item.PrintBook();
            }
        }
    }
}
