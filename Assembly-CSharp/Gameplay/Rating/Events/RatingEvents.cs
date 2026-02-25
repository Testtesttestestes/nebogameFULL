using System;
using Gameplay.Rating.Model;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Rating.Events
{
	// Token: 0x02000591 RID: 1425
	[Token(Token = "0x2000591")]
	public sealed class RatingEvents : AbstractMVCEvents
	{
		// Token: 0x0600221A RID: 8730 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600221A")]
		[Address(RVA = "0x7379", Offset = "0x7379", VA = "0x7379")]
		public RatingEvents()
		{
		}

		// Token: 0x040012C4 RID: 4804
		[Token(Token = "0x40012C4")]
		[FieldOffset(Offset = "0x14")]
		public Action<RatingRequestDto> RatingsDataReceivingCompleteEvent;
	}
}
