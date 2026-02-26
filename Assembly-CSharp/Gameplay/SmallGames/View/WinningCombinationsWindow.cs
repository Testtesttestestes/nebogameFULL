using System;
using System.Collections.Generic;
using AssetContent;
using Il2CppDummyDll;
using Protocol.Dic;
using Protocol.SmallGames;
using TMPro;
using UI.Tabs;
using UI.Windows;
using UnityEngine;

namespace Gameplay.SmallGames.View
{
	// Token: 0x0200052A RID: 1322
	[Token(Token = "0x200052A")]
	public class WinningCombinationsWindow : ClosableBaseWindow<WinningCombinationsWindow.WinningCombinationsWindowArgs>
	{
		// Token: 0x170005BE RID: 1470
		// (get) Token: 0x06001F77 RID: 8055 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170005BE")]
		public override string WindowId
		{
			[Token(Token = "0x6001F77")]
			[Address(RVA = "0x70DC", Offset = "0x70DC", VA = "0x70DC", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001F78 RID: 8056 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F78")]
		[Address(RVA = "0x70DD", Offset = "0x70DD", VA = "0x70DD", Slot = "22")]
		protected override void OnShow(WinningCombinationsWindow.WinningCombinationsWindowArgs args)
		{
		/* --- GHIDRA: OnShow ---
		int * Gameplay_SmallGames_View_WinningCombinationsWindow__OnShow
		                (undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int *piVar3;
		  int iVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a58291 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseWindow_WinningCombinationsWindow_WinningCombinationsWindowArgs__get_WindowArgs__
		              );
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UI_Tabs_TabBarItemData___TypeInfo);
		    Mono_Security_ASN1__get_Item(&UI_Tabs_TabBarItemData_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_13843);
		    Mono_Security_ASN1__get_Item(&StringLiteral_13837);
		    DAT_ram_00a58291 = '\x01';
		  }
		  uVar5 = **(undefined4 **)(DAT_ram_00a66978 + 0x5c);
		  iVar1 = func_ii_8093(param1,
		                       Method_UI_Windows_BaseWindow_WinningCombinationsWindow_WinningCombinationsWindowArgs__get_WindowArgs__
		                      );
		  uVar2 = StringLiteral_13837;
		  if ((*(int *)(iVar1 + 0x1c) != 1) &&
		     (iVar1 = func_ii_8093(param1,
		                           Method_UI_Windows_BaseWindow_WinningCombinationsWindow_WinningCombinationsWindowArgs__get_WindowArgs__
		                          ), uVar2 = StringLiteral_13843, *(int *)(iVar1 + 0x1c) != 2)) {
		    uVar2 = uVar5;
		  }
		  iVar1 = unnamed_function_1417(UI_Tabs_TabBarItemData_TypeInfo);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(uVar2,1,0,1,0,0,0,0);
		  *(undefined4 *)(iVar1 + 0x10) = uVar2;
		  piVar3 = (int *)Mono_Security_ASN1Convert__ToOid(UI_Tabs_TabBarItemData___TypeInfo,1);
		  iVar4 = func_ii_1082(iVar1,*(undefined4 *)(*piVar3 + 0x20));
		  if (iVar4 == 0) {
		    uVar2 = func_ii_1083();
		    func_ii_1050(uVar2,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  piVar3[4] = iVar1;
		  return piVar3;
		}
		*/

		}

		// Token: 0x06001F79 RID: 8057 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001F79")]
		[Address(RVA = "0x70DE", Offset = "0x70DE", VA = "0x70DE")]
		private TabBarItemData[] ConstructTabBarDataArray()
		{
		/* --- GHIDRA: ConstructTabBarDataArray ---
		void Gameplay_SmallGames_View_WinningCombinationsWindow__ConstructTabBarDataArray
		               (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a58292 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_ClosableBaseWindow_WinningCombinationsWindow_WinningCombinationsWindowArgs___ctor__
		              );
		    Mono_Security_ASN1__get_Item(&AssetContent_GameRawImage___TypeInfo);
		    DAT_ram_00a58292 = '\x01';
		  }
		  uVar1 = Mono_Security_ASN1Convert__ToOid(AssetContent_GameRawImage___TypeInfo,3);
		  *(undefined4 *)(param1 + 0x48) = uVar1;
		  UI_MonoBehaviourWithStates_ClientStateChangedDelegate___Il2CppFullySharedGenericStructType___Invoke
		            (param1,
		             Method_UI_Windows_ClosableBaseWindow_WinningCombinationsWindow_WinningCombinationsWindowArgs___ctor__
		            );
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06001F7A RID: 8058 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F7A")]
		[Address(RVA = "0x70DF", Offset = "0x70DF", VA = "0x70DF")]
		public WinningCombinationsWindow()
		{
		}

		// Token: 0x04001127 RID: 4391
		[Token(Token = "0x4001127")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/SmallGames/WinningCombinationsWindow";

		// Token: 0x04001128 RID: 4392
		[Token(Token = "0x4001128")]
		private const string DIAMOND_COMBINATIONS = "SMALL_GAMES/DIAMOND_COMBINATIONS";

		// Token: 0x04001129 RID: 4393
		[Token(Token = "0x4001129")]
		private const string ONYX_COMBINATIONS = "SMALL_GAMES/ONYX_COMBINATIONS";

		// Token: 0x0400112A RID: 4394
		[Token(Token = "0x400112A")]
		private const int CLOVER_ICON_ID = 1;

		// Token: 0x0400112B RID: 4395
		[Token(Token = "0x400112B")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private WinningCombinationRow _rowPrefab;

		// Token: 0x0400112C RID: 4396
		[Token(Token = "0x400112C")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private RectTransform _contentParent;

		// Token: 0x0400112D RID: 4397
		[Token(Token = "0x400112D")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private TabBar _tabBar;

		// Token: 0x0400112E RID: 4398
		[Token(Token = "0x400112E")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameRawImage[] _cloverIcons;

		// Token: 0x0400112F RID: 4399
		[Token(Token = "0x400112F")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private TextMeshProUGUI _bottomAnnotation;

		// Token: 0x0200052B RID: 1323
		[Token(Token = "0x200052B")]
		public class WinningCombinationsWindowArgs : BaseWindowArgs
		{
			// Token: 0x06001F7B RID: 8059 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001F7B")]
			[Address(RVA = "0x70E0", Offset = "0x70E0", VA = "0x70E0")]
			public WinningCombinationsWindowArgs()
			{
			}

			// Token: 0x04001130 RID: 4400
			[Token(Token = "0x4001130")]
			[FieldOffset(Offset = "0x18")]
			public Dictionary<uint, WinCombinationDic> WinCombinations;

			// Token: 0x04001131 RID: 4401
			[Token(Token = "0x4001131")]
			[FieldOffset(Offset = "0x1C")]
			public SlotMachineType SlotMachineType;

			// Token: 0x04001132 RID: 4402
			[Token(Token = "0x4001132")]
			[FieldOffset(Offset = "0x20")]
			public SlotMachineDic SlotMachineDic;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_WindowId ---
		void Gameplay_SmallGames_View_WinningCombinationsWindow__get_WindowId
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 in_register_20000004;
		  undefined4 in_register_20000014;
		  uint *puVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int iVar5;
		  undefined4 uVar6;
		  undefined4 uVar7;
		  int *piVar8;
		  int iVar9;
		  ulonglong uVar10;
		  uint uVar11;
		  int local_28;
		  undefined8 *local_24;
		  undefined4 local_20;
		  int local_1c;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a58290 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseWindow_WinningCombinationsWindow_WinningCombinationsWindowArgs__get_WindowArgs__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_ClosableBaseWindow_WinningCombinationsWindow_WinningCombinationsWindowArgs__OnShow__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__string__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__string___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__WinCombinationDic__get_Values__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Dictionary_string__string__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__WinCombinationDic__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__WinCombinationDic__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__WinCombinationDic__get_Current__
		              );
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Object_Instantiate_WinningCombinationRow___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_TimeSpan_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_uint__WinCombinationDic__GetEnumerator__
		              );
		    Mono_Security_ASN1__get_Item(&StringLiteral_21978);
		    Mono_Security_ASN1__get_Item(&StringLiteral_24649);
		    Mono_Security_ASN1__get_Item(&StringLiteral_13840);
		    DAT_ram_00a58290 = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  local_18 = 0;
		  local_1c = 0;
		  local_20 = 0;
		  func_ii_7769(param1,param2,
		               Method_UI_Windows_ClosableBaseWindow_WinningCombinationsWindow_WinningCombinationsWindowArgs__OnShow__
		              );
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar11 = 0;
		  piVar8 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar9 = *piVar8;
		  if (*(ushort *)(iVar9 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar9 + 0x58) + uVar11 * 8)) {
		        puVar1 = (uint *)(*(int *)(*(int *)(iVar9 + 0x58) + uVar11 * 8 + 4) * 8 + iVar9 + 0x178);
		        goto code_r0x80ec4b8d;
		      }
		      uVar11 = uVar11 + 1;
		    } while (*(ushort *)(iVar9 + 0xb6) != uVar11);
		  }
		  puVar1 = (uint *)func_ii_1080(piVar8,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80ec4b8d:
		  uVar2 = (**(code **)((ulonglong)*puVar1 * 4))
		                    (CONCAT44(in_register_20000004,piVar8),CONCAT44(in_register_20000014,puVar1[1]))
		  ;
		  uVar2 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar2,0);
		  uVar3 = System_Collections_Generic_Dictionary_int__object___TryAdd
		                    (*(undefined4 *)(param2 + 0x18),
		                     Method_System_Collections_Generic_Dictionary_uint__WinCombinationDic__get_Values__
		                    );
		  System_Collections_Generic_Dictionary_Int32Enum__object___get_Values
		            (&local_18,uVar3,
		             Method_System_Collections_Generic_Dictionary_ValueCollection_uint__WinCombinationDic__GetEnumerator__
		            );
		  local_28 = 0;
		  local_24 = &local_18;
		  iVar9 = 0;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar4 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x25b,&local_18,
		                       Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__WinCombinationDic__MoveNext__
		                      );
		    iVar5 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar5 == 1) {
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80ec4d28:
		      iVar9 = global_1;
		      iVar5 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar9 == iVar5) {
		        piVar8 = (int *)import::env::__cxa_begin_catch(uVar3);
		        iVar5 = *piVar8;
		        DAT_ram_009d3e38 = 0;
		        local_28 = iVar5;
		        import::env::invoke_v(0x123);
		        iVar9 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar9 != 1) {
		          if (iVar5 != 0) {
		            System_Data_DataSet__ValidateLocaleConstraint(iVar5);
		            do {
		              halt_trap();
		            } while( true );
		          }
		code_r0x80ec4d7e:
		          DAT_ram_009d3e38 = 0;
		          iVar9 = 0;
		          iVar5 = *(int *)(param1 + 0x48);
		          if (0 < *(int *)(iVar5 + 0xc)) {
		            do {
		              uVar6 = *(undefined4 *)(iVar5 + iVar9 * 4 + 0x10);
		              uVar3 = Core_Extensions_Dict_DictExt__GetCraftSchemeDic(uVar2,1,0);
		              uVar3 = Core_Extensions_Dict_SaleMarkersDicExt__GetAprAssetId(uVar3,0);
		              Core_Extensions_Dict_PortalDicExt__GetCurrencyIcon60x66(uVar6,uVar3,0);
		              iVar9 = iVar9 + 1;
		              local_1c = iVar9;
		            } while (iVar9 < *(int *)(iVar5 + 0xc));
		          }
		          uVar2 = Gameplay_SmallGames_View_WinningCombinationsWindow__OnShow(param1,iVar9);
		          UI_Tabs_TabBar__HandleSelected(*(undefined4 *)(param1 + 0x44),uVar2,0);
		          Gameplay_GameEvents_Model_GameEventData__get_ContainsArtifactRewards
		                    (*(undefined4 *)(param1 + 0x44),0,0,0);
		          iVar9 = func_ii_8093(param1,
		                               Method_UI_Windows_BaseWindow_WinningCombinationsWindow_WinningCombinationsWindowArgs__get_WindowArgs__
		                              );
		          uVar10 = *(ulonglong *)(*(int *)(iVar9 + 0x20) + 0x20);
		          if (*(int *)(System_TimeSpan_TypeInfo + 0x74) == 0) {
		            func_ii_306000(System_TimeSpan_TypeInfo);
		          }
		          local_8 = func_ii_7125((double)uVar10,0);
		          uVar2 = *(undefined4 *)(param1 + 0x4c);
		          if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		            func_ii_306000(Core_GameLocalization_TypeInfo);
		          }
		          uVar3 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_13840,1,0,1,0,0,0,0);
		          uVar6 = unnamed_function_1417
		                            (System_Collections_Generic_Dictionary_string__string__TypeInfo);
		          System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		                    (uVar6,Method_System_Collections_Generic_Dictionary_string__string___ctor__);
		          iVar9 = func_ii_8093(param1,
		                               Method_UI_Windows_BaseWindow_WinningCombinationsWindow_WinningCombinationsWindowArgs__get_WindowArgs__
		                              );
		          local_20 = *(undefined4 *)(*(int *)(iVar9 + 0x20) + 0x1c);
		          uVar7 = Protocol_Combat_ProtoPlayerActionEvt___ctor(&local_20,0);
		          System_Reflection_FieldInfo__get_IsStatic
		                    (uVar6,StringLiteral_21978,uVar7,
		                     Method_System_Collections_Generic_Dictionary_string__string__Add__);
		          local_1c = System_TimeSpan__get_Days(&local_8,0);
		          uVar7 = func_ii_4443(&local_1c,0);
		          System_Reflection_FieldInfo__get_IsStatic
		                    (uVar6,StringLiteral_24649,uVar7,
		                     Method_System_Collections_Generic_Dictionary_string__string__Add__);
		          uVar3 = Core_GameLocalization__GetTranslation(uVar3,uVar6,0);
		          UnityEngine_Component__GetComponentInChildren_object_(uVar2,uVar3,0);
		          return;
		        }
		        uVar3 = import::env::__cxa_find_matching_catch_2();
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x13b,&local_28);
		      iVar9 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar9 == 1) {
		        import::env::__cxa_find_matching_catch_3(0);
		        unnamed_function_937();
		        do {
		          halt_trap();
		        } while( true );
		      }
		      import::env::__resumeException(uVar3);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    if (iVar4 == 0) goto code_r0x80ec4d7e;
		    uVar6 = *(undefined4 *)(param1 + 0x40);
		    uVar7 = *(undefined4 *)(param1 + 0x3c);
		    uVar3 = local_10._4_4_;
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi
		                (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,UnityEngine_Object_TypeInfo
		                );
		      iVar5 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar5 == 1) {
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80ec4d28;
		      }
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar6 = import::env::invoke_iiii
		                      (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x2ce,uVar7,uVar6,
		                       Method_UnityEngine_Object_Instantiate_WinningCombinationRow___);
		    iVar5 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar5 == 1) {
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80ec4d28;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viiii
		              (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x13a,uVar6,uVar3,iVar9,iVar9);
		    iVar5 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar5 == 1) {
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80ec4d28;
		    }
		    iVar9 = iVar9 + 1;
		  } while( true );
		}
		*/

}
