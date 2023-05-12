using System.Collections.Generic;

namespace avalonia_test.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    public string Greeting => "Welcome to Avalonia!";
    public List<string> BackingItems { get; set; } = new();

    public MainWindowViewModel()
    {
        var faker = new Bogus.Faker();
        for (int x = 0; x < 2000000; x++)
        {
            this.BackingItems.Add($"{x}. "+faker.Lorem.Sentence());
        }
    }
}
