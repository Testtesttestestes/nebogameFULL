using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Core.Data;
using Gameplay.Clans.Events;
using Gameplay.Clans.Model;
using Gameplay.World.Model;
using Google.Protobuf;
using Il2CppDummyDll;
using MVC;
using Protocol.Chat;
using Protocol.ClanIsle;
using Protocol.Clans;
using Protocol.Common;
using ServicesNamespace;
using Utils;
using Utils.Accumulators;

namespace Gameplay.Clans.Controller
{
	// Token: 0x02000A8D RID: 2701
	[Token(Token = "0x2000A8D")]
	public class ClansController : AbstractController<ClansModel, Gameplay.Clans.Events.ClansEvents>
	{
		// Token: 0x060040AD RID: 16557 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040AD")]
		[Address(RVA = "0x8F64", Offset = "0x8F64", VA = "0x8F64")]
		public ClansController(ClansModel model, Gameplay.Clans.Events.ClansEvents events)
		{
		/* --- GHIDRA: <AssignClanIsleToUser>g__GetShortClanInfoResultHandler|27_0 ---
		void Gameplay_Clans_Controller_ClansController___AssignClanIsleToUser_g__GetShortClanInfoResultHandler_27_0
		               (int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a57760 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_ClanCombatModel__ClanCombatEvents__ClanCombatController__ClanCombatViewMediator__ClanCombatView__Dispose__
		              );
		    DAT_ram_00a57760 = '\x01';
		  }
		  *(undefined4 *)(param1 + 0x28) = 0;
		  Gameplay_Combat_AbstractCombat_object__object__object__object__object___CheckRunRestrictions
		            (param1,
		             Method_Gameplay_Combat_AbstractCombat_ClanCombatModel__ClanCombatEvents__ClanCombatController__ClanCombatViewMediator__ClanCombatView__Dispose__
		            );
		  return;
		}
		*/

		/* --- GHIDRA: <HandleInit>g__GetOwnClanIsleInfoResultHandler|26_1 ---
		void Gameplay_Clans_Controller_ClansController___HandleInit_g__GetOwnClanIsleInfoResultHandler_26_1
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int *param1_00;
		  
		  if (DAT_ram_00a5775f == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Clans_ProtoGetShortClansInfoAns_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ClanShortInfo__get_Item__);
		    DAT_ram_00a5775f = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  param1_00 = *(int **)(param2 + 0x20);
		  if ((param1_00 != (int *)0x0) && (Protocol_Clans_ProtoGetShortClansInfoAns_TypeInfo != *param1_00)
		     ) {
		    System_Activator__CreateInstance(param1_00,Protocol_Clans_ProtoGetShortClansInfoAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  iVar1 = *(int *)(*(int *)(iVar1 + 8) + 0x34);
		  uVar2 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                    (param1_00[3],0,
		                     Method_Google_Protobuf_Collections_RepeatedField_ClanShortInfo__get_Item__);
		  *(undefined4 *)(iVar1 + 0x40) = uVar2;
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

		/* --- GHIDRA: <HandleInit>g__GetOwnClanIsleInfo|26_0 ---
		void Gameplay_Clans_Controller_ClansController___HandleInit_g__GetOwnClanIsleInfo_26_0
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  int iVar3;
		  undefined4 param1_00;
		  int *param1_01;
		  undefined4 param3_00;
		  undefined4 param4;
		  
		  if (DAT_ram_00a5775e == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Events_Scopes_UserScope_BaseUserEventArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_PopupController_Close_ClanOfficeWindow___);
		    Mono_Security_ASN1__get_Item(&Protocol_ClanIsle_ProtoGetIsleInfoAns_TypeInfo);
		    DAT_ram_00a5775e = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  param1_01 = *(int **)(param2 + 0x20);
		  if ((param1_01 != (int *)0x0) && (Protocol_ClanIsle_ProtoGetIsleInfoAns_TypeInfo != *param1_01)) {
		    System_Activator__CreateInstance(param1_01,Protocol_ClanIsle_ProtoGetIsleInfoAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  Gameplay_Clans_Controller_ClansController__HandleInit(param1,param1_01[3],param1);
		  uVar1 = System_Uri___ctor(0);
		  uVar1 = System_Globalization_TimeSpanFormat_FormatLiterals__get_Start(uVar1,0);
		  DG_Tweening_Plugins_Core_PluginsManager__GetDefaultPlugin___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType____Il2CppFullySharedGenericStructType_
		            (uVar1,0,Method_UI_Windows_PopupController_Close_ClanOfficeWindow___);
		  *(undefined1 *)((int)param1 + 9) = 1;
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar2 = *(int *)(iVar2 + 8);
		  if (iVar2 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		              (*(undefined4 *)(iVar2 + 0x20),*(undefined4 *)(iVar2 + 0x14));
		  }
		  iVar2 = System_Uri___ctor(0);
		  iVar2 = *(int *)(*(int *)(*(int *)(*(int *)(iVar2 + 0x38) + 0x10) + 0xc) + 0x3c);
		  if (iVar2 != 0) {
		    uVar1 = System_Uri___ctor(0);
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    param3_00 = **(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    param4 = *(undefined4 *)(iVar3 + 8);
		    param1_00 = unnamed_function_1417(Core_Events_Scopes_UserScope_BaseUserEventArgs_TypeInfo);
		    Core_Events_Scopes_UserScope_BaseUserEventArgs__set_UserData(param1_00,uVar1,param3_00,param4,0)
		    ;
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		              (*(undefined4 *)(iVar2 + 0x20),param1_00,*(undefined4 *)(iVar2 + 0x14));
		  }
		  return;
		}
		*/

		/* --- GHIDRA: .ctor ---
		void Gameplay_Clans_Controller_ClansController___ctor(undefined4 param1,undefined4 param2)
		
		{
		  Gameplay_Clans_Controller_ClansController__TreasuryChangedEventHandler(param1,param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x060040AE RID: 16558 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040AE")]
		[Address(RVA = "0x8F65", Offset = "0x8F65", VA = "0x8F65")]
		public void AssignNewClanToUser()
		{
		/* --- GHIDRA: AssignNewClanToUser ---
		void Gameplay_Clans_Controller_ClansController__AssignNewClanToUser(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a57746 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoTreasuryChangedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Clans_Controller_ClansController_TreasuryChangedEventHandler__);
		    DAT_ram_00a57746 = '\x01';
		  }
		  param1_01 = *(undefined4 *)(param1 + 0x18);
		  param1_00 = unnamed_function_1417(System_Action_ProtoTreasuryChangedEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_Clans_Controller_ClansController_TreasuryChangedEventHandler__,0);
		  ServicesNamespace_ClansService__add_TreasuryChangedEvent(param1_01,param1_00,0);
		  Gameplay_Clans_Controller_ClansController__DissociateClanFromUser(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x060040AF RID: 16559 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040AF")]
		[Address(RVA = "0x8F66", Offset = "0x8F66", VA = "0x8F66")]
		public void DissociateClanFromUser()
		{
		/* --- GHIDRA: DissociateClanFromUser ---
		void Gameplay_Clans_Controller_ClansController__DissociateClanFromUser(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a57747 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Clans_Controller_ClansController_GetOwnClanInfoResultHandler__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    DAT_ram_00a57747 = '\x01';
		  }
		  param1_00 = ServicesNamespace_ClansService__ServerEventHandler(*(undefined4 *)(param1 + 0x18),0);
		  param1_01 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_01,param1,
		             Method_Gameplay_Clans_Controller_ClansController_GetOwnClanInfoResultHandler__,0);
		  ServicesNamespace_MainService__GetUserStats
		            (param1_00,param1_01,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  return;
		}
		*/

		}

		// Token: 0x060040B0 RID: 16560 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040B0")]
		[Address(RVA = "0x8F67", Offset = "0x8F67", VA = "0x8F67")]
		private void GetOwnClanInfo()
		{
		/* --- GHIDRA: GetOwnClanInfo ---
		void Gameplay_Clans_Controller_ClansController__GetOwnClanInfo
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int *param1_00;
		  undefined8 uVar2;
		  
		  uVar2 = 0;
		  if (DAT_ram_00a57748 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Clans_ProtoGetOwnClanInfoAns_TypeInfo);
		    DAT_ram_00a57748 = '\x01';
		  }
		  param1_00 = *(int **)(param2 + 0x20);
		  if ((param1_00 != (int *)0x0) && (Protocol_Clans_ProtoGetOwnClanInfoAns_TypeInfo != *param1_00)) {
		    System_Activator__CreateInstance(param1_00,Protocol_Clans_ProtoGetOwnClanInfoAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  if ((char)param1_00[6] == '\0') {
		    uVar2 = *(undefined8 *)(param1_00 + 4);
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  *(undefined8 *)(iVar1 + 0x10) = uVar2;
		  Gameplay_Clans_Controller_ClansController__NewClanAssignedEventHandler(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x060040B1 RID: 16561 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040B1")]
		[Address(RVA = "0x8F68", Offset = "0x8F68", VA = "0x8F68")]
		private void GetOwnClanInfoResultHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: GetOwnClanInfoResultHandler ---
		void Gameplay_Clans_Controller_ClansController__GetOwnClanInfoResultHandler
		               (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a57749 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Clans_Controller_ClansController_GetClanTreasuryResultHandler__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    DAT_ram_00a57749 = '\x01';
		  }
		  uVar1 = ServicesNamespace_ClansService__SetClanStateFlags(*(undefined4 *)(param1 + 0x18),0);
		  param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_Clans_Controller_ClansController_GetClanTreasuryResultHandler__,0);
		  uVar1 = ServicesNamespace_MainService__GetUserStats
		                    (uVar1,param1_00,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  Utils_OpToken_int__object___AddHandlers(param1,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x060040B2 RID: 16562 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040B2")]
		[Address(RVA = "0x8F69", Offset = "0x8F69", VA = "0x8F69")]
		private void GetClanTreasury()
		{
		/* --- GHIDRA: GetClanTreasury ---
		void Gameplay_Clans_Controller_ClansController__GetClanTreasury
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  int *param1_00;
		  
		  if (DAT_ram_00a5774a == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Clans_ProtoGetClanTreasuryAns_TypeInfo);
		    DAT_ram_00a5774a = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  param1_00 = *(int **)(param2 + 0x20);
		  if ((param1_00 != (int *)0x0) && (Protocol_Clans_ProtoGetClanTreasuryAns_TypeInfo != *param1_00))
		  {
		    System_Activator__CreateInstance(param1_00,Protocol_Clans_ProtoGetClanTreasuryAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  if (DAT_ram_00a5773f == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Clans_Model_TreasuryData_TypeInfo);
		    DAT_ram_00a5773f = '\x01';
		  }
		  iVar2 = unnamed_function_1417(Gameplay_Clans_Model_TreasuryData_TypeInfo);
		  *(int *)(iVar2 + 8) = param1_00[3];
		  *(int *)(iVar2 + 0xc) = param1_00[4];
		  *(int *)(iVar1 + 0x18) = iVar2;
		  return;
		}
		*/

		}

		// Token: 0x060040B3 RID: 16563 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040B3")]
		[Address(RVA = "0x8F6A", Offset = "0x8F6A", VA = "0x8F6A")]
		private void GetClanTreasuryResultHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: GetClanTreasuryResultHandler ---
		void Gameplay_Clans_Controller_ClansController__GetClanTreasuryResultHandler
		               (int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a5774b == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Clans_Controller_ClansController_UpdateClanTreasuryResultHandler__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    DAT_ram_00a5774b = '\x01';
		  }
		  param1_00 = ServicesNamespace_ClansService__SetClanStateFlags(*(undefined4 *)(param1 + 0x18),0);
		  param1_01 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_01,param1,
		             Method_Gameplay_Clans_Controller_ClansController_UpdateClanTreasuryResultHandler__,0);
		  ServicesNamespace_MainService__GetUserStats
		            (param1_00,param1_01,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  return;
		}
		*/

		}

		// Token: 0x060040B4 RID: 16564 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040B4")]
		[Address(RVA = "0x8F6B", Offset = "0x8F6B", VA = "0x8F6B")]
		public void UpdateClanTreasury()
		{
		/* --- GHIDRA: UpdateClanTreasury ---
		void Gameplay_Clans_Controller_ClansController__UpdateClanTreasury
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int *param1_00;
		  
		  if (DAT_ram_00a5774c == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Clans_ProtoGetClanTreasuryAns_TypeInfo);
		    DAT_ram_00a5774c = '\x01';
		  }
		  param1_00 = *(int **)(param2 + 0x20);
		  if ((param1_00 != (int *)0x0) && (Protocol_Clans_ProtoGetClanTreasuryAns_TypeInfo != *param1_00))
		  {
		    System_Activator__CreateInstance(param1_00,Protocol_Clans_ProtoGetClanTreasuryAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  iVar1 = *(int *)(iVar1 + 0x18);
		  *(int *)(iVar1 + 8) = param1_00[3];
		  *(int *)(iVar1 + 0xc) = param1_00[4];
		  return;
		}
		*/

		}

		// Token: 0x060040B5 RID: 16565 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040B5")]
		[Address(RVA = "0x8F6C", Offset = "0x8F6C", VA = "0x8F6C")]
		private void UpdateClanTreasuryResultHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: UpdateClanTreasuryResultHandler ---
		void Gameplay_Clans_Controller_ClansController__UpdateClanTreasuryResultHandler
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 in_register_20000014;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param1_00;
		  undefined8 param3_00;
		  int param1_01;
		  undefined8 param2_00;
		  
		  if (DAT_ram_00a5774d == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Clans_Controller_ClansController_KickMemberResultHandler__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__SetCustomData__);
		    DAT_ram_00a5774d = '\x01';
		  }
		  param1_01 = param1[6];
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x104)));
		  param2_00 = *(undefined8 *)(iVar1 + 0x10);
		  param3_00 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext(param2,0);
		  uVar2 = ServicesNamespace_ClansService__ChangeClanInfo(param1_01,param2_00,param3_00,0);
		  param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_Clans_Controller_ClansController_KickMemberResultHandler__,0);
		  uVar2 = ServicesNamespace_MainService__GetUserStats
		                    (uVar2,param1_00,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  DG_Tweening_TweenParams__SetId
		            (uVar2,param2,Method_Utils_OpToken_IMessage__object__SetCustomData__);
		  return;
		}
		*/

		}

		// Token: 0x060040B6 RID: 16566 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040B6")]
		[Address(RVA = "0x8F6D", Offset = "0x8F6D", VA = "0x8F6D")]
		public void KickMember(UserData userData)
		{
		/* --- GHIDRA: KickMember ---
		void Gameplay_Clans_Controller_ClansController__KickMember(int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 in_register_20000014;
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  undefined8 param2_00;
		  int *param1_00;
		  int *param1_01;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5774e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_WorldAxis_ClanEquipment_View_ClanEquipmentWindow_ClanEquipmentWindowArgs_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedKickMemberErrors___
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_ulong___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Clans_ProtoKickMemberAns_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Data_UserData_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12685);
		    DAT_ram_00a5774e = '\x01';
		  }
		  param1_00 = *(int **)(param2 + 0x20);
		  if ((param1_00 != (int *)0x0) && (Protocol_Clans_ProtoKickMemberAns_TypeInfo != *param1_00)) {
		    System_Activator__CreateInstance(param1_00,Protocol_Clans_ProtoKickMemberAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param1_01 = *(int **)(param2 + 0xc);
		  if (param1_01 != (int *)0x0) {
		    if (((uint)*(byte *)(*param1_01 + 0xb8) < (uint)*(byte *)(Core_Data_UserData_TypeInfo + 0xb8))
		       || (*(int *)(*(int *)(*param1_01 + 100) +
		                    (uint)*(byte *)(Core_Data_UserData_TypeInfo + 0xb8) * 4 + -4) !=
		           Core_Data_UserData_TypeInfo)) {
		      System_Activator__CreateInstance(param1_01,Core_Data_UserData_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = UnityEngine_EventSystems_ExecuteEvents__ValidateEventData_object_
		                    (param1_00[3],0,
		                     Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedKickMemberErrors___
		                    );
		  if ((iVar1 != 0) && (param1_00[3] == -2)) {
		    uVar2 = System_Uri___ctor(0);
		    uVar2 = System_Globalization_TimeSpanFormat_FormatLiterals__get_Start(uVar2,0);
		    iVar1 = unnamed_function_1417
		                      (
		                      Gameplay_WorldAxis_ClanEquipment_View_ClanEquipmentWindow_ClanEquipmentWindowArgs_TypeInfo
		                      );
		    Gameplay_AccountLinker_View_SelectUserWindow___ctor(iVar1,0);
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x104)));
		    *(undefined4 *)(iVar1 + 0x18) = *(undefined4 *)(iVar3 + 8);
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    *(undefined4 *)(iVar1 + 0x1c) = *(undefined4 *)(iVar3 + 0x20);
		    param2_00 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext(param1_01,0);
		    local_8 = 0;
		    local_10 = 0;
		    Core_Log_Files_FileDownloadLogger__LogDownload
		              (&local_10,param2_00,Method_System_Nullable_ulong___ctor__);
		    *(undefined8 *)(iVar1 + 0x28) = local_8;
		    *(undefined8 *)(iVar1 + 0x20) = local_10;
		    UI_Windows_PopupController__set_TopWindow(uVar2,StringLiteral_12685,iVar1,0,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x060040B7 RID: 16567 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040B7")]
		[Address(RVA = "0x8F6E", Offset = "0x8F6E", VA = "0x8F6E")]
		private void KickMemberResultHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: KickMemberResultHandler ---
		void Gameplay_Clans_Controller_ClansController__KickMemberResultHandler
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 in_register_20000014;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param1_00;
		  undefined4 uVar3;
		  undefined8 param2_00;
		  int param1_01;
		  
		  if (DAT_ram_00a5774f == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Clans_Controller_ClansController_LeaveClanResultHandler__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__SetCustomData__);
		    DAT_ram_00a5774f = '\x01';
		  }
		  param1_01 = param1[6];
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x104)));
		  param2_00 = Core_Data_UserData___ctor(*(undefined4 *)(iVar1 + 8),0);
		  uVar2 = ServicesNamespace_ClansService__OnUnregisterClan(param1_01,param2_00,0);
		  uVar3 = (undefined4)((ulonglong)param2_00 >> 0x20);
		  param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_Clans_Controller_ClansController_LeaveClanResultHandler__,0);
		  uVar2 = ServicesNamespace_MainService__GetUserStats
		                    (uVar2,param1_00,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,CONCAT44(uVar3,*(undefined4 *)(*param1 + 0x104)));
		  uVar3 = DG_Tweening_TweenParams__SetId
		                    (uVar2,*(undefined4 *)(*(int *)(iVar1 + 8) + 0x68),
		                     Method_Utils_OpToken_IMessage__object__SetCustomData__);
		  Utils_OpToken_int__object___AddHandlers(param1,uVar3,0);
		  return;
		}
		*/

		}

		// Token: 0x060040B8 RID: 16568 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040B8")]
		[Address(RVA = "0x8F6F", Offset = "0x8F6F", VA = "0x8F6F")]
		public void LeaveClan()
		{
		/* --- GHIDRA: LeaveClan ---
		void Gameplay_Clans_Controller_ClansController__LeaveClan
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 param2_00;
		  undefined4 param1_00;
		  int *piVar2;
		  undefined4 param3_00;
		  
		  if (DAT_ram_00a57750 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Events_Scopes_ClansScope_BaseClansEventArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_World_Model_ClanData_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedKickMemberErrors___
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Clans_ProtoKickMemberAns_TypeInfo);
		    DAT_ram_00a57750 = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  piVar2 = *(int **)(param2 + 0x20);
		  if ((piVar2 != (int *)0x0) && (Protocol_Clans_ProtoKickMemberAns_TypeInfo != *piVar2)) {
		    System_Activator__CreateInstance(piVar2,Protocol_Clans_ProtoKickMemberAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar1 = UnityEngine_EventSystems_ExecuteEvents__ValidateEventData_object_
		                    (piVar2[3],0,
		                     Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedKickMemberErrors___
		                    );
		  if (iVar1 == 0) {
		    iVar1 = System_Uri___ctor(0);
		    iVar1 = *(int *)(*(int *)(*(int *)(*(int *)(iVar1 + 0x38) + 0x10) + 0x84) + 0x3c);
		    if (iVar1 != 0) {
		      param2_00 = System_Uri___ctor(0);
		      if (DAT_ram_00a6456f == '\0') {
		        Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		        DAT_ram_00a6456f = '\x01';
		      }
		      piVar2 = *(int **)(param2 + 0xc);
		      param3_00 = **(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		      param1_00 = unnamed_function_1417(Core_Events_Scopes_ClansScope_BaseClansEventArgs_TypeInfo);
		      if (piVar2 != (int *)0x0) {
		        if (((uint)*(byte *)(*piVar2 + 0xb8) <
		             (uint)*(byte *)(Gameplay_World_Model_ClanData_TypeInfo + 0xb8)) ||
		           (*(int *)(*(int *)(*piVar2 + 100) +
		                     (uint)*(byte *)(Gameplay_World_Model_ClanData_TypeInfo + 0xb8) * 4 + -4) !=
		            Gameplay_World_Model_ClanData_TypeInfo)) {
		          System_Activator__CreateInstance(piVar2,Gameplay_World_Model_ClanData_TypeInfo);
		          do {
		            halt_trap();
		          } while( true );
		        }
		      }
		      Core_Events_Scopes_UserScope_BaseUserEventArgs__set_UserData
		                (param1_00,param2_00,param3_00,piVar2,0);
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),param1_00,*(undefined4 *)(iVar1 + 0x14));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x060040B9 RID: 16569 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040B9")]
		[Address(RVA = "0x8F70", Offset = "0x8F70", VA = "0x8F70")]
		private void LeaveClanResultHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: LeaveClanResultHandler ---
		void Gameplay_Clans_Controller_ClansController__LeaveClanResultHandler
		               (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int *param1_00;
		  int iVar5;
		  int iVar6;
		  undefined4 uVar7;
		  
		  if (DAT_ram_00a57751 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Utils_Accumulators_AccumulatorBase_int__TriggerValue__remove_UpdateEvent__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Utils_Accumulators_AccumulatorBase_AccumulatorUpdateDelegate_int__TriggerValue__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoUserLeftClanEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ulong__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoTreasuryChangedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoUserInfoChangedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoClanLeaderChangedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Clans_Controller_ClansController_ClanLeaderChangedEventHandler__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Clans_Controller_ClansController_ClansServiceOnUserLeftClanEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Clans_Controller_ClansController_HandleCurrentIsleChangedEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Clans_Controller_ClansController_NewClanAssignedEventHandler__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Clans_Controller_ClansController_TreasuryChangedEventHandler__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Clans_Controller_ClansController_TriggerChangedEventHandler__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Clans_Controller_ClansController_UserInfoChangedEventHandler__);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_ChatService___);
		    Mono_Security_ASN1__get_Item(&Core_Net_ServiceFactory_TypeInfo);
		    DAT_ram_00a57751 = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar5 = *param1_00;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x110);
		        goto code_r0x80dd3c35;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,10);
		code_r0x80dd3c35:
		  iVar5 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  iVar6 = *(int *)(iVar5 + 0xc);
		  uVar7 = *(undefined4 *)(iVar6 + 0x1c);
		  uVar3 = unnamed_function_1417(System_Action_ulong__TypeInfo);
		  func_ii_6877(uVar3,param1,
		               Method_Gameplay_Clans_Controller_ClansController_HandleCurrentIsleChangedEvent__,0);
		  iVar5 = func_ii_7048(uVar7,uVar3,0);
		  uVar3 = System_Action_ulong__TypeInfo;
		  if (iVar5 == 0) {
		    *(undefined4 *)(iVar6 + 0x1c) = 0;
		  }
		  else {
		    iVar4 = func_ii_1082(iVar5,System_Action_ulong__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar5,uVar3);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar6 + 0x1c) = iVar4;
		    uVar3 = System_Action_ulong__TypeInfo;
		    iVar6 = func_ii_1082(iVar5,System_Action_ulong__TypeInfo);
		    if (iVar6 == 0) {
		      System_Activator__CreateInstance(iVar5,uVar3);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar5 = param1[6];
		  uVar3 = unnamed_function_1417(System_Action_ProtoTreasuryChangedEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar3,param1,
		             Method_Gameplay_Clans_Controller_ClansController_TreasuryChangedEventHandler__,0);
		  ServicesNamespace_ClansService__add_TreasuryChangedEvent(iVar5,uVar3,0);
		  iVar5 = param1[6];
		  uVar3 = unnamed_function_1417(System_Action_ProtoTreasuryChangedEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar3,param1,
		             Method_Gameplay_Clans_Controller_ClansController_NewClanAssignedEventHandler__,0);
		  ServicesNamespace_ClansService__add_TreasuryChangedEvent(iVar5,uVar3,0);
		  iVar5 = param1[6];
		  uVar3 = unnamed_function_1417(System_Action_ProtoClanLeaderChangedEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar3,param1,
		             Method_Gameplay_Clans_Controller_ClansController_ClanLeaderChangedEventHandler__,0);
		  ServicesNamespace_ClansService__add_ClanLeaderChangedEvent(iVar5,uVar3,0);
		  iVar5 = param1[6];
		  uVar3 = unnamed_function_1417(System_Action_ProtoUserLeftClanEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar3,param1,
		             Method_Gameplay_Clans_Controller_ClansController_ClansServiceOnUserLeftClanEvent__,0);
		  ServicesNamespace_ClansService__add_UserLeftClanEvent(iVar5,uVar3,0);
		  if (*(int *)(Core_Net_ServiceFactory_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_ServiceFactory_TypeInfo);
		  }
		  uVar3 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                    (Method_Core_Net_ServiceFactory_GetService_ChatService___);
		  uVar7 = unnamed_function_1417(System_Action_ProtoUserInfoChangedEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar7,param1,
		             Method_Gameplay_Clans_Controller_ClansController_UserInfoChangedEventHandler__,0);
		  ServicesNamespace_ChatService__add_UserInfoChangedEvent(uVar3,uVar7,0);
		  iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar3 = Core_Gameplay_Managers_UserManager__get_User(*(undefined4 *)(iVar5 + 8),0);
		  uVar7 = unnamed_function_1417
		                    (
		                    Utils_Accumulators_AccumulatorBase_AccumulatorUpdateDelegate_int__TriggerValue__TypeInfo
		                    );
		  Utils_Accumulators_AccumulatorBase___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType___remove_UpdateEvent
		            (uVar7,param1,
		             Method_Gameplay_Clans_Controller_ClansController_TriggerChangedEventHandler__,0);
		  UnityEngine_Events_InvokableCall_InputAction_CallbackContext___add_Delegate
		            (uVar3,uVar7,
		             Method_Utils_Accumulators_AccumulatorBase_int__TriggerValue__remove_UpdateEvent__);
		  return;
		}
		*/

		}

		// Token: 0x060040BA RID: 16570 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040BA")]
		[Address(RVA = "0x8F71", Offset = "0x8F71", VA = "0x8F71", Slot = "6")]
		protected override void HandleStop()
		{
		/* --- GHIDRA: HandleStop ---
		void Gameplay_Clans_Controller_ClansController__HandleStop(int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  uint *puVar3;
		  int iVar4;
		  undefined8 uVar5;
		  int iVar6;
		  int *param1_00;
		  int iVar7;
		  undefined4 uVar8;
		  
		  if (DAT_ram_00a57752 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Utils_Accumulators_AccumulatorBase_int__TriggerValue__add_UpdateEvent__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Utils_Accumulators_AccumulatorBase_AccumulatorUpdateDelegate_int__TriggerValue__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoUserLeftClanEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ulong__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoUserInfoChangedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoClanLeaderChangedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Clans_Controller_ClansController_ClanLeaderChangedEventHandler__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Clans_Controller_ClansController_ClansServiceOnUserLeftClanEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Clans_Controller_ClansController_HandleCurrentIsleChangedEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Clans_Controller_ClansController_TriggerChangedEventHandler__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Clans_Controller_ClansController_UserInfoChangedEventHandler__);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_ChatService___);
		    Mono_Security_ASN1__get_Item(&Core_Net_ServiceFactory_TypeInfo);
		    DAT_ram_00a57752 = '\x01';
		  }
		  iVar6 = param1[6];
		  uVar2 = unnamed_function_1417(System_Action_ProtoClanLeaderChangedEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Gameplay_Clans_Controller_ClansController_ClanLeaderChangedEventHandler__,0);
		  ServicesNamespace_ClansService__remove_UserLeftClanEvent(iVar6,uVar2,0);
		  iVar6 = param1[6];
		  uVar2 = unnamed_function_1417(System_Action_ProtoUserLeftClanEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Gameplay_Clans_Controller_ClansController_ClansServiceOnUserLeftClanEvent__,0);
		  ServicesNamespace_ClansService__remove_TreasuryChangedEvent(iVar6,uVar2,0);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar6 = *param1_00;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x110);
		        goto code_r0x80dd3fa0;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,10);
		code_r0x80dd3fa0:
		  iVar6 = (**(code **)((ulonglong)*puVar3 * 4))(param1_00,puVar3[1]);
		  iVar7 = *(int *)(iVar6 + 0xc);
		  uVar8 = *(undefined4 *)(iVar7 + 0x1c);
		  uVar2 = unnamed_function_1417(System_Action_ulong__TypeInfo);
		  func_ii_6877(uVar2,param1,
		               Method_Gameplay_Clans_Controller_ClansController_HandleCurrentIsleChangedEvent__,0);
		  iVar6 = UnityEngine_UI_Image__set_sprite(uVar8,uVar2,0);
		  uVar2 = System_Action_ulong__TypeInfo;
		  if (iVar6 == 0) {
		    *(undefined4 *)(iVar7 + 0x1c) = 0;
		  }
		  else {
		    iVar4 = func_ii_1082(iVar6,System_Action_ulong__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar6,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar7 + 0x1c) = iVar4;
		    uVar2 = System_Action_ulong__TypeInfo;
		    iVar7 = func_ii_1082(iVar6,System_Action_ulong__TypeInfo);
		    if (iVar7 == 0) {
		      System_Activator__CreateInstance(iVar6,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  if (*(int *)(Core_Net_ServiceFactory_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_ServiceFactory_TypeInfo);
		  }
		  uVar2 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                    (Method_Core_Net_ServiceFactory_GetService_ChatService___);
		  uVar8 = unnamed_function_1417(System_Action_ProtoUserInfoChangedEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar8,param1,
		             Method_Gameplay_Clans_Controller_ClansController_UserInfoChangedEventHandler__,0);
		  ServicesNamespace_ChatService__remove_NewMessageEvent(uVar2,uVar8,0);
		  iVar6 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  iVar7 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar5 = Core_Data_UserData___ctor(*(undefined4 *)(iVar7 + 8),0);
		  *(undefined8 *)(iVar6 + 0x10) = uVar5;
		  iVar6 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar2 = Core_Gameplay_Managers_UserManager__get_User(*(undefined4 *)(iVar6 + 8),0);
		  uVar8 = unnamed_function_1417
		                    (
		                    Utils_Accumulators_AccumulatorBase_AccumulatorUpdateDelegate_int__TriggerValue__TypeInfo
		                    );
		  Utils_Accumulators_AccumulatorBase___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType___remove_UpdateEvent
		            (uVar8,param1,
		             Method_Gameplay_Clans_Controller_ClansController_TriggerChangedEventHandler__,0);
		  UnityEngine_Events_InvokableCall_InputAction_CallbackContext___Invoke
		            (uVar2,uVar8,
		             Method_Utils_Accumulators_AccumulatorBase_int__TriggerValue__add_UpdateEvent__);
		  Gameplay_Clans_Controller_ClansController__NewClanAssignedEventHandler(param1,uVar2);
		  return;
		}
		*/

		}

		// Token: 0x060040BB RID: 16571 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040BB")]
		[Address(RVA = "0x8F72", Offset = "0x8F72", VA = "0x8F72", Slot = "7")]
		protected override void HandleRun()
		{
		/* --- GHIDRA: HandleRun ---
		void Gameplay_Clans_Controller_ClansController__HandleRun
		               (int *param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  int iVar1;
		  
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

		// Token: 0x060040BC RID: 16572 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040BC")]
		[Address(RVA = "0x8F73", Offset = "0x8F73", VA = "0x8F73")]
		private void TriggerChangedEventHandler(IEnumerable<TriggerValue> changes, AccumulatorBase<int, TriggerValue> accumulator)
		{
		/* --- GHIDRA: TriggerChangedEventHandler ---
		void Gameplay_Clans_Controller_ClansController__TriggerChangedEventHandler
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  uint *puVar1;
		  undefined4 uVar2;
		  longlong lVar3;
		  int *piVar4;
		  int iVar5;
		  uint uVar6;
		  
		  if (DAT_ram_00a57753 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a57753 = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar6 = 0;
		  piVar4 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar6 * 8)) {
		        puVar1 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar6 * 8 + 4) * 8 + iVar5 + 0x140);
		        goto code_r0x80dd4202;
		      }
		      uVar6 = uVar6 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar6);
		  }
		  puVar1 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x80dd4202:
		  uVar2 = (**(code **)((ulonglong)*puVar1 * 4))(piVar4,puVar1[1]);
		  uVar2 = func_ii_7112(uVar2,0);
		  lVar3 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext(uVar2,0);
		  if (lVar3 == *(longlong *)(param2 + 0x10)) {
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    uVar6 = 0;
		    piVar4 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar5 = *piVar4;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar6 * 8)) {
		          puVar1 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar6 * 8 + 4) * 8 + iVar5 + 0x230);
		          goto code_r0x80dd42c0;
		        }
		        uVar6 = uVar6 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar6);
		    }
		    puVar1 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x2e);
		code_r0x80dd42c0:
		    uVar2 = (**(code **)((ulonglong)*puVar1 * 4))(piVar4,puVar1[1]);
		    Core_Gameplay_Managers_ClansManager__AssignClanToUser(uVar2,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x060040BD RID: 16573 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040BD")]
		[Address(RVA = "0x8F74", Offset = "0x8F74", VA = "0x8F74")]
		private void ClansServiceOnUserLeftClanEvent(ProtoUserLeftClanEvt evt)
		{
		/* --- GHIDRA: ClansServiceOnUserLeftClanEvent ---
		void Gameplay_Clans_Controller_ClansController__ClansServiceOnUserLeftClanEvent
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  longlong lVar3;
		  int *param1_01;
		  longlong lVar4;
		  uint uVar5;
		  
		  if (DAT_ram_00a57754 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a57754 = '\x01';
		  }
		  lVar4 = *(longlong *)(*(int *)(*(int *)(param2 + 0xc) + 0xc) + 0x10);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  lVar3 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext
		                    (*(undefined4 *)(iVar1 + 8),0);
		  if (((lVar4 == lVar3) &&
		      (iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                         (param1,*(undefined4 *)(*param1 + 0x104)),
		      *(int *)(*(int *)(iVar1 + 8) + 0x68) != 0)) &&
		     (*(int *)(*(int *)(*(int *)(param2 + 0xc) + 0xc) + 0x40) == 0)) {
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    param1_01 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar1 = *param1_01;
		    if (*(ushort *)(iVar1 + 0xb6) != 0) {
		      uVar5 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar1 + 0x58) + uVar5 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar1 + 0x58) + uVar5 * 8 + 4) * 8 + iVar1 + 0x230);
		          goto code_r0x80dd43f0;
		        }
		        uVar5 = uVar5 + 1;
		      } while (*(ushort *)(iVar1 + 0xb6) != uVar5);
		    }
		    puVar2 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,0x2e);
		code_r0x80dd43f0:
		    param1_00 = (**(code **)((ulonglong)*puVar2 * 4))(param1_01,puVar2[1]);
		    Core_Gameplay_Managers_ClansManager__AssignClanToUser(param1_00,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x060040BE RID: 16574 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040BE")]
		[Address(RVA = "0x8F75", Offset = "0x8F75", VA = "0x8F75")]
		private void UserInfoChangedEventHandler(ProtoUserInfoChangedEvt evt)
		{
		/* --- GHIDRA: UserInfoChangedEventHandler ---
		void Gameplay_Clans_Controller_ClansController__UserInfoChangedEventHandler
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a57755 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Clans_Controller_ClansController_UnregisterClanResultHandler__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__SetCustomData__);
		    DAT_ram_00a57755 = '\x01';
		  }
		  uVar1 = ServicesNamespace_ClansService__SellGolemItem(*(undefined4 *)(param1 + 0x18),0);
		  param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_Clans_Controller_ClansController_UnregisterClanResultHandler__,0);
		  uVar1 = ServicesNamespace_MainService__GetUserStats
		                    (uVar1,param1_00,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  uVar1 = DG_Tweening_TweenParams__SetId
		                    (uVar1,param2,Method_Utils_OpToken_IMessage__object__SetCustomData__);
		  Utils_OpToken_int__object___AddHandlers(param1,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x060040BF RID: 16575 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040BF")]
		[Address(RVA = "0x8F76", Offset = "0x8F76", VA = "0x8F76")]
		public void DisbandClan(ClanData clanData)
		{
		/* --- GHIDRA: DisbandClan ---
		void Gameplay_Clans_Controller_ClansController__DisbandClan
		               (int *param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  undefined4 param1_00;
		  int *piVar5;
		  undefined4 param3_00;
		  
		  if (DAT_ram_00a57756 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Events_Scopes_ClansScope_BaseClansEventArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_World_Model_ClanData_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedUnregisterClanErrors___
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Clans_ProtoUnregisterClanAns_TypeInfo);
		    DAT_ram_00a57756 = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  piVar5 = *(int **)(param2 + 0x20);
		  if ((piVar5 != (int *)0x0) && (Protocol_Clans_ProtoUnregisterClanAns_TypeInfo != *piVar5)) {
		    System_Activator__CreateInstance(piVar5,Protocol_Clans_ProtoUnregisterClanAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar2 = UnityEngine_EventSystems_ExecuteEvents__ValidateEventData_object_
		                    (piVar5[3],0,
		                     Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedUnregisterClanErrors___
		                    );
		  if (iVar2 == 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    if (*(int *)(*(int *)(iVar2 + 8) + 0x68) != 0) {
		      if (DAT_ram_00a6456f == '\0') {
		        Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		        DAT_ram_00a6456f = '\x01';
		      }
		      piVar5 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		      iVar2 = *piVar5;
		      if (*(ushort *)(iVar2 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		            puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x230);
		            goto code_r0x80dd45da;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		      }
		      puVar3 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x2e);
		code_r0x80dd45da:
		      uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(piVar5,puVar3[1]);
		      Core_Gameplay_Managers_ClansManager__AssignClanToUser(uVar4,0);
		    }
		    iVar2 = System_Uri___ctor(0);
		    iVar2 = *(int *)(*(int *)(*(int *)(*(int *)(iVar2 + 0x38) + 0x10) + 0x84) + 0x40);
		    if (iVar2 != 0) {
		      uVar4 = System_Uri___ctor(0);
		      if (DAT_ram_00a6456f == '\0') {
		        Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		        DAT_ram_00a6456f = '\x01';
		      }
		      piVar5 = *(int **)(param2 + 0xc);
		      param3_00 = **(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		      param1_00 = unnamed_function_1417(Core_Events_Scopes_ClansScope_BaseClansEventArgs_TypeInfo);
		      if (piVar5 != (int *)0x0) {
		        if (((uint)*(byte *)(*piVar5 + 0xb8) <
		             (uint)*(byte *)(Gameplay_World_Model_ClanData_TypeInfo + 0xb8)) ||
		           (*(int *)(*(int *)(*piVar5 + 100) +
		                     (uint)*(byte *)(Gameplay_World_Model_ClanData_TypeInfo + 0xb8) * 4 + -4) !=
		            Gameplay_World_Model_ClanData_TypeInfo)) {
		          System_Activator__CreateInstance(piVar5,Gameplay_World_Model_ClanData_TypeInfo);
		          do {
		            halt_trap();
		          } while( true );
		        }
		      }
		      Core_Events_Scopes_UserScope_BaseUserEventArgs__set_UserData
		                (param1_00,uVar4,param3_00,piVar5,0);
		      (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		                (*(undefined4 *)(iVar2 + 0x20),param1_00,*(undefined4 *)(iVar2 + 0x14));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x060040C0 RID: 16576 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040C0")]
		[Address(RVA = "0x8F77", Offset = "0x8F77", VA = "0x8F77")]
		private void UnregisterClanResultHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: UnregisterClanResultHandler ---
		void Gameplay_Clans_Controller_ClansController__UnregisterClanResultHandler
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  uint *puVar2;
		  int *piVar3;
		  int iVar4;
		  undefined4 uVar5;
		  longlong lVar6;
		  uint uVar7;
		  
		  if (DAT_ram_00a57757 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Cache_User_IUserInfoWrapper_TypeInfo);
		    DAT_ram_00a57757 = '\x01';
		  }
		  lVar6 = *(longlong *)(param2 + 0x10);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  if (lVar6 == *(longlong *)(iVar1 + 0x10)) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    *(undefined4 *)(*(int *)(iVar1 + 0x1c) + 0x2c) = *(undefined4 *)(param2 + 0x18);
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    iVar1 = *(int *)(*(int *)(iVar1 + 8) + 0x68);
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    piVar3 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar4 = *piVar3;
		    if (*(ushort *)(iVar4 + 0xb6) != 0) {
		      uVar7 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar7 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar7 * 8 + 4) * 8 + iVar4 + 0x158);
		          goto code_r0x80dd47e8;
		        }
		        uVar7 = uVar7 + 1;
		      } while (*(ushort *)(iVar4 + 0xb6) != uVar7);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,0x13);
		code_r0x80dd47e8:
		    iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		    uVar7 = 0;
		    uVar5 = *(undefined4 *)(param2 + 0x18);
		    piVar3 = *(int **)(iVar4 + 0x14);
		    iVar4 = *piVar3;
		    if (*(ushort *)(iVar4 + 0xb6) != 0) {
		      do {
		        if (Core_Cache_User_IUserInfoWrapper_TypeInfo ==
		            *(int *)(*(int *)(iVar4 + 0x58) + uVar7 * 8)) {
		          puVar2 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar7 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x80dd4874;
		        }
		        uVar7 = uVar7 + 1;
		      } while (*(ushort *)(iVar4 + 0xb6) != uVar7);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar3,Core_Cache_User_IUserInfoWrapper_TypeInfo,0);
		code_r0x80dd4874:
		    uVar5 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,uVar5,puVar2[1]);
		    *(undefined4 *)(iVar1 + 0x14) = uVar5;
		  }
		  return;
		}
		*/

		}

		// Token: 0x060040C1 RID: 16577 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040C1")]
		[Address(RVA = "0x8F78", Offset = "0x8F78", VA = "0x8F78")]
		private void ClanLeaderChangedEventHandler(ProtoClanLeaderChangedEvt evt)
		{
		/* --- GHIDRA: ClanLeaderChangedEventHandler ---
		void Gameplay_Clans_Controller_ClansController__ClanLeaderChangedEventHandler
		               (int *param1,undefined8 param2,undefined4 param3)
		
		{
		  uint *puVar1;
		  int iVar2;
		  int *param1_00;
		  int iVar3;
		  longlong lVar4;
		  uint uVar5;
		  
		  if (DAT_ram_00a57758 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_ClanIsleEvents__ClanIsleModel__ClanIsleController__ClanBuildingTypes__get_Id__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_ClanIsleEvents__ClanIsleModel__ClanIsleController__ClanBuildingTypes__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a57758 = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar5 = 0;
		  param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar3 = *param1_00;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar5 * 8)) {
		        puVar1 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar5 * 8 + 4) * 8 + iVar3 + 0x110);
		        goto code_r0x80dd495a;
		      }
		      uVar5 = uVar5 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar5);
		  }
		  puVar1 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,10);
		code_r0x80dd495a:
		  iVar3 = (**(code **)((ulonglong)*puVar1 * 4))(param1_00,puVar1[1]);
		  iVar3 = *(int *)(iVar3 + 0x14);
		  if ((*(int *)(iVar3 + 0x1c) == 2) &&
		     (lVar4 = *(longlong *)(*(int *)(iVar3 + 0x28) + 0x18),
		     iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                       (param1,*(undefined4 *)(*param1 + 0x104)),
		     lVar4 == *(longlong *)(iVar2 + 0x10))) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    *(undefined4 *)(iVar2 + 0x1c) = *(undefined4 *)(*(int *)(*(int *)(iVar3 + 0x28) + 0x10) + 0x38);
		  }
		  return;
		}
		*/

		}

		// Token: 0x060040C2 RID: 16578 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040C2")]
		[Address(RVA = "0x8F79", Offset = "0x8F79", VA = "0x8F79")]
		private void HandleCurrentIsleChangedEvent(ulong id)
		{
		/* --- GHIDRA: HandleCurrentIsleChangedEvent ---
		void Gameplay_Clans_Controller_ClansController__HandleCurrentIsleChangedEvent
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  undefined4 param2_00;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  iVar2 = *(int *)(iVar1 + 0x18);
		  uVar3 = *(undefined4 *)(iVar2 + 8);
		  param2_00 = *(undefined4 *)(param2 + 0xc);
		  *(undefined4 *)(iVar2 + 8) = param2_00;
		  uVar3 = Core_Extensions_Dict_ResourceSetExt__Sub(uVar3,param2_00,0);
		  iVar1 = Core_Extensions_Dict_ResourceSetExt__GetDelta(uVar3,0);
		  if ((iVar1 == 0) && (iVar1 = *(int *)(iVar2 + 0x10), iVar1 != 0)) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar2 + 8),uVar3,
		               *(undefined4 *)(iVar1 + 0x14));
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(iVar1 + 0x14);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x060040C3 RID: 16579 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040C3")]
		[Address(RVA = "0x8F7A", Offset = "0x8F7A", VA = "0x8F7A")]
		private void TreasuryChangedEventHandler(ProtoTreasuryChangedEvt evt)
		{
		/* --- GHIDRA: TreasuryChangedEventHandler ---
		void Gameplay_Clans_Controller_ClansController__TreasuryChangedEventHandler
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 param1_00;
		  uint *param2_00;
		  undefined4 param1_01;
		  int *param1_02;
		  int iVar2;
		  
		  if (DAT_ram_00a57759 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoTreasuryChangedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Clans_Controller_ClansController_NewClanAssignedEventHandler__);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a57759 = '\x01';
		  }
		  param1_01 = *(undefined4 *)(param1 + 0x18);
		  param1_00 = unnamed_function_1417(System_Action_ProtoTreasuryChangedEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_Clans_Controller_ClansController_NewClanAssignedEventHandler__,0);
		  ServicesNamespace_ClansService__add_TreasuryChangedEvent(param1_01,param1_00,0);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  param1_02 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar2 = *param1_02;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        param2_00 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x140);
		        goto code_r0x80dd30ff;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  param2_00 = (uint *)func_ii_1080(param1_02,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x80dd30ff:
		  iVar2 = (**(code **)((ulonglong)*param2_00 * 4))(param1_02,param2_00[1]);
		  *(undefined8 *)(*(int *)(iVar2 + 0x14) + 0x10) = 0;
		  Gameplay_Clans_Controller_ClansController__DissociateClanFromUser(param1,param2_00);
		  return;
		}
		*/

		}

		// Token: 0x060040C4 RID: 16580 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040C4")]
		[Address(RVA = "0x8F7B", Offset = "0x8F7B", VA = "0x8F7B")]
		private void NewClanAssignedEventHandler([Optional] ProtoTreasuryChangedEvt evt)
		{
		/* --- GHIDRA: NewClanAssignedEventHandler ---
		void Gameplay_Clans_Controller_ClansController__NewClanAssignedEventHandler
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 in_register_20000014;
		  undefined8 uVar1;
		  int iVar3;
		  undefined4 uVar4;
		  int iVar5;
		  undefined4 param1_00;
		  undefined4 param3;
		  undefined4 param4;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a5775a == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoTreasuryChangedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Events_Scopes_UserScope_BaseUserEventArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Clans_Controller_ClansController_NewClanAssignedEventHandler__);
		    DAT_ram_00a5775a = '\x01';
		  }
		  uVar1 = CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x104));
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(param1,uVar1);
		  uVar2 = (undefined4)((ulonglong)uVar1 >> 0x20);
		  if (*(longlong *)(iVar3 + 0x10) != 0) {
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,CONCAT44(uVar2,*(undefined4 *)(*param1 + 0x104)));
		    Gameplay_Clans_Controller_ClansController__Dispose
		              (param1,*(undefined8 *)(iVar3 + 0x10),2,param1);
		    Gameplay_Clans_Controller_ClansController__GetOwnClanInfoResultHandler(param1,param1);
		    return;
		  }
		  iVar3 = param1[6];
		  uVar4 = unnamed_function_1417(System_Action_ProtoTreasuryChangedEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar4,param1,
		             Method_Gameplay_Clans_Controller_ClansController_NewClanAssignedEventHandler__,0);
		  ServicesNamespace_ClansService__remove_GolemSlotsChangedEvent(iVar3,uVar4,0);
		  *(undefined1 *)((int)param1 + 9) = 1;
		  uVar1 = CONCAT44(uVar2,*(undefined4 *)(*param1 + 0x114));
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))(param1,uVar1);
		  uVar2 = (undefined4)((ulonglong)uVar1 >> 0x20);
		  iVar3 = *(int *)(iVar3 + 8);
		  if (iVar3 != 0) {
		    uVar1 = CONCAT44(uVar2,*(undefined4 *)(iVar3 + 0x14));
		    (**(code **)((ulonglong)*(uint *)(iVar3 + 0xc) * 4))(*(undefined4 *)(iVar3 + 0x20),uVar1);
		    uVar2 = (undefined4)((ulonglong)uVar1 >> 0x20);
		  }
		  iVar3 = System_Uri___ctor(0);
		  iVar3 = *(int *)(*(int *)(*(int *)(*(int *)(iVar3 + 0x38) + 0x10) + 0xc) + 0x3c);
		  if (iVar3 != 0) {
		    uVar4 = System_Uri___ctor(0);
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    param3 = **(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    uVar1 = CONCAT44(uVar2,*(undefined4 *)(*param1 + 0x104));
		    iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(param1,uVar1);
		    uVar2 = (undefined4)((ulonglong)uVar1 >> 0x20);
		    param4 = *(undefined4 *)(iVar5 + 8);
		    param1_00 = unnamed_function_1417(Core_Events_Scopes_UserScope_BaseUserEventArgs_TypeInfo);
		    Core_Events_Scopes_UserScope_BaseUserEventArgs__set_UserData(param1_00,uVar4,param3,param4,0);
		    (**(code **)((ulonglong)*(uint *)(iVar3 + 0xc) * 4))
		              (*(undefined4 *)(iVar3 + 0x20),CONCAT44(uVar2,param1_00),*(undefined4 *)(iVar3 + 0x14)
		              );
		  }
		  return;
		}
		*/

		}

		// Token: 0x060040C5 RID: 16581 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040C5")]
		[Address(RVA = "0x8F7C", Offset = "0x8F7C", VA = "0x8F7C")]
		private void HandleInit()
		{
		/* --- GHIDRA: HandleInit ---
		void Gameplay_Clans_Controller_ClansController__HandleInit(int *param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  uint *puVar4;
		  int iVar5;
		  int *piVar6;
		  int iVar7;
		  
		  if (DAT_ram_00a5775b == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoTreasuryChangedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Clans_Controller_ClansController_TreasuryChangedEventHandler__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Controller_ClansController__AssignClanIsleToUser_g__GetShortClanInfoResultHandler_27_0__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Cache_User_IUserInfoWrapper_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item(&ulong___TypeInfo);
		    DAT_ram_00a5775b = '\x01';
		  }
		  iVar7 = *param1;
		  uVar2 = (**(code **)((ulonglong)*(uint *)(iVar7 + 0x100) * 4))
		                    (param1,*(undefined4 *)(iVar7 + 0x104));
		  Gameplay_Clans_Model_ClansModel__DissociateClanFromUser(uVar2,param2,iVar7);
		  iVar5 = param1[6];
		  iVar7 = Mono_Security_ASN1Convert__ToOid(ulong___TypeInfo,1);
		  *(undefined8 *)(iVar7 + 0x10) = *(undefined8 *)(*(int *)(param2 + 0x10) + 0x10);
		  uVar2 = ServicesNamespace_ClansService__GetOwnClanInfo(iVar5,iVar7,0);
		  uVar3 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar3,param1,
		             Method_Gameplay_Clans_Controller_ClansController__AssignClanIsleToUser_g__GetShortClanInfoResultHandler_27_0__
		             ,0);
		  uVar2 = ServicesNamespace_MainService__GetUserStats
		                    (uVar2,uVar3,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  Utils_OpToken_int__object___AddHandlers(param1,uVar2,0);
		  iVar7 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  iVar5 = *(int *)(iVar7 + 8);
		  uVar3 = *(undefined4 *)(param2 + 0x10);
		  iVar7 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar2 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System
		                    (*(undefined4 *)(iVar7 + 0xc),0);
		  uVar2 = func_ii_7325(uVar3,uVar2,0);
		  *(undefined4 *)(iVar5 + 0x68) = uVar2;
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  piVar6 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x158);
		        goto code_r0x80dd4c1c;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x13);
		code_r0x80dd4c1c:
		  iVar7 = (**(code **)((ulonglong)*puVar4 * 4))(piVar6,puVar4[1]);
		  piVar6 = *(int **)(iVar7 + 0x14);
		  iVar7 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  iVar7 = *(int *)(*(int *)(iVar7 + 8) + 0x68);
		  uVar1 = 0;
		  uVar2 = *(undefined4 *)(param2 + 0x2c);
		  iVar5 = *piVar6;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Cache_User_IUserInfoWrapper_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8))
		      {
		        puVar4 = (uint *)(iVar5 + *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80dd4cc6;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar6,Core_Cache_User_IUserInfoWrapper_TypeInfo,0);
		code_r0x80dd4cc6:
		  uVar2 = (**(code **)((ulonglong)*puVar4 * 4))(piVar6,uVar2,puVar4[1]);
		  *(undefined4 *)(iVar7 + 0x14) = uVar2;
		  if (*(int *)(param2 + 0x20) != 0) {
		    iVar7 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    iVar7 = *(int *)(*(int *)(iVar7 + 8) + 0x68);
		    uVar1 = 0;
		    uVar2 = *(undefined4 *)(param2 + 0x20);
		    iVar5 = *piVar6;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      do {
		        if (Core_Cache_User_IUserInfoWrapper_TypeInfo ==
		            *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		          puVar4 = (uint *)(iVar5 + *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x80dd4d71;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    puVar4 = (uint *)func_ii_1080(piVar6,Core_Cache_User_IUserInfoWrapper_TypeInfo,0);
		code_r0x80dd4d71:
		    uVar2 = (**(code **)((ulonglong)*puVar4 * 4))(piVar6,uVar2,puVar4[1]);
		    *(undefined4 *)(iVar7 + 0x18) = uVar2;
		  }
		  iVar7 = param1[6];
		  uVar2 = unnamed_function_1417(System_Action_ProtoTreasuryChangedEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Gameplay_Clans_Controller_ClansController_TreasuryChangedEventHandler__,0);
		  ServicesNamespace_ClansService__remove_GolemSlotsChangedEvent(iVar7,uVar2,0);
		  return;
		}
		*/

		}

		// Token: 0x060040C6 RID: 16582 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040C6")]
		[Address(RVA = "0x8F7D", Offset = "0x8F7D", VA = "0x8F7D")]
		private void AssignClanIsleToUser(ProtoGetIsleInfoAns.Types.ClanIsleInformation clanIsleInfo)
		{
		/* --- GHIDRA: AssignClanIsleToUser ---
		void Gameplay_Clans_Controller_ClansController__AssignClanIsleToUser(int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5775c == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_MVC_AbstractController_ClansModel__ClansEvents__Dispose__);
		    DAT_ram_00a5775c = '\x01';
		  }
		  MVC_AbstractController_object__object____ctor
		            (param1,Method_MVC_AbstractController_ClansModel__ClansEvents__Dispose__);
		  *(undefined8 *)(param1 + 0x18) = 0;
		  return;
		}
		*/

		}

		// Token: 0x060040C7 RID: 16583 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040C7")]
		[Address(RVA = "0x8F7E", Offset = "0x8F7E", VA = "0x8F7E", Slot = "5")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Gameplay_Clans_Controller_ClansController__Dispose
		               (int param1,undefined8 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5775d == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Controller_ClansController__HandleInit_g__GetOwnClanIsleInfoResultHandler_26_1__
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    DAT_ram_00a5775d = '\x01';
		  }
		  uVar1 = ServicesNamespace_ClanIsleService__ServerEventHandler
		                    (*(undefined4 *)(param1 + 0x1c),param2,param3,0);
		  param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_Clans_Controller_ClansController__HandleInit_g__GetOwnClanIsleInfoResultHandler_26_1__
		             ,0);
		  uVar1 = ServicesNamespace_MainService__GetUserStats
		                    (uVar1,param1_00,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  Utils_OpToken_int__object___AddHandlers(param1,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x060040C8 RID: 16584 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040C8")]
		[Address(RVA = "0x8F7F", Offset = "0x8F7F", VA = "0x8F7F")]
		[CompilerGenerated]
		private void <HandleInit>g__GetOwnClanIsleInfo|26_0(ulong clanId, uint flags)
		{
		}

		// Token: 0x060040C9 RID: 16585 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040C9")]
		[Address(RVA = "0x8F80", Offset = "0x8F80", VA = "0x8F80")]
		[CompilerGenerated]
		private void <HandleInit>g__GetOwnClanIsleInfoResultHandler|26_1(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x060040CA RID: 16586 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040CA")]
		[Address(RVA = "0x8F81", Offset = "0x8F81", VA = "0x8F81")]
		[CompilerGenerated]
		private void <AssignClanIsleToUser>g__GetShortClanInfoResultHandler|27_0(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x040023EF RID: 9199
		[Token(Token = "0x40023EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private ClansService _clansService;

		// Token: 0x040023F0 RID: 9200
		[Token(Token = "0x40023F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private ClanIsleService _clanIsleService;
	}
}
