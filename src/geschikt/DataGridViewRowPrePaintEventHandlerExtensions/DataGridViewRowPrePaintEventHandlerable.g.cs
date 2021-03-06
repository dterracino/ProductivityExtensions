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

namespace PRI.ProductivityExtensions.DataGridViewRowPrePaintEventHandlerExtensions
{

	/// <summary>
	/// Class that contains extension methods that extend <seealso cref="System.Windows.Forms.DataGridViewRowPrePaintEventHandler">DataGridViewRowPrePaintEventHandler</seealso>
	/// </summary>
	public static partial class DataGridViewRowPrePaintEventHandlerable
	{
		/// <summary>
		/// Extends BeginInvoke so that when a state object is not needed, null does not need to be passed.
		/// <example>
		/// datagridviewrowprepainteventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this DataGridViewRowPrePaintEventHandler datagridviewrowprepainteventhandler, Object sender, DataGridViewRowPrePaintEventArgs e, AsyncCallback callback)
		{
			if(datagridviewrowprepainteventhandler == null) throw new ArgumentNullException("datagridviewrowprepainteventhandler");

			return datagridviewrowprepainteventhandler.BeginInvoke(sender, e, callback, null);
		}

	}
}
