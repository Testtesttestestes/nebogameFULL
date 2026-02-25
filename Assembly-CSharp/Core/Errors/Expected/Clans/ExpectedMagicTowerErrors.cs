using System;
using Il2CppDummyDll;

namespace Core.Errors.Expected.Clans
{
	// Token: 0x02001086 RID: 4230
	[Token(Token = "0x2001086")]
	public class ExpectedMagicTowerErrors : ExpectedDefaultError
	{
		// Token: 0x060062A0 RID: 25248 RVA: 0x000128A0 File Offset: 0x00010AA0
		[Token(Token = "0x60062A0")]
		[Address(RVA = "0xAEC6", Offset = "0xAEC6", VA = "0xAEC6", Slot = "4")]
		public override bool Handle(int errorCode)
		{
			return default(bool);
		}

		// Token: 0x060062A1 RID: 25249 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60062A1")]
		[Address(RVA = "0xAEC7", Offset = "0xAEC7", VA = "0xAEC7")]
		public ExpectedMagicTowerErrors()
		{
		}
	}
}
