using Speakers.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Speakers.ViewModels
{
    public class SpeakersViewModel : BaseViewModel
    {
        public SpeakersViewModel()
        {
            this.Speakers = LoadSpeakers();
            this.Title = "speakers 1";
        }

        private ObservableCollection<Speaker> _speakers;
        public ObservableCollection<Speaker> Speakers
        {
            get { return _speakers; }
            set { if (_speakers != value) { _speakers = value; RaisePropertyChanged(() => Speakers); } }
        }

        private ObservableCollection<Speaker> LoadSpeakers()
        {
            ObservableCollection<Speaker> theCollection = new ObservableCollection<Speaker>();

            theCollection.Add(new Speaker() { FirstName = "Alec", LastName = "Tucker" });
            theCollection.Add(new Speaker() { FirstName = "Lars", LastName = "Klint" });
            theCollection.Add(new Speaker() { FirstName = "Filip", LastName = "Ekberg" });

            return theCollection;
        }
    }
}
