using System;
using Il2CppDummyDll;
using UI.Windows;

namespace Core.Errors.Expected
{
	// Token: 0x02001074 RID: 4212
	[Token(Token = "0x2001074")]
	public class ExpectedStartCraftErrors : ExpectedDefaultError
	{
		// Token: 0x0600627A RID: 25210 RVA: 0x00012738 File Offset: 0x00010938
		[Token(Token = "0x600627A")]
		[Address(RVA = "0xAEA0", Offset = "0xAEA0", VA = "0xAEA0", Slot = "4")]
		public override bool Handle(int errorCode)
		{
			return default(bool);
		}

		// Token: 0x0600627B RID: 25211 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600627B")]
		[Address(RVA = "0xAEA1", Offset = "0xAEA1", VA = "0xAEA1")]
		private DialogWindow ShowNotAvailableSlotsWindow()
		{
			return null;
		}

		// Token: 0x0600627C RID: 25212 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600627C")]
		[Address(RVA = "0xAEA2", Offset = "0xAEA2", VA = "0xAEA2")]
		public ExpectedStartCraftErrors()
		{
		}
	}
}
