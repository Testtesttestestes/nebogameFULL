using System;
using System.Runtime.CompilerServices;
using Gameplay.AccountLinker.Model;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.AccountLinker.View
{
	// Token: 0x02000DFC RID: 3580
	[Token(Token = "0x2000DFC")]
	public class ConfirmSelectedUserView : MonoBehaviour
	{
		// Token: 0x14000208 RID: 520
		// (add) Token: 0x06005754 RID: 22356 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06005755 RID: 22357 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000208")]
		public event Action<LinkerUser> OnSelectEvent
		{
			[Token(Token = "0x6005754")]
			[Address(RVA = "0xA4CF", Offset = "0xA4CF", VA = "0xA4CF")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6005755")]
			[Address(RVA = "0xA4D0", Offset = "0xA4D0", VA = "0xA4D0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06005756 RID: 22358 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005756")]
		[Address(RVA = "0xA4D1", Offset = "0xA4D1", VA = "0xA4D1")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void Gameplay_AccountLinker_View_ConfirmSelectedUserView__OnDestroy(int param1,undefined4 param2)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  undefined4 param1_01;
		  int param1_02;
		  int iVar3;
		  
		  if (DAT_ram_00a58917 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_AccountLinker_View_ConfirmSelectedUserView_UserViewOnSelectEvent__);
		    Mono_Security_ASN1__get_Item(&System_EventHandler_LinkerUser__TypeInfo);
		    DAT_ram_00a58917 = '\x01';
		  }
		  iVar3 = *(int *)(param1 + 0x10);
		  param1_01 = unnamed_function_1417(System_EventHandler_LinkerUser__TypeInfo);
		  UnityEngine_Object__Instantiate_object_
		            (param1_01,param1,
		             Method_Gameplay_AccountLinker_View_ConfirmSelectedUserView_UserViewOnSelectEvent__,0);
		  if (DAT_ram_00a58907 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_EventHandler_LinkerUser__TypeInfo);
		    DAT_ram_00a58907 = '\x01';
		  }
		  param1_00 = *(int *)(iVar3 + 0x30);
		  while( true ) {
		    iVar2 = 0;
		    param1_02 = UnityEngine_UI_Image__set_sprite(param1_00,param1_01,0);
		    param2_00 = System_EventHandler_LinkerUser__TypeInfo;
		    if ((param1_02 != 0) &&
		       (iVar2 = func_ii_1082(param1_02,System_EventHandler_LinkerUser__TypeInfo), iVar2 == 0))
		    break;
		    iVar2 = func_ii_4329(iVar3 + 0x30,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_02,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06005757 RID: 22359 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005757")]
		[Address(RVA = "0xA4D2", Offset = "0xA4D2", VA = "0xA4D2")]
		private void Awake()
		{
		/* --- GHIDRA: Awake ---
		void Gameplay_AccountLinker_View_ConfirmSelectedUserView__Awake
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  int iVar1;
		  
		  iVar1 = *(int *)(param1 + 0x14);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		            (*(undefined4 *)(iVar1 + 0x20),param3,*(undefined4 *)(iVar1 + 0x14));
		  return;
		}
		*/

		}

		// Token: 0x06005758 RID: 22360 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005758")]
		[Address(RVA = "0xA4D3", Offset = "0xA4D3", VA = "0xA4D3")]
		private void UserViewOnSelectEvent(object sender, LinkerUser user)
		{
		}

		// Token: 0x170011CF RID: 4559
		// (get) Token: 0x06005759 RID: 22361 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170011CF")]
		public AccountLinkerUserView UserView
		{
			[Token(Token = "0x6005759")]
			[Address(RVA = "0xA4D4", Offset = "0xA4D4", VA = "0xA4D4")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600575A RID: 22362 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600575A")]
		[Address(RVA = "0xA4D5", Offset = "0xA4D5", VA = "0xA4D5")]
		public ConfirmSelectedUserView()
		{
		/* --- GHIDRA: .ctor ---
		undefined4
		Gameplay_AccountLinker_View_ConfirmSelectedUserView___ctor(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a58918 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_12549);
		    DAT_ram_00a58918 = '\x01';
		  }
		  return StringLiteral_12549;
		}
		*/

		}

		// Token: 0x04002F51 RID: 12113
		[Token(Token = "0x4002F51")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private AccountLinkerUserView _userView;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_OnSelectEvent ---
		void Gameplay_AccountLinker_View_ConfirmSelectedUserView__add_OnSelectEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a58915 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_LinkerUser__TypeInfo);
		    DAT_ram_00a58915 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x14);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_LinkerUser__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_LinkerUser__TypeInfo), iVar2 == 0)) break;
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


		/* --- GHIDRA: remove_OnSelectEvent ---
		void Gameplay_AccountLinker_View_ConfirmSelectedUserView__remove_OnSelectEvent
		               (int param1,undefined4 param2)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  undefined4 param1_01;
		  int param1_02;
		  int iVar3;
		  
		  if (DAT_ram_00a58916 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_AccountLinker_View_ConfirmSelectedUserView_UserViewOnSelectEvent__);
		    Mono_Security_ASN1__get_Item(&System_EventHandler_LinkerUser__TypeInfo);
		    DAT_ram_00a58916 = '\x01';
		  }
		  iVar3 = *(int *)(param1 + 0x10);
		  param1_01 = unnamed_function_1417(System_EventHandler_LinkerUser__TypeInfo);
		  UnityEngine_Object__Instantiate_object_
		            (param1_01,param1,
		             Method_Gameplay_AccountLinker_View_ConfirmSelectedUserView_UserViewOnSelectEvent__,0);
		  if (DAT_ram_00a58908 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_EventHandler_LinkerUser__TypeInfo);
		    DAT_ram_00a58908 = '\x01';
		  }
		  param1_00 = *(int *)(iVar3 + 0x30);
		  while( true ) {
		    iVar2 = 0;
		    param1_02 = func_ii_7048(param1_00,param1_01,0);
		    param2_00 = System_EventHandler_LinkerUser__TypeInfo;
		    if ((param1_02 != 0) &&
		       (iVar2 = func_ii_1082(param1_02,System_EventHandler_LinkerUser__TypeInfo), iVar2 == 0))
		    break;
		    iVar2 = func_ii_4329(iVar3 + 0x30,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_02,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

}
