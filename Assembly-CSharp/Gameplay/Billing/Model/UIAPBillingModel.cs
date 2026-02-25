using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Dict;
using Core.Gameplay;
using Gameplay.Bank.Model;
using Gameplay.Billing.BillingProvider;
using Gameplay.Billing.Model.PurchasePayload;
using Il2CppDummyDll;
using UnityEngine.Purchasing;

namespace Gameplay.Billing.Model
{
	// Token: 0x02000BEB RID: 3051
	[Token(Token = "0x2000BEB")]
	public class UIAPBillingModel : BillingModelForAppMarketWhitProducts
	{
		// Token: 0x17000F24 RID: 3876
		// (get) Token: 0x06004AE6 RID: 19174 RVA: 0x0000DD28 File Offset: 0x0000BF28
		[Token(Token = "0x17000F24")]
		public override bool IsPurchasesAvailable
		{
			[Token(Token = "0x6004AE6")]
			[Address(RVA = "0x9943", Offset = "0x9943", VA = "0x9943", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000F25 RID: 3877
		// (get) Token: 0x06004AE7 RID: 19175 RVA: 0x0000DD40 File Offset: 0x0000BF40
		[Token(Token = "0x17000F25")]
		public override bool IsBalanceSupported
		{
			[Token(Token = "0x6004AE7")]
			[Address(RVA = "0x9944", Offset = "0x9944", VA = "0x9944", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000F26 RID: 3878
		// (get) Token: 0x06004AE8 RID: 19176 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004AE9 RID: 19177 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000F26")]
		public DevPayloadPrefs PayloadPrefs
		{
			[Token(Token = "0x6004AE8")]
			[Address(RVA = "0x9945", Offset = "0x9945", VA = "0x9945")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004AE9")]
			[Address(RVA = "0x9946", Offset = "0x9946", VA = "0x9946")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06004AEA RID: 19178 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004AEA")]
		[Address(RVA = "0x9947", Offset = "0x9947", VA = "0x9947")]
		public UIAPBillingModel(string storeName, IDictProvider dictProvider, IAuthTokenSource authTokenSource, DevPayloadPrefs devPayloadPrefs, IBillingProvider provider, IGame game, UserData user)
		{
		}

		// Token: 0x06004AEB RID: 19179 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004AEB")]
		[Address(RVA = "0x9948", Offset = "0x9948", VA = "0x9948", Slot = "8")]
		public override BankOptionData.ExtPriceData GetExtPriceData(BankOptionData data)
		{
			return null;
		}

		// Token: 0x06004AEC RID: 19180 RVA: 0x0000DD58 File Offset: 0x0000BF58
		[Token(Token = "0x6004AEC")]
		[Address(RVA = "0x9949", Offset = "0x9949", VA = "0x9949", Slot = "9")]
		public override bool IsOptionValid(string id)
		{
			return default(bool);
		}

		// Token: 0x06004AED RID: 19181 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004AED")]
		[Address(RVA = "0x994A", Offset = "0x994A", VA = "0x994A")]
		public void SetValidProducts(IList<Product> products)
		{
		}

		// Token: 0x06004AEE RID: 19182 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004AEE")]
		[Address(RVA = "0x994B", Offset = "0x994B", VA = "0x994B")]
		public void AddValidProducts(IList<Product> products)
		{
		}

		// Token: 0x040028C5 RID: 10437
		[Token(Token = "0x40028C5")]
		[FieldOffset(Offset = "0x4C")]
		private Dictionary<string, Product> _validExtPriceProducts;
	}
}
