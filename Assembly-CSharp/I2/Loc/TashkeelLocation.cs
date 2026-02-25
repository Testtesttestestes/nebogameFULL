using System;
using Il2CppDummyDll;

namespace I2.Loc
{
	// Token: 0x020013AF RID: 5039
	[Token(Token = "0x20013AF")]
	internal class TashkeelLocation
	{
		// Token: 0x060077D2 RID: 30674 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60077D2")]
		[Address(RVA = "0xC12D", Offset = "0xC12D", VA = "0xC12D")]
		public TashkeelLocation(char tashkeel, int position)
		{
		}

		// Token: 0x04003EDD RID: 16093
		[Token(Token = "0x4003EDD")]
		[FieldOffset(Offset = "0x8")]
		public char tashkeel;

		// Token: 0x04003EDE RID: 16094
		[Token(Token = "0x4003EDE")]
		[FieldOffset(Offset = "0xC")]
		public int position;
	}
}
