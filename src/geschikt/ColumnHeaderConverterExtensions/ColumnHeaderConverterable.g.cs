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

namespace PRI.ProductivityExtensions.ColumnHeaderConverterExtensions
{

	/// <summary>
	/// Class that contains extension methods that extend <seealso cref="System.Windows.Forms.ColumnHeaderConverter">ColumnHeaderConverter</seealso>
	/// </summary>
	public static partial class ColumnHeaderConverterable
	{
		/// <summary>
		/// Extends ConvertTo so that methods that return a specific type object given a Type parameter can be
		/// used as generic method and casting is not required.
		/// <example>
		/// typeconverter.ConvertTo&lt;int&gt;(value);
		/// </example>
		/// </summary>
		public static T ConvertTo<T>(this ColumnHeaderConverter typeconverter, Object value)
		{
			if(typeconverter == null) throw new ArgumentNullException("typeconverter");

			return (T)typeconverter.ConvertTo(value, typeof(T));
		}

		/// <summary>
		/// Extends ConvertTo so that methods that return a specific type object given a Type parameter can be
		/// used as generic method and casting is not required.
		/// <example>
		/// columnheaderconverter.ConvertTo&lt;int&gt;(context, culture, value);
		/// </example>
		/// </summary>
		public static T ConvertTo<T>(this ColumnHeaderConverter columnheaderconverter, System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, Object value)
		{
			if(columnheaderconverter == null) throw new ArgumentNullException("columnheaderconverter");

			return (T)columnheaderconverter.ConvertTo(context, culture, value, typeof(T));
		}

	}
}
