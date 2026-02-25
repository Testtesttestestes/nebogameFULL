using System;
using Il2CppDummyDll;

namespace Gameplay.GameEvents.Model.Tags.Clans
{
	// Token: 0x020007C5 RID: 1989
	[Token(Token = "0x20007C5")]
	public class ClanRestriction_32 : AbstractTag
	{
		// Token: 0x17000920 RID: 2336
		// (get) Token: 0x06002ED7 RID: 11991 RVA: 0x00009750 File Offset: 0x00007950
		[Token(Token = "0x17000920")]
		public uint RestrictionId
		{
			[Token(Token = "0x6002ED7")]
			[Address(RVA = "0x7F46", Offset = "0x7F46", VA = "0x7F46")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x06002ED8 RID: 11992 RVA: 0x00009768 File Offset: 0x00007968
		[Token(Token = "0x6002ED8")]
		[Address(RVA = "0x7F47", Offset = "0x7F47", VA = "0x7F47", Slot = "7")]
		public override bool TryGetValue(string tagName, GameEventData evtData, out string value, AbstractTag.TagViewHandler viewHandler)
		{
			return default(bool);
		}

		// Token: 0x06002ED9 RID: 11993 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002ED9")]
		[Address(RVA = "0x7F48", Offset = "0x7F48", VA = "0x7F48")]
		public ClanRestriction_32()
		{
		}

		// Token: 0x040019A5 RID: 6565
		[Token(Token = "0x40019A5")]
		public const string CLAN_RESTRICTION_TITLE = "clanrestriction";
	}
}
