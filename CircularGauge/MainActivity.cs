using Android.App;
using Android.Widget;
using Android.OS;
using Com.Syncfusion.Gauges.SfCircularGauge;
using System.Collections.ObjectModel;
using Android.Graphics;

namespace CircularGauge
{
    [Activity(Label = "CircularGauge", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SfCircularGauge circularGauge = new SfCircularGauge(this);
            circularGauge.SetBackgroundColor(Color.White);
            
            //Initializing scales for circular gauge
            ObservableCollection<CircularScale> scales = new ObservableCollection<CircularScale>();
            CircularScale scale = new CircularScale();
            scale.StartValue = 0;
            scale.EndValue = 100;
            scale.StartAngle = 180;
            scale.SweepAngle = 180;
            scales.Add(scale);
            
            //Adding needle pointer
            NeedlePointer needlePointer = new NeedlePointer();
            needlePointer.Value = 60;
            scale.CircularPointers.Add(needlePointer);
           
            circularGauge.CircularScales = scales;
            SetContentView(circularGauge);
        }
    }
}

