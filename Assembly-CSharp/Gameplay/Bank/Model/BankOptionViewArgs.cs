using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Core.Gameplay.Managers.Ad.Placements.BankOptions;
using Il2CppDummyDll;

namespace Gameplay.Bank.Model
{
	// Token: 0x02000C5A RID: 3162
	[Token(Token = "0x2000C5A")]
	public class BankOptionViewArgs
	{
		// Token: 0x17000FA4 RID: 4004
		// (get) Token: 0x06004D43 RID: 19779 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004D44 RID: 19780 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000FA4")]
		public BankOptionData BankOptionData
		{
			[Token(Token = "0x6004D43")]
			[Address(RVA = "0x9B7D", Offset = "0x9B7D", VA = "0x9B7D")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004D44")]
			[Address(RVA = "0x9B7E", Offset = "0x9B7E", VA = "0x9B7E")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06004D45 RID: 19781 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D45")]
		[Address(RVA = "0x9B7F", Offset = "0x9B7F", VA = "0x9B7F")]
		public BankOptionViewArgs(BankOptionData bankOptionData, [Optional] BankOptionsAdPlacementManager adManager)
		{
		}

		// Token: 0x04002A2A RID: 10794
		[Token(Token = "0x4002A2A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public readonly BankOptionsAdPlacementManager AdPlacementManager;
	}
}
