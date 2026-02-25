using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Com.TheFallenGames.OSA.CustomAdapters.GridView;
using Core.Data;
using Il2CppDummyDll;

namespace Gameplay.Inventory.View.Chest
{
	// Token: 0x0200068B RID: 1675
	[Token(Token = "0x200068B")]
	public class InventoryGridOsaView : GridAdapter<InventoryGridWithCategoriesParams, ArtifactCellViewHolder>
	{
		// Token: 0x170007AC RID: 1964
		// (get) Token: 0x06002878 RID: 10360 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170007AC")]
		public List<ArtifactData> Data
		{
			[Token(Token = "0x6002878")]
			[Address(RVA = "0x7998", Offset = "0x7998", VA = "0x7998")]
			get
			{
				return null;
			}
		}

		// Token: 0x170007AD RID: 1965
		// (get) Token: 0x06002879 RID: 10361 RVA: 0x00007AB8 File Offset: 0x00005CB8
		// (set) Token: 0x0600287A RID: 10362 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007AD")]
		public ArtifactView.ArtifactViewArgs ArtifactViewArgs
		{
			[Token(Token = "0x6002879")]
			[Address(RVA = "0x7999", Offset = "0x7999", VA = "0x7999")]
			[CompilerGenerated]
			get
			{
				return default(ArtifactView.ArtifactViewArgs);
			}
			[Token(Token = "0x600287A")]
			[Address(RVA = "0x799A", Offset = "0x799A", VA = "0x799A")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600287B RID: 10363 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600287B")]
		[Address(RVA = "0x799B", Offset = "0x799B", VA = "0x799B", Slot = "69")]
		protected override void Start()
		{
		}

		// Token: 0x0600287C RID: 10364 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600287C")]
		[Address(RVA = "0x799C", Offset = "0x799C", VA = "0x799C", Slot = "79")]
		public override void Refresh(bool contentPanelEndEdgeStationary = false, bool keepVelocity = false)
		{
		}

		// Token: 0x0600287D RID: 10365 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600287D")]
		[Address(RVA = "0x799D", Offset = "0x799D", VA = "0x799D", Slot = "126")]
		protected override CellGroupViewsHolder<ArtifactCellViewHolder> GetNewCellGroupViewsHolder()
		{
			return null;
		}

		// Token: 0x0600287E RID: 10366 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600287E")]
		[Address(RVA = "0x799E", Offset = "0x799E", VA = "0x799E", Slot = "100")]
		protected override void UpdateViewsHolder(CellGroupViewsHolder<ArtifactCellViewHolder> newOrRecycled)
		{
		}

		// Token: 0x0600287F RID: 10367 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600287F")]
		[Address(RVA = "0x799F", Offset = "0x799F", VA = "0x799F")]
		private string GetCategoryNameByArtifact(ArtifactData artifactData)
		{
			return null;
		}

		// Token: 0x06002880 RID: 10368 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002880")]
		[Address(RVA = "0x79A0", Offset = "0x79A0", VA = "0x79A0", Slot = "128")]
		protected override void UpdateCellViewsHolder(ArtifactCellViewHolder viewsHolder)
		{
		}

		// Token: 0x06002881 RID: 10369 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002881")]
		[Address(RVA = "0x79A1", Offset = "0x79A1", VA = "0x79A1")]
		public void SetData(List<ArtifactCategoryData> categories)
		{
		}

		// Token: 0x06002882 RID: 10370 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002882")]
		[Address(RVA = "0x79A2", Offset = "0x79A2", VA = "0x79A2")]
		private void ConvertCategoriesToListOfItemModels(int itemSlotsPerRow, List<ArtifactCategoryData> categories, out List<ArtifactData> resultList, out Dictionary<ArtifactData, ArtifactCategoryData> categoriesHash)
		{
		}

		// Token: 0x06002883 RID: 10371 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002883")]
		[Address(RVA = "0x79A3", Offset = "0x79A3", VA = "0x79A3")]
		public InventoryGridOsaView()
		{
		}

		// Token: 0x04001655 RID: 5717
		[Token(Token = "0x4001655")]
		[FieldOffset(Offset = "0xB0")]
		private List<ArtifactData> _data;

		// Token: 0x04001656 RID: 5718
		[Token(Token = "0x4001656")]
		[FieldOffset(Offset = "0xB4")]
		private Dictionary<ArtifactData, ArtifactCategoryData> _categoriesByArtifactHash;

		// Token: 0x04001657 RID: 5719
		[Token(Token = "0x4001657")]
		[FieldOffset(Offset = "0xB8")]
		private HashSet<ArtifactData> _categorySeparateItems;

		// Token: 0x04001658 RID: 5720
		[Token(Token = "0x4001658")]
		[FieldOffset(Offset = "0xBC")]
		private HashSet<ArtifactData> _rowCompletionItems;

		// Token: 0x0400165A RID: 5722
		[Token(Token = "0x400165A")]
		[FieldOffset(Offset = "0xCC")]
		private ArtifactView.ArtifactViewArgs _currentArtifactViewArgs;
	}
}
