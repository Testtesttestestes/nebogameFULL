using System;
using Core.Data;
using Gameplay.Isles.User.Events;
using Gameplay.Isles.User.Model;
using Gameplay.Isles.User.View;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Isles.User.Controller
{
	// Token: 0x02000D2F RID: 3375
	[Token(Token = "0x2000D2F")]
	public class ColossusOnUserIsleViewMediator : AbstractViewMediator<UserIsleModel, UserIsleEvents, UserIsleController, ColossusOnUserIsleView>
	{
		// Token: 0x0600528F RID: 21135 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600528F")]
		[Address(RVA = "0xA065", Offset = "0xA065", VA = "0xA065")]
		public ColossusOnUserIsleViewMediator(UserIsleModel model, UserIsleEvents events, UserIsleController controller)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Isles_User_Controller_ColossusOnUserIsleViewMediator___ctor
		               (int *param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int iVar2;
		  int iVar3;
		  undefined4 uVar4;
		  int *piVar5;
		  uint *puVar6;
		  undefined4 uVar7;
		  
		  if (DAT_ram_00a58d8e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_UserIsleModel__UserIsleEvents__UserIsleController__ColossusOnUserIsleView__set_Events__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_User_Controller_ColossusOnUserIsleViewMediator_IsCurrentChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_User_Controller_ColossusOnUserIsleViewMediator_RenderColossus__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a58d8e = '\x01';
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar2 != 0) {
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar7 = *(undefined4 *)(iVar3 + 0x18);
		    uVar4 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar4,param1,
		               Method_Gameplay_Isles_User_Controller_ColossusOnUserIsleViewMediator_IsCurrentChangedEvent__
		               ,0);
		    piVar5 = (int *)func_ii_7048(uVar7,uVar4,0);
		    iVar2 = System_Action_TypeInfo;
		    if (piVar5 == (int *)0x0) {
		      *(undefined4 *)(iVar3 + 0x18) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar5) ||
		            (*(int **)(iVar3 + 0x18) = piVar5, *piVar5 != iVar2)) {
		      System_Activator__CreateInstance(piVar5,iVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
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
		          puVar6 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 600);
		          goto code_r0x80fa65ce;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    puVar6 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x33);
		code_r0x80fa65ce:
		    iVar2 = (**(code **)((ulonglong)*puVar6 * 4))(piVar5,puVar6[1]);
		    iVar3 = *(int *)(iVar2 + 0x18);
		    uVar7 = *(undefined4 *)(iVar3 + 0x14);
		    uVar4 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar4,param1,
		               Method_Gameplay_Isles_User_Controller_ColossusOnUserIsleViewMediator_RenderColossus__
		               ,0);
		    piVar5 = (int *)func_ii_7048(uVar7,uVar4,0);
		    iVar2 = System_Action_TypeInfo;
		    if (piVar5 == (int *)0x0) {
		      *(undefined4 *)(iVar3 + 0x14) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar5) ||
		            (*(int **)(iVar3 + 0x14) = piVar5, *piVar5 != iVar2)) {
		      System_Activator__CreateInstance(piVar5,iVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  param1[3] = param2;
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar2 != 0) {
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar7 = *(undefined4 *)(iVar3 + 0x18);
		    uVar4 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar4,param1,
		               Method_Gameplay_Isles_User_Controller_ColossusOnUserIsleViewMediator_IsCurrentChangedEvent__
		               ,0);
		    piVar5 = (int *)UnityEngine_UI_Image__set_sprite(uVar7,uVar4,0);
		    iVar2 = System_Action_TypeInfo;
		    if (piVar5 == (int *)0x0) {
		      *(undefined4 *)(iVar3 + 0x18) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar5) ||
		            (*(int **)(iVar3 + 0x18) = piVar5, *piVar5 != iVar2)) {
		      System_Activator__CreateInstance(piVar5,iVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
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
		          puVar6 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 600);
		          goto code_r0x80fa6774;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    puVar6 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x33);
		code_r0x80fa6774:
		    iVar2 = (**(code **)((ulonglong)*puVar6 * 4))(piVar5,puVar6[1]);
		    iVar3 = *(int *)(iVar2 + 0x18);
		    uVar7 = *(undefined4 *)(iVar3 + 0x14);
		    uVar4 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar4,param1,
		               Method_Gameplay_Isles_User_Controller_ColossusOnUserIsleViewMediator_RenderColossus__
		               ,0);
		    piVar5 = (int *)UnityEngine_UI_Image__set_sprite(uVar7,uVar4,0);
		    iVar2 = System_Action_TypeInfo;
		    if (piVar5 == (int *)0x0) {
		      *(undefined4 *)(iVar3 + 0x14) = 0;
		      return;
		    }
		    if ((System_Action_TypeInfo != *piVar5) || (*(int **)(iVar3 + 0x14) = piVar5, *piVar5 != iVar2))
		    {
		      System_Activator__CreateInstance(piVar5,iVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x170010D6 RID: 4310
		// (set) Token: 0x06005290 RID: 21136 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170010D6")]
		public override UserIsleEvents Events
		{
			[Token(Token = "0x6005290")]
			[Address(RVA = "0xA066", Offset = "0xA066", VA = "0xA066", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x170010D7 RID: 4311
		// (set) Token: 0x06005291 RID: 21137 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170010D7")]
		public override ColossusOnUserIsleView View
		{
			[Token(Token = "0x6005291")]
			[Address(RVA = "0xA067", Offset = "0xA067", VA = "0xA067", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06005292 RID: 21138 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005292")]
		[Address(RVA = "0xA068", Offset = "0xA068", VA = "0xA068")]
		private void ColossusClickedEventHandler(ColossusBattleData data)
		{
		/* --- GHIDRA: ColossusClickedEventHandler ---
		void Gameplay_Isles_User_Controller_ColossusOnUserIsleViewMediator__ColossusClickedEventHandler
		               (undefined4 param1,undefined4 param2)
		
		{
		  Gameplay_Isles_User_Controller_ColossusOnUserIsleViewMediator__IsCurrentChangedEvent
		            (param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06005293 RID: 21139 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005293")]
		[Address(RVA = "0xA069", Offset = "0xA069", VA = "0xA069")]
		private void IsCurrentChangedEvent()
		{
		/* --- GHIDRA: IsCurrentChangedEvent ---
		void Gameplay_Isles_User_Controller_ColossusOnUserIsleViewMediator__IsCurrentChangedEvent
		               (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 in_register_20000014;
		  int iVar2;
		  undefined4 uVar3;
		  uint *puVar4;
		  int *param1_00;
		  undefined8 uVar5;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a58d91 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_UserIsleModel__UserIsleEvents__UserIsleController__ColossusOnUserIsleView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a58d91 = '\x01';
		  }
		  local_4 = 0;
		  if (*(char *)(param1[2] + 0x2c) != '\0') {
		    uVar5 = CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x15c));
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))(param1,uVar5);
		    in_register_20000014 = (undefined4)((ulonglong)uVar5 >> 0x20);
		    if ((iVar2 != 0) && (*(char *)(param1[2] + 0x18) == '\0')) {
		      if (*(int *)(*(int *)(param1[2] + 8) + 0x68) != 0) {
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
		              puVar4 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 600);
		              goto code_r0x80fa6b7e;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		        }
		        puVar4 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x33);
		code_r0x80fa6b7e:
		        iVar2 = (**(code **)((ulonglong)*puVar4 * 4))
		                          (param1_00,CONCAT44(in_register_20000014,puVar4[1]));
		        uVar5 = *(undefined8 *)(*(int *)(*(int *)(*(int *)(param1[2] + 8) + 0x68) + 0x1c) + 0x10);
		        iVar2 = Gameplay_WorldAxis_Model_WorldAxisModel__DeterminePartyInfo
		                          (*(undefined4 *)(iVar2 + 0x14),uVar5,&local_4,0);
		        in_register_20000014 = (undefined4)((ulonglong)uVar5 >> 0x20);
		        if (iVar2 != 0) {
		          uVar5 = CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x15c));
		          iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))(param1,uVar5);
		          uVar3 = (undefined4)((ulonglong)uVar5 >> 0x20);
		          Gameplay_Isles_Axis_View_ColossusInWorldView__ButtonClickedEventHandler
		                    (*(undefined4 *)(iVar2 + 0x10),local_4,param1);
		          iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                            (param1,CONCAT44(uVar3,*(undefined4 *)(*param1 + 0x15c)));
		          uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                            (*(undefined4 *)(iVar2 + 0x10),0);
		          Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                    (uVar3,1,0);
		          return;
		        }
		      }
		      iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x15c)));
		      uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(iVar2 + 0x10),0);
		      Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                (uVar3,0,0);
		      return;
		    }
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x15c)));
		  uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(iVar2 + 0x10),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar3,0,0);
		  return;
		}
		*/

		}

		// Token: 0x06005294 RID: 21140 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005294")]
		[Address(RVA = "0xA06A", Offset = "0xA06A", VA = "0xA06A")]
		private void RenderColossus()
		{
		/* --- GHIDRA: RenderColossus ---
		void Gameplay_Isles_User_Controller_ColossusOnUserIsleViewMediator__RenderColossus
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5)
		
		{
		  if (DAT_ram_00a58d92 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_UserIsleModel__UserIsleEvents__UserIsleController__IsleAccountMarkersLayerView___ctor__
		              );
		    DAT_ram_00a58d92 = '\x01';
		  }
		  Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		            (param1,param2,param3,param4,
		             Method_MVC_AbstractViewMediator_UserIsleModel__UserIsleEvents__UserIsleController__IsleAccountMarkersLayerView___ctor__
		            );
		  return;
		}
		*/

		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_Events ---
		void Gameplay_Isles_User_Controller_ColossusOnUserIsleViewMediator__set_Events
		               (int *param1,int param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 uVar5;
		  int iVar6;
		  int iVar7;
		  
		  if (DAT_ram_00a58d8f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_UserIsleModel__UserIsleEvents__UserIsleController__ColossusOnUserIsleView__set_View__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_ColossusBattleData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_User_Controller_ColossusOnUserIsleViewMediator_ColossusClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a58d8f = '\x01';
		  }
		  uVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar6 = UnityEngine_TextCore_Text_TextElement__get_textAsset(uVar5,param2,0);
		  if (iVar6 != 0) {
		    uVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    iVar6 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar5,0);
		    if (iVar6 != 0) {
		      iVar6 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      iVar6 = *(int *)(iVar6 + 0x10);
		      uVar5 = unnamed_function_1417(System_Action_ColossusBattleData__TypeInfo);
		      UnityEngine_UIElements_VisualElement__get_layout
		                (uVar5,param1,
		                 Method_Gameplay_Isles_User_Controller_ColossusOnUserIsleViewMediator_ColossusClickedEventHandler__
		                 ,0);
		      if (DAT_ram_00a58cf9 == '\0') {
		        Mono_Security_ASN1__get_Item(&System_Action_ColossusBattleData__TypeInfo);
		        DAT_ram_00a58cf9 = '\x01';
		      }
		      iVar3 = *(int *)(iVar6 + 0x44);
		      do {
		        iVar4 = 0;
		        iVar7 = func_ii_7048(iVar3,uVar5,0);
		        uVar2 = System_Action_ColossusBattleData__TypeInfo;
		        if ((iVar7 != 0) &&
		           (iVar4 = func_ii_1082(iVar7,System_Action_ColossusBattleData__TypeInfo), iVar4 == 0)) {
		          System_Activator__CreateInstance(iVar7,uVar2);
		          do {
		            halt_trap();
		          } while( true );
		        }
		        iVar4 = func_ii_4329(iVar6 + 0x44,iVar4,iVar3);
		        bVar1 = iVar4 != iVar3;
		        iVar3 = iVar4;
		      } while (bVar1);
		    }
		    param1[5] = param2;
		    uVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    iVar6 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar5,0);
		    if (iVar6 != 0) {
		      iVar6 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      iVar6 = *(int *)(iVar6 + 0x10);
		      uVar5 = unnamed_function_1417(System_Action_ColossusBattleData__TypeInfo);
		      UnityEngine_UIElements_VisualElement__get_layout
		                (uVar5,param1,
		                 Method_Gameplay_Isles_User_Controller_ColossusOnUserIsleViewMediator_ColossusClickedEventHandler__
		                 ,0);
		      if (DAT_ram_00a58cf8 == '\0') {
		        Mono_Security_ASN1__get_Item(&System_Action_ColossusBattleData__TypeInfo);
		        DAT_ram_00a58cf8 = '\x01';
		      }
		      iVar3 = *(int *)(iVar6 + 0x44);
		      do {
		        iVar4 = 0;
		        iVar7 = UnityEngine_UI_Image__set_sprite(iVar3,uVar5,0);
		        uVar2 = System_Action_ColossusBattleData__TypeInfo;
		        if ((iVar7 != 0) &&
		           (iVar4 = func_ii_1082(iVar7,System_Action_ColossusBattleData__TypeInfo), iVar4 == 0)) {
		          System_Activator__CreateInstance(iVar7,uVar2);
		          do {
		            halt_trap();
		          } while( true );
		        }
		        iVar4 = func_ii_4329(iVar6 + 0x44,iVar4,iVar3);
		        bVar1 = iVar4 != iVar3;
		        iVar3 = iVar4;
		      } while (bVar1);
		      Gameplay_Isles_User_Controller_ColossusOnUserIsleViewMediator__IsCurrentChangedEvent
		                (param1,iVar4);
		    }
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_View ---
		void Gameplay_Isles_User_Controller_ColossusOnUserIsleViewMediator__set_View
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  int *param1_01;
		  int iVar3;
		  
		  if (DAT_ram_00a58d90 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a58d90 = '\x01';
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
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 600);
		        goto code_r0x80fa6ceb;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,0x33);
		code_r0x80fa6ceb:
		  param1_00 = (**(code **)((ulonglong)*puVar2 * 4))(param1_01,puVar2[1]);
		  Core_Gameplay_Managers_WorldAxisManager__ShowWorldAxisWindow(param1_00,param2,0);
		  return;
		}
		*/

}
