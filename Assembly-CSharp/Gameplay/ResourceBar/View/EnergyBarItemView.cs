using System;
using Il2CppDummyDll;
using UI.ToolTip;

namespace Gameplay.ResourceBar.View
{
	// Token: 0x0200054B RID: 1355
	[Token(Token = "0x200054B")]
	public class EnergyBarItemView : ResourceBarItemView
	{
		// Token: 0x0600208C RID: 8332 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600208C")]
		[Address(RVA = "0x71F1", Offset = "0x71F1", VA = "0x71F1", Slot = "8")]
		public override BaseToolTipData GetData()
		{
		/* --- GHIDRA: GetData ---
		void Gameplay_ResourceBar_View_EnergyBarItemView__GetData(undefined4 param1,undefined4 param2)
		
		{
		  Gameplay_ResourceBar_View_ResourceBarItemView__GetData(param1,param1);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x0600208D RID: 8333 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600208D")]
		[Address(RVA = "0x71F2", Offset = "0x71F2", VA = "0x71F2")]
		public EnergyBarItemView()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_ResourceBar_View_EnergyBarItemView___ctor
		               (int param1,int param2,float param3,undefined4 param4,undefined4 param5)
		
		{
		  bool bVar1;
		  undefined8 uVar2;
		  int param2_00;
		  undefined4 uVar3;
		  undefined4 param1_00;
		  undefined4 uVar4;
		  double dVar5;
		  int iVar6;
		  float param3_00;
		  longlong local_38;
		  undefined4 local_30;
		  longlong local_28;
		  undefined4 local_20;
		  undefined4 local_18;
		  float4 local_14;
		  undefined4 local_10;
		  undefined4 local_c;
		  float4 local_8;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a58324 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_ResourceBar_View_ResourceBarDeltaView_SetupCloud__);
		    Mono_Security_ASN1__get_Item(&Utils_StringUtils_TypeInfo);
		    Mono_Security_ASN1__get_Item(&DG_Tweening_TweenCallback_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_DG_Tweening_TweenSettingsExtensions_OnComplete_TweenerCore_Vector3__Vector3__VectorOptions____
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_DG_Tweening_TweenSettingsExtensions_OnStart_TweenerCore_Vector3__Vector3__VectorOptions____
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_DG_Tweening_TweenSettingsExtensions_SetDelay_TweenerCore_float__float__FloatOptions____
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_DG_Tweening_TweenSettingsExtensions_SetEase_TweenerCore_float__float__FloatOptions____
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_DG_Tweening_TweenSettingsExtensions_SetEase_TweenerCore_Vector3__Vector3__VectorOptions____
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_DG_Tweening_TweenSettingsExtensions_SetLink_TweenerCore_float__float__FloatOptions____
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_DG_Tweening_TweenSettingsExtensions_SetLink_TweenerCore_Vector3__Vector3__VectorOptions____
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_ResourceBar_View_ResourceBarDeltaView___c__DisplayClass4_0__ShowAnimation_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_ResourceBar_View_ResourceBarDeltaView___c__DisplayClass4_0_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28780);
		    Mono_Security_ASN1__get_Item(&StringLiteral_1226);
		    DAT_ram_00a58324 = '\x01';
		  }
		  param2_00 = unnamed_function_1417
		                        (
		                        Gameplay_ResourceBar_View_ResourceBarDeltaView___c__DisplayClass4_0_TypeInfo
		                        );
		  *(int *)(param2_00 + 0xc) = param1;
		  *(undefined4 *)(param2_00 + 8) = param4;
		  Utils_TweenContainer__AddTween(*(undefined4 *)(param1 + 0x3c),0);
		  *(int *)(param1 + 0x38) = param2;
		  dVar5 = *(double *)(param2 + 0x10);
		  if (dVar5 <= 0.0) {
		    if (*(int *)(Utils_StringUtils_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Utils_StringUtils_TypeInfo);
		    }
		    uVar3 = UI_SimpleIconValue__set_IconAssetId(dVar5,StringLiteral_28780,0);
		    uVar4 = (undefined4)((ulonglong)dVar5 >> 0x20);
		  }
		  else {
		    if (*(int *)(Utils_StringUtils_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Utils_StringUtils_TypeInfo);
		    }
		    uVar3 = UI_SimpleIconValue__set_IconAssetId(dVar5,StringLiteral_28780,0);
		    uVar4 = (undefined4)((ulonglong)dVar5 >> 0x20);
		    uVar3 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(StringLiteral_1226,uVar3,0);
		  }
		  iVar6 = **(int **)(param1 + 0x14);
		  uVar2 = CONCAT44(uVar4,*(int **)(param1 + 0x14));
		  param1_00 = (**(code **)((ulonglong)*(uint *)(iVar6 + 0x2c8) * 4))
		                        (uVar2,*(undefined4 *)(iVar6 + 0x2cc));
		  uVar4 = (undefined4)((ulonglong)uVar2 >> 0x20);
		  iVar6 = System_Collections_CollectionBase___ctor(param1_00,uVar3,0);
		  if (iVar6 == 0) {
		    iVar6 = **(int **)(param1 + 0x14);
		    (**(code **)((ulonglong)*(uint *)(iVar6 + 0x2d0) * 4))
		              (CONCAT44(uVar4,*(int **)(param1 + 0x14)),uVar3,*(undefined4 *)(iVar6 + 0x2d4));
		  }
		  dVar5 = *(double *)(*(int *)(param1 + 0x38) + 0x10);
		  uVar4 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                    (param1,0);
		  local_4 = 0;
		  local_20 = 0;
		  local_c = 0;
		  local_8 = -50.0;
		  bVar1 = dVar5 <= 0.0;
		  if (bVar1) {
		    local_8 = 30.0;
		  }
		  local_28 = (ulonglong)(uint)local_8 << 0x20;
		  Gameplay_Isles_User_View_IsleAccountMarkersLayerView__GetView(uVar4,&local_28,0);
		  uVar4 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                    (param1,0);
		  local_10 = 0;
		  local_30 = 0;
		  local_14 = 30.0;
		  if (bVar1) {
		    local_14 = -50.0;
		  }
		  local_18 = 0;
		  local_38 = (ulonglong)(uint)local_14 << 0x20;
		  uVar4 = DG_Tweening_ShortcutExtensions__DOMoveZ(uVar4,&local_38,param3,0,0);
		  uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (param1,0);
		  uVar4 = DG_Tweening_TweenSettingsExtensions__SetDelay_object_
		                    (uVar4,uVar3,
		                     Method_DG_Tweening_TweenSettingsExtensions_SetLink_TweenerCore_Vector3__Vector3__VectorOptions____
		                    );
		  uVar3 = 0xe;
		  if (*(double *)(*(int *)(param1 + 0x38) + 0x10) <= 0.0) {
		    uVar3 = 0xf;
		  }
		  uVar4 = DG_Tweening_ShortcutExtensions__DOScale
		                    (uVar4,uVar3,
		                     Method_DG_Tweening_TweenSettingsExtensions_SetEase_TweenerCore_Vector3__Vector3__VectorOptions____
		                    );
		  uVar3 = unnamed_function_1417(DG_Tweening_TweenCallback_TypeInfo);
		  DG_Tweening_Color2__op_Multiply
		            (uVar3,param1,Method_Gameplay_ResourceBar_View_ResourceBarDeltaView_SetupCloud__,0);
		  uVar4 = DG_Tweening_TweenSettingsExtensions__OnRewind_object_
		                    (uVar4,uVar3,
		                     Method_DG_Tweening_TweenSettingsExtensions_OnStart_TweenerCore_Vector3__Vector3__VectorOptions____
		                    );
		  uVar3 = unnamed_function_1417(DG_Tweening_TweenCallback_TypeInfo);
		  DG_Tweening_Color2__op_Multiply
		            (uVar3,param2_00,
		             Method_Gameplay_ResourceBar_View_ResourceBarDeltaView___c__DisplayClass4_0__ShowAnimation_b__0__
		             ,0);
		  uVar4 = DG_Tweening_TweenSettingsExtensions__From___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType____Il2CppFullySharedGenericStructType_
		                    (uVar4,uVar3,
		                     Method_DG_Tweening_TweenSettingsExtensions_OnComplete_TweenerCore_Vector3__Vector3__VectorOptions____
		                    );
		  Utils_TimeUtils___cctor(*(undefined4 *)(param1 + 0x3c),uVar4,0);
		  UnityEngine_CanvasGroup__get_alpha(*(undefined4 *)(param1 + 0x30),0.0,0);
		  param3_00 = param3 * 0.125;
		  uVar4 = Core_Animations_GameSpineUiAnimation__Play(*(undefined4 *)(param1 + 0x30),1.0,param3_00,0)
		  ;
		  uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x30),0);
		  uVar4 = DG_Tweening_TweenSettingsExtensions__SetDelay_object_
		                    (uVar4,uVar3,
		                     Method_DG_Tweening_TweenSettingsExtensions_SetLink_TweenerCore_float__float__FloatOptions____
		                    );
		  uVar4 = DG_Tweening_ShortcutExtensions__DOScale
		                    (uVar4,5,
		                     Method_DG_Tweening_TweenSettingsExtensions_SetEase_TweenerCore_float__float__FloatOptions____
		                    );
		  Utils_TimeUtils___cctor(*(undefined4 *)(param1 + 0x3c),uVar4,0);
		  uVar4 = Core_Animations_GameSpineUiAnimation__Play(*(undefined4 *)(param1 + 0x30),0.0,param3_00,0)
		  ;
		  uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x30),0);
		  uVar4 = DG_Tweening_TweenSettingsExtensions__SetDelay_object_
		                    (uVar4,uVar3,
		                     Method_DG_Tweening_TweenSettingsExtensions_SetLink_TweenerCore_float__float__FloatOptions____
		                    );
		  uVar4 = DG_Tweening_DOTweenModuleUI__DOFade
		                    (uVar4,param3 - param3_00,
		                     Method_DG_Tweening_TweenSettingsExtensions_SetDelay_TweenerCore_float__float__FloatOptions____
		                    );
		  uVar4 = DG_Tweening_ShortcutExtensions__DOScale
		                    (uVar4,6,
		                     Method_DG_Tweening_TweenSettingsExtensions_SetEase_TweenerCore_float__float__FloatOptions____
		                    );
		  Utils_TimeUtils___cctor(*(undefined4 *)(param1 + 0x3c),uVar4,0);
		  return;
		}
		*/

		}
	}
}
