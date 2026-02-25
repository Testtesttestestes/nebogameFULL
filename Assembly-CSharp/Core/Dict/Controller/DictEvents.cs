using System;
using Il2CppDummyDll;
using MVC;

namespace Core.Dict.Controller
{
	// Token: 0x020010A8 RID: 4264
	[Token(Token = "0x20010A8")]
	public class DictEvents : AbstractMVCEvents
	{
		// Token: 0x06006313 RID: 25363 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006313")]
		[Address(RVA = "0xAF1F", Offset = "0xAF1F", VA = "0xAF1F")]
		public DictEvents()
		{
		}

		// Token: 0x04003523 RID: 13603
		[Token(Token = "0x4003523")]
		[FieldOffset(Offset = "0x14")]
		public Action DictChangedEvent;
	}
}
