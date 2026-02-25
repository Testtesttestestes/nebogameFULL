using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace WebGLSupport
{
	// Token: 0x02000022 RID: 34
	[Token(Token = "0x2000022")]
	internal class WebGLInputMobilePlugin
	{
		// Token: 0x0600017E RID: 382
		[Token(Token = "0x600017E")]
		[Address(RVA = "0x5641", Offset = "0x5641", VA = "0x5641")]
		[PreserveSig]
		public static extern int WebGLInputMobileRegister(Action<int> OnTouchEnd);

		// Token: 0x0600017F RID: 383
		[Token(Token = "0x600017F")]
		[Address(RVA = "0x5642", Offset = "0x5642", VA = "0x5642")]
		[PreserveSig]
		public static extern void WebGLInputMobileOnFocusOut(int id, Action<int> OnFocusOut);

		// Token: 0x06000180 RID: 384 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000180")]
		[Address(RVA = "0x5643", Offset = "0x5643", VA = "0x5643")]
		public WebGLInputMobilePlugin()
		{
		}
	}
}
