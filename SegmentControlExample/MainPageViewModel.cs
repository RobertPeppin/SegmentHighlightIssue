using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using Syncfusion.XForms.Buttons;
using Xamarin.Forms;

namespace SegmentControlExample
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        private int selectedScope;

        public MainPageViewModel()
        {
            ClearScopes();
            EnableAllCommand = new Command(() => { CreateAllScopes(); });
            DisableItems = new Command(() => { ClearScopes(); });
        }
        public event PropertyChangedEventHandler PropertyChanged;

        public Command EnableAllCommand { get; }
        public Command DisableItems { get; }

        public ObservableCollection<SfSegmentItem> SearchScopes { get; } = new ObservableCollection<SfSegmentItem>();
        public int SelectedScope
        {
            get => selectedScope;
            set
            {
                selectedScope = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SelectedScope"));
            }
        }

        private void ClearScopes()
        {
            if (SearchScopes.Count == 0)
            {
                SearchScopes.Add(new SfSegmentItem() { Text = "Current", IsEnabled = false });
                SearchScopes.Add(new SfSegmentItem() { Text = "Group", IsEnabled = false });
                SearchScopes.Add(new SfSegmentItem() { Text = "All", IsEnabled = true });
            }
            else
            {
                SearchScopes[0].IsEnabled = false;
                SearchScopes[1].IsEnabled = false;
                SearchScopes[2].IsEnabled = true;
            }

            if (SelectedScope != 2)
            {
                SelectedScope = 2;
            }
        }

        private void CreateAllScopes()
        {
            if (SearchScopes.Count == 0)
            {
                SearchScopes.Add(new SfSegmentItem() { Text = "Current", IsEnabled = true });
                SearchScopes.Add(new SfSegmentItem() { Text = "Group", IsEnabled = true });
                SearchScopes.Add(new SfSegmentItem() { Text = "All", IsEnabled = true });
                SelectedScope = 0;
            }
            else
            {
                SearchScopes[0].IsEnabled = true;
                SearchScopes[1].IsEnabled = true;
                SearchScopes[2].IsEnabled = true;
            }
        }
    }
}
