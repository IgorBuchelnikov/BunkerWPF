using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Bunker.Models;

namespace Bunker.Data
{
    public static class HeroesData
    {
        private static ObservableCollection<Hero> _savedHeroData;
        public static ObservableCollection<Hero> GetAllSavedHero()
        {
            if(_savedHeroData ==  null)
            {
                _savedHeroData = new ObservableCollection<Hero>();
                _savedHeroData.Add(new Hero(0, "Случайно", new Uri(Environment.CurrentDirectory + @"\Pictures\Heroes\random.jpg", UriKind.Absolute)));
                _savedHeroData.Add(new Hero(1, "Осел", new Uri( Environment.CurrentDirectory + @"\Pictures\Heroes\osel.jpg", UriKind.Absolute)));
                _savedHeroData.Add(new Hero(2, "Петух", new Uri(Environment.CurrentDirectory + @"\Pictures\Heroes\petuh.jpg", UriKind.Absolute)));
                _savedHeroData.Add(new Hero(3, "Олень", new Uri(Environment.CurrentDirectory + @"\Pictures\Heroes\olen.jpg", UriKind.Absolute)));
            }
            return _savedHeroData;
        }
    }
}
