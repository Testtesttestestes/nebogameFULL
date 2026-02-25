using System;
using Il2CppDummyDll;

namespace MVC
{
	// Token: 0x02000E3C RID: 3644
	[Token(Token = "0x2000E3C")]
	public abstract class AbstractMVCEvents
	{
		// Token: 0x06005954 RID: 22868 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005954")]
		[Address(RVA = "0xA695", Offset = "0xA695", VA = "0xA695")]
		protected AbstractMVCEvents()
		{
		}

		// Token: 0x04003030 RID: 12336
		[Token(Token = "0x4003030")]
		[FieldOffset(Offset = "0x8")]
		public Action InitEvent;

		// Token: 0x04003031 RID: 12337
		[Token(Token = "0x4003031")]
		[FieldOffset(Offset = "0xC")]
		public Action StartRequestEvent;

		// Token: 0x04003032 RID: 12338
		[Token(Token = "0x4003032")]
		[FieldOffset(Offset = "0x10")]
		public Action StopRequestEvent;
	}
}
