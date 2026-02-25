using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Dict;
using Core.Gameplay;
using Gameplay.Bank.Model;
using Gameplay.Billing.BillingProvider;
using Il2CppDummyDll;
using MVC;
using Protocol.Dic;

namespace Gameplay.Billing.Model
{
	// Token: 0x02000BE2 RID: 3042
	[Token(Token = "0x2000BE2")]
	public abstract class AbstractBillingModel : AbstractModel
	{
		// Token: 0x17000F0F RID: 3855
		// (get) Token: 0x06004AA8 RID: 19112 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004AA9 RID: 19113 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000F0F")]
		public IGame Game
		{
			[Token(Token = "0x6004AA8")]
			[Address(RVA = "0x990A", Offset = "0x990A", VA = "0x990A")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004AA9")]
			[Address(RVA = "0x990B", Offset = "0x990B", VA = "0x990B")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000F10 RID: 3856
		// (get) Token: 0x06004AAA RID: 19114 RVA: 0x0000DBC0 File Offset: 0x0000BDC0
		// (set) Token: 0x06004AAB RID: 19115 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000F10")]
		public double Balance
		{
			[Token(Token = "0x6004AAA")]
			[Address(RVA = "0x990C", Offset = "0x990C", VA = "0x990C")]
			[CompilerGenerated]
			get
			{
				return 0.0;
			}
			[Token(Token = "0x6004AAB")]
			[Address(RVA = "0x990D", Offset = "0x990D", VA = "0x990D")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000F11 RID: 3857
		// (get) Token: 0x06004AAC RID: 19116 RVA: 0x0000DBD8 File Offset: 0x0000BDD8
		// (set) Token: 0x06004AAD RID: 19117 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000F11")]
		public bool IsBankAvailable
		{
			[Token(Token = "0x6004AAC")]
			[Address(RVA = "0x990E", Offset = "0x990E", VA = "0x990E")]
			[CompilerGenerated]
			protected get
			{
				return default(bool);
			}
			[Token(Token = "0x6004AAD")]
			[Address(RVA = "0x990F", Offset = "0x990F", VA = "0x990F")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000F12 RID: 3858
		// (get) Token: 0x06004AAE RID: 19118 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000F12")]
		public string CurrencyCode
		{
			[Token(Token = "0x6004AAE")]
			[Address(RVA = "0x9910", Offset = "0x9910", VA = "0x9910")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000F13 RID: 3859
		// (get) Token: 0x06004AAF RID: 19119 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000F13")]
		public string CurrencyTitle
		{
			[Token(Token = "0x6004AAF")]
			[Address(RVA = "0x9911", Offset = "0x9911", VA = "0x9911")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000F14 RID: 3860
		// (get) Token: 0x06004AB0 RID: 19120 RVA: 0x0000DBF0 File Offset: 0x0000BDF0
		[Token(Token = "0x17000F14")]
		public uint CurrencyId
		{
			[Token(Token = "0x6004AB0")]
			[Address(RVA = "0x9912", Offset = "0x9912", VA = "0x9912")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x17000F15 RID: 3861
		// (get) Token: 0x06004AB1 RID: 19121 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004AB2 RID: 19122 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000F15")]
		public BankOptionData СurrentOption
		{
			[Token(Token = "0x6004AB1")]
			[Address(RVA = "0x9913", Offset = "0x9913", VA = "0x9913")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004AB2")]
			[Address(RVA = "0x9914", Offset = "0x9914", VA = "0x9914")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000F16 RID: 3862
		// (get) Token: 0x06004AB3 RID: 19123 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004AB4 RID: 19124 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000F16")]
		public IAuthTokenSource AuthTokenSource
		{
			[Token(Token = "0x6004AB3")]
			[Address(RVA = "0x9915", Offset = "0x9915", VA = "0x9915")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004AB4")]
			[Address(RVA = "0x9916", Offset = "0x9916", VA = "0x9916")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000F17 RID: 3863
		// (get) Token: 0x06004AB5 RID: 19125
		[Token(Token = "0x17000F17")]
		public abstract bool IsBalanceSupported { [Token(Token = "0x6004AB5")] get; }

		// Token: 0x17000F18 RID: 3864
		// (get) Token: 0x06004AB6 RID: 19126
		[Token(Token = "0x17000F18")]
		public abstract bool IsPurchasesAvailable { [Token(Token = "0x6004AB6")] get; }

		// Token: 0x17000F19 RID: 3865
		// (get) Token: 0x06004AB7 RID: 19127 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004AB8 RID: 19128 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000F19")]
		public Queue<List<string>> PartsOfProductsIdsForGetInformation
		{
			[Token(Token = "0x6004AB7")]
			[Address(RVA = "0x9917", Offset = "0x9917", VA = "0x9917")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004AB8")]
			[Address(RVA = "0x9918", Offset = "0x9918", VA = "0x9918")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06004AB9 RID: 19129 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004AB9")]
		[Address(RVA = "0x9919", Offset = "0x9919", VA = "0x9919", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x06004ABA RID: 19130 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004ABA")]
		[Address(RVA = "0x991A", Offset = "0x991A", VA = "0x991A")]
		protected AbstractBillingModel(IDictProvider dictProvider, IAuthTokenSource authTokenSource, IBillingProvider provider, IGame game, UserData user)
		{
		}

		// Token: 0x06004ABB RID: 19131 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004ABB")]
		[Address(RVA = "0x991B", Offset = "0x991B", VA = "0x991B")]
		private void Init()
		{
		}

		// Token: 0x06004ABC RID: 19132 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004ABC")]
		[Address(RVA = "0x991C", Offset = "0x991C", VA = "0x991C")]
		public string GetDefaultCurrencyCode()
		{
			return null;
		}

		// Token: 0x06004ABD RID: 19133 RVA: 0x0000DC08 File Offset: 0x0000BE08
		[Token(Token = "0x6004ABD")]
		[Address(RVA = "0x991D", Offset = "0x991D", VA = "0x991D")]
		public bool IsCanBuyWithDrawMoney(BankOptionData option)
		{
			return default(bool);
		}

		// Token: 0x06004ABE RID: 19134
		[Token(Token = "0x6004ABE")]
		public abstract BankOptionData.ExtPriceData GetExtPriceData(BankOptionData data);

		// Token: 0x06004ABF RID: 19135 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004ABF")]
		[Address(RVA = "0x991E", Offset = "0x991E", VA = "0x991E")]
		public Queue<List<string>> BreakAPartProductsIds(List<string> ids, int count)
		{
			return null;
		}

		// Token: 0x06004AC0 RID: 19136
		[Token(Token = "0x6004AC0")]
		public abstract bool IsOptionValid(string id);

		// Token: 0x06004AC1 RID: 19137
		[Token(Token = "0x6004AC1")]
		protected abstract void HandleInit();

		// Token: 0x0400289F RID: 10399
		[Token(Token = "0x400289F")]
		[FieldOffset(Offset = "0xC")]
		private CurrenciesDic _currenciesDic;

		// Token: 0x040028A6 RID: 10406
		[Token(Token = "0x40028A6")]
		[FieldOffset(Offset = "0x30")]
		public readonly IBillingProvider Provider;

		// Token: 0x040028A7 RID: 10407
		[Token(Token = "0x40028A7")]
		[FieldOffset(Offset = "0x34")]
		public readonly IDictProvider DictProvider;
	}
}
