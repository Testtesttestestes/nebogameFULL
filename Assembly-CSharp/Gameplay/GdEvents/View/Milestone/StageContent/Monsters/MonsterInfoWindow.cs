using System;
using AssetContent;
using Core.Data;
using Core.Dict;
using Il2CppDummyDll;
using UI.Elements.RightPanel;
using UI.Elements.RightPanel.TitledList;
using UI.Windows;
using UnityEngine;

namespace Gameplay.GdEvents.View.Milestone.StageContent.Monsters
{
	// Token: 0x02000725 RID: 1829
	[Token(Token = "0x2000725")]
	public class MonsterInfoWindow : ClosableBaseWindow<MonsterInfoWindow.MonsterInfoWindowArgs>
	{
		// Token: 0x17000856 RID: 2134
		// (get) Token: 0x06002BC2 RID: 11202 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000856")]
		public override string WindowId
		{
			[Token(Token = "0x6002BC2")]
			[Address(RVA = "0x7C53", Offset = "0x7C53", VA = "0x7C53", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002BC3 RID: 11203 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BC3")]
		[Address(RVA = "0x7C54", Offset = "0x7C54", VA = "0x7C54", Slot = "22")]
		protected override void OnShow(MonsterInfoWindow.MonsterInfoWindowArgs args)
		{
		/* --- GHIDRA: OnShow ---
		void Gameplay_GdEvents_View_Milestone_StageContent_Monsters_MonsterInfoWindow__OnShow
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5a274 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_ClosableBaseWindow_MonsterInfoWindow_MonsterInfoWindowArgs___ctor__
		              );
		    DAT_ram_00a5a274 = '\x01';
		  }
		  UI_MonoBehaviourWithStates_ClientStateChangedDelegate___Il2CppFullySharedGenericStructType___Invoke
		            (param1,
		             Method_UI_Windows_ClosableBaseWindow_MonsterInfoWindow_MonsterInfoWindowArgs___ctor__);
		  return;
		}
		*/

		}

		// Token: 0x06002BC4 RID: 11204 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BC4")]
		[Address(RVA = "0x7C55", Offset = "0x7C55", VA = "0x7C55")]
		public MonsterInfoWindow()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_GdEvents_View_Milestone_StageContent_Monsters_MonsterInfoWindow___ctor
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  UI_Windows_BaseWindowArgs__Dispose(param1,0);
		  *(undefined4 *)(param1 + 0x18) = param3;
		  *(undefined4 *)(param1 + 0x1c) = param2;
		  return;
		}
		*/

		}

		// Token: 0x040017F2 RID: 6130
		[Token(Token = "0x40017F2")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/GdEvents/MonsterInfoWindow";

		// Token: 0x040017F3 RID: 6131
		[Token(Token = "0x40017F3")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private TitleWithLevel _windowTitle;

		// Token: 0x040017F4 RID: 6132
		[Token(Token = "0x40017F4")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameAssetViewRawImage _monsterAssetView;

		// Token: 0x040017F5 RID: 6133
		[Token(Token = "0x40017F5")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private TitledList _titledList;

		// Token: 0x040017F6 RID: 6134
		[Token(Token = "0x40017F6")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Transform _background;

		// Token: 0x040017F7 RID: 6135
		[Token(Token = "0x40017F7")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private Transform _bossBackground;

		// Token: 0x040017F8 RID: 6136
		[Token(Token = "0x40017F8")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Transform _pedestal;

		// Token: 0x040017F9 RID: 6137
		[Token(Token = "0x40017F9")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private Transform _bossPedestal;

		// Token: 0x02000726 RID: 1830
		[Token(Token = "0x2000726")]
		public class MonsterInfoWindowArgs : BaseWindowArgs
		{
			// Token: 0x06002BC5 RID: 11205 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002BC5")]
			[Address(RVA = "0x7C56", Offset = "0x7C56", VA = "0x7C56")]
			public MonsterInfoWindowArgs(IDictProvider dictProvider, MonsterData monster)
			{
			}

			// Token: 0x040017FA RID: 6138
			[Token(Token = "0x40017FA")]
			[FieldOffset(Offset = "0x18")]
			public readonly MonsterData Monster;

			// Token: 0x040017FB RID: 6139
			[Token(Token = "0x40017FB")]
			[FieldOffset(Offset = "0x1C")]
			public readonly IDictProvider DictProvider;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_WindowId ---
		void Gameplay_GdEvents_View_Milestone_StageContent_Monsters_MonsterInfoWindow__get_WindowId
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int param2_00;
		  uint *puVar1;
		  undefined4 uVar2;
		  uint uVar3;
		  int *param1_00;
		  int iVar4;
		  undefined4 uVar5;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a5a273 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_AprDic__uint__get_Data__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_ClosableBaseWindow_MonsterInfoWindow_MonsterInfoWindowArgs__OnShow__
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Any_BossTypeDic___);
		    Mono_Security_ASN1__get_Item(&System_Func_BossTypeDic__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Elements_RightPanel_TitledList_Elements_TextTitledListElement_TextTitledListElementArgs_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&UI_Elements_RightPanel_TitledList_TitledListArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GdEvents_View_Milestone_StageContent_Monsters_MonsterInfoWindow___c__DisplayClass11_0__OnShow_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_GdEvents_View_Milestone_StageContent_Monsters_MonsterInfoWindow___c__DisplayClass11_0_TypeInfo
		              );
		    DAT_ram_00a5a273 = '\x01';
		  }
		  param2_00 = unnamed_function_1417
		                        (
		                        Gameplay_GdEvents_View_Milestone_StageContent_Monsters_MonsterInfoWindow___c__DisplayClass11_0_TypeInfo
		                        );
		  *(undefined4 *)(param2_00 + 8) = param2;
		  func_ii_7769(param1,param2,
		               Method_UI_Windows_ClosableBaseWindow_MonsterInfoWindow_MonsterInfoWindowArgs__OnShow__
		              );
		  param1_00 = *(int **)(*(int *)(param2_00 + 8) + 0x1c);
		  iVar4 = *param1_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar3 = 0;
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar3 * 8)) {
		        puVar1 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar3 * 8 + 4) * 8 + iVar4 + 0xd0);
		        goto code_r0x811f0dcf;
		      }
		      uVar3 = uVar3 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar3);
		  }
		  puVar1 = (uint *)func_ii_1080(param1_00,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x811f0dcf:
		  iVar4 = (**(code **)((ulonglong)*puVar1 * 4))(param1_00,puVar1[1]);
		  uVar5 = *(undefined4 *)(iVar4 + 0x158);
		  uVar2 = unnamed_function_1417(System_Func_BossTypeDic__bool__TypeInfo);
		  System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		            (uVar2,param2_00,
		             Method_Gameplay_GdEvents_View_Milestone_StageContent_Monsters_MonsterInfoWindow___c__DisplayClass11_0__OnShow_b__0__
		             ,0);
		  uVar3 = Newtonsoft_Json_Utilities_ReflectionUtils__IsOverridenGenericMember
		                    (uVar5,uVar2,Method_System_Linq_Enumerable_Any_BossTypeDic___);
		  uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x48),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar2,uVar3 ^ 1,0);
		  uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x4c),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar2,uVar3,0);
		  uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x50),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar2,uVar3 ^ 1,0);
		  uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x54),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar2,uVar3,0);
		  uVar5 = *(undefined4 *)(param1 + 0x3c);
		  uVar2 = AssetContent_GameAssetViewRawImage__set_AssetId
		                    (*(undefined4 *)(*(int *)(*(int *)(param2_00 + 8) + 0x18) + 8),0);
		  Core_Extensions_Dict_MonsterDictExt__GetTitle(uVar5,uVar2,0);
		  uVar5 = *(undefined4 *)(param1 + 0x3c);
		  uVar2 = GAFInternal_Objects_GAFBakedObjectInternal__get_impl
		                    (*(undefined4 *)(*(int *)(param2_00 + 8) + 0x18),0);
		  UI_Elements_RightPanel_TitleWithLevel__set_Title(uVar5,uVar2,0);
		  uVar5 = *(undefined4 *)(param1 + 0x40);
		  uVar2 = UI_Wiki_WikiUriRouter__SetData
		                    (*(undefined4 *)
		                      (*(int *)(*(int *)(*(int *)(param2_00 + 8) + 0x18) + 0xc) + 0x10),0);
		  Core_Extensions_Dict_AprDicExt__Get1024AssetId(uVar5,uVar2,0);
		  uVar5 = *(undefined4 *)(param1 + 0x44);
		  uVar2 = unnamed_function_1417(UI_Elements_RightPanel_TitledList_TitledListArgs_TypeInfo);
		  UI_Elements_RightPanel_TitledList_TitledList__set_Title(uVar5,uVar2,0);
		  uVar5 = *(undefined4 *)(param1 + 0x44);
		  uVar2 = Gameplay_Boss_View_CaptainTab_BossInfoView__set_AttackOptions
		                    (*(undefined4 *)(*(int *)(*(int *)(param2_00 + 8) + 0x18) + 8),0);
		  Core_Extensions_Dict_MonsterDictExt__GetTitle(uVar5,uVar2,0);
		  param1_01 = *(undefined4 *)(param1 + 0x44);
		  uVar2 = Core_Extensions_Dict_ModifierDicExt__GetDescription
		                    (*(undefined4 *)(*(int *)(*(int *)(param2_00 + 8) + 0x18) + 8),0);
		  uVar5 = unnamed_function_1417
		                    (
		                    UI_Elements_RightPanel_TitledList_Elements_TextTitledListElement_TextTitledListElementArgs_TypeInfo
		                    );
		  Unity_Services_Core_Environments_Internal_Environments__get_Current(uVar5,uVar2,0);
		  UI_Elements_RightPanel_TitledList_TitledList__Init(param1_01,uVar5,0);
		  return;
		}
		*/

}
