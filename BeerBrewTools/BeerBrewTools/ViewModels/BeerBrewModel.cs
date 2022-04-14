using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace BeerBrewTools.ViewModels
{
    class BeerBrewModel : INotifyPropertyChanged
    

    {
        double origGravity, finalGravity, calories, alcByVol;
        
        public event PropertyChangedEventHandler PropertyChanged;
        

        public double OrigGravity
        {
            set
            {
                if (origGravity != value)
                {
                    origGravity = value;
                    OnPropertyChanged("CurrentGravity");
                    Recalculate();
                }
            }
            get
            {
                return origGravity;
            }
        }

        public double FinalGravity
        {
            set
            {
                if (finalGravity != value)
                {
                    finalGravity = value;
                    OnPropertyChanged("FinalGravity");
                    Recalculate();
                }
            }
            get
            {
                return finalGravity;
            }
        }

        
        public double Calories
        {
            set
            {
                if (calories != value)
                {
                    calories = value;
                    OnPropertyChanged("Calories");
                    
                }
            }
            get
            {
                return calories;
            }
        }

        
        public double AlcByVol
        {
            set
            {
                if (alcByVol != value)
                {
                    alcByVol = value;
                    OnPropertyChanged("AlcByVol");
                    
                }
            }
            get
            {
                return alcByVol;
            }
        }
        void Recalculate()
        {
            // Round total to nearest quarter.
            //this.AlcByVol = Math.Round((this.FinalGravity - this.OrigGravity) * 131.25) / 1000;

            //this.Calories = Math.Round(this.AlcByVol * 2.5) * 11.2;

            
            this.AlcByVol = System.Math.Abs((this.FinalGravity - this.OrigGravity) * 131.25) / 1000;
            

            this.Calories = System.Math.Abs(this.AlcByVol * 2.5) * 11.2;
        }

        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    
    }
}
