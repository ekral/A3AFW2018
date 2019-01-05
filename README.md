# Popis vzorového úkolu

Příklad obsahuje základy toho co byste měli znát abyste uspěli u testu.

## Základní pojmy:

- **View** - typicky jedno okno aplikace, tedy to co vidí uživatel
- **ViewModel** - je třída obsahující data pro zobrazení, konkrétně property, které chceme zobrazovat ve View. Například *MainViewModel*. Mmodel jsou obecně data v paměti.
- **Bindování** - mechanismus pomocí kterého spolu komunikují View a View model a přitom na sebe nemají přímou referenci, což umožňuje nezávislý vývoj a testování.
- **PropertyChange** - event v rozhraní *INotifyPropertyChanged* pomocí kterého ViewModel informuje control ve View, například TextBox, že došlo ke změně property ve ViewModelu a View ji má znovu načíst a zobrazit.
- **Command** - pomocí commandů může View volat metody ViewModelu a opět na sebe nemusí mít referenci. Commnand je potom třída implementující rozhraní *ICommand*. Ve ViewModelu potom vytváříme property typu Commmand a předáváme jí delegáta na metodu ve ViewModelu, kterou chceme zavolat. Ve View potom například Button na tuto property Command binduje.

## Popis kódu

Kód popisovaný v následujícím textu najdete v projektu [Exam](Exam/Exam), který obsahuje kód společný pro všechny platformy.

Nejdůležitější soubory v projektu jsou:

- [MainPage.xaml](Exam/Exam/MainPage.xaml) - View obsahující hlavní stránku aplikace obsahující `Label` a `Button` pro zvýšení hodnoty počítadla, reset hodnoty počítadla a pro editaci hodnoty počítadla, kdy naviguje na druhé View  [EditPage.xaml](Exam/Exam/EditPage.xaml)
- [EditPage.xaml](Exam/Exam/EditPage.xaml) - View obsahující `Entry` pro editaci hodnoty počítadla.
- [CounterViewModel.cs](Exam/Exam/CounterViewModel.cs) - ViewModel, který má property `Number`, `CommandIncrease`, `CommandReset` a `CommandNavigateToEdit`. Obě View v tomto příkladu sdílejí jednu instanci tohoto ViewModelu.

Dále si popíšeme základní principy použíté v tomto příkladu:

- Bindování

1. Nejprve vytvoříme v souboru [App.xaml.cs](Exam/Exam/App.xaml.cs) instanci našeho ViewModelu, tedy třídy `CounterViewModel` a referenci na tuto instanci přiřadíme propertě `MainPage` třídy `App`:

```cs 
MainPage mainPage = new MainPage(new CounterViewModel());
MainPage = new NavigationPage(mainPage);
```







