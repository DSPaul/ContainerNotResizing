using System.Collections.ObjectModel;
using System.Linq;

namespace ContainerNotResizing
{
    public class MainViewModel
    {
        public MainViewModel(int size = 1000)
        {
            Items = new(Enumerable.Range(0, size));
        }

        public ObservableCollection<int> Items { get; set; }
    }
}
