using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Exam
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class EditPage : ContentPage
	{
        CounterViewModel _viewModelPocitadlo;

        public EditPage (CounterViewModel viewModelPocitadlo)
		{
			InitializeComponent ();

            _viewModelPocitadlo = viewModelPocitadlo;
            BindingContext = _viewModelPocitadlo;
        }
	}
}