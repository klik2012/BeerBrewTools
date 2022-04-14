using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace BeerBrewTools.ViewModels
{
    class BottlingViewModel : INotifyPropertyChanged
    {
        double litersToPackage, mlToPackage, qty330, qty500, qty650, total330, total500, total650, capacity, target, difference;

        public event PropertyChangedEventHandler PropertyChanged;

        public double LitersToPackage
        {
            set
            {
                if (litersToPackage != value)
                {
                    litersToPackage = value;
                    OnPropertyChanged("LitersToPackage");
                    Recalculate();
                }
            }
            get
            {
                return litersToPackage;
            }
        }

        public double MlToPackage
        {
            set
            {
                if (mlToPackage != value)
                {
                    mlToPackage = value;
                    OnPropertyChanged("MlToPackage");
                    Recalculate();
                }
            }
            get
            {
                return mlToPackage;
            }
        }

        public double Qty330
        {
            set
            {
                if (qty330 != value)
                {
                    qty330 = value;
                    OnPropertyChanged("Qty330");
                    Recalculate();
                }
            }
            get
            {
                return qty330;
            }
        }

        public double Qty500
        {
            set
            {
                if (qty500 != value)
                {
                    qty500 = value;
                    OnPropertyChanged("Qty500");
                    Recalculate();
                }
            }
            get
            {
                return qty500;
            }
        }

        public double Qty650
        {
            set
            {
                if (qty650 != value)
                {
                    qty650 = value;
                    OnPropertyChanged("Qty650");
                    Recalculate();
                }
            }
            get
            {
                return qty650;
            }
        }

        public double Total330
        {
            set
            {
                if (total330 != value)
                {
                    total330 = value;
                    OnPropertyChanged("Total330");
                    Recalculate();
                }
            }
            get
            {
                return total330;
            }
        }

        public double Total500
        {
            set
            {
                if (total500 != value)
                {
                    total500 = value;
                    OnPropertyChanged("Total500");
                    Recalculate();
                }
            }
            get
            {
                return total500;
            }
        }

        public double Total650
        {
            set
            {
                if (total650 != value)
                {
                    total650 = value;
                    OnPropertyChanged("Total650");
                    Recalculate();
                }
            }
            get
            {
                return total650;
            }
        }
                

        public double Capacity
        {
            set
            {
                if (capacity != value)
                {
                    capacity = value;
                    OnPropertyChanged("Capacity");
                    Recalculate();
                }
            }
            get
            {
                return capacity;
            }
        }

        public double Target
        {
            set
            {
                if (target != value)
                {
                    target = value;
                    OnPropertyChanged("Target");
                    Recalculate();
                }
            }
            get
            {
                return target;
            }
        }

        public double Difference
        {
            set
            {
                if (difference != value)
                {
                    difference = value;
                    OnPropertyChanged("Difference");
                    Recalculate();
                }
            }
            get
            {
                return difference;
            }
        }
        
        void Recalculate()
        {
            
            this.MlToPackage = (this.LitersToPackage) * 1000;
            this.Total330 = (this.Qty330) * 330;
            this.Total500 = (this.Qty500) * 500;
            this.Total650 = (this.Qty650) * 330;
            this.Capacity = (this.Total330 + this.Total500 + this.Total650);
            this.Target = this.MlToPackage;
            this.Difference = (this.Capacity - this.Target);

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
