using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Dict;
using Il2CppDummyDll;
using MVC;
using Protocol.Craft;
using Protocol.Dic;
using UI.Tabs;

namespace Gameplay.Craft.Model
{
	// Token: 0x020008C0 RID: 2240
	[Token(Token = "0x20008C0")]
	public class CraftModel : AbstractModel
	{
		// Token: 0x17000A70 RID: 2672
		// (get) Token: 0x06003495 RID: 13461 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000A70")]
		public Dictionaries Dict
		{
			[Token(Token = "0x6003495")]
			[Address(RVA = "0x84BF", Offset = "0x84BF", VA = "0x84BF")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A71 RID: 2673
		// (get) Token: 0x06003496 RID: 13462 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003497 RID: 13463 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A71")]
		public UserProfession Profession
		{
			[Token(Token = "0x6003496")]
			[Address(RVA = "0x84C0", Offset = "0x84C0", VA = "0x84C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003497")]
			[Address(RVA = "0x84C1", Offset = "0x84C1", VA = "0x84C1")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000A72 RID: 2674
		// (get) Token: 0x06003498 RID: 13464 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003499 RID: 13465 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A72")]
		public ProfessionDic ProfessionDic
		{
			[Token(Token = "0x6003498")]
			[Address(RVA = "0x84C2", Offset = "0x84C2", VA = "0x84C2")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003499")]
			[Address(RVA = "0x84C3", Offset = "0x84C3", VA = "0x84C3")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000A73 RID: 2675
		// (get) Token: 0x0600349A RID: 13466 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600349B RID: 13467 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A73")]
		public ArtikulTypeFilters[] Filters
		{
			[Token(Token = "0x600349A")]
			[Address(RVA = "0x84C4", Offset = "0x84C4", VA = "0x84C4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600349B")]
			[Address(RVA = "0x84C5", Offset = "0x84C5", VA = "0x84C5")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000A74 RID: 2676
		// (get) Token: 0x0600349C RID: 13468 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600349D RID: 13469 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A74")]
		public IList<UserCraftSlotInfo> SlotInfos
		{
			[Token(Token = "0x600349C")]
			[Address(RVA = "0x84C6", Offset = "0x84C6", VA = "0x84C6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600349D")]
			[Address(RVA = "0x84C7", Offset = "0x84C7", VA = "0x84C7")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000A75 RID: 2677
		// (get) Token: 0x0600349E RID: 13470 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600349F RID: 13471 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A75")]
		public IList<CraftSlotDic> AllCraftSlots
		{
			[Token(Token = "0x600349E")]
			[Address(RVA = "0x84C8", Offset = "0x84C8", VA = "0x84C8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600349F")]
			[Address(RVA = "0x84C9", Offset = "0x84C9", VA = "0x84C9")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000A76 RID: 2678
		// (get) Token: 0x060034A0 RID: 13472 RVA: 0x0000AA88 File Offset: 0x00008C88
		// (set) Token: 0x060034A1 RID: 13473 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A76")]
		public DateTime OriginTime
		{
			[Token(Token = "0x60034A0")]
			[Address(RVA = "0x84CA", Offset = "0x84CA", VA = "0x84CA")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Token(Token = "0x60034A1")]
			[Address(RVA = "0x84CB", Offset = "0x84CB", VA = "0x84CB")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060034A2 RID: 13474 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034A2")]
		[Address(RVA = "0x84CC", Offset = "0x84CC", VA = "0x84CC")]
		public CraftModel(UserData user)
		{
		}

		// Token: 0x060034A3 RID: 13475 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034A3")]
		[Address(RVA = "0x84CD", Offset = "0x84CD", VA = "0x84CD")]
		public void PopulateSchemes(IList<UserScheme> userSchemes)
		{
		}

		// Token: 0x060034A4 RID: 13476 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60034A4")]
		[Address(RVA = "0x84CE", Offset = "0x84CE", VA = "0x84CE")]
		public TabBarItemData[] GetTabBarData()
		{
			return null;
		}

		// Token: 0x060034A5 RID: 13477 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034A5")]
		[Address(RVA = "0x84CF", Offset = "0x84CF", VA = "0x84CF")]
		public void SetProfession(UserProfession profession)
		{
		}

		// Token: 0x060034A6 RID: 13478 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034A6")]
		[Address(RVA = "0x84D0", Offset = "0x84D0", VA = "0x84D0")]
		public void SetCraftSlots(IList<UserCraftSlotInfo> slots)
		{
		}

		// Token: 0x060034A7 RID: 13479 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60034A7")]
		[Address(RVA = "0x4498", Offset = "0x4498", VA = "0x4498")]
		public CraftSchemeData.CraftSchemeInfo GetSchemeInfo(uint schemeId)
		{
			return null;
		}

		// Token: 0x060034A8 RID: 13480 RVA: 0x0000AAA0 File Offset: 0x00008CA0
		[Token(Token = "0x60034A8")]
		[Address(RVA = "0x84D1", Offset = "0x84D1", VA = "0x84D1")]
		public bool TryGetSlotExpirationTime(uint slotId, out long time)
		{
			return default(bool);
		}

		// Token: 0x060034A9 RID: 13481 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034A9")]
		[Address(RVA = "0x84D2", Offset = "0x84D2", VA = "0x84D2", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x04001CCC RID: 7372
		[Token(Token = "0x4001CCC")]
		private const string LOCALIZATION_CRAFT_RECIPES = "CRAFT/RECIPES";

		// Token: 0x04001CCD RID: 7373
		[Token(Token = "0x4001CCD")]
		private const string LOCALIZATION_CRAFT_PRODUCTION = "CRAFT/PRODUCTION";

		// Token: 0x04001CCE RID: 7374
		[Token(Token = "0x4001CCE")]
		[FieldOffset(Offset = "0xC")]
		public List<CraftSchemeData> CraftSchemes;

		// Token: 0x04001CCF RID: 7375
		[Token(Token = "0x4001CCF")]
		[FieldOffset(Offset = "0x10")]
		private IDictProvider _dictProvider;

		// Token: 0x04001CD6 RID: 7382
		[Token(Token = "0x4001CD6")]
		[FieldOffset(Offset = "0x30")]
		private readonly Dictionary<uint, CraftSchemeData.CraftSchemeInfo> _schemeInfoCache;

		// Token: 0x04001CD7 RID: 7383
		[Token(Token = "0x4001CD7")]
		[FieldOffset(Offset = "0x34")]
		private readonly Dictionary<uint, long> _expirationTimesBySlotId;
	}
}
