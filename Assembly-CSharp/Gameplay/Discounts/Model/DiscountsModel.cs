using System;
using System.Collections.Generic;
using Core.Data;
using Core.Gameplay.Managers;
using Il2CppDummyDll;
using MVC;
using Protocol.Consts;
using Protocol.Services;

namespace Gameplay.Discounts.Model
{
	// Token: 0x0200089A RID: 2202
	[Token(Token = "0x200089A")]
	public class DiscountsModel : AbstractModel, IDiscountsProvider
	{
		// Token: 0x060033DC RID: 13276 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033DC")]
		[Address(RVA = "0x8414", Offset = "0x8414", VA = "0x8414")]
		public DiscountsModel(UserData user)
		{
		}

		// Token: 0x060033DD RID: 13277 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033DD")]
		[Address(RVA = "0x8415", Offset = "0x8415", VA = "0x8415")]
		public void PopulateDiscounts(IList<ProtoGetDiscountsAns.Types.DiscountInfo> discounts)
		{
		}

		// Token: 0x060033DE RID: 13278 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033DE")]
		[Address(RVA = "0x8416", Offset = "0x8416", VA = "0x8416")]
		public void RepopulateServerParams()
		{
		}

		// Token: 0x060033DF RID: 13279 RVA: 0x0000A908 File Offset: 0x00008B08
		[Token(Token = "0x60033DF")]
		[Address(RVA = "0x8417", Offset = "0x8417", VA = "0x8417", Slot = "6")]
		private bool TryGetDiscount(DiscountTargets type, out DiscountData data)
		{
			return default(bool);
		}

		// Token: 0x060033E0 RID: 13280 RVA: 0x0000A920 File Offset: 0x00008B20
		[Token(Token = "0x60033E0")]
		[Address(RVA = "0x8418", Offset = "0x8418", VA = "0x8418", Slot = "7")]
		private bool TryGetDiscountCoeff(DiscountTargets target, out double discountCoeff)
		{
			return default(bool);
		}

		// Token: 0x04001C41 RID: 7233
		[Token(Token = "0x4001C41")]
		[FieldOffset(Offset = "0xC")]
		public readonly DictManager DictManager;

		// Token: 0x04001C42 RID: 7234
		[Token(Token = "0x4001C42")]
		[FieldOffset(Offset = "0x10")]
		public DiscountData[] Discounts;

		// Token: 0x04001C43 RID: 7235
		[Token(Token = "0x4001C43")]
		[FieldOffset(Offset = "0x14")]
		private readonly Dictionary<DiscountTargets, double> _discountsParams;
	}
}
