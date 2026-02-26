using System;
using System.Collections;
using System.Collections.Generic;
using AssetContent.Loaders;
using Core.MVC.Interfaces;
using Il2CppDummyDll;
using TMPro;
using UI.Tweens;
using UnityEngine;
using UnityEngine.Pool;

namespace Gameplay.Competition.View.GetRatingRewardWidget
{
	// Token: 0x020008E9 RID: 2281
	[Token(Token = "0x20008E9")]
	public class CompetitionGetRatingView : MonoBehaviour
	{
		// Token: 0x17000AA8 RID: 2728
		// (get) Token: 0x060035BE RID: 13758 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000AA8")]
		public GameImageLoader Icon
		{
			[Token(Token = "0x60035BE")]
			[Address(RVA = "0x85CC", Offset = "0x85CC", VA = "0x85CC")]
			get
			{
				return null;
			}
		}

		// Token: 0x060035BF RID: 13759 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60035BF")]
		[Address(RVA = "0x85CD", Offset = "0x85CD", VA = "0x85CD")]
		private CompetitionGetRatingView()
		{
		/* --- GHIDRA: <.ctor>b__19_1 ---
		void Gameplay_Competition_View_GetRatingRewardWidget_CompetitionGetRatingView____ctor_b__19_1
		               (undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a63aae == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Competition_View_GetRatingRewardWidget_CompetitionGetRatingView___c_TypeInfo
		              );
		    DAT_ram_00a63aae = '\x01';
		  }
		  uVar1 = unnamed_function_1417
		                    (
		                    Gameplay_Competition_View_GetRatingRewardWidget_CompetitionGetRatingView___c_TypeInfo
		                    );
		  **(undefined4 **)
		    (Gameplay_Competition_View_GetRatingRewardWidget_CompetitionGetRatingView___c_TypeInfo + 0x5c) =
		       uVar1;
		  return;
		}
		*/

		/* --- GHIDRA: <.ctor>b__19_0 ---
		void Gameplay_Competition_View_GetRatingRewardWidget_CompetitionGetRatingView____ctor_b__19_0
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined8 local_20;
		  undefined4 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (param2,0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,1,0);
		  uVar1 = UI_Tweens_TweeningValue__get_ValueTransform(param2,0);
		  UnityEngine_RectTransform__set_anchorMax(&local_8,*(undefined4 *)(param1 + 0x20),0);
		  local_10 = local_8;
		  UnityEngine_RectTransform__get_anchoredPosition(uVar1,&local_10,0);
		  uVar1 = UI_Tweens_TweeningValue__get_Value(param2,0);
		  if (DAT_ram_00a6501f == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Vector3_TypeInfo);
		    DAT_ram_00a6501f = '\x01';
		  }
		  local_18 = *(undefined4 *)(*(int *)(UnityEngine_Vector3_TypeInfo + 0x5c) + 0x14);
		  local_20 = *(undefined8 *)(*(int *)(UnityEngine_Vector3_TypeInfo + 0x5c) + 0xc);
		  Com_TheFallenGames_OSA_Core_OSA_object__object___SetNormalizedPosition(uVar1,&local_20,0);
		  uVar1 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                    (param2,0);
		  UnityEngine_Transform__SetAsLastSibling(uVar1,0,0);
		  return;
		}
		*/

		/* --- GHIDRA: .ctor ---
		float Gameplay_Competition_View_GetRatingRewardWidget_CompetitionGetRatingView___ctor
		                (int param1,undefined4 param2)
		
		{
		  return *(float *)(*(int *)(param1 + 0x14) + 0x30);
		}
		*/

		}

		// Token: 0x17000AA9 RID: 2729
		// (get) Token: 0x060035C0 RID: 13760 RVA: 0x0000ADB8 File Offset: 0x00008FB8
		[Token(Token = "0x17000AA9")]
		public float Value
		{
			[Token(Token = "0x60035C0")]
			[Address(RVA = "0x85CE", Offset = "0x85CE", VA = "0x85CE")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x060035C1 RID: 13761 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60035C1")]
		[Address(RVA = "0x85CF", Offset = "0x85CF", VA = "0x85CF")]
		private void Awake()
		{
		/* --- GHIDRA: Awake ---
		void Gameplay_Competition_View_GetRatingRewardWidget_CompetitionGetRatingView__Awake
		               (int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *param1_00;
		  int iVar3;
		  
		  if (DAT_ram_00a63aa5 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_MVC_Interfaces_IViewMediator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Pool_ObjectPool_TweeningValue__Dispose__);
		    DAT_ram_00a63aa5 = '\x01';
		  }
		  param1_00 = *(int **)(param1 + 0x44);
		  iVar3 = *param1_00;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_MVC_Interfaces_IViewMediator_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)
		         ) {
		        puVar2 = (uint *)(iVar3 + *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x82337f21;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_MVC_Interfaces_IViewMediator_TypeInfo,0);
		code_r0x82337f21:
		  (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  UnityEngine_Pool_ObjectPool_object___Clear
		            (*(undefined4 *)(param1 + 0x50),
		             Method_UnityEngine_Pool_ObjectPool_TweeningValue__Dispose__);
		  return;
		}
		*/

		}

		// Token: 0x060035C2 RID: 13762 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60035C2")]
		[Address(RVA = "0x85D0", Offset = "0x85D0", VA = "0x85D0")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		int Gameplay_Competition_View_GetRatingRewardWidget_CompetitionGetRatingView__OnDestroy
		              (undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a63aa6 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Competition_View_GetRatingRewardWidget_CompetitionGetRatingView__Show_d__24_TypeInfo
		              );
		    DAT_ram_00a63aa6 = '\x01';
		  }
		  iVar1 = unnamed_function_1417
		                    (
		                    Gameplay_Competition_View_GetRatingRewardWidget_CompetitionGetRatingView__Show_d__24_TypeInfo
		                    );
		  *(undefined4 *)(iVar1 + 0x10) = param1;
		  *(undefined4 *)(iVar1 + 8) = 0;
		  return iVar1;
		}
		*/

		}

		// Token: 0x060035C3 RID: 13763 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60035C3")]
		[Address(RVA = "0x85D1", Offset = "0x85D1", VA = "0x85D1")]
		private IEnumerator Show()
		{
		/* --- GHIDRA: Show ---
		int Gameplay_Competition_View_GetRatingRewardWidget_CompetitionGetRatingView__Show
		              (undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a63aa7 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Competition_View_GetRatingRewardWidget_CompetitionGetRatingView__Hide_d__25_TypeInfo
		              );
		    DAT_ram_00a63aa7 = '\x01';
		  }
		  iVar1 = unnamed_function_1417
		                    (
		                    Gameplay_Competition_View_GetRatingRewardWidget_CompetitionGetRatingView__Hide_d__25_TypeInfo
		                    );
		  *(undefined4 *)(iVar1 + 0x10) = param1;
		  *(undefined4 *)(iVar1 + 8) = 0;
		  return iVar1;
		}
		*/

			return null;
		}

		// Token: 0x060035C4 RID: 13764 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60035C4")]
		[Address(RVA = "0x85D2", Offset = "0x85D2", VA = "0x85D2")]
		private IEnumerator Hide()
		{
		/* --- GHIDRA: Hide ---
		int Gameplay_Competition_View_GetRatingRewardWidget_CompetitionGetRatingView__Hide
		              (undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a63aa8 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Competition_View_GetRatingRewardWidget_CompetitionGetRatingView__Handle_d__26_TypeInfo
		              );
		    DAT_ram_00a63aa8 = '\x01';
		  }
		  iVar1 = unnamed_function_1417
		                    (
		                    Gameplay_Competition_View_GetRatingRewardWidget_CompetitionGetRatingView__Handle_d__26_TypeInfo
		                    );
		  *(undefined4 *)(iVar1 + 0x10) = param1;
		  *(undefined4 *)(iVar1 + 8) = 0;
		  return iVar1;
		}
		*/

			return null;
		}

		// Token: 0x060035C5 RID: 13765 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60035C5")]
		[Address(RVA = "0x85D3", Offset = "0x85D3", VA = "0x85D3")]
		private IEnumerator Handle()
		{
		/* --- GHIDRA: Handle ---
		int Gameplay_Competition_View_GetRatingRewardWidget_CompetitionGetRatingView__Handle
		              (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,float param5,
		              float param6,undefined4 param7,undefined4 param8)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a63aa9 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Competition_View_GetRatingRewardWidget_CompetitionGetRatingView__MoveToTarget_d__27_TypeInfo
		              );
		    DAT_ram_00a63aa9 = '\x01';
		  }
		  iVar1 = unnamed_function_1417
		                    (
		                    Gameplay_Competition_View_GetRatingRewardWidget_CompetitionGetRatingView__MoveToTarget_d__27_TypeInfo
		                    );
		  *(undefined4 *)(iVar1 + 0x24) = param1;
		  *(undefined4 *)(iVar1 + 8) = 0;
		  *(undefined4 *)(iVar1 + 0x20) = param4;
		  *(undefined4 *)(iVar1 + 0x14) = param3;
		  *(undefined4 *)(iVar1 + 0x10) = param2;
		  *(undefined1 *)(iVar1 + 0x28) = (undefined1)param7;
		  *(float *)(iVar1 + 0x1c) = param6;
		  *(float *)(iVar1 + 0x18) = param5;
		  return iVar1;
		}
		*/

			return null;
		}

		// Token: 0x060035C6 RID: 13766 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60035C6")]
		[Address(RVA = "0x85D4", Offset = "0x85D4", VA = "0x85D4")]
		private IEnumerator MoveToTarget(TweeningValue item, TweeningValue target, LinkedList<TweeningValue> visibleItems, float duration, float delay, bool skipAwaitCounter)
		{
		/* --- GHIDRA: MoveToTarget ---
		int Gameplay_Competition_View_GetRatingRewardWidget_CompetitionGetRatingView__MoveToTarget
		              (undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a63aaa == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Competition_View_GetRatingRewardWidget_CompetitionGetRatingView__Run_d__28_TypeInfo
		              );
		    DAT_ram_00a63aaa = '\x01';
		  }
		  iVar1 = unnamed_function_1417
		                    (
		                    Gameplay_Competition_View_GetRatingRewardWidget_CompetitionGetRatingView__Run_d__28_TypeInfo
		                    );
		  *(undefined4 *)(iVar1 + 0x10) = param1;
		  *(undefined4 *)(iVar1 + 8) = 0;
		  return iVar1;
		}
		*/

			return null;
		}

		// Token: 0x060035C7 RID: 13767 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60035C7")]
		[Address(RVA = "0x85D5", Offset = "0x85D5", VA = "0x85D5")]
		private IEnumerator Run()
		{
		/* --- GHIDRA: Run ---
		void Gameplay_Competition_View_GetRatingRewardWidget_CompetitionGetRatingView__Run
		               (int param1,float param2,undefined4 param3)
		
		{
		  UI_Tweens_TweeningValue__Display(*(undefined4 *)(param1 + 0x14),param2,0);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x060035C8 RID: 13768 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60035C8")]
		[Address(RVA = "0x44A1", Offset = "0x44A1", VA = "0x44A1")]
		public void Add(params float[] values)
		{
		}

		// Token: 0x060035C9 RID: 13769 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60035C9")]
		[Address(RVA = "0x85D6", Offset = "0x85D6", VA = "0x85D6")]
		public void SetValue(float value)
		{
		/* --- GHIDRA: SetValue ---
		void Gameplay_Competition_View_GetRatingRewardWidget_CompetitionGetRatingView__SetValue
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int param1_00;
		  int iVar2;
		  undefined4 param2_00;
		  uint uVar3;
		  
		  if (DAT_ram_00a63aac == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_float__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_float__ToArray__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_float___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_float__TypeInfo);
		    DAT_ram_00a63aac = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_Collections_Generic_List_float__TypeInfo);
		  Unity_Services_Core_Internal_UnityServicesInternal___c__DisplayClass33_0___InitializeServicesAsync_g__FailServicesInitialization_2
		            (param1_00,param2,Method_System_Collections_Generic_List_float___ctor__);
		  while (param2 != 0) {
		    iVar2 = UnityEngine_Random__Range(1,0xb,0);
		    iVar1 = Method_System_Collections_Generic_List_float__Add__;
		    *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		    param2 = param2 + -1;
		    uVar3 = *(uint *)(param1_00 + 0xc);
		    if (uVar3 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		      *(uint *)(param1_00 + 0xc) = uVar3 + 1;
		      *(float *)(*(int *)(param1_00 + 8) + uVar3 * 4 + 0x10) = (float)iVar2;
		    }
		    else {
		      func_ii_2840(param1_00,(float)iVar2,
		                   *(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		    }
		  }
		  param2_00 = UnityEngine_TextCore_Text_FontAsset__UpdateFontFeaturesForNewlyAddedGlyphs
		                        (param1_00,Method_System_Collections_Generic_List_float__ToArray__);
		  func_ii_17568(param1,param2_00,param1_00);
		  return;
		}
		*/

		}

		// Token: 0x060035CA RID: 13770 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60035CA")]
		[Address(RVA = "0x85D7", Offset = "0x85D7", VA = "0x85D7")]
		private void DebugAddValue(uint count = 1U)
		{
		/* --- GHIDRA: DebugAddValue ---
		undefined4
		Gameplay_Competition_View_GetRatingRewardWidget_CompetitionGetRatingView__DebugAddValue
		          (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a63aad == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Object_Instantiate_TweeningValue___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a63aad = '\x01';
		  }
		  uVar1 = *(undefined4 *)(param1 + 0x28);
		  param1_00 = *(undefined4 *)(param1 + 0x18);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  uVar1 = func_ii_6805(param1_00,uVar1,Method_UnityEngine_Object_Instantiate_TweeningValue___);
		  return uVar1;
		}
		*/

		}

		// Token: 0x04001D65 RID: 7525
		[Token(Token = "0x4001D65")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TextMeshProUGUI _valueTextField;

		// Token: 0x04001D66 RID: 7526
		[Token(Token = "0x4001D66")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private TweeningValue _target;

		// Token: 0x04001D67 RID: 7527
		[Token(Token = "0x4001D67")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TweeningValue _valuePrefab;

		// Token: 0x04001D68 RID: 7528
		[Token(Token = "0x4001D68")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private RectTransform _summatorAnchor;

		// Token: 0x04001D69 RID: 7529
		[Token(Token = "0x4001D69")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _queueValueAnchor;

		// Token: 0x04001D6A RID: 7530
		[Token(Token = "0x4001D6A")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x04001D6B RID: 7531
		[Token(Token = "0x4001D6B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform _valuesContainer;

		// Token: 0x04001D6C RID: 7532
		[Token(Token = "0x4001D6C")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private GameImageLoader _icon;

		// Token: 0x04001D6D RID: 7533
		[Token(Token = "0x4001D6D")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _showHideDuration;

		// Token: 0x04001D6E RID: 7534
		[Token(Token = "0x4001D6E")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float _moveItemsDuration;

		// Token: 0x04001D6F RID: 7535
		[Token(Token = "0x4001D6F")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _moveSummatorDuration;

		// Token: 0x04001D70 RID: 7536
		[Token(Token = "0x4001D70")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private float _moveSummatorDelay;

		// Token: 0x04001D71 RID: 7537
		[Token(Token = "0x4001D71")]
		[FieldOffset(Offset = "0x40")]
		private Coroutine _runRoutine;

		// Token: 0x04001D72 RID: 7538
		[Token(Token = "0x4001D72")]
		[FieldOffset(Offset = "0x44")]
		private IViewMediator _mediator;

		// Token: 0x04001D73 RID: 7539
		[Token(Token = "0x4001D73")]
		[FieldOffset(Offset = "0x48")]
		private Vector2 _startAnchoredPosition;

		// Token: 0x04001D74 RID: 7540
		[Token(Token = "0x4001D74")]
		[FieldOffset(Offset = "0x50")]
		private readonly ObjectPool<TweeningValue> _valuesPool;

		// Token: 0x04001D75 RID: 7541
		[Token(Token = "0x4001D75")]
		[FieldOffset(Offset = "0x54")]
		private readonly Queue<float> _queue;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Icon ---
		void Gameplay_Competition_View_GetRatingRewardWidget_CompetitionGetRatingView__get_Icon
		               (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  undefined4 uVar2;
		  undefined4 *puVar3;
		  int param1_01;
		  
		  if (DAT_ram_00a63aa3 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TweeningValue__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Competition_View_GetRatingRewardWidget_CompetitionGetRatingView___ctor_b__19_0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Competition_View_GetRatingRewardWidget_CompetitionGetRatingView___ctor_b__19_1__
		              );
		    Mono_Security_ASN1__get_Item(&System_Func_TweeningValue__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Pool_ObjectPool_TweeningValue___ctor__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Pool_ObjectPool_TweeningValue__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_Queue_float___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Queue_float__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Competition_View_GetRatingRewardWidget_CompetitionGetRatingView___c___ctor_b__19_2__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Competition_View_GetRatingRewardWidget_CompetitionGetRatingView___c_TypeInfo
		              );
		    DAT_ram_00a63aa3 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(System_Collections_Generic_Queue_float__TypeInfo);
		  Sirenix_Serialization_StackFormatter_object____Il2CppFullySharedGenericType___SerializeImplementation
		            (uVar1,Method_System_Collections_Generic_Queue_float___ctor__);
		  *(undefined4 *)(param1 + 0x54) = uVar1;
		  UnityEngine_RectTransform__GetParentSize(param1,0);
		  uVar1 = unnamed_function_1417(System_Func_TweeningValue__TypeInfo);
		  func_ii_19797(uVar1,param1,
		                Method_Gameplay_Competition_View_GetRatingRewardWidget_CompetitionGetRatingView___ctor_b__19_0__
		                ,0);
		  param1_00 = unnamed_function_1417(System_Action_TweeningValue__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_Competition_View_GetRatingRewardWidget_CompetitionGetRatingView___ctor_b__19_1__
		             ,0);
		  if (*(int *)(Gameplay_Competition_View_GetRatingRewardWidget_CompetitionGetRatingView___c_TypeInfo
		              + 0x74) == 0) {
		    func_ii_306000(
		                  Gameplay_Competition_View_GetRatingRewardWidget_CompetitionGetRatingView___c_TypeInfo
		                  );
		  }
		  puVar3 = *(undefined4 **)
		            (Gameplay_Competition_View_GetRatingRewardWidget_CompetitionGetRatingView___c_TypeInfo +
		            0x5c);
		  param1_01 = puVar3[1];
		  if (param1_01 == 0) {
		    if (*(int *)(
		                Gameplay_Competition_View_GetRatingRewardWidget_CompetitionGetRatingView___c_TypeInfo
		                + 0x74) == 0) {
		      func_ii_306000(
		                    Gameplay_Competition_View_GetRatingRewardWidget_CompetitionGetRatingView___c_TypeInfo
		                    );
		      puVar3 = *(undefined4 **)
		                (
		                Gameplay_Competition_View_GetRatingRewardWidget_CompetitionGetRatingView___c_TypeInfo
		                + 0x5c);
		    }
		    uVar2 = *puVar3;
		    param1_01 = unnamed_function_1417(System_Action_TweeningValue__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (param1_01,uVar2,
		               Method_Gameplay_Competition_View_GetRatingRewardWidget_CompetitionGetRatingView___c___ctor_b__19_2__
		               ,0);
		    *(int *)(*(int *)(
		                     Gameplay_Competition_View_GetRatingRewardWidget_CompetitionGetRatingView___c_TypeInfo
		                     + 0x5c) + 4) = param1_01;
		  }
		  uVar2 = unnamed_function_1417(UnityEngine_Pool_ObjectPool_TweeningValue__TypeInfo);
		  Coffee_UISoftMaskInternal_ObjectPool___Il2CppFullySharedGenericType___Return
		            (uVar2,uVar1,param1_00,param1_01,0,1,2,
		             s_var<private>_posTex__array<vec4<_ram_00002538 + 0x1d8,
		             Method_UnityEngine_Pool_ObjectPool_TweeningValue___ctor__);
		  *(undefined4 *)(param1 + 0x50) = uVar2;
		  return;
		}
		*/


		/* --- GHIDRA: get_Value ---
		void Gameplay_Competition_View_GetRatingRewardWidget_CompetitionGetRatingView__get_Value
		               (int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int *piVar2;
		  uint *puVar3;
		  undefined4 param3;
		  undefined4 param4;
		  undefined4 param1_00;
		  int iVar4;
		  undefined4 param5;
		  int iVar5;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a63aa4 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Competition_Control_CompetitionGetRatingViewMediator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_RectTransform_TypeInfo);
		    DAT_ram_00a63aa4 = '\x01';
		  }
		  UnityEngine_CanvasGroup__get_alpha(*(undefined4 *)(param1 + 0x24),0.0,0);
		  piVar2 = (int *)System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                            (param1,0);
		  if ((piVar2 != (int *)0x0) && (UnityEngine_RectTransform_TypeInfo != *piVar2)) {
		    System_Activator__CreateInstance(piVar2,UnityEngine_RectTransform_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  UnityEngine_RectTransform__set_anchorMax(&local_8,piVar2,0);
		  *(undefined8 *)(param1 + 0x48) = local_8;
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar2 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar4 = *piVar2;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x2a0);
		        goto code_r0x82337c53;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar2,Core_Gameplay_IGame_TypeInfo,0x3c);
		code_r0x82337c53:
		  iVar4 = (**(code **)((ulonglong)*puVar3 * 4))(piVar2,puVar3[1]);
		  iVar5 = **(int **)(iVar4 + 0x14);
		  param3 = (**(code **)((ulonglong)*(uint *)(iVar5 + 0x100) * 4))
		                     (*(int **)(iVar4 + 0x14),*(undefined4 *)(iVar5 + 0x104));
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar2 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar4 = *piVar2;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x2a0);
		        goto code_r0x82337d18;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar2,Core_Gameplay_IGame_TypeInfo,0x3c);
		code_r0x82337d18:
		  iVar4 = (**(code **)((ulonglong)*puVar3 * 4))(piVar2,puVar3[1]);
		  iVar5 = **(int **)(iVar4 + 0x14);
		  param4 = (**(code **)((ulonglong)*(uint *)(iVar5 + 0x110) * 4))
		                     (*(int **)(iVar4 + 0x14),*(undefined4 *)(iVar5 + 0x114));
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar2 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar4 = *piVar2;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x2a0);
		        goto code_r0x82337ddd;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar2,Core_Gameplay_IGame_TypeInfo,0x3c);
		code_r0x82337ddd:
		  iVar4 = (**(code **)((ulonglong)*puVar3 * 4))(piVar2,puVar3[1]);
		  param5 = *(undefined4 *)(iVar4 + 0x14);
		  param1_00 = unnamed_function_1417
		                        (Gameplay_Competition_Control_CompetitionGetRatingViewMediator_TypeInfo);
		  if (DAT_ram_00a63add == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractCozyViewMediator_CompetitionModel__CompetitionEvents__CompetitionController__CompetitionGetRatingView___ctor__
		              );
		    DAT_ram_00a63add = '\x01';
		  }
		  MVC_AbstractCozyViewMediator_object__object__object__object____ctor
		            (param1_00,param1,param3,param4,param5,
		             Method_MVC_AbstractCozyViewMediator_CompetitionModel__CompetitionEvents__CompetitionController__CompetitionGetRatingView___ctor__
		            );
		  *(undefined4 *)(param1 + 0x44) = param1_00;
		  return;
		}
		*/

}
