using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AndroidX.Activity;
using Bumptech.Glide;
using Bumptech.Glide.Load.Engine;
using Square.Picasso;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace AndroidLitraryPlaces
{
    [Activity(Label = "SingleMarkerDetails")]
    public class SingleMarkerDetails : Activity
    {
        TextView  tvidd, tvname , tvgname , tvplacetype , tvgps , tvgps2;
        ImageView img;
        int i = 0;
        int id = -1;
        int reminder = -1;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.activity_markerdetails);

           // Preferences.Set("id", id);
            img = (ImageView)FindViewById(Resource.Id.imgview);

            tvidd = FindViewById<TextView>(Resource.Id.tvidd);
            tvname = FindViewById<TextView>(Resource.Id.tvnamee);
            tvgname = FindViewById<TextView>(Resource.Id.tvgname);
            tvplacetype = FindViewById<TextView>(Resource.Id.tvtype);
            tvgps = FindViewById<TextView>(Resource.Id.tvgps);
            tvgps2 = FindViewById<TextView>(Resource.Id.tvgps2);

            string id = Intent.GetStringExtra("id");

            var ttt  =  int.Parse(id);
            reminder = ttt % 2;
            string name = Intent.GetStringExtra("name");
            string gailic_name = Intent.GetStringExtra("gname");
            string lattitude = Intent.GetStringExtra("lat");
            string longitude = Intent.GetStringExtra("long");
            string type = Intent.GetStringExtra("type");

            tvidd.Text = id;
            tvname.Text = name;
            tvgname.Text = gailic_name;
            tvplacetype.Text = type;
            tvgps.Text = lattitude ;
            tvgps2.Text = longitude ;
            
           /* tvname.Text = "Name : " + name 
                +"\n\n Gaelic_Name : "+gailic_name
                +"\n\nPlace Type : "+type;*/
           // Toast.MakeText(this, name + ","+type, ToastLength.Short).Show();
            // Create your application here
        }

        [Obsolete]
        public override void OnBackPressed()
        {
            base.OnBackPressed();
            base.OnDestroy();
           // Glide.With(this).Clear(img);
           // img.Invalidate();
            
            
        }
        protected override void OnPause()
        {
            base.OnPause();
              img.Invalidate();

        }
        

        [Obsolete]
        protected override void OnResume()
        {
            base.OnResume();
            //img.Invalidate();
            //Task.Delay(100);

            try
            { 
               // string url = "https://picsum.photos/200/300";
                // Glide.With(this).Clear(img);
                // Glide.With(this).Load("https://picsum.photos/200/300").Into(img);
               // Picasso.With(this).CancelRequest(img);

              /*  if(reminder == 1)
                {
                    //img.Invalidate();
                    string url = "https://picsum.photos/200/300";

                    Picasso.With(this).Load(url).Into(img);
                    img.Invalidate();
                }
                else
                {*/
                    string url = "https://picsum.photos/250/300";

                    Glide.With(this).Load(url)
                        .SkipMemoryCache(true)
                        .SetDiskCacheStrategy(DiskCacheStrategy.None)
                        .Into(img);
                    //img.Invalidate();
               // }
                 
                //Picasso.With(this).Load(url).Into(img);
                /*
                                Picasso.With(this)
                   .Load(ur).skipMemoryCache().into(img);*/

            }
            catch (Exception exc)
            {

            }
        }
    }
}