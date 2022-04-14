using System;
using System.Collections.Generic;
using System.Text;

namespace BeerBrewTools.Models
{
    public enum MenuItemType
    {
        BrewLog,
        Bottling,
        About
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
