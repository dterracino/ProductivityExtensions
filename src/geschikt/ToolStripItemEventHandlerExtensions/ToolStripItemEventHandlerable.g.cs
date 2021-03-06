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

namespace PRI.ProductivityExtensions.ToolStripItemEventHandlerExtensions
{

	/// <summary>
	/// Class that contains extension methods that extend <seealso cref="System.Windows.Forms.ToolStripItemEventHandler">ToolStripItemEventHandler</seealso>
	/// </summary>
	public static partial class ToolStripItemEventHandlerable
	{
		/// <summary>
		/// Extends BeginInvoke so that when a state object is not needed, null does not need to be passed.
		/// <example>
		/// toolstripitemeventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this ToolStripItemEventHandler toolstripitemeventhandler, Object sender, ToolStripItemEventArgs e, AsyncCallback callback)
		{
			if(toolstripitemeventhandler == null) throw new ArgumentNullException("toolstripitemeventhandler");

			return toolstripitemeventhandler.BeginInvoke(sender, e, callback, null);
		}

	}
}
