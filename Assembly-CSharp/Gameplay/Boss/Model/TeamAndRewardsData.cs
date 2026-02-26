using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Protocol.Boss;

namespace Gameplay.Boss.Model
{
	// Token: 0x02000B94 RID: 2964
	[Token(Token = "0x2000B94")]
	public class TeamAndRewardsData
	{
		// Token: 0x17000EAE RID: 3758
		// (get) Token: 0x06004866 RID: 18534 RVA: 0x0000D650 File Offset: 0x0000B850
		[Token(Token = "0x17000EAE")]
		public bool NotDistributed
		{
			[Token(Token = "0x6004866")]
			[Address(RVA = "0x96E5", Offset = "0x96E5", VA = "0x96E5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000EAF RID: 3759
		// (get) Token: 0x06004867 RID: 18535 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004868 RID: 18536 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000EAF")]
		public TeamData TeamData
		{
			[Token(Token = "0x6004867")]
			[Address(RVA = "0x96E6", Offset = "0x96E6", VA = "0x96E6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004868")]
			[Address(RVA = "0x96E7", Offset = "0x96E7", VA = "0x96E7")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000EB0 RID: 3760
		// (get) Token: 0x06004869 RID: 18537 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600486A RID: 18538 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000EB0")]
		public List<GetTeamRewardsAns.Types.BossRewardInfo> CaptainRewards
		{
			[Token(Token = "0x6004869")]
			[Address(RVA = "0x96E8", Offset = "0x96E8", VA = "0x96E8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600486A")]
			[Address(RVA = "0x96E9", Offset = "0x96E9", VA = "0x96E9")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000EB1 RID: 3761
		// (get) Token: 0x0600486B RID: 18539 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600486C RID: 18540 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000EB1")]
		public List<GetTeamRewardsAns.Types.BossRewardInfo> AssistantRewards
		{
			[Token(Token = "0x600486B")]
			[Address(RVA = "0x96EA", Offset = "0x96EA", VA = "0x96EA")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600486C")]
			[Address(RVA = "0x96EB", Offset = "0x96EB", VA = "0x96EB")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000EB2 RID: 3762
		// (get) Token: 0x0600486D RID: 18541 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600486E RID: 18542 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000EB2")]
		public List<GetTeamRewardsAns.Types.BossRewardInfo> RawRewards
		{
			[Token(Token = "0x600486D")]
			[Address(RVA = "0x96EC", Offset = "0x96EC", VA = "0x96EC")]
			get
			{
				return null;
			}
			[Token(Token = "0x600486E")]
			[Address(RVA = "0x96ED", Offset = "0x96ED", VA = "0x96ED")]
			set
			{
			}
		}

		// Token: 0x0600486F RID: 18543 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600486F")]
		[Address(RVA = "0x96EE", Offset = "0x96EE", VA = "0x96EE")]
		public TeamAndRewardsData(TeamData teamData, IList<GetTeamRewardsAns.Types.BossRewardInfo> rewards)
		{
		}

		// Token: 0x040027AB RID: 10155
		[Token(Token = "0x40027AB")]
		[FieldOffset(Offset = "0x8")]
		public TeamRewardState State;

		// Token: 0x040027AF RID: 10159
		[Token(Token = "0x40027AF")]
		[FieldOffset(Offset = "0x18")]
		private List<GetTeamRewardsAns.Types.BossRewardInfo> _rawRewards;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_RawRewards ---
		void Gameplay_Boss_Model_TeamAndRewardsData__get_RawRewards
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 uVar2;
		  int *piVar3;
		  longlong lVar4;
		  int iVar5;
		  int iVar6;
		  int iVar7;
		  uint uVar8;
		  longlong lVar9;
		  int local_18;
		  undefined8 *local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  bVar1 = false;
		  if (DAT_ram_00a5788e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_GetTeamRewardsAns_Types_BossRewardInfo__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_GetTeamRewardsAns_Types_BossRewardInfo__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_GetTeamRewardsAns_Types_BossRewardInfo__get_Current__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_GetTeamRewardsAns_Types_BossRewardInfo__Add__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_GetTeamRewardsAns_Types_BossRewardInfo__Clear__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_GetTeamRewardsAns_Types_BossRewardInfo__GetEnumerator__
		              );
		    DAT_ram_00a5788e = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  *(undefined4 *)(param1 + 0x18) = param2;
		  iVar5 = *(int *)(param1 + 0x10);
		  iVar6 = *(int *)(iVar5 + 0xc);
		  *(undefined4 *)(iVar5 + 0xc) = 0;
		  *(int *)(iVar5 + 0x10) = *(int *)(iVar5 + 0x10) + 1;
		  if (0 < iVar6) {
		    func_ii_2064(*(undefined4 *)(iVar5 + 8),0,iVar6,0);
		  }
		  iVar5 = *(int *)(param1 + 0x14);
		  iVar6 = *(int *)(iVar5 + 0xc);
		  *(undefined4 *)(iVar5 + 0xc) = 0;
		  *(int *)(iVar5 + 0x10) = *(int *)(iVar5 + 0x10) + 1;
		  if (0 < iVar6) {
		    func_ii_2064(*(undefined4 *)(iVar5 + 8),0,iVar6,0);
		  }
		  System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		            (&local_10,*(undefined4 *)(param1 + 0x18),
		             Method_System_Collections_Generic_List_GetTeamRewardsAns_Types_BossRewardInfo__GetEnumerator__
		            );
		  local_18 = 0;
		  local_14 = &local_10;
		  do {
		    while( true ) {
		      DAT_ram_009d3e38 = 0;
		      iVar6 = import::env::invoke_iii
		                        (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_10,
		                         Method_System_Collections_Generic_List_Enumerator_GetTeamRewardsAns_Types_BossRewardInfo__MoveNext__
		                        );
		      iVar5 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar5 == 1) {
		        uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80def859;
		      }
		      if (iVar6 == 0) {
		        iVar6 = 7;
		        iVar5 = local_18;
		        goto code_r0x80def8a6;
		      }
		      iVar5 = local_8._4_4_;
		      lVar9 = *(longlong *)(local_8._4_4_ + 0x18);
		      if (lVar9 != 0) break;
		code_r0x80def6ef:
		      iVar6 = Method_System_Collections_Generic_List_GetTeamRewardsAns_Types_BossRewardInfo__Add__;
		      bVar1 = (bool)(lVar9 != 0 | bVar1);
		      iVar7 = *(int *)(param1 + 0x10);
		      *(int *)(iVar7 + 0x10) = *(int *)(iVar7 + 0x10) + 1;
		      uVar8 = *(uint *)(iVar7 + 0xc);
		      if (uVar8 < *(uint *)(*(int *)(iVar7 + 8) + 0xc)) {
		        *(uint *)(iVar7 + 0xc) = uVar8 + 1;
		        *(int *)(*(int *)(iVar7 + 8) + uVar8 * 4 + 0x10) = iVar5;
		      }
		      else {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,iVar7,iVar5,
		                   *(undefined4 *)(*(int *)(*(int *)(iVar6 + 0x10) + 0x60) + 0x38));
		        iVar5 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar5 == 1) {
		          uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80def859;
		        }
		      }
		    }
		    piVar3 = *(int **)(*(int *)(param1 + 0xc) + 0x18);
		    iVar6 = *piVar3;
		    DAT_ram_009d3e38 = 0;
		    uVar2 = import::env::invoke_iii
		                      (*(undefined4 *)(iVar6 + 0xe0),piVar3,*(undefined4 *)(iVar6 + 0xe4));
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 == 1) {
		      bVar1 = true;
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80def859;
		    }
		    DAT_ram_009d3e38 = 0;
		    lVar4 = unnamed_function_184054(s_struct_Uniforms___color__array<v_ram_000017c8 + 0x356,uVar2,0)
		    ;
		    iVar7 = DAT_ram_009d3e38;
		    iVar6 = Method_System_Collections_Generic_List_GetTeamRewardsAns_Types_BossRewardInfo__Add__;
		    DAT_ram_009d3e38 = 0;
		    if (iVar7 == 1) {
		      bVar1 = true;
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80def859;
		    }
		    if (lVar9 == lVar4) goto code_r0x80def6ef;
		    iVar7 = *(int *)(param1 + 0x14);
		    *(int *)(iVar7 + 0x10) = *(int *)(iVar7 + 0x10) + 1;
		    uVar8 = *(uint *)(iVar7 + 0xc);
		    if (uVar8 < *(uint *)(*(int *)(iVar7 + 8) + 0xc)) {
		      bVar1 = true;
		      *(uint *)(iVar7 + 0xc) = uVar8 + 1;
		      *(int *)(*(int *)(iVar7 + 8) + uVar8 * 4 + 0x10) = iVar5;
		    }
		    else {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_viii
		                (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,iVar7,iVar5,
		                 *(undefined4 *)(*(int *)(*(int *)(iVar6 + 0x10) + 0x60) + 0x38));
		      iVar5 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      bVar1 = true;
		      if (iVar5 == 1) {
		        uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80def859:
		        iVar5 = global_1;
		        iVar6 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		        if (iVar5 == iVar6) {
		          piVar3 = (int *)import::env::__cxa_begin_catch(uVar2);
		          iVar5 = *piVar3;
		          iVar6 = 0;
		          DAT_ram_009d3e38 = 0;
		          local_18 = iVar5;
		          import::env::invoke_v(0x123);
		          iVar7 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar7 != 1) {
		code_r0x80def8a6:
		            DAT_ram_009d3e38 = 0;
		            if (iVar5 == 0) {
		              if ((iVar6 == 0) ||
		                 ((((iVar6 != 1 && (iVar6 != 2)) && (iVar6 != 3)) &&
		                  (((iVar6 != 4 && (iVar6 != 5)) && ((iVar6 != 6 && (iVar6 == 7)))))))) {
		                uVar2 = 2;
		                if (!bVar1) {
		                  uVar2 = 1;
		                }
		                *(undefined4 *)(param1 + 8) = uVar2;
		              }
		              return;
		            }
		            System_Data_DataSet__ValidateLocaleConstraint(iVar5);
		            do {
		              halt_trap();
		            } while( true );
		          }
		          uVar2 = import::env::__cxa_find_matching_catch_2();
		        }
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_000017c8 + 0x373,&local_18);
		        iVar5 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar5 != 1) {
		          import::env::__resumeException(uVar2);
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
		    }
		  } while( true );
		}
		*/


		/* --- GHIDRA: set_RawRewards ---
		void Gameplay_Boss_Model_TeamAndRewardsData__set_RawRewards
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5788f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_ToList_GetTeamRewardsAns_Types_BossRewardInfo___);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_GetTeamRewardsAns_Types_BossRewardInfo___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_List_GetTeamRewardsAns_Types_BossRewardInfo__TypeInfo);
		    DAT_ram_00a5788f = '\x01';
		  }
		  uVar1 = unnamed_function_1417
		                    (
		                    System_Collections_Generic_List_GetTeamRewardsAns_Types_BossRewardInfo__TypeInfo
		                    );
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (uVar1,
		             Method_System_Collections_Generic_List_GetTeamRewardsAns_Types_BossRewardInfo___ctor__)
		  ;
		  *(undefined4 *)(param1 + 0x10) = uVar1;
		  uVar1 = unnamed_function_1417
		                    (
		                    System_Collections_Generic_List_GetTeamRewardsAns_Types_BossRewardInfo__TypeInfo
		                    );
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (uVar1,
		             Method_System_Collections_Generic_List_GetTeamRewardsAns_Types_BossRewardInfo___ctor__)
		  ;
		  *(undefined4 *)(param1 + 0x14) = uVar1;
		  *(undefined4 *)(param1 + 0xc) = param2;
		  uVar1 = System_Linq_Enumerable__Select_object__object_
		                    (param3,
		                     Method_System_Linq_Enumerable_ToList_GetTeamRewardsAns_Types_BossRewardInfo___)
		  ;
		  Gameplay_Boss_Model_TeamAndRewardsData__get_RawRewards(param1,uVar1,param1);
		  return;
		}
		*/

}
