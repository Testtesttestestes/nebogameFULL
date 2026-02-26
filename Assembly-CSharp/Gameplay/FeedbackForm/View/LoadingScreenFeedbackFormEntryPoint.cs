using System;
using Il2CppDummyDll;
using UI;
using UnityEngine;

namespace Gameplay.FeedbackForm.View
{
	// Token: 0x0200081A RID: 2074
	[Token(Token = "0x200081A")]
	public class LoadingScreenFeedbackFormEntryPoint : MonoBehaviour
	{
		// Token: 0x060030DF RID: 12511 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030DF")]
		[Address(RVA = "0x8142", Offset = "0x8142", VA = "0x8142")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void Gameplay_FeedbackForm_View_LoadingScreenFeedbackFormEntryPoint__OnDestroy
		               (int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a575f4 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IndexButtonBasic__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_FeedbackForm_View_LoadingScreenFeedbackFormEntryPoint_HandleFeedbackButtonClickEvent__
		              );
		    DAT_ram_00a575f4 = '\x01';
		  }
		  param1_01 = *(undefined4 *)(param1 + 0x10);
		  param1_00 = unnamed_function_1417(System_Action_IndexButtonBasic__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_FeedbackForm_View_LoadingScreenFeedbackFormEntryPoint_HandleFeedbackButtonClickEvent__
		             ,0);
		  UI_IndexButtonBasic__get_CanvasGroup(param1_01,param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x060030E0 RID: 12512 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030E0")]
		[Address(RVA = "0x8143", Offset = "0x8143", VA = "0x8143")]
		private void Awake()
		{
		/* --- GHIDRA: Awake ---
		void Gameplay_FeedbackForm_View_LoadingScreenFeedbackFormEntryPoint__Awake
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  undefined4 param1_00;
		  undefined4 param1_01;
		  int iVar3;
		  
		  uVar1 = 0;
		  if (DAT_ram_00a575f5 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_FeedbackForm_View_FeedbackFormWindow_FeedbackFormWindowArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_PopupController_Show_FeedbackFormWindow___);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12616);
		    DAT_ram_00a575f5 = '\x01';
		  }
		  uVar2 = System_Uri___ctor(0);
		  param1_00 = System_Globalization_TimeSpanFormat_FormatLiterals__get_Start(uVar2,0);
		  param1_01 = System_Uri___ctor(0);
		  iVar3 = System_Uri___ctor(0);
		  uVar2 = StringLiteral_12616;
		  if (*(int *)(iVar3 + 0x28) != 0) {
		    uVar1 = *(undefined4 *)(*(int *)(iVar3 + 0x28) + 0x14);
		  }
		  uVar1 = Gameplay_FeedbackForm_Model_Source_LoadScreenSource___ctor(param1_01,uVar1,uVar1);
		  iVar3 = unnamed_function_1417
		                    (Gameplay_FeedbackForm_View_FeedbackFormWindow_FeedbackFormWindowArgs_TypeInfo);
		  UI_Windows_BaseWindowArgs__Dispose(iVar3,0);
		  *(undefined4 *)(iVar3 + 0x1c) = uVar1;
		  Gameplay_Antiq_View_GroupReviewWindow_WindowArgs___ctor
		            (param1_00,uVar2,iVar3,Method_UI_Windows_PopupController_Show_FeedbackFormWindow___);
		  return;
		}
		*/

		}

		// Token: 0x060030E1 RID: 12513 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030E1")]
		[Address(RVA = "0x8144", Offset = "0x8144", VA = "0x8144")]
		private void HandleFeedbackButtonClickEvent(IndexButtonBasic button)
		{
		}

		// Token: 0x060030E2 RID: 12514 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030E2")]
		[Address(RVA = "0x8145", Offset = "0x8145", VA = "0x8145")]
		public LoadingScreenFeedbackFormEntryPoint()
		{
		}

		// Token: 0x04001AAE RID: 6830
		[Token(Token = "0x4001AAE")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private IndexButtonBasic _button;
	}
}
