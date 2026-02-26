using System;
using Core.Data;
using Il2CppDummyDll;
using UI.Windows;

namespace Gameplay.Medals.View
{
	// Token: 0x020005FC RID: 1532
	[Token(Token = "0x20005FC")]
	public class MedalsWindowArgs : BaseWindowArgs
	{
		// Token: 0x06002535 RID: 9525 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002535")]
		[Address(RVA = "0x767E", Offset = "0x767E", VA = "0x767E")]
		public MedalsWindowArgs()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Medals_View_MedalsWindowArgs___ctor(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a57d9a == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_FilterButton__TypeInfo);
		    DAT_ram_00a57d9a = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x20);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_FilterButton__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_FilterButton__TypeInfo), iVar2 == 0)) break;
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

		// Token: 0x0400145E RID: 5214
		[Token(Token = "0x400145E")]
		[FieldOffset(Offset = "0x18")]
		public UserData Owner;

		// Token: 0x0400145F RID: 5215
		[Token(Token = "0x400145F")]
		[FieldOffset(Offset = "0x1C")]
		public UserData LoggedUser;

		// Token: 0x04001460 RID: 5216
		[Token(Token = "0x4001460")]
		[FieldOffset(Offset = "0x20")]
		public Predicate<MedalData> CustomFilter;
	}
}
