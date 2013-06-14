//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Net.Sockets;

namespace PRI.ProductivityExtensions.UdpSingleSourceMulticastClientExtensions
{

	/// <summary>
	/// Class that contains extension methods that extend <seealso cref="System.Net.Sockets.UdpSingleSourceMulticastClient">UdpSingleSourceMulticastClient</seealso>
	/// </summary>
	public static partial class UdpSingleSourceMulticastClientable
	{
		/// <summary>
		/// Extends BeginJoinGroup so that when a state object is not needed, null does not need to be passed.
		/// <example>
		/// udpsinglesourcemulticastclient.BeginJoinGroup(callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginJoinGroup(this UdpSingleSourceMulticastClient udpsinglesourcemulticastclient, AsyncCallback callback)
		{
			if(udpsinglesourcemulticastclient == null) throw new ArgumentNullException("udpsinglesourcemulticastclient");

			return udpsinglesourcemulticastclient.BeginJoinGroup(callback, null);
		}

		/// <summary>
		/// Extends BeginReceiveFromSource so that buffer offset of 0 and call to Array.Length are not needed.
		/// <example>
		/// udpsinglesourcemulticastclient.BeginReceiveFromSource(buffer, callback, state);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginReceiveFromSource(this UdpSingleSourceMulticastClient udpsinglesourcemulticastclient, Byte[] buffer, AsyncCallback callback, Object state)
		{
			if(udpsinglesourcemulticastclient == null) throw new ArgumentNullException("udpsinglesourcemulticastclient");

			if(buffer == null) throw new ArgumentNullException("buffer");

			return udpsinglesourcemulticastclient.BeginReceiveFromSource(buffer, 0, buffer.Length, callback, state);
		}

		/// <summary>
		/// Extends BeginReceiveFromSource so that when a state object is not needed, null does not need to be passed.
		/// <example>
		/// udpsinglesourcemulticastclient.BeginReceiveFromSource(buffer, offset, count, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginReceiveFromSource(this UdpSingleSourceMulticastClient udpsinglesourcemulticastclient, Byte[] buffer, Int32 offset, Int32 count, AsyncCallback callback)
		{
			if(udpsinglesourcemulticastclient == null) throw new ArgumentNullException("udpsinglesourcemulticastclient");

			return udpsinglesourcemulticastclient.BeginReceiveFromSource(buffer, offset, count, callback, null);
		}

		/// <summary>
		/// Extends BeginReceiveFromSource so that buffer offset of 0 and call to Array.Length are not needed.
		/// <example>
		/// udpsinglesourcemulticastclient.BeginReceiveFromSource(buffer, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginReceiveFromSource(this UdpSingleSourceMulticastClient udpsinglesourcemulticastclient, Byte[] buffer, AsyncCallback callback)
		{
			if(udpsinglesourcemulticastclient == null) throw new ArgumentNullException("udpsinglesourcemulticastclient");

			if(buffer == null) throw new ArgumentNullException("buffer");

			return udpsinglesourcemulticastclient.BeginReceiveFromSource(buffer, 0, buffer.Length, callback);
		}

		/// <summary>
		/// Extends BeginSendToSource so that buffer offset of 0 and call to Array.Length are not needed.
		/// <example>
		/// udpsinglesourcemulticastclient.BeginSendToSource(buffer, remotePort, callback, state);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginSendToSource(this UdpSingleSourceMulticastClient udpsinglesourcemulticastclient, Byte[] buffer, Int32 remotePort, AsyncCallback callback, Object state)
		{
			if(udpsinglesourcemulticastclient == null) throw new ArgumentNullException("udpsinglesourcemulticastclient");

			if(buffer == null) throw new ArgumentNullException("buffer");

			return udpsinglesourcemulticastclient.BeginSendToSource(buffer, 0, buffer.Length, remotePort, callback, state);
		}

		/// <summary>
		/// Extends BeginSendToSource so that when a state object is not needed, null does not need to be passed.
		/// <example>
		/// udpsinglesourcemulticastclient.BeginSendToSource(buffer, offset, count, remotePort, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginSendToSource(this UdpSingleSourceMulticastClient udpsinglesourcemulticastclient, Byte[] buffer, Int32 offset, Int32 count, Int32 remotePort, AsyncCallback callback)
		{
			if(udpsinglesourcemulticastclient == null) throw new ArgumentNullException("udpsinglesourcemulticastclient");

			return udpsinglesourcemulticastclient.BeginSendToSource(buffer, offset, count, remotePort, callback, null);
		}

		/// <summary>
		/// Extends BeginSendToSource so that buffer offset of 0 and call to Array.Length are not needed.
		/// <example>
		/// udpsinglesourcemulticastclient.BeginSendToSource(buffer, remotePort, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginSendToSource(this UdpSingleSourceMulticastClient udpsinglesourcemulticastclient, Byte[] buffer, Int32 remotePort, AsyncCallback callback)
		{
			if(udpsinglesourcemulticastclient == null) throw new ArgumentNullException("udpsinglesourcemulticastclient");

			if(buffer == null) throw new ArgumentNullException("buffer");

			return udpsinglesourcemulticastclient.BeginSendToSource(buffer, 0, buffer.Length, remotePort, callback);
		}

	}
}
