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

namespace PRI.ProductivityExtensions.DrawItemEventHandlerExtensions
{

	/// <summary>
	/// Class that contains extension methods that extend <seealso cref="System.Windows.Forms.DrawItemEventHandler">DrawItemEventHandler</seealso>
	/// </summary>
	public static partial class DrawItemEventHandlerable
	{
		/// <summary>
		/// Extends BeginInvoke so that when a state object is not needed, null does not need to be passed.
		/// <example>
		/// drawitemeventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this DrawItemEventHandler drawitemeventhandler, Object sender, DrawItemEventArgs e, AsyncCallback callback)
		{
			if(drawitemeventhandler == null) throw new ArgumentNullException("drawitemeventhandler");

			return drawitemeventhandler.BeginInvoke(sender, e, callback, null);
		}

	}
}
