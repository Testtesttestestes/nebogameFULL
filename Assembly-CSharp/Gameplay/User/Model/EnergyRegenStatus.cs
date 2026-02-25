using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Protocol.Balance;
using Protocol.Common;
using Utils;

namespace Gameplay.User.Model
{
	// Token: 0x0200041E RID: 1054
	[Token(Token = "0x200041E")]
	public class EnergyRegenStatus : IDisposable
	{
		// Token: 0x1700045B RID: 1115
		// (get) Token: 0x060018E5 RID: 6373 RVA: 0x00005790 File Offset: 0x00003990
		[Token(Token = "0x1700045B")]
		public uint MaxEnergy
		{
			[Token(Token = "0x60018E5")]
			[Address(RVA = "0x6A84", Offset = "0x6A84", VA = "0x6A84")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x1700045C RID: 1116
		// (get) Token: 0x060018E6 RID: 6374 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060018E7 RID: 6375 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700045C")]
		public BackTime EnergyRecoveryBacktime
		{
			[Token(Token = "0x60018E6")]
			[Address(RVA = "0x6A85", Offset = "0x6A85", VA = "0x6A85")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60018E7")]
			[Address(RVA = "0x6A86", Offset = "0x6A86", VA = "0x6A86")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700045D RID: 1117
		// (get) Token: 0x060018E8 RID: 6376 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060018E9 RID: 6377 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700045D")]
		public BackTime FullEnergyRecoveryBacktime
		{
			[Token(Token = "0x60018E8")]
			[Address(RVA = "0x6A87", Offset = "0x6A87", VA = "0x6A87")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60018E9")]
			[Address(RVA = "0x6A88", Offset = "0x6A88", VA = "0x6A88")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060018EA RID: 6378 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018EA")]
		[Address(RVA = "0x6A89", Offset = "0x6A89", VA = "0x6A89")]
		public EnergyRegenStatus(ResourceSet money, ProtoGetEnergyRegenStatusAns status, double energyRecoveryIncrementPercentPerInterval, uint energyRecoveryIncrementInterval)
		{
		}

		// Token: 0x060018EB RID: 6379 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018EB")]
		[Address(RVA = "0x6A8A", Offset = "0x6A8A", VA = "0x6A8A", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x04000D29 RID: 3369
		[Token(Token = "0x4000D29")]
		[FieldOffset(Offset = "0x8")]
		private ProtoGetEnergyRegenStatusAns _status;
	}
}
