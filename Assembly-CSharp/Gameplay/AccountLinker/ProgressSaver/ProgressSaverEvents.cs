using System;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.AccountLinker.ProgressSaver
{
	// Token: 0x02000E08 RID: 3592
	[Token(Token = "0x2000E08")]
	public class ProgressSaverEvents : AbstractMVCEvents
	{
		// Token: 0x06005785 RID: 22405 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005785")]
		[Address(RVA = "0xA500", Offset = "0xA500", VA = "0xA500")]
		public ProgressSaverEvents()
		{
		}

		// Token: 0x04002F73 RID: 12147
		[Token(Token = "0x4002F73")]
		[FieldOffset(Offset = "0x14")]
		public Action SetEmailPasswordSuccessEvent;

		// Token: 0x04002F74 RID: 12148
		[Token(Token = "0x4002F74")]
		[FieldOffset(Offset = "0x18")]
		public Action ProgressSavedSuccessEvent;
	}
}
