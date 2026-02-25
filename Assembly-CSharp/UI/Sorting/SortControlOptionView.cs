using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UI.Sorting
{
	// Token: 0x0200017F RID: 383
	[Token(Token = "0x200017F")]
	public class SortControlOptionView : MonoBehaviour
	{
		// Token: 0x140000E0 RID: 224
		// (add) Token: 0x06000AD4 RID: 2772 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000AD5 RID: 2773 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000E0")]
		public event Action<SortControlOptionView> SelectEvent
		{
			[Token(Token = "0x6000AD4")]
			[Address(RVA = "0x2A50", Offset = "0x2A50", VA = "0x2A50")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000AD5")]
			[Address(RVA = "0x2A52", Offset = "0x2A52", VA = "0x2A52")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000171 RID: 369
		// (set) Token: 0x06000AD6 RID: 2774 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000171")]
		public string Label
		{
			[Token(Token = "0x6000AD6")]
			[Address(RVA = "0x2A4F", Offset = "0x2A4F", VA = "0x2A4F")]
			set
			{
			}
		}

		// Token: 0x06000AD7 RID: 2775 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AD7")]
		[Address(RVA = "0x5E0C", Offset = "0x5E0C", VA = "0x5E0C")]
		private void Awake()
		{
		}

		// Token: 0x06000AD8 RID: 2776 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AD8")]
		[Address(RVA = "0x5E0D", Offset = "0x5E0D", VA = "0x5E0D")]
		private void Start()
		{
		}

		// Token: 0x06000AD9 RID: 2777 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AD9")]
		[Address(RVA = "0x5E0E", Offset = "0x5E0E", VA = "0x5E0E")]
		private void OnValueChangedEventHandler(bool arg0)
		{
		}

		// Token: 0x06000ADA RID: 2778 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000ADA")]
		[Address(RVA = "0x5E0F", Offset = "0x5E0F", VA = "0x5E0F")]
		private void OnDestroy()
		{
		}

		// Token: 0x06000ADB RID: 2779 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000ADB")]
		[Address(RVA = "0x5E10", Offset = "0x5E10", VA = "0x5E10")]
		public void SetIsOnWithoutNotify(bool value)
		{
		}

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x06000ADC RID: 2780 RVA: 0x00003A20 File Offset: 0x00001C20
		// (set) Token: 0x06000ADD RID: 2781 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000172")]
		public bool IsDescending
		{
			[Token(Token = "0x6000ADC")]
			[Address(RVA = "0x5E11", Offset = "0x5E11", VA = "0x5E11")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000ADD")]
			[Address(RVA = "0x5E12", Offset = "0x5E12", VA = "0x5E12")]
			set
			{
			}
		}

		// Token: 0x06000ADE RID: 2782 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000ADE")]
		[Address(RVA = "0x5E13", Offset = "0x5E13", VA = "0x5E13")]
		private void HandleIsDescendingChanged()
		{
		}

		// Token: 0x06000ADF RID: 2783 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000ADF")]
		[Address(RVA = "0x5E14", Offset = "0x5E14", VA = "0x5E14")]
		public SortControlOptionView()
		{
		}

		// Token: 0x040004CE RID: 1230
		[Token(Token = "0x40004CE")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TextMeshProUGUI _label;

		// Token: 0x040004CF RID: 1231
		[Token(Token = "0x40004CF")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Toggle _toggle;

		// Token: 0x040004D0 RID: 1232
		[Token(Token = "0x40004D0")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform _sortImagesOwner;

		// Token: 0x040004D1 RID: 1233
		[Token(Token = "0x40004D1")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private Transform _forwardSortImage;

		// Token: 0x040004D2 RID: 1234
		[Token(Token = "0x40004D2")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _backwardImage;

		// Token: 0x040004D4 RID: 1236
		[Token(Token = "0x40004D4")]
		[FieldOffset(Offset = "0x28")]
		private bool _isDescending;
	}
}
