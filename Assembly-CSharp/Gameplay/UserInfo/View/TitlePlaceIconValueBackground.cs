using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.UserInfo.View
{
	// Token: 0x020003FF RID: 1023
	[Token(Token = "0x20003FF")]
	public class TitlePlaceIconValueBackground : TitleIconValueBackground
	{
		// Token: 0x0600180E RID: 6158 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600180E")]
		[Address(RVA = "0x69C5", Offset = "0x69C5", VA = "0x69C5")]
		public void SetPlace(uint place)
		{
		}

		// Token: 0x0600180F RID: 6159 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600180F")]
		[Address(RVA = "0x69C6", Offset = "0x69C6", VA = "0x69C6")]
		public TitlePlaceIconValueBackground()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_UserInfo_View_TitlePlaceIconValueBackground___ctor
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a598eb == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a598eb = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x3c);
		  while ((param1_01 = (int *)UnityEngine_UI_Image__set_sprite(param1_00,param2,0),
		         param1_01 == (int *)0x0 || (System_Action_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 0x3c,param1_01,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,System_Action_TypeInfo);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x04000CC8 RID: 3272
		[Token(Token = "0x4000CC8")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		protected Image _placeIcon;

		// Token: 0x04000CC9 RID: 3273
		[Token(Token = "0x4000CC9")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		protected Sprite _place1;

		// Token: 0x04000CCA RID: 3274
		[Token(Token = "0x4000CCA")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		protected Sprite _place10;

		// Token: 0x04000CCB RID: 3275
		[Token(Token = "0x4000CCB")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		protected Sprite _place100;
	}
}
