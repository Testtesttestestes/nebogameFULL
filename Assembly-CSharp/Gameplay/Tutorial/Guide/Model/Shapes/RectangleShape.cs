using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.Tutorial.Guide.Model.Shapes
{
	// Token: 0x02000482 RID: 1154
	[Token(Token = "0x2000482")]
	public class RectangleShape : AbstractShape
	{
		// Token: 0x06001B5E RID: 7006 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001B5E")]
		[Address(RVA = "0x6CE4", Offset = "0x6CE4", VA = "0x6CE4", Slot = "5")]
		public override float[] GetParams()
		{
			return null;
		}

		// Token: 0x170004CC RID: 1228
		// (get) Token: 0x06001B5F RID: 7007 RVA: 0x00005D30 File Offset: 0x00003F30
		[Token(Token = "0x170004CC")]
		public override Vector2 Size
		{
			[Token(Token = "0x6001B5F")]
			[Address(RVA = "0x6CE5", Offset = "0x6CE5", VA = "0x6CE5", Slot = "6")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x06001B60 RID: 7008 RVA: 0x00005D48 File Offset: 0x00003F48
		[Token(Token = "0x6001B60")]
		[Address(RVA = "0x6CE6", Offset = "0x6CE6", VA = "0x6CE6", Slot = "7")]
		public override bool TryGetSprite(out Sprite sprite)
		{
			return default(bool);
		}

		// Token: 0x06001B61 RID: 7009 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B61")]
		[Address(RVA = "0x6CE7", Offset = "0x6CE7", VA = "0x6CE7")]
		public RectangleShape()
		{
		}
	}
}
