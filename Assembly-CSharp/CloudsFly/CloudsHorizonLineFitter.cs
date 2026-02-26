using System;
using System.Collections;
using CloudsFly.WebGL;
using Il2CppDummyDll;
using UnityEngine;

namespace CloudsFly
{
	// Token: 0x020012FD RID: 4861
	[Token(Token = "0x20012FD")]
	public class CloudsHorizonLineFitter : MonoBehaviour
	{
		// Token: 0x060073AC RID: 29612 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60073AC")]
		[Address(RVA = "0xBD93", Offset = "0xBD93", VA = "0xBD93")]
		private void OnDisable()
		{
		/* --- GHIDRA: OnDisable ---
		void CloudsFly_CloudsHorizonLineFitter__OnDisable(undefined4 param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  int param2_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a59684 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_CloudsFly_CloudsHorizonLineFitter_OnGameContentScaledEvent__);
		    DAT_ram_00a59684 = '\x01';
		  }
		  if (DAT_ram_00a5b8f1 == '\0') {
		    Mono_Security_ASN1__get_Item(&ScreenAdaptation_Scale_GameScaler_TypeInfo);
		    DAT_ram_00a5b8f1 = '\x01';
		  }
		  param1_01 = **(undefined4 **)(ScreenAdaptation_Scale_GameScaler_TypeInfo + 0x5c);
		  param1_00 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (param1_00,param1,Method_CloudsFly_CloudsHorizonLineFitter_OnGameContentScaledEvent__,0)
		  ;
		  ScreenAdaptation_Scale_GameScaler__Awake(param1_01,param1_00,0);
		  if (DAT_ram_00a59685 == '\0') {
		    Mono_Security_ASN1__get_Item(&CloudsFly_CloudsHorizonLineFitter__AdaptRoutine_d__7_TypeInfo);
		    DAT_ram_00a59685 = '\x01';
		  }
		  param2_00 = unnamed_function_1417(CloudsFly_CloudsHorizonLineFitter__AdaptRoutine_d__7_TypeInfo);
		  *(undefined4 *)(param2_00 + 0x10) = param1;
		  *(undefined4 *)(param2_00 + 8) = 0;
		  UnityEngine_MonoBehaviour__StartCoroutine(param1,param2_00,0);
		  return;
		}
		*/

		}

		// Token: 0x060073AD RID: 29613 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60073AD")]
		[Address(RVA = "0xBD94", Offset = "0xBD94", VA = "0xBD94")]
		private void OnEnable()
		{
		/* --- GHIDRA: OnEnable ---
		void CloudsFly_CloudsHorizonLineFitter__OnEnable(undefined4 param1,undefined4 param2)
		
		{
		  int param2_00;
		  
		  if (DAT_ram_00a59685 == '\0') {
		    Mono_Security_ASN1__get_Item(&CloudsFly_CloudsHorizonLineFitter__AdaptRoutine_d__7_TypeInfo);
		    DAT_ram_00a59685 = '\x01';
		  }
		  param2_00 = unnamed_function_1417(CloudsFly_CloudsHorizonLineFitter__AdaptRoutine_d__7_TypeInfo);
		  *(undefined4 *)(param2_00 + 0x10) = param1;
		  *(undefined4 *)(param2_00 + 8) = 0;
		  UnityEngine_MonoBehaviour__StartCoroutine(param1,param2_00,0);
		  return;
		}
		*/

		}

		// Token: 0x060073AE RID: 29614 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60073AE")]
		[Address(RVA = "0xBD95", Offset = "0xBD95", VA = "0xBD95")]
		private void OnGameContentScaledEvent()
		{
		/* --- GHIDRA: OnGameContentScaledEvent ---
		int CloudsFly_CloudsHorizonLineFitter__OnGameContentScaledEvent(undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a59685 == '\0') {
		    Mono_Security_ASN1__get_Item(&CloudsFly_CloudsHorizonLineFitter__AdaptRoutine_d__7_TypeInfo);
		    DAT_ram_00a59685 = '\x01';
		  }
		  iVar1 = unnamed_function_1417(CloudsFly_CloudsHorizonLineFitter__AdaptRoutine_d__7_TypeInfo);
		  *(undefined4 *)(iVar1 + 0x10) = param1;
		  *(undefined4 *)(iVar1 + 8) = 0;
		  return iVar1;
		}
		*/

		}

		// Token: 0x060073AF RID: 29615 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60073AF")]
		[Address(RVA = "0xBD96", Offset = "0xBD96", VA = "0xBD96")]
		private IEnumerator AdaptRoutine()
		{
		/* --- GHIDRA: AdaptRoutine ---
		void CloudsFly_CloudsHorizonLineFitter__AdaptRoutine(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a59686 == '\0') {
		    Mono_Security_ASN1__get_Item(&CloudsFly_WebGL_CloudsHorizonSolver_TypeInfo);
		    DAT_ram_00a59686 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(CloudsFly_WebGL_CloudsHorizonSolver_TypeInfo);
		  *(undefined4 *)(param1 + 0x1c) = uVar1;
		  UnityEngine_RectTransform__GetParentSize(param1,0);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x060073B0 RID: 29616 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60073B0")]
		[Address(RVA = "0xBD97", Offset = "0xBD97", VA = "0xBD97")]
		public CloudsHorizonLineFitter()
		{
		}

		// Token: 0x04003C94 RID: 15508
		[Token(Token = "0x4003C94")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private RectTransform _background;

		// Token: 0x04003C95 RID: 15509
		[Token(Token = "0x4003C95")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private RectTransform _backgroundContainer;

		// Token: 0x04003C96 RID: 15510
		[Token(Token = "0x4003C96")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Camera _camera;

		// Token: 0x04003C97 RID: 15511
		[Token(Token = "0x4003C97")]
		[FieldOffset(Offset = "0x1C")]
		private readonly CloudsHorizonSolver _cloudsHorizonSolver;
	}
}
