using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using AndroidX.AppCompat.App;
using System;

namespace number
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        SeekBar seekBar;
        TextView resultTextView; 
        Button rollButton;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_main);
            seekBar = FindViewById<SeekBar>(Resource.Id.seekBar1);
            resultTextView = FindViewById<TextView>(Resource.Id.resultTextView); resultTextView.Text = "5";
            rollButton = (Button)FindViewById(Resource.Id.button1); rollButton.Click += RollButton_Click;
            SupportActionBar.Title = "My Lucky Number";
        }

        private void RollButton_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int luckyNmber = random.Next(seekBar.Progress) + 1; resultTextView.Text = luckyNmber.ToString();
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}