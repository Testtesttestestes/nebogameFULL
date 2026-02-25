using System;
using Core.Gameplay;
using Il2CppDummyDll;
using Protocol.Common;
using Protocol.Consts;

namespace Gameplay.Cave
{
	// Token: 0x02000B2D RID: 2861
	[Token(Token = "0x2000B2D")]
	public abstract class BaseRewardBehaviour
	{
		// Token: 0x17000DB3 RID: 3507
		// (get) Token: 0x06004591 RID: 17809
		[Token(Token = "0x17000DB3")]
		public abstract RewardTypes[] RewardTypesList { [Token(Token = "0x6004591")] get; }

		// Token: 0x06004592 RID: 17810
		[Token(Token = "0x6004592")]
		public abstract CaveModel.RewardInCave GetReward(IGame game, RewardInfo info);

		// Token: 0x06004593 RID: 17811 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004593")]
		[Address(RVA = "0x9435", Offset = "0x9435", VA = "0x9435")]
		protected BaseRewardBehaviour()
		{
		}
	}
}
