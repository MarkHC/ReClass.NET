﻿using System;
using System.Text;
using ReClassNET.UI;

namespace ReClassNET.Nodes
{
	public class UTF8TextPtrNode : BaseTextPtrNode
	{
		/// <summary>Draws this node.</summary>
		/// <param name="view">The view information.</param>
		/// <param name="x">The x coordinate.</param>
		/// <param name="y">The y coordinate.</param>
		/// <returns>The height the node occupies.</returns>
		public override int Draw(ViewInfo view, int x, int y)
		{
			var ptr = view.Memory.ReadObject<IntPtr>(Offset);
			var str = view.Memory.Process.ReadRemoteString(Encoding.UTF8, ptr, 64);

			return DrawText(view, x, y, "Text8Ptr", MemorySize, str);
		}
	}
}
