using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Gameplay.Craft.View;
using Gameplay.Medals.View;
using Il2CppDummyDll;
using TMPro;
using UI.Toggle;
using UnityEngine;

namespace UI.Filters
{
	// Token: 0x020001E0 RID: 480
	[Token(Token = "0x20001E0")]
	public class FiltersView : MonoBehaviour
	{
		// Token: 0x1700019F RID: 415
		// (get) Token: 0x06000C73 RID: 3187 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700019F")]
		public FilterButton PriceFilterButton
		{
			[Token(Token = "0x6000C73")]
			[Address(RVA = "0x5F77", Offset = "0x5F77", VA = "0x5F77")]
			get
			{
				return null;
			}
		}

		// Token: 0x140000E5 RID: 229
		// (add) Token: 0x06000C74 RID: 3188 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000C75 RID: 3189 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000E5")]
		public event Action ChangedEvent
		{
			[Token(Token = "0x6000C74")]
			[Address(RVA = "0x5F78", Offset = "0x5F78", VA = "0x5F78")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000C75")]
			[Address(RVA = "0x5F79", Offset = "0x5F79", VA = "0x5F79")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x06000C76 RID: 3190 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170001A0")]
		public List<FilterInfo> FiltersInfo
		{
			[Token(Token = "0x6000C76")]
			[Address(RVA = "0x5F7A", Offset = "0x5F7A", VA = "0x5F7A")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x06000C77 RID: 3191 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170001A1")]
		public Dictionary<FilterInfo.FilterType, FilterInfo> FiltersInfoDictionary
		{
			[Token(Token = "0x6000C77")]
			[Address(RVA = "0x5F7B", Offset = "0x5F7B", VA = "0x5F7B")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x06000C78 RID: 3192 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170001A2")]
		public GameObject AchievedToggle
		{
			[Token(Token = "0x6000C78")]
			[Address(RVA = "0x5F7C", Offset = "0x5F7C", VA = "0x5F7C")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000C79 RID: 3193 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C79")]
		[Address(RVA = "0x5F7D", Offset = "0x5F7D", VA = "0x5F7D")]
		private void Awake()
		{
		}

		// Token: 0x06000C7A RID: 3194 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C7A")]
		[Address(RVA = "0x5F7E", Offset = "0x5F7E", VA = "0x5F7E")]
		private void AchievedToggleOnChangedEvent()
		{
		}

		// Token: 0x06000C7B RID: 3195 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C7B")]
		[Address(RVA = "0x5F7F", Offset = "0x5F7F", VA = "0x5F7F")]
		public void SetCounter(int currentValue, int totalValue)
		{
		}

		// Token: 0x06000C7C RID: 3196 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C7C")]
		[Address(RVA = "0x5F80", Offset = "0x5F80", VA = "0x5F80")]
		private void ButtonOnClickEvent(FilterButton filterButton)
		{
		}

		// Token: 0x06000C7D RID: 3197 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C7D")]
		[Address(RVA = "0x5F81", Offset = "0x5F81", VA = "0x5F81")]
		private void OtherFilterButtonOnClickEvent(FilterButton filterButton)
		{
		}

		// Token: 0x06000C7E RID: 3198 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C7E")]
		[Address(RVA = "0x5F82", Offset = "0x5F82", VA = "0x5F82")]
		private void PriceFilterButtonOnClickEvent(FilterButton filterButton)
		{
		}

		// Token: 0x06000C7F RID: 3199 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C7F")]
		[Address(RVA = "0x5F83", Offset = "0x5F83", VA = "0x5F83")]
		private void SearchInputChangedHandler(string value)
		{
		}

		// Token: 0x06000C80 RID: 3200 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C80")]
		[Address(RVA = "0x5F84", Offset = "0x5F84", VA = "0x5F84")]
		private void CraftFilterViewChangedEventHandler()
		{
		}

		// Token: 0x06000C81 RID: 3201 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C81")]
		[Address(RVA = "0x5F85", Offset = "0x5F85", VA = "0x5F85")]
		private void OnDestroy()
		{
		}

		// Token: 0x06000C82 RID: 3202 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C82")]
		[Address(RVA = "0x5F86", Offset = "0x5F86", VA = "0x5F86")]
		public FiltersView()
		{
		}

		// Token: 0x04000605 RID: 1541
		[Token(Token = "0x4000605")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private bool _useCraftFilters;

		// Token: 0x04000606 RID: 1542
		[Token(Token = "0x4000606")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private SearchInput _searchInput;

		// Token: 0x04000607 RID: 1543
		[Token(Token = "0x4000607")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private FilterButton _priceFilterButton;

		// Token: 0x04000608 RID: 1544
		[Token(Token = "0x4000608")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private FilterButton _otherFilterButton;

		// Token: 0x04000609 RID: 1545
		[Token(Token = "0x4000609")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GreenToggle _achievedToggle;

		// Token: 0x0400060A RID: 1546
		[Token(Token = "0x400060A")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private CraftFiltersView _craftFilters;

		// Token: 0x0400060B RID: 1547
		[Token(Token = "0x400060B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SkillFilterButtonData[] _skillButtons;

		// Token: 0x0400060C RID: 1548
		[Token(Token = "0x400060C")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private TextMeshProUGUI _countLabel;

		// Token: 0x0400060E RID: 1550
		[Token(Token = "0x400060E")]
		[FieldOffset(Offset = "0x34")]
		private List<FilterInfo> _filtersInfo;

		// Token: 0x0400060F RID: 1551
		[Token(Token = "0x400060F")]
		[FieldOffset(Offset = "0x38")]
		private Dictionary<FilterInfo.FilterType, FilterInfo> _filtersInfoDictionary;
	}
}
