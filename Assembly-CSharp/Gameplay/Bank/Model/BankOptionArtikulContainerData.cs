using System;
using System.Collections.Generic;
using Core.Data;
using Il2CppDummyDll;

namespace Gameplay.Bank.Model
{
	// Token: 0x02000C56 RID: 3158
	[Token(Token = "0x2000C56")]
	public class BankOptionArtikulContainerData
	{
		// Token: 0x06004CF6 RID: 19702 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004CF6")]
		[Address(RVA = "0x9B32", Offset = "0x9B32", VA = "0x9B32")]
		public BankOptionArtikulContainerData()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Bank_Model_BankOptionArtikulContainerData___ctor
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a597c1 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a597c1 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 8);
		  while ((param1_01 = (int *)UnityEngine_UI_Image__set_sprite(param1_00,param2,0),
		         param1_01 == (int *)0x0 || (System_Action_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 8,param1_01,param1_00);
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

		// Token: 0x04002A09 RID: 10761
		[Token(Token = "0x4002A09")]
		[FieldOffset(Offset = "0x8")]
		public ArtikulData ArtikulData;

		// Token: 0x04002A0A RID: 10762
		[Token(Token = "0x4002A0A")]
		[FieldOffset(Offset = "0xC")]
		public List<ArtikulData> ContainerArtikulData;
	}
}
