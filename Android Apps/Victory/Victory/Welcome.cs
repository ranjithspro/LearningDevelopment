
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Provider;

namespace Victory
{
    [Activity(Label = "Welcome")]
    public class Welcome : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            ActionBar.NavigationMode = ActionBarNavigationMode.Tabs;
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Welcome_Page);

            Button Logout = FindViewById<Button>(Resource.Id.Logout);
            Logout.Click+=  delegate {
                StartActivity(typeof(MainActivity));
            };
			// Create your application here

			//var uri = ContactsContract.Contacts.ContentUri;

			string[] projection = { ContactsContract.Contacts.InterfaceConsts.Id,
	   ContactsContract.Contacts.InterfaceConsts.DisplayName };

            //var cursor = ManagedQuery(uri, projection, null, null, null);
            // var cursor = getContentResolver().query(uri, null, null, null,null);
            var cursor = ApplicationContext.ContentResolver.Query(ContactsContract.CommonDataKinds.Phone.ContentUri, null, null, null, null);

            var contactList = new string[cursor.Count];


			if (cursor.MoveToFirst())
			{
                int inc= 0;
				do
				{
                    contactList[inc]=cursor.GetString(
                        cursor.GetColumnIndex(projection[1]));
                    inc++;
				} while (cursor.MoveToNext());
			}
           // IListAdapter Adapter = new ArrayAdapter<string>(this, Resource.Id.tab1, contactList);


            TabHost tabHost = (TabHost)FindViewById(Resource.Id.tabHost);
			tabHost.Setup();
            ListView LV = FindViewById<ListView>(Resource.Id.ListViews);

            TabHost.TabSpec spec1 = tabHost.NewTabSpec("Tab 1");
            spec1.SetContent(Resource.Id.tab1);
			spec1.SetIndicator("Chats");
            ArrayAdapter Adapters = new ArrayAdapter(this, Resource.Layout.Contacts, contactList);
			LV.Adapter = Adapters;
			TabHost.TabSpec spec2 = tabHost.NewTabSpec("Tab 2");
			spec2.SetIndicator("Contacts");
			spec2.SetContent(Resource.Id.tab2);

			TabHost.TabSpec spec3 = tabHost.NewTabSpec("Tab 3");
			spec3.SetIndicator("Accounts");
			spec3.SetContent(Resource.Id.tab3);

			tabHost.AddTab(spec1);
			tabHost.AddTab(spec2);
			tabHost.AddTab(spec3);
        }
		
      
    }
}
