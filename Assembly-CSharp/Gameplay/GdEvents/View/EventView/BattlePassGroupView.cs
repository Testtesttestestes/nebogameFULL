using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AssetContent;
using Core.Dict.DictWrappers.Wrappers;
using Core.Gameplay.Managers.Inventory;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.GdEvents.View.EventView
{
	// Token: 0x02000741 RID: 1857
	[Token(Token = "0x2000741")]
	public class BattlePassGroupView : MonoBehaviour
	{
		// Token: 0x14000163 RID: 355
		// (add) Token: 0x06002C35 RID: 11317 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06002C36 RID: 11318 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000163")]
		private event Action ButtonClickedEvent
		{
			[Token(Token = "0x6002C35")]
			[Address(RVA = "0x7CC4", Offset = "0x7CC4", VA = "0x7CC4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6002C36")]
			[Address(RVA = "0x7CC5", Offset = "0x7CC5", VA = "0x7CC5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06002C37 RID: 11319 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C37")]
		[Address(RVA = "0x7CC6", Offset = "0x7CC6", VA = "0x7CC6")]
		public void Init(InventoryManager inventoryManager, ArtikulDicWrapper artikul, IList<uint> optionIds)
		{
		/* --- GHIDRA: Init ---
		void Gameplay_GdEvents_View_EventView_BattlePassGroupView__Init
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a5a2ad == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_ulong__ArtifactData__get_Values__);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Any_ArtifactData___);
		    Mono_Security_ASN1__get_Item(&System_Func_ArtifactData__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GdEvents_View_EventView_BattlePassGroupView___c__DisplayClass10_0__DetermineBattlePassState_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_GdEvents_View_EventView_BattlePassGroupView___c__DisplayClass10_0_TypeInfo)
		    ;
		    DAT_ram_00a5a2ad = '\x01';
		  }
		  iVar1 = unnamed_function_1417
		                    (
		                    Gameplay_GdEvents_View_EventView_BattlePassGroupView___c__DisplayClass10_0_TypeInfo
		                    );
		  *(undefined4 *)(iVar1 + 8) = param2;
		  param1_00 = System_Collections_Generic_Dictionary_int__object___TryAdd
		                        (*(undefined4 *)(*(int *)(*(int *)(param1 + 0x1c) + 0x10) + 0x28),
		                         Method_System_Collections_Generic_Dictionary_ulong__ArtifactData__get_Values__
		                        );
		  param1_01 = unnamed_function_1417(System_Func_ArtifactData__bool__TypeInfo);
		  System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		            (param1_01,iVar1,
		             Method_Gameplay_GdEvents_View_EventView_BattlePassGroupView___c__DisplayClass10_0__DetermineBattlePassState_b__0__
		             ,0);
		  iVar1 = Newtonsoft_Json_Utilities_ReflectionUtils__IsOverridenGenericMember
		                    (param1_00,param1_01,Method_System_Linq_Enumerable_Any_ArtifactData___);
		  if (iVar1 != 0) {
		    Gameplay_GdEvents_View_EventView_BattlePassGroupView__ShowNoBattlePassState(param1,param1);
		    return;
		  }
		  Gameplay_GdEvents_View_EventView_BattlePassGroupView__ButtonClickedEventHandler(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06002C38 RID: 11320 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C38")]
		[Address(RVA = "0x7CC7", Offset = "0x7CC7", VA = "0x7CC7")]
		private void DetermineBattlePassState(IList<uint> setIds)
		{
		/* --- GHIDRA: DetermineBattlePassState ---
		void Gameplay_GdEvents_View_EventView_BattlePassGroupView__DetermineBattlePassState
		               (int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a5a2ae == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GdEvents_View_EventView_BattlePassGroupView_ButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a5a2ae = '\x01';
		  }
		  param1_01 = *(undefined4 *)(*(int *)(param1 + 0x14) + 0xb4);
		  param1_00 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (param1_00,param1,
		             Method_Gameplay_GdEvents_View_EventView_BattlePassGroupView_ButtonClickedEventHandler__
		             ,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(param1_01,param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x06002C39 RID: 11321 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C39")]
		[Address(RVA = "0x7CC8", Offset = "0x7CC8", VA = "0x7CC8")]
		private void Start()
		{
		/* --- GHIDRA: Start ---
		void Gameplay_GdEvents_View_EventView_BattlePassGroupView__Start(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a5a2af == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GdEvents_View_EventView_BattlePassGroupView_ButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a5a2af = '\x01';
		  }
		  param1_01 = *(undefined4 *)(*(int *)(param1 + 0x14) + 0xb4);
		  param1_00 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (param1_00,param1,
		             Method_Gameplay_GdEvents_View_EventView_BattlePassGroupView_ButtonClickedEventHandler__
		             ,0);
		  UnityEngine_Events_UnityAction___ctor(param1_01,param1_00,0);
		  *(undefined4 *)(param1 + 0x28) = 0;
		  return;
		}
		*/

		}

		// Token: 0x06002C3A RID: 11322 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C3A")]
		[Address(RVA = "0x7CC9", Offset = "0x7CC9", VA = "0x7CC9")]
		private void OnDestroy()
		{
		}

		// Token: 0x06002C3B RID: 11323 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C3B")]
		[Address(RVA = "0x7CCA", Offset = "0x7CCA", VA = "0x7CCA")]
		private void ButtonClickedEventHandler()
		{
		/* --- GHIDRA: ButtonClickedEventHandler ---
		void Gameplay_GdEvents_View_EventView_BattlePassGroupView__ButtonClickedEventHandler
		               (int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  int *param1_00;
		  int iVar5;
		  
		  if (DAT_ram_00a5a2b0 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_GdEvents_View_EventView_BattlePassGroupView_ShowBattlePassOptions__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_UnityEngine_Component_GetComponentInChildren_TextMeshProUGUI___);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_ICollection_uint__TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4376);
		    Mono_Security_ASN1__get_Item(&StringLiteral_8333);
		    DAT_ram_00a5a2b0 = '\x01';
		  }
		  uVar4 = *(undefined4 *)(param1 + 0x10);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar1 = 0;
		  uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_8333,1,0,1,0,0,0,0);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar4,uVar2,0);
		  uVar4 = UI_Rewards_AbstractRewardsRender__SetRewards
		                    (*(undefined4 *)(param1 + 0x14),
		                     Method_UnityEngine_Component_GetComponentInChildren_TextMeshProUGUI___);
		  uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4376,1,0,1,0,0,0,0);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar4,uVar2,0);
		  uVar4 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar4,param1,
		             Method_Gameplay_GdEvents_View_EventView_BattlePassGroupView_ShowBattlePassOptions__,0);
		  *(undefined4 *)(param1 + 0x28) = uVar4;
		  uVar4 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x14),0);
		  param1_00 = *(int **)(param1 + 0x24);
		  iVar5 = *param1_00;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (System_Collections_Generic_ICollection_uint__TypeInfo ==
		          *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(iVar5 + *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x811f550d;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param1_00,System_Collections_Generic_ICollection_uint__TypeInfo,0);
		code_r0x811f550d:
		  iVar5 = (**(code **)((ulonglong)*puVar3 * 4))(param1_00,puVar3[1]);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar4,(uint)(0 < iVar5),0);
		  return;
		}
		*/

		}

		// Token: 0x06002C3C RID: 11324 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C3C")]
		[Address(RVA = "0x7CCB", Offset = "0x7CCB", VA = "0x7CCB")]
		private void ShowNoBattlePassState()
		{
		/* --- GHIDRA: ShowNoBattlePassState ---
		void Gameplay_GdEvents_View_EventView_BattlePassGroupView__ShowNoBattlePassState
		               (int param1,undefined4 param2)
		
		{
		  undefined4 param2_00;
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5a2b1 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_8328);
		    DAT_ram_00a5a2b1 = '\x01';
		  }
		  uVar1 = *(undefined4 *)(param1 + 0x10);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  param2_00 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_8328,1,0,1,0,0,0,0);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar1,param2_00,0);
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x14),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,0,0);
		  return;
		}
		*/

		}

		// Token: 0x06002C3D RID: 11325 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C3D")]
		[Address(RVA = "0x7CCC", Offset = "0x7CCC", VA = "0x7CCC")]
		private void ShowBattlePassState()
		{
		/* --- GHIDRA: ShowBattlePassState ---
		void Gameplay_GdEvents_View_EventView_BattlePassGroupView__ShowBattlePassState
		               (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int param1_00;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a5a2b2 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_SpecialOffers_View_OptionsOfferWindow_OptionsOfferWindowArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_PopupController_Show_OptionsOfferWindow___);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12670);
		    Mono_Security_ASN1__get_Item(&StringLiteral_8321);
		    Mono_Security_ASN1__get_Item(&StringLiteral_8320);
		    DAT_ram_00a5a2b2 = '\x01';
		  }
		  uVar1 = System_Uri___ctor(0);
		  uVar1 = System_Globalization_TimeSpanFormat_FormatLiterals__get_Start(uVar1,0);
		  param1_00 = unnamed_function_1417
		                        (
		                        Gameplay_SpecialOffers_View_OptionsOfferWindow_OptionsOfferWindowArgs_TypeInfo
		                        );
		  Gameplay_AccountLinker_View_SelectUserWindow___ctor(param1_00,0);
		  *(undefined4 *)(param1_00 + 0x18) = *(undefined4 *)(*(int *)(*(int *)(param1 + 0x1c) + 0x10) + 8);
		  *(undefined4 *)(param1_00 + 0x1c) = *(undefined4 *)(param1 + 0x24);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_8320,1,0,1,0,0,0,0);
		  *(undefined4 *)(param1_00 + 0x20) = uVar2;
		  uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_8321,1,0,1,0,0,0,0);
		  *(undefined4 *)(param1_00 + 0x24) = uVar2;
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  *(undefined4 *)(param1_00 + 0x28) = **(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  Gameplay_Antiq_View_GroupReviewWindow_WindowArgs___ctor
		            (uVar1,StringLiteral_12670,param1_00,
		             Method_UI_Windows_PopupController_Show_OptionsOfferWindow___);
		  return;
		}
		*/

		}

		// Token: 0x06002C3E RID: 11326 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C3E")]
		[Address(RVA = "0x7CCD", Offset = "0x7CCD", VA = "0x7CCD")]
		private void ShowBattlePassOptions()
		{
		/* --- GHIDRA: ShowBattlePassOptions ---
		void Gameplay_GdEvents_View_EventView_BattlePassGroupView__ShowBattlePassOptions
		               (int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a5a2b3 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Inventory_View_Chest_InventoryChestWindowOptions_ArtifactFilterDelegate_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GdEvents_View_EventView_BattlePassGroupView__ShowFilteredInventory_b__17_0__
		              );
		    DAT_ram_00a5a2b3 = '\x01';
		  }
		  param1_01 = *(undefined4 *)(param1 + 0x1c);
		  param1_00 = unnamed_function_1417
		                        (
		                        Gameplay_Inventory_View_Chest_InventoryChestWindowOptions_ArtifactFilterDelegate_TypeInfo
		                        );
		  Gameplay_Inventory_View_Chest_InventoryChestWindowOptions___ctor
		            (param1_00,param1,
		             Method_Gameplay_GdEvents_View_EventView_BattlePassGroupView__ShowFilteredInventory_b__17_0__
		             ,0);
		  Core_Gameplay_Managers_Inventory_InventoryManager__DismantleArtifact(param1_01,0,0,param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x06002C3F RID: 11327 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C3F")]
		[Address(RVA = "0x7CCE", Offset = "0x7CCE", VA = "0x7CCE")]
		private void ShowFilteredInventory()
		{
		}

		// Token: 0x06002C40 RID: 11328 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C40")]
		[Address(RVA = "0x7CCF", Offset = "0x7CCF", VA = "0x7CCF")]
		public BattlePassGroupView()
		{
		/* --- GHIDRA: .ctor ---
		undefined4
		Gameplay_GdEvents_View_EventView_BattlePassGroupView___ctor(int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5a2b4 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_ArtikulDic__uint__get_Data__)
		    ;
		    Mono_Security_ASN1__get_Item(&Method_Core_Extensions_ICollectionExt_ContainsAny_uint___);
		    DAT_ram_00a5a2b4 = '\x01';
		  }
		  uVar1 = I2_Loc_I2Utils__FindInParents_object_
		                    (*(undefined4 *)(*(int *)(*(int *)(param2 + 8) + 0x10) + 0x54),
		                     *(undefined4 *)(param1 + 0x20),
		                     Method_Core_Extensions_ICollectionExt_ContainsAny_uint___);
		  return uVar1;
		}
		*/

		}

		// Token: 0x0400183C RID: 6204
		[Token(Token = "0x400183C")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TextMeshProUGUI _text;

		// Token: 0x0400183D RID: 6205
		[Token(Token = "0x400183D")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Button _button;

		// Token: 0x0400183E RID: 6206
		[Token(Token = "0x400183E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameImage _icon;

		// Token: 0x0400183F RID: 6207
		[Token(Token = "0x400183F")]
		[FieldOffset(Offset = "0x1C")]
		private InventoryManager _inventoryManager;

		// Token: 0x04001840 RID: 6208
		[Token(Token = "0x4001840")]
		[FieldOffset(Offset = "0x20")]
		private IList<uint> _setIds;

		// Token: 0x04001841 RID: 6209
		[Token(Token = "0x4001841")]
		[FieldOffset(Offset = "0x24")]
		private IList<uint> _optionIds;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_ButtonClickedEvent ---
		void Gameplay_GdEvents_View_EventView_BattlePassGroupView__add_ButtonClickedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a5a2ab == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a5a2ab = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x28);
		  while ((param1_01 = (int *)func_ii_7048(param1_00,param2,0), param1_01 == (int *)0x0 ||
		         (System_Action_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 0x28,param1_01,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,System_Action_TypeInfo);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: remove_ButtonClickedEvent ---
		void Gameplay_GdEvents_View_EventView_BattlePassGroupView__remove_ButtonClickedEvent
		               (int param1,undefined4 param2,int param3,undefined4 param4,undefined4 param5)
		
		{
		  int param1_00;
		  undefined4 uVar1;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a5a2ac == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_ArtikulDic__uint__get_Data__)
		    ;
		    DAT_ram_00a5a2ac = '\x01';
		  }
		  *(undefined4 *)(param1 + 0x1c) = param2;
		  param1_00 = *(int *)(param3 + 0x10);
		  uVar1 = *(undefined4 *)(param1_00 + 0x54);
		  *(undefined4 *)(param1 + 0x24) = param4;
		  *(undefined4 *)(param1 + 0x20) = uVar1;
		  param1_01 = *(undefined4 *)(param1 + 0x18);
		  uVar1 = Core_Extensions_Dict_AprMarkerDicExt__GetTitle(param1_00,0);
		  AssetContent_GameImage__get_AssetId(param1_01,uVar1,0);
		  Gameplay_GdEvents_View_EventView_BattlePassGroupView__Init
		            (param1,*(undefined4 *)(param1 + 0x20),param1);
		  return;
		}
		*/

}
