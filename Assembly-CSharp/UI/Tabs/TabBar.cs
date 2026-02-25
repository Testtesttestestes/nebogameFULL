using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;

namespace UI.Tabs
{
	// Token: 0x02000179 RID: 377
	[Token(Token = "0x2000179")]
	public class TabBar : MonoBehaviour
	{
		// Token: 0x140000DC RID: 220
		// (add) Token: 0x06000A94 RID: 2708 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000A95 RID: 2709 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000DC")]
		public event Action ChangeEvent
		{
			[Token(Token = "0x6000A94")]
			[Address(RVA = "0x5DDF", Offset = "0x5DDF", VA = "0x5DDF")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000A95")]
			[Address(RVA = "0x5DE0", Offset = "0x5DE0", VA = "0x5DE0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x06000A96 RID: 2710 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000163")]
		public IList<TabBarItemData> Data
		{
			[Token(Token = "0x6000A96")]
			[Address(RVA = "0x5DE1", Offset = "0x5DE1", VA = "0x5DE1")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x06000A97 RID: 2711 RVA: 0x00003990 File Offset: 0x00001B90
		[Token(Token = "0x17000164")]
		public int SelectedIndex
		{
			[Token(Token = "0x6000A97")]
			[Address(RVA = "0x5DE2", Offset = "0x5DE2", VA = "0x5DE2")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x06000A98 RID: 2712 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000165")]
		public TabBarItemData SelectedItem
		{
			[Token(Token = "0x6000A98")]
			[Address(RVA = "0x5DE3", Offset = "0x5DE3", VA = "0x5DE3")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000A99 RID: 2713 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A99")]
		[Address(RVA = "0x5DE4", Offset = "0x5DE4", VA = "0x5DE4", Slot = "4")]
		protected virtual void OnDestroy()
		{
		}

		// Token: 0x06000A9A RID: 2714 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A9A")]
		[Address(RVA = "0x5DE5", Offset = "0x5DE5", VA = "0x5DE5")]
		private void Awake()
		{
		}

		// Token: 0x06000A9B RID: 2715 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A9B")]
		[Address(RVA = "0x5DE6", Offset = "0x5DE6", VA = "0x5DE6")]
		private void NextButtonClicked()
		{
		}

		// Token: 0x06000A9C RID: 2716 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A9C")]
		[Address(RVA = "0x5DE7", Offset = "0x5DE7", VA = "0x5DE7")]
		private void PrevButtonClicked()
		{
		}

		// Token: 0x06000A9D RID: 2717 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A9D")]
		[Address(RVA = "0x5DE8", Offset = "0x5DE8", VA = "0x5DE8")]
		private void EnsureSelectedIsVisible()
		{
		}

		// Token: 0x06000A9E RID: 2718 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A9E")]
		[Address(RVA = "0x5DE9", Offset = "0x5DE9", VA = "0x5DE9")]
		private void ItemOnSelectEvent(TabBarItemData itemData)
		{
		}

		// Token: 0x06000A9F RID: 2719 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A9F")]
		[Address(RVA = "0x5DEA", Offset = "0x5DEA", VA = "0x5DEA")]
		private void Clear()
		{
		}

		// Token: 0x06000AA0 RID: 2720 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AA0")]
		[Address(RVA = "0x5DEB", Offset = "0x5DEB", VA = "0x5DEB", Slot = "5")]
		protected virtual void ResetView()
		{
		}

		// Token: 0x06000AA1 RID: 2721 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AA1")]
		[Address(RVA = "0x5DEC", Offset = "0x5DEC", VA = "0x5DEC", Slot = "6")]
		protected virtual void HandleSelected()
		{
		}

		// Token: 0x06000AA2 RID: 2722 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AA2")]
		[Address(RVA = "0x5DED", Offset = "0x5DED", VA = "0x5DED")]
		public void Init([NotNull] IEnumerable<TabBarItemData> data)
		{
		}

		// Token: 0x06000AA3 RID: 2723 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AA3")]
		[Address(RVA = "0x5DEE", Offset = "0x5DEE", VA = "0x5DEE")]
		public void SelectByItem(TabBarItemData item)
		{
		}

		// Token: 0x06000AA4 RID: 2724 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AA4")]
		[Address(RVA = "0x1ACE", Offset = "0x1ACE", VA = "0x1ACE")]
		public void SelectByIndex(int index, bool silent = false)
		{
		}

		// Token: 0x06000AA5 RID: 2725 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000AA5")]
		[Address(RVA = "0x5DEF", Offset = "0x5DEF", VA = "0x5DEF")]
		public TabBarItemData GetItem(int index)
		{
			return null;
		}

		// Token: 0x06000AA6 RID: 2726 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000AA6")]
		public TabBarItemData<T> GetItem<T>(T value)
		{
			return null;
		}

		// Token: 0x06000AA7 RID: 2727 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000AA7")]
		public TabBarItemData<T> GetSelectedItem<T>()
		{
			return null;
		}

		// Token: 0x06000AA8 RID: 2728 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AA8")]
		[Address(RVA = "0x5DF0", Offset = "0x5DF0", VA = "0x5DF0")]
		public TabBar()
		{
		}

		// Token: 0x040004A6 RID: 1190
		[Token(Token = "0x40004A6")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private GameObject _itemPrefab;

		// Token: 0x040004A7 RID: 1191
		[Token(Token = "0x40004A7")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _separatorPrefab;

		// Token: 0x040004A8 RID: 1192
		[Token(Token = "0x40004A8")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private Transform _container;

		// Token: 0x040004A9 RID: 1193
		[Token(Token = "0x40004A9")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _viewport;

		// Token: 0x040004AA RID: 1194
		[Token(Token = "0x40004AA")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private ScrollRect _scrollRect;

		// Token: 0x040004AB RID: 1195
		[Token(Token = "0x40004AB")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Button _prevButton;

		// Token: 0x040004AC RID: 1196
		[Token(Token = "0x40004AC")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private Button _nextButton;

		// Token: 0x040004AD RID: 1197
		[Token(Token = "0x40004AD")]
		[FieldOffset(Offset = "0x30")]
		private ITabBarItemView _selectedItem;

		// Token: 0x040004AE RID: 1198
		[Token(Token = "0x40004AE")]
		[FieldOffset(Offset = "0x34")]
		private RectTransform _containerRectTransform;

		// Token: 0x040004AF RID: 1199
		[Token(Token = "0x40004AF")]
		[FieldOffset(Offset = "0x38")]
		private RectTransform _viewportRectTransform;

		// Token: 0x040004B0 RID: 1200
		[Token(Token = "0x40004B0")]
		[FieldOffset(Offset = "0x3C")]
		private int _selectedIndex;

		// Token: 0x040004B1 RID: 1201
		[Token(Token = "0x40004B1")]
		[FieldOffset(Offset = "0x40")]
		private readonly List<TabBarItemData> _data;

		// Token: 0x040004B2 RID: 1202
		[Token(Token = "0x40004B2")]
		[FieldOffset(Offset = "0x44")]
		protected readonly List<ITabBarItemView> _items;
	}
}
