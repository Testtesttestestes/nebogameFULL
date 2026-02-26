using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using WebGLSupport.Detail;

namespace WebGLSupport
{
	// Token: 0x0200002C RID: 44
	[Token(Token = "0x200002C")]
	internal class WrappedInputField : IInputField
	{
		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060001D1 RID: 465 RVA: 0x00002628 File Offset: 0x00000828
		[Token(Token = "0x1700003C")]
		public bool ReadOnly
		{
			[Token(Token = "0x60001D1")]
			[Address(RVA = "0x567B", Offset = "0x567B", VA = "0x567B", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060001D2 RID: 466 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060001D3 RID: 467 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700003D")]
		public string text
		{
			[Token(Token = "0x60001D2")]
			[Address(RVA = "0x567C", Offset = "0x567C", VA = "0x567C", Slot = "7")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001D3")]
			[Address(RVA = "0x567D", Offset = "0x567D", VA = "0x567D", Slot = "8")]
			set
			{
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060001D4 RID: 468 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700003E")]
		public string placeholder
		{
			[Token(Token = "0x60001D4")]
			[Address(RVA = "0x567E", Offset = "0x567E", VA = "0x567E", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060001D5 RID: 469 RVA: 0x00002640 File Offset: 0x00000840
		[Token(Token = "0x1700003F")]
		public int fontSize
		{
			[Token(Token = "0x60001D5")]
			[Address(RVA = "0x567F", Offset = "0x567F", VA = "0x567F", Slot = "6")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060001D6 RID: 470 RVA: 0x00002658 File Offset: 0x00000858
		[Token(Token = "0x17000040")]
		public ContentType contentType
		{
			[Token(Token = "0x60001D6")]
			[Address(RVA = "0x5680", Offset = "0x5680", VA = "0x5680", Slot = "4")]
			get
			{
				return ContentType.Standard;
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060001D7 RID: 471 RVA: 0x00002670 File Offset: 0x00000870
		[Token(Token = "0x17000041")]
		public LineType lineType
		{
			[Token(Token = "0x60001D7")]
			[Address(RVA = "0x5681", Offset = "0x5681", VA = "0x5681", Slot = "5")]
			get
			{
				return LineType.SingleLine;
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060001D8 RID: 472 RVA: 0x00002688 File Offset: 0x00000888
		[Token(Token = "0x17000042")]
		public int characterLimit
		{
			[Token(Token = "0x60001D8")]
			[Address(RVA = "0x5682", Offset = "0x5682", VA = "0x5682", Slot = "10")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060001D9 RID: 473 RVA: 0x000026A0 File Offset: 0x000008A0
		[Token(Token = "0x17000043")]
		public int caretPosition
		{
			[Token(Token = "0x60001D9")]
			[Address(RVA = "0x5683", Offset = "0x5683", VA = "0x5683", Slot = "11")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060001DA RID: 474 RVA: 0x000026B8 File Offset: 0x000008B8
		[Token(Token = "0x17000044")]
		public bool isFocused
		{
			[Token(Token = "0x60001DA")]
			[Address(RVA = "0x5684", Offset = "0x5684", VA = "0x5684", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060001DB RID: 475 RVA: 0x000026D0 File Offset: 0x000008D0
		// (set) Token: 0x060001DC RID: 476 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000045")]
		public int selectionFocusPosition
		{
			[Token(Token = "0x60001DB")]
			[Address(RVA = "0x5685", Offset = "0x5685", VA = "0x5685", Slot = "13")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60001DC")]
			[Address(RVA = "0x5686", Offset = "0x5686", VA = "0x5686", Slot = "14")]
			set
			{
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060001DD RID: 477 RVA: 0x000026E8 File Offset: 0x000008E8
		// (set) Token: 0x060001DE RID: 478 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000046")]
		public int selectionAnchorPosition
		{
			[Token(Token = "0x60001DD")]
			[Address(RVA = "0x5687", Offset = "0x5687", VA = "0x5687", Slot = "15")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60001DE")]
			[Address(RVA = "0x5688", Offset = "0x5688", VA = "0x5688", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x060001DF RID: 479 RVA: 0x00002700 File Offset: 0x00000900
		[Token(Token = "0x17000047")]
		public bool OnFocusSelectAll
		{
			[Token(Token = "0x60001DF")]
			[Address(RVA = "0x5689", Offset = "0x5689", VA = "0x5689", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001E0")]
		[Address(RVA = "0x568A", Offset = "0x568A", VA = "0x568A")]
		public WrappedInputField(InputField input)
		{
		/* --- GHIDRA: .ctor ---
		undefined4 WebGLSupport_WrappedInputField___ctor(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a648c6 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_RectTransform___);
		    DAT_ram_00a648c6 = '\x01';
		  }
		  uVar1 = func_ii_5677(*(undefined4 *)(param1 + 8),
		                       Method_UnityEngine_Component_GetComponent_RectTransform___);
		  return uVar1;
		}
		*/

		}

		// Token: 0x060001E1 RID: 481 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x568B", Offset = "0x568B", VA = "0x568B", Slot = "19")]
		public RectTransform RectTransform()
		{
		/* --- GHIDRA: RectTransform ---
		void WebGLSupport_WrappedInputField__RectTransform(int param1,undefined4 param2)
		
		{
		  UnityEngine_UI_InputField__Validate(*(undefined4 *)(param1 + 8),0);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x568C", Offset = "0x568C", VA = "0x568C", Slot = "20")]
		public void ActivateInputField()
		{
		/* --- GHIDRA: ActivateInputField ---
		void WebGLSupport_WrappedInputField__ActivateInputField(int param1,undefined4 param2)
		
		{
		  UnityEngine_UI_InputField__OnPointerClick(*(undefined4 *)(param1 + 8),0);
		  return;
		}
		*/

		}

		// Token: 0x060001E3 RID: 483 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001E3")]
		[Address(RVA = "0x568D", Offset = "0x568D", VA = "0x568D", Slot = "21")]
		public void DeactivateInputField()
		{
		/* --- GHIDRA: DeactivateInputField ---
		void WebGLSupport_WrappedInputField__DeactivateInputField(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  int *piVar2;
		  
		  iVar1 = WebGLSupport_Detail_RebuildChecker___ctor(*(undefined4 *)(param1 + 0xc),0,param1);
		  if (iVar1 != 0) {
		    piVar2 = *(int **)(*(int *)(param1 + 8) + 0xb8);
		    iVar1 = *piVar2;
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 400) * 4))(piVar2,*(undefined4 *)(iVar1 + 0x194));
		    iVar1 = **(int **)(param1 + 8);
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0x2e0) * 4))
		              (*(int **)(param1 + 8),4,*(undefined4 *)(iVar1 + 0x2e4));
		  }
		  return;
		}
		*/

		}

		// Token: 0x060001E4 RID: 484 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001E4")]
		[Address(RVA = "0x568E", Offset = "0x568E", VA = "0x568E", Slot = "22")]
		public void Rebuild()
		{
		/* --- GHIDRA: Rebuild ---
		uint WebGLSupport_WrappedInputField__Rebuild(int param1,undefined4 param2)
		
		{
		  return (uint)*(byte *)(*(int *)(param1 + 8) + 0x16c);
		}
		*/

		}

		// Token: 0x040000D7 RID: 215
		[Token(Token = "0x40000D7")]
		[FieldOffset(Offset = "0x8")]
		private InputField input;

		// Token: 0x040000D8 RID: 216
		[Token(Token = "0x40000D8")]
		[FieldOffset(Offset = "0xC")]
		private RebuildChecker checker;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_text ---
		void WebGLSupport_WrappedInputField__get_text(int param1,undefined4 param2,undefined4 param3)
		
		{
		  UnityEngine_UI_InputField__get_text(*(undefined4 *)(param1 + 8),param2,0);
		  return;
		}
		*/


		/* --- GHIDRA: set_text ---
		undefined4 WebGLSupport_WrappedInputField__set_text(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  int *param1_00;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a648c4 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_Text___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5);
		    DAT_ram_00a648c4 = '\x01';
		  }
		  uVar2 = *(undefined4 *)(*(int *)(param1 + 8) + 0xbc);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar1 = UnityEngine_Component__GetComponent_object_(uVar2,0);
		  if (iVar1 == 0) {
		    return StringLiteral_5;
		  }
		  param1_00 = (int *)func_ii_5677(*(undefined4 *)(*(int *)(param1 + 8) + 0xbc),
		                                  Method_UnityEngine_Component_GetComponent_Text___);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar1 = UnityEngine_Component__GetComponent_object_(param1_00,0);
		  if (iVar1 == 0) {
		    return StringLiteral_5;
		  }
		  uVar2 = (**(code **)((ulonglong)*(uint *)(*param1_00 + 0x310) * 4))
		                    (param1_00,*(undefined4 *)(*param1_00 + 0x314));
		  return uVar2;
		}
		*/


		/* --- GHIDRA: get_placeholder ---
		undefined4 WebGLSupport_WrappedInputField__get_placeholder(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = UnityEngine_UI_Text__set_alignByGeometry(*(undefined4 *)(*(int *)(param1 + 8) + 0xb8),0);
		  return uVar1;
		}
		*/


		/* --- GHIDRA: get_fontSize ---
		undefined4 WebGLSupport_WrappedInputField__get_fontSize(int param1,undefined4 param2)
		
		{
		  return *(undefined4 *)(*(int *)(param1 + 8) + 0xc0);
		}
		*/


		/* --- GHIDRA: get_contentType ---
		undefined4 WebGLSupport_WrappedInputField__get_contentType(int param1,undefined4 param2)
		
		{
		  return *(undefined4 *)(*(int *)(param1 + 8) + 0xd0);
		}
		*/


		/* --- GHIDRA: get_lineType ---
		undefined4 WebGLSupport_WrappedInputField__get_lineType(int param1,undefined4 param2)
		
		{
		  return *(undefined4 *)(*(int *)(param1 + 8) + 0xdc);
		}
		*/


		/* --- GHIDRA: get_caretPosition ---
		uint WebGLSupport_WrappedInputField__get_caretPosition(int param1,undefined4 param2)
		
		{
		  return (uint)*(byte *)(*(int *)(param1 + 8) + 0x144);
		}
		*/


		/* --- GHIDRA: get_isFocused ---
		undefined4 WebGLSupport_WrappedInputField__get_isFocused(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = UnityEngine_UI_InputField__set_selectionAnchorPosition(*(undefined4 *)(param1 + 8),0);
		  return uVar1;
		}
		*/


		/* --- GHIDRA: get_selectionFocusPosition ---
		void WebGLSupport_WrappedInputField__get_selectionFocusPosition
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  UnityEngine_UI_InputField__get_selectionFocusPosition(*(undefined4 *)(param1 + 8),param2,0);
		  return;
		}
		*/


		/* --- GHIDRA: set_selectionFocusPosition ---
		undefined4 WebGLSupport_WrappedInputField__set_selectionFocusPosition(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = UnityEngine_UI_InputField__set_caretPosition(*(undefined4 *)(param1 + 8),0);
		  return uVar1;
		}
		*/


		/* --- GHIDRA: get_selectionAnchorPosition ---
		void WebGLSupport_WrappedInputField__get_selectionAnchorPosition
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  UnityEngine_UI_InputField__get_selectionAnchorPosition(*(undefined4 *)(param1 + 8),param2,0);
		  return;
		}
		*/


		/* --- GHIDRA: get_OnFocusSelectAll ---
		void WebGLSupport_WrappedInputField__get_OnFocusSelectAll
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a648c5 == '\0') {
		    Mono_Security_ASN1__get_Item(&WebGLSupport_Detail_RebuildChecker_TypeInfo);
		    DAT_ram_00a648c5 = '\x01';
		  }
		  *(undefined4 *)(param1 + 8) = param2;
		  iVar1 = unnamed_function_1417(WebGLSupport_Detail_RebuildChecker_TypeInfo);
		  *(int *)(iVar1 + 8) = param1;
		  *(int *)(param1 + 0xc) = iVar1;
		  return;
		}
		*/

}
