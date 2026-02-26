using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Gameplay.Managers;
using Il2CppDummyDll;
using MVC;
using Protocol.Dic;
using UI.Elements.Filters.GenericFilter;

namespace Gameplay.WorldAxis.Office.Model
{
	// Token: 0x020002D4 RID: 724
	[Token(Token = "0x20002D4")]
	public class SeasonRewardsModel : AbstractModel
	{
		// Token: 0x17000286 RID: 646
		// (get) Token: 0x06001118 RID: 4376 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000286")]
		public Dictionaries Dict
		{
			[Token(Token = "0x6001118")]
			[Address(RVA = "0x6315", Offset = "0x6315", VA = "0x6315")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001119 RID: 4377 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001119")]
		[Address(RVA = "0x6316", Offset = "0x6316", VA = "0x6316")]
		public SeasonRewardsModel(UserData user)
		{
		}

		// Token: 0x17000287 RID: 647
		// (get) Token: 0x0600111A RID: 4378 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600111B RID: 4379 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000287")]
		public RatingPrizeDic[] UserPrizes
		{
			[Token(Token = "0x600111A")]
			[Address(RVA = "0x6317", Offset = "0x6317", VA = "0x6317")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600111B")]
			[Address(RVA = "0x6318", Offset = "0x6318", VA = "0x6318")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000288 RID: 648
		// (get) Token: 0x0600111C RID: 4380 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600111D RID: 4381 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000288")]
		public RatingPrizeDic[] ClanPrizes
		{
			[Token(Token = "0x600111C")]
			[Address(RVA = "0x6319", Offset = "0x6319", VA = "0x6319")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600111D")]
			[Address(RVA = "0x631A", Offset = "0x631A", VA = "0x631A")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000289 RID: 649
		// (get) Token: 0x0600111E RID: 4382 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600111F RID: 4383 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000289")]
		public FilterListElement.FilterData[] FilterDatas
		{
			[Token(Token = "0x600111E")]
			[Address(RVA = "0x631B", Offset = "0x631B", VA = "0x631B")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600111F")]
			[Address(RVA = "0x631C", Offset = "0x631C", VA = "0x631C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x040008E1 RID: 2273
		[Token(Token = "0x40008E1")]
		[FieldOffset(Offset = "0xC")]
		private DictManager _dictManager;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Dict ---
		/* WARNING: Removing unreachable block (ram,0x80f77a47) */
		
		void Gameplay_WorldAxis_Office_Model_SeasonRewardsModel__get_Dict
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  uint uVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  int iVar5;
		  undefined4 uVar6;
		  int iVar7;
		  int *piVar8;
		  int iVar9;
		  undefined4 *puVar10;
		  undefined4 local_24;
		  int local_20;
		  undefined8 *puStack_1c;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a58b1e == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Select_RatingPrizeDic__uint___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToHashSet_uint___);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_HashSet_Enumerator_uint__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_HashSet_Enumerator_uint__MoveNext__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_HashSet_Enumerator_uint__get_Current__);
		    Mono_Security_ASN1__get_Item
		              (&UI_Elements_Filters_GenericFilter_FilterListElement_FilterData___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&UI_Elements_Filters_GenericFilter_FilterListElement_FilterData_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Func_RatingPrizeDic__uint__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_HashSet_uint__GetEnumerator__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_HashSet_uint__get_Count__);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_WorldAxis_Office_Model_SeasonRewardsModel___c___ctor_b__3_0__);
		    Mono_Security_ASN1__get_Item(&Gameplay_WorldAxis_Office_Model_SeasonRewardsModel___c_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_17796);
		    DAT_ram_00a58b1e = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  Unity_Services_Core_Environments_Internal_Environments__get_Current(param1,param2,0);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar2 = 0;
		  piVar8 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar9 = *piVar8;
		  if (*(ushort *)(iVar9 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar9 + 0x58) + uVar2 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar9 + 0x58) + uVar2 * 8 + 4) * 8 + iVar9 + 0x178);
		        goto code_r0x80f775dc;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar9 + 0xb6) != uVar2);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar8,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80f775dc:
		  uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(piVar8,puVar3[1]);
		  *(undefined4 *)(param1 + 0xc) = uVar4;
		  uVar4 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar4,0);
		  uVar4 = Core_Extensions_Dict_DictExt__GetGreatRewardSet(uVar4,0xb,0);
		  *(undefined4 *)(param1 + 0x10) = uVar4;
		  if (*(int *)(Gameplay_WorldAxis_Office_Model_SeasonRewardsModel___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_WorldAxis_Office_Model_SeasonRewardsModel___c_TypeInfo);
		  }
		  puVar10 = *(undefined4 **)(Gameplay_WorldAxis_Office_Model_SeasonRewardsModel___c_TypeInfo + 0x5c)
		  ;
		  iVar9 = puVar10[1];
		  if (iVar9 == 0) {
		    if (*(int *)(Gameplay_WorldAxis_Office_Model_SeasonRewardsModel___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_WorldAxis_Office_Model_SeasonRewardsModel___c_TypeInfo);
		      puVar10 = *(undefined4 **)
		                 (Gameplay_WorldAxis_Office_Model_SeasonRewardsModel___c_TypeInfo + 0x5c);
		    }
		    uVar6 = *puVar10;
		    iVar9 = unnamed_function_1417(System_Func_RatingPrizeDic__uint__TypeInfo);
		    System_Collections_Generic_Dictionary_KeyCollection_uint__object___GetEnumerator
		              (iVar9,uVar6,
		               Method_Gameplay_WorldAxis_Office_Model_SeasonRewardsModel___c___ctor_b__3_0__,0);
		    *(int *)(*(int *)(Gameplay_WorldAxis_Office_Model_SeasonRewardsModel___c_TypeInfo + 0x5c) + 4) =
		         iVar9;
		  }
		  uVar4 = System_Linq_Enumerable__ReverseIterator___Il2CppFullySharedGenericType_
		                    (uVar4,iVar9,Method_System_Linq_Enumerable_Select_RatingPrizeDic__uint___);
		  iVar9 = System_Linq_Enumerable__ToHashSet_int_
		                    (uVar4,Method_System_Linq_Enumerable_ToHashSet_uint___);
		  uVar4 = Mono_Security_ASN1Convert__ToOid
		                    (UI_Elements_Filters_GenericFilter_FilterListElement_FilterData___TypeInfo,
		                     *(undefined4 *)(iVar9 + 0x10));
		  *(undefined4 *)(param1 + 0x18) = uVar4;
		  Sirenix_Utilities_TypeExtensions__AreGenericConstraintsSatisfiedBy
		            (&local_20,iVar9,Method_System_Collections_Generic_HashSet_uint__GetEnumerator__);
		  local_8 = local_18;
		  local_20 = 0;
		  puStack_1c = &local_10;
		  iVar9 = 0;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar5 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x16d,&local_10,
		                       Method_System_Collections_Generic_HashSet_Enumerator_uint__MoveNext__);
		    iVar7 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar7 == 1) {
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80f77bb8:
		      iVar9 = global_1;
		      iVar7 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar9 == iVar7) {
		        piVar8 = (int *)import::env::__cxa_begin_catch(uVar4);
		        iVar9 = *piVar8;
		        iVar7 = 0;
		        DAT_ram_009d3e38 = 0;
		        local_20 = iVar9;
		        import::env::invoke_v(0x123);
		        iVar5 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar5 != 1) {
		code_r0x80f77c05:
		          DAT_ram_009d3e38 = 0;
		          if (iVar9 == 0) {
		            if ((iVar7 == 0) ||
		               ((((iVar7 != 1 && (iVar7 != 2)) && (iVar7 != 3)) &&
		                (((iVar7 != 4 && (iVar7 != 5)) && ((iVar7 != 6 && (iVar7 == 7)))))))) {
		              uVar4 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System
		                                (*(undefined4 *)(param1 + 0xc),0);
		              uVar4 = Core_Extensions_Dict_DictExt__GetUserPrizesByKindId(uVar4,5,0);
		              *(undefined4 *)(param1 + 0x14) = uVar4;
		            }
		            return;
		          }
		          System_Data_DataSet__ValidateLocaleConstraint(iVar9);
		          do {
		            halt_trap();
		          } while( true );
		        }
		        uVar4 = import::env::__cxa_find_matching_catch_2();
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x245,&local_20);
		      iVar9 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar9 == 1) {
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
		    if (iVar5 == 0) {
		      iVar7 = 7;
		      iVar9 = local_20;
		      goto code_r0x80f77c05;
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar4 = local_8._4_4_;
		    uVar6 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System
		                      (*(undefined4 *)(param1 + 0xc),0);
		    iVar7 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar7 == 1) {
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80f77bb8;
		    }
		    DAT_ram_009d3e38 = 0;
		    iVar5 = import::env::invoke_iiii
		                      (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x243,uVar6,uVar4,0);
		    iVar7 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar7 == 1) {
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80f77bb8;
		    }
		    piVar8 = *(int **)(param1 + 0x18);
		    if (iVar5 != 0) {
		      DAT_ram_009d3e38 = 0;
		      iVar7 = import::env::invoke_ii
		                        (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                         UI_Elements_Filters_GenericFilter_FilterListElement_FilterData_TypeInfo);
		      if (DAT_ram_009d3e38 == 1) {
		        DAT_ram_009d3e38 = 0;
		        uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80f77bb8;
		      }
		      local_24 = uVar4;
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::invoke_iii
		                        (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x19,DAT_ram_00a66958,
		                         &local_24);
		      iVar1 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar1 == 1) {
		        uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80f77bb8;
		      }
		      *(undefined4 *)(iVar7 + 0xc) = uVar4;
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::invoke_iii
		                        (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x244,iVar5,0);
		      if (DAT_ram_009d3e38 != 1) {
		        *(undefined4 *)(iVar7 + 8) = uVar4;
		        DAT_ram_009d3e38 = 0;
		        iVar5 = import::env::invoke_iii
		                          (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1a,iVar7,
		                           *(undefined4 *)(*piVar8 + 0x20));
		        if (DAT_ram_009d3e38 != 1) {
		          if (iVar5 != 0) {
		            piVar8[iVar9 + 4] = iVar7;
		            goto code_r0x80f77b79;
		          }
		          DAT_ram_009d3e38 = 0;
		          uVar4 = import::env::invoke_i(s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1b);
		          if (DAT_ram_009d3e38 != 1) {
		            DAT_ram_009d3e38 = 0;
		            import::env::invoke_vii(0x41b,uVar4,0);
		            if (DAT_ram_009d3e38 != 1) goto code_r0x80f77c94;
		          }
		          DAT_ram_009d3e38 = 0;
		          uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80f77bb8;
		        }
		      }
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80f77bb8;
		    }
		    DAT_ram_009d3e38 = 0;
		    iVar7 = import::env::invoke_ii
		                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                       UI_Elements_Filters_GenericFilter_FilterListElement_FilterData_TypeInfo);
		    if (DAT_ram_009d3e38 == 1) {
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80f77bb8;
		    }
		    local_24 = uVar4;
		    DAT_ram_009d3e38 = 0;
		    uVar4 = import::env::invoke_iii
		                      (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x19,DAT_ram_00a66958,
		                       &local_24);
		    iVar5 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar5 == 1) {
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80f77bb8;
		    }
		    *(undefined4 *)(iVar7 + 0xc) = uVar4;
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi
		                (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                 Core_GameLocalization_TypeInfo);
		      iVar5 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar5 == 1) {
		        uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80f77bb8;
		      }
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar4 = import::env::invoke_iiiiiiiii
		                      (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x392,StringLiteral_17796,1
		                       ,0,1,0,0,0,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80f779e2:
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80f77bb8;
		    }
		    *(undefined4 *)(iVar7 + 8) = uVar4;
		    DAT_ram_009d3e38 = 0;
		    iVar5 = import::env::invoke_iii
		                      (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1a,iVar7,
		                       *(undefined4 *)(*piVar8 + 0x20));
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80f779e2;
		    if (iVar5 == 0) {
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::invoke_i(s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1b);
		      if (DAT_ram_009d3e38 != 1) {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vii(0x41b,uVar4,0);
		        if (DAT_ram_009d3e38 != 1) {
		code_r0x80f77c94:
		          do {
		            halt_trap();
		          } while( true );
		        }
		      }
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80f77bb8;
		    }
		    piVar8[iVar9 + 4] = iVar7;
		code_r0x80f77b79:
		    iVar9 = iVar9 + 1;
		  } while( true );
		}
		*/


		/* --- GHIDRA: set_FilterDatas ---
		void Gameplay_WorldAxis_Office_Model_SeasonRewardsModel__set_FilterDatas(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a58b1f == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_WorldAxis_Office_Model_SeasonRewardsModel___c_TypeInfo);
		    DAT_ram_00a58b1f = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Gameplay_WorldAxis_Office_Model_SeasonRewardsModel___c_TypeInfo);
		  **(undefined4 **)(Gameplay_WorldAxis_Office_Model_SeasonRewardsModel___c_TypeInfo + 0x5c) = uVar1;
		  return;
		}
		*/

}
