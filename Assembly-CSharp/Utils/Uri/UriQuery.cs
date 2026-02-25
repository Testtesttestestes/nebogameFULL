using System;
using System.Text;
using Il2CppDummyDll;

namespace Utils.Uri
{
	// Token: 0x0200005A RID: 90
	[Token(Token = "0x200005A")]
	public class UriQuery
	{
		// Token: 0x060002FF RID: 767 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002FF")]
		[Address(RVA = "0x5772", Offset = "0x5772", VA = "0x5772")]
		public UriQuery()
		{
		}

		// Token: 0x06000300 RID: 768 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000300")]
		[Address(RVA = "0x5773", Offset = "0x5773", VA = "0x5773")]
		public UriQuery(Uri uri)
		{
		}

		// Token: 0x06000301 RID: 769 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000301")]
		[Address(RVA = "0x5774", Offset = "0x5774", VA = "0x5774")]
		public void Add(string name, string value)
		{
		}

		// Token: 0x06000302 RID: 770 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000302")]
		[Address(RVA = "0x5775", Offset = "0x5775", VA = "0x5775", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x04000150 RID: 336
		[Token(Token = "0x4000150")]
		public const char SEPARATOR = '&';

		// Token: 0x04000151 RID: 337
		[Token(Token = "0x4000151")]
		public const char EQUAL = '=';

		// Token: 0x04000152 RID: 338
		[Token(Token = "0x4000152")]
		[FieldOffset(Offset = "0x8")]
		private readonly StringBuilder _builder;
	}
}
