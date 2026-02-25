using System;
using System.Collections.Generic;
using Com.TheFallenGames.OSA.CustomAdapters.GridView;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.GdEvents.View.EventsList
{
	// Token: 0x0200073D RID: 1853
	[Token(Token = "0x200073D")]
	public class MyCellGroupViewsHolder : CellGroupViewsHolder<MyCellViewsHolder>
	{
		// Token: 0x06002C26 RID: 11302 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C26")]
		[Address(RVA = "0x7CB6", Offset = "0x7CB6", VA = "0x7CB6", Slot = "7")]
		public override void CollectViews()
		{
		}

		// Token: 0x06002C27 RID: 11303 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C27")]
		[Address(RVA = "0x7CB7", Offset = "0x7CB7", VA = "0x7CB7")]
		public void ShowHeader(string text)
		{
		}

		// Token: 0x06002C28 RID: 11304 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C28")]
		[Address(RVA = "0x7CB8", Offset = "0x7CB8", VA = "0x7CB8")]
		public void ClearHeader()
		{
		}

		// Token: 0x06002C29 RID: 11305 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C29")]
		[Address(RVA = "0x7CB9", Offset = "0x7CB9", VA = "0x7CB9")]
		public MyCellGroupViewsHolder()
		{
		}

		// Token: 0x04001834 RID: 6196
		[Token(Token = "0x4001834")]
		[FieldOffset(Offset = "0x24")]
		public ContentSizeFitter contentSizeFitterComponent;

		// Token: 0x04001835 RID: 6197
		[Token(Token = "0x4001835")]
		[FieldOffset(Offset = "0x28")]
		private Transform _HeaderPanel;

		// Token: 0x04001836 RID: 6198
		[Token(Token = "0x4001836")]
		[FieldOffset(Offset = "0x2C")]
		private TextMeshProUGUI _HeaderText;

		// Token: 0x0200073E RID: 1854
		[Token(Token = "0x200073E")]
		public static class GridWithCategoriesDataUtil
		{
			// Token: 0x06002C2A RID: 11306 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6002C2A")]
			[Address(RVA = "0x7CBA", Offset = "0x7CBA", VA = "0x7CBA")]
			private static CellModel CreateItemModelForRowCompletion(CategoryModel parentCategory)
			{
				return null;
			}

			// Token: 0x06002C2B RID: 11307 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6002C2B")]
			[Address(RVA = "0x7CBB", Offset = "0x7CBB", VA = "0x7CBB")]
			private static CellModel CreateItemModelInRowSeparatingCategories(CategoryModel parentCategory)
			{
				return null;
			}

			// Token: 0x06002C2C RID: 11308 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6002C2C")]
			[Address(RVA = "0x7CBC", Offset = "0x7CBC", VA = "0x7CBC")]
			public static List<CellModel> ConvertCategoriesToListOfItemModels(int itemSlotsPerRow, List<CategoryModel> categories)
			{
				return null;
			}
		}
	}
}
