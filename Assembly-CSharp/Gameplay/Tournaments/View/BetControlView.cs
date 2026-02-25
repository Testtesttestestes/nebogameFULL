using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Money;
using Il2CppDummyDll;
using Protocol.Common;
using Protocol.Consts;
using TMPro;
using UI;
using UI.Elements.Buttons;
using UI.Price;
using UnityEngine;

namespace Gameplay.Tournaments.View
{
	// Token: 0x020004A3 RID: 1187
	[Token(Token = "0x20004A3")]
	public class BetControlView : MonoBehaviour
	{
		// Token: 0x170004EE RID: 1262
		// (get) Token: 0x06001C05 RID: 7173 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170004EE")]
		public TextMeshProUGUI PlayerStatus
		{
			[Token(Token = "0x6001C05")]
			[Address(RVA = "0x6D84", Offset = "0x6D84", VA = "0x6D84")]
			get
			{
				return null;
			}
		}

		// Token: 0x14000134 RID: 308
		// (add) Token: 0x06001C06 RID: 7174 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06001C07 RID: 7175 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000134")]
		public event Action<ResourceSet> BetAddedEvent
		{
			[Token(Token = "0x6001C06")]
			[Address(RVA = "0x6D85", Offset = "0x6D85", VA = "0x6D85")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6001C07")]
			[Address(RVA = "0x6D86", Offset = "0x6D86", VA = "0x6D86")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06001C08 RID: 7176 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C08")]
		[Address(RVA = "0x6D87", Offset = "0x6D87", VA = "0x6D87")]
		private void Awake()
		{
		}

		// Token: 0x06001C09 RID: 7177 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C09")]
		[Address(RVA = "0x6D88", Offset = "0x6D88", VA = "0x6D88")]
		private void OnDestroy()
		{
		}

		// Token: 0x06001C0A RID: 7178 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C0A")]
		[Address(RVA = "0x6D89", Offset = "0x6D89", VA = "0x6D89")]
		private void PriceButtonClickedEventHandler()
		{
		}

		// Token: 0x06001C0B RID: 7179 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C0B")]
		[Address(RVA = "0x6D8A", Offset = "0x6D8A", VA = "0x6D8A")]
		private void InputChangedEventHandler(int value)
		{
		}

		// Token: 0x06001C0C RID: 7180 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C0C")]
		[Address(RVA = "0x6D8B", Offset = "0x6D8B", VA = "0x6D8B")]
		private void SetNewPrice(int value)
		{
		}

		// Token: 0x06001C0D RID: 7181 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C0D")]
		[Address(RVA = "0x6D8C", Offset = "0x6D8C", VA = "0x6D8C")]
		public void Init(Money gladiatorsBet, Money viewersBet, Money playerBet)
		{
		}

		// Token: 0x06001C0E RID: 7182 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C0E")]
		[Address(RVA = "0x6D8D", Offset = "0x6D8D", VA = "0x6D8D")]
		public void UpdateGladiatorsBet(Money bet)
		{
		}

		// Token: 0x06001C0F RID: 7183 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C0F")]
		[Address(RVA = "0x6D8E", Offset = "0x6D8E", VA = "0x6D8E")]
		public void UpdatePlayerBet(Money bet)
		{
		}

		// Token: 0x06001C10 RID: 7184 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C10")]
		[Address(RVA = "0x6D8F", Offset = "0x6D8F", VA = "0x6D8F")]
		public BetControlView()
		{
		}

		// Token: 0x04000F1F RID: 3871
		[Token(Token = "0x4000F1F")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private NumbersInput _input;

		// Token: 0x04000F20 RID: 3872
		[Token(Token = "0x4000F20")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private ButtonWithCost _priceButton;

		// Token: 0x04000F21 RID: 3873
		[Token(Token = "0x4000F21")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Price _gladiatorsBet;

		// Token: 0x04000F22 RID: 3874
		[Token(Token = "0x4000F22")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private Price _viewersBet;

		// Token: 0x04000F23 RID: 3875
		[Token(Token = "0x4000F23")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Price _playerBet;

		// Token: 0x04000F24 RID: 3876
		[Token(Token = "0x4000F24")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private PriceItemRenderer _validationRenderer;

		// Token: 0x04000F25 RID: 3877
		[Token(Token = "0x4000F25")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TextMeshProUGUI _playerStatus;

		// Token: 0x04000F26 RID: 3878
		[Token(Token = "0x4000F26")]
		[FieldOffset(Offset = "0x2C")]
		private Protocol.Consts.Resources _currency;

		// Token: 0x04000F27 RID: 3879
		[Token(Token = "0x4000F27")]
		[FieldOffset(Offset = "0x30")]
		private UserData _user;

		// Token: 0x04000F28 RID: 3880
		[Token(Token = "0x4000F28")]
		[FieldOffset(Offset = "0x38")]
		private double _minBetValue;
	}
}
