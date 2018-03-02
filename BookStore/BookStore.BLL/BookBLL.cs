using BookStore.DAO;
using System.Collections.Generic;
using System.Linq;

namespace BookStore.BLL
{
    /// <summary>
    /// Data access Object for book model
    /// </summary>
    public class BookBLL
    {
        SellingBookWebsiteDataEntities db = null;

        /// <summary>
        /// Comstructor for BookDAO
        /// </summary>
        public BookBLL()
        {
            db = new SellingBookWebsiteDataEntities();
        }

        /// <summary>
        /// Insert Book 
        /// </summary>
        /// <param name="book"></param>
        /// <returns>Book ID</returns>
        public int Insert(Book book)
        {
            db.Books.Add(book);
            db.SaveChanges();
            return book.BookId;
        }

        /// <summary>
        /// Get Book by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>book</returns>
        public Book GetById(int id)
        {
            return db.Books.Find(id);
        }

        /// <summary>
        /// Get List Product by category
        /// </summary>
        /// <param name="cateId"></param>
        /// <returns></returns>
        public IEnumerable<Book> GetByCategory(int cateId)
        {
            IEnumerable<Book> model = null;
            model = db.Books.Where(x => x.CateId == cateId).OrderBy(x=>x.Price).ToList();
            return model;
        }

     /*   public int Delete(int id)
        {

        }*/
    }
}
