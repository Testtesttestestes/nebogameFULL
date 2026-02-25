using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace I2.Loc
{
	// Token: 0x020013AE RID: 5038
	[Token(Token = "0x20013AE")]
	internal class ArabicTable
	{
		// Token: 0x060077CF RID: 30671 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60077CF")]
		[Address(RVA = "0xC12A", Offset = "0xC12A", VA = "0xC12A")]
		private ArabicTable()
		{
		}

		// Token: 0x170017B6 RID: 6070
		// (get) Token: 0x060077D0 RID: 30672 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170017B6")]
		internal static ArabicTable ArabicMapper
		{
			[Token(Token = "0x60077D0")]
			[Address(RVA = "0xC12B", Offset = "0xC12B", VA = "0xC12B")]
			get
			{
				return null;
			}
		}

		// Token: 0x060077D1 RID: 30673 RVA: 0x00015FF0 File Offset: 0x000141F0
		[Token(Token = "0x60077D1")]
		[Address(RVA = "0xC12C", Offset = "0xC12C", VA = "0xC12C")]
		internal int Convert(int toBeConverted)
		{
			return 0;
		}

		// Token: 0x04003EDB RID: 16091
		[Token(Token = "0x4003EDB")]
		[FieldOffset(Offset = "0x0")]
		private static List<ArabicMapping> mapList;

		// Token: 0x04003EDC RID: 16092
		[Token(Token = "0x4003EDC")]
		[FieldOffset(Offset = "0x4")]
		private static ArabicTable arabicMapper;
	}
}
