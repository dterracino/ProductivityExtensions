//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Xml.Serialization;

namespace PRI.ProductivityExtensions.XmlSerializationReadCallbackExtensions
{

	/// <summary>
	/// Class that contains extension methods that extend <seealso cref="System.Xml.Serialization.XmlSerializationReadCallback">XmlSerializationReadCallback</seealso>
	/// </summary>
	public static partial class XmlSerializationReadCallbackable
	{
		/// <summary>
		/// Extends BeginInvoke so that when a state object is not needed, null does not need to be passed.
		/// <example>
		/// xmlserializationreadcallback.BeginInvoke(callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this XmlSerializationReadCallback xmlserializationreadcallback, AsyncCallback callback)
		{
			if(xmlserializationreadcallback == null) throw new ArgumentNullException("xmlserializationreadcallback");

			return xmlserializationreadcallback.BeginInvoke(callback, null);
		}

	}
}
