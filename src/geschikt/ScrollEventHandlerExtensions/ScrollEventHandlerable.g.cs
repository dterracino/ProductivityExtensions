//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Windows.Forms;

namespace PRI.ProductivityExtensions.ScrollEventHandlerExtensions
{

	/// <summary>
	/// Class that contains extension methods that extend <seealso cref="System.Windows.Forms.ScrollEventHandler">ScrollEventHandler</seealso>
	/// </summary>
	public static partial class ScrollEventHandlerable
	{
		/// <summary>
		/// Extends BeginInvoke so that when a state object is not needed, null does not need to be passed.
		/// <example>
		/// scrolleventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this ScrollEventHandler scrolleventhandler, Object sender, ScrollEventArgs e, AsyncCallback callback)
		{
			if(scrolleventhandler == null) throw new ArgumentNullException("scrolleventhandler");

			return scrolleventhandler.BeginInvoke(sender, e, callback, null);
		}

	}
}
