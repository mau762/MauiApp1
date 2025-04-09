namespace MauiApp1;

public partial class DisciplinasDoCurso : ContentPage
{
    private string CursoPesquisado;

    public DisciplinasDoCurso(string cursoPesquisado)
    {
        InitializeComponent();
        CursoPesquisado = cursoPesquisado;

        CursoLabel.Text = $"Curso: {CursoPesquisado}";
        LoadDisciplinas();
    }

    private void LoadDisciplinas()
    {
        var disciplinas = new List<string>();

        if (CursoPesquisado == "Ci�ncia da Computa��o")
        {
            disciplinas = new List<string>
            {
                "Algoritmos",
                "Banco de Dados",
                "Intelig�ncia Artificial"
            };
        }
        else if (CursoPesquisado == "Engenharia de Software")
        {
            disciplinas = new List<string>
            {
                "Redes de Computadores",
                "Gest�o de Projetos",
                "Engenharia de Requisitos"
            };
        }
        else
        {
            disciplinas.Add("Nenhuma disciplina encontrada.");
        }

        foreach (var disciplina in disciplinas)
        {
            DisciplinasLayout.Children.Add(new Label
            {
                Text = disciplina,
                TextColor = Colors.Black
            });
        }
    }

    private async void OnVoltarButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}
