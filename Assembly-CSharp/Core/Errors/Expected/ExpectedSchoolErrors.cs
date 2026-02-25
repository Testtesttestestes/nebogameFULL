using System;
using Il2CppDummyDll;
using UI.Windows;

namespace Core.Errors.Expected
{
	// Token: 0x0200106E RID: 4206
	[Token(Token = "0x200106E")]
	public class ExpectedSchoolErrors : ExpectedDefaultError
	{
		// Token: 0x06006271 RID: 25201 RVA: 0x000126D8 File Offset: 0x000108D8
		[Token(Token = "0x6006271")]
		[Address(RVA = "0xAE97", Offset = "0xAE97", VA = "0xAE97", Slot = "4")]
		public override bool Handle(int errorCode)
		{
			return default(bool);
		}

		// Token: 0x06006272 RID: 25202 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006272")]
		[Address(RVA = "0xAE98", Offset = "0xAE98", VA = "0xAE98")]
		protected void Show(RequirementsWindow.RequirementsWindowArgs windowArgs)
		{
		}

		// Token: 0x06006273 RID: 25203 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006273")]
		[Address(RVA = "0xAE99", Offset = "0xAE99", VA = "0xAE99")]
		public ExpectedSchoolErrors()
		{
		}
	}
}
