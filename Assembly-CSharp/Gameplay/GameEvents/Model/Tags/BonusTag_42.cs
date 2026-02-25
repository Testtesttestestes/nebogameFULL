using System;
using Il2CppDummyDll;

namespace Gameplay.GameEvents.Model.Tags
{
	// Token: 0x02000799 RID: 1945
	[Token(Token = "0x2000799")]
	public class BonusTag_42 : AbstractTag
	{
		// Token: 0x170008EE RID: 2286
		// (get) Token: 0x06002E4E RID: 11854 RVA: 0x00008FD0 File Offset: 0x000071D0
		[Token(Token = "0x170008EE")]
		public uint BonusId
		{
			[Token(Token = "0x6002E4E")]
			[Address(RVA = "0x7EC9", Offset = "0x7EC9", VA = "0x7EC9")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x06002E4F RID: 11855 RVA: 0x00008FE8 File Offset: 0x000071E8
		[Token(Token = "0x6002E4F")]
		[Address(RVA = "0x7ECA", Offset = "0x7ECA", VA = "0x7ECA", Slot = "7")]
		public override bool TryGetValue(string tagName, GameEventData evtData, out string value, AbstractTag.TagViewHandler viewHandler)
		{
			return default(bool);
		}

		// Token: 0x06002E50 RID: 11856 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E50")]
		[Address(RVA = "0x7ECB", Offset = "0x7ECB", VA = "0x7ECB")]
		public BonusTag_42()
		{
		}
	}
}
