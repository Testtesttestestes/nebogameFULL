using System;
using System.Runtime.CompilerServices;
using Gameplay.Inventory.View.Chest;
using Il2CppDummyDll;
using JetBrains.Annotations;
using UI.Tabs;

namespace UI.Inventory
{
	// Token: 0x0200025E RID: 606
	[Token(Token = "0x200025E")]
	public class InventorySubcategoriesTabBarItemData : TabBarItemData
	{
		// Token: 0x170001FB RID: 507
		// (get) Token: 0x06000EA3 RID: 3747 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000EA4 RID: 3748 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001FB")]
		[NotNull]
		public ArtifactCategoryData ArtifactCategoryData
		{
			[Token(Token = "0x6000EA3")]
			[Address(RVA = "0x6123", Offset = "0x6123", VA = "0x6123")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000EA4")]
			[Address(RVA = "0x6124", Offset = "0x6124", VA = "0x6124")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06000EA5 RID: 3749 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EA5")]
		[Address(RVA = "0x6125", Offset = "0x6125", VA = "0x6125")]
		public InventorySubcategoriesTabBarItemData([NotNull] ArtifactCategoryData artifactCategoryData)
		{
		}
	}
}
