using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Collections.ArrayList;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Chat
{
	[Activity (Label = "Chat", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{
		/** The Conversation list. */
		private List<Conversation> convList;

		/** The chat adapter. */
		private ChatAdapter adp;

		/** The Editext to compose the message. */
		private EditText txt;

		/** The user name of buddy. */
		private String buddy;

		/** The date of last message in conversation. */
		private Date lastMsgDate;

		/** Flag to hold if the activity is running or not. */
		private boolean isRunning;

		/** The handler. */
		private static Handler handler;

		protected override void OnCreate (Bundle savedInstanceState)
		{
			Xamarin.Insights.Initialize (XamarinInsights.ApiKey, this);
			base.OnCreate (savedInstanceState);
			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);
		
		}
	}
}
