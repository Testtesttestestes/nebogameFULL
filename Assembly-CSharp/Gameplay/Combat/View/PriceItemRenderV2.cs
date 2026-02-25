using System;
using System.Runtime.CompilerServices;
using Core.Money;
using Il2CppDummyDll;
using Protocol.Consts;
using UI.Price;

namespace Gameplay.Combat.View
{
	// Token: 0x02000923 RID: 2339
	[Token(Token = "0x2000923")]
	public class PriceItemRenderV2 : PriceItemRenderer
	{
		// Token: 0x17000AE3 RID: 2787
		// (get) Token: 0x06003721 RID: 14113 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003722 RID: 14114 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000AE3")]
		public override Func<Resources, string> GetAssetIdHandler
		{
			[Token(Token = "0x6003721")]
			[Address(RVA = "0x8710", Offset = "0x8710", VA = "0x8710", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003722")]
			[Address(RVA = "0x8711", Offset = "0x8711", VA = "0x8711", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000AE4 RID: 2788
		// (get) Token: 0x06003723 RID: 14115 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003724 RID: 14116 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000AE4")]
		public override Func<Money.MoneyType, string> GetMoneyAssetIdHandler
		{
			[Token(Token = "0x6003723")]
			[Address(RVA = "0x8712", Offset = "0x8712", VA = "0x8712", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003724")]
			[Address(RVA = "0x8713", Offset = "0x8713", VA = "0x8713", Slot = "7")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06003725 RID: 14117 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003725")]
		[Address(RVA = "0x8714", Offset = "0x8714", VA = "0x8714")]
		private static string GetAssetResIcon(Resources resId)
		{
			return null;
		}

		// Token: 0x06003726 RID: 14118 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003726")]
		[Address(RVA = "0x8715", Offset = "0x8715", VA = "0x8715")]
		private static string GetAssetResIcon(Money.MoneyType moneyType)
		{
			return null;
		}

		// Token: 0x06003727 RID: 14119 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003727")]
		[Address(RVA = "0x8716", Offset = "0x8716", VA = "0x8716")]
		public PriceItemRenderV2()
		{
		}
	}
}
