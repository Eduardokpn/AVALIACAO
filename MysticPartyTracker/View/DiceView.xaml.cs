namespace MysticPartyTracker.View;
using MysticPartyTracker.Models;
using MysticPartyTracker.ViewModels;

public partial class DiceView : ContentPage
{
	public DiceView()
	{
		InitializeComponent();
		BindingContext = new DiceViewModel();

	}

    /*
     private void rollardadosButton_Clicked(object sender, EventArgs e)
    {
		int lados = Convert.ToInt32(PickerLados.SelectedItem);
		int dados = Convert.ToInt32(PickerDados.SelectedItem.ToString());
		Dice dice = new Dice(lados);
        int total = 0;


        for (int i = 0; i < dados; i++)
		{

			int resultado = dice.Rolar();
			total += resultado;

            ValueDice.Text = Convert.ToString(total);
            ValueDiceSecond.Text += resultado + ",";

        }

    }
	*/
	
}