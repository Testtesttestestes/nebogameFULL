using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Data.Balance;
using Core.Data.InfoRows;
using Il2CppDummyDll;
using Protocol.Common;

namespace Core.Gameplay.Managers.Requirements
{
	// Token: 0x02001193 RID: 4499
	[Token(Token = "0x2001193")]
	public class CostRequirementsInfoProvider : AbstractInformationProvider
	{
		// Token: 0x170015D8 RID: 5592
		// (get) Token: 0x06006AE5 RID: 27365 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006AE6 RID: 27366 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170015D8")]
		public ResourceSet Cost
		{
			[Token(Token = "0x6006AE5")]
			[Address(RVA = "0xB5F5", Offset = "0xB5F5", VA = "0xB5F5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006AE6")]
			[Address(RVA = "0xB5F6", Offset = "0xB5F6", VA = "0xB5F6")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06006AE7 RID: 27367 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006AE7")]
		[Address(RVA = "0xB5F7", Offset = "0xB5F7", VA = "0xB5F7", Slot = "7")]
		public override void Dispose()
		{
		}

		// Token: 0x06006AE8 RID: 27368 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006AE8")]
		[Address(RVA = "0xB5F8", Offset = "0xB5F8", VA = "0xB5F8")]
		public CostRequirementsInfoProvider(IBalanceSource balanceSource, UserData loggedUser, ResourceSet cost)
		{
		}

		// Token: 0x06006AE9 RID: 27369 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006AE9")]
		[Address(RVA = "0xB5F9", Offset = "0xB5F9", VA = "0xB5F9", Slot = "9")]
		protected override void PrepareInformation()
		{
		}

		// Token: 0x06006AEA RID: 27370 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006AEA")]
		[Address(RVA = "0xB5FA", Offset = "0xB5FA", VA = "0xB5FA")]
		public List<IInformationRow> GetCost()
		{
			return null;
		}

		// Token: 0x04003887 RID: 14471
		[Token(Token = "0x4003887")]
		public const string REQUIREMENTS_COST = "REQUIREMENTS/COST";

		// Token: 0x04003888 RID: 14472
		[Token(Token = "0x4003888")]
		[FieldOffset(Offset = "0x18")]
		public string CostTitle;

		// Token: 0x0400388A RID: 14474
		[Token(Token = "0x400388A")]
		[FieldOffset(Offset = "0x20")]
		private IBalanceSource _balanceSource;
	}
}
