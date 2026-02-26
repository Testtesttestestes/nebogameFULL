using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace UI.Utils
{
	// Token: 0x02000120 RID: 288
	[Token(Token = "0x2000120")]
	public class LateUpdateOnceInvoker : MonoBehaviour
	{
		// Token: 0x060008F5 RID: 2293 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008F5")]
		[Address(RVA = "0x5C74", Offset = "0x5C74", VA = "0x5C74")]
		private void LateUpdate()
		{
		}

		// Token: 0x060008F6 RID: 2294 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008F6")]
		[Address(RVA = "0x5C75", Offset = "0x5C75", VA = "0x5C75")]
		public LateUpdateOnceInvoker()
		{
		/* --- GHIDRA: .ctor ---
		void UI_Utils_LateUpdateOnceInvoker___ctor(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int *piVar2;
		  int iVar3;
		  
		  if (DAT_ram_00a5b8b0 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TMP_TextInfo__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_LayoutElement___);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_RectTransform___);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_TextMeshProUGUI___);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Utils_LayoutElementTMPBoundsPreferedWidthSetter_TextFiledOnOnPreRenderText__
		              );
		    DAT_ram_00a5b8b0 = '\x01';
		  }
		  uVar1 = func_ii_5677(param1,Method_UnityEngine_Component_GetComponent_TextMeshProUGUI___);
		  *(undefined4 *)(param1 + 0x14) = uVar1;
		  uVar1 = func_ii_5677(param1,Method_UnityEngine_Component_GetComponent_LayoutElement___);
		  *(undefined4 *)(param1 + 0x18) = uVar1;
		  uVar1 = func_ii_5677(param1,Method_UnityEngine_Component_GetComponent_RectTransform___);
		  *(undefined4 *)(param1 + 0x10) = uVar1;
		  piVar2 = *(int **)(param1 + 0x14);
		  uVar1 = unnamed_function_1417(System_Action_TMP_TextInfo__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,
		             Method_UI_Utils_LayoutElementTMPBoundsPreferedWidthSetter_TextFiledOnOnPreRenderText__,
		             0);
		  iVar3 = *piVar2;
		  (**(code **)((ulonglong)*(uint *)(iVar3 + 0x330) * 4))
		            (piVar2,uVar1,*(undefined4 *)(iVar3 + 0x334));
		  return;
		}
		*/

		}

		// Token: 0x04000347 RID: 839
		[Token(Token = "0x4000347")]
		[FieldOffset(Offset = "0x10")]
		public UnityEvent SomeCall;

		// Token: 0x04000348 RID: 840
		[Token(Token = "0x4000348")]
		[FieldOffset(Offset = "0x14")]
		private bool _isCall;
	}
}
