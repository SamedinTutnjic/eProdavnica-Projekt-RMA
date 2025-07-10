using eProdavnica.Models;
using MvvmHelpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eProdavnica.ViewModels
{
    public class MainPageViewModel : LocalBaseViewModel
    {
        public MainPageViewModel()
        {
            LoadItemCategories();
            LoadBestSellingItemCollection();
        }

        public List<ItemCategory> Categories { get; set; }
        public List<Item> AllBestSellingItems { get; set; }
        public ObservableRangeCollection<ItemCategory> ItemCategories { get; set; }

        public ObservableRangeCollection<Item> BestSellingItems { get; set; }
        public void LoadItemCategories()
        {
            ItemCategories = new ObservableRangeCollection<ItemCategory>();
            Categories = new List<ItemCategory>();
            

            Categories.Add(new ItemCategory
            {
                Name = "Muškarci",
                Image = "icon_Mens_Shoe"
            });
            Categories.Add(new ItemCategory
            {
                Name = "Žene",
                Image = "shoe"
            });
            Categories.Add(new ItemCategory
            {
                Name = "Uređaji",
                Image = "devices"
            });
            Categories.Add(new ItemCategory
            {
                Name = "Tehnička oprema",
                Image = "headphone"
            });
            ItemCategories.AddRange(Categories);

        }

        public void LoadBestSellingItemCollection()
        {
            BestSellingItems = new ObservableRangeCollection<Item>();
            AllBestSellingItems = new List<Item>();


            BestSellingItems.Add(new Item
            {
                Name = "Pametni sat",
                Brand = "Huawei",
                Image = "pametnisat",
                Price = "199.00 KM"
            });
            BestSellingItems.Add(new Item
            {
                Name = "AirPods Slusalice",
                Brand = "Apple",
                Image = "slusalice",
                Price = "120.00 KM"
            });
            BestSellingItems.Add(new Item
            {
                Name = "Set alata za auto",
                Brand = "Bosch",
                Image = "alati",
                Price = "59.90 KM"
            });
            BestSellingItems.Add(new Item
            {
                Name = "Set za kuhinju",
                Brand = "Bosch",
                Image = "kuhinja",
                Price = "20.00 KM"
            });
        }
    }
}
