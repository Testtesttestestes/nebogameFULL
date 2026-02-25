using System;
using Il2CppDummyDll;
using MVC;
using Protocol.Craft;

namespace Gameplay.Craft.Events
{
	// Token: 0x020008C2 RID: 2242
	[Token(Token = "0x20008C2")]
	public class CraftEvents : AbstractMVCEvents
	{
		// Token: 0x060034B1 RID: 13489 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034B1")]
		[Address(RVA = "0x84DA", Offset = "0x84DA", VA = "0x84DA")]
		public CraftEvents()
		{
		}

		// Token: 0x04001CDD RID: 7389
		[Token(Token = "0x4001CDD")]
		[FieldOffset(Offset = "0x14")]
		public Action ProfessionRequestedEvent;

		// Token: 0x04001CDE RID: 7390
		[Token(Token = "0x4001CDE")]
		[FieldOffset(Offset = "0x18")]
		public Action SchemesRequestedEvent;

		// Token: 0x04001CDF RID: 7391
		[Token(Token = "0x4001CDF")]
		[FieldOffset(Offset = "0x1C")]
		public Action CraftSlotsRequestedEvent;

		// Token: 0x04001CE0 RID: 7392
		[Token(Token = "0x4001CE0")]
		[FieldOffset(Offset = "0x20")]
		public Action UserBalanceChangedEvent;

		// Token: 0x04001CE1 RID: 7393
		[Token(Token = "0x4001CE1")]
		[FieldOffset(Offset = "0x24")]
		public Action<UserScheme> SchemeChangedEvent;

		// Token: 0x04001CE2 RID: 7394
		[Token(Token = "0x4001CE2")]
		[FieldOffset(Offset = "0x28")]
		public Action CraftSlotsChangedEvent;
	}
}
