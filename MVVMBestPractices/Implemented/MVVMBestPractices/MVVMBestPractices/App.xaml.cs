using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FreshMvvm;
using MVVMBestPractices.PageModels;
using MVVMBestPractices.Services;
using Xamarin.Forms;

namespace MVVMBestPractices
{
    public partial class App : Application
    {
        public App()
        {
            InitContainer();
            var toDoList = FreshMvvm.FreshPageModelResolver.ResolvePageModel<ToDoListPageModel>();
            var navContainer = new FreshMvvm.FreshNavigationContainer(toDoList);
            MainPage = navContainer;
        }

        private void InitContainer()
        {
            FreshIOC.Container.Register<IDataService, FakeDataService>();
        }
         
        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
