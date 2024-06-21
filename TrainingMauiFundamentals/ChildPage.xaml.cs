using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingMauiFundamentals;

public partial class ChildPage : ContentPage
{
    public ChildPage()
    {
        InitializeComponent();
    }

    private void Button_Clicked(object? sender, EventArgs e)
    {
        Navigation.PopModalAsync();
    }
}