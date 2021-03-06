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

namespace PRI.ProductivityExtensions.TypeValidationEventHandlerExtensions
{

	/// <summary>
	/// Class that contains extension methods that extend <seealso cref="System.Windows.Forms.TypeValidationEventHandler">TypeValidationEventHandler</seealso>
	/// </summary>
	public static partial class TypeValidationEventHandlerable
	{
		/// <summary>
		/// Extends BeginInvoke so that when a state object is not needed, null does not need to be passed.
		/// <example>
		/// typevalidationeventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this TypeValidationEventHandler typevalidationeventhandler, Object sender, TypeValidationEventArgs e, AsyncCallback callback)
		{
			if(typevalidationeventhandler == null) throw new ArgumentNullException("typevalidationeventhandler");

			return typevalidationeventhandler.BeginInvoke(sender, e, callback, null);
		}

	}
}
