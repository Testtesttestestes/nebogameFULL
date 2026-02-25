using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Core.Animations;
using DG.Tweening;
using Gameplay.Sound.Control;
using Il2CppDummyDll;
using Protocol.Combat;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Utils;

namespace Gameplay.Combat.View.TurnDisplay
{
	// Token: 0x02000935 RID: 2357
	[Token(Token = "0x2000935")]
	public class TurnClock : MonoBehaviour
	{
		// Token: 0x17000AF5 RID: 2805
		// (get) Token: 0x0600379A RID: 14234 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600379B RID: 14235 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000AF5")]
		public IGameAudio GameAudio
		{
			[Token(Token = "0x600379A")]
			[Address(RVA = "0x877C", Offset = "0x877C", VA = "0x877C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600379B")]
			[Address(RVA = "0x877D", Offset = "0x877D", VA = "0x877D")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000AF6 RID: 2806
		// (get) Token: 0x0600379C RID: 14236 RVA: 0x0000B268 File Offset: 0x00009468
		// (set) Token: 0x0600379D RID: 14237 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000AF6")]
		public bool IsUseScaleWhenSetDuration
		{
			[Token(Token = "0x600379C")]
			[Address(RVA = "0x877E", Offset = "0x877E", VA = "0x877E")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600379D")]
			[Address(RVA = "0x877F", Offset = "0x877F", VA = "0x877F")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000AF7 RID: 2807
		// (get) Token: 0x0600379E RID: 14238 RVA: 0x0000B280 File Offset: 0x00009480
		// (set) Token: 0x0600379F RID: 14239 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000AF7")]
		public TurnStates TurnState
		{
			[Token(Token = "0x600379E")]
			[Address(RVA = "0x8780", Offset = "0x8780", VA = "0x8780")]
			[CompilerGenerated]
			get
			{
				return TurnStates.NoTurn;
			}
			[Token(Token = "0x600379F")]
			[Address(RVA = "0x8781", Offset = "0x8781", VA = "0x8781")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060037A0 RID: 14240 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60037A0")]
		[Address(RVA = "0x8782", Offset = "0x8782", VA = "0x8782")]
		public void SetDuration(int value)
		{
		}

		// Token: 0x17000AF8 RID: 2808
		// (set) Token: 0x060037A1 RID: 14241 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000AF8")]
		private bool WarningEnabled
		{
			[Token(Token = "0x60037A1")]
			[Address(RVA = "0x8783", Offset = "0x8783", VA = "0x8783")]
			set
			{
			}
		}

		// Token: 0x060037A2 RID: 14242 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60037A2")]
		[Address(RVA = "0x8784", Offset = "0x8784", VA = "0x8784")]
		private void HandleSetDuration(float value)
		{
		}

		// Token: 0x060037A3 RID: 14243 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60037A3")]
		[Address(RVA = "0x8785", Offset = "0x8785", VA = "0x8785")]
		private void SetEnableAnimations(bool value)
		{
		}

		// Token: 0x060037A4 RID: 14244 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60037A4")]
		[Address(RVA = "0x8786", Offset = "0x8786", VA = "0x8786")]
		private void HandleEnableAnimationChanged()
		{
		}

		// Token: 0x060037A5 RID: 14245 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60037A5")]
		[Address(RVA = "0x8787", Offset = "0x8787", VA = "0x8787")]
		private IEnumerator EdgeFillRoutine()
		{
			return null;
		}

		// Token: 0x060037A6 RID: 14246 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60037A6")]
		[Address(RVA = "0x8788", Offset = "0x8788", VA = "0x8788")]
		private IEnumerator TimerRoutine()
		{
			return null;
		}

		// Token: 0x060037A7 RID: 14247 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60037A7")]
		[Address(RVA = "0x8789", Offset = "0x8789", VA = "0x8789")]
		private void DisplayBackTime(float value)
		{
		}

		// Token: 0x060037A8 RID: 14248 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60037A8")]
		[Address(RVA = "0x878A", Offset = "0x878A", VA = "0x878A")]
		private void DisplayBackTimeScaleOut(float value)
		{
		}

		// Token: 0x060037A9 RID: 14249 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60037A9")]
		[Address(RVA = "0x878B", Offset = "0x878B", VA = "0x878B")]
		private void OnDestroy()
		{
		}

		// Token: 0x060037AA RID: 14250 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60037AA")]
		[Address(RVA = "0x878C", Offset = "0x878C", VA = "0x878C")]
		public void Test()
		{
		}

		// Token: 0x060037AB RID: 14251 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60037AB")]
		[Address(RVA = "0x878D", Offset = "0x878D", VA = "0x878D")]
		public TurnClock()
		{
		}

		// Token: 0x04001EAD RID: 7853
		[Token(Token = "0x4001EAD")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private GameSpineUiAnimation[] _animations;

		// Token: 0x04001EAE RID: 7854
		[Token(Token = "0x4001EAE")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private GameSpineUiAnimation _edge;

		// Token: 0x04001EAF RID: 7855
		[Token(Token = "0x4001EAF")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _mask;

		// Token: 0x04001EB0 RID: 7856
		[Token(Token = "0x4001EB0")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private TextMeshProUGUI _backtimeField;

		// Token: 0x04001EB1 RID: 7857
		[Token(Token = "0x4001EB1")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Color _thresholdWarningColor;

		// Token: 0x04001EB2 RID: 7858
		[Token(Token = "0x4001EB2")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Color _defaultColor;

		// Token: 0x04001EB3 RID: 7859
		[Token(Token = "0x4001EB3")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Vector3 _displayedValueScale;

		// Token: 0x04001EB4 RID: 7860
		[Token(Token = "0x4001EB4")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private float _thresholdWarningValue;

		// Token: 0x04001EB5 RID: 7861
		[Token(Token = "0x4001EB5")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private float _scaleDuration;

		// Token: 0x04001EB6 RID: 7862
		[Token(Token = "0x4001EB6")]
		public const float FULL_ANGLE = 360f;

		// Token: 0x04001EB7 RID: 7863
		[Token(Token = "0x4001EB7")]
		public const float REDRAW_RATE = 0.03f;

		// Token: 0x04001EB8 RID: 7864
		[Token(Token = "0x4001EB8")]
		[FieldOffset(Offset = "0x54")]
		private bool _enableAnimation;

		// Token: 0x04001EB9 RID: 7865
		[Token(Token = "0x4001EB9")]
		[FieldOffset(Offset = "0x55")]
		private bool _warningEnabled;

		// Token: 0x04001EBA RID: 7866
		[Token(Token = "0x4001EBA")]
		[FieldOffset(Offset = "0x58")]
		private Tween _scaleTween;

		// Token: 0x04001EBB RID: 7867
		[Token(Token = "0x4001EBB")]
		[FieldOffset(Offset = "0x5C")]
		private BackTime _backTime;

		// Token: 0x04001EBC RID: 7868
		[Token(Token = "0x4001EBC")]
		[FieldOffset(Offset = "0x60")]
		private Coroutine _timerRoutine;

		// Token: 0x04001EBD RID: 7869
		[Token(Token = "0x4001EBD")]
		[FieldOffset(Offset = "0x64")]
		private Coroutine _edgeRoutine;

		// Token: 0x04001EC1 RID: 7873
		[Token(Token = "0x4001EC1")]
		[FieldOffset(Offset = "0x74")]
		[SerializeField]
		private float _testDuration;
	}
}
