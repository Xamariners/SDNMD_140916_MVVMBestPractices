using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVMBestPractices.Shared.Models;

namespace MVVMBestPractices.Services
{
    public class DataService : IDataService
    {
        public Task<List<ToDoItem>> GetToDoItems()
        {
            throw new NotImplementedException();
        }
    }
}
