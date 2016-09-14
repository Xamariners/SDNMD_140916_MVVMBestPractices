using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVMBestPractices.Data.Fake;
using MVVMBestPractices.Shared.Models;

namespace MVVMBestPractices.Services
{
    public class FakeDataService : IDataService
    {
        public async Task<List<ToDoItem>> GetToDoItems()
        {
            await Task.Delay(TimeSpan.FromSeconds(3));
            return FakeToDoData.FakeData;
        }
    }
}
