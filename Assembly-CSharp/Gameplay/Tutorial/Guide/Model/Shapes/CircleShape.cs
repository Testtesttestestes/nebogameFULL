using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.Tutorial.Guide.Model.Shapes
{
	// Token: 0x02000481 RID: 1153
	[Token(Token = "0x2000481")]
	public class CircleShape : AbstractShape
	{
		// Token: 0x06001B5A RID: 7002 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001B5A")]
		[Address(RVA = "0x6CE0", Offset = "0x6CE0", VA = "0x6CE0", Slot = "5")]
		public override float[] GetParams()
		{
			return null;
		}

		// Token: 0x170004CB RID: 1227
		// (get) Token: 0x06001B5B RID: 7003 RVA: 0x00005D00 File Offset: 0x00003F00
		[Token(Token = "0x170004CB")]
		public override Vector2 Size
		{
			[Token(Token = "0x6001B5B")]
			[Address(RVA = "0x6CE1", Offset = "0x6CE1", VA = "0x6CE1", Slot = "6")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x06001B5C RID: 7004 RVA: 0x00005D18 File Offset: 0x00003F18
		[Token(Token = "0x6001B5C")]
		[Address(RVA = "0x6CE2", Offset = "0x6CE2", VA = "0x6CE2", Slot = "7")]
		public override bool TryGetSprite(out Sprite sprite)
		{
			return default(bool);
		}

		// Token: 0x06001B5D RID: 7005 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B5D")]
		[Address(RVA = "0x6CE3", Offset = "0x6CE3", VA = "0x6CE3")]
		public CircleShape()
		{
		}
	}
}
