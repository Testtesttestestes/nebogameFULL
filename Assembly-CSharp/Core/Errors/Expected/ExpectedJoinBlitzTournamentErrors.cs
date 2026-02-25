using System;
using Il2CppDummyDll;

namespace Core.Errors.Expected
{
	// Token: 0x02001065 RID: 4197
	[Token(Token = "0x2001065")]
	public class ExpectedJoinBlitzTournamentErrors : ExpectedDefaultError
	{
		// Token: 0x0600625E RID: 25182 RVA: 0x00012618 File Offset: 0x00010818
		[Token(Token = "0x600625E")]
		[Address(RVA = "0xAE84", Offset = "0xAE84", VA = "0xAE84", Slot = "4")]
		public override bool Handle(int errorCode)
		{
			return default(bool);
		}

		// Token: 0x0600625F RID: 25183 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600625F")]
		[Address(RVA = "0xAE85", Offset = "0xAE85", VA = "0xAE85")]
		public ExpectedJoinBlitzTournamentErrors()
		{
		}
	}
}
