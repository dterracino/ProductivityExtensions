//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using Microsoft.Win32;

namespace PRI.ProductivityExtensions.SessionEndedEventHandlerExtensions
{

	/// <summary>
	/// Class that contains extension methods that extend <seealso cref="Microsoft.Win32.SessionEndedEventHandler">SessionEndedEventHandler</seealso>
	/// </summary>
	public static partial class SessionEndedEventHandlerable
	{
		/// <summary>
		/// Extends BeginInvoke so that when a state object is not needed, null does not need to be passed.
		/// <example>
		/// sessionendedeventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this SessionEndedEventHandler sessionendedeventhandler, Object sender, SessionEndedEventArgs e, AsyncCallback callback)
		{
			if(sessionendedeventhandler == null) throw new ArgumentNullException("sessionendedeventhandler");

			return sessionendedeventhandler.BeginInvoke(sender, e, callback, null);
		}

	}
}
