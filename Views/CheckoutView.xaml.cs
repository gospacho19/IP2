using System.Windows.Controls;
using LuxuryCarRental.ViewModels;
using Microsoft.Extensions.DependencyInjection;

namespace LuxuryCarRental.Views
{
    public partial class CheckoutView : UserControl
    {
        public CheckoutView()
        {
            InitializeComponent();

            if (App.Current is not App app) return;
            DataContext = app.Services.GetRequiredService<CheckoutViewModel>();
        }
    }
}
