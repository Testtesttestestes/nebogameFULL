using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Animations;
using DG.Tweening;
using Gameplay.Sound.Control;
using Il2CppDummyDll;
using TMPro;
using UI.Windows;
using UnityEngine;
using UnityEngine.UI;
using Utils;

namespace Gameplay.Combat.View
{
	// Token: 0x0200091B RID: 2331
	[Token(Token = "0x200091B")]
	public class CombatWaitingWindowMono : BaseWindow<CombatWaitingWindowMono.CombatWaitingWindowArgs>
	{
		// Token: 0x17000AD5 RID: 2773
		// (get) Token: 0x060036E8 RID: 14056 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000AD5")]
		public override string WindowId
		{
			[Token(Token = "0x60036E8")]
			[Address(RVA = "0x86D7", Offset = "0x86D7", VA = "0x86D7", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000AD6 RID: 2774
		// (get) Token: 0x060036E9 RID: 14057 RVA: 0x0000B010 File Offset: 0x00009210
		[Token(Token = "0x17000AD6")]
		public override bool IsFullscreenWindow
		{
			[Token(Token = "0x60036E9")]
			[Address(RVA = "0x86D8", Offset = "0x86D8", VA = "0x86D8", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000AD7 RID: 2775
		// (get) Token: 0x060036EA RID: 14058 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060036EB RID: 14059 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000AD7")]
		public IGameAudio GameAudio
		{
			[Token(Token = "0x60036EA")]
			[Address(RVA = "0x86D9", Offset = "0x86D9", VA = "0x86D9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60036EB")]
			[Address(RVA = "0x86DA", Offset = "0x86DA", VA = "0x86DA")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000AD8 RID: 2776
		// (get) Token: 0x060036EC RID: 14060 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060036ED RID: 14061 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000AD8")]
		public BackTime BackTimer
		{
			[Token(Token = "0x60036EC")]
			[Address(RVA = "0x86DB", Offset = "0x86DB", VA = "0x86DB")]
			get
			{
				return null;
			}
			[Token(Token = "0x60036ED")]
			[Address(RVA = "0x86DC", Offset = "0x86DC", VA = "0x86DC")]
			private set
			{
			}
		}

		// Token: 0x060036EE RID: 14062 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60036EE")]
		[Address(RVA = "0x86DD", Offset = "0x86DD", VA = "0x86DD")]
		private void HandleBackTimerChanged()
		{
		}

		// Token: 0x060036EF RID: 14063 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60036EF")]
		[Address(RVA = "0x86DE", Offset = "0x86DE", VA = "0x86DE")]
		private IEnumerator ShowCurrentState()
		{
			return null;
		}

		// Token: 0x060036F0 RID: 14064 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60036F0")]
		[Address(RVA = "0x86DF", Offset = "0x86DF", VA = "0x86DF")]
		private void SetSpritesByDigit(int value)
		{
		}

		// Token: 0x060036F1 RID: 14065 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60036F1")]
		[Address(RVA = "0x86E0", Offset = "0x86E0", VA = "0x86E0")]
		private void StartScaling()
		{
		}

		// Token: 0x060036F2 RID: 14066 RVA: 0x0000B028 File Offset: 0x00009228
		[Token(Token = "0x60036F2")]
		[Address(RVA = "0x86E1", Offset = "0x86E1", VA = "0x86E1")]
		private bool TrySetLastValue(int value)
		{
			return default(bool);
		}

		// Token: 0x060036F3 RID: 14067 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60036F3")]
		[Address(RVA = "0x86E2", Offset = "0x86E2", VA = "0x86E2")]
		private void PlaySound(int value)
		{
		}

		// Token: 0x060036F4 RID: 14068 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60036F4")]
		[Address(RVA = "0x86E3", Offset = "0x86E3", VA = "0x86E3")]
		public void HideWaitingWindow()
		{
		}

		// Token: 0x060036F5 RID: 14069 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60036F5")]
		[Address(RVA = "0x86E4", Offset = "0x86E4", VA = "0x86E4")]
		public void SetTitle(string value)
		{
		}

		// Token: 0x060036F6 RID: 14070 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60036F6")]
		[Address(RVA = "0x86E5", Offset = "0x86E5", VA = "0x86E5")]
		public void SetDescription(string value)
		{
		}

		// Token: 0x060036F7 RID: 14071 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60036F7")]
		[Address(RVA = "0x86E6", Offset = "0x86E6", VA = "0x86E6")]
		private void OnDestroy()
		{
		}

		// Token: 0x060036F8 RID: 14072 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60036F8")]
		[Address(RVA = "0x86E7", Offset = "0x86E7", VA = "0x86E7", Slot = "19")]
		protected override void OnClose()
		{
		}

		// Token: 0x060036F9 RID: 14073 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60036F9")]
		[Address(RVA = "0x86E8", Offset = "0x86E8", VA = "0x86E8", Slot = "22")]
		protected override void OnShow(CombatWaitingWindowMono.CombatWaitingWindowArgs args)
		{
		}

		// Token: 0x060036FA RID: 14074 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60036FA")]
		[Address(RVA = "0x86E9", Offset = "0x86E9", VA = "0x86E9")]
		public CombatWaitingWindowMono()
		{
		}

		// Token: 0x04001E14 RID: 7700
		[Token(Token = "0x4001E14")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/Combat/CombatWaitingWindow";

		// Token: 0x04001E15 RID: 7701
		[Token(Token = "0x4001E15")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private TextMeshProUGUI _title;

		// Token: 0x04001E16 RID: 7702
		[Token(Token = "0x4001E16")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private TextMeshProUGUI _description;

		// Token: 0x04001E17 RID: 7703
		[Token(Token = "0x4001E17")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private Image _timeOutImage;

		// Token: 0x04001E18 RID: 7704
		[Token(Token = "0x4001E18")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameSpineUiAnimation _bgAnimation;

		// Token: 0x04001E19 RID: 7705
		[Token(Token = "0x4001E19")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private RectTransform _timeoutTransform;

		// Token: 0x04001E1A RID: 7706
		[Token(Token = "0x4001E1A")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Sprite[] _digidsSprites;

		// Token: 0x04001E1C RID: 7708
		[Token(Token = "0x4001E1C")]
		[FieldOffset(Offset = "0x50")]
		private BackTime _bactime;

		// Token: 0x04001E1D RID: 7709
		[Token(Token = "0x4001E1D")]
		[FieldOffset(Offset = "0x54")]
		private Tween _scaleTween;

		// Token: 0x04001E1E RID: 7710
		[Token(Token = "0x4001E1E")]
		[FieldOffset(Offset = "0x58")]
		private List<Image> _pool;

		// Token: 0x04001E1F RID: 7711
		[Token(Token = "0x4001E1F")]
		[FieldOffset(Offset = "0x5C")]
		private int _lastValue;

		// Token: 0x0200091C RID: 2332
		[Token(Token = "0x200091C")]
		public class CombatWaitingWindowArgs : BaseWindowArgs
		{
			// Token: 0x060036FB RID: 14075 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60036FB")]
			[Address(RVA = "0x86EA", Offset = "0x86EA", VA = "0x86EA")]
			public CombatWaitingWindowArgs(BackTime backTimer, IGameAudio gameAudio)
			{
			}

			// Token: 0x04001E20 RID: 7712
			[Token(Token = "0x4001E20")]
			[FieldOffset(Offset = "0x18")]
			public readonly IGameAudio GameAudio;

			// Token: 0x04001E21 RID: 7713
			[Token(Token = "0x4001E21")]
			[FieldOffset(Offset = "0x1C")]
			public readonly BackTime BackTimer;
		}
	}
}
