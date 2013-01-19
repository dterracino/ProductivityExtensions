//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace PRI.ProductivityExtensions.TcpClientExtensions
{

	/// <summary>
	/// Class that contains extension methods that extend <seealso cref="System.Net.Sockets.TcpClient">TcpClient</seealso>
	/// </summary>
	public static partial class TcpClientable
	{
		/// <summary>
		/// Extends BeginConnect so that when a state object is not needed, null does not need to be passed.
		/// <example>
		/// tcpclient.BeginConnect(host, port, requestCallback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginConnect(this TcpClient tcpclient, String host, Int32 port, AsyncCallback requestCallback)
		{
			if(tcpclient == null) throw new ArgumentNullException("tcpclient");

			return tcpclient.BeginConnect(host, port, requestCallback, null);
		}

		/// <summary>
		/// Extends BeginConnect so that when a state object is not needed, null does not need to be passed.
		/// <example>
		/// tcpclient.BeginConnect(address, port, requestCallback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginConnect(this TcpClient tcpclient, System.Net.IPAddress address, Int32 port, AsyncCallback requestCallback)
		{
			if(tcpclient == null) throw new ArgumentNullException("tcpclient");

			return tcpclient.BeginConnect(address, port, requestCallback, null);
		}

		/// <summary>
		/// Extends BeginConnect so that when a state object is not needed, null does not need to be passed.
		/// <example>
		/// tcpclient.BeginConnect(addresses, port, requestCallback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginConnect(this TcpClient tcpclient, System.Net.IPAddress[] addresses, Int32 port, AsyncCallback requestCallback)
		{
			if(tcpclient == null) throw new ArgumentNullException("tcpclient");

			return tcpclient.BeginConnect(addresses, port, requestCallback, null);
		}

	}
}
