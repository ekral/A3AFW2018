using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Exam
{
    public partial class MainPage : ContentPage
    {
        CounterViewModel _viewModelPocitadlo;
        public MainPage(CounterViewModel viewModelPocitadlo)
        {
            InitializeComponent();

            _viewModelPocitadlo = viewModelPocitadlo;
            BindingContext = _viewModelPocitadlo;
        }
    }
}
