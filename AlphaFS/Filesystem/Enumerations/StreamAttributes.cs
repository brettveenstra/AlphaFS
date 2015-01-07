/* Copyright (C) 2008-2015 Peter Palotas, Jeffrey Jangli, Alexandr Normuradov
 *  
 *  Permission is hereby granted, free of charge, to any person obtaining a copy 
 *  of this software and associated documentation files (the "Software"), to deal 
 *  in the Software without restriction, including without limitation the rights 
 *  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell 
 *  copies of the Software, and to permit persons to whom the Software is 
 *  furnished to do so, subject to the following conditions:
 *  
 *  The above copyright notice and this permission notice shall be included in 
 *  all copies or substantial portions of the Software.
 *  
 *  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR 
 *  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, 
 *  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE 
 *  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER 
 *  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, 
 *  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN 
 *  THE SOFTWARE. 
 */

using System;

namespace Alphaleonis.Win32.Filesystem
{
   /// <summary>WIN32_STREAM_ID Attributes of data to facilitate cross-operating system transfer.</summary>
   [Flags]
   public enum StreamAttributes
   {
      /// <summary>(0) STREAM_NORMAL_ATTRIBUTE - This backup stream has no special attributes.</summary>
      None = 0,

      /// <summary>(1) STREAM_MODIFIED_WHEN_READ - Attribute set if the stream contains data that is modified when read.
      /// <para>Allows the backup application to know that verification of data will fail.</para>
      /// </summary>
      ModifiedWhenRead = 1,

      /// <summary>(2) STREAM_CONTAINS_SECURITY - The backup stream contains security information.
      /// <para>This attribute applies only to backup stream of type <see cref="StreamType.SecurityData"/>.</para>
      /// </summary>
      ContainsSecurity = 2,

      /// <summary>(4) Reserved.</summary>
      ContainsProperties = 4,

      /// <summary>(8) STREAM_SPARSE_ATTRIBUTE - The backup stream is part of a sparse file stream.
      /// <para>This attribute applies only to backup stream of type <see cref="StreamType.Data"/>, <see cref="StreamType.AlternateData"/>, and <see cref="StreamType.SparseBlock"/>.</para>
      /// </summary>
      Sparse = 8
   }
}