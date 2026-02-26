using System;
using Il2CppDummyDll;
using UI;

namespace Gameplay.Boss.View
{
	// Token: 0x02000B4D RID: 2893
	[Token(Token = "0x2000B4D")]
	public class BossWindowStateController : MonoBehaviourWithStates<BossWindowState>
	{
		// Token: 0x06004605 RID: 17925 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004605")]
		[Address(RVA = "0x949F", Offset = "0x949F", VA = "0x949F")]
		public BossWindowStateController()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Boss_View_BossWindowStateController___ctor
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a579a6 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_BossRewardListItemView__TypeInfo);
		    DAT_ram_00a579a6 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x30);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_BossRewardListItemView__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_BossRewardListItemView__TypeInfo), iVar2 == 0))
		    break;
		    iVar2 = func_ii_4329(param1 + 0x30,iVar2,param1_00);
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
