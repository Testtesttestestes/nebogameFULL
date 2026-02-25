using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Protocol.Dic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace UI.Filters
{
	// Token: 0x020001EA RID: 490
	[Token(Token = "0x20001EA")]
	public class SubFiltersDropdown : MonoBehaviour, IDeselectHandler, IEventSystemHandler
	{
		// Token: 0x140000E8 RID: 232
		// (add) Token: 0x06000CAA RID: 3242 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000CAB RID: 3243 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000E8")]
		public event Action ChangedEvent
		{
			[Token(Token = "0x6000CAA")]
			[Address(RVA = "0x5FAD", Offset = "0x5FAD", VA = "0x5FAD")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000CAB")]
			[Address(RVA = "0x5FAE", Offset = "0x5FAE", VA = "0x5FAE")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x06000CAC RID: 3244 RVA: 0x00003F00 File Offset: 0x00002100
		[Token(Token = "0x170001A8")]
		private bool AllSelected
		{
			[Token(Token = "0x6000CAC")]
			[Address(RVA = "0x5FAF", Offset = "0x5FAF", VA = "0x5FAF")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000CAD RID: 3245 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CAD")]
		[Address(RVA = "0x5FB0", Offset = "0x5FB0", VA = "0x5FB0")]
		public void Init(Dictionary<uint, ArtikulTypeFilters> allFilters)
		{
		}

		// Token: 0x06000CAE RID: 3246 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CAE")]
		[Address(RVA = "0x5FB1", Offset = "0x5FB1", VA = "0x5FB1")]
		private void Awake()
		{
		}

		// Token: 0x06000CAF RID: 3247 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CAF")]
		[Address(RVA = "0x5FB2", Offset = "0x5FB2", VA = "0x5FB2")]
		private void OnDestroy()
		{
		}

		// Token: 0x06000CB0 RID: 3248 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CB0")]
		[Address(RVA = "0x5FB3", Offset = "0x5FB3", VA = "0x5FB3")]
		private void MetaFiltersChangedEventHandler()
		{
		}

		// Token: 0x06000CB1 RID: 3249 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CB1")]
		[Address(RVA = "0x5FB4", Offset = "0x5FB4", VA = "0x5FB4")]
		public void AdjustFilters()
		{
		}

		// Token: 0x06000CB2 RID: 3250 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CB2")]
		[Address(RVA = "0x5FB5", Offset = "0x5FB5", VA = "0x5FB5")]
		private void HandleFilterInfo()
		{
		}

		// Token: 0x06000CB3 RID: 3251 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CB3")]
		[Address(RVA = "0x5FB6", Offset = "0x5FB6", VA = "0x5FB6")]
		private void DestroyAllToggles()
		{
		}

		// Token: 0x06000CB4 RID: 3252 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CB4")]
		[Address(RVA = "0x5FB7", Offset = "0x5FB7", VA = "0x5FB7")]
		private void ToggleEventHandler(SimpleToggleWithData toggle)
		{
		}

		// Token: 0x06000CB5 RID: 3253 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CB5")]
		[Address(RVA = "0x5FB8", Offset = "0x5FB8", VA = "0x5FB8")]
		private void ChangeToggleSilent(SimpleToggleWithData toggle, bool enable)
		{
		}

		// Token: 0x06000CB6 RID: 3254 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CB6")]
		[Address(RVA = "0x4481", Offset = "0x4481", VA = "0x4481")]
		private void ToggleSilent(SimpleToggleWithData toggle)
		{
		}

		// Token: 0x06000CB7 RID: 3255 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CB7")]
		[Address(RVA = "0x5FB9", Offset = "0x5FB9", VA = "0x5FB9")]
		private void ToggleChangedEventHandler(bool enable)
		{
		}

		// Token: 0x06000CB8 RID: 3256 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CB8")]
		[Address(RVA = "0x5FBA", Offset = "0x5FBA", VA = "0x5FBA")]
		private void AllToggleChangedEventHandler(bool enable)
		{
		}

		// Token: 0x06000CB9 RID: 3257 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CB9")]
		[Address(RVA = "0x5FBB", Offset = "0x5FBB", VA = "0x5FBB")]
		private void ApplyFilters()
		{
		}

		// Token: 0x06000CBA RID: 3258 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CBA")]
		[Address(RVA = "0x5FBC", Offset = "0x5FBC", VA = "0x5FBC", Slot = "4")]
		public void OnDeselect(BaseEventData eventData)
		{
		}

		// Token: 0x06000CBB RID: 3259 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CBB")]
		[Address(RVA = "0x5FBD", Offset = "0x5FBD", VA = "0x5FBD")]
		private void HandleSelectedObject(BaseEventData eventData)
		{
		}

		// Token: 0x06000CBC RID: 3260 RVA: 0x00003F18 File Offset: 0x00002118
		[Token(Token = "0x6000CBC")]
		[Address(RVA = "0x5FBE", Offset = "0x5FBE", VA = "0x5FBE")]
		private bool AnyParent(GameObject obj)
		{
			return default(bool);
		}

		// Token: 0x06000CBD RID: 3261 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CBD")]
		[Address(RVA = "0x5FBF", Offset = "0x5FBF", VA = "0x5FBF")]
		public SubFiltersDropdown()
		{
		}

		// Token: 0x06000CBF RID: 3263 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CBF")]
		[Address(RVA = "0x447F", Offset = "0x447F", VA = "0x447F")]
		[CompilerGenerated]
		private void <AdjustFilters>g__CreateAndAddToggle|23_3(ArtikulTypeFilters filter)
		{
		}

		// Token: 0x0400062A RID: 1578
		[Token(Token = "0x400062A")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private MetaFiltersView _metaFiltersView;

		// Token: 0x0400062B RID: 1579
		[Token(Token = "0x400062B")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private SimpleToggleWithData _togglePrefab;

		// Token: 0x0400062C RID: 1580
		[Token(Token = "0x400062C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform _content;

		// Token: 0x0400062D RID: 1581
		[Token(Token = "0x400062D")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private TextMeshProUGUI _text;

		// Token: 0x0400062E RID: 1582
		[Token(Token = "0x400062E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Sprite _lightBg;

		// Token: 0x0400062F RID: 1583
		[Token(Token = "0x400062F")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private Sprite _darkBg;

		// Token: 0x04000630 RID: 1584
		[Token(Token = "0x4000630")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Toggle _toggle;

		// Token: 0x04000631 RID: 1585
		[Token(Token = "0x4000631")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private SimpleToggleWithData _allToggle;

		// Token: 0x04000632 RID: 1586
		[Token(Token = "0x4000632")]
		[FieldOffset(Offset = "0x30")]
		private Dictionary<uint, ArtikulTypeFilters> _allFilters;

		// Token: 0x04000633 RID: 1587
		[Token(Token = "0x4000633")]
		[FieldOffset(Offset = "0x34")]
		private IList<ArtikulTypeFilters> _availableFilters;

		// Token: 0x04000634 RID: 1588
		[Token(Token = "0x4000634")]
		[FieldOffset(Offset = "0x38")]
		private readonly List<SimpleToggleWithData> _availableToggles;

		// Token: 0x04000635 RID: 1589
		[Token(Token = "0x4000635")]
		[FieldOffset(Offset = "0x3C")]
		private readonly IList<ArtikulTypeFilters> _activeFilters;

		// Token: 0x04000636 RID: 1590
		[Token(Token = "0x4000636")]
		[FieldOffset(Offset = "0x40")]
		private int _index;

		// Token: 0x04000638 RID: 1592
		[Token(Token = "0x4000638")]
		[FieldOffset(Offset = "0x48")]
		public readonly FilterInfo FilterInfo;
	}
}
