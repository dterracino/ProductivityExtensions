//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;

namespace PRI.ProductivityExtensions.FuncExtensions
{

	/// <summary>
	/// Class that contains extension methods that extend <seealso cref="System.Func<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,TResult>">Func<T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16,TResult></seealso>
	/// </summary>
	public static partial class Funcable
	{
		/// <summary>
		/// Extends BeginInvoke<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> so that when a state object is not needed, null does not need to be passed.
		/// <example>
		/// func.BeginInvoke<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke<T1, T2, T3, T4, TResult>(this Func<T1,T2,T3,T4,TResult> func, T1 arg1, T2 arg2, T3 arg3, T4 arg4, AsyncCallback callback)
		{
			if(func == null) throw new ArgumentNullException("func");

			return func.BeginInvoke(arg1, arg2, arg3, arg4, callback, null);
		}

	}
}
