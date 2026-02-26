using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Protocol.Common;

namespace Utils.Accumulators
{
	// Token: 0x0200007D RID: 125
	[Token(Token = "0x200007D")]
	public class TriggersAccumulator : AccumulatorBase<int, TriggerValue>
	{
		// Token: 0x0600038A RID: 906 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600038A")]
		[Address(RVA = "0x57BC", Offset = "0x57BC", VA = "0x57BC")]
		public TriggersAccumulator(float seconds)
		{
		/* --- GHIDRA: .ctor ---
		undefined4
		Utils_Accumulators_TriggersAccumulator___ctor
		          (int param1,undefined4 param2,int *param3,undefined4 param4)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a62853 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_int__TriggerValue__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_int__TriggerValue__TryGetValue__);
		    Mono_Security_ASN1__get_Item(&Protocol_Common_TriggerValue_TypeInfo);
		    DAT_ram_00a62853 = '\x01';
		  }
		  iVar1 = System_Collections_Generic_List_Enumerator_int___MoveNext
		                    (*(undefined4 *)(param1 + 0x18),param2,param3,
		                     Method_System_Collections_Generic_Dictionary_int__TriggerValue__TryGetValue__);
		  if (iVar1 == 0) {
		    iVar1 = unnamed_function_1417(Protocol_Common_TriggerValue_TypeInfo);
		    *(undefined4 *)(iVar1 + 0xc) = param2;
		    *param3 = iVar1;
		    UnityEngine_Object__GetInstanceID
		              (*(undefined4 *)(param1 + 0x18),param2,iVar1,
		               Method_System_Collections_Generic_Dictionary_int__TriggerValue__Add__);
		  }
		  return 1;
		}
		*/

		}

		// Token: 0x0600038B RID: 907 RVA: 0x00002D60 File Offset: 0x00000F60
		[Token(Token = "0x600038B")]
		[Address(RVA = "0x57BD", Offset = "0x57BD", VA = "0x57BD", Slot = "8")]
		public override bool TryGetValue(int triggerId, out TriggerValue trigger)
		{
		/* --- GHIDRA: TryGetValue ---
		uint Utils_Accumulators_TriggersAccumulator__TryGetValue
		               (int param1,int *param2,int *param3,undefined4 param4)
		
		{
		  uint *puVar1;
		  undefined4 *puVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 param1_00;
		  int iVar5;
		  int *piVar6;
		  longlong lVar7;
		  int *piVar8;
		  longlong lVar9;
		  int iVar10;
		  uint uVar11;
		  int local_10;
		  int **local_c;
		  int local_8;
		  int *local_4;
		  
		  iVar4 = 0;
		  if (DAT_ram_00a62854 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_int__TriggerValue__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_int__TriggerValue__TryGetValue__);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerable_TriggerValue__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerator_TriggerValue__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_TriggerValue__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_TriggerValue___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_TriggerValue__TypeInfo);
		    DAT_ram_00a62854 = '\x01';
		  }
		  local_8 = 0;
		  iVar10 = *param2;
		  if (*(ushort *)(iVar10 + 0xb6) != 0) {
		    uVar11 = 0;
		    do {
		      if (System_Collections_Generic_IEnumerable_TriggerValue__TypeInfo ==
		          *(int *)(*(int *)(iVar10 + 0x58) + uVar11 * 8)) {
		        puVar1 = (uint *)(iVar10 + *(int *)(*(int *)(iVar10 + 0x58) + uVar11 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x820f96d8;
		      }
		      uVar11 = uVar11 + 1;
		    } while (*(ushort *)(iVar10 + 0xb6) != uVar11);
		  }
		  puVar1 = (uint *)func_ii_1080(param2,System_Collections_Generic_IEnumerable_TriggerValue__TypeInfo
		                                ,0);
		code_r0x820f96d8:
		  local_4 = (int *)(**(code **)((ulonglong)*puVar1 * 4))(param2,puVar1[1]);
		  local_10 = 0;
		  local_c = &local_4;
		code_r0x820f970f:
		  do {
		    piVar6 = local_4;
		    iVar10 = *local_4;
		    if (*(ushort *)(iVar10 + 0xb6) != 0) {
		      uVar11 = 0;
		      do {
		        piVar8 = (int *)(*(int *)(iVar10 + 0x58) + uVar11 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar8) {
		          puVar2 = (undefined4 *)(iVar10 + piVar8[1] * 8 + 0xc0);
		          goto code_r0x820f97a8;
		        }
		        uVar11 = uVar11 + 1;
		      } while (*(ushort *)(iVar10 + 0xb6) != uVar11);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar2 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_IEnumerator_TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x820f9ab8:
		      DAT_ram_009d3e38 = 0;
		      param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x820f9ac0;
		    }
		code_r0x820f97a8:
		    DAT_ram_009d3e38 = 0;
		    iVar10 = import::env::invoke_iii(*puVar2,piVar6,puVar2[1]);
		    piVar6 = local_4;
		    if (DAT_ram_009d3e38 == 1) goto code_r0x820f9ab8;
		    if (iVar10 == 0) {
		      iVar10 = 7;
		      goto code_r0x820f9b0d;
		    }
		    iVar10 = *local_4;
		    if (*(ushort *)(iVar10 + 0xb6) != 0) {
		      uVar11 = 0;
		      do {
		        piVar8 = (int *)(*(int *)(iVar10 + 0x58) + uVar11 * 8);
		        if (System_Collections_Generic_IEnumerator_TriggerValue__TypeInfo == *piVar8) {
		          puVar2 = (undefined4 *)(iVar10 + piVar8[1] * 8 + 0xc0);
		          goto code_r0x820f988e;
		        }
		        uVar11 = uVar11 + 1;
		      } while (*(ushort *)(iVar10 + 0xb6) != uVar11);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar2 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_Generic_IEnumerator_TriggerValue__TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x820f993d:
		      DAT_ram_009d3e38 = 0;
		      param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x820f9ac0;
		    }
		code_r0x820f988e:
		    DAT_ram_009d3e38 = 0;
		    iVar10 = import::env::invoke_iii(*puVar2,piVar6,puVar2[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x820f993d;
		    DAT_ram_009d3e38 = 0;
		    iVar3 = import::env::invoke_iiiii
		                      (s_struct_Uniforms___color__array<v_ram_000013c7 + 0x217,
		                       *(undefined4 *)(param1 + 0x18),*(undefined4 *)(iVar10 + 0xc),&local_8,
		                       Method_System_Collections_Generic_Dictionary_int__TriggerValue__TryGetValue__
		                      );
		    iVar5 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar5 == 1) {
		      param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x820f9ac0;
		    }
		    if (iVar3 == 0) {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_viiii
		                (s_struct_Uniforms___color__array<v_ram_00000aff + 0x259,
		                 *(undefined4 *)(param1 + 0x18),*(undefined4 *)(iVar10 + 0xc),iVar10,
		                 Method_System_Collections_Generic_Dictionary_int__TriggerValue__Add__);
		      iVar5 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar5 == 1) {
		        param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x820f9ac0;
		      }
		    }
		    else {
		      lVar7 = *(longlong *)(local_8 + 0x10);
		      lVar9 = *(longlong *)(iVar10 + 0x10);
		      *(longlong *)(local_8 + 0x10) = lVar9;
		      iVar10 = local_8;
		      if (lVar7 == lVar9) goto code_r0x820f970f;
		    }
		    if (iVar4 == 0) {
		      DAT_ram_009d3e38 = 0;
		      iVar4 = import::env::invoke_ii
		                        (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                         System_Collections_Generic_List_TriggerValue__TypeInfo);
		      if (DAT_ram_009d3e38 != 1) {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vii
		                  (s_struct_Uniforms___color__array<v_ram_00000aff + 0x252,iVar4,
		                   Method_System_Collections_Generic_List_TriggerValue___ctor__);
		        if (DAT_ram_009d3e38 != 1) goto code_r0x820f9a21;
		      }
		      DAT_ram_009d3e38 = 0;
		      iVar4 = 0;
		      param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x820f9ac0;
		    }
		code_r0x820f9a21:
		    iVar5 = Method_System_Collections_Generic_List_TriggerValue__Add__;
		    *(int *)(iVar4 + 0x10) = *(int *)(iVar4 + 0x10) + 1;
		    uVar11 = *(uint *)(iVar4 + 0xc);
		    if (uVar11 < *(uint *)(*(int *)(iVar4 + 8) + 0xc)) {
		      *(uint *)(iVar4 + 0xc) = uVar11 + 1;
		      *(int *)(*(int *)(iVar4 + 8) + uVar11 * 4 + 0x10) = iVar10;
		      goto code_r0x820f970f;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,iVar4,iVar10,
		               *(undefined4 *)(*(int *)(*(int *)(iVar5 + 0x10) + 0x60) + 0x38));
		    iVar10 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		  } while (iVar10 != 1);
		  param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x820f9ac0:
		  iVar10 = global_1;
		  iVar5 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar10 == iVar5) {
		    piVar6 = (int *)import::env::__cxa_begin_catch(param1_00);
		    local_10 = *piVar6;
		    iVar10 = 0;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_v(0x123);
		    iVar5 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar5 != 1) {
		code_r0x820f9b0d:
		      DAT_ram_009d3e38 = 0;
		      piVar6 = *local_c;
		      if (piVar6 != (int *)0x0) {
		        uVar11 = 0;
		        iVar5 = *piVar6;
		        if (*(ushort *)(iVar5 + 0xb6) != 0) {
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar11 * 8)) {
		              puVar1 = (uint *)(iVar5 + *(int *)(*(int *)(iVar5 + 0x58) + uVar11 * 8 + 4) * 8 + 0xc0
		                               );
		              goto code_r0x820f9b88;
		            }
		            uVar11 = uVar11 + 1;
		          } while (*(ushort *)(iVar5 + 0xb6) != uVar11);
		        }
		        puVar1 = (uint *)func_ii_1080(piVar6,System_IDisposable_TypeInfo,0);
		code_r0x820f9b88:
		        (**(code **)((ulonglong)*puVar1 * 4))(piVar6,puVar1[1]);
		      }
		      if (local_10 == 0) {
		        if ((iVar10 == 0) ||
		           ((((uVar11 = 0, iVar10 != 1 && (iVar10 != 2)) && (iVar10 != 3)) &&
		            (((iVar10 != 4 && (iVar10 != 5)) && ((iVar10 != 6 && (iVar10 == 7)))))))) {
		          *param3 = iVar4;
		          uVar11 = (uint)(iVar4 != 0);
		        }
		        return uVar11;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(local_10);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    param1_00 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s___Scripting__UnityEngine__Raycas_ram_00004083 + 0x1f,&local_10);
		  iVar4 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar4 != 1) {
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

			return default(bool);
		}

		// Token: 0x0600038C RID: 908 RVA: 0x00002D78 File Offset: 0x00000F78
		[Token(Token = "0x600038C")]
		[Address(RVA = "0x57BE", Offset = "0x57BE", VA = "0x57BE", Slot = "7")]
		protected override bool TryUpdateOrCreate(IEnumerable<TriggerValue> collection, out IEnumerable<TriggerValue> changes)
		{
		/* --- GHIDRA: TryUpdateOrCreate ---
		void Utils_Accumulators_TriggersAccumulator__TryUpdateOrCreate(int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a62855 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Utils_Accumulators_AccumulatorBase_int__TriggerValue__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_int__TriggerValue__Clear__);
		    DAT_ram_00a62855 = '\x01';
		  }
		  Utils_Accumulators_AccumulatorBase_int__object____ctor
		            (param1,Method_Utils_Accumulators_AccumulatorBase_int__TriggerValue__Dispose__);
		  System_Xml_XmlWellFormedWriter__PushNamespaceImplicit
		            (*(undefined4 *)(param1 + 0x18),
		             Method_System_Collections_Generic_Dictionary_int__TriggerValue__Clear__);
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x0600038D RID: 909 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600038D")]
		[Address(RVA = "0x57BF", Offset = "0x57BF", VA = "0x57BF", Slot = "6")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Utils_Accumulators_TriggersAccumulator__Dispose(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a62856 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_long__TypeInfo);
		    DAT_ram_00a62856 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x18);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_long__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_long__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x18,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x04000193 RID: 403
		[Token(Token = "0x4000193")]
		[FieldOffset(Offset = "0x18")]
		private readonly Dictionary<int, TriggerValue> _triggers;
	}
}
