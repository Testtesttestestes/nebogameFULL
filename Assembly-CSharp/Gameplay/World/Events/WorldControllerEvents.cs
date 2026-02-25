using System;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.World.Events
{
	// Token: 0x02000374 RID: 884
	[Token(Token = "0x2000374")]
	public class WorldControllerEvents : AbstractMVCEvents
	{
		// Token: 0x06001495 RID: 5269 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001495")]
		[Address(RVA = "0x665F", Offset = "0x665F", VA = "0x665F")]
		public WorldControllerEvents()
		{
		}

		// Token: 0x04000AF4 RID: 2804
		[Token(Token = "0x4000AF4")]
		[FieldOffset(Offset = "0x14")]
		public Action WorldLocationChangedEvent;

		// Token: 0x04000AF5 RID: 2805
		[Token(Token = "0x4000AF5")]
		[FieldOffset(Offset = "0x18")]
		public Action<ulong> RequestIsleInformationEvent;

		// Token: 0x04000AF6 RID: 2806
		[Token(Token = "0x4000AF6")]
		[FieldOffset(Offset = "0x1C")]
		public Action<ulong> CurrentIsleChangedEvent;

		// Token: 0x04000AF7 RID: 2807
		[Token(Token = "0x4000AF7")]
		[FieldOffset(Offset = "0x20")]
		public Action<ulong, WorldControllerEvents.MonsterChangeReason> MonsterChangedEvent;

		// Token: 0x04000AF8 RID: 2808
		[Token(Token = "0x4000AF8")]
		[FieldOffset(Offset = "0x24")]
		public Action AnimationInfoChangedEvent;

		// Token: 0x04000AF9 RID: 2809
		[Token(Token = "0x4000AF9")]
		[FieldOffset(Offset = "0x28")]
		public Action DictChangedEvent;

		// Token: 0x02000375 RID: 885
		[Token(Token = "0x2000375")]
		public enum MonsterChangeReason
		{
			// Token: 0x04000AFB RID: 2811
			[Token(Token = "0x4000AFB")]
			DEFAULT,
			// Token: 0x04000AFC RID: 2812
			[Token(Token = "0x4000AFC")]
			KICKED,
			// Token: 0x04000AFD RID: 2813
			[Token(Token = "0x4000AFD")]
			FLEW_AWAY
		}
	}
}
