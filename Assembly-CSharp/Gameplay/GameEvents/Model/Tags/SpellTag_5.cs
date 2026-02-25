using System;
using Il2CppDummyDll;

namespace Gameplay.GameEvents.Model.Tags
{
	// Token: 0x020007B2 RID: 1970
	[Token(Token = "0x20007B2")]
	public class SpellTag_5 : AbstractTag
	{
		// Token: 0x1700090D RID: 2317
		// (get) Token: 0x06002E9D RID: 11933 RVA: 0x000094C8 File Offset: 0x000076C8
		[Token(Token = "0x1700090D")]
		public uint SpellId
		{
			[Token(Token = "0x6002E9D")]
			[Address(RVA = "0x7F18", Offset = "0x7F18", VA = "0x7F18")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x1700090E RID: 2318
		// (get) Token: 0x06002E9E RID: 11934 RVA: 0x000094E0 File Offset: 0x000076E0
		[Token(Token = "0x1700090E")]
		public uint SpellLevel
		{
			[Token(Token = "0x6002E9E")]
			[Address(RVA = "0x7F19", Offset = "0x7F19", VA = "0x7F19")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x06002E9F RID: 11935 RVA: 0x000094F8 File Offset: 0x000076F8
		[Token(Token = "0x6002E9F")]
		[Address(RVA = "0x7F1A", Offset = "0x7F1A", VA = "0x7F1A", Slot = "7")]
		public override bool TryGetValue(string tagName, GameEventData evtData, out string value, AbstractTag.TagViewHandler viewHandler)
		{
			return default(bool);
		}

		// Token: 0x06002EA0 RID: 11936 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EA0")]
		[Address(RVA = "0x7F1B", Offset = "0x7F1B", VA = "0x7F1B")]
		public SpellTag_5()
		{
		}

		// Token: 0x04001989 RID: 6537
		[Token(Token = "0x4001989")]
		public const string SPELL_TITLE = "spell_title";

		// Token: 0x0400198A RID: 6538
		[Token(Token = "0x400198A")]
		public const string SPELL_LEVEL = "spell_level";

		// Token: 0x0400198B RID: 6539
		[Token(Token = "0x400198B")]
		public const string SPELL_VIEW = "spell_view";

		// Token: 0x0400198C RID: 6540
		[Token(Token = "0x400198C")]
		public const string SPELL_VIEW_PREFAB = "SpellTagView";
	}
}
