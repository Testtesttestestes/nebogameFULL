using System;
using System.Runtime.CompilerServices;
using AssetContent;
using Core.Data;
using Gameplay.Rating.View;
using Gameplay.World.Model;
using Il2CppDummyDll;
using Protocol.Dic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UI.Elements.RatingElements
{
	// Token: 0x02000215 RID: 533
	[Token(Token = "0x2000215")]
	public class TopLeader : MonoBehaviour
	{
		// Token: 0x140000EC RID: 236
		// (add) Token: 0x06000D57 RID: 3415 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000D58 RID: 3416 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000EC")]
		private event Action OnClick
		{
			[Token(Token = "0x6000D57")]
			[Address(RVA = "0x603A", Offset = "0x603A", VA = "0x603A")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000D58")]
			[Address(RVA = "0x603B", Offset = "0x603B", VA = "0x603B")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06000D59 RID: 3417 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D59")]
		[Address(RVA = "0x603C", Offset = "0x603C", VA = "0x603C")]
		private void Awake()
		{
		/* --- GHIDRA: Awake ---
		void UI_Elements_RatingElements_TopLeader__Awake(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a6396f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Elements_RatingElements_TopLeader_ButtonClickedEventHandler__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a6396f = '\x01';
		  }
		  *(undefined4 *)(param1 + 0x2c) = 0;
		  param1_01 = *(undefined4 *)(*(int *)(param1 + 0x10) + 0xb4);
		  param1_00 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (param1_00,param1,
		             Method_UI_Elements_RatingElements_TopLeader_ButtonClickedEventHandler__,0);
		  UnityEngine_Events_UnityAction___ctor(param1_01,param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x06000D5A RID: 3418 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D5A")]
		[Address(RVA = "0x603D", Offset = "0x603D", VA = "0x603D")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void UI_Elements_RatingElements_TopLeader__OnDestroy(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = *(int *)(param1 + 0x2c);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06000D5B RID: 3419 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D5B")]
		[Address(RVA = "0x603E", Offset = "0x603E", VA = "0x603E")]
		private void ButtonClickedEventHandler()
		{
		/* --- GHIDRA: ButtonClickedEventHandler ---
		void UI_Elements_RatingElements_TopLeader__ButtonClickedEventHandler
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (param2 != 0) {
		    func_ii_7050(*(undefined4 *)(param1 + 0x1c),*(undefined4 *)(param1 + 0x24),0);
		    uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(param1 + 0x14),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar1,0,0);
		    uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(param1 + 0x18),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar1,1,0);
		    Gameplay_Rating_View_UserView__get_UserData(*(undefined4 *)(param1 + 0x18),param2,0);
		    param1_00 = *(undefined4 *)(param1 + 0x20);
		    uVar1 = Google_Protobuf_Collections_RepeatedField_object___GetEnumerator(param2,0);
		    UnityEngine_Component__GetComponentInChildren_object_(param1_00,uVar1,0);
		    uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (param1,0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar1,1,0);
		    *(undefined4 *)(param1 + 0x2c) = 0;
		    return;
		  }
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (param1,0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,0,0);
		  return;
		}
		*/

		}

		// Token: 0x06000D5C RID: 3420 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D5C")]
		[Address(RVA = "0x603F", Offset = "0x603F", VA = "0x603F")]
		public void Init(UserData userData)
		{
		/* --- GHIDRA: Init ---
		void UI_Elements_RatingElements_TopLeader__Init
		               (int param1,int param2,undefined4 param3,undefined4 param4)
		
		{
		  int param2_00;
		  undefined4 uVar1;
		  undefined4 param1_00;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a63970 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Elements_RatingElements_TopLeader___c__DisplayClass15_0__Init_b__0__);
		    Mono_Security_ASN1__get_Item
		              (&UI_Elements_RatingElements_TopLeader___c__DisplayClass15_0_TypeInfo);
		    DAT_ram_00a63970 = '\x01';
		  }
		  local_4 = 0;
		  param2_00 = unnamed_function_1417
		                        (UI_Elements_RatingElements_TopLeader___c__DisplayClass15_0_TypeInfo);
		  *(int *)(param2_00 + 0xc) = param2;
		  *(undefined4 *)(param2_00 + 8) = param3;
		  if (param2 == 0) {
		    uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (param1,0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar1,0,0);
		  }
		  else {
		    func_ii_7050(*(undefined4 *)(param1 + 0x1c),*(undefined4 *)(param1 + 0x28),0);
		    uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(param1 + 0x14),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar1,1,0);
		    uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(param1 + 0x18),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar1,0,0);
		    Gameplay_World_Model_ClanData__TryGetFractionCultDic
		              (*(undefined4 *)(param2_00 + 0xc),&local_4,0);
		    param1_00 = *(undefined4 *)(param1 + 0x14);
		    uVar1 = Core_Extensions_Dict_CultDicExt__GetCultBgAssetId(local_4,0);
		    Core_Extensions_Dict_PortalDicExt__GetCurrencyIcon60x66(param1_00,uVar1,0);
		    UnityEngine_Component__GetComponentInChildren_object_
		              (*(undefined4 *)(param1 + 0x20),
		               *(undefined4 *)(*(int *)(*(int *)(param2_00 + 0xc) + 0x1c) + 0x18),0);
		    uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (param1,0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar1,1,0);
		    uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar1,param2_00,
		               Method_UI_Elements_RatingElements_TopLeader___c__DisplayClass15_0__Init_b__0__,0);
		    *(undefined4 *)(param1 + 0x2c) = uVar1;
		  }
		  return;
		}
		*/

		/* --- GHIDRA: Init ---
		void UI_Elements_RatingElements_TopLeader__Init
		               (int param1,int param2,undefined4 param3,undefined4 param4)
		
		{
		  int param2_00;
		  undefined4 uVar1;
		  undefined4 param1_00;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a63970 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Elements_RatingElements_TopLeader___c__DisplayClass15_0__Init_b__0__);
		    Mono_Security_ASN1__get_Item
		              (&UI_Elements_RatingElements_TopLeader___c__DisplayClass15_0_TypeInfo);
		    DAT_ram_00a63970 = '\x01';
		  }
		  local_4 = 0;
		  param2_00 = unnamed_function_1417
		                        (UI_Elements_RatingElements_TopLeader___c__DisplayClass15_0_TypeInfo);
		  *(int *)(param2_00 + 0xc) = param2;
		  *(undefined4 *)(param2_00 + 8) = param3;
		  if (param2 == 0) {
		    uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (param1,0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar1,0,0);
		  }
		  else {
		    func_ii_7050(*(undefined4 *)(param1 + 0x1c),*(undefined4 *)(param1 + 0x28),0);
		    uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(param1 + 0x14),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar1,1,0);
		    uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(param1 + 0x18),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar1,0,0);
		    Gameplay_World_Model_ClanData__TryGetFractionCultDic
		              (*(undefined4 *)(param2_00 + 0xc),&local_4,0);
		    param1_00 = *(undefined4 *)(param1 + 0x14);
		    uVar1 = Core_Extensions_Dict_CultDicExt__GetCultBgAssetId(local_4,0);
		    Core_Extensions_Dict_PortalDicExt__GetCurrencyIcon60x66(param1_00,uVar1,0);
		    UnityEngine_Component__GetComponentInChildren_object_
		              (*(undefined4 *)(param1 + 0x20),
		               *(undefined4 *)(*(int *)(*(int *)(param2_00 + 0xc) + 0x1c) + 0x18),0);
		    uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (param1,0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar1,1,0);
		    uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar1,param2_00,
		               Method_UI_Elements_RatingElements_TopLeader___c__DisplayClass15_0__Init_b__0__,0);
		    *(undefined4 *)(param1 + 0x2c) = uVar1;
		  }
		  return;
		}
		*/

		/* --- GHIDRA: Init ---
		void UI_Elements_RatingElements_TopLeader__Init
		               (int param1,int param2,undefined4 param3,undefined4 param4)
		
		{
		  int param2_00;
		  undefined4 uVar1;
		  undefined4 param1_00;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a63970 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Elements_RatingElements_TopLeader___c__DisplayClass15_0__Init_b__0__);
		    Mono_Security_ASN1__get_Item
		              (&UI_Elements_RatingElements_TopLeader___c__DisplayClass15_0_TypeInfo);
		    DAT_ram_00a63970 = '\x01';
		  }
		  local_4 = 0;
		  param2_00 = unnamed_function_1417
		                        (UI_Elements_RatingElements_TopLeader___c__DisplayClass15_0_TypeInfo);
		  *(int *)(param2_00 + 0xc) = param2;
		  *(undefined4 *)(param2_00 + 8) = param3;
		  if (param2 == 0) {
		    uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (param1,0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar1,0,0);
		  }
		  else {
		    func_ii_7050(*(undefined4 *)(param1 + 0x1c),*(undefined4 *)(param1 + 0x28),0);
		    uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(param1 + 0x14),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar1,1,0);
		    uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(param1 + 0x18),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar1,0,0);
		    Gameplay_World_Model_ClanData__TryGetFractionCultDic
		              (*(undefined4 *)(param2_00 + 0xc),&local_4,0);
		    param1_00 = *(undefined4 *)(param1 + 0x14);
		    uVar1 = Core_Extensions_Dict_CultDicExt__GetCultBgAssetId(local_4,0);
		    Core_Extensions_Dict_PortalDicExt__GetCurrencyIcon60x66(param1_00,uVar1,0);
		    UnityEngine_Component__GetComponentInChildren_object_
		              (*(undefined4 *)(param1 + 0x20),
		               *(undefined4 *)(*(int *)(*(int *)(param2_00 + 0xc) + 0x1c) + 0x18),0);
		    uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (param1,0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar1,1,0);
		    uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar1,param2_00,
		               Method_UI_Elements_RatingElements_TopLeader___c__DisplayClass15_0__Init_b__0__,0);
		    *(undefined4 *)(param1 + 0x2c) = uVar1;
		  }
		  return;
		}
		*/

		}

		// Token: 0x06000D5D RID: 3421 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D5D")]
		[Address(RVA = "0x6040", Offset = "0x6040", VA = "0x6040")]
		public void Init(CultDic cultDic)
		{
		}

		// Token: 0x06000D5E RID: 3422 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D5E")]
		[Address(RVA = "0x6041", Offset = "0x6041", VA = "0x6041")]
		public void Init(ClanData clanData, Action<ClanData> callback)
		{
		}

		// Token: 0x06000D5F RID: 3423 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D5F")]
		[Address(RVA = "0x6042", Offset = "0x6042", VA = "0x6042")]
		public TopLeader()
		{
		}

		// Token: 0x0400069D RID: 1693
		[Token(Token = "0x400069D")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Button _button;

		// Token: 0x0400069E RID: 1694
		[Token(Token = "0x400069E")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private GameRawImage _gameImage;

		// Token: 0x0400069F RID: 1695
		[Token(Token = "0x400069F")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UserView _userView;

		// Token: 0x040006A0 RID: 1696
		[Token(Token = "0x40006A0")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private Image _bg;

		// Token: 0x040006A1 RID: 1697
		[Token(Token = "0x40006A1")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TextMeshProUGUI _title;

		// Token: 0x040006A2 RID: 1698
		[Token(Token = "0x40006A2")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private Sprite _playerBg;

		// Token: 0x040006A3 RID: 1699
		[Token(Token = "0x40006A3")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Sprite _cultBg;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_OnClick ---
		void UI_Elements_RatingElements_TopLeader__add_OnClick
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a6396d == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a6396d = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x2c);
		  while ((param1_01 = (int *)func_ii_7048(param1_00,param2,0), param1_01 == (int *)0x0 ||
		         (System_Action_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 0x2c,param1_01,param1_00);
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


		/* --- GHIDRA: remove_OnClick ---
		void UI_Elements_RatingElements_TopLeader__remove_OnClick(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a6396e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Elements_RatingElements_TopLeader_ButtonClickedEventHandler__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a6396e = '\x01';
		  }
		  param1_01 = *(undefined4 *)(*(int *)(param1 + 0x10) + 0xb4);
		  param1_00 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (param1_00,param1,
		             Method_UI_Elements_RatingElements_TopLeader_ButtonClickedEventHandler__,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(param1_01,param1_00,0);
		  return;
		}
		*/

}
