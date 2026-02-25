using System;
using Il2CppDummyDll;

namespace Gameplay.GameEvents.Model.Tags
{
	// Token: 0x020007B7 RID: 1975
	[Token(Token = "0x20007B7")]
	public class UserRatingTypeTag_19 : AbstractTag
	{
		// Token: 0x17000913 RID: 2323
		// (get) Token: 0x06002EAD RID: 11949 RVA: 0x000095D0 File Offset: 0x000077D0
		[Token(Token = "0x17000913")]
		public uint RatingKindId
		{
			[Token(Token = "0x6002EAD")]
			[Address(RVA = "0x7F28", Offset = "0x7F28", VA = "0x7F28")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x06002EAE RID: 11950 RVA: 0x000095E8 File Offset: 0x000077E8
		[Token(Token = "0x6002EAE")]
		[Address(RVA = "0x7F29", Offset = "0x7F29", VA = "0x7F29", Slot = "7")]
		public override bool TryGetValue(string tagName, GameEventData evtData, out string value, AbstractTag.TagViewHandler viewHandler)
		{
			return default(bool);
		}

		// Token: 0x06002EAF RID: 11951 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EAF")]
		[Address(RVA = "0x7F2A", Offset = "0x7F2A", VA = "0x7F2A")]
		public UserRatingTypeTag_19()
		{
		}

		// Token: 0x04001994 RID: 6548
		[Token(Token = "0x4001994")]
		public const string USER_RATING_TYPE = "user_rating_type";
	}
}
