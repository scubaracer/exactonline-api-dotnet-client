Namespace Webhooks

    <SupportedActionsSDK(True, True, False, True)>
    <DataServiceKey("ID")>
    Public Class [WebhookSubscriptions]
        Public Property [ID] As Guid
        Public Property [CallbackURL] As String
        Public Property [Topic] As String
    End Class

End Namespace