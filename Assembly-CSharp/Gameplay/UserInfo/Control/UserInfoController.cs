using System;
using System.Collections.Generic;
using Core.Data;
using Core.Dict.DictWrappers.Wrappers;
using Gameplay.UserInfo.Model;
using Google.Protobuf;
using Il2CppDummyDll;
using MVC;
using Protocol.Common;
using Protocol.Dic;
using ServicesNamespace;
using Utils;
using Utils.Accumulators;

namespace Gameplay.UserInfo.Control
{
	// Token: 0x0200041B RID: 1051
	[Token(Token = "0x200041B")]
	public class UserInfoController : AbstractController<UserInfoModel, UserInfoEvents>
	{
		// Token: 0x06001895 RID: 6293 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001895")]
		[Address(RVA = "0x6A34", Offset = "0x6A34", VA = "0x6A34")]
		public UserInfoController(MainService mainService, ServicesService servicesService, UserInfoModel model, UserInfoEvents events)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_UserInfo_Control_UserInfoController___ctor(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined8 uVar4;
		  int iVar5;
		  int iVar6;
		  int *piVar7;
		  uint uVar8;
		  
		  if (DAT_ram_00a59917 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Cache_CacheResultCallback_UserData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Cache_ICache_ulong__UserData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&ulong___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_UserInfo_Control_UserInfoController_UserBasicCacheResultCallback__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_UserInfo_Control_UserInfoController_UserCacheResultCallback__);
		    DAT_ram_00a59917 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  iVar5 = *(int *)(iVar1 + 8);
		  iVar6 = *(int *)(*(int *)(iVar1 + 0xc) + 8);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  if (iVar6 == iVar5) {
		    iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    uVar8 = 0;
		    piVar7 = *(int **)(iVar5 + 0x28);
		    iVar5 = *piVar7;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar8 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar8 * 8 + 4) * 8 + iVar5 + 0x120);
		          goto code_r0x8108f942;
		        }
		        uVar8 = uVar8 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar8);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar7,Core_Gameplay_IGame_TypeInfo,0xc);
		code_r0x8108f942:
		    iVar5 = (**(code **)((ulonglong)*puVar2 * 4))(piVar7,puVar2[1]);
		    *(undefined4 *)(iVar1 + 0x14) = *(undefined4 *)(iVar5 + 0x10);
		    Gameplay_UserInfo_Control_UserInfoController__HandleGetUserArtifactsService(param1,puVar2);
		  }
		  else {
		    uVar8 = 0;
		    piVar7 = *(int **)(iVar1 + 0x28);
		    iVar1 = *piVar7;
		    if (*(ushort *)(iVar1 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar1 + 0x58) + uVar8 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar1 + 0x58) + uVar8 * 8 + 4) * 8 + iVar1 + 0x158);
		          goto code_r0x8108f9d8;
		        }
		        uVar8 = uVar8 + 1;
		      } while (*(ushort *)(iVar1 + 0xb6) != uVar8);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar7,Core_Gameplay_IGame_TypeInfo,0x13);
		code_r0x8108f9d8:
		    iVar1 = (**(code **)((ulonglong)*puVar2 * 4))(piVar7,puVar2[1]);
		    piVar7 = *(int **)(iVar1 + 0x18);
		    uVar8 = 0;
		    uVar3 = unnamed_function_1417(Core_Cache_CacheResultCallback_UserData__TypeInfo);
		    Cysharp_Threading_Tasks_UniTaskCompletionSource__get_Task
		              (uVar3,param1,
		               Method_Gameplay_UserInfo_Control_UserInfoController_UserCacheResultCallback__,0);
		    iVar1 = Mono_Security_ASN1Convert__ToOid(ulong___TypeInfo,1);
		    iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    uVar4 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext
		                      (*(undefined4 *)(iVar5 + 8),0);
		    *(undefined8 *)(iVar1 + 0x10) = uVar4;
		    iVar5 = *piVar7;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      do {
		        if (Core_Cache_ICache_ulong__UserData__TypeInfo ==
		            *(int *)(*(int *)(iVar5 + 0x58) + uVar8 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar8 * 8 + 4) * 8 + iVar5 + 200);
		          goto code_r0x8108faaf;
		        }
		        uVar8 = uVar8 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar8);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar7,Core_Cache_ICache_ulong__UserData__TypeInfo,1);
		code_r0x8108faaf:
		    (**(code **)((ulonglong)*puVar2 * 4))(piVar7,uVar3,iVar1,puVar2[1]);
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  if (*(int *)(iVar1 + 8) != *(int *)(*(int *)(iVar1 + 0xc) + 8)) {
		    puVar2 = (uint *)*param1;
		    iVar1 = (**(code **)((ulonglong)puVar2[0x40] * 4))(param1,puVar2[0x41]);
		    if (*(char *)(*(int *)(iVar1 + 8) + 0x48) != '\0') goto code_r0x8108fdc5;
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar8 = 0;
		  piVar7 = *(int **)(iVar1 + 0x28);
		  iVar1 = *piVar7;
		  if (*(ushort *)(iVar1 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar1 + 0x58) + uVar8 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar1 + 0x58) + uVar8 * 8 + 4) * 8 + iVar1 + 0x158);
		        goto code_r0x8108fb8f;
		      }
		      uVar8 = uVar8 + 1;
		    } while (*(ushort *)(iVar1 + 0xb6) != uVar8);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar7,Core_Gameplay_IGame_TypeInfo,0x13);
		code_r0x8108fb8f:
		  iVar1 = (**(code **)((ulonglong)*puVar2 * 4))(piVar7,puVar2[1]);
		  piVar7 = *(int **)(iVar1 + 0x14);
		  uVar8 = 0;
		  iVar1 = Mono_Security_ASN1Convert__ToOid(ulong___TypeInfo,1);
		  iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar4 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext
		                    (*(undefined4 *)(iVar5 + 8),0);
		  *(undefined8 *)(iVar1 + 0x10) = uVar4;
		  iVar5 = *piVar7;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Cache_ICache_ulong__UserData__TypeInfo ==
		          *(int *)(*(int *)(iVar5 + 0x58) + uVar8 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar8 * 8 + 4) * 8 + iVar5 + 0xd0);
		        goto code_r0x8108fc47;
		      }
		      uVar8 = uVar8 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar8);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar7,Core_Cache_ICache_ulong__UserData__TypeInfo,2);
		code_r0x8108fc47:
		  (**(code **)((ulonglong)*puVar2 * 4))(piVar7,iVar1,puVar2[1]);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar8 = 0;
		  piVar7 = *(int **)(iVar1 + 0x28);
		  iVar1 = *piVar7;
		  if (*(ushort *)(iVar1 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar1 + 0x58) + uVar8 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar1 + 0x58) + uVar8 * 8 + 4) * 8 + iVar1 + 0x158);
		        goto code_r0x8108fcdf;
		      }
		      uVar8 = uVar8 + 1;
		    } while (*(ushort *)(iVar1 + 0xb6) != uVar8);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar7,Core_Gameplay_IGame_TypeInfo,0x13);
		code_r0x8108fcdf:
		  iVar1 = (**(code **)((ulonglong)*puVar2 * 4))(piVar7,puVar2[1]);
		  piVar7 = *(int **)(iVar1 + 0x14);
		  uVar8 = 0;
		  uVar3 = unnamed_function_1417(Core_Cache_CacheResultCallback_UserData__TypeInfo);
		  Cysharp_Threading_Tasks_UniTaskCompletionSource__get_Task
		            (uVar3,param1,
		             Method_Gameplay_UserInfo_Control_UserInfoController_UserBasicCacheResultCallback__,0);
		  iVar1 = Mono_Security_ASN1Convert__ToOid(ulong___TypeInfo,1);
		  iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar4 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext
		                    (*(undefined4 *)(iVar5 + 8),0);
		  *(undefined8 *)(iVar1 + 0x10) = uVar4;
		  iVar5 = *piVar7;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Cache_ICache_ulong__UserData__TypeInfo ==
		          *(int *)(*(int *)(iVar5 + 0x58) + uVar8 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar8 * 8 + 4) * 8 + iVar5 + 200);
		        goto code_r0x8108fdb6;
		      }
		      uVar8 = uVar8 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar8);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar7,Core_Cache_ICache_ulong__UserData__TypeInfo,1);
		code_r0x8108fdb6:
		  (**(code **)((ulonglong)*puVar2 * 4))(piVar7,uVar3,iVar1,puVar2[1]);
		code_r0x8108fdc5:
		  Gameplay_UserInfo_Control_UserInfoController__HandleGetPossibleNicksService(param1,puVar2);
		  return;
		}
		*/

		}

		// Token: 0x06001896 RID: 6294 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001896")]
		[Address(RVA = "0x6A35", Offset = "0x6A35", VA = "0x6A35", Slot = "7")]
		protected override void HandleRun()
		{
		/* --- GHIDRA: HandleRun ---
		void Gameplay_UserInfo_Control_UserInfoController__HandleRun(int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  undefined8 uVar5;
		  int iVar6;
		  int *piVar7;
		  undefined4 uVar8;
		  
		  if (DAT_ram_00a59918 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Utils_Accumulators_AccumulatorBase_int__TriggerValue__remove_UpdateEvent__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Utils_Accumulators_AccumulatorBase_AccumulatorUpdateDelegate_int__TriggerValue__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_AprDicWrapper__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Cache_ICache_ulong__UserData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&ulong___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_UserInfo_Control_UserInfoController_HandleEquipChangedEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_UserInfo_Control_UserInfoController_HandleOnUserNickChangedEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_UserInfo_Control_UserInfoController_HandleUserTriggersUpdateEvent__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_UserInfo_Control_UserInfoController_UserOnOnUserAprChangedEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_UserInfo_Control_UserInfoController_UserOnUserSkillsChangedEvent__);
		    DAT_ram_00a59918 = '\x01';
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  iVar6 = *(int *)(*(int *)(iVar2 + 0xc) + 8);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  if (iVar6 != *(int *)(iVar2 + 8)) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    uVar1 = 0;
		    piVar7 = *(int **)(iVar2 + 0x28);
		    iVar2 = *piVar7;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x158);
		          goto code_r0x8109032c;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar7,Core_Gameplay_IGame_TypeInfo,0x13);
		code_r0x8109032c:
		    iVar2 = (**(code **)((ulonglong)*puVar3 * 4))(piVar7,puVar3[1]);
		    piVar7 = *(int **)(iVar2 + 0x18);
		    uVar1 = 0;
		    iVar2 = Mono_Security_ASN1Convert__ToOid(ulong___TypeInfo,1);
		    iVar6 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    uVar5 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext
		                      (*(undefined4 *)(iVar6 + 8),0);
		    *(undefined8 *)(iVar2 + 0x10) = uVar5;
		    iVar6 = *piVar7;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      do {
		        if (Core_Cache_ICache_ulong__UserData__TypeInfo ==
		            *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0xd0);
		          goto code_r0x810903e4;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar7,Core_Cache_ICache_ulong__UserData__TypeInfo,2);
		code_r0x810903e4:
		    (**(code **)((ulonglong)*puVar3 * 4))(piVar7,iVar2,puVar3[1]);
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar1 = 0;
		  piVar7 = *(int **)(iVar2 + 0x28);
		  iVar2 = *piVar7;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x120);
		        goto code_r0x8109047d;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar7,Core_Gameplay_IGame_TypeInfo,0xc);
		code_r0x8109047d:
		  iVar2 = (**(code **)((ulonglong)*puVar3 * 4))(piVar7,puVar3[1]);
		  iVar6 = *(int *)(iVar2 + 0x20);
		  uVar8 = *(undefined4 *)(iVar6 + 0x18);
		  uVar4 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar4,param1,
		             Method_Gameplay_UserInfo_Control_UserInfoController_HandleEquipChangedEvent__,0);
		  piVar7 = (int *)func_ii_7048(uVar8,uVar4,0);
		  iVar2 = System_Action_TypeInfo;
		  if (piVar7 == (int *)0x0) {
		    *(undefined4 *)(iVar6 + 0x18) = 0;
		  }
		  else if ((System_Action_TypeInfo != *piVar7) ||
		          (*(int **)(iVar6 + 0x18) = piVar7, *piVar7 != iVar2)) {
		    System_Activator__CreateInstance(piVar7,iVar2);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar8 = *(undefined4 *)(iVar2 + 8);
		  uVar4 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar4,param1,
		             Method_Gameplay_UserInfo_Control_UserInfoController_HandleOnUserNickChangedEvent__,0);
		  Core_Data_UserData__add_OnUserNickChangedEvent(uVar8,uVar4,0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar8 = *(undefined4 *)(iVar2 + 8);
		  uVar4 = unnamed_function_1417(System_Action_AprDicWrapper__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar4,param1,
		             Method_Gameplay_UserInfo_Control_UserInfoController_UserOnOnUserAprChangedEvent__,0);
		  Core_Data_UserData__add_OnUserAprChangedEvent(uVar8,uVar4,0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar8 = *(undefined4 *)(iVar2 + 8);
		  uVar4 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar4,param1,
		             Method_Gameplay_UserInfo_Control_UserInfoController_UserOnUserSkillsChangedEvent__,0);
		  Core_Data_UserData__add_UserSkillsChangedEvent(uVar8,uVar4,0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar4 = Core_Gameplay_Managers_UserManager__get_User(*(undefined4 *)(iVar2 + 8),0);
		  uVar8 = unnamed_function_1417
		                    (
		                    Utils_Accumulators_AccumulatorBase_AccumulatorUpdateDelegate_int__TriggerValue__TypeInfo
		                    );
		  Utils_Accumulators_AccumulatorBase___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType___remove_UpdateEvent
		            (uVar8,param1,
		             Method_Gameplay_UserInfo_Control_UserInfoController_HandleUserTriggersUpdateEvent__,0);
		  UnityEngine_Events_InvokableCall_InputAction_CallbackContext___add_Delegate
		            (uVar4,uVar8,
		             Method_Utils_Accumulators_AccumulatorBase_int__TriggerValue__remove_UpdateEvent__);
		  return;
		}
		*/

		}

		// Token: 0x06001897 RID: 6295 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001897")]
		[Address(RVA = "0x6A36", Offset = "0x6A36", VA = "0x6A36", Slot = "6")]
		protected override void HandleStop()
		{
		/* --- GHIDRA: HandleStop ---
		void Gameplay_UserInfo_Control_UserInfoController__HandleStop
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int *piVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a59919 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_Auth2Service___);
		    Mono_Security_ASN1__get_Item(&Core_Net_ServiceFactory_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_UserInfo_Control_UserInfoController_HandleGetPossibleNicksService__)
		    ;
		    DAT_ram_00a59919 = '\x01';
		  }
		  if (*(int *)(Core_Net_ServiceFactory_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_ServiceFactory_TypeInfo);
		  }
		  uVar1 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                    (Method_Core_Net_ServiceFactory_GetService_Auth2Service___);
		  if (DAT_ram_00a63c4b == '\0') {
		    Mono_Security_ASN1__get_Item(&Localization_Culture_Culture_TypeInfo);
		    DAT_ram_00a63c4b = '\x01';
		  }
		  piVar2 = (int *)Gameplay_FeedbackForm_Model_Controll_FeedbackFormController__GetBase64ZipContent
		                            (*(undefined4 *)
		                              (*(int *)(Localization_Culture_Culture_TypeInfo + 0x5c) + 4),0);
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*piVar2 + 0xf8) * 4))
		                    (piVar2,*(undefined4 *)(*piVar2 + 0xfc));
		  uVar1 = ServicesNamespace_Auth2Service__ServerEventHandler(uVar1,param2,uVar3,0);
		  uVar3 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar3,param1,
		             Method_Gameplay_UserInfo_Control_UserInfoController_HandleGetPossibleNicksService__,0);
		  ServicesNamespace_MainService__GetUserStats
		            (uVar1,uVar3,param2,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  return;
		}
		*/

		}

		// Token: 0x06001898 RID: 6296 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001898")]
		[Address(RVA = "0x6A37", Offset = "0x6A37", VA = "0x6A37")]
		private void RequestGetPossibleNicks(string nick)
		{
		/* --- GHIDRA: RequestGetPossibleNicks ---
		void Gameplay_UserInfo_Control_UserInfoController__RequestGetPossibleNicks
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  int iVar3;
		  undefined4 uVar4;
		  int *param1_00;
		  int *piVar5;
		  
		  if (DAT_ram_00a5991a == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Auth2_GetPossibleNicksCmd_Types_Ans_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_string__get_Item__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5);
		    DAT_ram_00a5991a = '\x01';
		  }
		  param1_00 = *(int **)(param2 + 0x20);
		  if ((param1_00 != (int *)0x0) &&
		     (Protocol_Auth2_GetPossibleNicksCmd_Types_Ans_TypeInfo != *param1_00)) {
		    System_Activator__CreateInstance
		              (param1_00,Protocol_Auth2_GetPossibleNicksCmd_Types_Ans_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar1 = 0;
		  piVar5 = *(int **)(param2 + 0xc);
		  if (piVar5 != (int *)0x0) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*piVar5 + 0xd8) * 4))
		                      (piVar5,*(undefined4 *)(*piVar5 + 0xdc));
		  }
		  if (iVar1 == 0) {
		    iVar1 = StringLiteral_5;
		  }
		  iVar2 = func_ii_4769(iVar1,0);
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  if (iVar2 != 0) {
		    iVar1 = *(int *)(iVar3 + 0x34);
		    uVar4 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                      (param1_00[3],0,
		                       Method_Google_Protobuf_Collections_RepeatedField_string__get_Item__);
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),uVar4,*(undefined4 *)(iVar1 + 0x14));
		    return;
		  }
		  iVar2 = *(int *)(iVar3 + 0x38);
		  (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		            (*(undefined4 *)(iVar2 + 0x20),iVar1,param1_00[3],*(undefined4 *)(iVar2 + 0x14));
		  return;
		}
		*/

		}

		// Token: 0x06001899 RID: 6297 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001899")]
		[Address(RVA = "0x6A38", Offset = "0x6A38", VA = "0x6A38")]
		private void HandleGetPossibleNicksService(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: HandleGetPossibleNicksService ---
		void Gameplay_UserInfo_Control_UserInfoController__HandleGetPossibleNicksService
		               (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5991b == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_UserInfo_Control_UserInfoController_HandleGetNickPriceService__);
		    DAT_ram_00a5991b = '\x01';
		  }
		  uVar1 = ServicesNamespace_ServicesService__GetEndlessPaymentOptions
		                    (*(undefined4 *)(param1 + 0x1c),0);
		  param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_UserInfo_Control_UserInfoController_HandleGetNickPriceService__,0);
		  uVar1 = ServicesNamespace_MainService__GetUserStats
		                    (uVar1,param1_00,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  Utils_OpToken_int__object___AddHandlers(param1,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x0600189A RID: 6298 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600189A")]
		[Address(RVA = "0x6A39", Offset = "0x6A39", VA = "0x6A39")]
		public void RequestNickChangePrice()
		{
		/* --- GHIDRA: RequestNickChangePrice ---
		void Gameplay_UserInfo_Control_UserInfoController__RequestNickChangePrice
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5991c == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_UserInfo_Control_UserInfoController_HandleChangeNickService__);
		    DAT_ram_00a5991c = '\x01';
		  }
		  uVar1 = ServicesNamespace_ServicesService__BuyNextLevel
		                    (*(undefined4 *)(param1 + 0x1c),param2,param3,0);
		  param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_UserInfo_Control_UserInfoController_HandleChangeNickService__,0);
		  uVar1 = ServicesNamespace_MainService__GetUserStats
		                    (uVar1,param1_00,param2,
		                     Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  Utils_OpToken_int__object___AddHandlers(param1,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x0600189B RID: 6299 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600189B")]
		[Address(RVA = "0x6A3A", Offset = "0x6A3A", VA = "0x6A3A")]
		private void RequestChangesNick(string nick, bool check)
		{
		/* --- GHIDRA: RequestChangesNick ---
		void Gameplay_UserInfo_Control_UserInfoController__RequestChangesNick
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  undefined4 param3_00;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a5991d == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_UserInfo_Control_UserInfoController_HandleChangeAprService__);
		    DAT_ram_00a5991d = '\x01';
		  }
		  uVar1 = ServicesNamespace_ServicesService__ChangeNick
		                    (*(undefined4 *)(param1 + 0x1c),param2,param3,0);
		  param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_UserInfo_Control_UserInfoController_HandleChangeAprService__,0);
		  local_4 = param2;
		  param3_00 = func_ii_1081(DAT_ram_00a66958,&local_4);
		  uVar1 = ServicesNamespace_MainService__GetUserStats
		                    (uVar1,param1_00,param3_00,
		                     Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  Utils_OpToken_int__object___AddHandlers(param1,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x0600189C RID: 6300 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600189C")]
		[Address(RVA = "0x6A3B", Offset = "0x6A3B", VA = "0x6A3B")]
		private void RequestChangeApr(uint aprId, bool check)
		{
		/* --- GHIDRA: RequestChangeApr ---
		void Gameplay_UserInfo_Control_UserInfoController__RequestChangeApr
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  undefined8 param2_00;
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5991e == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_UserInfo_Control_UserInfoController_HandleGetUserArtifactsService__)
		    ;
		    DAT_ram_00a5991e = '\x01';
		  }
		  uVar1 = *(undefined4 *)(param1 + 0x18);
		  param2_00 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext(param2,0);
		  uVar1 = ServicesNamespace_MainService__GetClientState(uVar1,param2_00,0);
		  param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_UserInfo_Control_UserInfoController_HandleGetUserArtifactsService__,0);
		  uVar1 = ServicesNamespace_MainService__GetUserStats
		                    (uVar1,param1_00,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  Utils_OpToken_int__object___AddHandlers(param1,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x0600189D RID: 6301 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600189D")]
		[Address(RVA = "0x6A3C", Offset = "0x6A3C", VA = "0x6A3C")]
		private void RequestUserArtifacts(UserData user)
		{
		/* --- GHIDRA: RequestUserArtifacts ---
		void Gameplay_UserInfo_Control_UserInfoController__RequestUserArtifacts
		               (int *param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int iVar2;
		  int iVar3;
		  uint *puVar4;
		  undefined4 param3_00;
		  undefined4 uVar5;
		  undefined4 param5;
		  undefined4 param6;
		  undefined4 param1_00;
		  int *param1_01;
		  int *piVar6;
		  undefined4 param7;
		  
		  if (DAT_ram_00a5991f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Inventory_Model_InventoryModel_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Main_ProtoGetUserArtifactsAns_TypeInfo);
		    DAT_ram_00a5991f = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  param1_01 = *(int **)(param2 + 0x20);
		  if ((param1_01 != (int *)0x0) && (Protocol_Main_ProtoGetUserArtifactsAns_TypeInfo != *param1_01))
		  {
		    System_Activator__CreateInstance(param1_01,Protocol_Main_ProtoGetUserArtifactsAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar1 = 0;
		  piVar6 = *(int **)(iVar3 + 0x28);
		  iVar3 = *piVar6;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0xe0);
		        goto code_r0x81090ab4;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x81090ab4:
		  piVar6 = (int *)(**(code **)((ulonglong)*puVar4 * 4))(piVar6,puVar4[1]);
		  uVar1 = 0;
		  iVar3 = *piVar6;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0xf0);
		        goto code_r0x81090b36;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar6,Core_Application_IApp_TypeInfo,6);
		code_r0x81090b36:
		  param3_00 = (**(code **)((ulonglong)*puVar4 * 4))(piVar6,puVar4[1]);
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar1 = 0;
		  piVar6 = *(int **)(iVar3 + 0x28);
		  iVar3 = *piVar6;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x158);
		        goto code_r0x81090bcf;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x13);
		code_r0x81090bcf:
		  uVar1 = 0;
		  uVar5 = (**(code **)((ulonglong)*puVar4 * 4))(piVar6,puVar4[1]);
		  uVar5 = Core_Gameplay_Managers_CacheManager__GetEndOfFrameCacheRequestAccumulator(uVar5,0);
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  piVar6 = *(int **)(iVar3 + 0x28);
		  iVar3 = *piVar6;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x160);
		        goto code_r0x81090c72;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x14);
		code_r0x81090c72:
		  param5 = (**(code **)((ulonglong)*puVar4 * 4))(piVar6,puVar4[1]);
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar1 = 0;
		  piVar6 = *(int **)(iVar3 + 0x28);
		  iVar3 = *piVar6;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x178);
		        goto code_r0x81090d0f;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x81090d0f:
		  param6 = (**(code **)((ulonglong)*puVar4 * 4))(piVar6,puVar4[1]);
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  param7 = *(undefined4 *)(iVar3 + 8);
		  param1_00 = unnamed_function_1417(Gameplay_Inventory_Model_InventoryModel_TypeInfo);
		  Gameplay_Inventory_Model_InventoryMetaFilterData___ctor
		            (param1_00,2,param3_00,uVar5,param5,param6,param7,0);
		  *(undefined4 *)(iVar2 + 0x14) = param1_00;
		  iVar3 = *param1;
		  iVar2 = (**(code **)((ulonglong)*(uint *)(iVar3 + 0x100) * 4))
		                    (param1,*(undefined4 *)(iVar3 + 0x104));
		  Gameplay_Inventory_Model_InventoryBaseModel__SetArtifact
		            (*(undefined4 *)(iVar2 + 0x14),param1_01[4],0);
		  Gameplay_UserInfo_Control_UserInfoController__HandleGetUserArtifactsService(param1,iVar3);
		  return;
		}
		*/

		}

		// Token: 0x0600189E RID: 6302 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600189E")]
		[Address(RVA = "0x6A3D", Offset = "0x6A3D", VA = "0x6A3D")]
		private void HandleGetUserArtifactsService(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: HandleGetUserArtifactsService ---
		void Gameplay_UserInfo_Control_UserInfoController__HandleGetUserArtifactsService
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 param2_00;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  *(undefined4 *)(iVar1 + 0x10) = *(undefined4 *)(*(int *)(iVar2 + 8) + 0x44);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  param2_00 = Gameplay_UserInfo_Model_UserInfoModel__get_ExperienceProgress
		                        (*(undefined4 *)(*(int *)(iVar1 + 0x10) + 0x18),param1);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  Core_Data_Skills_SkillCollection__Clone(*(undefined4 *)(iVar1 + 0x1c),param2_00,0);
		  if (*(char *)((int)param1 + 9) == '\0') {
		    Gameplay_UserInfo_Control_UserInfoController__HandleUserTriggersUpdateEvent(param1,param1);
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(iVar1 + 0x18);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		            (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  return;
		}
		*/

		}

		// Token: 0x0600189F RID: 6303 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600189F")]
		[Address(RVA = "0x6A3E", Offset = "0x6A3E", VA = "0x6A3E")]
		private void ValidateUserSkills()
		{
		/* --- GHIDRA: ValidateUserSkills ---
		void Gameplay_UserInfo_Control_UserInfoController__ValidateUserSkills
		               (int *param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int iVar2;
		  undefined4 *puVar3;
		  uint *puVar4;
		  int iVar5;
		  undefined4 uVar6;
		  int *piVar7;
		  undefined4 uVar8;
		  
		  if (DAT_ram_00a59920 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Dict_DictWrappers_Base_AbstractDictWrapperStorage_AprDicWrapper__uint__GetWrapper__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_AprDic__uint__get_Data__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedChangeAprErrors__ExpectedBillingErrors___
		              );
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Services_ProtoChangeAprAns_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4160);
		    DAT_ram_00a59920 = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  piVar7 = *(int **)(param2 + 0x20);
		  if ((piVar7 != (int *)0x0) && (Protocol_Services_ProtoChangeAprAns_TypeInfo != *piVar7)) {
		    System_Activator__CreateInstance(piVar7,Protocol_Services_ProtoChangeAprAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar2 = Core_Errors_Expected_ExpectedErrorsHandler__HandleErrorChain_object_
		                    (piVar7[3],piVar7,0,
		                     Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedChangeAprErrors__ExpectedBillingErrors___
		                    );
		  if (iVar2 == 0) {
		    piVar7 = *(int **)(param2 + 0xc);
		    if (piVar7 == (int *)0x0) {
		      System_Collections_Generic_Comparer_ValueTuple_int__Int32Enum__object____get_Default();
		      do {
		        halt_trap();
		      } while( true );
		    }
		    if (*(int *)(*piVar7 + 0x20) != *(int *)(DAT_ram_00a66958 + 0x20)) {
		      System_Activator__CreateInstance(piVar7,DAT_ram_00a66958);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    puVar3 = (undefined4 *)func_ii_15774(piVar7);
		    uVar8 = *puVar3;
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    uVar1 = 0;
		    piVar7 = *(int **)(iVar2 + 0x28);
		    iVar2 = *piVar7;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		          puVar4 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x178);
		          goto code_r0x81090ef7;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    puVar4 = (uint *)func_ii_1080(piVar7,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x81090ef7:
		    uVar1 = 0;
		    iVar2 = (**(code **)((ulonglong)*puVar4 * 4))(piVar7,puVar4[1]);
		    iVar2 = func_ii_7730(*(undefined4 *)(*(int *)(iVar2 + 0x24) + 0x14),uVar8,
		                         Method_Core_Dict_DictWrappers_Base_AbstractDictWrapperStorage_AprDicWrapper__uint__GetWrapper__
		                        );
		    iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    uVar8 = *(undefined4 *)(iVar5 + 8);
		    iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    piVar7 = *(int **)(iVar5 + 0x28);
		    iVar5 = *piVar7;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		          puVar4 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x178);
		          goto code_r0x81090fc3;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    puVar4 = (uint *)func_ii_1080(piVar7,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x81090fc3:
		    uVar6 = (**(code **)((ulonglong)*puVar4 * 4))(piVar7,puVar4[1]);
		    uVar6 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar6,0);
		    uVar6 = Core_Extensions_Dict_DictExt__GetAllArtikulTypeMetaFilterByType
		                      (uVar6,*(undefined4 *)(*(int *)(iVar2 + 0x10) + 0x14),0);
		    Core_Data_UserData__get_UserInfo(uVar8,uVar6,0);
		    iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    Core_Data_UserData__get_Apr(*(undefined4 *)(iVar5 + 8),iVar2,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    if (*(int *)(*(int *)(*(int *)(*(int *)(iVar2 + 8) + 0x38) + 0x10) + 0x10) != 0) {
		      iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		      uVar8 = *(undefined4 *)(iVar2 + 8);
		      iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		      Core_Data_UserData__get_CultDic
		                (uVar8,*(undefined4 *)(*(int *)(*(int *)(*(int *)(iVar2 + 8) + 0x38) + 0x10) + 0x10)
		                 ,0);
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar2 = *(int *)(iVar2 + 0x28);
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		              (*(undefined4 *)(iVar2 + 0x20),*(undefined4 *)(iVar2 + 0x14));
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    piVar7 = *(int **)(iVar2 + 0x28);
		    iVar2 = *piVar7;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		          puVar4 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0xe0);
		          goto code_r0x8109112c;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    puVar4 = (uint *)func_ii_1080(piVar7,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x8109112c:
		    piVar7 = (int *)(**(code **)((ulonglong)*puVar4 * 4))(piVar7,puVar4[1]);
		    uVar1 = 0;
		    iVar2 = *piVar7;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      do {
		        if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		          puVar4 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0xf0);
		          goto code_r0x810911ae;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    puVar4 = (uint *)func_ii_1080(piVar7,Core_Application_IApp_TypeInfo,6);
		code_r0x810911ae:
		    uVar8 = (**(code **)((ulonglong)*puVar4 * 4))(piVar7,puVar4[1]);
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar6 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4160,1,0,1,0,0,0,0);
		    Core_Application_App__get_ToastController(uVar8,1,uVar6,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x060018A0 RID: 6304 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018A0")]
		[Address(RVA = "0x6A3F", Offset = "0x6A3F", VA = "0x6A3F")]
		private void HandleChangeAprService(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: HandleChangeAprService ---
		void Gameplay_UserInfo_Control_UserInfoController__HandleChangeAprService
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int *param1_00;
		  int iVar2;
		  
		  if (DAT_ram_00a59921 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Services_ProtoGetNickPriceAns_TypeInfo);
		    DAT_ram_00a59921 = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  param1_00 = *(int **)(param2 + 0x20);
		  if ((param1_00 != (int *)0x0) && (Protocol_Services_ProtoGetNickPriceAns_TypeInfo != *param1_00))
		  {
		    System_Activator__CreateInstance(param1_00,Protocol_Services_ProtoGetNickPriceAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar2 = param1_00[3];
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  *(int *)(iVar1 + 0x30) = iVar2;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(iVar1 + 0x2c);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x060018A1 RID: 6305 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018A1")]
		[Address(RVA = "0x6A40", Offset = "0x6A40", VA = "0x6A40")]
		private void HandleGetNickPriceService(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: HandleGetNickPriceService ---
		void Gameplay_UserInfo_Control_UserInfoController__HandleGetNickPriceService
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int param2_00;
		  undefined4 uVar2;
		  int iVar3;
		  undefined4 param3_00;
		  int *param1_00;
		  int *piVar4;
		  int param1_01;
		  
		  if (DAT_ram_00a59922 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_string__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedChangeNickErrors__ExpectedBillingErrors___
		              );
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Services_ProtoChangeNickAns_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Core_Errors_Expected_ExpectedChangeNickErrors_SuggestNickVariants_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_UserInfo_Control_UserInfoController_RequestGetPossibleNicks__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4162);
		    DAT_ram_00a59922 = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  param1_00 = *(int **)(param2 + 0x20);
		  if ((param1_00 != (int *)0x0) && (Protocol_Services_ProtoChangeNickAns_TypeInfo != *param1_00)) {
		    System_Activator__CreateInstance(param1_00,Protocol_Services_ProtoChangeNickAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar1 = 0;
		  piVar4 = *(int **)(param2 + 0xc);
		  if (piVar4 != (int *)0x0) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*piVar4 + 0xd8) * 4))
		                      (piVar4,*(undefined4 *)(*piVar4 + 0xdc));
		  }
		  iVar3 = StringLiteral_5;
		  param1_01 = param1_00[3];
		  param2_00 = unnamed_function_1417
		                        (Core_Errors_Expected_ExpectedChangeNickErrors_SuggestNickVariants_TypeInfo)
		  ;
		  if (iVar1 == 0) {
		    iVar1 = iVar3;
		  }
		  *(int *)(param2_00 + 8) = iVar1;
		  uVar2 = unnamed_function_1417(System_Action_string__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Gameplay_UserInfo_Control_UserInfoController_RequestGetPossibleNicks__,0);
		  *(undefined4 *)(param2_00 + 0xc) = uVar2;
		  iVar3 = Core_Errors_Expected_ExpectedErrorsHandler__HandleErrorChain_object_
		                    (param1_01,param2_00,0,
		                     Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedChangeNickErrors__ExpectedBillingErrors___
		                    );
		  if (iVar3 == 0) {
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    Core_Data_UserData__get_IsClanHead(*(undefined4 *)(iVar3 + 8),iVar1,0);
		    uVar2 = System_Uri___ctor(0);
		    uVar2 = System_Globalization_TimeSpanFormat_FormatLiterals__get_DayHourSep(uVar2,0);
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    param3_00 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4162,1,0,1,0,0,0,0);
		    Core_Application_App__get_ToastController(uVar2,1,param3_00,0);
		    iVar3 = param1_00[4];
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    *(int *)(iVar1 + 0x30) = iVar3;
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar1 = *(int *)(iVar1 + 0x2c);
		    if (iVar1 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x060018A2 RID: 6306 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018A2")]
		[Address(RVA = "0x6A41", Offset = "0x6A41", VA = "0x6A41")]
		private void HandleChangeNickService(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: HandleChangeNickService ---
		void Gameplay_UserInfo_Control_UserInfoController__HandleChangeNickService
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  *(undefined4 *)(iVar1 + 0x30) = param2;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(iVar1 + 0x2c);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x060018A3 RID: 6307 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018A3")]
		[Address(RVA = "0x6A42", Offset = "0x6A42", VA = "0x6A42")]
		private void SetupPriceOfChangeNick(ResourceSet price)
		{
		/* --- GHIDRA: SetupPriceOfChangeNick ---
		void Gameplay_UserInfo_Control_UserInfoController__SetupPriceOfChangeNick
		               (undefined4 param1,undefined4 param2)
		
		{
		  Gameplay_UserInfo_Control_UserInfoController__HandleGetUserArtifactsService(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x060018A4 RID: 6308 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018A4")]
		[Address(RVA = "0x6A43", Offset = "0x6A43", VA = "0x6A43")]
		private void UserOnUserSkillsChangedEvent()
		{
		/* --- GHIDRA: UserOnUserSkillsChangedEvent ---
		void Gameplay_UserInfo_Control_UserInfoController__UserOnUserSkillsChangedEvent
		               (int *param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  int iVar1;
		  int iVar2;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(iVar1 + 0x3c);
		  if (iVar1 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar2 + 8),
		               *(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x060018A5 RID: 6309 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018A5")]
		[Address(RVA = "0x6A44", Offset = "0x6A44", VA = "0x6A44")]
		private void HandleUserTriggersUpdateEvent(IEnumerable<TriggerValue> changes, AccumulatorBase<int, TriggerValue> accumulator)
		{
		/* --- GHIDRA: HandleUserTriggersUpdateEvent ---
		void Gameplay_UserInfo_Control_UserInfoController__HandleUserTriggersUpdateEvent
		               (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  uint *puVar4;
		  undefined4 uVar5;
		  int *piVar6;
		  int iVar7;
		  
		  if (DAT_ram_00a59923 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Utils_Accumulators_AccumulatorBase_int__TriggerValue__add_UpdateEvent__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Utils_Accumulators_AccumulatorBase_AccumulatorUpdateDelegate_int__TriggerValue__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_AprDicWrapper__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_UserInfo_Control_UserInfoController_HandleEquipChangedEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_UserInfo_Control_UserInfoController_HandleOnUserNickChangedEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_UserInfo_Control_UserInfoController_HandleUserTriggersUpdateEvent__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_UserInfo_Control_UserInfoController_UserOnOnUserAprChangedEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_UserInfo_Control_UserInfoController_UserOnUserSkillsChangedEvent__);
		    DAT_ram_00a59923 = '\x01';
		  }
		  if (*(char *)((int)param1 + 9) == '\0') {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    uVar5 = *(undefined4 *)(iVar2 + 8);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_UserInfo_Control_UserInfoController_HandleOnUserNickChangedEvent__,0)
		    ;
		    Core_Data_UserData__remove_BalanceChangedEvent(uVar5,uVar3,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    uVar5 = *(undefined4 *)(iVar2 + 8);
		    uVar3 = unnamed_function_1417(System_Action_AprDicWrapper__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar3,param1,
		               Method_Gameplay_UserInfo_Control_UserInfoController_UserOnOnUserAprChangedEvent__,0);
		    Core_Data_UserData__remove_OnUserLevelChangedEvent(uVar5,uVar3,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    uVar5 = *(undefined4 *)(iVar2 + 8);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_UserInfo_Control_UserInfoController_UserOnUserSkillsChangedEvent__,0)
		    ;
		    Core_Data_UserData__remove_OnUserTreeLevelChangedEvent(uVar5,uVar3,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    uVar3 = Core_Gameplay_Managers_UserManager__get_User(*(undefined4 *)(iVar2 + 8),0);
		    uVar5 = unnamed_function_1417
		                      (
		                      Utils_Accumulators_AccumulatorBase_AccumulatorUpdateDelegate_int__TriggerValue__TypeInfo
		                      );
		    Utils_Accumulators_AccumulatorBase___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType___remove_UpdateEvent
		              (uVar5,param1,
		               Method_Gameplay_UserInfo_Control_UserInfoController_HandleUserTriggersUpdateEvent__,0
		              );
		    UnityEngine_Events_InvokableCall_InputAction_CallbackContext___Invoke
		              (uVar3,uVar5,
		               Method_Utils_Accumulators_AccumulatorBase_int__TriggerValue__add_UpdateEvent__);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    if (*(int *)(iVar2 + 8) == *(int *)(*(int *)(iVar2 + 0xc) + 8)) {
		      iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		      piVar6 = *(int **)(iVar2 + 0x28);
		      iVar2 = *piVar6;
		      if (*(ushort *)(iVar2 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		            puVar4 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x120);
		            goto code_r0x8109013c;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		      }
		      puVar4 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0xc);
		code_r0x8109013c:
		      iVar2 = (**(code **)((ulonglong)*puVar4 * 4))(piVar6,puVar4[1]);
		      iVar7 = *(int *)(iVar2 + 0x20);
		      uVar5 = *(undefined4 *)(iVar7 + 0x18);
		      uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		      UnityEngine_Events_UnityEvent__AddListener
		                (uVar3,param1,
		                 Method_Gameplay_UserInfo_Control_UserInfoController_HandleEquipChangedEvent__,0);
		      piVar6 = (int *)UnityEngine_UI_Image__set_sprite(uVar5,uVar3,0);
		      iVar2 = System_Action_TypeInfo;
		      if (piVar6 == (int *)0x0) {
		        *(undefined4 *)(iVar7 + 0x18) = 0;
		      }
		      else if ((System_Action_TypeInfo != *piVar6) ||
		              (*(int **)(iVar7 + 0x18) = piVar6, *piVar6 != iVar2)) {
		        System_Activator__CreateInstance(piVar6,iVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    *(undefined1 *)((int)param1 + 9) = 1;
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar2 = *(int *)(iVar2 + 8);
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		              (*(undefined4 *)(iVar2 + 0x20),*(undefined4 *)(iVar2 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x060018A6 RID: 6310 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018A6")]
		[Address(RVA = "0x6A45", Offset = "0x6A45", VA = "0x6A45")]
		private void ValidateInit()
		{
		/* --- GHIDRA: ValidateInit ---
		void Gameplay_UserInfo_Control_UserInfoController__ValidateInit(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(iVar1 + 0x20);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		            (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  return;
		}
		*/

		}

		// Token: 0x060018A7 RID: 6311 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018A7")]
		[Address(RVA = "0x6A46", Offset = "0x6A46", VA = "0x6A46")]
		private void HandleOnUserNickChangedEvent()
		{
		/* --- GHIDRA: HandleOnUserNickChangedEvent ---
		void Gameplay_UserInfo_Control_UserInfoController__HandleOnUserNickChangedEvent
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(iVar1 + 0x24);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		            (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  return;
		}
		*/

		}

		// Token: 0x060018A8 RID: 6312 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018A8")]
		[Address(RVA = "0x6A47", Offset = "0x6A47", VA = "0x6A47")]
		private void UserOnOnUserAprChangedEvent(AprDicWrapper apr)
		{
		/* --- GHIDRA: UserOnOnUserAprChangedEvent ---
		void Gameplay_UserInfo_Control_UserInfoController__UserOnOnUserAprChangedEvent
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(iVar1 + 0x1c);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		            (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  return;
		}
		*/

		}

		// Token: 0x060018A9 RID: 6313 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018A9")]
		[Address(RVA = "0x6A48", Offset = "0x6A48", VA = "0x6A48")]
		private void HandleEquipChangedEvent()
		{
		/* --- GHIDRA: HandleEquipChangedEvent ---
		void Gameplay_UserInfo_Control_UserInfoController__HandleEquipChangedEvent
		               (int param1,undefined8 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a59924 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_First_UserData___);
		    DAT_ram_00a59924 = '\x01';
		  }
		  if (*(char *)(param1 + 8) != '\0') {
		    param2_00 = System_Linq_Enumerable__Count_object_
		                          (param3,Method_System_Linq_Enumerable_First_UserData___);
		    Gameplay_UserInfo_Control_UserInfoController__RequestChangeApr(param1,param2_00,param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x060018AA RID: 6314 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018AA")]
		[Address(RVA = "0x6A49", Offset = "0x6A49", VA = "0x6A49")]
		private void UserCacheResultCallback(long operationIndex, UserData[] data)
		{
		/* --- GHIDRA: UserCacheResultCallback ---
		void Gameplay_UserInfo_Control_UserInfoController__UserCacheResultCallback
		               (int *param1,undefined8 param2,undefined4 param3,undefined4 param4)
		
		{
		  int iVar1;
		  
		  if ((char)param1[2] != '\0') {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar1 = *(int *)(iVar1 + 0x14);
		    if (iVar1 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x060018AB RID: 6315 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018AB")]
		[Address(RVA = "0x6A4A", Offset = "0x6A4A", VA = "0x6A4A")]
		private void UserBasicCacheResultCallback(long operationIndex, UserData[] data)
		{
		/* --- GHIDRA: UserBasicCacheResultCallback ---
		void Gameplay_UserInfo_Control_UserInfoController__UserBasicCacheResultCallback
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a59925 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_AprDic__uint__get_Data__);
		    DAT_ram_00a59925 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  if (param2 != *(int *)(*(int *)(iVar1 + 8) + 0x38)) {
		    Gameplay_UserInfo_Control_UserInfoController__RequestChangesNick
		              (param1,*(undefined4 *)(*(int *)(param2 + 0x10) + 0xc),0,param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x060018AC RID: 6316 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018AC")]
		[Address(RVA = "0x6A4B", Offset = "0x6A4B", VA = "0x6A4B")]
		public void ChangeCult(AprDicWrapper apr)
		{
		/* --- GHIDRA: ChangeCult ---
		void Gameplay_UserInfo_Control_UserInfoController__ChangeCult
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 param2_00;
		  
		  iVar1 = Newtonsoft_Json_Serialization_JsonSerializerInternalReader__ShouldDeserialize(param2,0);
		  if (iVar1 == 0) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    param2_00 = Google_Protobuf_Collections_RepeatedField_object___GetEnumerator
		                          (*(undefined4 *)(iVar1 + 8),0);
		    iVar1 = Mono_Security_X509_X509CertificateCollection_X509CertificateEnumerator__get_Current
		                      (param2,param2_00,0);
		    if (iVar1 != 0) {
		      Gameplay_UserInfo_Control_UserInfoController__RequestNickChangePrice(param1,param2,0,param2);
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x060018AD RID: 6317 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018AD")]
		[Address(RVA = "0x6A4C", Offset = "0x6A4C", VA = "0x6A4C")]
		public void ChangeNick(string nick)
		{
		/* --- GHIDRA: ChangeNick ---
		void Gameplay_UserInfo_Control_UserInfoController__ChangeNick(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a59926 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_5);
		    DAT_ram_00a59926 = '\x01';
		  }
		  Gameplay_UserInfo_Control_UserInfoController__HandleStop(param1,StringLiteral_5,param1);
		  return;
		}
		*/

		}

		// Token: 0x060018AE RID: 6318 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018AE")]
		[Address(RVA = "0x6A4D", Offset = "0x6A4D", VA = "0x6A4D")]
		public void GenerateNick()
		{
		/* --- GHIDRA: GenerateNick ---
		void Gameplay_UserInfo_Control_UserInfoController__GenerateNick
		               (int *param1,int param2,int param3,undefined4 param4)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  int iVar2;
		  
		  if (DAT_ram_00a59927 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__AprDicWrapper__get_Item__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_Genders__Dictionary_uint__AprDicWrapper___get_Item__
		              );
		    DAT_ram_00a59927 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  param1_00 = GAFInternal_Reader_GAFReader__OpenTag
		                        (*(undefined4 *)(iVar1 + 0x24),*(undefined4 *)(param2 + 0xc),
		                         Method_System_Collections_Generic_Dictionary_Genders__Dictionary_uint__AprDicWrapper___get_Item__
		                        );
		  iVar1 = System_Collections_Generic_List_object___get_Item
		                    (param1_00,*(undefined4 *)(param3 + 0xc),
		                     Method_System_Collections_Generic_Dictionary_uint__AprDicWrapper__get_Item__);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  if (iVar1 != *(int *)(iVar2 + 0x34)) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    *(int *)(iVar2 + 0x34) = iVar1;
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar1 = *(int *)(iVar1 + 0x30);
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x060018AF RID: 6319 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018AF")]
		[Address(RVA = "0x6A4E", Offset = "0x6A4E", VA = "0x6A4E")]
		public void SelectApr(GenderDic genderDic, CultDic cultDic)
		{
		/* --- GHIDRA: SelectApr ---
		void Gameplay_UserInfo_Control_UserInfoController__SelectApr(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  *(undefined4 *)(iVar1 + 0x34) = 0;
		  return;
		}
		*/

		}

		// Token: 0x060018B0 RID: 6320 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018B0")]
		[Address(RVA = "0x6A4F", Offset = "0x6A4F", VA = "0x6A4F")]
		public void DeselectSelectedApr()
		{
		/* --- GHIDRA: DeselectSelectedApr ---
		void Gameplay_UserInfo_Control_UserInfoController__DeselectSelectedApr
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  byte bVar1;
		  int iVar2;
		  int param1_00;
		  
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  *(undefined1 *)(*(int *)(iVar2 + 8) + 0x48) = (undefined1)param2;
		  param1_00 = param1[6];
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  bVar1 = *(byte *)(*(int *)(iVar2 + 8) + 0x48);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  ServicesNamespace_MainService__ChangeFavoriteArtifact
		            (param1_00,(uint)bVar1,(uint)*(byte *)(*(int *)(iVar2 + 8) + 0x49),0);
		  return;
		}
		*/

		}

		// Token: 0x060018B1 RID: 6321 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018B1")]
		[Address(RVA = "0x6A50", Offset = "0x6A50", VA = "0x6A50")]
		public void SetMedalsVisible(bool value)
		{
		/* --- GHIDRA: SetMedalsVisible ---
		void Gameplay_UserInfo_Control_UserInfoController__SetMedalsVisible
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  byte bVar1;
		  int iVar2;
		  int param1_00;
		  
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  *(undefined1 *)(*(int *)(iVar2 + 8) + 0x49) = (undefined1)param2;
		  param1_00 = param1[6];
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  bVar1 = *(byte *)(*(int *)(iVar2 + 8) + 0x48);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  ServicesNamespace_MainService__ChangeFavoriteArtifact
		            (param1_00,(uint)bVar1,(uint)*(byte *)(*(int *)(iVar2 + 8) + 0x49),0);
		  return;
		}
		*/

		}

		// Token: 0x060018B2 RID: 6322 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018B2")]
		[Address(RVA = "0x6A51", Offset = "0x6A51", VA = "0x6A51")]
		public void SetAprsVisible(bool value)
		{
		/* --- GHIDRA: SetAprsVisible ---
		void Gameplay_UserInfo_Control_UserInfoController__SetAprsVisible
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5)
		
		{
		  if (DAT_ram_00a59928 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_UserInfoModel__UserInfoEvents__UserInfoController__CultGenderNickSettingsView___ctor__
		              );
		    DAT_ram_00a59928 = '\x01';
		  }
		  Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		            (param1,param2,param3,param4,
		             Method_MVC_AbstractViewMediator_UserInfoModel__UserInfoEvents__UserInfoController__CultGenderNickSettingsView___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x04000D27 RID: 3367
		[Token(Token = "0x4000D27")]
		[FieldOffset(Offset = "0x18")]
		private readonly MainService _mainService;

		// Token: 0x04000D28 RID: 3368
		[Token(Token = "0x4000D28")]
		[FieldOffset(Offset = "0x1C")]
		private readonly ServicesService _servicesService;
	}
}
