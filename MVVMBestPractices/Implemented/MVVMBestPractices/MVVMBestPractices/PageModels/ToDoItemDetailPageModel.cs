using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVMBestPractices.Shared.Enums;
using MVVMBestPractices.Controls;
using MVVMBestPractices.Services;
using MVVMBestPractices.Shared.Models;
using PropertyChanged;
using Xamarin.Forms;

namespace MVVMBestPractices.PageModels
{
    [ImplementPropertyChanged]
    public class ToDoItemDetailPageModel : PageModelBase
    {
        public ToDoItem ToDoItem { get; set; }

        public override void Init(object initData)
        {
            base.Init(initData);

            ToDoItem = initData as ToDoItem;
        }

        public override void SetViewModel(object InitData)
        {
		ToDoItem  = InitData as ToDoItem;
        }


        public Command ToDoStatusUpdateCommand
        {
            get
            {
                return new Command((statupsUpdateValue) =>
                {
                    ToDoItem.ToDoStatus =
                         (ToDoStatus)Enum.Parse(typeof(ToDoStatus), (string)statupsUpdateValue);
                });
            }
        }
    }
}