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

namespace PRI.ProductivityExtensions.DataGridViewRowHeightInfoNeededEventHandlerExtensions
{

	/// <summary>
	/// Class that contains extension methods that extend <seealso cref="System.Windows.Forms.DataGridViewRowHeightInfoNeededEventHandler">DataGridViewRowHeightInfoNeededEventHandler</seealso>
	/// </summary>
	public static partial class DataGridViewRowHeightInfoNeededEventHandlerable
	{
		/// <summary>
		/// Extends BeginInvoke so that when a state object is not needed, null does not need to be passed.
		/// <example>
		/// datagridviewrowheightinfoneededeventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this DataGridViewRowHeightInfoNeededEventHandler datagridviewrowheightinfoneededeventhandler, Object sender, DataGridViewRowHeightInfoNeededEventArgs e, AsyncCallback callback)
		{
			if(datagridviewrowheightinfoneededeventhandler == null) throw new ArgumentNullException("datagridviewrowheightinfoneededeventhandler");

			return datagridviewrowheightinfoneededeventhandler.BeginInvoke(sender, e, callback, null);
		}

	}
}
