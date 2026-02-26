using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace WebGLSupport
{
	// Token: 0x02000025 RID: 37
	[Token(Token = "0x2000025")]
	internal class WebGLInputPlugin
	{
		// Token: 0x0600018E RID: 398
		[Token(Token = "0x600018E")]
		[Address(RVA = "0x564F", Offset = "0x564F", VA = "0x564F")]
		[PreserveSig]
		public static extern int WebGLInputCreate(string canvasId, int x, int y, int width, int height, int fontsize, string text, string placeholder, bool isMultiLine, bool isPassword, bool isHidden);

		// Token: 0x0600018F RID: 399
		[Token(Token = "0x600018F")]
		[Address(RVA = "0x5650", Offset = "0x5650", VA = "0x5650")]
		[PreserveSig]
		public static extern void WebGLInputEnterSubmit(int id, bool flag);

		// Token: 0x06000190 RID: 400
		[Token(Token = "0x6000190")]
		[Address(RVA = "0x5651", Offset = "0x5651", VA = "0x5651")]
		[PreserveSig]
		public static extern void WebGLInputTab(int id, Action<int, int> cb);

		// Token: 0x06000191 RID: 401
		[Token(Token = "0x6000191")]
		[Address(RVA = "0x5652", Offset = "0x5652", VA = "0x5652")]
		[PreserveSig]
		public static extern void WebGLInputFocus(int id);

		// Token: 0x06000192 RID: 402
		[Token(Token = "0x6000192")]
		[Address(RVA = "0x5653", Offset = "0x5653", VA = "0x5653")]
		[PreserveSig]
		public static extern void WebGLInputOnFocus(int id, Action<int> cb);

		// Token: 0x06000193 RID: 403
		[Token(Token = "0x6000193")]
		[Address(RVA = "0x5654", Offset = "0x5654", VA = "0x5654")]
		[PreserveSig]
		public static extern void WebGLInputOnBlur(int id, Action<int> cb);

		// Token: 0x06000194 RID: 404
		[Token(Token = "0x6000194")]
		[Address(RVA = "0x5655", Offset = "0x5655", VA = "0x5655")]
		[PreserveSig]
		public static extern void WebGLInputOnValueChange(int id, Action<int, string> cb);

		// Token: 0x06000195 RID: 405
		[Token(Token = "0x6000195")]
		[Address(RVA = "0x5656", Offset = "0x5656", VA = "0x5656")]
		[PreserveSig]
		public static extern void WebGLInputOnEditEnd(int id, Action<int, string> cb);

		// Token: 0x06000196 RID: 406
		[Token(Token = "0x6000196")]
		[Address(RVA = "0x5657", Offset = "0x5657", VA = "0x5657")]
		[PreserveSig]
		public static extern int WebGLInputSelectionStart(int id);

		// Token: 0x06000197 RID: 407
		[Token(Token = "0x6000197")]
		[Address(RVA = "0x5658", Offset = "0x5658", VA = "0x5658")]
		[PreserveSig]
		public static extern int WebGLInputSelectionEnd(int id);

		// Token: 0x06000198 RID: 408
		[Token(Token = "0x6000198")]
		[Address(RVA = "0x5659", Offset = "0x5659", VA = "0x5659")]
		[PreserveSig]
		public static extern int WebGLInputSelectionDirection(int id);

		// Token: 0x06000199 RID: 409
		[Token(Token = "0x6000199")]
		[Address(RVA = "0x565A", Offset = "0x565A", VA = "0x565A")]
		[PreserveSig]
		public static extern void WebGLInputSetSelectionRange(int id, int start, int end);

		// Token: 0x0600019A RID: 410
		[Token(Token = "0x600019A")]
		[Address(RVA = "0x565B", Offset = "0x565B", VA = "0x565B")]
		[PreserveSig]
		public static extern void WebGLInputMaxLength(int id, int maxlength);

		// Token: 0x0600019B RID: 411
		[Token(Token = "0x600019B")]
		[Address(RVA = "0x565C", Offset = "0x565C", VA = "0x565C")]
		[PreserveSig]
		public static extern void WebGLInputText(int id, string text);

		// Token: 0x0600019C RID: 412
		[Token(Token = "0x600019C")]
		[Address(RVA = "0x565D", Offset = "0x565D", VA = "0x565D")]
		[PreserveSig]
		public static extern bool WebGLInputIsFocus(int id);

		// Token: 0x0600019D RID: 413
		[Token(Token = "0x600019D")]
		[Address(RVA = "0x565E", Offset = "0x565E", VA = "0x565E")]
		[PreserveSig]
		public static extern void WebGLInputDelete(int id);

		// Token: 0x0600019E RID: 414 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600019E")]
		[Address(RVA = "0x565F", Offset = "0x565F", VA = "0x565F")]
		public WebGLInputPlugin()
		{
		/* --- GHIDRA: .ctor ---
		undefined4 WebGLSupport_WebGLInputPlugin___ctor(undefined4 param1)
		
		{
		  if (DAT_ram_00a648ad == '\0') {
		    Mono_Security_ASN1__get_Item(&WebGLSupport_WebGLInput_TypeInfo);
		    DAT_ram_00a648ad = '\x01';
		  }
		  if (*(int *)(WebGLSupport_WebGLInput_TypeInfo + 0x74) == 0) {
		    func_ii_306000(WebGLSupport_WebGLInput_TypeInfo);
		  }
		  return *(undefined4 *)(*(int *)(WebGLSupport_WebGLInput_TypeInfo + 0x5c) + 4);
		}
		*/

		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: WebGLInputCreate ---
		void WebGLSupport_WebGLInputPlugin__WebGLInputCreate
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  import::env::WebGLInputEnterSubmit(param1,param2);
		  return;
		}
		*/


		/* --- GHIDRA: WebGLInputEnterSubmit ---
		void WebGLSupport_WebGLInputPlugin__WebGLInputEnterSubmit
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param2_00;
		  
		  param2_00 = unnamed_function_1434(param2);
		  import::env::WebGLInputTab(param1,param2_00);
		  return;
		}
		*/


		/* --- GHIDRA: WebGLInputTab ---
		void WebGLSupport_WebGLInputPlugin__WebGLInputTab(undefined4 param1,undefined4 param2)
		
		{
		  import::env::WebGLInputFocus(param1);
		  return;
		}
		*/


		/* --- GHIDRA: WebGLInputFocus ---
		void WebGLSupport_WebGLInputPlugin__WebGLInputFocus
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param2_00;
		  
		  param2_00 = unnamed_function_1434(param2);
		  import::env::WebGLInputOnFocus(param1,param2_00);
		  return;
		}
		*/


		/* --- GHIDRA: WebGLInputOnFocus ---
		void WebGLSupport_WebGLInputPlugin__WebGLInputOnFocus
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param2_00;
		  
		  param2_00 = unnamed_function_1434(param2);
		  import::env::WebGLInputOnBlur(param1,param2_00);
		  return;
		}
		*/


		/* --- GHIDRA: WebGLInputOnBlur ---
		void WebGLSupport_WebGLInputPlugin__WebGLInputOnBlur
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param2_00;
		  
		  param2_00 = unnamed_function_1434(param2);
		  import::env::WebGLInputOnValueChange(param1,param2_00);
		  return;
		}
		*/


		/* --- GHIDRA: WebGLInputOnValueChange ---
		void WebGLSupport_WebGLInputPlugin__WebGLInputOnValueChange
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param2_00;
		  
		  param2_00 = unnamed_function_1434(param2);
		  import::env::WebGLInputOnEditEnd(param1,param2_00);
		  return;
		}
		*/


		/* --- GHIDRA: WebGLInputOnEditEnd ---
		undefined4 WebGLSupport_WebGLInputPlugin__WebGLInputOnEditEnd(undefined4 param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = import::env::WebGLInputSelectionStart(param1);
		  return uVar1;
		}
		*/


		/* --- GHIDRA: WebGLInputSelectionStart ---
		undefined4
		WebGLSupport_WebGLInputPlugin__WebGLInputSelectionStart(undefined4 param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = import::env::WebGLInputSelectionEnd(param1);
		  return uVar1;
		}
		*/


		/* --- GHIDRA: WebGLInputSelectionEnd ---
		undefined4
		WebGLSupport_WebGLInputPlugin__WebGLInputSelectionEnd(undefined4 param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = import::env::WebGLInputSelectionDirection(param1);
		  return uVar1;
		}
		*/


		/* --- GHIDRA: WebGLInputSelectionDirection ---
		void WebGLSupport_WebGLInputPlugin__WebGLInputSelectionDirection
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  import::env::WebGLInputSetSelectionRange(param1,param2,param3);
		  return;
		}
		*/


		/* --- GHIDRA: WebGLInputSetSelectionRange ---
		void WebGLSupport_WebGLInputPlugin__WebGLInputSetSelectionRange
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  import::env::WebGLInputMaxLength(param1,param2);
		  return;
		}
		*/


		/* --- GHIDRA: WebGLInputMaxLength ---
		void WebGLSupport_WebGLInputPlugin__WebGLInputMaxLength
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param2_00;
		  
		  param2_00 = unnamed_function_1428(param2);
		  import::env::WebGLInputText(param1,param2_00);
		  unnamed_function_1427(param2_00);
		  return;
		}
		*/


		/* --- GHIDRA: WebGLInputText ---
		uint WebGLSupport_WebGLInputPlugin__WebGLInputText(undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = import::env::WebGLInputIsFocus(param1);
		  return (uint)(iVar1 != 0);
		}
		*/


		/* --- GHIDRA: WebGLInputIsFocus ---
		void WebGLSupport_WebGLInputPlugin__WebGLInputIsFocus(undefined4 param1,undefined4 param2)
		
		{
		  import::env::WebGLInputDelete(param1);
		  return;
		}
		*/

}
