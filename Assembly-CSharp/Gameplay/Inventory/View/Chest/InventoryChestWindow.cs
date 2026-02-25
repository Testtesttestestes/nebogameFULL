using System;
using System.Runtime.CompilerServices;
using Gameplay.Inventory.View.Bag;
using Il2CppDummyDll;
using Protocol.Dic;
using UI.Filters;
using UI.Tabs;
using UI.Windows;
using UnityEngine;

namespace Gameplay.Inventory.View.Chest
{
	// Token: 0x02000684 RID: 1668
	[Token(Token = "0x2000684")]
	public abstract class InventoryChestWindow : ClosableBaseWindow<InventoryChestWindowOptions>
	{
		// Token: 0x170007A6 RID: 1958
		// (get) Token: 0x0600285B RID: 10331 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170007A6")]
		public ChestSlotsInfoView ChestSlotsInfoView
		{
			[Token(Token = "0x600285B")]
			[Address(RVA = "0x797B", Offset = "0x797B", VA = "0x797B")]
			get
			{
				return null;
			}
		}

		// Token: 0x14000156 RID: 342
		// (add) Token: 0x0600285C RID: 10332 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600285D RID: 10333 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000156")]
		public event Action ChestClosedEvent
		{
			[Token(Token = "0x600285C")]
			[Address(RVA = "0x797C", Offset = "0x797C", VA = "0x797C")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600285D")]
			[Address(RVA = "0x797D", Offset = "0x797D", VA = "0x797D")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x170007A7 RID: 1959
		// (get) Token: 0x0600285E RID: 10334 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170007A7")]
		public TabBar TabBarView
		{
			[Token(Token = "0x600285E")]
			[Address(RVA = "0x797E", Offset = "0x797E", VA = "0x797E")]
			get
			{
				return null;
			}
		}

		// Token: 0x170007A8 RID: 1960
		// (get) Token: 0x0600285F RID: 10335 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170007A8")]
		public FiltersView FiltersView
		{
			[Token(Token = "0x600285F")]
			[Address(RVA = "0x797F", Offset = "0x797F", VA = "0x797F")]
			get
			{
				return null;
			}
		}

		// Token: 0x170007A9 RID: 1961
		// (get) Token: 0x06002860 RID: 10336 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170007A9")]
		public InventoryBagView UserBag
		{
			[Token(Token = "0x6002860")]
			[Address(RVA = "0x7980", Offset = "0x7980", VA = "0x7980")]
			get
			{
				return null;
			}
		}

		// Token: 0x170007AA RID: 1962
		// (get) Token: 0x06002861 RID: 10337 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170007AA")]
		public InventoryGridView InventoryGridView
		{
			[Token(Token = "0x6002861")]
			[Address(RVA = "0x7981", Offset = "0x7981", VA = "0x7981")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002862 RID: 10338 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002862")]
		[Address(RVA = "0x7982", Offset = "0x7982", VA = "0x7982", Slot = "22")]
		protected override void OnShow(InventoryChestWindowOptions args)
		{
		}

		// Token: 0x06002863 RID: 10339 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002863")]
		[Address(RVA = "0x7983", Offset = "0x7983", VA = "0x7983")]
		private void ArtifactContextMenuOnActionHandledEvent(ArtikulMenuActionDic.Types.Actions action)
		{
		}

		// Token: 0x06002864 RID: 10340 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002864")]
		[Address(RVA = "0x7984", Offset = "0x7984", VA = "0x7984", Slot = "19")]
		protected override void OnClose()
		{
		}

		// Token: 0x06002865 RID: 10341 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002865")]
		[Address(RVA = "0x7985", Offset = "0x7985", VA = "0x7985")]
		protected InventoryChestWindow()
		{
		}

		// Token: 0x04001642 RID: 5698
		[Token(Token = "0x4001642")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		protected TabBar _tabBarView;

		// Token: 0x04001643 RID: 5699
		[Token(Token = "0x4001643")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		protected InventoryBagView _userBag;

		// Token: 0x04001644 RID: 5700
		[Token(Token = "0x4001644")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		protected InventoryGridView _inventoryGridView;

		// Token: 0x04001645 RID: 5701
		[Token(Token = "0x4001645")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		protected FiltersView _filtersView;

		// Token: 0x04001646 RID: 5702
		[Token(Token = "0x4001646")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		protected ChestSlotsInfoView _chestSlotsInfoView;
	}
}
