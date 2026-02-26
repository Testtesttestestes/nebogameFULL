using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Data.Balance;
using Gameplay.WorldAxis.Model;
using Il2CppDummyDll;
using MVC;
using Protocol.Colossus;
using Protocol.Dic;

namespace Gameplay.Clans.Office.Model
{
	// Token: 0x02000A54 RID: 2644
	[Token(Token = "0x2000A54")]
	public class SquadModel : AbstractModel
	{
		// Token: 0x17000C8D RID: 3213
		// (get) Token: 0x06003E9F RID: 16031 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000C8D")]
		public Dictionaries Dict
		{
			[Token(Token = "0x6003E9F")]
			[Address(RVA = "0x8D5D", Offset = "0x8D5D", VA = "0x8D5D")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C8E RID: 3214
		// (get) Token: 0x06003EA0 RID: 16032 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003EA1 RID: 16033 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C8E")]
		public List<SquadModel.PartyData> Parties
		{
			[Token(Token = "0x6003EA0")]
			[Address(RVA = "0x8D5E", Offset = "0x8D5E", VA = "0x8D5E")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003EA1")]
			[Address(RVA = "0x8D5F", Offset = "0x8D5F", VA = "0x8D5F")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000C8F RID: 3215
		// (get) Token: 0x06003EA2 RID: 16034 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003EA3 RID: 16035 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C8F")]
		public IBalanceSource Treasury
		{
			[Token(Token = "0x6003EA2")]
			[Address(RVA = "0x8D60", Offset = "0x8D60", VA = "0x8D60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003EA3")]
			[Address(RVA = "0x8D61", Offset = "0x8D61", VA = "0x8D61")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06003EA4 RID: 16036 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EA4")]
		[Address(RVA = "0x8D62", Offset = "0x8D62", VA = "0x8D62")]
		public SquadModel(UserData user, ClanInfoModel model, WorldAxisModel worldAxisModel)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Clans_Office_Model_SquadModel___ctor(int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  undefined4 *puVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a57fc0 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_OrderBy_PartyInfo__uint___);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_Select_PartyInfo__SquadModel_PartyData___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToList_SquadModel_PartyData___);
		    Mono_Security_ASN1__get_Item(&System_Func_PartyInfo__SquadModel_PartyData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Func_PartyInfo__uint__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Clans_Office_Model_SquadModel__PopulateParties_b__14_1__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Clans_Office_Model_SquadModel___c__PopulateParties_b__14_0__);
		    Mono_Security_ASN1__get_Item(&Gameplay_Clans_Office_Model_SquadModel___c_TypeInfo);
		    DAT_ram_00a57fc0 = '\x01';
		  }
		  if (*(int *)(Gameplay_Clans_Office_Model_SquadModel___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_Clans_Office_Model_SquadModel___c_TypeInfo);
		  }
		  puVar2 = *(undefined4 **)(Gameplay_Clans_Office_Model_SquadModel___c_TypeInfo + 0x5c);
		  param1_01 = puVar2[1];
		  if (param1_01 == 0) {
		    if (*(int *)(Gameplay_Clans_Office_Model_SquadModel___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_Clans_Office_Model_SquadModel___c_TypeInfo);
		      puVar2 = *(undefined4 **)(Gameplay_Clans_Office_Model_SquadModel___c_TypeInfo + 0x5c);
		    }
		    uVar1 = *puVar2;
		    param1_01 = unnamed_function_1417(System_Func_PartyInfo__uint__TypeInfo);
		    System_Collections_Generic_Dictionary_KeyCollection_uint__object___GetEnumerator
		              (param1_01,uVar1,
		               Method_Gameplay_Clans_Office_Model_SquadModel___c__PopulateParties_b__14_0__,0);
		    *(int *)(*(int *)(Gameplay_Clans_Office_Model_SquadModel___c_TypeInfo + 0x5c) + 4) = param1_01;
		  }
		  uVar1 = System_Linq_Enumerable__Min___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType_
		                    (param2,param1_01,Method_System_Linq_Enumerable_OrderBy_PartyInfo__uint___);
		  param1_00 = unnamed_function_1417(System_Func_PartyInfo__SquadModel_PartyData__TypeInfo);
		  System_Linq_Enumerable__Where_object_
		            (param1_00,param1,
		             Method_Gameplay_Clans_Office_Model_SquadModel__PopulateParties_b__14_1__,0);
		  uVar1 = System_Linq_Enumerable__ReverseIterator___Il2CppFullySharedGenericType_
		                    (uVar1,param1_00,
		                     Method_System_Linq_Enumerable_Select_PartyInfo__SquadModel_PartyData___);
		  uVar1 = System_Linq_Enumerable__Select_object__object_
		                    (uVar1,Method_System_Linq_Enumerable_ToList_SquadModel_PartyData___);
		  *(undefined4 *)(param1 + 0x18) = uVar1;
		  return;
		}
		*/

		}

		// Token: 0x06003EA5 RID: 16037 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EA5")]
		[Address(RVA = "0x8D63", Offset = "0x8D63", VA = "0x8D63")]
		public void PopulateParties(IList<PartyInfo> parties)
		{
		/* --- GHIDRA: PopulateParties ---
		/* WARNING: Removing unreachable block (ram,0x80e8bd47) */
		/* WARNING: Removing unreachable block (ram,0x80e8b7ad) */
		
		void Gameplay_Clans_Office_Model_SquadModel__PopulateParties
		               (int param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 *puVar3;
		  undefined4 uVar4;
		  int iVar5;
		  int param3_00;
		  int iVar6;
		  int *piVar7;
		  undefined4 uVar8;
		  undefined4 param2_00;
		  int param2_01;
		  int *piVar9;
		  int iVar10;
		  int local_18;
		  int **local_14;
		  int local_10;
		  int **local_c;
		  int *local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a57fc1 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerable_PartyInfo__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerator_PartySlot__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerator_PartyInfo__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_SquadModel_PartyData__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_SquadModel_ColossusPartySlot__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_SquadModel_ColossusPartySlot__FindIndex__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_SquadModel_PartyData__FindIndex__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_SquadModel_PartyData__get_Item__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_SquadModel_ColossusPartySlot__set_Item__);
		    Mono_Security_ASN1__get_Item(&System_Predicate_SquadModel_ColossusPartySlot__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Predicate_SquadModel_PartyData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_PartySlot__GetEnumerator__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Model_SquadModel___c__DisplayClass15_0__ParsePartyChanges_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Clans_Office_Model_SquadModel___c__DisplayClass15_0_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Model_SquadModel___c__DisplayClass15_1__ParsePartyChanges_b__1__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Clans_Office_Model_SquadModel___c__DisplayClass15_1_TypeInfo);
		    DAT_ram_00a57fc1 = '\x01';
		  }
		  local_4 = (int *)0x0;
		  local_8 = (int *)0x0;
		  iVar10 = *param2;
		  if (*(ushort *)(iVar10 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (System_Collections_Generic_IEnumerable_PartyInfo__TypeInfo ==
		          *(int *)(*(int *)(iVar10 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(iVar10 + *(int *)(*(int *)(iVar10 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80e8b62f;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar10 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,System_Collections_Generic_IEnumerable_PartyInfo__TypeInfo,0)
		  ;
		code_r0x80e8b62f:
		  local_4 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		  local_10 = 0;
		  local_c = &local_4;
		code_r0x80e8b654:
		  do {
		    piVar7 = local_4;
		    iVar10 = *local_4;
		    if (*(ushort *)(iVar10 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar9 = (int *)(*(int *)(iVar10 + 0x58) + uVar1 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar9) {
		          puVar3 = (undefined4 *)(iVar10 + piVar9[1] * 8 + 0xc0);
		          goto code_r0x80e8b6fe;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar10 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar3 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_IEnumerator_TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80e8b742:
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      iVar10 = global_1;
		      goto code_r0x80e8c448;
		    }
		code_r0x80e8b6fe:
		    DAT_ram_009d3e38 = 0;
		    iVar10 = import::env::invoke_iii(*puVar3,piVar7,puVar3[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80e8b742;
		    if (iVar10 == 0) goto code_r0x80e8c48f;
		    DAT_ram_009d3e38 = 0;
		    iVar10 = import::env::invoke_ii
		                       (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                        Gameplay_Clans_Office_Model_SquadModel___c__DisplayClass15_0_TypeInfo);
		    piVar7 = local_4;
		    if (DAT_ram_009d3e38 == 1) {
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      iVar10 = global_1;
		      goto code_r0x80e8c448;
		    }
		    iVar6 = *local_4;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar9 = (int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8);
		        if (System_Collections_Generic_IEnumerator_PartyInfo__TypeInfo == *piVar9) {
		          puVar3 = (undefined4 *)(iVar6 + piVar9[1] * 8 + 0xc0);
		          goto code_r0x80e8b854;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar3 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_Generic_IEnumerator_PartyInfo__TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80e8b9d1:
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      iVar10 = global_1;
		      goto code_r0x80e8c448;
		    }
		code_r0x80e8b854:
		    DAT_ram_009d3e38 = 0;
		    uVar4 = import::env::invoke_iii(*puVar3,piVar7,puVar3[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80e8b9d1;
		    *(undefined4 *)(iVar10 + 8) = uVar4;
		    uVar8 = *(undefined4 *)(param1 + 0x18);
		    DAT_ram_009d3e38 = 0;
		    uVar4 = import::env::invoke_ii
		                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                       System_Predicate_SquadModel_PartyData__TypeInfo);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80e8b9db:
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      iVar10 = global_1;
		      goto code_r0x80e8c448;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viiii
		              (s_struct_Uniforms___color__array<v_ram_00001b87 + 0xfb,uVar4,iVar10,
		               Method_Gameplay_Clans_Office_Model_SquadModel___c__DisplayClass15_0__ParsePartyChanges_b__0__
		               ,0);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80e8b9db;
		    DAT_ram_009d3e38 = 0;
		    iVar5 = import::env::invoke_iiii
		                      (s_struct_Uniforms___color__array<v_ram_00001b87 + 0xfc,uVar8,uVar4,
		                       Method_System_Collections_Generic_List_SquadModel_PartyData__FindIndex__);
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 == 1) {
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      iVar10 = global_1;
		      goto code_r0x80e8c448;
		    }
		    iVar6 = *(int *)(param1 + 0x18);
		    if (iVar5 == -1) {
		      iVar5 = *(int *)(param1 + 0xc);
		      uVar4 = *(undefined4 *)(iVar10 + 8);
		      if (DAT_ram_00a57f87 == '\0') {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vi(0x7ff,&Core_Dict_IDictProvider_TypeInfo);
		        if (DAT_ram_009d3e38 != 1) {
		          DAT_ram_00a57f87 = '\x01';
		          goto code_r0x80e8b9a4;
		        }
		      }
		      else {
		code_r0x80e8b9a4:
		        piVar7 = *(int **)(iVar5 + 0xc);
		        iVar10 = *piVar7;
		        if (*(ushort *)(iVar10 + 0xb6) != 0) {
		          uVar1 = 0;
		          do {
		            piVar9 = (int *)(*(int *)(iVar10 + 0x58) + uVar1 * 8);
		            if (Core_Dict_IDictProvider_TypeInfo == *piVar9) {
		              puVar3 = (undefined4 *)(piVar9[1] * 8 + iVar10 + 0xd0);
		              goto code_r0x80e8ba5a;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar10 + 0xb6) != uVar1);
		        }
		        DAT_ram_009d3e38 = 0;
		        puVar3 = (undefined4 *)
		                 import::env::invoke_iiii
		                           (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar7,
		                            Core_Dict_IDictProvider_TypeInfo,2);
		        if (DAT_ram_009d3e38 != 1) {
		code_r0x80e8ba5a:
		          DAT_ram_009d3e38 = 0;
		          uVar8 = import::env::invoke_iii(*puVar3,piVar7,puVar3[1]);
		          if (DAT_ram_009d3e38 != 1) {
		            DAT_ram_009d3e38 = 0;
		            uVar4 = import::env::invoke_iiiii
		                              (s_struct_Uniforms___color__array<v_ram_00001b87 + 0xfd,uVar4,uVar8,
		                               *(undefined4 *)(param1 + 8),*(undefined4 *)(param1 + 8));
		            iVar10 = Method_System_Collections_Generic_List_SquadModel_PartyData__Add__;
		            if (DAT_ram_009d3e38 != 1) {
		              *(int *)(iVar6 + 0x10) = *(int *)(iVar6 + 0x10) + 1;
		              uVar1 = *(uint *)(iVar6 + 0xc);
		              if (uVar1 < *(uint *)(*(int *)(iVar6 + 8) + 0xc)) {
		                *(uint *)(iVar6 + 0xc) = uVar1 + 1;
		                *(undefined4 *)(*(int *)(iVar6 + 8) + uVar1 * 4 + 0x10) = uVar4;
		                goto code_r0x80e8b654;
		              }
		              DAT_ram_009d3e38 = 0;
		              import::env::invoke_viii
		                        (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,iVar6,uVar4,
		                         *(undefined4 *)(*(int *)(*(int *)(iVar10 + 0x10) + 0x60) + 0x38));
		              if (DAT_ram_009d3e38 != 1) goto code_r0x80e8b654;
		            }
		            DAT_ram_009d3e38 = 0;
		            uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            iVar10 = global_1;
		            goto code_r0x80e8c448;
		          }
		        }
		      }
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      iVar10 = global_1;
		      goto code_r0x80e8c448;
		    }
		    DAT_ram_009d3e38 = 0;
		    iVar5 = import::env::invoke_iiii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x22a,iVar6,iVar5,
		                       Method_System_Collections_Generic_List_SquadModel_PartyData__get_Item__);
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 == 1) {
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      iVar10 = global_1;
		      goto code_r0x80e8c448;
		    }
		    iVar10 = *(int *)(iVar10 + 8);
		    *(undefined1 *)(*(int *)(iVar5 + 0x10) + 0x10) = *(undefined1 *)(iVar10 + 0x10);
		    DAT_ram_009d3e38 = 0;
		    piVar7 = (int *)import::env::invoke_iii
		                              (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x3a2,
		                               *(undefined4 *)(iVar10 + 0x14),
		                               Method_Google_Protobuf_Collections_RepeatedField_PartySlot__GetEnumerator__
		                              );
		    iVar10 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar10 == 1) {
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      iVar10 = global_1;
		      goto code_r0x80e8c448;
		    }
		    local_18 = 0;
		    local_14 = &local_8;
		    local_8 = piVar7;
		code_r0x80e8bc14:
		    do {
		      piVar7 = local_8;
		      iVar10 = *local_8;
		      if (*(ushort *)(iVar10 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          piVar9 = (int *)(*(int *)(iVar10 + 0x58) + uVar1 * 8);
		          if (System_Collections_IEnumerator_TypeInfo == *piVar9) {
		            puVar3 = (undefined4 *)(iVar10 + piVar9[1] * 8 + 0xc0);
		            goto code_r0x80e8bcae;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar10 + 0xb6) != uVar1);
		      }
		      DAT_ram_009d3e38 = 0;
		      puVar3 = (undefined4 *)
		               import::env::invoke_iiii
		                         (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_8,
		                          System_Collections_IEnumerator_TypeInfo,0);
		      if (DAT_ram_009d3e38 == 1) break;
		code_r0x80e8bcae:
		      DAT_ram_009d3e38 = 0;
		      iVar10 = import::env::invoke_iii(*puVar3,piVar7,puVar3[1]);
		      if (DAT_ram_009d3e38 == 1) break;
		      if (iVar10 == 0) goto code_r0x80e8c2fb;
		      DAT_ram_009d3e38 = 0;
		      iVar10 = import::env::invoke_ii
		                         (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                          Gameplay_Clans_Office_Model_SquadModel___c__DisplayClass15_1_TypeInfo);
		      piVar7 = local_8;
		      if (DAT_ram_009d3e38 == 1) break;
		      iVar6 = *local_8;
		      if (*(ushort *)(iVar6 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          piVar9 = (int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8);
		          if (System_Collections_Generic_IEnumerator_PartySlot__TypeInfo == *piVar9) {
		            puVar3 = (undefined4 *)(iVar6 + piVar9[1] * 8 + 0xc0);
		            goto code_r0x80e8bde2;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		      }
		      DAT_ram_009d3e38 = 0;
		      puVar3 = (undefined4 *)
		               import::env::invoke_iiii
		                         (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_8,
		                          System_Collections_Generic_IEnumerator_PartySlot__TypeInfo,0);
		      if (DAT_ram_009d3e38 == 1) break;
		code_r0x80e8bde2:
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::invoke_iii(*puVar3,piVar7,puVar3[1]);
		      if (DAT_ram_009d3e38 == 1) break;
		      *(undefined4 *)(iVar10 + 8) = uVar4;
		      iVar6 = *(int *)(param1 + 0xc);
		      if (DAT_ram_00a57f87 == '\0') {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vi(0x7ff,&Core_Dict_IDictProvider_TypeInfo);
		        if (DAT_ram_009d3e38 == 1) break;
		        DAT_ram_00a57f87 = '\x01';
		      }
		      piVar7 = *(int **)(iVar6 + 0xc);
		      iVar6 = *piVar7;
		      if (*(ushort *)(iVar6 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          piVar9 = (int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8);
		          if (Core_Dict_IDictProvider_TypeInfo == *piVar9) {
		            puVar3 = (undefined4 *)(piVar9[1] * 8 + iVar6 + 0xd0);
		            goto code_r0x80e8bf0b;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		      }
		      DAT_ram_009d3e38 = 0;
		      puVar3 = (undefined4 *)
		               import::env::invoke_iiii
		                         (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar7,
		                          Core_Dict_IDictProvider_TypeInfo,2);
		      if (DAT_ram_009d3e38 == 1) break;
		code_r0x80e8bf0b:
		      DAT_ram_009d3e38 = 0;
		      uVar8 = import::env::invoke_iii(*puVar3,piVar7,puVar3[1]);
		      if (DAT_ram_009d3e38 == 1) break;
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::invoke_iiiii
		                        (s_struct_Uniforms___color__array<v_ram_00001b87 + 0xfe,uVar4,uVar8,
		                         *(undefined4 *)(param1 + 8),*(undefined4 *)(param1 + 8));
		      if (DAT_ram_009d3e38 == 1) break;
		      param2_00 = *(undefined4 *)(iVar5 + 0xc);
		      DAT_ram_009d3e38 = 0;
		      uVar8 = import::env::invoke_ii
		                        (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                         System_Predicate_SquadModel_ColossusPartySlot__TypeInfo);
		      if (DAT_ram_009d3e38 == 1) break;
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_viiii
		                (s_struct_Uniforms___color__array<v_ram_00001b87 + 0xfb,uVar8,iVar10,
		                 Method_Gameplay_Clans_Office_Model_SquadModel___c__DisplayClass15_1__ParsePartyChanges_b__1__
		                 ,0);
		      if (DAT_ram_009d3e38 == 1) break;
		      DAT_ram_009d3e38 = 0;
		      param3_00 = import::env::invoke_iiii
		                            (s_struct_Uniforms___color__array<v_ram_00001b87 + 0xfc,param2_00,uVar8,
		                             Method_System_Collections_Generic_List_SquadModel_ColossusPartySlot__FindIndex__
		                            );
		      iVar6 = Method_System_Collections_Generic_List_SquadModel_ColossusPartySlot__Add__;
		      if (DAT_ram_009d3e38 == 1) break;
		      param2_01 = *(int *)(iVar5 + 0xc);
		      if (param3_00 != -1) {
		        iVar6 = *(int *)(param1 + 0xc);
		        uVar4 = *(undefined4 *)(iVar10 + 8);
		        if (DAT_ram_00a57f87 == '\0') {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_vi(0x7ff,&Core_Dict_IDictProvider_TypeInfo);
		          if (DAT_ram_009d3e38 == 1) break;
		          DAT_ram_00a57f87 = '\x01';
		        }
		        piVar7 = *(int **)(iVar6 + 0xc);
		        iVar10 = *piVar7;
		        if (*(ushort *)(iVar10 + 0xb6) != 0) {
		          uVar1 = 0;
		          do {
		            piVar9 = (int *)(*(int *)(iVar10 + 0x58) + uVar1 * 8);
		            if (Core_Dict_IDictProvider_TypeInfo == *piVar9) {
		              puVar3 = (undefined4 *)(piVar9[1] * 8 + iVar10 + 0xd0);
		              goto code_r0x80e8c1b4;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar10 + 0xb6) != uVar1);
		        }
		        DAT_ram_009d3e38 = 0;
		        puVar3 = (undefined4 *)
		                 import::env::invoke_iiii
		                           (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar7,
		                            Core_Dict_IDictProvider_TypeInfo,2);
		        if (DAT_ram_009d3e38 == 1) break;
		code_r0x80e8c1b4:
		        DAT_ram_009d3e38 = 0;
		        uVar8 = import::env::invoke_iii(*puVar3,piVar7,puVar3[1]);
		        if (DAT_ram_009d3e38 == 1) break;
		        DAT_ram_009d3e38 = 0;
		        uVar4 = import::env::invoke_iiiii
		                          (s_struct_Uniforms___color__array<v_ram_00001b87 + 0xfe,uVar4,uVar8,
		                           *(undefined4 *)(param1 + 8),*(undefined4 *)(param1 + 8));
		        if (DAT_ram_009d3e38 == 1) break;
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viiii
		                  (s_struct_Uniforms___color__array<v_ram_00001b87 + 0xff,param2_01,param3_00,uVar4,
		                   Method_System_Collections_Generic_List_SquadModel_ColossusPartySlot__set_Item__);
		        if (DAT_ram_009d3e38 == 1) break;
		        goto code_r0x80e8bc14;
		      }
		      *(int *)(param2_01 + 0x10) = *(int *)(param2_01 + 0x10) + 1;
		      uVar1 = *(uint *)(param2_01 + 0xc);
		      if (uVar1 < *(uint *)(*(int *)(param2_01 + 8) + 0xc)) {
		        *(uint *)(param2_01 + 0xc) = uVar1 + 1;
		        *(undefined4 *)(*(int *)(param2_01 + 8) + uVar1 * 4 + 0x10) = uVar4;
		        goto code_r0x80e8bc14;
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_viii
		                (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,param2_01,uVar4,
		                 *(undefined4 *)(*(int *)(*(int *)(iVar6 + 0x10) + 0x60) + 0x38));
		    } while (DAT_ram_009d3e38 != 1);
		    DAT_ram_009d3e38 = 0;
		    uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    iVar10 = global_1;
		    iVar6 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		    if (iVar10 != iVar6) {
		code_r0x80e8c2c4:
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x100,&local_18);
		      iVar6 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar6 != 1) goto code_r0x80e8c448;
		      goto code_r0x80e8c568;
		    }
		    piVar7 = (int *)import::env::__cxa_begin_catch(uVar4);
		    local_18 = *piVar7;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_v(0x123);
		    iVar10 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar10 == 1) {
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      iVar10 = global_1;
		      goto code_r0x80e8c2c4;
		    }
		code_r0x80e8c2fb:
		    piVar7 = *local_14;
		    if (piVar7 != (int *)0x0) {
		      iVar10 = *piVar7;
		      if (*(ushort *)(iVar10 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          piVar9 = (int *)(*(int *)(iVar10 + 0x58) + uVar1 * 8);
		          if (System_IDisposable_TypeInfo == *piVar9) {
		            puVar3 = (undefined4 *)(iVar10 + piVar9[1] * 8 + 0xc0);
		            goto code_r0x80e8c39b;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar10 + 0xb6) != uVar1);
		      }
		      DAT_ram_009d3e38 = 0;
		      puVar3 = (undefined4 *)
		               import::env::invoke_iiii
		                         (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar7,
		                          System_IDisposable_TypeInfo,0);
		      if (DAT_ram_009d3e38 != 1) {
		code_r0x80e8c39b:
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vii(*puVar3,piVar7,puVar3[1]);
		        if (DAT_ram_009d3e38 != 1) goto code_r0x80e8c3d7;
		      }
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      iVar10 = global_1;
		      goto code_r0x80e8c448;
		    }
		code_r0x80e8c3d7:
		  } while (local_18 == 0);
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_vi(s_var<private>_posTex__array<vec4<_ram_00000655 + 0x1d3,local_18);
		  iVar10 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar10 != 1) {
		    do {
		      halt_trap();
		    } while( true );
		  }
		  uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		  iVar10 = global_1;
		code_r0x80e8c448:
		  iVar6 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar6 == iVar10) {
		    piVar7 = (int *)import::env::__cxa_begin_catch(uVar4);
		    local_10 = *piVar7;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_v(0x123);
		    iVar10 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar10 != 1) {
		code_r0x80e8c48f:
		      DAT_ram_009d3e38 = 0;
		      piVar7 = *local_c;
		      if (piVar7 != (int *)0x0) {
		        uVar1 = 0;
		        iVar10 = *piVar7;
		        if (*(ushort *)(iVar10 + 0xb6) != 0) {
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar10 + 0x58) + uVar1 * 8)) {
		              puVar2 = (uint *)(iVar10 + *(int *)(*(int *)(iVar10 + 0x58) + uVar1 * 8 + 4) * 8 +
		                               0xc0);
		              goto code_r0x80e8c50a;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar10 + 0xb6) != uVar1);
		        }
		        puVar2 = (uint *)func_ii_1080(piVar7,System_IDisposable_TypeInfo,0);
		code_r0x80e8c50a:
		        (**(code **)((ulonglong)*puVar2 * 4))(piVar7,puVar2[1]);
		      }
		      if (local_10 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(local_10);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      Gameplay_Clans_Office_Model_SquadModel__ParsePartyChanges(param1,0);
		      return;
		    }
		    uVar4 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x101,&local_10);
		  iVar10 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar10 != 1) {
		    import::env::__resumeException(uVar4);
		    do {
		      halt_trap();
		    } while( true );
		  }
		code_r0x80e8c568:
		  DAT_ram_009d3e38 = 0;
		  import::env::__cxa_find_matching_catch_3(0);
		  unnamed_function_937();
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06003EA6 RID: 16038 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EA6")]
		[Address(RVA = "0x8D64", Offset = "0x8D64", VA = "0x8D64")]
		public void ParsePartyChanges(IList<PartyInfo> partiesChanged)
		{
		/* --- GHIDRA: ParsePartyChanges ---
		void Gameplay_Clans_Office_Model_SquadModel__ParsePartyChanges(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 *puVar2;
		  int iVar3;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a57fc2 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_FirstOrDefault_SquadModel_PartyData___);
		    Mono_Security_ASN1__get_Item(&System_Func_SquadModel_PartyData__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Clans_Office_Model_SquadModel___c__UpdatePlayerParty_b__16_0__);
		    Mono_Security_ASN1__get_Item(&Gameplay_Clans_Office_Model_SquadModel___c_TypeInfo);
		    DAT_ram_00a57fc2 = '\x01';
		  }
		  uVar1 = *(undefined4 *)(param1 + 0x18);
		  if (*(int *)(Gameplay_Clans_Office_Model_SquadModel___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_Clans_Office_Model_SquadModel___c_TypeInfo);
		  }
		  puVar2 = *(undefined4 **)(Gameplay_Clans_Office_Model_SquadModel___c_TypeInfo + 0x5c);
		  iVar3 = puVar2[3];
		  if (iVar3 == 0) {
		    if (*(int *)(Gameplay_Clans_Office_Model_SquadModel___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_Clans_Office_Model_SquadModel___c_TypeInfo);
		      puVar2 = *(undefined4 **)(Gameplay_Clans_Office_Model_SquadModel___c_TypeInfo + 0x5c);
		    }
		    param2_00 = *puVar2;
		    iVar3 = unnamed_function_1417(System_Func_SquadModel_PartyData__bool__TypeInfo);
		    System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		              (iVar3,param2_00,
		               Method_Gameplay_Clans_Office_Model_SquadModel___c__UpdatePlayerParty_b__16_0__,0);
		    *(int *)(*(int *)(Gameplay_Clans_Office_Model_SquadModel___c_TypeInfo + 0x5c) + 0xc) = iVar3;
		  }
		  iVar3 = System_Func_object__bool____ctor
		                    (uVar1,iVar3,
		                     Method_System_Linq_Enumerable_FirstOrDefault_SquadModel_PartyData___);
		  if (iVar3 == 0) {
		    uVar1 = 0;
		  }
		  else {
		    uVar1 = *(undefined4 *)(iVar3 + 8);
		  }
		  *(undefined4 *)(*(int *)(param1 + 0x10) + 0x30) = uVar1;
		  return;
		}
		*/

		}

		// Token: 0x06003EA7 RID: 16039 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EA7")]
		[Address(RVA = "0x8D65", Offset = "0x8D65", VA = "0x8D65")]
		private void UpdatePlayerParty()
		{
		/* --- GHIDRA: UpdatePlayerParty ---
		undefined4
		Gameplay_Clans_Office_Model_SquadModel__UpdatePlayerParty
		          (int param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *param4;
		  undefined4 uVar2;
		  int iVar3;
		  int *param1_00;
		  
		  iVar3 = *(int *)(param1 + 0xc);
		  if (DAT_ram_00a57f87 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    DAT_ram_00a57f87 = '\x01';
		  }
		  param1_00 = *(int **)(iVar3 + 0xc);
		  iVar3 = *param1_00;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        param4 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0xd0);
		        goto code_r0x80e8c993;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  param4 = (uint *)func_ii_1080(param1_00,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x80e8c993:
		  uVar2 = (**(code **)((ulonglong)*param4 * 4))(param1_00,param4[1]);
		  uVar2 = System_Collections_Generic_List_object___FindIndex
		                    (param2,uVar2,*(undefined4 *)(param1 + 8),param4);
		  return uVar2;
		}
		*/

		}

		// Token: 0x0400233E RID: 9022
		[Token(Token = "0x400233E")]
		[FieldOffset(Offset = "0xC")]
		public readonly ClanInfoModel ClanInfoModel;

		// Token: 0x0400233F RID: 9023
		[Token(Token = "0x400233F")]
		[FieldOffset(Offset = "0x10")]
		public readonly WorldAxisModel WorldAxisModel;

		// Token: 0x04002340 RID: 9024
		[Token(Token = "0x4002340")]
		[FieldOffset(Offset = "0x14")]
		public readonly ColossusSlotsInfoDic[] Slots;

		// Token: 0x02000A55 RID: 2645
		[Token(Token = "0x2000A55")]
		public class PartyData
		{
			// Token: 0x17000C90 RID: 3216
			// (get) Token: 0x06003EA9 RID: 16041 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x06003EAA RID: 16042 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000C90")]
			public ColossusPartiesInfoDic PartyInfoDic
			{
				[Token(Token = "0x6003EA9")]
				[Address(RVA = "0x8D67", Offset = "0x8D67", VA = "0x8D67")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6003EAA")]
				[Address(RVA = "0x8D68", Offset = "0x8D68", VA = "0x8D68")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000C91 RID: 3217
			// (get) Token: 0x06003EAB RID: 16043 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x06003EAC RID: 16044 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000C91")]
			public List<SquadModel.ColossusPartySlot> Slots
			{
				[Token(Token = "0x6003EAB")]
				[Address(RVA = "0x8D69", Offset = "0x8D69", VA = "0x8D69")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6003EAC")]
				[Address(RVA = "0x8D6A", Offset = "0x8D6A", VA = "0x8D6A")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000C92 RID: 3218
			// (get) Token: 0x06003EAD RID: 16045 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x06003EAE RID: 16046 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000C92")]
			public PartyInfo PartyInfo
			{
				[Token(Token = "0x6003EAD")]
				[Address(RVA = "0x8D6B", Offset = "0x8D6B", VA = "0x8D6B")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6003EAE")]
				[Address(RVA = "0x8D6C", Offset = "0x8D6C", VA = "0x8D6C")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x06003EAF RID: 16047 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6003EAF")]
			[Address(RVA = "0x1C84", Offset = "0x1C84", VA = "0x1C84")]
			public static SquadModel.PartyData Create(PartyInfo info, Dictionaries dict, UserData user)
			{
				return null;
			}

			// Token: 0x06003EB0 RID: 16048 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003EB0")]
			[Address(RVA = "0x8D6D", Offset = "0x8D6D", VA = "0x8D6D")]
			public PartyData()
			{
			}
		}

		// Token: 0x02000A57 RID: 2647
		[Token(Token = "0x2000A57")]
		public class ColossusPartySlot
		{
			// Token: 0x17000C93 RID: 3219
			// (get) Token: 0x06003EB3 RID: 16051 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x06003EB4 RID: 16052 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000C93")]
			public DollsInfoDic DollDic
			{
				[Token(Token = "0x6003EB3")]
				[Address(RVA = "0x8D70", Offset = "0x8D70", VA = "0x8D70")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6003EB4")]
				[Address(RVA = "0x8D71", Offset = "0x8D71", VA = "0x8D71")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000C94 RID: 3220
			// (get) Token: 0x06003EB5 RID: 16053 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x06003EB6 RID: 16054 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000C94")]
			public UserData DollUser
			{
				[Token(Token = "0x6003EB5")]
				[Address(RVA = "0x8D72", Offset = "0x8D72", VA = "0x8D72")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6003EB6")]
				[Address(RVA = "0x8D73", Offset = "0x8D73", VA = "0x8D73")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000C95 RID: 3221
			// (get) Token: 0x06003EB7 RID: 16055 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x06003EB8 RID: 16056 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000C95")]
			public PartySlot PartySlot
			{
				[Token(Token = "0x6003EB7")]
				[Address(RVA = "0x8D74", Offset = "0x8D74", VA = "0x8D74")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6003EB8")]
				[Address(RVA = "0x8D75", Offset = "0x8D75", VA = "0x8D75")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000C96 RID: 3222
			// (get) Token: 0x06003EB9 RID: 16057 RVA: 0x0000C570 File Offset: 0x0000A770
			// (set) Token: 0x06003EBA RID: 16058 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000C96")]
			public bool MyDoll
			{
				[Token(Token = "0x6003EB9")]
				[Address(RVA = "0x8D76", Offset = "0x8D76", VA = "0x8D76")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6003EBA")]
				[Address(RVA = "0x8D77", Offset = "0x8D77", VA = "0x8D77")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x06003EBB RID: 16059 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6003EBB")]
			[Address(RVA = "0x1C85", Offset = "0x1C85", VA = "0x1C85")]
			public static SquadModel.ColossusPartySlot Create(PartySlot slot, Dictionaries dict, UserData user)
			{
				return null;
			}

			// Token: 0x06003EBC RID: 16060 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003EBC")]
			[Address(RVA = "0x8D78", Offset = "0x8D78", VA = "0x8D78")]
			public ColossusPartySlot()
			{
			}
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_Treasury ---
		void Gameplay_Clans_Office_Model_SquadModel__set_Treasury
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  uint *puVar3;
		  int *piVar4;
		  int iVar5;
		  int iVar6;
		  int *piVar7;
		  
		  if (DAT_ram_00a57fbf == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Dic_ColossusSlotsInfoDic___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_SquadModel_PartyData___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_SquadModel_PartyData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ColossusSlotsInfoDic__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ColossusSlotsInfoDic__get_Item__);
		    DAT_ram_00a57fbf = '\x01';
		  }
		  uVar2 = Mono_Security_ASN1Convert__ToOid(Protocol_Dic_ColossusSlotsInfoDic___TypeInfo,7);
		  *(undefined4 *)(param1 + 0x14) = uVar2;
		  uVar2 = unnamed_function_1417(System_Collections_Generic_List_SquadModel_PartyData__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (uVar2,Method_System_Collections_Generic_List_SquadModel_PartyData___ctor__);
		  *(undefined4 *)(param1 + 0x18) = uVar2;
		  Unity_Services_Core_Environments_Internal_Environments__get_Current(param1,param2,0);
		  *(undefined4 *)(param1 + 0x10) = param4;
		  *(undefined4 *)(param1 + 0xc) = param3;
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  piVar4 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x230);
		        goto code_r0x80e8b22d;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x2e);
		code_r0x80e8b22d:
		  iVar5 = (**(code **)((ulonglong)*puVar3 * 4))(piVar4,puVar3[1]);
		  *(undefined4 *)(param1 + 0x1c) = *(undefined4 *)(*(int *)(iVar5 + 0x10) + 0x18);
		  iVar5 = 0;
		  do {
		    iVar6 = *(int *)(param1 + 0xc);
		    if (DAT_ram_00a57f87 == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		      DAT_ram_00a57f87 = '\x01';
		    }
		    piVar4 = *(int **)(iVar6 + 0xc);
		    iVar6 = *piVar4;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar7 = (int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8);
		        if (Core_Dict_IDictProvider_TypeInfo == *piVar7) {
		          puVar3 = (uint *)(piVar7[1] * 8 + iVar6 + 0xd0);
		          goto code_r0x80e8b2e2;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar4,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x80e8b2e2:
		    iVar6 = (**(code **)((ulonglong)*puVar3 * 4))(piVar4,puVar3[1]);
		    if (*(int *)(*(int *)(iVar6 + 0x204) + 0xc) <= iVar5) {
		      return;
		    }
		    iVar6 = *(int *)(param1 + 0xc);
		    if (DAT_ram_00a57f87 == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		      DAT_ram_00a57f87 = '\x01';
		    }
		    piVar4 = *(int **)(iVar6 + 0xc);
		    iVar6 = *piVar4;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar7 = (int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8);
		        if (Core_Dict_IDictProvider_TypeInfo == *piVar7) {
		          puVar3 = (uint *)(piVar7[1] * 8 + iVar6 + 0xd0);
		          goto code_r0x80e8b392;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar4,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x80e8b392:
		    iVar6 = (**(code **)((ulonglong)*puVar3 * 4))(piVar4,puVar3[1]);
		    uVar2 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                      (*(undefined4 *)(iVar6 + 0x204),iVar5,
		                       Method_Google_Protobuf_Collections_RepeatedField_ColossusSlotsInfoDic__get_Item__
		                      );
		    *(undefined4 *)(*(int *)(param1 + 0x14) + iVar5 * 4 + 0x10) = uVar2;
		    iVar5 = iVar5 + 1;
		  } while( true );
		}
		*/

}
