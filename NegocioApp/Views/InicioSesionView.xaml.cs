using NegocioApp.ViewModels;

namespace NegocioApp.Views;

public partial class InicioSesionView : ContentPage
{
	public InicioSesionView()
	{
		InitializeComponent();
		BindingContext = new InicioSesionViewModel();
	}
}