using System;
using Core.Data;
using Gameplay.Medals.Controller;
using Il2CppDummyDll;
using UI.Windows;

namespace Gameplay.Medals.View
{
	// Token: 0x020005F7 RID: 1527
	[Token(Token = "0x20005F7")]
	public class MedalInfoWindowArgs : BaseWindowArgs
	{
		// Token: 0x06002510 RID: 9488 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002510")]
		[Address(RVA = "0x765A", Offset = "0x765A", VA = "0x765A")]
		public MedalInfoWindowArgs()
		{
		}

		// Token: 0x04001440 RID: 5184
		[Token(Token = "0x4001440")]
		[FieldOffset(Offset = "0x18")]
		public MedalsController Controller;

		// Token: 0x04001441 RID: 5185
		[Token(Token = "0x4001441")]
		[FieldOffset(Offset = "0x1C")]
		public MedalData MedalData;

		// Token: 0x04001442 RID: 5186
		[Token(Token = "0x4001442")]
		[FieldOffset(Offset = "0x20")]
		public uint SelectRankId;
	}
}
