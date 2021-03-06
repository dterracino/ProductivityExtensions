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

namespace PRI.ProductivityExtensions.MaskInputRejectedEventHandlerExtensions
{

	/// <summary>
	/// Class that contains extension methods that extend <seealso cref="System.Windows.Forms.MaskInputRejectedEventHandler">MaskInputRejectedEventHandler</seealso>
	/// </summary>
	public static partial class MaskInputRejectedEventHandlerable
	{
		/// <summary>
		/// Extends BeginInvoke so that when a state object is not needed, null does not need to be passed.
		/// <example>
		/// maskinputrejectedeventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this MaskInputRejectedEventHandler maskinputrejectedeventhandler, Object sender, MaskInputRejectedEventArgs e, AsyncCallback callback)
		{
			if(maskinputrejectedeventhandler == null) throw new ArgumentNullException("maskinputrejectedeventhandler");

			return maskinputrejectedeventhandler.BeginInvoke(sender, e, callback, null);
		}

	}
}
