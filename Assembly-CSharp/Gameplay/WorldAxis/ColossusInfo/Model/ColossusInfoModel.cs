using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Data.Balance;
using Core.Dict;
using Gameplay.WorldAxis.Colossus.Combat.Model;
using Gameplay.WorldAxis.Model;
using Gameplay.WorldAxis.Office.Model;
using Il2CppDummyDll;
using MVC;
using Protocol.Colossus;
using UI.Tabs;

namespace Gameplay.WorldAxis.ColossusInfo.Model
{
	// Token: 0x02000329 RID: 809
	[Token(Token = "0x2000329")]
	public class ColossusInfoModel : AbstractModel
	{
		// Token: 0x170002E0 RID: 736
		// (get) Token: 0x06001290 RID: 4752 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06001291 RID: 4753 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002E0")]
		public IDictProvider DictProvider
		{
			[Token(Token = "0x6001290")]
			[Address(RVA = "0x648A", Offset = "0x648A", VA = "0x648A")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001291")]
			[Address(RVA = "0x648B", Offset = "0x648B", VA = "0x648B")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170002E1 RID: 737
		// (get) Token: 0x06001292 RID: 4754 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06001293 RID: 4755 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002E1")]
		public WorldAxisOfficeModel.ColossusClanRating[] Rating
		{
			[Token(Token = "0x6001292")]
			[Address(RVA = "0x648C", Offset = "0x648C", VA = "0x648C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001293")]
			[Address(RVA = "0x648D", Offset = "0x648D", VA = "0x648D")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170002E2 RID: 738
		// (get) Token: 0x06001294 RID: 4756 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06001295 RID: 4757 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002E2")]
		public ColossusCombatRewards CombatRewards
		{
			[Token(Token = "0x6001294")]
			[Address(RVA = "0x648E", Offset = "0x648E", VA = "0x648E")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001295")]
			[Address(RVA = "0x648F", Offset = "0x648F", VA = "0x648F")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170002E3 RID: 739
		// (get) Token: 0x06001296 RID: 4758 RVA: 0x00004998 File Offset: 0x00002B98
		[Token(Token = "0x170002E3")]
		public bool IsMyColossus
		{
			[Token(Token = "0x6001296")]
			[Address(RVA = "0x6490", Offset = "0x6490", VA = "0x6490")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06001297 RID: 4759 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001297")]
		[Address(RVA = "0x6491", Offset = "0x6491", VA = "0x6491")]
		public ColossusInfoModel(UserData user, ColossusBattleData colossusBattleData, WorldAxisModel worldAxisModel)
		{
		}

		// Token: 0x06001298 RID: 4760 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001298")]
		[Address(RVA = "0x6492", Offset = "0x6492", VA = "0x6492")]
		public List<TabBarItemData> GetTabBarItemData()
		{
			return null;
		}

		// Token: 0x06001299 RID: 4761 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001299")]
		[Address(RVA = "0x6493", Offset = "0x6493", VA = "0x6493")]
		public void SetRatings(IList<ColossusRating> ratings)
		{
		}

		// Token: 0x04000A0C RID: 2572
		[Token(Token = "0x4000A0C")]
		[FieldOffset(Offset = "0x10")]
		public readonly WorldAxisModel WorldAxisModel;

		// Token: 0x04000A0D RID: 2573
		[Token(Token = "0x4000A0D")]
		[FieldOffset(Offset = "0x14")]
		public readonly IBalanceSource Treasury;

		// Token: 0x04000A0E RID: 2574
		[Token(Token = "0x4000A0E")]
		[FieldOffset(Offset = "0x18")]
		public readonly ColossusBattleData ColossusBattleData;
	}
}
