using System;
using System.Collections.Generic;
using Gameplay.Inventory.Model.Tabs;
using Il2CppDummyDll;
using UI.ContextMenu;
using UI.Tabs;
using UnityEngine;

namespace Gameplay.Inventory.View.Chest
{
	// Token: 0x0200068F RID: 1679
	[Token(Token = "0x200068F")]
	public class InventoryGridView : MonoBehaviour
	{
		// Token: 0x170007AE RID: 1966
		// (set) Token: 0x0600288B RID: 10379 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007AE")]
		public ArtifactView.ArtifactViewArgs ArtifactViewArgs
		{
			[Token(Token = "0x600288B")]
			[Address(RVA = "0x79AA", Offset = "0x79AA", VA = "0x79AA")]
			set
			{
			}
		}

		// Token: 0x0600288C RID: 10380 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600288C")]
		[Address(RVA = "0x79AB", Offset = "0x79AB", VA = "0x79AB")]
		private void ContextMenuControllerOnContextMenuShowEvent(IBaseContextMenu obj)
		{
		}

		// Token: 0x0600288D RID: 10381 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600288D")]
		[Address(RVA = "0x79AC", Offset = "0x79AC", VA = "0x79AC")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600288E RID: 10382 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600288E")]
		[Address(RVA = "0x79AD", Offset = "0x79AD", VA = "0x79AD")]
		private void Start()
		{
		}

		// Token: 0x0600288F RID: 10383 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600288F")]
		[Address(RVA = "0x79AE", Offset = "0x79AE", VA = "0x79AE")]
		private void TabBarOnChangeEvent()
		{
		}

		// Token: 0x06002890 RID: 10384 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002890")]
		[Address(RVA = "0x79AF", Offset = "0x79AF", VA = "0x79AF")]
		public void SetData(List<ArtifactCategoryData> data)
		{
		}

		// Token: 0x06002891 RID: 10385 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002891")]
		[Address(RVA = "0x79B0", Offset = "0x79B0", VA = "0x79B0")]
		private void RenderCategories()
		{
		}

		// Token: 0x06002892 RID: 10386 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002892")]
		[Address(RVA = "0x79B1", Offset = "0x79B1", VA = "0x79B1")]
		private void ScrollToCategory(ArtifactCategoryData cat)
		{
		}

		// Token: 0x06002893 RID: 10387 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002893")]
		[Address(RVA = "0x79B2", Offset = "0x79B2", VA = "0x79B2")]
		public void SelectDefaultTab()
		{
		}

		// Token: 0x06002894 RID: 10388 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002894")]
		[Address(RVA = "0x79B3", Offset = "0x79B3", VA = "0x79B3")]
		public InventoryGridView()
		{
		}

		// Token: 0x04001663 RID: 5731
		[Token(Token = "0x4001663")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TabBar _tabBar;

		// Token: 0x04001664 RID: 5732
		[Token(Token = "0x4001664")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private InventoryGridOsaView _inventoryGridOsaView;

		// Token: 0x04001665 RID: 5733
		[Token(Token = "0x4001665")]
		[FieldOffset(Offset = "0x18")]
		private List<ArtifactCategoryData> _categories;

		// Token: 0x04001666 RID: 5734
		[Token(Token = "0x4001666")]
		[FieldOffset(Offset = "0x1C")]
		private InventoryTabData _currentTab;
	}
}
