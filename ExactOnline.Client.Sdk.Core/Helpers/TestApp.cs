﻿using System;

namespace ExactOnline.Client.Sdk.Helpers
{

	/// <summary>
	/// This class is a container for the authorisation details of your test app. These details can be found in the app center 
	/// in the maintenance page of your app.
	/// </summary>
	public class TestApp
	{
		public Guid ClientId { get; set; }
		public string ClientSecret { get; set; }
		public Uri CallbackUrl { get; set; }

		/// <summary>
		/// The application details are read from file testapp.config.
		/// testapp.config should consist of 3 lines containing client id, secret and callback url:
		/// 00000000-0000-0000-0000-000000000000
		/// secret
		/// http://foo.bar
		/// </summary>
		public TestApp()
		{
			string[] details = System.IO.File.ReadAllLines(@"..\..\..\..\testapp.config");

			ClientId = new Guid(details[0]);
			ClientSecret = details[1];
			CallbackUrl = new Uri(details[2]);
		}

	}
}
