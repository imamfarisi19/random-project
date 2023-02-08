using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using Plugin.SharedTransitions;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using XFFurniture.Models;
using XFFurniture.Service;
using XFFurniture.ViewModel;
using XFFurniture.Views;
//using System.Linq;

namespace XFFurniture.ViewModels
{
    public class MainPageViewModel : BaseViewModel
    {
        public MainPageViewModel(INavigation navigation)
        {
            Navigation = navigation;
            SelectCategoryCommand = new Command<Category>((param) => ExecuteSelectCategoryCommand(param));
            NavigateToDetailPageCommand = new Command<Product>(async (param) => await ExeccuteNavigateToDetailPageCommand(param));
            GetCategories();
            GetProducts();
            TestLitedb();
        }

        public Command NavigateToDetailPageCommand { get; }
        public Command SelectCategoryCommand { get; }
        public ObservableCollection<Category> Categories { get; set; }
        public ObservableCollection<Product> Products { get; set; }

        void GetCategories()
        {
            Categories = new ObservableCollection<Category>(DataService.GetCategories());
        }

        void GetProducts()
        {
            Products = new ObservableCollection<Product>(DataService.GetProducts());
        }

        private void ExecuteSelectCategoryCommand(Category model)
        {
            var index = Categories
               .ToList()
               .FindIndex(p => p.description == model.description);

            if (index > -1)
            {
                UnselectGroupItems();

                Categories[index].selected = true;
                Categories[index].textColor = "#272829";
                Categories[index].backgroundColor = "#F4C03E"; // #F4C03E yellow
            }
        }

        void UnselectGroupItems()
        {
            Categories.ForEach((item) =>
            {
                item.selected = false;
                item.textColor = "#000000"; // #272829 ColorBlack27
                item.backgroundColor = "#EAEDF6"; // #EAEDF6 white
            });
        }

        private async Task ExeccuteNavigateToDetailPageCommand(Product product)
        {
            var page = (App.Current.MainPage as SharedTransitionNavigationPage).CurrentPage;
            SharedTransitionNavigationPage.SetTransitionSelectedGroup(page,product.Id);
            await Navigation.PushAsync(new DetailPage(product));
        }

        public void TestLitedb()
        {
            DataService dataService = new DataService(@"D:\database\mydata.db");

            var productSet = dataService.GetAll();
            if (productSet.Count() <= 0) // apabila tidak ada data product
            {
                Console.WriteLine("Tulis Data Awal");
                foreach(Product item in Product.Contoh())
                {
                    dataService.Insert(item);
                }
                productSet = dataService.GetAll();
            }

            Console.WriteLine("Lihat isi data buku");
            foreach (Product item in productSet)
            {
                Console.WriteLine($"{item.Id} \t {item.createdBy}");
            }
        }



        private Product test;
        public Product Test
        {
            get { return test; }
            set { SetProperty(ref test, value); }
        }

    }
}
