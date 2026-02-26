using System;
using System.Runtime.CompilerServices;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Il2CppDummyDll;
using UnityEngine;

namespace UI.Informer.Network
{
	// Token: 0x020001DB RID: 475
	[Token(Token = "0x20001DB")]
	public class WarnIconView : MonoBehaviour
	{
		// Token: 0x1700019C RID: 412
		// (get) Token: 0x06000C5C RID: 3164 RVA: 0x00003E58 File Offset: 0x00002058
		// (set) Token: 0x06000C5D RID: 3165 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700019C")]
		public float FadeoutDuration
		{
			[Token(Token = "0x6000C5C")]
			[Address(RVA = "0x5F6B", Offset = "0x5F6B", VA = "0x5F6B")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000C5D")]
			[Address(RVA = "0x5F6C", Offset = "0x5F6C", VA = "0x5F6C")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000C5E RID: 3166 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C5E")]
		[Address(RVA = "0x5F6D", Offset = "0x5F6D", VA = "0x5F6D")]
		private void OnEnable()
		{
		/* --- GHIDRA: OnEnable ---
		void UI_Informer_Network_WarnIconView__OnEnable(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a63918 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_Image___);
		    DAT_ram_00a63918 = '\x01';
		  }
		  uVar1 = func_ii_5677(param1,Method_UnityEngine_Component_GetComponent_Image___);
		  uVar1 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                    (uVar1,0);
		  func_ii_8007(uVar1,0,0);
		  *(undefined4 *)(param1 + 0x14) = 0;
		  return;
		}
		*/

		}

		// Token: 0x06000C5F RID: 3167 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C5F")]
		[Address(RVA = "0x5F6E", Offset = "0x5F6E", VA = "0x5F6E")]
		private void OnDisable()
		{
		/* --- GHIDRA: OnDisable ---
		void UI_Informer_Network_WarnIconView__OnDisable(int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  
		  *(undefined4 *)(param1 + 0x18) = param2;
		  if (*(int *)(param1 + 0x14) == 0) {
		    param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                          (param1,0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (param1_00,1,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06000C60 RID: 3168 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C60")]
		[Address(RVA = "0x5F6F", Offset = "0x5F6F", VA = "0x5F6F")]
		public void Show(int loops)
		{
		/* --- GHIDRA: Show ---
		void UI_Informer_Network_WarnIconView__Show(int param1,undefined4 param2)
		
		{
		  *(undefined4 *)(param1 + 0x18) = 0xffffffff;
		  *(undefined4 *)(param1 + 0x10) = 0x3f333333;
		  UnityEngine_RectTransform__GetParentSize(param1,0);
		  return;
		}
		*/

		}

		// Token: 0x06000C61 RID: 3169 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C61")]
		[Address(RVA = "0x5F70", Offset = "0x5F70", VA = "0x5F70")]
		public WarnIconView()
		{
		}

		// Token: 0x040005F5 RID: 1525
		[Token(Token = "0x40005F5")]
		[FieldOffset(Offset = "0x14")]
		private TweenerCore<Vector3, Vector3, VectorOptions> _tween;

		// Token: 0x040005F6 RID: 1526
		[Token(Token = "0x40005F6")]
		[FieldOffset(Offset = "0x18")]
		private int _loops;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_FadeoutDuration ---
		void UI_Informer_Network_WarnIconView__set_FadeoutDuration(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param1_00;
		  undefined8 local_30;
		  undefined4 local_28;
		  undefined8 local_20;
		  undefined4 local_18;
		  undefined8 local_10;
		  undefined4 local_8;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a63917 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_TryGetComponent_Image___);
		    Mono_Security_ASN1__get_Item(&DG_Tweening_TweenCallback_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_DG_Tweening_TweenSettingsExtensions_OnComplete_TweenerCore_Vector3__Vector3__VectorOptions____
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_DG_Tweening_TweenSettingsExtensions_SetLoops_TweenerCore_Vector3__Vector3__VectorOptions____
		              );
		    Mono_Security_ASN1__get_Item(&Method_UI_Informer_Network_WarnIconView__OnEnable_b__4_0__);
		    DAT_ram_00a63917 = '\x01';
		  }
		  local_4 = 0;
		  iVar1 = UnityEngine_UIElements_GroupBoxUtility__UnregisterGroupBoxOption_object_
		                    (param1,&local_4,Method_UnityEngine_Component_TryGetComponent_Image___);
		  if (iVar1 != 0) {
		    uVar2 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                      (local_4,0);
		    if (DAT_ram_00a6501f == '\0') {
		      Mono_Security_ASN1__get_Item(&UnityEngine_Vector3_TypeInfo);
		      DAT_ram_00a6501f = '\x01';
		    }
		    local_18 = *(undefined4 *)(*(int *)(UnityEngine_Vector3_TypeInfo + 0x5c) + 0x14);
		    local_20 = *(undefined8 *)(*(int *)(UnityEngine_Vector3_TypeInfo + 0x5c) + 0xc);
		    Com_TheFallenGames_OSA_Core_OSA_object__object___SetNormalizedPosition(uVar2,&local_20,0);
		    uVar2 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                      (local_4,0);
		    local_8 = 0;
		    local_28 = 0;
		    local_10 = 0x3fb333333fb33333;
		    local_30 = 0x3fb333333fb33333;
		    uVar2 = System_Collections_Generic_Queue_object___Dequeue
		                      (uVar2,&local_30,*(float *)(param1 + 0x10),0);
		    uVar2 = DG_Tweening_TweenSettingsExtensions__SetLoops_object_
		                      (uVar2,*(undefined4 *)(param1 + 0x18),1,
		                       Method_DG_Tweening_TweenSettingsExtensions_SetLoops_TweenerCore_Vector3__Vector3__VectorOptions____
		                      );
		    param1_00 = unnamed_function_1417(DG_Tweening_TweenCallback_TypeInfo);
		    DG_Tweening_Color2__op_Multiply
		              (param1_00,param1,Method_UI_Informer_Network_WarnIconView__OnEnable_b__4_0__,0);
		    uVar2 = DG_Tweening_TweenSettingsExtensions__From___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType____Il2CppFullySharedGenericStructType_
		                      (uVar2,param1_00,
		                       Method_DG_Tweening_TweenSettingsExtensions_OnComplete_TweenerCore_Vector3__Vector3__VectorOptions____
		                      );
		    *(undefined4 *)(param1 + 0x14) = uVar2;
		  }
		  return;
		}
		*/

}
