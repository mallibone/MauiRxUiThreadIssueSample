using System;
using System.Reactive.Linq;
using System.Windows.Input;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;

namespace MauiRxUiThreadIssueSample.ViewModels
{
    public class MainViewModel : ReactiveObject
    {
        public MainViewModel()
        {
            ExecuteDoNothing = ReactiveCommand.Create(() => Counter++);
            this.WhenAnyValue(vm => vm.Counter)
                .Select(c => c == 1 ? $"Button clicked {c} time" : $"Button clicked {c} times")
                .ToPropertyEx(this, vm => vm.CounterText);
        }

        public ICommand ExecuteDoNothing { get; }

        [Reactive] public int Counter { get; set; }
        
        [ObservableAsProperty] public string CounterText { get; }
    }
}

