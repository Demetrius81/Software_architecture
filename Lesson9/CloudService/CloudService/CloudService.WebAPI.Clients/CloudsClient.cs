using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudService.WebAPI.Clients;
public class CloudsClient
{
    private readonly HttpClient _client;
    private readonly ILogger<CloudsClient> _logger;

    public CloudsClient(HttpClient client, ILogger<CloudsClient> logger)
	{
        this._client = client;
        this._logger = logger;
    }
}
