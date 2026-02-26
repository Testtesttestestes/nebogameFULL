using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UI.Utils
{
	// Token: 0x02000121 RID: 289
	[Token(Token = "0x2000121")]
	[RequireComponent(typeof(TextMeshProUGUI))]
	[RequireComponent(typeof(LayoutElement))]
	public class LayoutElementTMPBoundsPreferedWidthSetter : MonoBehaviour
	{
		// Token: 0x060008F7 RID: 2295 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008F7")]
		[Address(RVA = "0x5C76", Offset = "0x5C76", VA = "0x5C76")]
		private void Start()
		{
		/* --- GHIDRA: Start ---
		void UI_Utils_LayoutElementTMPBoundsPreferedWidthSetter__Start
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  int *piVar1;
		  float fVar2;
		  int iVar3;
		  undefined1 auStack_18 [8];
		  float4 local_10;
		  float4 local_c;
		  
		  if (DAT_ram_00a5b8b1 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TMP_TextInfo__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Utils_LayoutElementTMPBoundsPreferedWidthSetter_TextFiledOnOnPreRenderText__
		              );
		    DAT_ram_00a5b8b1 = '\x01';
		  }
		  piVar1 = *(int **)(param1 + 0x14);
		  param1_00 = unnamed_function_1417(System_Action_TMP_TextInfo__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_UI_Utils_LayoutElementTMPBoundsPreferedWidthSetter_TextFiledOnOnPreRenderText__,
		             0);
		  iVar3 = *piVar1;
		  (**(code **)((ulonglong)*(uint *)(iVar3 + 0x338) * 4))
		            (piVar1,param1_00,*(undefined4 *)(iVar3 + 0x33c));
		  iVar3 = *(int *)(param2 + 0x20);
		  TMPro_TMP_Text__get_bounds(auStack_18,*(undefined4 *)(param2 + 8),0);
		  if (iVar3 < 2) {
		    iVar3 = **(int **)(param1 + 0x18);
		    (**(code **)((ulonglong)*(uint *)(iVar3 + 0x1e0) * 4))
		              (*(int **)(param1 + 0x18),0xbf800000,*(undefined4 *)(iVar3 + 0x1e4));
		  }
		  else {
		    UnityEngine_RectTransform__remove_reapplyDrivenProperties
		              (auStack_18,*(undefined4 *)(param1 + 0x10),0);
		    fVar2 = CEIL((float)local_c + (float)local_c + 10.0);
		    if (fVar2 < (float)local_10) {
		      iVar3 = **(int **)(param1 + 0x18);
		      (**(code **)((ulonglong)*(uint *)(iVar3 + 0x1e0) * 4))
		                (*(int **)(param1 + 0x18),fVar2,*(undefined4 *)(iVar3 + 0x1e4));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x060008F8 RID: 2296 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008F8")]
		[Address(RVA = "0x5C77", Offset = "0x5C77", VA = "0x5C77")]
		private void TextFiledOnOnPreRenderText(TMP_TextInfo info)
		{
		}

		// Token: 0x060008F9 RID: 2297 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008F9")]
		[Address(RVA = "0x5C78", Offset = "0x5C78", VA = "0x5C78")]
		public LayoutElementTMPBoundsPreferedWidthSetter()
		{
		}

		// Token: 0x04000349 RID: 841
		[Token(Token = "0x4000349")]
		[FieldOffset(Offset = "0x10")]
		private RectTransform _textFieldRectTransform;

		// Token: 0x0400034A RID: 842
		[Token(Token = "0x400034A")]
		[FieldOffset(Offset = "0x14")]
		private TextMeshProUGUI _textFiled;

		// Token: 0x0400034B RID: 843
		[Token(Token = "0x400034B")]
		[FieldOffset(Offset = "0x18")]
		private LayoutElement _layoutElement;
	}
}
