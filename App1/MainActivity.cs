using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Com.Xamarin.Textcounter;

namespace App1
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            var txtIntput = FindViewById<EditText>(Resource.Id.txtInput);
            var btnAnalyze = FindViewById<Button>(Resource.Id.btnAnalyze);

            btnAnalyze.Click += (sender, e) =>
            {
                int vowelCount = TextCounter.NumVowels(txtIntput.Text);
                int consonantCount = TextCounter.NumConsonants(txtIntput.Text);
                Toast.MakeText(this, $"Vowels : {vowelCount}, Consonants : {consonantCount}", ToastLength.Long).Show();
            };
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}