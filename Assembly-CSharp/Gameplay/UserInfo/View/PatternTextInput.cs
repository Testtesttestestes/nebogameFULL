using System;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace Gameplay.UserInfo.View
{
	// Token: 0x020003FB RID: 1019
	[Token(Token = "0x20003FB")]
	[RequireComponent(typeof(TMP_InputField))]
	public class PatternTextInput : MonoBehaviour
	{
		// Token: 0x14000116 RID: 278
		// (add) Token: 0x060017E6 RID: 6118 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060017E7 RID: 6119 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000116")]
		public event Action<bool> OnStatusChanged
		{
			[Token(Token = "0x60017E6")]
			[Address(RVA = "0x69A1", Offset = "0x69A1", VA = "0x69A1")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60017E7")]
			[Address(RVA = "0x69A2", Offset = "0x69A2", VA = "0x69A2")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000428 RID: 1064
		// (get) Token: 0x060017E8 RID: 6120 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000428")]
		public TMP_InputField Input
		{
			[Token(Token = "0x60017E8")]
			[Address(RVA = "0x69A3", Offset = "0x69A3", VA = "0x69A3")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000429 RID: 1065
		// (get) Token: 0x060017E9 RID: 6121 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060017EA RID: 6122 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000429")]
		public string Pattern
		{
			[Token(Token = "0x60017E9")]
			[Address(RVA = "0x69A4", Offset = "0x69A4", VA = "0x69A4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60017EA")]
			[Address(RVA = "0x69A5", Offset = "0x69A5", VA = "0x69A5")]
			set
			{
			}
		}

		// Token: 0x060017EB RID: 6123 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017EB")]
		[Address(RVA = "0x69A6", Offset = "0x69A6", VA = "0x69A6")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void Gameplay_UserInfo_View_PatternTextInput__OnDestroy(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a598e6 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_TMP_InputField___);
		    Mono_Security_ASN1__get_Item(&TMPro_TMP_InputField_OnValidateInput_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_UserInfo_View_PatternTextInput_HandleOnValueChanged__);
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_UserInfo_View_PatternTextInput_OnValidateInput__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_string__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Events_UnityEvent_string__AddListener__);
		    DAT_ram_00a598e6 = '\x01';
		  }
		  uVar1 = func_ii_5677(param1,Method_UnityEngine_Component_GetComponent_TMP_InputField___);
		  *(undefined4 *)(param1 + 0x10) = uVar1;
		  uVar2 = unnamed_function_1417(TMPro_TMP_InputField_OnValidateInput_TypeInfo);
		  TMPro_TMP_InputField__UnityEngine_UI_ICanvasElement_get_transform
		            (uVar2,param1,Method_Gameplay_UserInfo_View_PatternTextInput_OnValidateInput__,0);
		  TMPro_TMP_InputField__get_onValidateInput(uVar1,uVar2,0);
		  uVar2 = *(undefined4 *)(*(int *)(param1 + 0x10) + 0x130);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_string__TypeInfo);
		  func_ii_7054(uVar1,param1,Method_Gameplay_UserInfo_View_PatternTextInput_HandleOnValueChanged__,0)
		  ;
		  UnityEngine_Events_UnityEvent_InputAction_CallbackContext____ctor
		            (uVar2,uVar1,Method_UnityEngine_Events_UnityEvent_string__AddListener__);
		  return;
		}
		*/

		}

		// Token: 0x060017EC RID: 6124 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017EC")]
		[Address(RVA = "0x69A7", Offset = "0x69A7", VA = "0x69A7")]
		private void Awake()
		{
		/* --- GHIDRA: Awake ---
		void Gameplay_UserInfo_View_PatternTextInput__Awake(int *param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int iVar2;
		  
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                    (param1,param2,*(undefined4 *)(*param1 + 0xe4));
		  if (uVar1 != *(byte *)(param1 + 8)) {
		    *(char *)(param1 + 8) = (char)uVar1;
		    iVar2 = param1[5];
		    if (iVar2 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		                (*(undefined4 *)(iVar2 + 0x20),uVar1,*(undefined4 *)(iVar2 + 0x14));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x060017ED RID: 6125 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017ED")]
		[Address(RVA = "0x69A8", Offset = "0x69A8", VA = "0x69A8")]
		private void HandleOnValueChanged(string value)
		{
		}

		// Token: 0x1700042A RID: 1066
		// (get) Token: 0x060017EE RID: 6126 RVA: 0x00005610 File Offset: 0x00003810
		// (set) Token: 0x060017EF RID: 6127 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700042A")]
		public bool Status
		{
			[Token(Token = "0x60017EE")]
			[Address(RVA = "0x69A9", Offset = "0x69A9", VA = "0x69A9")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60017EF")]
			[Address(RVA = "0x69AA", Offset = "0x69AA", VA = "0x69AA")]
			set
			{
			}
		}

		// Token: 0x060017F0 RID: 6128 RVA: 0x00005628 File Offset: 0x00003828
		[Token(Token = "0x60017F0")]
		[Address(RVA = "0x69AB", Offset = "0x69AB", VA = "0x69AB")]
		private char OnValidateInput(string text, int charindex, char addedchar)
		{
		/* --- GHIDRA: OnValidateInput ---
		undefined4
		Gameplay_UserInfo_View_PatternTextInput__OnValidateInput
		          (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = System_Text_RegularExpressions_Regex__IsMatch(*(undefined4 *)(param1 + 0x1c),param2,0);
		  return uVar1;
		}
		*/

			return '\0';
		}

		// Token: 0x060017F1 RID: 6129 RVA: 0x00005640 File Offset: 0x00003840
		[Token(Token = "0x60017F1")]
		[Address(RVA = "0x69AC", Offset = "0x69AC", VA = "0x69AC", Slot = "4")]
		protected virtual bool Check(string value)
		{
			return default(bool);
		}

		// Token: 0x060017F2 RID: 6130 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017F2")]
		[Address(RVA = "0x69AD", Offset = "0x69AD", VA = "0x69AD")]
		public PatternTextInput()
		{
		}

		// Token: 0x04000CB0 RID: 3248
		[Token(Token = "0x4000CB0")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TMP_InputField _input;

		// Token: 0x04000CB2 RID: 3250
		[Token(Token = "0x4000CB2")]
		[FieldOffset(Offset = "0x18")]
		private string _pattern;

		// Token: 0x04000CB3 RID: 3251
		[Token(Token = "0x4000CB3")]
		[FieldOffset(Offset = "0x1C")]
		private Regex _regex;

		// Token: 0x04000CB4 RID: 3252
		[Token(Token = "0x4000CB4")]
		[FieldOffset(Offset = "0x20")]
		private bool _status;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_OnStatusChanged ---
		void Gameplay_UserInfo_View_PatternTextInput__add_OnStatusChanged
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a598e4 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_bool__TypeInfo);
		    DAT_ram_00a598e4 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x14);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_bool__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_bool__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x14,iVar2,param1_00);
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


		/* --- GHIDRA: get_Pattern ---
		void Gameplay_UserInfo_View_PatternTextInput__get_Pattern
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a598e5 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Text_RegularExpressions_Regex_TypeInfo);
		    DAT_ram_00a598e5 = '\x01';
		  }
		  iVar1 = System_Collections_CollectionBase___ctor(*(undefined4 *)(param1 + 0x18),param2,0);
		  if (iVar1 == 0) {
		    *(undefined4 *)(param1 + 0x18) = param2;
		    param1_00 = unnamed_function_1417(System_Text_RegularExpressions_Regex_TypeInfo);
		    System_Xml_Schema_FacetsChecker_FacetsCompiler__Preprocess(param1_00,param2,0x218,0);
		    *(undefined4 *)(param1 + 0x1c) = param1_00;
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_Pattern ---
		void Gameplay_UserInfo_View_PatternTextInput__set_Pattern(int param1,undefined4 param2)
		
		{
		  *(undefined8 *)(param1 + 0x18) = 0;
		  TMPro_TMP_InputField__get_onValidateInput(*(undefined4 *)(param1 + 0x10),0,0);
		  *(undefined4 *)(param1 + 0x10) = 0;
		  return;
		}
		*/


		/* --- GHIDRA: get_Status ---
		void Gameplay_UserInfo_View_PatternTextInput__get_Status(int param1,uint param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  if (*(byte *)(param1 + 0x20) != param2) {
		    *(char *)(param1 + 0x20) = (char)param2;
		    iVar1 = *(int *)(param1 + 0x14);
		    if (iVar1 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),param2,*(undefined4 *)(iVar1 + 0x14));
		    }
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_Status ---
		uint Gameplay_UserInfo_View_PatternTextInput__set_Status
		               (int *param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  undefined4 uVar1;
		  uint uVar2;
		  int iVar3;
		  ushort local_2;
		  
		  local_2 = (ushort)param4;
		  if (param1[7] != 0) {
		    if (*(int *)(DAT_ram_00a66974 + 0x74) == 0) {
		      func_ii_306000(DAT_ram_00a66974);
		    }
		    uVar1 = System_Text_StringBuilder___ctor(&local_2,0);
		    uVar1 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(param2,uVar1,0);
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,uVar1,*(undefined4 *)(*param1 + 0xe4));
		    if (uVar2 == 0) {
		      local_2 = 0;
		    }
		    if (*(byte *)(param1 + 8) != uVar2) {
		      *(char *)(param1 + 8) = (char)uVar2;
		      iVar3 = param1[5];
		      if (iVar3 != 0) {
		        (**(code **)((ulonglong)*(uint *)(iVar3 + 0xc) * 4))
		                  (*(undefined4 *)(iVar3 + 0x20),uVar2,*(undefined4 *)(iVar3 + 0x14));
		      }
		    }
		  }
		  return (uint)local_2;
		}
		*/

}
