using System;
using Com.TheFallenGames.OSA.Core;
using Il2CppDummyDll;

namespace Gameplay.Craft.View
{
	// Token: 0x020008B1 RID: 2225
	[Token(Token = "0x20008B1")]
	public class CraftRecipesViewsHolder : BaseItemViewsHolder
	{
		// Token: 0x17000A5D RID: 2653
		// (get) Token: 0x06003443 RID: 13379 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003444 RID: 13380 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A5D")]
		public CraftRecipeListElement.CraftRecipeListElementArgs CraftData
		{
			[Token(Token = "0x6003443")]
			[Address(RVA = "0x8470", Offset = "0x8470", VA = "0x8470")]
			get
			{
				return null;
			}
			[Token(Token = "0x6003444")]
			[Address(RVA = "0x8471", Offset = "0x8471", VA = "0x8471")]
			set
			{
			}
		}

		// Token: 0x06003445 RID: 13381 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003445")]
		[Address(RVA = "0x8472", Offset = "0x8472", VA = "0x8472", Slot = "7")]
		public override void CollectViews()
		{
		}

		// Token: 0x06003446 RID: 13382 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003446")]
		[Address(RVA = "0x8473", Offset = "0x8473", VA = "0x8473")]
		public CraftRecipesViewsHolder()
		{
		}

		// Token: 0x04001C79 RID: 7289
		[Token(Token = "0x4001C79")]
		[FieldOffset(Offset = "0x14")]
		private CraftRecipeListElement _craftRecipeListElement;
	}
}
