using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Gameplay.Combat.Model;
using Il2CppDummyDll;
using Utils;

namespace Gameplay.BlitzTournament.Model
{
	// Token: 0x02000BD1 RID: 3025
	[Token(Token = "0x2000BD1")]
	public class BlitzTournamentCombatModel : CombatModel
	{
		// Token: 0x06004A1F RID: 18975 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A1F")]
		[Address(RVA = "0x9881", Offset = "0x9881", VA = "0x9881")]
		public BlitzTournamentCombatModel(CombatDependencies dependencies, BackTime awaitBackTime, UserData loggedUser, UserData user)
		{
		}

		// Token: 0x17000EFE RID: 3838
		// (get) Token: 0x06004A20 RID: 18976 RVA: 0x0000DA58 File Offset: 0x0000BC58
		// (set) Token: 0x06004A21 RID: 18977 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000EFE")]
		public ulong LoserId
		{
			[Token(Token = "0x6004A20")]
			[Address(RVA = "0x9882", Offset = "0x9882", VA = "0x9882")]
			[CompilerGenerated]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x6004A21")]
			[Address(RVA = "0x9883", Offset = "0x9883", VA = "0x9883")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000EFF RID: 3839
		// (get) Token: 0x06004A22 RID: 18978 RVA: 0x0000DA70 File Offset: 0x0000BC70
		// (set) Token: 0x06004A23 RID: 18979 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000EFF")]
		public ulong WinnerId
		{
			[Token(Token = "0x6004A22")]
			[Address(RVA = "0x9884", Offset = "0x9884", VA = "0x9884")]
			[CompilerGenerated]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x6004A23")]
			[Address(RVA = "0x9885", Offset = "0x9885", VA = "0x9885")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000F00 RID: 3840
		// (get) Token: 0x06004A24 RID: 18980 RVA: 0x0000DA88 File Offset: 0x0000BC88
		[Token(Token = "0x17000F00")]
		public ulong OpponentId
		{
			[Token(Token = "0x6004A24")]
			[Address(RVA = "0x9886", Offset = "0x9886", VA = "0x9886")]
			get
			{
				return 0UL;
			}
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_WinnerId ---
		void Gameplay_BlitzTournament_Model_BlitzTournamentCombatModel__get_WinnerId
		               (int param1,undefined8 param2,undefined4 param3)
		
		{
		  *(undefined8 *)(param1 + 0x68) = param2;
		  return;
		}
		*/


		/* --- GHIDRA: set_WinnerId ---
		longlong Gameplay_BlitzTournament_Model_BlitzTournamentCombatModel__set_WinnerId
		                   (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  longlong lVar2;
		  int iVar3;
		  undefined4 uVar4;
		  int *piVar5;
		  longlong lVar6;
		  int local_30;
		  undefined8 *local_2c;
		  undefined8 local_28;
		  undefined8 local_20;
		  longlong local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a608ae == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_ulong__CombatPlayer__GetEnumerator__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_Enumerator_ulong__CombatPlayer__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_Enumerator_ulong__CombatPlayer__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_Enumerator_ulong__CombatPlayer__get_Current__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_KeyValuePair_ulong__CombatPlayer__get_Key__);
		    DAT_ram_00a608ae = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  local_18 = 0;
		  local_20 = 0;
		  local_28 = 0;
		  System_Collections_Generic_Dictionary_ulong__ulong___FindEntry
		            (&local_28,param1[7],
		             Method_System_Collections_Generic_Dictionary_ulong__CombatPlayer__GetEnumerator__);
		  local_30 = 0;
		  local_2c = &local_28;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar3 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x2d5,&local_28,
		                       Method_System_Collections_Generic_Dictionary_Enumerator_ulong__CombatPlayer__MoveNext__
		                      );
		    lVar2 = local_18;
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 == 1) {
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x81cf3d7d:
		      iVar1 = global_1;
		      iVar3 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar1 == iVar3) {
		        piVar5 = (int *)import::env::__cxa_begin_catch(uVar4);
		        iVar3 = *piVar5;
		        DAT_ram_009d3e38 = 0;
		        local_30 = iVar3;
		        import::env::invoke_v(0x123);
		        iVar1 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar1 != 1) {
		          if (iVar3 == 0) {
		            DAT_ram_009d3e38 = 0;
		            return 0;
		          }
		          System_Data_DataSet__ValidateLocaleConstraint(iVar3);
		          do {
		            halt_trap();
		          } while( true );
		        }
		        uVar4 = import::env::__cxa_find_matching_catch_2();
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s___Scripting__UnityEngine__Playab_ram_000036f4 + 0xb,&local_30);
		      iVar1 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar1 != 1) {
		        import::env::__resumeException(uVar4);
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
		    if (iVar3 == 0) {
		      DAT_ram_009d3e38 = 0;
		      return 0;
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar4 = import::env::invoke_iii
		                      (*(undefined4 *)(*param1 + 0x100),param1,*(undefined4 *)(*param1 + 0x104));
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 == 1) {
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81cf3d7d;
		    }
		    DAT_ram_009d3e38 = 0;
		    lVar6 = unnamed_function_184054(s_struct_Uniforms___color__array<v_ram_000017c8 + 0x357,uVar4,0)
		    ;
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 == 1) {
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81cf3d7d;
		    }
		    if (lVar2 != lVar6) {
		      DAT_ram_009d3e38 = 0;
		      return lVar2;
		    }
		  } while( true );
		}
		*/

}
