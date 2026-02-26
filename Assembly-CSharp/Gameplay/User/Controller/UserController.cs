using System;
using System.Collections;
using Gameplay.User.Events;
using Gameplay.User.Model;
using Google.Protobuf;
using Il2CppDummyDll;
using MVC;
using Protocol.Auth;
using Protocol.Balance;
using Protocol.Clans;
using Protocol.Common;
using Protocol.Craft;
using Protocol.Main;
using Protocol.Tree;
using Protocol.World;
using ServicesNamespace;
using UnityEngine;
using Utils;

namespace Gameplay.User.Controller
{
	// Token: 0x02000422 RID: 1058
	[Token(Token = "0x2000422")]
	public class UserController : AbstractController<UserModel, UserEvents>
	{
		// Token: 0x06001901 RID: 6401 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001901")]
		[Address(RVA = "0x6AA0", Offset = "0x6AA0", VA = "0x6AA0")]
		public UserController(UserModel model, UserEvents events)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_User_Controller_UserController___ctor(int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a59954 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_MVC_AbstractController_UserModel__UserEvents__Dispose__);
		    DAT_ram_00a59954 = '\x01';
		  }
		  *(undefined4 *)(param1 + 0x18) = 0;
		  MVC_AbstractController_object__object____ctor
		            (param1,Method_MVC_AbstractController_UserModel__UserEvents__Dispose__);
		  return;
		}
		*/

		}

		// Token: 0x06001902 RID: 6402 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001902")]
		[Address(RVA = "0x6AA1", Offset = "0x6AA1", VA = "0x6AA1", Slot = "5")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Gameplay_User_Controller_UserController__Dispose(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a59955 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoUserLeftClanEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoNewLevelEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoExperienceChangedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoTakeOffMedalsEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoUnregisterClanAns__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoUserAprChangedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoTriggersChangedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoSkillsChangedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoResourcesChangedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoRegenTreeEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoBanStatusChangedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_UserProfession__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_AuthService___);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_BalanceService___);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_CraftService___);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_MainService___);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_TreeService___);
		    Mono_Security_ASN1__get_Item(&Core_Net_ServiceFactory_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_User_Controller_UserController_BanStatusChangedEventHandler__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_User_Controller_UserController_ClanUnregisteredHandler__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_User_Controller_UserController_GetUserProfessionsResultHandler__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_User_Controller_UserController_HandelGetUserBalanceService__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_User_Controller_UserController_HandleBalanceChangedEventService__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_User_Controller_UserController_HandleExpChangedEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_User_Controller_UserController_HandleNewLevelEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_User_Controller_UserController_HandleTreeRegenEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_User_Controller_UserController_HandleTriggersChangedEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_User_Controller_UserController_MainServiceOnSkillsChangedEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_User_Controller_UserController_ProfessionChangedEventHandler__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_User_Controller_UserController_TakeOffMedalsEventHandler__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_User_Controller_UserController_UserAprChangedEventHandler__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_User_Controller_UserController_UserLeftClanEventHandler__);
		    DAT_ram_00a59955 = '\x01';
		  }
		  uVar2 = *(undefined4 *)(param1 + 0x18);
		  uVar1 = unnamed_function_1417(System_Action_ProtoTriggersChangedEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_User_Controller_UserController_HandleTriggersChangedEvent__,0);
		  ServicesNamespace_MainService__get_ServiceId(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param1 + 0x18);
		  uVar1 = unnamed_function_1417(System_Action_ProtoExperienceChangedEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,Method_Gameplay_User_Controller_UserController_HandleExpChangedEvent__,0);
		  ServicesNamespace_MainService__remove_NewLevelEvent(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param1 + 0x18);
		  uVar1 = unnamed_function_1417(System_Action_ProtoNewLevelEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,Method_Gameplay_User_Controller_UserController_HandleNewLevelEvent__,0);
		  ServicesNamespace_MainService__remove_TriggersChangedEvent(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param1 + 0x18);
		  uVar1 = unnamed_function_1417(System_Action_ProtoSkillsChangedEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_User_Controller_UserController_MainServiceOnSkillsChangedEvent__,0);
		  ServicesNamespace_MainService__remove_TakeOffMedalsEvent(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param1 + 0x1c);
		  uVar1 = unnamed_function_1417(System_Action_ProtoUserAprChangedEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_User_Controller_UserController_UserAprChangedEventHandler__,0);
		  ServicesNamespace_WorldService__remove_GoHomeEvent(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param1 + 0x20);
		  uVar1 = unnamed_function_1417(System_Action_ProtoUserLeftClanEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,Method_Gameplay_User_Controller_UserController_UserLeftClanEventHandler__,
		             0);
		  ServicesNamespace_ClansService__remove_TreasuryChangedEvent(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param1 + 0x20);
		  uVar1 = unnamed_function_1417(System_Action_ProtoUnregisterClanAns__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,Method_Gameplay_User_Controller_UserController_ClanUnregisteredHandler__,0
		            );
		  ServicesNamespace_ClansService__remove_ClanCreatedEvent(uVar2,uVar1,0);
		  if (*(int *)(Core_Net_ServiceFactory_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_ServiceFactory_TypeInfo);
		  }
		  uVar1 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                    (Method_Core_Net_ServiceFactory_GetService_AuthService___);
		  uVar2 = unnamed_function_1417(System_Action_ProtoBanStatusChangedEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Gameplay_User_Controller_UserController_BanStatusChangedEventHandler__,0);
		  ServicesNamespace_AuthService__get_ServiceId(uVar1,uVar2,0);
		  uVar1 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                    (Method_Core_Net_ServiceFactory_GetService_MainService___);
		  uVar2 = unnamed_function_1417(System_Action_ProtoTakeOffMedalsEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,Method_Gameplay_User_Controller_UserController_TakeOffMedalsEventHandler__
		             ,0);
		  ServicesNamespace_MainService__remove_NewMedalsEvent(uVar1,uVar2,0);
		  uVar1 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                    (Method_Core_Net_ServiceFactory_GetService_TreeService___);
		  uVar2 = unnamed_function_1417(System_Action_ProtoRegenTreeEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,Method_Gameplay_User_Controller_UserController_HandleTreeRegenEvent__,0);
		  ServicesNamespace_TreeService__get_ServiceId(uVar1,uVar2,0);
		  uVar1 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                    (Method_Core_Net_ServiceFactory_GetService_BalanceService___);
		  uVar2 = unnamed_function_1417(System_Action_ProtoResourcesChangedEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Gameplay_User_Controller_UserController_HandleBalanceChangedEventService__,0);
		  ServicesNamespace_BalanceService__get_ServiceId(uVar1,uVar2,0);
		  uVar1 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                    (Method_Core_Net_ServiceFactory_GetService_CraftService___);
		  uVar2 = unnamed_function_1417(System_Action_UserProfession__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Gameplay_User_Controller_UserController_ProfessionChangedEventHandler__,0);
		  ServicesNamespace_CraftService__get_ServiceId(uVar1,uVar2,0);
		  uVar1 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                    (Method_Core_Net_ServiceFactory_GetService_BalanceService___);
		  uVar1 = ServicesNamespace_BalanceService__ServerEventHandler(uVar1,0);
		  uVar2 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Gameplay_User_Controller_UserController_HandelGetUserBalanceService__,0);
		  uVar1 = ServicesNamespace_MainService__GetUserStats
		                    (uVar1,uVar2,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  uVar2 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                    (Method_Core_Net_ServiceFactory_GetService_CraftService___);
		  uVar2 = ServicesNamespace_CraftService__ServerEventHandler(uVar2,0);
		  param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_User_Controller_UserController_GetUserProfessionsResultHandler__,0);
		  uVar2 = ServicesNamespace_MainService__GetUserStats
		                    (uVar2,param1_00,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  Utils_OpToken_int__object___AddHandlers(param1,uVar1,0);
		  Utils_OpToken_int__object___AddHandlers(param1,uVar2,0);
		  return;
		}
		*/

		}

		// Token: 0x06001903 RID: 6403 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001903")]
		[Address(RVA = "0x6AA2", Offset = "0x6AA2", VA = "0x6AA2", Slot = "7")]
		protected override void HandleRun()
		{
		/* --- GHIDRA: HandleRun ---
		void Gameplay_User_Controller_UserController__HandleRun(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a59956 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoUserLeftClanEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoNewLevelEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoExperienceChangedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoTakeOffMedalsEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoUnregisterClanAns__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoUserAprChangedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoTriggersChangedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoSkillsChangedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoResourcesChangedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoRegenTreeEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoBanStatusChangedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_UserProfession__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_AuthService___);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_BalanceService___);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_CraftService___);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_MainService___);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_TreeService___);
		    Mono_Security_ASN1__get_Item(&Core_Net_ServiceFactory_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_User_Controller_UserController_BanStatusChangedEventHandler__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_User_Controller_UserController_ClanUnregisteredHandler__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_User_Controller_UserController_HandleBalanceChangedEventService__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_User_Controller_UserController_HandleExpChangedEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_User_Controller_UserController_HandleNewLevelEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_User_Controller_UserController_HandleTreeRegenEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_User_Controller_UserController_HandleTriggersChangedEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_User_Controller_UserController_MainServiceOnSkillsChangedEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_User_Controller_UserController_ProfessionChangedEventHandler__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_User_Controller_UserController_TakeOffMedalsEventHandler__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_User_Controller_UserController_UserAprChangedEventHandler__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_User_Controller_UserController_UserLeftClanEventHandler__);
		    DAT_ram_00a59956 = '\x01';
		  }
		  if (*(int *)(param1 + 0x24) != 0) {
		    func_ii_7950(*(int *)(param1 + 0x24),0);
		  }
		  *(undefined4 *)(param1 + 0x24) = 0;
		  uVar2 = *(undefined4 *)(param1 + 0x18);
		  uVar1 = unnamed_function_1417(System_Action_ProtoTriggersChangedEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_User_Controller_UserController_HandleTriggersChangedEvent__,0);
		  ServicesNamespace_MainService__add_TriggersChangedEvent(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param1 + 0x18);
		  uVar1 = unnamed_function_1417(System_Action_ProtoExperienceChangedEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,Method_Gameplay_User_Controller_UserController_HandleExpChangedEvent__,0);
		  ServicesNamespace_MainService__add_ExpChangedEvent(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param1 + 0x18);
		  uVar1 = unnamed_function_1417(System_Action_ProtoNewLevelEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,Method_Gameplay_User_Controller_UserController_HandleNewLevelEvent__,0);
		  ServicesNamespace_MainService__add_NewLevelEvent(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param1 + 0x18);
		  uVar1 = unnamed_function_1417(System_Action_ProtoSkillsChangedEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_User_Controller_UserController_MainServiceOnSkillsChangedEvent__,0);
		  ServicesNamespace_MainService__add_SkillsChangedEvent(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param1 + 0x1c);
		  uVar1 = unnamed_function_1417(System_Action_ProtoUserAprChangedEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_User_Controller_UserController_UserAprChangedEventHandler__,0);
		  ServicesNamespace_WorldService__add_UserAprChangedEvent(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param1 + 0x20);
		  uVar1 = unnamed_function_1417(System_Action_ProtoUserLeftClanEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,Method_Gameplay_User_Controller_UserController_UserLeftClanEventHandler__,
		             0);
		  ServicesNamespace_ClansService__add_UserLeftClanEvent(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param1 + 0x20);
		  uVar1 = unnamed_function_1417(System_Action_ProtoUnregisterClanAns__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,Method_Gameplay_User_Controller_UserController_ClanUnregisteredHandler__,0
		            );
		  ServicesNamespace_ClansService__add_ClanUnregisteredEvent(uVar2,uVar1,0);
		  if (*(int *)(Core_Net_ServiceFactory_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_ServiceFactory_TypeInfo);
		  }
		  uVar1 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                    (Method_Core_Net_ServiceFactory_GetService_AuthService___);
		  uVar2 = unnamed_function_1417(System_Action_ProtoBanStatusChangedEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Gameplay_User_Controller_UserController_BanStatusChangedEventHandler__,0);
		  ServicesNamespace_AuthService__add_BanStatusChangedEvent(uVar1,uVar2,0);
		  uVar1 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                    (Method_Core_Net_ServiceFactory_GetService_MainService___);
		  uVar2 = unnamed_function_1417(System_Action_ProtoTakeOffMedalsEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,Method_Gameplay_User_Controller_UserController_TakeOffMedalsEventHandler__
		             ,0);
		  ServicesNamespace_MainService__add_TakeOffMedalsEvent(uVar1,uVar2,0);
		  uVar1 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                    (Method_Core_Net_ServiceFactory_GetService_TreeService___);
		  uVar2 = unnamed_function_1417(System_Action_ProtoRegenTreeEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,Method_Gameplay_User_Controller_UserController_HandleTreeRegenEvent__,0);
		  ServicesNamespace_TreeService__add_RegenTree(uVar1,uVar2,0);
		  uVar1 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                    (Method_Core_Net_ServiceFactory_GetService_BalanceService___);
		  uVar2 = unnamed_function_1417(System_Action_ProtoResourcesChangedEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Gameplay_User_Controller_UserController_HandleBalanceChangedEventService__,0);
		  ServicesNamespace_BalanceService__add_BalanceChangedEvent(uVar1,uVar2,0);
		  uVar1 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                    (Method_Core_Net_ServiceFactory_GetService_CraftService___);
		  uVar2 = unnamed_function_1417(System_Action_UserProfession__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,
		             Method_Gameplay_User_Controller_UserController_ProfessionChangedEventHandler__,0);
		  ServicesNamespace_CraftService__add_ProfessionChangedEvent(uVar1,uVar2,0);
		  return;
		}
		*/

		}

		// Token: 0x06001904 RID: 6404 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001904")]
		[Address(RVA = "0x6AA3", Offset = "0x6AA3", VA = "0x6AA3", Slot = "6")]
		protected override void HandleStop()
		{
		/* --- GHIDRA: HandleStop ---
		void Gameplay_User_Controller_UserController__HandleStop
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  *(undefined4 *)(*(int *)(iVar1 + 8) + 0x68) = 0;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  *(undefined4 *)(*(int *)(*(int *)(iVar1 + 8) + 0x34) + 0x40) = 0;
		  return;
		}
		*/

		}

		// Token: 0x06001905 RID: 6405 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001905")]
		[Address(RVA = "0x6AA4", Offset = "0x6AA4", VA = "0x6AA4")]
		private void ClanUnregisteredHandler(ProtoUnregisterClanAns ans)
		{
		/* --- GHIDRA: ClanUnregisteredHandler ---
		void Gameplay_User_Controller_UserController__ClanUnregisteredHandler
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  longlong lVar2;
		  longlong lVar3;
		  
		  lVar3 = *(longlong *)(param2 + 0x10);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  lVar2 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext
		                    (*(undefined4 *)(iVar1 + 8),0);
		  if (lVar3 == lVar2) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    *(undefined4 *)(*(int *)(iVar1 + 8) + 0x68) = 0;
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    *(undefined4 *)(*(int *)(*(int *)(iVar1 + 8) + 0x34) + 0x40) = 0;
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001906 RID: 6406 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001906")]
		[Address(RVA = "0x6AA5", Offset = "0x6AA5", VA = "0x6AA5")]
		private void UserLeftClanEventHandler(ProtoUserLeftClanEvt evt)
		{
		/* --- GHIDRA: UserLeftClanEventHandler ---
		void Gameplay_User_Controller_UserController__UserLeftClanEventHandler
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int iVar2;
		  int iVar3;
		  undefined4 param1_00;
		  uint *puVar4;
		  int *param1_01;
		  
		  if (DAT_ram_00a59957 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Cache_CacheResultCallback_UserData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Cache_ICache_ulong__UserData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_User_Controller_UserController___c__DisplayClass10_0__UserAprChangedEventHandler_g__GetUserDataResultHandler_0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_User_Controller_UserController___c__DisplayClass10_0_TypeInfo);
		    Mono_Security_ASN1__get_Item(&ulong___TypeInfo);
		    DAT_ram_00a59957 = '\x01';
		  }
		  iVar2 = unnamed_function_1417
		                    (Gameplay_User_Controller_UserController___c__DisplayClass10_0_TypeInfo);
		  *(undefined4 *)(iVar2 + 0xc) = param2;
		  *(int **)(iVar2 + 8) = param1;
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  param1_01 = *(int **)(iVar3 + 0x38);
		  param1_00 = unnamed_function_1417(Core_Cache_CacheResultCallback_UserData__TypeInfo);
		  Cysharp_Threading_Tasks_UniTaskCompletionSource__get_Task
		            (param1_00,iVar2,
		             Method_Gameplay_User_Controller_UserController___c__DisplayClass10_0__UserAprChangedEventHandler_g__GetUserDataResultHandler_0__
		             ,0);
		  iVar3 = Mono_Security_ASN1Convert__ToOid(ulong___TypeInfo,1);
		  *(undefined8 *)(iVar3 + 0x10) = *(undefined8 *)(*(int *)(iVar2 + 0xc) + 0x10);
		  iVar2 = *param1_01;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Cache_ICache_ulong__UserData__TypeInfo ==
		          *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 200);
		        goto code_r0x81096be8;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(param1_01,Core_Cache_ICache_ulong__UserData__TypeInfo,1);
		code_r0x81096be8:
		  (**(code **)((ulonglong)*puVar4 * 4))(param1_01,param1_00,iVar3,puVar4[1]);
		  return;
		}
		*/

		}

		// Token: 0x06001907 RID: 6407 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001907")]
		[Address(RVA = "0x6AA6", Offset = "0x6AA6", VA = "0x6AA6")]
		private void UserAprChangedEventHandler(ProtoUserAprChangedEvt evt)
		{
		/* --- GHIDRA: UserAprChangedEventHandler ---
		void Gameplay_User_Controller_UserController__UserAprChangedEventHandler
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  iVar2 = *(int *)(param2 + 0xc);
		  *(int *)(iVar1 + 0x24) = iVar2;
		  if (iVar2 != 0) {
		    Core_Errors_Expected_ExpectedBillingErrors__ShowNotEnoughResourcesWindow(0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001908 RID: 6408 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001908")]
		[Address(RVA = "0x6AA7", Offset = "0x6AA7", VA = "0x6AA7")]
		private void BanStatusChangedEventHandler(ProtoBanStatusChangedEvt evt)
		{
		/* --- GHIDRA: BanStatusChangedEventHandler ---
		void Gameplay_User_Controller_UserController__BanStatusChangedEventHandler
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  uint uVar2;
		  undefined4 *puVar3;
		  undefined4 param1_00;
		  int iVar4;
		  int iVar5;
		  int iVar6;
		  int *piVar7;
		  uint *puVar8;
		  int iVar9;
		  int *piVar10;
		  int local_c;
		  int **local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a59958 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_IEnumerator_ProtoTakeOffMedalsEvt_Types_MedalInform__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Google_Protobuf_Collections_RepeatedField_ProtoTakeOffMedalsEvt_Types_MedalInform__GetEnumerator__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_MedalInfo__Remove__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_MedalInfo__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_MedalInfo__get_Item__);
		    DAT_ram_00a59958 = '\x01';
		  }
		  local_4 = (int *)Google_Protobuf_Collections_RepeatedField_float___Equals
		                             (*(undefined4 *)(param2 + 0xc),
		                              Method_Google_Protobuf_Collections_RepeatedField_ProtoTakeOffMedalsEvt_Types_MedalInform__GetEnumerator__
		                             );
		  local_c = 0;
		  local_8 = &local_4;
		code_r0x81096cbb:
		  piVar7 = local_4;
		  iVar9 = *local_4;
		  if (*(ushort *)(iVar9 + 0xb6) != 0) {
		    uVar2 = 0;
		    do {
		      piVar10 = (int *)(*(int *)(iVar9 + 0x58) + uVar2 * 8);
		      if (System_Collections_IEnumerator_TypeInfo == *piVar10) {
		        puVar3 = (undefined4 *)(iVar9 + piVar10[1] * 8 + 0xc0);
		        goto code_r0x81096d53;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar9 + 0xb6) != uVar2);
		  }
		  DAT_ram_009d3e38 = 0;
		  puVar3 = (undefined4 *)
		           import::env::invoke_iiii
		                     (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                      System_Collections_IEnumerator_TypeInfo,0);
		  if (DAT_ram_009d3e38 != 1) {
		code_r0x81096d53:
		    DAT_ram_009d3e38 = 0;
		    iVar9 = import::env::invoke_iii(*puVar3,piVar7,puVar3[1]);
		    piVar7 = local_4;
		    if (DAT_ram_009d3e38 == 1) goto code_r0x81096d9b;
		    if (iVar9 == 0) {
		      iVar9 = 0;
		      goto code_r0x8109709c;
		    }
		    iVar9 = *local_4;
		    if (*(ushort *)(iVar9 + 0xb6) != 0) {
		      uVar2 = 0;
		      do {
		        piVar10 = (int *)(*(int *)(iVar9 + 0x58) + uVar2 * 8);
		        if (System_Collections_Generic_IEnumerator_ProtoTakeOffMedalsEvt_Types_MedalInform__TypeInfo
		            == *piVar10) {
		          puVar3 = (undefined4 *)(iVar9 + piVar10[1] * 8 + 0xc0);
		          goto code_r0x81096e4c;
		        }
		        uVar2 = uVar2 + 1;
		      } while (*(ushort *)(iVar9 + 0xb6) != uVar2);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar3 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_Generic_IEnumerator_ProtoTakeOffMedalsEvt_Types_MedalInform__TypeInfo
		                        ,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x81096f88:
		      DAT_ram_009d3e38 = 0;
		      param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81097053;
		    }
		code_r0x81096e4c:
		    DAT_ram_009d3e38 = 0;
		    iVar9 = import::env::invoke_iii(*puVar3,piVar7,puVar3[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x81096f88;
		    DAT_ram_009d3e38 = 0;
		    iVar4 = import::env::invoke_iii
		                      (*(undefined4 *)(*param1 + 0x100),param1,*(undefined4 *)(*param1 + 0x104));
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 == 1) {
		      param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81097053;
		    }
		    iVar6 = *(int *)(*(int *)(*(int *)(iVar4 + 8) + 0x40) + 0xc);
		    if (0 < iVar6) {
		      iVar4 = 0;
		      do {
		        DAT_ram_009d3e38 = 0;
		        iVar5 = import::env::invoke_iii
		                          (*(undefined4 *)(*param1 + 0x100),param1,*(undefined4 *)(*param1 + 0x104))
		        ;
		        iVar1 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar1 == 1) {
		          param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x81097053;
		        }
		        DAT_ram_009d3e38 = 0;
		        iVar5 = import::env::invoke_iiii
		                          (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x2e0,
		                           *(undefined4 *)(*(int *)(iVar5 + 8) + 0x40),iVar4,
		                           Method_Google_Protobuf_Collections_RepeatedField_MedalInfo__get_Item__);
		        iVar1 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar1 == 1) {
		          param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x81097053;
		        }
		        if (*(int *)(iVar5 + 0xc) == *(int *)(iVar9 + 0xc)) {
		          DAT_ram_009d3e38 = 0;
		          iVar6 = import::env::invoke_iii
		                            (*(undefined4 *)(*param1 + 0x100),param1,
		                             *(undefined4 *)(*param1 + 0x104));
		          iVar9 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar9 == 1) {
		            param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x81097053;
		          }
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_iiii
		                    (s_struct_Uniforms___color__array<v_ram_00001f04 + 0x3f,
		                     *(undefined4 *)(*(int *)(iVar6 + 8) + 0x40),iVar5,
		                     Method_Google_Protobuf_Collections_RepeatedField_MedalInfo__Remove__);
		          iVar9 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar9 == 1) {
		            param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x81097053;
		          }
		          break;
		        }
		        iVar4 = iVar4 + 1;
		      } while (iVar4 != iVar6);
		    }
		    goto code_r0x81096cbb;
		  }
		code_r0x81096d9b:
		  DAT_ram_009d3e38 = 0;
		  param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x81097053:
		  iVar9 = global_1;
		  iVar6 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar9 == iVar6) {
		    piVar7 = (int *)import::env::__cxa_begin_catch(param1_00);
		    iVar9 = *piVar7;
		    DAT_ram_009d3e38 = 0;
		    local_c = iVar9;
		    import::env::invoke_v(0x123);
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 != 1) {
		code_r0x8109709c:
		      piVar7 = local_4;
		      DAT_ram_009d3e38 = 0;
		      if (local_4 != (int *)0x0) {
		        uVar2 = 0;
		        iVar6 = *local_4;
		        if (*(ushort *)(iVar6 + 0xb6) != 0) {
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar2 * 8)) {
		              puVar8 = (uint *)(iVar6 + *(int *)(*(int *)(iVar6 + 0x58) + uVar2 * 8 + 4) * 8 + 0xc0)
		              ;
		              goto code_r0x81097114;
		            }
		            uVar2 = uVar2 + 1;
		          } while (*(ushort *)(iVar6 + 0xb6) != uVar2);
		        }
		        puVar8 = (uint *)func_ii_1080(local_4,System_IDisposable_TypeInfo,0);
		code_r0x81097114:
		        (**(code **)((ulonglong)*puVar8 * 4))(piVar7,puVar8[1]);
		      }
		      if (iVar9 == 0) {
		        return;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(iVar9);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    param1_00 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001f04 + 0x40,&local_c);
		  iVar9 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar9 == 1) {
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  import::env::__resumeException(param1_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06001909 RID: 6409 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001909")]
		[Address(RVA = "0x6AA8", Offset = "0x6AA8", VA = "0x6AA8")]
		private void TakeOffMedalsEventHandler(ProtoTakeOffMedalsEvt evt)
		{
		/* --- GHIDRA: TakeOffMedalsEventHandler ---
		void Gameplay_User_Controller_UserController__TakeOffMedalsEventHandler
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  Core_Data_UserData__get_SkillsData(*(undefined4 *)(iVar1 + 8),param2,0);
		  return;
		}
		*/

		}

		// Token: 0x0600190A RID: 6410 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600190A")]
		[Address(RVA = "0x6AA9", Offset = "0x6AA9", VA = "0x6AA9")]
		private void MainServiceOnSkillsChangedEvent(ProtoSkillsChangedEvt evt)
		{
		/* --- GHIDRA: MainServiceOnSkillsChangedEvent ---
		void Gameplay_User_Controller_UserController__MainServiceOnSkillsChangedEvent
		               (undefined4 param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a59959 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_ServicesService___);
		    Mono_Security_ASN1__get_Item(&Core_Net_ServiceFactory_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_User_Controller_UserController_HandlerServiceBuyNextLevel__);
		    DAT_ram_00a59959 = '\x01';
		  }
		  if (*(int *)(Core_Net_ServiceFactory_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_ServiceFactory_TypeInfo);
		  }
		  uVar1 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                    (Method_Core_Net_ServiceFactory_GetService_ServicesService___);
		  uVar1 = ServicesNamespace_ServicesService__BuyUserSlots(uVar1,0);
		  param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_User_Controller_UserController_HandlerServiceBuyNextLevel__,0);
		  ServicesNamespace_MainService__GetUserStats
		            (uVar1,param1_00,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  return;
		}
		*/

		}

		// Token: 0x0600190B RID: 6411 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600190B")]
		[Address(RVA = "0x6AAA", Offset = "0x6AAA", VA = "0x6AAA")]
		public void BuyNextLevel()
		{
		/* --- GHIDRA: BuyNextLevel ---
		void Gameplay_User_Controller_UserController__BuyNextLevel
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int *param1_00;
		  int local_4;
		  
		  if (DAT_ram_00a5995a == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Common_ProtoDefaultAns_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_17357);
		    DAT_ram_00a5995a = '\x01';
		  }
		  param1_00 = *(int **)(param2 + 0x20);
		  if ((param1_00 != (int *)0x0) && (Protocol_Common_ProtoDefaultAns_TypeInfo != *param1_00)) {
		    System_Activator__CreateInstance(param1_00,Protocol_Common_ProtoDefaultAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  local_4 = param1_00[3];
		  if (local_4 < 0) {
		    uVar1 = func_ii_1081(DAT_ram_00a66954,&local_4);
		    uVar1 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                      (StringLiteral_17357,uVar1,param1_00[4],0);
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    System_Collections_Generic_Dictionary_uint__object___get_Count(uVar1,0);
		  }
		  else {
		    Gameplay_User_Controller_UserController__ProfessionChangedEventHandler(param1,local_4,param1_00)
		    ;
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600190C RID: 6412 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600190C")]
		[Address(RVA = "0x6AAB", Offset = "0x6AAB", VA = "0x6AAB")]
		private void HandlerServiceBuyNextLevel(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: HandlerServiceBuyNextLevel ---
		void Gameplay_User_Controller_UserController__HandlerServiceBuyNextLevel
		               (undefined4 param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5995b == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_ServicesService___);
		    Mono_Security_ASN1__get_Item(&Core_Net_ServiceFactory_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_User_Controller_UserController_PayoffBanResultHandler__);
		    DAT_ram_00a5995b = '\x01';
		  }
		  if (*(int *)(Core_Net_ServiceFactory_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_ServiceFactory_TypeInfo);
		  }
		  uVar1 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                    (Method_Core_Net_ServiceFactory_GetService_ServicesService___);
		  uVar1 = ServicesNamespace_ServicesService__RestoreGolemItem(uVar1,0);
		  param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_User_Controller_UserController_PayoffBanResultHandler__,0);
		  ServicesNamespace_MainService__GetUserStats
		            (uVar1,param1_00,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  return;
		}
		*/

		}

		// Token: 0x0600190D RID: 6413 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600190D")]
		[Address(RVA = "0x6AAC", Offset = "0x6AAC", VA = "0x6AAC")]
		public void PayoffBan()
		{
		/* --- GHIDRA: PayoffBan ---
		void Gameplay_User_Controller_UserController__PayoffBan(int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int *param1_00;
		  
		  if (DAT_ram_00a5995c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedBillingErrors__ExpectedPayoffBanErrors___
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Services_ProtoPayoffBanAns_TypeInfo);
		    DAT_ram_00a5995c = '\x01';
		  }
		  param1_00 = *(int **)(param2 + 0x20);
		  if ((param1_00 != (int *)0x0) && (Protocol_Services_ProtoPayoffBanAns_TypeInfo != *param1_00)) {
		    System_Activator__CreateInstance(param1_00,Protocol_Services_ProtoPayoffBanAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar1 = Core_Errors_Expected_ExpectedErrorsHandler__HandleErrorChain_object_
		                    (param1_00[3],0,0,
		                     Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedBillingErrors__ExpectedPayoffBanErrors___
		                    );
		  if (iVar1 == 0) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    *(undefined4 *)(iVar1 + 0x24) = 0;
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600190E RID: 6414 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600190E")]
		[Address(RVA = "0x6AAD", Offset = "0x6AAD", VA = "0x6AAD")]
		private void PayoffBanResultHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: PayoffBanResultHandler ---
		undefined4
		Gameplay_User_Controller_UserController__PayoffBanResultHandler(undefined4 param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 uVar1;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a5995d == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_bool__int___ctor__);
		    Mono_Security_ASN1__get_Item(&Utils_OpToken_bool__int__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_TreeService___);
		    Mono_Security_ASN1__get_Item(&Core_Net_ServiceFactory_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_User_Controller_UserController_BuyLicenseServerHandler__);
		    DAT_ram_00a5995d = '\x01';
		  }
		  param1_00 = unnamed_function_1417(Utils_OpToken_bool__int__TypeInfo);
		  Gameplay_FeedbackForm_Model_FeedbackFormModel__GetUid
		            (param1_00,Method_Utils_OpToken_bool__int___ctor__);
		  if (*(int *)(Core_Net_ServiceFactory_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_ServiceFactory_TypeInfo);
		  }
		  uVar1 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                    (Method_Core_Net_ServiceFactory_GetService_TreeService___);
		  uVar1 = ServicesNamespace_TreeService__ServerEventHandler(uVar1,0);
		  param1_01 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_01,param1,
		             Method_Gameplay_User_Controller_UserController_BuyLicenseServerHandler__,0);
		  ServicesNamespace_MainService__GetUserStats
		            (uVar1,param1_01,param1_00,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  return param1_00;
		}
		*/

		}

		// Token: 0x0600190F RID: 6415 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600190F")]
		[Address(RVA = "0x6AAE", Offset = "0x6AAE", VA = "0x6AAE")]
		public OpToken<bool, int> BuyLicense()
		{
		/* --- GHIDRA: BuyLicense ---
		void Gameplay_User_Controller_UserController__BuyLicense(int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int *param1_00;
		  int *param1_01;
		  
		  if (DAT_ram_00a5995e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedBillingErrors___
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_bool__int__Complete__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_bool__int__Fail__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Utils_OpToken_bool__int__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Tree_ProtoBuyLicenseAns_TypeInfo);
		    DAT_ram_00a5995e = '\x01';
		  }
		  param1_00 = *(int **)(param2 + 0xc);
		  if (param1_00 != (int *)0x0) {
		    if (((uint)*(byte *)(*param1_00 + 0xb8) <
		         (uint)*(byte *)(Utils_OpToken_bool__int__TypeInfo + 0xb8)) ||
		       (*(int *)(*(int *)(*param1_00 + 100) +
		                 (uint)*(byte *)(Utils_OpToken_bool__int__TypeInfo + 0xb8) * 4 + -4) !=
		        Utils_OpToken_bool__int__TypeInfo)) {
		      System_Activator__CreateInstance(param1_00,Utils_OpToken_bool__int__TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  param1_01 = *(int **)(param2 + 0x20);
		  if ((param1_01 != (int *)0x0) && (Protocol_Tree_ProtoBuyLicenseAns_TypeInfo != *param1_01)) {
		    System_Activator__CreateInstance(param1_01,Protocol_Tree_ProtoBuyLicenseAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar1 = UnityEngine_EventSystems_ExecuteEvents__ValidateEventData_object_
		                    (param1_01[3],0,
		                     Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedBillingErrors___
		                    );
		  if (iVar1 != 0) {
		    Utils_OpToken_object__object___DisposeHandlers
		              (param1_00,param1_01[3],Method_Utils_OpToken_bool__int__Fail__);
		    return;
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  Core_Data_UserData__get_LicenseCount(*(undefined4 *)(iVar1 + 8),param1_01[3],0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(iVar1 + 0x18);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  }
		  Utils_OpToken_bool__int___Cancel(param1_00,1,Method_Utils_OpToken_bool__int__Complete__);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06001910 RID: 6416 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001910")]
		[Address(RVA = "0x6AAF", Offset = "0x6AAF", VA = "0x6AAF")]
		private void BuyLicenseServerHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: BuyLicenseServerHandler ---
		void Gameplay_User_Controller_UserController__BuyLicenseServerHandler
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param1_00;
		  int *param1_01;
		  
		  if (DAT_ram_00a5995f == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Balance_ProtoGetUserBalanceAns_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_ClansService___);
		    Mono_Security_ASN1__get_Item(&Core_Net_ServiceFactory_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_User_Controller_UserController_HandleGetOwnClanInfoService__);
		    DAT_ram_00a5995f = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  param1_01 = *(int **)(param2 + 0x20);
		  if ((param1_01 != (int *)0x0) && (Protocol_Balance_ProtoGetUserBalanceAns_TypeInfo != *param1_01))
		  {
		    System_Activator__CreateInstance(param1_01,Protocol_Balance_ProtoGetUserBalanceAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  Core_Data_UserData__get_Money(*(undefined4 *)(iVar1 + 8),param1_01[3],0);
		  if (*(int *)(Core_Net_ServiceFactory_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_ServiceFactory_TypeInfo);
		  }
		  uVar2 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                    (Method_Core_Net_ServiceFactory_GetService_ClansService___);
		  uVar2 = ServicesNamespace_ClansService__ServerEventHandler(uVar2,0);
		  param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_User_Controller_UserController_HandleGetOwnClanInfoService__,0);
		  uVar2 = ServicesNamespace_MainService__GetUserStats
		                    (uVar2,param1_00,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  Utils_OpToken_int__object___AddHandlers(param1,uVar2,0);
		  return;
		}
		*/

		}

		// Token: 0x06001911 RID: 6417 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001911")]
		[Address(RVA = "0x6AB0", Offset = "0x6AB0", VA = "0x6AB0")]
		private void HandelGetUserBalanceService(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: HandelGetUserBalanceService ---
		void Gameplay_User_Controller_UserController__HandelGetUserBalanceService
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int *param1_00;
		  undefined8 uVar2;
		  
		  if (DAT_ram_00a59960 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Clans_ProtoGetOwnClanInfoAns_TypeInfo);
		    DAT_ram_00a59960 = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  param1_00 = *(int **)(param2 + 0x20);
		  if ((param1_00 != (int *)0x0) && (Protocol_Clans_ProtoGetOwnClanInfoAns_TypeInfo != *param1_00)) {
		    System_Activator__CreateInstance(param1_00,Protocol_Clans_ProtoGetOwnClanInfoAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  if ((char)param1_00[6] == '\0') {
		    uVar2 = 0;
		  }
		  else {
		    uVar2 = *(undefined8 *)(param1_00 + 4);
		  }
		  *(undefined8 *)(iVar1 + 0x10) = uVar2;
		  Gameplay_User_Controller_UserController__HandleGetOwnClanInfoService(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06001912 RID: 6418 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001912")]
		[Address(RVA = "0x6AB1", Offset = "0x6AB1", VA = "0x6AB1")]
		private void HandleGetOwnClanInfoService(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: HandleGetOwnClanInfoService ---
		void Gameplay_User_Controller_UserController__HandleGetOwnClanInfoService
		               (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a59961 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_User_Controller_UserController_HandleGetUserInfoService__);
		    DAT_ram_00a59961 = '\x01';
		  }
		  uVar1 = ServicesNamespace_MainService__GetUserMedals(*(undefined4 *)(param1 + 0x18),0);
		  param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_User_Controller_UserController_HandleGetUserInfoService__,0);
		  uVar1 = ServicesNamespace_MainService__GetUserStats
		                    (uVar1,param1_00,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  Utils_OpToken_int__object___AddHandlers(param1,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x06001913 RID: 6419 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001913")]
		[Address(RVA = "0x6AB2", Offset = "0x6AB2", VA = "0x6AB2")]
		public void UpdateUserInfo()
		{
		/* --- GHIDRA: UpdateUserInfo ---
		void Gameplay_User_Controller_UserController__UpdateUserInfo
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 in_register_20000014;
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 param1_00;
		  undefined4 param2_00;
		  undefined4 param2_01;
		  int iVar3;
		  double param3_00;
		  int iVar4;
		  
		  iVar3 = 0;
		  if (DAT_ram_00a59962 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Resources__get_Count__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Resources__get_Item__);
		    DAT_ram_00a59962 = '\x01';
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x104)));
		  param1_00 = Protocol_Common_ResourceSet___ctor(*(undefined4 *)(*(int *)(iVar2 + 8) + 0x78),0);
		  uVar1 = 0xbff00000;
		  iVar2 = Core_Extensions_Dict_NullableResourceSetExt__ToResourceSet(param2,-1.0,0);
		  iVar4 = *(int *)(iVar2 + 0xc);
		  if (0 < iVar4) {
		    do {
		      param2_00 = System_Linq_Enumerable__ToList_object_
		                            (iVar2,iVar3,
		                             Method_System_Collections_Generic_List_Resources__get_Item__);
		      param2_01 = System_Linq_Enumerable__ToList_object_
		                            (iVar2,iVar3,
		                             Method_System_Collections_Generic_List_Resources__get_Item__);
		      param3_00 = func_ii_6906(param2,param2_01,0);
		      Core_Extensions_Dict_ResourceSetExt__HasNewCurrency(param1_00,param2_00,param3_00,0);
		      iVar3 = iVar3 + 1;
		    } while (iVar3 != iVar4);
		  }
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,CONCAT44(uVar1,*(undefined4 *)(*param1 + 0x104)));
		  Core_Data_UserData__get_Money(*(undefined4 *)(iVar3 + 8),param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x06001914 RID: 6420 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001914")]
		[Address(RVA = "0x6AB3", Offset = "0x6AB3", VA = "0x6AB3")]
		public void SetBalance(NullableResourceSet value)
		{
		/* --- GHIDRA: SetBalance ---
		void Gameplay_User_Controller_UserController__SetBalance(int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 in_register_20000014;
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  undefined4 param2_00;
		  int *param1_00;
		  undefined8 uVar4;
		  
		  if (DAT_ram_00a59963 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToArray_AccountInfo___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToArray_ulong___);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Main_ProtoGetUserInfoAns_TypeInfo);
		    DAT_ram_00a59963 = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  param1_00 = *(int **)(param2 + 0x20);
		  if ((param1_00 != (int *)0x0) && (Protocol_Main_ProtoGetUserInfoAns_TypeInfo != *param1_00)) {
		    System_Activator__CreateInstance(param1_00,Protocol_Main_ProtoGetUserInfoAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  uVar4 = CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x104));
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(param1,uVar4);
		  iVar2 = *(int *)(iVar2 + 8);
		  uVar1 = (undefined4)((ulonglong)uVar4 >> 0x20);
		  uVar3 = System_Linq_Enumerable__ToArray_PlayerLoopSystem_
		                    (param1_00[0x12],Method_System_Linq_Enumerable_ToArray_ulong___);
		  *(undefined4 *)(iVar2 + 0x54) = uVar3;
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,CONCAT44(uVar1,*(undefined4 *)(*param1 + 0x104)));
		  uVar4 = *(undefined8 *)(param1_00 + 10);
		  Core_Data_UserData__get_Experience(*(undefined4 *)(iVar2 + 8),uVar4,0);
		  uVar4 = CONCAT44((int)((ulonglong)uVar4 >> 0x20),*(undefined4 *)(*param1 + 0x104));
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(param1,uVar4);
		  uVar1 = (undefined4)((ulonglong)uVar4 >> 0x20);
		  Core_Data_UserData__get_LicenseCount(*(undefined4 *)(iVar2 + 8),param1_00[0xd],0);
		  uVar4 = CONCAT44(uVar1,*(undefined4 *)(*param1 + 0x104));
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(param1,uVar4);
		  uVar1 = (undefined4)((ulonglong)uVar4 >> 0x20);
		  Core_Data_UserData__get_TreeLevel(*(undefined4 *)(iVar2 + 8),param1_00[0xc],0);
		  uVar4 = CONCAT44(uVar1,*(undefined4 *)(*param1 + 0x104));
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(param1,uVar4);
		  uVar1 = (undefined4)((ulonglong)uVar4 >> 0x20);
		  uVar3 = func_ii_7504(*(undefined4 *)(iVar2 + 8),0);
		  param2_00 = func_ii_6295(param1_00[0x10],Method_System_Linq_Enumerable_ToArray_AccountInfo___);
		  Core_Data_Accounts_AccountsStorage__Reset(uVar3,param2_00,0);
		  Gameplay_User_Controller_UserController__HandleGetUserInfoService(param1,param1);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,CONCAT44(uVar1,*(undefined4 *)(*param1 + 0x114)));
		  iVar2 = *(int *)(iVar2 + 0x14);
		  if (iVar2 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		              (*(undefined4 *)(iVar2 + 0x20),*(undefined4 *)(iVar2 + 0x14));
		  }
		  Gameplay_User_Controller_UserController__GetUserProfessionsResultHandler(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06001915 RID: 6421 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001915")]
		[Address(RVA = "0x6AB4", Offset = "0x6AB4", VA = "0x6AB4")]
		private void HandleGetUserInfoService(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: HandleGetUserInfoService ---
		void Gameplay_User_Controller_UserController__HandleGetUserInfoService
		               (undefined4 param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a59964 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_BalanceService___);
		    Mono_Security_ASN1__get_Item(&Core_Net_ServiceFactory_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_User_Controller_UserController_HandleGetEnergyRegenStatusService__);
		    DAT_ram_00a59964 = '\x01';
		  }
		  if (*(int *)(Core_Net_ServiceFactory_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_ServiceFactory_TypeInfo);
		  }
		  uVar1 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                    (Method_Core_Net_ServiceFactory_GetService_BalanceService___);
		  uVar1 = ServicesNamespace_BalanceService__GetUserBalance(uVar1,0);
		  param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_User_Controller_UserController_HandleGetEnergyRegenStatusService__,0);
		  uVar1 = ServicesNamespace_MainService__GetUserStats
		                    (uVar1,param1_00,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  Utils_OpToken_int__object___AddHandlers(param1,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x06001916 RID: 6422 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001916")]
		[Address(RVA = "0x6AB5", Offset = "0x6AB5", VA = "0x6AB5")]
		private void UpdateEnergyRegenStatus()
		{
		/* --- GHIDRA: UpdateEnergyRegenStatus ---
		void Gameplay_User_Controller_UserController__UpdateEnergyRegenStatus
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 in_register_20000014;
		  int iVar1;
		  undefined4 param1_00;
		  int *param1_01;
		  undefined4 param2_00;
		  undefined4 param5;
		  double param2_01;
		  double param4;
		  
		  if (DAT_ram_00a59965 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_User_Model_EnergyRegenStatus_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Balance_ProtoGetEnergyRegenStatusAns_TypeInfo);
		    DAT_ram_00a59965 = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  param1_01 = *(int **)(param2 + 0x20);
		  if ((param1_01 != (int *)0x0) &&
		     (Protocol_Balance_ProtoGetEnergyRegenStatusAns_TypeInfo != *param1_01)) {
		    System_Activator__CreateInstance
		              (param1_01,Protocol_Balance_ProtoGetEnergyRegenStatusAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x104)));
		  param2_01 = *(double *)(*(int *)(*(int *)(iVar1 + 8) + 0x78) + 0x20);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  param2_00 = *(undefined4 *)(*(int *)(iVar1 + 8) + 0x78);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  param4 = *(double *)(iVar1 + 0x30);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  param5 = *(undefined4 *)(iVar1 + 0x28);
		  param1_00 = unnamed_function_1417(Gameplay_User_Model_EnergyRegenStatus_TypeInfo);
		  Gameplay_User_Model_EnergyRegenStatus__set_FullEnergyRecoveryBacktime
		            (param1_00,param2_00,param1_01,param4,param5,param1);
		  Gameplay_User_Controller_UserController__HandleGetEnergyRegenStatusService
		            (param1,param2_01,param1_00,param1);
		  return;
		}
		*/

		}

		// Token: 0x06001917 RID: 6423 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001917")]
		[Address(RVA = "0x6AB6", Offset = "0x6AB6", VA = "0x6AB6")]
		private void HandleGetEnergyRegenStatusService(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: HandleGetEnergyRegenStatusService ---
		void Gameplay_User_Controller_UserController__HandleGetEnergyRegenStatusService
		               (int *param1,double param2,int param3,undefined4 param4)
		
		{
		  int iVar1;
		  float fVar2;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  if (*(int *)(iVar1 + 0x1c) != param3) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    iVar1 = *(int *)(iVar1 + 0x1c);
		    *(undefined4 *)(iVar1 + 0x10) = 0;
		    *(undefined8 *)(iVar1 + 8) = 0;
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    *(int *)(iVar1 + 0x1c) = param3;
		    if (param1[9] != 0) {
		      func_ii_7950(param1[9],0);
		    }
		    param1[9] = 0;
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    if (param2 < (double)*(uint *)(*(int *)(*(int *)(iVar1 + 0x1c) + 8) + 0x10)) {
		      iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		      fVar2 = func_ii_7103(*(undefined4 *)(*(int *)(iVar1 + 0x1c) + 0xc),0);
		      if (0.0 < fVar2) {
		        iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0x104));
		        fVar2 = func_ii_7103(*(undefined4 *)(*(int *)(iVar1 + 0x1c) + 0xc),0);
		        if (DAT_ram_00a59966 == '\0') {
		          Mono_Security_ASN1__get_Item
		                    (&
		                     Gameplay_User_Controller_UserController__EnergyRecoveryCoroutine_d__28_TypeInfo
		                    );
		          DAT_ram_00a59966 = '\x01';
		        }
		        iVar1 = unnamed_function_1417
		                          (
		                          Gameplay_User_Controller_UserController__EnergyRecoveryCoroutine_d__28_TypeInfo
		                          );
		        Unity_Services_Core_Environments_Internal_Environments__get_Current(iVar1,0,0);
		        *(float *)(iVar1 + 0x10) = fVar2;
		        *(int **)(iVar1 + 0x14) = param1;
		        iVar1 = Utils_CoroutineSource__GetMono(iVar1,0);
		        param1[9] = iVar1;
		      }
		    }
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar1 = *(int *)(iVar1 + 0x1c);
		    if (iVar1 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001918 RID: 6424 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001918")]
		[Address(RVA = "0x6AB7", Offset = "0x6AB7", VA = "0x6AB7")]
		private void SetEnergyRegenStatus(double energy, EnergyRegenStatus value)
		{
		/* --- GHIDRA: SetEnergyRegenStatus ---
		int Gameplay_User_Controller_UserController__SetEnergyRegenStatus
		              (undefined4 param1,float param2,undefined4 param3)
		
		{
		  int param1_00;
		  
		  if (DAT_ram_00a59966 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_User_Controller_UserController__EnergyRecoveryCoroutine_d__28_TypeInfo);
		    DAT_ram_00a59966 = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (
		                        Gameplay_User_Controller_UserController__EnergyRecoveryCoroutine_d__28_TypeInfo
		                        );
		  Unity_Services_Core_Environments_Internal_Environments__get_Current(param1_00,0,0);
		  *(float *)(param1_00 + 0x10) = param2;
		  *(undefined4 *)(param1_00 + 0x14) = param1;
		  return param1_00;
		}
		*/

		}

		// Token: 0x06001919 RID: 6425 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001919")]
		[Address(RVA = "0x6AB8", Offset = "0x6AB8", VA = "0x6AB8")]
		private IEnumerator EnergyRecoveryCoroutine(float seconds)
		{
		/* --- GHIDRA: EnergyRecoveryCoroutine ---
		void Gameplay_User_Controller_UserController__EnergyRecoveryCoroutine(int param1,undefined4 param2)
		
		{
		  if (*(int *)(param1 + 0x24) != 0) {
		    func_ii_7950(*(int *)(param1 + 0x24),0);
		  }
		  *(undefined4 *)(param1 + 0x24) = 0;
		  return;
		}
		*/

			return null;
		}

		// Token: 0x0600191A RID: 6426 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600191A")]
		[Address(RVA = "0x6AB9", Offset = "0x6AB9", VA = "0x6AB9")]
		private void StopEnergyRecoveryCoroutine()
		{
		/* --- GHIDRA: StopEnergyRecoveryCoroutine ---
		void Gameplay_User_Controller_UserController__StopEnergyRecoveryCoroutine
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int *param1_00;
		  
		  if (DAT_ram_00a59967 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Craft_ProtoGetUserProfessionsAns_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_UserProfession__get_Item__);
		    DAT_ram_00a59967 = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  param1_00 = *(int **)(param2 + 0x20);
		  if ((param1_00 != (int *)0x0) &&
		     (Protocol_Craft_ProtoGetUserProfessionsAns_TypeInfo != *param1_00)) {
		    System_Activator__CreateInstance(param1_00,Protocol_Craft_ProtoGetUserProfessionsAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar2 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                    (param1_00[3],0,
		                     Method_Google_Protobuf_Collections_RepeatedField_UserProfession__get_Item__);
		  *(undefined4 *)(iVar1 + 0x20) = uVar2;
		  return;
		}
		*/

		}

		// Token: 0x0600191B RID: 6427 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600191B")]
		[Address(RVA = "0x6ABA", Offset = "0x6ABA", VA = "0x6ABA")]
		private void GetUserProfessionsResultHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: GetUserProfessionsResultHandler ---
		void Gameplay_User_Controller_UserController__GetUserProfessionsResultHandler
		               (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  undefined4 param2_00;
		  int iVar5;
		  int *param1_00;
		  
		  if (DAT_ram_00a59968 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a59968 = '\x01';
		  }
		  if (*(char *)((int)param1 + 9) == '\0') {
		    *(undefined1 *)((int)param1 + 9) = 1;
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    iVar5 = *(int *)(iVar2 + 8);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    uVar1 = 0;
		    param1_00 = *(int **)(iVar2 + 0x40);
		    iVar2 = *param1_00;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x178);
		          goto code_r0x81097d32;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x81097d32:
		    uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(param1_00,puVar3[1]);
		    uVar4 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar4,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    param2_00 = Core_Data_UserData__set_LevelDic(*(undefined4 *)(iVar2 + 8),0);
		    uVar4 = Core_Extensions_Dict_DictExt__GetCaveLevel(uVar4,param2_00,0);
		    *(undefined4 *)(iVar5 + 0x6c) = uVar4;
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    iVar2 = *(int *)(iVar2 + 8);
		    iVar5 = *param1;
		    uVar4 = (**(code **)((ulonglong)*(uint *)(iVar5 + 0x100) * 4))
		                      (param1,*(undefined4 *)(iVar5 + 0x104));
		    uVar4 = Gameplay_User_Model_EnergyRegenStatus__Dispose(uVar4,iVar5);
		    *(undefined4 *)(iVar2 + 0x70) = uVar4;
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar2 = *(int *)(iVar2 + 8);
		    if (iVar2 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		                (*(undefined4 *)(iVar2 + 0x20),*(undefined4 *)(iVar2 + 0x14));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600191C RID: 6428 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600191C")]
		[Address(RVA = "0x6ABB", Offset = "0x6ABB", VA = "0x6ABB")]
		private void HandleInit()
		{
		/* --- GHIDRA: HandleInit ---
		void Gameplay_User_Controller_UserController__HandleInit(int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a59969 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Utils_Accumulators_AccumulatorBase_int__TriggerValue__Update__);
		    DAT_ram_00a59969 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  param1_00 = Core_Gameplay_Managers_UserManager__get_User(*(undefined4 *)(iVar1 + 8),0);
		  Utils_Accumulators_AccumulatorBase_int__object___RunTimer
		            (param1_00,*(undefined4 *)(param2 + 0xc),
		             Method_Utils_Accumulators_AccumulatorBase_int__TriggerValue__Update__);
		  return;
		}
		*/

		}

		// Token: 0x0600191D RID: 6429 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600191D")]
		[Address(RVA = "0x6ABC", Offset = "0x6ABC", VA = "0x6ABC")]
		private void HandleTriggersChangedEvent(ProtoTriggersChangedEvt msg)
		{
		/* --- GHIDRA: HandleTriggersChangedEvent ---
		void Gameplay_User_Controller_UserController__HandleTriggersChangedEvent
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 in_register_20000014;
		  undefined8 uVar1;
		  int iVar2;
		  int param3_00;
		  int iVar3;
		  undefined4 uVar4;
		  undefined4 param5;
		  double param4;
		  
		  if (DAT_ram_00a5996a == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_User_Model_EnergyRegenStatus_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Balance_ProtoGetEnergyRegenStatusAns_TypeInfo);
		    DAT_ram_00a5996a = '\x01';
		  }
		  uVar1 = CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x104));
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(param1,uVar1);
		  if (*(int *)(*(int *)(iVar2 + 8) + 0x78) != 0) {
		    uVar1 = CONCAT44((int)((ulonglong)uVar1 >> 0x20),*(undefined4 *)(*param1 + 0x104));
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(param1,uVar1);
		    uVar4 = (undefined4)((ulonglong)uVar1 >> 0x20);
		    iVar2 = Protocol_Common_ResourceSet___ctor(*(undefined4 *)(*(int *)(iVar2 + 8) + 0x78),0);
		    if (*(int *)(param2 + 0x10) != 0) {
		      param3_00 = unnamed_function_1417(Protocol_Balance_ProtoGetEnergyRegenStatusAns_TypeInfo);
		      iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,CONCAT44(uVar4,*(undefined4 *)(*param1 + 0x104)));
		      *(undefined4 *)(param3_00 + 0x10) =
		           *(undefined4 *)(*(int *)(*(int *)(iVar3 + 0x1c) + 8) + 0x10);
		      *(undefined4 *)(param3_00 + 0xc) = *(undefined4 *)(param2 + 0x10);
		      iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		      param4 = *(double *)(iVar3 + 0x30);
		      iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		      param5 = *(undefined4 *)(iVar3 + 0x28);
		      uVar4 = unnamed_function_1417(Gameplay_User_Model_EnergyRegenStatus_TypeInfo);
		      Gameplay_User_Model_EnergyRegenStatus__set_FullEnergyRecoveryBacktime
		                (uVar4,iVar2,param3_00,param4,param5,param1);
		      Gameplay_User_Controller_UserController__HandleGetEnergyRegenStatusService
		                (param1,*(double *)(iVar2 + 0x20),uVar4,param1);
		    }
		    Gameplay_User_Controller_UserController__UpdateUserInfo
		              (param1,*(undefined4 *)(param2 + 0xc),param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600191E RID: 6430 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600191E")]
		[Address(RVA = "0x6ABD", Offset = "0x6ABD", VA = "0x6ABD")]
		private void HandleBalanceChangedEventService(ProtoResourcesChangedEvt evt)
		{
		/* --- GHIDRA: HandleBalanceChangedEventService ---
		void Gameplay_User_Controller_UserController__HandleBalanceChangedEventService
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  Gameplay_User_Controller_UserController__ProfessionChangedEventHandler
		            (param1,*(undefined4 *)(param2 + 0xc),param2);
		  return;
		}
		*/

		}

		// Token: 0x0600191F RID: 6431 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600191F")]
		[Address(RVA = "0x6ABE", Offset = "0x6ABE", VA = "0x6ABE")]
		private void HandleNewLevelEvent(ProtoNewLevelEvt evt)
		{
		/* --- GHIDRA: HandleNewLevelEvent ---
		void Gameplay_User_Controller_UserController__HandleNewLevelEvent
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 in_register_20000014;
		  int iVar1;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x104)));
		  Core_Data_UserData__get_Experience(*(undefined4 *)(iVar1 + 8),*(undefined8 *)(param2 + 0x10),0);
		  return;
		}
		*/

		}

		// Token: 0x06001920 RID: 6432 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001920")]
		[Address(RVA = "0x6ABF", Offset = "0x6ABF", VA = "0x6ABF")]
		private void HandleExpChangedEvent(ProtoExperienceChangedEvt evt)
		{
		/* --- GHIDRA: HandleExpChangedEvent ---
		void Gameplay_User_Controller_UserController__HandleExpChangedEvent
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  param1_00 = *(undefined4 *)(iVar1 + 8);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  Core_Data_UserData__get_LicenseCount(param1_00,*(undefined4 *)(*(int *)(iVar1 + 8) + 100),0);
		  return;
		}
		*/

		}

		// Token: 0x06001921 RID: 6433 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001921")]
		[Address(RVA = "0x6AC0", Offset = "0x6AC0", VA = "0x6AC0")]
		private void HandleTreeRegenEvent(ProtoRegenTreeEvt evt)
		{
		/* --- GHIDRA: HandleTreeRegenEvent ---
		void Gameplay_User_Controller_UserController__HandleTreeRegenEvent
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  
		  iVar2 = *(int *)(param2 + 0xc);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  if (iVar2 == *(int *)(*(int *)(iVar1 + 0x20) + 0xc)) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    *(int *)(iVar1 + 0x20) = param2;
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001922 RID: 6434 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001922")]
		[Address(RVA = "0x6AC1", Offset = "0x6AC1", VA = "0x6AC1")]
		private void ProfessionChangedEventHandler(UserProfession profession)
		{
		/* --- GHIDRA: ProfessionChangedEventHandler ---
		void Gameplay_User_Controller_UserController__ProfessionChangedEventHandler
		               (int *param1,uint param2,undefined4 param3)
		
		{
		  int iVar1;
		  uint uVar2;
		  undefined4 param3_00;
		  uint *puVar3;
		  undefined4 uVar4;
		  undefined4 param1_00;
		  int iVar5;
		  int *param1_01;
		  undefined4 local_18;
		  undefined8 local_14;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5996b == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Utils_LocalProps_Names_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Utils_LocalProps_Scopes_TypeInfo);
		    DAT_ram_00a5996b = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar2 = Core_Data_UserData__set_LevelDic(*(undefined4 *)(iVar1 + 8),0);
		  if (uVar2 < param2) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    param1_00 = *(undefined4 *)(iVar1 + 0x3c);
		    local_8 = 0xffffffff;
		    local_c = Utils_LocalProps_Scopes_TypeInfo;
		    uVar4 = Spine_SkeletonJson__GetFloat(&local_c,0);
		    local_14 = 0xffffffff;
		    local_18 = Utils_LocalProps_Names_TypeInfo;
		    param3_00 = Spine_SkeletonJson__GetFloat(&local_18,0);
		    uVar4 = Utils_LocalProps__TryGetProp(param1_00,uVar4,param3_00,(longlong)(int)param2,0,0);
		    Utils_LocalProps__SetProp(uVar4,0);
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  iVar5 = *(int *)(iVar1 + 8);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar2 = 0;
		  param1_01 = *(int **)(iVar1 + 0x40);
		  iVar1 = *param1_01;
		  if (*(ushort *)(iVar1 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar1 + 0x58) + uVar2 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar1 + 0x58) + uVar2 * 8 + 4) * 8 + iVar1 + 0x178);
		        goto code_r0x8109749c;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar1 + 0xb6) != uVar2);
		  }
		  puVar3 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x8109749c:
		  uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(param1_01,puVar3[1]);
		  uVar4 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar4,0);
		  uVar4 = Core_Extensions_Dict_DictExt__GetCaveLevel(uVar4,param2,0);
		  *(undefined4 *)(iVar5 + 0x6c) = uVar4;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  Core_Data_UserData__get_Level(*(undefined4 *)(iVar1 + 8),param2,0);
		  return;
		}
		*/

		}

		// Token: 0x06001923 RID: 6435 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001923")]
		[Address(RVA = "0x6AC2", Offset = "0x6AC2", VA = "0x6AC2")]
		private void SetLevel(uint value)
		{
		}

		// Token: 0x04000D3C RID: 3388
		[Token(Token = "0x4000D3C")]
		[FieldOffset(Offset = "0x18")]
		private MainService _mainService;

		// Token: 0x04000D3D RID: 3389
		[Token(Token = "0x4000D3D")]
		[FieldOffset(Offset = "0x1C")]
		private WorldService _worldService;

		// Token: 0x04000D3E RID: 3390
		[Token(Token = "0x4000D3E")]
		[FieldOffset(Offset = "0x20")]
		private ClansService _clansService;

		// Token: 0x04000D3F RID: 3391
		[Token(Token = "0x4000D3F")]
		[FieldOffset(Offset = "0x24")]
		private Coroutine _energyRecoveryCoroutine;
	}
}
