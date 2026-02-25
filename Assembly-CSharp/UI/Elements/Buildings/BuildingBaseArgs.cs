using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UI.Elements.Buildings
{
	// Token: 0x02000248 RID: 584
	[Token(Token = "0x2000248")]
	public abstract class BuildingBaseArgs
	{
		// Token: 0x06000E4C RID: 3660 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E4C")]
		[Address(RVA = "0x60D6", Offset = "0x60D6", VA = "0x60D6")]
		public BuildingBaseArgs(Sprite backGround)
		{
		}

		// Token: 0x0400071C RID: 1820
		[Token(Token = "0x400071C")]
		[FieldOffset(Offset = "0x8")]
		public Sprite backGround;
	}
}
