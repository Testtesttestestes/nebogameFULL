using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Com.TheFallenGames.OSA.Core;
using Com.TheFallenGames.OSA.CustomParams;
using Com.TheFallenGames.OSA.DataHelpers;
using Il2CppDummyDll;

namespace Gameplay.Craft.View
{
	// Token: 0x020008AE RID: 2222
	[Token(Token = "0x20008AE")]
	public class CraftRecipesOSAView : OSA<BaseParamsWithPrefab, CraftRecipesViewsHolder>
	{
		// Token: 0x17000A5A RID: 2650
		// (get) Token: 0x06003430 RID: 13360 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003431 RID: 13361 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A5A")]
		public SimpleDataHelper<CraftRecipeListElement.CraftRecipeListElementArgs> Data
		{
			[Token(Token = "0x6003430")]
			[Address(RVA = "0x845D", Offset = "0x845D", VA = "0x845D")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003431")]
			[Address(RVA = "0x845E", Offset = "0x845E", VA = "0x845E")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06003432 RID: 13362 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003432")]
		[Address(RVA = "0x845F", Offset = "0x845F", VA = "0x845F", Slot = "69")]
		protected override void Start()
		{
		}

		// Token: 0x06003433 RID: 13363 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003433")]
		[Address(RVA = "0x8460", Offset = "0x8460", VA = "0x8460", Slot = "99")]
		protected override CraftRecipesViewsHolder CreateViewsHolder(int itemIndex)
		{
			return null;
		}

		// Token: 0x06003434 RID: 13364 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003434")]
		[Address(RVA = "0x8461", Offset = "0x8461", VA = "0x8461", Slot = "100")]
		protected override void UpdateViewsHolder(CraftRecipesViewsHolder newOrRecycled)
		{
		}

		// Token: 0x06003435 RID: 13365 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003435")]
		[Address(RVA = "0x8462", Offset = "0x8462", VA = "0x8462")]
		public void AddItemsAt(int index, IList<CraftRecipeListElement.CraftRecipeListElementArgs> items)
		{
		}

		// Token: 0x06003436 RID: 13366 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003436")]
		[Address(RVA = "0x8463", Offset = "0x8463", VA = "0x8463")]
		public void RemoveItemsFrom(int index, int count)
		{
		}

		// Token: 0x06003437 RID: 13367 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003437")]
		[Address(RVA = "0x8464", Offset = "0x8464", VA = "0x8464")]
		public void SetItems(IList<CraftRecipeListElement.CraftRecipeListElementArgs> items)
		{
		}

		// Token: 0x06003438 RID: 13368 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003438")]
		[Address(RVA = "0x8465", Offset = "0x8465", VA = "0x8465")]
		private void RetrieveDataAndUpdate(int count)
		{
		}

		// Token: 0x06003439 RID: 13369 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003439")]
		[Address(RVA = "0x8466", Offset = "0x8466", VA = "0x8466")]
		private IEnumerator FetchMoreItemsFromDataSourceAndUpdate(int count)
		{
			return null;
		}

		// Token: 0x0600343A RID: 13370 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600343A")]
		[Address(RVA = "0x8467", Offset = "0x8467", VA = "0x8467")]
		private void OnDataRetrieved(CraftRecipeListElement.CraftRecipeListElementArgs[] newItems)
		{
		}

		// Token: 0x0600343B RID: 13371 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600343B")]
		[Address(RVA = "0x8468", Offset = "0x8468", VA = "0x8468")]
		public CraftRecipesOSAView()
		{
		}
	}
}
