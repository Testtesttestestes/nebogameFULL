using System;
using System.Collections;
using System.Collections.Generic;
using Core.Data;
using Cysharp.Threading.Tasks;
using Gameplay.GameEvents.Model;
using Google.Protobuf;
using Il2CppDummyDll;
using MVC;
using Protocol.Dic;
using Protocol.Events;
using Protocol.Main;
using ServicesNamespace;
using Utils;
using Utils.Timers;

namespace Gameplay.GameEvents.Control
{
	// Token: 0x020007E0 RID: 2016
	[Token(Token = "0x20007E0")]
	public class GameEventsController : AbstractController<GameEventsModel, GameEventsEvents>
	{
		// Token: 0x06002F2A RID: 12074 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F2A")]
		[Address(RVA = "0x7F97", Offset = "0x7F97", VA = "0x7F97", Slot = "5")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Gameplay_GameEvents_Control_GameEventsController__Dispose
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a57514 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_MVC_AbstractController_GameEventsModel__GameEventsEvents___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Utils_Timers_DelayedCall_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GameEvents_Control_GameEventsController_ExpirationSchedulerCallback__
		              );
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_EventsService___);
		    Mono_Security_ASN1__get_Item(&Core_Net_ServiceFactory_TypeInfo);
		    DAT_ram_00a57514 = '\x01';
		  }
		  Gameplay_Combat_AbstractCombat_object__object__object__object__object___set_User
		            (param1,param2,param3,
		             Method_MVC_AbstractController_GameEventsModel__GameEventsEvents___ctor__);
		  if (*(int *)(Core_Net_ServiceFactory_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_ServiceFactory_TypeInfo);
		  }
		  uVar1 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                    (Method_Core_Net_ServiceFactory_GetService_EventsService___);
		  *(undefined4 *)(param1 + 0x18) = uVar1;
		  uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar1,param1,
		             Method_Gameplay_GameEvents_Control_GameEventsController_ExpirationSchedulerCallback__,0
		            );
		  param1_00 = unnamed_function_1417(Utils_Timers_DelayedCall_TypeInfo);
		  Unity_Services_Core_Environments_Internal_Environments__get_Current(param1_00,uVar1,0);
		  *(undefined4 *)(param1 + 0x1c) = param1_00;
		  return;
		}
		*/

		}

		// Token: 0x06002F2B RID: 12075 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F2B")]
		[Address(RVA = "0x7F98", Offset = "0x7F98", VA = "0x7F98")]
		public GameEventsController(GameEventsModel model, GameEventsEvents events)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_GameEvents_Control_GameEventsController___ctor(int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  uint *puVar5;
		  int iVar6;
		  undefined4 uVar7;
		  int *piVar8;
		  
		  if (DAT_ram_00a57515 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoGetEventsListAns__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_DropTypes__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_DropTypes__ArtifactData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GameEvents_Control_GameEventsController_HandleArtifactDropRemoveEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_GameEvents_Control_GameEventsController_HandleDropRemoveEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_GameEvents_Control_GameEventsController_HandleThereIsNewEvent__);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a57515 = '\x01';
		  }
		  iVar6 = param1[6];
		  uVar7 = *(undefined4 *)(iVar6 + 0x14);
		  uVar2 = unnamed_function_1417(System_Action_ProtoGetEventsListAns__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Gameplay_GameEvents_Control_GameEventsController_HandleThereIsNewEvent__,0);
		  iVar3 = UnityEngine_UI_Image__set_sprite(uVar7,uVar2,0);
		  uVar2 = System_Action_ProtoGetEventsListAns__TypeInfo;
		  if (iVar3 == 0) {
		    *(undefined4 *)(iVar6 + 0x14) = 0;
		  }
		  else {
		    iVar4 = func_ii_1082(iVar3,System_Action_ProtoGetEventsListAns__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar3,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar6 + 0x14) = iVar4;
		    uVar2 = System_Action_ProtoGetEventsListAns__TypeInfo;
		    iVar6 = func_ii_1082(iVar3,System_Action_ProtoGetEventsListAns__TypeInfo);
		    if (iVar6 == 0) {
		      System_Activator__CreateInstance(iVar3,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar1 = 0;
		  piVar8 = *(int **)(iVar3 + 0xc);
		  iVar3 = *piVar8;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar5 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x150);
		        goto code_r0x80d9d18e;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar5 = (uint *)func_ii_1080(piVar8,Core_Gameplay_IGame_TypeInfo,0x12);
		code_r0x80d9d18e:
		  iVar3 = (**(code **)((ulonglong)*puVar5 * 4))(piVar8,puVar5[1]);
		  iVar6 = **(int **)(iVar3 + 0x10);
		  iVar3 = (**(code **)((ulonglong)*(uint *)(iVar6 + 0x110) * 4))
		                    (*(int **)(iVar3 + 0x10),*(undefined4 *)(iVar6 + 0x114));
		  uVar7 = *(undefined4 *)(iVar3 + 0x1c);
		  uVar2 = unnamed_function_1417(System_Action_DropTypes__ArtifactData__TypeInfo);
		  System_Action_Int32Enum__Int32Enum___Invoke
		            (uVar2,param1,
		             Method_Gameplay_GameEvents_Control_GameEventsController_HandleArtifactDropRemoveEvent__
		             ,0);
		  iVar6 = UnityEngine_UI_Image__set_sprite(uVar7,uVar2,0);
		  uVar2 = System_Action_DropTypes__ArtifactData__TypeInfo;
		  if (iVar6 == 0) {
		    *(undefined4 *)(iVar3 + 0x1c) = 0;
		  }
		  else {
		    iVar4 = func_ii_1082(iVar6,System_Action_DropTypes__ArtifactData__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar6,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar3 + 0x1c) = iVar4;
		    uVar2 = System_Action_DropTypes__ArtifactData__TypeInfo;
		    iVar3 = func_ii_1082(iVar6,System_Action_DropTypes__ArtifactData__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar6,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar1 = 0;
		  piVar8 = *(int **)(iVar3 + 0xc);
		  iVar3 = *piVar8;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar5 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x150);
		        goto code_r0x80d9d2af;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar5 = (uint *)func_ii_1080(piVar8,Core_Gameplay_IGame_TypeInfo,0x12);
		code_r0x80d9d2af:
		  iVar3 = (**(code **)((ulonglong)*puVar5 * 4))(piVar8,puVar5[1]);
		  iVar6 = **(int **)(iVar3 + 0x10);
		  iVar3 = (**(code **)((ulonglong)*(uint *)(iVar6 + 0x110) * 4))
		                    (*(int **)(iVar3 + 0x10),*(undefined4 *)(iVar6 + 0x114));
		  uVar7 = *(undefined4 *)(iVar3 + 0x18);
		  uVar2 = unnamed_function_1417(System_Action_DropTypes__TypeInfo);
		  System_Action_int___Invoke
		            (uVar2,param1,
		             Method_Gameplay_GameEvents_Control_GameEventsController_HandleDropRemoveEvent__,0);
		  iVar6 = UnityEngine_UI_Image__set_sprite(uVar7,uVar2,0);
		  uVar2 = System_Action_DropTypes__TypeInfo;
		  if (iVar6 == 0) {
		    *(undefined4 *)(iVar3 + 0x18) = 0;
		    Gameplay_GameEvents_Control_GameEventsController__HandleDeleteEventsService(param1,0);
		    return;
		  }
		  iVar4 = func_ii_1082(iVar6,System_Action_DropTypes__TypeInfo);
		  if (iVar4 != 0) {
		    *(int *)(iVar3 + 0x18) = iVar4;
		    uVar2 = System_Action_DropTypes__TypeInfo;
		    iVar3 = func_ii_1082(iVar6,System_Action_DropTypes__TypeInfo);
		    if (iVar3 != 0) {
		      Gameplay_GameEvents_Control_GameEventsController__HandleDeleteEventsService(param1,iVar6);
		      return;
		    }
		    System_Activator__CreateInstance(iVar6,uVar2);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  System_Activator__CreateInstance(iVar6,uVar2);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06002F2C RID: 12076 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F2C")]
		[Address(RVA = "0x7F99", Offset = "0x7F99", VA = "0x7F99", Slot = "7")]
		protected override void HandleRun()
		{
		/* --- GHIDRA: HandleRun ---
		void Gameplay_GameEvents_Control_GameEventsController__HandleRun(int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  uint *puVar5;
		  int iVar6;
		  undefined4 uVar7;
		  int *piVar8;
		  
		  if (DAT_ram_00a57516 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoGetEventsListAns__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_DropTypes__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_DropTypes__ArtifactData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GameEvents_Control_GameEventsController_HandleArtifactDropRemoveEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_GameEvents_Control_GameEventsController_HandleDropRemoveEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_GameEvents_Control_GameEventsController_HandleThereIsNewEvent__);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a57516 = '\x01';
		  }
		  iVar6 = param1[6];
		  uVar7 = *(undefined4 *)(iVar6 + 0x14);
		  uVar2 = unnamed_function_1417(System_Action_ProtoGetEventsListAns__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Gameplay_GameEvents_Control_GameEventsController_HandleThereIsNewEvent__,0);
		  iVar3 = func_ii_7048(uVar7,uVar2,0);
		  uVar2 = System_Action_ProtoGetEventsListAns__TypeInfo;
		  if (iVar3 == 0) {
		    *(undefined4 *)(iVar6 + 0x14) = 0;
		  }
		  else {
		    iVar4 = func_ii_1082(iVar3,System_Action_ProtoGetEventsListAns__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar3,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar6 + 0x14) = iVar4;
		    uVar2 = System_Action_ProtoGetEventsListAns__TypeInfo;
		    iVar6 = func_ii_1082(iVar3,System_Action_ProtoGetEventsListAns__TypeInfo);
		    if (iVar6 == 0) {
		      System_Activator__CreateInstance(iVar3,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar1 = 0;
		  piVar8 = *(int **)(iVar3 + 0xc);
		  iVar3 = *piVar8;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar5 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x150);
		        goto code_r0x80d9d55c;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar5 = (uint *)func_ii_1080(piVar8,Core_Gameplay_IGame_TypeInfo,0x12);
		code_r0x80d9d55c:
		  iVar3 = (**(code **)((ulonglong)*puVar5 * 4))(piVar8,puVar5[1]);
		  iVar6 = **(int **)(iVar3 + 0x10);
		  iVar3 = (**(code **)((ulonglong)*(uint *)(iVar6 + 0x110) * 4))
		                    (*(int **)(iVar3 + 0x10),*(undefined4 *)(iVar6 + 0x114));
		  uVar7 = *(undefined4 *)(iVar3 + 0x1c);
		  uVar2 = unnamed_function_1417(System_Action_DropTypes__ArtifactData__TypeInfo);
		  System_Action_Int32Enum__Int32Enum___Invoke
		            (uVar2,param1,
		             Method_Gameplay_GameEvents_Control_GameEventsController_HandleArtifactDropRemoveEvent__
		             ,0);
		  iVar6 = func_ii_7048(uVar7,uVar2,0);
		  uVar2 = System_Action_DropTypes__ArtifactData__TypeInfo;
		  if (iVar6 == 0) {
		    *(undefined4 *)(iVar3 + 0x1c) = 0;
		  }
		  else {
		    iVar4 = func_ii_1082(iVar6,System_Action_DropTypes__ArtifactData__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar6,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar3 + 0x1c) = iVar4;
		    uVar2 = System_Action_DropTypes__ArtifactData__TypeInfo;
		    iVar3 = func_ii_1082(iVar6,System_Action_DropTypes__ArtifactData__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar6,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar1 = 0;
		  piVar8 = *(int **)(iVar3 + 0xc);
		  iVar3 = *piVar8;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar5 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x150);
		        goto code_r0x80d9d67d;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar5 = (uint *)func_ii_1080(piVar8,Core_Gameplay_IGame_TypeInfo,0x12);
		code_r0x80d9d67d:
		  iVar3 = (**(code **)((ulonglong)*puVar5 * 4))(piVar8,puVar5[1]);
		  iVar6 = **(int **)(iVar3 + 0x10);
		  iVar3 = (**(code **)((ulonglong)*(uint *)(iVar6 + 0x110) * 4))
		                    (*(int **)(iVar3 + 0x10),*(undefined4 *)(iVar6 + 0x114));
		  uVar7 = *(undefined4 *)(iVar3 + 0x18);
		  uVar2 = unnamed_function_1417(System_Action_DropTypes__TypeInfo);
		  System_Action_int___Invoke
		            (uVar2,param1,
		             Method_Gameplay_GameEvents_Control_GameEventsController_HandleDropRemoveEvent__,0);
		  iVar6 = func_ii_7048(uVar7,uVar2,0);
		  uVar2 = System_Action_DropTypes__TypeInfo;
		  if (iVar6 == 0) {
		    *(undefined4 *)(iVar3 + 0x18) = 0;
		  }
		  else {
		    iVar4 = func_ii_1082(iVar6,System_Action_DropTypes__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar6,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar3 + 0x18) = iVar4;
		    uVar2 = System_Action_DropTypes__TypeInfo;
		    iVar3 = func_ii_1082(iVar6,System_Action_DropTypes__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar6,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  Utils_Timers_DelayedCall__SetDelay(param1[7],0);
		  return;
		}
		*/

		}

		// Token: 0x06002F2D RID: 12077 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F2D")]
		[Address(RVA = "0x7F9A", Offset = "0x7F9A", VA = "0x7F9A", Slot = "6")]
		protected override void HandleStop()
		{
		/* --- GHIDRA: HandleStop ---
		void Gameplay_GameEvents_Control_GameEventsController__HandleStop(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  int param2_00;
		  undefined1 auStack_20 [8];
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined4 local_4;
		  
		  local_4 = 0;
		  iVar1 = Gameplay_GameEvents_Control_GameEventsController__SetNotViewedEventCount
		                    (param1,&local_4,auStack_20);
		  if (iVar1 != 0) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar1 = *(int *)(iVar1 + 0x34);
		    if (iVar1 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),local_4,*(undefined4 *)(iVar1 + 0x14));
		    }
		  }
		  param2_00 = param1[7];
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  local_18 = *(undefined8 *)(iVar1 + 0x3c);
		  local_10 = local_18;
		  Gameplay_GameEvents_Control_GameEventsController__TryDeleteExpired
		            (param1,param2_00,&local_18,auStack_20);
		  return;
		}
		*/

		}

		// Token: 0x06002F2E RID: 12078 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F2E")]
		[Address(RVA = "0x7F9B", Offset = "0x7F9B", VA = "0x7F9B")]
		private void ExpirationSchedulerCallback()
		{
		}

		// Token: 0x06002F2F RID: 12079 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F2F")]
		[Address(RVA = "0x7F9C", Offset = "0x7F9C", VA = "0x7F9C")]
		private void ValidateInit()
		{
		}

		// Token: 0x06002F30 RID: 12080 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F30")]
		[Address(RVA = "0x7F9D", Offset = "0x7F9D", VA = "0x7F9D")]
		private void SetEvents(ProtoGetEventsListAns msg)
		{
		/* --- GHIDRA: SetEvents ---
		void Gameplay_GameEvents_Control_GameEventsController__SetEvents
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 in_register_20000014;
		  undefined8 uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int param3_00;
		  int local_4;
		  
		  if (*(int *)(param2 + 0x14) == 0) {
		    uVar1 = CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x104));
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(param1,uVar1);
		    in_register_20000014 = (undefined4)((ulonglong)uVar1 >> 0x20);
		    uVar3 = *(undefined4 *)(*(int *)(param2 + 0x1c) + 0xc);
		    if (DAT_ram_00a574bc == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&
		                 Method_System_Collections_Generic_Dictionary_EventCategoriesDic_Types_Category__int__TryGetValue__
		                );
		      DAT_ram_00a574bc = '\x01';
		    }
		    local_4 = 0;
		    iVar2 = System_Collections_Generic_List_Enumerator_ValueTuple_object__double____MoveNext
		                      (*(undefined4 *)(iVar2 + 0x2c),uVar3,&local_4,
		                       Method_System_Collections_Generic_Dictionary_EventCategoriesDic_Types_Category__int__TryGetValue__
		                      );
		    param3_00 = local_4 + -1;
		    if (iVar2 == 0) {
		      param3_00 = -1;
		    }
		    System_Collections_Generic_Dictionary_Int32Enum__int___TryGetValue
		              (param1,*(undefined4 *)(*(int *)(param2 + 0x1c) + 0xc),param3_00,param1);
		  }
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x104)));
		  Gameplay_GameEvents_Model_GameEventsModel__AddEvent
		            (uVar3,*(undefined8 *)(*(int *)(param2 + 0x24) + 0x10),param1);
		  return;
		}
		*/

		}

		// Token: 0x06002F31 RID: 12081 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F31")]
		[Address(RVA = "0x1AC8", Offset = "0x1AC8", VA = "0x1AC8")]
		private void SetNotViewedEventCount(EventCategoriesDic.Types.Category category, int value)
		{
		/* --- GHIDRA: SetNotViewedEventCount ---
		uint Gameplay_GameEvents_Control_GameEventsController__SetNotViewedEventCount
		               (int *param1,int *param2,undefined4 param3)
		
		{
		  ulonglong uVar1;
		  uint uVar2;
		  int iVar3;
		  uint *puVar4;
		  int iVar5;
		  undefined4 param1_00;
		  int iVar6;
		  int *piVar7;
		  int param2_00;
		  int param3_00;
		  int *piVar8;
		  
		  if (DAT_ram_00a5751b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_ulong__GameEventData__get_Values__);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToArray_GameEventData___);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_ICollection_GameEventData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_GameTime_ICurrentTimeProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_GameEventData___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_GameEventData__TypeInfo);
		    DAT_ram_00a5751b = '\x01';
		  }
		  *param2 = 0;
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  piVar7 = *(int **)(iVar3 + 0x1c);
		  iVar3 = *piVar7;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar2 = 0;
		    do {
		      if (Core_GameTime_ICurrentTimeProvider_TypeInfo ==
		          *(int *)(*(int *)(iVar3 + 0x58) + uVar2 * 8)) {
		        puVar4 = (uint *)(iVar3 + *(int *)(*(int *)(iVar3 + 0x58) + uVar2 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80d9d8da;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar2);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar7,Core_GameTime_ICurrentTimeProvider_TypeInfo,0);
		code_r0x80d9d8da:
		  uVar1 = (**(code **)((ulonglong)*puVar4 * 4))(piVar7,puVar4[1]);
		  iVar3 = 0;
		  iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  param1_00 = System_Collections_Generic_Dictionary_int__object___TryAdd
		                        (*(undefined4 *)(iVar5 + 0x28),
		                         Method_System_Collections_Generic_Dictionary_ulong__GameEventData__get_Values__
		                        );
		  iVar5 = func_ii_6295(param1_00,Method_System_Linq_Enumerable_ToArray_GameEventData___);
		  if (0 < *(int *)(iVar5 + 0xc)) {
		    do {
		      param2_00 = *(int *)(iVar5 + iVar3 * 4 + 0x10);
		      if (*(ulonglong *)(*(int *)(param2_00 + 0x24) + 0x40) < uVar1) {
		        param3_00 = *param1;
		        iVar6 = (**(code **)((ulonglong)*(uint *)(param3_00 + 0x100) * 4))
		                          (param1,*(undefined4 *)(param3_00 + 0x104));
		        if (param2_00 != *(int *)(iVar6 + 0x34)) {
		          Gameplay_GameEvents_Control_GameEventsController__SetEvents(param1,param2_00,param3_00);
		          piVar7 = (int *)*param2;
		          if (piVar7 == (int *)0x0) {
		            piVar7 = (int *)unnamed_function_1417
		                                      (System_Collections_Generic_List_GameEventData__TypeInfo);
		            GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		                      (piVar7,Method_System_Collections_Generic_List_GameEventData___ctor__);
		            *param2 = (int)piVar7;
		          }
		          iVar6 = *piVar7;
		          if (*(ushort *)(iVar6 + 0xb6) != 0) {
		            uVar2 = 0;
		            do {
		              piVar8 = (int *)(*(int *)(iVar6 + 0x58) + uVar2 * 8);
		              if (System_Collections_Generic_ICollection_GameEventData__TypeInfo == *piVar8) {
		                puVar4 = (uint *)(piVar8[1] * 8 + iVar6 + 0xd0);
		                goto code_r0x80d9da06;
		              }
		              uVar2 = uVar2 + 1;
		            } while (*(ushort *)(iVar6 + 0xb6) != uVar2);
		          }
		          puVar4 = (uint *)func_ii_1080(piVar7,
		                                        System_Collections_Generic_ICollection_GameEventData__TypeInfo
		                                        ,2);
		code_r0x80d9da06:
		          (**(code **)((ulonglong)*puVar4 * 4))(piVar7,param2_00,puVar4[1]);
		        }
		      }
		      iVar3 = iVar3 + 1;
		    } while (iVar3 < *(int *)(iVar5 + 0xc));
		  }
		  return (uint)(*param2 != 0);
		}
		*/

		}

		// Token: 0x06002F32 RID: 12082 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F32")]
		[Address(RVA = "0x7F9E", Offset = "0x7F9E", VA = "0x7F9E")]
		private void RemoveEvent(GameEventData evt)
		{
		/* --- GHIDRA: RemoveEvent ---
		int Gameplay_GameEvents_Control_GameEventsController__RemoveEvent
		              (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a57518 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_GameEvents_Control_GameEventsController__EventProcessCompleteCoroutine_d__11_TypeInfo
		              );
		    DAT_ram_00a57518 = '\x01';
		  }
		  iVar1 = unnamed_function_1417
		                    (
		                    Gameplay_GameEvents_Control_GameEventsController__EventProcessCompleteCoroutine_d__11_TypeInfo
		                    );
		  *(undefined4 *)(iVar1 + 0x14) = param2;
		  *(undefined4 *)(iVar1 + 0x10) = param1;
		  *(undefined4 *)(iVar1 + 8) = 0;
		  return iVar1;
		}
		*/

		}

		// Token: 0x06002F33 RID: 12083 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002F33")]
		[Address(RVA = "0x7F9F", Offset = "0x7F9F", VA = "0x7F9F")]
		private IEnumerator EventProcessCompleteCoroutine(GameEventData evt)
		{
		/* --- GHIDRA: EventProcessCompleteCoroutine ---
		undefined4
		Gameplay_GameEvents_Control_GameEventsController__EventProcessCompleteCoroutine
		          (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param2_00;
		  int iVar3;
		  int param1_00;
		  uint uVar4;
		  
		  if (DAT_ram_00a57519 == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Common_ContentStringMessage_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Dic_EventCategoriesDic_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_EventCategoriesDic__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ContentStringMessage__Add__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_8258);
		    DAT_ram_00a57519 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  iVar3 = *(int *)(iVar1 + 0x44);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  if (iVar3 == 0) {
		    uVar2 = unnamed_function_1417(Protocol_Dic_EventCategoriesDic_TypeInfo);
		    Protocol_Dic_EventCategoriesDic__pb__Google_Protobuf_IMessage_get_Descriptor(uVar2,0);
		    *(undefined4 *)(iVar1 + 0x44) = uVar2;
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    uVar2 = *(undefined4 *)(*(int *)(iVar1 + 0x44) + 0x18);
		    iVar1 = unnamed_function_1417(Protocol_Common_ContentStringMessage_TypeInfo);
		    Protocol_Common_ContentStringMessage__pb__Google_Protobuf_IMessage_get_Descriptor(iVar1,0);
		    *(undefined4 *)(iVar1 + 0xc) = 0x42;
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    param2_00 = func_ii_7508(StringLiteral_8258,1,0,1,0,0,0,0);
		    Protocol_Common_ContentStringMessage__get_Message(iVar1,param2_00,0);
		    func_ii_6441(uVar2,iVar1,
		                 Method_Google_Protobuf_Collections_RepeatedField_ContentStringMessage__Add__);
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    param1_00 = *(int *)(iVar1 + 0x10);
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    iVar1 = Method_System_Collections_Generic_List_EventCategoriesDic__Add__;
		    uVar2 = *(undefined4 *)(iVar3 + 0x44);
		    *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		    uVar4 = *(uint *)(param1_00 + 0xc);
		    if (uVar4 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		      *(uint *)(param1_00 + 0xc) = uVar4 + 1;
		      *(undefined4 *)(*(int *)(param1_00 + 8) + uVar4 * 4 + 0x10) = uVar2;
		    }
		    else {
		      System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                (param1_00,uVar2,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		    }
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		  }
		  return *(undefined4 *)(iVar1 + 0x44);
		}
		*/

			return null;
		}

		// Token: 0x06002F34 RID: 12084 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002F34")]
		[Address(RVA = "0x7FA0", Offset = "0x7FA0", VA = "0x7FA0")]
		private EventCategoriesDic GetArchiveCategory()
		{
		/* --- GHIDRA: GetArchiveCategory ---
		void Gameplay_GameEvents_Control_GameEventsController__GetArchiveCategory
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 in_register_20000014;
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  uint param2_00;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x104)));
		  param2_00 = *(uint *)(*(int *)(param2 + 0x1c) + 0xc);
		  if (DAT_ram_00a574c5 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__List_GameEventData___ContainsKey__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_ulong__GameEventData__Remove__);
		    DAT_ram_00a574c5 = '\x01';
		  }
		  iVar2 = UnityEngine_TextCore_Text_FontAsset__ReadFontAssetDefinition
		                    (*(undefined4 *)(iVar1 + 0x4c),param2_00,
		                     Method_System_Collections_Generic_Dictionary_uint__List_GameEventData___ContainsKey__
		                    );
		  if (iVar2 != 0) {
		    Gameplay_GameEvents_Model_GameEventsModel__GetEvent
		              (*(undefined4 *)(iVar1 + 0x28),(ulonglong)param2_00,
		               Method_System_Collections_Generic_Dictionary_ulong__GameEventData__Remove__);
		  }
		  uVar3 = Gameplay_GameEvents_Control_GameEventsController__EventProcessCompleteCoroutine
		                    (param1,param1);
		  *(undefined4 *)(param2 + 0x30) = 0;
		  *(undefined4 *)(param2 + 0x1c) = uVar3;
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06002F35 RID: 12085 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F35")]
		[Address(RVA = "0x7FA1", Offset = "0x7FA1", VA = "0x7FA1")]
		private void MoveToArchive(GameEventData evt)
		{
		/* --- GHIDRA: MoveToArchive ---
		void Gameplay_GameEvents_Control_GameEventsController__MoveToArchive
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 param2_00;
		  int param3_00;
		  undefined1 auStack_10 [12];
		  int local_4;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  param2_00 = *(undefined4 *)(*(int *)(param2 + 0x1c) + 0xc);
		  if (DAT_ram_00a574bc == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_EventCategoriesDic_Types_Category__int__TryGetValue__
		              );
		    DAT_ram_00a574bc = '\x01';
		  }
		  local_4 = 0;
		  iVar1 = System_Collections_Generic_List_Enumerator_ValueTuple_object__double____MoveNext
		                    (*(undefined4 *)(iVar1 + 0x2c),param2_00,&local_4,
		                     Method_System_Collections_Generic_Dictionary_EventCategoriesDic_Types_Category__int__TryGetValue__
		                    );
		  param3_00 = local_4 + 1;
		  if (iVar1 == 0) {
		    param3_00 = 1;
		  }
		  System_Collections_Generic_Dictionary_Int32Enum__int___TryGetValue
		            (param1,*(undefined4 *)(*(int *)(param2 + 0x1c) + 0xc),param3_00,auStack_10);
		  return;
		}
		*/

		}

		// Token: 0x06002F36 RID: 12086 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F36")]
		[Address(RVA = "0x7FA2", Offset = "0x7FA2", VA = "0x7FA2")]
		private void IncreaseNotViewedEventsCount(GameEventData evt)
		{
		/* --- GHIDRA: IncreaseNotViewedEventsCount ---
		void Gameplay_GameEvents_Control_GameEventsController__IncreaseNotViewedEventsCount
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 param2_00;
		  int param3_00;
		  undefined1 auStack_10 [12];
		  int local_4;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  param2_00 = *(undefined4 *)(*(int *)(param2 + 0x1c) + 0xc);
		  if (DAT_ram_00a574bc == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_EventCategoriesDic_Types_Category__int__TryGetValue__
		              );
		    DAT_ram_00a574bc = '\x01';
		  }
		  local_4 = 0;
		  iVar1 = System_Collections_Generic_List_Enumerator_ValueTuple_object__double____MoveNext
		                    (*(undefined4 *)(iVar1 + 0x2c),param2_00,&local_4,
		                     Method_System_Collections_Generic_Dictionary_EventCategoriesDic_Types_Category__int__TryGetValue__
		                    );
		  param3_00 = local_4 + -1;
		  if (iVar1 == 0) {
		    param3_00 = -1;
		  }
		  System_Collections_Generic_Dictionary_Int32Enum__int___TryGetValue
		            (param1,*(undefined4 *)(*(int *)(param2 + 0x1c) + 0xc),param3_00,auStack_10);
		  return;
		}
		*/

		}

		// Token: 0x06002F37 RID: 12087 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F37")]
		[Address(RVA = "0x7FA3", Offset = "0x7FA3", VA = "0x7FA3")]
		private void DecreaseNotViewedEventsCount(GameEventData evt)
		{
		/* --- GHIDRA: DecreaseNotViewedEventsCount ---
		void Gameplay_GameEvents_Control_GameEventsController__DecreaseNotViewedEventsCount
		               (undefined8 *param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5)
		
		{
		  undefined8 local_40;
		  undefined8 local_38;
		  undefined4 local_30;
		  undefined8 local_2c;
		  undefined8 local_24;
		  undefined4 local_1c;
		  undefined4 local_18;
		  undefined4 local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5751e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskMethodBuilder_UniTask__Create__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskMethodBuilder_UniTask__Start_GameEventsController__WarmSourceInfo_d__20___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskMethodBuilder_UniTask__get_Task__
		              );
		    DAT_ram_00a5751e = '\x01';
		  }
		  local_8 = 0;
		  local_24 = 0;
		  local_10 = 0;
		  local_2c = 0;
		  local_30 = 0xffffffff;
		  local_1c = param2;
		  local_18 = param4;
		  local_14 = param3;
		  if (*(int *)(
		              Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskMethodBuilder_UniTask__Start_GameEventsController__WarmSourceInfo_d__20___
		              + 0x1c) == 0) {
		    System_ReadOnlySpan_char___GetPinnableReference
		              (
		              Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskMethodBuilder_UniTask__Start_GameEventsController__WarmSourceInfo_d__20___
		              );
		  }
		  Gameplay_GameEvents_Control_GameEventsController__SetEvents_d__8__SetStateMachine
		            (&local_30,&local_40);
		  unnamed_function_62993
		            (&local_40,&local_2c,
		             Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskMethodBuilder_UniTask__get_Task__
		            );
		  param1[1] = local_38;
		  *param1 = local_40;
		  return;
		}
		*/

		}

		// Token: 0x06002F38 RID: 12088 RVA: 0x00009978 File Offset: 0x00007B78
		[Token(Token = "0x6002F38")]
		[Address(RVA = "0x1ACA", Offset = "0x1ACA", VA = "0x1ACA")]
		private bool TryScheduleByExpirations(DelayedCall scheduler, float? scheduleThreshold)
		{
		/* --- GHIDRA: TryScheduleByExpirations ---
		int * Gameplay_GameEvents_Control_GameEventsController__TryScheduleByExpirations(int *param1)
		
		{
		  if (*param1 == 0) {
		    return param1;
		  }
		  System_Data_DataSet__ValidateLocaleConstraint(*param1);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

			return default(bool);
		}

		// Token: 0x06002F39 RID: 12089 RVA: 0x00009990 File Offset: 0x00007B90
		[Token(Token = "0x6002F39")]
		[Address(RVA = "0x1AC9", Offset = "0x1AC9", VA = "0x1AC9")]
		private bool TryDeleteExpired(out IList<GameEventData> deleted)
		{
		/* --- GHIDRA: TryDeleteExpired ---
		undefined4
		Gameplay_GameEvents_Control_GameEventsController__TryDeleteExpired
		          (int *param1,undefined4 param2,char *param3,undefined4 param4)
		
		{
		  float8 fVar1;
		  undefined4 in_register_20000004;
		  undefined8 uVar2;
		  undefined4 in_register_20000014;
		  undefined8 uVar3;
		  undefined4 uVar4;
		  int iVar5;
		  undefined4 param1_00;
		  uint *puVar6;
		  undefined4 uVar7;
		  int iVar8;
		  float param2_00;
		  ulonglong uVar9;
		  double dVar10;
		  int *piVar11;
		  longlong lVar12;
		  longlong param1_01;
		  uint uVar13;
		  byte local_38;
		  float8 local_30;
		  int local_28;
		  undefined8 *local_24;
		  undefined8 local_20;
		  undefined8 local_18;
		  byte local_10;
		  float8 local_8;
		  
		  if (DAT_ram_00a5751a == '\0') {
		    Mono_Security_ASN1__get_Item(&Utils_BackTime_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_ulong__GameEventData__get_Values__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_ulong__GameEventData__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_ulong__GameEventData__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_ulong__GameEventData__get_Current__
		              );
		    Mono_Security_ASN1__get_Item(&Core_GameTime_ICurrentTimeProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_float__GetValueOrDefault__);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_double__GetValueOrDefault__);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_double___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_double__get_HasValue__);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_float__get_HasValue__);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_double__get_Value__);
		    Mono_Security_ASN1__get_Item(&Utils_TimeUtils_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_ulong__GameEventData__GetEnumerator__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_ulong__GameEventData__get_Count__
		              );
		    DAT_ram_00a5751a = '\x01';
		  }
		  local_18 = 0;
		  local_20 = 0;
		  uVar2 = CONCAT44(in_register_20000004,param1);
		  uVar3 = CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x104));
		  iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(uVar2,uVar3);
		  uVar7 = (undefined4)((ulonglong)uVar2 >> 0x20);
		  uVar4 = (undefined4)((ulonglong)uVar3 >> 0x20);
		  param1_00 = System_Collections_Generic_Dictionary_int__object___TryAdd
		                        (*(undefined4 *)(iVar5 + 0x28),
		                         Method_System_Collections_Generic_Dictionary_ulong__GameEventData__get_Values__
		                        );
		  iVar5 = System_Collections_Generic_Dictionary_ValueCollection_TypeConverterRegistry_ConverterKey__object___System_Collections_IEnumerable_GetEnumerator
		                    (param1_00,
		                     Method_System_Collections_Generic_Dictionary_ValueCollection_ulong__GameEventData__get_Count__
		                    );
		  if (iVar5 == 0) {
		    return 0;
		  }
		  uVar2 = CONCAT44(uVar7,param1);
		  uVar3 = CONCAT44(uVar4,*(undefined4 *)(*param1 + 0x104));
		  iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(uVar2,uVar3);
		  uVar4 = (undefined4)((ulonglong)uVar3 >> 0x20);
		  uVar7 = (undefined4)((ulonglong)uVar2 >> 0x20);
		  uVar13 = 0;
		  piVar11 = *(int **)(iVar5 + 0x1c);
		  iVar5 = *piVar11;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_GameTime_ICurrentTimeProvider_TypeInfo ==
		          *(int *)(*(int *)(iVar5 + 0x58) + uVar13 * 8)) {
		        puVar6 = (uint *)(iVar5 + *(int *)(*(int *)(iVar5 + 0x58) + uVar13 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80d9dba5;
		      }
		      uVar13 = uVar13 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar13);
		  }
		  puVar6 = (uint *)func_ii_1080(piVar11,Core_GameTime_ICurrentTimeProvider_TypeInfo,0);
		code_r0x80d9dba5:
		  uVar9 = (**(code **)((ulonglong)*puVar6 * 4))(CONCAT44(uVar7,piVar11),CONCAT44(uVar4,puVar6[1]));
		  local_8 = 0.0;
		  _local_10 = 0;
		  iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar7 = System_Collections_Generic_Dictionary_int__object___TryAdd
		                    (*(undefined4 *)(iVar5 + 0x28),
		                     Method_System_Collections_Generic_Dictionary_ulong__GameEventData__get_Values__
		                    );
		  System_Collections_Generic_Dictionary_Int32Enum__object___get_Values
		            (&local_20,uVar7,
		             Method_System_Collections_Generic_Dictionary_ValueCollection_ulong__GameEventData__GetEnumerator__
		            );
		  local_28 = 0;
		  local_24 = &local_20;
		  while( true ) {
		    DAT_ram_009d3e38 = 0;
		    iVar8 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x2e2,&local_20,
		                       Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_ulong__GameEventData__MoveNext__
		                      );
		    iVar5 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar5 == 1) break;
		    if (iVar8 == 0) goto code_r0x80d9ddd6;
		    dVar10 = (double)*(ulonglong *)(*(int *)(local_18._4_4_ + 0x24) + 0x40) - (double)uVar9;
		    if (0.0 <= dVar10) {
		      if (local_10 == 0) {
		        local_30 = 0.0;
		        _local_38 = 0;
		        DAT_ram_009d3e38 = 0;
		        System_Collections_Generic_Dictionary_ValueCollection_Enumerator_ulong__object___MoveNext
		                  (&local_38,dVar10,Method_System_Nullable_double___ctor__);
		        iVar5 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar5 == 1) {
		          uVar7 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80d9dd80;
		        }
		        local_8 = local_30;
		        _local_10 = _local_38;
		      }
		      else if (dVar10 < (double)local_8) {
		        local_30 = 0.0;
		        _local_38 = 0;
		        DAT_ram_009d3e38 = 0;
		        System_Collections_Generic_Dictionary_ValueCollection_Enumerator_ulong__object___MoveNext
		                  (&local_38,dVar10,Method_System_Nullable_double___ctor__);
		        iVar5 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar5 == 1) {
		          uVar7 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80d9dd80;
		        }
		        local_8 = local_30;
		        _local_10 = _local_38;
		      }
		    }
		  }
		  uVar7 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80d9dd80:
		  iVar5 = global_1;
		  iVar8 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar5 != iVar8) {
		code_r0x80d9de42:
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_000017c8 + 0x2e4,&local_28);
		    iVar5 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar5 == 1) {
		      import::env::__cxa_find_matching_catch_3(0);
		      unnamed_function_937();
		      do {
		        halt_trap();
		      } while( true );
		    }
		    import::env::__resumeException(uVar7);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  piVar11 = (int *)import::env::__cxa_begin_catch(uVar7);
		  iVar8 = *piVar11;
		  DAT_ram_009d3e38 = 0;
		  local_28 = iVar8;
		  import::env::invoke_v(0x123);
		  iVar5 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar5 == 1) {
		    uVar7 = import::env::__cxa_find_matching_catch_2();
		    goto code_r0x80d9de42;
		  }
		  if (iVar8 != 0) {
		    System_Data_DataSet__ValidateLocaleConstraint(iVar8);
		    do {
		      halt_trap();
		    } while( true );
		  }
		code_r0x80d9ddd6:
		  fVar1 = local_8;
		  DAT_ram_009d3e38 = 0;
		  if (local_10 == 0) {
		code_r0x80d9de2e:
		    uVar7 = 0;
		    Utils_Timers_DelayedCall__SetDelay(param2,0);
		  }
		  else {
		    if (*param3 != '\0') {
		      local_30 = 0.0;
		      _local_38 = 0;
		      System_Collections_Generic_Dictionary_ValueCollection_Enumerator_ulong__object___MoveNext
		                (&local_38,(double)*(float *)(param3 + 4),Method_System_Nullable_double___ctor__);
		      if ((local_38 != 0) && ((double)local_30 < (double)fVar1)) goto code_r0x80d9de2e;
		    }
		    dVar10 = System_Nullable_double___get_HasValue
		                       (&local_10,Method_System_Nullable_double__get_Value__);
		    if (*(int *)(Utils_TimeUtils_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Utils_TimeUtils_TypeInfo);
		    }
		    if (dVar10 < 1.8446744073709552e+19 && 0.0 <= dVar10) {
		      lVar12 = (longlong)dVar10;
		    }
		    else {
		      lVar12 = 0;
		    }
		    if (ABS(dVar10) < 9.223372036854776e+18) {
		      param1_01 = (longlong)dVar10;
		    }
		    else {
		      param1_01 = -0x8000000000000000;
		    }
		    if (0.0 <= dVar10) {
		      param1_01 = lVar12;
		    }
		    param2_00 = Utils_StringUtils___cctor(param1_01,0);
		    uVar7 = unnamed_function_1417(Utils_BackTime_TypeInfo);
		    Core_Extensions_Dict_DictExt__BinarySearch_object__uint_(uVar7,param2_00,0);
		    Utils_Timers_DelayedCall__SetDelay(param2,uVar7,0);
		    uVar7 = 1;
		  }
		  return uVar7;
		}
		*/

			return default(bool);
		}

		// Token: 0x06002F3A RID: 12090 RVA: 0x000099A8 File Offset: 0x00007BA8
		[Token(Token = "0x6002F3A")]
		[Address(RVA = "0x1AC2", Offset = "0x1AC2", VA = "0x1AC2")]
		private UniTask<UniTask> WarmSourceInfo(IEnumerable<ProtoGetEventsListAns.Types.EventInfo> eventsInfos)
		{
		/* --- GHIDRA: WarmSourceInfo ---
		/* WARNING: Removing unreachable block (ram,0x81f3a38a) */
		/* WARNING: Removing unreachable block (ram,0x81f3a31c) */
		
		void Gameplay_GameEvents_Control_GameEventsController__WarmSourceInfo
		               (int param1,undefined4 param2,undefined8 *param3,int param4)
		
		{
		  int iVar1;
		  undefined4 param3_00;
		  int iVar2;
		  undefined4 *puVar3;
		  undefined4 uVar4;
		  undefined4 *param2_00;
		  int *param2_01;
		  undefined8 local_38;
		  undefined8 local_30;
		  undefined8 local_28;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined4 local_10;
		  undefined4 local_4;
		  
		  if ((*(int *)(param4 + 0x1c) == 0) &&
		     (Mono_Security_ASN1__get_Item(&StringLiteral_3352), *(int *)(param4 + 0x1c) == 0)) {
		    System_ReadOnlySpan_char___GetPinnableReference(param4);
		  }
		  local_4 = 0;
		  DAT_ram_009d3e38 = 0;
		  param2_01 = (int *)(param1 + 4);
		  uVar4 = import::env::invoke_iiiii
		                    (s_struct_VertexOutput____builtin_p_ram_000028b3 + 0x27c,param2_01,0,&local_4,0)
		  ;
		  iVar1 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar1 == 1) {
		    uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		  }
		  else if (*param2_01 == 0) {
		    local_10 = *(undefined4 *)(param3 + 5);
		    local_18 = param3[4];
		    local_20 = param3[3];
		    local_28 = param3[2];
		    local_30 = param3[1];
		    local_38 = *param3;
		    DAT_ram_009d3e38 = 0;
		    param3_00 = import::env::invoke_iii
		                          (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x19,
		                           *(undefined4 *)(*(int *)(param4 + 0x1c) + 4),&local_38);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 == 1) {
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    }
		    else {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_viiiii
		                (s_struct_VertexOutput____builtin_p_ram_000028b3 + 0x27d,param2_01,param3_00,local_4
		                 ,0,0);
		      iVar1 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar1 != 1) goto code_r0x81f3a43e;
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    }
		  }
		  else {
		code_r0x81f3a43e:
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s___Scripting__UnityEngine__Animat_ram_00003bae + 0x19,param2,uVar4,
		               *(undefined4 *)(*(int *)(param4 + 0x1c) + 0x14));
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 != 1) {
		      DAT_ram_009d3e38 = 0;
		      return;
		    }
		    uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		  }
		  iVar1 = global_1;
		  iVar2 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar1 == iVar2) {
		    puVar3 = (undefined4 *)import::env::__cxa_begin_catch(uVar4);
		    DAT_ram_009d3e38 = 0;
		    uVar4 = import::env::invoke_ii
		                      (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1c,
		                       &System_Exception_TypeInfo);
		    if (DAT_ram_009d3e38 != 1) {
		      DAT_ram_009d3e38 = 0;
		      iVar2 = import::env::invoke_iii
		                        (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1d,uVar4,
		                         *(undefined4 *)*puVar3);
		      iVar1 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar1 != 1) {
		        if (iVar2 != 0) {
		          uVar4 = *puVar3;
		          import::env::__cxa_end_catch();
		          func_ii_21539(uVar4,0,0);
		          return;
		        }
		        param2_00 = (undefined4 *)unnamed_function_951(4);
		        *param2_00 = *puVar3;
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1e,param2_00,
		                   &DAT_ram_0072c9c8,0);
		        if (DAT_ram_009d3e38 != 1) goto code_r0x81f3a5ce;
		      }
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar4 = import::env::__cxa_find_matching_catch_2();
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_v(0x123);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 == 1) {
		      import::env::__cxa_find_matching_catch_3(0);
		      unnamed_function_937();
		code_r0x81f3a5ce:
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  import::env::__resumeException(uVar4);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		/* --- GHIDRA: WarmSourceInfo ---
		/* WARNING: Removing unreachable block (ram,0x81f3a38a) */
		/* WARNING: Removing unreachable block (ram,0x81f3a31c) */
		
		void Gameplay_GameEvents_Control_GameEventsController__WarmSourceInfo
		               (int param1,undefined4 param2,undefined8 *param3,int param4)
		
		{
		  int iVar1;
		  undefined4 param3_00;
		  int iVar2;
		  undefined4 *puVar3;
		  undefined4 uVar4;
		  undefined4 *param2_00;
		  int *param2_01;
		  undefined8 local_38;
		  undefined8 local_30;
		  undefined8 local_28;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined4 local_10;
		  undefined4 local_4;
		  
		  if ((*(int *)(param4 + 0x1c) == 0) &&
		     (Mono_Security_ASN1__get_Item(&StringLiteral_3352), *(int *)(param4 + 0x1c) == 0)) {
		    System_ReadOnlySpan_char___GetPinnableReference(param4);
		  }
		  local_4 = 0;
		  DAT_ram_009d3e38 = 0;
		  param2_01 = (int *)(param1 + 4);
		  uVar4 = import::env::invoke_iiiii
		                    (s_struct_VertexOutput____builtin_p_ram_000028b3 + 0x27c,param2_01,0,&local_4,0)
		  ;
		  iVar1 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar1 == 1) {
		    uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		  }
		  else if (*param2_01 == 0) {
		    local_10 = *(undefined4 *)(param3 + 5);
		    local_18 = param3[4];
		    local_20 = param3[3];
		    local_28 = param3[2];
		    local_30 = param3[1];
		    local_38 = *param3;
		    DAT_ram_009d3e38 = 0;
		    param3_00 = import::env::invoke_iii
		                          (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x19,
		                           *(undefined4 *)(*(int *)(param4 + 0x1c) + 4),&local_38);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 == 1) {
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    }
		    else {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_viiiii
		                (s_struct_VertexOutput____builtin_p_ram_000028b3 + 0x27d,param2_01,param3_00,local_4
		                 ,0,0);
		      iVar1 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar1 != 1) goto code_r0x81f3a43e;
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    }
		  }
		  else {
		code_r0x81f3a43e:
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s___Scripting__UnityEngine__Animat_ram_00003bae + 0x19,param2,uVar4,
		               *(undefined4 *)(*(int *)(param4 + 0x1c) + 0x14));
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 != 1) {
		      DAT_ram_009d3e38 = 0;
		      return;
		    }
		    uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		  }
		  iVar1 = global_1;
		  iVar2 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar1 == iVar2) {
		    puVar3 = (undefined4 *)import::env::__cxa_begin_catch(uVar4);
		    DAT_ram_009d3e38 = 0;
		    uVar4 = import::env::invoke_ii
		                      (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1c,
		                       &System_Exception_TypeInfo);
		    if (DAT_ram_009d3e38 != 1) {
		      DAT_ram_009d3e38 = 0;
		      iVar2 = import::env::invoke_iii
		                        (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1d,uVar4,
		                         *(undefined4 *)*puVar3);
		      iVar1 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar1 != 1) {
		        if (iVar2 != 0) {
		          uVar4 = *puVar3;
		          import::env::__cxa_end_catch();
		          func_ii_21539(uVar4,0,0);
		          return;
		        }
		        param2_00 = (undefined4 *)unnamed_function_951(4);
		        *param2_00 = *puVar3;
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1e,param2_00,
		                   &DAT_ram_0072c9c8,0);
		        if (DAT_ram_009d3e38 != 1) goto code_r0x81f3a5ce;
		      }
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar4 = import::env::__cxa_find_matching_catch_2();
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_v(0x123);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 == 1) {
		      import::env::__cxa_find_matching_catch_3(0);
		      unnamed_function_937();
		code_r0x81f3a5ce:
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  import::env::__resumeException(uVar4);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		/* --- GHIDRA: WarmSourceInfo ---
		/* WARNING: Removing unreachable block (ram,0x81f3a38a) */
		/* WARNING: Removing unreachable block (ram,0x81f3a31c) */
		
		void Gameplay_GameEvents_Control_GameEventsController__WarmSourceInfo
		               (int param1,undefined4 param2,undefined8 *param3,int param4)
		
		{
		  int iVar1;
		  undefined4 param3_00;
		  int iVar2;
		  undefined4 *puVar3;
		  undefined4 uVar4;
		  undefined4 *param2_00;
		  int *param2_01;
		  undefined8 local_38;
		  undefined8 local_30;
		  undefined8 local_28;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined4 local_10;
		  undefined4 local_4;
		  
		  if ((*(int *)(param4 + 0x1c) == 0) &&
		     (Mono_Security_ASN1__get_Item(&StringLiteral_3352), *(int *)(param4 + 0x1c) == 0)) {
		    System_ReadOnlySpan_char___GetPinnableReference(param4);
		  }
		  local_4 = 0;
		  DAT_ram_009d3e38 = 0;
		  param2_01 = (int *)(param1 + 4);
		  uVar4 = import::env::invoke_iiiii
		                    (s_struct_VertexOutput____builtin_p_ram_000028b3 + 0x27c,param2_01,0,&local_4,0)
		  ;
		  iVar1 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar1 == 1) {
		    uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		  }
		  else if (*param2_01 == 0) {
		    local_10 = *(undefined4 *)(param3 + 5);
		    local_18 = param3[4];
		    local_20 = param3[3];
		    local_28 = param3[2];
		    local_30 = param3[1];
		    local_38 = *param3;
		    DAT_ram_009d3e38 = 0;
		    param3_00 = import::env::invoke_iii
		                          (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x19,
		                           *(undefined4 *)(*(int *)(param4 + 0x1c) + 4),&local_38);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 == 1) {
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    }
		    else {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_viiiii
		                (s_struct_VertexOutput____builtin_p_ram_000028b3 + 0x27d,param2_01,param3_00,local_4
		                 ,0,0);
		      iVar1 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar1 != 1) goto code_r0x81f3a43e;
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    }
		  }
		  else {
		code_r0x81f3a43e:
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s___Scripting__UnityEngine__Animat_ram_00003bae + 0x19,param2,uVar4,
		               *(undefined4 *)(*(int *)(param4 + 0x1c) + 0x14));
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 != 1) {
		      DAT_ram_009d3e38 = 0;
		      return;
		    }
		    uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		  }
		  iVar1 = global_1;
		  iVar2 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar1 == iVar2) {
		    puVar3 = (undefined4 *)import::env::__cxa_begin_catch(uVar4);
		    DAT_ram_009d3e38 = 0;
		    uVar4 = import::env::invoke_ii
		                      (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1c,
		                       &System_Exception_TypeInfo);
		    if (DAT_ram_009d3e38 != 1) {
		      DAT_ram_009d3e38 = 0;
		      iVar2 = import::env::invoke_iii
		                        (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1d,uVar4,
		                         *(undefined4 *)*puVar3);
		      iVar1 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar1 != 1) {
		        if (iVar2 != 0) {
		          uVar4 = *puVar3;
		          import::env::__cxa_end_catch();
		          func_ii_21539(uVar4,0,0);
		          return;
		        }
		        param2_00 = (undefined4 *)unnamed_function_951(4);
		        *param2_00 = *puVar3;
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1e,param2_00,
		                   &DAT_ram_0072c9c8,0);
		        if (DAT_ram_009d3e38 != 1) goto code_r0x81f3a5ce;
		      }
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar4 = import::env::__cxa_find_matching_catch_2();
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_v(0x123);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 == 1) {
		      import::env::__cxa_find_matching_catch_3(0);
		      unnamed_function_937();
		code_r0x81f3a5ce:
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  import::env::__resumeException(uVar4);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

			return default(UniTask<UniTask>);
		}

		// Token: 0x06002F3B RID: 12091 RVA: 0x000099C0 File Offset: 0x00007BC0
		[Token(Token = "0x6002F3B")]
		[Address(RVA = "0x1AC0", Offset = "0x1AC0", VA = "0x1AC0")]
		private UniTask<UniTask> WarmSourceInfo(IEnumerable<GameEventData> events)
		{
			return default(UniTask<UniTask>);
		}

		// Token: 0x06002F3C RID: 12092 RVA: 0x000099D8 File Offset: 0x00007BD8
		[Token(Token = "0x6002F3C")]
		[Address(RVA = "0x7FA4", Offset = "0x7FA4", VA = "0x7FA4")]
		private UniTask<UniTask> WarmSourceInfo(List<ulong> userIds, List<ulong> clanIds)
		{
			return default(UniTask<UniTask>);
		}

		// Token: 0x06002F3D RID: 12093 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F3D")]
		[Address(RVA = "0x7FA5", Offset = "0x7FA5", VA = "0x7FA5")]
		private void ValidateExpired()
		{
		/* --- GHIDRA: ValidateExpired ---
		void Gameplay_GameEvents_Control_GameEventsController__ValidateExpired
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined8 local_3c;
		  undefined8 local_34;
		  undefined4 local_2c;
		  undefined8 local_28;
		  undefined8 local_20;
		  undefined4 local_18;
		  undefined4 local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a57517 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Runtime_CompilerServices_AsyncVoidMethodBuilder_Start_GameEventsController__SetEvents_d__8___
		              );
		    DAT_ram_00a57517 = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  System_Linq_Enumerable__ToDictionary_KeyValuePair_object__object___object__object_(&local_3c,0);
		  local_20 = local_34;
		  local_2c = 0xffffffff;
		  local_28 = local_3c;
		  local_18 = param1;
		  local_14 = param2;
		  System_Runtime_CompilerServices_AsyncVoidMethodBuilder__Start_GameEventsController__RequestOpenListView_d__39_
		            (&local_28,&local_2c,
		             Method_System_Runtime_CompilerServices_AsyncVoidMethodBuilder_Start_GameEventsController__SetEvents_d__8___
		            );
		  return;
		}
		*/

		}

		// Token: 0x06002F3E RID: 12094 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F3E")]
		[Address(RVA = "0x7FA6", Offset = "0x7FA6", VA = "0x7FA6")]
		private void HandleThereIsNewEvent(ProtoGetEventsListAns msg)
		{
		/* --- GHIDRA: HandleThereIsNewEvent ---
		void Gameplay_GameEvents_Control_GameEventsController__HandleThereIsNewEvent
		               (int *param1,int param2,int param3,undefined4 param4)
		
		{
		  int iVar1;
		  undefined4 param2_00;
		  int iVar2;
		  
		  if ((param2 == 3) &&
		     (iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104)), *(int *)(iVar1 + 0x34) != 0)) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    iVar1 = *(int *)(iVar1 + 0x34);
		    param2_00 = *(undefined4 *)(param3 + 0x74);
		    if (DAT_ram_00a574b8 == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&Method_Google_Protobuf_Collections_RepeatedField_ArtifactInfo__IndexOf__);
		      Mono_Security_ASN1__get_Item
		                (&Method_Google_Protobuf_Collections_RepeatedField_ArtifactInfo__RemoveAt__);
		      DAT_ram_00a574b8 = '\x01';
		    }
		    iVar2 = *(int *)(iVar1 + 0x30);
		    if ((iVar2 != 0) &&
		       (iVar2 = Google_Protobuf_Collections_RepeatedField_object___GetHashCode
		                          (iVar2,param2_00,
		                           Method_Google_Protobuf_Collections_RepeatedField_ArtifactInfo__IndexOf__)
		       , iVar2 != -1)) {
		      Google_Protobuf_Collections_RepeatedField_object___Insert
		                (*(undefined4 *)(iVar1 + 0x30),iVar2,
		                 Method_Google_Protobuf_Collections_RepeatedField_ArtifactInfo__RemoveAt__);
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002F3F RID: 12095 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F3F")]
		[Address(RVA = "0x7FA7", Offset = "0x7FA7", VA = "0x7FA7")]
		private void HandleArtifactDropRemoveEvent(DropTypes dropType, ArtifactData artifactData)
		{
		/* --- GHIDRA: HandleArtifactDropRemoveEvent ---
		void Gameplay_GameEvents_Control_GameEventsController__HandleArtifactDropRemoveEvent
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  if ((param2 == 3) &&
		     (iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104)), *(int *)(iVar1 + 0x34) != 0)) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    *(undefined4 *)(*(int *)(iVar1 + 0x34) + 0x30) = 0;
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002F40 RID: 12096 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F40")]
		[Address(RVA = "0x7FA8", Offset = "0x7FA8", VA = "0x7FA8")]
		private void HandleDropRemoveEvent(DropTypes dropType)
		{
		/* --- GHIDRA: HandleDropRemoveEvent ---
		void Gameplay_GameEvents_Control_GameEventsController__HandleDropRemoveEvent
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  undefined4 *puVar3;
		  int param1_00;
		  undefined4 param2_00;
		  undefined8 param2_01;
		  
		  if (DAT_ram_00a5751f == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_Select_AbstractActionOnEvent__uint___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToArray_uint___);
		    Mono_Security_ASN1__get_Item(&System_Func_AbstractActionOnEvent__uint__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_GameEvents_Control_GameEventsController_HandleProcessEventService__)
		    ;
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GameEvents_Control_GameEventsController___c__RequestProcessEvent_b__25_0__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_GameEvents_Control_GameEventsController___c_TypeInfo);
		    DAT_ram_00a5751f = '\x01';
		  }
		  uVar1 = *(undefined4 *)(param2 + 0x34);
		  uVar2 = *(undefined4 *)(param1 + 0x18);
		  param2_01 = *(undefined8 *)(*(int *)(param2 + 0x24) + 0x10);
		  if (*(int *)(Gameplay_GameEvents_Control_GameEventsController___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_GameEvents_Control_GameEventsController___c_TypeInfo);
		  }
		  puVar3 = *(undefined4 **)(Gameplay_GameEvents_Control_GameEventsController___c_TypeInfo + 0x5c);
		  param1_00 = puVar3[1];
		  if (param1_00 == 0) {
		    if (*(int *)(Gameplay_GameEvents_Control_GameEventsController___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_GameEvents_Control_GameEventsController___c_TypeInfo);
		      puVar3 = *(undefined4 **)
		                (Gameplay_GameEvents_Control_GameEventsController___c_TypeInfo + 0x5c);
		    }
		    param2_00 = *puVar3;
		    param1_00 = unnamed_function_1417(System_Func_AbstractActionOnEvent__uint__TypeInfo);
		    System_Collections_Generic_Dictionary_KeyCollection_uint__object___GetEnumerator
		              (param1_00,param2_00,
		               Method_Gameplay_GameEvents_Control_GameEventsController___c__RequestProcessEvent_b__25_0__
		               ,0);
		    *(int *)(*(int *)(Gameplay_GameEvents_Control_GameEventsController___c_TypeInfo + 0x5c) + 4) =
		         param1_00;
		  }
		  uVar1 = System_Linq_Enumerable__ReverseIterator___Il2CppFullySharedGenericType_
		                    (uVar1,param1_00,
		                     Method_System_Linq_Enumerable_Select_AbstractActionOnEvent__uint___);
		  uVar1 = System_Linq_Enumerable__OrderBy_uint__uint_
		                    (uVar1,Method_System_Linq_Enumerable_ToArray_uint___);
		  uVar1 = ServicesNamespace_EventsService__GetEventReward(uVar2,param2_01,uVar1,0);
		  uVar2 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Gameplay_GameEvents_Control_GameEventsController_HandleProcessEventService__,0);
		  uVar1 = ServicesNamespace_MainService__GetUserStats
		                    (uVar1,uVar2,param2,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  Utils_OpToken_int__object___AddHandlers(param1,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x06002F41 RID: 12097 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F41")]
		[Address(RVA = "0x7FA9", Offset = "0x7FA9", VA = "0x7FA9")]
		private void RequestProcessEvent(GameEventData evt)
		{
		/* --- GHIDRA: RequestProcessEvent ---
		void Gameplay_GameEvents_Control_GameEventsController__RequestProcessEvent
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  int *param1_00;
		  
		  if (DAT_ram_00a57520 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedGameEventsErrors___
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Events_ProtoProcessEventAns_TypeInfo);
		    DAT_ram_00a57520 = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  param1_00 = *(int **)(param2 + 0x20);
		  if ((param1_00 != (int *)0x0) && (Protocol_Events_ProtoProcessEventAns_TypeInfo != *param1_00)) {
		    System_Activator__CreateInstance(param1_00,Protocol_Events_ProtoProcessEventAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  UnityEngine_EventSystems_ExecuteEvents__ValidateEventData_object_
		            (param1_00[3],0,
		             Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedGameEventsErrors___
		            );
		  return;
		}
		*/

		}

		// Token: 0x06002F42 RID: 12098 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F42")]
		[Address(RVA = "0x7FAA", Offset = "0x7FAA", VA = "0x7FAA")]
		private void HandleProcessEventService(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: HandleProcessEventService ---
		void Gameplay_GameEvents_Control_GameEventsController__HandleProcessEventService
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a57521 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GameEvents_Control_GameEventsController_HandleGetEventRewardService__
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    DAT_ram_00a57521 = '\x01';
		  }
		  uVar1 = ServicesNamespace_EventsService__DeleteEvents
		                    (*(undefined4 *)(param1 + 0x18),*(undefined8 *)(*(int *)(param2 + 0x24) + 0x10),
		                     0);
		  param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_GameEvents_Control_GameEventsController_HandleGetEventRewardService__,0
		            );
		  uVar1 = ServicesNamespace_MainService__GetUserStats
		                    (uVar1,param1_00,param2,
		                     Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  Utils_OpToken_int__object___AddHandlers(param1,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x06002F43 RID: 12099 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F43")]
		[Address(RVA = "0x7FAB", Offset = "0x7FAB", VA = "0x7FAB")]
		private void RequestGetEventReward(GameEventData evt)
		{
		/* --- GHIDRA: RequestGetEventReward ---
		void Gameplay_GameEvents_Control_GameEventsController__RequestGetEventReward
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int *param1_00;
		  int *param1_01;
		  
		  if (DAT_ram_00a57522 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedGameEventsErrors___
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_GameEvents_Model_GameEventData_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Events_ProtoGetEventRewardAns_TypeInfo);
		    DAT_ram_00a57522 = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  param1_00 = *(int **)(param2 + 0x20);
		  if ((param1_00 != (int *)0x0) && (Protocol_Events_ProtoGetEventRewardAns_TypeInfo != *param1_00))
		  {
		    System_Activator__CreateInstance(param1_00,Protocol_Events_ProtoGetEventRewardAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar1 = UnityEngine_EventSystems_ExecuteEvents__ValidateEventData_object_
		                    (param1_00[4],0,
		                     Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedGameEventsErrors___
		                    );
		  if (iVar1 == 0) {
		    param1_01 = *(int **)(param2 + 0xc);
		    if (param1_01 != (int *)0x0) {
		      if (((uint)*(byte *)(*param1_01 + 0xb8) <
		           (uint)*(byte *)(Gameplay_GameEvents_Model_GameEventData_TypeInfo + 0xb8)) ||
		         (*(int *)(*(int *)(*param1_01 + 100) +
		                   (uint)*(byte *)(Gameplay_GameEvents_Model_GameEventData_TypeInfo + 0xb8) * 4 + -4
		                  ) != Gameplay_GameEvents_Model_GameEventData_TypeInfo)) {
		        System_Activator__CreateInstance(param1_01,Gameplay_GameEvents_Model_GameEventData_TypeInfo)
		        ;
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    param1_01[0xc] = param1_00[3];
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    if (*(int **)(iVar1 + 0x34) == param1_01) {
		      iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x114));
		      iVar1 = *(int *)(iVar1 + 0x24);
		      if (iVar1 != 0) {
		        (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                  (*(undefined4 *)(iVar1 + 0x20),param1_01,*(undefined4 *)(iVar1 + 0x14));
		      }
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002F44 RID: 12100 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F44")]
		[Address(RVA = "0x7FAC", Offset = "0x7FAC", VA = "0x7FAC")]
		private void HandleGetEventRewardService(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: HandleGetEventRewardService ---
		void Gameplay_GameEvents_Control_GameEventsController__HandleGetEventRewardService
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a57523 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_GameEvents_Control_GameEventsController_HandleDeleteEventsService__)
		    ;
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    DAT_ram_00a57523 = '\x01';
		  }
		  param1_00 = ServicesNamespace_EventsService__GetEventsList
		                        (*(undefined4 *)(param1 + 0x18),param2,0);
		  param1_01 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_01,param1,
		             Method_Gameplay_GameEvents_Control_GameEventsController_HandleDeleteEventsService__,0);
		  ServicesNamespace_MainService__GetUserStats
		            (param1_00,param1_01,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  return;
		}
		*/

		}

		// Token: 0x06002F45 RID: 12101 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F45")]
		[Address(RVA = "0x7FAD", Offset = "0x7FAD", VA = "0x7FAD")]
		private void RequestDelete(ulong[] ids)
		{
		}

		// Token: 0x06002F46 RID: 12102 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F46")]
		[Address(RVA = "0x7FAE", Offset = "0x7FAE", VA = "0x7FAE")]
		private void HandleDeleteEventsService(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: HandleDeleteEventsService ---
		void Gameplay_GameEvents_Control_GameEventsController__HandleDeleteEventsService
		               (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a57524 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_GameEvents_Control_GameEventsController_HandleGetEventsList__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    DAT_ram_00a57524 = '\x01';
		  }
		  uVar1 = ServicesNamespace_EventsService__ServerEventHandler(*(undefined4 *)(param1 + 0x18),0);
		  param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_GameEvents_Control_GameEventsController_HandleGetEventsList__,0);
		  uVar1 = ServicesNamespace_MainService__GetUserStats
		                    (uVar1,param1_00,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  Utils_OpToken_int__object___AddHandlers(param1,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x06002F47 RID: 12103 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F47")]
		[Address(RVA = "0x7FAF", Offset = "0x7FAF", VA = "0x7FAF")]
		private void RequestEventsList()
		{
		/* --- GHIDRA: RequestEventsList ---
		void Gameplay_GameEvents_Control_GameEventsController__RequestEventsList
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int *param1_00;
		  undefined8 local_3c;
		  undefined8 local_34;
		  undefined4 local_2c;
		  undefined8 local_28;
		  undefined8 local_20;
		  int *local_18;
		  int *local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a57525 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Events_ProtoGetEventsListAns_TypeInfo);
		    DAT_ram_00a57525 = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  param1_00 = *(int **)(param2 + 0x20);
		  if ((param1_00 != (int *)0x0) && (Protocol_Events_ProtoGetEventsListAns_TypeInfo != *param1_00)) {
		    System_Activator__CreateInstance(param1_00,Protocol_Events_ProtoGetEventsListAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  if (DAT_ram_00a57517 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Runtime_CompilerServices_AsyncVoidMethodBuilder_Start_GameEventsController__SetEvents_d__8___
		              );
		    DAT_ram_00a57517 = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  System_Linq_Enumerable__ToDictionary_KeyValuePair_object__object___object__object_(&local_3c,0);
		  local_20 = local_34;
		  local_2c = 0xffffffff;
		  local_28 = local_3c;
		  local_18 = param1;
		  local_14 = param1_00;
		  System_Runtime_CompilerServices_AsyncVoidMethodBuilder__Start_GameEventsController__RequestOpenListView_d__39_
		            (&local_28,&local_2c,
		             Method_System_Runtime_CompilerServices_AsyncVoidMethodBuilder_Start_GameEventsController__SetEvents_d__8___
		            );
		  if (*(char *)((int)param1 + 9) == '\0') {
		    *(undefined1 *)((int)param1 + 9) = 1;
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar1 = *(int *)(iVar1 + 8);
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002F48 RID: 12104 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F48")]
		[Address(RVA = "0x7FB0", Offset = "0x7FB0", VA = "0x7FB0")]
		private void HandleGetEventsList(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: HandleGetEventsList ---
		void Gameplay_GameEvents_Control_GameEventsController__HandleGetEventsList
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 param2_00;
		  int param3_00;
		  undefined1 auStack_10 [12];
		  int local_4;
		  
		  *(undefined1 *)(param2 + 8) = 1;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  param2_00 = *(undefined4 *)(*(int *)(param2 + 0x1c) + 0xc);
		  if (DAT_ram_00a574bc == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_EventCategoriesDic_Types_Category__int__TryGetValue__
		              );
		    DAT_ram_00a574bc = '\x01';
		  }
		  local_4 = 0;
		  iVar1 = System_Collections_Generic_List_Enumerator_ValueTuple_object__double____MoveNext
		                    (*(undefined4 *)(iVar1 + 0x2c),param2_00,&local_4,
		                     Method_System_Collections_Generic_Dictionary_EventCategoriesDic_Types_Category__int__TryGetValue__
		                    );
		  param3_00 = local_4 + -1;
		  if (iVar1 == 0) {
		    param3_00 = -1;
		  }
		  System_Collections_Generic_Dictionary_Int32Enum__int___TryGetValue
		            (param1,*(undefined4 *)(*(int *)(param2 + 0x1c) + 0xc),param3_00,auStack_10);
		  return;
		}
		*/

		}

		// Token: 0x06002F49 RID: 12105 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F49")]
		[Address(RVA = "0x7FB1", Offset = "0x7FB1", VA = "0x7FB1")]
		public void NotifyEventHasBeenViewed(GameEventData evt)
		{
		/* --- GHIDRA: NotifyEventHasBeenViewed ---
		void Gameplay_GameEvents_Control_GameEventsController__NotifyEventHasBeenViewed
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  if (*(int *)(iVar1 + 0x34) != param2) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    *(int *)(iVar1 + 0x34) = param2;
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar1 = *(int *)(iVar1 + 0x20);
		    if (iVar1 != 0) {
		      iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar2 + 0x34),
		                 *(undefined4 *)(iVar1 + 0x14));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002F4A RID: 12106 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F4A")]
		[Address(RVA = "0x7FB2", Offset = "0x7FB2", VA = "0x7FB2")]
		public void SetCurrentReadEvent(GameEventData evt)
		{
		/* --- GHIDRA: SetCurrentReadEvent ---
		void Gameplay_GameEvents_Control_GameEventsController__SetCurrentReadEvent
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 in_register_20000014;
		  int param1_00;
		  int param2_00;
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int iVar4;
		  undefined4 param1_01;
		  uint uVar5;
		  int param2_01;
		  undefined8 uVar6;
		  
		  param2_01 = 0;
		  if (DAT_ram_00a57526 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_ulong__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_ulong__ToArray__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_ulong___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_ulong__get_Count__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_GameEventData__get_Count__)
		    ;
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_GameEventData__get_Item__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_ulong__TypeInfo);
		    DAT_ram_00a57526 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_Collections_Generic_List_ulong__TypeInfo);
		  uVar6 = CONCAT44(in_register_20000014,Method_System_Collections_Generic_List_ulong___ctor__);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_00,Method_System_Collections_Generic_List_ulong___ctor__);
		  iVar4 = *(int *)(param2 + 0xc);
		  if (0 < iVar4) {
		    do {
		      uVar3 = (undefined4)((ulonglong)uVar6 >> 0x20);
		      param2_00 = System_Linq_Enumerable__ToList_object_
		                            (param2,param2_01,
		                             Method_System_Collections_Generic_List_GameEventData__get_Item__);
		      param1_01 = *(undefined4 *)(param2_00 + 0x1c);
		      uVar6 = CONCAT44(uVar3,*(undefined4 *)(*param1 + 0x104));
		      iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(param1,uVar6);
		      uVar3 = (undefined4)((ulonglong)uVar6 >> 0x20);
		      iVar2 = System_Collections_Generic_Dictionary_Enumerator_ulong__object___MoveNext
		                        (param1_01,*(undefined4 *)(iVar1 + 0x44),0);
		      iVar1 = Method_System_Collections_Generic_List_ulong__Add__;
		      if (iVar2 == 0) {
		        uVar6 = *(undefined8 *)(*(int *)(param2_00 + 0x24) + 0x10);
		        *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		        uVar5 = *(uint *)(param1_00 + 0xc);
		        if (uVar5 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		          *(uint *)(param1_00 + 0xc) = uVar5 + 1;
		          *(undefined8 *)(*(int *)(param1_00 + 8) + uVar5 * 8 + 0x10) = uVar6;
		        }
		        else {
		          System_Collections_Generic_List_ulong___Contains
		                    (param1_00,uVar6,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38)
		                    );
		          uVar3 = (undefined4)((ulonglong)uVar6 >> 0x20);
		        }
		      }
		      uVar6 = CONCAT44(uVar3,param2_00);
		      Gameplay_GameEvents_Control_GameEventsController__SetEvents(param1,param2_00,param1);
		      param2_01 = param2_01 + 1;
		    } while (param2_01 != iVar4);
		  }
		  if (0 < *(int *)(param1_00 + 0xc)) {
		    uVar3 = UnityEngine_TextCore_Text_FontAsset__UpdateFontFeaturesForNewlyAddedGlyphs
		                      (param1_00,Method_System_Collections_Generic_List_ulong__ToArray__);
		    Gameplay_GameEvents_Control_GameEventsController__HandleGetEventRewardService
		              (param1,uVar3,param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002F4B RID: 12107 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F4B")]
		[Address(RVA = "0x7FB3", Offset = "0x7FB3", VA = "0x7FB3")]
		public void Delete(List<GameEventData> events)
		{
		/* --- GHIDRA: Delete ---
		void Gameplay_GameEvents_Control_GameEventsController__Delete
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  undefined1 auStack_10 [12];
		  undefined4 local_4;
		  
		  local_4 = *(undefined4 *)(*(int *)(param2 + 0x24) + 0x24);
		  Core_Extensions_TransformExt__SetBottom(&local_4,4,0);
		  *(undefined4 *)(*(int *)(param2 + 0x24) + 0x24) = local_4;
		  Gameplay_GameEvents_Control_GameEventsController__HandleProcessEventService
		            (param1,param2,auStack_10);
		  return;
		}
		*/

		}

		// Token: 0x06002F4C RID: 12108 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F4C")]
		[Address(RVA = "0x7FB4", Offset = "0x7FB4", VA = "0x7FB4")]
		public void GetReward(GameEventData evt)
		{
		/* --- GHIDRA: GetReward ---
		void Gameplay_GameEvents_Control_GameEventsController__GetReward
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  int param2_00;
		  int *piVar1;
		  undefined4 param1_00;
		  undefined4 *puVar2;
		  int iVar3;
		  undefined4 param2_01;
		  
		  if (DAT_ram_00a57527 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Comparison_AbstractActionOnEvent__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_AbstractActionOnEvent__Sort__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_AbstractActionOnEvent__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_AbstractActionOnEvent__get_Item__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GameEvents_Control_GameEventsController___c__HandleEventActions_b__37_0__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_GameEvents_Control_GameEventsController___c_TypeInfo);
		    DAT_ram_00a57527 = '\x01';
		  }
		  param1_00 = *(undefined4 *)(param2 + 0x34);
		  if (*(int *)(Gameplay_GameEvents_Control_GameEventsController___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_GameEvents_Control_GameEventsController___c_TypeInfo);
		  }
		  puVar2 = *(undefined4 **)(Gameplay_GameEvents_Control_GameEventsController___c_TypeInfo + 0x5c);
		  iVar3 = puVar2[2];
		  if (iVar3 == 0) {
		    if (*(int *)(Gameplay_GameEvents_Control_GameEventsController___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_GameEvents_Control_GameEventsController___c_TypeInfo);
		      puVar2 = *(undefined4 **)
		                (Gameplay_GameEvents_Control_GameEventsController___c_TypeInfo + 0x5c);
		    }
		    param2_01 = *puVar2;
		    iVar3 = unnamed_function_1417(System_Comparison_AbstractActionOnEvent__TypeInfo);
		    System_Collections_Generic_Comparer_object___get_Default
		              (iVar3,param2_01,
		               Method_Gameplay_GameEvents_Control_GameEventsController___c__HandleEventActions_b__37_0__
		               ,0);
		    *(int *)(*(int *)(Gameplay_GameEvents_Control_GameEventsController___c_TypeInfo + 0x5c) + 8) =
		         iVar3;
		  }
		  param2_00 = 0;
		  Google_Protobuf_Collections_RepeatedField_uint___Contains
		            (param1_00,iVar3,Method_System_Collections_Generic_List_AbstractActionOnEvent__Sort__);
		  iVar3 = *(int *)(*(int *)(param2 + 0x34) + 0xc);
		  if (0 < iVar3) {
		    do {
		      piVar1 = (int *)System_Linq_Enumerable__ToList_object_
		                                (*(undefined4 *)(param2 + 0x34),param2_00,
		                                 Method_System_Collections_Generic_List_AbstractActionOnEvent__get_Item__
		                                );
		      if ((char)piVar1[6] != '\0') {
		        (**(code **)((ulonglong)*(uint *)(*piVar1 + 0xf0) * 4))
		                  (piVar1,param1,*(undefined4 *)(*piVar1 + 0xf4));
		      }
		      param2_00 = param2_00 + 1;
		    } while (param2_00 != iVar3);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002F4D RID: 12109 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F4D")]
		[Address(RVA = "0x7FB5", Offset = "0x7FB5", VA = "0x7FB5")]
		public void HandleEventActions(GameEventData evt)
		{
		/* --- GHIDRA: HandleEventActions ---
		void Gameplay_GameEvents_Control_GameEventsController__HandleEventActions
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 in_register_20000014;
		  undefined8 uVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 uVar5;
		  uint param2_00;
		  ulonglong param2_01;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a57528 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_GameEventData__IndexOf__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_GameEventData__RemoveAt__);
		    DAT_ram_00a57528 = '\x01';
		  }
		  local_4 = *(undefined4 *)(*(int *)(param2 + 0x24) + 0x24);
		  Core_Extensions_TransformExt__SetBottom(&local_4,1,0);
		  *(undefined4 *)(*(int *)(param2 + 0x24) + 0x24) = local_4;
		  uVar1 = CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x104));
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(param1,uVar1);
		  uVar2 = (undefined4)((ulonglong)uVar1 >> 0x20);
		  if (*(int *)(iVar3 + 0x34) != 0) {
		    uVar1 = CONCAT44(uVar2,*(undefined4 *)(*param1 + 0x104));
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(param1,uVar1);
		    *(undefined4 *)(iVar3 + 0x34) = 0;
		    uVar1 = CONCAT44((int)((ulonglong)uVar1 >> 0x20),*(undefined4 *)(*param1 + 0x114));
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))(param1,uVar1);
		    uVar2 = (undefined4)((ulonglong)uVar1 >> 0x20);
		    iVar3 = *(int *)(iVar3 + 0x20);
		    if (iVar3 != 0) {
		      uVar1 = CONCAT44(uVar2,*(undefined4 *)(*param1 + 0x104));
		      iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(param1,uVar1);
		      uVar1 = CONCAT44((int)((ulonglong)uVar1 >> 0x20),*(undefined4 *)(iVar4 + 0x34));
		      (**(code **)((ulonglong)*(uint *)(iVar3 + 0xc) * 4))
		                (*(undefined4 *)(iVar3 + 0x20),uVar1,*(undefined4 *)(iVar3 + 0x14));
		      uVar2 = (undefined4)((ulonglong)uVar1 >> 0x20);
		    }
		  }
		  Gameplay_GameEvents_Control_GameEventsController__HandleDropRemoveEvent(param1,param2,param1);
		  uVar1 = CONCAT44(uVar2,*(undefined4 *)(*param1 + 0x104));
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(param1,uVar1);
		  uVar2 = (undefined4)((ulonglong)uVar1 >> 0x20);
		  param2_00 = *(uint *)(*(int *)(param2 + 0x1c) + 0xc);
		  if (DAT_ram_00a574c5 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__List_GameEventData___ContainsKey__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_ulong__GameEventData__Remove__);
		    DAT_ram_00a574c5 = '\x01';
		  }
		  iVar4 = UnityEngine_TextCore_Text_FontAsset__ReadFontAssetDefinition
		                    (*(undefined4 *)(iVar3 + 0x4c),param2_00,
		                     Method_System_Collections_Generic_Dictionary_uint__List_GameEventData___ContainsKey__
		                    );
		  if (iVar4 != 0) {
		    param2_01 = (ulonglong)param2_00;
		    Gameplay_GameEvents_Model_GameEventsModel__GetEvent
		              (*(undefined4 *)(iVar3 + 0x28),param2_01,
		               Method_System_Collections_Generic_Dictionary_ulong__GameEventData__Remove__);
		    uVar2 = (undefined4)(param2_01 >> 0x20);
		  }
		  uVar5 = Gameplay_GameEvents_Control_GameEventsController__EventProcessCompleteCoroutine
		                    (param1,param1);
		  *(undefined4 *)(param2 + 0x30) = 0;
		  *(undefined4 *)(param2 + 0x1c) = uVar5;
		  uVar1 = CONCAT44(uVar2,*(undefined4 *)(*param1 + 0x104));
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(param1,uVar1);
		  uVar2 = (undefined4)((ulonglong)uVar1 >> 0x20);
		  iVar3 = UnityEngine_UIElements_RadioButtonGroup__GetAllRadioButtons
		                    (*(undefined4 *)(iVar3 + 0x48),param2,
		                     Method_System_Collections_Generic_List_GameEventData__IndexOf__);
		  if (iVar3 == -1) {
		    if (DAT_ram_00a57518 == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&
		                 Gameplay_GameEvents_Control_GameEventsController__EventProcessCompleteCoroutine_d__11_TypeInfo
		                );
		      DAT_ram_00a57518 = '\x01';
		    }
		    iVar3 = unnamed_function_1417
		                      (
		                      Gameplay_GameEvents_Control_GameEventsController__EventProcessCompleteCoroutine_d__11_TypeInfo
		                      );
		    *(int *)(iVar3 + 0x14) = param2;
		    *(int **)(iVar3 + 0x10) = param1;
		    *(undefined4 *)(iVar3 + 8) = 0;
		    Utils_CoroutineSource__GetMono(iVar3,0);
		  }
		  else {
		    uVar1 = CONCAT44(uVar2,*(undefined4 *)(*param1 + 0x104));
		    iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(param1,uVar1);
		    uVar2 = (undefined4)((ulonglong)uVar1 >> 0x20);
		    UnityEngine_TextCore_Glyph__set_atlasIndex
		              (*(undefined4 *)(iVar4 + 0x48),iVar3,
		               Method_System_Collections_Generic_List_GameEventData__RemoveAt__);
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,CONCAT44(uVar2,*(undefined4 *)(*param1 + 0x114)));
		    iVar3 = *(int *)(iVar3 + 0x2c);
		    (**(code **)((ulonglong)*(uint *)(iVar3 + 0xc) * 4))
		              (*(undefined4 *)(iVar3 + 0x20),*(undefined4 *)(iVar3 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002F4E RID: 12110 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F4E")]
		[Address(RVA = "0x7FB6", Offset = "0x7FB6", VA = "0x7FB6")]
		public void Read(GameEventData evt)
		{
		/* --- GHIDRA: Read ---
		void Gameplay_GameEvents_Control_GameEventsController__Read
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined8 local_3c;
		  undefined8 local_34;
		  undefined4 local_2c;
		  undefined8 local_28;
		  undefined8 local_20;
		  undefined4 local_18;
		  undefined4 local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a57529 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Runtime_CompilerServices_AsyncVoidMethodBuilder_Start_GameEventsController__RequestOpenListView_d__39___
		              );
		    DAT_ram_00a57529 = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  System_Linq_Enumerable__ToDictionary_KeyValuePair_object__object___object__object_(&local_3c,0);
		  local_20 = local_34;
		  local_2c = 0xffffffff;
		  local_28 = local_3c;
		  local_18 = param1;
		  local_14 = param2;
		  System_Runtime_CompilerServices_AsyncVoidMethodBuilder__Start_FtpWebRequest__CreateConnectionAsync_d__86_
		            (&local_28,&local_2c,
		             Method_System_Runtime_CompilerServices_AsyncVoidMethodBuilder_Start_GameEventsController__RequestOpenListView_d__39___
		            );
		  return;
		}
		*/

		}

		// Token: 0x06002F4F RID: 12111 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F4F")]
		[Address(RVA = "0x7FB7", Offset = "0x7FB7", VA = "0x7FB7")]
		public void RequestOpenListView(EventCategoriesDic category)
		{
		/* --- GHIDRA: RequestOpenListView ---
		void Gameplay_GameEvents_Control_GameEventsController__RequestOpenListView
		               (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  int iVar3;
		  int param2_00;
		  int param2_01;
		  undefined4 *puVar4;
		  undefined4 *param2_02;
		  int *piVar5;
		  uint *puVar6;
		  int *piVar7;
		  double dVar8;
		  uint uVar9;
		  int iVar10;
		  int local_1c;
		  int local_18;
		  undefined4 local_14;
		  undefined4 local_10;
		  undefined4 local_c;
		  undefined4 local_8;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a5752a == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_GameEvents_Model_Tags_EventAssetsTag_45_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_GameEvents_Model_Tags_EventURLBannerTag_43_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_GameEvents_Model_GameEventData_GameEventBackground_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_AbstractTag__get_Item__);
		    Mono_Security_ASN1__get_Item(&Gameplay_GameEvents_Model_Tags_OptionTag_41_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_GameEvents_Model_Tags_PromotionTag_38_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Google_Protobuf_Collections_RepeatedField_uint__IndexOf__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_string__get_Item__);
		    DAT_ram_00a5752a = '\x01';
		  }
		  local_4 = 0;
		  local_8 = 0;
		  local_c = 0;
		  local_10 = 0;
		  local_14 = 0;
		  uVar1 = unnamed_function_1417
		                    (Gameplay_GameEvents_Model_GameEventData_GameEventBackground_TypeInfo);
		  *(undefined4 *)(param1 + 0x10) = uVar1;
		  iVar2 = func_ii_7703(*(undefined4 *)(*(int *)(param1 + 0x20) + 0x1c),0x2b,
		                       Method_Google_Protobuf_Collections_RepeatedField_uint__IndexOf__);
		  iVar3 = func_ii_7703(*(undefined4 *)(*(int *)(param1 + 0x20) + 0x1c),0x2d,
		                       Method_Google_Protobuf_Collections_RepeatedField_uint__IndexOf__);
		  param2_00 = func_ii_7703(*(undefined4 *)(*(int *)(param1 + 0x20) + 0x1c),0x26,
		                           Method_Google_Protobuf_Collections_RepeatedField_uint__IndexOf__);
		  param2_01 = func_ii_7703(*(undefined4 *)(*(int *)(param1 + 0x20) + 0x1c),0x29,
		                           Method_Google_Protobuf_Collections_RepeatedField_uint__IndexOf__);
		  if (iVar2 != -1) {
		    piVar5 = (int *)System_Linq_Enumerable__ToList_object_
		                              (*(undefined4 *)(param1 + 0x2c),iVar2,
		                               Method_System_Collections_Generic_List_AbstractTag__get_Item__);
		    if (piVar5 != (int *)0x0) {
		      if (((uint)*(byte *)(*piVar5 + 0xb8) <
		           (uint)*(byte *)(Gameplay_GameEvents_Model_Tags_EventURLBannerTag_43_TypeInfo + 0xb8)) ||
		         (*(int *)(*(int *)(*piVar5 + 100) +
		                   (uint)*(byte *)(Gameplay_GameEvents_Model_Tags_EventURLBannerTag_43_TypeInfo +
		                                  0xb8) * 4 + -4) !=
		          Gameplay_GameEvents_Model_Tags_EventURLBannerTag_43_TypeInfo)) {
		        System_Activator__CreateInstance
		                  (piVar5,Gameplay_GameEvents_Model_Tags_EventURLBannerTag_43_TypeInfo);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    iVar2 = *(int *)(param1 + 0x10);
		    if (ABS(*(double *)(piVar5[5] + 0x10)) < 2147483648.0) {
		      iVar10 = (int)*(double *)(piVar5[5] + 0x10);
		    }
		    else {
		      iVar10 = -0x80000000;
		    }
		    uVar1 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                      (*(undefined4 *)(*(int *)(param1 + 0x24) + 0x38),iVar10 + -1,
		                       Method_Google_Protobuf_Collections_RepeatedField_string__get_Item__);
		    *(undefined4 *)(iVar2 + 0xc) = uVar1;
		    iVar2 = *(int *)(param1 + 0x10);
		    if (ABS(*(double *)(piVar5[5] + 0x18)) < 2147483648.0) {
		      iVar10 = (int)*(double *)(piVar5[5] + 0x18);
		    }
		    else {
		      iVar10 = -0x80000000;
		    }
		    uVar1 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                      (*(undefined4 *)(*(int *)(param1 + 0x24) + 0x38),iVar10 + -1,
		                       Method_Google_Protobuf_Collections_RepeatedField_string__get_Item__);
		    *(undefined4 *)(iVar2 + 8) = uVar1;
		  }
		  if (iVar3 != -1) {
		    piVar5 = (int *)System_Linq_Enumerable__ToList_object_
		                              (*(undefined4 *)(param1 + 0x2c),iVar3,
		                               Method_System_Collections_Generic_List_AbstractTag__get_Item__);
		    if (piVar5 != (int *)0x0) {
		      if (((uint)*(byte *)(*piVar5 + 0xb8) <
		           (uint)*(byte *)(Gameplay_GameEvents_Model_Tags_EventAssetsTag_45_TypeInfo + 0xb8)) ||
		         (*(int *)(*(int *)(*piVar5 + 100) +
		                   (uint)*(byte *)(Gameplay_GameEvents_Model_Tags_EventAssetsTag_45_TypeInfo + 0xb8)
		                   * 4 + -4) != Gameplay_GameEvents_Model_Tags_EventAssetsTag_45_TypeInfo)) {
		        System_Activator__CreateInstance
		                  (piVar5,Gameplay_GameEvents_Model_Tags_EventAssetsTag_45_TypeInfo);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    iVar2 = *(int *)(param1 + 0x10);
		    DAT_ram_009d3e38 = 0;
		    if (ABS(*(double *)(piVar5[5] + 0x10)) < 2147483648.0) {
		      iVar3 = (int)*(double *)(piVar5[5] + 0x10);
		    }
		    else {
		      iVar3 = -0x80000000;
		    }
		    uVar1 = import::env::invoke_iiii
		                      (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x2e0,
		                       *(undefined4 *)(*(int *)(param1 + 0x24) + 0x38),iVar3 + -1,
		                       Method_Google_Protobuf_Collections_RepeatedField_string__get_Item__);
		    iVar3 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar3 == 1) {
		      uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    }
		    else {
		      *(undefined4 *)(iVar2 + 0x14) = uVar1;
		      iVar2 = *(int *)(param1 + 0x10);
		      DAT_ram_009d3e38 = 0;
		      if (ABS(*(double *)(piVar5[5] + 0x18)) < 2147483648.0) {
		        iVar3 = (int)*(double *)(piVar5[5] + 0x18);
		      }
		      else {
		        iVar3 = -0x80000000;
		      }
		      uVar1 = import::env::invoke_iiii
		                        (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x2e0,
		                         *(undefined4 *)(*(int *)(param1 + 0x24) + 0x38),iVar3 + -1,
		                         Method_Google_Protobuf_Collections_RepeatedField_string__get_Item__);
		      iVar3 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar3 != 1) {
		        *(undefined4 *)(iVar2 + 0x10) = uVar1;
		        goto code_r0x80da244d;
		      }
		      uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    }
		    iVar2 = global_1;
		    iVar3 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		    if (iVar2 != iVar3) goto code_r0x80da2428;
		    puVar4 = (undefined4 *)import::env::__cxa_begin_catch(uVar1);
		    DAT_ram_009d3e38 = 0;
		    uVar1 = import::env::invoke_ii
		                      (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1c,
		                       &System_Exception_TypeInfo);
		    if (DAT_ram_009d3e38 != 1) {
		      DAT_ram_009d3e38 = 0;
		      iVar3 = import::env::invoke_iii
		                        (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1d,uVar1,
		                         *(undefined4 *)*puVar4);
		      iVar2 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar2 != 1) {
		        if (iVar3 != 0) {
		          piVar7 = (int *)*puVar4;
		          import::env::__cxa_end_catch();
		          uVar1 = unnamed_function_2232(&object___TypeInfo);
		          iVar2 = Mono_Security_ASN1Convert__ToOid(uVar1,4);
		          if (ABS(*(double *)(piVar5[5] + 0x10)) < 2147483648.0) {
		            local_18 = (int)*(double *)(piVar5[5] + 0x10);
		          }
		          else {
		            local_18 = -0x80000000;
		          }
		          local_18 = local_18 + -1;
		          uVar1 = func_ii_1081(DAT_ram_00a66954,&local_18);
		          func_ii_4505(iVar2,uVar1);
		          *(undefined4 *)(iVar2 + 0x10) = uVar1;
		          if (ABS(*(double *)(piVar5[5] + 0x18)) < 2147483648.0) {
		            local_1c = (int)*(double *)(piVar5[5] + 0x18);
		          }
		          else {
		            local_1c = -0x80000000;
		          }
		          local_1c = local_1c + -1;
		          uVar1 = func_ii_1081(DAT_ram_00a66954,&local_1c);
		          func_ii_4505(iVar2,uVar1);
		          *(undefined4 *)(iVar2 + 0x14) = uVar1;
		          uVar1 = *(undefined4 *)(param1 + 0x24);
		          func_ii_4505(iVar2,uVar1);
		          *(undefined4 *)(iVar2 + 0x18) = uVar1;
		          iVar3 = *piVar7;
		          uVar1 = (**(code **)((ulonglong)*(uint *)(iVar3 + 0xe8) * 4))
		                            (piVar7,*(undefined4 *)(iVar3 + 0xec));
		          func_ii_4505(iVar2,uVar1);
		          *(undefined4 *)(iVar2 + 0x1c) = uVar1;
		          uVar1 = unnamed_function_2232(&StringLiteral_8481);
		          uVar1 = UnityEngine_InputSystem_Utilities_TypeHelpers__GetNiceTypeName(uVar1,iVar2,0);
		          iVar2 = unnamed_function_2232(&OKG_Logs_Debug_TypeInfo);
		          if (*(int *)(iVar2 + 0x74) == 0) {
		            func_ii_306000(iVar2);
		          }
		          func_ii_7830(uVar1,0);
		          goto code_r0x80da244d;
		        }
		        param2_02 = (undefined4 *)unnamed_function_951(4);
		        *param2_02 = *puVar4;
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1e,param2_02,
		                   &DAT_ram_0072c9c8,0);
		        if (DAT_ram_009d3e38 != 1) goto code_r0x80da2437;
		      }
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar1 = import::env::__cxa_find_matching_catch_2();
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_v(0x123);
		    iVar2 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar2 == 1) {
		      import::env::__cxa_find_matching_catch_3(0);
		      unnamed_function_937();
		code_r0x80da2437:
		      do {
		        halt_trap();
		      } while( true );
		    }
		code_r0x80da2428:
		    import::env::__resumeException(uVar1);
		    do {
		      halt_trap();
		    } while( true );
		  }
		code_r0x80da244d:
		  if (param2_00 != -1) {
		    piVar5 = (int *)System_Linq_Enumerable__ToList_object_
		                              (*(undefined4 *)(param1 + 0x2c),param2_00,
		                               Method_System_Collections_Generic_List_AbstractTag__get_Item__);
		    if (piVar5 != (int *)0x0) {
		      if (((uint)*(byte *)(*piVar5 + 0xb8) <
		           (uint)*(byte *)(Gameplay_GameEvents_Model_Tags_PromotionTag_38_TypeInfo + 0xb8)) ||
		         (*(int *)(*(int *)(*piVar5 + 100) +
		                   (uint)*(byte *)(Gameplay_GameEvents_Model_Tags_PromotionTag_38_TypeInfo + 0xb8) *
		                   4 + -4) != Gameplay_GameEvents_Model_Tags_PromotionTag_38_TypeInfo)) {
		        System_Activator__CreateInstance
		                  (piVar5,Gameplay_GameEvents_Model_Tags_PromotionTag_38_TypeInfo);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    uVar9 = 0;
		    piVar7 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar2 = *piVar7;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar9 * 8)) {
		          puVar6 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar9 * 8 + 4) * 8 + iVar2 + 0x178);
		          goto code_r0x80da2544;
		        }
		        uVar9 = uVar9 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar9);
		    }
		    puVar6 = (uint *)func_ii_1080(piVar7,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80da2544:
		    uVar1 = (**(code **)((ulonglong)*puVar6 * 4))(piVar7,puVar6[1]);
		    uVar1 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar1,0);
		    iVar3 = piVar5[5];
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*piVar5 + 0xe8) * 4))
		                      (piVar5,*(undefined4 *)(*piVar5 + 0xec));
		    dVar8 = *(double *)(iVar3 + iVar2 * 8 + 8);
		    if (dVar8 < 4294967296.0 && 0.0 <= dVar8) {
		      iVar2 = (int)dVar8;
		    }
		    else {
		      iVar2 = 0;
		    }
		    if (ABS(dVar8) < 2147483648.0) {
		      iVar3 = (int)dVar8;
		    }
		    else {
		      iVar3 = -0x80000000;
		    }
		    if (0.0 <= dVar8) {
		      iVar3 = iVar2;
		    }
		    iVar2 = func_ii_7496(uVar1,iVar3,0);
		    if (iVar2 != 0) {
		      iVar3 = *(int *)(param1 + 0x10);
		      uVar1 = Core_Extensions_Dict_ProfessionDicExt__GetDescription(iVar2,0);
		      *(undefined4 *)(iVar3 + 0x14) = uVar1;
		      iVar3 = *(int *)(param1 + 0x10);
		      uVar1 = Core_Extensions_Dict_PromotionsDicExt__GetEventBannerListAssetId(iVar2,0);
		      *(undefined4 *)(iVar3 + 0x10) = uVar1;
		    }
		  }
		  if (param2_01 == -1) goto code_r0x80da2d1e;
		  piVar5 = (int *)System_Linq_Enumerable__ToList_object_
		                            (*(undefined4 *)(param1 + 0x2c),param2_01,
		                             Method_System_Collections_Generic_List_AbstractTag__get_Item__);
		  if (piVar5 != (int *)0x0) {
		    if (((uint)*(byte *)(*piVar5 + 0xb8) <
		         (uint)*(byte *)(Gameplay_GameEvents_Model_Tags_OptionTag_41_TypeInfo + 0xb8)) ||
		       (*(int *)(*(int *)(*piVar5 + 100) +
		                 (uint)*(byte *)(Gameplay_GameEvents_Model_Tags_OptionTag_41_TypeInfo + 0xb8) * 4 +
		                -4) != Gameplay_GameEvents_Model_Tags_OptionTag_41_TypeInfo)) {
		      System_Activator__CreateInstance(piVar5,Gameplay_GameEvents_Model_Tags_OptionTag_41_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  if (ABS(*(double *)(piVar5[5] + 0x10)) < 2147483648.0) {
		    iVar2 = (int)*(double *)(piVar5[5] + 0x10);
		  }
		  else {
		    iVar2 = -0x80000000;
		  }
		  if (iVar2 == 0) {
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    piVar7 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar2 = *piVar7;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      uVar9 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar9 * 8)) {
		          puVar6 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar9 * 8 + 4) * 8 + iVar2 + 0x178);
		          goto code_r0x80da2736;
		        }
		        uVar9 = uVar9 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar9);
		    }
		    puVar6 = (uint *)func_ii_1080(piVar7,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80da2736:
		    uVar1 = (**(code **)((ulonglong)*puVar6 * 4))(piVar7,puVar6[1]);
		    uVar1 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar1,0);
		    dVar8 = *(double *)(piVar5[5] + 0x18);
		    if (dVar8 < 4294967296.0 && 0.0 <= dVar8) {
		      iVar2 = (int)dVar8;
		    }
		    else {
		      iVar2 = 0;
		    }
		    if (ABS(dVar8) < 2147483648.0) {
		      iVar3 = (int)dVar8;
		    }
		    else {
		      iVar3 = -0x80000000;
		    }
		    if (0.0 <= dVar8) {
		      iVar3 = iVar2;
		    }
		    iVar2 = Core_Extensions_Dict_DictExt__GetOptionTypesDic(uVar1,iVar3,&local_4,0);
		    if (iVar2 == 0) goto code_r0x80da2d1e;
		    iVar2 = *(int *)(param1 + 0x10);
		    uVar1 = Core_Extensions_Dict_DailyQuestsDicExt__GetBackground(local_4,0);
		    *(undefined4 *)(iVar2 + 0x14) = uVar1;
		    iVar2 = *(int *)(param1 + 0x10);
		    uVar1 = Core_Extensions_Dict_DiamondOptionsDicExt__GetEventBannerListAssetId(local_4,0);
		  }
		  else {
		    if ((iVar2 == 1) || (iVar2 == 2)) goto code_r0x80da2d1e;
		    if (iVar2 == 3) {
		      if (DAT_ram_00a6456f == '\0') {
		        Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		        DAT_ram_00a6456f = '\x01';
		      }
		      piVar7 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		      iVar2 = *piVar7;
		      if (*(ushort *)(iVar2 + 0xb6) != 0) {
		        uVar9 = 0;
		        do {
		          if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar9 * 8)) {
		            puVar6 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar9 * 8 + 4) * 8 + iVar2 + 0x178);
		            goto code_r0x80da2c62;
		          }
		          uVar9 = uVar9 + 1;
		        } while (*(ushort *)(iVar2 + 0xb6) != uVar9);
		      }
		      puVar6 = (uint *)func_ii_1080(piVar7,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80da2c62:
		      uVar1 = (**(code **)((ulonglong)*puVar6 * 4))(piVar7,puVar6[1]);
		      uVar1 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar1,0);
		      dVar8 = *(double *)(piVar5[5] + 0x18);
		      if (dVar8 < 4294967296.0 && 0.0 <= dVar8) {
		        iVar2 = (int)dVar8;
		      }
		      else {
		        iVar2 = 0;
		      }
		      if (ABS(dVar8) < 2147483648.0) {
		        iVar3 = (int)dVar8;
		      }
		      else {
		        iVar3 = -0x80000000;
		      }
		      if (0.0 <= dVar8) {
		        iVar3 = iVar2;
		      }
		      iVar2 = Core_Extensions_Dict_DictExt__TryGetColossusFragmentsOptionsDic
		                        (uVar1,iVar3,&local_14,0);
		      if (iVar2 == 0) goto code_r0x80da2d1e;
		      iVar2 = *(int *)(param1 + 0x10);
		      uVar1 = Core_Extensions_Dict_ArtikulMenuActionDicExt__GetRequirementMessage(local_14,0);
		      *(undefined4 *)(iVar2 + 0x14) = uVar1;
		      iVar2 = *(int *)(param1 + 0x10);
		      uVar1 = Core_Extensions_Dict_ArtikulOptionsDicExt__GetEventBannerListAssetId(local_14,0);
		    }
		    else if (iVar2 == 4) {
		      if (DAT_ram_00a6456f == '\0') {
		        Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		        DAT_ram_00a6456f = '\x01';
		      }
		      piVar7 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		      iVar2 = *piVar7;
		      if (*(ushort *)(iVar2 + 0xb6) != 0) {
		        uVar9 = 0;
		        do {
		          if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar9 * 8)) {
		            puVar6 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar9 * 8 + 4) * 8 + iVar2 + 0x178);
		            goto code_r0x80da2881;
		          }
		          uVar9 = uVar9 + 1;
		        } while (*(ushort *)(iVar2 + 0xb6) != uVar9);
		      }
		      puVar6 = (uint *)func_ii_1080(piVar7,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80da2881:
		      uVar1 = (**(code **)((ulonglong)*puVar6 * 4))(piVar7,puVar6[1]);
		      uVar1 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar1,0);
		      dVar8 = *(double *)(piVar5[5] + 0x18);
		      if (dVar8 < 4294967296.0 && 0.0 <= dVar8) {
		        iVar2 = (int)dVar8;
		      }
		      else {
		        iVar2 = 0;
		      }
		      if (ABS(dVar8) < 2147483648.0) {
		        iVar3 = (int)dVar8;
		      }
		      else {
		        iVar3 = -0x80000000;
		      }
		      if (0.0 <= dVar8) {
		        iVar3 = iVar2;
		      }
		      iVar2 = Core_Extensions_Dict_DictExt__TryGetDiamondOptionsDic(uVar1,iVar3,&local_8,0);
		      if (iVar2 == 0) goto code_r0x80da2d1e;
		      iVar2 = *(int *)(param1 + 0x10);
		      uVar1 = Core_Extensions_Dict_CraftSchemeDicExt__GetDescription(local_8,0);
		      *(undefined4 *)(iVar2 + 0x14) = uVar1;
		      iVar2 = *(int *)(param1 + 0x10);
		      uVar1 = Core_Extensions_Dict_CrystalEnergyOptionsDicExt__GetEventBannerListAssetId(local_8,0);
		    }
		    else {
		      if (iVar2 == 5) goto code_r0x80da2d1e;
		      if (iVar2 == 6) {
		        if (DAT_ram_00a6456f == '\0') {
		          Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		          DAT_ram_00a6456f = '\x01';
		        }
		        piVar7 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		        iVar2 = *piVar7;
		        if (*(ushort *)(iVar2 + 0xb6) != 0) {
		          uVar9 = 0;
		          do {
		            if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar9 * 8)) {
		              puVar6 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar9 * 8 + 4) * 8 + iVar2 + 0x178
		                               );
		              goto code_r0x80da29cc;
		            }
		            uVar9 = uVar9 + 1;
		          } while (*(ushort *)(iVar2 + 0xb6) != uVar9);
		        }
		        puVar6 = (uint *)func_ii_1080(piVar7,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80da29cc:
		        uVar1 = (**(code **)((ulonglong)*puVar6 * 4))(piVar7,puVar6[1]);
		        uVar1 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar1,0);
		        dVar8 = *(double *)(piVar5[5] + 0x18);
		        if (dVar8 < 4294967296.0 && 0.0 <= dVar8) {
		          iVar2 = (int)dVar8;
		        }
		        else {
		          iVar2 = 0;
		        }
		        if (ABS(dVar8) < 2147483648.0) {
		          iVar3 = (int)dVar8;
		        }
		        else {
		          iVar3 = -0x80000000;
		        }
		        if (0.0 <= dVar8) {
		          iVar3 = iVar2;
		        }
		        iVar2 = Core_Extensions_Dict_DictExt__TryGetCrystalEnergyOptionsDic(uVar1,iVar3,&local_c,0);
		        if (iVar2 == 0) goto code_r0x80da2d1e;
		        iVar2 = *(int *)(param1 + 0x10);
		        uVar1 = Core_Extensions_Dict_MonsterDictExt__GetGameEventLibraryDescription(local_c,0);
		        *(undefined4 *)(iVar2 + 0x14) = uVar1;
		        iVar2 = *(int *)(param1 + 0x10);
		        uVar1 = Core_Extensions_Dict_NewResourceOptionsDicExt__GetEventBannerListAssetId(local_c,0);
		      }
		      else {
		        if ((((iVar2 == 7) || (iVar2 == 8)) || (iVar2 == 9)) || (iVar2 != 10))
		        goto code_r0x80da2d1e;
		        if (DAT_ram_00a6456f == '\0') {
		          Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		          DAT_ram_00a6456f = '\x01';
		        }
		        piVar7 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		        iVar2 = *piVar7;
		        if (*(ushort *)(iVar2 + 0xb6) != 0) {
		          uVar9 = 0;
		          do {
		            if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar9 * 8)) {
		              puVar6 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar9 * 8 + 4) * 8 + iVar2 + 0x178
		                               );
		              goto code_r0x80da2b17;
		            }
		            uVar9 = uVar9 + 1;
		          } while (*(ushort *)(iVar2 + 0xb6) != uVar9);
		        }
		        puVar6 = (uint *)func_ii_1080(piVar7,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80da2b17:
		        uVar1 = (**(code **)((ulonglong)*puVar6 * 4))(piVar7,puVar6[1]);
		        uVar1 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar1,0);
		        dVar8 = *(double *)(piVar5[5] + 0x18);
		        if (dVar8 < 4294967296.0 && 0.0 <= dVar8) {
		          iVar2 = (int)dVar8;
		        }
		        else {
		          iVar2 = 0;
		        }
		        if (ABS(dVar8) < 2147483648.0) {
		          iVar3 = (int)dVar8;
		        }
		        else {
		          iVar3 = -0x80000000;
		        }
		        if (0.0 <= dVar8) {
		          iVar3 = iVar2;
		        }
		        iVar2 = Core_Extensions_Dict_DictExt__TryGetNewResourceOptionsDic(uVar1,iVar3,&local_10,0);
		        if (iVar2 == 0) goto code_r0x80da2d1e;
		        iVar2 = *(int *)(param1 + 0x10);
		        uVar1 = Core_Extensions_Dict_CraftSchemeDicExt__GetDescription(local_10,0);
		        *(undefined4 *)(iVar2 + 0x14) = uVar1;
		        iVar2 = *(int *)(param1 + 0x10);
		        uVar1 = Core_Extensions_Dict_ColossusFragmentsOptionsDicExt__GetEventBannerListAssetId
		                          (local_10,0);
		      }
		    }
		  }
		  *(undefined4 *)(iVar2 + 0x10) = uVar1;
		code_r0x80da2d1e:
		  iVar3 = *(int *)(param1 + 0x10);
		  iVar2 = Newtonsoft_Json_Serialization_JsonSerializerInternalReader__ShouldDeserialize
		                    (*(undefined4 *)(iVar3 + 8),0);
		  if (((iVar2 != 0) &&
		      (iVar2 = Newtonsoft_Json_Serialization_JsonSerializerInternalReader__ShouldDeserialize
		                         (*(undefined4 *)(iVar3 + 0xc),0), iVar2 != 0)) &&
		     ((iVar2 = Newtonsoft_Json_Serialization_JsonSerializerInternalReader__ShouldDeserialize
		                         (*(undefined4 *)(iVar3 + 0x10),0), iVar2 != 0 &&
		      (iVar2 = Newtonsoft_Json_Serialization_JsonSerializerInternalReader__ShouldDeserialize
		                         (*(undefined4 *)(iVar3 + 0x14),0), iVar2 != 0)))) {
		    iVar2 = *(int *)(param1 + 0x10);
		    uVar1 = Core_Extensions_Dict_EventTypeDicExt__GetSmallBannerAssetId
		                      (*(undefined4 *)(param1 + 0x20),0);
		    *(undefined4 *)(iVar2 + 0x10) = uVar1;
		    iVar2 = *(int *)(param1 + 0x10);
		    uVar1 = Core_Extensions_Dict_EventTypeDicExt__GetSoundAssetIdShowInReadView
		                      (*(undefined4 *)(param1 + 0x20),0);
		    *(undefined4 *)(iVar2 + 0x14) = uVar1;
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002F50 RID: 12112 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F50")]
		[Address(RVA = "0x7FB8", Offset = "0x7FB8", VA = "0x7FB8")]
		public static void FillGameEventBackground(GameEventData evt)
		{
		/* --- GHIDRA: FillGameEventBackground ---
		void Gameplay_GameEvents_Control_GameEventsController__FillGameEventBackground(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5752b == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_GameEvents_Control_GameEventsController___c_TypeInfo);
		    DAT_ram_00a5752b = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Gameplay_GameEvents_Control_GameEventsController___c_TypeInfo);
		  **(undefined4 **)(Gameplay_GameEvents_Control_GameEventsController___c_TypeInfo + 0x5c) = uVar1;
		  return;
		}
		*/

		}

		// Token: 0x040019BD RID: 6589
		[Token(Token = "0x40019BD")]
		[FieldOffset(Offset = "0x18")]
		private EventsService _service;

		// Token: 0x040019BE RID: 6590
		[Token(Token = "0x40019BE")]
		[FieldOffset(Offset = "0x1C")]
		private DelayedCall _expirationScheduler;
	}
}
