using System;
using Core.Data.Skills;
using Gameplay.Clans.Buildings.Golem.Events;
using Gameplay.Clans.Buildings.Golem.Model;
using Google.Protobuf;
using Il2CppDummyDll;
using MVC;
using ServicesNamespace;
using Utils;

namespace Gameplay.Clans.Buildings.Golem.Controller
{
	// Token: 0x02000ADC RID: 2780
	[Token(Token = "0x2000ADC")]
	public class GolemController : AbstractController<GolemModel, GolemEvents>
	{
		// Token: 0x060042F2 RID: 17138 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042F2")]
		[Address(RVA = "0x91A6", Offset = "0x91A6", VA = "0x91A6")]
		public GolemController(GolemModel model, GolemEvents events)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Clans_Buildings_Golem_Controller_GolemController___ctor(int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *param2_00;
		  int *param1_00;
		  int iVar3;
		  
		  if (DAT_ram_00a57a88 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a57a88 = '\x01';
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  iVar2 = *(int *)(iVar2 + 0x14);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar3 = *param1_00;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        param2_00 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x238);
		        goto code_r0x80e1a3b9;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  param2_00 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x2f);
		code_r0x80e1a3b9:
		  iVar3 = (**(code **)((ulonglong)*param2_00 * 4))(param1_00,param2_00[1]);
		  if (*(int *)(iVar3 + 0x10) == iVar2) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar2 = *(int *)(iVar2 + 0x18);
		    if (iVar2 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		                (*(undefined4 *)(iVar2 + 0x20),*(undefined4 *)(iVar2 + 0x14));
		      return;
		    }
		  }
		  else {
		    Gameplay_Clans_Buildings_Golem_Controller_GolemController__ConstructSkills(param1,param2_00);
		  }
		  return;
		}
		*/

		}

		// Token: 0x060042F3 RID: 17139 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042F3")]
		[Address(RVA = "0x91A7", Offset = "0x91A7", VA = "0x91A7")]
		public void GetGolemInfo()
		{
		/* --- GHIDRA: GetGolemInfo ---
		void Gameplay_Clans_Buildings_Golem_Controller_GolemController__GetGolemInfo
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 in_register_20000014;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param1_00;
		  undefined8 param2_00;
		  int param1_01;
		  
		  if (DAT_ram_00a57a89 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Buildings_Golem_Controller_GolemController_GetUserSkillsResultHandler__
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    DAT_ram_00a57a89 = '\x01';
		  }
		  param1_01 = param1[6];
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x104)));
		  param2_00 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext
		                        (*(undefined4 *)(iVar1 + 0x1c),0);
		  uVar2 = ServicesNamespace_MainService__ServerEventHandler(param1_01,param2_00,0);
		  param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_Clans_Buildings_Golem_Controller_GolemController_GetUserSkillsResultHandler__
		             ,0);
		  uVar2 = ServicesNamespace_MainService__GetUserStats
		                    (uVar2,param1_00,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  Utils_OpToken_int__object___AddHandlers(param1,uVar2,0);
		  return;
		}
		*/

		}

		// Token: 0x060042F4 RID: 17140 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042F4")]
		[Address(RVA = "0x91A8", Offset = "0x91A8", VA = "0x91A8")]
		public void GetGolemSkills()
		{
		/* --- GHIDRA: GetGolemSkills ---
		void Gameplay_Clans_Buildings_Golem_Controller_GolemController__GetGolemSkills
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar2 = Gameplay_Clans_Buildings_Golem_Controller_GolemController__GetUserSkillsResultHandler
		                    (param1,param2,param1);
		  *(undefined4 *)(iVar1 + 0x20) = uVar2;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(iVar1 + 0x1c);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x060042F5 RID: 17141 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042F5")]
		[Address(RVA = "0x91A9", Offset = "0x91A9", VA = "0x91A9")]
		private void GetUserSkillsResultHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: GetUserSkillsResultHandler ---
		undefined4
		Gameplay_Clans_Buildings_Golem_Controller_GolemController__GetUserSkillsResultHandler
		          (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int *param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a57a8a == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Main_ProtoGetUserSkillsAns_TypeInfo);
		    DAT_ram_00a57a8a = '\x01';
		  }
		  param1_00 = *(int **)(param2 + 0x20);
		  if ((param1_00 != (int *)0x0) && (Protocol_Main_ProtoGetUserSkillsAns_TypeInfo != *param1_00)) {
		    System_Activator__CreateInstance(param1_00,Protocol_Main_ProtoGetUserSkillsAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  param1_01 = *(undefined4 *)(*(int *)(iVar1 + 0x1c) + 0x44);
		  uVar2 = Core_Extensions_Dict_ProtoCastExt__ToUserInfo(param1_00,0);
		  Core_Data_UserSkillsData__get_RawData(param1_01,uVar2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar2 = Gameplay_UserInfo_Model_UserInfoModel__get_ExperienceProgress
		                    (*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x1c) + 0x44) + 0x18),0);
		  return uVar2;
		}
		*/

		}

		// Token: 0x060042F6 RID: 17142 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60042F6")]
		[Address(RVA = "0x91AA", Offset = "0x91AA", VA = "0x91AA")]
		private SkillCollection ConstructSkills(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: ConstructSkills ---
		void Gameplay_Clans_Buildings_Golem_Controller_GolemController__ConstructSkills
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 in_register_20000014;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param1_00;
		  undefined8 param2_00;
		  int param1_01;
		  
		  if (DAT_ram_00a57a8b == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Buildings_Golem_Controller_GolemController_HandleGetUserArtifactsService__
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    DAT_ram_00a57a8b = '\x01';
		  }
		  param1_01 = param1[6];
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x104)));
		  param2_00 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext
		                        (*(undefined4 *)(iVar1 + 0x1c),0);
		  uVar2 = ServicesNamespace_MainService__GetClientState(param1_01,param2_00,0);
		  param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_Clans_Buildings_Golem_Controller_GolemController_HandleGetUserArtifactsService__
		             ,0);
		  uVar2 = ServicesNamespace_MainService__GetUserStats
		                    (uVar2,param1_00,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  Utils_OpToken_int__object___AddHandlers(param1,uVar2,0);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x060042F7 RID: 17143 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042F7")]
		[Address(RVA = "0x91AB", Offset = "0x91AB", VA = "0x91AB")]
		private void RequestUserArtifacts()
		{
		/* --- GHIDRA: RequestUserArtifacts ---
		void Gameplay_Clans_Buildings_Golem_Controller_GolemController__RequestUserArtifacts
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int *param1_00;
		  
		  if (DAT_ram_00a57a8c == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Main_ProtoGetUserArtifactsAns_TypeInfo);
		    DAT_ram_00a57a8c = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  param1_00 = *(int **)(param2 + 0x20);
		  if ((param1_00 != (int *)0x0) && (Protocol_Main_ProtoGetUserArtifactsAns_TypeInfo != *param1_00))
		  {
		    System_Activator__CreateInstance(param1_00,Protocol_Main_ProtoGetUserArtifactsAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  Gameplay_Inventory_Model_InventoryBaseModel__SetArtifact
		            (*(undefined4 *)(iVar1 + 0x14),param1_00[4],0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(iVar1 + 0x18);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x060042F8 RID: 17144 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042F8")]
		[Address(RVA = "0x91AC", Offset = "0x91AC", VA = "0x91AC")]
		private void HandleGetUserArtifactsService(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: HandleGetUserArtifactsService ---
		void Gameplay_Clans_Buildings_Golem_Controller_GolemController__HandleGetUserArtifactsService
		               (int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a57a8d == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_MVC_AbstractController_GolemModel__GolemEvents__Dispose__);
		    DAT_ram_00a57a8d = '\x01';
		  }
		  MVC_AbstractController_object__object____ctor
		            (param1,Method_MVC_AbstractController_GolemModel__GolemEvents__Dispose__);
		  *(undefined4 *)(param1 + 0x18) = 0;
		  return;
		}
		*/

		}

		// Token: 0x060042F9 RID: 17145 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042F9")]
		[Address(RVA = "0x91AD", Offset = "0x91AD", VA = "0x91AD", Slot = "5")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Gameplay_Clans_Buildings_Golem_Controller_GolemController__Dispose
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5)
		
		{
		  if (DAT_ram_00a57a8e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_GolemModel__GolemEvents__GolemController__GolemInfoWindow___ctor__
		              );
		    DAT_ram_00a57a8e = '\x01';
		  }
		  Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		            (param1,param2,param3,param4,
		             Method_MVC_AbstractViewMediator_GolemModel__GolemEvents__GolemController__GolemInfoWindow___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x040024F5 RID: 9461
		[Token(Token = "0x40024F5")]
		[FieldOffset(Offset = "0x18")]
		private MainService _mainService;
	}
}
