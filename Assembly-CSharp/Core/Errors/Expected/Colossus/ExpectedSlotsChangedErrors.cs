using System;
using Il2CppDummyDll;

namespace Core.Errors.Expected.Colossus
{
	// Token: 0x0200107D RID: 4221
	[Token(Token = "0x200107D")]
	public class ExpectedSlotsChangedErrors : ExpectedDefaultError
	{
		// Token: 0x0600628D RID: 25229 RVA: 0x000127F8 File Offset: 0x000109F8
		[Token(Token = "0x600628D")]
		[Address(RVA = "0xAEB3", Offset = "0xAEB3", VA = "0xAEB3", Slot = "4")]
		public override bool Handle(int errorCode)
		{
			return default(bool);
		}

		// Token: 0x0600628E RID: 25230 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600628E")]
		[Address(RVA = "0xAEB4", Offset = "0xAEB4", VA = "0xAEB4")]
		public ExpectedSlotsChangedErrors()
		{
		}
	}
}
