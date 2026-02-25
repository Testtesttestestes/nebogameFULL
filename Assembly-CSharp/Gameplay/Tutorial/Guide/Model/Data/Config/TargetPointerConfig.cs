using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.Tutorial.Guide.Model.Data.Config
{
	// Token: 0x02000489 RID: 1161
	[Token(Token = "0x2000489")]
	[Serializable]
	public class TargetPointerConfig
	{
		// Token: 0x06001B78 RID: 7032 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B78")]
		[Address(RVA = "0x6CF7", Offset = "0x6CF7", VA = "0x6CF7")]
		public TargetPointerConfig()
		{
		}

		// Token: 0x06001B79 RID: 7033 RVA: 0x00005D90 File Offset: 0x00003F90
		[Token(Token = "0x6001B79")]
		[Address(RVA = "0x6CF8", Offset = "0x6CF8", VA = "0x6CF8")]
		public Vector2 GetScale()
		{
			return default(Vector2);
		}

		// Token: 0x04000EE2 RID: 3810
		[Token(Token = "0x4000EE2")]
		[FieldOffset(Offset = "0x8")]
		public TargetPointerShape Shape;

		// Token: 0x04000EE3 RID: 3811
		[Token(Token = "0x4000EE3")]
		[FieldOffset(Offset = "0xC")]
		public OverlapType OverlapType;

		// Token: 0x04000EE4 RID: 3812
		[Token(Token = "0x4000EE4")]
		[FieldOffset(Offset = "0x10")]
		public Vector2 Offset;

		// Token: 0x04000EE5 RID: 3813
		[Token(Token = "0x4000EE5")]
		[FieldOffset(Offset = "0x18")]
		[Obsolete]
		public float Scale;

		// Token: 0x04000EE6 RID: 3814
		[Token(Token = "0x4000EE6")]
		[FieldOffset(Offset = "0x1C")]
		public float ScaleX;

		// Token: 0x04000EE7 RID: 3815
		[Token(Token = "0x4000EE7")]
		[FieldOffset(Offset = "0x20")]
		public float ScaleY;

		// Token: 0x04000EE8 RID: 3816
		[Token(Token = "0x4000EE8")]
		[FieldOffset(Offset = "0x24")]
		public float ShadeAlpha;

		// Token: 0x04000EE9 RID: 3817
		[Token(Token = "0x4000EE9")]
		[FieldOffset(Offset = "0x28")]
		public bool OutlineDisabled;

		// Token: 0x04000EEA RID: 3818
		[Token(Token = "0x4000EEA")]
		[FieldOffset(Offset = "0x2C")]
		public float OutlineScale;
	}
}
