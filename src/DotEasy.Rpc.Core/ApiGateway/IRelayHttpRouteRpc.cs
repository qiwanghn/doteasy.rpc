using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;

namespace DotEasy.Rpc.Core.ApiGateway
{
    public interface IRelayHttpRouteRpc
    {
        StringContent HttpRouteRpc(List<dynamic> proxys, Uri urlPath, HttpRequestHeaders headers);
    }
}