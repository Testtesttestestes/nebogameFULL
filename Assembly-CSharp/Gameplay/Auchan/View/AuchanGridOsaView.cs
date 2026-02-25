using System;
using System.Collections.Generic;
using Com.TheFallenGames.OSA.CustomAdapters.GridView;
using Gameplay.Auchan.Model;
using Il2CppDummyDll;

namespace Gameplay.Auchan.View
{
	// Token: 0x02000C86 RID: 3206
	[Token(Token = "0x2000C86")]
	public class AuchanGridOsaView : GridAdapter<AuchanGridWithCategoriesParams, AuchanArtifactCellViewHolder>
	{
		// Token: 0x17000FD6 RID: 4054
		// (get) Token: 0x06004E2E RID: 20014 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000FD6")]
		public List<AuchanArtifactData> Data
		{
			[Token(Token = "0x6004E2E")]
			[Address(RVA = "0x9C61", Offset = "0x9C61", VA = "0x9C61")]
			get
			{
				return null;
			}
		}

		// Token: 0x06004E2F RID: 20015 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E2F")]
		[Address(RVA = "0x9C62", Offset = "0x9C62", VA = "0x9C62", Slot = "69")]
		protected override void Start()
		{
		}

		// Token: 0x06004E30 RID: 20016 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E30")]
		[Address(RVA = "0x9C63", Offset = "0x9C63", VA = "0x9C63", Slot = "79")]
		public override void Refresh(bool contentPanelEndEdgeStationary = false, bool keepVelocity = false)
		{
		}

		// Token: 0x06004E31 RID: 20017 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004E31")]
		[Address(RVA = "0x9C64", Offset = "0x9C64", VA = "0x9C64", Slot = "126")]
		protected override CellGroupViewsHolder<AuchanArtifactCellViewHolder> GetNewCellGroupViewsHolder()
		{
			return null;
		}

		// Token: 0x06004E32 RID: 20018 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E32")]
		[Address(RVA = "0x9C65", Offset = "0x9C65", VA = "0x9C65", Slot = "100")]
		protected override void UpdateViewsHolder(CellGroupViewsHolder<AuchanArtifactCellViewHolder> newOrRecycled)
		{
		}

		// Token: 0x06004E33 RID: 20019 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004E33")]
		[Address(RVA = "0x9C66", Offset = "0x9C66", VA = "0x9C66")]
		private string GetCategoryNameByArtifact(AuchanArtifactData artifactData)
		{
			return null;
		}

		// Token: 0x06004E34 RID: 20020 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E34")]
		[Address(RVA = "0x9C67", Offset = "0x9C67", VA = "0x9C67", Slot = "128")]
		protected override void UpdateCellViewsHolder(AuchanArtifactCellViewHolder viewsHolder)
		{
		}

		// Token: 0x06004E35 RID: 20021 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E35")]
		[Address(RVA = "0x9C68", Offset = "0x9C68", VA = "0x9C68")]
		public void SetData(List<AuchanArtifactCategoryData> categories)
		{
		}

		// Token: 0x06004E36 RID: 20022 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E36")]
		[Address(RVA = "0x9C69", Offset = "0x9C69", VA = "0x9C69")]
		private void ConvertCategoriesToListOfItemModels(int itemSlotsPerRow, List<AuchanArtifactCategoryData> categories, out List<AuchanArtifactData> resultList, out Dictionary<AuchanArtifactData, AuchanArtifactCategoryData> categoriesHash)
		{
		}

		// Token: 0x06004E37 RID: 20023 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E37")]
		[Address(RVA = "0x9C6A", Offset = "0x9C6A", VA = "0x9C6A")]
		public AuchanGridOsaView()
		{
		}

		// Token: 0x04002AB4 RID: 10932
		[Token(Token = "0x4002AB4")]
		[FieldOffset(Offset = "0xB0")]
		private List<AuchanArtifactData> _data;

		// Token: 0x04002AB5 RID: 10933
		[Token(Token = "0x4002AB5")]
		[FieldOffset(Offset = "0xB4")]
		private Dictionary<AuchanArtifactData, AuchanArtifactCategoryData> _categoriesByArtifactHash;

		// Token: 0x04002AB6 RID: 10934
		[Token(Token = "0x4002AB6")]
		[FieldOffset(Offset = "0xB8")]
		private HashSet<AuchanArtifactData> _categorySeparateItems;

		// Token: 0x04002AB7 RID: 10935
		[Token(Token = "0x4002AB7")]
		[FieldOffset(Offset = "0xBC")]
		private HashSet<AuchanArtifactData> _rowCompletionItems;
	}
}
