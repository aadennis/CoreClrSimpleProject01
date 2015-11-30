using System.ComponentModel;

namespace ViewModel {
	
	public class Observable : INotifyPropertyChanged {
		public event PropertyChangedEventHandler PropertyChanged;
	}
}