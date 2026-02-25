using System;
using Gameplay.WorldAxis.Events;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Clans.Office.Events
{
	// Token: 0x02000A61 RID: 2657
	[Token(Token = "0x2000A61")]
	public class ClassEvents : AbstractMVCEvents
	{
		// Token: 0x06003ED3 RID: 16083 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003ED3")]
		[Address(RVA = "0x8D8F", Offset = "0x8D8F", VA = "0x8D8F")]
		public ClassEvents(WorldAxisEvents worldAxisEvents)
		{
		}

		// Token: 0x04002370 RID: 9072
		[Token(Token = "0x4002370")]
		[FieldOffset(Offset = "0x14")]
		public readonly WorldAxisEvents WorldAxisEvents;

		// Token: 0x04002371 RID: 9073
		[Token(Token = "0x4002371")]
		[FieldOffset(Offset = "0x18")]
		public Action SlotsChangedEventHandler;

		// Token: 0x04002372 RID: 9074
		[Token(Token = "0x4002372")]
		[FieldOffset(Offset = "0x1C")]
		public Action DollSpellsRequestedEvent;

		// Token: 0x04002373 RID: 9075
		[Token(Token = "0x4002373")]
		[FieldOffset(Offset = "0x20")]
		public Action<ulong> DollSkillsRequestedEvent;
	}
}
