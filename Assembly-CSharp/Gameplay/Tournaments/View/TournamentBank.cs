using System;
using AssetContent;
using Core.Data;
using Core.Money;
using Il2CppDummyDll;
using Protocol.Consts;
using UI.Price;
using UI.Rewards;
using UnityEngine;

namespace Gameplay.Tournaments.View
{
	// Token: 0x020004A4 RID: 1188
	[Token(Token = "0x20004A4")]
	public class TournamentBank : MonoBehaviour
	{
		// Token: 0x06001C11 RID: 7185 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C11")]
		[Address(RVA = "0x6D90", Offset = "0x6D90", VA = "0x6D90")]
		private void Start()
		{
		}

		// Token: 0x06001C12 RID: 7186 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C12")]
		[Address(RVA = "0x6D91", Offset = "0x6D91", VA = "0x6D91")]
		public void RenderRewards(RewardData[] rewards, Money gladiatorsResources, Money viewersResources, Protocol.Consts.Resources betResource)
		{
		}

		// Token: 0x06001C13 RID: 7187 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C13")]
		[Address(RVA = "0x6D92", Offset = "0x6D92", VA = "0x6D92")]
		public void ChangeGladiatorsBank(Money resources)
		{
		}

		// Token: 0x06001C14 RID: 7188 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C14")]
		[Address(RVA = "0x6D93", Offset = "0x6D93", VA = "0x6D93")]
		public TournamentBank()
		{
		}

		// Token: 0x04000F2A RID: 3882
		[Token(Token = "0x4000F2A")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private RewardsRender _gladiatorsRewards;

		// Token: 0x04000F2B RID: 3883
		[Token(Token = "0x4000F2B")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Price _gladiatorsBank;

		// Token: 0x04000F2C RID: 3884
		[Token(Token = "0x4000F2C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Price _viewersBank;

		// Token: 0x04000F2D RID: 3885
		[Token(Token = "0x4000F2D")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private GameImage _resourceImage;
	}
}
