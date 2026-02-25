using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Protocol.Consts;
using Protocol.Dic;
using Protocol.Tournaments;

namespace Core.Data.Tournaments
{
	// Token: 0x020010CC RID: 4300
	[Token(Token = "0x20010CC")]
	public class TournamentData : ITournament
	{
		// Token: 0x1700145B RID: 5211
		// (get) Token: 0x060064AB RID: 25771 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060064AC RID: 25772 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700145B")]
		public TournamentDic Dic
		{
			[Token(Token = "0x60064AB")]
			[Address(RVA = "0xB093", Offset = "0xB093", VA = "0xB093")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60064AC")]
			[Address(RVA = "0xB094", Offset = "0xB094", VA = "0xB094")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700145C RID: 5212
		// (get) Token: 0x060064AD RID: 25773 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060064AE RID: 25774 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700145C")]
		public TournamentInfo Info
		{
			[Token(Token = "0x60064AD")]
			[Address(RVA = "0xB095", Offset = "0xB095", VA = "0xB095")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60064AE")]
			[Address(RVA = "0xB096", Offset = "0xB096", VA = "0xB096")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700145D RID: 5213
		// (get) Token: 0x060064AF RID: 25775 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060064B0 RID: 25776 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700145D")]
		public UserData PreviousWinnerData
		{
			[Token(Token = "0x60064AF")]
			[Address(RVA = "0xB097", Offset = "0xB097", VA = "0xB097")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60064B0")]
			[Address(RVA = "0xB098", Offset = "0xB098", VA = "0xB098")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700145E RID: 5214
		// (get) Token: 0x060064B1 RID: 25777 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060064B2 RID: 25778 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700145E")]
		public RewardData[] WinnerRewards
		{
			[Token(Token = "0x60064B1")]
			[Address(RVA = "0xB099", Offset = "0xB099", VA = "0xB099")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60064B2")]
			[Address(RVA = "0xB09A", Offset = "0xB09A", VA = "0xB09A")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700145F RID: 5215
		// (get) Token: 0x060064B3 RID: 25779 RVA: 0x00013248 File Offset: 0x00011448
		// (set) Token: 0x060064B4 RID: 25780 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700145F")]
		public Resources BetResource
		{
			[Token(Token = "0x60064B3")]
			[Address(RVA = "0xB09B", Offset = "0xB09B", VA = "0xB09B")]
			[CompilerGenerated]
			get
			{
				return Resources.UnknownResource;
			}
			[Token(Token = "0x60064B4")]
			[Address(RVA = "0xB09C", Offset = "0xB09C", VA = "0xB09C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001460 RID: 5216
		// (get) Token: 0x060064B5 RID: 25781 RVA: 0x00013260 File Offset: 0x00011460
		[Token(Token = "0x17001460")]
		public uint TypeId
		{
			[Token(Token = "0x60064B5")]
			[Address(RVA = "0xB09D", Offset = "0xB09D", VA = "0xB09D", Slot = "4")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x060064B6 RID: 25782 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60064B6")]
		[Address(RVA = "0xB09E", Offset = "0xB09E", VA = "0xB09E")]
		public static TournamentData Create(TournamentInfo tournament, Dictionaries dict)
		{
			return null;
		}

		// Token: 0x060064B7 RID: 25783 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60064B7")]
		[Address(RVA = "0xB09F", Offset = "0xB09F", VA = "0xB09F")]
		public string GetTournamentStatusLocalization()
		{
			return null;
		}

		// Token: 0x060064B8 RID: 25784 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60064B8")]
		[Address(RVA = "0xB0A0", Offset = "0xB0A0", VA = "0xB0A0")]
		public TournamentData()
		{
		}
	}
}
