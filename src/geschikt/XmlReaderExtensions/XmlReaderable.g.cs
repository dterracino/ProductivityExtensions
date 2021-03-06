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

namespace PRI.ProductivityExtensions.XmlReaderExtensions
{

	/// <summary>
	/// Class that contains extension methods that extend <seealso cref="System.Xml.XmlReader">XmlReader</seealso>
	/// </summary>
	public static partial class XmlReaderable
	{
		/// <summary>
		/// Extends ReadContentAs so that methods that return a specific type object given a Type parameter can be
		/// used as generic method and casting is not required.
		/// <example>
		/// xmlreader.ReadContentAs<int>(namespaceResolver);
		/// </example>
		/// </summary>
		public static T ReadContentAs<T>(this XmlReader xmlreader, IXmlNamespaceResolver namespaceResolver)
		{
			if(xmlreader == null) throw new ArgumentNullException("xmlreader");

			return (T)xmlreader.ReadContentAs(typeof(T), namespaceResolver);
		}

		/// <summary>
		/// Extends ReadElementContentAs so that methods that return a specific type object given a Type parameter can be
		/// used as generic method and casting is not required.
		/// <example>
		/// xmlreader.ReadElementContentAs<int>(namespaceResolver);
		/// </example>
		/// </summary>
		public static T ReadElementContentAs<T>(this XmlReader xmlreader, IXmlNamespaceResolver namespaceResolver)
		{
			if(xmlreader == null) throw new ArgumentNullException("xmlreader");

			return (T)xmlreader.ReadElementContentAs(typeof(T), namespaceResolver);
		}

		/// <summary>
		/// Extends ReadElementContentAs so that methods that return a specific type object given a Type parameter can be
		/// used as generic method and casting is not required.
		/// <example>
		/// xmlreader.ReadElementContentAs<int>(namespaceResolver, localName, namespaceURI);
		/// </example>
		/// </summary>
		public static T ReadElementContentAs<T>(this XmlReader xmlreader, IXmlNamespaceResolver namespaceResolver, String localName, String namespaceURI)
		{
			if(xmlreader == null) throw new ArgumentNullException("xmlreader");

			return (T)xmlreader.ReadElementContentAs(typeof(T), namespaceResolver, localName, namespaceURI);
		}

		/// <summary>
		/// Extends ReadContentAsBase64 so that buffer offset of 0 and call to Array.Length are not needed.
		/// <example>
		/// xmlreader.ReadContentAsBase64(buffer);
		/// </example>
		/// </summary>
		public static Int32 ReadContentAsBase64(this XmlReader xmlreader, Byte[] buffer)
		{
			if(xmlreader == null) throw new ArgumentNullException("xmlreader");

			if(buffer == null) throw new ArgumentNullException("buffer");

			return xmlreader.ReadContentAsBase64(buffer, 0, buffer.Length);
		}

		/// <summary>
		/// Extends ReadElementContentAsBase64 so that buffer offset of 0 and call to Array.Length are not needed.
		/// <example>
		/// xmlreader.ReadElementContentAsBase64(buffer);
		/// </example>
		/// </summary>
		public static Int32 ReadElementContentAsBase64(this XmlReader xmlreader, Byte[] buffer)
		{
			if(xmlreader == null) throw new ArgumentNullException("xmlreader");

			if(buffer == null) throw new ArgumentNullException("buffer");

			return xmlreader.ReadElementContentAsBase64(buffer, 0, buffer.Length);
		}

		/// <summary>
		/// Extends ReadContentAsBinHex so that buffer offset of 0 and call to Array.Length are not needed.
		/// <example>
		/// xmlreader.ReadContentAsBinHex(buffer);
		/// </example>
		/// </summary>
		public static Int32 ReadContentAsBinHex(this XmlReader xmlreader, Byte[] buffer)
		{
			if(xmlreader == null) throw new ArgumentNullException("xmlreader");

			if(buffer == null) throw new ArgumentNullException("buffer");

			return xmlreader.ReadContentAsBinHex(buffer, 0, buffer.Length);
		}

		/// <summary>
		/// Extends ReadElementContentAsBinHex so that buffer offset of 0 and call to Array.Length are not needed.
		/// <example>
		/// xmlreader.ReadElementContentAsBinHex(buffer);
		/// </example>
		/// </summary>
		public static Int32 ReadElementContentAsBinHex(this XmlReader xmlreader, Byte[] buffer)
		{
			if(xmlreader == null) throw new ArgumentNullException("xmlreader");

			if(buffer == null) throw new ArgumentNullException("buffer");

			return xmlreader.ReadElementContentAsBinHex(buffer, 0, buffer.Length);
		}

		/// <summary>
		/// Extends ReadValueChunk so that buffer offset of 0 and call to Array.Length are not needed.
		/// <example>
		/// xmlreader.ReadValueChunk(buffer);
		/// </example>
		/// </summary>
		public static Int32 ReadValueChunk(this XmlReader xmlreader, Char[] buffer)
		{
			if(xmlreader == null) throw new ArgumentNullException("xmlreader");

			if(buffer == null) throw new ArgumentNullException("buffer");

			return xmlreader.ReadValueChunk(buffer, 0, buffer.Length);
		}

	}
}
