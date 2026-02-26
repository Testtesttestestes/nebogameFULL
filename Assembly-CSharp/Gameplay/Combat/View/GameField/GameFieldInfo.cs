using System;
using Il2CppDummyDll;

namespace Gameplay.Combat.View.GameField
{
	// Token: 0x0200095E RID: 2398
	[Token(Token = "0x200095E")]
	public abstract class GameFieldInfo
	{
		// Token: 0x060038DA RID: 14554 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60038DA")]
		[Address(RVA = "0x8878", Offset = "0x8878", VA = "0x8878")]
		protected GameFieldInfo()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Combat_View_GameField_GameFieldInfo___ctor
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5671b == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_StoneMono__StoneMono__TypeInfo);
		    DAT_ram_00a5671b = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x10);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_StoneMono__StoneMono__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_StoneMono__StoneMono__TypeInfo), iVar2 == 0))
		    break;
		    iVar2 = func_ii_4329(param1 + 0x10,iVar2,param1_00);
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

		// Token: 0x04001F67 RID: 8039
		[Token(Token = "0x4001F67")]
		public const int CellSize = 88;

		// Token: 0x04001F68 RID: 8040
		[Token(Token = "0x4001F68")]
		public const int HalfCellSize = 44;
	}
}
