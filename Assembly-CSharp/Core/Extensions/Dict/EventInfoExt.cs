using System;
using Il2CppDummyDll;
using Protocol.Events;

namespace Core.Extensions.Dict
{
	// Token: 0x02000F6D RID: 3949
	[Token(Token = "0x2000F6D")]
	public static class EventInfoExt
	{
		// Token: 0x06005F2A RID: 24362 RVA: 0x000116D0 File Offset: 0x0000F8D0
		[Token(Token = "0x6005F2A")]
		[Address(RVA = "0x1AC4", Offset = "0x1AC4", VA = "0x1AC4")]
		public static bool IsDeleted(this ProtoGetEventsListAns.Types.EventInfo eventInfo)
		{
		/* --- GHIDRA: IsDeleted ---
		int Core_Extensions_Dict_EventInfoExt__IsDeleted(int param1,int param2,undefined4 param3)
		
		{
		  uint *param1_00;
		  uint uVar1;
		  int iVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  int iVar5;
		  undefined4 uVar6;
		  int param2_00;
		  int *piVar7;
		  undefined4 uVar8;
		  undefined4 *puVar9;
		  int iVar10;
		  undefined4 param2_01;
		  int iVar11;
		  int param1_01;
		  undefined8 uVar12;
		  int *piVar13;
		  uint *local_8;
		  int local_4;
		  
		  if (DAT_ram_00a574c1 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_ulong__GameEventData__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_ulong__GameEventData__TryGetValue__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_Select_IMetaTagFactory__AbstractTag___);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_Select_uint__EventTagDic_Types_Tag___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToArray_EventTagDic_Types_Tag___);
		    Mono_Security_ASN1__get_Item(&System_Func_IMetaTagFactory__AbstractTag__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Func_uint__EventTagDic_Types_Tag__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_GameEvents_Model_GameEventData_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_GameEvents_Model_GameEventsModel__GetEvent_b__40_1__);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_GameEvents_Model_Tags_Repo_IMetaTagFactoriesRepository_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_GameEvents_Model_Tags_Repo_ISourceTagFactoriesRepository_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_GameEvents_Model_Tags_Factories_ISourceTagFactory_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_AbstractTag__AddRange__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_AbstractTag__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_AbstractTag___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_AbstractTag__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ulong__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_GameEvents_Model_ActionsOnEvents_SupportedActionsOnEvents_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_GameEvents_Model_GameEventsModel___c__GetEvent_b__40_0__);
		    Mono_Security_ASN1__get_Item(&Gameplay_GameEvents_Model_GameEventsModel___c_TypeInfo);
		    DAT_ram_00a574c1 = '\x01';
		  }
		  local_4 = 0;
		  local_8 = (uint *)0x0;
		  uVar12 = *(undefined8 *)(param2 + 0x10);
		  iVar2 = func_ii_7090(*(undefined4 *)(param1 + 0x28),uVar12,&local_4,
		                       Method_System_Collections_Generic_Dictionary_ulong__GameEventData__TryGetValue__
		                      );
		  uVar6 = (undefined4)((ulonglong)uVar12 >> 0x20);
		  if (iVar2 == 0) {
		    uVar1 = 0;
		    piVar7 = *(int **)(param1 + 0xc);
		    iVar2 = *piVar7;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x178);
		          goto code_r0x80d916c0;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar7,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80d916c0:
		    uVar12 = CONCAT44(uVar6,puVar3[1]);
		    uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(piVar7,uVar12);
		    uVar6 = (undefined4)((ulonglong)uVar12 >> 0x20);
		    uVar4 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar4,0);
		    iVar2 = Core_Gameplay_Managers_DictManager__get_D(uVar4,*(undefined4 *)(param2 + 0x20),0);
		    uVar4 = unnamed_function_1417(System_Collections_Generic_List_AbstractTag__TypeInfo);
		    GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		              (uVar4,Method_System_Collections_Generic_List_AbstractTag___ctor__);
		    uVar8 = *(undefined4 *)(iVar2 + 0x1c);
		    piVar7 = *(int **)(param1 + 0x24);
		    if (*(int *)(Gameplay_GameEvents_Model_GameEventsModel___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_GameEvents_Model_GameEventsModel___c_TypeInfo);
		    }
		    puVar9 = *(undefined4 **)(Gameplay_GameEvents_Model_GameEventsModel___c_TypeInfo + 0x5c);
		    iVar10 = puVar9[3];
		    if (iVar10 == 0) {
		      if (*(int *)(Gameplay_GameEvents_Model_GameEventsModel___c_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Gameplay_GameEvents_Model_GameEventsModel___c_TypeInfo);
		        puVar9 = *(undefined4 **)(Gameplay_GameEvents_Model_GameEventsModel___c_TypeInfo + 0x5c);
		      }
		      param2_01 = *puVar9;
		      iVar10 = unnamed_function_1417(System_Func_uint__EventTagDic_Types_Tag__TypeInfo);
		      System_Func_uint__int___Invoke
		                (iVar10,param2_01,
		                 Method_Gameplay_GameEvents_Model_GameEventsModel___c__GetEvent_b__40_0__,0);
		      *(int *)(*(int *)(Gameplay_GameEvents_Model_GameEventsModel___c_TypeInfo + 0x5c) + 0xc) =
		           iVar10;
		    }
		    uVar1 = 0;
		    uVar8 = System_Linq_Enumerable__ReverseIterator___Il2CppFullySharedGenericType_
		                      (uVar8,iVar10,
		                       Method_System_Linq_Enumerable_Select_uint__EventTagDic_Types_Tag___);
		    uVar8 = System_Linq_Enumerable__Select_object__Int32Enum_
		                      (uVar8,Method_System_Linq_Enumerable_ToArray_EventTagDic_Types_Tag___);
		    iVar10 = *piVar7;
		    if (*(ushort *)(iVar10 + 0xb6) != 0) {
		      do {
		        if (Gameplay_GameEvents_Model_Tags_Repo_IMetaTagFactoriesRepository_TypeInfo ==
		            *(int *)(*(int *)(iVar10 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar10 + 0x58) + uVar1 * 8 + 4) * 8 + iVar10 + 200);
		          goto code_r0x80d9181c;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar10 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar7,
		                                  Gameplay_GameEvents_Model_Tags_Repo_IMetaTagFactoriesRepository_TypeInfo
		                                  ,1);
		code_r0x80d9181c:
		    uVar12 = CONCAT44(uVar6,uVar8);
		    iVar10 = (**(code **)((ulonglong)*puVar3 * 4))(piVar7,uVar12,&local_8,puVar3[1]);
		    param1_00 = local_8;
		    uVar6 = (undefined4)((ulonglong)uVar12 >> 0x20);
		    if (iVar10 != 0) {
		      uVar8 = unnamed_function_1417(System_Func_IMetaTagFactory__AbstractTag__TypeInfo);
		      System_Linq_Enumerable__Where_object_
		                (uVar8,param1,Method_Gameplay_GameEvents_Model_GameEventsModel__GetEvent_b__40_1__,0
		                );
		      uVar8 = System_Linq_Enumerable__ReverseIterator___Il2CppFullySharedGenericType_
		                        (param1_00,uVar8,
		                         Method_System_Linq_Enumerable_Select_IMetaTagFactory__AbstractTag___);
		      func_ii_6335(uVar4,uVar8,Method_System_Collections_Generic_List_AbstractTag__AddRange__);
		      puVar3 = param1_00;
		    }
		    Gameplay_GameEvents_Model_GameEventsModel__ResetCacheByCategory(uVar4,param2,puVar3);
		    iVar10 = unnamed_function_1417(Gameplay_GameEvents_Model_GameEventData_TypeInfo);
		    Gameplay_GameEvents_Model_GameEventData__Dispose(iVar10,iVar2,param2,uVar4,iVar10);
		    local_4 = iVar10;
		    uVar4 = Core_Extensions_Dict_EventTypeActionDicExt__GetLabel(*(undefined4 *)(iVar10 + 0x20),0);
		    iVar5 = Newtonsoft_Json_Serialization_JsonSerializerInternalReader__ShouldDeserialize(uVar4,0);
		    iVar10 = local_4;
		    if (iVar5 == 0) {
		      piVar7 = *(int **)(param1 + 0xc);
		      iVar5 = *piVar7;
		      if (*(ushort *)(iVar5 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		            puVar3 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x178);
		            goto code_r0x80d91924;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		      }
		      puVar3 = (uint *)func_ii_1080(piVar7,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80d91924:
		      uVar12 = CONCAT44(uVar6,puVar3[1]);
		      uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(piVar7,uVar12);
		      uVar6 = (undefined4)((ulonglong)uVar12 >> 0x20);
		      uVar8 = Core_Extensions_Dict_EventTypeActionDicExt__GetLabel(iVar2,0);
		      uVar4 = Core_Gameplay_Managers_DictManager__CheckSupportedService(uVar4,uVar8,0);
		      *(undefined4 *)(iVar10 + 0x3c) = uVar4;
		    }
		    iVar10 = local_4;
		    *(int *)(local_4 + 0x18) = param1;
		    if (*(int *)(Gameplay_GameEvents_Model_ActionsOnEvents_SupportedActionsOnEvents_TypeInfo + 0x74)
		        == 0) {
		      func_ii_306000(Gameplay_GameEvents_Model_ActionsOnEvents_SupportedActionsOnEvents_TypeInfo);
		    }
		    uVar4 = Gameplay_GameEvents_Model_ActionsOnEvents_SupportedActionsOnEvents___cctor
		                      (iVar10,iVar10);
		    iVar5 = local_4;
		    *(undefined4 *)(iVar10 + 0x34) = uVar4;
		    uVar1 = 0;
		    piVar7 = *(int **)(param1 + 0xc);
		    iVar10 = *piVar7;
		    if (*(ushort *)(iVar10 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar10 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar10 + 0x58) + uVar1 * 8 + 4) * 8 + iVar10 + 0x178);
		          goto code_r0x80d919f2;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar10 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar7,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80d919f2:
		    uVar12 = CONCAT44(uVar6,puVar3[1]);
		    uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(piVar7,uVar12);
		    uVar6 = (undefined4)((ulonglong)uVar12 >> 0x20);
		    uVar4 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar4,0);
		    uVar12 = CONCAT44(uVar6,*(undefined4 *)(iVar2 + 0x18));
		    uVar6 = Core_Extensions_Dict_DictExt__GetMonsterDic(uVar4,*(undefined4 *)(iVar2 + 0x18),0);
		    *(undefined4 *)(iVar5 + 0x1c) = uVar6;
		    iVar10 = *(int *)(*(int *)(param2 + 0x30) + 0xc);
		    if (0 < iVar10) {
		      iVar5 = 0;
		      do {
		        uVar6 = (undefined4)((ulonglong)uVar12 >> 0x20);
		        uVar4 = *(undefined4 *)(iVar2 + 0x10);
		        piVar7 = *(int **)(param1 + 0x20);
		        iVar11 = *piVar7;
		        if (*(ushort *)(iVar11 + 0xb6) != 0) {
		          uVar1 = 0;
		          do {
		            piVar13 = (int *)(*(int *)(iVar11 + 0x58) + uVar1 * 8);
		            if (Gameplay_GameEvents_Model_Tags_Repo_ISourceTagFactoriesRepository_TypeInfo ==
		                *piVar13) {
		              puVar3 = (uint *)(iVar11 + piVar13[1] * 8 + 0xc0);
		              goto code_r0x80d91aa3;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar11 + 0xb6) != uVar1);
		        }
		        puVar3 = (uint *)func_ii_1080(piVar7,
		                                      Gameplay_GameEvents_Model_Tags_Repo_ISourceTagFactoriesRepository_TypeInfo
		                                      ,0);
		code_r0x80d91aa3:
		        uVar12 = CONCAT44(uVar6,uVar4);
		        piVar7 = (int *)(**(code **)((ulonglong)*puVar3 * 4))(piVar7,uVar12,puVar3[1]);
		        uVar6 = (undefined4)((ulonglong)uVar12 >> 0x20);
		        iVar11 = *piVar7;
		        if (*(ushort *)(iVar11 + 0xb6) != 0) {
		          uVar1 = 0;
		          do {
		            piVar13 = (int *)(*(int *)(iVar11 + 0x58) + uVar1 * 8);
		            if (Gameplay_GameEvents_Model_Tags_Factories_ISourceTagFactory_TypeInfo == *piVar13) {
		              puVar3 = (uint *)(iVar11 + piVar13[1] * 8 + 0xc0);
		              goto code_r0x80d91b23;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar11 + 0xb6) != uVar1);
		        }
		        puVar3 = (uint *)func_ii_1080(piVar7,
		                                      Gameplay_GameEvents_Model_Tags_Factories_ISourceTagFactory_TypeInfo
		                                      ,0);
		code_r0x80d91b23:
		        uVar12 = CONCAT44(uVar6,puVar3[1]);
		        param2_00 = (**(code **)((ulonglong)*puVar3 * 4))(piVar7,uVar12);
		        iVar5 = iVar5 + 1;
		        *(int *)(param2_00 + 0x10) = iVar5;
		        iVar11 = Method_System_Collections_Generic_List_AbstractTag__Add__;
		        param1_01 = *(int *)(local_4 + 0x28);
		        *(int *)(param1_01 + 0x10) = *(int *)(param1_01 + 0x10) + 1;
		        uVar1 = *(uint *)(param1_01 + 0xc);
		        if (uVar1 < *(uint *)(*(int *)(param1_01 + 8) + 0xc)) {
		          *(uint *)(param1_01 + 0xc) = uVar1 + 1;
		          *(int *)(*(int *)(param1_01 + 8) + uVar1 * 4 + 0x10) = param2_00;
		        }
		        else {
		          uVar12 = CONCAT44((int)((ulonglong)uVar12 >> 0x20),param2_00);
		          System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                    (param1_01,param2_00,
		                     *(undefined4 *)(*(int *)(*(int *)(iVar11 + 0x10) + 0x60) + 0x38));
		        }
		      } while (iVar5 != iVar10);
		    }
		    BestHTTP_Caching_HTTPCacheFileInfo___ctor
		              (*(undefined4 *)(param1 + 0x28),*(undefined8 *)(param2 + 0x10),local_4,
		               Method_System_Collections_Generic_Dictionary_ulong__GameEventData__Add__);
		  }
		  else {
		    *(int *)(local_4 + 0x24) = param2;
		  }
		  return local_4;
		}
		*/

			return default(bool);
		}
	}
}
