using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Combat.View.Players.LongEffects
{
	// Token: 0x0200095C RID: 2396
	[Token(Token = "0x200095C")]
	public class LongEffectsView : MonoBehaviour
	{
		// Token: 0x17000B31 RID: 2865
		// (get) Token: 0x060038CE RID: 14542 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000B31")]
		public Transform LongEffectContainer
		{
			[Token(Token = "0x60038CE")]
			[Address(RVA = "0x886C", Offset = "0x886C", VA = "0x886C")]
			get
			{
				return null;
			}
		}

		// Token: 0x060038CF RID: 14543 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60038CF")]
		[Address(RVA = "0x886D", Offset = "0x886D", VA = "0x886D")]
		public void ValidateControlsEnabled(int count)
		{
		/* --- GHIDRA: ValidateControlsEnabled ---
		void Gameplay_Combat_View_Players_LongEffects_LongEffectsView__ValidateControlsEnabled
		               (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a56717 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_View_Players_LongEffects_LongEffectsView_HandleDownClickEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Combat_View_Players_LongEffects_LongEffectsView_HandleUpClickEvent__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a56717 = '\x01';
		  }
		  uVar2 = *(undefined4 *)(*(int *)(param1 + 0x14) + 0xb4);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar1,param1,
		             Method_Gameplay_Combat_View_Players_LongEffects_LongEffectsView_HandleUpClickEvent__,0)
		  ;
		  UnityEngine_Events_UnityAction___ctor(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(*(int *)(param1 + 0x18) + 0xb4);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar1,param1,
		             Method_Gameplay_Combat_View_Players_LongEffects_LongEffectsView_HandleDownClickEvent__,
		             0);
		  UnityEngine_Events_UnityAction___ctor(uVar2,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x060038D0 RID: 14544 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60038D0")]
		[Address(RVA = "0x886E", Offset = "0x886E", VA = "0x886E")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void Gameplay_Combat_View_Players_LongEffects_LongEffectsView__OnDestroy
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  
		  iVar3 = *(int *)(param1 + 0x10);
		  if (0 < *(int *)(iVar3 + 0xc)) {
		    iVar1 = 0;
		    iVar4 = *(int *)(param1 + 0x2c);
		    if (iVar4 < 1) {
		      do {
		        uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                          (*(undefined4 *)(iVar3 + iVar1 * 4 + 0x10),0);
		        Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                  (uVar2,0,0);
		        iVar1 = iVar1 + 1;
		      } while (iVar1 < *(int *)(iVar3 + 0xc));
		    }
		    else {
		      do {
		        uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                          (*(undefined4 *)(iVar3 + iVar1 * 4 + 0x10),0);
		        Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                  (uVar2,(uint)(*(int *)(param1 + 0x24) < iVar4),0);
		        iVar1 = iVar1 + 1;
		      } while (iVar1 < *(int *)(iVar3 + 0xc));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x060038D1 RID: 14545 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60038D1")]
		[Address(RVA = "0x886F", Offset = "0x886F", VA = "0x886F")]
		private void Awake()
		{
		/* --- GHIDRA: Awake ---
		void Gameplay_Combat_View_Players_LongEffects_LongEffectsView__Awake(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a56718 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_View_Players_LongEffects_LongEffectsView_HandleDownClickEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Combat_View_Players_LongEffects_LongEffectsView_HandleUpClickEvent__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a56718 = '\x01';
		  }
		  uVar2 = *(undefined4 *)(*(int *)(param1 + 0x14) + 0xb4);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar1,param1,
		             Method_Gameplay_Combat_View_Players_LongEffects_LongEffectsView_HandleUpClickEvent__,0)
		  ;
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(*(int *)(param1 + 0x18) + 0xb4);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar1,param1,
		             Method_Gameplay_Combat_View_Players_LongEffects_LongEffectsView_HandleDownClickEvent__,
		             0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar2,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x060038D2 RID: 14546 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60038D2")]
		[Address(RVA = "0x8870", Offset = "0x8870", VA = "0x8870")]
		private void Start()
		{
		/* --- GHIDRA: Start ---
		void Gameplay_Combat_View_Players_LongEffects_LongEffectsView__Start
		               (int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  
		  iVar3 = *(int *)(param1 + 0x10);
		  if (0 < *(int *)(iVar3 + 0xc)) {
		    iVar1 = 0;
		    if (param2 < 1) {
		      do {
		        uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                          (*(undefined4 *)(iVar3 + iVar1 * 4 + 0x10),0);
		        Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                  (uVar2,0,0);
		        iVar1 = iVar1 + 1;
		      } while (iVar1 < *(int *)(iVar3 + 0xc));
		    }
		    else {
		      do {
		        uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                          (*(undefined4 *)(iVar3 + iVar1 * 4 + 0x10),0);
		        Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                  (uVar2,(uint)(*(int *)(param1 + 0x24) < param2),0);
		        iVar1 = iVar1 + 1;
		      } while (iVar1 < *(int *)(iVar3 + 0xc));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x060038D3 RID: 14547 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60038D3")]
		[Address(RVA = "0x8871", Offset = "0x8871", VA = "0x8871")]
		private void ValidateControls(int count)
		{
		/* --- GHIDRA: ValidateControls ---
		void Gameplay_Combat_View_Players_LongEffects_LongEffectsView__ValidateControls
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined1 auStack_10 [12];
		  float4 local_4;
		  
		  local_4 = 0.0;
		  iVar1 = Gameplay_Combat_View_Players_LongEffects_LongEffectsView__HandleUpClickEvent
		                    (param1,1,&local_4,auStack_10);
		  if (iVar1 != 0) {
		    DG_Tweening_DOTweenModuleUI__DOHorizontalNormalizedPos
		              (*(undefined4 *)(param1 + 0x20),(float)local_4,*(float *)(param1 + 0x28),0,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x060038D4 RID: 14548 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60038D4")]
		[Address(RVA = "0x8872", Offset = "0x8872", VA = "0x8872")]
		private void HandleDownClickEvent()
		{
		/* --- GHIDRA: HandleDownClickEvent ---
		void Gameplay_Combat_View_Players_LongEffects_LongEffectsView__HandleDownClickEvent
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined1 auStack_10 [12];
		  float4 local_4;
		  
		  local_4 = 0.0;
		  iVar1 = Gameplay_Combat_View_Players_LongEffects_LongEffectsView__HandleUpClickEvent
		                    (param1,0,&local_4,auStack_10);
		  if (iVar1 != 0) {
		    DG_Tweening_DOTweenModuleUI__DOHorizontalNormalizedPos
		              (*(undefined4 *)(param1 + 0x20),(float)local_4,*(float *)(param1 + 0x28),0,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x060038D5 RID: 14549 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60038D5")]
		[Address(RVA = "0x8873", Offset = "0x8873", VA = "0x8873")]
		private void HandleUpClickEvent()
		{
		/* --- GHIDRA: HandleUpClickEvent ---
		uint Gameplay_Combat_View_Players_LongEffects_LongEffectsView__HandleUpClickEvent
		               (int param1,int param2,float *param3,undefined4 param4)
		
		{
		  float4 fVar1;
		  int *piVar2;
		  float fVar3;
		  float fVar4;
		  float fVar5;
		  undefined1 auStack_8 [4];
		  float4 local_4;
		  
		  if (DAT_ram_00a56719 == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_RectTransform_TypeInfo);
		    DAT_ram_00a56719 = '\x01';
		  }
		  piVar2 = (int *)System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                            (*(undefined4 *)(param1 + 0x20),0);
		  if ((piVar2 != (int *)0x0) && (UnityEngine_RectTransform_TypeInfo != *piVar2)) {
		    System_Activator__CreateInstance(piVar2,UnityEngine_RectTransform_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  UnityEngine_RectTransform__set_anchoredPosition(auStack_8,piVar2,0);
		  fVar1 = local_4;
		  piVar2 = (int *)System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                            (*(undefined4 *)(*(int *)(param1 + 0x20) + 0x10),0);
		  if ((piVar2 != (int *)0x0) && (UnityEngine_RectTransform_TypeInfo != *piVar2)) {
		    System_Activator__CreateInstance(piVar2,UnityEngine_RectTransform_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  UnityEngine_RectTransform__set_anchoredPosition(auStack_8,piVar2,0);
		  if ((float)local_4 <= (float)fVar1 == 0) {
		    fVar3 = UnityEngine_UI_ScrollRect__set_horizontalNormalizedPosition
		                      (*(undefined4 *)(param1 + 0x20),0);
		    fVar5 = ((float)local_4 - (float)fVar1) * (1.0 - fVar3);
		    fVar3 = (float)fVar1 / ((float)local_4 - (float)fVar1);
		    if (param2 == 0) {
		      fVar4 = UnityEngine_UI_ScrollRect__set_horizontalNormalizedPosition
		                        (*(undefined4 *)(param1 + 0x20),0);
		      if (fVar5 < (float)fVar1) {
		        fVar3 = fVar3 * (fVar5 / (float)fVar1);
		      }
		      fVar4 = fVar4 + fVar3;
		    }
		    else {
		      fVar4 = UnityEngine_UI_ScrollRect__set_horizontalNormalizedPosition
		                        (*(undefined4 *)(param1 + 0x20),0);
		      fVar5 = (float)local_4 - ((float)fVar1 + fVar5);
		      if (fVar5 < (float)fVar1) {
		        fVar3 = fVar3 * (fVar5 / (float)fVar1);
		      }
		      fVar4 = fVar4 - fVar3;
		    }
		  }
		  else {
		    fVar4 = 0.0;
		  }
		  *param3 = fVar4;
		  return (float)local_4 <= (float)fVar1 ^ 1;
		}
		*/

		}

		// Token: 0x060038D6 RID: 14550 RVA: 0x0000B478 File Offset: 0x00009678
		[Token(Token = "0x60038D6")]
		[Address(RVA = "0x8874", Offset = "0x8874", VA = "0x8874")]
		private bool GetScrollValue(bool scrollDown, out float position)
		{
			return default(bool);
		}

		// Token: 0x060038D7 RID: 14551 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60038D7")]
		[Address(RVA = "0x8875", Offset = "0x8875", VA = "0x8875")]
		public LongEffectsView()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Combat_View_Players_LongEffects_LongEffectsView___ctor
		               (int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  int param1_01;
		  int local_4;
		  
		  if (DAT_ram_00a5671a == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_GameObject_TryGetComponent_LongEffectV2___);
		    DAT_ram_00a5671a = '\x01';
		  }
		  local_4 = 0;
		  iVar1 = func_ii_8014(*(undefined4 *)(param2 + 0x28),&local_4,
		                       Method_UnityEngine_GameObject_TryGetComponent_LongEffectV2___);
		  if (iVar1 != 0) {
		    iVar1 = *(int *)(local_4 + 0x34);
		    param1_01 = *(int *)(param1 + 0x30);
		    param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                          (param1_01,0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (param1_00,(uint)(iVar1 != *(int *)(*(int *)(param1_01 + 0x10) + 0x2c)),0);
		    if (iVar1 == *(int *)(*(int *)(param1_01 + 0x10) + 0x2c)) {
		      iVar1 = 0;
		    }
		    UI_ToolTip_Implementations_View_Combat_CombatLongEffectToolTipItemView__get_Data
		              (*(int *)(param1_01 + 0x10),iVar1,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x04001F5E RID: 8030
		[Token(Token = "0x4001F5E")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Transform[] _controls;

		// Token: 0x04001F5F RID: 8031
		[Token(Token = "0x4001F5F")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Button _upButton;

		// Token: 0x04001F60 RID: 8032
		[Token(Token = "0x4001F60")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Button _downButton;

		// Token: 0x04001F61 RID: 8033
		[Token(Token = "0x4001F61")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private Transform _longEffectConatiner;

		// Token: 0x04001F62 RID: 8034
		[Token(Token = "0x4001F62")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		protected ScrollRect _scrollView;

		// Token: 0x04001F63 RID: 8035
		[Token(Token = "0x4001F63")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		[Range(7f, 200f)]
		private int _maxCountForScroll;

		// Token: 0x04001F64 RID: 8036
		[Token(Token = "0x4001F64")]
		[FieldOffset(Offset = "0x28")]
		private float _scrollDuration;

		// Token: 0x04001F65 RID: 8037
		[Token(Token = "0x4001F65")]
		[FieldOffset(Offset = "0x2C")]
		private int _count;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_LongEffectContainer ---
		void Gameplay_Combat_View_Players_LongEffects_LongEffectsView__get_LongEffectContainer
		               (int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  
		  *(int *)(param1 + 0x2c) = param2;
		  iVar3 = *(int *)(param1 + 0x10);
		  if (0 < *(int *)(iVar3 + 0xc)) {
		    iVar1 = 0;
		    if (param2 < 1) {
		      do {
		        uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                          (*(undefined4 *)(iVar3 + iVar1 * 4 + 0x10),0);
		        Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                  (uVar2,0,0);
		        iVar1 = iVar1 + 1;
		      } while (iVar1 < *(int *)(iVar3 + 0xc));
		    }
		    else {
		      do {
		        uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                          (*(undefined4 *)(iVar3 + iVar1 * 4 + 0x10),0);
		        Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                  (uVar2,(uint)(*(int *)(param1 + 0x24) < param2),0);
		        iVar1 = iVar1 + 1;
		      } while (iVar1 < *(int *)(iVar3 + 0xc));
		    }
		  }
		  return;
		}
		*/

}
