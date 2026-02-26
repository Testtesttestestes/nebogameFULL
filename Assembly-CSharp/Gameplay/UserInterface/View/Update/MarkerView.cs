using System;
using DG.Tweening;
using Il2CppDummyDll;
using UI;

namespace Gameplay.UserInterface.View.Update
{
	// Token: 0x020003D0 RID: 976
	[Token(Token = "0x20003D0")]
	public class MarkerView : MonoBehaviourWithStates<RecommendedAppUpdateViewState>
	{
		// Token: 0x060016E3 RID: 5859 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016E3")]
		[Address(RVA = "0x68A2", Offset = "0x68A2", VA = "0x68A2")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void Gameplay_UserInterface_View_Update_MarkerView__OnDestroy
		               (int param1,undefined4 param2,int param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  undefined8 local_10;
		  undefined4 local_8;
		  
		  if (DAT_ram_00a59874 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_MonoBehaviourWithStates_RecommendedAppUpdateViewState__HandleCurrentStateChanged__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_DG_Tweening_TweenSettingsExtensions_SetLoops_TweenerCore_Vector3__Vector3__VectorOptions____
		              );
		    DAT_ram_00a59874 = '\x01';
		  }
		  UI_MonoBehaviourWithStates_Int32Enum____ctor
		            (param1,param2,param3,
		             Method_UI_MonoBehaviourWithStates_RecommendedAppUpdateViewState__HandleCurrentStateChanged__
		            );
		  uVar1 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                    (param1,0);
		  if (param3 == 1) {
		    uVar1 = DG_Tweening_ShortcutExtensions__DOLocalRotateQuaternion(uVar1,0.6,0.7,0);
		    uVar1 = DG_Tweening_TweenSettingsExtensions__SetLoops_object_
		                      (uVar1,0xffffffff,1,
		                       Method_DG_Tweening_TweenSettingsExtensions_SetLoops_TweenerCore_Vector3__Vector3__VectorOptions____
		                      );
		    *(undefined4 *)(param1 + 0x1c) = uVar1;
		  }
		  else {
		    if (DAT_ram_00a6501f == '\0') {
		      Mono_Security_ASN1__get_Item(&UnityEngine_Vector3_TypeInfo);
		      DAT_ram_00a6501f = '\x01';
		    }
		    local_8 = *(undefined4 *)(*(int *)(UnityEngine_Vector3_TypeInfo + 0x5c) + 0x14);
		    local_10 = *(undefined8 *)(*(int *)(UnityEngine_Vector3_TypeInfo + 0x5c) + 0xc);
		    Com_TheFallenGames_OSA_Core_OSA_object__object___SetNormalizedPosition(uVar1,&local_10,0);
		    if (*(int *)(param1 + 0x1c) != 0) {
		      func_ii_7891(*(int *)(param1 + 0x1c),0,0);
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x060016E4 RID: 5860 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016E4")]
		[Address(RVA = "0x68A3", Offset = "0x68A3", VA = "0x68A3", Slot = "4")]
		protected override void HandleCurrentStateChanged(RecommendedAppUpdateViewState fromState, RecommendedAppUpdateViewState toState)
		{
		/* --- GHIDRA: HandleCurrentStateChanged ---
		void Gameplay_UserInterface_View_Update_MarkerView__HandleCurrentStateChanged
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a59875 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_RecommendedAppUpdateViewState___ctor__);
		    DAT_ram_00a59875 = '\x01';
		  }
		  ScreenAdaptation_Common_AppSize__Update
		            (param1,Method_UI_MonoBehaviourWithStates_RecommendedAppUpdateViewState___ctor__);
		  return;
		}
		*/

		}

		// Token: 0x060016E5 RID: 5861 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016E5")]
		[Address(RVA = "0x68A4", Offset = "0x68A4", VA = "0x68A4")]
		public MarkerView()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_UserInterface_View_Update_MarkerView___ctor(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int *piVar3;
		  float4 local_4;
		  
		  if (DAT_ram_00a59876 == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_708);
		    DAT_ram_00a59876 = '\x01';
		  }
		  uVar2 = *(undefined4 *)(param1 + 0x20);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar1 = UnityEngine_Component__GetComponent_object_(uVar2,0);
		  if (iVar1 != 0) {
		    uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(param1 + 0x20),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar2,(uint)(0.0 < *(float *)(param1 + 0x28)),0);
		    piVar3 = *(int **)(param1 + 0x20);
		    local_4 = (float4)CEIL(*(float *)(param1 + 0x28) * 100.0);
		    uVar2 = System_Collections_Generic_List_float___GetEnumerator(&local_4,0);
		    uVar2 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(uVar2,StringLiteral_708,0);
		    iVar1 = *piVar3;
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0x2d0) * 4))
		              (piVar3,uVar2,*(undefined4 *)(iVar1 + 0x2d4));
		  }
		  return;
		}
		*/

		}

		// Token: 0x04000C20 RID: 3104
		[Token(Token = "0x4000C20")]
		[FieldOffset(Offset = "0x1C")]
		private Tween _scaleTween;
	}
}
