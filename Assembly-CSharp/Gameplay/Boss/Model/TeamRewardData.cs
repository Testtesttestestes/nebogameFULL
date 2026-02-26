using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Il2CppDummyDll;
using JetBrains.Annotations;
using Protocol.Boss;

namespace Gameplay.Boss.Model
{
	// Token: 0x02000B9A RID: 2970
	[Token(Token = "0x2000B9A")]
	public class TeamRewardData
	{
		// Token: 0x17000ECD RID: 3789
		// (get) Token: 0x060048A6 RID: 18598 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060048A7 RID: 18599 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000ECD")]
		public GetCaptainTeamListAns.Types.TeamRewardInfo RawTeamRewardInfo
		{
			[Token(Token = "0x60048A6")]
			[Address(RVA = "0x9722", Offset = "0x9722", VA = "0x9722")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60048A7")]
			[Address(RVA = "0x9723", Offset = "0x9723", VA = "0x9723")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000ECE RID: 3790
		// (get) Token: 0x060048A8 RID: 18600 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060048A9 RID: 18601 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000ECE")]
		public List<TeamRewardData.TeamMemberData> TeamMembers
		{
			[Token(Token = "0x60048A8")]
			[Address(RVA = "0x9724", Offset = "0x9724", VA = "0x9724")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60048A9")]
			[Address(RVA = "0x9725", Offset = "0x9725", VA = "0x9725")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000ECF RID: 3791
		// (get) Token: 0x060048AA RID: 18602 RVA: 0x0000D7A0 File Offset: 0x0000B9A0
		// (set) Token: 0x060048AB RID: 18603 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000ECF")]
		public bool IsAlive
		{
			[Token(Token = "0x60048AA")]
			[Address(RVA = "0x9726", Offset = "0x9726", VA = "0x9726")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60048AB")]
			[Address(RVA = "0x9727", Offset = "0x9727", VA = "0x9727")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000ED0 RID: 3792
		// (get) Token: 0x060048AC RID: 18604 RVA: 0x0000D7B8 File Offset: 0x0000B9B8
		[Token(Token = "0x17000ED0")]
		public ulong TeamId
		{
			[Token(Token = "0x60048AC")]
			[Address(RVA = "0x9728", Offset = "0x9728", VA = "0x9728")]
			get
			{
				return 0UL;
			}
		}

		// Token: 0x060048AD RID: 18605 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048AD")]
		[Address(RVA = "0x9729", Offset = "0x9729", VA = "0x9729")]
		public TeamRewardData(GetCaptainTeamListAns.Types.TeamRewardInfo teamRewardInfo, bool isAlive)
		{
		}

		// Token: 0x02000B9B RID: 2971
		[Token(Token = "0x2000B9B")]
		public class TeamMemberData
		{
			// Token: 0x17000ED1 RID: 3793
			// (get) Token: 0x060048AE RID: 18606 RVA: 0x0000D7D0 File Offset: 0x0000B9D0
			// (set) Token: 0x060048AF RID: 18607 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000ED1")]
			public ulong UserId
			{
				[Token(Token = "0x60048AE")]
				[Address(RVA = "0x972A", Offset = "0x972A", VA = "0x972A")]
				[CompilerGenerated]
				get
				{
					return 0UL;
				}
				[Token(Token = "0x60048AF")]
				[Address(RVA = "0x972B", Offset = "0x972B", VA = "0x972B")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x140001CB RID: 459
			// (add) Token: 0x060048B0 RID: 18608 RVA: 0x00002050 File Offset: 0x00000250
			// (remove) Token: 0x060048B1 RID: 18609 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x140001CB")]
			public event Action UserDataChangedEvent
			{
				[Token(Token = "0x60048B0")]
				[Address(RVA = "0x972C", Offset = "0x972C", VA = "0x972C")]
				[CompilerGenerated]
				add
				{
				}
				[Token(Token = "0x60048B1")]
				[Address(RVA = "0x972D", Offset = "0x972D", VA = "0x972D")]
				[CompilerGenerated]
				remove
				{
				}
			}

			// Token: 0x060048B2 RID: 18610 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60048B2")]
			[Address(RVA = "0x1B3D", Offset = "0x1B3D", VA = "0x1B3D")]
			public TeamMemberData(ulong userId)
			{
			}

			// Token: 0x060048B3 RID: 18611 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60048B3")]
			[Address(RVA = "0x972E", Offset = "0x972E", VA = "0x972E")]
			private void ResultCallback(long operationIndex, UserData[] data)
			{
			}

			// Token: 0x040027CE RID: 10190
			[Token(Token = "0x40027CE")]
			[FieldOffset(Offset = "0x14")]
			[CanBeNull]
			public UserData UserData;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_TeamId ---
		void Gameplay_Boss_Model_TeamRewardData__get_TeamId
		               (int param1,int param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  undefined4 *puVar2;
		  int iVar3;
		  int *piVar4;
		  uint *puVar5;
		  undefined8 param3_00;
		  int iVar6;
		  int *piVar7;
		  uint uVar8;
		  int local_c;
		  int **local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a57899 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerator_ulong__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_TeamRewardData_TeamMemberData__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_TeamRewardData_TeamMemberData___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_List_TeamRewardData_TeamMemberData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ulong__GetEnumerator__);
		    Mono_Security_ASN1__get_Item(&Gameplay_Boss_Model_TeamRewardData_TeamMemberData_TypeInfo);
		    DAT_ram_00a57899 = '\x01';
		  }
		  *(undefined1 *)(param1 + 0x10) = (undefined1)param3;
		  *(int *)(param1 + 8) = param2;
		  uVar1 = unnamed_function_1417
		                    (System_Collections_Generic_List_TeamRewardData_TeamMemberData__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (uVar1,Method_System_Collections_Generic_List_TeamRewardData_TeamMemberData___ctor__);
		  *(undefined4 *)(param1 + 0xc) = uVar1;
		  local_4 = (int *)Google_Protobuf_Collections_RepeatedField_long___Equals
		                             (*(undefined4 *)(param2 + 0x18),
		                              Method_Google_Protobuf_Collections_RepeatedField_ulong__GetEnumerator__
		                             );
		  local_c = 0;
		  local_8 = &local_4;
		code_r0x80deff02:
		  do {
		    piVar4 = local_4;
		    iVar6 = *local_4;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      uVar8 = 0;
		      do {
		        piVar7 = (int *)(*(int *)(iVar6 + 0x58) + uVar8 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar7) {
		          puVar2 = (undefined4 *)(iVar6 + piVar7[1] * 8 + 0xc0);
		          goto code_r0x80deff96;
		        }
		        uVar8 = uVar8 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar8);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar2 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_IEnumerator_TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80df01c3:
		      DAT_ram_009d3e38 = 0;
		      uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80df01cb;
		    }
		code_r0x80deff96:
		    DAT_ram_009d3e38 = 0;
		    iVar6 = import::env::invoke_iii(*puVar2,piVar4,puVar2[1]);
		    piVar4 = local_4;
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80df01c3;
		    if (iVar6 == 0) goto code_r0x80df0214;
		    iVar6 = *local_4;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      uVar8 = 0;
		      do {
		        piVar7 = (int *)(*(int *)(iVar6 + 0x58) + uVar8 * 8);
		        if (System_Collections_Generic_IEnumerator_ulong__TypeInfo == *piVar7) {
		          puVar2 = (undefined4 *)(iVar6 + piVar7[1] * 8 + 0xc0);
		          goto code_r0x80df0073;
		        }
		        uVar8 = uVar8 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar8);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar2 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_Generic_IEnumerator_ulong__TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80df01af:
		      DAT_ram_009d3e38 = 0;
		      uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80df01cb;
		    }
		code_r0x80df0073:
		    DAT_ram_009d3e38 = 0;
		    param3_00 = unnamed_function_184054(*puVar2,piVar4,puVar2[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80df01af;
		    iVar6 = *(int *)(param1 + 0xc);
		    DAT_ram_009d3e38 = 0;
		    uVar1 = import::env::invoke_ii
		                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                       Gameplay_Boss_Model_TeamRewardData_TeamMemberData_TypeInfo);
		    if (DAT_ram_009d3e38 == 1) break;
		    DAT_ram_009d3e38 = 0;
		    unnamed_function_184058
		              (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x375,uVar1,param3_00,iVar6);
		    iVar3 = Method_System_Collections_Generic_List_TeamRewardData_TeamMemberData__Add__;
		    if (DAT_ram_009d3e38 == 1) break;
		    *(int *)(iVar6 + 0x10) = *(int *)(iVar6 + 0x10) + 1;
		    uVar8 = *(uint *)(iVar6 + 0xc);
		    if (uVar8 < *(uint *)(*(int *)(iVar6 + 8) + 0xc)) {
		      *(uint *)(iVar6 + 0xc) = uVar8 + 1;
		      *(undefined4 *)(*(int *)(iVar6 + 8) + uVar8 * 4 + 0x10) = uVar1;
		      goto code_r0x80deff02;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,iVar6,uVar1,
		               *(undefined4 *)(*(int *)(*(int *)(iVar3 + 0x10) + 0x60) + 0x38));
		  } while (DAT_ram_009d3e38 != 1);
		  DAT_ram_009d3e38 = 0;
		  uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80df01cb:
		  iVar6 = global_1;
		  iVar3 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar6 == iVar3) {
		    piVar4 = (int *)import::env::__cxa_begin_catch(uVar1);
		    local_c = *piVar4;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_v(0x123);
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 != 1) {
		code_r0x80df0214:
		      DAT_ram_009d3e38 = 0;
		      piVar4 = *local_8;
		      if (piVar4 != (int *)0x0) {
		        uVar8 = 0;
		        iVar6 = *piVar4;
		        if (*(ushort *)(iVar6 + 0xb6) != 0) {
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar8 * 8)) {
		              puVar5 = (uint *)(iVar6 + *(int *)(*(int *)(iVar6 + 0x58) + uVar8 * 8 + 4) * 8 + 0xc0)
		              ;
		              goto code_r0x80df028f;
		            }
		            uVar8 = uVar8 + 1;
		          } while (*(ushort *)(iVar6 + 0xb6) != uVar8);
		        }
		        puVar5 = (uint *)func_ii_1080(piVar4,System_IDisposable_TypeInfo,0);
		code_r0x80df028f:
		        (**(code **)((ulonglong)*puVar5 * 4))(piVar4,puVar5[1]);
		      }
		      if (local_c == 0) {
		        return;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(local_c);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar1 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_000017c8 + 0x376,&local_c);
		  iVar6 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar6 == 1) {
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  import::env::__resumeException(uVar1);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

}
