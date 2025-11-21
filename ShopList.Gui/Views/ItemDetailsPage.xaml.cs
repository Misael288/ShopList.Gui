using ShopList.Gui.ViewModels;

namespace ShopList.Gui.Views;

public partial class ItemDetailsPage : ContentPage
{
    public ItemDetailsPage()
    {
        InitializeComponent();
        BindingContext = new ItemDetailsViewModel();
    }
}