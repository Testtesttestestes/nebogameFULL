using System;
using AssetContent;
using Gameplay.Combat.Model;
using Gameplay.Combat.TeamCombat.View;
using Gameplay.Combat.View;
using Gameplay.Combat.View.Players;
using Gameplay.UserInfo.View;
using Gameplay.VortexCombat.Model;
using Gameplay.VortexCombat.View.Player;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.VortexCombat.View
{
	// Token: 0x020003A5 RID: 933
	[Token(Token = "0x20003A5")]
	public class VortexCombatView : AbstractTeamCombatView<VortexCombatPlayer>
	{
		// Token: 0x17000397 RID: 919
		// (get) Token: 0x060015C2 RID: 5570 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000397")]
		public Toggle ShowHideSkillsNumbersButton
		{
			[Token(Token = "0x60015C2")]
			[Address(RVA = "0x6784", Offset = "0x6784", VA = "0x6784")]
			get
			{
				return null;
			}
		}

		// Token: 0x060015C3 RID: 5571 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015C3")]
		[Address(RVA = "0x6785", Offset = "0x6785", VA = "0x6785", Slot = "6")]
		protected override void Start()
		{
		/* --- GHIDRA: Start ---
		undefined4
		Gameplay_VortexCombat_View_VortexCombatView__Start(int param1,int param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param2_00;
		  int *param1_01;
		  int param1_02;
		  uint uVar3;
		  int local_4;
		  
		  if (DAT_ram_00a5820b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_VortexCombatModel__VortexCombatEvents__VortexCombatController__VortexCombatViewMediator__VortexCombatView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_ICombatPLayerView__Add__);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Object_Instantiate_VortexCombatPlayerView___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_DefaultNamespace_SceneAppManager_TryGetSceneArgs_ICombat___);
		    Mono_Security_ASN1__get_Item(&Gameplay_VortexCombat_VortexCombat_TypeInfo);
		    DAT_ram_00a5820b = '\x01';
		  }
		  local_4 = 0;
		  uVar2 = *(undefined4 *)(param1 + 0x4c);
		  param2_00 = *(undefined4 *)(param1 + 0x54);
		  param1_00 = UI_Windows_PopupController__get_OpenedWindowsCount(0);
		  iVar1 = DefaultNamespace_SceneAppManager__LoadScene___Il2CppFullySharedGenericType_
		                    (param1_00,0xb,&local_4,
		                     Method_DefaultNamespace_SceneAppManager_TryGetSceneArgs_ICombat___);
		  if (iVar1 != 0) {
		    param1_01 = *(int **)(local_4 + 0xc);
		    if (param1_01 != (int *)0x0) {
		      if (((uint)*(byte *)(*param1_01 + 0xb8) <
		           (uint)*(byte *)(Gameplay_VortexCombat_VortexCombat_TypeInfo + 0xb8)) ||
		         (*(int *)(*(int *)(*param1_01 + 100) +
		                   (uint)*(byte *)(Gameplay_VortexCombat_VortexCombat_TypeInfo + 0xb8) * 4 + -4) !=
		          Gameplay_VortexCombat_VortexCombat_TypeInfo)) {
		        System_Activator__CreateInstance(param1_01,Gameplay_VortexCombat_VortexCombat_TypeInfo);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    if (*(int *)(*(int *)(param2 + 8) + 0x14) == *(int *)(*(int *)(param1_01[6] + 0xc) + 0x2c)) {
		      uVar2 = *(undefined4 *)(param1 + 0x48);
		      param2_00 = *(undefined4 *)(param1 + 0x50);
		    }
		  }
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  uVar2 = func_ii_6805(uVar2,param2_00,
		                       Method_UnityEngine_Object_Instantiate_VortexCombatPlayerView___);
		  iVar1 = Method_System_Collections_Generic_List_ICombatPLayerView__Add__;
		  param1_02 = *(int *)(param1 + 0x44);
		  *(int *)(param1_02 + 0x10) = *(int *)(param1_02 + 0x10) + 1;
		  uVar3 = *(uint *)(param1_02 + 0xc);
		  if (uVar3 < *(uint *)(*(int *)(param1_02 + 8) + 0xc)) {
		    *(uint *)(param1_02 + 0xc) = uVar3 + 1;
		    *(undefined4 *)(*(int *)(param1_02 + 8) + uVar3 * 4 + 0x10) = uVar2;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (param1_02,uVar2,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  }
		  return uVar2;
		}
		*/

		}

		// Token: 0x060015C4 RID: 5572 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60015C4")]
		[Address(RVA = "0x6786", Offset = "0x6786", VA = "0x6786", Slot = "13")]
		protected override ICombatPLayerView CreatePlayerView(VortexCombatPlayer player)
		{
		/* --- GHIDRA: CreatePlayerView ---
		undefined4
		Gameplay_VortexCombat_View_VortexCombatView__CreatePlayerView
		          (int param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int *param1_00;
		  uint *puVar2;
		  int iVar3;
		  int param2_00;
		  int *piVar4;
		  
		  param2_00 = 0;
		  if (DAT_ram_00a5820c == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_View_Players_ICombatPLayerView_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ICombatPLayerView__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ICombatPLayerView__get_Item__);
		    DAT_ram_00a5820c = '\x01';
		  }
		  iVar3 = *(int *)(param1 + 0x44);
		  if (0 < *(int *)(iVar3 + 0xc)) {
		    do {
		      param1_00 = (int *)System_Linq_Enumerable__ToList_object_
		                                   (iVar3,param2_00,
		                                    Method_System_Collections_Generic_List_ICombatPLayerView__get_Item__
		                                   );
		      iVar3 = *param1_00;
		      if (*(ushort *)(iVar3 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          piVar4 = (int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8);
		          if (Gameplay_Combat_View_Players_ICombatPLayerView_TypeInfo == *piVar4) {
		            puVar2 = (uint *)(piVar4[1] * 8 + iVar3 + 0x100);
		            goto code_r0x80eb9d1f;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		      }
		      puVar2 = (uint *)func_ii_1080(param1_00,
		                                    Gameplay_Combat_View_Players_ICombatPLayerView_TypeInfo,8);
		code_r0x80eb9d1f:
		      iVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		      if (iVar3 == param2) {
		        return param1_00;
		      }
		      param2_00 = param2_00 + 1;
		      iVar3 = *(int *)(param1 + 0x44);
		    } while (param2_00 < *(int *)(iVar3 + 0xc));
		  }
		  return 0;
		}
		*/

			return null;
		}

		// Token: 0x060015C5 RID: 5573 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60015C5")]
		[Address(RVA = "0x6787", Offset = "0x6787", VA = "0x6787", Slot = "9")]
		public override ICombatPLayerView GetPlayer(CombatPlayer player)
		{
		/* --- GHIDRA: GetPlayer ---
		void Gameplay_VortexCombat_View_VortexCombatView__GetPlayer
		               (int param1,undefined4 param2,int param3,undefined4 param4,undefined4 param5)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  uint *puVar3;
		  int *piVar4;
		  int iVar5;
		  undefined4 uVar6;
		  float param2_00;
		  int iVar7;
		  
		  if (DAT_ram_00a5820d == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_11325);
		    Mono_Security_ASN1__get_Item(&StringLiteral_17531);
		    Mono_Security_ASN1__get_Item(&StringLiteral_11323);
		    DAT_ram_00a5820d = '\x01';
		  }
		  piVar4 = *(int **)(param1 + 0x6c);
		  iVar5 = *(int *)(param3 + 0x18);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar2 = func_ii_7508(StringLiteral_17531,1,0,1,0,0,0,0);
		  iVar7 = *piVar4;
		  (**(code **)((ulonglong)*(uint *)(iVar7 + 0x2d0) * 4))
		            (piVar4,uVar2,*(undefined4 *)(iVar7 + 0x2d4));
		  piVar4 = *(int **)(param1 + 0x60);
		  uVar2 = Google_Protobuf_Collections_RepeatedField_object___GetEnumerator
		                    (*(undefined4 *)(iVar5 + 0x14),0);
		  iVar7 = *piVar4;
		  (**(code **)((ulonglong)*(uint *)(iVar7 + 0x2d0) * 4))
		            (piVar4,uVar2,*(undefined4 *)(iVar7 + 0x2d4));
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar4 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar7 = *piVar4;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x178);
		        goto code_r0x80eb9ea6;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80eb9ea6:
		  uVar2 = (**(code **)((ulonglong)*puVar3 * 4))(piVar4,puVar3[1]);
		  uVar2 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar2,0);
		  uVar2 = Core_Extensions_Dict_DictExt__GetArtikulTypeFiltersByFilterType
		                    (uVar2,*(undefined4 *)(*(int *)(*(int *)(iVar5 + 0x14) + 0x34) + 0x1c),0);
		  uVar2 = UI_Wiki_WikiUriRouter__SetData(uVar2,0);
		  Core_Extensions_Dict_AprDicExt__Get1024AssetId(*(undefined4 *)(param1 + 0x5c),uVar2,0);
		  uVar2 = *(undefined4 *)(param1 + 0x68);
		  if (*(int *)(iVar5 + 0x20) == 0) {
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    uVar1 = 0;
		    piVar4 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar7 = *piVar4;
		    if (*(ushort *)(iVar7 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x178);
		          goto code_r0x80eb9f8f;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80eb9f8f:
		    uVar6 = (**(code **)((ulonglong)*puVar3 * 4))(piVar4,puVar3[1]);
		    uVar6 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar6,0);
		    uVar6 = Core_Extensions_Dict_DictExt__GetServiceOptionDic(uVar6,StringLiteral_11323,0);
		    Gameplay_UserInfo_View_CultView2___ctor(uVar2,uVar6,0);
		    uVar2 = *(undefined4 *)(param1 + 0x68);
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    piVar4 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar7 = *piVar4;
		    if (*(ushort *)(iVar7 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x178);
		          goto code_r0x80eba05c;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80eba05c:
		    uVar6 = (**(code **)((ulonglong)*puVar3 * 4))(piVar4,puVar3[1]);
		    uVar6 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar6,0);
		    uVar6 = Core_Extensions_Dict_DictExt__GetServiceOptionDic(uVar6,StringLiteral_11325,0);
		    Core_Extensions_Dict_ResourcesDicExt__GetIconForResourceBar64AssetId(uVar2,uVar6,0);
		  }
		  else {
		    Gameplay_UserInfo_View_CultView2__get_CultDic(uVar2,*(int *)(iVar5 + 0x20),0);
		  }
		  param2_00 = 0.0;
		  if (*(char *)(param3 + 8) == '\0') {
		    param2_00 = 1.0;
		  }
		  AssetContent_GameAssetViewRawImage__get_AssetPath(*(undefined4 *)(param1 + 0x5c),param2_00,0.0,0);
		  uVar6 = *(undefined4 *)(param1 + 100);
		  uVar2 = Core_Data_UserData__set_LevelDic(*(undefined4 *)(iVar5 + 0x14),0);
		  Gameplay_Combat_View_Players_CombatPlayerLevelView__HandleIsPreminumExpChanged(uVar6,uVar2,0);
		  uVar6 = *(undefined4 *)(param1 + 100);
		  uVar2 = Core_Data_UserData__set_Level(*(undefined4 *)(iVar5 + 0x14),0);
		  Gameplay_Combat_View_Players_CombatPlayerLevelView__SetValue(uVar6,uVar2,0);
		  Gameplay_Combat_View_AbstractCombatView__HideHint(param1,param2,param3,param4,0);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x060015C6 RID: 5574 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015C6")]
		[Address(RVA = "0x6788", Offset = "0x6788", VA = "0x6788", Slot = "11")]
		public override void ShowGameOver(CombatModel model, GameOverData gameOver, Action<CombatGameOverView> callback)
		{
		/* --- GHIDRA: ShowGameOver ---
		undefined4
		Gameplay_VortexCombat_View_VortexCombatView__ShowGameOver
		          (int param1,undefined4 param2,int *param3,undefined4 param4)
		
		{
		  undefined4 param4_00;
		  undefined4 param1_00;
		  int *piVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a5820e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Combat_View_CombatGameOverView_CombatGameOverViewArgs_TypeInfo);
		    DAT_ram_00a5820e = '\x01';
		  }
		  piVar1 = *(int **)(param1 + 0x28);
		  iVar2 = param3[2];
		  param4_00 = (**(code **)((ulonglong)*(uint *)(*param3 + 0x120) * 4))
		                        (param3,*(undefined4 *)(*param3 + 0x124));
		  param1_00 = unnamed_function_1417
		                        (Gameplay_Combat_View_CombatGameOverView_CombatGameOverViewArgs_TypeInfo);
		  UnityEngine_Purchasing_PurchasingManager___c__DisplayClass27_0___OnAllPurchasesRetrieved_b__0
		            (param1_00,iVar2,param2,param4_00,0);
		  iVar2 = *piVar1;
		  (**(code **)((ulonglong)*(uint *)(iVar2 + 0xe8) * 4))
		            (piVar1,param1_00,*(undefined4 *)(iVar2 + 0xec));
		  return *(undefined4 *)(param1 + 0x28);
		}
		*/

		}

		// Token: 0x060015C7 RID: 5575 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60015C7")]
		[Address(RVA = "0x6789", Offset = "0x6789", VA = "0x6789", Slot = "8")]
		protected override CombatGameOverView ShowGameOverView(GameOverData gameOver, CombatModel model)
		{
		/* --- GHIDRA: ShowGameOverView ---
		void Gameplay_VortexCombat_View_VortexCombatView__ShowGameOverView
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5820f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_VortexCombatPlayer___ctor__
		              );
		    DAT_ram_00a5820f = '\x01';
		  }
		  HuaweiMobileServices_Base_AbstractTask___Il2CppFullySharedGenericType___get_Successful
		            (param1,
		             Method_Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_VortexCombatPlayer___ctor__
		            );
		  return;
		}
		*/

			return null;
		}

		// Token: 0x060015C8 RID: 5576 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015C8")]
		[Address(RVA = "0x678A", Offset = "0x678A", VA = "0x678A")]
		public VortexCombatView()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_VortexCombat_View_VortexCombatView___ctor(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  int iVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 uVar5;
		  int *piVar6;
		  int iVar7;
		  
		  iVar4 = 0;
		  iVar1 = *(int *)(param1 + 0x20);
		  iVar2 = *(int *)(param1 + 0x10);
		  if (DAT_ram_00a58217 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    DAT_ram_00a58217 = '\x01';
		  }
		  iVar3 = *(int *)(iVar2 + 0x14);
		  if (*(int *)(iVar3 + 0xc) < 1) {
		    iVar2 = *(int *)(param1 + 0x20);
		    iVar1 = *(int *)(param1 + 0x14);
		  }
		  else {
		    do {
		      iVar7 = iVar3 + iVar4 * 8;
		      if (iVar1 == *(int *)(iVar7 + 0x10)) {
		        uVar5 = *(undefined4 *)(iVar7 + 0x14);
		        piVar6 = *(int **)(iVar2 + 0xc);
		        if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		          func_ii_306000(Core_GameLocalization_TypeInfo);
		        }
		        uVar5 = func_ii_7508(uVar5,1,0,1,0,0,0,0);
		        iVar3 = *piVar6;
		        (**(code **)((ulonglong)*(uint *)(iVar3 + 0x2d0) * 4))
		                  (piVar6,uVar5,*(undefined4 *)(iVar3 + 0x2d4));
		        iVar3 = *(int *)(iVar2 + 0x14);
		      }
		      iVar4 = iVar4 + 1;
		    } while (iVar4 < *(int *)(iVar3 + 0xc));
		    iVar2 = *(int *)(param1 + 0x20);
		    iVar1 = *(int *)(param1 + 0x14);
		    if (DAT_ram_00a58217 == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		      DAT_ram_00a58217 = '\x01';
		    }
		  }
		  iVar3 = *(int *)(iVar1 + 0x14);
		  if (0 < *(int *)(iVar3 + 0xc)) {
		    iVar4 = 0;
		    do {
		      iVar7 = iVar3 + iVar4 * 8;
		      if (iVar2 == *(int *)(iVar7 + 0x10)) {
		        uVar5 = *(undefined4 *)(iVar7 + 0x14);
		        piVar6 = *(int **)(iVar1 + 0xc);
		        if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		          func_ii_306000(Core_GameLocalization_TypeInfo);
		        }
		        uVar5 = func_ii_7508(uVar5,1,0,1,0,0,0,0);
		        iVar3 = *piVar6;
		        (**(code **)((ulonglong)*(uint *)(iVar3 + 0x2d0) * 4))
		                  (piVar6,uVar5,*(undefined4 *)(iVar3 + 0x2d4));
		        iVar3 = *(int *)(iVar1 + 0x14);
		      }
		      iVar4 = iVar4 + 1;
		    } while (iVar4 < *(int *)(iVar3 + 0xc));
		  }
		  Gameplay_VortexCombat_View_TurnDisplay_TurnStatePointerArrows_TurnPointerElements__get_Visible
		            (*(undefined4 *)(param1 + 0x10),(uint)((*(uint *)(param1 + 0x20) & 0xfffffffd) == 1),
		             iVar4);
		  iVar4 = *(int *)(param1 + 0x20);
		  Gameplay_VortexCombat_View_TurnDisplay_TurnStatePointerArrows_TurnPointerElements__get_Visible
		            (*(undefined4 *)(param1 + 0x14),(uint)(iVar4 == 4 || iVar4 == 2),iVar4);
		  iVar4 = *(int *)(param1 + 0x2c);
		  if (iVar4 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar4 + 0xc) * 4))
		              (*(undefined4 *)(iVar4 + 0x20),*(undefined4 *)(iVar4 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x04000B7D RID: 2941
		[Token(Token = "0x4000B7D")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		protected VortexCombatPlayerView _mySidePlayerPrefab;

		// Token: 0x04000B7E RID: 2942
		[Token(Token = "0x4000B7E")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		protected VortexCombatPlayerView _otherSidePlayerPrefab;

		// Token: 0x04000B7F RID: 2943
		[Token(Token = "0x4000B7F")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		protected Transform _leftSidePlayers;

		// Token: 0x04000B80 RID: 2944
		[Token(Token = "0x4000B80")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		protected Transform _rightSidePlayers;

		// Token: 0x04000B81 RID: 2945
		[Token(Token = "0x4000B81")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Toggle _showHideSkillsNumbersButton;

		// Token: 0x04000B82 RID: 2946
		[Token(Token = "0x4000B82")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private GameAssetViewRawImage _avatar;

		// Token: 0x04000B83 RID: 2947
		[Token(Token = "0x4000B83")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private TextMeshProUGUI _nickField;

		// Token: 0x04000B84 RID: 2948
		[Token(Token = "0x4000B84")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		private CombatPlayerLevelView _level;

		// Token: 0x04000B85 RID: 2949
		[Token(Token = "0x4000B85")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private CultWhitBackground _cultOnNickView;

		// Token: 0x04000B86 RID: 2950
		[Token(Token = "0x4000B86")]
		[FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private TextMeshProUGUI _opponentSquadNickField;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_ShowHideSkillsNumbersButton ---
		void Gameplay_VortexCombat_View_VortexCombatView__get_ShowHideSkillsNumbersButton
		               (undefined4 param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  int *param1_01;
		  int local_4;
		  
		  if (DAT_ram_00a5820a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_VortexCombatModel__VortexCombatEvents__VortexCombatController__VortexCombatViewMediator__VortexCombatView__get_Mediator__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_DefaultNamespace_SceneAppManager_TryGetSceneArgs_ICombat___);
		    Mono_Security_ASN1__get_Item(&Gameplay_VortexCombat_VortexCombat_TypeInfo);
		    DAT_ram_00a5820a = '\x01';
		  }
		  local_4 = 0;
		  param1_00 = UI_Windows_PopupController__get_OpenedWindowsCount(0);
		  iVar1 = DefaultNamespace_SceneAppManager__LoadScene___Il2CppFullySharedGenericType_
		                    (param1_00,0xb,&local_4,
		                     Method_DefaultNamespace_SceneAppManager_TryGetSceneArgs_ICombat___);
		  if (iVar1 != 0) {
		    param1_01 = *(int **)(local_4 + 0xc);
		    if (param1_01 != (int *)0x0) {
		      if (((uint)*(byte *)(*param1_01 + 0xb8) <
		           (uint)*(byte *)(Gameplay_VortexCombat_VortexCombat_TypeInfo + 0xb8)) ||
		         (*(int *)(*(int *)(*param1_01 + 100) +
		                   (uint)*(byte *)(Gameplay_VortexCombat_VortexCombat_TypeInfo + 0xb8) * 4 + -4) !=
		          Gameplay_VortexCombat_VortexCombat_TypeInfo)) {
		        System_Activator__CreateInstance(param1_01,Gameplay_VortexCombat_VortexCombat_TypeInfo);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    iVar1 = *(int *)param1_01[7];
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0x160) * 4))
		              ((int *)param1_01[7],param1,*(undefined4 *)(iVar1 + 0x164));
		  }
		  return;
		}
		*/

}
