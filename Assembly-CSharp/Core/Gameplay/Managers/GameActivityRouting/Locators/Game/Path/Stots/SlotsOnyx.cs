using System;
using Core.Rounting;
using Il2CppDummyDll;
using Utils;

namespace Core.Gameplay.Managers.GameActivityRouting.Locators.Game.Path.Stots
{
	// Token: 0x020011EB RID: 4587
	[Token(Token = "0x20011EB")]
	public class SlotsOnyx : AbstractPathNode
	{
		// Token: 0x06006CF3 RID: 27891 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CF3")]
		[Address(RVA = "0xB7DF", Offset = "0xB7DF", VA = "0xB7DF", Slot = "5")]
		protected override void ExecuteTransition(IGame game, OpToken<LocatorPayload, AbstractPathNode> token, LocatorPayload payload)
		{
		}

		// Token: 0x06006CF4 RID: 27892 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CF4")]
		[Address(RVA = "0xB7E0", Offset = "0xB7E0", VA = "0xB7E0", Slot = "6")]
		protected override void TransitionCanceled()
		{
		/* --- GHIDRA: TransitionCanceled ---
		void Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Stots_SlotsOnyx__TransitionCanceled
		               (undefined4 param1,undefined4 param2)
		
		{
		  Core_Rounting_AbstractPathNode__Dispose(param1,0);
		  return;
		}
		*/

		}

		// Token: 0x06006CF5 RID: 27893 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006CF5")]
		[Address(RVA = "0xB7E1", Offset = "0xB7E1", VA = "0xB7E1")]
		public SlotsOnyx()
		{
		/* --- GHIDRA: .ctor ---
		undefined4
		Core_Gameplay_Managers_GameActivityRouting_Locators_Game_Path_Stots_SlotsOnyx___ctor
		          (int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int *param1_00;
		  undefined4 uVar2;
		  int iVar3;
		  undefined4 *puVar4;
		  int *piVar5;
		  int iVar6;
		  int *piVar7;
		  int local_18;
		  undefined8 *local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5a733 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__IPathNodeFactory__get_Values__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_string__IPathNodeFactory__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_string__IPathNodeFactory__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_string__IPathNodeFactory__get_Current__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Rounting_IPathNodeFactory_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Text_StringBuilder_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_string__IPathNodeFactory__GetEnumerator__
		              );
		    Mono_Security_ASN1__get_Item(&StringLiteral_1702);
		    DAT_ram_00a5a733 = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  param1_00 = (int *)unnamed_function_1417(System_Text_StringBuilder_TypeInfo);
		  func_ii_2101(param1_00,0);
		  uVar2 = System_Collections_Generic_Dictionary_int__object___TryAdd
		                    (*(undefined4 *)(param1 + 8),
		                     Method_System_Collections_Generic_Dictionary_string__IPathNodeFactory__get_Values__
		                    );
		  System_Collections_Generic_Dictionary_Int32Enum__object___get_Values
		            (&local_10,uVar2,
		             Method_System_Collections_Generic_Dictionary_ValueCollection_string__IPathNodeFactory__GetEnumerator__
		            );
		  local_18 = 0;
		  local_14 = &local_10;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar3 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000f84 + 0x1a2,&local_10,
		                       Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_string__IPathNodeFactory__MoveNext__
		                      );
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81264042;
		    }
		    if (iVar3 == 0) goto code_r0x81264098;
		    piVar5 = local_8._4_4_;
		    iVar6 = *local_8._4_4_;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar7 = (int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8);
		        if (Core_Rounting_IPathNodeFactory_TypeInfo == *piVar7) {
		          puVar4 = (undefined4 *)(iVar6 + piVar7[1] * 8 + 0xc0);
		          goto code_r0x81263f67;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar4 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_8._4_4_,
		                        Core_Rounting_IPathNodeFactory_TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x8126401c:
		      DAT_ram_009d3e38 = 0;
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81264042;
		    }
		code_r0x81263f67:
		    DAT_ram_009d3e38 = 0;
		    uVar2 = import::env::invoke_iii(*puVar4,piVar5,puVar4[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x8126401c;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_iiii
		              (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x186,param1_00,uVar2,0);
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81264042;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_iiii
		              (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x186,param1_00,StringLiteral_1702,
		               0);
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		  } while (iVar6 != 1);
		  uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x81264042:
		  iVar6 = global_1;
		  iVar3 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar6 == iVar3) {
		    piVar5 = (int *)import::env::__cxa_begin_catch(uVar2);
		    iVar3 = *piVar5;
		    DAT_ram_009d3e38 = 0;
		    local_18 = iVar3;
		    import::env::invoke_v(0x123);
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 != 1) {
		      if (iVar3 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(iVar3);
		        do {
		          halt_trap();
		        } while( true );
		      }
		code_r0x81264098:
		      DAT_ram_009d3e38 = 0;
		      uVar2 = (**(code **)((ulonglong)*(uint *)(*param1_00 + 0xd8) * 4))
		                        (param1_00,*(undefined4 *)(*param1_00 + 0xdc));
		      return uVar2;
		    }
		    uVar2 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001f04 + 0x330,&local_18);
		  iVar6 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar6 == 1) {
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  import::env::__resumeException(uVar2);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}
	}
}
