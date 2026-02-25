using System;
using Il2CppDummyDll;

namespace Core.Errors.Expected
{
	// Token: 0x02001054 RID: 4180
	[Token(Token = "0x2001054")]
	public class ExpectedDefaultError
	{
		// Token: 0x0600622F RID: 25135 RVA: 0x00012498 File Offset: 0x00010698
		[Token(Token = "0x600622F")]
		[Address(RVA = "0xAE5A", Offset = "0xAE5A", VA = "0xAE5A", Slot = "4")]
		public virtual bool Handle(int errorCode)
		{
			return default(bool);
		}

		// Token: 0x06006230 RID: 25136 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006230")]
		[Address(RVA = "0xAE5B", Offset = "0xAE5B", VA = "0xAE5B")]
		public ExpectedDefaultError()
		{
		}

		// Token: 0x040034DA RID: 13530
		[Token(Token = "0x40034DA")]
		[FieldOffset(Offset = "0x8")]
		public object Args;
	}
}
