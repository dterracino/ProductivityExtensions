//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Xml;

namespace PRI.ProductivityExtensions.XmlNodeChangedEventHandlerExtensions
{

	/// <summary>
	/// Class that contains extension methods that extend <seealso cref="System.Xml.XmlNodeChangedEventHandler">XmlNodeChangedEventHandler</seealso>
	/// </summary>
	public static partial class XmlNodeChangedEventHandlerable
	{
		/// <summary>
		/// Extends BeginInvoke so that when a state object is not needed, null does not need to be passed.
		/// <example>
		/// xmlnodechangedeventhandler.BeginInvoke(sender, e, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this XmlNodeChangedEventHandler xmlnodechangedeventhandler, Object sender, XmlNodeChangedEventArgs e, AsyncCallback callback)
		{
			if(xmlnodechangedeventhandler == null) throw new ArgumentNullException("xmlnodechangedeventhandler");

			return xmlnodechangedeventhandler.BeginInvoke(sender, e, callback, null);
		}

	}
}
