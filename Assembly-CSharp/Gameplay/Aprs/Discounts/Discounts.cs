using System;
using System.Runtime.CompilerServices;
using Core.Cache;
using Core.Dict.DictWrappers.Wrappers;
using Gameplay.Aprs.Model;
using Gameplay.Discounts.Model;
using Il2CppDummyDll;

namespace Gameplay.Aprs.Discounts
{
	// Token: 0x02000D6E RID: 3438
	[Token(Token = "0x2000D6E")]
	public class Discounts : IDiscountHandler, IDisposable
	{
		// Token: 0x17001125 RID: 4389
		// (get) Token: 0x06005438 RID: 21560 RVA: 0x0000F360 File Offset: 0x0000D560
		// (set) Token: 0x06005439 RID: 21561 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001125")]
		public bool IsDisposed
		{
			[Token(Token = "0x6005438")]
			[Address(RVA = "0xA1EF", Offset = "0xA1EF", VA = "0xA1EF")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005439")]
			[Address(RVA = "0xA1F0", Offset = "0xA1F0", VA = "0xA1F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600543A RID: 21562 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600543A")]
		[Address(RVA = "0xA1F1", Offset = "0xA1F1", VA = "0xA1F1", Slot = "5")]
		public void Dispose()
		{
		}

		// Token: 0x0600543B RID: 21563 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600543B")]
		[Address(RVA = "0xA1F2", Offset = "0xA1F2", VA = "0xA1F2")]
		public Discounts(AprsModel model, IDiscountsProvider discountsModel, ICache<MedalDicWrapper, IDiscountArgs> cache)
		{
		}

		// Token: 0x0600543C RID: 21564 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600543C")]
		[Address(RVA = "0xA1F3", Offset = "0xA1F3", VA = "0xA1F3", Slot = "4")]
		public void Handle(IDiscountTarget target)
		{
		}

		// Token: 0x0600543D RID: 21565 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600543D")]
		[Address(RVA = "0xA1F4", Offset = "0xA1F4", VA = "0xA1F4")]
		public void Reset()
		{
		}

		// Token: 0x04002D9E RID: 11678
		[Token(Token = "0x4002D9E")]
		[FieldOffset(Offset = "0x8")]
		private IDiscountsProvider _discountsProvider;

		// Token: 0x04002D9F RID: 11679
		[Token(Token = "0x4002D9F")]
		[FieldOffset(Offset = "0xC")]
		private AprsModel _model;

		// Token: 0x04002DA0 RID: 11680
		[Token(Token = "0x4002DA0")]
		[FieldOffset(Offset = "0x10")]
		private ICache<MedalDicWrapper, IDiscountArgs> _cache;
	}
}
