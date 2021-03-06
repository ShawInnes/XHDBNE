﻿using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

using Xamarin.Forms.Platform.Android;
using Microsoft.WindowsAzure.MobileServices;

namespace MobileApp.Droid
{
	[Activity(Label = "MobileApp", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : AndroidActivity
	{
		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);

			CurrentPlatform.Init();

			Xamarin.Forms.Forms.Init(this, bundle);

			SetPage(App.GetMainPage());
		}
	}
}

