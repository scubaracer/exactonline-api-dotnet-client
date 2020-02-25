﻿using System;

namespace ExactOnline.Client.Sdk.Exceptions
{
	[Serializable]
	public class IncorrectJsonException : Exception
	{
		public IncorrectJsonException()
		{
		}

		public IncorrectJsonException(string message)
			: base(message)
		{
		}
	}
}
