using System;
using AssetContent;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Utils;

namespace Gameplay.GameEvents.View.Lists
{
	// Token: 0x02000789 RID: 1929
	[Token(Token = "0x2000789")]
	public class GameEventItemRenderer : MonoBehaviour
	{
		// Token: 0x170008D1 RID: 2257
		// (get) Token: 0x06002DD3 RID: 11731 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002DD4 RID: 11732 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008D1")]
		public GameEventsListView.GameEventsListItemWrapper Data
		{
			[Token(Token = "0x6002DD3")]
			[Address(RVA = "0x7E51", Offset = "0x7E51", VA = "0x7E51")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002DD4")]
			[Address(RVA = "0x7E52", Offset = "0x7E52", VA = "0x7E52")]
			set
			{
			}
		}

		// Token: 0x06002DD5 RID: 11733 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DD5")]
		[Address(RVA = "0x7E53", Offset = "0x7E53", VA = "0x7E53")]
		private void HandleDataChanged(GameEventsListView.GameEventsListItemWrapper from, GameEventsListView.GameEventsListItemWrapper to)
		{
		}

		// Token: 0x06002DD6 RID: 11734 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DD6")]
		[Address(RVA = "0x7E54", Offset = "0x7E54", VA = "0x7E54")]
		private void HandleOnEditModeChanged()
		{
		/* --- GHIDRA: HandleOnEditModeChanged ---
		void Gameplay_GameEvents_View_Lists_GameEventItemRenderer__HandleOnEditModeChanged
		               (int param1,undefined4 param2)
		
		{
		  func_ii_7603(*(undefined4 *)(param1 + 0x18),(uint)*(byte *)(*(int *)(param1 + 0x28) + 0x14),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (*(undefined4 *)(param1 + 0x1c),(uint)*(byte *)(*(int *)(param1 + 0x28) + 0x14),0);
		  return;
		}
		*/

		}

		// Token: 0x06002DD7 RID: 11735 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DD7")]
		[Address(RVA = "0x7E55", Offset = "0x7E55", VA = "0x7E55")]
		private void HandleOnSelectedChanged()
		{
		/* --- GHIDRA: HandleOnSelectedChanged ---
		void Gameplay_GameEvents_View_Lists_GameEventItemRenderer__HandleOnSelectedChanged
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  int iVar2;
		  
		  iVar1 = *(int *)(param1 + 0x28);
		  if ((iVar1 != 0) && (*(char *)(iVar1 + 8) == '\0')) {
		    iVar2 = *(int *)(iVar1 + 0x1c);
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		              (*(undefined4 *)(iVar2 + 0x20),param1,*(undefined4 *)(iVar1 + 0x18),
		               *(undefined4 *)(iVar2 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002DD8 RID: 11736 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DD8")]
		[Address(RVA = "0x7E56", Offset = "0x7E56", VA = "0x7E56")]
		private void ButtonClickedEventHandler()
		{
		/* --- GHIDRA: ButtonClickedEventHandler ---
		void Gameplay_GameEvents_View_Lists_GameEventItemRenderer__ButtonClickedEventHandler
		               (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a574a4 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_LongTap___);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GameEvents_View_Lists_GameEventItemRenderer_ButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_GameEvents_View_Lists_GameEventItemRenderer_CheckBoxValueChanged__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_GameEvents_View_Lists_GameEventItemRenderer_HandleLongTapEvent__);
		    Mono_Security_ASN1__get_Item(&Utils_LongTap_LongTapHandler_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Events_UnityEvent_bool__AddListener__);
		    DAT_ram_00a574a4 = '\x01';
		  }
		  uVar1 = func_ii_5677(param1,Method_UnityEngine_Component_GetComponent_LongTap___);
		  *(undefined4 *)(param1 + 0x2c) = uVar1;
		  uVar2 = *(undefined4 *)(*(int *)(param1 + 0x18) + 0xc0);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_bool__TypeInfo);
		  UnityEngine_UI_Toggle__set_group
		            (uVar1,param1,
		             Method_Gameplay_GameEvents_View_Lists_GameEventItemRenderer_CheckBoxValueChanged__,0);
		  UnityEngine_Events_UnityEvent_InputAction_CallbackContext____ctor
		            (uVar2,uVar1,Method_UnityEngine_Events_UnityEvent_bool__AddListener__);
		  uVar2 = *(undefined4 *)(param1 + 0x2c);
		  uVar1 = unnamed_function_1417(Utils_LongTap_LongTapHandler_TypeInfo);
		  Utils_LongTap___cctor
		            (uVar1,param1,
		             Method_Gameplay_GameEvents_View_Lists_GameEventItemRenderer_HandleLongTapEvent__,0);
		  Utils_LongTap__remove_CancelLongTapEvent(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(*(int *)(param1 + 0x24) + 0xb4);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar1,param1,
		             Method_Gameplay_GameEvents_View_Lists_GameEventItemRenderer_ButtonClickedEventHandler__
		             ,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar2,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x06002DD9 RID: 11737 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DD9")]
		[Address(RVA = "0x7E57", Offset = "0x7E57", VA = "0x7E57")]
		private void Awake()
		{
		/* --- GHIDRA: Awake ---
		void Gameplay_GameEvents_View_Lists_GameEventItemRenderer__Awake
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  byte bVar1;
		  int iVar2;
		  int iVar3;
		  int iVar4;
		  
		  iVar2 = *(int *)(param1 + 0x28);
		  bVar1 = *(byte *)(*(int *)(param1 + 0x18) + 0xc4) ^ 1;
		  iVar4 = iVar2;
		  if (bVar1 != *(byte *)(iVar2 + 0x14)) {
		    *(byte *)(iVar2 + 0x14) = bVar1;
		    iVar3 = *(int *)(iVar2 + 0x10);
		    if (iVar3 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar3 + 0xc) * 4))
		                (*(undefined4 *)(iVar3 + 0x20),*(undefined4 *)(iVar3 + 0x14));
		      iVar4 = *(int *)(param1 + 0x28);
		    }
		  }
		  iVar4 = *(int *)(iVar4 + 0x20);
		  (**(code **)((ulonglong)*(uint *)(iVar4 + 0xc) * 4))
		            (*(undefined4 *)(iVar4 + 0x20),param1,iVar2,*(undefined4 *)(iVar4 + 0x14));
		  return;
		}
		*/

		}

		// Token: 0x06002DDA RID: 11738 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DDA")]
		[Address(RVA = "0x7E58", Offset = "0x7E58", VA = "0x7E58")]
		private void HandleLongTapEvent(LongTap sender)
		{
		/* --- GHIDRA: HandleLongTapEvent ---
		void Gameplay_GameEvents_View_Lists_GameEventItemRenderer__HandleLongTapEvent
		               (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a574a5 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GameEvents_View_Lists_GameEventItemRenderer_ButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_GameEvents_View_Lists_GameEventItemRenderer_CheckBoxValueChanged__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_GameEvents_View_Lists_GameEventItemRenderer_HandleLongTapEvent__);
		    Mono_Security_ASN1__get_Item(&Utils_LongTap_LongTapHandler_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Events_UnityEvent_bool__RemoveListener__);
		    DAT_ram_00a574a5 = '\x01';
		  }
		  uVar2 = *(undefined4 *)(*(int *)(param1 + 0x18) + 0xc0);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_bool__TypeInfo);
		  UnityEngine_UI_Toggle__set_group
		            (uVar1,param1,
		             Method_Gameplay_GameEvents_View_Lists_GameEventItemRenderer_CheckBoxValueChanged__,0);
		  UnityEngine_Events_UnityEvent_InputAction_CallbackContext___Invoke
		            (uVar2,uVar1,Method_UnityEngine_Events_UnityEvent_bool__RemoveListener__);
		  uVar2 = *(undefined4 *)(param1 + 0x2c);
		  uVar1 = unnamed_function_1417(Utils_LongTap_LongTapHandler_TypeInfo);
		  Utils_LongTap___cctor
		            (uVar1,param1,
		             Method_Gameplay_GameEvents_View_Lists_GameEventItemRenderer_HandleLongTapEvent__,0);
		  Utils_LongTap__add_LongTapEvent(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(*(int *)(param1 + 0x24) + 0xb4);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar1,param1,
		             Method_Gameplay_GameEvents_View_Lists_GameEventItemRenderer_ButtonClickedEventHandler__
		             ,0);
		  UnityEngine_Events_UnityAction___ctor(uVar2,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x06002DDB RID: 11739 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DDB")]
		[Address(RVA = "0x7E59", Offset = "0x7E59", VA = "0x7E59")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void Gameplay_GameEvents_View_Lists_GameEventItemRenderer__OnDestroy
		               (int param1,uint param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  int iVar3;
		  
		  iVar1 = *(int *)(param1 + 0x28);
		  iVar3 = iVar1;
		  if (*(byte *)(iVar1 + 0x14) != param2) {
		    *(char *)(iVar1 + 0x14) = (char)param2;
		    iVar2 = *(int *)(iVar1 + 0x10);
		    if (iVar2 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		                (*(undefined4 *)(iVar2 + 0x20),*(undefined4 *)(iVar2 + 0x14));
		      iVar3 = *(int *)(param1 + 0x28);
		    }
		  }
		  iVar3 = *(int *)(iVar3 + 0x20);
		  (**(code **)((ulonglong)*(uint *)(iVar3 + 0xc) * 4))
		            (*(undefined4 *)(iVar3 + 0x20),param1,iVar1,*(undefined4 *)(iVar3 + 0x14));
		  return;
		}
		*/

		}

		// Token: 0x06002DDC RID: 11740 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DDC")]
		[Address(RVA = "0x7E5A", Offset = "0x7E5A", VA = "0x7E5A")]
		private void CheckBoxValueChanged(bool selected)
		{
		/* --- GHIDRA: CheckBoxValueChanged ---
		void Gameplay_GameEvents_View_Lists_GameEventItemRenderer__CheckBoxValueChanged
		               (int param1,uint param2,undefined4 param3,undefined4 param4)
		
		{
		  int iVar1;
		  int iVar2;
		  
		  iVar1 = *(int *)(param1 + 0x28);
		  if (*(byte *)(iVar1 + 0x14) != param2) {
		    *(char *)(iVar1 + 0x14) = (char)param2;
		    iVar2 = *(int *)(iVar1 + 0x10);
		    if (iVar2 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		                (*(undefined4 *)(iVar2 + 0x20),*(undefined4 *)(iVar2 + 0x14));
		      iVar1 = *(int *)(param1 + 0x28);
		    }
		  }
		  iVar1 = *(int *)(iVar1 + 0x20);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		            (*(undefined4 *)(iVar1 + 0x20),param1,param3,*(undefined4 *)(iVar1 + 0x14));
		  return;
		}
		*/

		}

		// Token: 0x06002DDD RID: 11741 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DDD")]
		[Address(RVA = "0x7E5B", Offset = "0x7E5B", VA = "0x7E5B")]
		private void SetSelect(bool value, GameEventsListView.GameEventsListItemWrapper data)
		{
		}

		// Token: 0x06002DDE RID: 11742 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DDE")]
		[Address(RVA = "0x7E5C", Offset = "0x7E5C", VA = "0x7E5C")]
		public GameEventItemRenderer()
		{
		}

		// Token: 0x04001924 RID: 6436
		[Token(Token = "0x4001924")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TextMeshProUGUI _title;

		// Token: 0x04001925 RID: 6437
		[Token(Token = "0x4001925")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private TextMeshProUGUI _timestampField;

		// Token: 0x04001926 RID: 6438
		[Token(Token = "0x4001926")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Toggle _checkbox;

		// Token: 0x04001927 RID: 6439
		[Token(Token = "0x4001927")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private GameObject _selecetedBorder;

		// Token: 0x04001928 RID: 6440
		[Token(Token = "0x4001928")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameRawImage _backgroundLoader;

		// Token: 0x04001929 RID: 6441
		[Token(Token = "0x4001929")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private Button _button;

		// Token: 0x0400192A RID: 6442
		[Token(Token = "0x400192A")]
		[FieldOffset(Offset = "0x28")]
		private GameEventsListView.GameEventsListItemWrapper _data;

		// Token: 0x0400192B RID: 6443
		[Token(Token = "0x400192B")]
		[FieldOffset(Offset = "0x2C")]
		private LongTap _longTap;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Data ---
		void Gameplay_GameEvents_View_Lists_GameEventItemRenderer__get_Data
		               (int param1,int param2,undefined4 param3)
		
		{
		  int param2_00;
		  
		  param2_00 = *(int *)(param1 + 0x28);
		  if (param2 != param2_00) {
		    *(int *)(param1 + 0x28) = param2;
		    Gameplay_GameEvents_View_Lists_GameEventItemRenderer__set_Data(param1,param2_00,param2,param1);
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_Data ---
		void Gameplay_GameEvents_View_Lists_GameEventItemRenderer__set_Data
		               (int param1,int param2,int param3,undefined4 param4)
		
		{
		  bool bVar1;
		  uint uVar2;
		  uint *puVar3;
		  undefined4 param3_00;
		  undefined4 uVar4;
		  int *piVar5;
		  int iVar6;
		  int iVar7;
		  int param3_01;
		  undefined8 local_10;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a574a3 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GameEvents_View_Lists_GameEventItemRenderer_HandleOnEditModeChanged__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GameEvents_View_Lists_GameEventItemRenderer_HandleOnSelectedChanged__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_8424);
		    DAT_ram_00a574a3 = '\x01';
		  }
		  if (param3 != 0) {
		    iVar7 = *(int *)(param3 + 0x18);
		    *(int *)(iVar7 + 0x14) = *(int *)(iVar7 + 0x14) + 1;
		    if (*(char *)(iVar7 + 8) == '\0') {
		      if (DAT_ram_00a6456f == '\0') {
		        Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		        DAT_ram_00a6456f = '\x01';
		      }
		      piVar5 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		      iVar7 = *piVar5;
		      if (*(ushort *)(iVar7 + 0xb6) != 0) {
		        uVar2 = 0;
		        do {
		          if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar2 * 8)) {
		            puVar3 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar2 * 8 + 4) * 8 + iVar7 + 0x168);
		            goto code_r0x80d8f575;
		          }
		          uVar2 = uVar2 + 1;
		        } while (*(ushort *)(iVar7 + 0xb6) != uVar2);
		      }
		      puVar3 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x15);
		code_r0x80d8f575:
		      iVar7 = (**(code **)((ulonglong)*puVar3 * 4))(piVar5,puVar3[1]);
		      piVar5 = *(int **)(iVar7 + 0x1c);
		      iVar6 = *(int *)(param3 + 0x18);
		      *(undefined1 *)(iVar6 + 8) = 1;
		      iVar7 = (**(code **)((ulonglong)*(uint *)(*piVar5 + 0x100) * 4))
		                        (piVar5,*(undefined4 *)(*piVar5 + 0x104));
		      uVar4 = *(undefined4 *)(*(int *)(iVar6 + 0x1c) + 0xc);
		      if (DAT_ram_00a574bc == '\0') {
		        Mono_Security_ASN1__get_Item
		                  (&
		                   Method_System_Collections_Generic_Dictionary_EventCategoriesDic_Types_Category__int__TryGetValue__
		                  );
		        DAT_ram_00a574bc = '\x01';
		      }
		      local_10 = (ulonglong)local_10._4_4_ << 0x20;
		      iVar7 = System_Collections_Generic_List_Enumerator_ValueTuple_object__double____MoveNext
		                        (*(undefined4 *)(iVar7 + 0x2c),uVar4,&local_10,
		                         Method_System_Collections_Generic_Dictionary_EventCategoriesDic_Types_Category__int__TryGetValue__
		                        );
		      param3_01 = (int)local_10 + -1;
		      if (iVar7 == 0) {
		        param3_01 = -1;
		      }
		      System_Collections_Generic_Dictionary_Int32Enum__int___TryGetValue
		                (piVar5,*(undefined4 *)(*(int *)(iVar6 + 0x1c) + 0xc),param3_01,piVar5);
		      iVar7 = *(int *)(param3 + 0x18);
		    }
		    piVar5 = *(int **)(param1 + 0x10);
		    uVar4 = Gameplay_GameEvents_Model_GameEventData___ctor(iVar7,iVar7);
		    iVar7 = *piVar5;
		    (**(code **)((ulonglong)*(uint *)(iVar7 + 0x2d0) * 4))
		              (piVar5,uVar4,*(undefined4 *)(iVar7 + 0x2d4));
		    iVar7 = **(int **)(param1 + 0x14);
		    (**(code **)((ulonglong)*(uint *)(iVar7 + 0x2d0) * 4))
		              (*(int **)(param1 + 0x14),*(undefined4 *)(*(int *)(param3 + 0x18) + 0xc),
		               *(undefined4 *)(iVar7 + 0x2d4));
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (*(undefined4 *)(param1 + 0x1c),(uint)*(byte *)(*(int *)(param1 + 0x28) + 0x14),0);
		    func_ii_7603(*(undefined4 *)(param1 + 0x18),(uint)*(byte *)(param3 + 0x14),0);
		    Core_Extensions_Dict_PortalDicExt__GetCurrencyIcon60x66
		              (*(undefined4 *)(param1 + 0x20),
		               *(undefined4 *)(*(int *)(*(int *)(param3 + 0x18) + 0x10) + 0x14),0);
		    iVar6 = *(int *)(*(int *)(param3 + 0x18) + 0x10);
		    iVar7 = Newtonsoft_Json_Serialization_JsonSerializerInternalReader__ShouldDeserialize
		                      (*(undefined4 *)(iVar6 + 0x10),0);
		    if ((iVar7 == 0) &&
		       (iVar7 = Newtonsoft_Json_Serialization_JsonSerializerInternalReader__ShouldDeserialize
		                          (*(undefined4 *)(iVar6 + 0x14),0), iVar7 == 0)) {
		      Core_Extensions_Dict_PortalDicExt__GetCurrencyIcon60x66
		                (*(undefined4 *)(param1 + 0x20),*(undefined4 *)(iVar6 + 0x14),0);
		    }
		    else {
		      iVar6 = *(int *)(*(int *)(param3 + 0x18) + 0x10);
		      iVar7 = Newtonsoft_Json_Serialization_JsonSerializerInternalReader__ShouldDeserialize
		                        (*(undefined4 *)(iVar6 + 8),0);
		      if ((iVar7 == 0) &&
		         (iVar7 = Newtonsoft_Json_Serialization_JsonSerializerInternalReader__ShouldDeserialize
		                            (*(undefined4 *)(iVar6 + 0xc),0), iVar7 == 0)) {
		        AssetContent_GameRawImage__get_AssetPath
		                  (*(undefined4 *)(param1 + 0x20),*(undefined4 *)(iVar6 + 0xc),0);
		      }
		      else {
		        local_4 = *(undefined4 *)(*(int *)(*(int *)(param3 + 0x18) + 0x20) + 0xc);
		        uVar4 = func_ii_1081(DAT_ram_00a66958,&local_4);
		        local_10 = *(longlong *)(*(int *)(*(int *)(param3 + 0x18) + 0x24) + 0x10);
		        param3_00 = func_ii_1081(DAT_ram_00a66968,&local_10);
		        uVar4 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                          (StringLiteral_8424,uVar4,param3_00,0);
		        if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		          func_ii_306000(OKG_Logs_Debug_TypeInfo);
		        }
		        func_ii_7830(uVar4,0);
		      }
		    }
		    uVar4 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar4,param1,
		               Method_Gameplay_GameEvents_View_Lists_GameEventItemRenderer_HandleOnSelectedChanged__
		               ,0);
		    if (DAT_ram_00a57497 == '\0') {
		      Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		      DAT_ram_00a57497 = '\x01';
		    }
		    iVar7 = *(int *)(param3 + 0x10);
		    do {
		      piVar5 = (int *)UnityEngine_UI_Image__set_sprite(iVar7,uVar4,0);
		      if ((piVar5 != (int *)0x0) && (System_Action_TypeInfo != *piVar5)) {
		        System_Activator__CreateInstance(piVar5,System_Action_TypeInfo);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      iVar6 = func_ii_4329(param3 + 0x10,piVar5,iVar7);
		      bVar1 = iVar6 != iVar7;
		      iVar7 = iVar6;
		    } while (bVar1);
		    uVar4 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar4,param1,
		               Method_Gameplay_GameEvents_View_Lists_GameEventItemRenderer_HandleOnEditModeChanged__
		               ,0);
		    if (DAT_ram_00a57495 == '\0') {
		      Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		      DAT_ram_00a57495 = '\x01';
		    }
		    iVar7 = *(int *)(param3 + 0xc);
		    do {
		      piVar5 = (int *)UnityEngine_UI_Image__set_sprite(iVar7,uVar4,0);
		      if ((piVar5 != (int *)0x0) && (System_Action_TypeInfo != *piVar5)) {
		        System_Activator__CreateInstance(piVar5,System_Action_TypeInfo);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      iVar6 = func_ii_4329(param3 + 0xc,piVar5,iVar7);
		      bVar1 = iVar6 != iVar7;
		      iVar7 = iVar6;
		    } while (bVar1);
		  }
		  if (param2 != 0) {
		    uVar4 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar4,param1,
		               Method_Gameplay_GameEvents_View_Lists_GameEventItemRenderer_HandleOnSelectedChanged__
		               ,0);
		    if (DAT_ram_00a57498 == '\0') {
		      Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		      DAT_ram_00a57498 = '\x01';
		    }
		    iVar7 = *(int *)(param2 + 0x10);
		    do {
		      piVar5 = (int *)func_ii_7048(iVar7,uVar4,0);
		      if ((piVar5 != (int *)0x0) && (System_Action_TypeInfo != *piVar5)) {
		        System_Activator__CreateInstance(piVar5,System_Action_TypeInfo);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      iVar6 = func_ii_4329(param2 + 0x10,piVar5,iVar7);
		      bVar1 = iVar6 != iVar7;
		      iVar7 = iVar6;
		    } while (bVar1);
		    uVar4 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar4,param1,
		               Method_Gameplay_GameEvents_View_Lists_GameEventItemRenderer_HandleOnEditModeChanged__
		               ,0);
		    if (DAT_ram_00a57496 == '\0') {
		      Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		      DAT_ram_00a57496 = '\x01';
		    }
		    iVar7 = *(int *)(param2 + 0xc);
		    do {
		      piVar5 = (int *)func_ii_7048(iVar7,uVar4,0);
		      if ((piVar5 != (int *)0x0) && (System_Action_TypeInfo != *piVar5)) {
		        System_Activator__CreateInstance(piVar5,System_Action_TypeInfo);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      iVar6 = func_ii_4329(param2 + 0xc,piVar5,iVar7);
		      bVar1 = iVar6 != iVar7;
		      iVar7 = iVar6;
		    } while (bVar1);
		  }
		  return;
		}
		*/

}
