using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UI.Elements.Buildings
{
	// Token: 0x02000249 RID: 585
	[Token(Token = "0x2000249")]
	public abstract class BuildingBaseArgs<BuildingT> : BuildingBaseArgs
	{
		// Token: 0x06000E4D RID: 3661 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E4D")]
		public BuildingBaseArgs(Sprite backGround, BuildingT buildingType)
		{
		}

		// Token: 0x0400071D RID: 1821
		[Token(Token = "0x400071D")]
		[FieldOffset(Offset = "0x0")]
		public BuildingT buildingType;
	}
}
