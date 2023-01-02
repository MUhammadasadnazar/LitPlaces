using Android.App;
using Android.Content;
using Android.Gms.Maps.Model;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AndroidLitraryPlaces.model
{
    public class Place 
    { 
        public int id { get; set; }
         public string location { get; set; }
         public string name { get; set; }
         public string gaelic_name { get; set; }
         public int place_type_id { get; set; }

        public double latitude { get; set; }
        public double longitude { get; set; }
        //  public LatLng LatLng { get; set; }
        /*"latitude": 57.15,
        "longitude": -2.1*/

    }
}