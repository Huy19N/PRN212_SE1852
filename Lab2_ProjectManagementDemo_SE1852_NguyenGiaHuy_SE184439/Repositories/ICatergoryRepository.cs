using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;
using BusinessObject.Models;

namespace Repositories
{
    public interface ICatergoryRepository
    {
        List<Category> GetCategories();
    }
}
