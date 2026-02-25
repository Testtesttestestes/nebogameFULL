using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data.Accounts;
using Il2CppDummyDll;
using Protocol.Common;
using Protocol.Dic;

namespace Gameplay.Accounts.Model.Data
{
	// Token: 0x02000DDD RID: 3549
	[Token(Token = "0x2000DDD")]
	public class ClanAccount : AccountDataDecorator
	{
		// Token: 0x170011AE RID: 4526
		// (get) Token: 0x060056A6 RID: 22182 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060056A7 RID: 22183 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170011AE")]
		public List<ClanAccountLevelsDic> LevelsDics
		{
			[Token(Token = "0x60056A6")]
			[Address(RVA = "0xA42E", Offset = "0xA42E", VA = "0xA42E")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60056A7")]
			[Address(RVA = "0xA42F", Offset = "0xA42F", VA = "0xA42F")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170011AF RID: 4527
		// (get) Token: 0x060056A8 RID: 22184 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170011AF")]
		public override string Title
		{
			[Token(Token = "0x60056A8")]
			[Address(RVA = "0xA430", Offset = "0xA430", VA = "0xA430", Slot = "18")]
			get
			{
				return null;
			}
		}

		// Token: 0x060056A9 RID: 22185 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056A9")]
		[Address(RVA = "0xA431", Offset = "0xA431", VA = "0xA431", Slot = "19")]
		public override void Init(uint id, Dictionaries dicts, IAccountRepository accountRepository)
		{
		}

		// Token: 0x060056AA RID: 22186 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60056AA")]
		[Address(RVA = "0xA432", Offset = "0xA432", VA = "0xA432")]
		public ResourceSet GetAutoIncomeCoeff(uint zigguratLevel)
		{
			return null;
		}

		// Token: 0x060056AB RID: 22187 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60056AB")]
		[Address(RVA = "0xA433", Offset = "0xA433", VA = "0xA433")]
		public ResourceSet GetJoinPriceCoeff(uint zigguratLevel)
		{
			return null;
		}

		// Token: 0x060056AC RID: 22188 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60056AC")]
		[Address(RVA = "0xA434", Offset = "0xA434", VA = "0xA434")]
		public ResourceSet GetAutoIncome(uint zigguratLevel)
		{
			return null;
		}

		// Token: 0x060056AD RID: 22189 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056AD")]
		[Address(RVA = "0xA435", Offset = "0xA435", VA = "0xA435")]
		public ClanAccount()
		{
		}
	}
}
