﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace WebMvc.Infrastructure
{
    public class CustomHttpClient : IHttpClient
    {
        private readonly HttpClient _client;
        public CustomHttpClient()
        {
            _client = new HttpClient() ;
        }
        
        public Task<HttpResponseMessage> DeleteAsync(string uri, string authorizationToken = null, string authorizationMethod = "Bearer")
        {
            throw new NotImplementedException();
        }

        public async Task<string> GetStringAsync(string uri, string authorizationToken = null, string authorizationMethod = "Bearer")
        {
            var requestMessage = new HttpRequestMessage(HttpMethod.Get, uri);

            if (authorizationToken != null)
            {
                requestMessage.Headers.Authorization = new AuthenticationHeaderValue(authorizationMethod,
                    authorizationToken);
            }

            try
            {
                var response = await _client.SendAsync(requestMessage);

                return await response.Content.ReadAsStringAsync();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public Task<HttpResponseMessage> PostAsync<T>(string uri, T item, string authorizationToken = null, string authorizationMethod = "Bearer")
        {
            throw new NotImplementedException();
        }

        public Task<HttpResponseMessage> PutAsync<T>(string uri, T item, string authorizationToken = null, string authorizationMethod = "Bearer")
        {
            throw new NotImplementedException();
        }
    }
}
