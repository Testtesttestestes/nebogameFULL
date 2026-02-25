using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data.Balance;
using Gameplay.Clans.Office.Model;
using Il2CppDummyDll;
using Protocol.Dic;
using TMPro;
using UI;
using UI.Elements.Buttons;
using UnityEngine;

namespace Gameplay.Clans.Office.View.SquadTab
{
	// Token: 0x02000A10 RID: 2576
	[Token(Token = "0x2000A10")]
	public class SquadListElement : MonoBehaviourWithStates<SquadListElement.State>
	{
		// Token: 0x14000193 RID: 403
		// (add) Token: 0x06003D35 RID: 15669 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06003D36 RID: 15670 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000193")]
		public event Action<MemberSlotView, SquadListElement> JoinButtonClickedEvent
		{
			[Token(Token = "0x6003D35")]
			[Address(RVA = "0x8BF5", Offset = "0x8BF5", VA = "0x8BF5")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6003D36")]
			[Address(RVA = "0x8BF6", Offset = "0x8BF6", VA = "0x8BF6")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000194 RID: 404
		// (add) Token: 0x06003D37 RID: 15671 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06003D38 RID: 15672 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000194")]
		public event Action<MemberSlotView, SquadListElement> CrossButtonClickedEvent
		{
			[Token(Token = "0x6003D37")]
			[Address(RVA = "0x8BF7", Offset = "0x8BF7", VA = "0x8BF7")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6003D38")]
			[Address(RVA = "0x8BF8", Offset = "0x8BF8", VA = "0x8BF8")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000C1B RID: 3099
		// (get) Token: 0x06003D39 RID: 15673 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000C1B")]
		public ButtonWithCost RentButton
		{
			[Token(Token = "0x6003D39")]
			[Address(RVA = "0x8BF9", Offset = "0x8BF9", VA = "0x8BF9")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C1C RID: 3100
		// (get) Token: 0x06003D3A RID: 15674 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003D3B RID: 15675 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C1C")]
		public SquadModel.PartyData PartyData
		{
			[Token(Token = "0x6003D3A")]
			[Address(RVA = "0x8BFA", Offset = "0x8BFA", VA = "0x8BFA")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003D3B")]
			[Address(RVA = "0x8BFB", Offset = "0x8BFB", VA = "0x8BFB")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000C1D RID: 3101
		// (get) Token: 0x06003D3C RID: 15676 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003D3D RID: 15677 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C1D")]
		public ColossusPartiesInfoDic Dic
		{
			[Token(Token = "0x6003D3C")]
			[Address(RVA = "0x8BFC", Offset = "0x8BFC", VA = "0x8BFC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003D3D")]
			[Address(RVA = "0x8BFD", Offset = "0x8BFD", VA = "0x8BFD")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06003D3E RID: 15678 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D3E")]
		[Address(RVA = "0x8BFE", Offset = "0x8BFE", VA = "0x8BFE")]
		public void Init(ColossusPartiesInfoDic dic, IList<ColossusSlotsInfoDic> slots, IBalanceSource treasury)
		{
		}

		// Token: 0x06003D3F RID: 15679 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D3F")]
		[Address(RVA = "0x8BFF", Offset = "0x8BFF", VA = "0x8BFF")]
		public void UpdateParty(SquadModel.PartyData party)
		{
		}

		// Token: 0x06003D40 RID: 15680 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D40")]
		[Address(RVA = "0x8C00", Offset = "0x8C00", VA = "0x8C00")]
		private void JoinButtonClickedEventHandler(MemberSlotView slot)
		{
		}

		// Token: 0x06003D41 RID: 15681 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D41")]
		[Address(RVA = "0x8C01", Offset = "0x8C01", VA = "0x8C01")]
		private void CrossButtonClickedEventHandler(MemberSlotView slot)
		{
		}

		// Token: 0x06003D42 RID: 15682 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D42")]
		[Address(RVA = "0x8C02", Offset = "0x8C02", VA = "0x8C02")]
		public SquadListElement()
		{
		}

		// Token: 0x04002209 RID: 8713
		[Token(Token = "0x4002209")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private TextMeshProUGUI _title;

		// Token: 0x0400220A RID: 8714
		[Token(Token = "0x400220A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _content;

		// Token: 0x0400220B RID: 8715
		[Token(Token = "0x400220B")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private MemberSlotView _slotPrefab;

		// Token: 0x0400220C RID: 8716
		[Token(Token = "0x400220C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RectTransform _titleGroup;

		// Token: 0x0400220D RID: 8717
		[Token(Token = "0x400220D")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private ButtonWithCost _costButton;

		// Token: 0x0400220E RID: 8718
		[Token(Token = "0x400220E")]
		[FieldOffset(Offset = "0x30")]
		private MemberSlotView[] _slots;

		// Token: 0x02000A11 RID: 2577
		[Token(Token = "0x2000A11")]
		public enum State
		{
			// Token: 0x04002214 RID: 8724
			[Token(Token = "0x4002214")]
			UNKNOWN_STATE,
			// Token: 0x04002215 RID: 8725
			[Token(Token = "0x4002215")]
			OPENED,
			// Token: 0x04002216 RID: 8726
			[Token(Token = "0x4002216")]
			CLOSED
		}
	}
}
