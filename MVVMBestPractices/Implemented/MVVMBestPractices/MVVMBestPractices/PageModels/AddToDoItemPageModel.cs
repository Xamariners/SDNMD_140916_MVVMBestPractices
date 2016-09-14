using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVMBestPractices.Data.Fake;
using MVVMBestPractices.Shared.Enums;
using MVVMBestPractices.Shared.Models;
using PropertyChanged;
using Xamarin.Forms;

namespace MVVMBestPractices.PageModels
{
    [ImplementPropertyChanged]
    public class AddToDoItemPageModel : PageModelBase
    {
        public string TodoName { get; set; }

        public string ToDoDescription { get; set; }

        public override void SetViewModel(object initData)
        {

        }

        public override void Init(object initData)
        {
            base.Init(initData);
        }

        /// <summary>
        /// Add new item command
        /// </summary>
        public Command SaveNewToDoItemCommand
        {
            get
            {
                return new Command(() =>
                {
                    FakeToDoData.FakeData.Add(new ToDoItem()
                    {
                        Name = TodoName,
                        Details = ToDoDescription,
                        Created = DateTime.Now,
                        ToDoStatus = ToDoStatus.Open,
                        Id = Guid.NewGuid(),
                    });
                });
            }
        }

    }
}
