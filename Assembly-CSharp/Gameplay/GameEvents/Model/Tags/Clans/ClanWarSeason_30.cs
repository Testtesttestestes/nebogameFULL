using System;
using Il2CppDummyDll;

namespace Gameplay.GameEvents.Model.Tags.Clans
{
	// Token: 0x020007C7 RID: 1991
	[Token(Token = "0x20007C7")]
	public class ClanWarSeason_30 : AbstractTag
	{
		// Token: 0x17000922 RID: 2338
		// (get) Token: 0x06002EDD RID: 11997 RVA: 0x000097B0 File Offset: 0x000079B0
		[Token(Token = "0x17000922")]
		public uint SeasonId
		{
			[Token(Token = "0x6002EDD")]
			[Address(RVA = "0x7F4C", Offset = "0x7F4C", VA = "0x7F4C")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x06002EDE RID: 11998 RVA: 0x000097C8 File Offset: 0x000079C8
		[Token(Token = "0x6002EDE")]
		[Address(RVA = "0x7F4D", Offset = "0x7F4D", VA = "0x7F4D", Slot = "7")]
		public override bool TryGetValue(string tagName, GameEventData evtData, out string value, AbstractTag.TagViewHandler viewHandler)
		{
			return default(bool);
		}

		// Token: 0x06002EDF RID: 11999 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EDF")]
		[Address(RVA = "0x7F4E", Offset = "0x7F4E", VA = "0x7F4E")]
		public ClanWarSeason_30()
		{
		}

		// Token: 0x040019A7 RID: 6567
		[Token(Token = "0x40019A7")]
		public const string SEASON_TITLE = "season_title";
	}
}
