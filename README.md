# Popis vzorového úkolu

Příklad obsahuje základy toho co byste měli znát abyste uspěli u testu.

## Základní pojmy:

- **View** - typicky jedno okno aplikace, tedy to co vidí uživatel
- **ViewModel** - je třída obsahující data pro zobrazení, konkrétně property, které chceme zobrazovat ve View. Například *MainViewModel*. Mmodel jsou obecně data v paměti.
- **Bindování** - mechanismus pomocí kterého spolu komunikují View a View model a přitom na sebe nemají přímou referenci, což umožňuje nezávislý vývoj a testování.
- **PropertyChange** - event v rozhraní *INotifyPropertyChanged* pomocí kterého ViewModel informuje control ve View, například TextBox, že došlo ke změně property ve ViewModelu a View ji má znovu načíst a zobrazit.
- **Command** - pomocí commandů může View volat metody ViewModelu a opět na sebe nemusí mít referenci. Commnand je potom třída implementující rozhraní *ICommand*. Ve ViewModelu potom vytváříme property typu Commmand a předáváme jí delegáta na metodu ve ViewModelu, kterou chceme zavolat. Ve View potom například Button na tuto property Command binduje.

## Popis kódu

Kód popisovaný v následujícím textu najdete v projektu *Exam*, který obsahuje kód společný pro všechny platformy.

Nejdůležitější soubory v projektu jsou:

- `MainPage.xaml` - View obsahující hlavní stránku aplikace obsahující *Label* a *Buttony* pro zvýšení hodnoty počítadla, resetu hodnoty počítadla a pro editaci hodnoty počítadla, které naviguje na druhé View `EditPage.xaml`







