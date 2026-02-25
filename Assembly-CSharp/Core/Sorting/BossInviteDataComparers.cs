using System;
using Gameplay.Boss.Model;
using Il2CppDummyDll;

namespace Core.Sorting
{
	// Token: 0x02000E6E RID: 3694
	[Token(Token = "0x2000E6E")]
	public class BossInviteDataComparers
	{
		// Token: 0x06005A18 RID: 23064 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A18")]
		[Address(RVA = "0xA725", Offset = "0xA725", VA = "0xA725")]
		public BossInviteDataComparers()
		{
		}

		// Token: 0x02000E6F RID: 3695
		[Token(Token = "0x2000E6F")]
		public class ByNick : AbstractGameDataComparer<BossInviteData>
		{
			// Token: 0x06005A19 RID: 23065 RVA: 0x0000FFC0 File Offset: 0x0000E1C0
			[Token(Token = "0x6005A19")]
			[Address(RVA = "0xA726", Offset = "0xA726", VA = "0xA726", Slot = "8")]
			public override int Compare(BossInviteData x, BossInviteData y)
			{
				return 0;
			}

			// Token: 0x17001258 RID: 4696
			// (get) Token: 0x06005A1A RID: 23066 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17001258")]
			public override string Title
			{
				[Token(Token = "0x6005A1A")]
				[Address(RVA = "0xA727", Offset = "0xA727", VA = "0xA727", Slot = "9")]
				get
				{
					return null;
				}
			}

			// Token: 0x06005A1B RID: 23067 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005A1B")]
			[Address(RVA = "0xA728", Offset = "0xA728", VA = "0xA728")]
			public ByNick()
			{
			}
		}

		// Token: 0x02000E70 RID: 3696
		[Token(Token = "0x2000E70")]
		public class ByLevel : AbstractGameDataComparer<BossInviteData>
		{
			// Token: 0x06005A1C RID: 23068 RVA: 0x0000FFD8 File Offset: 0x0000E1D8
			[Token(Token = "0x6005A1C")]
			[Address(RVA = "0xA729", Offset = "0xA729", VA = "0xA729", Slot = "8")]
			public override int Compare(BossInviteData x, BossInviteData y)
			{
				return 0;
			}

			// Token: 0x17001259 RID: 4697
			// (get) Token: 0x06005A1D RID: 23069 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17001259")]
			public override string Title
			{
				[Token(Token = "0x6005A1D")]
				[Address(RVA = "0xA72A", Offset = "0xA72A", VA = "0xA72A", Slot = "9")]
				get
				{
					return null;
				}
			}

			// Token: 0x06005A1E RID: 23070 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005A1E")]
			[Address(RVA = "0xA72B", Offset = "0xA72B", VA = "0xA72B")]
			public ByLevel()
			{
			}
		}

		// Token: 0x02000E71 RID: 3697
		[Token(Token = "0x2000E71")]
		public class ByCult : AbstractGameDataComparer<BossInviteData>
		{
			// Token: 0x06005A1F RID: 23071 RVA: 0x0000FFF0 File Offset: 0x0000E1F0
			[Token(Token = "0x6005A1F")]
			[Address(RVA = "0xA72C", Offset = "0xA72C", VA = "0xA72C", Slot = "8")]
			public override int Compare(BossInviteData x, BossInviteData y)
			{
				return 0;
			}

			// Token: 0x1700125A RID: 4698
			// (get) Token: 0x06005A20 RID: 23072 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x1700125A")]
			public override string Title
			{
				[Token(Token = "0x6005A20")]
				[Address(RVA = "0xA72D", Offset = "0xA72D", VA = "0xA72D", Slot = "9")]
				get
				{
					return null;
				}
			}

			// Token: 0x06005A21 RID: 23073 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005A21")]
			[Address(RVA = "0xA72E", Offset = "0xA72E", VA = "0xA72E")]
			public ByCult()
			{
			}
		}
	}
}
