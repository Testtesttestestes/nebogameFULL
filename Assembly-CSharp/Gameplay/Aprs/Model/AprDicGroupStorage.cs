using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Dict;
using Core.Dict.DictWrappers.Wrappers;
using Il2CppDummyDll;

namespace Gameplay.Aprs.Model
{
	// Token: 0x02000D63 RID: 3427
	[Token(Token = "0x2000D63")]
	public class AprDicGroupStorage : IDisposable
	{
		// Token: 0x17001118 RID: 4376
		// (get) Token: 0x06005405 RID: 21509 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005406 RID: 21510 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001118")]
		public Dictionary<uint, AprDicGroup> AprDicGroupsByMedalId
		{
			[Token(Token = "0x6005405")]
			[Address(RVA = "0xA1BC", Offset = "0xA1BC", VA = "0xA1BC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005406")]
			[Address(RVA = "0xA1BD", Offset = "0xA1BD", VA = "0xA1BD")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001119 RID: 4377
		// (get) Token: 0x06005407 RID: 21511 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005408 RID: 21512 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001119")]
		public List<AprDicGroup> AprDicGroups
		{
			[Token(Token = "0x6005407")]
			[Address(RVA = "0xA1BE", Offset = "0xA1BE", VA = "0xA1BE")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005408")]
			[Address(RVA = "0xA1BF", Offset = "0xA1BF", VA = "0xA1BF")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06005409 RID: 21513 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005409")]
		[Address(RVA = "0xA1C0", Offset = "0xA1C0", VA = "0xA1C0")]
		public AprDicGroupStorage(IDictProvider dictionaries)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Aprs_Model_AprDicGroupStorage___ctor(int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined1 uVar1;
		  uint uVar2;
		  int iVar3;
		  undefined4 uVar4;
		  uint *puVar5;
		  undefined4 uVar6;
		  undefined4 *puVar7;
		  int iVar8;
		  int iVar9;
		  int *piVar10;
		  int iVar11;
		  undefined4 uVar12;
		  undefined4 param3_00;
		  int *piVar13;
		  int iVar14;
		  int local_30;
		  int **local_2c;
		  undefined8 local_28;
		  int local_20;
		  int **local_1c;
		  undefined8 local_18;
		  undefined8 local_10;
		  int *local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a5943d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_MedalDic__uint__get_Data__);
		    Mono_Security_ASN1__get_Item(&Gameplay_Aprs_Model_AprDicGroup_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__AprDicGroup__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__AprDicGroup__ContainsKey__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__AprDicGroup___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__AprDicGroup__get_Item__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Dictionary_uint__AprDicGroup__TypeInfo)
		    ;
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Select_MedalDic__MedalDicWrapper___)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_MedalDicWrapper__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_MedalDicWrapper__MoveNext__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_MedalDicWrapper__get_Current__);
		    Mono_Security_ASN1__get_Item(&System_Func_MedalDic__MedalDicWrapper__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerable_MedalDicWrapper__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerator_MedalDicWrapper__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerator_RewardInfo__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_MedalDicWrapper__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_AprDicGroup__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_MedalDicWrapper__GetEnumerator__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_MedalDicWrapper___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_AprDicGroup___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_AprDicGroup__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_MedalDicWrapper__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_RewardInfo__GetEnumerator__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Aprs_Model_AprDicGroupStorage___c__DisplayClass10_0__Collect_b__0__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Aprs_Model_AprDicGroupStorage___c__DisplayClass10_0_TypeInfo);
		    DAT_ram_00a5943d = '\x01';
		  }
		  local_4 = (int *)0x0;
		  local_8 = (int *)0x0;
		  local_10 = 0;
		  local_18 = 0;
		  iVar3 = unnamed_function_1417
		                    (Gameplay_Aprs_Model_AprDicGroupStorage___c__DisplayClass10_0_TypeInfo);
		  *(undefined4 *)(iVar3 + 8) = param2;
		  uVar4 = unnamed_function_1417(System_Collections_Generic_Dictionary_uint__AprDicGroup__TypeInfo);
		  System_Collections_Generic_List_GAFAnimationAssetInternal_KeyFrame____ctor
		            (uVar4,Method_System_Collections_Generic_Dictionary_uint__AprDicGroup___ctor__);
		  *(undefined4 *)(param1 + 8) = uVar4;
		  uVar4 = unnamed_function_1417(System_Collections_Generic_List_AprDicGroup__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (uVar4,Method_System_Collections_Generic_List_AprDicGroup___ctor__);
		  *(undefined4 *)(param1 + 0xc) = uVar4;
		  uVar4 = unnamed_function_1417(System_Collections_Generic_Dictionary_uint__AprDicGroup__TypeInfo);
		  System_Collections_Generic_List_GAFAnimationAssetInternal_KeyFrame____ctor
		            (uVar4,Method_System_Collections_Generic_Dictionary_uint__AprDicGroup___ctor__);
		  piVar10 = *(int **)(iVar3 + 8);
		  iVar11 = *piVar10;
		  if (*(ushort *)(iVar11 + 0xb6) != 0) {
		    uVar2 = 0;
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar11 + 0x58) + uVar2 * 8)) {
		        puVar5 = (uint *)(*(int *)(*(int *)(iVar11 + 0x58) + uVar2 * 8 + 4) * 8 + iVar11 + 0xd0);
		        goto code_r0x810028b5;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar11 + 0xb6) != uVar2);
		  }
		  puVar5 = (uint *)func_ii_1080(piVar10,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x810028b5:
		  iVar11 = (**(code **)((ulonglong)*puVar5 * 4))(piVar10,puVar5[1]);
		  uVar12 = *(undefined4 *)(iVar11 + 0x70);
		  uVar2 = 0;
		  uVar6 = unnamed_function_1417(System_Func_MedalDic__MedalDicWrapper__TypeInfo);
		  System_Linq_Enumerable__Where_object_
		            (uVar6,iVar3,
		             Method_Gameplay_Aprs_Model_AprDicGroupStorage___c__DisplayClass10_0__Collect_b__0__,0);
		  piVar10 = (int *)System_Linq_Enumerable__ReverseIterator___Il2CppFullySharedGenericType_
		                             (uVar12,uVar6,
		                              Method_System_Linq_Enumerable_Select_MedalDic__MedalDicWrapper___);
		  iVar11 = unnamed_function_1417(System_Collections_Generic_List_MedalDicWrapper__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (iVar11,Method_System_Collections_Generic_List_MedalDicWrapper___ctor__);
		  iVar14 = *piVar10;
		  if (*(ushort *)(iVar14 + 0xb6) != 0) {
		    do {
		      if (System_Collections_Generic_IEnumerable_MedalDicWrapper__TypeInfo ==
		          *(int *)(*(int *)(iVar14 + 0x58) + uVar2 * 8)) {
		        puVar5 = (uint *)(iVar14 + *(int *)(*(int *)(iVar14 + 0x58) + uVar2 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x81002982;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar14 + 0xb6) != uVar2);
		  }
		  puVar5 = (uint *)func_ii_1080(piVar10,
		                                System_Collections_Generic_IEnumerable_MedalDicWrapper__TypeInfo,0);
		code_r0x81002982:
		  local_4 = (int *)(**(code **)((ulonglong)*puVar5 * 4))(piVar10,puVar5[1]);
		  local_30 = 0;
		  local_2c = &local_4;
		  do {
		    piVar10 = local_4;
		    iVar14 = *local_4;
		    if (*(ushort *)(iVar14 + 0xb6) != 0) {
		      uVar2 = 0;
		      do {
		        piVar13 = (int *)(*(int *)(iVar14 + 0x58) + uVar2 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar13) {
		          puVar7 = (undefined4 *)(iVar14 + piVar13[1] * 8 + 0xc0);
		          goto code_r0x81002a65;
		        }
		        uVar2 = uVar2 + 1;
		      } while (*(ushort *)(iVar14 + 0xb6) != uVar2);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar7 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_IEnumerator_TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x810030a6:
		      DAT_ram_009d3e38 = 0;
		      uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      iVar14 = global_1;
		      goto code_r0x810030d0;
		    }
		code_r0x81002a65:
		    DAT_ram_009d3e38 = 0;
		    iVar14 = import::env::invoke_iii(*puVar7,piVar10,puVar7[1]);
		    piVar10 = local_4;
		    if (DAT_ram_009d3e38 == 1) goto code_r0x810030a6;
		    if (iVar14 == 0) {
		      iVar14 = 7;
		      goto code_r0x8100311b;
		    }
		    iVar14 = *local_4;
		    if (*(ushort *)(iVar14 + 0xb6) != 0) {
		      uVar2 = 0;
		      do {
		        piVar13 = (int *)(*(int *)(iVar14 + 0x58) + uVar2 * 8);
		        if (System_Collections_Generic_IEnumerator_MedalDicWrapper__TypeInfo == *piVar13) {
		          puVar7 = (undefined4 *)(iVar14 + piVar13[1] * 8 + 0xc0);
		          goto code_r0x81002b40;
		        }
		        uVar2 = uVar2 + 1;
		      } while (*(ushort *)(iVar14 + 0xb6) != uVar2);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar7 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_Generic_IEnumerator_MedalDicWrapper__TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x810030c1:
		      DAT_ram_009d3e38 = 0;
		      uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      iVar14 = global_1;
		      goto code_r0x810030d0;
		    }
		code_r0x81002b40:
		    DAT_ram_009d3e38 = 0;
		    iVar14 = import::env::invoke_iii(*puVar7,piVar10,puVar7[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x810030c1;
		    DAT_ram_009d3e38 = 0;
		    piVar10 = (int *)import::env::invoke_iii
		                               (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x3a2,
		                                *(undefined4 *)(*(int *)(iVar14 + 0x10) + 0x28),
		                                Method_Google_Protobuf_Collections_RepeatedField_RewardInfo__GetEnumerator__
		                               );
		    iVar8 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar8 == 1) {
		      uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      iVar14 = global_1;
		      goto code_r0x810030d0;
		    }
		    local_20 = 0;
		    local_1c = &local_8;
		    local_8 = piVar10;
		    do {
		      piVar10 = local_8;
		      iVar8 = *local_8;
		      if (*(ushort *)(iVar8 + 0xb6) != 0) {
		        uVar2 = 0;
		        do {
		          piVar13 = (int *)(*(int *)(iVar8 + 0x58) + uVar2 * 8);
		          if (System_Collections_IEnumerator_TypeInfo == *piVar13) {
		            puVar7 = (undefined4 *)(iVar8 + piVar13[1] * 8 + 0xc0);
		            goto code_r0x81002c74;
		          }
		          uVar2 = uVar2 + 1;
		        } while (*(ushort *)(iVar8 + 0xb6) != uVar2);
		      }
		      DAT_ram_009d3e38 = 0;
		      puVar7 = (undefined4 *)
		               import::env::invoke_iiii
		                         (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_8,
		                          System_Collections_IEnumerator_TypeInfo,0);
		      if (DAT_ram_009d3e38 == 1) goto code_r0x81002ee0;
		code_r0x81002c74:
		      DAT_ram_009d3e38 = 0;
		      iVar8 = import::env::invoke_iii(*puVar7,piVar10,puVar7[1]);
		      piVar10 = local_8;
		      if (DAT_ram_009d3e38 == 1) goto code_r0x81002ee0;
		      if (iVar8 == 0) goto code_r0x81002f74;
		      iVar8 = *local_8;
		      if (*(ushort *)(iVar8 + 0xb6) != 0) {
		        uVar2 = 0;
		        do {
		          piVar13 = (int *)(*(int *)(iVar8 + 0x58) + uVar2 * 8);
		          if (System_Collections_Generic_IEnumerator_RewardInfo__TypeInfo == *piVar13) {
		            puVar7 = (undefined4 *)(iVar8 + piVar13[1] * 8 + 0xc0);
		            goto code_r0x81002d4f;
		          }
		          uVar2 = uVar2 + 1;
		        } while (*(ushort *)(iVar8 + 0xb6) != uVar2);
		      }
		      DAT_ram_009d3e38 = 0;
		      puVar7 = (undefined4 *)
		               import::env::invoke_iiii
		                         (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_8,
		                          System_Collections_Generic_IEnumerator_RewardInfo__TypeInfo,0);
		      if (DAT_ram_009d3e38 == 1) goto code_r0x81002ee0;
		code_r0x81002d4f:
		      DAT_ram_009d3e38 = 0;
		      iVar8 = import::env::invoke_iii(*puVar7,piVar10,puVar7[1]);
		      if (DAT_ram_009d3e38 == 1) goto code_r0x81002ee0;
		    } while (*(int *)(iVar8 + 0xc) != 0x68);
		    DAT_ram_009d3e38 = 0;
		    iVar9 = func_ii_7735(*(undefined4 *)(iVar14 + 0x10),0);
		    iVar8 = Method_System_Collections_Generic_List_MedalDicWrapper__Add__;
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x81002ee0:
		      DAT_ram_009d3e38 = 0;
		      uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      iVar14 = global_1;
		      iVar8 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar14 == iVar8) {
		        piVar10 = (int *)import::env::__cxa_begin_catch(uVar6);
		        local_20 = *piVar10;
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_v(0x123);
		        iVar14 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar14 != 1) goto code_r0x81002f74;
		        uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        iVar14 = global_1;
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x2b2,&local_20);
		      iVar8 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar8 == 1) goto code_r0x81003c63;
		      goto code_r0x810030d0;
		    }
		    if (iVar9 != 0) {
		      iVar9 = *(int *)(param1 + 0x10);
		      *(int *)(iVar9 + 0x10) = *(int *)(iVar9 + 0x10) + 1;
		      uVar2 = *(uint *)(iVar9 + 0xc);
		      if (uVar2 < *(uint *)(*(int *)(iVar9 + 8) + 0xc)) {
		        *(uint *)(iVar9 + 0xc) = uVar2 + 1;
		        *(int *)(*(int *)(iVar9 + 8) + uVar2 * 4 + 0x10) = iVar14;
		      }
		      else {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,iVar9,iVar14,
		                   *(undefined4 *)(*(int *)(*(int *)(iVar8 + 0x10) + 0x60) + 0x38));
		        if (DAT_ram_009d3e38 == 1) goto code_r0x81002ee0;
		      }
		    }
		    iVar8 = Method_System_Collections_Generic_List_MedalDicWrapper__Add__;
		    *(int *)(iVar11 + 0x10) = *(int *)(iVar11 + 0x10) + 1;
		    uVar2 = *(uint *)(iVar11 + 0xc);
		    if (uVar2 < *(uint *)(*(int *)(iVar11 + 8) + 0xc)) {
		      *(uint *)(iVar11 + 0xc) = uVar2 + 1;
		      *(int *)(*(int *)(iVar11 + 8) + uVar2 * 4 + 0x10) = iVar14;
		    }
		    else {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_viii
		                (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,iVar11,iVar14,
		                 *(undefined4 *)(*(int *)(*(int *)(iVar8 + 0x10) + 0x60) + 0x38));
		      if (DAT_ram_009d3e38 == 1) goto code_r0x81002ee0;
		    }
		code_r0x81002f74:
		    piVar10 = *local_1c;
		    if (piVar10 != (int *)0x0) {
		      iVar14 = *piVar10;
		      if (*(ushort *)(iVar14 + 0xb6) != 0) {
		        uVar2 = 0;
		        do {
		          piVar13 = (int *)(*(int *)(iVar14 + 0x58) + uVar2 * 8);
		          if (System_IDisposable_TypeInfo == *piVar13) {
		            puVar7 = (undefined4 *)(iVar14 + piVar13[1] * 8 + 0xc0);
		            goto code_r0x81003014;
		          }
		          uVar2 = uVar2 + 1;
		        } while (*(ushort *)(iVar14 + 0xb6) != uVar2);
		      }
		      DAT_ram_009d3e38 = 0;
		      puVar7 = (undefined4 *)
		               import::env::invoke_iiii
		                         (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar10,
		                          System_IDisposable_TypeInfo,0);
		      if (DAT_ram_009d3e38 != 1) {
		code_r0x81003014:
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vii(*puVar7,piVar10,puVar7[1]);
		        if (DAT_ram_009d3e38 != 1) goto code_r0x81003050;
		      }
		      DAT_ram_009d3e38 = 0;
		      uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      iVar14 = global_1;
		      goto code_r0x810030d0;
		    }
		code_r0x81003050:
		  } while (local_20 == 0);
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_vi(s_var<private>_posTex__array<vec4<_ram_00000655 + 0x1d3,local_20);
		  iVar14 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar14 != 1) {
		    do {
		      halt_trap();
		    } while( true );
		  }
		  uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		  iVar14 = global_1;
		code_r0x810030d0:
		  iVar8 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar8 == iVar14) {
		    piVar10 = (int *)import::env::__cxa_begin_catch(uVar6);
		    local_30 = *piVar10;
		    iVar14 = 0;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_v(0x123);
		    iVar8 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar8 != 1) {
		code_r0x8100311b:
		      DAT_ram_009d3e38 = 0;
		      piVar10 = *local_2c;
		      if (piVar10 != (int *)0x0) {
		        uVar2 = 0;
		        iVar8 = *piVar10;
		        if (*(ushort *)(iVar8 + 0xb6) != 0) {
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar2 * 8)) {
		              puVar5 = (uint *)(iVar8 + *(int *)(*(int *)(iVar8 + 0x58) + uVar2 * 8 + 4) * 8 + 0xc0)
		              ;
		              goto code_r0x81003196;
		            }
		            uVar2 = uVar2 + 1;
		          } while (*(ushort *)(iVar8 + 0xb6) != uVar2);
		        }
		        puVar5 = (uint *)func_ii_1080(piVar10,System_IDisposable_TypeInfo,0);
		code_r0x81003196:
		        (**(code **)((ulonglong)*puVar5 * 4))(piVar10,puVar5[1]);
		      }
		      if (local_30 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(local_30);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      if ((iVar14 != 0) &&
		         ((((iVar14 == 1 || (iVar14 == 2)) || (iVar14 == 3)) ||
		          (((iVar14 == 4 || (iVar14 == 5)) || ((iVar14 == 6 || (iVar14 != 7)))))))) {
		        return;
		      }
		      System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		                (&local_30,iVar11,
		                 Method_System_Collections_Generic_List_MedalDicWrapper__GetEnumerator__);
		      local_10 = local_28;
		      local_18 = CONCAT44(local_2c,local_30);
		      local_30 = 0;
		      local_2c = (int **)&local_18;
		code_r0x81003233:
		      do {
		        DAT_ram_009d3e38 = 0;
		        iVar14 = import::env::invoke_iii
		                           (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_18,
		                            Method_System_Collections_Generic_List_Enumerator_MedalDicWrapper__MoveNext__
		                           );
		        iVar11 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar11 == 1) {
		          uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x81003bca;
		        }
		        iVar11 = local_30;
		        if (iVar14 == 0) goto code_r0x81003c13;
		        iVar11 = local_10._4_4_;
		        piVar10 = *(int **)(iVar3 + 8);
		        iVar14 = *piVar10;
		        if (*(ushort *)(iVar14 + 0xb6) != 0) {
		          uVar2 = 0;
		          do {
		            piVar13 = (int *)(*(int *)(iVar14 + 0x58) + uVar2 * 8);
		            if (Core_Dict_IDictProvider_TypeInfo == *piVar13) {
		              puVar7 = (undefined4 *)(piVar13[1] * 8 + iVar14 + 0xd0);
		              goto code_r0x8100331c;
		            }
		            uVar2 = uVar2 + 1;
		          } while (*(ushort *)(iVar14 + 0xb6) != uVar2);
		        }
		        DAT_ram_009d3e38 = 0;
		        puVar7 = (undefined4 *)
		                 import::env::invoke_iiii
		                           (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar10,
		                            Core_Dict_IDictProvider_TypeInfo,2);
		        if (DAT_ram_009d3e38 == 1) {
		code_r0x81003656:
		          DAT_ram_009d3e38 = 0;
		          uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x81003bca;
		        }
		code_r0x8100331c:
		        DAT_ram_009d3e38 = 0;
		        uVar6 = import::env::invoke_iii(*puVar7,piVar10,puVar7[1]);
		        if (DAT_ram_009d3e38 == 1) goto code_r0x81003656;
		        DAT_ram_009d3e38 = 0;
		        iVar8 = import::env::invoke_iiii
		                          (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x69,uVar6,
		                           *(undefined4 *)(*(int *)(iVar11 + 0x10) + 0x1c),0);
		        iVar14 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar14 == 1) {
		          uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x81003bca;
		        }
		        piVar10 = *(int **)(iVar3 + 8);
		        iVar14 = *piVar10;
		        if (*(ushort *)(iVar14 + 0xb6) != 0) {
		          uVar2 = 0;
		          do {
		            piVar13 = (int *)(*(int *)(iVar14 + 0x58) + uVar2 * 8);
		            if (Core_Dict_IDictProvider_TypeInfo == *piVar13) {
		              puVar7 = (undefined4 *)(piVar13[1] * 8 + iVar14 + 0xd0);
		              goto code_r0x8100342e;
		            }
		            uVar2 = uVar2 + 1;
		          } while (*(ushort *)(iVar14 + 0xb6) != uVar2);
		        }
		        DAT_ram_009d3e38 = 0;
		        puVar7 = (undefined4 *)
		                 import::env::invoke_iiii
		                           (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar10,
		                            Core_Dict_IDictProvider_TypeInfo,2);
		        if (DAT_ram_009d3e38 == 1) {
		code_r0x8100366a:
		          DAT_ram_009d3e38 = 0;
		          uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x81003bca;
		        }
		code_r0x8100342e:
		        DAT_ram_009d3e38 = 0;
		        uVar6 = import::env::invoke_iii(*puVar7,piVar10,puVar7[1]);
		        if (DAT_ram_009d3e38 == 1) goto code_r0x8100366a;
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_iiii
		                  (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x6a,uVar6,
		                   *(undefined4 *)(*(int *)(iVar11 + 0x10) + 0x1c),0);
		        iVar14 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar14 == 1) {
		          uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x81003bca;
		        }
		        iVar14 = *(int *)(*(int *)(iVar11 + 0x10) + 0x34);
		        if (iVar14 != 0) {
		          DAT_ram_009d3e38 = 0;
		          iVar9 = import::env::invoke_iiii
		                            (s_struct_Uniforms___color__array<v_ram_00000aff + 0x3c1,uVar4,iVar14,
		                             Method_System_Collections_Generic_Dictionary_uint__AprDicGroup__ContainsKey__
		                            );
		          iVar14 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar14 == 1) {
		            uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x81003bca;
		          }
		          if (iVar9 == 0) {
		            uVar12 = *(undefined4 *)(*(int *)(iVar11 + 0x10) + 0x34);
		            DAT_ram_009d3e38 = 0;
		            uVar6 = import::env::invoke_ii
		                              (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                               Gameplay_Aprs_Model_AprDicGroup_TypeInfo);
		            if (DAT_ram_009d3e38 != 1) {
		              DAT_ram_009d3e38 = 0;
		              import::env::invoke_vii
		                        (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x2b4,uVar6,uVar6);
		              if (DAT_ram_009d3e38 != 1) {
		                DAT_ram_009d3e38 = 0;
		                import::env::invoke_viiii
		                          (s_struct_Uniforms___color__array<v_ram_00000aff + 0x39f,uVar4,uVar12,
		                           uVar6,
		                           Method_System_Collections_Generic_Dictionary_uint__AprDicGroup__Add__);
		                if (DAT_ram_009d3e38 != 1) {
		                  iVar9 = *(int *)(param1 + 0xc);
		                  DAT_ram_009d3e38 = 0;
		                  uVar6 = import::env::invoke_iiii
		                                    (s_struct_Uniforms___color__array<v_ram_00000aff + 0x22b,uVar4,
		                                     *(undefined4 *)(*(int *)(iVar11 + 0x10) + 0x34),
		                                     Method_System_Collections_Generic_Dictionary_uint__AprDicGroup__get_Item__
		                                    );
		                  iVar14 = Method_System_Collections_Generic_List_AprDicGroup__Add__;
		                  if (DAT_ram_009d3e38 == 1) {
		code_r0x81003a68:
		                    DAT_ram_009d3e38 = 0;
		                    uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                  }
		                  else {
		                    *(int *)(iVar9 + 0x10) = *(int *)(iVar9 + 0x10) + 1;
		                    uVar2 = *(uint *)(iVar9 + 0xc);
		                    if (uVar2 < *(uint *)(*(int *)(iVar9 + 8) + 0xc)) {
		                      *(uint *)(iVar9 + 0xc) = uVar2 + 1;
		                      *(undefined4 *)(*(int *)(iVar9 + 8) + uVar2 * 4 + 0x10) = uVar6;
		                    }
		                    else {
		                      DAT_ram_009d3e38 = 0;
		                      import::env::invoke_viii
		                                (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,iVar9,uVar6,
		                                 *(undefined4 *)(*(int *)(*(int *)(iVar14 + 0x10) + 0x60) + 0x38));
		                      if (DAT_ram_009d3e38 == 1) goto code_r0x81003a68;
		                    }
		                    uVar12 = *(undefined4 *)(param1 + 8);
		                    param3_00 = *(undefined4 *)(*(int *)(iVar11 + 0x10) + 0xc);
		                    DAT_ram_009d3e38 = 0;
		                    uVar6 = import::env::invoke_iiii
		                                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x22b,uVar4
		                                       ,*(undefined4 *)(*(int *)(iVar11 + 0x10) + 0x34),
		                                       Method_System_Collections_Generic_Dictionary_uint__AprDicGroup__get_Item__
		                                      );
		                    if (DAT_ram_009d3e38 != 1) {
		                      DAT_ram_009d3e38 = 0;
		                      import::env::invoke_viiii
		                                (s_struct_Uniforms___color__array<v_ram_00000aff + 0x39f,uVar12,
		                                 param3_00,uVar6,
		                                 Method_System_Collections_Generic_Dictionary_uint__AprDicGroup__Add__
		                                );
		                      if (DAT_ram_009d3e38 != 1) goto code_r0x810038c2;
		                    }
		                    DAT_ram_009d3e38 = 0;
		                    uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                  }
		                  goto code_r0x81003bca;
		                }
		              }
		            }
		            DAT_ram_009d3e38 = 0;
		            uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x81003bca;
		          }
		code_r0x810038c2:
		          DAT_ram_009d3e38 = 0;
		          iVar9 = import::env::invoke_iiii
		                            (s_struct_Uniforms___color__array<v_ram_00000aff + 0x22b,uVar4,
		                             *(undefined4 *)(*(int *)(iVar11 + 0x10) + 0x34),
		                             Method_System_Collections_Generic_Dictionary_uint__AprDicGroup__get_Item__
		                            );
		          iVar14 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar14 == 1) {
		            uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x81003bca;
		          }
		          if (DAT_ram_00a59439 == '\0') {
		            DAT_ram_009d3e38 = 0;
		            import::env::invoke_vi
		                      (0x7ff,&
		                             Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_MedalDic__uint__get_Data__
		                      );
		            if (DAT_ram_009d3e38 != 1) {
		              DAT_ram_009d3e38 = 0;
		              import::env::invoke_vi
		                        (0x7ff,&
		                               Method_System_Collections_Generic_Dictionary_uint__MedalDicWrapper__Add__
		                        );
		              if (DAT_ram_009d3e38 != 1) {
		                DAT_ram_009d3e38 = 0;
		                import::env::invoke_vi
		                          (0x7ff,&
		                                 Method_System_Collections_Generic_SortedList_uint__MedalDicWrapper__Add__
		                          );
		                if (DAT_ram_009d3e38 != 1) {
		                  DAT_ram_00a59439 = '\x01';
		                  goto code_r0x810039a7;
		                }
		              }
		            }
		          }
		          else {
		code_r0x810039a7:
		            DAT_ram_009d3e38 = 0;
		            import::env::invoke_viiii
		                      (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x2b5,
		                       *(undefined4 *)(iVar9 + 8),*(undefined4 *)(*(int *)(iVar11 + 0x10) + 0x38),
		                       iVar11,
		                       Method_System_Collections_Generic_SortedList_uint__MedalDicWrapper__Add__);
		            if (DAT_ram_009d3e38 != 1) {
		              DAT_ram_009d3e38 = 0;
		              import::env::invoke_viiii
		                        (s_struct_Uniforms___color__array<v_ram_00000aff + 0x39f,
		                         *(undefined4 *)(iVar9 + 0xc),*(undefined4 *)(*(int *)(iVar11 + 0x10) + 0xc)
		                         ,iVar11,
		                         Method_System_Collections_Generic_Dictionary_uint__MedalDicWrapper__Add__);
		              if (DAT_ram_009d3e38 != 1) {
		                *(undefined4 *)(iVar9 + 0x14) = *(undefined4 *)(*(int *)(iVar11 + 0x10) + 0x34);
		                uVar1 = *(undefined1 *)(iVar8 + 0x10);
		                *(int *)(iVar9 + 0x10) = iVar8;
		                *(undefined1 *)(iVar9 + 0x18) = uVar1;
		                goto code_r0x81003233;
		              }
		            }
		          }
		          DAT_ram_009d3e38 = 0;
		          uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x81003bca;
		        }
		        DAT_ram_009d3e38 = 0;
		        iVar14 = import::env::invoke_ii
		                           (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                            Gameplay_Aprs_Model_AprDicGroup_TypeInfo);
		        if (DAT_ram_009d3e38 == 1) {
		code_r0x81003b93:
		          DAT_ram_009d3e38 = 0;
		          uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x81003bca;
		        }
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vii
		                  (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x2b4,iVar14,iVar14);
		        if (DAT_ram_009d3e38 == 1) goto code_r0x81003b93;
		        if (DAT_ram_00a59439 == '\0') {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_vi
		                    (0x7ff,&
		                           Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_MedalDic__uint__get_Data__
		                    );
		          if (DAT_ram_009d3e38 != 1) {
		            DAT_ram_009d3e38 = 0;
		            import::env::invoke_vi
		                      (0x7ff,&
		                             Method_System_Collections_Generic_Dictionary_uint__MedalDicWrapper__Add__
		                      );
		            if (DAT_ram_009d3e38 != 1) {
		              DAT_ram_009d3e38 = 0;
		              import::env::invoke_vi
		                        (0x7ff,&
		                               Method_System_Collections_Generic_SortedList_uint__MedalDicWrapper__Add__
		                        );
		              if (DAT_ram_009d3e38 != 1) {
		                DAT_ram_00a59439 = '\x01';
		                goto code_r0x810035b9;
		              }
		            }
		          }
		code_r0x8100364c:
		          DAT_ram_009d3e38 = 0;
		          uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x81003bca;
		        }
		code_r0x810035b9:
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viiii
		                  (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x2b5,
		                   *(undefined4 *)(iVar14 + 8),*(undefined4 *)(*(int *)(iVar11 + 0x10) + 0x38),
		                   iVar11,Method_System_Collections_Generic_SortedList_uint__MedalDicWrapper__Add__)
		        ;
		        if (DAT_ram_009d3e38 == 1) goto code_r0x8100364c;
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viiii
		                  (s_struct_Uniforms___color__array<v_ram_00000aff + 0x39f,
		                   *(undefined4 *)(iVar14 + 0xc),*(undefined4 *)(*(int *)(iVar11 + 0x10) + 0xc),
		                   iVar11,Method_System_Collections_Generic_Dictionary_uint__MedalDicWrapper__Add__)
		        ;
		        if (DAT_ram_009d3e38 == 1) goto code_r0x8100364c;
		        *(undefined4 *)(iVar14 + 0x14) = *(undefined4 *)(*(int *)(iVar11 + 0x10) + 0x34);
		        uVar1 = *(undefined1 *)(iVar8 + 0x10);
		        *(int *)(iVar14 + 0x10) = iVar8;
		        *(undefined1 *)(iVar14 + 0x18) = uVar1;
		        iVar8 = Method_System_Collections_Generic_List_AprDicGroup__Add__;
		        iVar9 = *(int *)(param1 + 0xc);
		        *(int *)(iVar9 + 0x10) = *(int *)(iVar9 + 0x10) + 1;
		        uVar2 = *(uint *)(iVar9 + 0xc);
		        if (uVar2 < *(uint *)(*(int *)(iVar9 + 8) + 0xc)) {
		          *(uint *)(iVar9 + 0xc) = uVar2 + 1;
		          *(int *)(*(int *)(iVar9 + 8) + uVar2 * 4 + 0x10) = iVar14;
		        }
		        else {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_viii
		                    (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,iVar9,iVar14,
		                     *(undefined4 *)(*(int *)(*(int *)(iVar8 + 0x10) + 0x60) + 0x38));
		          iVar8 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar8 == 1) {
		            uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x81003bca;
		          }
		        }
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viiii
		                  (s_struct_Uniforms___color__array<v_ram_00000aff + 0x39f,
		                   *(undefined4 *)(param1 + 8),*(undefined4 *)(*(int *)(iVar11 + 0x10) + 0xc),iVar14
		                   ,Method_System_Collections_Generic_Dictionary_uint__AprDicGroup__Add__);
		        iVar11 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		      } while (iVar11 != 1);
		      uVar6 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x81003bca:
		      iVar3 = global_1;
		      iVar11 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar3 == iVar11) {
		        piVar10 = (int *)import::env::__cxa_begin_catch(uVar6);
		        iVar11 = *piVar10;
		        DAT_ram_009d3e38 = 0;
		        local_30 = iVar11;
		        import::env::invoke_v(0x123);
		        iVar3 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar3 != 1) {
		code_r0x81003c13:
		          DAT_ram_009d3e38 = 0;
		          if (iVar11 == 0) {
		            DAT_ram_009d3e38 = 0;
		            return;
		          }
		          System_Data_DataSet__ValidateLocaleConstraint(iVar11);
		          do {
		            halt_trap();
		          } while( true );
		        }
		        uVar6 = import::env::__cxa_find_matching_catch_2();
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x2b6,&local_30);
		      goto joined_r0x81003c60;
		    }
		    uVar6 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x2b3,&local_30);
		joined_r0x81003c60:
		  if (DAT_ram_009d3e38 != 1) {
		    DAT_ram_009d3e38 = 0;
		    import::env::__resumeException(uVar6);
		    do {
		      halt_trap();
		    } while( true );
		  }
		code_r0x81003c63:
		  DAT_ram_009d3e38 = 0;
		  import::env::__cxa_find_matching_catch_3(0);
		  unnamed_function_937();
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x0600540A RID: 21514 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600540A")]
		[Address(RVA = "0xA1C1", Offset = "0xA1C1", VA = "0xA1C1")]
		public void Collect(IDictProvider dictProvider)
		{
		/* --- GHIDRA: Collect ---
		void Gameplay_Aprs_Model_AprDicGroupStorage__Collect(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a5943e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__AprDicGroup__Clear__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_AprDicGroup__Clear__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_MedalDicWrapper__Clear__);
		    DAT_ram_00a5943e = '\x01';
		  }
		  iVar1 = *(int *)(param1 + 0x10);
		  iVar2 = *(int *)(iVar1 + 0xc);
		  *(undefined4 *)(iVar1 + 0xc) = 0;
		  *(int *)(iVar1 + 0x10) = *(int *)(iVar1 + 0x10) + 1;
		  if (0 < iVar2) {
		    func_ii_2064(*(undefined4 *)(iVar1 + 8),0,iVar2,0);
		  }
		  System_Xml_XmlWellFormedWriter__PushNamespaceImplicit
		            (*(undefined4 *)(param1 + 8),
		             Method_System_Collections_Generic_Dictionary_uint__AprDicGroup__Clear__);
		  iVar1 = *(int *)(param1 + 0xc);
		  iVar2 = *(int *)(iVar1 + 0xc);
		  *(undefined4 *)(iVar1 + 0xc) = 0;
		  *(int *)(iVar1 + 0x10) = *(int *)(iVar1 + 0x10) + 1;
		  if (0 < iVar2) {
		    func_ii_2064(*(undefined4 *)(iVar1 + 8),0,iVar2,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600540B RID: 21515 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600540B")]
		[Address(RVA = "0xA1C2", Offset = "0xA1C2", VA = "0xA1C2")]
		public void Reset()
		{
		/* --- GHIDRA: Reset ---
		void Gameplay_Aprs_Model_AprDicGroupStorage__Reset(int param1,undefined4 param2)
		
		{
		  Gameplay_Aprs_Model_AprDicGroupStorage__Collect(param1,param1);
		  *(undefined8 *)(param1 + 8) = 0;
		  return;
		}
		*/

		}

		// Token: 0x0600540C RID: 21516 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600540C")]
		[Address(RVA = "0xA1C3", Offset = "0xA1C3", VA = "0xA1C3", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x04002D85 RID: 11653
		[Token(Token = "0x4002D85")]
		[FieldOffset(Offset = "0x10")]
		public readonly List<MedalDicWrapper> MedalsWhitDiscount;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_AprDicGroups ---
		void Gameplay_Aprs_Model_AprDicGroupStorage__set_AprDicGroups
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5943c == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_MedalDicWrapper___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_MedalDicWrapper__TypeInfo);
		    DAT_ram_00a5943c = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_Collections_Generic_List_MedalDicWrapper__TypeInfo);
		  Unity_Services_Core_Internal_UnityServicesInternal___c__DisplayClass33_0___InitializeServicesAsync_g__FailServicesInitialization_2
		            (param1_00,0x1e,Method_System_Collections_Generic_List_MedalDicWrapper___ctor__);
		  *(undefined4 *)(param1 + 0x10) = param1_00;
		  Gameplay_Aprs_Model_AprDicGroupStorage___ctor(param1,param2,param1);
		  return;
		}
		*/

}
