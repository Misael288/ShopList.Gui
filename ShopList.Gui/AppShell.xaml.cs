using ShopList.Gui.Views;

namespace ShopList.Gui
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute("itemdetails", 
            typeof(ItemDetailsPage));
        }
    }
}
