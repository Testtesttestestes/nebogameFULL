using System;
using System.Collections.Generic;
using Core.Data;
using Gameplay.Inventory.Controller.Filters;
using Gameplay.Inventory.Events;
using Gameplay.Inventory.Model;
using Gameplay.Inventory.Model.Tabs;
using Gameplay.Inventory.View.Chest;
using Il2CppDummyDll;
using MVC;
using UI.Filters;
using UI.Tabs;

namespace Gameplay.Inventory.Controller
{
	// Token: 0x020006B5 RID: 1717
	[Token(Token = "0x20006B5")]
	public abstract class InventoryBaseViewMediator<M, E, C, V> : AbstractViewMediator<M, E, C, V> where M : InventoryBaseModel where E : InventoryBaseEvents where C : InventoryBaseController<M, E> where V : InventoryChestWindow
	{
		// Token: 0x0600298D RID: 10637 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600298D")]
		public InventoryBaseViewMediator(M model, E events, C controller)
		{
		}

		// Token: 0x170007DF RID: 2015
		// (set) Token: 0x0600298E RID: 10638 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007DF")]
		public override E Events
		{
			[Token(Token = "0x600298E")]
			set
			{
			}
		}

		// Token: 0x170007E0 RID: 2016
		// (set) Token: 0x0600298F RID: 10639 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007E0")]
		public override V View
		{
			[Token(Token = "0x600298F")]
			set
			{
			}
		}

		// Token: 0x06002990 RID: 10640
		[Token(Token = "0x6002990")]
		protected abstract void BuySlotClickHandler();

		// Token: 0x06002991 RID: 10641 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002991")]
		private void RenderSlotsCountInfo()
		{
		}

		// Token: 0x06002992 RID: 10642
		[Token(Token = "0x6002992")]
		protected abstract void RenderSlotsPrice();

		// Token: 0x06002993 RID: 10643 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002993")]
		private void FiltersViewOnChangedEvent()
		{
		}

		// Token: 0x06002994 RID: 10644 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002994")]
		private void SetFiltersData()
		{
		}

		// Token: 0x06002995 RID: 10645 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002995")]
		private void ViewOnChestClosedEvent()
		{
		}

		// Token: 0x170007E1 RID: 2017
		// (get) Token: 0x06002996 RID: 10646 RVA: 0x00007E48 File Offset: 0x00006048
		[Token(Token = "0x170007E1")]
		private bool IsAnyFilterEnabled
		{
			[Token(Token = "0x6002996")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06002997 RID: 10647 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002997")]
		private IList<ArtifactData> FilterArtifacts(IList<ArtifactData> rawData)
		{
			return null;
		}

		// Token: 0x06002998 RID: 10648 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002998")]
		private List<ArtifactCategoryData> GetArtikulTypeGroupedData(TabBarItemData<InventoryTabData> currentTab)
		{
			return null;
		}

		// Token: 0x06002999 RID: 10649 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002999")]
		protected void RedrawCurrentTab()
		{
		}

		// Token: 0x0600299A RID: 10650 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600299A")]
		protected void TabBarOnChangeEvent()
		{
		}

		// Token: 0x0600299B RID: 10651 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600299B")]
		protected void InventoryChangedEventHandler()
		{
		}

		// Token: 0x0600299C RID: 10652 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600299C")]
		private List<TabBarItemData<InventoryTabData>> GetCurrentTabs()
		{
			return null;
		}

		// Token: 0x0600299D RID: 10653 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600299D")]
		private List<InventoryMetaFilterData> GetCurrentAvailableArtikulMetaFilters()
		{
			return null;
		}

		// Token: 0x0600299E RID: 10654 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600299E")]
		private void ValidateTabsOnInventoryChanged()
		{
		}

		// Token: 0x0600299F RID: 10655 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600299F")]
		private void ValidateCounters()
		{
		}

		// Token: 0x060029A0 RID: 10656 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029A0")]
		private void SelectDefaultTab()
		{
		}

		// Token: 0x0400171E RID: 5918
		[Token(Token = "0x400171E")]
		[FieldOffset(Offset = "0x0")]
		private Dictionary<FilterInfo.FilterType, IArtifactFilter> _filters;
	}
}
