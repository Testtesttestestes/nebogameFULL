using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Il2CppDummyDll;
using Protocol.Combat;

namespace Gameplay.Combat.Model
{
	// Token: 0x0200099F RID: 2463
	[Token(Token = "0x200099F")]
	public class PlayerProfitData
	{
		// Token: 0x17000BAC RID: 2988
		// (get) Token: 0x06003AEA RID: 15082 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003AEB RID: 15083 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BAC")]
		public PlayerProfit Data
		{
			[Token(Token = "0x6003AEA")]
			[Address(RVA = "0x8A5F", Offset = "0x8A5F", VA = "0x8A5F")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003AEB")]
			[Address(RVA = "0x8A60", Offset = "0x8A60", VA = "0x8A60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06003AEC RID: 15084 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003AEC")]
		[Address(RVA = "0x8A61", Offset = "0x8A61", VA = "0x8A61")]
		public PlayerProfitData(PlayerProfit data)
		{
		}

		// Token: 0x06003AED RID: 15085 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003AED")]
		[Address(RVA = "0x1BE3", Offset = "0x1BE3", VA = "0x1BE3")]
		public List<RewardData> ToRewards()
		{
			return null;
		}
	}
}
