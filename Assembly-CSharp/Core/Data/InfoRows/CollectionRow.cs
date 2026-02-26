using System;
using System.Collections.Generic;
using Gameplay.Collections.Model;
using Il2CppDummyDll;

namespace Core.Data.InfoRows
{
	// Token: 0x020010E4 RID: 4324
	[Token(Token = "0x20010E4")]
	public class CollectionRow : CommonRow
	{
		// Token: 0x06006525 RID: 25893 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006525")]
		[Address(RVA = "0xB0F5", Offset = "0xB0F5", VA = "0xB0F5")]
		public CollectionRow(IEnumerable<CollectionWithRank> collectionsWithRank, UserData user)
		{
		/* --- GHIDRA: .ctor ---
		void Core_Data_InfoRows_CollectionRow___ctor(int param1,int param2,int param3,undefined4 param4)
		
		{
		  char cVar1;
		  int iVar2;
		  undefined4 uVar3;
		  
		  uVar3 = *(undefined4 *)(param3 + 4);
		  *(int *)(param1 + 0x14) = param3;
		  *(undefined4 *)(param1 + 8) = uVar3;
		  *(int *)(param1 + 0x10) = param2;
		  cVar1 = *(char *)(param3 + 0x2e);
		  *(int *)(param1 + 0x20) = param1;
		  iVar2 = func_ii_4538(param3);
		  if (iVar2 == 0) {
		    if (cVar1 == '\x01') {
		      *(char **)(param1 + 0xc) = s___Scripting__UnityEngine__Playab_ram_000036f4 + 7;
		    }
		    else {
		      if (param2 == 0) {
		        uVar3 = Mono_Unity_CertHelper__AddCertificatesToNativeChain
		                          (0,s_Delegate_to_an_instance_method_c_ram_0005d205);
		        func_ii_1050(uVar3,0);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(undefined4 *)(param1 + 0xc) = *(undefined4 *)(param1 + 8);
		      *(undefined4 *)(param1 + 0x20) = *(undefined4 *)(param1 + 0x10);
		    }
		  }
		  else if (cVar1 == '\x02') {
		    *(char **)(param1 + 0xc) = s___Scripting__UnityEngine__Playab_ram_000036f4 + 6;
		  }
		  else {
		    *(undefined4 *)(param1 + 0xc) = *(undefined4 *)(param1 + 8);
		    *(undefined4 *)(param1 + 0x20) = *(undefined4 *)(param1 + 0x10);
		  }
		  *(char **)(param1 + 0x1c) = s___Scripting__UnityEngine__Playab_ram_000036f4 + 8;
		  return;
		}
		*/

		}

		// Token: 0x04003611 RID: 13841
		[Token(Token = "0x4003611")]
		[FieldOffset(Offset = "0x10")]
		public readonly IEnumerable<CollectionWithRank> CollectionsWithRank;

		// Token: 0x04003612 RID: 13842
		[Token(Token = "0x4003612")]
		[FieldOffset(Offset = "0x14")]
		public readonly UserData User;
	}
}
