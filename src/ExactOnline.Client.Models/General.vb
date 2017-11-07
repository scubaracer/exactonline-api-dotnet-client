' Last generated on 2017-11-07 10:05:59Z

Namespace General

	<SupportedActionsSDK(False, True, False, False)>
	<DataServiceKey("Code")>
	Public Class [Currency]
		'''<summary>Amount precision</summary>
		Public Property [AmountPrecision] As Double
		'''<summary>Primary key</summary>
		Public Property [Code] As String
		'''<summary>Creation date</summary>
		Public Property [Created] As DateTime?
		'''<summary>Description of the currency</summary>
		Public Property [Description] As String
		'''<summary>Last modified date</summary>
		Public Property [Modified] As DateTime?
		'''<summary>Price precision</summary>
		Public Property [PricePrecision] As Double
	End Class

End Namespace