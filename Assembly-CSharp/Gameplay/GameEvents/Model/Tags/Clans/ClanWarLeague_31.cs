using System;
using Il2CppDummyDll;

namespace Gameplay.GameEvents.Model.Tags.Clans
{
	// Token: 0x020007C6 RID: 1990
	[Token(Token = "0x20007C6")]
	public class ClanWarLeague_31 : AbstractTag
	{
		// Token: 0x17000921 RID: 2337
		// (get) Token: 0x06002EDA RID: 11994 RVA: 0x00009780 File Offset: 0x00007980
		[Token(Token = "0x17000921")]
		public uint LeagueId
		{
			[Token(Token = "0x6002EDA")]
			[Address(RVA = "0x7F49", Offset = "0x7F49", VA = "0x7F49")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x06002EDB RID: 11995 RVA: 0x00009798 File Offset: 0x00007998
		[Token(Token = "0x6002EDB")]
		[Address(RVA = "0x7F4A", Offset = "0x7F4A", VA = "0x7F4A", Slot = "7")]
		public override bool TryGetValue(string tagName, GameEventData evtData, out string value, AbstractTag.TagViewHandler viewHandler)
		{
			return default(bool);
		}

		// Token: 0x06002EDC RID: 11996 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EDC")]
		[Address(RVA = "0x7F4B", Offset = "0x7F4B", VA = "0x7F4B")]
		public ClanWarLeague_31()
		{
		}

		// Token: 0x040019A6 RID: 6566
		[Token(Token = "0x40019A6")]
		public const string LEAGUE_TITLE = "league_title";
	}
}
