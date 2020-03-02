using ExactOnline.Client.Sdk.Exceptions;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using Site.Models.Exact.Helpers;

//using System.Web.Script.Serialization;

namespace ExactOnline.Client.Sdk.Helpers
{
	/// <summary>
	/// Class for stripping unnecessary Json tags from API Response
	/// </summary>
	public class ApiResponseCleaner
	{
		#region Public methods

		/// <summary>
		/// Fetch Json Object (Json within ['d'] name/value pair) from response
		/// </summary>
		/// <param name="response"></param>
		/// <returns></returns>
        public static string GetJsonObject(string response)
        {

            var serializer = new JsonSerializer();
            serializer.Converters.Add( new JssDateTimeConverter());

            var oldCulture = CultureInfo.CurrentCulture;
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

            //var serializer = new JavaScriptSerializer();
            //serializer.RegisterConverters(new JssDateTimeConverter});

            string output;
            try
            {
				//var converter = new ExpandoObjectConverter();

				//JsonTextReader reader = new JsonTextReader(new StringReader(response));
                //var dict = serializer.Deserialize<Dictionary<string, object>>(reader);

                //JsonTextReader reader2 = new JsonTextReader(new StringReader(dict["d"].ToString()));
              //  return dict["d"].ToString();

                var jobjects = JObject.Parse(response);
                var d = jobjects["d"];

                var props = new Dictionary<string, object>();
                foreach (JProperty child in d.Children())
                {

                    var x = child.Name;
                    if (!child.Value.ToString().Contains("def"))
                    {
                        if (child.Value.Type.ToString() == "Null")
                        {
                            props.Add(child.Name, null);
                        }
                        else
                        {
                            props.Add(child.Name, child.Value.ToString());
                        }

                        //d.Children(). 
                    }
                }

                output = JsonConvert.SerializeObject(props);
				//var innerPart = serializer.Deserialize<Dictionary<string, object>>(reader2);

				//return innerPart["results"].ToString();
				//var dict = (Dictionary<string, object>)serializer.Deserialize<object>(response); // < -HERE IS THE ERROR
				//  var a = new JObject("json string");
				//                Dictionary<string, object> d = a.ToObject<Dictionary<string, object>>();

				//var d = (Dictionary<string, object>)dict["d"];
				//output = GetJsonFromDictionary(d);
			}
            finally
            {
                CultureInfo.CurrentCulture = oldCulture;
            }
            return output;
        }

		public static string GetSkipToken(string response)
		{
			//var serializer = new JavaScriptSerializer();
			//serializer.RegisterConverters(new JavaScriptConverter[] { new JssDateTimeConverter() });
            var serializer = new JsonSerializer();
            //var serializer = new JavaScriptSerializer();
            serializer.Converters.Add(new JssDateTimeConverter());

			var oldCulture = Thread.CurrentThread.CurrentCulture;
			Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
			string token = string.Empty;
			try
            {
                var dict = JsonConvert.DeserializeObject<Dictionary<string, object>>(response);
				//var dict = (Dictionary<string, object>)serializer.Deserialize<object>(response);
                //var a = new JObject("json string");
                //Dictionary<string, object> dict = a.ToObject<Dictionary<string, object>>();

				var innerPart = dict["d"];
				if (innerPart.GetType() == typeof(Dictionary<string, object>))
				{
					var d = (Dictionary<string, object>)dict["d"];
					if (d.ContainsKey("__next"))
					{
						var next = (string)d["__next"];

						// Skiptoken has format "$skiptoken=xyz" in the url and we want to extract xyz.
						var match = Regex.Match(next ?? "", @"\$skiptoken=([^&#]*)");

						// Extract the skip token
						token = match.Success ? match.Groups[1].Value : null;
					}
				}
			}
			catch (Exception e)
			{
				throw new IncorrectJsonException(e.Message);
			}
			finally
			{
				Thread.CurrentThread.CurrentCulture = oldCulture;
			}
			return token;
		}

		/// <summary>
		/// Fetch Json Array (Json within ['d']['results']) from response
		/// </summary>
		public static string GetJsonArray(string response)
		{
            var serializer = new JsonSerializer();
			//var serializer = new JavaScriptSerializer();
			serializer.Converters.Add(new JssDateTimeConverter());
			//serializer.RegisterConverters(new JavaScriptConverter[] { new JssDateTimeConverter() });

			var oldCulture = Thread.CurrentThread.CurrentCulture;
			Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
			try
			{

				//var z4 = JsonConvert.DeserializeObject<ArrayList>(z3["results"].ToString());
				//var j = JObject.Parse(response);

				////var jo = (JObject)JsonConvert.DeserializeObject<object>(response);
				////var converter = new ExpandoObjectConverter();
				JsonTextReader reader = new JsonTextReader(new StringReader(response));
				var dict = serializer.Deserialize<Dictionary<string, object>>(reader);
    
	    		JsonTextReader reader2 = new JsonTextReader(new StringReader(dict["d"].ToString()));
		    	var innerPart = serializer.Deserialize<Dictionary<string, object>>(reader2);

                return innerPart["results"].ToString();
				//            if (innerPart.GetType() == typeof(Dictionary<string, object>))
				//{
				//JsonTextReader reader3 = new JsonTextReader(new StringReader());
				//var res = serializer.Deserialize<ArrayList>(reader3);
				//                //var r = GetJsonFromResultDictionary(res);
				//	//   var d = (Dictionary<string, object>)dict["d"];
				//	//  results = (ArrayList)d["results"];
				//}
				//else
				//            {
				//               // results = (ArrayList)innerPart;
				//}
				//JObject jsonObj = JObject.Parse(response);
				//            var zzz = serializer.Deserialize<JObject>(jsonObj);
				//            var resultsJson = jsonObj["d"]["results"];
				//            if (resultsJson != null)
				//            {
				//                results = JsonConvert.DeserializeObject<ArrayList>(resultsJson.ToString());
				//            }
				//else
				//{
				//                results = JsonConvert.DeserializeObject<ArrayList>(jsonObj.ToString());
				//}

				//	return GetJsonFromResultDictionary("");
				//return null;
                //if (innerPart.GetType() == typeof(Dictionary<string, object>))
                //{
                //	var d = (Dictionary<string, object>)dict["d"];
                //	results = (ArrayList)d["results"];
                //}
                //else
                //{
                //	results = (ArrayList)innerPart;
                //}
                //return GetJsonFromResultDictionary(results);
            }
			catch (Exception e)
			{
				throw new IncorrectJsonException(e.Message);
			}
			finally
			{
				Thread.CurrentThread.CurrentCulture = oldCulture;
			}



        }
		#endregion

		#region Private methods

		/// <summary>
		/// Converts key/value pairs to json
		/// </summary>
		private static string GetJsonFromDictionary(Dictionary<string, object> dictionary)
		{
			string json = "{";

			foreach (var entry in dictionary)
			{
				if (entry.Value == null || entry.Value.GetType() != typeof(Dictionary<string, object>))
				{
					// Entry is of type keyvaluepair
					json += "\"" + entry.Key + "\":";
					if (entry.Value == null)
					{
						json += "null";
					}
					else
					{
						json += JsonConvert.ToString(entry.Value.ToString());
					}
					json += ",";
				}
				else
				{
					// Create linked entities json
					var subcollection = (Dictionary<string, object>)entry.Value;
					if (subcollection.Keys.Contains("results"))
					{
						var results = (ArrayList)subcollection["results"];
						string subjson = GetJsonFromResultDictionary(results);
						if (subjson.Length > 0)
						{
							json += "\"" + entry.Key + "\":";
							json += subjson;
							json += ",";
						}
					}
				}
			}

			json = json.Remove(json.Length - 1, 1); // Remove last comma
			json += "}";

			return json;
		}

		private static string GetJsonFromResultDictionary(ArrayList results)
		{
			string json = "[";
			if (results != null && results.Count > 0)
			{

				foreach (var Jentity in results)
				{
                    var entity = JsonConvert.DeserializeObject<Dictionary<string, Object>>(Jentity.ToString());
					json += GetJsonFromDictionary(entity) + ",";
				}

				json = json.Remove(json.Length - 1, 1); // Remove last comma
			}
			json += "]";
			return json;
		}

		#endregion

	}
}
