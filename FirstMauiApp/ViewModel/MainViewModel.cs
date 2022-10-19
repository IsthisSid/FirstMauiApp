using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace FirstMauiApp.ViewModel
{

    // Using communitytoolkit.MVVM from nuget : highly optimized automatic source code generators

    public partial class MainViewModel : ObservableObject
    {
        public MainViewModel()
        {
            Items = new ObservableCollection<string>();
        }


        [ObservableProperty]    
        ObservableCollection<string> items; 

        [ObservableProperty]
        string text;

        [RelayCommand]
        void Add()
        {
            if(string.IsNullOrWhiteSpace(Text))
                    return;
            Items.Add(Text);

   
            Text = string.Empty;
        }

        [RelayCommand]
        void Delete(string s)
        {
            if (Items.Contains(s))
            {
                Items.Remove(s);
            }
        }

    }
}







/* Traditional way to update the user interface prior to using the MVVM community toolkit

using System.ComponentModel;
public class MainViewModel : INotifyPropertyChanged
{
    string text;
    public string Text
    {
        get => text;
        set
        {
            text = value;
            OnPropertyChanged(nameof(Text));
        }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    void OnPropertyChanged(string name) =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
}
*/

