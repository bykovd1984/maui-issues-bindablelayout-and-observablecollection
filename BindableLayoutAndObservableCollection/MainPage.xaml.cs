using System.Collections.ObjectModel;
using System.Diagnostics;

namespace BindableLayoutAndObservableCollection
{
  public partial class MainPage : ContentPage
  {
    public ObservableCollection<int> BindableLayoutItems { get; set; } = new ObservableCollection<int>();
    public ObservableCollection<int> CollectionViewItems { get; set; } = new ObservableCollection<int>();

    public MainPage()
    {
      InitializeComponent();

      BindingContext = this;
    }

    private void BindableLayoutButton_Clicked(object sender, EventArgs e)
    {
      Task.Run(() =>
      {
        try
        {
          BindableLayoutItems.Add(BindableLayoutItems.Count + 1);
        }
        catch(Exception ex)
        {
          Debug.WriteLine($"BindableLayoutButton_Clicked: {ex.Message}");
        }
      });
    }


    private void CollectionViewButton_Clicked(object sender, EventArgs e)
    {
      Task.Run(() =>
      {
        try
        {
          CollectionViewItems.Add(CollectionViewItems.Count + 1);
        }
        catch(Exception ex)
        {
          Debug.WriteLine($"CollectionViewButton_Clicked: {ex.Message}");
        }
      });
    }
  }
}