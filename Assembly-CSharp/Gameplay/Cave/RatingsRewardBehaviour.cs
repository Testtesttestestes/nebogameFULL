using System;
using System.Runtime.CompilerServices;
using Core.Gameplay;
using Il2CppDummyDll;
using Protocol.Common;
using Protocol.Consts;

namespace Gameplay.Cave
{
	// Token: 0x02000B2F RID: 2863
	[Token(Token = "0x2000B2F")]
	public class RatingsRewardBehaviour : BaseRewardBehaviour
	{
		// Token: 0x17000DB5 RID: 3509
		// (get) Token: 0x06004597 RID: 17815 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000DB5")]
		public override RewardTypes[] RewardTypesList
		{
			[Token(Token = "0x6004597")]
			[Address(RVA = "0x9439", Offset = "0x9439", VA = "0x9439", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x06004598 RID: 17816 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004598")]
		[Address(RVA = "0x943A", Offset = "0x943A", VA = "0x943A", Slot = "5")]
		public override CaveModel.RewardInCave GetReward(IGame game, RewardInfo info)
		{
			return null;
		}

		// Token: 0x06004599 RID: 17817 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004599")]
		[Address(RVA = "0x943B", Offset = "0x943B", VA = "0x943B")]
		public RatingsRewardBehaviour()
		{
		}
	}
}
