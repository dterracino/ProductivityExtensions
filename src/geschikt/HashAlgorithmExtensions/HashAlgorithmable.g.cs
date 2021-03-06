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

namespace PRI.ProductivityExtensions.HashAlgorithmExtensions
{

	/// <summary>
	/// Class that contains extension methods that extend <seealso cref="System.Security.Cryptography.HashAlgorithm">HashAlgorithm</seealso>
	/// </summary>
	public static partial class HashAlgorithmable
	{
		/// <summary>
		/// Extends TransformBlock so that buffer offset of 0 and call to Array.Length are not needed.
		/// <example>
		/// hashalgorithm.TransformBlock(inputBuffer, outputBuffer, outputOffset);
		/// </example>
		/// </summary>
		public static Int32 TransformBlock(this HashAlgorithm hashalgorithm, Byte[] inputBuffer, Byte[] outputBuffer, Int32 outputOffset)
		{
			if(hashalgorithm == null) throw new ArgumentNullException("hashalgorithm");

			if(inputBuffer == null) throw new ArgumentNullException("inputBuffer");

			return hashalgorithm.TransformBlock(inputBuffer, 0, inputBuffer.Length, outputBuffer, outputOffset);
		}

		/// <summary>
		/// Extends TransformFinalBlock so that buffer offset of 0 and call to Array.Length are not needed.
		/// <example>
		/// hashalgorithm.TransformFinalBlock(inputBuffer);
		/// </example>
		/// </summary>
		public static Byte[] TransformFinalBlock(this HashAlgorithm hashalgorithm, Byte[] inputBuffer)
		{
			if(hashalgorithm == null) throw new ArgumentNullException("hashalgorithm");

			if(inputBuffer == null) throw new ArgumentNullException("inputBuffer");

			return hashalgorithm.TransformFinalBlock(inputBuffer, 0, inputBuffer.Length);
		}

	}
}
