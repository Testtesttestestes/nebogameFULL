using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.Tutorial.Guide.Model.Shapes
{
	// Token: 0x02000483 RID: 1155
	[Token(Token = "0x2000483")]
	public class RuntimeGeneratedShape : AbstractShape
	{
		// Token: 0x06001B62 RID: 7010 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B62")]
		[Address(RVA = "0x6CE8", Offset = "0x6CE8", VA = "0x6CE8")]
		public RuntimeGeneratedShape(Sprite sprite)
		{
		}

		// Token: 0x06001B63 RID: 7011 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001B63")]
		[Address(RVA = "0x6CE9", Offset = "0x6CE9", VA = "0x6CE9", Slot = "5")]
		public override float[] GetParams()
		{
			return null;
		}

		// Token: 0x170004CD RID: 1229
		// (get) Token: 0x06001B64 RID: 7012 RVA: 0x00005D60 File Offset: 0x00003F60
		[Token(Token = "0x170004CD")]
		public override Vector2 Size
		{
			[Token(Token = "0x6001B64")]
			[Address(RVA = "0x6CEA", Offset = "0x6CEA", VA = "0x6CEA", Slot = "6")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x06001B65 RID: 7013 RVA: 0x00005D78 File Offset: 0x00003F78
		[Token(Token = "0x6001B65")]
		[Address(RVA = "0x6CEB", Offset = "0x6CEB", VA = "0x6CEB", Slot = "7")]
		public override bool TryGetSprite(out Sprite sprite)
		{
			return default(bool);
		}

		// Token: 0x04000ECF RID: 3791
		[Token(Token = "0x4000ECF")]
		[FieldOffset(Offset = "0x24")]
		private Sprite _sprite;
	}
}
