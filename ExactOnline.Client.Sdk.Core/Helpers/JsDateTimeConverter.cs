using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
//using Microsoft.AspNetCore.Mvc.Formatters.Json;
//using Microsoft.AspNetCore.JsonPatch;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Site.Models.Exact.Helpers
{
	/// <summary>
	/// Custom JavaScriptConverter for parsing datetime value correctly
	/// </summary>
	public class JssDateTimeConverter : StringEnumConverter // : JavaScriptConverter
	{
		public IEnumerable<Type> SupportedTypes  //override
		{
			get
			{
				return new[] { typeof(Object) };
			}
		}

		public object Deserialize(IDictionary<string, object> dictionary, Type type, JsonSerializer serializer)
		{
			var keys = new List<string>(dictionary.Keys);

			foreach (string key in keys)
			{
				object entity = dictionary[key];

				// Check if content is a dictionary > send to this method recursively
				if (entity != null && entity.GetType() == typeof(Dictionary<string, object>))
				{
					var value = (Dictionary<string, object>)entity;
					Deserialize(value, type, serializer);
				}
				else
				{
					var value = entity;
					if (value != null)
					{
						// Set EPOCH datetime
						Type valueType = value.GetType();
						if (valueType == typeof(DateTime))
						{
							var date = (DateTime)entity;
							TimeSpan t = (date - new DateTime(1970, 1, 1));
							double timestamp = t.TotalMilliseconds;
							dictionary[key] = string.Format("/Date({0})/", timestamp);
						}

						// For collection within this collection > send to this method recursively
						if (valueType == typeof(ArrayList))
						{
							IEnumerable<object> dictionaries = ((ArrayList)value).ToArray().Where(x => x.GetType() == typeof(Dictionary<string, object>));

							foreach (var dict in dictionaries)
							{
								Deserialize((Dictionary<string, object>)dict, type, serializer);
							}
						}
					}
				}
			}
			return dictionary;
		}

		public IDictionary<string, object> Serialize(object obj, JsonSerializer serializer)
		{
			return null;
		}
	}
}