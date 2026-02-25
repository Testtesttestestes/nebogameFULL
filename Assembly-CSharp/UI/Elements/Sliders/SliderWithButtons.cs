using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace UI.Elements.Sliders
{
	// Token: 0x020001F8 RID: 504
	[Token(Token = "0x20001F8")]
	public class SliderWithButtons : MonoBehaviour
	{
		// Token: 0x140000EA RID: 234
		// (add) Token: 0x06000CF1 RID: 3313 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000CF2 RID: 3314 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000EA")]
		public event Action<int> OnValueChangedEvent
		{
			[Token(Token = "0x6000CF1")]
			[Address(RVA = "0x5FE8", Offset = "0x5FE8", VA = "0x5FE8")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000CF2")]
			[Address(RVA = "0x5FE9", Offset = "0x5FE9", VA = "0x5FE9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x170001B1 RID: 433
		// (get) Token: 0x06000CF3 RID: 3315 RVA: 0x00003FA8 File Offset: 0x000021A8
		// (set) Token: 0x06000CF4 RID: 3316 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001B1")]
		public int MinValue
		{
			[Token(Token = "0x6000CF3")]
			[Address(RVA = "0x5FEA", Offset = "0x5FEA", VA = "0x5FEA")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000CF4")]
			[Address(RVA = "0x5FEB", Offset = "0x5FEB", VA = "0x5FEB")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x06000CF5 RID: 3317 RVA: 0x00003FC0 File Offset: 0x000021C0
		// (set) Token: 0x06000CF6 RID: 3318 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001B2")]
		public int MaxValue
		{
			[Token(Token = "0x6000CF5")]
			[Address(RVA = "0x5FEC", Offset = "0x5FEC", VA = "0x5FEC")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000CF6")]
			[Address(RVA = "0x5FED", Offset = "0x5FED", VA = "0x5FED")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x06000CF7 RID: 3319 RVA: 0x00003FD8 File Offset: 0x000021D8
		// (set) Token: 0x06000CF8 RID: 3320 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001B3")]
		public int Value
		{
			[Token(Token = "0x6000CF7")]
			[Address(RVA = "0x5FEE", Offset = "0x5FEE", VA = "0x5FEE")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000CF8")]
			[Address(RVA = "0x5FEF", Offset = "0x5FEF", VA = "0x5FEF")]
			set
			{
			}
		}

		// Token: 0x06000CF9 RID: 3321 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CF9")]
		[Address(RVA = "0x5FF0", Offset = "0x5FF0", VA = "0x5FF0")]
		public void SetLimitValues(int minValue, int maxValue)
		{
		}

		// Token: 0x06000CFA RID: 3322 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CFA")]
		[Address(RVA = "0x5FF1", Offset = "0x5FF1", VA = "0x5FF1")]
		public void SetLimitValues(int minValue, int maxValue, int value)
		{
		}

		// Token: 0x06000CFB RID: 3323 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CFB")]
		[Address(RVA = "0x5FF2", Offset = "0x5FF2", VA = "0x5FF2")]
		private void OnDestroy()
		{
		}

		// Token: 0x06000CFC RID: 3324 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CFC")]
		[Address(RVA = "0x5FF3", Offset = "0x5FF3", VA = "0x5FF3")]
		private void Start()
		{
		}

		// Token: 0x06000CFD RID: 3325 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CFD")]
		[Address(RVA = "0x5FF4", Offset = "0x5FF4", VA = "0x5FF4")]
		private void IncrementButtonClickEventHandler()
		{
		}

		// Token: 0x06000CFE RID: 3326 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CFE")]
		[Address(RVA = "0x5FF5", Offset = "0x5FF5", VA = "0x5FF5")]
		private void DecrementButtonClickEventHandler()
		{
		}

		// Token: 0x06000CFF RID: 3327 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CFF")]
		[Address(RVA = "0x5FF6", Offset = "0x5FF6", VA = "0x5FF6")]
		private void HandleValueChanged(float newValue)
		{
		}

		// Token: 0x06000D00 RID: 3328 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D00")]
		[Address(RVA = "0x5FF7", Offset = "0x5FF7", VA = "0x5FF7")]
		public SliderWithButtons()
		{
		}

		// Token: 0x04000664 RID: 1636
		[Token(Token = "0x4000664")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Slider _slider;

		// Token: 0x04000665 RID: 1637
		[Token(Token = "0x4000665")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Button _decrementButton;

		// Token: 0x04000666 RID: 1638
		[Token(Token = "0x4000666")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Button _incrementButton;
	}
}
