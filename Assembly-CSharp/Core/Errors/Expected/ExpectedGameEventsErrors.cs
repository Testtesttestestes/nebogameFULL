using System;
using Il2CppDummyDll;

namespace Core.Errors.Expected
{
	// Token: 0x0200105B RID: 4187
	[Token(Token = "0x200105B")]
	public class ExpectedGameEventsErrors : ExpectedDefaultError
	{
		// Token: 0x06006243 RID: 25155 RVA: 0x000125A0 File Offset: 0x000107A0
		[Token(Token = "0x6006243")]
		[Address(RVA = "0xAE69", Offset = "0xAE69", VA = "0xAE69", Slot = "4")]
		public override bool Handle(int errorCode)
		{
			return default(bool);
		}

		// Token: 0x06006244 RID: 25156 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006244")]
		[Address(RVA = "0xAE6A", Offset = "0xAE6A", VA = "0xAE6A")]
		public ExpectedGameEventsErrors()
		{
		}
	}
}
