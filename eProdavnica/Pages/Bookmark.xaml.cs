using System.Collections.ObjectModel;
using System.Windows.Input;
using Microsoft.Maui.Controls;

namespace eProdavnica.Pages
{
    public partial class BookmarkPage : ContentPage
    {
        
        public ObservableCollection<Product> Products { get; }

        
        public ICommand ShowDetailsCommand { get; }

        public BookmarkPage()
        {
            InitializeComponent();

            
            Products = new ObservableCollection<Product>
            {
                new Product { Id = 1, Name = "Proizvod A", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", ImageUrl = "example.png" },
                new Product { Id = 2, Name = "Proizvod B", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", ImageUrl = "example.png" },
                new Product { Id = 3, Name = "Proizvod C", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", ImageUrl = "example.png" },
                
            };

            // Ovdje mijenjamo navigaciju u popup
            ShowDetailsCommand = new Command<Product>(async prod =>
            {
                // Ovo otvara mali alert s nazivom i opisom proizvoda
                await DisplayAlert(
                    title: prod.Name,
                    message: prod.Description,
                    cancel: "OK");
            });

           
            BindingContext = this;
        }
    }

    // Jednostavan model proizvoda
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }
}
