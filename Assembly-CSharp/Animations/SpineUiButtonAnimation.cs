using System;
using System.Collections;
using Core.Animations;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Animations
{
	// Token: 0x02001338 RID: 4920
	[Token(Token = "0x2001338")]
	public class SpineUiButtonAnimation : GameSpineUiAnimation, IPointerClickHandler, IEventSystemHandler, IPointerEnterHandler, IPointerExitHandler
	{
		// Token: 0x17001775 RID: 6005
		// (get) Token: 0x06007474 RID: 29812 RVA: 0x00014F70 File Offset: 0x00013170
		// (set) Token: 0x06007475 RID: 29813 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001775")]
		public bool DemoMode
		{
			[Token(Token = "0x6007474")]
			[Address(RVA = "0xBE40", Offset = "0xBE40", VA = "0xBE40")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6007475")]
			[Address(RVA = "0xBE41", Offset = "0xBE41", VA = "0xBE41")]
			set
			{
			}
		}

		// Token: 0x17001776 RID: 6006
		// (get) Token: 0x06007476 RID: 29814 RVA: 0x00014F88 File Offset: 0x00013188
		// (set) Token: 0x06007477 RID: 29815 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001776")]
		public bool Enabled
		{
			[Token(Token = "0x6007476")]
			[Address(RVA = "0xBE42", Offset = "0xBE42", VA = "0xBE42")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6007477")]
			[Address(RVA = "0xBE43", Offset = "0xBE43", VA = "0xBE43")]
			set
			{
			}
		}

		// Token: 0x06007478 RID: 29816 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007478")]
		[Address(RVA = "0xBE44", Offset = "0xBE44", VA = "0xBE44")]
		private void OnEnable()
		{
		}

		// Token: 0x06007479 RID: 29817 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007479")]
		[Address(RVA = "0xBE45", Offset = "0xBE45", VA = "0xBE45")]
		private void OnDisable()
		{
		}

		// Token: 0x0600747A RID: 29818 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600747A")]
		[Address(RVA = "0xBE46", Offset = "0xBE46", VA = "0xBE46")]
		private void PlayCurrentState()
		{
		}

		// Token: 0x0600747B RID: 29819 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600747B")]
		[Address(RVA = "0xBE47", Offset = "0xBE47", VA = "0xBE47")]
		private IEnumerator ShowDemoCoroutine()
		{
			return null;
		}

		// Token: 0x0600747C RID: 29820 RVA: 0x00014FA0 File Offset: 0x000131A0
		[Token(Token = "0x600747C")]
		[Address(RVA = "0xBE48", Offset = "0xBE48", VA = "0xBE48")]
		private bool HasAnimation(string animationName)
		{
			return default(bool);
		}

		// Token: 0x0600747D RID: 29821 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600747D")]
		[Address(RVA = "0xBE49", Offset = "0xBE49", VA = "0xBE49")]
		private void Start()
		{
		}

		// Token: 0x0600747E RID: 29822 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600747E")]
		[Address(RVA = "0xBE4A", Offset = "0xBE4A", VA = "0xBE4A", Slot = "24")]
		public void OnPointerClick(PointerEventData eventData)
		{
		}

		// Token: 0x0600747F RID: 29823 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600747F")]
		[Address(RVA = "0xBE4B", Offset = "0xBE4B", VA = "0xBE4B")]
		private void OnCompleteEvent(IGameAnimation obj)
		{
		}

		// Token: 0x06007480 RID: 29824 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007480")]
		[Address(RVA = "0xBE4C", Offset = "0xBE4C", VA = "0xBE4C", Slot = "25")]
		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		// Token: 0x06007481 RID: 29825 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007481")]
		[Address(RVA = "0xBE4D", Offset = "0xBE4D", VA = "0xBE4D", Slot = "26")]
		public void OnPointerExit(PointerEventData eventData)
		{
		}

		// Token: 0x06007482 RID: 29826 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007482")]
		[Address(RVA = "0xBE4E", Offset = "0xBE4E", VA = "0xBE4E")]
		public SpineUiButtonAnimation()
		{
		}

		// Token: 0x04003D15 RID: 15637
		[Token(Token = "0x4003D15")]
		[FieldOffset(Offset = "0x0")]
		public static string IDLE;

		// Token: 0x04003D16 RID: 15638
		[Token(Token = "0x4003D16")]
		[FieldOffset(Offset = "0x4")]
		public static string NON_ACTIVE;

		// Token: 0x04003D17 RID: 15639
		[Token(Token = "0x4003D17")]
		[FieldOffset(Offset = "0x8")]
		public static string ON;

		// Token: 0x04003D18 RID: 15640
		[Token(Token = "0x4003D18")]
		[FieldOffset(Offset = "0xC")]
		public static string OVER;

		// Token: 0x04003D19 RID: 15641
		[Token(Token = "0x4003D19")]
		[FieldOffset(Offset = "0x30")]
		private bool _over;

		// Token: 0x04003D1A RID: 15642
		[Token(Token = "0x4003D1A")]
		[FieldOffset(Offset = "0x31")]
		private bool _playingOnAnimation;

		// Token: 0x04003D1B RID: 15643
		[Token(Token = "0x4003D1B")]
		[FieldOffset(Offset = "0x32")]
		private bool _demoMode;

		// Token: 0x04003D1C RID: 15644
		[Token(Token = "0x4003D1C")]
		[FieldOffset(Offset = "0x34")]
		private Coroutine _demoCoroutine;

		// Token: 0x04003D1D RID: 15645
		[Token(Token = "0x4003D1D")]
		[FieldOffset(Offset = "0x38")]
		public int DemoModeIdleDuration;

		// Token: 0x04003D1E RID: 15646
		[Token(Token = "0x4003D1E")]
		[FieldOffset(Offset = "0x3C")]
		public int DemoModeOverDuration;

		// Token: 0x04003D1F RID: 15647
		[Token(Token = "0x4003D1F")]
		[FieldOffset(Offset = "0x40")]
		private bool _enabled;

		// Token: 0x04003D20 RID: 15648
		[Token(Token = "0x4003D20")]
		[FieldOffset(Offset = "0x41")]
		private bool _isGameObjectEnabled;
	}
}
