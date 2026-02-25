using System;
using System.Runtime.CompilerServices;
using Core.Gameplay;
using Il2CppDummyDll;
using Protocol.Common;
using Protocol.Consts;

namespace Gameplay.Cave
{
	// Token: 0x02000B30 RID: 2864
	[Token(Token = "0x2000B30")]
	public class ResourceRewardBehaviour : BaseRewardBehaviour
	{
		// Token: 0x17000DB6 RID: 3510
		// (get) Token: 0x0600459A RID: 17818 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000DB6")]
		public override RewardTypes[] RewardTypesList
		{
			[Token(Token = "0x600459A")]
			[Address(RVA = "0x943C", Offset = "0x943C", VA = "0x943C", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x0600459B RID: 17819 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600459B")]
		[Address(RVA = "0x943D", Offset = "0x943D", VA = "0x943D", Slot = "5")]
		public override CaveModel.RewardInCave GetReward(IGame game, RewardInfo info)
		{
			return null;
		}

		// Token: 0x0600459C RID: 17820 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600459C")]
		[Address(RVA = "0x943E", Offset = "0x943E", VA = "0x943E")]
		public ResourceRewardBehaviour()
		{
		}
	}
}
