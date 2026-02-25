using System;
using Il2CppDummyDll;

namespace Gameplay.GameEvents.Model.Tags
{
	// Token: 0x0200079C RID: 1948
	[Token(Token = "0x200079C")]
	public class CollectionPartTag_46 : AbstractTag
	{
		// Token: 0x170008F1 RID: 2289
		// (get) Token: 0x06002E57 RID: 11863 RVA: 0x00009060 File Offset: 0x00007260
		[Token(Token = "0x170008F1")]
		public uint MedalId
		{
			[Token(Token = "0x6002E57")]
			[Address(RVA = "0x7ED2", Offset = "0x7ED2", VA = "0x7ED2")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x06002E58 RID: 11864 RVA: 0x00009078 File Offset: 0x00007278
		[Token(Token = "0x6002E58")]
		[Address(RVA = "0x7ED3", Offset = "0x7ED3", VA = "0x7ED3", Slot = "7")]
		public override bool TryGetValue(string tagName, GameEventData evtData, out string value, AbstractTag.TagViewHandler viewHandler)
		{
			return default(bool);
		}

		// Token: 0x06002E59 RID: 11865 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E59")]
		[Address(RVA = "0x7ED4", Offset = "0x7ED4", VA = "0x7ED4")]
		public CollectionPartTag_46()
		{
		}

		// Token: 0x0400196C RID: 6508
		[Token(Token = "0x400196C")]
		public const string COLLECTION_PART_VIEW = "collection_part_view";

		// Token: 0x0400196D RID: 6509
		[Token(Token = "0x400196D")]
		public const string APPR_SMALL_VIEW_PREFAB = "AprSmallTagView";

		// Token: 0x0400196E RID: 6510
		[Token(Token = "0x400196E")]
		public const string MEDAL_VIEW_PREFAB = "MedalTagView";
	}
}
