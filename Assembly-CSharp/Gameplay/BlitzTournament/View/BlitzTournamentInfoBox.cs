using System;
using Core.Data;
using Core.Money;
using Il2CppDummyDll;
using TMPro;
using UI;
using UI.Elements.Buttons;
using UI.Rewards;
using UnityEngine;

namespace Gameplay.BlitzTournament.View
{
	// Token: 0x02000BC4 RID: 3012
	[Token(Token = "0x2000BC4")]
	public class BlitzTournamentInfoBox : MonoBehaviourWithStates<BlitzTournamentInfoBox.State>
	{
		// Token: 0x17000EEB RID: 3819
		// (get) Token: 0x060049D9 RID: 18905 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000EEB")]
		public ButtonWithCost EnterTournamentButton
		{
			[Token(Token = "0x60049D9")]
			[Address(RVA = "0x9843", Offset = "0x9843", VA = "0x9843")]
			get
			{
				return null;
			}
		}

		// Token: 0x060049DA RID: 18906 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60049DA")]
		[Address(RVA = "0x9844", Offset = "0x9844", VA = "0x9844")]
		public void SetState(BlitzTournamentInfoBox.State state)
		{
		}

		// Token: 0x060049DB RID: 18907 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60049DB")]
		[Address(RVA = "0x9845", Offset = "0x9845", VA = "0x9845")]
		public void SetParticipantsCount(uint count, uint maxCount)
		{
		}

		// Token: 0x060049DC RID: 18908 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60049DC")]
		[Address(RVA = "0x9846", Offset = "0x9846", VA = "0x9846")]
		public void RenderRewards(RewardData[] rewards)
		{
		}

		// Token: 0x060049DD RID: 18909 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60049DD")]
		[Address(RVA = "0x9847", Offset = "0x9847", VA = "0x9847")]
		public void SetTitle(string title)
		{
		}

		// Token: 0x060049DE RID: 18910 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60049DE")]
		[Address(RVA = "0x9848", Offset = "0x9848", VA = "0x9848")]
		public void SetDescription(string text)
		{
		}

		// Token: 0x060049DF RID: 18911 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60049DF")]
		[Address(RVA = "0x9849", Offset = "0x9849", VA = "0x9849")]
		public void UpdatePriceButtonView(UserData user, Money resources, string label)
		{
		}

		// Token: 0x060049E0 RID: 18912 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60049E0")]
		[Address(RVA = "0x984A", Offset = "0x984A", VA = "0x984A")]
		public BlitzTournamentInfoBox()
		{
		}

		// Token: 0x04002825 RID: 10277
		[Token(Token = "0x4002825")]
		private const string LOCALIZATION_PARTICIPANTS = "BLITZ/PARTICIPANTS";

		// Token: 0x04002826 RID: 10278
		[Token(Token = "0x4002826")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private TextMeshProUGUI _title;

		// Token: 0x04002827 RID: 10279
		[Token(Token = "0x4002827")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TextMeshProUGUI _description;

		// Token: 0x04002828 RID: 10280
		[Token(Token = "0x4002828")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private RewardsRender _rewardsView;

		// Token: 0x04002829 RID: 10281
		[Token(Token = "0x4002829")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ButtonWithCost _priceButton;

		// Token: 0x0400282A RID: 10282
		[Token(Token = "0x400282A")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private TextMeshProUGUI _participants;

		// Token: 0x02000BC5 RID: 3013
		[Token(Token = "0x2000BC5")]
		public enum State
		{
			// Token: 0x0400282C RID: 10284
			[Token(Token = "0x400282C")]
			UNKNOWN,
			// Token: 0x0400282D RID: 10285
			[Token(Token = "0x400282D")]
			TOURNAMENT_VIEW = 3,
			// Token: 0x0400282E RID: 10286
			[Token(Token = "0x400282E")]
			IN_QUEUE
		}
	}
}
