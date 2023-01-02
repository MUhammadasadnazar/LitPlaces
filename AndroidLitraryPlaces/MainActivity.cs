using Android.App;
using Android.OS;
using Android.Runtime;
using AndroidX.AppCompat.App;
using Android.Gms.Maps;
using Android.Gms.Maps.Model;
using Java.Util;
using Xamarin.Essentials;
using System;
using AndroidLitraryPlaces.model;
using System.Collections.Generic;
using Newtonsoft.Json;
using Android.Widget;
using System.Linq;
using System.Collections.ObjectModel;
using Android.Gms.Common.Apis;
using AlertDialog = Android.App.AlertDialog;
using Android.Graphics;
using Bumptech.Glide;
using Android.Content;
using Android.Views;
using System.Drawing;
using System.Reflection;
using System.Threading.Tasks;

namespace AndroidLitraryPlaces
{
  //  [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme")]
    public class MainActivity : AppCompatActivity , IOnMapReadyCallback ,
        GoogleMap.IOnInfoWindowClickListener,GoogleMap.IOnMapLongClickListener,
        GoogleMap.IOnMarkerDragListener  , ProgressBar.IOnTouchListener 
    {
        List<PlaceType> listplacetype = new List<PlaceType>();
        ObservableCollection<Place> listplaces = new ObservableCollection<Place>();
        System.Net.Http.HttpClient client = new System.Net.Http.HttpClient();

        GoogleMap map;
        Spinner spinner;
        Circle circle;
        MarkerOptions marker;
        Marker dragablemarker;
        ProgressBar progress;
        LatLng circlepoint;
        Polyline polylinedistance;
        int index = 0;
        int counter = 0;

        int circleradious = 10;
        TextView tvcircleradious;
        TextView tvnoofplaces , tvnearestdistance;


        protected override void OnCreate(Bundle savedInstanceState)
        {

            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

           // Task.Delay(1000);
            progress = (ProgressBar)FindViewById(Resource.Id.progressBar);
            spinner = (Spinner)FindViewById(Resource.Id.spinner1);
            tvcircleradious = (TextView)FindViewById(Resource.Id.tvcircleradious);
            tvnoofplaces = (TextView)FindViewById(Resource.Id.tvnoofplaces);
            tvnearestdistance = (TextView)FindViewById(Resource.Id.tvdistance);
            FragmentManager.FindFragmentById<MapFragment>(Resource.Id.map).GetMapAsync(this);

           // progress.SetOnDragListener(this);
            progress.SetOnTouchListener(this);
           // progress.SetOnScrollChangeListener(this);
         
            
            
            LoadPlaceType();

            LoadPlaces(0);

           /* AlertDialog.Builder builder = new AlertDialog.Builder(this);

            AlertDialog alert = builder.Create();

            alert
                .Show();*/
            // Setupmap();
           

        }

        public void Setupmap()
        {
            if(map != null)
            {
                FragmentManager.FindFragmentById<MapFragment>(Resource.Id.map).GetMapAsync(this);
            }
        }

         public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }

        public void OnMapReady(GoogleMap googleMap)
        {
           
            map = googleMap;

            map.MapType = GoogleMap.MapTypeTerrain;
            map.SetOnInfoWindowClickListener(this);
            map.SetOnMapLongClickListener(this);
            map.SetOnMarkerDragListener(this);

         /*   CircleOptions circleOptions = new CircleOptions()
    .InvokeCenter(new LatLng(57.15, -2.1))
    .InvokeFillColor(Resource.Color.material_blue_grey_800)
    .InvokeRadius(10000);*/ // In meters

            // Get back the mutable Circle
           // Circle circle = map.AddCircle(circleOptions);
            /* LatLng sydney1 = new LatLng(57.15, -2.1);

              LatLng s11 = new LatLng(56.6181111111111, -3.8655);
              googleMap.AddMarker(new MarkerOptions()
                  .SetPosition(sydney1)
                  .SetTitle("Marker in Sydney"));

           googleMap.MoveCamera(CameraUpdateFactory.NewLatLng(sydney1));
*/
            /* 
                  googleMap.AddMarker(new MarkerOptions()
                      .SetPosition(s11)
                      .SetIcon(BitmapDescriptorFactory.FromResource(Resource.Drawable.pin))
                      .SetTitle("Marker in Sydney")); */
            /* LatLng lt = new LatLng(57.15, -2.1);
             map = googleMap;
             MarkerOptions options = new MarkerOptions()
                 .SetPosition(lt)
             .SetTitle("Hello").SetSnippet("Snippet");

             map.AddMarker(options);*/
            // map.MoveCamera(CameraUpdateFactory.NewLatLng(lt));


        }

        public async void LoadPlaceType()
        {
            try
            {
                string webApiUrl = "https://gist.githubusercontent.com/saravanabalagi/541a511eb71c366e0bf3eecbee2dab0a/raw/bb1529d2e5b71fd06760cb030d6e15d6d56c34b3/place_types.json";

                var uri = new Uri(webApiUrl);
                var response = await client.GetAsync(uri);

                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();

                    List<PlaceType> list = new List<PlaceType>();

                    list = JsonConvert.DeserializeObject<List<PlaceType>>(content);

                    listplacetype.Add(new PlaceType
                    {
                        id = 0,
                        name = "All",
                        created_at = DateTime.Now,
                        updated_at = DateTime.Now,

                    });

                    for (int i = 0; i < list.Count; i++)
                    {
                        listplacetype.Add(new PlaceType
                        {
                            id = list[i].id,
                            name = list[i].name,
                            created_at = list[i].created_at,
                            updated_at = list[i].updated_at,
                        });
                       // Toast.MakeText(this, "count" + listplacetype[i].name, ToastLength.Long).Show();

                    }
                     
                    string[] array1234 = new string[listplacetype.Count];

                    for(int i = 0; i < listplacetype.Count; i++)
                    {
                        array1234[i] = listplacetype[i].name;

                    }

                    List<string> list123 = new List<string>();
                    //ObservableCollection<PlaceType> list123 = new ObservableCollection<PlaceType>();
                    ArrayAdapter<string> adapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleSpinnerDropDownItem, array1234);
                   // adapter.SetDropDownViewResource(Android.Resource.Layout.SimpleSpinnerItem);

                    spinner.Adapter = adapter;
                    int initialSpinnerPosition = spinner.SelectedItemPosition;

                    spinner.ItemSelected += (sender, args) =>
                    {
                         if (args.Position != initialSpinnerPosition)
                          {
              //          Toast.MakeText(this, listplaces.Count+" Total Places Found", ToastLength.Short).Show();
                       
                        LoadPlaces(args.Position);
                       // LoadPlaces(args.Position+1);
                        // do stuff
                         }
                        else
                        {
                            LoadPlaces(0);
                        }
                    };

                   

                   
                 }
            }
            catch (Exception exc)
            {
                Toast.MakeText(this, "Excep : "+exc.Message, ToastLength.Long).Show();
               // await DisplayAlert("Alert", "Exce : " + exc.Message, "ok");
            }
        }
        public async void LoadPlaces(int id)
        {
            listplaces.Clear();
            try
            {
                string webApiUrl = "https://gist.githubusercontent.com/saravanabalagi/541a511eb71c366e0bf3eecbee2dab0a/raw/bb1529d2e5b71fd06760cb030d6e15d6d56c34b3/places.json";

                var uri = new Uri(webApiUrl);
                var response = await client.GetAsync(uri);

                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();

                    ObservableCollection<Place> list = new ObservableCollection<Place>();

                    list = JsonConvert.DeserializeObject<ObservableCollection<Place>>(content);

                    for (int i = 0; i < list.Count; i++)
                    {
                        if(id == 0)
                        {
                            listplaces.Add(new Place
                            {
                                id = list[i].id,
                                name = list[i].name,
                                gaelic_name = list[i].gaelic_name,
                                location = list[i].location,
                                place_type_id = list[i].place_type_id,
                                latitude = list[i].latitude,
                                longitude = list[i].longitude,

                            });

                        }
                        else
                        {
                            if (list[i].place_type_id == id)
                            {
                                listplaces.Add(new Place
                                {
                                    id = list[i].id,
                                    name = list[i].name,
                                    gaelic_name = list[i].gaelic_name,
                                    location = list[i].location,
                                    place_type_id = list[i].place_type_id,
                                    latitude = list[i].latitude,
                                    longitude = list[i].longitude,

                                });

                            }
                        }


                    }
                    Toast.MakeText(this, listplaces.Count + " Total Places Found", ToastLength.Short).Show();


                    map.Clear();

                    var bitmap =   BitmapDescriptorFactory.DefaultMarker(BitmapDescriptorFactory.HueAzure);
                   
 
                    for (int i = 0; i < listplaces.Count; i++)
                    {
                        if (listplaces[i].place_type_id == 1)
                        {
                            bitmap = BitmapDescriptorFactory.DefaultMarker(BitmapDescriptorFactory.HueGreen);

                        }
                        else if (listplaces[i].place_type_id == 2)
                        {
                            bitmap = BitmapDescriptorFactory.DefaultMarker(BitmapDescriptorFactory.HueCyan);

                        }
                        else if (listplaces[i].place_type_id == 3)
                        {
                            bitmap = BitmapDescriptorFactory.DefaultMarker(BitmapDescriptorFactory.HueMagenta);

                        }
                        else if (listplaces[i].place_type_id == 4)
                        {
                            bitmap = BitmapDescriptorFactory.DefaultMarker(BitmapDescriptorFactory.HueOrange);

                        } else if (listplaces[i].place_type_id == 5)
                        {
                            bitmap = BitmapDescriptorFactory.DefaultMarker(BitmapDescriptorFactory.HueBlue);

                        }else if (listplaces[i].place_type_id == 6)
                        {
                            bitmap = BitmapDescriptorFactory.DefaultMarker(BitmapDescriptorFactory.HueRed);

                        }
                        else if (listplaces[i].place_type_id == 7)
                        {
                            bitmap = BitmapDescriptorFactory.DefaultMarker(BitmapDescriptorFactory.HueRose);

                        } else if (listplaces[i].place_type_id == 8)
                        {
                            bitmap = BitmapDescriptorFactory.DefaultMarker(BitmapDescriptorFactory.HueYellow);

                        }

                        LatLng sydney = new LatLng(listplaces[i].latitude, listplaces[i].longitude);

                        map.AddMarker(new MarkerOptions()
                            .SetPosition(sydney)
                            .SetTitle(listplaces[i].name)
                            .SetIcon(bitmap));
                           // .SetIcon(BitmapDescriptorFactory.DefaultMarker(BitmapDescriptorFactory.HueGreen)));

                        map.MoveCamera(CameraUpdateFactory.NewLatLng(sydney));


                    }

                //    Toast.MakeText(this, "count" + listplaces.Count, ToastLength.Long).Show();

 

                    
                    //pickerplacetype.ItemsSource = listplacetype;
                }
            }
            catch (Exception exc)
            {
                Toast.MakeText(this, "Excep : "+exc.Message, ToastLength.Long).Show();
               // await DisplayAlert("Alert", "Exce : " + exc.Message, "ok");
            }
        }

        public void OnInfoWindowClick(Marker marker)
        {
            try
            {


                string placetype = "";
                int index = -1;
                for (int i = 0; i < listplaces.Count; i++)
                {
                    if (listplaces[i].name == marker.Title)
                    {
                        index = i;
                        break;

                    }
                }
                for (int i = 0; i < listplacetype.Count; i++)
                {
                    if (listplacetype[i].id == listplaces[index].place_type_id)
                    {
                        placetype = listplacetype[i].name;
                    }

                }

                Intent intent = new Intent(this, typeof(SingleMarkerDetails));
                intent.PutExtra("id", listplaces[index].id+"");
                intent.PutExtra("name", listplaces[index].name);
                intent.PutExtra("gname", listplaces[index].gaelic_name);
                intent.PutExtra("lat", listplaces[index].latitude+"");
                intent.PutExtra("long", listplaces[index].longitude+"");
                intent.PutExtra("type", placetype);
                //intent.PutExtra("name", listplaces[index].name);

                StartActivity(intent);
            }
            catch (Exception exc)
            {

            }
            // Toast.MakeText(this, "info"+marker.Title, ToastLength.Long).Show();  
            // throw new NotImplementedException();
        }

        public void OnMapLongClick(LatLng point)
        {
            //10000 km 6213 in  miles
            circlepoint = point;
            CreateDragableMarker(point);
            CreateCircle(point , circleradious);

            NoOfPlaces(point);
            FindDistanceToNearest(point);

           // ShowDialloge("Hello" , "hello");

           // Toast.MakeText(this , "Count : "+counter , ToastLength.Long).Show();
                  
            // map.MoveCamera(CameraUpdateFactory.NewLatLng(point));

        }

        public void NoOfPlaces(LatLng point)
        {
            counter = 0;
            for (int i = 0; i < listplaces.Count; i++)
            {
                Location startPoint = new Location(point.Latitude, point.Longitude);

                Location endPoint = new Location(listplaces[i].latitude, listplaces[i].longitude);

                var distan = Location.CalculateDistance(startPoint, endPoint, DistanceUnits.Kilometers);

                // dis = dis / 0.62137;
                if (distan < circleradious)
                {
                    counter = counter + 1;
                }

                tvnoofplaces.Text = "Number of Places : "+counter;
            }
             
        }
         
        public void CreateDragableMarker(LatLng point)
        {
            MarkerOptions options = new MarkerOptions()
              .SetTitle("Drag Me")
              .Draggable(true)
              .SetIcon(BitmapDescriptorFactory.DefaultMarker(BitmapDescriptorFactory.HueMagenta))
              .SetPosition(point);
            // map.Clear();
            if (dragablemarker == null)
            {
                dragablemarker = map.AddMarker(options);

            }
            else
            {
                dragablemarker.Remove();
                dragablemarker = map.AddMarker(options);

            }

        }
        public void CreateCircle(LatLng point , int radious)
        {
            CircleOptions circleOptions = new CircleOptions()
              .InvokeCenter(point)
              .InvokeFillColor(Resource.Color.colorPrimary)
              .InvokeRadius(radious*1000); // In meters

            // Get back the mutable Circle

            if (circle == null)
            {
                circle = map.AddCircle(circleOptions);

            }
            else
            {
                circle.Remove();
                circle = map.AddCircle(circleOptions);

            }

            map.MoveCamera(CameraUpdateFactory.NewLatLngZoom(point, 2));


        }

        private double distance(double lat1, double lon1, double lat2, double lon2)
        {
           //10000 km 6213 in  miles
            double theta = lon1 - lon2;
            double dist = Math.Sin(deg2rad(lat1))
                            * Math.Sin(deg2rad(lat2))
                            + Math.Cos(deg2rad(lat1))
                            * Math.Cos(deg2rad(lat2))
                            * Math.Cos(deg2rad(theta));
            dist = Math.Acos(dist);
            dist = rad2deg(dist);
            dist = dist * 60 * 1.1515;
            return (dist);
        }

        private double deg2rad(double deg)
        {
            return (deg * Math.PI / 180.0);
        }

        private double rad2deg(double rad)
        {
            return (rad * 180.0 / Math.PI);
        }
        public void OnMarkerDrag(Marker marker)
        {
           // throw new NotImplementedException();
        }

        public void OnMarkerDragEnd(Marker marker)
        {
            circlepoint = marker.Position;
            CreateCircle(marker.Position , circleradious);

            NoOfPlaces(marker.Position);
            
               FindDistanceToNearest(marker.Position);

           /* if (polylinedistance != null)
            {
                polylinedistance.Remove();
            }*/
           // Toast.MakeText(this , "marker position "+marker.Position , ToastLength.Long).Show();
           // throw new NotImplementedException();
        }

        public void OnMarkerDragStart(Marker marker)
        {
           // throw new NotImplementedException();
        }

       public void FindDistanceToNearest(LatLng point)
        {
            if(listplaces.Count  > 0)
            {
                Location startPoint = new Location(point.Latitude, point.Longitude);

                Location endPoint = new Location(listplaces[0].latitude, listplaces[0].longitude);

                var distance1 = Location.CalculateDistance(startPoint, endPoint, DistanceUnits.Kilometers);
                 
                for(int i = 1; i < listplaces.Count; i++)
                {
                    endPoint = new Location(listplaces[i].latitude, listplaces[i].longitude);
                    var distance2 = Location.CalculateDistance(startPoint, endPoint, DistanceUnits.Kilometers);

                    if(distance2 < distance1)
                    {
                        index = i;
                        distance1 = distance2;
                    }
                }

                PolylineOptions options = new PolylineOptions()
                    .Add(new LatLng(point.Latitude, point.Longitude) 
                    , new LatLng(listplaces[index].latitude, listplaces[index].longitude));

                DrawPolyLine(options);

                var dist = (int)distance1;
                tvnearestdistance.Text = "Nearest Place Distance : " + dist+"(Km)";
                // PolygonOptions polyline 
                /*  map.AddPolyline(new PolylineOptions() 
                      .Add(new LatLng(circlepoint.Latitude, circlepoint.Longitude),
                      new LatLng(listplaces[index].latitude, listplaces[index].longitude)));
               */


                //  Toast.MakeText(this , "Distance" + listplaces[index].name  , ToastLength.Long).Show();

            }


        }

        public void DrawPolyLine(PolylineOptions options)
        {
            if (polylinedistance == null)
            {
                polylinedistance = map.AddPolyline(options);

            }
            else
            {
                polylinedistance.Remove();
                polylinedistance = map.AddPolyline(options);

            }
        }

        public bool OnTouch(View v, MotionEvent e)
        {
            // var sizee = e.GetSize(2);

            var aaa =(int) e.RawX;

            tvcircleradious.Text = "Circle Radius : " + aaa + "(Km)";

            progress.SetProgress(aaa , false);
            circleradious = aaa;

            if(circlepoint != null)
            {
                CreateCircle(circlepoint, circleradious);
                NoOfPlaces(circlepoint);

            }
            else
            {
                Toast.MakeText( this, "Long Press on Map Anywhere to Show Dragable Marker" , ToastLength.Short).Show();
            }
            // Toast.MakeText(this, "size"+ aaa, ToastLength.Long).Show();

            return true;
           // throw new NotImplementedException();
        }

        public void ShowDialloge(string text1 , string text2)
        {
            Dialog dialog = new Dialog(this);

            dialog.SetContentView(Resource.Layout.dialogee);

            TextView tv1 = (TextView) dialog.FindViewById(Resource.Id.tv1);
            
            tv1.Text = text1;

            dialog.Show();
            //AlertDialog dialog = new AlertDialog();
        }

     }
}