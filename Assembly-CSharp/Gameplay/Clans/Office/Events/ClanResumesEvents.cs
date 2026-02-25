using System;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Clans.Office.Events
{
	// Token: 0x02000A5F RID: 2655
	[Token(Token = "0x2000A5F")]
	public class ClanResumesEvents : AbstractMVCEvents
	{
		// Token: 0x06003ED1 RID: 16081 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003ED1")]
		[Address(RVA = "0x8D8D", Offset = "0x8D8D", VA = "0x8D8D")]
		public ClanResumesEvents(ClanInfoEvents clanInfoEvents)
		{
		}

		// Token: 0x04002369 RID: 9065
		[Token(Token = "0x4002369")]
		[FieldOffset(Offset = "0x14")]
		public readonly ClanInfoEvents ClanInfoEvents;

		// Token: 0x0400236A RID: 9066
		[Token(Token = "0x400236A")]
		[FieldOffset(Offset = "0x18")]
		public Action FirstResumesRequestedEvent;

		// Token: 0x0400236B RID: 9067
		[Token(Token = "0x400236B")]
		[FieldOffset(Offset = "0x1C")]
		public Action ResumesAddedEvent;

		// Token: 0x0400236C RID: 9068
		[Token(Token = "0x400236C")]
		[FieldOffset(Offset = "0x20")]
		public Action<ulong> ResumeRemovedEvent;
	}
}
