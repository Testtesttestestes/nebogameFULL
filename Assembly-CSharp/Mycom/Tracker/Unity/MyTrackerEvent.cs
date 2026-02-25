using System;
using Il2CppDummyDll;

namespace Mycom.Tracker.Unity
{
	// Token: 0x02001341 RID: 4929
	[Token(Token = "0x2001341")]
	public abstract class MyTrackerEvent
	{
		// Token: 0x060074B7 RID: 29879 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60074B7")]
		[Address(RVA = "0xBE83", Offset = "0xBE83", VA = "0xBE83")]
		internal MyTrackerEvent(AppEventEnum appEvent)
		{
		}

		// Token: 0x04003D39 RID: 15673
		[Token(Token = "0x4003D39")]
		[FieldOffset(Offset = "0x8")]
		internal readonly AppEventEnum appEvent;
	}
}
