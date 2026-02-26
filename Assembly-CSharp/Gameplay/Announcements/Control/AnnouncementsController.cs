using System;
using System.Collections.Generic;
using CloudsFly.Movement;
using DG.Tweening;
using Gameplay.Announcements.Model;
using Google.Protobuf;
using Il2CppDummyDll;
using MVC;
using Protocol.Announcements;
using ServicesNamespace;
using Utils;

namespace Gameplay.Announcements.Control
{
	// Token: 0x02000DA7 RID: 3495
	[Token(Token = "0x2000DA7")]
	public class AnnouncementsController : AbstractController<AnnouncementsModel, AnnouncementsEvents>
	{
		// Token: 0x06005567 RID: 21863 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005567")]
		[Address(RVA = "0xA307", Offset = "0xA307", VA = "0xA307", Slot = "5")]
		public override void Dispose()
		{
		/* --- GHIDRA: <HandleRun>b__6_0 ---
		void Gameplay_Announcements_Control_AnnouncementsController___HandleRun_b__6_0
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5)
		
		{
		  if (DAT_ram_00a58839 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_AnnouncementsModel__AnnouncementsEvents__AnnouncementsController__AnnouncementsView___ctor__
		              );
		    DAT_ram_00a58839 = '\x01';
		  }
		  Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		            (param1,param2,param3,param4,
		             Method_MVC_AbstractViewMediator_AnnouncementsModel__AnnouncementsEvents__AnnouncementsController__AnnouncementsView___ctor__
		            );
		  return;
		}
		*/

		/* --- GHIDRA: Dispose ---
		void Gameplay_Announcements_Control_AnnouncementsController__Dispose
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  if (DAT_ram_00a5882f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_MVC_AbstractController_AnnouncementsModel__AnnouncementsEvents___ctor__);
		    DAT_ram_00a5882f = '\x01';
		  }
		  Gameplay_Combat_AbstractCombat_object__object__object__object__object___set_User
		            (param1,param3,param4,
		             Method_MVC_AbstractController_AnnouncementsModel__AnnouncementsEvents___ctor__);
		  *(undefined4 *)(param1 + 0x18) = param2;
		  return;
		}
		*/

		}

		// Token: 0x06005568 RID: 21864 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005568")]
		[Address(RVA = "0xA308", Offset = "0xA308", VA = "0xA308")]
		public AnnouncementsController(AnnouncementsService service, AnnouncementsModel model, AnnouncementsEvents events)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Announcements_Control_AnnouncementsController___ctor(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a58830 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_WorldMovementTypes__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoGetListCmd_Types_Ans__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Announcements_Control_AnnouncementsController_HandleThereIsNewAnnouncementsEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Announcements_Control_AnnouncementsController_WorldMoveCompleteEvent__
		              );
		    DAT_ram_00a58830 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  *(undefined4 *)(*(int *)(iVar1 + 0x20) + 0x10) = 0;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  iVar4 = *(int *)(iVar1 + 0x24);
		  param1_00 = *(undefined4 *)(iVar4 + 0xc);
		  uVar2 = unnamed_function_1417(System_Action_WorldMovementTypes__TypeInfo);
		  System_Action_int___Invoke
		            (uVar2,param1,
		             Method_Gameplay_Announcements_Control_AnnouncementsController_WorldMoveCompleteEvent__,
		             0);
		  iVar1 = func_ii_7048(param1_00,uVar2,0);
		  uVar2 = System_Action_WorldMovementTypes__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0xc) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_WorldMovementTypes__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0xc) = iVar3;
		    uVar2 = System_Action_WorldMovementTypes__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_WorldMovementTypes__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = param1[6];
		  uVar2 = unnamed_function_1417(System_Action_ProtoGetListCmd_Types_Ans__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Gameplay_Announcements_Control_AnnouncementsController_HandleThereIsNewAnnouncementsEvent__
		             ,0);
		  ServicesNamespace_AnnouncementsService__add_ThereIsNewAnnouncementsEvent(iVar1,uVar2,0);
		  return;
		}
		*/

		}

		// Token: 0x06005569 RID: 21865 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005569")]
		[Address(RVA = "0xA309", Offset = "0xA309", VA = "0xA309", Slot = "6")]
		protected override void HandleStop()
		{
		/* --- GHIDRA: HandleStop ---
		void Gameplay_Announcements_Control_AnnouncementsController__HandleStop
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  undefined4 uVar4;
		  int iVar5;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a58831 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_WorldMovementTypes__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoGetListCmd_Types_Ans__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Announcements_Control_AnnouncementsController_HandleThereIsNewAnnouncementsEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Announcements_Control_AnnouncementsController_Notify__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Announcements_Control_AnnouncementsController__HandleRun_b__6_0__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Announcements_Control_AnnouncementsController_WorldMoveCompleteEvent__
		              );
		    Mono_Security_ASN1__get_Item(&System_Func_bool____TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Func_bool__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_PopupScheduleManager_ScheduleOpenWindow_AnnouncementsWindow___
		              );
		    DAT_ram_00a58831 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  iVar1 = *(int *)(iVar1 + 0x20);
		  uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar2,param1,Method_Gameplay_Announcements_Control_AnnouncementsController_Notify__,0);
		  *(undefined4 *)(iVar1 + 0x10) = uVar2;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar4 = *(undefined4 *)(iVar1 + 0x18);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  local_4 = *(undefined4 *)(iVar1 + 0x20);
		  iVar1 = Mono_Security_ASN1Convert__ToOid(System_Func_bool____TypeInfo,1);
		  uVar2 = unnamed_function_1417(System_Func_bool__TypeInfo);
		  System_Func_BackgroundSize___Invoke
		            (uVar2,param1,
		             Method_Gameplay_Announcements_Control_AnnouncementsController__HandleRun_b__6_0__,0);
		  *(undefined4 *)(iVar1 + 0x10) = uVar2;
		  UI_Windows_PopupController__HasOpenWindow_object_
		            (uVar4,&local_4,iVar1,
		             Method_Core_Gameplay_Managers_PopupScheduleManager_ScheduleOpenWindow_AnnouncementsWindow___
		            );
		  iVar1 = param1[6];
		  uVar2 = unnamed_function_1417(System_Action_ProtoGetListCmd_Types_Ans__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Gameplay_Announcements_Control_AnnouncementsController_HandleThereIsNewAnnouncementsEvent__
		             ,0);
		  ServicesNamespace_AnnouncementsService__get_ServiceId(iVar1,uVar2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  iVar5 = *(int *)(iVar1 + 0x24);
		  uVar4 = *(undefined4 *)(iVar5 + 0xc);
		  uVar2 = unnamed_function_1417(System_Action_WorldMovementTypes__TypeInfo);
		  System_Action_int___Invoke
		            (uVar2,param1,
		             Method_Gameplay_Announcements_Control_AnnouncementsController_WorldMoveCompleteEvent__,
		             0);
		  iVar1 = UnityEngine_UI_Image__set_sprite(uVar4,uVar2,0);
		  uVar2 = System_Action_WorldMovementTypes__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar5 + 0xc) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_WorldMovementTypes__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar5 + 0xc) = iVar3;
		    uVar2 = System_Action_WorldMovementTypes__TypeInfo;
		    iVar5 = func_ii_1082(iVar1,System_Action_WorldMovementTypes__TypeInfo);
		    if (iVar5 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  Gameplay_Announcements_Control_AnnouncementsController__OpenNextWindow(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x0600556A RID: 21866 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600556A")]
		[Address(RVA = "0xA30A", Offset = "0xA30A", VA = "0xA30A", Slot = "7")]
		protected override void HandleRun()
		{
		/* --- GHIDRA: HandleRun ---
		void Gameplay_Announcements_Control_AnnouncementsController__HandleRun
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  
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

		// Token: 0x0600556B RID: 21867 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600556B")]
		[Address(RVA = "0xA30B", Offset = "0xA30B", VA = "0xA30B")]
		private void ValidateInit()
		{
		/* --- GHIDRA: ValidateInit ---
		void Gameplay_Announcements_Control_AnnouncementsController__ValidateInit
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a58832 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_WorldMovementTypes__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Announcements_Control_AnnouncementsController_OpenNextWindow__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Announcements_Control_AnnouncementsController_WorldMoveCompleteEvent__
		              );
		    Mono_Security_ASN1__get_Item(&DG_Tweening_TweenCallback_TypeInfo);
		    DAT_ram_00a58832 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  iVar4 = *(int *)(iVar1 + 0x24);
		  param1_00 = *(undefined4 *)(iVar4 + 0xc);
		  uVar2 = unnamed_function_1417(System_Action_WorldMovementTypes__TypeInfo);
		  System_Action_int___Invoke
		            (uVar2,param1,
		             Method_Gameplay_Announcements_Control_AnnouncementsController_WorldMoveCompleteEvent__,
		             0);
		  iVar1 = func_ii_7048(param1_00,uVar2,0);
		  uVar2 = System_Action_WorldMovementTypes__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0xc) = 0;
		  }
		  else {
		    iVar3 = func_ii_1082(iVar1,System_Action_WorldMovementTypes__TypeInfo);
		    if (iVar3 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0xc) = iVar3;
		    uVar2 = System_Action_WorldMovementTypes__TypeInfo;
		    iVar4 = func_ii_1082(iVar1,System_Action_WorldMovementTypes__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar1,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  if (param1[7] != 0) {
		    func_ii_7891(param1[7],0,0);
		  }
		  uVar2 = unnamed_function_1417(DG_Tweening_TweenCallback_TypeInfo);
		  DG_Tweening_Color2__op_Multiply
		            (uVar2,param1,
		             Method_Gameplay_Announcements_Control_AnnouncementsController_OpenNextWindow__,0);
		  iVar1 = DG_Tweening_DOVirtual__EasedValue(1.0,uVar2,1,0);
		  param1[7] = iVar1;
		  return;
		}
		*/

		}

		// Token: 0x0600556C RID: 21868 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600556C")]
		[Address(RVA = "0xA30C", Offset = "0xA30C", VA = "0xA30C")]
		private void WorldMoveCompleteEvent(WorldMovementTypes type)
		{
		/* --- GHIDRA: WorldMoveCompleteEvent ---
		void Gameplay_Announcements_Control_AnnouncementsController__WorldMoveCompleteEvent
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  iVar1 = Core_Gameplay_Managers_PopupScheduleManager___ctor(*(undefined4 *)(iVar1 + 0x18),0);
		  if (iVar1 != 0) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    Core_Gameplay_Managers_PopupScheduleManager__UnScheduleOpenWindow
		              (*(undefined4 *)(iVar1 + 0x18),1,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600556D RID: 21869 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600556D")]
		[Address(RVA = "0xA30D", Offset = "0xA30D", VA = "0xA30D")]
		private void OpenNextWindow()
		{
		/* --- GHIDRA: OpenNextWindow ---
		void Gameplay_Announcements_Control_AnnouncementsController__OpenNextWindow
		               (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a58833 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Announcements_Control_AnnouncementsController_HandleGetListService__
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    DAT_ram_00a58833 = '\x01';
		  }
		  uVar1 = ServicesNamespace_AnnouncementsService__ServerEventHandler
		                    (*(undefined4 *)(param1 + 0x18),0);
		  param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_Announcements_Control_AnnouncementsController_HandleGetListService__,0)
		  ;
		  uVar1 = ServicesNamespace_MainService__GetUserStats
		                    (uVar1,param1_00,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  Utils_OpToken_int__object___AddHandlers(param1,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x0600556E RID: 21870 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600556E")]
		[Address(RVA = "0xA30E", Offset = "0xA30E", VA = "0xA30E")]
		private void RequestList()
		{
		/* --- GHIDRA: RequestList ---
		void Gameplay_Announcements_Control_AnnouncementsController__RequestList
		               (int *param1,undefined8 param2,undefined4 param3)
		
		{
		  undefined8 uVar1;
		  undefined4 uVar3;
		  undefined4 param1_00;
		  int param1_01;
		  int iVar4;
		  undefined4 local_4;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a58834 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Announcements_Control_AnnouncementsController_HandleReadService__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    DAT_ram_00a58834 = '\x01';
		  }
		  uVar1 = param2;
		  uVar3 = ServicesNamespace_AnnouncementsService__GetList(param1[6],param2,0);
		  uVar2 = (undefined4)((ulonglong)uVar1 >> 0x20);
		  param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_Announcements_Control_AnnouncementsController_HandleReadService__,0);
		  uVar3 = ServicesNamespace_MainService__GetUserStats
		                    (uVar3,param1_00,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  Utils_OpToken_int__object___AddHandlers(param1,uVar3,0);
		  param1_01 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,CONCAT44(uVar2,*(undefined4 *)(*param1 + 0x104)));
		  if (DAT_ram_00a5882a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_LinkedList_AnnouncementsData__Remove__);
		    DAT_ram_00a5882a = '\x01';
		  }
		  local_4 = 0;
		  iVar4 = Gameplay_Announcements_Model_AnnouncementsModel__Add(param1_01,param2,&local_4,param1_01);
		  if (iVar4 != 0) {
		    System_Net_WebConnection__StartOperation
		              (*(undefined4 *)(param1_01 + 0xc),local_4,
		               Method_System_Collections_Generic_LinkedList_AnnouncementsData__Remove__);
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600556F RID: 21871 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600556F")]
		[Address(RVA = "0xA30F", Offset = "0xA30F", VA = "0xA30F")]
		private void RequestRead(ulong id)
		{
		/* --- GHIDRA: RequestRead ---
		void Gameplay_Announcements_Control_AnnouncementsController__RequestRead
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  Gameplay_Announcements_Control_AnnouncementsController__HandleGetListService
		            (param1,*(undefined4 *)(param2 + 0xc),param1);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  iVar1 = Core_Gameplay_Managers_PopupScheduleManager___ctor(*(undefined4 *)(iVar1 + 0x18),0);
		  if (iVar1 != 0) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    Core_Gameplay_Managers_PopupScheduleManager__UnScheduleOpenWindow
		              (*(undefined4 *)(iVar1 + 0x18),1,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06005570 RID: 21872 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005570")]
		[Address(RVA = "0xA310", Offset = "0xA310", VA = "0xA310")]
		private void HandleThereIsNewAnnouncementsEvent(ProtoGetListCmd.Types.Ans msg)
		{
		/* --- GHIDRA: HandleThereIsNewAnnouncementsEvent ---
		void Gameplay_Announcements_Control_AnnouncementsController__HandleThereIsNewAnnouncementsEvent
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a58835 == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Announcements_ProtoReadCmd_Types_Ans_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    DAT_ram_00a58835 = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  return;
		}
		*/

		}

		// Token: 0x06005571 RID: 21873 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005571")]
		[Address(RVA = "0xA311", Offset = "0xA311", VA = "0xA311")]
		private void HandleReadService(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: HandleReadService ---
		void Gameplay_Announcements_Control_AnnouncementsController__HandleReadService
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int *param1_00;
		  
		  if (DAT_ram_00a58836 == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Announcements_ProtoGetListCmd_Types_Ans_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    DAT_ram_00a58836 = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  param1_00 = *(int **)(param2 + 0x20);
		  if ((param1_00 != (int *)0x0) &&
		     (Protocol_Announcements_ProtoGetListCmd_Types_Ans_TypeInfo != *param1_00)) {
		    System_Activator__CreateInstance
		              (param1_00,Protocol_Announcements_ProtoGetListCmd_Types_Ans_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  Gameplay_Announcements_Control_AnnouncementsController__HandleGetListService
		            (param1,param1_00[3],param1);
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

		// Token: 0x06005572 RID: 21874 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005572")]
		[Address(RVA = "0xA312", Offset = "0xA312", VA = "0xA312")]
		private void HandleGetListService(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: HandleGetListService ---
		void Gameplay_Announcements_Control_AnnouncementsController__HandleGetListService
		               (int *param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *puVar3;
		  undefined4 *puVar4;
		  undefined4 uVar5;
		  undefined4 param2_00;
		  int iVar6;
		  int iVar7;
		  int *piVar8;
		  int *piVar9;
		  int iVar10;
		  int local_10;
		  int **local_c;
		  undefined4 local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a58837 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerable_Announcement__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerator_Announcement__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_AnnouncementsData__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_AnnouncementsData___ctor__)
		    ;
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_AnnouncementsData__TypeInfo);
		    DAT_ram_00a58837 = '\x01';
		  }
		  local_8 = 0;
		  iVar2 = unnamed_function_1417(System_Collections_Generic_List_AnnouncementsData__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (iVar2,Method_System_Collections_Generic_List_AnnouncementsData___ctor__);
		  iVar10 = *param2;
		  if (*(ushort *)(iVar10 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (System_Collections_Generic_IEnumerable_Announcement__TypeInfo ==
		          *(int *)(*(int *)(iVar10 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(iVar10 + *(int *)(*(int *)(iVar10 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80f32d96;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar10 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param2,System_Collections_Generic_IEnumerable_Announcement__TypeInfo
		                                ,0);
		code_r0x80f32d96:
		  local_4 = (int *)(**(code **)((ulonglong)*puVar3 * 4))(param2,puVar3[1]);
		  local_10 = 0;
		  local_c = &local_4;
		code_r0x80f32dbb:
		  do {
		    do {
		      piVar8 = local_4;
		      iVar10 = *local_4;
		      if (*(ushort *)(iVar10 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          piVar9 = (int *)(*(int *)(iVar10 + 0x58) + uVar1 * 8);
		          if (System_Collections_IEnumerator_TypeInfo == *piVar9) {
		            puVar4 = (undefined4 *)(iVar10 + piVar9[1] * 8 + 0xc0);
		            goto code_r0x80f32e61;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar10 + 0xb6) != uVar1);
		      }
		      DAT_ram_009d3e38 = 0;
		      puVar4 = (undefined4 *)
		               import::env::invoke_iiii
		                         (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                          System_Collections_IEnumerator_TypeInfo,0);
		      if (DAT_ram_009d3e38 == 1) {
		code_r0x80f32ea5:
		        DAT_ram_009d3e38 = 0;
		        uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80f330c5;
		      }
		code_r0x80f32e61:
		      DAT_ram_009d3e38 = 0;
		      iVar10 = import::env::invoke_iii(*puVar4,piVar8,puVar4[1]);
		      piVar8 = local_4;
		      if (DAT_ram_009d3e38 == 1) goto code_r0x80f32ea5;
		      if (iVar10 == 0) goto code_r0x80f3310e;
		      iVar10 = *local_4;
		      if (*(ushort *)(iVar10 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          piVar9 = (int *)(*(int *)(iVar10 + 0x58) + uVar1 * 8);
		          if (System_Collections_Generic_IEnumerator_Announcement__TypeInfo == *piVar9) {
		            puVar4 = (undefined4 *)(iVar10 + piVar9[1] * 8 + 0xc0);
		            goto code_r0x80f32f50;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar10 + 0xb6) != uVar1);
		      }
		      DAT_ram_009d3e38 = 0;
		      puVar4 = (undefined4 *)
		               import::env::invoke_iiii
		                         (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                          System_Collections_Generic_IEnumerator_Announcement__TypeInfo,0);
		      if (DAT_ram_009d3e38 == 1) {
		code_r0x80f3300f:
		        DAT_ram_009d3e38 = 0;
		        uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80f330c5;
		      }
		code_r0x80f32f50:
		      DAT_ram_009d3e38 = 0;
		      uVar5 = import::env::invoke_iii(*puVar4,piVar8,puVar4[1]);
		      if (DAT_ram_009d3e38 == 1) goto code_r0x80f3300f;
		      DAT_ram_009d3e38 = 0;
		      param2_00 = import::env::invoke_iii
		                            (*(undefined4 *)(*param1 + 0x100),param1,
		                             *(undefined4 *)(*param1 + 0x104));
		      iVar10 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar10 == 1) {
		        uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80f330c5;
		      }
		      DAT_ram_009d3e38 = 0;
		      iVar6 = import::env::invoke_iiiii
		                        (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x1a6,param2_00,uVar5,
		                         &local_8,iVar10);
		      iVar7 = DAT_ram_009d3e38;
		      iVar10 = Method_System_Collections_Generic_List_AnnouncementsData__Add__;
		      DAT_ram_009d3e38 = 0;
		      if (iVar7 == 1) {
		        uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80f330c5;
		      }
		    } while (iVar6 == 0);
		    *(int *)(iVar2 + 0x10) = *(int *)(iVar2 + 0x10) + 1;
		    uVar1 = *(uint *)(iVar2 + 0xc);
		    if (uVar1 < *(uint *)(*(int *)(iVar2 + 8) + 0xc)) {
		      *(uint *)(iVar2 + 0xc) = uVar1 + 1;
		      *(undefined4 *)(*(int *)(iVar2 + 8) + uVar1 * 4 + 0x10) = local_8;
		      goto code_r0x80f32dbb;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,iVar2,local_8,
		               *(undefined4 *)(*(int *)(*(int *)(iVar10 + 0x10) + 0x60) + 0x38));
		    iVar10 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		  } while (iVar10 != 1);
		  uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80f330c5:
		  iVar10 = global_1;
		  iVar7 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar10 == iVar7) {
		    piVar8 = (int *)import::env::__cxa_begin_catch(uVar5);
		    local_10 = *piVar8;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_v(0x123);
		    iVar10 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar10 != 1) {
		code_r0x80f3310e:
		      DAT_ram_009d3e38 = 0;
		      piVar8 = *local_c;
		      if (piVar8 != (int *)0x0) {
		        uVar1 = 0;
		        iVar10 = *piVar8;
		        if (*(ushort *)(iVar10 + 0xb6) != 0) {
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar10 + 0x58) + uVar1 * 8)) {
		              puVar3 = (uint *)(iVar10 + *(int *)(*(int *)(iVar10 + 0x58) + uVar1 * 8 + 4) * 8 +
		                               0xc0);
		              goto code_r0x80f33189;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar10 + 0xb6) != uVar1);
		        }
		        puVar3 = (uint *)func_ii_1080(piVar8,System_IDisposable_TypeInfo,0);
		code_r0x80f33189:
		        (**(code **)((ulonglong)*puVar3 * 4))(piVar8,puVar3[1]);
		      }
		      if (local_10 == 0) {
		        iVar10 = *param1;
		        uVar5 = (**(code **)((ulonglong)*(uint *)(iVar10 + 0x100) * 4))
		                          (param1,*(undefined4 *)(iVar10 + 0x104));
		        Gameplay_Announcements_Model_AnnouncementsModel__GetNotificationsCount(uVar5,iVar2,iVar10);
		        return;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(local_10);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar5 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x1a7,&local_10);
		  iVar2 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar2 == 1) {
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  import::env::__resumeException(uVar5);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06005573 RID: 21875 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005573")]
		[Address(RVA = "0xA313", Offset = "0xA313", VA = "0xA313")]
		private void AddNotifications(IEnumerable<Announcement> values)
		{
		/* --- GHIDRA: AddNotifications ---
		void Gameplay_Announcements_Control_AnnouncementsController__AddNotifications
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a58838 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Announcements_View_AnnouncementsWindow_AnnouncementsWindowArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_PopupController_Show_AnnouncementsWindow___);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12558);
		    DAT_ram_00a58838 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  param1_00 = *(undefined4 *)(iVar1 + 0x1c);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  if (DAT_ram_00a5882c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_LinkedListNode_AnnouncementsData__get_Value__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_LinkedList_AnnouncementsData__get_First__);
		    DAT_ram_00a5882c = '\x01';
		  }
		  uVar2 = *(undefined4 *)(*(int *)(*(int *)(iVar1 + 0xc) + 8) + 0x14);
		  iVar1 = unnamed_function_1417
		                    (
		                    Gameplay_Announcements_View_AnnouncementsWindow_AnnouncementsWindowArgs_TypeInfo
		                    );
		  UI_Windows_BaseWindowArgs__Dispose(iVar1,0);
		  *(undefined4 *)(iVar1 + 0x1c) = uVar2;
		  *(int **)(iVar1 + 0x18) = param1;
		  *(undefined1 *)(iVar1 + 0xc) = 0;
		  Gameplay_Antiq_View_GroupReviewWindow_WindowArgs___ctor
		            (param1_00,StringLiteral_12558,iVar1,
		             Method_UI_Windows_PopupController_Show_AnnouncementsWindow___);
		  return;
		}
		*/

		}

		// Token: 0x06005574 RID: 21876 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005574")]
		[Address(RVA = "0xA314", Offset = "0xA314", VA = "0xA314")]
		private void Notify()
		{
		/* --- GHIDRA: Notify ---
		void Gameplay_Announcements_Control_AnnouncementsController__Notify
		               (undefined4 param1,undefined8 param2,undefined4 param3)
		
		{
		  Gameplay_Announcements_Control_AnnouncementsController__RequestList(param1,param2,param1);
		  return;
		}
		*/

		}

		// Token: 0x06005575 RID: 21877 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005575")]
		[Address(RVA = "0xA315", Offset = "0xA315", VA = "0xA315")]
		public void ReadNotification(ulong id)
		{
		/* --- GHIDRA: ReadNotification ---
		uint Gameplay_Announcements_Control_AnnouncementsController__ReadNotification
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  if (DAT_ram_00a58827 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_LinkedList_AnnouncementsData__get_Count__);
		    DAT_ram_00a58827 = '\x01';
		  }
		  return (uint)(0 < *(int *)(*(int *)(iVar1 + 0xc) + 0xc));
		}
		*/

		}

		// Token: 0x04002E3F RID: 11839
		[Token(Token = "0x4002E3F")]
		private const float DELAY_OPEN = 1f;

		// Token: 0x04002E40 RID: 11840
		[Token(Token = "0x4002E40")]
		[FieldOffset(Offset = "0x18")]
		private AnnouncementsService _service;

		// Token: 0x04002E41 RID: 11841
		[Token(Token = "0x4002E41")]
		[FieldOffset(Offset = "0x1C")]
		private Tween _delayTween;
	}
}
