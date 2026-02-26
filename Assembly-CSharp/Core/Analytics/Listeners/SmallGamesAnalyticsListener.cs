using System;
using Core.Events;
using Core.Events.Scopes;
using Il2CppDummyDll;

namespace Core.Analytics.Listeners
{
	// Token: 0x020012DF RID: 4831
	[Token(Token = "0x20012DF")]
	public class SmallGamesAnalyticsListener : AbstractAnalyticsListener
	{
		// Token: 0x17001743 RID: 5955
		// (get) Token: 0x060072EF RID: 29423 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001743")]
		protected override string Theme
		{
			[Token(Token = "0x60072EF")]
			[Address(RVA = "0xBCF8", Offset = "0xBCF8", VA = "0xBCF8", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x060072F0 RID: 29424 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072F0")]
		[Address(RVA = "0xBCF9", Offset = "0xBCF9", VA = "0xBCF9", Slot = "10")]
		public override void Init()
		{
		/* --- GHIDRA: Init ---
		void Core_Analytics_Listeners_SmallGamesAnalyticsListener__Init(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a5962b == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SmallGamesScope_SlotMachineSpinEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_BaseEventBusEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_SmallGamesAnalyticsListener_DailyBonusTakenEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_SmallGamesAnalyticsListener_SlotMachineSpinEvent__);
		    DAT_ram_00a5962b = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 100);
		  uVar5 = *(undefined4 *)(iVar4 + 8);
		  uVar2 = unnamed_function_1417(System_Action_BaseEventBusEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_SmallGamesAnalyticsListener_DailyBonusTakenEvent__,0);
		  iVar1 = func_ii_7048(uVar5,uVar2,0);
		  uVar2 = System_Action_BaseEventBusEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 8) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_BaseEventBusEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 8) = iVar3;
		    uVar2 = System_Action_BaseEventBusEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_BaseEventBusEventArgs__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 100);
		  uVar5 = *(undefined4 *)(iVar4 + 0xc);
		  uVar2 = unnamed_function_1417(System_Action_SmallGamesScope_SlotMachineSpinEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_SmallGamesAnalyticsListener_SlotMachineSpinEvent__,0);
		  iVar1 = func_ii_7048(uVar5,uVar2,0);
		  uVar2 = System_Action_SmallGamesScope_SlotMachineSpinEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0xc) = 0;
		    return;
		  }
		  iVar3 = func_ii_1082(iVar1,System_Action_SmallGamesScope_SlotMachineSpinEventArgs__TypeInfo);
		  if (iVar3 != 0) {
		    *(int *)(iVar4 + 0xc) = iVar3;
		    uVar2 = System_Action_SmallGamesScope_SlotMachineSpinEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_SmallGamesScope_SlotMachineSpinEventArgs__TypeInfo);
		    if (iVar4 != 0) {
		      return;
		    }
		    System_Activator__CreateInstance(iVar1,uVar2);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  System_Activator__CreateInstance(iVar1,uVar2);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x060072F1 RID: 29425 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072F1")]
		[Address(RVA = "0xBCFA", Offset = "0xBCFA", VA = "0xBCFA", Slot = "11")]
		protected override void Deinit()
		{
		/* --- GHIDRA: Deinit ---
		void Core_Analytics_Listeners_SmallGamesAnalyticsListener__Deinit
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 in_register_20000014;
		  undefined8 uVar2;
		  int iVar3;
		  undefined4 param1_00;
		  undefined4 uVar4;
		  undefined4 uVar5;
		  uint *puVar6;
		  int iVar7;
		  undefined4 uVar8;
		  int *piVar9;
		  double param2_00;
		  undefined4 local_14;
		  undefined4 local_10;
		  undefined4 local_c;
		  undefined4 local_8;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a5962c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_FirstOrDefault_SlotMachineDic___);
		    Mono_Security_ASN1__get_Item(&System_Func_SlotMachineDic__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_IAnalyticsApi_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Common_ResourceSet_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_SmallGames_SlotMachineType_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Analytics_Listeners_SmallGamesAnalyticsListener___c__DisplayClass6_0__SlotMachineSpinEvent_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Core_Analytics_Listeners_SmallGamesAnalyticsListener___c__DisplayClass6_0_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_26155);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27353);
		    Mono_Security_ASN1__get_Item(&StringLiteral_23268);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27282);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27890);
		    DAT_ram_00a5962c = '\x01';
		  }
		  iVar3 = unnamed_function_1417
		                    (
		                    Core_Analytics_Listeners_SmallGamesAnalyticsListener___c__DisplayClass6_0_TypeInfo
		                    );
		  *(undefined4 *)(iVar3 + 8) = param2;
		  param1_00 = Core_Analytics_Listeners_AbstractAnalyticsListener__RemoveService(param1,0);
		  local_4 = *(undefined4 *)(*(int *)(iVar3 + 8) + 0x10);
		  local_8 = 0xffffffff;
		  local_c = Protocol_SmallGames_SlotMachineType_TypeInfo;
		  uVar4 = Spine_SkeletonJson__GetFloat(&local_c,0);
		  func_ii_2946(param1_00,StringLiteral_27890,uVar4,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  local_10 = *(undefined4 *)(*(int *)(iVar3 + 8) + 0x14);
		  uVar4 = func_ii_1081(DAT_ram_00a66958,&local_10);
		  func_ii_2946(param1_00,StringLiteral_27353,uVar4,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  local_14 = *(undefined4 *)(*(int *)(iVar3 + 8) + 0x18);
		  uVar4 = func_ii_1081(DAT_ram_00a66958,&local_14);
		  func_ii_2946(param1_00,StringLiteral_23268,uVar4,
		               Method_System_Collections_Generic_Dictionary_string__object__set_Item__);
		  if (*(int *)(*(int *)(iVar3 + 8) + 0x18) == 0) {
		    uVar1 = 0;
		    piVar9 = *(int **)(*(int *)(iVar3 + 8) + 0xc);
		    iVar7 = *piVar9;
		    if (*(ushort *)(iVar7 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		          puVar6 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x178);
		          goto code_r0x8103ec84;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		    }
		    puVar6 = (uint *)func_ii_1080(piVar9,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x8103ec84:
		    uVar2 = CONCAT44(in_register_20000014,puVar6[1]);
		    uVar4 = (**(code **)((ulonglong)*puVar6 * 4))(piVar9,uVar2);
		    in_register_20000014 = (undefined4)((ulonglong)uVar2 >> 0x20);
		    iVar7 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar4,0);
		    uVar8 = *(undefined4 *)(iVar7 + 0x140);
		    uVar4 = unnamed_function_1417(System_Func_SlotMachineDic__bool__TypeInfo);
		    System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		              (uVar4,iVar3,
		               Method_Core_Analytics_Listeners_SmallGamesAnalyticsListener___c__DisplayClass6_0__SlotMachineSpinEvent_b__0__
		               ,0);
		    iVar7 = System_Func_object__bool____ctor
		                      (uVar8,uVar4,Method_System_Linq_Enumerable_FirstOrDefault_SlotMachineDic___);
		    if (iVar7 != 0) {
		      uVar8 = *(undefined4 *)(iVar7 + 0x18);
		      uVar4 = unnamed_function_1417(Protocol_Common_ResourceSet_TypeInfo);
		      Protocol_Common_NullableResourceSet___ctor(uVar4,uVar8,0);
		      param2_00 = (double)*(uint *)(*(int *)(iVar3 + 8) + 0x14);
		      Core_Extensions_Dict_ResourceSetExt__Round(uVar4,param2_00,0);
		      in_register_20000014 = (undefined4)((ulonglong)param2_00 >> 0x20);
		      Gameplay_Boss_Model_BossInfo_BossAttackOption_BossAttackOptionVariant__get_Price
		                (param1,param1_00,uVar4,StringLiteral_26155,0);
		    }
		  }
		  piVar9 = (int *)param1[2];
		  uVar1 = 0;
		  uVar2 = CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0xec));
		  uVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))(param1,uVar2);
		  uVar4 = StringLiteral_27282;
		  uVar8 = (undefined4)((ulonglong)uVar2 >> 0x20);
		  iVar3 = *piVar9;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		          *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar6 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0xd8);
		        goto code_r0x8103edaf;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar6 = (uint *)func_ii_1080(piVar9,Core_Analytics_Service_IAnalyticsApi_TypeInfo,3);
		code_r0x8103edaf:
		  (**(code **)((ulonglong)*puVar6 * 4))(piVar9,CONCAT44(uVar8,uVar5),uVar4,param1_00,puVar6[1]);
		  return;
		}
		*/

		}

		// Token: 0x060072F2 RID: 29426 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072F2")]
		[Address(RVA = "0xBCFB", Offset = "0xBCFB", VA = "0xBCFB")]
		private void SlotMachineSpinEvent(SmallGamesScope.SlotMachineSpinEventArgs e)
		{
		/* --- GHIDRA: SlotMachineSpinEvent ---
		void Core_Analytics_Listeners_SmallGamesAnalyticsListener__SlotMachineSpinEvent
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  uint uVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  uint *puVar5;
		  int *param1_00;
		  int iVar6;
		  
		  if (DAT_ram_00a5962d == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Analytics_Service_IAnalyticsApi_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_22486);
		    DAT_ram_00a5962d = '\x01';
		  }
		  param1_00 = (int *)param1[2];
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xec));
		  uVar4 = Core_Analytics_Listeners_AbstractAnalyticsListener__RemoveService(param1,0);
		  uVar1 = StringLiteral_22486;
		  iVar6 = *param1_00;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    uVar2 = 0;
		    do {
		      if (Core_Analytics_Service_IAnalyticsApi_TypeInfo ==
		          *(int *)(*(int *)(iVar6 + 0x58) + uVar2 * 8)) {
		        puVar5 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar2 * 8 + 4) * 8 + iVar6 + 0xd8);
		        goto code_r0x8103ee93;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar2);
		  }
		  puVar5 = (uint *)func_ii_1080(param1_00,Core_Analytics_Service_IAnalyticsApi_TypeInfo,3);
		code_r0x8103ee93:
		  (**(code **)((ulonglong)*puVar5 * 4))(param1_00,uVar3,uVar1,uVar4,puVar5[1]);
		  return;
		}
		*/

		}

		// Token: 0x060072F3 RID: 29427 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072F3")]
		[Address(RVA = "0xBCFC", Offset = "0xBCFC", VA = "0xBCFC")]
		private void DailyBonusTakenEvent(BaseEventBusEventArgs e)
		{
		}

		// Token: 0x060072F4 RID: 29428 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60072F4")]
		[Address(RVA = "0xBCFD", Offset = "0xBCFD", VA = "0xBCFD")]
		public SmallGamesAnalyticsListener()
		{
		}

		// Token: 0x04003C2D RID: 15405
		[Token(Token = "0x4003C2D")]
		private const string DAILY_BONUS_TAKEN = "daily_bonus_taken";

		// Token: 0x04003C2E RID: 15406
		[Token(Token = "0x4003C2E")]
		private const string SLOTMACHINE_SPIN = "slotmachine_spin";
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Theme ---
		void Core_Analytics_Listeners_SmallGamesAnalyticsListener__get_Theme(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a5962a == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SmallGamesScope_SlotMachineSpinEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_BaseEventBusEventArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_SmallGamesAnalyticsListener_DailyBonusTakenEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Analytics_Listeners_SmallGamesAnalyticsListener_SlotMachineSpinEvent__);
		    DAT_ram_00a5962a = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 100);
		  uVar5 = *(undefined4 *)(iVar4 + 8);
		  uVar2 = unnamed_function_1417(System_Action_BaseEventBusEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_SmallGamesAnalyticsListener_DailyBonusTakenEvent__,0);
		  iVar1 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		  uVar2 = System_Action_BaseEventBusEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 8) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_BaseEventBusEventArgs__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 8) = iVar3;
		    uVar2 = System_Action_BaseEventBusEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_BaseEventBusEventArgs__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  iVar4 = *(int *)(iVar1 + 100);
		  uVar5 = *(undefined4 *)(iVar4 + 0xc);
		  uVar2 = unnamed_function_1417(System_Action_SmallGamesScope_SlotMachineSpinEventArgs__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Core_Analytics_Listeners_SmallGamesAnalyticsListener_SlotMachineSpinEvent__,0);
		  iVar1 = UnityEngine_UI_Image__set_sprite(uVar5,uVar2,0);
		  uVar2 = System_Action_SmallGamesScope_SlotMachineSpinEventArgs__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0xc) = 0;
		    return;
		  }
		  iVar3 = func_ii_1082(iVar1,System_Action_SmallGamesScope_SlotMachineSpinEventArgs__TypeInfo);
		  if (iVar3 != 0) {
		    *(int *)(iVar4 + 0xc) = iVar3;
		    uVar2 = System_Action_SmallGamesScope_SlotMachineSpinEventArgs__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_SmallGamesScope_SlotMachineSpinEventArgs__TypeInfo);
		    if (iVar4 != 0) {
		      return;
		    }
		    System_Activator__CreateInstance(iVar1,uVar2);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  System_Activator__CreateInstance(iVar1,uVar2);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

}
