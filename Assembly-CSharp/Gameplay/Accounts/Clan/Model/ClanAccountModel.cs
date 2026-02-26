using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Gameplay.Accounts.Model.Data;
using Gameplay.Clans.Model;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Accounts.Clan.Model
{
	// Token: 0x02000DEF RID: 3567
	[Token(Token = "0x2000DEF")]
	public class ClanAccountModel : AbstractModel
	{
		// Token: 0x170011C0 RID: 4544
		// (get) Token: 0x06005710 RID: 22288 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005711 RID: 22289 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170011C0")]
		public ClansModel ClansModel
		{
			[Token(Token = "0x6005710")]
			[Address(RVA = "0xA48C", Offset = "0xA48C", VA = "0xA48C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005711")]
			[Address(RVA = "0xA48D", Offset = "0xA48D", VA = "0xA48D")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06005712 RID: 22290 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005712")]
		[Address(RVA = "0xA48E", Offset = "0xA48E", VA = "0xA48E", Slot = "5")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Gameplay_Accounts_Clan_Model_ClanAccountModel__Dispose
		               (int param1,int *param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  uint uVar1;
		  int iVar2;
		  int iVar3;
		  undefined4 *puVar4;
		  undefined4 param1_00;
		  int *piVar5;
		  int *piVar6;
		  int local_28;
		  undefined1 *puStack_24;
		  undefined8 local_20;
		  undefined1 local_18 [8];
		  undefined8 local_10;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a588f3 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Accounts_Model_Data_ClanAccount_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_First_IAccountDataDecorator___);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_IAccountDataDecorator__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_IAccountDataDecorator__MoveNext__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_IAccountDataDecorator__get_Current__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Data_Accounts_IAccountData_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_IAccountDataDecorator__GetEnumerator__);
		    DAT_ram_00a588f3 = '\x01';
		  }
		  local_4 = 0;
		  Unity_Services_Core_Environments_Internal_Environments__get_Current(param1,param4,0);
		  *(undefined4 *)(param1 + 0xc) = param3;
		  *(int **)(param1 + 0x10) = param2;
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param2 + 0x160) * 4))
		                    (param2,&local_4,*(undefined4 *)(*param2 + 0x164));
		  if (iVar2 != 0) {
		    System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		              (&local_28,local_4,
		               Method_System_Collections_Generic_List_IAccountDataDecorator__GetEnumerator__);
		    local_10 = local_20;
		    local_28 = 0;
		    puStack_24 = local_18;
		    do {
		      DAT_ram_009d3e38 = 0;
		      iVar3 = import::env::invoke_iii
		                        (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,local_18,
		                         Method_System_Collections_Generic_List_Enumerator_IAccountDataDecorator__MoveNext__
		                        );
		      iVar2 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar2 == 1) {
		        param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80f450c5;
		      }
		      if (iVar3 == 0) goto code_r0x80f45120;
		      piVar5 = local_10._4_4_;
		      iVar2 = *local_10._4_4_;
		      if (*(ushort *)(iVar2 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          piVar6 = (int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8);
		          if (Core_Data_Accounts_IAccountData_TypeInfo == *piVar6) {
		            puVar4 = (undefined4 *)(piVar6[1] * 8 + iVar2 + 0xd0);
		            goto code_r0x80f44fe6;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		      }
		      DAT_ram_009d3e38 = 0;
		      puVar4 = (undefined4 *)
		               import::env::invoke_iiii
		                         (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_10._4_4_,
		                          Core_Data_Accounts_IAccountData_TypeInfo,2);
		      if (DAT_ram_009d3e38 == 1) {
		code_r0x80f450b7:
		        DAT_ram_009d3e38 = 0;
		        param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80f450c5;
		      }
		code_r0x80f44fe6:
		      DAT_ram_009d3e38 = 0;
		      iVar3 = import::env::invoke_iii(*puVar4,piVar5,puVar4[1]);
		      iVar2 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar2 == 1) goto code_r0x80f450b7;
		    } while (iVar3 != 0);
		    if (((uint)*(byte *)(*piVar5 + 0xb8) <
		         (uint)*(byte *)(Gameplay_Accounts_Model_Data_ClanAccount_TypeInfo + 0xb8)) ||
		       (*(int *)(*(int *)(*piVar5 + 100) +
		                 (uint)*(byte *)(Gameplay_Accounts_Model_Data_ClanAccount_TypeInfo + 0xb8) * 4 + -4)
		        != Gameplay_Accounts_Model_Data_ClanAccount_TypeInfo)) {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vii
		                (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x183,piVar5,
		                 Gameplay_Accounts_Model_Data_ClanAccount_TypeInfo);
		      iVar2 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar2 != 1) {
		        do {
		          halt_trap();
		        } while( true );
		      }
		      param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80f450c5:
		      iVar2 = global_1;
		      iVar3 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar2 != iVar3) {
		code_r0x80f45180:
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x1c9,&local_28);
		        iVar2 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar2 != 1) {
		          import::env::__resumeException(param1_00);
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
		      piVar5 = (int *)import::env::__cxa_begin_catch(param1_00);
		      iVar3 = *piVar5;
		      DAT_ram_009d3e38 = 0;
		      local_28 = iVar3;
		      import::env::invoke_v(0x123);
		      iVar2 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar2 == 1) {
		        param1_00 = import::env::__cxa_find_matching_catch_2();
		        goto code_r0x80f45180;
		      }
		      if (iVar3 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(iVar3);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    else {
		      *(int **)(param1 + 0x14) = piVar5;
		    }
		code_r0x80f45120:
		    if (*(int *)(param1 + 0x14) == 0) {
		      piVar5 = (int *)System_Linq_Enumerable__Count_object_
		                                (local_4,
		                                 Method_System_Linq_Enumerable_First_IAccountDataDecorator___);
		      if (piVar5 != (int *)0x0) {
		        if (((uint)*(byte *)(*piVar5 + 0xb8) <
		             (uint)*(byte *)(Gameplay_Accounts_Model_Data_ClanAccount_TypeInfo + 0xb8)) ||
		           (*(int *)(*(int *)(*piVar5 + 100) +
		                     (uint)*(byte *)(Gameplay_Accounts_Model_Data_ClanAccount_TypeInfo + 0xb8) * 4 +
		                    -4) != Gameplay_Accounts_Model_Data_ClanAccount_TypeInfo)) {
		          System_Activator__CreateInstance(piVar5,Gameplay_Accounts_Model_Data_ClanAccount_TypeInfo)
		          ;
		          do {
		            halt_trap();
		          } while( true );
		        }
		      }
		      *(int **)(param1 + 0x14) = piVar5;
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06005713 RID: 22291 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005713")]
		[Address(RVA = "0xA48F", Offset = "0xA48F", VA = "0xA48F")]
		public ClanAccountModel(ClanAccountGroup accountGroup, ClansModel clansModel, UserData user)
		{
		}

		// Token: 0x170011C1 RID: 4545
		// (get) Token: 0x06005714 RID: 22292 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005715 RID: 22293 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170011C1")]
		public ClanAccountGroup AccountGroup
		{
			[Token(Token = "0x6005714")]
			[Address(RVA = "0xA490", Offset = "0xA490", VA = "0xA490")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005715")]
			[Address(RVA = "0xA491", Offset = "0xA491", VA = "0xA491")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170011C2 RID: 4546
		// (get) Token: 0x06005716 RID: 22294 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005717 RID: 22295 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170011C2")]
		public ClanAccount CurrentSelected
		{
			[Token(Token = "0x6005716")]
			[Address(RVA = "0xA492", Offset = "0xA492", VA = "0xA492")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005717")]
			[Address(RVA = "0xA493", Offset = "0xA493", VA = "0xA493")]
			[CompilerGenerated]
			set
			{
			}
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_ClansModel ---
		void Gameplay_Accounts_Clan_Model_ClanAccountModel__set_ClansModel(int param1,undefined4 param2)
		
		{
		  *(undefined4 *)(param1 + 0x14) = 0;
		  *(undefined8 *)(param1 + 0xc) = 0;
		  Core_ExternalIncomingScriptCall_CallbackItem___Il2CppFullySharedGenericType____ctor(param1,0);
		  return;
		}
		*/


		/* --- GHIDRA: set_CurrentSelected ---
		void Gameplay_Accounts_Clan_Model_ClanAccountModel__set_CurrentSelected
		               (int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a588f4 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_MVC_AbstractController_ClanAccountModel__AccountsEvents__Dispose__);
		    DAT_ram_00a588f4 = '\x01';
		  }
		  *(undefined4 *)(param1 + 0x18) = 0;
		  MVC_AbstractController_object__object____ctor
		            (param1,Method_MVC_AbstractController_ClanAccountModel__AccountsEvents__Dispose__);
		  return;
		}
		*/

}
