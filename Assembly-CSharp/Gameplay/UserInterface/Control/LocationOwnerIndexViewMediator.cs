using System;
using Gameplay.UserInterface.Events;
using Gameplay.UserInterface.Model;
using Gameplay.UserInterface.View;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.UserInterface.Control
{
	// Token: 0x020003E9 RID: 1001
	[Token(Token = "0x20003E9")]
	public class LocationOwnerIndexViewMediator : AbstractViewMediator<UserInterfaceModel, UserInterfaceEvents, UserInterfaceController, LocationOwnerIndexView>
	{
		// Token: 0x06001755 RID: 5973 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001755")]
		[Address(RVA = "0x6912", Offset = "0x6912", VA = "0x6912")]
		public LocationOwnerIndexViewMediator(UserInterfaceModel model, UserInterfaceEvents events, UserInterfaceController controller)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_UserInterface_Control_LocationOwnerIndexViewMediator___ctor
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a598a0 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_UserInterfaceModel__UserInterfaceEvents__UserInterfaceController__LocationOwnerIndexView__set_Events__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_UserInterface_Control_LocationOwnerIndexViewMediator_LocationChangedEvent__
		              );
		    DAT_ram_00a598a0 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x14);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_UserInterface_Control_LocationOwnerIndexViewMediator_LocationChangedEvent__
		               ,0);
		    piVar4 = (int *)func_ii_7048(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x14) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x14) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  param1[3] = param2;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x14);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_UserInterface_Control_LocationOwnerIndexViewMediator_LocationChangedEvent__
		               ,0);
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x14) = 0;
		      return;
		    }
		    if ((System_Action_TypeInfo != *piVar4) || (*(int **)(iVar2 + 0x14) = piVar4, *piVar4 != iVar1))
		    {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x1700040D RID: 1037
		// (set) Token: 0x06001756 RID: 5974 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700040D")]
		public override UserInterfaceEvents Events
		{
			[Token(Token = "0x6001756")]
			[Address(RVA = "0x6913", Offset = "0x6913", VA = "0x6913", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x06001757 RID: 5975 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001757")]
		[Address(RVA = "0x6914", Offset = "0x6914", VA = "0x6914")]
		private void LocationChangedEvent()
		{
		/* --- GHIDRA: LocationChangedEvent ---
		void Gameplay_UserInterface_Control_LocationOwnerIndexViewMediator__LocationChangedEvent
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a598a2 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_UserInterfaceModel__UserInterfaceEvents__UserInterfaceController__LocationOwnerIndexView__set_View__
		              );
		    DAT_ram_00a598a2 = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    Gameplay_UserInterface_Control_LocationOwnerIndexViewMediator__set_View(param1,param1);
		  }
		  param1[5] = param2;
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    Gameplay_UserInterface_Control_LocationOwnerIndexViewMediator__ResetView(param1,param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x1700040E RID: 1038
		// (set) Token: 0x06001758 RID: 5976 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700040E")]
		public override LocationOwnerIndexView View
		{
			[Token(Token = "0x6001758")]
			[Address(RVA = "0x6915", Offset = "0x6915", VA = "0x6915", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06001759 RID: 5977 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001759")]
		[Address(RVA = "0x6916", Offset = "0x6916", VA = "0x6916")]
		private void ResetView()
		{
		/* --- GHIDRA: ResetView ---
		void Gameplay_UserInterface_Control_LocationOwnerIndexViewMediator__ResetView
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a598a4 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_UserInterface_Control_LocationOwnerIndexViewMediator_GiftButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_UserInterface_Control_LocationOwnerIndexViewMediator_HandleRatingBtnClickEvent__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a598a4 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x14) + 0xb4);
		  uVar2 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar2,param1,
		             Method_Gameplay_UserInterface_Control_LocationOwnerIndexViewMediator_GiftButtonClickedEventHandler__
		             ,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar3,uVar2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(*(int *)(iVar1 + 0x18) + 0xb4);
		  uVar2 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar2,param1,
		             Method_Gameplay_UserInterface_Control_LocationOwnerIndexViewMediator_HandleRatingBtnClickEvent__
		             ,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar3,uVar2,0);
		  Gameplay_UserInterface_Control_LocationOwnerIndexViewMediator__set_Events(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x0600175A RID: 5978 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600175A")]
		[Address(RVA = "0x6917", Offset = "0x6917", VA = "0x6917")]
		private void SetupView()
		{
		/* --- GHIDRA: SetupView ---
		void Gameplay_UserInterface_Control_LocationOwnerIndexViewMediator__SetupView
		               (undefined4 param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  int *piVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a598a5 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_UserIsleEvents__UserIsleModel__UserIsleController__UserBuildingTypes__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a598a5 = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  piVar3 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x1b0);
		        goto code_r0x81081710;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,0x1e);
		code_r0x81081710:
		  param1_00 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar3 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x110);
		        goto code_r0x810817bc;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,10);
		code_r0x810817bc:
		  iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  Core_Gameplay_Managers_GameActivityRouting_GameFeatureRouterManager__ShowAuchan
		            (param1_00,*(undefined4 *)(*(int *)(*(int *)(*(int *)(iVar4 + 0x14) + 0x24) + 0x10) + 8)
		             ,0);
		  return;
		}
		*/

		}

		// Token: 0x0600175B RID: 5979 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600175B")]
		[Address(RVA = "0x6918", Offset = "0x6918", VA = "0x6918")]
		private void GiftButtonClickedEventHandler()
		{
		/* --- GHIDRA: GiftButtonClickedEventHandler ---
		void Gameplay_UserInterface_Control_LocationOwnerIndexViewMediator__GiftButtonClickedEventHandler
		               (undefined4 param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  int *param1_01;
		  int iVar3;
		  
		  if (DAT_ram_00a598a6 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a598a6 = '\x01';
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
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x1b0);
		        goto code_r0x8108189e;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,0x1e);
		code_r0x8108189e:
		  param1_00 = (**(code **)((ulonglong)*puVar2 * 4))(param1_01,puVar2[1]);
		  Core_Gameplay_Managers_GameActivityRouting_GameFeatureRouterManager__ShowMyShopBuilding
		            (param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x0600175C RID: 5980 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600175C")]
		[Address(RVA = "0x6919", Offset = "0x6919", VA = "0x6919")]
		private void HandleRatingBtnClickEvent()
		{
		/* --- GHIDRA: HandleRatingBtnClickEvent ---
		void Gameplay_UserInterface_Control_LocationOwnerIndexViewMediator__HandleRatingBtnClickEvent
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5)
		
		{
		  if (DAT_ram_00a598a7 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_UserInterfaceModel__UserInterfaceEvents__UserInterfaceController__UserGotNewLevelWindow___ctor__
		              );
		    DAT_ram_00a598a7 = '\x01';
		  }
		  Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		            (param1,param2,param3,param4,
		             Method_MVC_AbstractViewMediator_UserInterfaceModel__UserInterfaceEvents__UserInterfaceController__UserGotNewLevelWindow___ctor__
		            );
		  return;
		}
		*/

		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_Events ---
		void Gameplay_UserInterface_Control_LocationOwnerIndexViewMediator__set_Events
		               (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  uint uVar5;
		  int *piVar6;
		  int iVar7;
		  
		  if (DAT_ram_00a598a1 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_UserIsleEvents__UserIsleModel__UserIsleController__UserBuildingTypes__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_UserInterfaceModel__UserInterfaceEvents__UserInterfaceController__LocationOwnerIndexView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Tutorial_Guide_Model_Data_IGuideTarget_TypeInfo);
		    DAT_ram_00a598a1 = '\x01';
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  if (iVar2 != 0) {
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    piVar6 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar2 = *piVar6;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x110);
		          goto code_r0x8108105a;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,10);
		code_r0x8108105a:
		    iVar2 = (**(code **)((ulonglong)*puVar3 * 4))(piVar6,puVar3[1]);
		    iVar2 = *(int *)(iVar2 + 0x14);
		    iVar7 = *(int *)(iVar2 + 0x1c);
		    if (iVar7 == 1) {
		      uVar1 = 0;
		      iVar7 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      uVar4 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(iVar7 + 0x10),0);
		      Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                (uVar4,1,0);
		      iVar7 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      uVar4 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(iVar7 + 0x14),0);
		      Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                (uVar4,0,0);
		      iVar7 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      uVar4 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(*(int *)(iVar7 + 0x10) + 0x14),0);
		      uVar5 = Gameplay_World_Model_WorldModel___ctor(iVar2,0);
		      Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                (uVar4,uVar5 ^ 1,0);
		      iVar7 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      Gameplay_UserInterface_View_UserView__get_UserData
		                (*(undefined4 *)(*(int *)(iVar7 + 0x10) + 0x10),
		                 *(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x24) + 0x10) + 8),0);
		      iVar7 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      piVar6 = (int *)Gameplay_UserInterface_View_UserView__StopListenEvents
		                                (*(undefined4 *)(*(int *)(iVar7 + 0x10) + 0x10),0);
		      iVar7 = *piVar6;
		      if (*(ushort *)(iVar7 + 0xb6) != 0) {
		        do {
		          if (Gameplay_Tutorial_Guide_Model_Data_IGuideTarget_TypeInfo ==
		              *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		            puVar3 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0xe0);
		            goto code_r0x810811c5;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		      }
		      puVar3 = (uint *)func_ii_1080(piVar6,Gameplay_Tutorial_Guide_Model_Data_IGuideTarget_TypeInfo,
		                                    4);
		code_r0x810811c5:
		      uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(piVar6,puVar3[1]);
		      UnityEngine_Object__op_Implicit
		                (uVar4,(uint)(*(int *)(*(int *)(*(int *)(iVar2 + 0x24) + 0x10) + 8) ==
		                             *(int *)(param1[2] + 8)),0);
		      iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      iVar7 = **(int **)(iVar2 + 0x14);
		      (**(code **)((ulonglong)*(uint *)(iVar7 + 0x138) * 4))
		                (*(int **)(iVar2 + 0x14),0,*(undefined4 *)(iVar7 + 0x13c));
		      return;
		    }
		    if (iVar7 == 2) {
		      iVar7 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      uVar4 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(iVar7 + 0x10),0);
		      Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                (uVar4,0,0);
		      iVar7 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      uVar4 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(iVar7 + 0x14),0);
		      Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                (uVar4,1,0);
		      uVar4 = *(undefined4 *)(iVar2 + 0x28);
		      iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      iVar7 = **(int **)(iVar2 + 0x14);
		      (**(code **)((ulonglong)*(uint *)(iVar7 + 0x138) * 4))
		                (*(int **)(iVar2 + 0x14),uVar4,*(undefined4 *)(iVar7 + 0x13c));
		      iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      Gameplay_UserInterface_View_UserView__get_UserData
		                (*(undefined4 *)(*(int *)(iVar2 + 0x10) + 0x10),0,0);
		      return;
		    }
		    if ((iVar7 != 3) && (iVar7 == 4)) {
		      uVar1 = 0;
		      iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      uVar4 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(iVar2 + 0x10),0);
		      Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                (uVar4,1,0);
		      iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      uVar4 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(iVar2 + 0x14),0);
		      Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                (uVar4,0,0);
		      iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      uVar4 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(*(int *)(iVar2 + 0x10) + 0x14),0);
		      Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                (uVar4,0,0);
		      iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      Gameplay_UserInterface_View_UserView__get_UserData
		                (*(undefined4 *)(*(int *)(iVar2 + 0x10) + 0x10),*(undefined4 *)(param1[2] + 8),0);
		      iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      piVar6 = (int *)Gameplay_UserInterface_View_UserView__StopListenEvents
		                                (*(undefined4 *)(*(int *)(iVar2 + 0x10) + 0x10),0);
		      iVar2 = *piVar6;
		      if (*(ushort *)(iVar2 + 0xb6) != 0) {
		        do {
		          if (Gameplay_Tutorial_Guide_Model_Data_IGuideTarget_TypeInfo ==
		              *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		            puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0xe0);
		            goto code_r0x81081400;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		      }
		      puVar3 = (uint *)func_ii_1080(piVar6,Gameplay_Tutorial_Guide_Model_Data_IGuideTarget_TypeInfo,
		                                    4);
		code_r0x81081400:
		      uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(piVar6,puVar3[1]);
		      UnityEngine_Object__op_Implicit(uVar4,0,0);
		      iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      iVar7 = **(int **)(iVar2 + 0x14);
		      (**(code **)((ulonglong)*(uint *)(iVar7 + 0x138) * 4))
		                (*(int **)(iVar2 + 0x14),0,*(undefined4 *)(iVar7 + 0x13c));
		    }
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_View ---
		void Gameplay_UserInterface_Control_LocationOwnerIndexViewMediator__set_View
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a598a3 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_UserInterface_Control_LocationOwnerIndexViewMediator_GiftButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_UserInterface_Control_LocationOwnerIndexViewMediator_HandleRatingBtnClickEvent__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a598a3 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x14) + 0xb4);
		  uVar2 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar2,param1,
		             Method_Gameplay_UserInterface_Control_LocationOwnerIndexViewMediator_GiftButtonClickedEventHandler__
		             ,0);
		  UnityEngine_Events_UnityAction___ctor(uVar3,uVar2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(*(int *)(iVar1 + 0x18) + 0xb4);
		  uVar2 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar2,param1,
		             Method_Gameplay_UserInterface_Control_LocationOwnerIndexViewMediator_HandleRatingBtnClickEvent__
		             ,0);
		  UnityEngine_Events_UnityAction___ctor(uVar3,uVar2,0);
		  return;
		}
		*/

}
