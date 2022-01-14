using System;
using System.Collections.ObjectModel;
using Bunker.Data;
using Bunker.Models;
using ObservableComputations;

namespace BunkerWPF.ViewModels.StartGame
{
	class PlayerViewModel : IDisposable
	{
		public Player Player {get; private set;}

		OcConsumer _ocConsumer = new OcConsumer();
		public ObservableCollection<Hero> AvailableHeroes {get; }

		public PlayerViewModel(Player player, OcConsumer ocConsumer)
		{
			Player = player;
			_ocConsumer = ocConsumer;

			AvailableHeroes = 
				HeroesData.GetAllSavedHero()
				.Filtering(h => h != Player.Hero)
				.For(_ocConsumer);
		}

		public void SetRandomHero()
        {
            Random random = new Random();
            Player.Hero = HeroesData.GetAllSavedHero()[random.Next(1, HeroesData.GetAllSavedHero().Count)];
        }

		#region Implementation of IDisposable

		public void Dispose()
		{
			throw new NotImplementedException();
		}

		#endregion
	}
}
