using System;
using Il2CppDummyDll;

namespace Core.Application.Update
{
	// Token: 0x02001236 RID: 4662
	[Token(Token = "0x2001236")]
	public class AppUpdateInstall
	{
		// Token: 0x06006EAA RID: 28330 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006EAA")]
		[Address(RVA = "0xB92E", Offset = "0xB92E", VA = "0xB92E")]
		public void Run()
		{
		}

		// Token: 0x06006EAB RID: 28331 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006EAB")]
		[Address(RVA = "0xB92F", Offset = "0xB92F", VA = "0xB92F")]
		public void Stop()
		{
		}

		// Token: 0x06006EAC RID: 28332 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006EAC")]
		[Address(RVA = "0xB930", Offset = "0xB930", VA = "0xB930")]
		public AppUpdateInstall()
		{
		/* --- GHIDRA: .ctor ---
		void Core_Application_Update_AppUpdateInstall___ctor
		               (int param1,undefined4 param2,int *param3,undefined4 param4,undefined4 param5,
		               undefined4 param6)
		
		{
		  uint uVar1;
		  undefined4 param1_00;
		  uint *puVar2;
		  int iVar3;
		  
		  if (DAT_ram_00a5a7ff == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IAuthDataProvider_TypeInfo);
		    DAT_ram_00a5a7ff = '\x01';
		  }
		  *(undefined4 *)(param1 + 0x14) = param4;
		  *(undefined4 *)(param1 + 0x10) = param5;
		  *(int **)(param1 + 0xc) = param3;
		  *(undefined4 *)(param1 + 8) = param2;
		  param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (param4,0);
		  iVar3 = *param3;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IAuthDataProvider_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8))
		      {
		        puVar2 = (uint *)(iVar3 + *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x81279769;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param3,Core_Gameplay_IAuthDataProvider_TypeInfo,0);
		code_r0x81279769:
		  iVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param3,puVar2[1]);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (param1_00,(uint)*(byte *)(iVar3 + 0x28),0);
		  return;
		}
		*/

		}
	}
}
