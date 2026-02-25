using System;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Duel.Events
{
	// Token: 0x02000863 RID: 2147
	[Token(Token = "0x2000863")]
	public class DuelEvents : AbstractMVCEvents
	{
		// Token: 0x06003267 RID: 12903 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003267")]
		[Address(RVA = "0x82BC", Offset = "0x82BC", VA = "0x82BC")]
		public DuelEvents()
		{
		}

		// Token: 0x04001BA5 RID: 7077
		[Token(Token = "0x4001BA5")]
		[FieldOffset(Offset = "0x14")]
		public Action SkillsRequestedEvent;

		// Token: 0x04001BA6 RID: 7078
		[Token(Token = "0x4001BA6")]
		[FieldOffset(Offset = "0x18")]
		public Action DuelInfoRequestedEvent;

		// Token: 0x04001BA7 RID: 7079
		[Token(Token = "0x4001BA7")]
		[FieldOffset(Offset = "0x1C")]
		public Action UpdateDataEvent;

		// Token: 0x04001BA8 RID: 7080
		[Token(Token = "0x4001BA8")]
		[FieldOffset(Offset = "0x20")]
		public Action CloseViewEvent;
	}
}
