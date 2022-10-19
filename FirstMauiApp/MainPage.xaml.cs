using FirstMauiApp.ViewModel;

namespace FirstMauiApp;

public partial class MainPage : ContentPage
{
	public MainPage(MainViewModel vm)
	{
		InitializeComponent();

		// Use built-in Dependency injection system to cascade down. Register this system with the dependency service (see MauiProgram.cs).
		BindingContext = vm; 


	}

}



/* Traditional way of using BindingContext

BindingContext = new MainViewModel();

*/

