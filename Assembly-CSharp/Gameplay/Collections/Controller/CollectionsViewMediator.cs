using System;
using System.Collections.Generic;
using Core.Data;
using Gameplay.Collections.Controller.Filters;
using Gameplay.Collections.Events;
using Gameplay.Collections.Model;
using Gameplay.Collections.View;
using Il2CppDummyDll;
using MVC;
using UI.Filters;

namespace Gameplay.Collections.Controller
{
	// Token: 0x020009E8 RID: 2536
	[Token(Token = "0x20009E8")]
	public class CollectionsViewMediator : AbstractViewMediator<CollectionsModel, CollectionsEvents, CollectionsController, CollectionsWindow>
	{
		// Token: 0x06003C95 RID: 15509 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C95")]
		[Address(RVA = "0x8B5C", Offset = "0x8B5C", VA = "0x8B5C")]
		public CollectionsViewMediator(CollectionsModel model, CollectionsEvents events, CollectionsController controller)
		{
		}

		// Token: 0x17000BEE RID: 3054
		// (set) Token: 0x06003C96 RID: 15510 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BEE")]
		public override CollectionsEvents Events
		{
			[Token(Token = "0x6003C96")]
			[Address(RVA = "0x8B5D", Offset = "0x8B5D", VA = "0x8B5D", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x17000BEF RID: 3055
		// (set) Token: 0x06003C97 RID: 15511 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BEF")]
		public override CollectionsWindow View
		{
			[Token(Token = "0x6003C97")]
			[Address(RVA = "0x8B5E", Offset = "0x8B5E", VA = "0x8B5E", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06003C98 RID: 15512 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C98")]
		[Address(RVA = "0x8B5F", Offset = "0x8B5F", VA = "0x8B5F")]
		private void FrescoButtonClickedHandler()
		{
		}

		// Token: 0x06003C99 RID: 15513 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C99")]
		[Address(RVA = "0x8B60", Offset = "0x8B60", VA = "0x8B60")]
		private void SetFiltersData()
		{
		}

		// Token: 0x06003C9A RID: 15514 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C9A")]
		[Address(RVA = "0x8B61", Offset = "0x8B61", VA = "0x8B61")]
		private void RedrawCurrentTab()
		{
		}

		// Token: 0x06003C9B RID: 15515 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003C9B")]
		[Address(RVA = "0x8B62", Offset = "0x8B62", VA = "0x8B62")]
		private List<CollectionListElement.CollectionListElementArgs> FilterCollections(IList<CollectionListElement.CollectionListElementArgs> rawData)
		{
			return null;
		}

		// Token: 0x06003C9C RID: 15516 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C9C")]
		[Address(RVA = "0x8B63", Offset = "0x8B63", VA = "0x8B63")]
		private void FiltersViewChangedEventHandler()
		{
		}

		// Token: 0x06003C9D RID: 15517 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C9D")]
		[Address(RVA = "0x8B64", Offset = "0x8B64", VA = "0x8B64")]
		private void InitEventHandler()
		{
		}

		// Token: 0x06003C9E RID: 15518 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C9E")]
		[Address(RVA = "0x8B65", Offset = "0x8B65", VA = "0x8B65")]
		private void ShowNextRankEventHandler(CollectionListElement.CollectionListElementArgs args)
		{
		}

		// Token: 0x06003C9F RID: 15519 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C9F")]
		[Address(RVA = "0x8B66", Offset = "0x8B66", VA = "0x8B66")]
		private void ShowCollectionInfoWindow(CollectionData data, uint rank)
		{
		}

		// Token: 0x06003CA0 RID: 15520 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CA0")]
		[Address(RVA = "0x8B67", Offset = "0x8B67", VA = "0x8B67", Slot = "14")]
		public override void Dispose()
		{
		}

		// Token: 0x0400217D RID: 8573
		[Token(Token = "0x400217D")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<FilterInfo.FilterType, ICollectionFilter> _filters;

		// Token: 0x0400217E RID: 8574
		[Token(Token = "0x400217E")]
		[FieldOffset(Offset = "0x1C")]
		private Predicate<CollectionData> _customFilter;
	}
}
