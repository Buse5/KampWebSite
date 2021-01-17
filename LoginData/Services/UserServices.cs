using LoginData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LoginData.Services
{
    public class UserServices
    {
        public List<Models.User> GetAll()
        {
            List<Models.User> users = new List<Models.User>();
            using (var kullanicilar=new Models.KampContext())
            {
                users= kullanicilar.Users.ToList();

            }
            return users;

        }
        public Models.User GetById(int id) 
        {
            Models.User users = new Models.User();
            using (var kullanici = new Models.KampContext()) 
            {
                users = kullanici.Users.FirstOrDefault(x=>x.Id==id); 

            }
                return users;
        }
        public bool Login(string email,string password) 
        {
            bool deger = false;
            using (var x=new Models.KampContext()) 
            {
                var veri = x.Users.Where(y=>y.Email ==email&& y.Password==password).FirstOrDefault();
                if (veri!=null && veri.Id>0) 
                {
                     deger = true;
                }
            }
                return deger;
        }
        public bool Insert(LoginData.Models.Registration registration) 
        {
            bool result = true;
            using (var srv= new KampContext()) 
            {
                if (registration.Id > 0) 
                { 
                }
                else 
                { 
                    srv.Registrations.Add(registration); 
                }
                srv.SaveChanges();
            }
            return result;
        }

        public object Save(Registration data)
        {
            throw new NotImplementedException();
        }

        public object Save(User data)
        {
            throw new NotImplementedException();
        }

        public object Kayit(int email, int password, int userName)
        {
            throw new NotImplementedException();
        }
    }
}
