using System;
using Gameplay.Clans.Buildings.MagicTower.Events;
using Gameplay.Clans.Buildings.MagicTower.Model;
using Gameplay.School.Model;
using Google.Protobuf;
using Il2CppDummyDll;
using MVC;
using Protocol.MagicTower;
using ServicesNamespace;
using Utils;

namespace Gameplay.Clans.Buildings.MagicTower.Controller
{
	// Token: 0x02000AB9 RID: 2745
	[Token(Token = "0x2000AB9")]
	public class MagicTowerController : AbstractController<MagicTowerModel, Gameplay.Clans.Buildings.MagicTower.Events.MagicTowerEvents>
	{
		// Token: 0x06004237 RID: 16951 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004237")]
		[Address(RVA = "0x90EB", Offset = "0x90EB", VA = "0x90EB")]
		public MagicTowerController(MagicTowerModel model, Gameplay.Clans.Buildings.MagicTower.Events.MagicTowerEvents events)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Clans_Buildings_MagicTower_Controller_MagicTowerController___ctor
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 in_register_20000014;
		  int iVar1;
		  undefined4 param1_00;
		  undefined4 param1_01;
		  int param1_02;
		  
		  if (DAT_ram_00a57812 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Buildings_MagicTower_Controller_MagicTowerController_GetMagicTowerInfoResultHandler__
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    DAT_ram_00a57812 = '\x01';
		  }
		  param1_02 = param1[6];
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x104)));
		  if (DAT_ram_00a5780b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_ClanIsleEvents__ClanIsleModel__ClanIsleController__ClanBuildingTypes__get_Model__
		              );
		    DAT_ram_00a5780b = '\x01';
		  }
		  param1_00 = ServicesNamespace_MagicTowerService__ServerEventHandler
		                        (param1_02,
		                         *(undefined8 *)
		                          (*(int *)(*(int *)(*(int *)(*(int *)(iVar1 + 0x14) + 0x10) + 0x30) + 0x1c)
		                          + 0x10),0);
		  param1_01 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_01,param1,
		             Method_Gameplay_Clans_Buildings_MagicTower_Controller_MagicTowerController_GetMagicTowerInfoResultHandler__
		             ,0);
		  ServicesNamespace_MainService__GetUserStats
		            (param1_00,param1_01,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  return;
		}
		*/

		}

		// Token: 0x06004238 RID: 16952 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004238")]
		[Address(RVA = "0x90EC", Offset = "0x90EC", VA = "0x90EC")]
		public void GetMagicTowerInfo()
		{
		/* --- GHIDRA: GetMagicTowerInfo ---
		void Gameplay_Clans_Buildings_MagicTower_Controller_MagicTowerController__GetMagicTowerInfo
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  int *param1_01;
		  
		  if (DAT_ram_00a57813 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_School_ProtoGetSchoolInfoAns_TypeInfo);
		    DAT_ram_00a57813 = '\x01';
		  }
		  param1_01 = *(int **)(param2 + 0x20);
		  if ((param1_01 != (int *)0x0) && (Protocol_School_ProtoGetSchoolInfoAns_TypeInfo != *param1_01)) {
		    System_Activator__CreateInstance(param1_01,Protocol_School_ProtoGetSchoolInfoAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		  Gameplay_Clans_Buildings_MagicTower_Model_MagicTowerModel___ctor(param1_00,param1_01,param1);
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

		// Token: 0x06004239 RID: 16953 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004239")]
		[Address(RVA = "0x90ED", Offset = "0x90ED", VA = "0x90ED")]
		private void GetMagicTowerInfoResultHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: GetMagicTowerInfoResultHandler ---
		void Gameplay_Clans_Buildings_MagicTower_Controller_MagicTowerController__GetMagicTowerInfoResultHandler
		               (int *param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint uVar3;
		  uint *puVar4;
		  undefined4 uVar5;
		  int *param1_00;
		  undefined4 uVar6;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a57814 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_ClanIsleEvents__ClanIsleModel__ClanIsleController__ClanBuildingTypes__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__BaseBuildingData__TryGetValue__);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Buildings_MagicTower_Controller_MagicTowerController_StartLearnSpellResultHandler__
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__SetCustomData__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4274);
		    DAT_ram_00a57814 = '\x01';
		  }
		  local_4 = 0;
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  iVar2 = UnityEngine_TextCore_LowLevel_LigatureSubstitutionRecord__get_componentGlyphIDs
		                    (*(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x14) + 0x10) + 0x24),2,&local_4,
		                     Method_System_Collections_Generic_Dictionary_uint__BaseBuildingData__TryGetValue__
		                    );
		  if (iVar2 != 0) {
		    uVar1 = Newtonsoft_Json_Converters_XDeclarationWrapper__get_Encoding(local_4,0);
		    uVar3 = (**(code **)((ulonglong)*(uint *)(*param2 + 0xf0) * 4))
		                      (param2,*(undefined4 *)(*param2 + 0xf4));
		    if (uVar1 <= uVar3) {
		      uVar5 = System_Uri___ctor(0);
		      uVar5 = System_Globalization_TimeSpanFormat_FormatLiterals__get_DayHourSep(uVar5,0);
		      if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_GameLocalization_TypeInfo);
		      }
		      uVar6 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4274,1,0,1,0,0,0,0);
		      Core_Application_App__get_ToastController(uVar5,1,uVar6,0);
		      return;
		    }
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar2 = *param1_00;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x230);
		        goto code_r0x80de39f0;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x2e);
		code_r0x80de39f0:
		  iVar2 = (**(code **)((ulonglong)*puVar4 * 4))(param1_00,puVar4[1]);
		  uVar6 = *(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x18) + 8);
		  uVar5 = (**(code **)((ulonglong)*(uint *)(*param2 + 0x110) * 4))
		                    (param2,*(undefined4 *)(*param2 + 0x114));
		  iVar2 = Core_Errors_Expected_Clans_ExpectedClanBillingErrors__Handle(uVar6,uVar5,0);
		  if (iVar2 != 0) {
		    iVar2 = param1[6];
		    uVar5 = UnityEngine_AndroidJavaObject___GetRawObject(param2,0);
		    uVar5 = ServicesNamespace_MagicTowerService__GetMagicTowerInfo(iVar2,uVar5,0);
		    uVar6 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar6,param1,
		               Method_Gameplay_Clans_Buildings_MagicTower_Controller_MagicTowerController_StartLearnSpellResultHandler__
		               ,0);
		    uVar5 = ServicesNamespace_MainService__GetUserStats
		                      (uVar5,uVar6,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    DG_Tweening_TweenParams__SetId
		              (uVar5,param2,Method_Utils_OpToken_IMessage__object__SetCustomData__);
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600423A RID: 16954 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600423A")]
		[Address(RVA = "0x90EE", Offset = "0x90EE", VA = "0x90EE")]
		public void StartLearnSpell(SchoolSpellData spell)
		{
		/* --- GHIDRA: StartLearnSpell ---
		void Gameplay_Clans_Buildings_MagicTower_Controller_MagicTowerController__StartLearnSpell
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 param2_00;
		  undefined4 param5;
		  undefined4 param1_00;
		  int *piVar2;
		  undefined4 param3_00;
		  
		  if (DAT_ram_00a57815 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Events_Scopes_ClansScope_ClanSpellEventArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedMagicTowerErrors__ExpectedClanBillingErrors___
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_MagicTower_ProtoStartLearnSpellAns_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_School_Model_SchoolSpellData_TypeInfo);
		    DAT_ram_00a57815 = '\x01';
		  }
		  piVar2 = *(int **)(param2 + 0x20);
		  if ((piVar2 != (int *)0x0) && (Protocol_MagicTower_ProtoStartLearnSpellAns_TypeInfo != *piVar2)) {
		    System_Activator__CreateInstance(piVar2,Protocol_MagicTower_ProtoStartLearnSpellAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar1 = Core_Errors_Expected_ExpectedErrorsHandler__HandleErrorChain_object_
		                    (piVar2[3],0,0,
		                     Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedMagicTowerErrors__ExpectedClanBillingErrors___
		                    );
		  if (iVar1 == 0) {
		    piVar2 = *(int **)(param2 + 0xc);
		    if (piVar2 != (int *)0x0) {
		      if (((uint)*(byte *)(*piVar2 + 0xb8) <
		           (uint)*(byte *)(Gameplay_School_Model_SchoolSpellData_TypeInfo + 0xb8)) ||
		         (*(int *)(*(int *)(*piVar2 + 100) +
		                   (uint)*(byte *)(Gameplay_School_Model_SchoolSpellData_TypeInfo + 0xb8) * 4 + -4)
		          != Gameplay_School_Model_SchoolSpellData_TypeInfo)) {
		        System_Activator__CreateInstance(piVar2,Gameplay_School_Model_SchoolSpellData_TypeInfo);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    iVar1 = System_Uri___ctor(0);
		    iVar1 = *(int *)(*(int *)(*(int *)(*(int *)(iVar1 + 0x38) + 0x10) + 0x84) + 0x20);
		    if (iVar1 != 0) {
		      param2_00 = System_Uri___ctor(0);
		      if (DAT_ram_00a6456f == '\0') {
		        Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		        DAT_ram_00a6456f = '\x01';
		      }
		      param3_00 = **(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		      param5 = (**(code **)((ulonglong)*(uint *)(*piVar2 + 0x110) * 4))
		                         (piVar2,*(undefined4 *)(*piVar2 + 0x114));
		      param1_00 = unnamed_function_1417(Core_Events_Scopes_ClansScope_ClanSpellEventArgs_TypeInfo);
		      Core_Events_Scopes_UiScope_WindowClosedEventArgs__get_WindowCloseReason
		                (param1_00,param2_00,param3_00,piVar2,param5,0);
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),param1_00,*(undefined4 *)(iVar1 + 0x14));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600423B RID: 16955 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600423B")]
		[Address(RVA = "0x90EF", Offset = "0x90EF", VA = "0x90EF")]
		private void StartLearnSpellResultHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: StartLearnSpellResultHandler ---
		void Gameplay_Clans_Buildings_MagicTower_Controller_MagicTowerController__StartLearnSpellResultHandler
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a57816 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Buildings_MagicTower_Controller_MagicTowerController_CancelLearnSpellResultHandler__
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    DAT_ram_00a57816 = '\x01';
		  }
		  param1_00 = ServicesNamespace_MagicTowerService__StartLearnSpell
		                        (*(undefined4 *)(param1 + 0x18),param2,0);
		  param1_01 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_01,param1,
		             Method_Gameplay_Clans_Buildings_MagicTower_Controller_MagicTowerController_CancelLearnSpellResultHandler__
		             ,0);
		  ServicesNamespace_MainService__GetUserStats
		            (param1_00,param1_01,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  return;
		}
		*/

		}

		// Token: 0x0600423C RID: 16956 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600423C")]
		[Address(RVA = "0x90F0", Offset = "0x90F0", VA = "0x90F0")]
		public void CancelLearnSpell(uint spellId)
		{
		}

		// Token: 0x0600423D RID: 16957 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600423D")]
		[Address(RVA = "0x90F1", Offset = "0x90F1", VA = "0x90F1")]
		private void CancelLearnSpellResultHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: CancelLearnSpellResultHandler ---
		void Gameplay_Clans_Buildings_MagicTower_Controller_MagicTowerController__CancelLearnSpellResultHandler
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 param1_00;
		  int param1_01;
		  
		  if (DAT_ram_00a57817 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Buildings_MagicTower_Controller_MagicTowerController_AccelerateLearnSpellResultHandler__
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    DAT_ram_00a57817 = '\x01';
		  }
		  param1_01 = param1[6];
		  uVar1 = UnityEngine_AndroidJavaObject___GetRawObject(param2,0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  if (DAT_ram_00a5780b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_ClanIsleEvents__ClanIsleModel__ClanIsleController__ClanBuildingTypes__get_Model__
		              );
		    DAT_ram_00a5780b = '\x01';
		  }
		  uVar1 = ServicesNamespace_MagicTowerService__CancelLearnSpell
		                    (param1_01,uVar1,
		                     *(undefined8 *)
		                      (*(int *)(*(int *)(*(int *)(*(int *)(iVar2 + 0x14) + 0x10) + 0x30) + 0x1c) +
		                      0x10),0);
		  param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_Clans_Buildings_MagicTower_Controller_MagicTowerController_AccelerateLearnSpellResultHandler__
		             ,0);
		  ServicesNamespace_MainService__GetUserStats
		            (uVar1,param1_00,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  return;
		}
		*/

		}

		// Token: 0x0600423E RID: 16958 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600423E")]
		[Address(RVA = "0x90F2", Offset = "0x90F2", VA = "0x90F2")]
		public void AccelerateLearnSpell(SchoolSpellData spell)
		{
		/* --- GHIDRA: AccelerateLearnSpell ---
		void Gameplay_Clans_Buildings_MagicTower_Controller_MagicTowerController__AccelerateLearnSpell
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  int *param1_00;
		  
		  if (DAT_ram_00a57818 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedClanBillingErrors___
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_MagicTower_ProtoAccelerateLearnSpellAns_TypeInfo);
		    DAT_ram_00a57818 = '\x01';
		  }
		  param1_00 = *(int **)(param2 + 0x20);
		  if ((param1_00 != (int *)0x0) &&
		     (Protocol_MagicTower_ProtoAccelerateLearnSpellAns_TypeInfo != *param1_00)) {
		    System_Activator__CreateInstance
		              (param1_00,Protocol_MagicTower_ProtoAccelerateLearnSpellAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  UnityEngine_EventSystems_ExecuteEvents__ValidateEventData_object_
		            (param1_00[3],0,
		             Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedClanBillingErrors___
		            );
		  return;
		}
		*/

		}

		// Token: 0x0600423F RID: 16959 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600423F")]
		[Address(RVA = "0x90F3", Offset = "0x90F3", VA = "0x90F3")]
		private void AccelerateLearnSpellResultHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: AccelerateLearnSpellResultHandler ---
		void Gameplay_Clans_Buildings_MagicTower_Controller_MagicTowerController__AccelerateLearnSpellResultHandler
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  int *param1_00;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a57819 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Buildings_MagicTower_Controller_MagicTowerController_UseSpellResultHandler__
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__SetCustomData__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4270);
		    Mono_Security_ASN1__get_Item(&StringLiteral_8357);
		    DAT_ram_00a57819 = '\x01';
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  iVar2 = Core_Data_UserData__get_ClanId(*(undefined4 *)(iVar2 + 8),0);
		  if (iVar2 == 0) {
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar4 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_8357,1,0,1,0,0,0,0);
		    uVar5 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4270,1,0,1,0,0,0,0);
		    UI_Windows_DialogWindow__Show(uVar4,uVar5,0);
		    return;
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar2 = *param1_00;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x230);
		        goto code_r0x80de3ef7;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x2e);
		code_r0x80de3ef7:
		  iVar2 = (**(code **)((ulonglong)*puVar3 * 4))(param1_00,puVar3[1]);
		  uVar5 = *(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x18) + 8);
		  uVar4 = func_ii_10810(param2,0);
		  iVar2 = Core_Errors_Expected_Clans_ExpectedClanBillingErrors__Handle(uVar5,uVar4,0);
		  if (iVar2 != 0) {
		    iVar2 = param1[6];
		    uVar4 = UnityEngine_AndroidJavaObject___GetRawObject(param2,0);
		    uVar4 = ServicesNamespace_MagicTowerService__AccelerateLearnSpell(iVar2,uVar4,0);
		    uVar5 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar5,param1,
		               Method_Gameplay_Clans_Buildings_MagicTower_Controller_MagicTowerController_UseSpellResultHandler__
		               ,0);
		    uVar4 = ServicesNamespace_MainService__GetUserStats
		                      (uVar4,uVar5,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    DG_Tweening_TweenParams__SetId
		              (uVar4,param2,Method_Utils_OpToken_IMessage__object__SetCustomData__);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004240 RID: 16960 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004240")]
		[Address(RVA = "0x90F4", Offset = "0x90F4", VA = "0x90F4")]
		public void UseSpell(SchoolSpellData spell)
		{
		/* --- GHIDRA: UseSpell ---
		void Gameplay_Clans_Buildings_MagicTower_Controller_MagicTowerController__UseSpell
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 param2_00;
		  undefined4 param5;
		  undefined4 param1_00;
		  int *piVar2;
		  undefined4 param3_00;
		  
		  if (DAT_ram_00a5781a == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Events_Scopes_ClansScope_ClanSpellEventArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedClanBillingErrors___
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Common_ProtoDefaultAns_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_School_Model_SchoolSpellData_TypeInfo);
		    DAT_ram_00a5781a = '\x01';
		  }
		  piVar2 = *(int **)(param2 + 0x20);
		  if ((piVar2 != (int *)0x0) && (Protocol_Common_ProtoDefaultAns_TypeInfo != *piVar2)) {
		    System_Activator__CreateInstance(piVar2,Protocol_Common_ProtoDefaultAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar1 = UnityEngine_EventSystems_ExecuteEvents__ValidateEventData_object_
		                    (piVar2[3],0,
		                     Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedClanBillingErrors___
		                    );
		  if (iVar1 == 0) {
		    piVar2 = *(int **)(param2 + 0xc);
		    if (piVar2 != (int *)0x0) {
		      if (((uint)*(byte *)(*piVar2 + 0xb8) <
		           (uint)*(byte *)(Gameplay_School_Model_SchoolSpellData_TypeInfo + 0xb8)) ||
		         (*(int *)(*(int *)(*piVar2 + 100) +
		                   (uint)*(byte *)(Gameplay_School_Model_SchoolSpellData_TypeInfo + 0xb8) * 4 + -4)
		          != Gameplay_School_Model_SchoolSpellData_TypeInfo)) {
		        System_Activator__CreateInstance(piVar2,Gameplay_School_Model_SchoolSpellData_TypeInfo);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    iVar1 = System_Uri___ctor(0);
		    iVar1 = *(int *)(*(int *)(*(int *)(*(int *)(iVar1 + 0x38) + 0x10) + 0x84) + 0x24);
		    if (iVar1 != 0) {
		      param2_00 = System_Uri___ctor(0);
		      if (DAT_ram_00a6456f == '\0') {
		        Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		        DAT_ram_00a6456f = '\x01';
		      }
		      param3_00 = **(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		      param5 = func_ii_10810(piVar2,0);
		      param1_00 = unnamed_function_1417(Core_Events_Scopes_ClansScope_ClanSpellEventArgs_TypeInfo);
		      Core_Events_Scopes_UiScope_WindowClosedEventArgs__get_WindowCloseReason
		                (param1_00,param2_00,param3_00,piVar2,param5,0);
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),param1_00,*(undefined4 *)(iVar1 + 0x14));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004241 RID: 16961 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004241")]
		[Address(RVA = "0x90F5", Offset = "0x90F5", VA = "0x90F5")]
		private void UseSpellResultHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: UseSpellResultHandler ---
		void Gameplay_Clans_Buildings_MagicTower_Controller_MagicTowerController__UseSpellResultHandler
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5781b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__ClanSchoolSpellData__get_Item__);
		    DAT_ram_00a5781b = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  param1_00 = System_Collections_Generic_List_object___get_Item
		                        (*(undefined4 *)(iVar1 + 0x1c),*(undefined4 *)(param2 + 0xc),
		                         Method_System_Collections_Generic_Dictionary_uint__ClanSchoolSpellData__get_Item__
		                        );
		  Gameplay_School_Model_SchoolSpellData__get_ActionBacktime(param1_00,0,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(iVar1 + 0x1c);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(param2 + 0xc),
		               *(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004242 RID: 16962 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004242")]
		[Address(RVA = "0x90F6", Offset = "0x90F6", VA = "0x90F6")]
		private void SpellActionExpiredEventHandler(ProtoSpellActionExpiredEvt evt)
		{
		/* --- GHIDRA: SpellActionExpiredEventHandler ---
		void Gameplay_Clans_Buildings_MagicTower_Controller_MagicTowerController__SpellActionExpiredEventHandler
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5781c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__ClanSchoolSpellData__get_Item__);
		    DAT_ram_00a5781c = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  param1_00 = System_Collections_Generic_List_object___get_Item
		                        (*(undefined4 *)(iVar1 + 0x1c),*(undefined4 *)(param2 + 0xc),
		                         Method_System_Collections_Generic_Dictionary_uint__ClanSchoolSpellData__get_Item__
		                        );
		  Gameplay_School_Model_SchoolSpellData__get_ActionBacktime
		            (param1_00,*(undefined4 *)(param2 + 0x10),0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(iVar1 + 0x1c);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(param2 + 0xc),
		               *(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004243 RID: 16963 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004243")]
		[Address(RVA = "0x90F7", Offset = "0x90F7", VA = "0x90F7")]
		private void SpellUsedEventHandler(ProtoSpellUsedEvt evt)
		{
		/* --- GHIDRA: SpellUsedEventHandler ---
		void Gameplay_Clans_Buildings_MagicTower_Controller_MagicTowerController__SpellUsedEventHandler
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5781d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__ClanSchoolSpellData__get_Item__);
		    DAT_ram_00a5781d = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  param1_00 = System_Collections_Generic_List_object___get_Item
		                        (*(undefined4 *)(iVar1 + 0x1c),*(undefined4 *)(param2 + 0xc),
		                         Method_System_Collections_Generic_Dictionary_uint__ClanSchoolSpellData__get_Item__
		                        );
		  Gameplay_School_Model_SchoolSpellData__get_IconAssetId(param1_00,*(undefined4 *)(param2 + 0x10),0)
		  ;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(iVar1 + 0x1c);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(param2 + 0xc),
		               *(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004244 RID: 16964 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004244")]
		[Address(RVA = "0x90F8", Offset = "0x90F8", VA = "0x90F8")]
		private void LearnSpellStartedEventHandler(ProtoLearnSpellStartedEvt evt)
		{
		/* --- GHIDRA: LearnSpellStartedEventHandler ---
		void Gameplay_Clans_Buildings_MagicTower_Controller_MagicTowerController__LearnSpellStartedEventHandler
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5781e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__ClanSchoolSpellData__get_Item__);
		    DAT_ram_00a5781e = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  param1_00 = System_Collections_Generic_List_object___get_Item
		                        (*(undefined4 *)(iVar1 + 0x1c),*(undefined4 *)(param2 + 0xc),
		                         Method_System_Collections_Generic_Dictionary_uint__ClanSchoolSpellData__get_Item__
		                        );
		  Gameplay_School_Model_SchoolSpellData__get_IconAssetId(param1_00,0,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(iVar1 + 0x1c);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(param2 + 0xc),
		               *(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004245 RID: 16965 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004245")]
		[Address(RVA = "0x90F9", Offset = "0x90F9", VA = "0x90F9")]
		private void LearnSpellCanceledEventHandler(ProtoLearnSpellCanceledEvt evt)
		{
		/* --- GHIDRA: LearnSpellCanceledEventHandler ---
		void Gameplay_Clans_Buildings_MagicTower_Controller_MagicTowerController__LearnSpellCanceledEventHandler
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 in_register_20000014;
		  undefined8 uVar1;
		  int param2_00;
		  int iVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  int param1_00;
		  
		  if (DAT_ram_00a5781f == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__ClanSchoolSpellData__get_Item__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Buildings_MagicTower_Controller_MagicTowerController___c__DisplayClass16_0__LearnSpellFinishedEventHandler_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Clans_Buildings_MagicTower_Controller_MagicTowerController___c__DisplayClass16_0_TypeInfo
		              );
		    DAT_ram_00a5781f = '\x01';
		  }
		  param2_00 = unnamed_function_1417
		                        (
		                        Gameplay_Clans_Buildings_MagicTower_Controller_MagicTowerController___c__DisplayClass16_0_TypeInfo
		                        );
		  *(undefined4 *)(param2_00 + 0xc) = param2;
		  *(int **)(param2_00 + 8) = param1;
		  uVar1 = CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x104));
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(param1,uVar1);
		  uVar4 = (undefined4)((ulonglong)uVar1 >> 0x20);
		  uVar3 = System_Collections_Generic_List_object___get_Item
		                    (*(undefined4 *)(iVar2 + 0x1c),*(undefined4 *)(*(int *)(param2_00 + 0xc) + 0xc),
		                     Method_System_Collections_Generic_Dictionary_uint__ClanSchoolSpellData__get_Item__
		                    );
		  Gameplay_School_Model_SchoolSpellData__get_IconAssetId(uVar3,0,0);
		  uVar1 = CONCAT44(uVar4,*(undefined4 *)(*param1 + 0x104));
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(param1,uVar1);
		  uVar4 = (undefined4)((ulonglong)uVar1 >> 0x20);
		  iVar2 = System_Collections_Generic_List_object___get_Item
		                    (*(undefined4 *)(iVar2 + 0x1c),*(undefined4 *)(*(int *)(param2_00 + 0xc) + 0xc),
		                     Method_System_Collections_Generic_Dictionary_uint__ClanSchoolSpellData__get_Item__
		                    );
		  *(int *)(*(int *)(iVar2 + 0x34) + 0x10) = *(int *)(*(int *)(iVar2 + 0x34) + 0x10) + 1;
		  param1_00 = param1[6];
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,CONCAT44(uVar4,*(undefined4 *)(*param1 + 0x104)));
		  if (DAT_ram_00a5780b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_ClanIsleEvents__ClanIsleModel__ClanIsleController__ClanBuildingTypes__get_Model__
		              );
		    DAT_ram_00a5780b = '\x01';
		  }
		  uVar4 = ServicesNamespace_MagicTowerService__ServerEventHandler
		                    (param1_00,
		                     *(undefined8 *)
		                      (*(int *)(*(int *)(*(int *)(*(int *)(iVar2 + 0x14) + 0x10) + 0x30) + 0x1c) +
		                      0x10),0);
		  uVar3 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar3,param2_00,
		             Method_Gameplay_Clans_Buildings_MagicTower_Controller_MagicTowerController___c__DisplayClass16_0__LearnSpellFinishedEventHandler_b__0__
		             ,0);
		  ServicesNamespace_MainService__GetUserStats
		            (uVar4,uVar3,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  return;
		}
		*/

		}

		// Token: 0x06004246 RID: 16966 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004246")]
		[Address(RVA = "0x90FA", Offset = "0x90FA", VA = "0x90FA")]
		private void LearnSpellFinishedEventHandler(ProtoLearnSpellFinishedEvt evt)
		{
		/* --- GHIDRA: LearnSpellFinishedEventHandler ---
		void Gameplay_Clans_Buildings_MagicTower_Controller_MagicTowerController__LearnSpellFinishedEventHandler
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a57820 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__ClanSchoolSpellData__get_Item__);
		    DAT_ram_00a57820 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  param1_00 = System_Collections_Generic_List_object___get_Item
		                        (*(undefined4 *)(iVar1 + 0x1c),*(undefined4 *)(param2 + 0xc),
		                         Method_System_Collections_Generic_Dictionary_uint__ClanSchoolSpellData__get_Item__
		                        );
		  Gameplay_School_Model_SchoolSpellData__get_IconAssetId(param1_00,*(undefined4 *)(param2 + 0x10),0)
		  ;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(iVar1 + 0x1c);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(param2 + 0xc),
		               *(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004247 RID: 16967 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004247")]
		[Address(RVA = "0x90FB", Offset = "0x90FB", VA = "0x90FB")]
		private void LearnSpellAcceleratedEventHandler(ProtoLearnSpellAcceleratedEvt evt)
		{
		/* --- GHIDRA: LearnSpellAcceleratedEventHandler ---
		void Gameplay_Clans_Buildings_MagicTower_Controller_MagicTowerController__LearnSpellAcceleratedEventHandler
		               (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a57821 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoSpellUsedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoLearnSpellCanceledEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoLearnSpellAcceleratedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoSpellActionExpiredEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoLearnSpellFinishedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoLearnSpellStartedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Buildings_MagicTower_Controller_MagicTowerController_LearnSpellAcceleratedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Buildings_MagicTower_Controller_MagicTowerController_LearnSpellCanceledEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Buildings_MagicTower_Controller_MagicTowerController_LearnSpellFinishedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Buildings_MagicTower_Controller_MagicTowerController_LearnSpellStartedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Buildings_MagicTower_Controller_MagicTowerController_SpellActionExpiredEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Buildings_MagicTower_Controller_MagicTowerController_SpellUsedEventHandler__
		              );
		    DAT_ram_00a57821 = '\x01';
		  }
		  uVar2 = *(undefined4 *)(param1 + 0x18);
		  uVar1 = unnamed_function_1417(System_Action_ProtoLearnSpellAcceleratedEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_Clans_Buildings_MagicTower_Controller_MagicTowerController_LearnSpellAcceleratedEventHandler__
		             ,0);
		  ServicesNamespace_MagicTowerService__get_ServiceId(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param1 + 0x18);
		  uVar1 = unnamed_function_1417(System_Action_ProtoLearnSpellFinishedEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_Clans_Buildings_MagicTower_Controller_MagicTowerController_LearnSpellFinishedEventHandler__
		             ,0);
		  ServicesNamespace_MagicTowerService__remove_LearnSpellAcceleratedEvent(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param1 + 0x18);
		  uVar1 = unnamed_function_1417(System_Action_ProtoLearnSpellCanceledEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_Clans_Buildings_MagicTower_Controller_MagicTowerController_LearnSpellCanceledEventHandler__
		             ,0);
		  ServicesNamespace_MagicTowerService__remove_LearnSpellFinishedEvent(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param1 + 0x18);
		  uVar1 = unnamed_function_1417(System_Action_ProtoLearnSpellStartedEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_Clans_Buildings_MagicTower_Controller_MagicTowerController_LearnSpellStartedEventHandler__
		             ,0);
		  ServicesNamespace_MagicTowerService__remove_LearnSpellCanceledEvent(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param1 + 0x18);
		  uVar1 = unnamed_function_1417(System_Action_ProtoSpellUsedEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_Clans_Buildings_MagicTower_Controller_MagicTowerController_SpellUsedEventHandler__
		             ,0);
		  ServicesNamespace_MagicTowerService__remove_LearnSpellStartedEvent(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param1 + 0x18);
		  uVar1 = unnamed_function_1417(System_Action_ProtoSpellActionExpiredEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_Clans_Buildings_MagicTower_Controller_MagicTowerController_SpellActionExpiredEventHandler__
		             ,0);
		  ServicesNamespace_MagicTowerService__remove_SpellUsedEvent(uVar2,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x06004248 RID: 16968 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004248")]
		[Address(RVA = "0x90FC", Offset = "0x90FC", VA = "0x90FC", Slot = "7")]
		protected override void HandleRun()
		{
		/* --- GHIDRA: HandleRun ---
		void Gameplay_Clans_Buildings_MagicTower_Controller_MagicTowerController__HandleRun
		               (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a57822 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoSpellUsedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoLearnSpellCanceledEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoLearnSpellAcceleratedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoSpellActionExpiredEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoLearnSpellFinishedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoLearnSpellStartedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Buildings_MagicTower_Controller_MagicTowerController_LearnSpellAcceleratedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Buildings_MagicTower_Controller_MagicTowerController_LearnSpellCanceledEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Buildings_MagicTower_Controller_MagicTowerController_LearnSpellFinishedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Buildings_MagicTower_Controller_MagicTowerController_LearnSpellStartedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Buildings_MagicTower_Controller_MagicTowerController_SpellActionExpiredEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Buildings_MagicTower_Controller_MagicTowerController_SpellUsedEventHandler__
		              );
		    DAT_ram_00a57822 = '\x01';
		  }
		  uVar2 = *(undefined4 *)(param1 + 0x18);
		  uVar1 = unnamed_function_1417(System_Action_ProtoLearnSpellAcceleratedEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_Clans_Buildings_MagicTower_Controller_MagicTowerController_LearnSpellAcceleratedEventHandler__
		             ,0);
		  ServicesNamespace_MagicTowerService__add_LearnSpellAcceleratedEvent(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param1 + 0x18);
		  uVar1 = unnamed_function_1417(System_Action_ProtoLearnSpellFinishedEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_Clans_Buildings_MagicTower_Controller_MagicTowerController_LearnSpellFinishedEventHandler__
		             ,0);
		  ServicesNamespace_MagicTowerService__add_LearnSpellFinishedEvent(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param1 + 0x18);
		  uVar1 = unnamed_function_1417(System_Action_ProtoLearnSpellCanceledEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_Clans_Buildings_MagicTower_Controller_MagicTowerController_LearnSpellCanceledEventHandler__
		             ,0);
		  ServicesNamespace_MagicTowerService__add_LearnSpellCanceledEvent(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param1 + 0x18);
		  uVar1 = unnamed_function_1417(System_Action_ProtoLearnSpellStartedEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_Clans_Buildings_MagicTower_Controller_MagicTowerController_LearnSpellStartedEventHandler__
		             ,0);
		  ServicesNamespace_MagicTowerService__add_LearnSpellStartedEvent(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param1 + 0x18);
		  uVar1 = unnamed_function_1417(System_Action_ProtoSpellUsedEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_Clans_Buildings_MagicTower_Controller_MagicTowerController_SpellUsedEventHandler__
		             ,0);
		  ServicesNamespace_MagicTowerService__add_SpellUsedEvent(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param1 + 0x18);
		  uVar1 = unnamed_function_1417(System_Action_ProtoSpellActionExpiredEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_Gameplay_Clans_Buildings_MagicTower_Controller_MagicTowerController_SpellActionExpiredEventHandler__
		             ,0);
		  ServicesNamespace_MagicTowerService__add_SpellActionExpiredEvent(uVar2,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x06004249 RID: 16969 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004249")]
		[Address(RVA = "0x90FD", Offset = "0x90FD", VA = "0x90FD", Slot = "6")]
		protected override void HandleStop()
		{
		/* --- GHIDRA: HandleStop ---
		void Gameplay_Clans_Buildings_MagicTower_Controller_MagicTowerController__HandleStop
		               (int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a57823 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_MVC_AbstractController_MagicTowerModel__MagicTowerEvents__Dispose__);
		    DAT_ram_00a57823 = '\x01';
		  }
		  MVC_AbstractController_object__object____ctor
		            (param1,Method_MVC_AbstractController_MagicTowerModel__MagicTowerEvents__Dispose__);
		  *(undefined4 *)(param1 + 0x18) = 0;
		  return;
		}
		*/

		}

		// Token: 0x0600424A RID: 16970 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600424A")]
		[Address(RVA = "0x90FE", Offset = "0x90FE", VA = "0x90FE", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x04002490 RID: 9360
		[Token(Token = "0x4002490")]
		[FieldOffset(Offset = "0x18")]
		private MagicTowerService _service;
	}
}
