using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Dict;
using Core.Gameplay;
using Gameplay.Bank.Model;
using Gameplay.Billing.BillingProvider;
using Il2CppDummyDll;

namespace Gameplay.Billing.Model
{
	// Token: 0x02000BE3 RID: 3043
	[Token(Token = "0x2000BE3")]
	public class BillingModelForAppMarketWhitProducts : AbstractBillingModel
	{
		// Token: 0x17000F1A RID: 3866
		// (get) Token: 0x06004AC2 RID: 19138 RVA: 0x0000DC20 File Offset: 0x0000BE20
		[Token(Token = "0x17000F1A")]
		public override bool IsBalanceSupported
		{
			[Token(Token = "0x6004AC2")]
			[Address(RVA = "0x991F", Offset = "0x991F", VA = "0x991F", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000F1B RID: 3867
		// (get) Token: 0x06004AC3 RID: 19139 RVA: 0x0000DC38 File Offset: 0x0000BE38
		[Token(Token = "0x17000F1B")]
		public override bool IsPurchasesAvailable
		{
			[Token(Token = "0x6004AC3")]
			[Address(RVA = "0x9920", Offset = "0x9920", VA = "0x9920", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06004AC4 RID: 19140 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004AC4")]
		[Address(RVA = "0x9921", Offset = "0x9921", VA = "0x9921")]
		public BillingModelForAppMarketWhitProducts(string storeName, IDictProvider dictProvider, IAuthTokenSource authTokenSource, IBillingProvider provider, IGame game, UserData user)
		{
		}

		// Token: 0x06004AC5 RID: 19141 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004AC5")]
		[Address(RVA = "0x9922", Offset = "0x9922", VA = "0x9922", Slot = "10")]
		protected override void HandleInit()
		{
		}

		// Token: 0x06004AC6 RID: 19142 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004AC6")]
		[Address(RVA = "0x9923", Offset = "0x9923", VA = "0x9923", Slot = "8")]
		public override BankOptionData.ExtPriceData GetExtPriceData(BankOptionData data)
		{
			return null;
		}

		// Token: 0x06004AC7 RID: 19143 RVA: 0x0000DC50 File Offset: 0x0000BE50
		[Token(Token = "0x6004AC7")]
		[Address(RVA = "0x9924", Offset = "0x9924", VA = "0x9924", Slot = "9")]
		public override bool IsOptionValid(string id)
		{
			return default(bool);
		}

		// Token: 0x06004AC8 RID: 19144 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004AC8")]
		[Address(RVA = "0x9925", Offset = "0x9925", VA = "0x9925")]
		public Uri GetRecipeValidatorEndpoint(string storeName)
		{
			return null;
		}

		// Token: 0x040028A8 RID: 10408
		[Token(Token = "0x40028A8")]
		[FieldOffset(Offset = "0x38")]
		public readonly List<string> AllOptionIds;

		// Token: 0x040028A9 RID: 10409
		[Token(Token = "0x40028A9")]
		[FieldOffset(Offset = "0x3C")]
		public readonly List<string> AllExtPriceOptionIds;

		// Token: 0x040028AA RID: 10410
		[Token(Token = "0x40028AA")]
		[FieldOffset(Offset = "0x40")]
		public readonly List<string> AllResourcePriceOptionIds;

		// Token: 0x040028AD RID: 10413
		[Token(Token = "0x40028AD")]
		[FieldOffset(Offset = "0x48")]
		public readonly string StoreName;
	}
}
