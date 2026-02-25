using System;
using Il2CppDummyDll;

namespace Gameplay.GameEvents.Model.Tags
{
	// Token: 0x0200079D RID: 1949
	[Token(Token = "0x200079D")]
	public class CollectionsTag_33 : AbstractTag
	{
		// Token: 0x170008F2 RID: 2290
		// (get) Token: 0x06002E5A RID: 11866 RVA: 0x00009090 File Offset: 0x00007290
		[Token(Token = "0x170008F2")]
		public uint CollectionId
		{
			[Token(Token = "0x6002E5A")]
			[Address(RVA = "0x7ED5", Offset = "0x7ED5", VA = "0x7ED5")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x170008F3 RID: 2291
		// (get) Token: 0x06002E5B RID: 11867 RVA: 0x000090A8 File Offset: 0x000072A8
		[Token(Token = "0x170008F3")]
		public uint Rank
		{
			[Token(Token = "0x6002E5B")]
			[Address(RVA = "0x7ED6", Offset = "0x7ED6", VA = "0x7ED6")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x06002E5C RID: 11868 RVA: 0x000090C0 File Offset: 0x000072C0
		[Token(Token = "0x6002E5C")]
		[Address(RVA = "0x7ED7", Offset = "0x7ED7", VA = "0x7ED7", Slot = "7")]
		public override bool TryGetValue(string tagName, GameEventData evtData, out string value, AbstractTag.TagViewHandler viewHandler)
		{
			return default(bool);
		}

		// Token: 0x06002E5D RID: 11869 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E5D")]
		[Address(RVA = "0x7ED8", Offset = "0x7ED8", VA = "0x7ED8")]
		public CollectionsTag_33()
		{
		}

		// Token: 0x0400196F RID: 6511
		[Token(Token = "0x400196F")]
		public const string COLLECTION_TITLE = "collection_title";

		// Token: 0x04001970 RID: 6512
		[Token(Token = "0x4001970")]
		public const string COLLECTION_RANK = "collection_rank";

		// Token: 0x04001971 RID: 6513
		[Token(Token = "0x4001971")]
		public const string COLLECTION_VIEW = "collection_view";

		// Token: 0x04001972 RID: 6514
		[Token(Token = "0x4001972")]
		public const string VIEW_PREFAB = "CollectionTagView";
	}
}
