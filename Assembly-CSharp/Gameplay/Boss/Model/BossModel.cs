using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Gameplay;
using Il2CppDummyDll;
using MVC;
using Protocol.Boss;

namespace Gameplay.Boss.Model
{
	// Token: 0x02000B93 RID: 2963
	[Token(Token = "0x2000B93")]
	public class BossModel : AbstractModel
	{
		// Token: 0x17000EA7 RID: 3751
		// (get) Token: 0x06004857 RID: 18519 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000EA7")]
		public Dictionary<long, BossInstance> Storage
		{
			[Token(Token = "0x6004857")]
			[Address(RVA = "0x96D6", Offset = "0x96D6", VA = "0x96D6")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000EA8 RID: 3752
		// (get) Token: 0x06004858 RID: 18520 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004859 RID: 18521 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000EA8")]
		public MonsterData CurrentMinion
		{
			[Token(Token = "0x6004858")]
			[Address(RVA = "0x96D7", Offset = "0x96D7", VA = "0x96D7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004859")]
			[Address(RVA = "0x96D8", Offset = "0x96D8", VA = "0x96D8")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000EA9 RID: 3753
		// (get) Token: 0x0600485A RID: 18522 RVA: 0x0000D620 File Offset: 0x0000B820
		[Token(Token = "0x17000EA9")]
		public int TotalNotificationNum
		{
			[Token(Token = "0x600485A")]
			[Address(RVA = "0x96D9", Offset = "0x96D9", VA = "0x96D9")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000EAA RID: 3754
		// (get) Token: 0x0600485B RID: 18523 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600485C RID: 18524 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000EAA")]
		public IGame Game
		{
			[Token(Token = "0x600485B")]
			[Address(RVA = "0x96DA", Offset = "0x96DA", VA = "0x96DA")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600485C")]
			[Address(RVA = "0x96DB", Offset = "0x96DB", VA = "0x96DB")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600485D RID: 18525 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600485D")]
		[Address(RVA = "0x96DC", Offset = "0x96DC", VA = "0x96DC")]
		public BossModel(IGame game, UserData user)
		{
		}

		// Token: 0x17000EAB RID: 3755
		// (get) Token: 0x0600485E RID: 18526 RVA: 0x0000D638 File Offset: 0x0000B838
		// (set) Token: 0x0600485F RID: 18527 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000EAB")]
		public long CurrentInstanceId
		{
			[Token(Token = "0x600485E")]
			[Address(RVA = "0x96DD", Offset = "0x96DD", VA = "0x96DD")]
			get
			{
				return 0L;
			}
			[Token(Token = "0x600485F")]
			[Address(RVA = "0x96DE", Offset = "0x96DE", VA = "0x96DE")]
			set
			{
			}
		}

		// Token: 0x17000EAC RID: 3756
		// (get) Token: 0x06004860 RID: 18528 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004861 RID: 18529 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000EAC")]
		public BossCreateRequestData CurrentCreateRequest
		{
			[Token(Token = "0x6004860")]
			[Address(RVA = "0x96DF", Offset = "0x96DF", VA = "0x96DF")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004861")]
			[Address(RVA = "0x96E0", Offset = "0x96E0", VA = "0x96E0")]
			set
			{
			}
		}

		// Token: 0x06004862 RID: 18530 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004862")]
		[Address(RVA = "0x96E1", Offset = "0x96E1", VA = "0x96E1")]
		public BossInstance AddBoss(InstanceInfo instanceInfo)
		{
		/* --- GHIDRA: AddBoss ---
		void Gameplay_Boss_Model_BossModel__AddBoss(int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int *piVar3;
		  undefined8 uVar4;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5788c == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_long__BossInstance__ContainsKey__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_long__BossInstance__Remove__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_long__BossInstance__get_Item__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3966);
		    DAT_ram_00a5788c = '\x01';
		  }
		  iVar1 = System_Collections_Generic_Dictionary_long__InvocationDefinition___Clear
		                    (*(undefined4 *)(param1 + 0xc),
		                     *(undefined8 *)(*(int *)(*(int *)(param2 + 8) + 0x28) + 0x10),
		                     Method_System_Collections_Generic_Dictionary_long__BossInstance__ContainsKey__)
		  ;
		  if (iVar1 == 0) {
		    local_8 = *(undefined8 *)(*(int *)(*(int *)(param2 + 8) + 0x28) + 0x10);
		    uVar2 = func_ii_1081(DAT_ram_00a66964,&local_8);
		    uVar2 = func_ii_4419(StringLiteral_3966,uVar2,0);
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    func_ii_7830(uVar2,0);
		  }
		  else {
		    iVar1 = System_Collections_Generic_Dictionary_long__object___ContainsKey
		                      (*(undefined4 *)(param1 + 0xc),
		                       *(undefined8 *)(*(int *)(*(int *)(param2 + 8) + 0x28) + 0x10),
		                       Method_System_Collections_Generic_Dictionary_long__BossInstance__get_Item__);
		    uVar4 = *(undefined8 *)(*(int *)(*(int *)(param2 + 8) + 0x28) + 0x10);
		    System_Collections_Generic_Dictionary_int__object___Remove
		              (*(undefined4 *)(param1 + 0xc),uVar4,
		               Method_System_Collections_Generic_Dictionary_long__BossInstance__Remove__);
		    uVar2 = (undefined4)((ulonglong)uVar4 >> 0x20);
		    if (*(int *)(iVar1 + 0xc) != 0) {
		      MVC_AbstractController__Run(*(int *)(iVar1 + 0xc),0);
		      piVar3 = *(int **)(iVar1 + 0xc);
		      if (piVar3 != (int *)0x0) {
		        uVar4 = CONCAT44(uVar2,*(undefined4 *)(*piVar3 + 0xec));
		        (**(code **)((ulonglong)*(uint *)(*piVar3 + 0xe8) * 4))(piVar3,uVar4);
		        uVar2 = (undefined4)((ulonglong)uVar4 >> 0x20);
		      }
		    }
		    piVar3 = *(int **)(iVar1 + 8);
		    if (piVar3 != (int *)0x0) {
		      (**(code **)((ulonglong)*(uint *)(*piVar3 + 0xe8) * 4))
		                (piVar3,CONCAT44(uVar2,*(undefined4 *)(*piVar3 + 0xec)));
		    }
		    *(undefined4 *)(iVar1 + 0x10) = 0;
		    *(undefined8 *)(iVar1 + 8) = 0;
		  }
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06004863 RID: 18531 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004863")]
		[Address(RVA = "0x96E2", Offset = "0x96E2", VA = "0x96E2")]
		public void RemoveBoss(BossInstance instance)
		{
		/* --- GHIDRA: RemoveBoss ---
		undefined4 Gameplay_Boss_Model_BossModel__RemoveBoss(int param1,undefined8 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a5788d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_long__BossInstance__ContainsKey__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_long__BossInstance__get_Item__);
		    DAT_ram_00a5788d = '\x01';
		  }
		  iVar1 = System_Collections_Generic_Dictionary_long__InvocationDefinition___Clear
		                    (*(undefined4 *)(param1 + 0xc),param2,
		                     Method_System_Collections_Generic_Dictionary_long__BossInstance__ContainsKey__)
		  ;
		  if (iVar1 == 0) {
		    uVar2 = 0;
		  }
		  else {
		    uVar2 = System_Collections_Generic_Dictionary_long__object___ContainsKey
		                      (*(undefined4 *)(param1 + 0xc),param2,
		                       Method_System_Collections_Generic_Dictionary_long__BossInstance__get_Item__);
		  }
		  return uVar2;
		}
		*/

		}

		// Token: 0x06004864 RID: 18532 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004864")]
		[Address(RVA = "0x96E3", Offset = "0x96E3", VA = "0x96E3")]
		public BossInstance GetBoss(long id)
		{
		/* --- GHIDRA: GetBoss ---
		undefined4 Gameplay_Boss_Model_BossModel__GetBoss(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  longlong param2_00;
		  
		  uVar2 = 0;
		  param2_00 = *(longlong *)(param1 + 0x18);
		  if (0 < param2_00) {
		    if (DAT_ram_00a5788d == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&Method_System_Collections_Generic_Dictionary_long__BossInstance__ContainsKey__);
		      Mono_Security_ASN1__get_Item
		                (&Method_System_Collections_Generic_Dictionary_long__BossInstance__get_Item__);
		      DAT_ram_00a5788d = '\x01';
		    }
		    iVar1 = System_Collections_Generic_Dictionary_long__InvocationDefinition___Clear
		                      (*(undefined4 *)(param1 + 0xc),param2_00,
		                       Method_System_Collections_Generic_Dictionary_long__BossInstance__ContainsKey__
		                      );
		    uVar2 = 0;
		    if (iVar1 != 0) {
		      uVar2 = System_Collections_Generic_Dictionary_long__object___ContainsKey
		                        (*(undefined4 *)(param1 + 0xc),param2_00,
		                         Method_System_Collections_Generic_Dictionary_long__BossInstance__get_Item__
		                        );
		    }
		  }
		  return uVar2;
		}
		*/

			return null;
		}

		// Token: 0x17000EAD RID: 3757
		// (get) Token: 0x06004865 RID: 18533 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000EAD")]
		public BossInstance CurrentInstance
		{
			[Token(Token = "0x6004865")]
			[Address(RVA = "0x96E4", Offset = "0x96E4", VA = "0x96E4")]
			get
			{
				return null;
			}
		}

		// Token: 0x040027A6 RID: 10150
		[Token(Token = "0x40027A6")]
		[FieldOffset(Offset = "0xC")]
		private Dictionary<long, BossInstance> _storage;

		// Token: 0x040027A9 RID: 10153
		[Token(Token = "0x40027A9")]
		[FieldOffset(Offset = "0x18")]
		private long _currentInstanceId;

		// Token: 0x040027AA RID: 10154
		[Token(Token = "0x40027AA")]
		[FieldOffset(Offset = "0x20")]
		private BossCreateRequestData _currentCreateRequest;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_CurrentMinion ---
		int Gameplay_Boss_Model_BossModel__set_CurrentMinion(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  int *piVar3;
		  int iVar4;
		  undefined4 param1_00;
		  int iVar5;
		  undefined1 auStack_20 [8];
		  int local_18;
		  undefined8 *local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  iVar5 = 0;
		  if (DAT_ram_00a57889 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_long__BossInstance__get_Values__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_long__BossInstance__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_long__BossInstance__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_long__BossInstance__get_Current__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_long__BossInstance__GetEnumerator__
		              );
		    DAT_ram_00a57889 = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  uVar1 = System_Collections_Generic_Dictionary_int__object___TryAdd
		                    (*(undefined4 *)(param1 + 0xc),
		                     Method_System_Collections_Generic_Dictionary_long__BossInstance__get_Values__);
		  System_Collections_Generic_Dictionary_Int32Enum__object___get_Values
		            (&local_10,uVar1,
		             Method_System_Collections_Generic_Dictionary_ValueCollection_long__BossInstance__GetEnumerator__
		            );
		  local_18 = 0;
		  local_14 = &local_10;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar2 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x370,&local_10,
		                       Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_long__BossInstance__MoveNext__
		                      );
		    iVar4 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar4 == 1) {
		      uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80def003:
		      iVar4 = global_1;
		      iVar2 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar4 == iVar2) {
		        piVar3 = (int *)import::env::__cxa_begin_catch(uVar1);
		        iVar2 = *piVar3;
		        DAT_ram_009d3e38 = 0;
		        local_18 = iVar2;
		        import::env::invoke_v(0x123);
		        iVar4 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar4 != 1) {
		          if (iVar2 == 0) {
		            DAT_ram_009d3e38 = 0;
		            return iVar5;
		          }
		          System_Data_DataSet__ValidateLocaleConstraint(iVar2);
		          do {
		            halt_trap();
		          } while( true );
		        }
		        uVar1 = import::env::__cxa_find_matching_catch_2();
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_000017c8 + 0x372,&local_18);
		      iVar5 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar5 != 1) {
		        import::env::__resumeException(uVar1);
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
		    if (iVar2 == 0) {
		      DAT_ram_009d3e38 = 0;
		      return iVar5;
		    }
		    iVar4 = *(int *)(local_8._4_4_ + 8);
		    if (DAT_ram_00a5787d == '\0') {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi(0x7ff,&System_Math_TypeInfo);
		      if (DAT_ram_009d3e38 != 1) {
		        DAT_ram_00a5787d = '\x01';
		        goto code_r0x80deeeed;
		      }
		code_r0x80deeff1:
		      DAT_ram_009d3e38 = 0;
		      uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80def003;
		    }
		code_r0x80deeeed:
		    if (DAT_ram_00a5787c == '\0') {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi
		                (0x7ff,&Method_System_Collections_Generic_List_BossInviteData__get_Count__);
		      if (DAT_ram_009d3e38 == 1) goto code_r0x80deeff1;
		      DAT_ram_00a5787c = '\x01';
		    }
		    param1_00 = *(undefined4 *)(*(int *)(iVar4 + 0x2c) + 0xc);
		    DAT_ram_009d3e38 = 0;
		    uVar1 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x371,iVar4,auStack_20);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80deeff1;
		    if (*(int *)(System_Math_TypeInfo + 0x74) == 0) {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi
		                (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,System_Math_TypeInfo);
		      if (DAT_ram_009d3e38 == 1) goto code_r0x80deeff1;
		    }
		    DAT_ram_009d3e38 = 0;
		    iVar4 = UnityEngine_Mathf__Max(param1_00,uVar1,0);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80deeff1;
		    iVar5 = iVar4 + iVar5;
		  } while( true );
		}
		*/


		/* --- GHIDRA: set_Game ---
		void Gameplay_Boss_Model_BossModel__set_Game
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5788a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_long__BossInstance___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_Dictionary_long__BossInstance__TypeInfo);
		    DAT_ram_00a5788a = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (System_Collections_Generic_Dictionary_long__BossInstance__TypeInfo);
		  System_Collections_Generic_Dictionary_long__InvocationDefinition___set_Item
		            (param1_00,Method_System_Collections_Generic_Dictionary_long__BossInstance___ctor__);
		  *(undefined4 *)(param1 + 0xc) = param1_00;
		  Unity_Services_Core_Environments_Internal_Environments__get_Current(param1,param3,0);
		  *(undefined4 *)(param1 + 0x14) = param2;
		  return;
		}
		*/


		/* --- GHIDRA: set_CurrentCreateRequest ---
		undefined4
		Gameplay_Boss_Model_BossModel__set_CurrentCreateRequest(int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5788b == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Boss_Model_BossInstance_TypeInfo);
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_long__BossInstance__ContainsKey__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_long__BossInstance__get_Item__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_long__BossInstance__set_Item__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3967);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3965);
		    DAT_ram_00a5788b = '\x01';
		  }
		  iVar1 = System_Collections_Generic_Dictionary_long__InvocationDefinition___Clear
		                    (*(undefined4 *)(param1 + 0xc),*(undefined8 *)(param2 + 0x10),
		                     Method_System_Collections_Generic_Dictionary_long__BossInstance__ContainsKey__)
		  ;
		  local_8 = *(undefined8 *)(param2 + 0x10);
		  if (iVar1 == 0) {
		    uVar2 = func_ii_1081(DAT_ram_00a66964,&local_8);
		    uVar2 = func_ii_4419(StringLiteral_3967,uVar2,0);
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    System_Collections_Generic_Dictionary_uint__object___get_Count(uVar2,0);
		    iVar1 = unnamed_function_1417(Gameplay_Boss_Model_BossInstance_TypeInfo);
		    Gameplay_Boss_Model_BossInstance___ctor(iVar1,param2);
		    Gameplay_Boss_Controller_BossController__AddBoss(*(undefined4 *)(iVar1 + 8),param2,param2);
		    MVC_AbstractController__Dispose(*(undefined4 *)(iVar1 + 0xc),0);
		    System_Collections_Generic_Dictionary_long__object___get_Values
		              (*(undefined4 *)(param1 + 0xc),*(undefined8 *)(param2 + 0x10),iVar1,
		               Method_System_Collections_Generic_Dictionary_long__BossInstance__set_Item__);
		    uVar2 = System_Collections_Generic_Dictionary_long__object___ContainsKey
		                      (*(undefined4 *)(param1 + 0xc),*(undefined8 *)(param2 + 0x10),
		                       Method_System_Collections_Generic_Dictionary_long__BossInstance__get_Item__);
		  }
		  else {
		    uVar2 = func_ii_1081(DAT_ram_00a66964,&local_8);
		    uVar2 = func_ii_4419(StringLiteral_3965,uVar2,0);
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    func_ii_7830(uVar2,0);
		    uVar2 = System_Collections_Generic_Dictionary_long__object___ContainsKey
		                      (*(undefined4 *)(param1 + 0xc),*(undefined8 *)(param2 + 0x10),
		                       Method_System_Collections_Generic_Dictionary_long__BossInstance__get_Item__);
		  }
		  return uVar2;
		}
		*/

}
