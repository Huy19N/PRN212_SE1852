﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject.Models;
using DataAccessLayer;

namespace Repositories
{
    public class CategoryRepository : ICatergoryRepository
    {
        public List<Category> GetCategories() => CategoryDAO.GetCategories();
        
    }
}
