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

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: WebGLWindowOnFocus ---
		void WebGLSupport_WebGLWindowPlugin__WebGLWindowOnFocus(undefined4 param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  param1_00 = unnamed_function_1434(param1);
		  import::env::WebGLWindowOnBlur(param1_00);
		  return;
		}
		*/


		/* --- GHIDRA: WebGLWindowOnBlur ---
		void WebGLSupport_WebGLWindowPlugin__WebGLWindowOnBlur(undefined4 param1)
		
		{
		  import::env::WebGLWindowInjectFullscreen();
		  return;
		}
		*/


		/* --- GHIDRA: WebGLWindowInjectFullscreen ---
		uint WebGLSupport_WebGLWindowPlugin__WebGLWindowInjectFullscreen(undefined4 param1)
		
		{
		  if (DAT_ram_00a648ca == '\0') {
		    Mono_Security_ASN1__get_Item(&WebGLSupport_WebGLWindow_TypeInfo);
		    DAT_ram_00a648ca = '\x01';
		  }
		  if (*(int *)(WebGLSupport_WebGLWindow_TypeInfo + 0x74) == 0) {
		    func_ii_306000(WebGLSupport_WebGLWindow_TypeInfo);
		  }
		  return (uint)**(byte **)(WebGLSupport_WebGLWindow_TypeInfo + 0x5c);
		}
		*/

}
