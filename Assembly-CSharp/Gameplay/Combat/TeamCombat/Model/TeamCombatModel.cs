using System;
using System.Collections.Generic;
using Core.Data;
using Gameplay.Combat.Model;
using Il2CppDummyDll;
using Utils;

namespace Gameplay.Combat.TeamCombat.Model
{
	// Token: 0x0200098E RID: 2446
	[Token(Token = "0x200098E")]
	public abstract class TeamCombatModel : CombatModel
	{
		// Token: 0x06003A59 RID: 14937 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A59")]
		[Address(RVA = "0x89CF", Offset = "0x89CF", VA = "0x89CF")]
		protected TeamCombatModel(CombatDependencies dependencies, BackTime awaitBackTime, UserData loggedUser, UserData user)
		{
		/* --- GHIDRA: .ctor ---
		int Gameplay_Combat_TeamCombat_Model_TeamCombatModel___ctor(int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int iVar5;
		  int *piVar6;
		  uint uVar7;
		  int local_18;
		  undefined8 *local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a57e2c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_ulong__CombatPlayer__get_Values__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_ulong__CombatPlayer__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_ulong__CombatPlayer__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_ulong__CombatPlayer__get_Current__
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_CombatPlayer__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_CombatPlayer___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_CombatPlayer__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_ulong__CombatPlayer__GetEnumerator__
		              );
		    DAT_ram_00a57e2c = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  iVar2 = unnamed_function_1417(System_Collections_Generic_List_CombatPlayer__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (iVar2,Method_System_Collections_Generic_List_CombatPlayer___ctor__);
		  uVar3 = System_Collections_Generic_Dictionary_int__object___TryAdd
		                    (*(undefined4 *)(param1 + 0x1c),
		                     Method_System_Collections_Generic_Dictionary_ulong__CombatPlayer__get_Values__)
		  ;
		  System_Collections_Generic_Dictionary_Int32Enum__object___get_Values
		            (&local_10,uVar3,
		             Method_System_Collections_Generic_Dictionary_ValueCollection_ulong__CombatPlayer__GetEnumerator__
		            );
		  local_18 = 0;
		  local_14 = &local_10;
		  do {
		    while( true ) {
		      do {
		        DAT_ram_009d3e38 = 0;
		        iVar4 = import::env::invoke_iii
		                          (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x2e2,&local_10,
		                           Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_ulong__CombatPlayer__MoveNext__
		                          );
		        iVar5 = DAT_ram_009d3e38;
		        iVar1 = Method_System_Collections_Generic_List_CombatPlayer__Add__;
		        DAT_ram_009d3e38 = 0;
		        if (iVar5 == 1) {
		          uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80e6a2c1;
		        }
		        iVar5 = local_18;
		        if (iVar4 == 0) goto code_r0x80e6a30a;
		      } while (*(int *)(*(int *)(local_8._4_4_ + 8) + 0x14) != param2);
		      *(int *)(iVar2 + 0x10) = *(int *)(iVar2 + 0x10) + 1;
		      uVar7 = *(uint *)(iVar2 + 0xc);
		      if (*(uint *)(*(int *)(iVar2 + 8) + 0xc) <= uVar7) break;
		      *(uint *)(iVar2 + 0xc) = uVar7 + 1;
		      *(int *)(*(int *)(iVar2 + 8) + uVar7 * 4 + 0x10) = local_8._4_4_;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,iVar2,local_8._4_4_,
		               *(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		  } while (iVar1 != 1);
		  uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80e6a2c1:
		  iVar1 = global_1;
		  iVar5 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar1 == iVar5) {
		    piVar6 = (int *)import::env::__cxa_begin_catch(uVar3);
		    iVar5 = *piVar6;
		    DAT_ram_009d3e38 = 0;
		    local_18 = iVar5;
		    import::env::invoke_v(0x123);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 != 1) {
		code_r0x80e6a30a:
		      DAT_ram_009d3e38 = 0;
		      if (iVar5 == 0) {
		        return iVar2;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(iVar5);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar3 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0xaf,&local_18);
		  iVar2 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar2 == 1) {
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  import::env::__resumeException(uVar3);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06003A5A RID: 14938 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003A5A")]
		[Address(RVA = "0x89D0", Offset = "0x89D0", VA = "0x89D0", Slot = "17")]
		public virtual List<CombatPlayer> GetTeamPlayersContains(uint userSide)
		{
		/* --- GHIDRA: GetTeamPlayersContains ---
		int Gameplay_Combat_TeamCombat_Model_TeamCombatModel__GetTeamPlayersContains
		              (int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int iVar5;
		  int *piVar6;
		  uint uVar7;
		  int local_18;
		  undefined8 *local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a57e2d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_ulong__CombatPlayer__get_Values__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_ulong__CombatPlayer__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_ulong__CombatPlayer__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_ulong__CombatPlayer__get_Current__
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_CombatPlayer__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_CombatPlayer___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_CombatPlayer__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_ulong__CombatPlayer__GetEnumerator__
		              );
		    DAT_ram_00a57e2d = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  iVar2 = unnamed_function_1417(System_Collections_Generic_List_CombatPlayer__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (iVar2,Method_System_Collections_Generic_List_CombatPlayer___ctor__);
		  uVar3 = System_Collections_Generic_Dictionary_int__object___TryAdd
		                    (*(undefined4 *)(param1 + 0x1c),
		                     Method_System_Collections_Generic_Dictionary_ulong__CombatPlayer__get_Values__)
		  ;
		  System_Collections_Generic_Dictionary_Int32Enum__object___get_Values
		            (&local_10,uVar3,
		             Method_System_Collections_Generic_Dictionary_ValueCollection_ulong__CombatPlayer__GetEnumerator__
		            );
		  local_18 = 0;
		  local_14 = &local_10;
		  do {
		    while( true ) {
		      do {
		        DAT_ram_009d3e38 = 0;
		        iVar4 = import::env::invoke_iii
		                          (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x2e2,&local_10,
		                           Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_ulong__CombatPlayer__MoveNext__
		                          );
		        iVar5 = DAT_ram_009d3e38;
		        iVar1 = Method_System_Collections_Generic_List_CombatPlayer__Add__;
		        DAT_ram_009d3e38 = 0;
		        if (iVar5 == 1) {
		          uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80e6a559;
		        }
		        iVar5 = local_18;
		        if (iVar4 == 0) goto code_r0x80e6a5a2;
		      } while (*(int *)(*(int *)(local_8._4_4_ + 8) + 0x14) == param2);
		      *(int *)(iVar2 + 0x10) = *(int *)(iVar2 + 0x10) + 1;
		      uVar7 = *(uint *)(iVar2 + 0xc);
		      if (*(uint *)(*(int *)(iVar2 + 8) + 0xc) <= uVar7) break;
		      *(uint *)(iVar2 + 0xc) = uVar7 + 1;
		      *(int *)(*(int *)(iVar2 + 8) + uVar7 * 4 + 0x10) = local_8._4_4_;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,iVar2,local_8._4_4_,
		               *(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		  } while (iVar1 != 1);
		  uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80e6a559:
		  iVar1 = global_1;
		  iVar5 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar1 == iVar5) {
		    piVar6 = (int *)import::env::__cxa_begin_catch(uVar3);
		    iVar5 = *piVar6;
		    DAT_ram_009d3e38 = 0;
		    local_18 = iVar5;
		    import::env::invoke_v(0x123);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 != 1) {
		code_r0x80e6a5a2:
		      DAT_ram_009d3e38 = 0;
		      if (iVar5 == 0) {
		        return iVar2;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(iVar5);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar3 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0xb0,&local_18);
		  iVar2 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar2 == 1) {
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  import::env::__resumeException(uVar3);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

			return null;
		}

		// Token: 0x06003A5B RID: 14939 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003A5B")]
		[Address(RVA = "0x89D1", Offset = "0x89D1", VA = "0x89D1", Slot = "18")]
		public virtual List<CombatPlayer> GetTeamPlayersNotContains(uint userSide)
		{
			return null;
		}
	}
}
