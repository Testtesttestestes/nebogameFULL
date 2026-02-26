using System;
using System.Runtime.CompilerServices;
using Gameplay.Portals.Events;
using Gameplay.Portals.Model;
using Google.Protobuf;
using Il2CppDummyDll;
using MVC;
using Protocol.Portal;
using ServicesNamespace;
using Utils;

namespace Gameplay.Portals.Controller
{
	// Token: 0x020005DA RID: 1498
	[Token(Token = "0x20005DA")]
	public class PortalsController : AbstractController<PortalsModel, PortalsEvents>
	{
		// Token: 0x170006D0 RID: 1744
		// (get) Token: 0x0600240A RID: 9226 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170006D0")]
		public PortalsService PortalsService
		{
			[Token(Token = "0x600240A")]
			[Address(RVA = "0x755B", Offset = "0x755B", VA = "0x755B")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x0600240B RID: 9227 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600240B")]
		[Address(RVA = "0x755C", Offset = "0x755C", VA = "0x755C")]
		public PortalsController(PortalsModel model, PortalsEvents events, PortalsService portalsService)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Portals_Controller_PortalsController___ctor(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a58141 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoPortalStartedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoPortalStageInfoChangedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoPortalMonsterInfoChangedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoPortalUserInfoChangedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoPortalUserBetChangedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoPortalDoneEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Portals_Controller_PortalsController_PortalDoneHandler__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Portals_Controller_PortalsController_PortalStageInfoChangedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Portals_Controller_PortalsController_PortalStartedHandler__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Portals_Controller_PortalsController_ProtoPortalMonsterInfoChangedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Portals_Controller_PortalsController_UserBetChangedHandler__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Portals_Controller_PortalsController_UserInfoChangedHandler__);
		    DAT_ram_00a58141 = '\x01';
		  }
		  uVar2 = *(undefined4 *)(param1 + 0x18);
		  uVar1 = unnamed_function_1417(System_Action_ProtoPortalDoneEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,Method_Gameplay_Portals_Controller_PortalsController_PortalDoneHandler__,0
		            );
		  ServicesNamespace_PortalsService__remove_OnProtoPortalStartedEvt(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param1 + 0x18);
		  uVar1 = unnamed_function_1417(System_Action_ProtoPortalStartedEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_Portals_Controller_PortalsController_PortalStartedHandler__,0);
		  ServicesNamespace_PortalsService__get_ServiceId(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param1 + 0x18);
		  uVar1 = unnamed_function_1417(System_Action_ProtoPortalUserBetChangedEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_Portals_Controller_PortalsController_UserBetChangedHandler__,0);
		  ServicesNamespace_PortalsService__remove_OnProtoPortalStageInfoChangedEvt(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param1 + 0x18);
		  uVar1 = unnamed_function_1417(System_Action_ProtoPortalUserInfoChangedEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_Portals_Controller_PortalsController_UserInfoChangedHandler__,0);
		  ServicesNamespace_PortalsService__remove_OnProtoPortalUserBetChangedEvt(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param1 + 0x18);
		  uVar1 = unnamed_function_1417(System_Action_ProtoPortalStageInfoChangedEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_Portals_Controller_PortalsController_PortalStageInfoChangedEventHandler__
		             ,0);
		  ServicesNamespace_PortalsService__remove_OnProtoPortalDoneEvt(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param1 + 0x18);
		  uVar1 = unnamed_function_1417(System_Action_ProtoPortalMonsterInfoChangedEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_Portals_Controller_PortalsController_ProtoPortalMonsterInfoChangedEventHandler__
		             ,0);
		  ServicesNamespace_PortalsService__remove_OnProtoPortalUserInfoChangedEvt(uVar2,uVar1,0);
		  Gameplay_Portals_Controller_PortalsController__Unsubscribe(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x0600240C RID: 9228 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600240C")]
		[Address(RVA = "0x755D", Offset = "0x755D", VA = "0x755D", Slot = "7")]
		protected override void HandleRun()
		{
		/* --- GHIDRA: HandleRun ---
		void Gameplay_Portals_Controller_PortalsController__HandleRun(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a58142 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoPortalStartedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoPortalStageInfoChangedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoPortalMonsterInfoChangedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoPortalUserInfoChangedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoPortalUserBetChangedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoPortalDoneEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Portals_Controller_PortalsController_PortalDoneHandler__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Portals_Controller_PortalsController_PortalStageInfoChangedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Portals_Controller_PortalsController_PortalStartedHandler__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Portals_Controller_PortalsController_ProtoPortalMonsterInfoChangedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Portals_Controller_PortalsController_UserBetChangedHandler__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Portals_Controller_PortalsController_UserInfoChangedHandler__);
		    DAT_ram_00a58142 = '\x01';
		  }
		  uVar2 = *(undefined4 *)(param1 + 0x18);
		  uVar1 = unnamed_function_1417(System_Action_ProtoPortalDoneEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,Method_Gameplay_Portals_Controller_PortalsController_PortalDoneHandler__,0
		            );
		  ServicesNamespace_PortalsService__add_OnProtoPortalDoneEvt(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param1 + 0x18);
		  uVar1 = unnamed_function_1417(System_Action_ProtoPortalStartedEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_Portals_Controller_PortalsController_PortalStartedHandler__,0);
		  ServicesNamespace_PortalsService__add_OnProtoPortalStartedEvt(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param1 + 0x18);
		  uVar1 = unnamed_function_1417(System_Action_ProtoPortalUserBetChangedEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_Portals_Controller_PortalsController_UserBetChangedHandler__,0);
		  ServicesNamespace_PortalsService__add_OnProtoPortalUserBetChangedEvt(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param1 + 0x18);
		  uVar1 = unnamed_function_1417(System_Action_ProtoPortalUserInfoChangedEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_Portals_Controller_PortalsController_UserInfoChangedHandler__,0);
		  ServicesNamespace_PortalsService__add_OnProtoPortalUserInfoChangedEvt(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param1 + 0x18);
		  uVar1 = unnamed_function_1417(System_Action_ProtoPortalStageInfoChangedEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_Portals_Controller_PortalsController_PortalStageInfoChangedEventHandler__
		             ,0);
		  ServicesNamespace_PortalsService__add_OnProtoPortalStageInfoChangedEvt(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param1 + 0x18);
		  uVar1 = unnamed_function_1417(System_Action_ProtoPortalMonsterInfoChangedEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_Portals_Controller_PortalsController_ProtoPortalMonsterInfoChangedEventHandler__
		             ,0);
		  ServicesNamespace_PortalsService__add_OnProtoPortalMonsterInfoChangedEvt(uVar2,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x0600240D RID: 9229 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600240D")]
		[Address(RVA = "0x755E", Offset = "0x755E", VA = "0x755E", Slot = "6")]
		protected override void HandleStop()
		{
		}

		// Token: 0x0600240E RID: 9230 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600240E")]
		[Address(RVA = "0x755F", Offset = "0x755F", VA = "0x755F")]
		private void UserBetChangedHandler(ProtoPortalUserBetChangedEvt msg)
		{
		/* --- GHIDRA: UserBetChangedHandler ---
		void Gameplay_Portals_Controller_PortalsController__UserBetChangedHandler
		               (int *param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int iVar2;
		  int iVar3;
		  uint *puVar4;
		  undefined4 param2_00;
		  int *param1_00;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a58143 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a58143 = '\x01';
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  if (param2 == 0) {
		    uVar5 = 0;
		  }
		  else {
		    uVar5 = *(undefined4 *)(param2 + 0xc);
		  }
		  *(undefined4 *)(iVar2 + 0x18) = uVar5;
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar2 = *(int *)(iVar2 + 0x28);
		  if (iVar2 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		              (*(undefined4 *)(iVar2 + 0x20),*(undefined4 *)(iVar2 + 0x14));
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  if ((*(int *)(iVar2 + 0x1c) == 0) ||
		     (iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104)),
		     *(int *)(*(int *)(iVar2 + 0x1c) + 0xc) == 0)) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    *(undefined4 *)(iVar2 + 0x14) = 0;
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar2 = *(int *)(iVar2 + 0x1c);
		  }
		  else {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    uVar5 = *(undefined4 *)(iVar3 + 0x1c);
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    uVar1 = 0;
		    param1_00 = *(int **)(iVar3 + 0x24);
		    iVar3 = *param1_00;
		    if (*(ushort *)(iVar3 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		          puVar4 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x178);
		          goto code_r0x80ea851a;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		    }
		    puVar4 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80ea851a:
		    param2_00 = (**(code **)((ulonglong)*puVar4 * 4))(param1_00,puVar4[1]);
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    uVar5 = Gameplay_Portals_Model_PortalMonsterData__set_DropChance
		                      (uVar5,param2_00,*(undefined4 *)(*(int *)(iVar3 + 0x18) + 0x1c),param1);
		    *(undefined4 *)(iVar2 + 0x14) = uVar5;
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar2 = *(int *)(iVar2 + 0x1c);
		  }
		  if (iVar2 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		              (*(undefined4 *)(iVar2 + 0x20),*(undefined4 *)(iVar2 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600240F RID: 9231 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600240F")]
		[Address(RVA = "0x7560", Offset = "0x7560", VA = "0x7560")]
		private void UserInfoChangedHandler(ProtoPortalUserInfoChangedEvt msg)
		{
		/* --- GHIDRA: UserInfoChangedHandler ---
		void Gameplay_Portals_Controller_PortalsController__UserInfoChangedHandler
		               (int *param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int iVar2;
		  int iVar3;
		  uint *puVar4;
		  undefined4 param2_00;
		  int *param1_00;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a58144 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a58144 = '\x01';
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  if (param2 == 0) {
		    uVar5 = 0;
		  }
		  else {
		    uVar5 = *(undefined4 *)(param2 + 0xc);
		  }
		  *(undefined4 *)(iVar2 + 0x1c) = uVar5;
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  if ((*(int *)(iVar2 + 0x1c) == 0) ||
		     (iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104)),
		     *(int *)(*(int *)(iVar2 + 0x1c) + 0xc) == 0)) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    *(undefined4 *)(iVar2 + 0x14) = 0;
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar2 = *(int *)(iVar2 + 0x1c);
		  }
		  else {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    uVar5 = *(undefined4 *)(iVar3 + 0x1c);
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    uVar1 = 0;
		    param1_00 = *(int **)(iVar3 + 0x24);
		    iVar3 = *param1_00;
		    if (*(ushort *)(iVar3 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		          puVar4 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x178);
		          goto code_r0x80ea8708;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		    }
		    puVar4 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80ea8708:
		    param2_00 = (**(code **)((ulonglong)*puVar4 * 4))(param1_00,puVar4[1]);
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    uVar5 = Gameplay_Portals_Model_PortalMonsterData__set_DropChance
		                      (uVar5,param2_00,*(undefined4 *)(*(int *)(iVar3 + 0x18) + 0x1c),param1);
		    *(undefined4 *)(iVar2 + 0x14) = uVar5;
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar2 = *(int *)(iVar2 + 0x1c);
		  }
		  if (iVar2 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		              (*(undefined4 *)(iVar2 + 0x20),*(undefined4 *)(iVar2 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002410 RID: 9232 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002410")]
		[Address(RVA = "0x7561", Offset = "0x7561", VA = "0x7561")]
		private void ProtoPortalMonsterInfoChangedEventHandler(ProtoPortalMonsterInfoChangedEvt msg)
		{
		/* --- GHIDRA: ProtoPortalMonsterInfoChangedEventHandler ---
		void Gameplay_Portals_Controller_PortalsController__ProtoPortalMonsterInfoChangedEventHandler
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  *(undefined4 *)(iVar1 + 0x10) = *(undefined4 *)(param2 + 0xc);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  Gameplay_Portals_Controller_PortalsController__SetEntryPointBackTime
		            (param1,*(undefined4 *)(*(int *)(iVar1 + 0x10) + 0xc),param1);
		  Gameplay_Portals_Controller_PortalsController__GetPortalInfoHandler(param1,param1);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(iVar1 + 0x50);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002411 RID: 9233 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002411")]
		[Address(RVA = "0x7562", Offset = "0x7562", VA = "0x7562")]
		private void PortalStartedHandler(ProtoPortalStartedEvt msg)
		{
		/* --- GHIDRA: PortalStartedHandler ---
		void Gameplay_Portals_Controller_PortalsController__PortalStartedHandler
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  *(undefined4 *)(iVar1 + 0x10) = 0;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  *(undefined4 *)(iVar1 + 0x18) = 0;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  *(undefined4 *)(iVar1 + 0x20) = 0;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(iVar1 + 0x50);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002412 RID: 9234 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002412")]
		[Address(RVA = "0x7563", Offset = "0x7563", VA = "0x7563")]
		private void PortalDoneHandler(ProtoPortalDoneEvt msg)
		{
		/* --- GHIDRA: PortalDoneHandler ---
		void Gameplay_Portals_Controller_PortalsController__PortalDoneHandler
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		  Gameplay_Portals_Model_PortalsModel___ctor(param1_00,*(undefined4 *)(param2 + 0xc),param1);
		  Gameplay_Portals_Controller_PortalsController__PortalStageInfoChangedEventHandler(param1,param1);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(iVar1 + 0x24);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002413 RID: 9235 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002413")]
		[Address(RVA = "0x7564", Offset = "0x7564", VA = "0x7564")]
		private void PortalStageInfoChangedEventHandler(ProtoPortalStageInfoChangedEvt msg)
		{
		/* --- GHIDRA: PortalStageInfoChangedEventHandler ---
		void Gameplay_Portals_Controller_PortalsController__PortalStageInfoChangedEventHandler
		               (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  int iVar3;
		  uint *puVar4;
		  undefined4 uVar5;
		  int *piVar6;
		  undefined4 uVar7;
		  
		  if (DAT_ram_00a58145 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    DAT_ram_00a58145 = '\x01';
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  if ((*(int *)(iVar2 + 0x10) != 0) &&
		     (iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104)), *(int *)(iVar2 + 0x20) != 0)) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    uVar1 = 0;
		    piVar6 = *(int **)(iVar3 + 0xc);
		    iVar3 = *piVar6;
		    if (*(ushort *)(iVar3 + 0xb6) != 0) {
		      do {
		        if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		          puVar4 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0xd0);
		          goto code_r0x80ea8cbe;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		    }
		    puVar4 = (uint *)func_ii_1080(piVar6,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x80ea8cbe:
		    uVar1 = 0;
		    uVar5 = (**(code **)((ulonglong)*puVar4 * 4))(piVar6,puVar4[1]);
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    uVar7 = *(undefined4 *)(*(int *)(iVar3 + 0x20) + 0xc);
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    uVar5 = Core_Extensions_Dict_PortalDicExt__GetPortalDic
		                      (uVar5,uVar7,*(undefined4 *)(*(int *)(iVar3 + 0x10) + 0xc),0);
		    *(undefined4 *)(iVar2 + 0x40) = uVar5;
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    piVar6 = *(int **)(iVar3 + 0xc);
		    iVar3 = *piVar6;
		    if (*(ushort *)(iVar3 + 0xb6) != 0) {
		      do {
		        if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		          puVar4 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0xd0);
		          goto code_r0x80ea8db4;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		    }
		    puVar4 = (uint *)func_ii_1080(piVar6,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x80ea8db4:
		    uVar5 = (**(code **)((ulonglong)*puVar4 * 4))(piVar6,puVar4[1]);
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    uVar7 = *(undefined4 *)(*(int *)(iVar3 + 0x20) + 0xc);
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    uVar5 = Core_Extensions_Dict_PortalDicExt__GetPortalStageDic
		                      (uVar5,uVar7,*(undefined4 *)(*(int *)(iVar3 + 0x10) + 0xc),0);
		    *(undefined4 *)(iVar2 + 0x44) = uVar5;
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002414 RID: 9236 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002414")]
		[Address(RVA = "0x7565", Offset = "0x7565", VA = "0x7565")]
		private void UpdateStageDic()
		{
		/* --- GHIDRA: UpdateStageDic ---
		void Gameplay_Portals_Controller_PortalsController__UpdateStageDic(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a58146 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Portals_Controller_PortalsController_RegisterUserHandler__);
		    DAT_ram_00a58146 = '\x01';
		  }
		  uVar1 = ServicesNamespace_PortalsService__ServerEventHandler(*(undefined4 *)(param1 + 0x18),0);
		  param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_Portals_Controller_PortalsController_RegisterUserHandler__,0);
		  uVar1 = ServicesNamespace_MainService__GetUserStats
		                    (uVar1,param1_00,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  Utils_OpToken_int__object___AddHandlers(param1,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x06002415 RID: 9237 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002415")]
		[Address(RVA = "0x7566", Offset = "0x7566", VA = "0x7566")]
		public void RegisterUser()
		{
		/* --- GHIDRA: RegisterUser ---
		void Gameplay_Portals_Controller_PortalsController__RegisterUser(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a58147 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Portals_Controller_PortalsController_SubscribeHandler__);
		    DAT_ram_00a58147 = '\x01';
		  }
		  uVar1 = ServicesNamespace_PortalsService__RegisterUser(*(undefined4 *)(param1 + 0x18),0);
		  param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_Portals_Controller_PortalsController_SubscribeHandler__,0);
		  uVar1 = ServicesNamespace_MainService__GetUserStats
		                    (uVar1,param1_00,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  Utils_OpToken_int__object___AddHandlers(param1,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x06002416 RID: 9238 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002416")]
		[Address(RVA = "0x7567", Offset = "0x7567", VA = "0x7567")]
		public void Subscribe()
		{
		/* --- GHIDRA: Subscribe ---
		void Gameplay_Portals_Controller_PortalsController__Subscribe(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a58148 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Portals_Controller_PortalsController_UnsubscribeHandler__);
		    DAT_ram_00a58148 = '\x01';
		  }
		  uVar1 = ServicesNamespace_PortalsService__Subscribe(*(undefined4 *)(param1 + 0x18),0);
		  param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_Portals_Controller_PortalsController_UnsubscribeHandler__,0);
		  uVar1 = ServicesNamespace_MainService__GetUserStats
		                    (uVar1,param1_00,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  Utils_OpToken_int__object___AddHandlers(param1,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x06002417 RID: 9239 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002417")]
		[Address(RVA = "0x7568", Offset = "0x7568", VA = "0x7568")]
		public void Unsubscribe()
		{
		/* --- GHIDRA: Unsubscribe ---
		void Gameplay_Portals_Controller_PortalsController__Unsubscribe(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a58149 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Portals_Controller_PortalsController_GetPortalInfoHandler__);
		    DAT_ram_00a58149 = '\x01';
		  }
		  uVar1 = ServicesNamespace_PortalsService__Unsubscribe(*(undefined4 *)(param1 + 0x18),0);
		  param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_Portals_Controller_PortalsController_GetPortalInfoHandler__,0);
		  uVar1 = ServicesNamespace_MainService__GetUserStats
		                    (uVar1,param1_00,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  Utils_OpToken_int__object___AddHandlers(param1,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x06002418 RID: 9240 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002418")]
		[Address(RVA = "0x7569", Offset = "0x7569", VA = "0x7569")]
		public void GetPortalInfo()
		{
		/* --- GHIDRA: GetPortalInfo ---
		void Gameplay_Portals_Controller_PortalsController__GetPortalInfo(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  param1_00 = *(undefined4 *)(iVar1 + 0x24);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  iVar1 = Gameplay_Portals_Combat_PortalCombat__InitMVC
		                    (param1_00,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x14) + 0x10) + 0x14),0);
		  if (iVar1 != 0) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar1 = *(int *)(iVar1 + 0x38);
		    if (iVar1 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002419 RID: 9241 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002419")]
		[Address(RVA = "0x1BEB", Offset = "0x1BEB", VA = "0x1BEB")]
		public void GetStageInfo()
		{
		/* --- GHIDRA: GetStageInfo ---
		undefined4 Gameplay_Portals_Controller_PortalsController__GetStageInfo(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5814b == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Portals_Controller_PortalsController_GetCurrentMonsterInfoHandler__)
		    ;
		    DAT_ram_00a5814b = '\x01';
		  }
		  uVar1 = ServicesNamespace_PortalsService__GetStageInfo(*(undefined4 *)(param1 + 0x18),0);
		  param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_Portals_Controller_PortalsController_GetCurrentMonsterInfoHandler__,0);
		  uVar1 = ServicesNamespace_MainService__GetUserStats
		                    (uVar1,param1_00,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  Utils_OpToken_int__object___AddHandlers(param1,uVar1,0);
		  return uVar1;
		}
		*/

		}

		// Token: 0x0600241A RID: 9242 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600241A")]
		[Address(RVA = "0x1BEC", Offset = "0x1BEC", VA = "0x1BEC")]
		public OpToken<IMessage, object> GetCurrentMonster()
		{
		/* --- GHIDRA: GetCurrentMonster ---
		void Gameplay_Portals_Controller_PortalsController__GetCurrentMonster
		               (undefined4 param1,undefined4 param2,undefined4 param3,int param4,int param5,
		               int param6,undefined4 param7)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int iVar2;
		  int param1_00;
		  uint uVar3;
		  int *param1_01;
		  float param2_01;
		  int iVar4;
		  
		  if (DAT_ram_00a57d86 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_MedalDic__uint__get_Data__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_MedalViewSelectable__Add__)
		    ;
		    DAT_ram_00a57d86 = '\x01';
		  }
		  iVar4 = Method_System_Collections_Generic_List_MedalViewSelectable__Add__;
		  *(int *)(param4 + 0x10) = *(int *)(param4 + 0x10) + 1;
		  uVar3 = *(uint *)(param4 + 0xc);
		  if (uVar3 < *(uint *)(*(int *)(param4 + 8) + 0xc)) {
		    *(uint *)(param4 + 0xc) = uVar3 + 1;
		    *(int *)(*(int *)(param4 + 8) + uVar3 * 4 + 0x10) = param6;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (param4,param6,*(undefined4 *)(*(int *)(*(int *)(iVar4 + 0x10) + 0x60) + 0x38));
		  }
		  if (DAT_ram_00a57d92 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_MedalViewSelectable__TypeInfo);
		    DAT_ram_00a57d92 = '\x01';
		  }
		  iVar4 = *(int *)(param6 + 0x1c);
		  while( true ) {
		    iVar2 = 0;
		    param1_00 = UnityEngine_UI_Image__set_sprite(iVar4,param3,0);
		    param2_00 = System_Action_MedalViewSelectable__TypeInfo;
		    if ((param1_00 != 0) &&
		       (iVar2 = func_ii_1082(param1_00,System_Action_MedalViewSelectable__TypeInfo), iVar2 == 0))
		    break;
		    iVar2 = func_ii_4329(param6 + 0x1c,iVar2,iVar4);
		    bVar1 = iVar2 == iVar4;
		    iVar4 = iVar2;
		    if (bVar1) {
		      iVar4 = **(int **)(param6 + 0x10);
		      (**(code **)((ulonglong)*(uint *)(iVar4 + 0x138) * 4))
		                (*(int **)(param6 + 0x10),param5,*(undefined4 *)(iVar4 + 0x13c));
		      param1_01 = *(int **)(param6 + 0x10);
		      iVar4 = func_ii_7183(param2,*(undefined4 *)(*(int *)(param5 + 0x10) + 0x20),0);
		      *(char *)(param1_01 + 0x14) = (char)iVar4;
		      param2_01 = 0.0;
		      if (iVar4 == 0) {
		        param2_01 = 1.0;
		      }
		      Core_Data_MedalData__IsMedalAchieved(param1_01[9],param2_01,0);
		      Core_Data_MedalData__IsMedalAchieved(param1_01[10],param2_01,0);
		      Core_Data_MedalData__IsMedalAchieved(param1_01[0xb],param2_01,0);
		      iVar4 = (**(code **)((ulonglong)*(uint *)(*param1_01 + 0x130) * 4))
		                        (param1_01,*(undefined4 *)(*param1_01 + 0x134));
		      if (iVar4 != 0) {
		        UI_RawImageWithGrayscale__SetGrayscale(param1_01,param1_01);
		      }
		      if (*(char *)(*(int *)(param6 + 0x10) + 0x50) != '\0') {
		        *(undefined4 *)(*(int *)(param6 + 0x10) + 0x48) = param2;
		      }
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_00,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

			return null;
		}

		// Token: 0x0600241B RID: 9243 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600241B")]
		[Address(RVA = "0x756A", Offset = "0x756A", VA = "0x756A")]
		public void AttackMonster()
		{
		/* --- GHIDRA: AttackMonster ---
		void Gameplay_Portals_Controller_PortalsController__AttackMonster(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5814c == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Portals_Controller_PortalsController_ComebackToStageHandler__);
		    DAT_ram_00a5814c = '\x01';
		  }
		  uVar1 = ServicesNamespace_PortalsService__GetMonsterInfo(*(undefined4 *)(param1 + 0x18),0);
		  param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_Portals_Controller_PortalsController_ComebackToStageHandler__,0);
		  uVar1 = ServicesNamespace_MainService__GetUserStats
		                    (uVar1,param1_00,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  Utils_OpToken_int__object___AddHandlers(param1,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x0600241C RID: 9244 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600241C")]
		[Address(RVA = "0x756B", Offset = "0x756B", VA = "0x756B")]
		public void ComebackToStage()
		{
		/* --- GHIDRA: ComebackToStage ---
		void Gameplay_Portals_Controller_PortalsController__ComebackToStage(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5814d == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Portals_Controller_PortalsController_GetBetPoolInfoHandler__);
		    DAT_ram_00a5814d = '\x01';
		  }
		  uVar1 = ServicesNamespace_PortalsService__RequestCombat(*(undefined4 *)(param1 + 0x18),0);
		  param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_Portals_Controller_PortalsController_GetBetPoolInfoHandler__,0);
		  uVar1 = ServicesNamespace_MainService__GetUserStats
		                    (uVar1,param1_00,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  Utils_OpToken_int__object___AddHandlers(param1,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x0600241D RID: 9245 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600241D")]
		[Address(RVA = "0x756C", Offset = "0x756C", VA = "0x756C")]
		public void GetBetPoolInfo()
		{
		/* --- GHIDRA: GetBetPoolInfo ---
		void Gameplay_Portals_Controller_PortalsController__GetBetPoolInfo(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5814e == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Portals_Controller_PortalsController_GetJackpotInfoHandler__);
		    DAT_ram_00a5814e = '\x01';
		  }
		  uVar1 = ServicesNamespace_PortalsService__GetBetPoolInfo(*(undefined4 *)(param1 + 0x18),0);
		  param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_Portals_Controller_PortalsController_GetJackpotInfoHandler__,0);
		  uVar1 = ServicesNamespace_MainService__GetUserStats
		                    (uVar1,param1_00,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  Utils_OpToken_int__object___AddHandlers(param1,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x0600241E RID: 9246 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600241E")]
		[Address(RVA = "0x756D", Offset = "0x756D", VA = "0x756D")]
		public void GetJackpotInfo()
		{
		/* --- GHIDRA: GetJackpotInfo ---
		void Gameplay_Portals_Controller_PortalsController__GetJackpotInfo
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  int *param1_00;
		  
		  if (DAT_ram_00a5814f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedPortalCommonErrors___
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Portal_ProtoPortalRegisterAns_TypeInfo);
		    DAT_ram_00a5814f = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  param1_00 = *(int **)(param2 + 0x20);
		  if ((param1_00 != (int *)0x0) && (Protocol_Portal_ProtoPortalRegisterAns_TypeInfo != *param1_00))
		  {
		    System_Activator__CreateInstance(param1_00,Protocol_Portal_ProtoPortalRegisterAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar1 = UnityEngine_EventSystems_ExecuteEvents__ValidateEventData_object_
		                    (param1_00[3],0,
		                     Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedPortalCommonErrors___
		                    );
		  if (iVar1 == 0) {
		    if (param1_00[4] == 0) {
		      uVar2 = unnamed_function_2232(&StringLiteral_9300);
		      uVar2 = func_ii_4419(uVar2,param1_00,0);
		      uVar3 = unnamed_function_2232(&System_Exception_TypeInfo);
		      uVar3 = unnamed_function_1417(uVar3);
		      System_String__Concat(uVar3,uVar2,0);
		      uVar2 = unnamed_function_2232
		                        (&Method_Gameplay_Portals_Controller_PortalsController_RegisterUserHandler__
		                        );
		      func_ii_1050(uVar3,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    *(int *)(iVar1 + 0x18) = param1_00[4];
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

		// Token: 0x0600241F RID: 9247 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600241F")]
		[Address(RVA = "0x756E", Offset = "0x756E", VA = "0x756E")]
		private void RegisterUserHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: RegisterUserHandler ---
		void Gameplay_Portals_Controller_PortalsController__RegisterUserHandler
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  int *param1_00;
		  
		  if (DAT_ram_00a58150 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedPortalCommonErrors___
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Portal_ProtoPortalSubscribeAns_TypeInfo);
		    DAT_ram_00a58150 = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  param1_00 = *(int **)(param2 + 0x20);
		  if ((param1_00 != (int *)0x0) && (Protocol_Portal_ProtoPortalSubscribeAns_TypeInfo != *param1_00))
		  {
		    System_Activator__CreateInstance(param1_00,Protocol_Portal_ProtoPortalSubscribeAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  UnityEngine_EventSystems_ExecuteEvents__ValidateEventData_object_
		            (param1_00[3],0,
		             Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedPortalCommonErrors___
		            );
		  return;
		}
		*/

		}

		// Token: 0x06002420 RID: 9248 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002420")]
		[Address(RVA = "0x756F", Offset = "0x756F", VA = "0x756F")]
		private void SubscribeHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: SubscribeHandler ---
		void Gameplay_Portals_Controller_PortalsController__SubscribeHandler
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  int *param1_00;
		  
		  if (DAT_ram_00a58151 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedPortalCommonErrors___
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Portal_ProtoPortalUnSubscribeAns_TypeInfo);
		    DAT_ram_00a58151 = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  param1_00 = *(int **)(param2 + 0x20);
		  if ((param1_00 != (int *)0x0) &&
		     (Protocol_Portal_ProtoPortalUnSubscribeAns_TypeInfo != *param1_00)) {
		    System_Activator__CreateInstance(param1_00,Protocol_Portal_ProtoPortalUnSubscribeAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  UnityEngine_EventSystems_ExecuteEvents__ValidateEventData_object_
		            (param1_00[3],0,
		             Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedPortalCommonErrors___
		            );
		  return;
		}
		*/

		}

		// Token: 0x06002421 RID: 9249 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002421")]
		[Address(RVA = "0x7570", Offset = "0x7570", VA = "0x7570")]
		private void UnsubscribeHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: UnsubscribeHandler ---
		void Gameplay_Portals_Controller_PortalsController__UnsubscribeHandler
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int *param1_00;
		  
		  if (DAT_ram_00a58152 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedPortalCommonErrors___
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Portal_ProtoGetPortalInfoAns_TypeInfo);
		    DAT_ram_00a58152 = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  param1_00 = *(int **)(param2 + 0x20);
		  if ((param1_00 != (int *)0x0) && (Protocol_Portal_ProtoGetPortalInfoAns_TypeInfo != *param1_00)) {
		    System_Activator__CreateInstance(param1_00,Protocol_Portal_ProtoGetPortalInfoAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar1 = UnityEngine_EventSystems_ExecuteEvents__ValidateEventData_object_
		                    (param1_00[3],0,
		                     Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedPortalCommonErrors___
		                    );
		  if (((iVar1 == 0) && (param1_00[4] != 0)) && (*(int *)(param1_00[4] + 0xc) != 0)) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    *(int *)(iVar1 + 0x10) = param1_00[4];
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    *(int *)(iVar1 + 0x18) = param1_00[5];
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    Gameplay_Portals_Controller_PortalsController__SetEntryPointBackTime
		              (param1,*(undefined4 *)(*(int *)(iVar1 + 0x10) + 0xc),param1);
		    Gameplay_Portals_Controller_PortalsController__GetPortalInfoHandler(param1,param1);
		    if (*(char *)((int)param1 + 9) == '\0') {
		      *(undefined1 *)((int)param1 + 9) = 1;
		      iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x114));
		      iVar1 = *(int *)(iVar1 + 8);
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		    }
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar1 = *(int *)(iVar1 + 0x30);
		    if (iVar1 == 0) {
		      return;
		    }
		  }
		  else {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    *(undefined4 *)(iVar1 + 0x10) = 0;
		    if (*(char *)((int)param1 + 9) != '\0') {
		      return;
		    }
		    *(undefined1 *)((int)param1 + 9) = 1;
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar1 = *(int *)(iVar1 + 8);
		  }
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		            (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  return;
		}
		*/

		}

		// Token: 0x06002422 RID: 9250 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002422")]
		[Address(RVA = "0x7571", Offset = "0x7571", VA = "0x7571")]
		private void GetPortalInfoHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: GetPortalInfoHandler ---
		void Gameplay_Portals_Controller_PortalsController__GetPortalInfoHandler
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 in_register_20000004;
		  undefined4 in_register_20000014;
		  undefined4 uVar1;
		  int iVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  undefined4 uVar5;
		  longlong lVar6;
		  undefined8 uVar7;
		  double dVar8;
		  undefined8 uVar9;
		  int *param1_00;
		  uint uVar10;
		  longlong lVar11;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a58153 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_DateTime_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Math_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_TimeSpan_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_22956);
		    DAT_ram_00a58153 = '\x01';
		  }
		  local_8 = 0;
		  uVar9 = CONCAT44(in_register_20000004,param1);
		  uVar7 = CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x104));
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(uVar9,uVar7);
		  uVar1 = (undefined4)((ulonglong)uVar7 >> 0x20);
		  uVar5 = (undefined4)((ulonglong)uVar9 >> 0x20);
		  param1_00 = *(int **)(iVar2 + 0x24);
		  iVar2 = *param1_00;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    uVar10 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar10 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar10 * 8 + 4) * 8 + iVar2 + 0x178);
		        goto code_r0x80ea89b7;
		      }
		      uVar10 = uVar10 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar10);
		  }
		  puVar3 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80ea89b7:
		  uVar9 = CONCAT44(uVar5,param1_00);
		  uVar7 = CONCAT44(uVar1,puVar3[1]);
		  uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(uVar9,uVar7);
		  uVar5 = (undefined4)((ulonglong)uVar9 >> 0x20);
		  uVar1 = (undefined4)((ulonglong)uVar7 >> 0x20);
		  uVar4 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar4,0);
		  lVar6 = Core_Extensions_Dict_DictExt__GetDoubleParameter(uVar4,StringLiteral_22956,0);
		  if (lVar6 < 1) {
		    iVar2 = *param1;
		    uVar5 = (**(code **)((ulonglong)*(uint *)(iVar2 + 0x100) * 4))
		                      (CONCAT44(uVar5,param1),CONCAT44(uVar1,*(undefined4 *)(iVar2 + 0x104)));
		    Gameplay_Portals_Model_PortalsModel__SetPortalBackTime(uVar5,0,iVar2);
		  }
		  else {
		    if (*(int *)(System_DateTime_TypeInfo + 0x74) == 0) {
		      func_ii_306000(System_DateTime_TypeInfo);
		    }
		    System_DateTime___ctor
		              (&local_8,s_var<private>_posTex__array<vec4<_ram_00000655 + 0x15d,1,1,0,0,0,1,0);
		    uVar7 = System_Net_ServicePoint__get_HasTimedOut(0);
		    uVar9 = local_8;
		    local_10 = System_DateTime__op_Subtraction(uVar7,local_8,0);
		    uVar1 = (undefined4)((ulonglong)uVar9 >> 0x20);
		    uVar5 = (undefined4)((ulonglong)uVar7 >> 0x20);
		    if (*(int *)(System_TimeSpan_TypeInfo + 0x74) == 0) {
		      func_ii_306000(System_TimeSpan_TypeInfo);
		    }
		    dVar8 = System_Net_FtpMethodInfo__GetMethodInfo(&local_10,0);
		    if (ABS(dVar8) < 9.223372036854776e+18) {
		      lVar11 = (longlong)dVar8;
		    }
		    else {
		      lVar11 = -0x8000000000000000;
		    }
		    uVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (CONCAT44(uVar5,param1),CONCAT44(uVar1,*(undefined4 *)(*param1 + 0x104)));
		    if (*(int *)(System_Math_TypeInfo + 0x74) == 0) {
		      func_ii_306000(System_Math_TypeInfo);
		    }
		    uVar9 = System_Math__Min(0,lVar6 - lVar11,0);
		    Gameplay_Portals_Model_PortalsModel__SetPortalBackTime(uVar5,uVar9,uVar5);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002423 RID: 9251 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002423")]
		[Address(RVA = "0x7572", Offset = "0x7572", VA = "0x7572")]
		private void SetEntryPointBackTime()
		{
		/* --- GHIDRA: SetEntryPointBackTime ---
		void Gameplay_Portals_Controller_PortalsController__SetEntryPointBackTime
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int iVar2;
		  int iVar3;
		  uint *puVar4;
		  undefined4 uVar5;
		  int *param1_00;
		  
		  if (DAT_ram_00a58154 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    DAT_ram_00a58154 = '\x01';
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  param1_00 = *(int **)(iVar3 + 0xc);
		  iVar3 = *param1_00;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0xd0);
		        goto code_r0x80ea88b7;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(param1_00,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x80ea88b7:
		  uVar5 = (**(code **)((ulonglong)*puVar4 * 4))(param1_00,puVar4[1]);
		  uVar5 = Core_Extensions_Dict_PortalDicExt__GetPopupDecor(uVar5,param2,0);
		  *(undefined4 *)(iVar2 + 0x3c) = uVar5;
		  return;
		}
		*/

		}

		// Token: 0x06002424 RID: 9252 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002424")]
		[Address(RVA = "0x7573", Offset = "0x7573", VA = "0x7573")]
		private void UpdateCurrentPortalDic(uint portalId)
		{
		/* --- GHIDRA: UpdateCurrentPortalDic ---
		void Gameplay_Portals_Controller_PortalsController__UpdateCurrentPortalDic
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  int *param1_00;
		  
		  if (DAT_ram_00a58155 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedPortalCommonErrors___
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Portal_ProtoGetPortalStageInfoAns_TypeInfo);
		    DAT_ram_00a58155 = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  param1_00 = *(int **)(param2 + 0x20);
		  if ((param1_00 != (int *)0x0) &&
		     (Protocol_Portal_ProtoGetPortalStageInfoAns_TypeInfo != *param1_00)) {
		    System_Activator__CreateInstance(param1_00,Protocol_Portal_ProtoGetPortalStageInfoAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar1 = UnityEngine_EventSystems_ExecuteEvents__ValidateEventData_object_
		                    (param1_00[3],0,
		                     Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedPortalCommonErrors___
		                    );
		  if (iVar1 == 0) {
		    if ((param1_00[4] == 0) || (*(int *)(param1_00[4] + 0xc) == 0)) {
		      uVar2 = unnamed_function_2232(&StringLiteral_9299);
		      uVar2 = func_ii_4419(uVar2,param1_00,0);
		      uVar3 = unnamed_function_2232(&System_Exception_TypeInfo);
		      uVar3 = unnamed_function_1417(uVar3);
		      System_String__Concat(uVar3,uVar2,0);
		      uVar2 = unnamed_function_2232
		                        (&Method_Gameplay_Portals_Controller_PortalsController_GetStageInfoHandler__
		                        );
		      func_ii_1050(uVar3,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    Gameplay_Portals_Model_PortalsModel___ctor(uVar2,param1_00[4],param1);
		    Gameplay_Portals_Controller_PortalsController__PortalStageInfoChangedEventHandler(param1,param1)
		    ;
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar1 = *(int *)(iVar1 + 0x20);
		    if (iVar1 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002425 RID: 9253 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002425")]
		[Address(RVA = "0x7574", Offset = "0x7574", VA = "0x7574")]
		private void GetStageInfoHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: GetStageInfoHandler ---
		void Gameplay_Portals_Controller_PortalsController__GetStageInfoHandler
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  int *param1_00;
		  
		  if (DAT_ram_00a58156 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedBillingErrors__ExpectedPortalCommonErrors___
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Portal_ProtoComebackToStageAns_TypeInfo);
		    DAT_ram_00a58156 = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  param1_00 = *(int **)(param2 + 0x20);
		  if ((param1_00 != (int *)0x0) && (Protocol_Portal_ProtoComebackToStageAns_TypeInfo != *param1_00))
		  {
		    System_Activator__CreateInstance(param1_00,Protocol_Portal_ProtoComebackToStageAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar1 = Core_Errors_Expected_ExpectedErrorsHandler__HandleErrorChain_object_
		                    (param1_00[3],0,0,
		                     Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedBillingErrors__ExpectedPortalCommonErrors___
		                    );
		  if (iVar1 == 0) {
		    if ((param1_00[4] == 0) || (*(int *)(param1_00[4] + 0xc) == 0)) {
		      uVar2 = unnamed_function_2232(&StringLiteral_9299);
		      uVar2 = func_ii_4419(uVar2,param1_00,0);
		      uVar3 = unnamed_function_2232(&System_Exception_TypeInfo);
		      uVar3 = unnamed_function_1417(uVar3);
		      System_String__Concat(uVar3,uVar2,0);
		      uVar2 = unnamed_function_2232
		                        (&
		                         Method_Gameplay_Portals_Controller_PortalsController_ComebackToStageHandler__
		                        );
		      func_ii_1050(uVar3,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    Gameplay_Portals_Model_PortalsModel___ctor(uVar2,param1_00[4],param1);
		    Gameplay_Portals_Controller_PortalsController__PortalStageInfoChangedEventHandler(param1,param1)
		    ;
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar1 = *(int *)(iVar1 + 0x20);
		    if (iVar1 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002426 RID: 9254 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002426")]
		[Address(RVA = "0x7575", Offset = "0x7575", VA = "0x7575")]
		private void ComebackToStageHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: ComebackToStageHandler ---
		void Gameplay_Portals_Controller_PortalsController__ComebackToStageHandler
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int *param1_00;
		  
		  if (DAT_ram_00a58157 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedPortalCommonErrors___
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Portal_ProtoGetBetPoolInfoAns_TypeInfo);
		    DAT_ram_00a58157 = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  param1_00 = *(int **)(param2 + 0x20);
		  if ((param1_00 != (int *)0x0) && (Protocol_Portal_ProtoGetBetPoolInfoAns_TypeInfo != *param1_00))
		  {
		    System_Activator__CreateInstance(param1_00,Protocol_Portal_ProtoGetBetPoolInfoAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar1 = UnityEngine_EventSystems_ExecuteEvents__ValidateEventData_object_
		                    (param1_00[3],0,
		                     Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedPortalCommonErrors___
		                    );
		  if (iVar1 == 0) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    *(int *)(iVar1 + 0x48) = param1_00[4];
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar1 = *(int *)(iVar1 + 0x54);
		    if (iVar1 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002427 RID: 9255 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002427")]
		[Address(RVA = "0x7576", Offset = "0x7576", VA = "0x7576")]
		private void GetBetPoolInfoHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: GetBetPoolInfoHandler ---
		void Gameplay_Portals_Controller_PortalsController__GetBetPoolInfoHandler
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int *param1_00;
		  
		  if (DAT_ram_00a58158 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedPortalCommonErrors___
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Portal_ProtoGetJackpotInfoAns_TypeInfo);
		    DAT_ram_00a58158 = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  param1_00 = *(int **)(param2 + 0x20);
		  if ((param1_00 != (int *)0x0) && (Protocol_Portal_ProtoGetJackpotInfoAns_TypeInfo != *param1_00))
		  {
		    System_Activator__CreateInstance(param1_00,Protocol_Portal_ProtoGetJackpotInfoAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar1 = UnityEngine_EventSystems_ExecuteEvents__ValidateEventData_object_
		                    (param1_00[3],0,
		                     Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedPortalCommonErrors___
		                    );
		  if (iVar1 == 0) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    *(int *)(iVar1 + 0x4c) = param1_00[4];
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar1 = *(int *)(iVar1 + 0x58);
		    if (iVar1 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002428 RID: 9256 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002428")]
		[Address(RVA = "0x7577", Offset = "0x7577", VA = "0x7577")]
		private void GetJackpotInfoHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: GetJackpotInfoHandler ---
		void Gameplay_Portals_Controller_PortalsController__GetJackpotInfoHandler
		               (int *param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int iVar2;
		  int iVar3;
		  uint *puVar4;
		  undefined4 param2_00;
		  int *piVar5;
		  undefined4 uVar6;
		  
		  if (DAT_ram_00a58159 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedPortalCommonErrors___
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Portal_ProtoGetPortalMonsterInfoAns_TypeInfo);
		    DAT_ram_00a58159 = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  piVar5 = *(int **)(param2 + 0x20);
		  if ((piVar5 != (int *)0x0) && (Protocol_Portal_ProtoGetPortalMonsterInfoAns_TypeInfo != *piVar5))
		  {
		    System_Activator__CreateInstance(piVar5,Protocol_Portal_ProtoGetPortalMonsterInfoAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar2 = UnityEngine_EventSystems_ExecuteEvents__ValidateEventData_object_
		                    (piVar5[3],0,
		                     Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedPortalCommonErrors___
		                    );
		  if (iVar2 == 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    *(int *)(iVar2 + 0x1c) = piVar5[4];
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    if ((*(int *)(iVar2 + 0x1c) == 0) ||
		       (iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0x104)),
		       *(int *)(*(int *)(iVar2 + 0x1c) + 0xc) == 0)) {
		      iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		      *(undefined4 *)(iVar2 + 0x14) = 0;
		      iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x114));
		      iVar2 = *(int *)(iVar2 + 0x18);
		    }
		    else {
		      iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		      iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		      uVar6 = *(undefined4 *)(iVar3 + 0x1c);
		      iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		      uVar1 = 0;
		      piVar5 = *(int **)(iVar3 + 0x24);
		      iVar3 = *piVar5;
		      if (*(ushort *)(iVar3 + 0xb6) != 0) {
		        do {
		          if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		            puVar4 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x178);
		            goto code_r0x80ea9bb7;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		      }
		      puVar4 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80ea9bb7:
		      param2_00 = (**(code **)((ulonglong)*puVar4 * 4))(piVar5,puVar4[1]);
		      iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		      uVar6 = Gameplay_Portals_Model_PortalMonsterData__set_DropChance
		                        (uVar6,param2_00,*(undefined4 *)(*(int *)(iVar3 + 0x18) + 0x1c),param1);
		      *(undefined4 *)(iVar2 + 0x14) = uVar6;
		      iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x114));
		      iVar2 = *(int *)(iVar2 + 0x18);
		    }
		    if (iVar2 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		                (*(undefined4 *)(iVar2 + 0x20),*(undefined4 *)(iVar2 + 0x14));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002429 RID: 9257 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002429")]
		[Address(RVA = "0x7578", Offset = "0x7578", VA = "0x7578")]
		private void GetCurrentMonsterInfoHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: GetCurrentMonsterInfoHandler ---
		void Gameplay_Portals_Controller_PortalsController__GetCurrentMonsterInfoHandler
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(iVar1 + 0x38);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600242A RID: 9258 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600242A")]
		[Address(RVA = "0x7579", Offset = "0x7579", VA = "0x7579")]
		private void AttackSuccessHandler()
		{
		}

		// Token: 0x0600242B RID: 9259 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600242B")]
		[Address(RVA = "0x757A", Offset = "0x757A", VA = "0x757A")]
		private void ValidateInit()
		{
		/* --- GHIDRA: ValidateInit ---
		void Gameplay_Portals_Controller_PortalsController__ValidateInit
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  if (DAT_ram_00a5815a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_MVC_AbstractController_PortalsMyBetsModel__PortalsEvents___ctor__);
		    DAT_ram_00a5815a = '\x01';
		  }
		  Gameplay_Combat_AbstractCombat_object__object__object__object__object___set_User
		            (param1,param2,param3,
		             Method_MVC_AbstractController_PortalsMyBetsModel__PortalsEvents___ctor__);
		  *(undefined4 *)(param1 + 0x18) = param4;
		  return;
		}
		*/

		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_PortalsService ---
		void Gameplay_Portals_Controller_PortalsController__get_PortalsService
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  if (DAT_ram_00a58140 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_MVC_AbstractController_PortalsModel__PortalsEvents___ctor__);
		    DAT_ram_00a58140 = '\x01';
		  }
		  Gameplay_Combat_AbstractCombat_object__object__object__object__object___set_User
		            (param1,param2,param3,Method_MVC_AbstractController_PortalsModel__PortalsEvents___ctor__
		            );
		  *(undefined4 *)(param1 + 0x18) = param4;
		  return;
		}
		*/

}
