using System;
using System.Collections.Generic;
using Gameplay.Aprs.Controller;
using Gameplay.Aprs.Events;
using Gameplay.Aprs.Model;
using Il2CppDummyDll;
using UI.Windows;

namespace Gameplay.Aprs.View
{
	// Token: 0x02000D51 RID: 3409
	[Token(Token = "0x2000D51")]
	public class AprInfoWindowArgs : BaseWindowArgs
	{
		// Token: 0x06005383 RID: 21379 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005383")]
		[Address(RVA = "0xA142", Offset = "0xA142", VA = "0xA142")]
		public AprInfoWindowArgs()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Aprs_View_AprInfoWindowArgs___ctor(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a593f5 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_AprView__TypeInfo);
		    DAT_ram_00a593f5 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x44);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_AprView__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_AprView__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x44,iVar2,param1_00);
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

		// Token: 0x04002D40 RID: 11584
		[Token(Token = "0x4002D40")]
		[FieldOffset(Offset = "0x18")]
		public AprData AprData;

		// Token: 0x04002D41 RID: 11585
		[Token(Token = "0x4002D41")]
		[FieldOffset(Offset = "0x1C")]
		public List<AprData> AprsList;

		// Token: 0x04002D42 RID: 11586
		[Token(Token = "0x4002D42")]
		[FieldOffset(Offset = "0x20")]
		public AprsController AprsController;

		// Token: 0x04002D43 RID: 11587
		[Token(Token = "0x4002D43")]
		[FieldOffset(Offset = "0x24")]
		public AprsModel AprsModel;

		// Token: 0x04002D44 RID: 11588
		[Token(Token = "0x4002D44")]
		[FieldOffset(Offset = "0x28")]
		public AprsEvents AprsEvents;
	}
}
