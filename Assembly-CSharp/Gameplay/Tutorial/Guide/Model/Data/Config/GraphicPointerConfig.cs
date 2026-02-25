using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.Tutorial.Guide.Model.Data.Config
{
	// Token: 0x02000486 RID: 1158
	[Token(Token = "0x2000486")]
	[Serializable]
	public class GraphicPointerConfig
	{
		// Token: 0x06001B6F RID: 7023 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B6F")]
		[Address(RVA = "0x6CEE", Offset = "0x6CEE", VA = "0x6CEE")]
		public GraphicPointerConfig()
		{
		}

		// Token: 0x04000ED2 RID: 3794
		[Token(Token = "0x4000ED2")]
		[FieldOffset(Offset = "0x8")]
		public uint GraphicPointerId;

		// Token: 0x04000ED3 RID: 3795
		[Token(Token = "0x4000ED3")]
		[FieldOffset(Offset = "0xC")]
		public float Angle;

		// Token: 0x04000ED4 RID: 3796
		[Token(Token = "0x4000ED4")]
		[FieldOffset(Offset = "0x10")]
		public Vector2 Offset;

		// Token: 0x04000ED5 RID: 3797
		[Token(Token = "0x4000ED5")]
		[FieldOffset(Offset = "0x18")]
		public Vector2 Scale;
	}
}
