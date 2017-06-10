using Android.App;
using Android.Widget;
using Android.OS;
using Android;

namespace Victory
{
    [Activity(Label = "Victory", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {
    //    int count = 1;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            Button button = FindViewById<Button>(Resource.Id.myButton);
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

            if (UserName == "441352" & passWord == "12345")
                return true;
			AD.SetMessage("Fuck OFFFFF!!!");
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

