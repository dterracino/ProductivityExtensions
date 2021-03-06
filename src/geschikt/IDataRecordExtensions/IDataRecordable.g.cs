//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data;

namespace PRI.ProductivityExtensions.IDataRecordExtensions
{

	/// <summary>
	/// Class that contains extension methods that extend <seealso cref="System.Data.IDataRecord">IDataRecord</seealso>
	/// </summary>
	public static partial class IDataRecordable
	{
		/// <summary>
		/// Extends GetBytes so that buffer offset of 0 and call to Array.Length are not needed.
		/// <example>
		/// idatarecord.GetBytes(i, fieldOffset, buffer);
		/// </example>
		/// </summary>
		public static Int64 GetBytes(this IDataRecord idatarecord, Int32 i, Int64 fieldOffset, Byte[] buffer)
		{
			if(idatarecord == null) throw new ArgumentNullException("idatarecord");

			if(buffer == null) throw new ArgumentNullException("buffer");

			return idatarecord.GetBytes(i, fieldOffset, buffer, 0, buffer.Length);
		}

		/// <summary>
		/// Extends GetChars so that buffer offset of 0 and call to Array.Length are not needed.
		/// <example>
		/// idatarecord.GetChars(i, fieldoffset, buffer);
		/// </example>
		/// </summary>
		public static Int64 GetChars(this IDataRecord idatarecord, Int32 i, Int64 fieldoffset, Char[] buffer)
		{
			if(idatarecord == null) throw new ArgumentNullException("idatarecord");

			if(buffer == null) throw new ArgumentNullException("buffer");

			return idatarecord.GetChars(i, fieldoffset, buffer, 0, buffer.Length);
		}

	}
}
