using System;
using Gameplay.Boss.Model;
using Il2CppDummyDll;
using UI.ValuePicker;

namespace Gameplay.Boss.View.CaptainTab
{
	// Token: 0x02000B76 RID: 2934
	[Token(Token = "0x2000B76")]
	public class BossAttackOptionValuePicker : ValuePicker<BossInfo.BossAttackOption.BossAttackOptionVariant>
	{
		// Token: 0x06004744 RID: 18244 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004744")]
		[Address(RVA = "0x95DA", Offset = "0x95DA", VA = "0x95DA")]
		public BossAttackOptionValuePicker()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Boss_View_CaptainTab_BossAttackOptionValuePicker___ctor
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a57a33 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Action_BossInfo_BossAttackOption__BossInfo_BossAttackOption_BossAttackOptionVariant__TypeInfo
		              );
		    DAT_ram_00a57a33 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x2c);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = 
		    System_Action_BossInfo_BossAttackOption__BossInfo_BossAttackOption_BossAttackOptionVariant__TypeInfo
		    ;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,
		                             System_Action_BossInfo_BossAttackOption__BossInfo_BossAttackOption_BossAttackOptionVariant__TypeInfo
		                            ), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x2c,iVar2,param1_00);
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
