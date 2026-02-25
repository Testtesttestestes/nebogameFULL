using System;
using CloudsFly.Movement;
using Il2CppDummyDll;

namespace Gameplay.World.Events
{
	// Token: 0x02000376 RID: 886
	[Token(Token = "0x2000376")]
	public class WorldEngineEvents
	{
		// Token: 0x06001496 RID: 5270 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001496")]
		[Address(RVA = "0x6660", Offset = "0x6660", VA = "0x6660")]
		public WorldEngineEvents()
		{
		}

		// Token: 0x04000AFE RID: 2814
		[Token(Token = "0x4000AFE")]
		[FieldOffset(Offset = "0x8")]
		public Action<WorldMovementTypes> MoveStartEvent;

		// Token: 0x04000AFF RID: 2815
		[Token(Token = "0x4000AFF")]
		[FieldOffset(Offset = "0xC")]
		public Action<WorldMovementTypes> MoveCompleteEvent;
	}
}
