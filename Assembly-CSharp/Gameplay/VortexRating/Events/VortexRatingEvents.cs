using System;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.VortexRating.Events
{
	// Token: 0x02000396 RID: 918
	[Token(Token = "0x2000396")]
	public class VortexRatingEvents : AbstractMVCEvents
	{
		// Token: 0x06001565 RID: 5477 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001565")]
		[Address(RVA = "0x6727", Offset = "0x6727", VA = "0x6727")]
		public VortexRatingEvents()
		{
		}

		// Token: 0x04000B62 RID: 2914
		[Token(Token = "0x4000B62")]
		[FieldOffset(Offset = "0x14")]
		public Action GreatTopRequestedEvent;

		// Token: 0x04000B63 RID: 2915
		[Token(Token = "0x4000B63")]
		[FieldOffset(Offset = "0x18")]
		public Action<ulong> VotedEvent;

		// Token: 0x04000B64 RID: 2916
		[Token(Token = "0x4000B64")]
		[FieldOffset(Offset = "0x1C")]
		public Action UsersTopChangedEvent;

		// Token: 0x04000B65 RID: 2917
		[Token(Token = "0x4000B65")]
		[FieldOffset(Offset = "0x20")]
		public Action<ulong> GreatUserSetChangedEvent;

		// Token: 0x04000B66 RID: 2918
		[Token(Token = "0x4000B66")]
		[FieldOffset(Offset = "0x24")]
		public Action<uint> GreatSetAssignedEvent;
	}
}
