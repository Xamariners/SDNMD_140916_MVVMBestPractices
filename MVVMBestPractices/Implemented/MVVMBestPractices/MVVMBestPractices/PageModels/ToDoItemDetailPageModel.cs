using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVMBestPractices.Shared.Enums;
using MVVMBestPractices.Shared.Models;
using PropertyChanged;
using Xamarin.Forms;

namespace MVVMBestPractices.PageModels
{
    [ImplementPropertyChanged]
    public class ToDoItemDetailPageModel : PageModelBase
    {
        public ToDoItem SelectedToDoItem { get; set; }

        public override void Init(object initData)
        {
            base.Init(initData);

            SelectedToDoItem = (ToDoItem)initData;
        }

        protected override void SetViewModel()
        {
           
        }


        public Command ToDoStatusUpdateCommand
        {
            get
            {
                return new Command((statupsUpdateValue) =>
                {
                    SelectedToDoItem.ToDoStatus =
                         (ToDoStatus)Enum.Parse(typeof(ToDoStatus), (string)statupsUpdateValue);
                });
            }
        }
    }
}