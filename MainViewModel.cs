using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MauiApp1;

public class MainViewModel : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler? PropertyChanged;

    //Notice it's an ObservableCollection of IMyInterface
    ObservableCollection<IMyInterface> _myInterfaceInstance = new ObservableCollection<IMyInterface>(new List<MyModel>{new MyModel("the binding worked!")});
    public ObservableCollection<IMyInterface> MyInterfaceInstance
    {
        get => _myInterfaceInstance;
        set
        {
            if (_myInterfaceInstance != value)
            {
                _myInterfaceInstance = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(MyInterfaceInstance)));
            }
        }
    }

    //Notice it's an ObservableCollection of MyModel
    ObservableCollection<MyModel> _myModelInstance = new ObservableCollection<MyModel>(new List<MyModel>{new MyModel("the binding worked!")});
    public ObservableCollection<MyModel> MyModelInstance
    {
        get => _myModelInstance;
        set
        {
            if (_myModelInstance != value)
            {
                _myModelInstance = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(MyModelInstance)));
            }
        }
    }
}
