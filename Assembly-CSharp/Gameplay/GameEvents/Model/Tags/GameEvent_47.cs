using System;
using Il2CppDummyDll;

namespace Gameplay.GameEvents.Model.Tags
{
	// Token: 0x020007A6 RID: 1958
	[Token(Token = "0x20007A6")]
	public class GameEvent_47 : AbstractTag
	{
		// Token: 0x170008FF RID: 2303
		// (get) Token: 0x06002E77 RID: 11895 RVA: 0x00009270 File Offset: 0x00007470
		[Token(Token = "0x170008FF")]
		public uint EventId
		{
			[Token(Token = "0x6002E77")]
			[Address(RVA = "0x7EF2", Offset = "0x7EF2", VA = "0x7EF2")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x06002E78 RID: 11896 RVA: 0x00009288 File Offset: 0x00007488
		[Token(Token = "0x6002E78")]
		[Address(RVA = "0x7EF3", Offset = "0x7EF3", VA = "0x7EF3", Slot = "7")]
		public override bool TryGetValue(string tagName, GameEventData evtData, out string value, AbstractTag.TagViewHandler viewHandler)
		{
			return default(bool);
		}

		// Token: 0x06002E79 RID: 11897 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E79")]
		[Address(RVA = "0x7EF4", Offset = "0x7EF4", VA = "0x7EF4")]
		public GameEvent_47()
		{
		}

		// Token: 0x04001979 RID: 6521
		[Token(Token = "0x4001979")]
		public const string GAME_EVENT_TITLE = "game_event_title";
	}
}
