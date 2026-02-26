using System;
using Gameplay.Boss.Controller;
using Gameplay.Boss.Events;
using Gameplay.Boss.Model;
using Il2CppDummyDll;
using UI.Windows;

namespace Gameplay.Boss.View.ListView
{
	// Token: 0x02000B6C RID: 2924
	[Token(Token = "0x2000B6C")]
	public class BossListWindowArgs : BaseWindowArgs
	{
		// Token: 0x06004705 RID: 18181 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004705")]
		[Address(RVA = "0x959B", Offset = "0x959B", VA = "0x959B")]
		public BossListWindowArgs()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Boss_View_ListView_BossListWindowArgs___ctor
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a57a12 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_BossInviteData__TypeInfo);
		    DAT_ram_00a57a12 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x20);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_BossInviteData__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_BossInviteData__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x20,iVar2,param1_00);
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

		// Token: 0x040026F3 RID: 9971
		[Token(Token = "0x40026F3")]
		[FieldOffset(Offset = "0x18")]
		public BossController Controller;

		// Token: 0x040026F4 RID: 9972
		[Token(Token = "0x40026F4")]
		[FieldOffset(Offset = "0x1C")]
		public BossEvents Events;

		// Token: 0x040026F5 RID: 9973
		[Token(Token = "0x40026F5")]
		[FieldOffset(Offset = "0x20")]
		public BossModel Model;
	}
}
