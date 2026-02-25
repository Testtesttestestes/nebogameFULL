using System;
using System.Runtime.CompilerServices;
using AOT;
using Il2CppDummyDll;
using UnityEngine;

namespace WebGLSupport
{
	// Token: 0x0200002F RID: 47
	[Token(Token = "0x200002F")]
	public static class WebGLWindow
	{
		// Token: 0x17000054 RID: 84
		// (get) Token: 0x060001FD RID: 509 RVA: 0x00002820 File Offset: 0x00000A20
		// (set) Token: 0x060001FE RID: 510 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000054")]
		public static bool Focus
		{
			[Token(Token = "0x60001FD")]
			[Address(RVA = "0x56A7", Offset = "0x56A7", VA = "0x56A7")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001FE")]
			[Address(RVA = "0x56A8", Offset = "0x56A8", VA = "0x56A8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x060001FF RID: 511 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000200 RID: 512 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000002")]
		public static event Action OnFocusEvent
		{
			[Token(Token = "0x60001FF")]
			[Address(RVA = "0x56A9", Offset = "0x56A9", VA = "0x56A9")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000200")]
			[Address(RVA = "0x56AA", Offset = "0x56AA", VA = "0x56AA")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x06000201 RID: 513 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000202 RID: 514 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000003")]
		public static event Action OnBlurEvent
		{
			[Token(Token = "0x6000201")]
			[Address(RVA = "0x56AB", Offset = "0x56AB", VA = "0x56AB")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000202")]
			[Address(RVA = "0x56AC", Offset = "0x56AC", VA = "0x56AC")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06000203 RID: 515 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000203")]
		[Address(RVA = "0x56AD", Offset = "0x56AD", VA = "0x56AD")]
		private static void Init()
		{
		}

		// Token: 0x06000204 RID: 516 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000204")]
		[Address(RVA = "0x56AE", Offset = "0x56AE", VA = "0x56AE")]
		[MonoPInvokeCallback(typeof(Action))]
		private static void OnWindowFocus()
		{
		}

		// Token: 0x06000205 RID: 517 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000205")]
		[Address(RVA = "0x56AF", Offset = "0x56AF", VA = "0x56AF")]
		[MonoPInvokeCallback(typeof(Action))]
		private static void OnWindowBlur()
		{
		}

		// Token: 0x06000206 RID: 518 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000206")]
		[Address(RVA = "0x56B0", Offset = "0x56B0", VA = "0x56B0")]
		[RuntimeInitializeOnLoadMethod]
		private static void RuntimeInitializeOnLoadMethod()
		{
		}
	}
}
