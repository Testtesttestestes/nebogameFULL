using System;
using Gameplay.Accounts.Clan.Model;
using Gameplay.Accounts.Control;
using Gameplay.Accounts.Model.Data;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Accounts.Clan.Control
{
	// Token: 0x02000DF0 RID: 3568
	[Token(Token = "0x2000DF0")]
	public class ClanAccountController : AbstractController<ClanAccountModel, AccountsEvents>
	{
		// Token: 0x06005718 RID: 22296 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005718")]
		[Address(RVA = "0xA494", Offset = "0xA494", VA = "0xA494", Slot = "5")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Gameplay_Accounts_Clan_Control_ClanAccountController__Dispose
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  if (DAT_ram_00a588f5 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_MVC_AbstractController_ClanAccountModel__AccountsEvents___ctor__);
		    DAT_ram_00a588f5 = '\x01';
		  }
		  Gameplay_Combat_AbstractCombat_object__object__object__object__object___set_User
		            (param1,param3,param4,
		             Method_MVC_AbstractController_ClanAccountModel__AccountsEvents___ctor__);
		  *(undefined4 *)(param1 + 0x18) = param2;
		  return;
		}
		*/

		}

		// Token: 0x06005719 RID: 22297 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005719")]
		[Address(RVA = "0xA495", Offset = "0xA495", VA = "0xA495")]
		public ClanAccountController(AccountsController accountsController, ClanAccountModel model, AccountsEvents events)
		{
		/* --- GHIDRA: .ctor ---
		undefined4
		Gameplay_Accounts_Clan_Control_ClanAccountController___ctor
		          (int *param1,undefined4 param2,undefined4 param3,undefined4 *param4,undefined4 param5)
		
		{
		  uint uVar1;
		  int iVar2;
		  int iVar3;
		  undefined4 *puVar4;
		  int *piVar5;
		  undefined4 uVar6;
		  int *piVar7;
		  int local_24;
		  undefined8 *local_20;
		  undefined4 local_1c;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a588f6 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_IAccountDataDecorator__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_IAccountDataDecorator__MoveNext__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_IAccountDataDecorator__get_Current__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Accounts_Model_Data_IAccountDataDecorator_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_IAccountDataDecorator__GetEnumerator__);
		    DAT_ram_00a588f6 = '\x01';
		  }
		  local_4 = 0;
		  local_10 = 0;
		  local_18 = 0;
		  local_1c = 0;
		  *param4 = 0;
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  iVar2 = Core_Data_UserData__get_ClanId(*(undefined4 *)(iVar2 + 8),0);
		  if (iVar2 == 0) {
		    *param4 = 1;
		    uVar6 = 0;
		  }
		  else {
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    iVar2 = **(int **)(iVar3 + 0x10);
		    iVar3 = (**(code **)((ulonglong)*(uint *)(iVar2 + 0x160) * 4))
		                      (*(int **)(iVar3 + 0x10),&local_4,*(undefined4 *)(iVar2 + 0x164));
		    if (iVar3 == 0) {
		code_r0x80f4586f:
		      Gameplay_Accounts_Control_AccountsController__BuyAccount(param1[6],param2,param3,iVar2);
		      uVar6 = 1;
		    }
		    else {
		      System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		                (&local_18,local_4,
		                 Method_System_Collections_Generic_List_IAccountDataDecorator__GetEnumerator__);
		      local_24 = 0;
		      local_20 = &local_18;
		      do {
		        DAT_ram_009d3e38 = 0;
		        iVar3 = import::env::invoke_iii
		                          (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_18,
		                           Method_System_Collections_Generic_List_Enumerator_IAccountDataDecorator__MoveNext__
		                          );
		        iVar2 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar2 == 1) {
		          uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80f457cd:
		          iVar2 = global_1;
		          iVar3 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		          if (iVar2 == iVar3) {
		            piVar5 = (int *)import::env::__cxa_begin_catch(uVar6);
		            iVar3 = *piVar5;
		            DAT_ram_009d3e38 = 0;
		            local_24 = iVar3;
		            import::env::invoke_v(0x123);
		            iVar2 = DAT_ram_009d3e38;
		            DAT_ram_009d3e38 = 0;
		            if (iVar2 != 1) {
		              if (iVar3 != 0) {
		                System_Data_DataSet__ValidateLocaleConstraint(iVar3);
		                do {
		                  halt_trap();
		                } while( true );
		              }
		              iVar2 = 0;
		              goto code_r0x80f4586f;
		            }
		            uVar6 = import::env::__cxa_find_matching_catch_2();
		          }
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x1cc,&local_24);
		          iVar2 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar2 != 1) {
		            import::env::__resumeException(uVar6);
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
		        if (iVar3 == 0) goto code_r0x80f4586f;
		        DAT_ram_009d3e38 = 0;
		        piVar5 = local_10._4_4_;
		        iVar3 = import::env::invoke_iii
		                          (*(undefined4 *)(*param1 + 0x100),param1,*(undefined4 *)(*param1 + 0x104))
		        ;
		        iVar2 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar2 == 1) {
		          uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80f457cd;
		        }
		        DAT_ram_009d3e38 = 0;
		        uVar6 = import::env::invoke_iii
		                          (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x1ca,
		                           *(undefined4 *)(iVar3 + 8),0);
		        iVar2 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar2 == 1) {
		          uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80f457cd;
		        }
		        iVar2 = *piVar5;
		        if (*(ushort *)(iVar2 + 0xb6) != 0) {
		          uVar1 = 0;
		          do {
		            piVar7 = (int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8);
		            if (Gameplay_Accounts_Model_Data_IAccountDataDecorator_TypeInfo == *piVar7) {
		              puVar4 = (undefined4 *)(piVar7[1] * 8 + iVar2 + 200);
		              goto code_r0x80f456fb;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		        }
		        DAT_ram_009d3e38 = 0;
		        puVar4 = (undefined4 *)
		                 import::env::invoke_iiii
		                           (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar5,
		                            Gameplay_Accounts_Model_Data_IAccountDataDecorator_TypeInfo,1);
		        if (DAT_ram_009d3e38 == 1) {
		code_r0x80f457a5:
		          DAT_ram_009d3e38 = 0;
		          uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80f457cd;
		        }
		code_r0x80f456fb:
		        DAT_ram_009d3e38 = 0;
		        iVar2 = import::env::invoke_iii(*puVar4,piVar5,puVar4[1]);
		        if (DAT_ram_009d3e38 == 1) goto code_r0x80f457a5;
		        DAT_ram_009d3e38 = 0;
		        iVar3 = import::env::invoke_iiiii
		                          (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x1cb,uVar6,
		                           *(undefined4 *)(iVar2 + 0xc),&local_1c,0);
		        iVar2 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar2 == 1) {
		          uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80f457cd;
		        }
		      } while (iVar3 == 0);
		      *param4 = 2;
		      uVar6 = 0;
		    }
		  }
		  return uVar6;
		}
		*/

		}

		// Token: 0x0600571A RID: 22298 RVA: 0x0000F978 File Offset: 0x0000DB78
		[Token(Token = "0x600571A")]
		[Address(RVA = "0xA496", Offset = "0xA496", VA = "0xA496")]
		public bool TryBuyAccount(IAccountDataDecorator account, AccountOptionData accountOption, out BuyRejectedReason rejectReason)
		{
		/* --- GHIDRA: TryBuyAccount ---
		void Gameplay_Accounts_Clan_Control_ClanAccountController__TryBuyAccount
		               (int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a588f7 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanAccountModel__AccountsEvents__ClanAccountController__ClanAccountView__Dispose__
		              );
		    DAT_ram_00a588f7 = '\x01';
		  }
		  Gameplay_Accounts_Clan_Control_ClanAccountViewMediator__DisplayOptionsButtons
		            (param1,*(undefined4 *)(param1 + 0x18),param1);
		  MVC_AbstractViewMediator_object__object__object__object___Core_MVC_Interfaces_IViewMediator_set_View
		            (param1,
		             Method_MVC_AbstractViewMediator_ClanAccountModel__AccountsEvents__ClanAccountController__ClanAccountView__Dispose__
		            );
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x04002F25 RID: 12069
		[Token(Token = "0x4002F25")]
		[FieldOffset(Offset = "0x18")]
		private AccountsController _accountsController;
	}
}
