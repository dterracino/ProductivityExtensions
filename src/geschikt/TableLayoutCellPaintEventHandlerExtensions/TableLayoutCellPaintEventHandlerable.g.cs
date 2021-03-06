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

namespace PRI.ProductivityExtensions.TableLayoutCellPaintEventHandlerExtensions
{

	/// <summary>
	/// Class that contains extension methods that extend <seealso cref="System.Windows.Forms.TableLayoutCellPaintEventHandler">TableLayoutCellPaintEventHandler</seealso>
	/// </summary>
	public static partial class TableLayoutCellPaintEventHandlerable
	{
		/// <summary>
		/// Extends BeginInvoke so that when a state object is not needed, null does not need to be passed.
		/// <example>
		/// tablelayoutcellpainteventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this TableLayoutCellPaintEventHandler tablelayoutcellpainteventhandler, Object sender, TableLayoutCellPaintEventArgs e, AsyncCallback callback)
		{
			if(tablelayoutcellpainteventhandler == null) throw new ArgumentNullException("tablelayoutcellpainteventhandler");

			return tablelayoutcellpainteventhandler.BeginInvoke(sender, e, callback, null);
		}

	}
}
