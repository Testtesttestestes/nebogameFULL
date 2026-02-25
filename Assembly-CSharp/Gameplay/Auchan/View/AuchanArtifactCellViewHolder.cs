using System;
using System.Collections.Generic;
using Com.TheFallenGames.OSA.CustomAdapters.GridView;
using Gameplay.Auchan.Model;
using Il2CppDummyDll;

namespace Gameplay.Auchan.View
{
	// Token: 0x02000C82 RID: 3202
	[Token(Token = "0x2000C82")]
	public class AuchanArtifactCellViewHolder : CellViewsHolder
	{
		// Token: 0x06004E20 RID: 20000 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E20")]
		[Address(RVA = "0x9C53", Offset = "0x9C53", VA = "0x9C53", Slot = "7")]
		public override void CollectViews()
		{
		}

		// Token: 0x06004E21 RID: 20001 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E21")]
		[Address(RVA = "0x9C54", Offset = "0x9C54", VA = "0x9C54")]
		public void UpdateViews(AuchanArtifactData model, AuchanGridWithCategoriesParams parameters, HashSet<AuchanArtifactData> separatorItems, HashSet<AuchanArtifactData> rowCompletionItems)
		{
		}

		// Token: 0x06004E22 RID: 20002 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E22")]
		[Address(RVA = "0x9C55", Offset = "0x9C55", VA = "0x9C55")]
		public void SetVisible(bool enabled)
		{
		}

		// Token: 0x06004E23 RID: 20003 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E23")]
		[Address(RVA = "0x9C56", Offset = "0x9C56", VA = "0x9C56")]
		public AuchanArtifactCellViewHolder()
		{
		}

		// Token: 0x04002AA9 RID: 10921
		[Token(Token = "0x4002AA9")]
		[FieldOffset(Offset = "0x18")]
		private AuchanArtifactView _itemView;
	}
}
