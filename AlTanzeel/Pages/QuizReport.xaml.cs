using AlTanzeel.ViewModel;
using DrawnUi.Maui.Draw;

namespace AlTanzeel.Pages;

public partial class QuizReport : SkiaLayout
{
    public QuizReport()
    {
        InitializeComponent();
    }

    private MainViewModel viewModel;

    public QuizReport(MainViewModel viewModel)
    {
        InitializeComponent();
        Console.WriteLine($"TAKASUR:: {viewModel.SelectedSura.Name}");
        Console.WriteLine($"TAKASUR:: {viewModel.SelectedAyasForTranslation.Count.ToString()}");
    }
}