using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Dict;
using Core.Gameplay;
using Core.Gameplay.Managers.Ad.Providers;
using Gameplay.Bank.Model;
using Il2CppDummyDll;
using MVC;
using Protocol.Dic;

namespace Gameplay.SpecialOffers.Model
{
	// Token: 0x02000503 RID: 1283
	[Token(Token = "0x2000503")]
	public class OptionsOfferModel : AbstractModel
	{
		// Token: 0x17000595 RID: 1429
		// (get) Token: 0x06001EA0 RID: 7840 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000595")]
		public Dictionaries Dict
		{
			[Token(Token = "0x6001EA0")]
			[Address(RVA = "0x7013", Offset = "0x7013", VA = "0x7013")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000596 RID: 1430
		// (get) Token: 0x06001EA1 RID: 7841 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06001EA2 RID: 7842 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000596")]
		public IGame Game
		{
			[Token(Token = "0x6001EA1")]
			[Address(RVA = "0x7014", Offset = "0x7014", VA = "0x7014")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001EA2")]
			[Address(RVA = "0x7015", Offset = "0x7015", VA = "0x7015")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000597 RID: 1431
		// (get) Token: 0x06001EA3 RID: 7843 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000597")]
		public IOptionValidator OptionValidator
		{
			[Token(Token = "0x6001EA3")]
			[Address(RVA = "0x7016", Offset = "0x7016", VA = "0x7016")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17000598 RID: 1432
		// (get) Token: 0x06001EA4 RID: 7844 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000598")]
		public IAdPlacementManagerProvider AdPlacementManagerProvider
		{
			[Token(Token = "0x6001EA4")]
			[Address(RVA = "0x7017", Offset = "0x7017", VA = "0x7017")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17000599 RID: 1433
		// (get) Token: 0x06001EA5 RID: 7845 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06001EA6 RID: 7846 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000599")]
		public virtual List<BankOptionData> Offers
		{
			[Token(Token = "0x6001EA5")]
			[Address(RVA = "0x7018", Offset = "0x7018", VA = "0x7018", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001EA6")]
			[Address(RVA = "0x7019", Offset = "0x7019", VA = "0x7019", Slot = "7")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06001EA7 RID: 7847 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EA7")]
		[Address(RVA = "0x701A", Offset = "0x701A", VA = "0x701A")]
		public OptionsOfferModel(UserData user, IList<uint> optionIds, IGame game)
		{
		}

		// Token: 0x06001EA8 RID: 7848 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EA8")]
		[Address(RVA = "0x701B", Offset = "0x701B", VA = "0x701B", Slot = "8")]
		protected virtual void PopulateOptions(IList<uint> optionIds, BankModel bankModel)
		{
		}

		// Token: 0x06001EA9 RID: 7849 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EA9")]
		[Address(RVA = "0x701C", Offset = "0x701C", VA = "0x701C", Slot = "9")]
		public virtual void RemoveOption(BankOptionData data)
		{
		}

		// Token: 0x040010A3 RID: 4259
		[Token(Token = "0x40010A3")]
		[FieldOffset(Offset = "0xC")]
		private readonly IDictProvider _dictProvider;
	}
}
