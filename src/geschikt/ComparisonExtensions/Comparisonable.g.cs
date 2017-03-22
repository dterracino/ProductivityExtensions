//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;

namespace PRI.ProductivityExtensions.ComparisonExtensions
{

	/// <summary>
	/// Class that contains extension methods that extend <seealso cref="System.Comparison&lt;T&gt;">Comparison&lt;T&gt;</seealso>
	/// </summary>
	public static partial class Comparisonable
	{
		/// <summary>
		/// Extends BeginInvoke&lt;T&gt; so that when a state object is not needed, null does not need to be passed.
		/// <example>
		/// comparison.BeginInvoke&lt;T&gt;(x, y, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke<T>(this Comparison<T> comparison, T x, T y, AsyncCallback callback)
		{
			if(comparison == null) throw new ArgumentNullException("comparison");

			return comparison.BeginInvoke(x, y, callback, null);
		}

	}
}
