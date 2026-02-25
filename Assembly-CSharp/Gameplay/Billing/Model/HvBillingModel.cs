using System;
using Core.Data;
using Core.Dict;
using Core.Gameplay;
using Gameplay.Bank.Model;
using Gameplay.Billing.BillingProvider;
using Il2CppDummyDll;

namespace Gameplay.Billing.Model
{
	// Token: 0x02000BE8 RID: 3048
	[Token(Token = "0x2000BE8")]
	public class HvBillingModel : AbstractBillingModel
	{
		// Token: 0x17000F1F RID: 3871
		// (get) Token: 0x06004AD4 RID: 19156 RVA: 0x0000DCB0 File Offset: 0x0000BEB0
		[Token(Token = "0x17000F1F")]
		public override bool IsPurchasesAvailable
		{
			[Token(Token = "0x6004AD4")]
			[Address(RVA = "0x9931", Offset = "0x9931", VA = "0x9931", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000F20 RID: 3872
		// (get) Token: 0x06004AD5 RID: 19157 RVA: 0x0000DCC8 File Offset: 0x0000BEC8
		[Token(Token = "0x17000F20")]
		public override bool IsBalanceSupported
		{
			[Token(Token = "0x6004AD5")]
			[Address(RVA = "0x9932", Offset = "0x9932", VA = "0x9932", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06004AD6 RID: 19158 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004AD6")]
		[Address(RVA = "0x9933", Offset = "0x9933", VA = "0x9933")]
		public HvBillingModel(IDictProvider dictProvider, IAuthTokenSource authTokenSource, IBillingProvider provider, IGame game, UserData user)
		{
		}

		// Token: 0x06004AD7 RID: 19159 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004AD7")]
		[Address(RVA = "0x9934", Offset = "0x9934", VA = "0x9934", Slot = "10")]
		protected override void HandleInit()
		{
		}

		// Token: 0x06004AD8 RID: 19160 RVA: 0x0000DCE0 File Offset: 0x0000BEE0
		[Token(Token = "0x6004AD8")]
		[Address(RVA = "0x9935", Offset = "0x9935", VA = "0x9935", Slot = "9")]
		public override bool IsOptionValid(string id)
		{
			return default(bool);
		}

		// Token: 0x06004AD9 RID: 19161 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004AD9")]
		[Address(RVA = "0x9936", Offset = "0x9936", VA = "0x9936", Slot = "8")]
		public override BankOptionData.ExtPriceData GetExtPriceData(BankOptionData data)
		{
			return null;
		}
	}
}
