![Logo](https://apps.exactonline.com/content/css/images/exact-logo-red.png)

C# client SDK for the Exact Online RESTFul API
===============
<h3>Dare to contribute</h3>

At Exact we know how important it is to have an API you can easily work with. In reaching this ambition the next step is to offer you a C# client SDK which gives you a set of easy functions to call our API. Just some words for otherwise long statements. Combine it with the right Oauth framework and you are quickly on your way.

We have built this open-source client SDK so that you, as part of our community, can contribute to this C# SDK or just build a client SDK for the language you love. Check out the Github page and start contributing to make all our lives more focused.

<h3>Quick Guide</h3>

The Exact Online Client SDK provides a rich application framework and simplifies the interconnection with the Exact Online RESTful API. The Exact Online API can help you to quickly integrate with Exact Online and build innovative apps within the .NET environment. This document describes how to get started using the Exact Online Client SDK. 

The sample code in this document is in C#

<h4>1.	Reference Libraries</h4>

Include following references in your web project:
- ExactOnline.Client.Models.dll
- ExactOnline.Client.Sdk

Add following namespaces in your code file:
```
using ExactOnline.Client.Models;
using ExactOnline.Client.Sdk;
```

<h4>2.  OAuth</h4>
We have added an ExactOnline.Client.OAuth module, which takes care of the authentication. In this way you can easily execute the integration tests and user acceptance tests. When you want to use this you need to fill in your own client ID, client secret and callback url in the ExactOnline.Client.Sdk.TestContext in the TestObjectsCreator class. Of course you also can use your own OAuth implementation. 

<h4>3.	Initializing Exact Client </h4>

ExactOnline Client only supports the OAuth authentication for the API calls. To know more about OAuth please refer to Getting started - OAuth. To initialize the ExactOnlineClient object you need to provide the “apiEndPoint” & “AccessTokenDelegate”:
```
ExactOnlineClient client = new ExactOnlineClient (apiEndPoint, AccessTokenDelegate);
```

For multiple administrations you can also specify the division

```
ExactOnlineClient client = 
        new ExactOnlineClient (apiEndPoint, division, AccessTokenDelegate);
```

<u>apiEndPoint:</u> Exact Online URL for your country. For Netherlands: “https://start.exactonline.nl”

<u>AccessTokenDelegate:</u> Delegate that will be responsible to retrieve and refresh the OAuth access token. For OAuth implementation please refer to Example OAuth.

<h4>4.  </h4>
