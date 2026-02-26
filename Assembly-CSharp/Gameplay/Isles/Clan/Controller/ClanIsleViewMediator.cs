using System;
using Core.Data;
using Gameplay.Isles.Base.Controller;
using Gameplay.Isles.Clan.Events;
using Gameplay.Isles.Clan.Model;
using Gameplay.Isles.Clan.View;
using Il2CppDummyDll;

namespace Gameplay.Isles.Clan.Controller
{
	// Token: 0x02000CF7 RID: 3319
	[Token(Token = "0x2000CF7")]
	public class ClanIsleViewMediator : BaseIsleViewMediator<ClanIsleController, ClanIsleView, ClanIsleModel, ClanIsleEvents>
	{
		// Token: 0x060050D3 RID: 20691 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050D3")]
		[Address(RVA = "0x9EE2", Offset = "0x9EE2", VA = "0x9EE2", Slot = "22")]
		protected override void HandleBuildingClick(uint type)
		{
		}

		// Token: 0x060050D4 RID: 20692 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050D4")]
		[Address(RVA = "0x9EE3", Offset = "0x9EE3", VA = "0x9EE3", Slot = "25")]
		protected override void ValidateBuildingAvailability()
		{
		/* --- GHIDRA: ValidateBuildingAvailability ---
		void Gameplay_Isles_Clan_Controller_ClanIsleViewMediator__ValidateBuildingAvailability
		               (int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 in_register_20000014;
		  uint *puVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  int iVar5;
		  
		  if (DAT_ram_00a58cd1 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_ClanIsleEvents__ClanIsleModel__ClanIsleController__ClanBuildingTypes__TryOpenBuildingByType__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanIsleModel__BaseIsleEvents__ClanIsleController__ClanIsleView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a58cd1 = '\x01';
		  }
		  if (*(char *)(*(int *)(param1 + 8) + 0x2c) == '\0') {
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    uVar1 = 0;
		    piVar4 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar5 = *piVar4;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x110);
		          goto code_r0x80f995ad;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,10);
		code_r0x80f995ad:
		    uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,CONCAT44(in_register_20000014,puVar2[1]));
		    Core_Gameplay_Managers_WorldManager__GoToUserIsleById
		              (uVar3,*(undefined8 *)(*(int *)(param1 + 8) + 0x10),0);
		    return;
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  piVar4 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x110);
		        goto code_r0x80f99665;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,10);
		code_r0x80f99665:
		  iVar5 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,CONCAT44(in_register_20000014,puVar2[1]));
		  uVar3 = Gameplay_World_Model_WorldModel__GetUserIsle
		                    (*(undefined4 *)(iVar5 + 0x14),*(undefined8 *)(*(int *)(param1 + 8) + 0x10),0);
		  Gameplay_Isles_Base_AbstractIsle_object__object__object__Int32Enum___SetIsCurrentIsle
		            (uVar3,1,
		             Method_Gameplay_Isles_Base_AbstractIsle_ClanIsleEvents__ClanIsleModel__ClanIsleController__ClanBuildingTypes__TryOpenBuildingByType__
		            );
		  return;
		}
		*/

		}

		// Token: 0x060050D5 RID: 20693 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050D5")]
		[Address(RVA = "0x9EE4", Offset = "0x9EE4", VA = "0x9EE4", Slot = "21")]
		protected override void HandleClickBg()
		{
		/* --- GHIDRA: HandleClickBg ---
		uint Gameplay_Isles_Clan_Controller_ClanIsleViewMediator__HandleClickBg
		               (int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a58cd2 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanIsleModel__BaseIsleEvents__ClanIsleController__ClanIsleView__get_Model__
		              );
		    DAT_ram_00a58cd2 = '\x01';
		  }
		  iVar2 = *(int *)(param1 + 8);
		  if (*(char *)(iVar2 + 0x2c) == '\0') {
		    uVar1 = 1;
		  }
		  else {
		    if (DAT_ram_00a58ceb == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&Method_System_Collections_Generic_Dictionary_uint__BaseBuildingData__TryGetValue__
		                );
		      DAT_ram_00a58ceb = '\x01';
		    }
		    local_4 = 0;
		    iVar2 = *(int *)(iVar2 + 0x24);
		    if (iVar2 == 0) {
		      uVar1 = 1;
		    }
		    else {
		      iVar2 = UnityEngine_TextCore_LowLevel_LigatureSubstitutionRecord__get_componentGlyphIDs
		                        (iVar2,1,&local_4,
		                         Method_System_Collections_Generic_Dictionary_uint__BaseBuildingData__TryGetValue__
		                        );
		      if (iVar2 == 0) {
		        uVar1 = 1;
		      }
		      else {
		        iVar2 = Newtonsoft_Json_Converters_XDeclarationWrapper__get_Encoding(local_4,0);
		        uVar1 = (uint)(iVar2 == 0);
		      }
		    }
		  }
		  return uVar1;
		}
		*/

		}

		// Token: 0x060050D6 RID: 20694 RVA: 0x0000EC40 File Offset: 0x0000CE40
		[Token(Token = "0x60050D6")]
		[Address(RVA = "0x9EE5", Offset = "0x9EE5", VA = "0x9EE5", Slot = "24")]
		protected override bool GetBgInteractable()
		{
		/* --- GHIDRA: GetBgInteractable ---
		undefined4
		Gameplay_Isles_Clan_Controller_ClanIsleViewMediator__GetBgInteractable(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a58cd3 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanIsleModel__BaseIsleEvents__ClanIsleController__ClanIsleView__get_Model__
		              );
		    DAT_ram_00a58cd3 = '\x01';
		  }
		  uVar1 = Gameplay_Isles_Clan_Model_ClanIsleModel__GetCancelImproveMoneyBack
		                    (*(undefined4 *)(param1 + 8),param1);
		  return uVar1;
		}
		*/

			return default(bool);
		}

		// Token: 0x060050D7 RID: 20695 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60050D7")]
		[Address(RVA = "0x9EE6", Offset = "0x9EE6", VA = "0x9EE6", Slot = "27")]
		protected override string GetBgAssetId()
		{
		/* --- GHIDRA: GetBgAssetId ---
		void Gameplay_Isles_Clan_Controller_ClanIsleViewMediator__GetBgAssetId
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5)
		
		{
		  if (DAT_ram_00a58cd4 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_Controller_BaseIsleViewMediator_ClanIsleController__ClanIsleView__ClanIsleModel__ClanIsleEvents___ctor__
		              );
		    DAT_ram_00a58cd4 = '\x01';
		  }
		  MVC_AbstractController_object__object___set_Model
		            (param1,param2,param3,param4,
		             Method_Gameplay_Isles_Base_Controller_BaseIsleViewMediator_ClanIsleController__ClanIsleView__ClanIsleModel__ClanIsleEvents___ctor__
		            );
		  return;
		}
		*/

			return null;
		}

		// Token: 0x060050D8 RID: 20696 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050D8")]
		[Address(RVA = "0x9EE7", Offset = "0x9EE7", VA = "0x9EE7")]
		public ClanIsleViewMediator(ClanIsleModel model, ClanIsleEvents events, ClanIsleController controller)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Isles_Clan_Controller_ClanIsleViewMediator___ctor
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  uint uVar2;
		  int iVar3;
		  undefined4 uVar4;
		  int iVar5;
		  int iVar6;
		  uint *puVar7;
		  int *piVar8;
		  int iVar9;
		  undefined4 uVar10;
		  
		  if (DAT_ram_00a58cd5 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ColossusBattleData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_Controller_BaseIsleViewMediator_ClanIsleController__ClanIsleView__ClanIsleModel__ClanIsleEvents__set_View__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Clan_Controller_ClanIsleViewMediator_ColossusClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Isles_Clan_Controller_ClanIsleViewMediator_HandleColossusView__);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a58cd5 = '\x01';
		  }
		  uVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar5 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar4,0);
		  if (iVar5 != 0) {
		    iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    iVar5 = *(int *)(iVar5 + 0x38);
		    uVar4 = unnamed_function_1417(System_Action_ColossusBattleData__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar4,param1,
		               Method_Gameplay_Isles_Clan_Controller_ClanIsleViewMediator_ColossusClickedEventHandler__
		               ,0);
		    if (DAT_ram_00a58cf9 == '\0') {
		      Mono_Security_ASN1__get_Item(&System_Action_ColossusBattleData__TypeInfo);
		      DAT_ram_00a58cf9 = '\x01';
		    }
		    iVar9 = *(int *)(iVar5 + 0x44);
		    do {
		      iVar3 = 0;
		      iVar6 = func_ii_7048(iVar9,uVar4,0);
		      uVar10 = System_Action_ColossusBattleData__TypeInfo;
		      if ((iVar6 != 0) &&
		         (iVar3 = func_ii_1082(iVar6,System_Action_ColossusBattleData__TypeInfo), iVar3 == 0)) {
		        System_Activator__CreateInstance(iVar6,uVar10);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      iVar3 = func_ii_4329(iVar5 + 0x44,iVar3,iVar9);
		      bVar1 = iVar3 != iVar9;
		      iVar9 = iVar3;
		    } while (bVar1);
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    piVar8 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar5 = *piVar8;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      uVar2 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar2 * 8)) {
		          puVar7 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar2 * 8 + 4) * 8 + iVar5 + 600);
		          goto code_r0x80f99982;
		        }
		        uVar2 = uVar2 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar2);
		    }
		    puVar7 = (uint *)func_ii_1080(piVar8,Core_Gameplay_IGame_TypeInfo,0x33);
		code_r0x80f99982:
		    iVar5 = (**(code **)((ulonglong)*puVar7 * 4))(piVar8,puVar7[1]);
		    iVar9 = *(int *)(iVar5 + 0x18);
		    uVar10 = *(undefined4 *)(iVar9 + 0x14);
		    uVar4 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar4,param1,
		               Method_Gameplay_Isles_Clan_Controller_ClanIsleViewMediator_HandleColossusView__,0);
		    piVar8 = (int *)func_ii_7048(uVar10,uVar4,0);
		    iVar5 = System_Action_TypeInfo;
		    if (piVar8 == (int *)0x0) {
		      *(undefined4 *)(iVar9 + 0x14) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar8) ||
		            (*(int **)(iVar9 + 0x14) = piVar8, *piVar8 != iVar5)) {
		      System_Activator__CreateInstance(piVar8,iVar5);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar4 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(iVar5 + 0x38),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar4,0,0);
		  }
		  Gameplay_Isles_Base_Controller_BaseIsleViewMediator_object__object__object__object___set_Events
		            (param1,param2,
		             Method_Gameplay_Isles_Base_Controller_BaseIsleViewMediator_ClanIsleController__ClanIsleView__ClanIsleModel__ClanIsleEvents__set_View__
		            );
		  uVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar5 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar4,0);
		  if (iVar5 != 0) {
		    iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    iVar5 = *(int *)(iVar5 + 0x38);
		    uVar4 = unnamed_function_1417(System_Action_ColossusBattleData__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar4,param1,
		               Method_Gameplay_Isles_Clan_Controller_ClanIsleViewMediator_ColossusClickedEventHandler__
		               ,0);
		    if (DAT_ram_00a58cf8 == '\0') {
		      Mono_Security_ASN1__get_Item(&System_Action_ColossusBattleData__TypeInfo);
		      DAT_ram_00a58cf8 = '\x01';
		    }
		    iVar9 = *(int *)(iVar5 + 0x44);
		    do {
		      iVar3 = 0;
		      iVar6 = UnityEngine_UI_Image__set_sprite(iVar9,uVar4,0);
		      uVar10 = System_Action_ColossusBattleData__TypeInfo;
		      if ((iVar6 != 0) &&
		         (iVar3 = func_ii_1082(iVar6,System_Action_ColossusBattleData__TypeInfo), iVar3 == 0)) {
		        System_Activator__CreateInstance(iVar6,uVar10);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      iVar3 = func_ii_4329(iVar5 + 0x44,iVar3,iVar9);
		      bVar1 = iVar3 != iVar9;
		      iVar9 = iVar3;
		    } while (bVar1);
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    piVar8 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar5 = *piVar8;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      uVar2 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar2 * 8)) {
		          puVar7 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar2 * 8 + 4) * 8 + iVar5 + 600);
		          goto code_r0x80f99b8f;
		        }
		        uVar2 = uVar2 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar2);
		    }
		    puVar7 = (uint *)func_ii_1080(piVar8,Core_Gameplay_IGame_TypeInfo,0x33);
		code_r0x80f99b8f:
		    iVar5 = (**(code **)((ulonglong)*puVar7 * 4))(piVar8,puVar7[1]);
		    iVar9 = *(int *)(iVar5 + 0x18);
		    uVar10 = *(undefined4 *)(iVar9 + 0x14);
		    uVar4 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar4,param1,
		               Method_Gameplay_Isles_Clan_Controller_ClanIsleViewMediator_HandleColossusView__,0);
		    piVar8 = (int *)UnityEngine_UI_Image__set_sprite(uVar10,uVar4,0);
		    iVar5 = System_Action_TypeInfo;
		    if (piVar8 == (int *)0x0) {
		      *(undefined4 *)(iVar9 + 0x14) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar8) ||
		            (*(int **)(iVar9 + 0x14) = piVar8, *piVar8 != iVar5)) {
		      System_Activator__CreateInstance(piVar8,iVar5);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    Gameplay_Isles_Clan_Controller_ClanIsleViewMediator__ColossusClickedEventHandler(param1,piVar8);
		  }
		  return;
		}
		*/

		}

		// Token: 0x17001056 RID: 4182
		// (set) Token: 0x060050D9 RID: 20697 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001056")]
		public override ClanIsleView View
		{
			[Token(Token = "0x60050D9")]
			[Address(RVA = "0x9EE8", Offset = "0x9EE8", VA = "0x9EE8", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x060050DA RID: 20698 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050DA")]
		[Address(RVA = "0x9EE9", Offset = "0x9EE9", VA = "0x9EE9")]
		private void ColossusClickedEventHandler(ColossusBattleData data)
		{
		/* --- GHIDRA: ColossusClickedEventHandler ---
		void Gameplay_Isles_Clan_Controller_ClanIsleViewMediator__ColossusClickedEventHandler
		               (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 in_register_20000014;
		  undefined4 uVar2;
		  uint *puVar3;
		  int iVar4;
		  undefined4 param1_00;
		  int *param1_01;
		  int iVar5;
		  undefined8 uVar6;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a58cd7 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanIsleModel__BaseIsleEvents__ClanIsleController__ClanIsleView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a58cd7 = '\x01';
		  }
		  local_4 = 0;
		  if (*(int *)(param1[2] + 0x38) != 0) {
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    param1_01 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar5 = *param1_01;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 600);
		          goto code_r0x80f99d16;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,0x33);
		code_r0x80f99d16:
		    iVar5 = (**(code **)((ulonglong)*puVar3 * 4))
		                      (param1_01,CONCAT44(in_register_20000014,puVar3[1]));
		    uVar6 = *(undefined8 *)(*(int *)(*(int *)(param1[2] + 0x38) + 0x10) + 0x10);
		    iVar5 = Gameplay_WorldAxis_Model_WorldAxisModel__DeterminePartyInfo
		                      (*(undefined4 *)(iVar5 + 0x14),uVar6,&local_4,0);
		    uVar6 = CONCAT44((int)((ulonglong)uVar6 >> 0x20),*(undefined4 *)(*param1 + 0x15c));
		    iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))(param1,uVar6);
		    uVar2 = (undefined4)((ulonglong)uVar6 >> 0x20);
		    param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                          (*(undefined4 *)(iVar4 + 0x38),0);
		    if (iVar5 == 0) {
		      Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                (param1_00,0,0);
		    }
		    else {
		      Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                (param1_00,1,0);
		      iVar4 = *param1;
		      iVar5 = (**(code **)((ulonglong)*(uint *)(iVar4 + 0x158) * 4))
		                        (param1,CONCAT44(uVar2,*(undefined4 *)(iVar4 + 0x15c)));
		      Gameplay_Isles_Axis_View_ColossusInWorldView__ButtonClickedEventHandler
		                (*(undefined4 *)(iVar5 + 0x38),local_4,iVar4);
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x060050DB RID: 20699 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60050DB")]
		[Address(RVA = "0x9EEA", Offset = "0x9EEA", VA = "0x9EEA")]
		private void HandleColossusView()
		{
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_View ---
		void Gameplay_Isles_Clan_Controller_ClanIsleViewMediator__set_View
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  int *param1_01;
		  int iVar3;
		  
		  if (DAT_ram_00a58cd6 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a58cd6 = '\x01';
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
		        goto code_r0x80f9a0e7;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,0x33);
		code_r0x80f9a0e7:
		  param1_00 = (**(code **)((ulonglong)*puVar2 * 4))(param1_01,puVar2[1]);
		  Core_Gameplay_Managers_WorldAxisManager__ShowWorldAxisWindow(param1_00,param2,0);
		  return;
		}
		*/

}
