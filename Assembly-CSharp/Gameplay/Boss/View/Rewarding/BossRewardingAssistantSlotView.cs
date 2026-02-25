using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Protocol.Boss;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Boss.View.Rewarding
{
	// Token: 0x02000B5C RID: 2908
	[Token(Token = "0x2000B5C")]
	public class BossRewardingAssistantSlotView : AbstractBossRewardingSlotView
	{
		// Token: 0x140001B4 RID: 436
		// (add) Token: 0x06004668 RID: 18024 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06004669 RID: 18025 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001B4")]
		public event Action<BossRewardingAssistantSlotView> ClickEvent
		{
			[Token(Token = "0x6004668")]
			[Address(RVA = "0x94FF", Offset = "0x94FF", VA = "0x94FF")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6004669")]
			[Address(RVA = "0x9500", Offset = "0x9500", VA = "0x9500")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000DE6 RID: 3558
		// (get) Token: 0x0600466A RID: 18026 RVA: 0x0000D200 File Offset: 0x0000B400
		// (set) Token: 0x0600466B RID: 18027 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000DE6")]
		public bool Editable
		{
			[Token(Token = "0x600466A")]
			[Address(RVA = "0x9501", Offset = "0x9501", VA = "0x9501")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600466B")]
			[Address(RVA = "0x9502", Offset = "0x9502", VA = "0x9502")]
			set
			{
			}
		}

		// Token: 0x17000DE7 RID: 3559
		// (get) Token: 0x0600466C RID: 18028 RVA: 0x0000D218 File Offset: 0x0000B418
		// (set) Token: 0x0600466D RID: 18029 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000DE7")]
		public bool Selected
		{
			[Token(Token = "0x600466C")]
			[Address(RVA = "0x9503", Offset = "0x9503", VA = "0x9503")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600466D")]
			[Address(RVA = "0x9504", Offset = "0x9504", VA = "0x9504")]
			set
			{
			}
		}

		// Token: 0x17000DE8 RID: 3560
		// (get) Token: 0x0600466E RID: 18030 RVA: 0x0000D230 File Offset: 0x0000B430
		// (set) Token: 0x0600466F RID: 18031 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000DE8")]
		public ulong OwnerId
		{
			[Token(Token = "0x600466E")]
			[Address(RVA = "0x9505", Offset = "0x9505", VA = "0x9505")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x600466F")]
			[Address(RVA = "0x9506", Offset = "0x9506", VA = "0x9506")]
			set
			{
			}
		}

		// Token: 0x17000DE9 RID: 3561
		// (set) Token: 0x06004670 RID: 18032 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000DE9")]
		public override bool Interactable
		{
			[Token(Token = "0x6004670")]
			[Address(RVA = "0x9507", Offset = "0x9507", VA = "0x9507", Slot = "8")]
			set
			{
			}
		}

		// Token: 0x17000DEA RID: 3562
		// (set) Token: 0x06004671 RID: 18033 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000DEA")]
		public override GetTeamRewardsAns.Types.BossRewardInfo BossRewardInfo
		{
			[Token(Token = "0x6004671")]
			[Address(RVA = "0x9508", Offset = "0x9508", VA = "0x9508", Slot = "5")]
			set
			{
			}
		}

		// Token: 0x06004672 RID: 18034 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004672")]
		[Address(RVA = "0x9509", Offset = "0x9509", VA = "0x9509")]
		private void ValidateInteractable()
		{
		}

		// Token: 0x06004673 RID: 18035 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004673")]
		[Address(RVA = "0x950A", Offset = "0x950A", VA = "0x950A", Slot = "6")]
		protected override void HandleClick()
		{
		}

		// Token: 0x06004674 RID: 18036 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004674")]
		[Address(RVA = "0x950B", Offset = "0x950B", VA = "0x950B")]
		public BossRewardingAssistantSlotView()
		{
		}

		// Token: 0x04002686 RID: 9862
		[Token(Token = "0x4002686")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private Image _plusIcon;

		// Token: 0x04002688 RID: 9864
		[Token(Token = "0x4002688")]
		[FieldOffset(Offset = "0x2C")]
		private bool _editable;

		// Token: 0x04002689 RID: 9865
		[Token(Token = "0x4002689")]
		[FieldOffset(Offset = "0x2D")]
		private bool _selected;

		// Token: 0x0400268A RID: 9866
		[Token(Token = "0x400268A")]
		[FieldOffset(Offset = "0x30")]
		private ulong _ownerId;
	}
}
