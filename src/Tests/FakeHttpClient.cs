﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Info.Blockchain.API.Abstractions;

namespace Info.Blockchain.API.Tests
{
	public class FakeHttpClient : IHttpClient
	{
		public void Dispose()
		{
		}

		public string ApiCode { get; set; }
		public Task<T> GetAsync<T>(string route, QueryString queryString = null, Func<string, T> customDeserialization = null)
		{
			return Task.FromResult(default(T));
		}

		public Task<TResponse> PostAsync<TPost, TResponse>(string route, TPost postObject, Func<string, TResponse> customDeserialization = null)
		{
			return Task.FromResult(default(TResponse));
		}
	}
}
