﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject.Models;

namespace Services
{
    public interface ICatergoryService
    {
        List<Category> GetCategories();
    }
}
