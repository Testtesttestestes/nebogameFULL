using System;
using Il2CppDummyDll;

namespace Gameplay.GameEvents.Model.Tags
{
	// Token: 0x0200079E RID: 1950
	[Token(Token = "0x200079E")]
	public class ColossusTag_39 : AbstractTag
	{
		// Token: 0x170008F4 RID: 2292
		// (get) Token: 0x06002E5E RID: 11870 RVA: 0x000090D8 File Offset: 0x000072D8
		[Token(Token = "0x170008F4")]
		public uint ColossusId
		{
			[Token(Token = "0x6002E5E")]
			[Address(RVA = "0x7ED9", Offset = "0x7ED9", VA = "0x7ED9")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x06002E5F RID: 11871 RVA: 0x000090F0 File Offset: 0x000072F0
		[Token(Token = "0x6002E5F")]
		[Address(RVA = "0x7EDA", Offset = "0x7EDA", VA = "0x7EDA", Slot = "7")]
		public override bool TryGetValue(string tagName, GameEventData evtData, out string value, AbstractTag.TagViewHandler viewHandler)
		{
			return default(bool);
		}

		// Token: 0x06002E60 RID: 11872 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E60")]
		[Address(RVA = "0x7EDB", Offset = "0x7EDB", VA = "0x7EDB")]
		public ColossusTag_39()
		{
		}

		// Token: 0x04001973 RID: 6515
		[Token(Token = "0x4001973")]
		public const string COLOSSUS_TITLE = "colossus_title";

		// Token: 0x04001974 RID: 6516
		[Token(Token = "0x4001974")]
		public const string COLOSSUS_VIEW = "colossus_view";
	}
}
