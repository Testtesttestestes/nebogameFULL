using System;
using System.Runtime.CompilerServices;
using Gameplay.Tutorial.Guide.Model.Data;
using Il2CppDummyDll;
using TMPro;
using UI.Elements.Counters;
using UnityEngine;
using UnityEngine.EventSystems;

namespace UI.Tabs
{
	// Token: 0x0200017D RID: 381
	[Token(Token = "0x200017D")]
	public class TabBarItemView : MonoBehaviourWithStates<TabBarItemData.State>, IPointerClickHandler, IEventSystemHandler, ITabBarItemView
	{
		// Token: 0x1700016C RID: 364
		// (get) Token: 0x06000ABC RID: 2748 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700016C")]
		public IGuideTarget GuideTarget
		{
			[Token(Token = "0x6000ABC")]
			[Address(RVA = "0x5DFD", Offset = "0x5DFD", VA = "0x5DFD")]
			get
			{
				return null;
			}
		}

		// Token: 0x140000DE RID: 222
		// (add) Token: 0x06000ABD RID: 2749 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000ABE RID: 2750 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000DE")]
		public event Action<TabBarItemData> SelectEvent
		{
			[Token(Token = "0x6000ABD")]
			[Address(RVA = "0x5DFE", Offset = "0x5DFE", VA = "0x5DFE", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000ABE")]
			[Address(RVA = "0x5DFF", Offset = "0x5DFF", VA = "0x5DFF", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x06000ABF RID: 2751 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000AC0 RID: 2752 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700016D")]
		public TabBarItemData Data
		{
			[Token(Token = "0x6000ABF")]
			[Address(RVA = "0x5E00", Offset = "0x5E00", VA = "0x5E00", Slot = "10")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000AC0")]
			[Address(RVA = "0x5E01", Offset = "0x5E01", VA = "0x5E01", Slot = "11")]
			set
			{
			}
		}

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x06000AC1 RID: 2753 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700016E")]
		public GameObject GameObject
		{
			[Token(Token = "0x6000AC1")]
			[Address(RVA = "0x5E02", Offset = "0x5E02", VA = "0x5E02", Slot = "12")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000AC2 RID: 2754 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AC2")]
		[Address(RVA = "0x5E03", Offset = "0x5E03", VA = "0x5E03")]
		private void HandleDataChanged(TabBarItemData from, TabBarItemData to)
		{
		}

		// Token: 0x06000AC3 RID: 2755 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AC3")]
		[Address(RVA = "0x5E04", Offset = "0x5E04", VA = "0x5E04")]
		private void HandleAnimation(TabBarItemData data)
		{
		}

		// Token: 0x06000AC4 RID: 2756 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AC4")]
		[Address(RVA = "0x5E05", Offset = "0x5E05", VA = "0x5E05")]
		private void HandleOnCountChangedEvent(int count)
		{
		}

		// Token: 0x06000AC5 RID: 2757 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AC5")]
		[Address(RVA = "0x5E06", Offset = "0x5E06", VA = "0x5E06", Slot = "13")]
		protected virtual void DisplayCount(int count)
		{
		}

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x06000AC6 RID: 2758 RVA: 0x00003A08 File Offset: 0x00001C08
		// (set) Token: 0x06000AC7 RID: 2759 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700016F")]
		public bool Selected
		{
			[Token(Token = "0x6000AC6")]
			[Address(RVA = "0x5E07", Offset = "0x5E07", VA = "0x5E07", Slot = "8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000AC7")]
			[Address(RVA = "0x5E08", Offset = "0x5E08", VA = "0x5E08", Slot = "9")]
			set
			{
			}
		}

		// Token: 0x06000AC8 RID: 2760 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AC8")]
		[Address(RVA = "0x5E09", Offset = "0x5E09", VA = "0x5E09", Slot = "5")]
		public void OnPointerClick(PointerEventData eventData)
		{
		}

		// Token: 0x06000AC9 RID: 2761 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AC9")]
		[Address(RVA = "0x5E0A", Offset = "0x5E0A", VA = "0x5E0A")]
		public void OnDestroy()
		{
		}

		// Token: 0x06000ACA RID: 2762 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000ACA")]
		[Address(RVA = "0x5E0B", Offset = "0x5E0B", VA = "0x5E0B")]
		public TabBarItemView()
		{
		}

		// Token: 0x040004BE RID: 1214
		[Token(Token = "0x40004BE")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private TextMeshProUGUI _label;

		// Token: 0x040004BF RID: 1215
		[Token(Token = "0x40004BF")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Color _fontColorSelected;

		// Token: 0x040004C0 RID: 1216
		[Token(Token = "0x40004C0")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Color _fontColorDefault;

		// Token: 0x040004C1 RID: 1217
		[Token(Token = "0x40004C1")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private CounterAutoHide _counter;

		// Token: 0x040004C2 RID: 1218
		[Token(Token = "0x40004C2")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private GameObject _animation;

		// Token: 0x040004C3 RID: 1219
		[Token(Token = "0x40004C3")]
		[FieldOffset(Offset = "0x48")]
		private IGuideTarget _guideTarget;

		// Token: 0x040004C5 RID: 1221
		[Token(Token = "0x40004C5")]
		[FieldOffset(Offset = "0x50")]
		private TabBarItemData _data;

		// Token: 0x040004C6 RID: 1222
		[Token(Token = "0x40004C6")]
		[FieldOffset(Offset = "0x54")]
		private bool _selected;
	}
}
