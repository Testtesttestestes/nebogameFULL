using System;
using Il2CppDummyDll;

namespace Gameplay.GameEvents.Model.Tags
{
	// Token: 0x020007AC RID: 1964
	[Token(Token = "0x20007AC")]
	public class MedalTag_10 : AbstractTag
	{
		// Token: 0x17000905 RID: 2309
		// (get) Token: 0x06002E89 RID: 11913 RVA: 0x00009390 File Offset: 0x00007590
		[Token(Token = "0x17000905")]
		public uint MedalId
		{
			[Token(Token = "0x6002E89")]
			[Address(RVA = "0x7F04", Offset = "0x7F04", VA = "0x7F04")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x06002E8A RID: 11914 RVA: 0x000093A8 File Offset: 0x000075A8
		[Token(Token = "0x6002E8A")]
		[Address(RVA = "0x7F05", Offset = "0x7F05", VA = "0x7F05", Slot = "7")]
		public override bool TryGetValue(string tagName, GameEventData evtData, out string value, AbstractTag.TagViewHandler viewHandler)
		{
			return default(bool);
		}

		// Token: 0x06002E8B RID: 11915 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E8B")]
		[Address(RVA = "0x7F06", Offset = "0x7F06", VA = "0x7F06")]
		public MedalTag_10()
		{
		}

		// Token: 0x0400197E RID: 6526
		[Token(Token = "0x400197E")]
		public const string MEDAl_TITLE = "medal_title";

		// Token: 0x0400197F RID: 6527
		[Token(Token = "0x400197F")]
		public const string MEDAl_RANK = "medal_rank";

		// Token: 0x04001980 RID: 6528
		[Token(Token = "0x4001980")]
		public const string MEDAl_VIEW = "medal_view";

		// Token: 0x04001981 RID: 6529
		[Token(Token = "0x4001981")]
		public const string MEDAL_VIEW_PREFAB = "MedalTagView";
	}
}
