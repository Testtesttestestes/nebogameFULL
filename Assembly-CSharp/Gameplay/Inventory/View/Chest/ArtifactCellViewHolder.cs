using System;
using System.Collections.Generic;
using Com.TheFallenGames.OSA.CustomAdapters.GridView;
using Core.Data;
using Il2CppDummyDll;

namespace Gameplay.Inventory.View.Chest
{
	// Token: 0x02000682 RID: 1666
	[Token(Token = "0x2000682")]
	public class ArtifactCellViewHolder : CellViewsHolder
	{
		// Token: 0x06002854 RID: 10324 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002854")]
		[Address(RVA = "0x7974", Offset = "0x7974", VA = "0x7974", Slot = "7")]
		public override void CollectViews()
		{
		}

		// Token: 0x06002855 RID: 10325 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002855")]
		[Address(RVA = "0x7975", Offset = "0x7975", VA = "0x7975")]
		public void UpdateViews(ArtifactData model, InventoryGridWithCategoriesParams parameters, HashSet<ArtifactData> separatorItems, HashSet<ArtifactData> rowCompletionItems, ArtifactView.ArtifactViewArgs artifactViewArgs)
		{
		}

		// Token: 0x06002856 RID: 10326 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002856")]
		[Address(RVA = "0x7976", Offset = "0x7976", VA = "0x7976")]
		private void SetVisible(bool enabled)
		{
		}

		// Token: 0x06002857 RID: 10327 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002857")]
		[Address(RVA = "0x7977", Offset = "0x7977", VA = "0x7977")]
		public ArtifactCellViewHolder()
		{
		}

		// Token: 0x0400163F RID: 5695
		[Token(Token = "0x400163F")]
		[FieldOffset(Offset = "0x18")]
		private ArtifactView _itemView;
	}
}
