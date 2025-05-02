using System.Collections.ObjectModel;

namespace MauiApp1;

public partial class MyControl : ContentView
{
	public MyControl()
	{
		InitializeComponent();
	}

    public static readonly BindableProperty MyLabelsProperty =
        BindableProperty.Create(nameof(MyLabels), typeof(ICollection<IMyInterface>), typeof(MyControl), defaultValue: new ObservableCollection<IMyInterface>(), defaultBindingMode: BindingMode.TwoWay);


    public ICollection<IMyInterface> MyLabels
    {
        get => (ICollection<IMyInterface>)GetValue(MyLabelsProperty);
        set => SetValue(MyLabelsProperty, value);
    }

}