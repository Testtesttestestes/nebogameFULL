using System;
using Gameplay.Auchan.View;
using Il2CppDummyDll;
using UI.Tabs;

namespace Gameplay.Auchan.UI
{
	// Token: 0x02000C7F RID: 3199
	[Token(Token = "0x2000C7F")]
	public class AuchanSubcategoriesTabBarItemData : TabBarItemData
	{
		// Token: 0x06004E18 RID: 19992 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E18")]
		[Address(RVA = "0x9C4B", Offset = "0x9C4B", VA = "0x9C4B")]
		public AuchanSubcategoriesTabBarItemData()
		{
		}

		// Token: 0x04002A99 RID: 10905
		[Token(Token = "0x4002A99")]
		[FieldOffset(Offset = "0x20")]
		public AuchanArtifactCategoryData ArtifactCategoryData;
	}
}
