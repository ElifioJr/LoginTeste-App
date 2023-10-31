namespace LoginTeste_APP.Pages;

public partial class CadastroPage : ContentPage
{
	public CadastroPage()
	{
		InitializeComponent();
        
        }

    private void btnCadastrar_Clicked(object sender, EventArgs e)
        {

        }

    private void btnCancelar_Clicked(object sender, EventArgs e)
        {
        Navigation.PushAsync(new MainPage());

        }
 
    }