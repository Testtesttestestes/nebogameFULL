using System;
using Core.Data;
using Gameplay.Chat;
using Gameplay.Chat.Model;
using Gameplay.Chat.Model.Data;
using Gameplay.Duel.View;
using Gameplay.World.Model;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Duel.Controller
{
	// Token: 0x02000867 RID: 2151
	[Token(Token = "0x2000867")]
	public class DuelEnterPointViewMediator : AbstractViewMediator<ChatModel, ChatEvents, DuelController, DuelButtonOnMainScreen>
	{
		// Token: 0x06003294 RID: 12948 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003294")]
		[Address(RVA = "0x82E9", Offset = "0x82E9", VA = "0x82E9")]
		public DuelEnterPointViewMediator(ChatModel model, ChatEvents events, DuelController controller, WorldModel worldModel)
		{
		/* --- GHIDRA: .ctor ---
		undefined4 Gameplay_Duel_Controller_DuelEnterPointViewMediator___ctor(int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a57bff == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_UserIsleEvents__UserIsleModel__UserIsleController__UserBuildingTypes__get_Model__
		              );
		    DAT_ram_00a57bff = '\x01';
		  }
		  return *(undefined4 *)(*(int *)(*(int *)(*(int *)(param1 + 0x18) + 0x24) + 0x10) + 8);
		}
		*/

		}

		// Token: 0x170009F6 RID: 2550
		// (get) Token: 0x06003295 RID: 12949 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170009F6")]
		private UserData CurrentUser
		{
			[Token(Token = "0x6003295")]
			[Address(RVA = "0x82EA", Offset = "0x82EA", VA = "0x82EA")]
			get
			{
				return null;
			}
		}

		// Token: 0x170009F7 RID: 2551
		// (set) Token: 0x06003296 RID: 12950 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009F7")]
		public override DuelButtonOnMainScreen View
		{
			[Token(Token = "0x6003296")]
			[Address(RVA = "0x82EB", Offset = "0x82EB", VA = "0x82EB", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x170009F8 RID: 2552
		// (set) Token: 0x06003297 RID: 12951 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009F8")]
		public override ChatEvents Events
		{
			[Token(Token = "0x6003297")]
			[Address(RVA = "0x82EC", Offset = "0x82EC", VA = "0x82EC", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x06003298 RID: 12952 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003298")]
		[Address(RVA = "0x82ED", Offset = "0x82ED", VA = "0x82ED")]
		private void CurrentRoomChangedEventHandler()
		{
		/* --- GHIDRA: CurrentRoomChangedEventHandler ---
		void Gameplay_Duel_Controller_DuelEnterPointViewMediator__CurrentRoomChangedEventHandler
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 in_register_20000014;
		  undefined4 param2_00;
		  undefined4 uVar1;
		  undefined8 param2_01;
		  int iVar2;
		  int param1_00;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a57c02 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_UserIsleEvents__UserIsleModel__UserIsleController__UserBuildingTypes__get_IsDisposed__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ChatModel__ChatEvents__DuelController__DuelButtonOnMainScreen__get_Model__
		              );
		    DAT_ram_00a57c02 = '\x01';
		  }
		  local_4 = 0;
		  iVar2 = *(int *)(param1[6] + 0x24);
		  if ((iVar2 != 0) && (*(char *)(iVar2 + 8) == '\0')) {
		    param1_00 = param1[2];
		    if (DAT_ram_00a57bff == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&
		                 Method_Gameplay_Isles_Base_AbstractIsle_UserIsleEvents__UserIsleModel__UserIsleController__UserBuildingTypes__get_Model__
		                );
		      DAT_ram_00a57bff = '\x01';
		      iVar2 = *(int *)(param1[6] + 0x24);
		    }
		    param2_01 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext
		                          (*(undefined4 *)(*(int *)(iVar2 + 0x10) + 8),0);
		    iVar2 = Gameplay_Chat_Model_ChatModel__TryGetFavorite(param1_00,param2_01,&local_4,0);
		    in_register_20000014 = (undefined4)((ulonglong)param2_01 >> 0x20);
		    if (iVar2 != 0) {
		      iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x15c)));
		      uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(iVar2 + 0x10),0);
		      param2_00 = Gameplay_Chat_Model_Data_ChatVisitorData__get_IsBanned(local_4,0);
		      Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                (uVar1,param2_00,0);
		      return;
		    }
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x15c)));
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(iVar2 + 0x10),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,0,0);
		  return;
		}
		*/

		}

		// Token: 0x06003299 RID: 12953 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003299")]
		[Address(RVA = "0x82EE", Offset = "0x82EE", VA = "0x82EE")]
		private void ValidateDuelButton()
		{
		/* --- GHIDRA: ValidateDuelButton ---
		void Gameplay_Duel_Controller_DuelEnterPointViewMediator__ValidateDuelButton
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 param2_00;
		  longlong lVar2;
		  longlong lVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a57c03 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_UserIsleEvents__UserIsleModel__UserIsleController__UserBuildingTypes__get_IsDisposed__
		              );
		    DAT_ram_00a57c03 = '\x01';
		  }
		  iVar4 = *(int *)(param1[6] + 0x24);
		  if ((iVar4 != 0) && (*(char *)(iVar4 + 8) == '\0')) {
		    if (DAT_ram_00a57bff == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&
		                 Method_Gameplay_Isles_Base_AbstractIsle_UserIsleEvents__UserIsleModel__UserIsleController__UserBuildingTypes__get_Model__
		                );
		      DAT_ram_00a57bff = '\x01';
		      iVar4 = *(int *)(param1[6] + 0x24);
		    }
		    lVar2 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext
		                      (*(undefined4 *)(*(int *)(iVar4 + 0x10) + 8),0);
		    lVar3 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext
		                      (*(undefined4 *)(param2 + 0x18),0);
		    if (lVar2 == lVar3) {
		      iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(iVar4 + 0x10),0);
		      param2_00 = Gameplay_Chat_Model_Data_ChatVisitorData__get_IsBanned(param2,0);
		      Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                (uVar1,param2_00,0);
		    }
		    return;
		  }
		  iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(iVar4 + 0x10),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,0,0);
		  return;
		}
		*/

		}

		// Token: 0x0600329A RID: 12954 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600329A")]
		[Address(RVA = "0x82EF", Offset = "0x82EF", VA = "0x82EF")]
		private void UserUpdateEventHandler(ChatVisitorData visitor)
		{
		/* --- GHIDRA: UserUpdateEventHandler ---
		void Gameplay_Duel_Controller_DuelEnterPointViewMediator__UserUpdateEventHandler
		               (int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  int *param1_01;
		  int iVar3;
		  
		  if (DAT_ram_00a57c04 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a57c04 = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  param1_01 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar3 = *param1_01;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x228);
		        goto code_r0x80e35b19;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,0x2d);
		code_r0x80e35b19:
		  param1_00 = (**(code **)((ulonglong)*puVar2 * 4))(param1_01,puVar2[1]);
		  if (DAT_ram_00a57bff == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_UserIsleEvents__UserIsleModel__UserIsleController__UserBuildingTypes__get_Model__
		              );
		    DAT_ram_00a57bff = '\x01';
		  }
		  Core_Gameplay_Managers_DuelManager__Init
		            (param1_00,
		             *(undefined4 *)(*(int *)(*(int *)(*(int *)(param1 + 0x18) + 0x24) + 0x10) + 8),0);
		  return;
		}
		*/

		}

		// Token: 0x0600329B RID: 12955 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600329B")]
		[Address(RVA = "0x82F0", Offset = "0x82F0", VA = "0x82F0")]
		private void DuelButtonClickedEventHandler()
		{
		/* --- GHIDRA: DuelButtonClickedEventHandler ---
		void Gameplay_Duel_Controller_DuelEnterPointViewMediator__DuelButtonClickedEventHandler
		               (int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a57c05 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ChatModel__ChatEvents__DuelController__DuelButtonOnMainScreen__Dispose__
		              );
		    DAT_ram_00a57c05 = '\x01';
		  }
		  MVC_AbstractViewMediator_object__object__object__object___Core_MVC_Interfaces_IViewMediator_set_View
		            (param1,
		             Method_MVC_AbstractViewMediator_ChatModel__ChatEvents__DuelController__DuelButtonOnMainScreen__Dispose__
		            );
		  *(undefined4 *)(param1 + 0x18) = 0;
		  return;
		}
		*/

		}

		// Token: 0x0600329C RID: 12956 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600329C")]
		[Address(RVA = "0x82F1", Offset = "0x82F1", VA = "0x82F1", Slot = "14")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Gameplay_Duel_Controller_DuelEnterPointViewMediator__Dispose
		               (int *param1,int param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  undefined4 in_register_20000014;
		  undefined4 param1_00;
		  undefined8 param2_00;
		  
		  if (DAT_ram_00a57c06 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_DuelModel__DuelEvents__DuelController__DuelWindow___ctor__
		              );
		    DAT_ram_00a57c06 = '\x01';
		  }
		  Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		            (param1,param2,param3,param4,
		             Method_MVC_AbstractViewMediator_DuelModel__DuelEvents__DuelController__DuelWindow___ctor__
		            );
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                        (param1,CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x14c)));
		  param2_00 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext
		                        (*(undefined4 *)(*(int *)(param2 + 0x14) + 8),0);
		  Gameplay_Duel_Controller_DuelController__PerformIntelligenceResultHandler
		            (param1_00,param2_00,param1);
		  return;
		}
		*/

		}

		// Token: 0x04001BAD RID: 7085
		[Token(Token = "0x4001BAD")]
		[FieldOffset(Offset = "0x18")]
		private WorldModel _worldModel;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_CurrentUser ---
		void Gameplay_Duel_Controller_DuelEnterPointViewMediator__get_CurrentUser
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a57c00 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ChatModel__ChatEvents__DuelController__DuelButtonOnMainScreen__set_View__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Duel_Controller_DuelEnterPointViewMediator_DuelButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a57c00 = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x10) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_Duel_Controller_DuelEnterPointViewMediator_DuelButtonClickedEventHandler__
		               ,0);
		    UnityEngine_Events_UnityAction___ctor(uVar3,uVar1,0);
		  }
		  param1[5] = param2;
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x10) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_Duel_Controller_DuelEnterPointViewMediator_DuelButtonClickedEventHandler__
		               ,0);
		    Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar3,uVar1,0);
		    Gameplay_Duel_Controller_DuelEnterPointViewMediator__CurrentRoomChangedEventHandler
		              (param1,param1);
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_View ---
		void Gameplay_Duel_Controller_DuelEnterPointViewMediator__set_View
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  int *piVar5;
		  undefined4 uVar6;
		  
		  if (DAT_ram_00a57c01 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ChatModel__ChatEvents__DuelController__DuelButtonOnMainScreen__set_Events__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_ChatVisitorData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Duel_Controller_DuelEnterPointViewMediator_CurrentRoomChangedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Duel_Controller_DuelEnterPointViewMediator_UserUpdateEventHandler__)
		    ;
		    DAT_ram_00a57c01 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar1 + 0x14);
		    uVar2 = unnamed_function_1417(System_Action_ChatVisitorData__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar2,param1,
		               Method_Gameplay_Duel_Controller_DuelEnterPointViewMediator_UserUpdateEventHandler__,0
		              );
		    iVar3 = func_ii_7048(uVar6,uVar2,0);
		    uVar2 = System_Action_ChatVisitorData__TypeInfo;
		    if (iVar3 == 0) {
		      *(undefined4 *)(iVar1 + 0x14) = 0;
		    }
		    else {
		      iVar4 = func_ii_1082(iVar3,System_Action_ChatVisitorData__TypeInfo);
		      if (iVar4 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(iVar1 + 0x14) = iVar4;
		      uVar2 = System_Action_ChatVisitorData__TypeInfo;
		      iVar1 = func_ii_1082(iVar3,System_Action_ChatVisitorData__TypeInfo);
		      if (iVar1 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar3 + 0x40);
		    uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar2,param1,
		               Method_Gameplay_Duel_Controller_DuelEnterPointViewMediator_CurrentRoomChangedEventHandler__
		               ,0);
		    piVar5 = (int *)func_ii_7048(uVar6,uVar2,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar5 == (int *)0x0) {
		      *(undefined4 *)(iVar3 + 0x40) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar5) ||
		            (*(int **)(iVar3 + 0x40) = piVar5, *piVar5 != iVar1)) {
		      System_Activator__CreateInstance(piVar5,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  param1[3] = param2;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar1 + 0x14);
		    uVar2 = unnamed_function_1417(System_Action_ChatVisitorData__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar2,param1,
		               Method_Gameplay_Duel_Controller_DuelEnterPointViewMediator_UserUpdateEventHandler__,0
		              );
		    iVar3 = UnityEngine_UI_Image__set_sprite(uVar6,uVar2,0);
		    uVar2 = System_Action_ChatVisitorData__TypeInfo;
		    if (iVar3 == 0) {
		      *(undefined4 *)(iVar1 + 0x14) = 0;
		    }
		    else {
		      iVar4 = func_ii_1082(iVar3,System_Action_ChatVisitorData__TypeInfo);
		      if (iVar4 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(iVar1 + 0x14) = iVar4;
		      uVar2 = System_Action_ChatVisitorData__TypeInfo;
		      iVar1 = func_ii_1082(iVar3,System_Action_ChatVisitorData__TypeInfo);
		      if (iVar1 == 0) {
		        System_Activator__CreateInstance(iVar3,uVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar3 + 0x40);
		    uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar2,param1,
		               Method_Gameplay_Duel_Controller_DuelEnterPointViewMediator_CurrentRoomChangedEventHandler__
		               ,0);
		    piVar5 = (int *)UnityEngine_UI_Image__set_sprite(uVar6,uVar2,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar5 == (int *)0x0) {
		      *(undefined4 *)(iVar3 + 0x40) = 0;
		      return;
		    }
		    if ((System_Action_TypeInfo != *piVar5) || (*(int **)(iVar3 + 0x40) = piVar5, *piVar5 != iVar1))
		    {
		      System_Activator__CreateInstance(piVar5,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_Events ---
		void Gameplay_Duel_Controller_DuelEnterPointViewMediator__set_Events
		               (undefined4 param1,undefined4 param2)
		
		{
		  Gameplay_Duel_Controller_DuelEnterPointViewMediator__CurrentRoomChangedEventHandler(param1,param1)
		  ;
		  return;
		}
		*/

}
