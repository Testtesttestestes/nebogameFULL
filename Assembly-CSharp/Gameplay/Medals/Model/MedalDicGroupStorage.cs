using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Dict;
using Il2CppDummyDll;

namespace Gameplay.Medals.Model
{
	// Token: 0x02000600 RID: 1536
	[Token(Token = "0x2000600")]
	public class MedalDicGroupStorage : IDisposable
	{
		// Token: 0x17000705 RID: 1797
		// (get) Token: 0x0600254F RID: 9551 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002550 RID: 9552 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000705")]
		public Dictionary<uint, MedalDicGroup> MedalDicGroupsByMedalId
		{
			[Token(Token = "0x600254F")]
			[Address(RVA = "0x7696", Offset = "0x7696", VA = "0x7696")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002550")]
			[Address(RVA = "0x7697", Offset = "0x7697", VA = "0x7697")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000706 RID: 1798
		// (get) Token: 0x06002551 RID: 9553 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002552 RID: 9554 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000706")]
		public List<MedalDicGroup> MedalDicGroups
		{
			[Token(Token = "0x6002551")]
			[Address(RVA = "0x7698", Offset = "0x7698", VA = "0x7698")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002552")]
			[Address(RVA = "0x7699", Offset = "0x7699", VA = "0x7699")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06002553 RID: 9555 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002553")]
		[Address(RVA = "0x769A", Offset = "0x769A", VA = "0x769A")]
		public MedalDicGroupStorage(IDictProvider dictProvider)
		{
		/* --- GHIDRA: .ctor ---
		uint Gameplay_Medals_Model_MedalDicGroupStorage___ctor
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a57da3 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__MedalDicGroup__get_Item__);
		    DAT_ram_00a57da3 = '\x01';
		  }
		  iVar1 = System_Collections_Generic_List_object___get_Item
		                    (*(undefined4 *)(param1 + 8),param2,
		                     Method_System_Collections_Generic_Dictionary_uint__MedalDicGroup__get_Item__);
		  if (DAT_ram_00a57d9f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_SortedList_uint__MedalDicWrapper__get_Count__);
		    DAT_ram_00a57d9f = '\x01';
		  }
		  return (uint)(1 < *(int *)(*(int *)(iVar1 + 8) + 0x10));
		}
		*/

		}

		// Token: 0x06002554 RID: 9556 RVA: 0x000071B8 File Offset: 0x000053B8
		[Token(Token = "0x6002554")]
		[Address(RVA = "0x769B", Offset = "0x769B", VA = "0x769B")]
		public bool IsMedalHasRanks(uint medalId)
		{
		/* --- GHIDRA: IsMedalHasRanks ---
		undefined4
		Gameplay_Medals_Model_MedalDicGroupStorage__IsMedalHasRanks
		          (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a57da4 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__MedalDicGroup__get_Item__);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Last_uint___);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_SortedList_uint__MedalDicWrapper__get_Keys__);
		    DAT_ram_00a57da4 = '\x01';
		  }
		  iVar1 = System_Collections_Generic_List_object___get_Item
		                    (*(undefined4 *)(param1 + 8),param2,
		                     Method_System_Collections_Generic_Dictionary_uint__MedalDicGroup__get_Item__);
		  uVar2 = System_Collections_Generic_SortedList_uint__object___System_Collections_IDictionary_get_Item
		                    (*(undefined4 *)(iVar1 + 8),
		                     Method_System_Collections_Generic_SortedList_uint__MedalDicWrapper__get_Keys__)
		  ;
		  uVar2 = System_Linq_Enumerable__Last_object_(uVar2,Method_System_Linq_Enumerable_Last_uint___);
		  return uVar2;
		}
		*/

			return default(bool);
		}

		// Token: 0x06002555 RID: 9557 RVA: 0x000071D0 File Offset: 0x000053D0
		[Token(Token = "0x6002555")]
		[Address(RVA = "0x769C", Offset = "0x769C", VA = "0x769C")]
		public uint GetMaxRank(uint medalId)
		{
		/* --- GHIDRA: GetMaxRank ---
		void Gameplay_Medals_Model_MedalDicGroupStorage__GetMaxRank
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  uint *puVar5;
		  undefined4 *puVar6;
		  undefined4 uVar7;
		  int iVar8;
		  undefined4 uVar9;
		  int *piVar10;
		  int iVar11;
		  undefined4 uVar12;
		  int iVar13;
		  int *piVar14;
		  int local_c;
		  int **local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a57da5 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_MedalDic__uint__get_Data__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__MedalDicGroup__ContainsKey__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__MedalDicGroup___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__MedalDicGroup__get_Item__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__MedalDicGroup__set_Item__);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_Dictionary_uint__MedalDicGroup__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Select_MedalDic__MedalDicWrapper___)
		    ;
		    Mono_Security_ASN1__get_Item(&System_Func_MedalDic__MedalDicWrapper__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerable_MedalDicWrapper__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerator_MedalDicWrapper__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_MedalDicGroup__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_MedalDicGroup___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_MedalDicGroup__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Medals_Model_MedalDicGroup_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Medals_Model_MedalDicGroupStorage___c__DisplayClass11_0__Init_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Medals_Model_MedalDicGroupStorage___c__DisplayClass11_0_TypeInfo);
		    DAT_ram_00a57da5 = '\x01';
		  }
		  local_4 = (int *)0x0;
		  iVar2 = unnamed_function_1417
		                    (Gameplay_Medals_Model_MedalDicGroupStorage___c__DisplayClass11_0_TypeInfo);
		  *(undefined4 *)(iVar2 + 8) = param2;
		  uVar3 = unnamed_function_1417(System_Collections_Generic_Dictionary_uint__MedalDicGroup__TypeInfo)
		  ;
		  System_Collections_Generic_List_GAFAnimationAssetInternal_KeyFrame____ctor
		            (uVar3,Method_System_Collections_Generic_Dictionary_uint__MedalDicGroup___ctor__);
		  uVar4 = unnamed_function_1417(System_Collections_Generic_Dictionary_uint__MedalDicGroup__TypeInfo)
		  ;
		  System_Collections_Generic_List_GAFAnimationAssetInternal_KeyFrame____ctor
		            (uVar4,Method_System_Collections_Generic_Dictionary_uint__MedalDicGroup___ctor__);
		  *(undefined4 *)(param1 + 8) = uVar4;
		  uVar4 = unnamed_function_1417(System_Collections_Generic_List_MedalDicGroup__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (uVar4,Method_System_Collections_Generic_List_MedalDicGroup___ctor__);
		  *(undefined4 *)(param1 + 0xc) = uVar4;
		  piVar10 = *(int **)(iVar2 + 8);
		  iVar11 = *piVar10;
		  if (*(ushort *)(iVar11 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar11 + 0x58) + uVar1 * 8)) {
		        puVar5 = (uint *)(*(int *)(*(int *)(iVar11 + 0x58) + uVar1 * 8 + 4) * 8 + iVar11 + 0xd0);
		        goto code_r0x80e5b065;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar11 + 0xb6) != uVar1);
		  }
		  puVar5 = (uint *)func_ii_1080(piVar10,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x80e5b065:
		  iVar11 = (**(code **)((ulonglong)*puVar5 * 4))(piVar10,puVar5[1]);
		  uVar12 = *(undefined4 *)(iVar11 + 0x70);
		  uVar1 = 0;
		  uVar4 = unnamed_function_1417(System_Func_MedalDic__MedalDicWrapper__TypeInfo);
		  System_Linq_Enumerable__Where_object_
		            (uVar4,iVar2,
		             Method_Gameplay_Medals_Model_MedalDicGroupStorage___c__DisplayClass11_0__Init_b__0__,0)
		  ;
		  piVar10 = (int *)System_Linq_Enumerable__ReverseIterator___Il2CppFullySharedGenericType_
		                             (uVar12,uVar4,
		                              Method_System_Linq_Enumerable_Select_MedalDic__MedalDicWrapper___);
		  iVar11 = *piVar10;
		  if (*(ushort *)(iVar11 + 0xb6) != 0) {
		    do {
		      if (System_Collections_Generic_IEnumerable_MedalDicWrapper__TypeInfo ==
		          *(int *)(*(int *)(iVar11 + 0x58) + uVar1 * 8)) {
		        puVar5 = (uint *)(iVar11 + *(int *)(*(int *)(iVar11 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80e5b11a;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar11 + 0xb6) != uVar1);
		  }
		  puVar5 = (uint *)func_ii_1080(piVar10,
		                                System_Collections_Generic_IEnumerable_MedalDicWrapper__TypeInfo,0);
		code_r0x80e5b11a:
		  local_4 = (int *)(**(code **)((ulonglong)*puVar5 * 4))(piVar10,puVar5[1]);
		  local_c = 0;
		  local_8 = &local_4;
		code_r0x80e5b13f:
		  piVar10 = local_4;
		  iVar11 = *local_4;
		  if (*(ushort *)(iVar11 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      piVar14 = (int *)(*(int *)(iVar11 + 0x58) + uVar1 * 8);
		      if (System_Collections_IEnumerator_TypeInfo == *piVar14) {
		        puVar6 = (undefined4 *)(iVar11 + piVar14[1] * 8 + 0xc0);
		        goto code_r0x80e5b1e5;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar11 + 0xb6) != uVar1);
		  }
		  DAT_ram_009d3e38 = 0;
		  puVar6 = (undefined4 *)
		           import::env::invoke_iiii
		                     (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                      System_Collections_IEnumerator_TypeInfo,0);
		  if (DAT_ram_009d3e38 == 1) {
		code_r0x80e5b229:
		    DAT_ram_009d3e38 = 0;
		    uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    goto code_r0x80e5b9b9;
		  }
		code_r0x80e5b1e5:
		  DAT_ram_009d3e38 = 0;
		  iVar11 = import::env::invoke_iii(*puVar6,piVar10,puVar6[1]);
		  piVar10 = local_4;
		  if (DAT_ram_009d3e38 == 1) goto code_r0x80e5b229;
		  if (iVar11 == 0) goto code_r0x80e5ba02;
		  iVar11 = *local_4;
		  if (*(ushort *)(iVar11 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      piVar14 = (int *)(*(int *)(iVar11 + 0x58) + uVar1 * 8);
		      if (System_Collections_Generic_IEnumerator_MedalDicWrapper__TypeInfo == *piVar14) {
		        puVar6 = (undefined4 *)(iVar11 + piVar14[1] * 8 + 0xc0);
		        goto code_r0x80e5b2dc;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar11 + 0xb6) != uVar1);
		  }
		  DAT_ram_009d3e38 = 0;
		  puVar6 = (undefined4 *)
		           import::env::invoke_iiii
		                     (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                      System_Collections_Generic_IEnumerator_MedalDicWrapper__TypeInfo,0);
		  if (DAT_ram_009d3e38 == 1) {
		code_r0x80e5b5be:
		    DAT_ram_009d3e38 = 0;
		    uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    goto code_r0x80e5b9b9;
		  }
		code_r0x80e5b2dc:
		  DAT_ram_009d3e38 = 0;
		  iVar11 = import::env::invoke_iii(*puVar6,piVar10,puVar6[1]);
		  if (DAT_ram_009d3e38 == 1) goto code_r0x80e5b5be;
		  uVar4 = *(undefined4 *)(*(int *)(iVar11 + 0x10) + 0x48);
		  piVar10 = *(int **)(iVar2 + 8);
		  iVar13 = *piVar10;
		  if (*(ushort *)(iVar13 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      piVar14 = (int *)(*(int *)(iVar13 + 0x58) + uVar1 * 8);
		      if (Core_Dict_IDictProvider_TypeInfo == *piVar14) {
		        puVar6 = (undefined4 *)(piVar14[1] * 8 + iVar13 + 0xd0);
		        goto code_r0x80e5b3bc;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar13 + 0xb6) != uVar1);
		  }
		  DAT_ram_009d3e38 = 0;
		  puVar6 = (undefined4 *)
		           import::env::invoke_iiii
		                     (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar10,
		                      Core_Dict_IDictProvider_TypeInfo,2);
		  if (DAT_ram_009d3e38 == 1) {
		code_r0x80e5b5c8:
		    DAT_ram_009d3e38 = 0;
		    uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    goto code_r0x80e5b9b9;
		  }
		code_r0x80e5b3bc:
		  DAT_ram_009d3e38 = 0;
		  uVar12 = import::env::invoke_iii(*puVar6,piVar10,puVar6[1]);
		  if (DAT_ram_009d3e38 == 1) goto code_r0x80e5b5c8;
		  DAT_ram_009d3e38 = 0;
		  uVar12 = import::env::invoke_iiii
		                     (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x69,uVar12,
		                      *(undefined4 *)(*(int *)(iVar11 + 0x10) + 0x1c),0);
		  iVar13 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar13 == 1) {
		    uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    goto code_r0x80e5b9b9;
		  }
		  piVar10 = *(int **)(iVar2 + 8);
		  iVar13 = *piVar10;
		  if (*(ushort *)(iVar13 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      piVar14 = (int *)(*(int *)(iVar13 + 0x58) + uVar1 * 8);
		      if (Core_Dict_IDictProvider_TypeInfo == *piVar14) {
		        puVar6 = (undefined4 *)(piVar14[1] * 8 + iVar13 + 0xd0);
		        goto code_r0x80e5b4ce;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar13 + 0xb6) != uVar1);
		  }
		  DAT_ram_009d3e38 = 0;
		  puVar6 = (undefined4 *)
		           import::env::invoke_iiii
		                     (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar10,
		                      Core_Dict_IDictProvider_TypeInfo,2);
		  if (DAT_ram_009d3e38 == 1) {
		code_r0x80e5b5dc:
		    DAT_ram_009d3e38 = 0;
		    uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    goto code_r0x80e5b9b9;
		  }
		code_r0x80e5b4ce:
		  DAT_ram_009d3e38 = 0;
		  uVar7 = import::env::invoke_iii(*puVar6,piVar10,puVar6[1]);
		  if (DAT_ram_009d3e38 == 1) goto code_r0x80e5b5dc;
		  DAT_ram_009d3e38 = 0;
		  uVar7 = import::env::invoke_iiii
		                    (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x6a,uVar7,
		                     *(undefined4 *)(*(int *)(iVar11 + 0x10) + 0x18),0);
		  iVar13 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar13 == 1) {
		    uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    goto code_r0x80e5b9b9;
		  }
		  if (*(int *)(*(int *)(iVar11 + 0x10) + 0x48) == 0) {
		    DAT_ram_009d3e38 = 0;
		    uVar4 = import::env::invoke_ii
		                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                       Gameplay_Medals_Model_MedalDicGroup_TypeInfo);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80e5b5b4:
		      DAT_ram_009d3e38 = 0;
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e5b9b9;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_vii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x6b,uVar4,uVar4);
		    iVar13 = Method_System_Collections_Generic_List_MedalDicGroup__Add__;
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80e5b5b4;
		    iVar8 = *(int *)(param1 + 0xc);
		    *(int *)(iVar8 + 0x10) = *(int *)(iVar8 + 0x10) + 1;
		    uVar1 = *(uint *)(iVar8 + 0xc);
		    if (uVar1 < *(uint *)(*(int *)(iVar8 + 8) + 0xc)) {
		      *(uint *)(iVar8 + 0xc) = uVar1 + 1;
		      *(undefined4 *)(*(int *)(iVar8 + 8) + uVar1 * 4 + 0x10) = uVar4;
		    }
		    else {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_viii
		                (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,iVar8,uVar4,
		                 *(undefined4 *)(*(int *)(*(int *)(iVar13 + 0x10) + 0x60) + 0x38));
		      iVar13 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar13 == 1) {
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80e5b9b9;
		      }
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viiiii
		              (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x6c,uVar4,iVar11,uVar12,uVar7,
		               uVar4);
		    iVar13 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar13 == 1) {
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e5b9b9;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viiii
		              (s_struct_Uniforms___color__array<v_ram_00000aff + 0x22c,*(undefined4 *)(param1 + 8),
		               *(undefined4 *)(*(int *)(iVar11 + 0x10) + 0xc),uVar4,
		               Method_System_Collections_Generic_Dictionary_uint__MedalDicGroup__set_Item__);
		    iVar11 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar11 == 1) goto code_r0x80e5b993;
		    goto code_r0x80e5b13f;
		  }
		  DAT_ram_009d3e38 = 0;
		  iVar8 = import::env::invoke_iiii
		                    (s_struct_Uniforms___color__array<v_ram_00000aff + 0x3c1,uVar3,uVar4,
		                     Method_System_Collections_Generic_Dictionary_uint__MedalDicGroup__ContainsKey__
		                    );
		  iVar13 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar13 == 1) {
		    uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    goto code_r0x80e5b9b9;
		  }
		  if (iVar8 == 0) {
		    DAT_ram_009d3e38 = 0;
		    uVar9 = import::env::invoke_ii
		                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                       Gameplay_Medals_Model_MedalDicGroup_TypeInfo);
		    iVar13 = DAT_ram_009d3e38;
		    if (DAT_ram_009d3e38 != 1) {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x6b,uVar9,iVar13);
		      if (DAT_ram_009d3e38 != 1) {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viiii
		                  (s_struct_Uniforms___color__array<v_ram_00000aff + 0x22c,uVar3,uVar4,uVar9,
		                   Method_System_Collections_Generic_Dictionary_uint__MedalDicGroup__set_Item__);
		        iVar8 = DAT_ram_009d3e38;
		        iVar13 = Method_System_Collections_Generic_List_MedalDicGroup__Add__;
		        DAT_ram_009d3e38 = 0;
		        if (iVar8 == 1) {
		          uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80e5b9b9;
		        }
		        iVar8 = *(int *)(param1 + 0xc);
		        *(int *)(iVar8 + 0x10) = *(int *)(iVar8 + 0x10) + 1;
		        uVar1 = *(uint *)(iVar8 + 0xc);
		        if (uVar1 < *(uint *)(*(int *)(iVar8 + 8) + 0xc)) {
		          *(uint *)(iVar8 + 0xc) = uVar1 + 1;
		          *(undefined4 *)(*(int *)(iVar8 + 8) + uVar1 * 4 + 0x10) = uVar9;
		          goto code_r0x80e5b75c;
		        }
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,iVar8,uVar9,
		                   *(undefined4 *)(*(int *)(*(int *)(iVar13 + 0x10) + 0x60) + 0x38));
		        iVar13 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar13 == 1) {
		          uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80e5b9b9;
		        }
		        goto code_r0x80e5b75c;
		      }
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    goto code_r0x80e5b9b9;
		  }
		code_r0x80e5b75c:
		  DAT_ram_009d3e38 = 0;
		  uVar9 = import::env::invoke_iiii
		                    (s_struct_Uniforms___color__array<v_ram_00000aff + 0x22b,uVar3,uVar4,
		                     Method_System_Collections_Generic_Dictionary_uint__MedalDicGroup__get_Item__);
		  iVar13 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar13 == 1) {
		    uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    goto code_r0x80e5b9b9;
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_viiiii
		            (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x6c,uVar9,iVar11,uVar12,uVar7,iVar13
		            );
		  iVar13 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar13 == 1) {
		    uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    goto code_r0x80e5b9b9;
		  }
		  uVar12 = *(undefined4 *)(param1 + 8);
		  uVar7 = *(undefined4 *)(*(int *)(iVar11 + 0x10) + 0xc);
		  DAT_ram_009d3e38 = 0;
		  uVar4 = import::env::invoke_iiii
		                    (s_struct_Uniforms___color__array<v_ram_00000aff + 0x22b,uVar3,uVar4,
		                     Method_System_Collections_Generic_Dictionary_uint__MedalDicGroup__get_Item__);
		  if (DAT_ram_009d3e38 != 1) {
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viiii
		              (s_struct_Uniforms___color__array<v_ram_00000aff + 0x22c,uVar12,uVar7,uVar4,
		               Method_System_Collections_Generic_Dictionary_uint__MedalDicGroup__set_Item__);
		    if (DAT_ram_009d3e38 != 1) goto code_r0x80e5b13f;
		  }
		  DAT_ram_009d3e38 = 0;
		  uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		  goto code_r0x80e5b9b9;
		code_r0x80e5b993:
		  uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80e5b9b9:
		  iVar2 = global_1;
		  iVar11 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar2 == iVar11) {
		    piVar10 = (int *)import::env::__cxa_begin_catch(uVar3);
		    local_c = *piVar10;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_v(0x123);
		    iVar2 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar2 != 1) {
		code_r0x80e5ba02:
		      DAT_ram_009d3e38 = 0;
		      piVar10 = *local_8;
		      if (piVar10 != (int *)0x0) {
		        uVar1 = 0;
		        iVar2 = *piVar10;
		        if (*(ushort *)(iVar2 + 0xb6) != 0) {
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		              puVar5 = (uint *)(iVar2 + *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0)
		              ;
		              goto code_r0x80e5ba7d;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		        }
		        puVar5 = (uint *)func_ii_1080(piVar10,System_IDisposable_TypeInfo,0);
		code_r0x80e5ba7d:
		        (**(code **)((ulonglong)*puVar5 * 4))(piVar10,puVar5[1]);
		      }
		      if (local_c == 0) {
		        return;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(local_c);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar3 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x6d,&local_c);
		  iVar2 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar2 == 1) {
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  import::env::__resumeException(uVar3);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

			return 0U;
		}

		// Token: 0x06002556 RID: 9558 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002556")]
		[Address(RVA = "0x769D", Offset = "0x769D", VA = "0x769D")]
		private void Init(IDictProvider dictProvider)
		{
		/* --- GHIDRA: Init ---
		void Gameplay_Medals_Model_MedalDicGroupStorage__Init(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  int param3;
		  
		  if (DAT_ram_00a57da6 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__MedalDicGroup__Clear__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_MedalDicGroup__Clear__);
		    DAT_ram_00a57da6 = '\x01';
		  }
		  iVar1 = *(int *)(param1 + 0xc);
		  param3 = *(int *)(iVar1 + 0xc);
		  *(undefined4 *)(iVar1 + 0xc) = 0;
		  *(int *)(iVar1 + 0x10) = *(int *)(iVar1 + 0x10) + 1;
		  if (0 < param3) {
		    func_ii_2064(*(undefined4 *)(iVar1 + 8),0,param3,0);
		  }
		  System_Xml_XmlWellFormedWriter__PushNamespaceImplicit
		            (*(undefined4 *)(param1 + 8),
		             Method_System_Collections_Generic_Dictionary_uint__MedalDicGroup__Clear__);
		  *(undefined8 *)(param1 + 8) = 0;
		  return;
		}
		*/

		}

		// Token: 0x06002557 RID: 9559 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002557")]
		[Address(RVA = "0x769E", Offset = "0x769E", VA = "0x769E", Slot = "4")]
		public void Dispose()
		{
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_MedalDicGroups ---
		void Gameplay_Medals_Model_MedalDicGroupStorage__set_MedalDicGroups
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  Gameplay_Medals_Model_MedalDicGroupStorage__GetMaxRank(param1,param2,param1);
		  return;
		}
		*/

}
