using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using ExactOnline.Client.Sdk.Delegates;
using ExactOnline.Client.Sdk.Enums;
using ExactOnline.Client.Sdk.Exceptions;
using ExactOnline.Client.Sdk.Interfaces;
using Newtonsoft.Json;

namespace ExactOnline.Client.Sdk.Helpers
{
	/// <summary>
	/// Class for doing request to REST API
	/// </summary>
	public class ApiConnector : IApiConnector
	{
		private readonly AccessTokenManagerDelegate _accessTokenDelegate;

		#region Constructor

		/// <summary>
		/// Creates new instance of ApiConnector
		/// </summary>
		/// <param name="accessTokenDelegate">Valid oAuth Access Token</param>
		public ApiConnector(AccessTokenManagerDelegate accessTokenDelegate)
		{
			if (accessTokenDelegate == null) throw new ArgumentException("accessTokenDelegate");
			_accessTokenDelegate = accessTokenDelegate;
		}

		#endregion

		#region Public methods

		/// <summary>
		/// Read Data: Perform a GET Request on the API
		/// </summary>
		/// <param name="endpoint">{URI}/{Division}/{Resource}/{Entity}</param>
		/// <param name="oDataQuery">oData Querystring</param>
		/// <returns>String with API Response in Json Format</returns>
		public string DoGetRequest(string endpoint, string oDataQuery)
		{
			if (string.IsNullOrEmpty(endpoint)) throw new ArgumentException("Cannot perform request with empty endpoint");

			var request = CreateRequest(endpoint, oDataQuery, RequestTypeEnum.GET);

			return GetResponse(request);
		}

		/// <summary>
		/// Create Data: Perform a POST Request on the API
		/// </summary>
		/// <param name="endpoint">{URI}/{Division}/{Resource}/{Entity}</param>
		/// <param name="postdata">String containing data of new entity in Json format</param>
		/// <returns>String with API Response in Json Format</returns>
		public string DoPostRequest(string endpoint, string postdata)
		{
			if (string.IsNullOrEmpty(endpoint) || string.IsNullOrEmpty(postdata)) throw new ArgumentException("Cannot perform request with empty endpoint or postdata");

			var request = CreateRequest(endpoint, null, RequestTypeEnum.POST);

			// Add POST data to the request
			if (!string.IsNullOrEmpty(postdata))
			{
				var bytes = Encoding.GetEncoding("iso-8859-1").GetBytes(postdata);
				request.ContentLength = bytes.Length;

				using (var writeStream = request.GetRequestStream())
				{
					writeStream.Write(bytes, 0, bytes.Length);
				}
			}
			else
			{
				throw new BadRequestException(); // Post request needs data
			}

			return GetResponse(request);
		}

		/// <summary>
		/// Update data: Perform a PUT Request on API
		/// </summary>
		/// <param name="endpoint">{URI}/{Division}/{Resource}/{Entity}</param>
		/// <param name="putData">String containing updated entity data in Json format</param>
		/// <returns>String with API Response in Json Format</returns>
		public string DoPutRequest(string endpoint, string putData)
		{
			if (string.IsNullOrEmpty(endpoint) || string.IsNullOrEmpty(putData)) throw new ArgumentException("Cannot perform request with empty endpoint or putData");

			var request = CreateRequest(endpoint, null, RequestTypeEnum.PUT);

			if (!string.IsNullOrEmpty(putData))
			{
				var bytes = Encoding.GetEncoding("iso-8859-1").GetBytes(putData);
				request.ContentLength = bytes.Length;

				using (var writeStream = request.GetRequestStream())
				{
					writeStream.Write(bytes, 0, bytes.Length);
				}
			}
			else
			{
				// Post request needs data
				throw new BadRequestException();
			}
			return GetResponse(request);
		}

		/// <summary>
		/// Delete entity: Perform a DELETE Request on API
		/// </summary>
		/// <param name="endpoint">{URI}/{Division}/{Resource}/{Entity}</param>
		/// <returns>String with API Response in Json Format</returns>
		public string DoDeleteRequest(string endpoint)
		{
			if (string.IsNullOrEmpty(endpoint)) throw new ArgumentException("Cannot perform request with empty endpoint");

			var request = CreateRequest(endpoint, null, RequestTypeEnum.DELETE);

			return GetResponse(request);
		}

		/// <summary>
		/// Request without 'Accept' Header
		/// </summary>
		/// <param name="uri"></param>
		/// <returns></returns>
		public string DoCleanRequest(string uri) // Build for doing $count function
		{
			var request = (HttpWebRequest)WebRequest.Create(uri);
			request.Method = RequestTypeEnum.GET.ToString();
			request.ContentType = "application/json";
			request.Headers.Add("Authorization", "Bearer " + _accessTokenDelegate());
			return GetResponse(request);
		}

		public int GetCurrentDivision(string website)
		{
			var url = website + "/api/v1/current/Me" ;
			const string oDataQuery = "$select=CurrentDivision";
			
			var request = CreateRequest(url, oDataQuery, RequestTypeEnum.GET);
			var response = GetResponse(request);
			var jsonObject = JsonConvert.DeserializeObject<dynamic>(response);
			
			return (int)jsonObject.d["results"][0]["CurrentDivision"].Value;
		}

		#endregion

		#region Private methods

		private HttpWebRequest CreateRequest(string url, string oDataQuery, RequestTypeEnum method)
		{
			if (!string.IsNullOrEmpty(oDataQuery))
			{
				url += "?" + oDataQuery;
			}

			var request = (HttpWebRequest)WebRequest.Create(url);
			request.Method = method.ToString();
			request.ContentType = "application/json";
			request.Accept = "application/json";
			request.Headers.Add("Authorization", "Bearer " + _accessTokenDelegate());

			Debug.WriteLine(request.Method);
			Debug.WriteLine(url);

			return request;
		}

		private string GetResponse(HttpWebRequest request)
		{
			// Grab the response
			var responseValue = string.Empty;

			// Get response. If this fails: Throw the correct Exception (for testability)
			try
			{
				WebResponse response = request.GetResponse();
				using (Stream responseStream = response.GetResponseStream())
				{
					if (responseStream != null)
					{
						var reader = new StreamReader(responseStream);
						responseValue = reader.ReadToEnd();
					}
				}
			}
			catch (Exception e)
			{
				// Check if of WebException Type
				if (e.GetType() == typeof(WebException))
				{
					var exception = (WebException)e;
					var errorMessage = new StreamReader(exception.Response.GetResponseStream()).ReadToEnd();
					var statusCode = (((HttpWebResponse)exception.Response).StatusCode);

					Debug.WriteLine(errorMessage);

					Exception throwException = exception;
					switch (statusCode)
					{
						case HttpStatusCode.BadRequest:
							throwException = new BadRequestException(e.Message); // 400
							break;

						case HttpStatusCode.Unauthorized: //401

							throwException = new UnauthorizedException(); // 401
							break;

						case HttpStatusCode.Forbidden:
							throwException = new ForbiddenException(); // 403
							break;

						case HttpStatusCode.NotFound:
							throwException = new NotFoundException(); // 404
							break;

						case HttpStatusCode.InternalServerError: // 500
							string exceptionmessage;

							try
							{
								var deserializedObject = JsonConvert.DeserializeObject<dynamic>(errorMessage);
								exceptionmessage = deserializedObject["error"]["message"]["value"];
							}
							catch (Exception)
							{
								exceptionmessage = "Unknown error";
							}
							throwException = new InternalServerErrorException(exceptionmessage);
							break;

						case HttpStatusCode.MethodNotAllowed: // 405
							throwException = new BadRequestException();
							break;
					}

					throw throwException;

				}
			}

			Debug.WriteLine(responseValue);

			return responseValue;
		}

		#endregion

	}
}