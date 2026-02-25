using System;
using System.Runtime.CompilerServices;
using AssetContent;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UI.Elements.Filters.GenericFilter
{
	// Token: 0x02000239 RID: 569
	[Token(Token = "0x2000239")]
	public class SubFilterListElement : MonoBehaviour
	{
		// Token: 0x170001DB RID: 475
		// (get) Token: 0x06000E14 RID: 3604 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000E15 RID: 3605 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001DB")]
		public object Data
		{
			[Token(Token = "0x6000E14")]
			[Address(RVA = "0x60A7", Offset = "0x60A7", VA = "0x60A7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000E15")]
			[Address(RVA = "0x60A8", Offset = "0x60A8", VA = "0x60A8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x140000F3 RID: 243
		// (add) Token: 0x06000E16 RID: 3606 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000E17 RID: 3607 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000F3")]
		public event Action<SubFilterListElement> ClickedEvent
		{
			[Token(Token = "0x6000E16")]
			[Address(RVA = "0x60A9", Offset = "0x60A9", VA = "0x60A9")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000E17")]
			[Address(RVA = "0x60AA", Offset = "0x60AA", VA = "0x60AA")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06000E18 RID: 3608 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E18")]
		[Address(RVA = "0x60AB", Offset = "0x60AB", VA = "0x60AB")]
		public void Init(SubFilterListElement.SubFilterData data)
		{
		}

		// Token: 0x170001DC RID: 476
		// (set) Token: 0x06000E19 RID: 3609 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001DC")]
		public bool Selected
		{
			[Token(Token = "0x6000E19")]
			[Address(RVA = "0x60AC", Offset = "0x60AC", VA = "0x60AC")]
			set
			{
			}
		}

		// Token: 0x06000E1A RID: 3610 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E1A")]
		[Address(RVA = "0x60AD", Offset = "0x60AD", VA = "0x60AD")]
		private void Awake()
		{
		}

		// Token: 0x06000E1B RID: 3611 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E1B")]
		[Address(RVA = "0x60AE", Offset = "0x60AE", VA = "0x60AE")]
		private void OnDestroy()
		{
		}

		// Token: 0x06000E1C RID: 3612 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E1C")]
		[Address(RVA = "0x60AF", Offset = "0x60AF", VA = "0x60AF")]
		private void ButtonClickedEventHandler()
		{
		}

		// Token: 0x06000E1D RID: 3613 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E1D")]
		[Address(RVA = "0x60B0", Offset = "0x60B0", VA = "0x60B0")]
		public SubFilterListElement()
		{
		}

		// Token: 0x040006F4 RID: 1780
		[Token(Token = "0x40006F4")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private GameRawImage _icon;

		// Token: 0x040006F5 RID: 1781
		[Token(Token = "0x40006F5")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private GameObject _selector;

		// Token: 0x040006F6 RID: 1782
		[Token(Token = "0x40006F6")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TextMeshProUGUI _label;

		// Token: 0x040006F7 RID: 1783
		[Token(Token = "0x40006F7")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private Button _button;

		// Token: 0x0200023A RID: 570
		[Token(Token = "0x200023A")]
		public class SubFilterData
		{
			// Token: 0x06000E1E RID: 3614 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000E1E")]
			[Address(RVA = "0x60B1", Offset = "0x60B1", VA = "0x60B1")]
			public SubFilterData()
			{
			}

			// Token: 0x040006FA RID: 1786
			[Token(Token = "0x40006FA")]
			[FieldOffset(Offset = "0x8")]
			public string IconAssetId;

			// Token: 0x040006FB RID: 1787
			[Token(Token = "0x40006FB")]
			[FieldOffset(Offset = "0xC")]
			public string Label;

			// Token: 0x040006FC RID: 1788
			[Token(Token = "0x40006FC")]
			[FieldOffset(Offset = "0x10")]
			public object Data;
		}
	}
}
