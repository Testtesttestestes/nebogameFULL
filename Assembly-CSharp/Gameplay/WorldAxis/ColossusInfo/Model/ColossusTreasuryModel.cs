using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Data.Balance;
using Core.Dict;
using Gameplay.WorldAxis.ColossusInfo.View;
using Il2CppDummyDll;
using MVC;
using Protocol.Colossus;

namespace Gameplay.WorldAxis.ColossusInfo.Model
{
	// Token: 0x0200032B RID: 811
	[Token(Token = "0x200032B")]
	public class ColossusTreasuryModel : AbstractModel
	{
		// Token: 0x170002E4 RID: 740
		// (get) Token: 0x0600129E RID: 4766 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170002E4")]
		public IDictProvider DictProvider
		{
			[Token(Token = "0x600129E")]
			[Address(RVA = "0x6498", Offset = "0x6498", VA = "0x6498")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600129F RID: 4767 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600129F")]
		[Address(RVA = "0x6499", Offset = "0x6499", VA = "0x6499")]
		public ColossusTreasuryModel(UserData user, ColossusInfoModel colossusInfoModel)
		{
		}

		// Token: 0x170002E5 RID: 741
		// (get) Token: 0x060012A0 RID: 4768 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060012A1 RID: 4769 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002E5")]
		public IBalanceSource ClanBalance
		{
			[Token(Token = "0x60012A0")]
			[Address(RVA = "0x649A", Offset = "0x649A", VA = "0x649A")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60012A1")]
			[Address(RVA = "0x649B", Offset = "0x649B", VA = "0x649B")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170002E6 RID: 742
		// (get) Token: 0x060012A2 RID: 4770 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060012A3 RID: 4771 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002E6")]
		public TreasuryOptionListElement.TreasuryOptionListElementArgs[] Options
		{
			[Token(Token = "0x60012A2")]
			[Address(RVA = "0x649C", Offset = "0x649C", VA = "0x649C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60012A3")]
			[Address(RVA = "0x649D", Offset = "0x649D", VA = "0x649D")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060012A4 RID: 4772 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012A4")]
		[Address(RVA = "0x649E", Offset = "0x649E", VA = "0x649E")]
		public void PopulateOptions(ProtoGetTreasuryOptionsAns msg)
		{
		}

		// Token: 0x060012A5 RID: 4773 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60012A5")]
		[Address(RVA = "0x649F", Offset = "0x649F", VA = "0x649F")]
		private TreasuryOptionListElement.TreasuryOptionListElementArgs CreateOptionArgs(ProtoGetTreasuryOptionsAns.Types.TreasuryOption option)
		{
			return null;
		}

		// Token: 0x04000A13 RID: 2579
		[Token(Token = "0x4000A13")]
		[FieldOffset(Offset = "0xC")]
		public readonly ColossusInfoModel ColossusInfoModel;
	}
}
