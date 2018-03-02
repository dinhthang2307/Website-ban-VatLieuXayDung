using BookStore.DAO;
using System.Collections.Generic;
using System.Linq;

namespace BookStore.BLL
{
    /// <summary>
    /// Category data access layer class
    /// </summary>
    public class CategoryBLL
    {
        SellingBookWebsiteDataEntities db = null;

        /// <summary>
        /// categoryDAO class constructor
        /// </summary>
        public CategoryBLL()
        {
            db = new SellingBookWebsiteDataEntities();
        }

        /// <summary>
        /// Get all record from Category table
        /// </summary>
        /// <returns>Ienumerable of Category</returns>
        public IEnumerable<Category> GetAll()      
        {
            IEnumerable<Category> model = null;
            model = db.Categories.ToList();
            return model;
        }


    }
}
