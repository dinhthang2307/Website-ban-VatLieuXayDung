using BookStore.Common;
using BookStore.DAO;

namespace BookStore.BLL
{
    public class UserBLL
    {
        SellingBookWebsiteDataEntities db = null;

        /// <summary>
        /// UserDAO class constructor
        /// </summary>
        public UserBLL()
        {
            db = new SellingBookWebsiteDataEntities();
        }

        /// <summary>
        /// Insert user to table
        /// </summary>
        public User Insert(User user)
        {
            db.Users.Add(user);
            db.SaveChanges();
            return user;
        }

        /// <summary>
        /// Login method
        /// </summary>
        /// <param name="UserName"></param>
        /// <param name="Password"></param>
        /// <returns></returns>
        public bool Login(string UserName, string Password)
        {
            bool statusLogin = false;
            if (UserName == AdminAccount.ACCOUNT && Password == AdminAccount.PASSWORD)
            {
                statusLogin = true;

            }
            else
            {
                statusLogin = false;
            }
            return statusLogin;

        }

    }
}
