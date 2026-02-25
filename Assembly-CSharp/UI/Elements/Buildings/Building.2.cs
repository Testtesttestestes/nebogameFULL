using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UI.Elements.Buildings
{
	// Token: 0x02000246 RID: 582
	[Token(Token = "0x2000246")]
	public abstract class Building<T, BuildingT> : Building where T : BuildingBaseArgs
	{
		// Token: 0x170001EB RID: 491
		// (get) Token: 0x06000E47 RID: 3655 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170001EB")]
		public BuildingT BuildingType
		{
			[Token(Token = "0x6000E47")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000E48 RID: 3656 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E48")]
		protected override void OnInit(BuildingBaseArgs args)
		{
		}

		// Token: 0x06000E49 RID: 3657
		[Token(Token = "0x6000E49")]
		protected abstract void OnInit(T args);

		// Token: 0x06000E4A RID: 3658 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E4A")]
		protected Building()
		{
		}

		// Token: 0x0400071B RID: 1819
		[Token(Token = "0x400071B")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private BuildingT _buildingType;

		// Token: 0x02000247 RID: 583
		[Token(Token = "0x2000247")]
		public abstract class BuildingBaseTArgs : BuildingBaseArgs<BuildingT>
		{
			// Token: 0x06000E4B RID: 3659 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000E4B")]
			protected BuildingBaseTArgs(Sprite backGround, BuildingT buildingType)
			{
			}
		}
	}
}
