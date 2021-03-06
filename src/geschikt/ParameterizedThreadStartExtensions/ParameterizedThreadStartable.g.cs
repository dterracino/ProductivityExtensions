//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Threading;

namespace PRI.ProductivityExtensions.ParameterizedThreadStartExtensions
{

	/// <summary>
	/// Class that contains extension methods that extend <seealso cref="System.Threading.ParameterizedThreadStart">ParameterizedThreadStart</seealso>
	/// </summary>
	public static partial class ParameterizedThreadStartable
	{
		/// <summary>
		/// Extends BeginInvoke so that when a state object is not needed, null does not need to be passed.
		/// <example>
		/// parameterizedthreadstart.BeginInvoke(obj, callback);
		/// </example>
		/// </summary>
		public static IAsyncResult BeginInvoke(this ParameterizedThreadStart parameterizedthreadstart, Object obj, AsyncCallback callback)
		{
			if(parameterizedthreadstart == null) throw new ArgumentNullException("parameterizedthreadstart");

			return parameterizedthreadstart.BeginInvoke(obj, callback, null);
		}

	}
}
