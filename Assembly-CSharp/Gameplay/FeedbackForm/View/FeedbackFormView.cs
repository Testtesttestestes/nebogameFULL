using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Gameplay.FeedbackForm.Model;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.FeedbackForm.View
{
	// Token: 0x02000815 RID: 2069
	[Token(Token = "0x2000815")]
	public class FeedbackFormView : MonoBehaviour
	{
		// Token: 0x14000169 RID: 361
		// (add) Token: 0x060030C5 RID: 12485 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060030C6 RID: 12486 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000169")]
		public event Func<FeedbackFormWindow, UniTask<bool>> CloseFormRequestEvent
		{
			[Token(Token = "0x60030C5")]
			[Address(RVA = "0x812A", Offset = "0x812A", VA = "0x812A")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60030C6")]
			[Address(RVA = "0x812B", Offset = "0x812B", VA = "0x812B")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x060030C7 RID: 12487 RVA: 0x00009F18 File Offset: 0x00008118
		[Token(Token = "0x60030C7")]
		[Address(RVA = "0x812C", Offset = "0x812C", VA = "0x812C")]
		public UniTask<bool>? InvokeCloseFormRequestEvent(FeedbackFormWindow window)
		{
			return null;
		}

		// Token: 0x17000981 RID: 2433
		// (get) Token: 0x060030C8 RID: 12488 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000981")]
		public Button SubmitButton
		{
			[Token(Token = "0x60030C8")]
			[Address(RVA = "0x812D", Offset = "0x812D", VA = "0x812D")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000982 RID: 2434
		// (get) Token: 0x060030C9 RID: 12489 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000982")]
		public TMP_Dropdown ThemeDropdown
		{
			[Token(Token = "0x60030C9")]
			[Address(RVA = "0x812E", Offset = "0x812E", VA = "0x812E")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000983 RID: 2435
		// (get) Token: 0x060030CA RID: 12490 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000983")]
		public TMP_InputField MessageField
		{
			[Token(Token = "0x60030CA")]
			[Address(RVA = "0x812F", Offset = "0x812F", VA = "0x812F")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000984 RID: 2436
		// (get) Token: 0x060030CB RID: 12491 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000984")]
		public string UserName
		{
			[Token(Token = "0x60030CB")]
			[Address(RVA = "0x8130", Offset = "0x8130", VA = "0x8130")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000985 RID: 2437
		// (get) Token: 0x060030CC RID: 12492 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000985")]
		public FeedbackFormField[] FormFields
		{
			[Token(Token = "0x60030CC")]
			[Address(RVA = "0x8131", Offset = "0x8131", VA = "0x8131")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000986 RID: 2438
		// (get) Token: 0x060030CD RID: 12493 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060030CE RID: 12494 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000986")]
		public string Email
		{
			[Token(Token = "0x60030CD")]
			[Address(RVA = "0x8132", Offset = "0x8132", VA = "0x8132")]
			get
			{
				return null;
			}
			[Token(Token = "0x60030CE")]
			[Address(RVA = "0x8133", Offset = "0x8133", VA = "0x8133")]
			set
			{
			}
		}

		// Token: 0x17000987 RID: 2439
		// (get) Token: 0x060030CF RID: 12495 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000987")]
		public string Message
		{
			[Token(Token = "0x60030CF")]
			[Address(RVA = "0x8134", Offset = "0x8134", VA = "0x8134")]
			get
			{
				return null;
			}
		}

		// Token: 0x060030D0 RID: 12496 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030D0")]
		[Address(RVA = "0x8135", Offset = "0x8135", VA = "0x8135")]
		public FeedbackFormView()
		{
		/* --- GHIDRA: .ctor ---
		undefined4 Gameplay_FeedbackForm_View_FeedbackFormView___ctor(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a575ea == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_12616);
		    DAT_ram_00a575ea = '\x01';
		  }
		  return StringLiteral_12616;
		}
		*/

		}

		// Token: 0x04001A96 RID: 6806
		[Token(Token = "0x4001A96")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TMP_InputField _userNameField;

		// Token: 0x04001A97 RID: 6807
		[Token(Token = "0x4001A97")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private TMP_InputField _emailField;

		// Token: 0x04001A98 RID: 6808
		[Token(Token = "0x4001A98")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TMP_InputField _messageField;

		// Token: 0x04001A99 RID: 6809
		[Token(Token = "0x4001A99")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private Button _submitButton;

		// Token: 0x04001A9A RID: 6810
		[Token(Token = "0x4001A9A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TMP_Dropdown _themeDropdown;

		// Token: 0x04001A9B RID: 6811
		[Token(Token = "0x4001A9B")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private FeedbackFormField[] _formFields;

		// Token: 0x04001A9D RID: 6813
		[Token(Token = "0x4001A9D")]
		[FieldOffset(Offset = "0x2C")]
		public Themes Theme;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_CloseFormRequestEvent ---
		void Gameplay_FeedbackForm_View_FeedbackFormView__add_CloseFormRequestEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a575e8 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Func_FeedbackFormWindow__UniTask_bool___TypeInfo);
		    DAT_ram_00a575e8 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x28);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Func_FeedbackFormWindow__UniTask_bool___TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Func_FeedbackFormWindow__UniTask_bool___TypeInfo),
		       iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x28,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: remove_CloseFormRequestEvent ---
		void Gameplay_FeedbackForm_View_FeedbackFormView__remove_CloseFormRequestEvent
		               (undefined8 *param1,int param2,undefined4 param3,undefined4 param4)
		
		{
		  int iVar1;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a575e9 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_UniTask_bool____ctor__);
		    DAT_ram_00a575e9 = '\x01';
		  }
		  iVar1 = *(int *)(param2 + 0x28);
		  if (iVar1 == 0) {
		    *param1 = 0;
		    *(undefined4 *)(param1 + 1) = 0;
		  }
		  else {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (&local_8,*(undefined4 *)(iVar1 + 0x20),param3,*(undefined4 *)(iVar1 + 0x14));
		    *(undefined4 *)(param1 + 1) = 0;
		    *param1 = 0;
		    local_10 = local_8;
		    System_Nullable_DefaultEventSystem_FocusBasedEventSequenceContext___get_Value
		              (param1,&local_10,Method_System_Nullable_UniTask_bool____ctor__);
		  }
		  return;
		}
		*/


		/* --- GHIDRA: get_MessageField ---
		undefined4
		Gameplay_FeedbackForm_View_FeedbackFormView__get_MessageField(int param1,undefined4 param2)
		
		{
		  return *(undefined4 *)(*(int *)(param1 + 0x10) + 0x160);
		}
		*/


		/* --- GHIDRA: get_FormFields ---
		undefined4 Gameplay_FeedbackForm_View_FeedbackFormView__get_FormFields(int param1,undefined4 param2)
		
		{
		  return *(undefined4 *)(*(int *)(param1 + 0x14) + 0x160);
		}
		*/


		/* --- GHIDRA: get_Email ---
		void Gameplay_FeedbackForm_View_FeedbackFormView__get_Email
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  TMPro_TMP_InputField__get_text(*(undefined4 *)(param1 + 0x14),param2,0);
		  return;
		}
		*/


		/* --- GHIDRA: set_Email ---
		undefined4 Gameplay_FeedbackForm_View_FeedbackFormView__set_Email(int param1,undefined4 param2)
		
		{
		  return *(undefined4 *)(*(int *)(param1 + 0x18) + 0x160);
		}
		*/

}
