using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace WebGLSupport
{
	// Token: 0x0200002E RID: 46
	[Token(Token = "0x200002E")]
	internal static class WebGLWindowPlugin
	{
		// Token: 0x060001FA RID: 506
		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x56A4", Offset = "0x56A4", VA = "0x56A4")]
		[PreserveSig]
		public static extern void WebGLWindowOnFocus(Action cb);

		// Token: 0x060001FB RID: 507
		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x56A5", Offset = "0x56A5", VA = "0x56A5")]
		[PreserveSig]
		public static extern void WebGLWindowOnBlur(Action cb);

		// Token: 0x060001FC RID: 508
		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x56A6", Offset = "0x56A6", VA = "0x56A6")]
		[PreserveSig]
		public static extern void WebGLWindowInjectFullscreen();
	}
}
