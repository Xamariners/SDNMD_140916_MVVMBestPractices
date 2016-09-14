using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using MVVMBestPractices.Annotations;
using SpecFlow.XForms.IViewModel;
using Xamarin.Forms;

namespace MVVMBestPractices.PageModels
{
    public abstract class PageModelBase : FreshMvvm.FreshBasePageModel, IViewModel
    {
        public INavigation Navigation { get; set; }
    }
}
