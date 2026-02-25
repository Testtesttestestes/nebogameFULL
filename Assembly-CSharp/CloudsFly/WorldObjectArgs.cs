using System;
using Il2CppDummyDll;
using UnityEngine;

namespace CloudsFly
{
	// Token: 0x0200130F RID: 4879
	[Token(Token = "0x200130F")]
	public class WorldObjectArgs
	{
		// Token: 0x060073F1 RID: 29681 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60073F1")]
		[Address(RVA = "0xBDCE", Offset = "0xBDCE", VA = "0xBDCE")]
		public WorldObjectArgs(Vector3 position, Func<float, float, float> randomRange)
		{
		}

		// Token: 0x04003CB9 RID: 15545
		[Token(Token = "0x4003CB9")]
		[FieldOffset(Offset = "0x8")]
		public readonly Vector3 Position;

		// Token: 0x04003CBA RID: 15546
		[Token(Token = "0x4003CBA")]
		[FieldOffset(Offset = "0x14")]
		public readonly Func<float, float, float> RandomRange;
	}
}
