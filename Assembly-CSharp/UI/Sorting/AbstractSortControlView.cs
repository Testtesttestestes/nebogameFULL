using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Sorting;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace UI.Sorting
{
	// Token: 0x0200017E RID: 382
	[Token(Token = "0x200017E")]
	public abstract class AbstractSortControlView<TData> : MonoBehaviour
	{
		// Token: 0x140000DF RID: 223
		// (add) Token: 0x06000ACB RID: 2763 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000ACC RID: 2764 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000DF")]
		public event Action<IGameDataComparer<TData>> ComparerChangedEvent
		{
			[Token(Token = "0x6000ACB")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000ACC")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x06000ACD RID: 2765 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000170")]
		public IGameDataComparer<TData> SelectedFilter
		{
			[Token(Token = "0x6000ACD")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000ACE RID: 2766 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000ACE")]
		private void Awake()
		{
		}

		// Token: 0x06000ACF RID: 2767 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000ACF")]
		private void OptionViewOnSelectEvent(SortControlOptionView target)
		{
		}

		// Token: 0x06000AD0 RID: 2768 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AD0")]
		private void OnDestroy()
		{
		}

		// Token: 0x06000AD1 RID: 2769 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AD1")]
		private void SwitcherValueChangedHandler(bool en)
		{
		}

		// Token: 0x06000AD2 RID: 2770
		[Token(Token = "0x6000AD2")]
		protected abstract List<IGameDataComparer<TData>> GetComparers();

		// Token: 0x06000AD3 RID: 2771 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AD3")]
		protected AbstractSortControlView()
		{
		}

		// Token: 0x040004C7 RID: 1223
		[Token(Token = "0x40004C7")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private RectTransform _optionsContainer;

		// Token: 0x040004C8 RID: 1224
		[Token(Token = "0x40004C8")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private Toggle _switch;

		// Token: 0x040004C9 RID: 1225
		[Token(Token = "0x40004C9")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private SortControlOptionView _itemPrefab;

		// Token: 0x040004CA RID: 1226
		[Token(Token = "0x40004CA")]
		[FieldOffset(Offset = "0x0")]
		private List<IGameDataComparer<TData>> _comparers;

		// Token: 0x040004CB RID: 1227
		[Token(Token = "0x40004CB")]
		[FieldOffset(Offset = "0x0")]
		private List<SortControlOptionView> _optionViews;

		// Token: 0x040004CD RID: 1229
		[Token(Token = "0x40004CD")]
		[FieldOffset(Offset = "0x0")]
		private IGameDataComparer<TData> _selectedFilter;
	}
}
