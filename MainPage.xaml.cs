namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnDisciplinasButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Disciplinas());
        }

        private async void OnCursosButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Cursos());
        }

        private async void OnPeriodosButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Periodos());
        }


    }



}
