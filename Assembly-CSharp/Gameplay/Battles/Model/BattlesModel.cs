using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Dict;
using Core.Gameplay;
using Core.Gameplay.Managers.Requirements;
using Il2CppDummyDll;
using MVC;
using Protocol.Common;

namespace Gameplay.Battles.Model
{
	// Token: 0x02000C2C RID: 3116
	[Token(Token = "0x2000C2C")]
	public class BattlesModel : AbstractModel
	{
		// Token: 0x06004BFB RID: 19451 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BFB")]
		[Address(RVA = "0x9A3F", Offset = "0x9A3F", VA = "0x9A3F")]
		public BattlesModel(uint[] userLevelsForNotification, IGame game, IRequirementValidator requirementValidator, IDictProvider dictProvider, UserData user)
		{
		}

		// Token: 0x17000F53 RID: 3923
		// (get) Token: 0x06004BFC RID: 19452 RVA: 0x0000E010 File Offset: 0x0000C210
		// (set) Token: 0x06004BFD RID: 19453 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000F53")]
		public int NotificationCount
		{
			[Token(Token = "0x6004BFC")]
			[Address(RVA = "0x9A40", Offset = "0x9A40", VA = "0x9A40")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6004BFD")]
			[Address(RVA = "0x9A41", Offset = "0x9A41", VA = "0x9A41")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06004BFE RID: 19454 RVA: 0x0000E028 File Offset: 0x0000C228
		[Token(Token = "0x6004BFE")]
		[Address(RVA = "0x9A42", Offset = "0x9A42", VA = "0x9A42")]
		public bool IsLickedByRestrictions(uint uiElementId, out IEnumerable<RestrictionInfo> ReasonRestrictions)
		{
			return default(bool);
		}

		// Token: 0x04002964 RID: 10596
		[Token(Token = "0x4002964")]
		[FieldOffset(Offset = "0xC")]
		public readonly IGame Game;

		// Token: 0x04002965 RID: 10597
		[Token(Token = "0x4002965")]
		[FieldOffset(Offset = "0x10")]
		public readonly IRequirementValidator RequirementValidator;

		// Token: 0x04002966 RID: 10598
		[Token(Token = "0x4002966")]
		[FieldOffset(Offset = "0x14")]
		public readonly IDictProvider DictProvider;

		// Token: 0x04002967 RID: 10599
		[Token(Token = "0x4002967")]
		[FieldOffset(Offset = "0x18")]
		public readonly uint[] UserLevelsForNotification;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_NotificationCount ---
		uint Gameplay_Battles_Model_BattlesModel__set_NotificationCount
		               (int param1,int param2,undefined4 *param3,undefined4 param4)
		
		{
		  uint uVar1;
		  uint uVar2;
		  uint *puVar3;
		  undefined4 *puVar4;
		  undefined4 uVar5;
		  int iVar6;
		  undefined4 uVar7;
		  int *piVar8;
		  int iVar9;
		  int *piVar10;
		  int iVar11;
		  int local_c;
		  int **local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a60975 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerator_UIElementsDic__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Core_Gameplay_Managers_Requirements_IRequirementValidator_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_UIElementsDic__GetEnumerator__);
		    DAT_ram_00a60975 = '\x01';
		  }
		  piVar8 = *(int **)(param1 + 0x14);
		  iVar9 = *piVar8;
		  if (*(ushort *)(iVar9 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8 + 4) * 8 + iVar9 + 0xd0);
		        goto code_r0x81d07107;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar9 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar8,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x81d07107:
		  iVar9 = (**(code **)((ulonglong)*puVar3 * 4))(piVar8,puVar3[1]);
		  local_4 = (int *)Google_Protobuf_Collections_RepeatedField_float___Equals
		                             (*(undefined4 *)(iVar9 + 0x1c8),
		                              Method_Google_Protobuf_Collections_RepeatedField_UIElementsDic__GetEnumerator__
		                             );
		  local_c = 0;
		  local_8 = &local_4;
		  do {
		    piVar8 = local_4;
		    iVar9 = *local_4;
		    if (*(ushort *)(iVar9 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar10 = (int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar10) {
		          puVar4 = (undefined4 *)(iVar9 + piVar10[1] * 8 + 0xc0);
		          goto code_r0x81d071ed;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar9 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar4 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_IEnumerator_TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x81d0723d:
		      DAT_ram_009d3e38 = 0;
		      uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81d07444;
		    }
		code_r0x81d071ed:
		    DAT_ram_009d3e38 = 0;
		    iVar9 = import::env::invoke_iii(*puVar4,piVar8,puVar4[1]);
		    piVar8 = local_4;
		    if (DAT_ram_009d3e38 == 1) goto code_r0x81d0723d;
		    if (iVar9 == 0) {
		      iVar9 = 0;
		      iVar6 = 5;
		      uVar1 = 0;
		      goto code_r0x81d07495;
		    }
		    iVar9 = *local_4;
		    if (*(ushort *)(iVar9 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar10 = (int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8);
		        if (System_Collections_Generic_IEnumerator_UIElementsDic__TypeInfo == *piVar10) {
		          puVar4 = (undefined4 *)(iVar9 + piVar10[1] * 8 + 0xc0);
		          goto code_r0x81d072e0;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar9 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar4 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_Generic_IEnumerator_UIElementsDic__TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x81d0743c:
		      DAT_ram_009d3e38 = 0;
		      uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81d07444;
		    }
		code_r0x81d072e0:
		    DAT_ram_009d3e38 = 0;
		    iVar9 = import::env::invoke_iii(*puVar4,piVar8,puVar4[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x81d0743c;
		  } while (*(int *)(iVar9 + 0xc) != param2);
		  *param3 = *(undefined4 *)(iVar9 + 0x14);
		  uVar1 = 0;
		  uVar5 = *(undefined4 *)(param1 + 8);
		  uVar7 = *(undefined4 *)(iVar9 + 0x14);
		  piVar8 = *(int **)(param1 + 0x10);
		  iVar9 = *piVar8;
		  if (*(ushort *)(iVar9 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_Managers_Requirements_IRequirementValidator_TypeInfo ==
		          *(int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8)) {
		        puVar4 = (undefined4 *)(*(int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8 + 4) * 8 + iVar9 + 0xd0)
		        ;
		        goto code_r0x81d073df;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar9 + 0xb6) != uVar1);
		  }
		  DAT_ram_009d3e38 = 0;
		  puVar4 = (undefined4 *)
		           import::env::invoke_iiii
		                     (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar8,
		                      Core_Gameplay_Managers_Requirements_IRequirementValidator_TypeInfo,2);
		  if (DAT_ram_009d3e38 != 1) {
		code_r0x81d073df:
		    iVar9 = 0;
		    DAT_ram_009d3e38 = 0;
		    uVar1 = import::env::invoke_iiiii(*puVar4,piVar8,uVar7,uVar5,puVar4[1]);
		    if (DAT_ram_009d3e38 != 1) {
		      uVar1 = uVar1 ^ 1;
		      iVar6 = 4;
		      goto code_r0x81d07495;
		    }
		  }
		  DAT_ram_009d3e38 = 0;
		  uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x81d07444:
		  iVar9 = global_1;
		  iVar6 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar9 == iVar6) {
		    piVar8 = (int *)import::env::__cxa_begin_catch(uVar5);
		    iVar9 = *piVar8;
		    iVar6 = 0;
		    DAT_ram_009d3e38 = 0;
		    local_c = iVar9;
		    import::env::invoke_v(0x123);
		    iVar11 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    uVar1 = 0;
		    if (iVar11 != 1) {
		code_r0x81d07495:
		      piVar8 = local_4;
		      DAT_ram_009d3e38 = 0;
		      if (local_4 != (int *)0x0) {
		        uVar2 = 0;
		        iVar11 = *local_4;
		        if (*(ushort *)(iVar11 + 0xb6) != 0) {
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar11 + 0x58) + uVar2 * 8)) {
		              puVar3 = (uint *)(iVar11 + *(int *)(*(int *)(iVar11 + 0x58) + uVar2 * 8 + 4) * 8 +
		                               0xc0);
		              goto code_r0x81d0750d;
		            }
		            uVar2 = uVar2 + 1;
		          } while (*(ushort *)(iVar11 + 0xb6) != uVar2);
		        }
		        puVar3 = (uint *)func_ii_1080(local_4,System_IDisposable_TypeInfo,0);
		code_r0x81d0750d:
		        (**(code **)((ulonglong)*puVar3 * 4))(piVar8,puVar3[1]);
		      }
		      if (iVar9 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(iVar9);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      if ((iVar6 != 0) &&
		         ((((iVar6 == 1 || (iVar6 == 2)) || (iVar6 == 3)) || ((iVar6 == 4 || (iVar6 != 5)))))) {
		        return uVar1;
		      }
		      local_c = param2;
		      uVar5 = func_ii_1081(DAT_ram_00a66958,&local_c);
		      uVar7 = unnamed_function_2232(&StringLiteral_16856);
		      uVar5 = func_ii_4419(uVar7,uVar5,0);
		      uVar7 = unnamed_function_2232(&System_Exception_TypeInfo);
		      uVar7 = unnamed_function_1417(uVar7);
		      System_String__Concat(uVar7,uVar5,0);
		      uVar5 = unnamed_function_2232
		                        (&Method_Gameplay_Battles_Model_BattlesModel_IsLickedByRestrictions__);
		      func_ii_1050(uVar7,uVar5);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar5 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s___Scripting__UnityEngine__Playab_ram_000036f4 + 0x25,&local_c);
		  iVar9 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar9 != 1) {
		    import::env::__resumeException(uVar5);
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
