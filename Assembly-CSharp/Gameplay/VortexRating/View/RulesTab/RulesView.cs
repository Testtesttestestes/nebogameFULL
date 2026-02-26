using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.VortexRating.View.RulesTab
{
	// Token: 0x0200038B RID: 907
	[Token(Token = "0x200038B")]
	public class RulesView : MonoBehaviour
	{
		// Token: 0x0600151C RID: 5404 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600151C")]
		[Address(RVA = "0x66DE", Offset = "0x66DE", VA = "0x66DE")]
		public RulesView()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_VortexRating_View_RulesTab_RulesView___ctor
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a581b2 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_FilterListElement__TypeInfo);
		    DAT_ram_00a581b2 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x1c);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_FilterListElement__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_FilterListElement__TypeInfo), iVar2 == 0))
		    break;
		    iVar2 = func_ii_4329(param1 + 0x1c,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}
	}
}
