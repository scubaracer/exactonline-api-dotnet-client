using System;

namespace ExactOnline.Client.Sdk.Exceptions
{
	[Serializable]
	public class BadRequestException : Exception // HTTP: 400
	{
		public BadRequestException() { }
		public BadRequestException(string message) : base(message) { }
	}
}