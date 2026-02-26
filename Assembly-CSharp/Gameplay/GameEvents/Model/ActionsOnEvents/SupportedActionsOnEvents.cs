using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Protocol.Events;

namespace Gameplay.GameEvents.Model.ActionsOnEvents
{
	// Token: 0x020007DD RID: 2013
	[Token(Token = "0x20007DD")]
	public static class SupportedActionsOnEvents
	{
		// Token: 0x06002F1A RID: 12058 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002F1A")]
		[Address(RVA = "0x7F87", Offset = "0x7F87", VA = "0x7F87")]
		public static List<AbstractActionOnEvent> Create(GameEventData evt)
		{
			return null;
		}

		// Token: 0x040019BB RID: 6587
		[Token(Token = "0x40019BB")]
		[FieldOffset(Offset = "0x0")]
		public static readonly Dictionary<EventActions, Type> SupportedActionOnEvents;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: .cctor ---
		int Gameplay_GameEvents_Model_ActionsOnEvents_SupportedActionsOnEvents___cctor
		              (int param1,undefined4 param2)
		
		{
		  int param1_00;
		  int iVar1;
		  int iVar2;
		  int *param1_01;
		  uint *puVar3;
		  undefined4 param3;
		  undefined4 uVar4;
		  int iVar5;
		  int *piVar6;
		  uint uVar7;
		  int param2_00;
		  int *piVar8;
		  undefined4 local_c;
		  undefined4 local_8;
		  undefined4 local_4;
		  
		  param2_00 = 0;
		  if (DAT_ram_00a57508 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_GameEvents_Model_ActionsOnEvents_AbstractActionOnEvent_TypeInfo);
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_EventActions__Type__TryGetValue__);
		    Mono_Security_ASN1__get_Item(&Protocol_Events_EventActions_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_AbstractActionOnEvent__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_AbstractActionOnEvent___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_AbstractActionOnEvent__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Google_Protobuf_Collections_RepeatedField_EventTypeDic_Types_ActionParams__get_Count__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Google_Protobuf_Collections_RepeatedField_EventTypeDic_Types_ActionParams__get_Item__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_GameEvents_Model_ActionsOnEvents_SupportedActionsOnEvents_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_8422);
		    DAT_ram_00a57508 = '\x01';
		  }
		  local_4 = 0;
		  uVar4 = *(undefined4 *)(*(int *)(*(int *)(param1 + 0x20) + 0x20) + 0xc);
		  param1_00 = unnamed_function_1417(System_Collections_Generic_List_AbstractActionOnEvent__TypeInfo)
		  ;
		  Unity_Services_Core_Internal_UnityServicesInternal___c__DisplayClass33_0___InitializeServicesAsync_g__FailServicesInitialization_2
		            (param1_00,uVar4,Method_System_Collections_Generic_List_AbstractActionOnEvent___ctor__);
		  iVar5 = *(int *)(*(int *)(*(int *)(param1 + 0x20) + 0x20) + 0xc);
		  if (0 < iVar5) {
		    do {
		      iVar1 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                        (*(undefined4 *)(*(int *)(param1 + 0x20) + 0x20),param2_00,
		                         Method_Google_Protobuf_Collections_RepeatedField_EventTypeDic_Types_ActionParams__get_Item__
		                        );
		      if (*(int *)(Gameplay_GameEvents_Model_ActionsOnEvents_SupportedActionsOnEvents_TypeInfo +
		                  0x74) == 0) {
		        func_ii_306000(Gameplay_GameEvents_Model_ActionsOnEvents_SupportedActionsOnEvents_TypeInfo);
		      }
		      iVar2 = System_Collections_Generic_List_Enumerator_ValueTuple_object__double____MoveNext
		                        (**(undefined4 **)
		                           (
		                           Gameplay_GameEvents_Model_ActionsOnEvents_SupportedActionsOnEvents_TypeInfo
		                           + 0x5c),*(undefined4 *)(iVar1 + 0xc),&local_4,
		                         Method_System_Collections_Generic_Dictionary_EventActions__Type__TryGetValue__
		                        );
		      if (iVar2 == 0) {
		        local_8 = *(undefined4 *)(iVar1 + 0xc);
		        uVar4 = func_ii_1081(Protocol_Events_EventActions_TypeInfo,&local_8);
		        local_c = *(undefined4 *)(iVar1 + 0xc);
		        param3 = func_ii_1081(DAT_ram_00a66958,&local_c);
		        uVar4 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                          (StringLiteral_8422,uVar4,param3,0);
		        if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		          func_ii_306000(OKG_Logs_Debug_TypeInfo);
		        }
		        func_ii_7830(uVar4,0);
		      }
		      else {
		        param1_01 = (int *)func_ii_2006(local_4,0);
		        if (param1_01 != (int *)0x0) {
		          if (((uint)*(byte *)(*param1_01 + 0xb8) <
		               (uint)*(byte *)(
		                              Gameplay_GameEvents_Model_ActionsOnEvents_AbstractActionOnEvent_TypeInfo
		                              + 0xb8)) ||
		             (*(int *)(*(int *)(*param1_01 + 100) +
		                       (uint)*(byte *)(
		                                      Gameplay_GameEvents_Model_ActionsOnEvents_AbstractActionOnEvent_TypeInfo
		                                      + 0xb8) * 4 + -4) !=
		              Gameplay_GameEvents_Model_ActionsOnEvents_AbstractActionOnEvent_TypeInfo)) {
		            System_Activator__CreateInstance
		                      (param1_01,
		                       Gameplay_GameEvents_Model_ActionsOnEvents_AbstractActionOnEvent_TypeInfo);
		            do {
		              halt_trap();
		            } while( true );
		          }
		        }
		        param1_01[3] = iVar1;
		        param1_01[4] = param1;
		        if (DAT_ram_00a6456f == '\0') {
		          Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		          DAT_ram_00a6456f = '\x01';
		        }
		        piVar6 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		        iVar2 = *piVar6;
		        if (*(ushort *)(iVar2 + 0xb6) != 0) {
		          uVar7 = 0;
		          do {
		            piVar8 = (int *)(*(int *)(iVar2 + 0x58) + uVar7 * 8);
		            if (Core_Gameplay_IGame_TypeInfo == *piVar8) {
		              puVar3 = (uint *)(piVar8[1] * 8 + iVar2 + 0x178);
		              goto code_r0x80d92319;
		            }
		            uVar7 = uVar7 + 1;
		          } while (*(ushort *)(iVar2 + 0xb6) != uVar7);
		        }
		        puVar3 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80d92319:
		        uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(piVar6,puVar3[1]);
		        uVar4 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar4,0);
		        iVar2 = Core_Extensions_Dict_DictExt__GetEventCategoriesDic
		                          (uVar4,*(undefined4 *)(*(int *)(param1 + 0x20) + 0xc),
		                           *(undefined4 *)(iVar1 + 0xc),0);
		        if (iVar2 == 0) {
		          if (DAT_ram_00a6456f == '\0') {
		            Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		            DAT_ram_00a6456f = '\x01';
		          }
		          piVar6 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		          iVar2 = *piVar6;
		          if (*(ushort *)(iVar2 + 0xb6) != 0) {
		            uVar7 = 0;
		            do {
		              piVar8 = (int *)(*(int *)(iVar2 + 0x58) + uVar7 * 8);
		              if (Core_Gameplay_IGame_TypeInfo == *piVar8) {
		                puVar3 = (uint *)(piVar8[1] * 8 + iVar2 + 0x178);
		                goto code_r0x80d924aa;
		              }
		              uVar7 = uVar7 + 1;
		            } while (*(ushort *)(iVar2 + 0xb6) != uVar7);
		          }
		          puVar3 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80d924aa:
		          uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(piVar6,puVar3[1]);
		          uVar4 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar4,0);
		          iVar1 = Core_Extensions_Dict_DictExt__GetEventTypeActionDic
		                            (uVar4,*(undefined4 *)(iVar1 + 0xc),0);
		          param1_01[2] = iVar1;
		          iVar1 = Core_Extensions_Dict_EndlessPaymentOptionListOptionDicExt__GetBankBgAssetId
		                            (iVar1,0);
		          param1_01[5] = iVar1;
		        }
		        else {
		          iVar1 = Core_Extensions_Dict_EventCategoriesDicExt__GetTitle(iVar2,0);
		          param1_01[5] = iVar1;
		          if (DAT_ram_00a6456f == '\0') {
		            Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		            DAT_ram_00a6456f = '\x01';
		          }
		          piVar6 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		          iVar1 = *piVar6;
		          if (*(ushort *)(iVar1 + 0xb6) != 0) {
		            uVar7 = 0;
		            do {
		              piVar8 = (int *)(*(int *)(iVar1 + 0x58) + uVar7 * 8);
		              if (Core_Gameplay_IGame_TypeInfo == *piVar8) {
		                puVar3 = (uint *)(piVar8[1] * 8 + iVar1 + 0x178);
		                goto code_r0x80d923eb;
		              }
		              uVar7 = uVar7 + 1;
		            } while (*(ushort *)(iVar1 + 0xb6) != uVar7);
		          }
		          puVar3 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80d923eb:
		          uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(piVar6,puVar3[1]);
		          uVar4 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar4,0);
		          iVar1 = Core_Extensions_Dict_DictExt__GetEventTypeActionDic
		                            (uVar4,*(undefined4 *)(iVar2 + 0x10),0);
		          param1_01[2] = iVar1;
		        }
		        iVar1 = Method_System_Collections_Generic_List_AbstractActionOnEvent__Add__;
		        *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		        uVar7 = *(uint *)(param1_00 + 0xc);
		        if (uVar7 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		          *(uint *)(param1_00 + 0xc) = uVar7 + 1;
		          *(int **)(*(int *)(param1_00 + 8) + uVar7 * 4 + 0x10) = param1_01;
		        }
		        else {
		          System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                    (param1_00,param1_01,
		                     *(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		        }
		      }
		      param2_00 = param2_00 + 1;
		    } while (param2_00 != iVar5);
		  }
		  return param1_00;
		}
		*/

}
