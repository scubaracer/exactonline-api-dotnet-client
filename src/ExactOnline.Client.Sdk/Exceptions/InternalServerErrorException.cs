using System;

namespace ExactOnline.Client.Sdk.Exceptions
{
	[Serializable]
	public class InternalServerErrorException : Exception // HTTP 500
	{
		public InternalServerErrorException()
		{
		}

		public InternalServerErrorException(string message) : base(message)
		{
		}
	}
}
