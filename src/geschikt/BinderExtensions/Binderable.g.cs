//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Reflection;

namespace PRI.ProductivityExtensions.BinderExtensions
{

	/// <summary>
	/// Class that contains extension methods that extend <seealso cref="System.Reflection.Binder">Binder</seealso>
	/// </summary>
	public static partial class Binderable
	{
		/// <summary>
		/// Extends ChangeType so that methods that return a specific type object given a Type parameter can be
		/// used as generic method and casting is not required.
		/// <example>
		/// binder.ChangeType&lt;int&gt;(value, culture);
		/// </example>
		/// </summary>
		public static T ChangeType<T>(this Binder binder, Object value, System.Globalization.CultureInfo culture)
		{
			if(binder == null) throw new ArgumentNullException("binder");

			return (T)binder.ChangeType(value, typeof(T), culture);
		}

	}
}
