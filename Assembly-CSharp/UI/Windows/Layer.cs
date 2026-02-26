using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UI.Windows
{
	// Token: 0x02000274 RID: 628
	[Token(Token = "0x2000274")]
	[AddComponentMenu("PopupLayer")]
	public class Layer : MonoBehaviour
	{
		// Token: 0x17000217 RID: 535
		// (get) Token: 0x06000F0E RID: 3854 RVA: 0x000043C8 File Offset: 0x000025C8
		[Token(Token = "0x17000217")]
		public LayerId LayerId
		{
			[Token(Token = "0x6000F0E")]
			[Address(RVA = "0x614D", Offset = "0x614D", VA = "0x614D")]
			get
			{
				return LayerId.None;
			}
		}

		// Token: 0x06000F0F RID: 3855 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F0F")]
		[Address(RVA = "0x614E", Offset = "0x614E", VA = "0x614E")]
		public Layer()
		{
		/* --- GHIDRA: .ctor ---
		void UI_Windows_Layer___ctor(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a639da == '\0') {
		    Mono_Security_ASN1__get_Item(&UI_Windows_PopupController_StateChanged_TypeInfo);
		    DAT_ram_00a639da = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x1c);
		  while ((param1_01 = (int *)UnityEngine_UI_Image__set_sprite(param1_00,param2,0),
		         param1_01 == (int *)0x0 || (UI_Windows_PopupController_StateChanged_TypeInfo == *param1_01)
		         )) {
		    iVar2 = func_ii_4329(param1 + 0x1c,param1_01,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,UI_Windows_PopupController_StateChanged_TypeInfo);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x04000790 RID: 1936
		[Token(Token = "0x4000790")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private LayerId _layerId;
	}
}
