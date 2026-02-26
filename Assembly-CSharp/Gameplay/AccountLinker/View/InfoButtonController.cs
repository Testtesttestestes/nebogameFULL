using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.AccountLinker.View
{
	// Token: 0x02000DFF RID: 3583
	[Token(Token = "0x2000DFF")]
	[DisallowMultipleComponent]
	[RequireComponent(typeof(Button))]
	public class InfoButtonController : MonoBehaviour
	{
		// Token: 0x06005760 RID: 22368 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005760")]
		[Address(RVA = "0xA4DB", Offset = "0xA4DB", VA = "0xA4DB")]
		private void Start()
		{
		/* --- GHIDRA: Start ---
		void Gameplay_AccountLinker_View_InfoButtonController__Start(undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a5891c == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_Button___);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_AccountLinker_View_InfoButtonController_OnInfoClick__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a5891c = '\x01';
		  }
		  iVar1 = func_ii_5677(param1,Method_UnityEngine_Component_GetComponent_Button___);
		  param1_01 = *(undefined4 *)(iVar1 + 0xb4);
		  param1_00 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (param1_00,param1,Method_Gameplay_AccountLinker_View_InfoButtonController_OnInfoClick__,
		             0);
		  UnityEngine_Events_UnityAction___ctor(param1_01,param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x06005761 RID: 22369 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005761")]
		[Address(RVA = "0xA4DC", Offset = "0xA4DC", VA = "0xA4DC")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void Gameplay_AccountLinker_View_InfoButtonController__OnDestroy(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param2_00;
		  undefined4 param3;
		  
		  if (DAT_ram_00a5891d == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_11743);
		    Mono_Security_ASN1__get_Item(&StringLiteral_9094);
		    DAT_ram_00a5891d = '\x01';
		  }
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  param1_00 = func_ii_7508(StringLiteral_9094,1,0,1,0,0,0,0);
		  param2_00 = func_ii_7508(*(undefined4 *)(param1 + 0x10),1,0,1,0,0,0,0);
		  param3 = func_ii_7508(StringLiteral_11743,1,0,1,0,0,0,0);
		  UI_Windows_DialogWindow__get_CANCEL_LABEL(param1_00,param2_00,param3,0);
		  return;
		}
		*/

		}

		// Token: 0x06005762 RID: 22370 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005762")]
		[Address(RVA = "0xA4DD", Offset = "0xA4DD", VA = "0xA4DD")]
		private void OnInfoClick()
		{
		}

		// Token: 0x06005763 RID: 22371 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005763")]
		[Address(RVA = "0xA4DE", Offset = "0xA4DE", VA = "0xA4DE")]
		public InfoButtonController()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_AccountLinker_View_InfoButtonController___ctor(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5891e == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_EnumValueInvoker_Provider___ctor__);
		    DAT_ram_00a5891e = '\x01';
		  }
		  ScreenAdaptation_Common_AppSize__Update(param1,Method_UI_EnumValueInvoker_Provider___ctor__);
		  return;
		}
		*/

		}

		// Token: 0x04002F57 RID: 12119
		[Token(Token = "0x4002F57")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private string _descriptionKey;
	}
}
