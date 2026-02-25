using System;
using System.Runtime.CompilerServices;
using Core.Dict.DictWrappers.Wrappers;
using Gameplay.Discounts.Model;
using Il2CppDummyDll;
using Protocol.Consts;

namespace Gameplay.Aprs.Discounts
{
	// Token: 0x02000D6B RID: 3435
	[Token(Token = "0x2000D6B")]
	public class AprDiscountArgs : DiscountArgs
	{
		// Token: 0x17001124 RID: 4388
		// (get) Token: 0x06005431 RID: 21553 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001124")]
		public MedalDicWrapper Medal
		{
			[Token(Token = "0x6005431")]
			[Address(RVA = "0xA1E8", Offset = "0xA1E8", VA = "0xA1E8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x06005432 RID: 21554 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005432")]
		[Address(RVA = "0xA1E9", Offset = "0xA1E9", VA = "0xA1E9")]
		public AprDiscountArgs(DiscountTargets discountTarget, MedalDicWrapper medal)
		{
		}
	}
}
