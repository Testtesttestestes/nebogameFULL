using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using WebGLSupport.Detail;

namespace WebGLSupport
{
	// Token: 0x0200002D RID: 45
	[Token(Token = "0x200002D")]
	internal class WrappedTMPInputField : IInputField
	{
		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060001E5 RID: 485 RVA: 0x00002718 File Offset: 0x00000918
		[Token(Token = "0x17000048")]
		public bool ReadOnly
		{
			[Token(Token = "0x60001E5")]
			[Address(RVA = "0x568F", Offset = "0x568F", VA = "0x568F", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060001E6 RID: 486 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060001E7 RID: 487 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000049")]
		public string text
		{
			[Token(Token = "0x60001E6")]
			[Address(RVA = "0x5690", Offset = "0x5690", VA = "0x5690", Slot = "7")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001E7")]
			[Address(RVA = "0x5691", Offset = "0x5691", VA = "0x5691", Slot = "8")]
			set
			{
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x060001E8 RID: 488 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700004A")]
		public string placeholder
		{
			[Token(Token = "0x60001E8")]
			[Address(RVA = "0x5692", Offset = "0x5692", VA = "0x5692", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x060001E9 RID: 489 RVA: 0x00002730 File Offset: 0x00000930
		[Token(Token = "0x1700004B")]
		public int fontSize
		{
			[Token(Token = "0x60001E9")]
			[Address(RVA = "0x5693", Offset = "0x5693", VA = "0x5693", Slot = "6")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x060001EA RID: 490 RVA: 0x00002748 File Offset: 0x00000948
		[Token(Token = "0x1700004C")]
		public ContentType contentType
		{
			[Token(Token = "0x60001EA")]
			[Address(RVA = "0x5694", Offset = "0x5694", VA = "0x5694", Slot = "4")]
			get
			{
				return ContentType.Standard;
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x060001EB RID: 491 RVA: 0x00002760 File Offset: 0x00000960
		[Token(Token = "0x1700004D")]
		public LineType lineType
		{
			[Token(Token = "0x60001EB")]
			[Address(RVA = "0x5695", Offset = "0x5695", VA = "0x5695", Slot = "5")]
			get
			{
				return LineType.SingleLine;
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x060001EC RID: 492 RVA: 0x00002778 File Offset: 0x00000978
		[Token(Token = "0x1700004E")]
		public int characterLimit
		{
			[Token(Token = "0x60001EC")]
			[Address(RVA = "0x5696", Offset = "0x5696", VA = "0x5696", Slot = "10")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x060001ED RID: 493 RVA: 0x00002790 File Offset: 0x00000990
		[Token(Token = "0x1700004F")]
		public int caretPosition
		{
			[Token(Token = "0x60001ED")]
			[Address(RVA = "0x5697", Offset = "0x5697", VA = "0x5697", Slot = "11")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x060001EE RID: 494 RVA: 0x000027A8 File Offset: 0x000009A8
		[Token(Token = "0x17000050")]
		public bool isFocused
		{
			[Token(Token = "0x60001EE")]
			[Address(RVA = "0x5698", Offset = "0x5698", VA = "0x5698", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x060001EF RID: 495 RVA: 0x000027C0 File Offset: 0x000009C0
		// (set) Token: 0x060001F0 RID: 496 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000051")]
		public int selectionFocusPosition
		{
			[Token(Token = "0x60001EF")]
			[Address(RVA = "0x5699", Offset = "0x5699", VA = "0x5699", Slot = "13")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60001F0")]
			[Address(RVA = "0x569A", Offset = "0x569A", VA = "0x569A", Slot = "14")]
			set
			{
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x060001F1 RID: 497 RVA: 0x000027D8 File Offset: 0x000009D8
		// (set) Token: 0x060001F2 RID: 498 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000052")]
		public int selectionAnchorPosition
		{
			[Token(Token = "0x60001F1")]
			[Address(RVA = "0x569B", Offset = "0x569B", VA = "0x569B", Slot = "15")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60001F2")]
			[Address(RVA = "0x569C", Offset = "0x569C", VA = "0x569C", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x060001F3 RID: 499 RVA: 0x000027F0 File Offset: 0x000009F0
		[Token(Token = "0x17000053")]
		public bool OnFocusSelectAll
		{
			[Token(Token = "0x60001F3")]
			[Address(RVA = "0x569D", Offset = "0x569D", VA = "0x569D", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x569E", Offset = "0x569E", VA = "0x569E")]
		public WrappedTMPInputField(TMP_InputField input)
		{
		/* --- GHIDRA: .ctor ---
		undefined4 WebGLSupport_WrappedTMPInputField___ctor(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a648c9 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_RectTransform___);
		    DAT_ram_00a648c9 = '\x01';
		  }
		  uVar1 = func_ii_5677(*(undefined4 *)(param1 + 8),
		                       Method_UnityEngine_Component_GetComponent_RectTransform___);
		  return uVar1;
		}
		*/

		}

		// Token: 0x060001F5 RID: 501 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x569F", Offset = "0x569F", VA = "0x569F", Slot = "19")]
		public RectTransform RectTransform()
		{
		/* --- GHIDRA: RectTransform ---
		void WebGLSupport_WrappedTMPInputField__RectTransform(int param1,undefined4 param2)
		
		{
		  TMPro_TMP_InputField__Validate(*(undefined4 *)(param1 + 8),0);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x56A0", Offset = "0x56A0", VA = "0x56A0", Slot = "20")]
		public void ActivateInputField()
		{
		/* --- GHIDRA: ActivateInputField ---
		void WebGLSupport_WrappedTMPInputField__ActivateInputField(int param1,undefined4 param2)
		
		{
		  TMPro_TMP_InputField__ReleaseSelection(*(undefined4 *)(param1 + 8),0,0);
		  return;
		}
		*/

		}

		// Token: 0x060001F7 RID: 503 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x56A1", Offset = "0x56A1", VA = "0x56A1", Slot = "21")]
		public void DeactivateInputField()
		{
		/* --- GHIDRA: DeactivateInputField ---
		void WebGLSupport_WrappedTMPInputField__DeactivateInputField(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  int *piVar2;
		  
		  iVar1 = WebGLSupport_Detail_RebuildChecker___ctor(*(undefined4 *)(param1 + 0xc),0,param1);
		  if (iVar1 != 0) {
		    piVar2 = *(int **)(*(int *)(param1 + 8) + 200);
		    iVar1 = *piVar2;
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0x1a0) * 4))(piVar2,*(undefined4 *)(iVar1 + 0x1a4));
		    piVar2 = *(int **)(*(int *)(param1 + 8) + 200);
		    iVar1 = *piVar2;
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0x198) * 4))(piVar2,*(undefined4 *)(iVar1 + 0x19c));
		    iVar1 = **(int **)(param1 + 8);
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0x300) * 4))
		              (*(int **)(param1 + 8),4,*(undefined4 *)(iVar1 + 0x304));
		  }
		  return;
		}
		*/

		}

		// Token: 0x060001F8 RID: 504 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x56A2", Offset = "0x56A2", VA = "0x56A2", Slot = "22")]
		public void Rebuild()
		{
		/* --- GHIDRA: Rebuild ---
		uint WebGLSupport_WrappedTMPInputField__Rebuild
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  float4 fVar1;
		  float4 fVar2;
		  float4 fVar3;
		  float4 fVar4;
		  uint uVar5;
		  float4 local_10;
		  float4 local_c;
		  float4 local_8;
		  float4 local_4;
		  
		  uVar5 = 0;
		  UnityEngine_Transform___ctor(&local_10,param2,0);
		  fVar1 = local_10;
		  UnityEngine_Transform___ctor(&local_10,param2,0);
		  fVar2 = local_c;
		  UnityEngine_RectTransform__remove_reapplyDrivenProperties(&local_10,param2,0);
		  fVar3 = local_8;
		  UnityEngine_RectTransform__remove_reapplyDrivenProperties(&local_10,param2,0);
		  fVar4 = local_4;
		  UnityEngine_Transform___ctor(&local_10,param3,0);
		  UnityEngine_Transform___ctor(&local_10,param3,0);
		  UnityEngine_RectTransform__remove_reapplyDrivenProperties(&local_10,param3,0);
		  UnityEngine_RectTransform__remove_reapplyDrivenProperties(&local_10,param3,0);
		  if ((((float)fVar1 < (float)local_10 + (float)local_8) &&
		      ((float)local_10 < (float)fVar1 + (float)fVar3)) &&
		     ((float)fVar2 < (float)local_c + (float)local_4)) {
		    uVar5 = (uint)((float)local_c < (float)fVar2 + (float)fVar4);
		  }
		  return uVar5;
		}
		*/

		}

		// Token: 0x060001F9 RID: 505 RVA: 0x00002808 File Offset: 0x00000A08
		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x56A3", Offset = "0x56A3", VA = "0x56A3")]
		private bool rectOverlaps(RectTransform rectTrans1, RectTransform rectTrans2)
		{
		/* --- GHIDRA: rectOverlaps ---
		void WebGLSupport_WrappedTMPInputField__rectOverlaps(undefined4 param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  param1_00 = unnamed_function_1434(param1);
		  import::env::WebGLWindowOnFocus(param1_00);
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x040000D9 RID: 217
		[Token(Token = "0x40000D9")]
		[FieldOffset(Offset = "0x8")]
		private TMP_InputField input;

		// Token: 0x040000DA RID: 218
		[Token(Token = "0x40000DA")]
		[FieldOffset(Offset = "0xC")]
		private RebuildChecker checker;

		// Token: 0x040000DB RID: 219
		[Token(Token = "0x40000DB")]
		[FieldOffset(Offset = "0x10")]
		private Coroutine delayedGraphicRebuild;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_ReadOnly ---
		undefined4 WebGLSupport_WrappedTMPInputField__get_ReadOnly(int param1,undefined4 param2)
		
		{
		  return *(undefined4 *)(*(int *)(param1 + 8) + 0x160);
		}
		*/


		/* --- GHIDRA: get_text ---
		void WebGLSupport_WrappedTMPInputField__get_text(int param1,undefined4 param2,undefined4 param3)
		
		{
		  TMPro_TMP_InputField__get_text(*(undefined4 *)(param1 + 8),param2,0);
		  return;
		}
		*/


		/* --- GHIDRA: set_text ---
		undefined4 WebGLSupport_WrappedTMPInputField__set_text(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  int *param1_00;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a648c7 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_TMP_Text___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5);
		    DAT_ram_00a648c7 = '\x01';
		  }
		  uVar2 = *(undefined4 *)(*(int *)(param1 + 8) + 0xd0);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar1 = UnityEngine_Component__GetComponent_object_(uVar2,0);
		  if (iVar1 == 0) {
		    return StringLiteral_5;
		  }
		  param1_00 = (int *)func_ii_5677(*(undefined4 *)(*(int *)(param1 + 8) + 0xd0),
		                                  Method_UnityEngine_Component_GetComponent_TMP_Text___);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar1 = UnityEngine_Component__GetComponent_object_(param1_00,0);
		  if (iVar1 == 0) {
		    return StringLiteral_5;
		  }
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param1_00 + 0x2c8) * 4))
		                    (param1_00,*(undefined4 *)(*param1_00 + 0x2cc));
		  return uVar2;
		}
		*/


		/* --- GHIDRA: get_placeholder ---
		undefined4 WebGLSupport_WrappedTMPInputField__get_placeholder(int param1,undefined4 param2)
		
		{
		  float fVar1;
		  
		  fVar1 = *(float *)(*(int *)(*(int *)(param1 + 8) + 200) + 0x16c);
		  if (2.1474836e+09 <= ABS(fVar1)) {
		    return 0x80000000;
		  }
		  return (int)fVar1;
		}
		*/


		/* --- GHIDRA: get_fontSize ---
		undefined4 WebGLSupport_WrappedTMPInputField__get_fontSize(int param1,undefined4 param2)
		
		{
		  return *(undefined4 *)(*(int *)(param1 + 8) + 0xf0);
		}
		*/


		/* --- GHIDRA: get_contentType ---
		undefined4 WebGLSupport_WrappedTMPInputField__get_contentType(int param1,undefined4 param2)
		
		{
		  return *(undefined4 *)(*(int *)(param1 + 8) + 0x100);
		}
		*/


		/* --- GHIDRA: get_lineType ---
		undefined4 WebGLSupport_WrappedTMPInputField__get_lineType(int param1,undefined4 param2)
		
		{
		  return *(undefined4 *)(*(int *)(param1 + 8) + 0x114);
		}
		*/


		/* --- GHIDRA: get_characterLimit ---
		undefined4 WebGLSupport_WrappedTMPInputField__get_characterLimit(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = TMPro_TMP_InputField__set_selectionAnchorPosition(*(undefined4 *)(param1 + 8),0);
		  return uVar1;
		}
		*/


		/* --- GHIDRA: get_caretPosition ---
		uint WebGLSupport_WrappedTMPInputField__get_caretPosition(int param1,undefined4 param2)
		
		{
		  return (uint)*(byte *)(*(int *)(param1 + 8) + 0x198);
		}
		*/


		/* --- GHIDRA: get_isFocused ---
		undefined4 WebGLSupport_WrappedTMPInputField__get_isFocused(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = TMPro_TMP_InputField__set_selectionStringAnchorPosition(*(undefined4 *)(param1 + 8),0);
		  return uVar1;
		}
		*/


		/* --- GHIDRA: get_selectionFocusPosition ---
		void WebGLSupport_WrappedTMPInputField__get_selectionFocusPosition
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  TMPro_TMP_InputField__get_selectionStringFocusPosition(*(undefined4 *)(param1 + 8),param2,0);
		  return;
		}
		*/


		/* --- GHIDRA: set_selectionFocusPosition ---
		undefined4
		WebGLSupport_WrappedTMPInputField__set_selectionFocusPosition(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = TMPro_TMP_InputField__set_stringPosition(*(undefined4 *)(param1 + 8),0);
		  return uVar1;
		}
		*/


		/* --- GHIDRA: get_selectionAnchorPosition ---
		void WebGLSupport_WrappedTMPInputField__get_selectionAnchorPosition
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  TMPro_TMP_InputField__get_selectionStringAnchorPosition(*(undefined4 *)(param1 + 8),param2,0);
		  return;
		}
		*/


		/* --- GHIDRA: set_selectionAnchorPosition ---
		uint WebGLSupport_WrappedTMPInputField__set_selectionAnchorPosition(int param1,undefined4 param2)
		
		{
		  return (uint)*(byte *)(*(int *)(param1 + 8) + 0x1d4);
		}
		*/


		/* --- GHIDRA: get_OnFocusSelectAll ---
		void WebGLSupport_WrappedTMPInputField__get_OnFocusSelectAll
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a648c8 == '\0') {
		    Mono_Security_ASN1__get_Item(&WebGLSupport_Detail_RebuildChecker_TypeInfo);
		    DAT_ram_00a648c8 = '\x01';
		  }
		  *(undefined4 *)(param1 + 8) = param2;
		  iVar1 = unnamed_function_1417(WebGLSupport_Detail_RebuildChecker_TypeInfo);
		  *(int *)(iVar1 + 8) = param1;
		  *(int *)(param1 + 0xc) = iVar1;
		  return;
		}
		*/

}
