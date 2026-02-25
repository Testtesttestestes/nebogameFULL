using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Utils.CoroutineUtils
{
	// Token: 0x0200006A RID: 106
	[Token(Token = "0x200006A")]
	public abstract class MyCustomYieldInstruction : CustomYieldInstruction
	{
		// Token: 0x1700007A RID: 122
		// (get) Token: 0x06000338 RID: 824 RVA: 0x00002CD0 File Offset: 0x00000ED0
		// (set) Token: 0x06000339 RID: 825 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700007A")]
		protected bool complited
		{
			[Token(Token = "0x6000338")]
			[Address(RVA = "0x57A4", Offset = "0x57A4", VA = "0x57A4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000339")]
			[Address(RVA = "0x57A5", Offset = "0x57A5", VA = "0x57A5")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x0600033A RID: 826 RVA: 0x00002CE8 File Offset: 0x00000EE8
		[Token(Token = "0x1700007B")]
		public override bool keepWaiting
		{
			[Token(Token = "0x600033A")]
			[Address(RVA = "0x57A6", Offset = "0x57A6", VA = "0x57A6", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600033B RID: 827 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600033B")]
		[Address(RVA = "0x57A7", Offset = "0x57A7", VA = "0x57A7", Slot = "8")]
		public override void Reset()
		{
		}

		// Token: 0x0600033C RID: 828 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600033C")]
		[Address(RVA = "0x57A8", Offset = "0x57A8", VA = "0x57A8")]
		protected MyCustomYieldInstruction()
		{
		}
	}
}
