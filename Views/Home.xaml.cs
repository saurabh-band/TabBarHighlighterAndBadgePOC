using TabBarHighlighterAndBadgePOC.Services;

namespace TabBarHighlighterAndBadgePOC.Views;

public partial class Home : ContentPage, IDisposable
{
    public Home()
    {
        InitializeComponent();
        
        BindingContext = this;

        BadgeCounterService.CountChanged += OnCountChanged;
    }
        

    private void OnCountChanged(object? sender, int newCount)
    {
        CounterLable.Text = $"Current Badge Count: {newCount}";
    }

    private void BadgeDecrementCounterBtn_Clicked(object sender, EventArgs e)
    {
        BadgeCounterService.SetCount(BadgeCounterService.Count - 1);
    }

    private void BadgeIncrementCounterBtn_Clicked(object sender, EventArgs e)
    {
        BadgeCounterService.SetCount(BadgeCounterService.Count + 1);

    }

    public void Dispose() => BadgeCounterService.CountChanged -= OnCountChanged;
}