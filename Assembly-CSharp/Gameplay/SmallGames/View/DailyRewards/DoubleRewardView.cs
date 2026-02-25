using System;
using Il2CppDummyDll;
using Protocol.SmallGames;
using UI.Rewards;
using UnityEngine;

namespace Gameplay.SmallGames.View.DailyRewards
{
	// Token: 0x0200052F RID: 1327
	[Token(Token = "0x200052F")]
	public class DoubleRewardView : SingleRewardView
	{
		// Token: 0x06001F95 RID: 8085 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F95")]
		[Address(RVA = "0x70FA", Offset = "0x70FA", VA = "0x70FA", Slot = "5")]
		public override void Init(ProtoRegisterVisitAns.Types.DailyRewards data, string title, SingleRewardView.State state)
		{
		}

		// Token: 0x06001F96 RID: 8086 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F96")]
		[Address(RVA = "0x70FB", Offset = "0x70FB", VA = "0x70FB")]
		public void InitSecondArtikul(ProtoRegisterVisitAns.Types.DailyRewards data, SingleRewardView.State state)
		{
		}

		// Token: 0x06001F97 RID: 8087 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F97")]
		[Address(RVA = "0x70FC", Offset = "0x70FC", VA = "0x70FC")]
		public DoubleRewardView()
		{
		}

		// Token: 0x04001149 RID: 4425
		[Token(Token = "0x4001149")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		protected RewardsRender _secondArtikulRender;
	}
}
