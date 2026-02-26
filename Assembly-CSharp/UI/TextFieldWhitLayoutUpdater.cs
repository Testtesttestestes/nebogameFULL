using System;
using Il2CppDummyDll;
using TMPro;
using UI.Utils;
using UnityEngine;

namespace UI
{
	// Token: 0x02000114 RID: 276
	[Token(Token = "0x2000114")]
	public class TextFieldWhitLayoutUpdater : MonoBehaviour
	{
		// Token: 0x1700011C RID: 284
		// (get) Token: 0x060008B7 RID: 2231 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060008B8 RID: 2232 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700011C")]
		public virtual string Text
		{
			[Token(Token = "0x60008B7")]
			[Address(RVA = "0x5C43", Offset = "0x5C43", VA = "0x5C43", Slot = "4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008B8")]
			[Address(RVA = "0x5C44", Offset = "0x5C44", VA = "0x5C44", Slot = "5")]
			set
			{
			}
		}

		// Token: 0x060008B9 RID: 2233 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008B9")]
		[Address(RVA = "0x5C45", Offset = "0x5C45", VA = "0x5C45")]
		public TextFieldWhitLayoutUpdater()
		{
		/* --- GHIDRA: .ctor ---
		void UI_TextFieldWhitLayoutUpdater___ctor(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  int *piVar2;
		  
		  if (DAT_ram_00a5b89c == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TMP_TextInfo__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_RectTransform___);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_TileAndScrollEntitieDescription_TextFieldOnOnPreRenderText__);
		    DAT_ram_00a5b89c = '\x01';
		  }
		  iVar1 = func_ii_5677(param1[4],Method_UnityEngine_Component_GetComponent_RectTransform___);
		  param1[8] = iVar1;
		  piVar2 = (int *)param1[4];
		  param1_00 = unnamed_function_1417(System_Action_TMP_TextInfo__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,Method_UI_TileAndScrollEntitieDescription_TextFieldOnOnPreRenderText__
		             ,0);
		  iVar1 = *piVar2;
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x330) * 4))
		            (piVar2,param1_00,*(undefined4 *)(iVar1 + 0x334));
		  (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))(param1,*(undefined4 *)(*param1 + 0xe4));
		  return;
		}
		*/

		}

		// Token: 0x04000324 RID: 804
		[Token(Token = "0x4000324")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		protected TextMeshProUGUI _textField;

		// Token: 0x04000325 RID: 805
		[Token(Token = "0x4000325")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private LayoutUpdater _layoutUpdater;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Text ---
		void UI_TextFieldWhitLayoutUpdater__get_Text(int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  int iVar2;
		  
		  iVar2 = **(int **)(param1 + 0x10);
		  (**(code **)((ulonglong)*(uint *)(iVar2 + 0x2d0) * 4))
		            (*(int **)(param1 + 0x10),param2,*(undefined4 *)(iVar2 + 0x2d4));
		  param1_00 = *(undefined4 *)(param1 + 0x14);
		  if (DAT_ram_00a5b8b2 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_RectTransform___);
		    DAT_ram_00a5b8b2 = '\x01';
		  }
		  uVar1 = func_ii_5677(param1_00,Method_UnityEngine_Component_GetComponent_RectTransform___);
		  if (DAT_ram_00a5b8b3 == '\0') {
		    Mono_Security_ASN1__get_Item(&UI_Utils_LayoutUpdater__SetDirty_d__2_TypeInfo);
		    DAT_ram_00a5b8b3 = '\x01';
		  }
		  iVar2 = unnamed_function_1417(UI_Utils_LayoutUpdater__SetDirty_d__2_TypeInfo);
		  *(undefined4 *)(iVar2 + 0x14) = param1_00;
		  *(undefined4 *)(iVar2 + 8) = 0;
		  *(undefined4 *)(iVar2 + 0x10) = uVar1;
		  UnityEngine_MonoBehaviour__StartCoroutine(param1_00,iVar2,0);
		  return;
		}
		*/

}
