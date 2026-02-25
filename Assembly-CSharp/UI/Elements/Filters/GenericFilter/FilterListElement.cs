using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UI.Elements.Filters.GenericFilter
{
	// Token: 0x02000233 RID: 563
	[Token(Token = "0x2000233")]
	public class FilterListElement : MonoBehaviour
	{
		// Token: 0x140000F0 RID: 240
		// (add) Token: 0x06000DF3 RID: 3571 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000DF4 RID: 3572 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000F0")]
		public event Action<FilterListElement> ClickedEvent
		{
			[Token(Token = "0x6000DF3")]
			[Address(RVA = "0x1C7B", Offset = "0x1C7B", VA = "0x1C7B")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000DF4")]
			[Address(RVA = "0x6088", Offset = "0x6088", VA = "0x6088")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x06000DF5 RID: 3573 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000DF6 RID: 3574 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001D8")]
		public object Data
		{
			[Token(Token = "0x6000DF5")]
			[Address(RVA = "0x6089", Offset = "0x6089", VA = "0x6089")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000DF6")]
			[Address(RVA = "0x608A", Offset = "0x608A", VA = "0x608A")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x06000DF7 RID: 3575 RVA: 0x000041A0 File Offset: 0x000023A0
		// (set) Token: 0x06000DF8 RID: 3576 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001D9")]
		public bool Selected
		{
			[Token(Token = "0x6000DF7")]
			[Address(RVA = "0x608B", Offset = "0x608B", VA = "0x608B")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000DF8")]
			[Address(RVA = "0x608C", Offset = "0x608C", VA = "0x608C")]
			set
			{
			}
		}

		// Token: 0x06000DF9 RID: 3577 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DF9")]
		[Address(RVA = "0x608D", Offset = "0x608D", VA = "0x608D")]
		private void Awake()
		{
		}

		// Token: 0x06000DFA RID: 3578 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DFA")]
		[Address(RVA = "0x608E", Offset = "0x608E", VA = "0x608E")]
		private void OnDestroy()
		{
		}

		// Token: 0x06000DFB RID: 3579 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DFB")]
		[Address(RVA = "0x608F", Offset = "0x608F", VA = "0x608F")]
		private void ButtonClickedEventHandler()
		{
		}

		// Token: 0x06000DFC RID: 3580 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DFC")]
		[Address(RVA = "0x6090", Offset = "0x6090", VA = "0x6090", Slot = "4")]
		public virtual void Init(FilterListElement.FilterData data)
		{
		}

		// Token: 0x06000DFD RID: 3581 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DFD")]
		[Address(RVA = "0x6091", Offset = "0x6091", VA = "0x6091")]
		public FilterListElement()
		{
		}

		// Token: 0x040006E1 RID: 1761
		[Token(Token = "0x40006E1")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TextMeshProUGUI _title;

		// Token: 0x040006E2 RID: 1762
		[Token(Token = "0x40006E2")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private GameObject _selector;

		// Token: 0x040006E3 RID: 1763
		[Token(Token = "0x40006E3")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Button _button;

		// Token: 0x040006E4 RID: 1764
		[Token(Token = "0x40006E4")]
		[FieldOffset(Offset = "0x1C")]
		private bool _selected;

		// Token: 0x02000234 RID: 564
		[Token(Token = "0x2000234")]
		public class FilterData
		{
			// Token: 0x06000DFE RID: 3582 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000DFE")]
			[Address(RVA = "0x1C7A", Offset = "0x1C7A", VA = "0x1C7A")]
			public FilterData()
			{
			}

			// Token: 0x040006E7 RID: 1767
			[Token(Token = "0x40006E7")]
			[FieldOffset(Offset = "0x8")]
			public string Title;

			// Token: 0x040006E8 RID: 1768
			[Token(Token = "0x40006E8")]
			[FieldOffset(Offset = "0xC")]
			public object Data;
		}
	}
}
