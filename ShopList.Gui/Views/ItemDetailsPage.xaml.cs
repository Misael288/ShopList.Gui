using ShopList.Gui.Models;
using ShopList.Gui.ViewModels;

namespace ShopList.Gui.Views;

public partial class ItemDetailsPage : ContentPage
{
    public ItemDetailsPage(Action<ShopListItem> _returnDataCallBack)
    {
        InitializeComponent();
        BindingContext = new ItemDetailsViewModel(_returnDataCallBack);
    }
}