using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace CC_MVC.Repository
{
    public interface ImovieRepository<T> where T : class
    {
        IEnumerable<T> GetAll(); //for all products
        T GetById(object Id); //for a particular product
        void Insert(T obj);
        void Update(T obj);
        void Delete(object Id);
        void Save();
    }
}