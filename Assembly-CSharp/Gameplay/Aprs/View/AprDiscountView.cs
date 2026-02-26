using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Gameplay.Aprs.Model;
using Gameplay.Discounts.Model;
using Gameplay.Discounts.View;
using Il2CppDummyDll;
using Protocol.Consts;
using UnityEngine;

namespace Gameplay.Aprs.View
{
	// Token: 0x02000D4D RID: 3405
	[Token(Token = "0x2000D4D")]
	public class AprDiscountView : MonoBehaviour, IDiscountTarget
	{
		// Token: 0x170010EE RID: 4334
		// (get) Token: 0x06005361 RID: 21345 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170010EE")]
		public DiscountTargets[] DiscountTargets
		{
			[Token(Token = "0x6005361")]
			[Address(RVA = "0xA120", Offset = "0xA120", VA = "0xA120", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x170010EF RID: 4335
		// (get) Token: 0x06005362 RID: 21346 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005363 RID: 21347 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170010EF")]
		public AprData AprData
		{
			[Token(Token = "0x6005362")]
			[Address(RVA = "0xA121", Offset = "0xA121", VA = "0xA121")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005363")]
			[Address(RVA = "0xA122", Offset = "0xA122", VA = "0xA122")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06005364 RID: 21348 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005364")]
		[Address(RVA = "0xA123", Offset = "0xA123", VA = "0xA123")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void Gameplay_Aprs_View_AprDiscountView__OnDestroy(int param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 *puVar3;
		  undefined4 uVar4;
		  int *piVar5;
		  int iVar6;
		  int iVar7;
		  int iVar8;
		  int iVar9;
		  int iVar10;
		  int *piVar11;
		  int local_c;
		  int **local_8;
		  int *local_4;
		  
		  iVar8 = 0;
		  if (DAT_ram_00a593e2 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Aprs_Discounts_AprDiscountArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Discounts_Model_IDiscountArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerable_IDiscountArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerator_IDiscountArgs__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    DAT_ram_00a593e2 = '\x01';
		  }
		  local_4 = (int *)0x0;
		  iVar6 = *(int *)(param1 + 0x18);
		  if (DAT_ram_00a59431 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_SortedList_uint__MedalInfo__get_Count__);
		    DAT_ram_00a59431 = '\x01';
		  }
		  if (*(int *)(*(int *)(iVar6 + 0x28) + 0x10) < 1) {
		    iVar6 = *(int *)(param1 + 0x10);
		    if (0 < *(int *)(iVar6 + 0xc)) {
		      do {
		        iVar7 = *(int *)(iVar6 + iVar8 * 4 + 0x10);
		        iVar10 = *param2;
		        if (*(ushort *)(iVar10 + 0xb6) != 0) {
		          uVar1 = 0;
		          do {
		            piVar5 = (int *)(*(int *)(iVar10 + 0x58) + uVar1 * 8);
		            if (System_Collections_Generic_IEnumerable_IDiscountArgs__TypeInfo == *piVar5) {
		              puVar2 = (uint *)(iVar10 + piVar5[1] * 8 + 0xc0);
		              goto code_r0x80ffc2cf;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar10 + 0xb6) != uVar1);
		        }
		        puVar2 = (uint *)func_ii_1080(param2,
		                                      System_Collections_Generic_IEnumerable_IDiscountArgs__TypeInfo
		                                      ,0);
		code_r0x80ffc2cf:
		        local_4 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		        local_c = 0;
		        local_8 = &local_4;
		        do {
		          do {
		            piVar5 = local_4;
		            iVar10 = *local_4;
		            if (*(ushort *)(iVar10 + 0xb6) != 0) {
		              uVar1 = 0;
		              do {
		                piVar11 = (int *)(*(int *)(iVar10 + 0x58) + uVar1 * 8);
		                if (System_Collections_IEnumerator_TypeInfo == *piVar11) {
		                  puVar3 = (undefined4 *)(iVar10 + piVar11[1] * 8 + 0xc0);
		                  goto code_r0x80ffc392;
		                }
		                uVar1 = uVar1 + 1;
		              } while (*(ushort *)(iVar10 + 0xb6) != uVar1);
		            }
		            DAT_ram_009d3e38 = 0;
		            puVar3 = (undefined4 *)
		                     import::env::invoke_iiii
		                               (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                                System_Collections_IEnumerator_TypeInfo,0);
		            if (DAT_ram_009d3e38 == 1) goto code_r0x80ffc6ee;
		code_r0x80ffc392:
		            DAT_ram_009d3e38 = 0;
		            iVar10 = import::env::invoke_iii(*puVar3,piVar5,puVar3[1]);
		            piVar5 = local_4;
		            if (DAT_ram_009d3e38 == 1) goto code_r0x80ffc6ee;
		            if (iVar10 == 0) {
		              iVar10 = 8;
		              iVar7 = 0;
		              goto code_r0x80ffc77c;
		            }
		            iVar10 = *local_4;
		            if (*(ushort *)(iVar10 + 0xb6) != 0) {
		              uVar1 = 0;
		              do {
		                piVar11 = (int *)(*(int *)(iVar10 + 0x58) + uVar1 * 8);
		                if (System_Collections_Generic_IEnumerator_IDiscountArgs__TypeInfo == *piVar11) {
		                  puVar3 = (undefined4 *)(iVar10 + piVar11[1] * 8 + 0xc0);
		                  goto code_r0x80ffc478;
		                }
		                uVar1 = uVar1 + 1;
		              } while (*(ushort *)(iVar10 + 0xb6) != uVar1);
		            }
		            DAT_ram_009d3e38 = 0;
		            puVar3 = (undefined4 *)
		                     import::env::invoke_iiii
		                               (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                                System_Collections_Generic_IEnumerator_IDiscountArgs__TypeInfo,0);
		            if (DAT_ram_009d3e38 == 1) goto code_r0x80ffc6ee;
		code_r0x80ffc478:
		            DAT_ram_009d3e38 = 0;
		            piVar5 = (int *)import::env::invoke_iii(*puVar3,piVar5,puVar3[1]);
		            if (DAT_ram_009d3e38 == 1) goto code_r0x80ffc6ee;
		            iVar10 = *piVar5;
		            if (*(ushort *)(iVar10 + 0xb6) != 0) {
		              uVar1 = 0;
		              do {
		                piVar11 = (int *)(*(int *)(iVar10 + 0x58) + uVar1 * 8);
		                if (Gameplay_Discounts_Model_IDiscountArgs_TypeInfo == *piVar11) {
		                  puVar3 = (undefined4 *)(iVar10 + piVar11[1] * 8 + 0xc0);
		                  goto code_r0x80ffc549;
		                }
		                uVar1 = uVar1 + 1;
		              } while (*(ushort *)(iVar10 + 0xb6) != uVar1);
		            }
		            DAT_ram_009d3e38 = 0;
		            puVar3 = (undefined4 *)
		                     import::env::invoke_iiii
		                               (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar5,
		                                Gameplay_Discounts_Model_IDiscountArgs_TypeInfo,0);
		            if (DAT_ram_009d3e38 == 1) goto code_r0x80ffc6ee;
		code_r0x80ffc549:
		            DAT_ram_009d3e38 = 0;
		            iVar10 = import::env::invoke_iii(*puVar3,piVar5,puVar3[1]);
		            if (DAT_ram_009d3e38 == 1) goto code_r0x80ffc6ee;
		          } while (iVar10 != iVar7);
		          if (((uint)*(byte *)(*piVar5 + 0xb8) <
		               (uint)*(byte *)(Gameplay_Aprs_Discounts_AprDiscountArgs_TypeInfo + 0xb8)) ||
		             (*(int *)(*(int *)(*piVar5 + 100) +
		                       (uint)*(byte *)(Gameplay_Aprs_Discounts_AprDiscountArgs_TypeInfo + 0xb8) * 4
		                      + -4) != Gameplay_Aprs_Discounts_AprDiscountArgs_TypeInfo)) {
		            DAT_ram_009d3e38 = 0;
		            import::env::invoke_vii
		                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x183,piVar5,
		                       Gameplay_Aprs_Discounts_AprDiscountArgs_TypeInfo);
		            if (DAT_ram_009d3e38 != 1) {
		              do {
		                halt_trap();
		              } while( true );
		            }
		            goto code_r0x80ffc6ee;
		          }
		          iVar10 = *(int *)piVar5[5];
		          DAT_ram_009d3e38 = 0;
		          iVar10 = import::env::invoke_iiii
		                             (*(undefined4 *)(iVar10 + 0xc0),(int *)piVar5[5],
		                              *(undefined4 *)(*(int *)(param1 + 0x18) + 0x14),
		                              *(undefined4 *)(iVar10 + 0xc4));
		          if (DAT_ram_009d3e38 == 1) goto code_r0x80ffc6ee;
		          DAT_ram_009d3e38 = 0;
		          uVar4 = import::env::invoke_iii
		                            (s_struct_Uniforms___color__array<v_ram_00000aff + 0x25c,param1,0);
		          if (DAT_ram_009d3e38 == 1) goto code_r0x80ffc6ee;
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_viii
		                    (s_struct_Uniforms___color__array<v_ram_000013c7 + 0x26d,uVar4,iVar10,0);
		          if (DAT_ram_009d3e38 == 1) goto code_r0x80ffc6ee;
		        } while (iVar10 == 0);
		        iVar7 = 0;
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x2a1,
		                   *(undefined4 *)(param1 + 0x14),piVar5,0);
		        iVar10 = 7;
		        if (DAT_ram_009d3e38 == 1) {
		code_r0x80ffc6ee:
		          DAT_ram_009d3e38 = 0;
		          uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          iVar7 = global_1;
		          iVar10 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		          if (iVar7 != iVar10) {
		code_r0x80ffc746:
		            DAT_ram_009d3e38 = 0;
		            import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x2a2,&local_c)
		            ;
		            iVar8 = DAT_ram_009d3e38;
		            DAT_ram_009d3e38 = 0;
		            if (iVar8 != 1) {
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
		          piVar5 = (int *)import::env::__cxa_begin_catch(uVar4);
		          iVar7 = *piVar5;
		          iVar10 = 0;
		          DAT_ram_009d3e38 = 0;
		          local_c = iVar7;
		          import::env::invoke_v(0x123);
		          iVar9 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar9 == 1) {
		            uVar4 = import::env::__cxa_find_matching_catch_2();
		            goto code_r0x80ffc746;
		          }
		        }
		code_r0x80ffc77c:
		        piVar5 = local_4;
		        DAT_ram_009d3e38 = 0;
		        if (local_4 != (int *)0x0) {
		          iVar9 = *local_4;
		          if (*(ushort *)(iVar9 + 0xb6) != 0) {
		            uVar1 = 0;
		            do {
		              piVar11 = (int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8);
		              if (System_IDisposable_TypeInfo == *piVar11) {
		                puVar2 = (uint *)(iVar9 + piVar11[1] * 8 + 0xc0);
		                goto code_r0x80ffc7f0;
		              }
		              uVar1 = uVar1 + 1;
		            } while (*(ushort *)(iVar9 + 0xb6) != uVar1);
		          }
		          puVar2 = (uint *)func_ii_1080(local_4,System_IDisposable_TypeInfo,0);
		code_r0x80ffc7f0:
		          (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		        }
		        if (iVar7 != 0) {
		          System_Data_DataSet__ValidateLocaleConstraint(iVar7);
		          do {
		            halt_trap();
		          } while( true );
		        }
		      } while (((iVar10 == 0) ||
		               (((((iVar10 != 1 && (iVar10 != 2)) && (iVar10 != 3)) &&
		                 ((iVar10 != 4 && (iVar10 != 5)))) &&
		                ((iVar10 != 6 && ((iVar10 != 7 && (iVar10 == 8)))))))) &&
		              (iVar8 = iVar8 + 1, iVar8 < *(int *)(iVar6 + 0xc)));
		    }
		  }
		  else {
		    uVar4 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (param1,0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar4,0,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06005365 RID: 21349 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005365")]
		[Address(RVA = "0xA124", Offset = "0xA124", VA = "0xA124", Slot = "5")]
		public void Setup(IEnumerable<IDiscountArgs> value)
		{
		}

		// Token: 0x06005366 RID: 21350 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005366")]
		[Address(RVA = "0xA125", Offset = "0xA125", VA = "0xA125")]
		public AprDiscountView()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Aprs_View_AprDiscountView___ctor(undefined4 param1,undefined4 param2)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a593e3 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_AprGridView__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Aprs_View_AprGridView_TypeInfo);
		    DAT_ram_00a593e3 = '\x01';
		  }
		  param1_00 = **(int **)(Gameplay_Aprs_View_AprGridView_TypeInfo + 0x5c);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param1,0);
		    param2_00 = System_Action_AprGridView__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_AprGridView__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(*(undefined4 *)(Gameplay_Aprs_View_AprGridView_TypeInfo + 0x5c),iVar2,
		                         param1_00);
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

		// Token: 0x04002D27 RID: 11559
		[Token(Token = "0x4002D27")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private DiscountTargets[] _discountTargets;

		// Token: 0x04002D28 RID: 11560
		[Token(Token = "0x4002D28")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private DiscountGroup _discountGroup;
	}
}
