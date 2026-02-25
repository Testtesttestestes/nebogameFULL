using System;
using Il2CppDummyDll;

namespace Gameplay.GameEvents.Model.Tags
{
	// Token: 0x020007B5 RID: 1973
	[Token(Token = "0x20007B5")]
	public class TournamentTypeTag_15 : AbstractTag
	{
		// Token: 0x17000911 RID: 2321
		// (get) Token: 0x06002EA7 RID: 11943 RVA: 0x00009570 File Offset: 0x00007770
		[Token(Token = "0x17000911")]
		public uint TournamentType
		{
			[Token(Token = "0x6002EA7")]
			[Address(RVA = "0x7F22", Offset = "0x7F22", VA = "0x7F22")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x06002EA8 RID: 11944 RVA: 0x00009588 File Offset: 0x00007788
		[Token(Token = "0x6002EA8")]
		[Address(RVA = "0x7F23", Offset = "0x7F23", VA = "0x7F23", Slot = "7")]
		public override bool TryGetValue(string tagName, GameEventData evtData, out string value, AbstractTag.TagViewHandler viewHandler)
		{
			return default(bool);
		}

		// Token: 0x06002EA9 RID: 11945 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EA9")]
		[Address(RVA = "0x7F24", Offset = "0x7F24", VA = "0x7F24")]
		public TournamentTypeTag_15()
		{
		}

		// Token: 0x0400198F RID: 6543
		[Token(Token = "0x400198F")]
		public const string TOURNAMENT_TYPE = "tournament_type";
	}
}
