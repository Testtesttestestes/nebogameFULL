using System;
using System.Collections.Generic;
using Com.TheFallenGames.OSA.CustomAdapters.GridView;
using Core.Data;
using DG.Tweening;
using Gameplay.Medals.View;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.Inventory.View.Chest
{
	// Token: 0x02000693 RID: 1683
	[Token(Token = "0x2000693")]
	public class MedalsGridOsaView : GridAdapter<MedalsGridWithCategoriesParams, MedalCellViewHolder>
	{
		// Token: 0x170007B4 RID: 1972
		// (get) Token: 0x060028A8 RID: 10408 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170007B4")]
		public List<MedalData> Data
		{
			[Token(Token = "0x60028A8")]
			[Address(RVA = "0x79C7", Offset = "0x79C7", VA = "0x79C7")]
			get
			{
				return null;
			}
		}

		// Token: 0x060028A9 RID: 10409 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028A9")]
		[Address(RVA = "0x79C8", Offset = "0x79C8", VA = "0x79C8", Slot = "69")]
		protected override void Start()
		{
		}

		// Token: 0x060028AA RID: 10410 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028AA")]
		[Address(RVA = "0x79C9", Offset = "0x79C9", VA = "0x79C9", Slot = "79")]
		public override void Refresh(bool contentPanelEndEdgeStationary = false, bool keepVelocity = false)
		{
		}

		// Token: 0x060028AB RID: 10411 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60028AB")]
		[Address(RVA = "0x79CA", Offset = "0x79CA", VA = "0x79CA", Slot = "126")]
		protected override CellGroupViewsHolder<MedalCellViewHolder> GetNewCellGroupViewsHolder()
		{
			return null;
		}

		// Token: 0x060028AC RID: 10412 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028AC")]
		[Address(RVA = "0x79CB", Offset = "0x79CB", VA = "0x79CB", Slot = "100")]
		protected override void UpdateViewsHolder(CellGroupViewsHolder<MedalCellViewHolder> newOrRecycled)
		{
		}

		// Token: 0x060028AD RID: 10413 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60028AD")]
		[Address(RVA = "0x79CC", Offset = "0x79CC", VA = "0x79CC")]
		private string GetCategoryNameByArtifact(MedalData medalData)
		{
			return null;
		}

		// Token: 0x060028AE RID: 10414 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028AE")]
		[Address(RVA = "0x79CD", Offset = "0x79CD", VA = "0x79CD", Slot = "128")]
		protected override void UpdateCellViewsHolder(MedalCellViewHolder viewsHolder)
		{
		}

		// Token: 0x060028AF RID: 10415 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028AF")]
		[Address(RVA = "0x79CE", Offset = "0x79CE", VA = "0x79CE", Slot = "73")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x060028B0 RID: 10416 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028B0")]
		[Address(RVA = "0x79CF", Offset = "0x79CF", VA = "0x79CF")]
		private void NotifyStencilDelayed()
		{
		}

		// Token: 0x060028B1 RID: 10417 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028B1")]
		[Address(RVA = "0x79D0", Offset = "0x79D0", VA = "0x79D0")]
		public void SetData(List<MedalsCategoryData> categories, UserData user, UserData loggedUser, Action<MedalView> medalViewClickCallback, bool saleEnabled)
		{
		}

		// Token: 0x060028B2 RID: 10418 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028B2")]
		[Address(RVA = "0x79D1", Offset = "0x79D1", VA = "0x79D1")]
		private void ConvertCategoriesToListOfItemModels(int itemSlotsPerRow, List<MedalsCategoryData> categories, out List<MedalData> resultList, out Dictionary<MedalData, MedalsCategoryData> categoriesHash)
		{
		}

		// Token: 0x060028B3 RID: 10419 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028B3")]
		[Address(RVA = "0x79D2", Offset = "0x79D2", VA = "0x79D2")]
		public MedalsGridOsaView()
		{
		}

		// Token: 0x0400166F RID: 5743
		[Token(Token = "0x400166F")]
		[FieldOffset(Offset = "0xB0")]
		private List<MedalData> _data;

		// Token: 0x04001670 RID: 5744
		[Token(Token = "0x4001670")]
		[FieldOffset(Offset = "0xB4")]
		private Dictionary<MedalData, MedalsCategoryData> _categoriesByMedalsHash;

		// Token: 0x04001671 RID: 5745
		[Token(Token = "0x4001671")]
		[FieldOffset(Offset = "0xB8")]
		private HashSet<MedalData> _categorySeparateItems;

		// Token: 0x04001672 RID: 5746
		[Token(Token = "0x4001672")]
		[FieldOffset(Offset = "0xBC")]
		private HashSet<MedalData> _rowCompletionItems;

		// Token: 0x04001673 RID: 5747
		[Token(Token = "0x4001673")]
		[FieldOffset(Offset = "0xC0")]
		public Component MaskOnTop;

		// Token: 0x04001674 RID: 5748
		[Token(Token = "0x4001674")]
		[FieldOffset(Offset = "0xC4")]
		private UserData _loggedUser;

		// Token: 0x04001675 RID: 5749
		[Token(Token = "0x4001675")]
		[FieldOffset(Offset = "0xC8")]
		private UserData _user;

		// Token: 0x04001676 RID: 5750
		[Token(Token = "0x4001676")]
		[FieldOffset(Offset = "0xCC")]
		private Action<MedalView> _medalViewClickCallback;

		// Token: 0x04001677 RID: 5751
		[Token(Token = "0x4001677")]
		[FieldOffset(Offset = "0xD0")]
		private bool _saleEnabled;

		// Token: 0x04001678 RID: 5752
		[Token(Token = "0x4001678")]
		[FieldOffset(Offset = "0xD4")]
		private Tween _delayedCall;
	}
}
