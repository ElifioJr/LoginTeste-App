using LoginTeste_APP.Models;
using LoginTeste_APP.Pages;
using Microsoft.Maui.Controls.PlatformConfiguration.GTKSpecific;

namespace LoginTeste_APP
    {
    public partial class MainPage : ContentPage
        {
        

        public MainPage()
            {
                InitializeComponent();          
                
            }

        private void btnEntrar_Clicked(object sender, EventArgs e)
            {
            
            string nome =  Usuario.Text;
            string senha =  Senha.Text;
            


            if (!string.IsNullOrEmpty(nome) && !string.IsNullOrEmpty(senha))
                {     
                    if(nome == "adm" && senha == "123")
                    {
                    DisplayAlert("Bem Vindo", "Usuario e Senha corretos!", "Fechar");
                    Navigation.PushAsync(new Dashboard());
                    }
                else
                    {
                    DisplayAlert("Atencao!", "Usuario Incorreto", "Fechar");
                    return;
                    }
               
                }
            else
                {
                DisplayAlert("Atencao!", "Usuario Incorreto", "Fechar");
                return;

                }
           
            }

        private void btnCadastro_Clicked(object sender, EventArgs e)
            {
                 Navigation.PushAsync(new CadastroPage());
            }       
        }
    }
