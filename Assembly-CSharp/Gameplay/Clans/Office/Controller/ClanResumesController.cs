using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Gameplay.Clans.Office.Events;
using Gameplay.Clans.Office.Model;
using Google.Protobuf;
using Il2CppDummyDll;
using MVC;
using Protocol.Rating;
using ServicesNamespace;
using UI.Windows;
using Utils;

namespace Gameplay.Clans.Office.Controller
{
	// Token: 0x02000A6E RID: 2670
	[Token(Token = "0x2000A6E")]
	public class ClanResumesController : AbstractController<ClanResumesModel, ClanResumesEvents>
	{
		// Token: 0x17000CA2 RID: 3234
		// (get) Token: 0x06003F68 RID: 16232 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003F69 RID: 16233 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CA2")]
		public ClanInfoController ClanInfoController
		{
			[Token(Token = "0x6003F68")]
			[Address(RVA = "0x8E23", Offset = "0x8E23", VA = "0x8E23")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003F69")]
			[Address(RVA = "0x8E24", Offset = "0x8E24", VA = "0x8E24")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06003F6A RID: 16234 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F6A")]
		[Address(RVA = "0x8E25", Offset = "0x8E25", VA = "0x8E25")]
		public ClanResumesController(ClanResumesModel model, ClanResumesEvents events, ClanInfoController clanInfoController)
		{
		/* --- GHIDRA: <ShowMembersExceededDiaogWindow>b__14_0 ---
		void Gameplay_Clans_Office_Controller_ClanResumesController___ShowMembersExceededDiaogWindow_b__14_0
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5)
		
		{
		  if (DAT_ram_00a57677 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanResumesModel__ClanResumesEvents__ClanResumesController__ClanResumesView___ctor__
		              );
		    DAT_ram_00a57677 = '\x01';
		  }
		  Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		            (param1,param2,param3,param4,
		             Method_MVC_AbstractViewMediator_ClanResumesModel__ClanResumesEvents__ClanResumesController__ClanResumesView___ctor__
		            );
		  return;
		}
		*/

		/* --- GHIDRA: .ctor ---
		void Gameplay_Clans_Office_Controller_ClanResumesController___ctor
		               (int *param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined8 param5,
		               undefined4 param6)
		
		{
		  int param2_00;
		  int iVar1;
		  undefined4 param1_00;
		  undefined4 param1_01;
		  undefined8 uVar2;
		  
		  if (DAT_ram_00a5766f == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_ClanResumesController_GetJoinRequestsResultHandler__
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item(&Protocol_Clans_ProtoGetJoinRequestListCmd_TypeInfo);
		    DAT_ram_00a5766f = '\x01';
		  }
		  param2_00 = unnamed_function_1417(Protocol_Clans_ProtoGetJoinRequestListCmd_TypeInfo);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar2 = *(undefined8 *)(*(int *)(iVar1 + 0x10) + 0x10);
		  *(undefined8 *)(param2_00 + 0x28) = param5;
		  *(undefined4 *)(param2_00 + 0x20) = param4;
		  *(undefined4 *)(param2_00 + 0x1c) = param3;
		  *(undefined4 *)(param2_00 + 0x18) = param2;
		  *(undefined8 *)(param2_00 + 0x10) = uVar2;
		  param1_00 = ServicesNamespace_ClansService__AddToTreasury(param1[6],param2_00,0);
		  param1_01 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_01,param1,
		             Method_Gameplay_Clans_Office_Controller_ClanResumesController_GetJoinRequestsResultHandler__
		             ,0);
		  ServicesNamespace_MainService__GetUserStats
		            (param1_00,param1_01,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  return;
		}
		*/

		}

		// Token: 0x06003F6B RID: 16235 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F6B")]
		[Address(RVA = "0x8E26", Offset = "0x8E26", VA = "0x8E26")]
		public void GetJoinRequests(UserRatingTypes ratingType, RatingPeriods period, uint lastRatingValue, ulong lastUserId)
		{
		/* --- GHIDRA: GetJoinRequests ---
		void Gameplay_Clans_Office_Controller_ClanResumesController__GetJoinRequests
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  int *param1_01;
		  
		  if (DAT_ram_00a57670 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Clans_ProtoGetJoinRequestListAns_TypeInfo);
		    DAT_ram_00a57670 = '\x01';
		  }
		  param1_01 = *(int **)(param2 + 0x20);
		  if ((param1_01 != (int *)0x0) &&
		     (Protocol_Clans_ProtoGetJoinRequestListAns_TypeInfo != *param1_01)) {
		    System_Activator__CreateInstance(param1_01,Protocol_Clans_ProtoGetJoinRequestListAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		  Gameplay_Clans_Office_Model_ClanResumesModel__CreateUsersList(param1_00,param1_01[3],0);
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

		// Token: 0x06003F6C RID: 16236 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F6C")]
		[Address(RVA = "0x8E27", Offset = "0x8E27", VA = "0x8E27")]
		private void GetJoinRequestsResultHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: GetJoinRequestsResultHandler ---
		void Gameplay_Clans_Office_Controller_ClanResumesController__GetJoinRequestsResultHandler
		               (int *param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  int param2_00;
		  int iVar1;
		  undefined4 param1_00;
		  undefined4 param1_01;
		  undefined8 uVar2;
		  
		  if (DAT_ram_00a57671 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_ClanResumesController_GetFirstJoinRequestsResultHandler__
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item(&Protocol_Clans_ProtoGetJoinRequestListCmd_TypeInfo);
		    DAT_ram_00a57671 = '\x01';
		  }
		  param2_00 = unnamed_function_1417(Protocol_Clans_ProtoGetJoinRequestListCmd_TypeInfo);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar2 = *(undefined8 *)(*(int *)(iVar1 + 0x10) + 0x10);
		  *(undefined4 *)(param2_00 + 0x20) = 0xffffffff;
		  *(undefined4 *)(param2_00 + 0x1c) = param3;
		  *(undefined4 *)(param2_00 + 0x18) = param2;
		  *(undefined8 *)(param2_00 + 0x10) = uVar2;
		  param1_00 = ServicesNamespace_ClansService__AddToTreasury(param1[6],param2_00,0);
		  param1_01 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_01,param1,
		             Method_Gameplay_Clans_Office_Controller_ClanResumesController_GetFirstJoinRequestsResultHandler__
		             ,0);
		  ServicesNamespace_MainService__GetUserStats
		            (param1_00,param1_01,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  return;
		}
		*/

		}

		// Token: 0x06003F6D RID: 16237 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F6D")]
		[Address(RVA = "0x8E28", Offset = "0x8E28", VA = "0x8E28")]
		public void GetFirstJoinRequests(UserRatingTypes ratingType, RatingPeriods period)
		{
		/* --- GHIDRA: GetFirstJoinRequests ---
		void Gameplay_Clans_Office_Controller_ClanResumesController__GetFirstJoinRequests
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  int *param1_01;
		  
		  if (DAT_ram_00a57672 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Clans_ProtoGetJoinRequestListAns_TypeInfo);
		    DAT_ram_00a57672 = '\x01';
		  }
		  param1_01 = *(int **)(param2 + 0x20);
		  if ((param1_01 != (int *)0x0) &&
		     (Protocol_Clans_ProtoGetJoinRequestListAns_TypeInfo != *param1_01)) {
		    System_Activator__CreateInstance(param1_01,Protocol_Clans_ProtoGetJoinRequestListAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		  Gameplay_Clans_Office_Model_ClanResumesModel__GetLastPage(param1_00,param1_01[3],0);
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

		// Token: 0x06003F6E RID: 16238 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F6E")]
		[Address(RVA = "0x8E29", Offset = "0x8E29", VA = "0x8E29")]
		private void GetFirstJoinRequestsResultHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: GetFirstJoinRequestsResultHandler ---
		void Gameplay_Clans_Office_Controller_ClanResumesController__GetFirstJoinRequestsResultHandler
		               (int *param1,undefined8 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  int param1_00;
		  undefined8 param2_00;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a57673 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_ClanResumesController_DeclineJoinRequestsResultHandler__
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__SetCustomData__);
		    Mono_Security_ASN1__get_Item(&ulong___TypeInfo);
		    DAT_ram_00a57673 = '\x01';
		  }
		  param1_00 = param1[6];
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  param2_00 = *(undefined8 *)(*(int *)(iVar1 + 0x10) + 0x10);
		  iVar1 = Mono_Security_ASN1Convert__ToOid(ulong___TypeInfo,1);
		  *(undefined8 *)(iVar1 + 0x10) = param2;
		  uVar2 = ServicesNamespace_ClansService__ApproveJoinRequest(param1_00,param2_00,iVar1,0);
		  uVar3 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar3,param1,
		             Method_Gameplay_Clans_Office_Controller_ClanResumesController_DeclineJoinRequestsResultHandler__
		             ,0);
		  uVar2 = ServicesNamespace_MainService__GetUserStats
		                    (uVar2,uVar3,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  local_8 = param2;
		  uVar3 = func_ii_1081(DAT_ram_00a66968,&local_8);
		  DG_Tweening_TweenParams__SetId(uVar2,uVar3,Method_Utils_OpToken_IMessage__object__SetCustomData__)
		  ;
		  return;
		}
		*/

		}

		// Token: 0x06003F6F RID: 16239 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F6F")]
		[Address(RVA = "0x8E2A", Offset = "0x8E2A", VA = "0x8E2A")]
		public void DeclineJoinRequest(ulong userId)
		{
		/* --- GHIDRA: DeclineJoinRequest ---
		void Gameplay_Clans_Office_Controller_ClanResumesController__DeclineJoinRequest
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 in_register_20000014;
		  undefined8 *puVar1;
		  int iVar2;
		  int *param1_00;
		  undefined8 uVar3;
		  
		  param1_00 = *(int **)(param2 + 0xc);
		  if (param1_00 == (int *)0x0) {
		    System_Collections_Generic_Comparer_ValueTuple_int__Int32Enum__object____get_Default();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  if (*(int *)(*param1_00 + 0x20) == *(int *)(DAT_ram_00a66968 + 0x20)) {
		    puVar1 = (undefined8 *)func_ii_15774(param1_00);
		    uVar3 = *puVar1;
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x114)));
		    iVar2 = *(int *)(iVar2 + 0x20);
		    if (iVar2 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		                (*(undefined4 *)(iVar2 + 0x20),uVar3,*(undefined4 *)(iVar2 + 0x14));
		    }
		    return;
		  }
		  System_Activator__CreateInstance(param1_00,DAT_ram_00a66968);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06003F70 RID: 16240 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F70")]
		[Address(RVA = "0x8E2B", Offset = "0x8E2B", VA = "0x8E2B")]
		private void DeclineJoinRequestsResultHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: DeclineJoinRequestsResultHandler ---
		void Gameplay_Clans_Office_Controller_ClanResumesController__DeclineJoinRequestsResultHandler
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 in_register_20000014;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param1_00;
		  undefined8 param3_00;
		  int param1_01;
		  undefined8 param2_00;
		  
		  if (DAT_ram_00a57674 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_ClanResumesController_AcceptJoinRequestResultHandler__
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__SetCustomData__);
		    DAT_ram_00a57674 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x104)));
		  iVar1 = *(int *)(*(int *)(iVar1 + 0x10) + 0x30);
		  if ((longlong)(ulonglong)*(uint *)(*(int *)(iVar1 + 8) + 0x1c) <= (longlong)*(int *)(iVar1 + 0x10)
		     ) {
		    Gameplay_Clans_Office_Controller_ClanResumesController__AcceptJoinRequestResultHandler
		              (param1,param1);
		    return;
		  }
		  param1_01 = param1[6];
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  param2_00 = *(undefined8 *)(*(int *)(iVar1 + 0x10) + 0x10);
		  param3_00 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext(param2,0);
		  uVar2 = ServicesNamespace_ClansService__GetJoinRequestList(param1_01,param2_00,param3_00,0);
		  param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_Clans_Office_Controller_ClanResumesController_AcceptJoinRequestResultHandler__
		             ,0);
		  uVar2 = ServicesNamespace_MainService__GetUserStats
		                    (uVar2,param1_00,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  DG_Tweening_TweenParams__SetId
		            (uVar2,param2,Method_Utils_OpToken_IMessage__object__SetCustomData__);
		  return;
		}
		*/

		}

		// Token: 0x06003F71 RID: 16241 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F71")]
		[Address(RVA = "0x8E2C", Offset = "0x8E2C", VA = "0x8E2C")]
		public void AcceptJoinRequest(UserData user)
		{
		/* --- GHIDRA: AcceptJoinRequest ---
		void Gameplay_Clans_Office_Controller_ClanResumesController__AcceptJoinRequest
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 in_register_20000014;
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  undefined4 param1_00;
		  undefined8 uVar4;
		  int *piVar5;
		  undefined4 param3_00;
		  
		  if (DAT_ram_00a57675 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Events_Scopes_UserScope_BaseUserEventArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Clans_ProtoApproveJoinRequestAns_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Data_UserData_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4271);
		    DAT_ram_00a57675 = '\x01';
		  }
		  piVar5 = *(int **)(param2 + 0x20);
		  if ((piVar5 != (int *)0x0) && (Protocol_Clans_ProtoApproveJoinRequestAns_TypeInfo != *piVar5)) {
		    System_Activator__CreateInstance(piVar5,Protocol_Clans_ProtoApproveJoinRequestAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  if (piVar5[3] == -1) {
		    uVar1 = System_Uri___ctor(0);
		    uVar1 = System_Globalization_TimeSpanFormat_FormatLiterals__get_DayHourSep(uVar1,0);
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar3 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4271,1,0,1,0,0,0,0);
		    Core_Application_App__get_ToastController(uVar1,2,uVar3,0);
		    return;
		  }
		  uVar4 = CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x104));
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(param1,uVar4);
		  iVar2 = *(int *)(*(int *)(iVar2 + 0x10) + 0x30);
		  *(int *)(iVar2 + 0x10) = *(int *)(iVar2 + 0x10) + 1;
		  piVar5 = *(int **)(param2 + 0xc);
		  if (piVar5 != (int *)0x0) {
		    if (((uint)*(byte *)(*piVar5 + 0xb8) < (uint)*(byte *)(Core_Data_UserData_TypeInfo + 0xb8)) ||
		       (*(int *)(*(int *)(*piVar5 + 100) + (uint)*(byte *)(Core_Data_UserData_TypeInfo + 0xb8) * 4 +
		                -4) != Core_Data_UserData_TypeInfo)) {
		      System_Activator__CreateInstance(piVar5,Core_Data_UserData_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  uVar4 = CONCAT44((int)((ulonglong)uVar4 >> 0x20),*(undefined4 *)(*param1 + 0x114));
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))(param1,uVar4);
		  uVar1 = (undefined4)((ulonglong)uVar4 >> 0x20);
		  iVar2 = *(int *)(iVar2 + 0x20);
		  if (iVar2 != 0) {
		    uVar4 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext(piVar5,0);
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		              (*(undefined4 *)(iVar2 + 0x20),uVar4,*(undefined4 *)(iVar2 + 0x14));
		    uVar1 = (undefined4)((ulonglong)uVar4 >> 0x20);
		  }
		  iVar2 = System_Uri___ctor(0);
		  iVar2 = *(int *)(*(int *)(*(int *)(*(int *)(iVar2 + 0x38) + 0x10) + 0x84) + 0x10);
		  if (iVar2 != 0) {
		    uVar3 = System_Uri___ctor(0);
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    param3_00 = **(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    param1_00 = unnamed_function_1417(Core_Events_Scopes_UserScope_BaseUserEventArgs_TypeInfo);
		    Core_Events_Scopes_UserScope_BaseUserEventArgs__set_UserData(param1_00,uVar3,param3_00,piVar5,0)
		    ;
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		              (*(undefined4 *)(iVar2 + 0x20),CONCAT44(uVar1,param1_00),*(undefined4 *)(iVar2 + 0x14)
		              );
		  }
		  return;
		}
		*/

		}

		// Token: 0x06003F72 RID: 16242 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F72")]
		[Address(RVA = "0x8E2D", Offset = "0x8E2D", VA = "0x8E2D")]
		private void AcceptJoinRequestResultHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: AcceptJoinRequestResultHandler ---
		undefined4
		Gameplay_Clans_Office_Controller_ClanResumesController__AcceptJoinRequestResultHandler
		          (int *param1,undefined4 param2)
		
		{
		  int param1_00;
		  undefined4 uVar1;
		  int param1_01;
		  int param1_02;
		  int iVar2;
		  int iVar3;
		  uint uVar4;
		  
		  if (DAT_ram_00a57676 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_DialogWindow_DialogWindowArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_DialogWindow_DialogWindowArgs___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_DialogWindow_DialogWindowArgs__set_Callback__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_DialogWindow_DialogWindowArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_ClanResumesController__ShowMembersExceededDiaogWindow_b__14_0__
		              );
		    Mono_Security_ASN1__get_Item(&UI_Windows_DialogWindow_DialogWindowArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___Add__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs____ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_PriceHolder_DialogWindow_DialogWindowArgs___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_PriceHolder_DialogWindow_DialogWindowArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&StringLiteral_4333);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4332);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4324);
		    DAT_ram_00a57676 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(UI_Windows_DialogWindow_DialogWindowArgs_TypeInfo);
		  func_ii_8625(param1_00,0);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar1 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4333,1,0,1,0,0,0,0);
		  *(undefined4 *)(param1_00 + 0x18) = uVar1;
		  uVar1 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4332,1,0,1,0,0,0,0);
		  *(undefined4 *)(param1_00 + 0x1c) = uVar1;
		  param1_01 = unnamed_function_1417
		                        (
		                        System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___TypeInfo
		                        );
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_01,
		             Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs____ctor__
		            );
		  param1_02 = unnamed_function_1417
		                        (
		                        UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs__TypeInfo
		                        );
		  UI_Windows_DialogWindow_DialogWindowArgs___ctor
		            (param1_02,
		             Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___ctor__
		            );
		  uVar1 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4324,1,0,1,0,0,0,0);
		  *(undefined4 *)(param1_02 + 8) = uVar1;
		  iVar2 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_PriceHolder_DialogWindow_DialogWindowArgs__TypeInfo
		                    );
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  *(undefined4 *)(iVar2 + 0xc) = *(undefined4 *)(*(int *)(*(int *)(iVar3 + 0x10) + 0x24) + 0x18);
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar1 = Gameplay_Clans_Office_Model_ClanInfoModel__PopulateMembers
		                    (*(undefined4 *)(iVar3 + 0x10),0);
		  if (*(int *)(Core_Money_Money_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Money_Money_TypeInfo);
		  }
		  uVar1 = Core_Money_Money__op_Explicit(uVar1,0);
		  *(undefined4 *)(iVar2 + 8) = uVar1;
		  *(int *)(param1_02 + 0x10) = iVar2;
		  iVar2 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_DialogWindow_DialogWindowArgs__TypeInfo
		                    );
		  uVar1 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_DialogWindow_DialogWindowArgs__TypeInfo
		                    );
		  UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_object____ctor
		            (uVar1,param1,
		             Method_Gameplay_Clans_Office_Controller_ClanResumesController__ShowMembersExceededDiaogWindow_b__14_0__
		             ,0);
		  *(undefined4 *)(iVar2 + 8) = uVar1;
		  *(int *)(param1_02 + 0x14) = iVar2;
		  iVar2 = 
		  Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___Add__
		  ;
		  *(int *)(param1_01 + 0x10) = *(int *)(param1_01 + 0x10) + 1;
		  uVar4 = *(uint *)(param1_01 + 0xc);
		  if (uVar4 < *(uint *)(*(int *)(param1_01 + 8) + 0xc)) {
		    *(uint *)(param1_01 + 0xc) = uVar4 + 1;
		    *(int *)(*(int *)(param1_01 + 8) + uVar4 * 4 + 0x10) = param1_02;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (param1_01,param1_02,*(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x60) + 0x38));
		  }
		  *(int *)(param1_00 + 0x24) = param1_01;
		  uVar1 = UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_object____ctor
		                    (param1_00,0);
		  return uVar1;
		}
		*/

		}

		// Token: 0x06003F73 RID: 16243 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003F73")]
		[Address(RVA = "0x8E2E", Offset = "0x8E2E", VA = "0x8E2E")]
		private DialogWindow ShowMembersExceededDiaogWindow()
		{
		/* --- GHIDRA: ShowMembersExceededDiaogWindow ---
		void Gameplay_Clans_Office_Controller_ClanResumesController__ShowMembersExceededDiaogWindow
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  Gameplay_Clans_Office_Controller_ClanInfoController__AppointHeadResultHandler
		            (*(undefined4 *)(param1 + 0x1c),0);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x0400239F RID: 9119
		[Token(Token = "0x400239F")]
		[FieldOffset(Offset = "0x18")]
		private ClansService _clansService;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_ClanInfoController ---
		void Gameplay_Clans_Office_Controller_ClanResumesController__set_ClanInfoController
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5766e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_MVC_AbstractController_ClanResumesModel__ClanResumesEvents___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_ClansService___);
		    Mono_Security_ASN1__get_Item(&Core_Net_ServiceFactory_TypeInfo);
		    DAT_ram_00a5766e = '\x01';
		  }
		  Gameplay_Combat_AbstractCombat_object__object__object__object__object___set_User
		            (param1,param2,param3,
		             Method_MVC_AbstractController_ClanResumesModel__ClanResumesEvents___ctor__);
		  if (*(int *)(Core_Net_ServiceFactory_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_ServiceFactory_TypeInfo);
		  }
		  uVar1 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                    (Method_Core_Net_ServiceFactory_GetService_ClansService___);
		  *(undefined4 *)(param1 + 0x1c) = param4;
		  *(undefined4 *)(param1 + 0x18) = uVar1;
		  return;
		}
		*/

}
