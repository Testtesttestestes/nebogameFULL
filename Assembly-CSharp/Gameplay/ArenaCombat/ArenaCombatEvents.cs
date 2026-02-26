using System;
using Gameplay.Combat.Events;
using Il2CppDummyDll;

namespace Gameplay.ArenaCombat
{
	// Token: 0x02000D42 RID: 3394
	[Token(Token = "0x2000D42")]
	public class ArenaCombatEvents : CombatEvents
	{
		// Token: 0x06005323 RID: 21283 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005323")]
		[Address(RVA = "0xA0F8", Offset = "0xA0F8", VA = "0xA0F8")]
		public ArenaCombatEvents()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_ArenaCombat_ArenaCombatEvents___ctor(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a593c7 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_long__TypeInfo);
		    DAT_ram_00a593c7 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x30);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_long__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_long__TypeInfo), iVar2 == 0)) break;
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
