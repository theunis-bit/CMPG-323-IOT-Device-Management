using DeviceManagement_WebApp.Models;
using DeviceManagement_WebApp.Repository;
using System;
using System.Collections.Generic;

namespace DeviceManagementWebApp.Repository
{
    public interface ICategoriesRepository : IGenericRepository<Category>
    {

        IEnumerable<Category> GetAll();
        Category GetById(Guid? CategoryId);
        void Insert(Category category_);
        void Update(Category category_);
        void Delete(Guid? CategoryId);

    }
}