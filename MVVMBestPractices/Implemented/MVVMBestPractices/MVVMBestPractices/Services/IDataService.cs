using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVMBestPractices.Shared.Models;

namespace MVVMBestPractices.Services
{
    public interface IDataService
    {
        Task<List<ToDoItem>> GetToDoItems();
    }
}
