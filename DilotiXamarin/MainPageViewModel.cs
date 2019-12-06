using DynamicData;
using ReactiveUI;
using System.Collections.Generic;
using System.Linq;
using System.Reactive;

namespace DilotiXamarin
{
    public class MainPageViewModel: ReactiveObject
    {
        private int _currentNum;
        public int CurrentNum
        {
            get => _currentNum;
            set => this.RaiseAndSetIfChanged(ref _currentNum, value);
        }

        private Stack<int> _history = new Stack<int>();
        public Stack<int> History
        {
            get => _history;
            set => this.RaisePropertyChanged(nameof(HistoryString));
        }

        public string HistoryString => string.Join("     ", History);

        public ReactiveCommand<string, int> UpdateCommand { get; }

        public MainPageViewModel()
        {
            History = new Stack<int>();

            UpdateCommand = ReactiveCommand.Create<string, int>((p) => 
            {   
                switch (p)
                {
                    case "+":
                        History.Push(_currentNum);
                        this.RaisePropertyChanged(nameof(HistoryString));
                        return CurrentNum++;
                    case "-":
                        History.Push(_currentNum);
                        this.RaisePropertyChanged(nameof(HistoryString));
                        return CurrentNum--;
                    case "C":
                        History.Clear();
                        this.RaisePropertyChanged(nameof(HistoryString));
                        CurrentNum = 0;
                        return CurrentNum;
                    case "U":
                        CurrentNum = History.Count > 0 ? History.Pop() : 0;
                        this.RaisePropertyChanged(nameof(HistoryString));
                        return CurrentNum;
                    default:
                        return CurrentNum;
                }
            });
        }

    }
}
