using System;
using Il2CppDummyDll;

namespace Gameplay.GameEvents.Model.Tags
{
	// Token: 0x020007A9 RID: 1961
	[Token(Token = "0x20007A9")]
	public class Isle_29 : AbstractTag
	{
		// Token: 0x17000902 RID: 2306
		// (get) Token: 0x06002E80 RID: 11904 RVA: 0x00009300 File Offset: 0x00007500
		[Token(Token = "0x17000902")]
		public uint MedalId
		{
			[Token(Token = "0x6002E80")]
			[Address(RVA = "0x7EFB", Offset = "0x7EFB", VA = "0x7EFB")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x06002E81 RID: 11905 RVA: 0x00009318 File Offset: 0x00007518
		[Token(Token = "0x6002E81")]
		[Address(RVA = "0x7EFC", Offset = "0x7EFC", VA = "0x7EFC", Slot = "7")]
		public override bool TryGetValue(string tagName, GameEventData evtData, out string value, AbstractTag.TagViewHandler viewHandler)
		{
			return default(bool);
		}

		// Token: 0x06002E82 RID: 11906 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E82")]
		[Address(RVA = "0x7EFD", Offset = "0x7EFD", VA = "0x7EFD")]
		public Isle_29()
		{
		}

		// Token: 0x0400197B RID: 6523
		[Token(Token = "0x400197B")]
		public const string ISLE_VIEW = "isle_view";

		// Token: 0x0400197C RID: 6524
		[Token(Token = "0x400197C")]
		public const string ISLE_WIDGET_PREFAB = "IsleTagView";
	}
}
