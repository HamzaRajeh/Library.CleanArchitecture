using Library.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Infrastructure.Services.Tbbook
{
    public class TbbookServices : ITbbookServices
    {
        private readonly DblibraryContext _context;
        public TbbookServices(DblibraryContext context)
        {
            _context = context;

        }

        public async Task<dynamic> AddItem(dynamic value)
        {

            var item = new Domain.Models.Tbbook() { BookDiscriptsion = value.BookDiscriptsion ,
                AuthorId=value.AuthorId,
                CategoryId= value.CategoryId,
                BooksImg=value.BooksImg };

             _context.Add<Domain.Models.Tbbook> (item);
            _context.SaveChanges();

            return await Task.FromResult(value);  
        }

        public async Task<dynamic> DeleteItem(int id)
        {
            var book=_context.Tbbooks.Find(id);
            if (book != null) {
                _context.Tbbooks.Remove(_context.Tbbooks.Find(id));
                _context.SaveChanges();
                return await _context.Tbbooks.ToArrayAsync();

            }

            return "Error Delete Item";
         }

        public async Task<dynamic> GetAll()
        {
                return await _context.Tbbooks.ToArrayAsync();   
        }

        public    dynamic  GetItem(int id)
        {
            return   _context.Tbbooks.Find(id) ;
        }

        public dynamic UpdateItem(int id,dynamic value)
        {
            var Book = _context.Tbbooks.Where(s=>s.Id==id).FirstOrDefault();
            if (Book != null) {

                Book.Id = value.Id;//!= null? value.Id : Book.Id;
                Book.BookDiscriptsion = value.BookDiscriptsion;// != null? value.BookDiscriptsion : Book.BookDiscriptsion;
                Book.CategoryId = value.CategoryId;// != null? value.CategoryId : Book.CategoryId;
                Book.BooksImg = value.BooksImg;// != null? value.BooksImg : Book.BooksImg;
                Book.AuthorId = value.AuthorId;// != null? value.AuthorId : Book.AuthorId;
                 _context.SaveChanges();
                return Book;

            }
            return null;

        }
    }
}
