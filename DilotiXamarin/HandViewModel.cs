using DynamicData;
using ReactiveUI;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace DilotiXamarin
{
    public class HandViewModel : ReactiveObject
    {
        private SourceList<Card> _myCards = new SourceList<Card>();
        //public IObservableList<Card> MyCards => _myCards.AsObservableList();

        public ObservableCollection<Card> MyCards => new ObservableCollection<Card>
        {
             new Card { ImagePath = "Assets/cards_svg/10C.svg", Name="10C" },
             new Card { ImagePath = "Assets/cards_svg/2D.svg", Name="2D" },
             new Card { ImagePath = "Assets/cards_svg/5H.svg", Name="5H" }
        };

        public HandViewModel()
        {
            _myCards.AddRange(new List<Card>
            {
                new Card { ImagePath = "Assets/cards_svg/10C.svg" },
                new Card { ImagePath = "Assets/cards_svg/2D.svg" },
                new Card { ImagePath = "Assets/cards_svg/5H.svg" }
            });
        }

    }

    public class Card
    {
        public string Name { get; set; }
        public string ImagePath { get; set; }
    }
}
