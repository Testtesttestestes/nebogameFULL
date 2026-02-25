using System;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Clans.Buildings.Golem.Events
{
	// Token: 0x02000AD5 RID: 2773
	[Token(Token = "0x2000AD5")]
	public class GolemEvents : AbstractMVCEvents
	{
		// Token: 0x060042C8 RID: 17096 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042C8")]
		[Address(RVA = "0x917C", Offset = "0x917C", VA = "0x917C")]
		public GolemEvents()
		{
		}

		// Token: 0x040024EC RID: 9452
		[Token(Token = "0x40024EC")]
		[FieldOffset(Offset = "0x14")]
		public GolemInventoryEvents GolemInventoryEvents;

		// Token: 0x040024ED RID: 9453
		[Token(Token = "0x40024ED")]
		[FieldOffset(Offset = "0x18")]
		public Action GolemUserInfoRequestedEvent;

		// Token: 0x040024EE RID: 9454
		[Token(Token = "0x40024EE")]
		[FieldOffset(Offset = "0x1C")]
		public Action GolemSkillsRequestedEvent;
	}
}
