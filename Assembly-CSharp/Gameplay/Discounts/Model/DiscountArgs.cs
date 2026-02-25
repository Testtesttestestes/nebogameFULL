using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Il2CppDummyDll;
using Protocol.Common;
using Protocol.Consts;

namespace Gameplay.Discounts.Model
{
	// Token: 0x02000899 RID: 2201
	[Token(Token = "0x2000899")]
	public class DiscountArgs : IDiscountArgs, IManageDiscountArgs
	{
		// Token: 0x060033D6 RID: 13270 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033D6")]
		[Address(RVA = "0x840E", Offset = "0x840E", VA = "0x840E")]
		public DiscountArgs(DiscountTargets discountTarget)
		{
		}

		// Token: 0x17000A44 RID: 2628
		// (get) Token: 0x060033D7 RID: 13271 RVA: 0x0000A8F0 File Offset: 0x00008AF0
		[Token(Token = "0x17000A44")]
		public DiscountTargets DiscountTarget
		{
			[Token(Token = "0x60033D7")]
			[Address(RVA = "0x840F", Offset = "0x840F", VA = "0x840F", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return DiscountTargets.UnknownDiscountTarget;
			}
		}

		// Token: 0x17000A45 RID: 2629
		// (get) Token: 0x060033D8 RID: 13272 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060033D9 RID: 13273 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A45")]
		public ResourceSet Value
		{
			[Token(Token = "0x60033D8")]
			[Address(RVA = "0x8410", Offset = "0x8410", VA = "0x8410", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60033D9")]
			[Address(RVA = "0x8411", Offset = "0x8411", VA = "0x8411")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000A46 RID: 2630
		// (get) Token: 0x060033DA RID: 13274 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060033DB RID: 13275 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A46")]
		public DiscountData Data
		{
			[Token(Token = "0x60033DA")]
			[Address(RVA = "0x8412", Offset = "0x8412", VA = "0x8412", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60033DB")]
			[Address(RVA = "0x8413", Offset = "0x8413", VA = "0x8413", Slot = "7")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
