using System;
using Gameplay.School.Model;
using Il2CppDummyDll;
using Protocol.Dic;
using UnityEngine;

namespace UI.Windows.Buildings.MageSchoolWindow
{
	// Token: 0x020002C1 RID: 705
	[Token(Token = "0x20002C1")]
	public class SpellUpgradeInfoDialogWindow : BaseDialogWindow<SpellUpgradeInfoDialogWindow.SpellUpgradeInfoDialogWindowArgs>
	{
		// Token: 0x1700026F RID: 623
		// (get) Token: 0x06001099 RID: 4249 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700026F")]
		public override string WindowId
		{
			[Token(Token = "0x6001099")]
			[Address(RVA = "0x6296", Offset = "0x6296", VA = "0x6296", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600109A RID: 4250 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600109A")]
		[Address(RVA = "0x6297", Offset = "0x6297", VA = "0x6297", Slot = "28")]
		protected override void HandleContent()
		{
		/* --- GHIDRA: HandleContent ---
		undefined4
		UI_Windows_Buildings_MageSchoolWindow_SpellUpgradeInfoDialogWindow__HandleContent
		          (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  uint uVar1;
		  int param1_00;
		  undefined4 uVar2;
		  uint *puVar3;
		  int *piVar4;
		  int iVar5;
		  
		  if (DAT_ram_00a58ae2 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_PopupController_Show_SpellUpgradeInfoDialogWindow___);
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_Buildings_MageSchoolWindow_SpellUpgradeInfoDialogWindow_SpellUpgradeInfoDialogWindowArgs_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&StringLiteral_12648);
		    DAT_ram_00a58ae2 = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (
		                        UI_Windows_Buildings_MageSchoolWindow_SpellUpgradeInfoDialogWindow_SpellUpgradeInfoDialogWindowArgs_TypeInfo
		                        );
		  if (DAT_ram_00a58ae5 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_SpellUpgradeInfoDialogWindow_SpellUpgradeInfoDialogWindowArgs___ctor__
		              );
		    DAT_ram_00a58ae5 = '\x01';
		  }
		  UnityEngine_UIElements_BaseCompositeField___Il2CppFullySharedGenericType__object____Il2CppFullySharedGenericType___UpdateMixedValueContent
		            (param1_00,
		             Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_SpellUpgradeInfoDialogWindow_SpellUpgradeInfoDialogWindowArgs___ctor__
		            );
		  *(undefined4 *)(param1_00 + 0x34) = param3;
		  *(undefined4 *)(param1_00 + 0x30) = param2;
		  *(int *)(param1_00 + 0x2c) = param1;
		  uVar2 = Core_Extensions_Dict_SpellDicExt__GetAnimationOnAvatarCanvasAssetId
		                    (*(undefined4 *)(param1 + 0xc),0);
		  *(undefined4 *)(param1_00 + 0x1c) = 0;
		  *(undefined4 *)(param1_00 + 0x18) = uVar2;
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar4 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xe0);
		        goto code_r0x80f7365c;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x80f7365c:
		  piVar4 = (int *)(**(code **)((ulonglong)*puVar3 * 4))(piVar4,puVar3[1]);
		  uVar1 = 0;
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xe8);
		        goto code_r0x80f736de;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar4,Core_Application_IApp_TypeInfo,5);
		code_r0x80f736de:
		  uVar2 = (**(code **)((ulonglong)*puVar3 * 4))(piVar4,puVar3[1]);
		  uVar2 = Gameplay_Antiq_View_GroupReviewWindow_WindowArgs___ctor
		                    (uVar2,StringLiteral_12648,param1_00,
		                     Method_UI_Windows_PopupController_Show_SpellUpgradeInfoDialogWindow___);
		  return uVar2;
		}
		*/

		}

		// Token: 0x0600109B RID: 4251 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600109B")]
		[Address(RVA = "0x6298", Offset = "0x6298", VA = "0x6298")]
		public static SpellUpgradeInfoDialogWindow Show(SchoolSpellData spellData, SpellDic nextSpellDic, SpellLevelDic nextSpellLevelDic)
		{
		/* --- GHIDRA: Show ---
		void UI_Windows_Buildings_MageSchoolWindow_SpellUpgradeInfoDialogWindow__Show
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a58ae4 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_SpellUpgradeInfoDialogWindow_SpellUpgradeInfoDialogWindowArgs___ctor__
		              );
		    DAT_ram_00a58ae4 = '\x01';
		  }
		  UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_object____ctor
		            (param1,
		             Method_UI_Windows_BaseDialogWindow_SpellUpgradeInfoDialogWindow_SpellUpgradeInfoDialogWindowArgs___ctor__
		            );
		  return;
		}
		*/

		/* --- GHIDRA: Show ---
		void UI_Windows_Buildings_MageSchoolWindow_SpellUpgradeInfoDialogWindow__Show
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a58ae4 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_SpellUpgradeInfoDialogWindow_SpellUpgradeInfoDialogWindowArgs___ctor__
		              );
		    DAT_ram_00a58ae4 = '\x01';
		  }
		  UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_object____ctor
		            (param1,
		             Method_UI_Windows_BaseDialogWindow_SpellUpgradeInfoDialogWindow_SpellUpgradeInfoDialogWindowArgs___ctor__
		            );
		  return;
		}
		*/

			return null;
		}

		// Token: 0x0600109C RID: 4252 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600109C")]
		[Address(RVA = "0x6299", Offset = "0x6299", VA = "0x6299")]
		public static SpellUpgradeInfoDialogWindow Show(SchoolSpellData spellData)
		{
			return null;
		}

		// Token: 0x0600109D RID: 4253 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600109D")]
		[Address(RVA = "0x629A", Offset = "0x629A", VA = "0x629A")]
		public SpellUpgradeInfoDialogWindow()
		{
		/* --- GHIDRA: .ctor ---
		void UI_Windows_Buildings_MageSchoolWindow_SpellUpgradeInfoDialogWindow___ctor
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a58ae5 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_SpellUpgradeInfoDialogWindow_SpellUpgradeInfoDialogWindowArgs___ctor__
		              );
		    DAT_ram_00a58ae5 = '\x01';
		  }
		  UnityEngine_UIElements_BaseCompositeField___Il2CppFullySharedGenericType__object____Il2CppFullySharedGenericType___UpdateMixedValueContent
		            (param1,
		             Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_SpellUpgradeInfoDialogWindow_SpellUpgradeInfoDialogWindowArgs___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x04000895 RID: 2197
		[Token(Token = "0x4000895")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/MageSchool/SpellUpgradeInfoDialogWindow";

		// Token: 0x04000896 RID: 2198
		[Token(Token = "0x4000896")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private SpellDescriptionGroup _currentDescription;

		// Token: 0x04000897 RID: 2199
		[Token(Token = "0x4000897")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private SpellDescriptionGroup _nextDescription;

		// Token: 0x04000898 RID: 2200
		[Token(Token = "0x4000898")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _spacer;

		// Token: 0x020002C2 RID: 706
		[Token(Token = "0x20002C2")]
		public class SpellUpgradeInfoDialogWindowArgs : BaseDialogWindow<SpellUpgradeInfoDialogWindow.SpellUpgradeInfoDialogWindowArgs>.BaseDialogWindowArgs
		{
			// Token: 0x0600109E RID: 4254 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600109E")]
			[Address(RVA = "0x629B", Offset = "0x629B", VA = "0x629B")]
			public SpellUpgradeInfoDialogWindowArgs()
			{
			}

			// Token: 0x04000899 RID: 2201
			[Token(Token = "0x4000899")]
			[FieldOffset(Offset = "0x2C")]
			public SchoolSpellData SpellData;

			// Token: 0x0400089A RID: 2202
			[Token(Token = "0x400089A")]
			[FieldOffset(Offset = "0x30")]
			public SpellDic NextSpellDic;

			// Token: 0x0400089B RID: 2203
			[Token(Token = "0x400089B")]
			[FieldOffset(Offset = "0x34")]
			public SpellLevelDic NextSpellLevelDic;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_WindowId ---
		void UI_Windows_Buildings_MageSchoolWindow_SpellUpgradeInfoDialogWindow__get_WindowId
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  undefined4 param6;
		  undefined8 uVar4;
		  int *param1_00;
		  int param2_00;
		  int *piVar5;
		  undefined4 uVar6;
		  undefined4 param3;
		  int iVar7;
		  undefined8 local_10;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a58ae1 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_SpellUpgradeInfoDialogWindow_SpellUpgradeInfoDialogWindowArgs__HandleContent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseWindow_SpellUpgradeInfoDialogWindow_SpellUpgradeInfoDialogWindowArgs__get_WindowArgs__
		              );
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_KeyValuePair_string__string____TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_10310);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28217);
		    Mono_Security_ASN1__get_Item(&StringLiteral_13731);
		    DAT_ram_00a58ae1 = '\x01';
		  }
		  local_4 = 0;
		  UI_Windows_BaseDialogWindow_object___HandleButtons
		            (param1,
		             Method_UI_Windows_BaseDialogWindow_SpellUpgradeInfoDialogWindow_SpellUpgradeInfoDialogWindowArgs__HandleContent__
		            );
		  iVar1 = func_ii_8093(param1,
		                       Method_UI_Windows_BaseWindow_SpellUpgradeInfoDialogWindow_SpellUpgradeInfoDialogWindowArgs__get_WindowArgs__
		                      );
		  param1_00 = *(int **)(iVar1 + 0x2c);
		  iVar1 = func_ii_8093(param1,
		                       Method_UI_Windows_BaseWindow_SpellUpgradeInfoDialogWindow_SpellUpgradeInfoDialogWindowArgs__get_WindowArgs__
		                      );
		  iVar7 = **(int **)(iVar1 + 0x2c);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(iVar7 + 0xf0) * 4))
		                    (*(int **)(iVar1 + 0x2c),*(undefined4 *)(iVar7 + 0xf4));
		  iVar7 = func_ii_8093(param1,
		                       Method_UI_Windows_BaseWindow_SpellUpgradeInfoDialogWindow_SpellUpgradeInfoDialogWindowArgs__get_WindowArgs__
		                      );
		  iVar7 = *(int *)(iVar7 + 0x30);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (*(undefined4 *)(param1 + 0x58),(uint)(iVar1 != 0 && iVar7 != 0),0);
		  uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x50),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar2,(uint)(iVar1 != 0),0);
		  uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x54),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar2,(uint)(iVar7 != 0),0);
		  if (iVar1 != 0) {
		    piVar5 = *(int **)(*(int *)(param1 + 0x50) + 0x10);
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_10310,1,0,1,0,0,0,0);
		    iVar1 = Mono_Security_ASN1Convert__ToOid
		                      (System_Collections_Generic_KeyValuePair_string__string____TypeInfo,1);
		    local_4 = (**(code **)((ulonglong)*(uint *)(*param1_00 + 0xf0) * 4))
		                        (param1_00,*(undefined4 *)(*param1_00 + 0xf4));
		    uVar3 = Protocol_Combat_ProtoPlayerActionEvt___ctor(&local_4,0);
		    local_10 = 0;
		    System_Text_Formatting_StringView__get_IsEmpty
		              (&local_10,StringLiteral_28217,uVar3,
		               Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		    *(undefined8 *)(iVar1 + 0x10) = local_10;
		    uVar2 = Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsRewardsTab_ClanWarsRewardsView__GetPlacesText
		                      (uVar2,iVar1,0);
		    iVar1 = *piVar5;
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0x2d0) * 4))
		              (piVar5,uVar2,*(undefined4 *)(iVar1 + 0x2d4));
		    iVar1 = param1_00[4];
		    param2_00 = param1_00[3];
		    uVar3 = *(undefined4 *)(param1 + 0x50);
		    uVar2 = func_ii_10810(param1_00,0);
		    if (*(int *)(Core_Money_Money_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Money_Money_TypeInfo);
		    }
		    uVar2 = Core_Money_Money__op_Explicit(uVar2,0);
		    uVar4 = Core_Data_Spells_SpellData__get_Level(param1_00,0);
		    uVar6 = (**(code **)((ulonglong)*(uint *)(*param1_00 + 0xe0) * 4))
		                      (param1_00,*(undefined4 *)(*param1_00 + 0xe4));
		    UI_Windows_Buildings_MageSchoolWindow_SpellDescriptionGroup__get_Title
		              (uVar3,param2_00,iVar1,uVar2,uVar4,uVar6,param1);
		  }
		  if (iVar7 != 0) {
		    piVar5 = *(int **)(*(int *)(param1 + 0x54) + 0x10);
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_13731,1,0,1,0,0,0,0);
		    iVar1 = Mono_Security_ASN1Convert__ToOid
		                      (System_Collections_Generic_KeyValuePair_string__string____TypeInfo,1);
		    iVar7 = func_ii_8093(param1,
		                         Method_UI_Windows_BaseWindow_SpellUpgradeInfoDialogWindow_SpellUpgradeInfoDialogWindowArgs__get_WindowArgs__
		                        );
		    local_4 = *(undefined4 *)(*(int *)(iVar7 + 0x34) + 0x10);
		    uVar3 = Protocol_Combat_ProtoPlayerActionEvt___ctor(&local_4,0);
		    local_10 = 0;
		    System_Text_Formatting_StringView__get_IsEmpty
		              (&local_10,StringLiteral_28217,uVar3,
		               Method_System_Collections_Generic_KeyValuePair_string__string___ctor__);
		    *(undefined8 *)(iVar1 + 0x10) = local_10;
		    uVar2 = Gameplay_Clans_Office_View_ClanWarsTab_ClanWarsRewardsTab_ClanWarsRewardsView__GetPlacesText
		                      (uVar2,iVar1,0);
		    iVar1 = *piVar5;
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0x2d0) * 4))
		              (piVar5,uVar2,*(undefined4 *)(iVar1 + 0x2d4));
		    uVar3 = *(undefined4 *)(param1 + 0x54);
		    iVar1 = func_ii_8093(param1,
		                         Method_UI_Windows_BaseWindow_SpellUpgradeInfoDialogWindow_SpellUpgradeInfoDialogWindowArgs__get_WindowArgs__
		                        );
		    uVar6 = *(undefined4 *)(iVar1 + 0x30);
		    iVar1 = func_ii_8093(param1,
		                         Method_UI_Windows_BaseWindow_SpellUpgradeInfoDialogWindow_SpellUpgradeInfoDialogWindowArgs__get_WindowArgs__
		                        );
		    param3 = *(undefined4 *)(iVar1 + 0x34);
		    uVar2 = Gameplay_School_Model_SchoolSpellData__get_IsMaxLevel(param1_00,0);
		    if (*(int *)(Core_Money_Money_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Money_Money_TypeInfo);
		    }
		    uVar2 = Core_Money_Money__op_Explicit(uVar2,0);
		    uVar4 = Gameplay_School_Model_SchoolSpellData__get_PriceOfUseNext(param1_00,0);
		    param6 = (**(code **)((ulonglong)*(uint *)(*param1_00 + 0xe0) * 4))
		                       (param1_00,*(undefined4 *)(*param1_00 + 0xe4));
		    UI_Windows_Buildings_MageSchoolWindow_SpellDescriptionGroup__get_Title
		              (uVar3,uVar6,param3,uVar2,uVar4,param6,param3);
		  }
		  return;
		}
		*/

}
