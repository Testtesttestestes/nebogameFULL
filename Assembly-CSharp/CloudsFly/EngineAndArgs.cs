using System;
using Il2CppDummyDll;

namespace CloudsFly
{
	// Token: 0x020012FB RID: 4859
	[Token(Token = "0x20012FB")]
	[Serializable]
	public class EngineAndArgs
	{
		// Token: 0x060073A9 RID: 29609 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60073A9")]
		[Address(RVA = "0xBD90", Offset = "0xBD90", VA = "0xBD90")]
		public EngineAndArgs(IWorldObjectEngine engine, WorldObjectEngineArgs args)
		{
		}

		// Token: 0x04003C8E RID: 15502
		[Token(Token = "0x4003C8E")]
		[FieldOffset(Offset = "0x8")]
		public IWorldObjectEngine engine;

		// Token: 0x04003C8F RID: 15503
		[Token(Token = "0x4003C8F")]
		[FieldOffset(Offset = "0xC")]
		public WorldObjectEngineArgs args;
	}
}
