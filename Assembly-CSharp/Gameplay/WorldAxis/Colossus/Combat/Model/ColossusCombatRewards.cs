using System;
using System.Runtime.CompilerServices;
using Core.Dict;
using Il2CppDummyDll;
using Protocol.Common;

namespace Gameplay.WorldAxis.Colossus.Combat.Model
{
	// Token: 0x0200033B RID: 827
	[Token(Token = "0x200033B")]
	public class ColossusCombatRewards : IColossusCombatRewards
	{
		// Token: 0x170002F5 RID: 757
		// (get) Token: 0x0600130F RID: 4879 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170002F5")]
		public int[] ColossusScores
		{
			[Token(Token = "0x600130F")]
			[Address(RVA = "0x6505", Offset = "0x6505", VA = "0x6505", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x170002F6 RID: 758
		// (get) Token: 0x06001310 RID: 4880 RVA: 0x00004AB8 File Offset: 0x00002CB8
		[Token(Token = "0x170002F6")]
		public double CombatWinTakeOffTax
		{
			[Token(Token = "0x6001310")]
			[Address(RVA = "0x6506", Offset = "0x6506", VA = "0x6506", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x170002F7 RID: 759
		// (get) Token: 0x06001311 RID: 4881 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170002F7")]
		public ResourceSet CombatWinTakeOff
		{
			[Token(Token = "0x6001311")]
			[Address(RVA = "0x6507", Offset = "0x6507", VA = "0x6507", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x170002F8 RID: 760
		// (get) Token: 0x06001312 RID: 4882 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170002F8")]
		public ResourceSet CombatWinReward
		{
			[Token(Token = "0x6001312")]
			[Address(RVA = "0x6508", Offset = "0x6508", VA = "0x6508", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x06001313 RID: 4883 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001313")]
		[Address(RVA = "0x6509", Offset = "0x6509", VA = "0x6509")]
		public ColossusCombatRewards(IDictProvider dictProvider)
		{
		}

		// Token: 0x06001314 RID: 4884 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001314")]
		[Address(RVA = "0x650A", Offset = "0x650A", VA = "0x650A", Slot = "8")]
		public ResourceSet GetResources()
		{
			return null;
		}
	}
}
