using System;
using Il2CppDummyDll;

namespace Gameplay.GameEvents.Model.Tags
{
	// Token: 0x02000798 RID: 1944
	[Token(Token = "0x2000798")]
	public class ArtikulTag_9 : AbstractTag
	{
		// Token: 0x170008ED RID: 2285
		// (get) Token: 0x06002E4B RID: 11851 RVA: 0x00008FA0 File Offset: 0x000071A0
		[Token(Token = "0x170008ED")]
		public uint ArtikulId
		{
			[Token(Token = "0x6002E4B")]
			[Address(RVA = "0x7EC6", Offset = "0x7EC6", VA = "0x7EC6")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x06002E4C RID: 11852 RVA: 0x00008FB8 File Offset: 0x000071B8
		[Token(Token = "0x6002E4C")]
		[Address(RVA = "0x7EC7", Offset = "0x7EC7", VA = "0x7EC7", Slot = "7")]
		public override bool TryGetValue(string tagName, GameEventData evtData, out string value, AbstractTag.TagViewHandler viewHandler)
		{
			return default(bool);
		}

		// Token: 0x06002E4D RID: 11853 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E4D")]
		[Address(RVA = "0x7EC8", Offset = "0x7EC8", VA = "0x7EC8")]
		public ArtikulTag_9()
		{
		}

		// Token: 0x04001966 RID: 6502
		[Token(Token = "0x4001966")]
		public const string ARTIKUL_TITLE = "artikul_title";

		// Token: 0x04001967 RID: 6503
		[Token(Token = "0x4001967")]
		public const string ARTIKUL_VIEW = "artikul_view";

		// Token: 0x04001968 RID: 6504
		[Token(Token = "0x4001968")]
		public const string VIEW_PREFAB = "ArtikulTagView";
	}
}
