using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using Entity.Base;

namespace Service
{
    public class UserService : Repository<User>
    {
        public void GetList()
        {
            var rep = (from a in Context.Admin
                       join b in Context.User
                           on a.UserName equals b.Name
                       select new
                       {
                           a.Id,
                           b.Name
                       }).ToList();
        }

        public User GetById(int id)
        {
            return base.Get(f => f.UserId == id).FirstOrDefault();
        }

        public int UpdateUser(User user)
        {
            var entity = base.Get(f => f.UserId == user.UserId).FirstOrDefault();
            if (entity != null)
            {
                entity.Name = user.Name;
                entity.Phone = user.Phone;
                entity.RegisterTime = user.RegisterTime;
                return base.Update(entity);
            }

            return 0;
        }

        public int InsertUser(User user)
        {
            return base.Insert(user);
        }

        public int DeleteUser(User user)
        {
            return base.Delete(user);
        }
    }
}
