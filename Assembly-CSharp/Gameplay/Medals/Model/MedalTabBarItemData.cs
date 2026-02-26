using System;
using Il2CppDummyDll;

namespace Gameplay.Medals.Model
{
	// Token: 0x02000602 RID: 1538
	[Token(Token = "0x2000602")]
	public class MedalTabBarItemData
	{
		// Token: 0x0600255A RID: 9562 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600255A")]
		[Address(RVA = "0x76A1", Offset = "0x76A1", VA = "0x76A1")]
		public MedalTabBarItemData()
		{
		/* --- GHIDRA: .ctor ---
		int Gameplay_Medals_Model_MedalTabBarItemData___ctor(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 *puVar2;
		  undefined4 param1_00;
		  int iVar3;
		  int *piVar4;
		  uint *puVar5;
		  int iVar6;
		  int *piVar7;
		  int iVar8;
		  int local_c;
		  int **local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a57da9 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerator_RewardInfo__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_RewardTypes__IndexOf__);
		    Mono_Security_ASN1__get_Item(&Gameplay_Medals_Model_MedalUtils_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_RewardInfo__GetEnumerator__);
		    DAT_ram_00a57da9 = '\x01';
		  }
		  local_4 = (int *)Google_Protobuf_Collections_RepeatedField_float___Equals
		                             (*(undefined4 *)(param1 + 0x28),
		                              Method_Google_Protobuf_Collections_RepeatedField_RewardInfo__GetEnumerator__
		                             );
		  local_c = 0;
		  local_8 = &local_4;
		  do {
		    piVar4 = local_4;
		    iVar6 = *local_4;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar7 = (int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar7) {
		          puVar2 = (undefined4 *)(iVar6 + piVar7[1] * 8 + 0xc0);
		          goto code_r0x80e5bf8d;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar2 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_IEnumerator_TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80e5bfd9:
		      DAT_ram_009d3e38 = 0;
		      param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80e5c16a:
		      iVar6 = global_1;
		      iVar3 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar6 == iVar3) {
		        piVar4 = (int *)import::env::__cxa_begin_catch(param1_00);
		        iVar3 = *piVar4;
		        iVar6 = 0;
		        DAT_ram_009d3e38 = 0;
		        local_c = iVar3;
		        import::env::invoke_v(0x123);
		        iVar8 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar8 != 1) goto code_r0x80e5c1b7;
		        param1_00 = import::env::__cxa_find_matching_catch_2();
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x6f,&local_c);
		      iVar6 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar6 == 1) {
		        import::env::__cxa_find_matching_catch_3(0);
		        unnamed_function_937();
		        do {
		          halt_trap();
		        } while( true );
		      }
		      import::env::__resumeException(param1_00);
		      do {
		        halt_trap();
		      } while( true );
		    }
		code_r0x80e5bf8d:
		    DAT_ram_009d3e38 = 0;
		    iVar6 = import::env::invoke_iii(*puVar2,piVar4,puVar2[1]);
		    piVar4 = local_4;
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80e5bfd9;
		    if (iVar6 == 0) {
		      iVar3 = 0;
		      iVar6 = 0;
		      goto code_r0x80e5c1b7;
		    }
		    iVar3 = *local_4;
		    if (*(ushort *)(iVar3 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar7 = (int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8);
		        if (System_Collections_Generic_IEnumerator_RewardInfo__TypeInfo == *piVar7) {
		          puVar2 = (undefined4 *)(iVar3 + piVar7[1] * 8 + 0xc0);
		          goto code_r0x80e5c07c;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar2 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_Generic_IEnumerator_RewardInfo__TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80e5c158:
		      DAT_ram_009d3e38 = 0;
		      param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e5c16a;
		    }
		code_r0x80e5c07c:
		    DAT_ram_009d3e38 = 0;
		    iVar3 = import::env::invoke_iii(*puVar2,piVar4,puVar2[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80e5c158;
		    if (*(int *)(Gameplay_Medals_Model_MedalUtils_TypeInfo + 0x74) == 0) {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi
		                (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                 Gameplay_Medals_Model_MedalUtils_TypeInfo);
		      if (DAT_ram_009d3e38 == 1) goto code_r0x80e5c158;
		    }
		    DAT_ram_009d3e38 = 0;
		    iVar8 = import::env::invoke_iiii
		                      (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x6e,
		                       **(undefined4 **)(Gameplay_Medals_Model_MedalUtils_TypeInfo + 0x5c),
		                       *(undefined4 *)(iVar3 + 0xc),
		                       Method_System_Collections_Generic_List_RewardTypes__IndexOf__);
		    iVar3 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar3 == 1) {
		      param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e5c16a;
		    }
		  } while (-1 < iVar8);
		  iVar3 = 0;
		code_r0x80e5c1b7:
		  piVar4 = local_4;
		  DAT_ram_009d3e38 = 0;
		  if (local_4 != (int *)0x0) {
		    uVar1 = 0;
		    iVar8 = *local_4;
		    if (*(ushort *)(iVar8 + 0xb6) != 0) {
		      do {
		        if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		          puVar5 = (uint *)(iVar8 + *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x80e5c22f;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		    }
		    puVar5 = (uint *)func_ii_1080(local_4,System_IDisposable_TypeInfo,0);
		code_r0x80e5c22f:
		    (**(code **)((ulonglong)*puVar5 * 4))(piVar4,puVar5[1]);
		  }
		  if (iVar3 == 0) {
		    return iVar6;
		  }
		  System_Data_DataSet__ValidateLocaleConstraint(iVar3);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x04001472 RID: 5234
		[Token(Token = "0x4001472")]
		[FieldOffset(Offset = "0x8")]
		public MedalTabBarItemData.MedalTabType Type;

		// Token: 0x02000603 RID: 1539
		[Token(Token = "0x2000603")]
		public enum MedalTabType
		{
			// Token: 0x04001474 RID: 5236
			[Token(Token = "0x4001474")]
			All = 1,
			// Token: 0x04001475 RID: 5237
			[Token(Token = "0x4001475")]
			Type
		}
	}
}
