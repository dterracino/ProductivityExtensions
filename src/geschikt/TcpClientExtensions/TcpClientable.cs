﻿using System;
using System.Net;
using System.Net.Sockets;

#if NET_4_5
using System.Threading.Tasks;
#endif

namespace PRI.ProductivityExtensions.TcpClientExtensions
{
	public static partial class TcpClientable
	{
		public static IAsyncResult BeginConnect(this TcpClient tcpClient, IPEndPoint endPoint, AsyncCallback asyncCallback)
		{
			if (tcpClient == null) throw new ArgumentNullException("tcpClient");
			return tcpClient.BeginConnect(endPoint.Address, endPoint.Port, asyncCallback, null);
		}

		public static IAsyncResult BeginConnect(this TcpClient tcpClient, IPEndPoint endPoint, AsyncCallback asyncCallback, object state)
		{
			if (tcpClient == null) throw new ArgumentNullException("tcpClient");
			return tcpClient.BeginConnect(endPoint.Address, endPoint.Port, asyncCallback, state);
		}

#if NET_4_5
		/// <summary>
		/// Connect asyncronously to <param name="endPoint"></param>
		/// </summary>
		/// <param name="tcpClient"><see cref="TcpClient"/> object to connect with</param>
		/// <param name="endPoint"></param>
		/// <returns></returns>
		/// <exception cref="ArgumentException">if <param name="endPoint"/> is not a 
		/// <see cref="DnsEndPoint"/> nor an <see cref="IPEndPoint"/></exception>
		public static Task ConnectAsync(this TcpClient tcpClient, EndPoint endPoint)
		{
			if (tcpClient == null) throw new ArgumentNullException("tcpClient");
			if (endPoint == null) throw new ArgumentNullException("endPoint");

			var dnsEndPoint = endPoint as DnsEndPoint;
			if (dnsEndPoint != null)
				return tcpClient.ConnectAsync(dnsEndPoint.Host, dnsEndPoint.Port);
			var ipEndPoint = endPoint as IPEndPoint;
			if (ipEndPoint != null)
				return tcpClient.ConnectAsync(ipEndPoint.Address, ipEndPoint.Port);
			throw new ArgumentException("Unsupported EndPoint type", "endpoint");
		}
#endif
	}
}
