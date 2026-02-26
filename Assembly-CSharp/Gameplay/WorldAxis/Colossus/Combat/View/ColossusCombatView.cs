using System;
using Gameplay.Combat.Model;
using Gameplay.Combat.View;
using Gameplay.Combat.View.Players;
using Gameplay.VortexCombat.Model;
using Gameplay.VortexCombat.View;
using Il2CppDummyDll;
using TMPro;
using UI.Rewards;
using UnityEngine;

namespace Gameplay.WorldAxis.Colossus.Combat.View
{
	// Token: 0x02000339 RID: 825
	[Token(Token = "0x2000339")]
	public class ColossusCombatView : VortexCombatView
	{
		// Token: 0x170002EE RID: 750
		// (get) Token: 0x060012FF RID: 4863 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170002EE")]
		public Transform ColossusScoresBlock
		{
			[Token(Token = "0x60012FF")]
			[Address(RVA = "0x64F5", Offset = "0x64F5", VA = "0x64F5")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002EF RID: 751
		// (get) Token: 0x06001300 RID: 4864 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170002EF")]
		public IconValueRender ColossusScoresReward
		{
			[Token(Token = "0x6001300")]
			[Address(RVA = "0x64F6", Offset = "0x64F6", VA = "0x64F6")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002F0 RID: 752
		// (get) Token: 0x06001301 RID: 4865 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170002F0")]
		public TextMeshProUGUI ColossusScoresRewardBlockTitle
		{
			[Token(Token = "0x6001301")]
			[Address(RVA = "0x64F7", Offset = "0x64F7", VA = "0x64F7")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002F1 RID: 753
		// (get) Token: 0x06001302 RID: 4866 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170002F1")]
		public TextMeshProUGUI ColossusRewardDescription
		{
			[Token(Token = "0x6001302")]
			[Address(RVA = "0x64F8", Offset = "0x64F8", VA = "0x64F8")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001303 RID: 4867 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001303")]
		[Address(RVA = "0x64F9", Offset = "0x64F9", VA = "0x64F9", Slot = "6")]
		protected override void Start()
		{
		/* --- GHIDRA: Start ---
		undefined4
		Gameplay_WorldAxis_Colossus_Combat_View_ColossusCombatView__Start
		          (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param2_00;
		  int *param1_01;
		  int param1_02;
		  uint uVar3;
		  int local_4;
		  
		  if (DAT_ram_00a58c19 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_ColossusCombatModel__ColossusCombatEvents__ColossusCombatController__ColossusCombatViewMediator__ColossusCombatView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_WorldAxis_Colossus_Combat_ColossusCombat_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_ICombatPLayerView__Add__);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Object_Instantiate_VortexCombatPlayerView___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_DefaultNamespace_SceneAppManager_TryGetSceneArgs_ICombat___);
		    DAT_ram_00a58c19 = '\x01';
		  }
		  local_4 = 0;
		  uVar2 = *(undefined4 *)(param1 + 0x4c);
		  param2_00 = *(undefined4 *)(param1 + 0x54);
		  param1_00 = UI_Windows_PopupController__get_OpenedWindowsCount(0);
		  iVar1 = DefaultNamespace_SceneAppManager__LoadScene___Il2CppFullySharedGenericType_
		                    (param1_00,0xd,&local_4,
		                     Method_DefaultNamespace_SceneAppManager_TryGetSceneArgs_ICombat___);
		  if (iVar1 != 0) {
		    param1_01 = *(int **)(local_4 + 0xc);
		    if (param1_01 != (int *)0x0) {
		      if (((uint)*(byte *)(*param1_01 + 0xb8) <
		           (uint)*(byte *)(Gameplay_WorldAxis_Colossus_Combat_ColossusCombat_TypeInfo + 0xb8)) ||
		         (*(int *)(*(int *)(*param1_01 + 100) +
		                   (uint)*(byte *)(Gameplay_WorldAxis_Colossus_Combat_ColossusCombat_TypeInfo + 0xb8
		                                  ) * 4 + -4) !=
		          Gameplay_WorldAxis_Colossus_Combat_ColossusCombat_TypeInfo)) {
		        System_Activator__CreateInstance
		                  (param1_01,Gameplay_WorldAxis_Colossus_Combat_ColossusCombat_TypeInfo);
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

		// Token: 0x06001304 RID: 4868 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001304")]
		[Address(RVA = "0x64FA", Offset = "0x64FA", VA = "0x64FA", Slot = "13")]
		protected override ICombatPLayerView CreatePlayerView(VortexCombatPlayer player)
		{
		/* --- GHIDRA: CreatePlayerView ---
		undefined4
		Gameplay_WorldAxis_Colossus_Combat_View_ColossusCombatView__CreatePlayerView
		          (int param1,int param2,int *param3,undefined4 param4)
		
		{
		  uint uVar1;
		  undefined4 in_register_20000004;
		  undefined8 uVar2;
		  undefined4 uVar3;
		  undefined4 in_register_20000014;
		  undefined8 uVar4;
		  undefined4 in_register_20000024;
		  undefined8 uVar5;
		  undefined4 uVar6;
		  undefined4 uVar7;
		  int iVar8;
		  uint *puVar9;
		  undefined4 uVar10;
		  int *piVar11;
		  int *piVar12;
		  int iVar13;
		  undefined4 uVar14;
		  undefined8 local_18;
		  float8 local_10;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a58c1a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_WorldAxis_Colossus_Combat_Model_ColossusCombatModel_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_FirstOrDefault_int___);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_WorldAxis_Colossus_Combat_Model_IColossusCombatRewards_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_KeyValuePair_string__string____TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4378);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4377);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28349);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28348);
		    Mono_Security_ASN1__get_Item(&StringLiteral_21421);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4380);
		    DAT_ram_00a58c1a = '\x01';
		  }
		  local_4 = 0;
		  local_10 = 0.0;
		  if (param3 != (int *)0x0) {
		    if (((uint)*(byte *)(*param3 + 0xb8) <
		         (uint)*(byte *)(Gameplay_WorldAxis_Colossus_Combat_Model_ColossusCombatModel_TypeInfo +
		                        0xb8)) ||
		       (*(int *)(*(int *)(*param3 + 100) +
		                 (uint)*(byte *)(
		                                Gameplay_WorldAxis_Colossus_Combat_Model_ColossusCombatModel_TypeInfo
		                                + 0xb8) * 4 + -4) !=
		        Gameplay_WorldAxis_Colossus_Combat_Model_ColossusCombatModel_TypeInfo)) {
		      System_Activator__CreateInstance
		                (param3,Gameplay_WorldAxis_Colossus_Combat_Model_ColossusCombatModel_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  if (*(char *)(param2 + 8) == '\0') {
		    uVar1 = 0;
		    iVar8 = *(int *)(*(int *)(param2 + 0x20) + 8);
		    piVar11 = *(int **)(param3[0x1a] + 8);
		    iVar13 = *piVar11;
		    if (*(ushort *)(iVar13 + 0xb6) != 0) {
		      do {
		        if (Gameplay_WorldAxis_Colossus_Combat_Model_IColossusCombatRewards_TypeInfo ==
		            *(int *)(*(int *)(iVar13 + 0x58) + uVar1 * 8)) {
		          puVar9 = (uint *)(*(int *)(*(int *)(iVar13 + 0x58) + uVar1 * 8 + 4) * 8 + iVar13 + 0xd0);
		          goto code_r0x80f8bed2;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar13 + 0xb6) != uVar1);
		    }
		    puVar9 = (uint *)func_ii_1080(piVar11,
		                                  Gameplay_WorldAxis_Colossus_Combat_Model_IColossusCombatRewards_TypeInfo
		                                  ,2);
		code_r0x80f8bed2:
		    iVar13 = (**(code **)((ulonglong)*puVar9 * 4))
		                       (CONCAT44(in_register_20000004,piVar11),
		                        CONCAT44(in_register_20000014,puVar9[1]));
		    in_register_20000004 = 0;
		    in_register_20000014 = 0;
		    in_register_20000024 = 0;
		    uVar6 = Utils_MoneyUtils__Create(0.0,0.0,0.0,0.0,-*(double *)(iVar13 + 0x30),0);
		    *(undefined4 *)(iVar8 + 0x14) = uVar6;
		  }
		  uVar6 = Gameplay_VortexCombat_View_VortexCombatView__ShowGameOver(param1,param2,param3,0);
		  piVar11 = *(int **)(param1 + 0x70);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar7 = func_ii_7508(StringLiteral_4378,1,0,1,0,0,0,0);
		  iVar8 = Mono_Security_ASN1Convert__ToOid
		                    (System_Collections_Generic_KeyValuePair_string__string____TypeInfo,3);
		  piVar12 = *(int **)(param3[0x1a] + 8);
		  iVar13 = *piVar12;
		  if (*(ushort *)(iVar13 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Gameplay_WorldAxis_Colossus_Combat_Model_IColossusCombatRewards_TypeInfo ==
		          *(int *)(*(int *)(iVar13 + 0x58) + uVar1 * 8)) {
		        puVar9 = (uint *)(iVar13 + *(int *)(*(int *)(iVar13 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80f8bfe3;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar13 + 0xb6) != uVar1);
		  }
		  puVar9 = (uint *)func_ii_1080(piVar12,
		                                Gameplay_WorldAxis_Colossus_Combat_Model_IColossusCombatRewards_TypeInfo
		                                ,0);
		code_r0x80f8bfe3:
		  uVar1 = 0;
		  uVar2 = CONCAT44(in_register_20000004,piVar12);
		  uVar4 = CONCAT44(in_register_20000014,puVar9[1]);
		  uVar10 = (**(code **)((ulonglong)*puVar9 * 4))(uVar2,uVar4);
		  uVar3 = (undefined4)((ulonglong)uVar2 >> 0x20);
		  uVar14 = (undefined4)((ulonglong)uVar4 >> 0x20);
		  local_4 = System_Linq_Enumerable__FirstOrDefault_KeyValuePair_object__object__
		                      (uVar10,Method_System_Linq_Enumerable_FirstOrDefault_int___);
		  iVar13 = func_ii_4443(&local_4,0);
		  local_18 = 0;
		  if (iVar13 == 0) {
		    iVar13 = StringLiteral_5;
		  }
		  System_Text_Formatting_StringView__get_IsEmpty
		            (&local_18,StringLiteral_21421,iVar13,
		             Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		  *(undefined8 *)(iVar8 + 0x10) = local_18;
		  piVar12 = *(int **)(param3[0x1a] + 8);
		  iVar13 = *piVar12;
		  if (*(ushort *)(iVar13 + 0xb6) != 0) {
		    do {
		      if (Gameplay_WorldAxis_Colossus_Combat_Model_IColossusCombatRewards_TypeInfo ==
		          *(int *)(*(int *)(iVar13 + 0x58) + uVar1 * 8)) {
		        puVar9 = (uint *)(*(int *)(*(int *)(iVar13 + 0x58) + uVar1 * 8 + 4) * 8 + iVar13 + 0xe0);
		        goto code_r0x80f8c0c5;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar13 + 0xb6) != uVar1);
		  }
		  puVar9 = (uint *)func_ii_1080(piVar12,
		                                Gameplay_WorldAxis_Colossus_Combat_Model_IColossusCombatRewards_TypeInfo
		                                ,4);
		code_r0x80f8c0c5:
		  uVar2 = CONCAT44(uVar3,piVar12);
		  uVar4 = CONCAT44(uVar14,puVar9[1]);
		  iVar13 = (**(code **)((ulonglong)*puVar9 * 4))(uVar2,uVar4);
		  local_10 = *(float8 *)(iVar13 + 0x30);
		  uVar1 = 0;
		  uVar3 = (undefined4)((ulonglong)uVar2 >> 0x20);
		  uVar14 = (undefined4)((ulonglong)uVar4 >> 0x20);
		  iVar13 = func_ii_7515(&local_10,0);
		  local_18 = 0;
		  if (iVar13 == 0) {
		    iVar13 = StringLiteral_5;
		  }
		  System_Text_Formatting_StringView__get_IsEmpty
		            (&local_18,StringLiteral_28348,iVar13,
		             Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		  *(undefined8 *)(iVar8 + 0x18) = local_18;
		  piVar12 = *(int **)(param3[0x1a] + 8);
		  iVar13 = *piVar12;
		  if (*(ushort *)(iVar13 + 0xb6) != 0) {
		    do {
		      if (Gameplay_WorldAxis_Colossus_Combat_Model_IColossusCombatRewards_TypeInfo ==
		          *(int *)(*(int *)(iVar13 + 0x58) + uVar1 * 8)) {
		        puVar9 = (uint *)(*(int *)(*(int *)(iVar13 + 0x58) + uVar1 * 8 + 4) * 8 + iVar13 + 0xd0);
		        goto code_r0x80f8c19e;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar13 + 0xb6) != uVar1);
		  }
		  puVar9 = (uint *)func_ii_1080(piVar12,
		                                Gameplay_WorldAxis_Colossus_Combat_Model_IColossusCombatRewards_TypeInfo
		                                ,2);
		code_r0x80f8c19e:
		  uVar2 = CONCAT44(uVar3,piVar12);
		  uVar4 = CONCAT44(uVar14,puVar9[1]);
		  iVar13 = (**(code **)((ulonglong)*puVar9 * 4))(uVar2,uVar4);
		  local_10 = (float8)-*(double *)(iVar13 + 0x30);
		  uVar3 = (undefined4)((ulonglong)uVar2 >> 0x20);
		  uVar14 = (undefined4)((ulonglong)uVar4 >> 0x20);
		  iVar13 = func_ii_7515(&local_10,0);
		  local_18 = 0;
		  if (iVar13 == 0) {
		    iVar13 = StringLiteral_5;
		  }
		  System_Text_Formatting_StringView__get_IsEmpty
		            (&local_18,StringLiteral_28349,iVar13,
		             Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		  *(undefined8 *)(iVar8 + 0x20) = local_18;
		  uVar7 = Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsRewardsTab_ClanWarsRewardsView__GetPlacesText
		                    (uVar7,iVar8,0);
		  iVar8 = *piVar11;
		  uVar2 = CONCAT44(uVar3,piVar11);
		  uVar4 = CONCAT44(uVar14,uVar7);
		  uVar5 = CONCAT44(in_register_20000024,*(undefined4 *)(iVar8 + 0x2d4));
		  (**(code **)((ulonglong)*(uint *)(iVar8 + 0x2d0) * 4))(uVar2,uVar4,uVar5);
		  uVar14 = (undefined4)((ulonglong)uVar5 >> 0x20);
		  uVar7 = (undefined4)((ulonglong)uVar2 >> 0x20);
		  uVar3 = (undefined4)((ulonglong)uVar4 >> 0x20);
		  uVar10 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                     (*(undefined4 *)(param1 + 0x74),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar10,(uint)*(byte *)(param2 + 8),0);
		  if (*(char *)(param2 + 8) != '\0') {
		    piVar11 = *(int **)(param1 + 0x78);
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar1 = 0;
		    uVar10 = func_ii_7508(StringLiteral_4377,1,0,1,0,0,0,0);
		    iVar8 = *piVar11;
		    uVar2 = CONCAT44(uVar7,piVar11);
		    uVar4 = CONCAT44(uVar3,uVar10);
		    (**(code **)((ulonglong)*(uint *)(iVar8 + 0x2d0) * 4))
		              (uVar2,uVar4,CONCAT44(uVar14,*(undefined4 *)(iVar8 + 0x2d4)));
		    uVar3 = (undefined4)((ulonglong)uVar4 >> 0x20);
		    uVar7 = (undefined4)((ulonglong)uVar2 >> 0x20);
		    uVar14 = *(undefined4 *)(param1 + 0x7c);
		    piVar11 = *(int **)(param3[0x1a] + 8);
		    iVar8 = *piVar11;
		    if (*(ushort *)(iVar8 + 0xb6) != 0) {
		      do {
		        if (Gameplay_WorldAxis_Colossus_Combat_Model_IColossusCombatRewards_TypeInfo ==
		            *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		          puVar9 = (uint *)(iVar8 + *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x80f8c30a;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		    }
		    puVar9 = (uint *)func_ii_1080(piVar11,
		                                  Gameplay_WorldAxis_Colossus_Combat_Model_IColossusCombatRewards_TypeInfo
		                                  ,0);
		code_r0x80f8c30a:
		    uVar2 = CONCAT44(uVar7,piVar11);
		    uVar4 = CONCAT44(uVar3,puVar9[1]);
		    uVar10 = (**(code **)((ulonglong)*puVar9 * 4))(uVar2,uVar4);
		    uVar7 = (undefined4)((ulonglong)uVar2 >> 0x20);
		    uVar3 = (undefined4)((ulonglong)uVar4 >> 0x20);
		    local_4 = System_Linq_Enumerable__FirstOrDefault_KeyValuePair_object__object__
		                        (uVar10,Method_System_Linq_Enumerable_FirstOrDefault_int___);
		    iVar8 = func_ii_4443(&local_4,0);
		    if (iVar8 == 0) {
		      iVar8 = StringLiteral_5;
		    }
		    UI_Rewards_IconValueRender__get_Value(uVar14,iVar8,0);
		    uVar14 = *(undefined4 *)(param1 + 0x7c);
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    piVar11 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar8 = *piVar11;
		    if (*(ushort *)(iVar8 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		          puVar9 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + iVar8 + 0x178);
		          goto code_r0x80f8c3ec;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		    }
		    puVar9 = (uint *)func_ii_1080(piVar11,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80f8c3ec:
		    uVar7 = (**(code **)((ulonglong)*puVar9 * 4))(CONCAT44(uVar7,piVar11),CONCAT44(uVar3,puVar9[1]))
		    ;
		    uVar7 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar7,0);
		    uVar7 = Core_Extensions_Dict_DictExt__GetServiceOptionDic(uVar7,StringLiteral_4380,0);
		    Gameplay_Portals_View_PortalsRewardView__SetTitle(uVar14,uVar7,0);
		  }
		  return uVar6;
		}
		*/

			return null;
		}

		// Token: 0x06001305 RID: 4869 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001305")]
		[Address(RVA = "0x64FB", Offset = "0x64FB", VA = "0x64FB", Slot = "8")]
		protected override CombatGameOverView ShowGameOverView(GameOverData gameOver, CombatModel model)
		{
		/* --- GHIDRA: ShowGameOverView ---
		void Gameplay_WorldAxis_Colossus_Combat_View_ColossusCombatView__ShowGameOverView
		               (undefined4 param1,undefined4 param2)
		
		{
		  Gameplay_VortexCombat_View_VortexCombatView__ShowGameOverView(param1,0);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06001306 RID: 4870 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001306")]
		[Address(RVA = "0x64FC", Offset = "0x64FC", VA = "0x64FC")]
		public ColossusCombatView()
		{
		}

		// Token: 0x04000A31 RID: 2609
		[Token(Token = "0x4000A31")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private TextMeshProUGUI _colossusRewardDescription;

		// Token: 0x04000A32 RID: 2610
		[Token(Token = "0x4000A32")]
		[FieldOffset(Offset = "0x74")]
		[SerializeField]
		private Transform _colossusScoresBlock;

		// Token: 0x04000A33 RID: 2611
		[Token(Token = "0x4000A33")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private TextMeshProUGUI _colossusScoresRewardBlockTitle;

		// Token: 0x04000A34 RID: 2612
		[Token(Token = "0x4000A34")]
		[FieldOffset(Offset = "0x7C")]
		[SerializeField]
		private IconValueRender _colossusScoresReward;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_ColossusRewardDescription ---
		void Gameplay_WorldAxis_Colossus_Combat_View_ColossusCombatView__get_ColossusRewardDescription
		               (undefined4 param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  int *param1_01;
		  int local_4;
		  
		  if (DAT_ram_00a58c18 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_ColossusCombatModel__ColossusCombatEvents__ColossusCombatController__ColossusCombatViewMediator__ColossusCombatView__get_Mediator__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_WorldAxis_Colossus_Combat_ColossusCombat_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_DefaultNamespace_SceneAppManager_TryGetSceneArgs_ICombat___);
		    DAT_ram_00a58c18 = '\x01';
		  }
		  local_4 = 0;
		  param1_00 = UI_Windows_PopupController__get_OpenedWindowsCount(0);
		  iVar1 = DefaultNamespace_SceneAppManager__LoadScene___Il2CppFullySharedGenericType_
		                    (param1_00,0xd,&local_4,
		                     Method_DefaultNamespace_SceneAppManager_TryGetSceneArgs_ICombat___);
		  if (iVar1 != 0) {
		    param1_01 = *(int **)(local_4 + 0xc);
		    if (param1_01 != (int *)0x0) {
		      if (((uint)*(byte *)(*param1_01 + 0xb8) <
		           (uint)*(byte *)(Gameplay_WorldAxis_Colossus_Combat_ColossusCombat_TypeInfo + 0xb8)) ||
		         (*(int *)(*(int *)(*param1_01 + 100) +
		                   (uint)*(byte *)(Gameplay_WorldAxis_Colossus_Combat_ColossusCombat_TypeInfo + 0xb8
		                                  ) * 4 + -4) !=
		          Gameplay_WorldAxis_Colossus_Combat_ColossusCombat_TypeInfo)) {
		        System_Activator__CreateInstance
		                  (param1_01,Gameplay_WorldAxis_Colossus_Combat_ColossusCombat_TypeInfo);
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
