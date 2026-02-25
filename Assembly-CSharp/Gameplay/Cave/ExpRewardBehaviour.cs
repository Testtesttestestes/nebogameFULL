using System;
using System.Runtime.CompilerServices;
using Core.Gameplay;
using Il2CppDummyDll;
using Protocol.Common;
using Protocol.Consts;

namespace Gameplay.Cave
{
	// Token: 0x02000B2E RID: 2862
	[Token(Token = "0x2000B2E")]
	public class ExpRewardBehaviour : BaseRewardBehaviour
	{
		// Token: 0x17000DB4 RID: 3508
		// (get) Token: 0x06004594 RID: 17812 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000DB4")]
		public override RewardTypes[] RewardTypesList
		{
			[Token(Token = "0x6004594")]
			[Address(RVA = "0x9436", Offset = "0x9436", VA = "0x9436", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x06004595 RID: 17813 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004595")]
		[Address(RVA = "0x9437", Offset = "0x9437", VA = "0x9437", Slot = "5")]
		public override CaveModel.RewardInCave GetReward(IGame game, RewardInfo info)
		{
			return null;
		}

		// Token: 0x06004596 RID: 17814 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004596")]
		[Address(RVA = "0x9438", Offset = "0x9438", VA = "0x9438")]
		public ExpRewardBehaviour()
		{
		}
	}
}
