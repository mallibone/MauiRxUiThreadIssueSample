using System;
using System.Windows.Input;
using ReactiveUI;

namespace MauiRxUiThreadIssueSample.ViewModels
{
    public class MainViewModel : ReactiveObject
    {
        public MainViewModel()
        {
            ExecuteDoNothing = ReactiveCommand.Create(() => { });
        }

        public ICommand ExecuteDoNothing { get; }
    }
}

