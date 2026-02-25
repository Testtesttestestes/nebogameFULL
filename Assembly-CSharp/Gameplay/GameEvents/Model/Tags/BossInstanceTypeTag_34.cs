using System;
using Il2CppDummyDll;

namespace Gameplay.GameEvents.Model.Tags
{
	// Token: 0x0200079A RID: 1946
	[Token(Token = "0x200079A")]
	public class BossInstanceTypeTag_34 : AbstractTag
	{
		// Token: 0x170008EF RID: 2287
		// (get) Token: 0x06002E51 RID: 11857 RVA: 0x00009000 File Offset: 0x00007200
		[Token(Token = "0x170008EF")]
		public int BossTypeId
		{
			[Token(Token = "0x6002E51")]
			[Address(RVA = "0x7ECC", Offset = "0x7ECC", VA = "0x7ECC")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06002E52 RID: 11858 RVA: 0x00009018 File Offset: 0x00007218
		[Token(Token = "0x6002E52")]
		[Address(RVA = "0x7ECD", Offset = "0x7ECD", VA = "0x7ECD", Slot = "7")]
		public override bool TryGetValue(string tagName, GameEventData evtData, out string value, AbstractTag.TagViewHandler viewHandler)
		{
			return default(bool);
		}

		// Token: 0x06002E53 RID: 11859 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E53")]
		[Address(RVA = "0x7ECE", Offset = "0x7ECE", VA = "0x7ECE")]
		public BossInstanceTypeTag_34()
		{
		}

		// Token: 0x04001969 RID: 6505
		[Token(Token = "0x4001969")]
		public const string BOSS_TITLE = "boss_title";

		// Token: 0x0400196A RID: 6506
		[Token(Token = "0x400196A")]
		public const string BOSS_VIEW = "boss_view";
	}
}
