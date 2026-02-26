using System;
using Il2CppDummyDll;

namespace Gameplay.Inventory.View.ContextMenu
{
	// Token: 0x0200067F RID: 1663
	[Token(Token = "0x200067F")]
	public class ItemContextMenuOptions
	{
		// Token: 0x0600284E RID: 10318 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600284E")]
		[Address(RVA = "0x796E", Offset = "0x796E", VA = "0x796E")]
		public ItemContextMenuOptions()
		{
		/* --- GHIDRA: .ctor ---
		undefined4 Gameplay_Inventory_View_ContextMenu_ItemContextMenuOptions___ctor(undefined4 param1)
		
		{
		  uint uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  undefined4 *puVar4;
		  int iVar5;
		  int iVar6;
		  int *piVar7;
		  uint *puVar8;
		  int iVar9;
		  int *piVar10;
		  int local_14;
		  int **local_10;
		  int *local_c;
		  int local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a5a0e4 == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Dic_ArtikulMenuActionDic_Types_Actions_var);
		    Mono_Security_ASN1__get_Item(&Protocol_Dic_ArtikulMenuActionDic_Types_Actions_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Inventory_View_ContextMenu_ArtifactContextMenuUtils_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_HashSet_ArtikulMenuActionDic_Types_Actions__Contains__
		              );
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ArtikulMenuActionDic_Types_Actions__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ArtikulMenuActionDic_Types_Actions__ToArray__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ArtikulMenuActionDic_Types_Actions___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_List_ArtikulMenuActionDic_Types_Actions__TypeInfo);
		    DAT_ram_00a5a0e4 = '\x01';
		  }
		  local_4 = (int *)0x0;
		  local_8 = 0;
		  if (*(int *)(Gameplay_Inventory_View_ContextMenu_ArtifactContextMenuUtils_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_Inventory_View_ContextMenu_ArtifactContextMenuUtils_TypeInfo);
		  }
		  iVar2 = Gameplay_Inventory_View_ContextMenu_ArtifactContextMenuUtils_TypeInfo;
		  if (*(int *)(*(int *)(Gameplay_Inventory_View_ContextMenu_ArtifactContextMenuUtils_TypeInfo + 0x5c
		                       ) + 8) != 0) {
		code_r0x811ca2c3:
		    if (*(int *)(iVar2 + 0x74) == 0) {
		      func_ii_306000(iVar2);
		      iVar2 = Gameplay_Inventory_View_ContextMenu_ArtifactContextMenuUtils_TypeInfo;
		    }
		    return *(undefined4 *)(*(int *)(iVar2 + 0x5c) + 8);
		  }
		  iVar2 = unnamed_function_1417
		                    (System_Collections_Generic_List_ArtikulMenuActionDic_Types_Actions__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (iVar2,
		             Method_System_Collections_Generic_List_ArtikulMenuActionDic_Types_Actions___ctor__);
		  uVar3 = Protocol_Dic_ArtikulMenuActionDic_Types_Actions_var;
		  if (*(int *)(DAT_ram_00a669a0 + 0x74) == 0) {
		    func_ii_306000(DAT_ram_00a669a0);
		  }
		  uVar3 = func_ii_2734(uVar3,0);
		  if (*(int *)(DAT_ram_00a6697c + 0x74) == 0) {
		    func_ii_306000(DAT_ram_00a6697c);
		  }
		  uVar3 = System_Enum__GetUnderlyingType(uVar3,0);
		  local_4 = (int *)System_Array__Sort(uVar3,0);
		  local_c = &local_8;
		  local_14 = 0;
		  local_10 = &local_4;
		code_r0x811c9d6a:
		  do {
		    do {
		      piVar7 = local_4;
		      iVar9 = *local_4;
		      if (*(ushort *)(iVar9 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          piVar10 = (int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8);
		          if (System_Collections_IEnumerator_TypeInfo == *piVar10) {
		            puVar4 = (undefined4 *)(iVar9 + piVar10[1] * 8 + 0xc0);
		            goto code_r0x811c9e10;
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
		code_r0x811c9e58:
		        DAT_ram_009d3e38 = 0;
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x811ca12b;
		      }
		code_r0x811c9e10:
		      DAT_ram_009d3e38 = 0;
		      iVar9 = import::env::invoke_iii(*puVar4,piVar7,puVar4[1]);
		      piVar7 = local_4;
		      if (DAT_ram_009d3e38 == 1) goto code_r0x811c9e58;
		      if (iVar9 == 0) {
		        iVar9 = 5;
		        goto code_r0x811ca178;
		      }
		      iVar9 = *local_4;
		      if (*(ushort *)(iVar9 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          piVar10 = (int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8);
		          if (System_Collections_IEnumerator_TypeInfo == *piVar10) {
		            puVar4 = (undefined4 *)(piVar10[1] * 8 + iVar9 + 200);
		            goto code_r0x811c9f01;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar9 + 0xb6) != uVar1);
		      }
		      DAT_ram_009d3e38 = 0;
		      puVar4 = (undefined4 *)
		               import::env::invoke_iiii
		                         (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                          System_Collections_IEnumerator_TypeInfo,1);
		      if (DAT_ram_009d3e38 == 1) {
		code_r0x811ca086:
		        DAT_ram_009d3e38 = 0;
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x811ca12b;
		      }
		code_r0x811c9f01:
		      DAT_ram_009d3e38 = 0;
		      piVar7 = (int *)import::env::invoke_iii(*puVar4,piVar7,puVar4[1]);
		      if (DAT_ram_009d3e38 == 1) goto code_r0x811ca086;
		      if (piVar7 == (int *)0x0) {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_v(s_struct_Uniforms___color__vec4<f3_ram_00000856 + 0xa7);
		        if (DAT_ram_009d3e38 != 1) {
		code_r0x811ca2f0:
		          do {
		            halt_trap();
		          } while( true );
		        }
		code_r0x811ca07c:
		        DAT_ram_009d3e38 = 0;
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x811ca12b;
		      }
		      if (*(int *)(*piVar7 + 0x20) !=
		          *(int *)(Protocol_Dic_ArtikulMenuActionDic_Types_Actions_TypeInfo + 0x20)) {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vii
		                  (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x183,piVar7,
		                   Protocol_Dic_ArtikulMenuActionDic_Types_Actions_TypeInfo);
		        if (DAT_ram_009d3e38 == 1) goto code_r0x811ca07c;
		        goto code_r0x811ca2f0;
		      }
		      DAT_ram_009d3e38 = 0;
		      puVar4 = (undefined4 *)func_ii_15774(piVar7);
		      if (DAT_ram_009d3e38 == 1) goto code_r0x811ca086;
		      uVar3 = *puVar4;
		      if (*(int *)(Gameplay_Inventory_View_ContextMenu_ArtifactContextMenuUtils_TypeInfo + 0x74) ==
		          0) {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vi
		                  (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                   Gameplay_Inventory_View_ContextMenu_ArtifactContextMenuUtils_TypeInfo);
		        if (DAT_ram_009d3e38 == 1) goto code_r0x811ca086;
		      }
		      DAT_ram_009d3e38 = 0;
		      iVar5 = import::env::invoke_iiii
		                        (s_struct_Uniforms___color__array<v_ram_00001f04 + 0x251,
		                         **(undefined4 **)
		                           (Gameplay_Inventory_View_ContextMenu_ArtifactContextMenuUtils_TypeInfo +
		                           0x5c),uVar3,
		                         Method_System_Collections_Generic_HashSet_ArtikulMenuActionDic_Types_Actions__Contains__
		                        );
		      iVar6 = DAT_ram_009d3e38;
		      iVar9 = Method_System_Collections_Generic_List_ArtikulMenuActionDic_Types_Actions__Add__;
		      DAT_ram_009d3e38 = 0;
		      if (iVar6 == 1) {
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x811ca12b;
		      }
		    } while (iVar5 != 0);
		    *(int *)(iVar2 + 0x10) = *(int *)(iVar2 + 0x10) + 1;
		    uVar1 = *(uint *)(iVar2 + 0xc);
		    if (uVar1 < *(uint *)(*(int *)(iVar2 + 8) + 0xc)) {
		      *(uint *)(iVar2 + 0xc) = uVar1 + 1;
		      *(undefined4 *)(*(int *)(iVar2 + 8) + uVar1 * 4 + 0x10) = uVar3;
		      goto code_r0x811c9d6a;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_00000aff + 0x9f,iVar2,uVar3,
		               *(undefined4 *)(*(int *)(*(int *)(iVar9 + 0x10) + 0x60) + 0x38));
		    iVar9 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		  } while (iVar9 != 1);
		  uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x811ca12b:
		  iVar9 = global_1;
		  iVar6 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar9 == iVar6) {
		    piVar7 = (int *)import::env::__cxa_begin_catch(uVar3);
		    local_14 = *piVar7;
		    iVar9 = 0;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_v(0x123);
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 != 1) {
		code_r0x811ca178:
		      DAT_ram_009d3e38 = 0;
		      local_8 = func_ii_1082(local_4,System_IDisposable_TypeInfo);
		      piVar7 = (int *)*local_c;
		      if (piVar7 != (int *)0x0) {
		        iVar6 = *piVar7;
		        if (*(ushort *)(iVar6 + 0xb6) != 0) {
		          uVar1 = 0;
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		              puVar8 = (uint *)(iVar6 + *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0)
		              ;
		              goto code_r0x811ca208;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		        }
		        puVar8 = (uint *)func_ii_1080(piVar7,System_IDisposable_TypeInfo,0);
		code_r0x811ca208:
		        (**(code **)((ulonglong)*puVar8 * 4))(piVar7,puVar8[1]);
		      }
		      if (local_14 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(local_14);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      if (iVar9 != 0) {
		        if (iVar9 == 1) {
		          return 0;
		        }
		        if (iVar9 == 2) {
		          return 0;
		        }
		        if (iVar9 == 3) {
		          return 0;
		        }
		        if (iVar9 == 4) {
		          return 0;
		        }
		        if (iVar9 != 5) {
		          return 0;
		        }
		      }
		      uVar3 = UnityEngine_TextCore_Text_FontAsset__UpdateFontFeaturesForNewlyAddedGlyphs
		                        (iVar2,
		                         Method_System_Collections_Generic_List_ArtikulMenuActionDic_Types_Actions__ToArray__
		                        );
		      if (*(int *)(Gameplay_Inventory_View_ContextMenu_ArtifactContextMenuUtils_TypeInfo + 0x74) ==
		          0) {
		        func_ii_306000(Gameplay_Inventory_View_ContextMenu_ArtifactContextMenuUtils_TypeInfo);
		      }
		      iVar2 = Gameplay_Inventory_View_ContextMenu_ArtifactContextMenuUtils_TypeInfo;
		      *(undefined4 *)
		       (*(int *)(Gameplay_Inventory_View_ContextMenu_ArtifactContextMenuUtils_TypeInfo + 0x5c) + 8)
		           = uVar3;
		      goto code_r0x811ca2c3;
		    }
		    uVar3 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001f04 + 0x252,&local_14);
		  iVar2 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar2 != 1) {
		    import::env::__resumeException(uVar3);
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

		// Token: 0x0400163A RID: 5690
		[Token(Token = "0x400163A")]
		[FieldOffset(Offset = "0x8")]
		public IArtifactView ItemView;
	}
}
