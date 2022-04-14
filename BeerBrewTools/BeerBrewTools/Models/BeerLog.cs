using System;
using SQLite;
using System.ComponentModel;

namespace BeerBrewTools.Models
{
    public class Note : INotifyPropertyChanged
    {

        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string BeerType { get; set; }
        public double OrigGravity { get; set; }
        public double FinalGravity { get; set; }
        [Ignore]
        public double AlcByVol => Math.Abs((OrigGravity - FinalGravity) * 131.25);
        [Ignore]
        public double Calories => Math.Abs((AlcByVol * 2.5) * 11.2);
        public DateTime Date { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyChanges()
        {
            OnPropertyChanged(nameof(AlcByVol));
            OnPropertyChanged(nameof(Calories));
        }

        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
