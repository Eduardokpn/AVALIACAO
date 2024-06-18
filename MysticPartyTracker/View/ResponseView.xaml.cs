using MysticPartyTracker.ViewModels;

namespace MysticPartyTracker.View;

public partial class ResponseView : ContentPage
{
	public ResponseView()
	{

		BindingContext = new ResponseViewModel();
        InitializeComponent();

	}
}