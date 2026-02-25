using System;
using Il2CppDummyDll;

namespace Gameplay.GameEvents.Model.Tags
{
	// Token: 0x020007B8 RID: 1976
	[Token(Token = "0x20007B8")]
	public class ViewTag_7 : AbstractTag
	{
		// Token: 0x17000914 RID: 2324
		// (get) Token: 0x06002EB0 RID: 11952 RVA: 0x00009600 File Offset: 0x00007800
		[Token(Token = "0x17000914")]
		public uint MedalId
		{
			[Token(Token = "0x6002EB0")]
			[Address(RVA = "0x7F2B", Offset = "0x7F2B", VA = "0x7F2B")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x06002EB1 RID: 11953 RVA: 0x00009618 File Offset: 0x00007818
		[Token(Token = "0x6002EB1")]
		[Address(RVA = "0x7F2C", Offset = "0x7F2C", VA = "0x7F2C", Slot = "7")]
		public override bool TryGetValue(string tagName, GameEventData evtData, out string value, AbstractTag.TagViewHandler viewHandler)
		{
			return default(bool);
		}

		// Token: 0x06002EB2 RID: 11954 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EB2")]
		[Address(RVA = "0x7F2D", Offset = "0x7F2D", VA = "0x7F2D")]
		public ViewTag_7()
		{
		}

		// Token: 0x04001995 RID: 6549
		[Token(Token = "0x4001995")]
		public const string VIEW_TITLE = "view_title";

		// Token: 0x04001996 RID: 6550
		[Token(Token = "0x4001996")]
		public const string VIEW_REWARD = "view_reward";

		// Token: 0x04001997 RID: 6551
		[Token(Token = "0x4001997")]
		public const string VIEW_VIEW = "view_view";

		// Token: 0x04001998 RID: 6552
		[Token(Token = "0x4001998")]
		public const string APR_PREFAB_PATH = "AprTagView";
	}
}
