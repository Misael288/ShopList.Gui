using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ShopList.Gui.Models;
using ShopList.Gui.Views;

using System.Collections.ObjectModel;

namespace ShopList.Gui.ViewModels
{
    public partial class ShopListViewModel : ObservableObject
    {
        [ObservableProperty]
        private ShopListItem? _elementoSeleccionado = null;
        public ObservableCollection<ShopListItem> Items { get; }

        public ShopListViewModel()
        {
            Items = new ObservableCollection<ShopListItem>();
            CargarDatos();
            if (Items.Count > 0)
            {
                //ElementoSeleccionado = Items[0];
                ElementoSeleccionado = Items.First();
            }

        }

        private void CargarDatos()
        {
            Items.Add(new ShopListItem
            {
                Id = 1,
                Nombre = "Leche",
                Cantidad = 2,
                Comprado = false,
            });
            Items.Add(new ShopListItem
            {
                Id = 2,
                Nombre = "Pan de caja",
                Cantidad = 1,
                Comprado = false,
            });
            Items.Add(new ShopListItem
            {
                Id = 3,
                Nombre = "Huevos",
                Cantidad = 12,
                Comprado = false,
            });
        }

        [RelayCommand]
        public async Task AddItem()
        {
            //await Shell.Current.GoToAsync("itemdetails");
            await Shell.Current.Navigation.PushAsync(
                new ItemDetailsPage(OnDataReturned)
                );


        }

        [RelayCommand]
        public void RemoveItem()
        {
            if (ElementoSeleccionado == null)
            {
                return;
            }
            ShopListItem? nuevoElementoSeleccionado;
            int indice = Items.IndexOf(ElementoSeleccionado);
            if (Items.Count > 1)
            {
                //Hay por lo menos dos elementos
                if (indice == Items.Count - 1)
                {
                    nuevoElementoSeleccionado = Items[indice - 1];
                }
                else
                {
                    nuevoElementoSeleccionado = Items[indice + 1];
                }
            }
            else
            {
                nuevoElementoSeleccionado = null;
            }


            Items.Remove(ElementoSeleccionado);
            ElementoSeleccionado = nuevoElementoSeleccionado;
        }

        public void OnDataReturned(ShopListItem item)
        {
            if (item == null)
            {
                return;
            }
            Items.Add(item);
        }

        //private Task<ShopListItem> NavigateForResult()
        //{
        //    var tcs = new TaskCompletionSource<ShopListItem>();
        //    Shell.Current.Navigation.PushAsync(
        //        new ItemDetailsPage(tcs)
        //        );
        //    return tcs.Task;
        //}
    }
}
