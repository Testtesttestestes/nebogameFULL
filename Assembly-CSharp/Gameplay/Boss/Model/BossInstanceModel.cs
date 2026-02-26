using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Dict;
using Google.Protobuf.Collections;
using Il2CppDummyDll;
using JetBrains.Annotations;
using MVC;
using Protocol.Boss;
using Utils;

namespace Gameplay.Boss.Model
{
	// Token: 0x02000B91 RID: 2961
	[Token(Token = "0x2000B91")]
	public class BossInstanceModel : AbstractModel
	{
		// Token: 0x17000E8D RID: 3725
		// (get) Token: 0x06004826 RID: 18470 RVA: 0x0000D4B8 File Offset: 0x0000B6B8
		[Token(Token = "0x17000E8D")]
		public bool IsAlive
		{
			[Token(Token = "0x6004826")]
			[Address(RVA = "0x96A9", Offset = "0x96A9", VA = "0x96A9")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000E8E RID: 3726
		// (get) Token: 0x06004827 RID: 18471 RVA: 0x0000D4D0 File Offset: 0x0000B6D0
		[Token(Token = "0x17000E8E")]
		public bool IsDead
		{
			[Token(Token = "0x6004827")]
			[Address(RVA = "0x96AA", Offset = "0x96AA", VA = "0x96AA")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000E8F RID: 3727
		// (get) Token: 0x06004828 RID: 18472 RVA: 0x0000D4E8 File Offset: 0x0000B6E8
		[Token(Token = "0x17000E8F")]
		public bool IsLocked
		{
			[Token(Token = "0x6004828")]
			[Address(RVA = "0x96AB", Offset = "0x96AB", VA = "0x96AB")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000E90 RID: 3728
		// (get) Token: 0x06004829 RID: 18473 RVA: 0x0000D500 File Offset: 0x0000B700
		[Token(Token = "0x17000E90")]
		public bool IsEnded
		{
			[Token(Token = "0x6004829")]
			[Address(RVA = "0x96AC", Offset = "0x96AC", VA = "0x96AC")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000E91 RID: 3729
		// (get) Token: 0x0600482A RID: 18474 RVA: 0x0000D518 File Offset: 0x0000B718
		[Token(Token = "0x17000E91")]
		public bool Allowed
		{
			[Token(Token = "0x600482A")]
			[Address(RVA = "0x96AD", Offset = "0x96AD", VA = "0x96AD")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000E92 RID: 3730
		// (get) Token: 0x0600482B RID: 18475 RVA: 0x0000D530 File Offset: 0x0000B730
		[Token(Token = "0x17000E92")]
		public bool IsIParticipated
		{
			[Token(Token = "0x600482B")]
			[Address(RVA = "0x96AE", Offset = "0x96AE", VA = "0x96AE")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000E93 RID: 3731
		// (get) Token: 0x0600482C RID: 18476 RVA: 0x0000D548 File Offset: 0x0000B748
		[Token(Token = "0x17000E93")]
		public int NumUndistributedRewards
		{
			[Token(Token = "0x600482C")]
			[Address(RVA = "0x1B39", Offset = "0x1B39", VA = "0x1B39")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000E94 RID: 3732
		// (get) Token: 0x0600482D RID: 18477 RVA: 0x0000D560 File Offset: 0x0000B760
		[Token(Token = "0x17000E94")]
		public int NumInvites
		{
			[Token(Token = "0x600482D")]
			[Address(RVA = "0x96AF", Offset = "0x96AF", VA = "0x96AF")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000E95 RID: 3733
		// (get) Token: 0x0600482E RID: 18478 RVA: 0x0000D578 File Offset: 0x0000B778
		[Token(Token = "0x17000E95")]
		public int NumNotifications
		{
			[Token(Token = "0x600482E")]
			[Address(RVA = "0x96B0", Offset = "0x96B0", VA = "0x96B0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000E96 RID: 3734
		// (get) Token: 0x0600482F RID: 18479 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004830 RID: 18480 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E96")]
		public List<BossInviteData> MyInvites
		{
			[Token(Token = "0x600482F")]
			[Address(RVA = "0x96B1", Offset = "0x96B1", VA = "0x96B1")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004830")]
			[Address(RVA = "0x96B2", Offset = "0x96B2", VA = "0x96B2")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000E97 RID: 3735
		// (get) Token: 0x06004831 RID: 18481 RVA: 0x0000D590 File Offset: 0x0000B790
		[Token(Token = "0x17000E97")]
		public long Id
		{
			[Token(Token = "0x6004831")]
			[Address(RVA = "0x96B3", Offset = "0x96B3", VA = "0x96B3")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x17000E98 RID: 3736
		// (get) Token: 0x06004832 RID: 18482 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004833 RID: 18483 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E98")]
		public BossInfo BossInfo
		{
			[Token(Token = "0x6004832")]
			[Address(RVA = "0x96B4", Offset = "0x96B4", VA = "0x96B4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004833")]
			[Address(RVA = "0x96B5", Offset = "0x96B5", VA = "0x96B5")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000E99 RID: 3737
		// (get) Token: 0x06004834 RID: 18484 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004835 RID: 18485 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E99")]
		public BackTime NextPhaseBacktime
		{
			[Token(Token = "0x6004834")]
			[Address(RVA = "0x96B6", Offset = "0x96B6", VA = "0x96B6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004835")]
			[Address(RVA = "0x96B7", Offset = "0x96B7", VA = "0x96B7")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000E9A RID: 3738
		// (get) Token: 0x06004836 RID: 18486 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004837 RID: 18487 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E9A")]
		public InstanceInfo InstanceInfo
		{
			[Token(Token = "0x6004836")]
			[Address(RVA = "0x96B8", Offset = "0x96B8", VA = "0x96B8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004837")]
			[Address(RVA = "0x1B67", Offset = "0x1B67", VA = "0x1B67")]
			set
			{
			}
		}

		// Token: 0x17000E9B RID: 3739
		// (get) Token: 0x06004838 RID: 18488 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004839 RID: 18489 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E9B")]
		public InstanceState InstanceState
		{
			[Token(Token = "0x6004838")]
			[Address(RVA = "0x96B9", Offset = "0x96B9", VA = "0x96B9")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004839")]
			[Address(RVA = "0x96BA", Offset = "0x96BA", VA = "0x96BA")]
			set
			{
			}
		}

		// Token: 0x17000E9C RID: 3740
		// (get) Token: 0x0600483A RID: 18490 RVA: 0x0000D5A8 File Offset: 0x0000B7A8
		// (set) Token: 0x0600483B RID: 18491 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E9C")]
		public ulong CurrentHealth
		{
			[Token(Token = "0x600483A")]
			[Address(RVA = "0x96BB", Offset = "0x96BB", VA = "0x96BB")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x600483B")]
			[Address(RVA = "0x96BC", Offset = "0x96BC", VA = "0x96BC")]
			set
			{
			}
		}

		// Token: 0x17000E9D RID: 3741
		// (get) Token: 0x0600483C RID: 18492 RVA: 0x0000D5C0 File Offset: 0x0000B7C0
		[Token(Token = "0x17000E9D")]
		public float CurrentHealthPercent
		{
			[Token(Token = "0x600483C")]
			[Address(RVA = "0x96BD", Offset = "0x96BD", VA = "0x96BD")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000E9E RID: 3742
		// (get) Token: 0x0600483D RID: 18493 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000E9E")]
		public string HealthBarValue
		{
			[Token(Token = "0x600483D")]
			[Address(RVA = "0x96BE", Offset = "0x96BE", VA = "0x96BE")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000E9F RID: 3743
		// (get) Token: 0x0600483E RID: 18494 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600483F RID: 18495 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E9F")]
		public TeamData MyTeam
		{
			[Token(Token = "0x600483E")]
			[Address(RVA = "0x96BF", Offset = "0x96BF", VA = "0x96BF")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600483F")]
			[Address(RVA = "0x96C0", Offset = "0x96C0", VA = "0x96C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06004840 RID: 18496 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004840")]
		[Address(RVA = "0x96C1", Offset = "0x96C1", VA = "0x96C1")]
		public BossInstanceModel(IDictProvider dictProvider, UserData user)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Boss_Model_BossInstanceModel___ctor(int param1,int param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  undefined4 param4;
		  undefined4 param3_00;
		  
		  if (DAT_ram_00a57882 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Boss_Model_TeamData_TypeInfo);
		    DAT_ram_00a57882 = '\x01';
		  }
		  if (param2 == 0) {
		    *(undefined4 *)(param1 + 0x3c) = 0;
		    return;
		  }
		  if (*(int *)(param1 + 0x3c) != 0) {
		    Gameplay_Boss_Model_TeamData__get_RawTeamInfo(*(int *)(param1 + 0x3c),param2,param1);
		    return;
		  }
		  param4 = *(undefined4 *)(param1 + 8);
		  param3_00 = *(undefined4 *)(param1 + 0x30);
		  param1_00 = unnamed_function_1417(Gameplay_Boss_Model_TeamData_TypeInfo);
		  Gameplay_Boss_Model_TeamData__get_MyRatingPlace(param1_00,param2,param3_00,param4,param1);
		  *(undefined4 *)(param1 + 0x3c) = param1_00;
		  return;
		}
		*/

		}

		// Token: 0x06004841 RID: 18497 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004841")]
		[Address(RVA = "0x96C2", Offset = "0x96C2", VA = "0x96C2")]
		public void SetMyTeam(TeamInfo teamInfo)
		{
		/* --- GHIDRA: SetMyTeam ---
		void Gameplay_Boss_Model_BossInstanceModel__SetMyTeam(int param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 *puVar3;
		  undefined4 param2_00;
		  undefined4 uVar4;
		  int *piVar5;
		  int iVar6;
		  int iVar7;
		  int *piVar8;
		  int local_c;
		  int **local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a57883 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Boss_Model_BossInviteData_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_IEnumerable_MercenaryInvitesEvt_Types_Invite__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_IEnumerator_MercenaryInvitesEvt_Types_Invite__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_BossInviteData__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_BossInviteData__Clear__);
		    DAT_ram_00a57883 = '\x01';
		  }
		  iVar6 = *(int *)(param1 + 0x2c);
		  iVar7 = *(int *)(iVar6 + 0xc);
		  *(undefined4 *)(iVar6 + 0xc) = 0;
		  *(int *)(iVar6 + 0x10) = *(int *)(iVar6 + 0x10) + 1;
		  if (0 < iVar7) {
		    func_ii_2064(*(undefined4 *)(iVar6 + 8),0,iVar7,0);
		  }
		  uVar1 = 0;
		  iVar6 = *param2;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (System_Collections_Generic_IEnumerable_MercenaryInvitesEvt_Types_Invite__TypeInfo ==
		          *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(iVar6 + *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80dede36;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,
		                                System_Collections_Generic_IEnumerable_MercenaryInvitesEvt_Types_Invite__TypeInfo
		                                ,0);
		code_r0x80dede36:
		  local_4 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		  local_c = 0;
		  local_8 = &local_4;
		code_r0x80dede6b:
		  do {
		    piVar5 = local_4;
		    iVar6 = *local_4;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar8 = (int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar8) {
		          puVar3 = (undefined4 *)(iVar6 + piVar8[1] * 8 + 0xc0);
		          goto code_r0x80dedeff;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar3 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_IEnumerator_TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80dee128:
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80dee130;
		    }
		code_r0x80dedeff:
		    DAT_ram_009d3e38 = 0;
		    iVar6 = import::env::invoke_iii(*puVar3,piVar5,puVar3[1]);
		    piVar5 = local_4;
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80dee128;
		    if (iVar6 == 0) goto code_r0x80dee179;
		    iVar6 = *local_4;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar8 = (int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8);
		        if (System_Collections_Generic_IEnumerator_MercenaryInvitesEvt_Types_Invite__TypeInfo ==
		            *piVar8) {
		          puVar3 = (undefined4 *)(iVar6 + piVar8[1] * 8 + 0xc0);
		          goto code_r0x80dedfdc;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar3 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_Generic_IEnumerator_MercenaryInvitesEvt_Types_Invite__TypeInfo
		                        ,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80dee114:
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80dee130;
		    }
		code_r0x80dedfdc:
		    DAT_ram_009d3e38 = 0;
		    uVar4 = import::env::invoke_iii(*puVar3,piVar5,puVar3[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80dee114;
		    iVar6 = *(int *)(param1 + 0x2c);
		    DAT_ram_009d3e38 = 0;
		    param2_00 = import::env::invoke_ii
		                          (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                           Gameplay_Boss_Model_BossInviteData_TypeInfo);
		    if (DAT_ram_009d3e38 == 1) break;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x36b,param2_00,uVar4,iVar6);
		    iVar7 = Method_System_Collections_Generic_List_BossInviteData__Add__;
		    if (DAT_ram_009d3e38 == 1) break;
		    *(int *)(iVar6 + 0x10) = *(int *)(iVar6 + 0x10) + 1;
		    uVar1 = *(uint *)(iVar6 + 0xc);
		    if (uVar1 < *(uint *)(*(int *)(iVar6 + 8) + 0xc)) {
		      *(uint *)(iVar6 + 0xc) = uVar1 + 1;
		      *(undefined4 *)(*(int *)(iVar6 + 8) + uVar1 * 4 + 0x10) = param2_00;
		      goto code_r0x80dede6b;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,iVar6,param2_00,
		               *(undefined4 *)(*(int *)(*(int *)(iVar7 + 0x10) + 0x60) + 0x38));
		  } while (DAT_ram_009d3e38 != 1);
		  DAT_ram_009d3e38 = 0;
		  uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80dee130:
		  iVar6 = global_1;
		  iVar7 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar6 == iVar7) {
		    piVar5 = (int *)import::env::__cxa_begin_catch(uVar4);
		    local_c = *piVar5;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_v(0x123);
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 != 1) {
		code_r0x80dee179:
		      DAT_ram_009d3e38 = 0;
		      piVar5 = *local_8;
		      if (piVar5 != (int *)0x0) {
		        uVar1 = 0;
		        iVar6 = *piVar5;
		        if (*(ushort *)(iVar6 + 0xb6) != 0) {
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		              puVar2 = (uint *)(iVar6 + *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0)
		              ;
		              goto code_r0x80dee1f4;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		        }
		        puVar2 = (uint *)func_ii_1080(piVar5,System_IDisposable_TypeInfo,0);
		code_r0x80dee1f4:
		        (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		      }
		      if (local_c == 0) {
		        return;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(local_c);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar4 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_000017c8 + 0x36c,&local_c);
		  iVar6 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar6 == 1) {
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  import::env::__resumeException(uVar4);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06004842 RID: 18498 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004842")]
		[Address(RVA = "0x96C3", Offset = "0x96C3", VA = "0x96C3")]
		public void SetMyInvites(IList<MercenaryInvitesEvt.Types.Invite> invitesRaw)
		{
		}

		// Token: 0x17000EA0 RID: 3744
		// (get) Token: 0x06004843 RID: 18499 RVA: 0x0000D5D8 File Offset: 0x0000B7D8
		// (set) Token: 0x06004844 RID: 18500 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000EA0")]
		public int LicenceCountCurrent
		{
			[Token(Token = "0x6004843")]
			[Address(RVA = "0x96C4", Offset = "0x96C4", VA = "0x96C4")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6004844")]
			[Address(RVA = "0x96C5", Offset = "0x96C5", VA = "0x96C5")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000EA1 RID: 3745
		// (get) Token: 0x06004845 RID: 18501 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004846 RID: 18502 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000EA1")]
		public RepeatedField<GetCaptainTeamListAns.Types.TeamRewardInfo> TeamsRewardInfo
		{
			[Token(Token = "0x6004845")]
			[Address(RVA = "0x96C6", Offset = "0x96C6", VA = "0x96C6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004846")]
			[Address(RVA = "0x96C7", Offset = "0x96C7", VA = "0x96C7")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000EA2 RID: 3746
		// (get) Token: 0x06004847 RID: 18503 RVA: 0x0000D5F0 File Offset: 0x0000B7F0
		// (set) Token: 0x06004848 RID: 18504 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000EA2")]
		public ulong CaptainsCount
		{
			[Token(Token = "0x6004847")]
			[Address(RVA = "0x96C8", Offset = "0x96C8", VA = "0x96C8")]
			[CompilerGenerated]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x6004848")]
			[Address(RVA = "0x96C9", Offset = "0x96C9", VA = "0x96C9")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000EA3 RID: 3747
		// (get) Token: 0x06004849 RID: 18505 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600484A RID: 18506 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000EA3")]
		public RepeatedField<ShortTeamInfo> MyCaptainsAllTeams
		{
			[Token(Token = "0x6004849")]
			[Address(RVA = "0x96CA", Offset = "0x96CA", VA = "0x96CA")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600484A")]
			[Address(RVA = "0x96CB", Offset = "0x96CB", VA = "0x96CB")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600484B RID: 18507 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600484B")]
		[Address(RVA = "0x96CC", Offset = "0x96CC", VA = "0x96CC")]
		[NotNull]
		public List<ulong> GetTeamIdsForMyCaptain(ulong captainId)
		{
			return null;
		}

		// Token: 0x0600484C RID: 18508 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600484C")]
		[Address(RVA = "0x1B81", Offset = "0x1B81", VA = "0x1B81")]
		[NotNull]
		public List<TeamData.TeamAssistantData> GetAssistantsByCultId(uint cultId)
		{
			return null;
		}

		// Token: 0x04002796 RID: 10134
		[Token(Token = "0x4002796")]
		[FieldOffset(Offset = "0xC")]
		public readonly IDictProvider DictProvider;

		// Token: 0x04002797 RID: 10135
		[Token(Token = "0x4002797")]
		[FieldOffset(Offset = "0x10")]
		[TupleElementNames(new string[]
		{
			"OptionId",
			"VariantId"
		})]
		public ValueTuple<long, int>? LastSavedOptionAndVariant;

		// Token: 0x04002798 RID: 10136
		[Token(Token = "0x4002798")]
		[FieldOffset(Offset = "0x28")]
		private InstanceInfo _instanceInfo;

		// Token: 0x0400279C RID: 10140
		[Token(Token = "0x400279C")]
		[FieldOffset(Offset = "0x38")]
		private InstanceState _instanceState;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_IsAlive ---
		uint Gameplay_Boss_Model_BossInstanceModel__get_IsAlive(int param1,undefined4 param2)
		
		{
		  return (uint)(*(int *)(*(int *)(param1 + 0x38) + 0x18) == 3);
		}
		*/


		/* --- GHIDRA: get_IsDead ---
		uint Gameplay_Boss_Model_BossInstanceModel__get_IsDead(int param1,undefined4 param2)
		
		{
		  return (uint)(*(int *)(*(int *)(param1 + 0x38) + 0x18) == 2);
		}
		*/


		/* --- GHIDRA: get_IsLocked ---
		uint Gameplay_Boss_Model_BossInstanceModel__get_IsLocked(int param1,undefined4 param2)
		
		{
		  return (uint)(*(int *)(*(int *)(param1 + 0x38) + 0x18) == 4);
		}
		*/


		/* --- GHIDRA: get_IsEnded ---
		uint Gameplay_Boss_Model_BossInstanceModel__get_IsEnded(int param1,undefined4 param2)
		
		{
		  return (uint)*(byte *)(*(int *)(param1 + 0x28) + 0x30);
		}
		*/


		/* --- GHIDRA: get_Allowed ---
		uint Gameplay_Boss_Model_BossInstanceModel__get_Allowed(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  
		  if (DAT_ram_00a5787a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Google_Protobuf_Collections_RepeatedField_GetCaptainTeamListAns_Types_TeamRewardInfo__get_Count__
		              );
		    DAT_ram_00a5787a = '\x01';
		  }
		  if (*(int *)(param1 + 0x44) == 0) {
		    uVar1 = 0;
		  }
		  else {
		    uVar1 = (uint)(0 < *(int *)(*(int *)(param1 + 0x44) + 0xc));
		  }
		  return uVar1;
		}
		*/


		/* --- GHIDRA: get_IsIParticipated ---
		undefined4 Gameplay_Boss_Model_BossInstanceModel__get_IsIParticipated(int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5787c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_BossInviteData__get_Count__);
		    DAT_ram_00a5787c = '\x01';
		  }
		  return *(undefined4 *)(*(int *)(param1 + 0x2c) + 0xc);
		}
		*/


		/* --- GHIDRA: get_NumUndistributedRewards ---
		int * Gameplay_Boss_Model_BossInstanceModel__get_NumUndistributedRewards(int *param1)
		
		{
		  if (*param1 == 0) {
		    return param1;
		  }
		  System_Data_DataSet__ValidateLocaleConstraint(*param1);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: get_NumInvites ---
		undefined4 Gameplay_Boss_Model_BossInstanceModel__get_NumInvites(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5787d == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Math_TypeInfo);
		    DAT_ram_00a5787d = '\x01';
		  }
		  if (DAT_ram_00a5787c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_BossInviteData__get_Count__);
		    DAT_ram_00a5787c = '\x01';
		  }
		  param1_00 = *(undefined4 *)(*(int *)(param1 + 0x2c) + 0xc);
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_long__object___MoveNext
		                    (param1,param1);
		  if (*(int *)(System_Math_TypeInfo + 0x74) == 0) {
		    func_ii_306000(System_Math_TypeInfo);
		  }
		  uVar1 = UnityEngine_Mathf__Max(param1_00,uVar1,0);
		  return uVar1;
		}
		*/


		/* --- GHIDRA: set_MyInvites ---
		undefined8 Gameplay_Boss_Model_BossInstanceModel__set_MyInvites(int param1,undefined4 param2)
		
		{
		  return *(undefined8 *)(*(int *)(param1 + 0x28) + 0x10);
		}
		*/


		/* --- GHIDRA: get_InstanceState ---
		void Gameplay_Boss_Model_BossInstanceModel__get_InstanceState
		               (int param1,int param2,undefined4 param3)
		
		{
		  float param2_00;
		  undefined4 param1_00;
		  undefined8 param1_01;
		  
		  if (DAT_ram_00a5787f == '\0') {
		    Mono_Security_ASN1__get_Item(&Utils_BackTime_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Utils_TimeUtils_TypeInfo);
		    DAT_ram_00a5787f = '\x01';
		  }
		  *(int *)(param1 + 0x38) = param2;
		  param1_01 = *(undefined8 *)(param2 + 0x20);
		  if (*(int *)(Utils_TimeUtils_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Utils_TimeUtils_TypeInfo);
		  }
		  param2_00 = func_ii_7331(param1_01,0);
		  param1_00 = unnamed_function_1417(Utils_BackTime_TypeInfo);
		  Core_Extensions_Dict_DictExt__BinarySearch_object__uint_(param1_00,param2_00,0);
		  *(undefined4 *)(param1 + 0x34) = param1_00;
		  return;
		}
		*/


		/* --- GHIDRA: set_InstanceState ---
		undefined8 Gameplay_Boss_Model_BossInstanceModel__set_InstanceState(int param1,undefined4 param2)
		
		{
		  return *(undefined8 *)(*(int *)(param1 + 0x28) + 0x28);
		}
		*/


		/* --- GHIDRA: get_CurrentHealth ---
		void Gameplay_Boss_Model_BossInstanceModel__get_CurrentHealth
		               (int param1,undefined8 param2,undefined4 param3)
		
		{
		  *(undefined8 *)(*(int *)(param1 + 0x28) + 0x28) = param2;
		  return;
		}
		*/


		/* --- GHIDRA: set_CurrentHealth ---
		float Gameplay_Boss_Model_BossInstanceModel__set_CurrentHealth(int param1,undefined4 param2)
		
		{
		  float fVar1;
		  ulonglong uVar2;
		  ulonglong uVar3;
		  
		  uVar3 = *(ulonglong *)(*(int *)(param1 + 0x28) + 0x28);
		  uVar2 = Gameplay_Boss_Model_BossInfo__get_HasLossReward(*(undefined4 *)(param1 + 0x30),param1);
		  fVar1 = UnityEngine_Camera__set_orthographicSize((float)uVar3,(float)uVar2,0);
		  return fVar1;
		}
		*/


		/* --- GHIDRA: get_CurrentHealthPercent ---
		undefined4
		Gameplay_Boss_Model_BossInstanceModel__get_CurrentHealthPercent(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  ulonglong uVar2;
		  ulonglong uVar3;
		  
		  if (DAT_ram_00a57880 == '\0') {
		    Mono_Security_ASN1__get_Item(&Utils_StringUtils_TypeInfo);
		    DAT_ram_00a57880 = '\x01';
		  }
		  uVar3 = *(ulonglong *)(*(int *)(param1 + 0x28) + 0x28);
		  uVar2 = Gameplay_Boss_Model_BossInfo__get_HasLossReward(*(undefined4 *)(param1 + 0x30),param1);
		  if (*(int *)(Utils_StringUtils_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Utils_StringUtils_TypeInfo);
		  }
		  uVar1 = Utils_StringUtils__GetRomanNumber((double)uVar3,(double)uVar2,0);
		  return uVar1;
		}
		*/


		/* --- GHIDRA: set_MyTeam ---
		void Gameplay_Boss_Model_BossInstanceModel__set_MyTeam
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a57881 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_BossInviteData___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_BossInviteData__TypeInfo);
		    DAT_ram_00a57881 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_Collections_Generic_List_BossInviteData__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_00,Method_System_Collections_Generic_List_BossInviteData___ctor__);
		  *(undefined4 *)(param1 + 0x2c) = param1_00;
		  Unity_Services_Core_Environments_Internal_Environments__get_Current(param1,param3,0);
		  *(undefined4 *)(param1 + 0xc) = param2;
		  return;
		}
		*/


		/* --- GHIDRA: set_MyCaptainsAllTeams ---
		int Gameplay_Boss_Model_BossInstanceModel__set_MyCaptainsAllTeams
		              (int param1,longlong param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 *puVar2;
		  undefined4 param1_00;
		  int iVar3;
		  int *piVar4;
		  uint *puVar5;
		  int iVar6;
		  undefined8 param3_00;
		  int *piVar7;
		  uint uVar8;
		  int local_c;
		  int **local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a57884 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerator_ShortTeamInfo__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_ulong__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_ulong___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_ulong__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ShortTeamInfo__GetEnumerator__);
		    DAT_ram_00a57884 = '\x01';
		  }
		  iVar1 = unnamed_function_1417(System_Collections_Generic_List_ulong__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (iVar1,Method_System_Collections_Generic_List_ulong___ctor__);
		  if (*(int *)(param1 + 0x50) == 0) {
		    return iVar1;
		  }
		  local_4 = (int *)Google_Protobuf_Collections_RepeatedField_float___Equals
		                             (*(int *)(param1 + 0x50),
		                              Method_Google_Protobuf_Collections_RepeatedField_ShortTeamInfo__GetEnumerator__
		                             );
		  local_c = 0;
		  local_8 = &local_4;
		code_r0x80dee5da:
		  do {
		    do {
		      piVar4 = local_4;
		      iVar6 = *local_4;
		      if (*(ushort *)(iVar6 + 0xb6) != 0) {
		        uVar8 = 0;
		        do {
		          piVar7 = (int *)(*(int *)(iVar6 + 0x58) + uVar8 * 8);
		          if (System_Collections_IEnumerator_TypeInfo == *piVar7) {
		            puVar2 = (undefined4 *)(iVar6 + piVar7[1] * 8 + 0xc0);
		            goto code_r0x80dee680;
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
		code_r0x80dee6c8:
		        DAT_ram_009d3e38 = 0;
		        param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80dee85d;
		      }
		code_r0x80dee680:
		      DAT_ram_009d3e38 = 0;
		      iVar6 = import::env::invoke_iii(*puVar2,piVar4,puVar2[1]);
		      piVar4 = local_4;
		      if (DAT_ram_009d3e38 == 1) goto code_r0x80dee6c8;
		      if (iVar6 == 0) {
		        iVar6 = 0;
		        goto code_r0x80dee8a6;
		      }
		      iVar6 = *local_4;
		      if (*(ushort *)(iVar6 + 0xb6) != 0) {
		        uVar8 = 0;
		        do {
		          piVar7 = (int *)(*(int *)(iVar6 + 0x58) + uVar8 * 8);
		          if (System_Collections_Generic_IEnumerator_ShortTeamInfo__TypeInfo == *piVar7) {
		            puVar2 = (undefined4 *)(iVar6 + piVar7[1] * 8 + 0xc0);
		            goto code_r0x80dee76f;
		          }
		          uVar8 = uVar8 + 1;
		        } while (*(ushort *)(iVar6 + 0xb6) != uVar8);
		      }
		      DAT_ram_009d3e38 = 0;
		      puVar2 = (undefined4 *)
		               import::env::invoke_iiii
		                         (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                          System_Collections_Generic_IEnumerator_ShortTeamInfo__TypeInfo,0);
		      if (DAT_ram_009d3e38 == 1) {
		code_r0x80dee7b9:
		        DAT_ram_009d3e38 = 0;
		        param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80dee85d;
		      }
		code_r0x80dee76f:
		      DAT_ram_009d3e38 = 0;
		      iVar3 = import::env::invoke_iii(*puVar2,piVar4,puVar2[1]);
		      iVar6 = Method_System_Collections_Generic_List_ulong__Add__;
		      if (DAT_ram_009d3e38 == 1) goto code_r0x80dee7b9;
		    } while (*(longlong *)(iVar3 + 0x10) != param2);
		    param3_00 = *(undefined8 *)(iVar3 + 0x18);
		    *(int *)(iVar1 + 0x10) = *(int *)(iVar1 + 0x10) + 1;
		    uVar8 = *(uint *)(iVar1 + 0xc);
		    if (uVar8 < *(uint *)(*(int *)(iVar1 + 8) + 0xc)) {
		      *(uint *)(iVar1 + 0xc) = uVar8 + 1;
		      *(undefined8 *)(*(int *)(iVar1 + 8) + uVar8 * 8 + 0x10) = param3_00;
		      goto code_r0x80dee5da;
		    }
		    DAT_ram_009d3e38 = 0;
		    unnamed_function_184058
		              (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x2ea,iVar1,param3_00,
		               *(undefined4 *)(*(int *)(*(int *)(iVar6 + 0x10) + 0x60) + 0x38));
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		  } while (iVar6 != 1);
		  param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80dee85d:
		  iVar6 = global_1;
		  iVar3 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar6 == iVar3) {
		    piVar4 = (int *)import::env::__cxa_begin_catch(param1_00);
		    iVar6 = *piVar4;
		    DAT_ram_009d3e38 = 0;
		    local_c = iVar6;
		    import::env::invoke_v(0x123);
		    iVar3 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar3 != 1) {
		code_r0x80dee8a6:
		      piVar4 = local_4;
		      DAT_ram_009d3e38 = 0;
		      if (local_4 != (int *)0x0) {
		        uVar8 = 0;
		        iVar3 = *local_4;
		        if (*(ushort *)(iVar3 + 0xb6) != 0) {
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar8 * 8)) {
		              puVar5 = (uint *)(iVar3 + *(int *)(*(int *)(iVar3 + 0x58) + uVar8 * 8 + 4) * 8 + 0xc0)
		              ;
		              goto code_r0x80dee91e;
		            }
		            uVar8 = uVar8 + 1;
		          } while (*(ushort *)(iVar3 + 0xb6) != uVar8);
		        }
		        puVar5 = (uint *)func_ii_1080(local_4,System_IDisposable_TypeInfo,0);
		code_r0x80dee91e:
		        (**(code **)((ulonglong)*puVar5 * 4))(piVar4,puVar5[1]);
		      }
		      if (iVar6 == 0) {
		        return iVar1;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(iVar6);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    param1_00 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_000017c8 + 0x36d,&local_c);
		  iVar1 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar1 != 1) {
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
		*/

}
