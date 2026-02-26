using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.UserInfo.View
{
	// Token: 0x020003FA RID: 1018
	[Token(Token = "0x20003FA")]
	public class NickVariantItemRow : MonoBehaviour
	{
		// Token: 0x17000427 RID: 1063
		// (get) Token: 0x060017DF RID: 6111 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000427")]
		public TextMeshProUGUI TextField
		{
			[Token(Token = "0x60017DF")]
			[Address(RVA = "0x699A", Offset = "0x699A", VA = "0x699A")]
			get
			{
				return null;
			}
		}

		// Token: 0x14000115 RID: 277
		// (add) Token: 0x060017E0 RID: 6112 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060017E1 RID: 6113 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000115")]
		public event Action<string> OnConfirmSelect
		{
			[Token(Token = "0x60017E0")]
			[Address(RVA = "0x699B", Offset = "0x699B", VA = "0x699B")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60017E1")]
			[Address(RVA = "0x699C", Offset = "0x699C", VA = "0x699C")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x060017E2 RID: 6114 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017E2")]
		[Address(RVA = "0x699D", Offset = "0x699D", VA = "0x699D")]
		private void Awake()
		{
		/* --- GHIDRA: Awake ---
		void Gameplay_UserInfo_View_NickVariantItemRow__Awake(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  int iVar3;
		  
		  iVar2 = *(int *)(param1 + 0x18);
		  iVar3 = **(int **)(param1 + 0x14);
		  uVar1 = (**(code **)((ulonglong)*(uint *)(iVar3 + 0x2c8) * 4))
		                    (*(int **)(param1 + 0x14),*(undefined4 *)(iVar3 + 0x2cc));
		  (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		            (*(undefined4 *)(iVar2 + 0x20),uVar1,*(undefined4 *)(iVar2 + 0x14));
		  return;
		}
		*/

		}

		// Token: 0x060017E3 RID: 6115 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017E3")]
		[Address(RVA = "0x699E", Offset = "0x699E", VA = "0x699E")]
		private void HandleClick()
		{
		/* --- GHIDRA: HandleClick ---
		void Gameplay_UserInfo_View_NickVariantItemRow__HandleClick(int param1,undefined4 param2)
		
		{
		  *(undefined4 *)(param1 + 0x18) = 0;
		  func_ii_14558(*(undefined4 *)(*(int *)(param1 + 0x10) + 0xb4),0);
		  return;
		}
		*/

		}

		// Token: 0x060017E4 RID: 6116 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017E4")]
		[Address(RVA = "0x699F", Offset = "0x699F", VA = "0x699F")]
		private void OnDestroy()
		{
		}

		// Token: 0x060017E5 RID: 6117 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017E5")]
		[Address(RVA = "0x69A0", Offset = "0x69A0", VA = "0x69A0")]
		public NickVariantItemRow()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_UserInfo_View_NickVariantItemRow___ctor
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a598e3 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_bool__TypeInfo);
		    DAT_ram_00a598e3 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x14);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
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

		}

		// Token: 0x04000CAD RID: 3245
		[Token(Token = "0x4000CAD")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Button _confirmButton;

		// Token: 0x04000CAE RID: 3246
		[Token(Token = "0x4000CAE")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private TextMeshProUGUI _textField;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_TextField ---
		void Gameplay_UserInfo_View_NickVariantItemRow__get_TextField
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a598e0 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_string__TypeInfo);
		    DAT_ram_00a598e0 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x18);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_string__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_string__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x18,iVar2,param1_00);
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


		/* --- GHIDRA: add_OnConfirmSelect ---
		void Gameplay_UserInfo_View_NickVariantItemRow__add_OnConfirmSelect
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a598e1 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_string__TypeInfo);
		    DAT_ram_00a598e1 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x18);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_string__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_string__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x18,iVar2,param1_00);
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


		/* --- GHIDRA: remove_OnConfirmSelect ---
		void Gameplay_UserInfo_View_NickVariantItemRow__remove_OnConfirmSelect(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a598e2 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_UserInfo_View_NickVariantItemRow_HandleClick__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a598e2 = '\x01';
		  }
		  param1_01 = *(undefined4 *)(*(int *)(param1 + 0x10) + 0xb4);
		  param1_00 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (param1_00,param1,Method_Gameplay_UserInfo_View_NickVariantItemRow_HandleClick__,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(param1_01,param1_00,0);
		  return;
		}
		*/

}
