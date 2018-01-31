namespace ExactOnline.Client.Sdk.Helpers
{
	public static class StringExtensions
	{
		public static int? ToNullableInt(this string s)
		{
            if (int.TryParse(s, out int i))
            {
                return i;
            }
            return null;
		}

        public static long? ToNullableLong(this string s)
        {
            if (long.TryParse(s, out long i))
            {
                return i;
            }
            return null;
        }

    }
}
