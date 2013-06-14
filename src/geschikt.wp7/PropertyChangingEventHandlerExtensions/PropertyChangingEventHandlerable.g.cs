//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;

namespace PRI.ProductivityExtensions.PropertyChangingEventHandlerExtensions
{

	/// <summary>
	/// Class that contains extension methods that extend <seealso cref="System.ComponentModel.PropertyChangingEventHandler">PropertyChangingEventHandler</seealso>
	/// </summary>
	public static partial class PropertyChangingEventHandlerable
	{
		/// <summary>
		/// Extends BeginInvoke so that when a state object is not needed, null does not need to be passed.
		/// <example>
		/// propertychangingeventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this PropertyChangingEventHandler propertychangingeventhandler, Object sender, PropertyChangingEventArgs e, AsyncCallback callback)
		{
			if(propertychangingeventhandler == null) throw new ArgumentNullException("propertychangingeventhandler");

			return propertychangingeventhandler.BeginInvoke(sender, e, callback, null);
		}

	}
}
