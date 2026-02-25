using System;
using AssetContent;
using Core.Data.Effect;
using Il2CppDummyDll;
using TMPro;
using UI.ToolTip;
using UnityEngine;
using Utils;

namespace Gameplay.Combat.View.Players.LongEffects
{
	// Token: 0x02000959 RID: 2393
	[Token(Token = "0x2000959")]
	public class LongEffect : MonoBehaviour, IToolTipDataProvider
	{
		// Token: 0x17000B2F RID: 2863
		// (get) Token: 0x060038BC RID: 14524 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000B2F")]
		protected TextMeshProUGUI StackField
		{
			[Token(Token = "0x60038BC")]
			[Address(RVA = "0x885A", Offset = "0x885A", VA = "0x885A")]
			get
			{
				return null;
			}
		}

		// Token: 0x060038BD RID: 14525 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60038BD")]
		[Address(RVA = "0x885B", Offset = "0x885B", VA = "0x885B")]
		private void OnDestroy()
		{
		}

		// Token: 0x17000B30 RID: 2864
		// (get) Token: 0x060038BE RID: 14526 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060038BF RID: 14527 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B30")]
		public EffectData Data
		{
			[Token(Token = "0x60038BE")]
			[Address(RVA = "0x885C", Offset = "0x885C", VA = "0x885C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60038BF")]
			[Address(RVA = "0x885D", Offset = "0x885D", VA = "0x885D")]
			set
			{
			}
		}

		// Token: 0x060038C0 RID: 14528 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60038C0")]
		[Address(RVA = "0x885E", Offset = "0x885E", VA = "0x885E")]
		private void HandleDataChanged()
		{
		}

		// Token: 0x060038C1 RID: 14529 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60038C1")]
		[Address(RVA = "0x885F", Offset = "0x885F", VA = "0x885F", Slot = "5")]
		protected virtual void SetupIcon(EffectData data)
		{
		}

		// Token: 0x060038C2 RID: 14530 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60038C2")]
		[Address(RVA = "0x8860", Offset = "0x8860", VA = "0x8860", Slot = "6")]
		protected virtual void SetupColor(EffectData data)
		{
		}

		// Token: 0x060038C3 RID: 14531 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60038C3")]
		[Address(RVA = "0x8861", Offset = "0x8861", VA = "0x8861", Slot = "7")]
		protected virtual void SetupVisibleStackValue(EffectData data)
		{
		}

		// Token: 0x060038C4 RID: 14532 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60038C4")]
		[Address(RVA = "0x8862", Offset = "0x8862", VA = "0x8862")]
		private void SetTimeLeft(uint steps, long time)
		{
		}

		// Token: 0x060038C5 RID: 14533 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60038C5")]
		[Address(RVA = "0x8863", Offset = "0x8863", VA = "0x8863")]
		private void OnEnable()
		{
		}

		// Token: 0x060038C6 RID: 14534 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60038C6")]
		[Address(RVA = "0x8864", Offset = "0x8864", VA = "0x8864", Slot = "4")]
		public BaseToolTipData GetData()
		{
			return null;
		}

		// Token: 0x060038C7 RID: 14535 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60038C7")]
		[Address(RVA = "0x8865", Offset = "0x8865", VA = "0x8865")]
		public LongEffect()
		{
		}

		// Token: 0x04001F55 RID: 8021
		[Token(Token = "0x4001F55")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		protected GameRawImage _image;

		// Token: 0x04001F56 RID: 8022
		[Token(Token = "0x4001F56")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private TextMeshProUGUI _stackField;

		// Token: 0x04001F57 RID: 8023
		[Token(Token = "0x4001F57")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TextMeshProUGUI _stepsField;

		// Token: 0x04001F58 RID: 8024
		[Token(Token = "0x4001F58")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private Color TextColor;

		// Token: 0x04001F59 RID: 8025
		[Token(Token = "0x4001F59")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private string _stackValuePrefix;

		// Token: 0x04001F5A RID: 8026
		[Token(Token = "0x4001F5A")]
		[FieldOffset(Offset = "0x30")]
		private readonly TweenContainer _tweenContainer;

		// Token: 0x04001F5B RID: 8027
		[Token(Token = "0x4001F5B")]
		[FieldOffset(Offset = "0x34")]
		private EffectData _data;

		// Token: 0x04001F5C RID: 8028
		[Token(Token = "0x4001F5C")]
		public const float ZOOM_OUT_DURATION = 0.4f;
	}
}
