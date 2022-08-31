using MyWebBookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebBookStore.Repository
{
    public class BookRepository
    {
        public List<BookModel> GetAllBooks()
        {
            return DataSorce();
        }

        public BookModel GetBookById(int id)
        {
            return DataSorce().Where(x => x.Id == id).FirstOrDefault();
        }

        public List<BookModel> SearchBook(string title, string author)
        {
            return DataSorce().Where(x => x.Title.Contains(title) && x.Author.Contains(author)).ToList();
        }

        private List<BookModel> DataSorce()
        {
            return new List<BookModel>()
            {
                new BookModel(){Id=1,Title="MVC",Author="Nitish"},
                new BookModel(){Id=2,Title="MVC1",Author="Nitish1"},
                new BookModel(){Id=3,Title="MVC2",Author="Nitish2"},
                new BookModel(){Id=4,Title="MVC3",Author="Nitish3"},
                new BookModel(){Id=5,Title="MVC4",Author="Nitish4"},
            };
        }
     }
}
