using System;
using System.Runtime.CompilerServices;
using Gameplay.GameEvents.Control;
using Il2CppDummyDll;

namespace Gameplay.GameEvents.Model.ActionsOnEvents
{
	// Token: 0x020007DA RID: 2010
	[Token(Token = "0x20007DA")]
	public class RouteToBillingActionOnEvent : AbstractActionOnEvent
	{
		// Token: 0x17000931 RID: 2353
		// (get) Token: 0x06002F0F RID: 12047 RVA: 0x00009900 File Offset: 0x00007B00
		[Token(Token = "0x17000931")]
		public override uint SortOrder
		{
			[Token(Token = "0x6002F0F")]
			[Address(RVA = "0x7F7C", Offset = "0x7F7C", VA = "0x7F7C", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return 0U;
			}
		}

		// Token: 0x06002F10 RID: 12048 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F10")]
		[Address(RVA = "0x7F7D", Offset = "0x7F7D", VA = "0x7F7D", Slot = "6")]
		public override void Execute(GameEventsController controller)
		{
		}

		// Token: 0x06002F11 RID: 12049 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F11")]
		[Address(RVA = "0x7F7E", Offset = "0x7F7E", VA = "0x7F7E")]
		public RouteToBillingActionOnEvent()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_GameEvents_Model_ActionsOnEvents_RouteToBillingActionOnEvent___ctor(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a57505 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_GameEvents_Model_ActionsOnEvents_RouteToBillingActionOnEvent___c_TypeInfo);
		    DAT_ram_00a57505 = '\x01';
		  }
		  uVar1 = unnamed_function_1417
		                    (
		                    Gameplay_GameEvents_Model_ActionsOnEvents_RouteToBillingActionOnEvent___c_TypeInfo
		                    );
		  **(undefined4 **)
		    (Gameplay_GameEvents_Model_ActionsOnEvents_RouteToBillingActionOnEvent___c_TypeInfo + 0x5c) =
		       uVar1;
		  return;
		}
		*/

		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_SortOrder ---
		void Gameplay_GameEvents_Model_ActionsOnEvents_RouteToBillingActionOnEvent__get_SortOrder
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int *piVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined4 *puVar4;
		  int iVar5;
		  undefined4 uVar6;
		  int iVar7;
		  double dVar8;
		  uint uVar9;
		  
		  if (DAT_ram_00a57504 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_SingleOrDefault_AbstractTag___);
		    Mono_Security_ASN1__get_Item(&System_Func_AbstractTag__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_GameEvents_Model_Tags_OptionTag_41_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_GameEvents_Model_Tags_OptionTypeTag_40_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GameEvents_Model_ActionsOnEvents_RouteToBillingActionOnEvent___c__Execute_b__3_0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GameEvents_Model_ActionsOnEvents_RouteToBillingActionOnEvent___c__Execute_b__3_1__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_GameEvents_Model_ActionsOnEvents_RouteToBillingActionOnEvent___c_TypeInfo);
		    DAT_ram_00a57504 = '\x01';
		  }
		  uVar3 = *(undefined4 *)(*(int *)(param1 + 0x10) + 0x2c);
		  if (*(int *)(Gameplay_GameEvents_Model_ActionsOnEvents_RouteToBillingActionOnEvent___c_TypeInfo +
		              0x74) == 0) {
		    func_ii_306000(
		                  Gameplay_GameEvents_Model_ActionsOnEvents_RouteToBillingActionOnEvent___c_TypeInfo
		                  );
		  }
		  puVar4 = *(undefined4 **)
		            (Gameplay_GameEvents_Model_ActionsOnEvents_RouteToBillingActionOnEvent___c_TypeInfo +
		            0x5c);
		  iVar5 = puVar4[1];
		  if (iVar5 == 0) {
		    if (*(int *)(Gameplay_GameEvents_Model_ActionsOnEvents_RouteToBillingActionOnEvent___c_TypeInfo
		                + 0x74) == 0) {
		      func_ii_306000(
		                    Gameplay_GameEvents_Model_ActionsOnEvents_RouteToBillingActionOnEvent___c_TypeInfo
		                    );
		      puVar4 = *(undefined4 **)
		                (Gameplay_GameEvents_Model_ActionsOnEvents_RouteToBillingActionOnEvent___c_TypeInfo
		                + 0x5c);
		    }
		    uVar6 = *puVar4;
		    iVar5 = unnamed_function_1417(System_Func_AbstractTag__bool__TypeInfo);
		    System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		              (iVar5,uVar6,
		               Method_Gameplay_GameEvents_Model_ActionsOnEvents_RouteToBillingActionOnEvent___c__Execute_b__3_0__
		               ,0);
		    *(int *)(*(int *)(
		                     Gameplay_GameEvents_Model_ActionsOnEvents_RouteToBillingActionOnEvent___c_TypeInfo
		                     + 0x5c) + 4) = iVar5;
		  }
		  piVar1 = (int *)UI_SimpleIconValue__set_Value
		                            (uVar3,iVar5,
		                             Method_System_Linq_Enumerable_SingleOrDefault_AbstractTag___);
		  if (piVar1 != (int *)0x0) {
		    iVar5 = *piVar1;
		    if (((uint)*(byte *)(iVar5 + 0xb8) <
		         (uint)*(byte *)(Gameplay_GameEvents_Model_Tags_OptionTypeTag_40_TypeInfo + 0xb8)) ||
		       (*(int *)(*(int *)(iVar5 + 100) +
		                 (uint)*(byte *)(Gameplay_GameEvents_Model_Tags_OptionTypeTag_40_TypeInfo + 0xb8) *
		                 4 + -4) != Gameplay_GameEvents_Model_Tags_OptionTypeTag_40_TypeInfo)) {
		      System_Activator__CreateInstance
		                (piVar1,Gameplay_GameEvents_Model_Tags_OptionTypeTag_40_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar7 = piVar1[5];
		    iVar5 = (**(code **)((ulonglong)*(uint *)(iVar5 + 0xe8) * 4))
		                      (piVar1,*(undefined4 *)(iVar5 + 0xec));
		    dVar8 = *(double *)(iVar7 + iVar5 * 8 + 8);
		    if (ABS(dVar8) < 2147483648.0) {
		      iVar5 = (int)dVar8;
		    }
		    else {
		      iVar5 = -0x80000000;
		    }
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    piVar1 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar7 = *piVar1;
		    if (*(ushort *)(iVar7 + 0xb6) != 0) {
		      uVar9 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar9 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar9 * 8 + 4) * 8 + iVar7 + 0x1b0);
		          goto code_r0x80d9b9fb;
		        }
		        uVar9 = uVar9 + 1;
		      } while (*(ushort *)(iVar7 + 0xb6) != uVar9);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar1,Core_Gameplay_IGame_TypeInfo,0x1e);
		code_r0x80d9b9fb:
		    uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar1,puVar2[1]);
		    Core_Gameplay_Managers_GameActivityRouting_GameFeatureRouterManager__get_Name(uVar3,iVar5,3,0);
		    return;
		  }
		  uVar3 = *(undefined4 *)(*(int *)(param1 + 0x10) + 0x2c);
		  if (*(int *)(Gameplay_GameEvents_Model_ActionsOnEvents_RouteToBillingActionOnEvent___c_TypeInfo +
		              0x74) == 0) {
		    func_ii_306000(
		                  Gameplay_GameEvents_Model_ActionsOnEvents_RouteToBillingActionOnEvent___c_TypeInfo
		                  );
		  }
		  puVar4 = *(undefined4 **)
		            (Gameplay_GameEvents_Model_ActionsOnEvents_RouteToBillingActionOnEvent___c_TypeInfo +
		            0x5c);
		  iVar5 = puVar4[2];
		  if (iVar5 == 0) {
		    if (*(int *)(Gameplay_GameEvents_Model_ActionsOnEvents_RouteToBillingActionOnEvent___c_TypeInfo
		                + 0x74) == 0) {
		      func_ii_306000(
		                    Gameplay_GameEvents_Model_ActionsOnEvents_RouteToBillingActionOnEvent___c_TypeInfo
		                    );
		      puVar4 = *(undefined4 **)
		                (Gameplay_GameEvents_Model_ActionsOnEvents_RouteToBillingActionOnEvent___c_TypeInfo
		                + 0x5c);
		    }
		    uVar6 = *puVar4;
		    iVar5 = unnamed_function_1417(System_Func_AbstractTag__bool__TypeInfo);
		    System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		              (iVar5,uVar6,
		               Method_Gameplay_GameEvents_Model_ActionsOnEvents_RouteToBillingActionOnEvent___c__Execute_b__3_1__
		               ,0);
		    *(int *)(*(int *)(
		                     Gameplay_GameEvents_Model_ActionsOnEvents_RouteToBillingActionOnEvent___c_TypeInfo
		                     + 0x5c) + 8) = iVar5;
		  }
		  piVar1 = (int *)UI_SimpleIconValue__set_Value
		                            (uVar3,iVar5,
		                             Method_System_Linq_Enumerable_SingleOrDefault_AbstractTag___);
		  if (piVar1 != (int *)0x0) {
		    if (((uint)*(byte *)(*piVar1 + 0xb8) <
		         (uint)*(byte *)(Gameplay_GameEvents_Model_Tags_OptionTag_41_TypeInfo + 0xb8)) ||
		       (*(int *)(*(int *)(*piVar1 + 100) +
		                 (uint)*(byte *)(Gameplay_GameEvents_Model_Tags_OptionTag_41_TypeInfo + 0xb8) * 4 +
		                -4) != Gameplay_GameEvents_Model_Tags_OptionTag_41_TypeInfo)) {
		      System_Activator__CreateInstance(piVar1,Gameplay_GameEvents_Model_Tags_OptionTag_41_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    if (ABS(*(double *)(piVar1[5] + 0x10)) < 2147483648.0) {
		      iVar5 = (int)*(double *)(piVar1[5] + 0x10);
		    }
		    else {
		      iVar5 = -0x80000000;
		    }
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    piVar1 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar7 = *piVar1;
		    if (*(ushort *)(iVar7 + 0xb6) != 0) {
		      uVar9 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar9 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar9 * 8 + 4) * 8 + iVar7 + 0x1b0);
		          goto code_r0x80d9bba9;
		        }
		        uVar9 = uVar9 + 1;
		      } while (*(ushort *)(iVar7 + 0xb6) != uVar9);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar1,Core_Gameplay_IGame_TypeInfo,0x1e);
		code_r0x80d9bba9:
		    uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar1,puVar2[1]);
		    Core_Gameplay_Managers_GameActivityRouting_GameFeatureRouterManager__get_Name(uVar3,iVar5,3,0);
		    return;
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar9 = 0;
		  piVar1 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar5 = *piVar1;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar9 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar9 * 8 + 4) * 8 + iVar5 + 0x1b0);
		        goto code_r0x80d9bc5f;
		      }
		      uVar9 = uVar9 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar9);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar1,Core_Gameplay_IGame_TypeInfo,0x1e);
		code_r0x80d9bc5f:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar1,puVar2[1]);
		  Core_Gameplay_Managers_GameActivityRouting_GameFeatureRouterManager__ShowBank(uVar3,2,3,0);
		  return;
		}
		*/

}
