using System;
using Gameplay.World.Model;
using Il2CppDummyDll;
using UI.Elements.Counters;
using UnityEngine;
using UnityEngine.UI;
using Utils.Timers;

namespace Gameplay.Clans.Office.View
{
	// Token: 0x020009EF RID: 2543
	[Token(Token = "0x20009EF")]
	public class ClanCursesIndicator : MonoBehaviour
	{
		// Token: 0x17000BF4 RID: 3060
		// (get) Token: 0x06003CB6 RID: 15542 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000BF4")]
		private DelayedCall Timer
		{
			[Token(Token = "0x6003CB6")]
			[Address(RVA = "0x8B79", Offset = "0x8B79", VA = "0x8B79")]
			get
			{
				return null;
			}
		}

		// Token: 0x06003CB7 RID: 15543 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CB7")]
		[Address(RVA = "0x8B7A", Offset = "0x8B7A", VA = "0x8B7A")]
		private void Awake()
		{
		/* --- GHIDRA: Awake ---
		void Gameplay_Clans_Office_View_ClanCursesIndicator__Awake(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a57eef == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Clans_Office_View_ClanCursesIndicator_ButtonClickedEventHandler__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a57eef = '\x01';
		  }
		  param1_00 = *(undefined4 *)(*(int *)(param1 + 0x14) + 0xb4);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar1,param1,
		             Method_Gameplay_Clans_Office_View_ClanCursesIndicator_ButtonClickedEventHandler__,0);
		  UnityEngine_Events_UnityAction___ctor(param1_00,uVar1,0);
		  uVar1 = Gameplay_Clans_Office_View_ClanCurseView___ctor(param1,param1);
		  Utils_Timers_DelayedCall__DelayedCallAsync(uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x06003CB8 RID: 15544 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CB8")]
		[Address(RVA = "0x8B7B", Offset = "0x8B7B", VA = "0x8B7B")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void Gameplay_Clans_Office_View_ClanCursesIndicator__OnDestroy
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int param1_00;
		  undefined4 uVar1;
		  float param2_00;
		  undefined4 *puVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a57ef0 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Func_ClanCurseData__float__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Extensions_IEnumerableExt_MinOrDefault_ClanCurseData__float___);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Clans_Office_View_ClanCursesIndicator___c__SetClanData_b__8_0__);
		    Mono_Security_ASN1__get_Item(&Gameplay_Clans_Office_View_ClanCursesIndicator___c_TypeInfo);
		    DAT_ram_00a57ef0 = '\x01';
		  }
		  *(undefined4 *)(param1 + 0x18) = param2;
		  param1_00 = Gameplay_World_Model_ClanData__set_ClanLeagueDic(param2,0);
		  System_Collections_Generic_Dictionary_int__object___get_Count
		            (*(undefined4 *)(param1 + 0x10),*(undefined4 *)(param1_00 + 0xc),0);
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (param1,0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,(uint)(0 < *(int *)(*(int *)(param1 + 0x10) + 0x1c)),0);
		  if (*(int *)(Gameplay_Clans_Office_View_ClanCursesIndicator___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_Clans_Office_View_ClanCursesIndicator___c_TypeInfo);
		  }
		  puVar2 = *(undefined4 **)(Gameplay_Clans_Office_View_ClanCursesIndicator___c_TypeInfo + 0x5c);
		  param1_01 = puVar2[1];
		  if (param1_01 == 0) {
		    if (*(int *)(Gameplay_Clans_Office_View_ClanCursesIndicator___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_Clans_Office_View_ClanCursesIndicator___c_TypeInfo);
		      puVar2 = *(undefined4 **)(Gameplay_Clans_Office_View_ClanCursesIndicator___c_TypeInfo + 0x5c);
		    }
		    uVar1 = *puVar2;
		    param1_01 = unnamed_function_1417(System_Func_ClanCurseData__float__TypeInfo);
		    System_Func_object__SerializableProjectConfiguration___Invoke
		              (param1_01,uVar1,
		               Method_Gameplay_Clans_Office_View_ClanCursesIndicator___c__SetClanData_b__8_0__,0);
		    *(int *)(*(int *)(Gameplay_Clans_Office_View_ClanCursesIndicator___c_TypeInfo + 0x5c) + 4) =
		         param1_01;
		  }
		  param2_00 = Core_Extensions_ICollectionExt__ContainsAny___Il2CppFullySharedGenericType_
		                        (param1_00,param1_01,
		                         Method_Core_Extensions_IEnumerableExt_MinOrDefault_ClanCurseData__float___)
		  ;
		  uVar1 = Gameplay_Clans_Office_View_ClanCurseView___ctor(param1,param1);
		  Utils_Timers_DelayedCall__SetDelay(uVar1,0);
		  if (0.0 < param2_00) {
		    uVar1 = Gameplay_Clans_Office_View_ClanCurseView___ctor(param1,param1);
		    Utils_Timers_DelayedCall___ctor(uVar1,param2_00,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06003CB9 RID: 15545 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CB9")]
		[Address(RVA = "0x8B7C", Offset = "0x8B7C", VA = "0x8B7C")]
		public void SetClanData(ClanData data)
		{
		/* --- GHIDRA: SetClanData ---
		void Gameplay_Clans_Office_View_ClanCursesIndicator__SetClanData(int param1,undefined4 param2)
		
		{
		  Gameplay_Clans_Office_View_ClanCursesIndicator__OnDestroy
		            (param1,*(undefined4 *)(param1 + 0x18),param1);
		  return;
		}
		*/

		}

		// Token: 0x06003CBA RID: 15546 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CBA")]
		[Address(RVA = "0x8B7D", Offset = "0x8B7D", VA = "0x8B7D")]
		private void UpdateData()
		{
		/* --- GHIDRA: UpdateData ---
		void Gameplay_Clans_Office_View_ClanCursesIndicator__UpdateData(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 param2_00;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a57ef1 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&UI_Windows_ClanCursesDialogWindow_ClanCursesDialogWindowArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_PopupController_Show_ClanCursesDialogWindow___);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12589);
		    DAT_ram_00a57ef1 = '\x01';
		  }
		  uVar1 = System_Uri___ctor(0);
		  uVar1 = System_Globalization_TimeSpanFormat_FormatLiterals__get_Start(uVar1,0);
		  param2_00 = Gameplay_World_Model_ClanData__set_ClanLeagueDic(*(undefined4 *)(param1 + 0x18),0);
		  param1_00 = unnamed_function_1417
		                        (UI_Windows_ClanCursesDialogWindow_ClanCursesDialogWindowArgs_TypeInfo);
		  UI_Windows_ClanCursesDialogWindow___ctor(param1_00,param2_00,0);
		  Gameplay_Antiq_View_GroupReviewWindow_WindowArgs___ctor
		            (uVar1,StringLiteral_12589,param1_00,
		             Method_UI_Windows_PopupController_Show_ClanCursesDialogWindow___);
		  return;
		}
		*/

		}

		// Token: 0x06003CBB RID: 15547 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CBB")]
		[Address(RVA = "0x8B7E", Offset = "0x8B7E", VA = "0x8B7E")]
		private void ButtonClickedEventHandler()
		{
		}

		// Token: 0x06003CBC RID: 15548 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CBC")]
		[Address(RVA = "0x8B7F", Offset = "0x8B7F", VA = "0x8B7F")]
		public ClanCursesIndicator()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Clans_Office_View_ClanCursesIndicator___ctor(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a57ef2 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Clans_Office_View_ClanCursesIndicator___c_TypeInfo);
		    DAT_ram_00a57ef2 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Gameplay_Clans_Office_View_ClanCursesIndicator___c_TypeInfo);
		  **(undefined4 **)(Gameplay_Clans_Office_View_ClanCursesIndicator___c_TypeInfo + 0x5c) = uVar1;
		  return;
		}
		*/

		}

		// Token: 0x04002189 RID: 8585
		[Token(Token = "0x4002189")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private CounterAutoHide _counter;

		// Token: 0x0400218A RID: 8586
		[Token(Token = "0x400218A")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Button _button;

		// Token: 0x0400218B RID: 8587
		[Token(Token = "0x400218B")]
		[FieldOffset(Offset = "0x18")]
		private ClanData _clanData;

		// Token: 0x0400218C RID: 8588
		[Token(Token = "0x400218C")]
		[FieldOffset(Offset = "0x1C")]
		private DelayedCall _timer;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Timer ---
		void Gameplay_Clans_Office_View_ClanCursesIndicator__get_Timer(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a57eee == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Clans_Office_View_ClanCursesIndicator_ButtonClickedEventHandler__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a57eee = '\x01';
		  }
		  param1_01 = *(undefined4 *)(*(int *)(param1 + 0x14) + 0xb4);
		  param1_00 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (param1_00,param1,
		             Method_Gameplay_Clans_Office_View_ClanCursesIndicator_ButtonClickedEventHandler__,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(param1_01,param1_00,0);
		  return;
		}
		*/

}
