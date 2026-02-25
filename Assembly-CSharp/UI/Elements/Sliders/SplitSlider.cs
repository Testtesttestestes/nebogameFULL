using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace UI.Elements.Sliders
{
	// Token: 0x020001F9 RID: 505
	[Token(Token = "0x20001F9")]
	public class SplitSlider : MonoBehaviour
	{
		// Token: 0x140000EB RID: 235
		// (add) Token: 0x06000D01 RID: 3329 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000D02 RID: 3330 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000EB")]
		public event Action<int> OnValueChangedEvent
		{
			[Token(Token = "0x6000D01")]
			[Address(RVA = "0x5FF8", Offset = "0x5FF8", VA = "0x5FF8")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000D02")]
			[Address(RVA = "0x5FF9", Offset = "0x5FF9", VA = "0x5FF9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x06000D03 RID: 3331 RVA: 0x00003FF0 File Offset: 0x000021F0
		// (set) Token: 0x06000D04 RID: 3332 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001B4")]
		public int MinRemainCount
		{
			[Token(Token = "0x6000D03")]
			[Address(RVA = "0x5FFA", Offset = "0x5FFA", VA = "0x5FFA")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000D04")]
			[Address(RVA = "0x5FFB", Offset = "0x5FFB", VA = "0x5FFB")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x06000D05 RID: 3333 RVA: 0x00004008 File Offset: 0x00002208
		// (set) Token: 0x06000D06 RID: 3334 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001B5")]
		public int TotalCount
		{
			[Token(Token = "0x6000D05")]
			[Address(RVA = "0x5FFC", Offset = "0x5FFC", VA = "0x5FFC")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000D06")]
			[Address(RVA = "0x5FFD", Offset = "0x5FFD", VA = "0x5FFD")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06000D07 RID: 3335 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D07")]
		[Address(RVA = "0x5FFE", Offset = "0x5FFE", VA = "0x5FFE")]
		private void OnDestroy()
		{
		}

		// Token: 0x06000D08 RID: 3336 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D08")]
		[Address(RVA = "0x5FFF", Offset = "0x5FFF", VA = "0x5FFF")]
		private void Start()
		{
		}

		// Token: 0x06000D09 RID: 3337 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D09")]
		[Address(RVA = "0x6000", Offset = "0x6000", VA = "0x6000")]
		private void HandleSliderValueChangedEventEvent(int value)
		{
		}

		// Token: 0x06000D0A RID: 3338 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D0A")]
		[Address(RVA = "0x6001", Offset = "0x6001", VA = "0x6001")]
		private void DisplayValue(int value)
		{
		}

		// Token: 0x06000D0B RID: 3339 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D0B")]
		[Address(RVA = "0x6002", Offset = "0x6002", VA = "0x6002")]
		public void SetValues(int minRemainCount, int totalCount)
		{
		}

		// Token: 0x06000D0C RID: 3340 RVA: 0x00004020 File Offset: 0x00002220
		[Token(Token = "0x6000D0C")]
		[Address(RVA = "0x6003", Offset = "0x6003", VA = "0x6003")]
		public int GetValue()
		{
			return 0;
		}

		// Token: 0x06000D0D RID: 3341 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D0D")]
		[Address(RVA = "0x6004", Offset = "0x6004", VA = "0x6004")]
		public void SetValue(int value)
		{
		}

		// Token: 0x06000D0E RID: 3342 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D0E")]
		[Address(RVA = "0x6005", Offset = "0x6005", VA = "0x6005")]
		public SplitSlider()
		{
		}

		// Token: 0x0400066A RID: 1642
		[Token(Token = "0x400066A")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private SliderWithButtons _slider;

		// Token: 0x0400066B RID: 1643
		[Token(Token = "0x400066B")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private TextMeshProUGUI _leftTextfield;

		// Token: 0x0400066C RID: 1644
		[Token(Token = "0x400066C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TextMeshProUGUI _rightTextfield;
	}
}
