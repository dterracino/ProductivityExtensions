//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Drawing;

namespace PRI.ProductivityExtensions.SizeFConverterExtensions
{

	/// <summary>
	/// Class that contains extension methods that extend <seealso cref="System.Drawing.SizeFConverter">SizeFConverter</seealso>
	/// </summary>
	public static partial class SizeFConverterable
	{
		/// <summary>
		/// Extends ConvertTo so that methods that return a specific type object given a Type parameter can be
		/// used as generic method and casting is not required.
		/// <example>
		/// typeconverter.ConvertTo<int>(value);
		/// </example>
		/// </summary>
		public static T ConvertTo<T>(this SizeFConverter typeconverter, Object value)
		{
			if(typeconverter == null) throw new ArgumentNullException("typeconverter");

			return (T)typeconverter.ConvertTo(value, typeof(T));
		}

		/// <summary>
		/// Extends ConvertTo so that methods that return a specific type object given a Type parameter can be
		/// used as generic method and casting is not required.
		/// <example>
		/// sizefconverter.ConvertTo<int>(context, culture, value);
		/// </example>
		/// </summary>
		public static T ConvertTo<T>(this SizeFConverter sizefconverter, System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, Object value)
		{
			if(sizefconverter == null) throw new ArgumentNullException("sizefconverter");

			return (T)sizefconverter.ConvertTo(context, culture, value, typeof(T));
		}

	}
}
