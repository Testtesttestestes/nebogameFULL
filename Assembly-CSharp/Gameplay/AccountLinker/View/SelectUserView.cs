using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Gameplay.AccountLinker.Model;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.AccountLinker.View
{
	// Token: 0x02000E03 RID: 3587
	[Token(Token = "0x2000E03")]
	public class SelectUserView : MonoBehaviour
	{
		// Token: 0x0600576A RID: 22378 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600576A")]
		[Address(RVA = "0xA4E5", Offset = "0xA4E5", VA = "0xA4E5")]
		private void OnDestroy()
		{
		}

		// Token: 0x170011D2 RID: 4562
		// (get) Token: 0x0600576B RID: 22379 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600576C RID: 22380 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170011D2")]
		public LinkerUser[] Users
		{
			[Token(Token = "0x600576B")]
			[Address(RVA = "0xA4E6", Offset = "0xA4E6", VA = "0xA4E6")]
			get
			{
				return null;
			}
			[Token(Token = "0x600576C")]
			[Address(RVA = "0xA4E7", Offset = "0xA4E7", VA = "0xA4E7")]
			set
			{
			}
		}

		// Token: 0x0600576D RID: 22381 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600576D")]
		[Address(RVA = "0xA4E8", Offset = "0xA4E8", VA = "0xA4E8")]
		private void HandleUsersChanged()
		{
		/* --- GHIDRA: HandleUsersChanged ---
		void Gameplay_AccountLinker_View_SelectUserView__HandleUsersChanged
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a58925 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_LinkerUser__TypeInfo);
		    DAT_ram_00a58925 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x20);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_LinkerUser__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_LinkerUser__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x20,iVar2,param1_00);
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

		// Token: 0x14000209 RID: 521
		// (add) Token: 0x0600576E RID: 22382 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600576F RID: 22383 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000209")]
		public event Action<LinkerUser> OnSelect
		{
			[Token(Token = "0x600576E")]
			[Address(RVA = "0xA4E9", Offset = "0xA4E9", VA = "0xA4E9")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600576F")]
			[Address(RVA = "0xA4EA", Offset = "0xA4EA", VA = "0xA4EA")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06005770 RID: 22384 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005770")]
		[Address(RVA = "0xA4EB", Offset = "0xA4EB", VA = "0xA4EB")]
		private void HandleOnSelectEvent(object sender, LinkerUser user)
		{
		/* --- GHIDRA: HandleOnSelectEvent ---
		void Gameplay_AccountLinker_View_SelectUserView__HandleOnSelectEvent(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a58927 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_AccountLinkerUserView___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_AccountLinkerUserView__TypeInfo);
		    DAT_ram_00a58927 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_Collections_Generic_List_AccountLinkerUserView__TypeInfo)
		  ;
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_00,Method_System_Collections_Generic_List_AccountLinkerUserView___ctor__);
		  *(undefined4 *)(param1 + 0x1c) = param1_00;
		  UnityEngine_RectTransform__GetParentSize(param1,0);
		  return;
		}
		*/

		}

		// Token: 0x06005771 RID: 22385 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005771")]
		[Address(RVA = "0xA4EC", Offset = "0xA4EC", VA = "0xA4EC")]
		public SelectUserView()
		{
		/* --- GHIDRA: .ctor ---
		undefined4 Gameplay_AccountLinker_View_SelectUserView___ctor(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a58928 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_12552);
		    DAT_ram_00a58928 = '\x01';
		  }
		  return StringLiteral_12552;
		}
		*/

		}

		// Token: 0x04002F5B RID: 12123
		[Token(Token = "0x4002F5B")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private AccountLinkerUserView _accountLinkerUserViewPrefab;

		// Token: 0x04002F5C RID: 12124
		[Token(Token = "0x4002F5C")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Transform _owner;

		// Token: 0x04002F5D RID: 12125
		[Token(Token = "0x4002F5D")]
		[FieldOffset(Offset = "0x18")]
		private LinkerUser[] _users;

		// Token: 0x04002F5E RID: 12126
		[Token(Token = "0x4002F5E")]
		[FieldOffset(Offset = "0x1C")]
		private List<AccountLinkerUserView> _views;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Users ---
		void Gameplay_AccountLinker_View_SelectUserView__get_Users(int param1,int param2,undefined4 param3)
		
		{
		  if (param2 != *(int *)(param1 + 0x18)) {
		    *(int *)(param1 + 0x18) = param2;
		    Gameplay_AccountLinker_View_SelectUserView__set_Users(param1,param1);
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_Users ---
		void Gameplay_AccountLinker_View_SelectUserView__set_Users(int param1,undefined4 param2)
		
		{
		  bool bVar1;
		  int iVar2;
		  int iVar3;
		  int iVar4;
		  int iVar5;
		  int iVar6;
		  undefined4 uVar7;
		  int *piVar8;
		  undefined4 uVar9;
		  int iVar10;
		  uint uVar11;
		  int iVar12;
		  int local_20;
		  undefined1 *puStack_1c;
		  undefined8 local_18;
		  undefined1 local_10 [8];
		  undefined8 local_8;
		  
		  iVar12 = 0;
		  if (DAT_ram_00a58924 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_AccountLinkerUserView__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_AccountLinkerUserView__MoveNext__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_AccountLinkerUserView__get_Current__
		              );
		    Mono_Security_ASN1__get_Item(&System_EventHandler_LinkerUser__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_AccountLinkerUserView__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_AccountLinkerUserView__Clear__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_AccountLinkerUserView__GetEnumerator__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_AccountLinkerUserView___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_AccountLinkerUserView__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Object_Instantiate_AccountLinkerUserView___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_AccountLinker_View_SelectUserView_HandleOnSelectEvent__);
		    DAT_ram_00a58924 = '\x01';
		  }
		  if (*(int *)(param1 + 0x18) != 0) {
		    uVar7 = unnamed_function_1417(System_Collections_Generic_List_AccountLinkerUserView__TypeInfo);
		    GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		              (uVar7,Method_System_Collections_Generic_List_AccountLinkerUserView___ctor__);
		    *(undefined4 *)(param1 + 0x1c) = uVar7;
		    iVar4 = *(int *)(param1 + 0x18);
		    if (0 < *(int *)(iVar4 + 0xc)) {
		      do {
		        iVar5 = *(int *)(iVar4 + iVar12 * 4 + 0x10);
		        uVar7 = *(undefined4 *)(param1 + 0x14);
		        uVar9 = *(undefined4 *)(param1 + 0x10);
		        if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		          func_ii_306000(UnityEngine_Object_TypeInfo);
		        }
		        iVar6 = func_ii_6805(uVar9,uVar7,
		                             Method_UnityEngine_Object_Instantiate_AccountLinkerUserView___);
		        uVar7 = unnamed_function_1417(System_EventHandler_LinkerUser__TypeInfo);
		        UnityEngine_Object__Instantiate_object_
		                  (uVar7,param1,
		                   Method_Gameplay_AccountLinker_View_SelectUserView_HandleOnSelectEvent__,0);
		        if (DAT_ram_00a58907 == '\0') {
		          Mono_Security_ASN1__get_Item(&System_EventHandler_LinkerUser__TypeInfo);
		          DAT_ram_00a58907 = '\x01';
		        }
		        iVar10 = *(int *)(iVar6 + 0x30);
		        do {
		          iVar2 = 0;
		          iVar3 = UnityEngine_UI_Image__set_sprite(iVar10,uVar7,0);
		          uVar9 = System_EventHandler_LinkerUser__TypeInfo;
		          if ((iVar3 != 0) &&
		             (iVar2 = func_ii_1082(iVar3,System_EventHandler_LinkerUser__TypeInfo), iVar2 == 0)) {
		            System_Activator__CreateInstance(iVar3,uVar9);
		            do {
		              halt_trap();
		            } while( true );
		          }
		          iVar3 = func_ii_4329(iVar6 + 0x30,iVar2,iVar10);
		          iVar2 = Method_System_Collections_Generic_List_AccountLinkerUserView__Add__;
		          bVar1 = iVar3 != iVar10;
		          iVar10 = iVar3;
		        } while (bVar1);
		        iVar10 = *(int *)(param1 + 0x1c);
		        *(int *)(iVar10 + 0x10) = *(int *)(iVar10 + 0x10) + 1;
		        uVar11 = *(uint *)(iVar10 + 0xc);
		        if (uVar11 < *(uint *)(*(int *)(iVar10 + 8) + 0xc)) {
		          *(uint *)(iVar10 + 0xc) = uVar11 + 1;
		          *(int *)(*(int *)(iVar10 + 8) + uVar11 * 4 + 0x10) = iVar6;
		        }
		        else {
		          System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                    (iVar10,iVar6,*(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x60) + 0x38));
		        }
		        if (iVar5 != *(int *)(iVar6 + 0x34)) {
		          *(int *)(iVar6 + 0x34) = iVar5;
		          Gameplay_AccountLinker_View_AccountLinkerUserView__set_User(iVar6,iVar10);
		        }
		        iVar12 = iVar12 + 1;
		      } while (iVar12 < *(int *)(iVar4 + 0xc));
		    }
		    return;
		  }
		  System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		            (&local_20,*(undefined4 *)(param1 + 0x1c),
		             Method_System_Collections_Generic_List_AccountLinkerUserView__GetEnumerator__);
		  local_8 = local_18;
		  local_20 = 0;
		  puStack_1c = local_10;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar4 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,local_10,
		                       Method_System_Collections_Generic_List_Enumerator_AccountLinkerUserView__MoveNext__
		                      );
		    iVar12 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar12 == 1) {
		      uVar7 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80f49ec2:
		      iVar12 = global_1;
		      iVar4 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar12 == iVar4) {
		        piVar8 = (int *)import::env::__cxa_begin_catch(uVar7);
		        iVar4 = *piVar8;
		        DAT_ram_009d3e38 = 0;
		        local_20 = iVar4;
		        import::env::invoke_v(0x123);
		        iVar12 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar12 != 1) {
		          if (iVar4 != 0) {
		            System_Data_DataSet__ValidateLocaleConstraint(iVar4);
		            do {
		              halt_trap();
		            } while( true );
		          }
		code_r0x80f49f71:
		          DAT_ram_009d3e38 = 0;
		          iVar12 = *(int *)(param1 + 0x1c);
		          iVar4 = *(int *)(iVar12 + 0xc);
		          *(undefined4 *)(iVar12 + 0xc) = 0;
		          *(int *)(iVar12 + 0x10) = *(int *)(iVar12 + 0x10) + 1;
		          if (iVar4 < 1) {
		            return;
		          }
		          func_ii_2064(*(undefined4 *)(iVar12 + 8),0,iVar4,0);
		          return;
		        }
		        uVar7 = import::env::__cxa_find_matching_catch_2();
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x1d9,&local_20);
		      iVar12 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar12 != 1) {
		        import::env::__resumeException(uVar7);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      import::env::__cxa_find_matching_catch_3(0);
		      unnamed_function_937();
		      do {
		        halt_trap();
		      } while( true );
		    }
		    if (iVar4 == 0) goto code_r0x80f49f71;
		    DAT_ram_009d3e38 = 0;
		    iVar12 = local_8._4_4_;
		    uVar7 = import::env::invoke_ii
		                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                       System_EventHandler_LinkerUser__TypeInfo);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80f49eba:
		      DAT_ram_009d3e38 = 0;
		      uVar7 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80f49ec2;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viiii
		              (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x2cf,uVar7,param1,
		               Method_Gameplay_AccountLinker_View_SelectUserView_HandleOnSelectEvent__,0);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80f49eba;
		    if (DAT_ram_00a58908 == '\0') {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi(0x7ff,&System_EventHandler_LinkerUser__TypeInfo);
		      if (DAT_ram_009d3e38 == 1) goto code_r0x80f49eba;
		      DAT_ram_00a58908 = '\x01';
		    }
		    iVar4 = *(int *)(iVar12 + 0x30);
		    do {
		      DAT_ram_009d3e38 = 0;
		      iVar5 = import::env::invoke_iiii
		                        (s_struct_Uniforms___color__array<v_ram_00001b87 + 2,iVar4,uVar7,0);
		      uVar9 = System_EventHandler_LinkerUser__TypeInfo;
		      if (DAT_ram_009d3e38 == 1) {
		code_r0x80f49e9d:
		        DAT_ram_009d3e38 = 0;
		        uVar7 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80f49ec2;
		      }
		      if (iVar5 == 0) {
		        iVar6 = 0;
		      }
		      else {
		        DAT_ram_009d3e38 = 0;
		        iVar6 = import::env::invoke_iii
		                          (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1a,iVar5,
		                           System_EventHandler_LinkerUser__TypeInfo);
		        if (DAT_ram_009d3e38 == 1) goto code_r0x80f49e9d;
		        if (iVar6 == 0) {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_vii
		                    (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x183,iVar5,uVar9);
		          iVar12 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar12 != 1) {
		            do {
		              halt_trap();
		            } while( true );
		          }
		          uVar7 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80f49ec2;
		        }
		      }
		      DAT_ram_009d3e38 = 0;
		      iVar5 = func_ii_4329(iVar12 + 0x30,iVar6,iVar4);
		      if (DAT_ram_009d3e38 == 1) goto code_r0x80f49e9d;
		      bVar1 = iVar4 != iVar5;
		      iVar4 = iVar5;
		    } while (bVar1);
		  } while( true );
		}
		*/


		/* --- GHIDRA: add_OnSelect ---
		void Gameplay_AccountLinker_View_SelectUserView__add_OnSelect
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a58926 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_LinkerUser__TypeInfo);
		    DAT_ram_00a58926 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x20);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_LinkerUser__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_LinkerUser__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x20,iVar2,param1_00);
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


		/* --- GHIDRA: remove_OnSelect ---
		void Gameplay_AccountLinker_View_SelectUserView__remove_OnSelect
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  int iVar1;
		  
		  iVar1 = *(int *)(param1 + 0x20);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		            (*(undefined4 *)(iVar1 + 0x20),param3,*(undefined4 *)(iVar1 + 0x14));
		  return;
		}
		*/

}
