using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace UI.Elements.Counters
{
	// Token: 0x0200023B RID: 571
	[Token(Token = "0x200023B")]
	public class CounterAutoHide : MonoBehaviour
	{
		// Token: 0x170001DD RID: 477
		// (get) Token: 0x06000E1F RID: 3615 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170001DD")]
		public string DisplayedStringWhenCrop
		{
			[Token(Token = "0x6000E1F")]
			[Address(RVA = "0x60B2", Offset = "0x60B2", VA = "0x60B2")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001DE RID: 478
		// (get) Token: 0x06000E20 RID: 3616 RVA: 0x000041D0 File Offset: 0x000023D0
		[Token(Token = "0x170001DE")]
		public int MaxValueToCrop
		{
			[Token(Token = "0x6000E20")]
			[Address(RVA = "0x60B3", Offset = "0x60B3", VA = "0x60B3")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170001DF RID: 479
		// (get) Token: 0x06000E21 RID: 3617 RVA: 0x000041E8 File Offset: 0x000023E8
		// (set) Token: 0x06000E22 RID: 3618 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001DF")]
		public int Value
		{
			[Token(Token = "0x6000E21")]
			[Address(RVA = "0x60B4", Offset = "0x60B4", VA = "0x60B4")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000E22")]
			[Address(RVA = "0x1A94", Offset = "0x1A94", VA = "0x1A94")]
			set
			{
			}
		}

		// Token: 0x06000E23 RID: 3619 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E23")]
		[Address(RVA = "0x60B5", Offset = "0x60B5", VA = "0x60B5", Slot = "4")]
		protected virtual void HandleValueChanged()
		{
		}

		// Token: 0x06000E24 RID: 3620 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E24")]
		[Address(RVA = "0x60B6", Offset = "0x60B6", VA = "0x60B6", Slot = "5")]
		protected virtual void DisplayValue(int value)
		{
		}

		// Token: 0x06000E25 RID: 3621 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E25")]
		[Address(RVA = "0x60B7", Offset = "0x60B7", VA = "0x60B7")]
		private void OnEnable()
		{
		}

		// Token: 0x06000E26 RID: 3622 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E26")]
		[Address(RVA = "0x60B8", Offset = "0x60B8", VA = "0x60B8")]
		public CounterAutoHide()
		{
		}

		// Token: 0x040006FD RID: 1789
		[Token(Token = "0x40006FD")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private int _maxValueToCrop;

		// Token: 0x040006FE RID: 1790
		[Token(Token = "0x40006FE")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private string _displayedStringWhenCrop;

		// Token: 0x040006FF RID: 1791
		[Token(Token = "0x40006FF")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TextMeshProUGUI _textField;

		// Token: 0x04000700 RID: 1792
		[Token(Token = "0x4000700")]
		[FieldOffset(Offset = "0x1C")]
		private int _value;
	}
}
