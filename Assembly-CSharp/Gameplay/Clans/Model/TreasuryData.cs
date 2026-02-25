using System;
using System.Runtime.CompilerServices;
using Core.Data.Balance;
using Il2CppDummyDll;
using Protocol.Clans;
using Protocol.Common;

namespace Gameplay.Clans.Model
{
	// Token: 0x02000A8B RID: 2699
	[Token(Token = "0x2000A8B")]
	public class TreasuryData : IBalanceSource
	{
		// Token: 0x17000CC1 RID: 3265
		// (get) Token: 0x060040A2 RID: 16546 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060040A3 RID: 16547 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CC1")]
		public ResourceSet Money
		{
			[Token(Token = "0x60040A2")]
			[Address(RVA = "0x8F59", Offset = "0x8F59", VA = "0x8F59", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60040A3")]
			[Address(RVA = "0x8F5A", Offset = "0x8F5A", VA = "0x8F5A")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000CC2 RID: 3266
		// (get) Token: 0x060040A4 RID: 16548 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060040A5 RID: 16549 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CC2")]
		public ResourceSet CreditDebt
		{
			[Token(Token = "0x60040A4")]
			[Address(RVA = "0x8F5B", Offset = "0x8F5B", VA = "0x8F5B")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60040A5")]
			[Address(RVA = "0x8F5C", Offset = "0x8F5C", VA = "0x8F5C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1400019A RID: 410
		// (add) Token: 0x060040A6 RID: 16550 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060040A7 RID: 16551 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400019A")]
		public event IBalanceSource.BalanceChangedDelegate BalanceChangedEvent
		{
			[Token(Token = "0x60040A6")]
			[Address(RVA = "0x8F5D", Offset = "0x8F5D", VA = "0x8F5D", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60040A7")]
			[Address(RVA = "0x8F5E", Offset = "0x8F5E", VA = "0x8F5E", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x060040A8 RID: 16552 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040A8")]
		[Address(RVA = "0x8F5F", Offset = "0x8F5F", VA = "0x8F5F")]
		public TreasuryData(ProtoGetClanTreasuryAns treasury)
		{
		}

		// Token: 0x060040A9 RID: 16553 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040A9")]
		[Address(RVA = "0x8F60", Offset = "0x8F60", VA = "0x8F60")]
		public void UpdateTreasury(ProtoGetClanTreasuryAns treasury)
		{
		}

		// Token: 0x060040AA RID: 16554 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040AA")]
		[Address(RVA = "0x8F61", Offset = "0x8F61", VA = "0x8F61")]
		public void RepayCreditDebt()
		{
		}

		// Token: 0x060040AB RID: 16555 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040AB")]
		[Address(RVA = "0x8F62", Offset = "0x8F62", VA = "0x8F62")]
		public void ChangeTreasury(ProtoTreasuryChangedEvt msg)
		{
		}
	}
}
