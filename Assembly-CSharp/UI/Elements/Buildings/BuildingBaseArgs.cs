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
		/* --- GHIDRA: .ctor ---
		int UI_Elements_Buildings_BuildingBaseArgs___ctor(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a639ab == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_IGuideTarget___);
		    DAT_ram_00a639ab = '\x01';
		  }
		  iVar1 = *(int *)(param1 + 0x34);
		  if (iVar1 == 0) {
		    iVar1 = func_ii_5677(*(undefined4 *)(param1 + 0x10),
		                         Method_UnityEngine_Component_GetComponent_IGuideTarget___);
		  }
		  *(int *)(param1 + 0x34) = iVar1;
		  return iVar1;
		}
		*/

		}

		// Token: 0x0400071C RID: 1820
		[Token(Token = "0x400071C")]
		[FieldOffset(Offset = "0x8")]
		public Sprite backGround;
	}
}
