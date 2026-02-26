using System;
using Il2CppDummyDll;

namespace Core.Errors.Expected
{
	// Token: 0x02001062 RID: 4194
	[Token(Token = "0x2001062")]
	public class ExpectedGetUserLevelRewardErrors : ExpectedDefaultError
	{
		// Token: 0x06006259 RID: 25177 RVA: 0x000125E8 File Offset: 0x000107E8
		[Token(Token = "0x6006259")]
		[Address(RVA = "0xAE7F", Offset = "0xAE7F", VA = "0xAE7F", Slot = "4")]
		public override bool Handle(int errorCode)
		{
			return default(bool);
		}

		// Token: 0x0600625A RID: 25178 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600625A")]
		[Address(RVA = "0xAE80", Offset = "0xAE80", VA = "0xAE80")]
		public ExpectedGetUserLevelRewardErrors()
		{
		/* --- GHIDRA: .ctor ---
		undefined4
		Core_Errors_Expected_ExpectedGetUserLevelRewardErrors___ctor
		          (int param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  uint *puVar3;
		  undefined4 param3_00;
		  int *piVar4;
		  int iVar5;
		  int iVar6;
		  
		  if (DAT_ram_00a5a384 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Errors_Expected_ExpectedItemErrors_ErrorArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Inventory_IInventory_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_7858);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4484);
		    Mono_Security_ASN1__get_Item(&StringLiteral_9180);
		    DAT_ram_00a5a384 = '\x01';
		  }
		  piVar4 = *(int **)(param1 + 8);
		  if (piVar4 != (int *)0x0) {
		    if (((uint)*(byte *)(*piVar4 + 0xb8) <
		         (uint)*(byte *)(Core_Errors_Expected_ExpectedItemErrors_ErrorArgs_TypeInfo + 0xb8)) ||
		       (*(int *)(*(int *)(*piVar4 + 100) +
		                 (uint)*(byte *)(Core_Errors_Expected_ExpectedItemErrors_ErrorArgs_TypeInfo + 0xb8)
		                 * 4 + -4) != Core_Errors_Expected_ExpectedItemErrors_ErrorArgs_TypeInfo)) {
		      System_Activator__CreateInstance
		                (piVar4,Core_Errors_Expected_ExpectedItemErrors_ErrorArgs_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  uVar2 = 0;
		  if (param2 == -0xcb) {
		    iVar6 = piVar4[3];
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar2 = 1;
		    param3_00 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4484,1,0,1,0,0,0,0);
		    Core_Application_App__get_ToastController(iVar6,2,param3_00,0);
		  }
		  else {
		    if (param2 == -0xca) {
		      iVar6 = piVar4[3];
		      if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_GameLocalization_TypeInfo);
		      }
		      uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_7858,1,0,1,0,0,0,0);
		      Core_Application_App__get_ToastController(iVar6,2,uVar2,0);
		      return 1;
		    }
		    if (param2 != -0xc9) {
		      if (param2 == -200) {
		        iVar6 = piVar4[5];
		        if (iVar6 != 0) {
		          (**(code **)((ulonglong)*(uint *)(iVar6 + 0xc) * 4))
		                    (*(undefined4 *)(iVar6 + 0x20),piVar4[4],*(undefined4 *)(iVar6 + 0x14));
		          return 1;
		        }
		        uVar1 = 0;
		        iVar6 = piVar4[4];
		        piVar4 = (int *)piVar4[2];
		        iVar5 = *piVar4;
		        if (*(ushort *)(iVar5 + 0xb6) != 0) {
		          do {
		            if (Gameplay_Inventory_IInventory_TypeInfo ==
		                *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		              puVar3 = (uint *)(iVar5 + *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0)
		              ;
		              goto code_r0x8120f7d6;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		        }
		        puVar3 = (uint *)func_ii_1080(piVar4,Gameplay_Inventory_IInventory_TypeInfo,0);
		code_r0x8120f7d6:
		        (**(code **)((ulonglong)*puVar3 * 4))(piVar4,iVar6,puVar3[1]);
		        return 1;
		      }
		      if (param2 == -4) {
		        iVar6 = piVar4[3];
		        if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		          func_ii_306000(Core_GameLocalization_TypeInfo);
		        }
		        uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_9180,1,0,1,0,0,0,0);
		        Core_Application_App__get_ToastController(iVar6,2,uVar2,0);
		        return 1;
		      }
		    }
		  }
		  return uVar2;
		}
		*/

		}
	}
}
