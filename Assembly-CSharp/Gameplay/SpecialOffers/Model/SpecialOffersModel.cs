using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Gameplay;
using Gameplay.Bank.Model;
using Il2CppDummyDll;
using Protocol.Services;

namespace Gameplay.SpecialOffers.Model
{
	// Token: 0x02000504 RID: 1284
	[Token(Token = "0x2000504")]
	public class SpecialOffersModel : OptionsOfferModel
	{
		// Token: 0x1700059A RID: 1434
		// (get) Token: 0x06001EAA RID: 7850 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06001EAB RID: 7851 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700059A")]
		public override List<BankOptionData> Offers
		{
			[Token(Token = "0x6001EAA")]
			[Address(RVA = "0x701D", Offset = "0x701D", VA = "0x701D", Slot = "6")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001EAB")]
			[Address(RVA = "0x701E", Offset = "0x701E", VA = "0x701E", Slot = "7")]
			protected set
			{
			}
		}

		// Token: 0x06001EAC RID: 7852 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EAC")]
		[Address(RVA = "0x701F", Offset = "0x701F", VA = "0x701F")]
		public SpecialOffersModel(UserData user, IList<uint> optionIds, IGame game)
		{
		}

		// Token: 0x06001EAD RID: 7853 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EAD")]
		[Address(RVA = "0x7020", Offset = "0x7020", VA = "0x7020")]
		public SpecialOffersModel(UserData user, IGame game)
		{
		}

		// Token: 0x1700059B RID: 1435
		// (get) Token: 0x06001EAE RID: 7854 RVA: 0x00006528 File Offset: 0x00004728
		[Token(Token = "0x1700059B")]
		public int UnseenOptionsCount
		{
			[Token(Token = "0x6001EAE")]
			[Address(RVA = "0x7021", Offset = "0x7021", VA = "0x7021")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06001EAF RID: 7855 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EAF")]
		[Address(RVA = "0x7022", Offset = "0x7022", VA = "0x7022", Slot = "8")]
		protected override void PopulateOptions(IList<uint> optionIds, BankModel bankModel)
		{
		}

		// Token: 0x06001EB0 RID: 7856 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EB0")]
		[Address(RVA = "0x7023", Offset = "0x7023", VA = "0x7023", Slot = "9")]
		public override void RemoveOption(BankOptionData data)
		{
		}

		// Token: 0x06001EB1 RID: 7857 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EB1")]
		[Address(RVA = "0x7024", Offset = "0x7024", VA = "0x7024")]
		public void PopulateOptions(IEnumerable<ProtoGetSpecialOfferAns.Types.SpecialOfferInfo> specialOffers)
		{
		}

		// Token: 0x06001EB2 RID: 7858 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001EB2")]
		[Address(RVA = "0x7025", Offset = "0x7025", VA = "0x7025")]
		private BankOptionData ConstructOption(ProtoGetSpecialOfferAns.Types.SpecialOfferInfo info)
		{
			return null;
		}

		// Token: 0x06001EB4 RID: 7860 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EB4")]
		[Address(RVA = "0x7027", Offset = "0x7027", VA = "0x7027")]
		[CompilerGenerated]
		internal static void <ConstructOption>g__AddRewards|13_0(ref SpecialOffersModel.<>c__DisplayClass13_0 A_0)
		{
		}

		// Token: 0x06001EB5 RID: 7861 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EB5")]
		[Address(RVA = "0x7028", Offset = "0x7028", VA = "0x7028")]
		[CompilerGenerated]
		internal static void <ConstructOption>g__CreateRewards|13_1(ref SpecialOffersModel.<>c__DisplayClass13_0 A_0)
		{
		}

		// Token: 0x040010A8 RID: 4264
		[Token(Token = "0x40010A8")]
		[FieldOffset(Offset = "0x20")]
		public bool OptionsViewed;

		// Token: 0x040010A9 RID: 4265
		[Token(Token = "0x40010A9")]
		[FieldOffset(Offset = "0x24")]
		private BankModel _bankModel;

		// Token: 0x040010AA RID: 4266
		[Token(Token = "0x40010AA")]
		[FieldOffset(Offset = "0x28")]
		private readonly int _maxOffersCount;
	}
}
