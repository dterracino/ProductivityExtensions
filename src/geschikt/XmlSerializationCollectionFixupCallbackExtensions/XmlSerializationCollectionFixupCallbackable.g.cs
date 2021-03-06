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

namespace PRI.ProductivityExtensions.XmlSerializationCollectionFixupCallbackExtensions
{

	/// <summary>
	/// Class that contains extension methods that extend <seealso cref="System.Xml.Serialization.XmlSerializationCollectionFixupCallback">XmlSerializationCollectionFixupCallback</seealso>
	/// </summary>
	public static partial class XmlSerializationCollectionFixupCallbackable
	{
		/// <summary>
		/// Extends BeginInvoke so that when a state object is not needed, null does not need to be passed.
		/// <example>
		/// xmlserializationcollectionfixupcallback.BeginInvoke(collection, collectionItems, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this XmlSerializationCollectionFixupCallback xmlserializationcollectionfixupcallback, Object collection, Object collectionItems, AsyncCallback callback)
		{
			if(xmlserializationcollectionfixupcallback == null) throw new ArgumentNullException("xmlserializationcollectionfixupcallback");

			return xmlserializationcollectionfixupcallback.BeginInvoke(collection, collectionItems, callback, null);
		}

	}
}
