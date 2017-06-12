using Android.App;
using Android.Widget;
using Android.OS;
using Android;
using System.Collections.Generic;

namespace Victory
{
    [Activity(Label = "Victory", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {
        //    int count = 1;
        Dictionary<string, string> Credentials = new Dictionary<string, string>();

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Credentials.Add("441352", "12345");
            Credentials.Add("1", "1");
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            ImageView button = FindViewById<ImageView>(Resource.Id.myButton);
            EditText txtName = FindViewById<EditText>(Resource.Id.editText1);
            EditText txtPassWord = FindViewById<EditText>(Resource.Id.editText2);

            //    button.Click += delegate { button.Text = $"{count++} clicks!"; };
            bool Validated = false;
            button.Click += delegate {
              Validated = Validate(txtName.Text,txtPassWord.Text);
                if(Validated)
                {
                    StartActivity(typeof(Welcome));
                }
                    
            };
        }

        public bool Validate(string UserName,string passWord)
        {
            
            Android.App.AlertDialog.Builder AlertBox = new AlertDialog.Builder(this);
            AlertDialog AD = AlertBox.Create();
            AD.SetIcon(Android.Resource.Drawable.IcDialogAlert);

            if (Credentials.ContainsKey(UserName))
            {
                if (Credentials[UserName] == passWord)
                    return true;
            }
			AD.SetMessage("Fuck Offff!!!");
            AD.SetButton("GetOut",(sender, e) =>
            {
                AD.Hide();
               
            });
            AD.Show();
            return false;
           // Toast.MakeText(ApplicationContext,Result,ToastLength.Long);
        }
    }
}

