using System;
using Il2CppDummyDll;

namespace Gameplay.GameEvents.Model.Tags
{
	// Token: 0x0200079B RID: 1947
	[Token(Token = "0x200079B")]
	public class ClanRatingKingTag_20 : AbstractTag
	{
		// Token: 0x170008F0 RID: 2288
		// (get) Token: 0x06002E54 RID: 11860 RVA: 0x00009030 File Offset: 0x00007230
		[Token(Token = "0x170008F0")]
		public uint RatingKindId
		{
			[Token(Token = "0x6002E54")]
			[Address(RVA = "0x7ECF", Offset = "0x7ECF", VA = "0x7ECF")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x06002E55 RID: 11861 RVA: 0x00009048 File Offset: 0x00007248
		[Token(Token = "0x6002E55")]
		[Address(RVA = "0x7ED0", Offset = "0x7ED0", VA = "0x7ED0", Slot = "7")]
		public override bool TryGetValue(string tagName, GameEventData evtData, out string value, AbstractTag.TagViewHandler viewHandler)
		{
			return default(bool);
		}

		// Token: 0x06002E56 RID: 11862 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E56")]
		[Address(RVA = "0x7ED1", Offset = "0x7ED1", VA = "0x7ED1")]
		public ClanRatingKingTag_20()
		{
		}

		// Token: 0x0400196B RID: 6507
		[Token(Token = "0x400196B")]
		public const string CLAN_RATING_TYPE = "clan_rating_type";
	}
}
