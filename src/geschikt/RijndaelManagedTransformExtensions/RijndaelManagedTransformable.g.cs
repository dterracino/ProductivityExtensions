//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Security.Cryptography;

namespace PRI.ProductivityExtensions.RijndaelManagedTransformExtensions
{

	/// <summary>
	/// Class that contains extension methods that extend <seealso cref="System.Security.Cryptography.RijndaelManagedTransform">RijndaelManagedTransform</seealso>
	/// </summary>
	public static partial class RijndaelManagedTransformable
	{
		/// <summary>
		/// Extends TransformBlock so that buffer offset of 0 and call to Array.Length are not needed.
		/// <example>
		/// rijndaelmanagedtransform.TransformBlock(inputBuffer, outputBuffer, outputOffset);
		/// </example>
		/// </summary>
		public static Int32 TransformBlock(this RijndaelManagedTransform rijndaelmanagedtransform, Byte[] inputBuffer, Byte[] outputBuffer, Int32 outputOffset)
		{
			if(rijndaelmanagedtransform == null) throw new ArgumentNullException("rijndaelmanagedtransform");

			if(inputBuffer == null) throw new ArgumentNullException("inputBuffer");

			return rijndaelmanagedtransform.TransformBlock(inputBuffer, 0, inputBuffer.Length, outputBuffer, outputOffset);
		}

		/// <summary>
		/// Extends TransformFinalBlock so that buffer offset of 0 and call to Array.Length are not needed.
		/// <example>
		/// rijndaelmanagedtransform.TransformFinalBlock(inputBuffer);
		/// </example>
		/// </summary>
		public static Byte[] TransformFinalBlock(this RijndaelManagedTransform rijndaelmanagedtransform, Byte[] inputBuffer)
		{
			if(rijndaelmanagedtransform == null) throw new ArgumentNullException("rijndaelmanagedtransform");

			if(inputBuffer == null) throw new ArgumentNullException("inputBuffer");

			return rijndaelmanagedtransform.TransformFinalBlock(inputBuffer, 0, inputBuffer.Length);
		}

	}
}
