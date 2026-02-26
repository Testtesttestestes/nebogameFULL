using System;
using Il2CppDummyDll;
using Protocol.Common;
using UnityEngine;

namespace UI.Windows.Buildings
{
	// Token: 0x020002AF RID: 687
	[Token(Token = "0x20002AF")]
	public class BuildingPriceView : MonoBehaviour
	{
		// Token: 0x1700024D RID: 589
		// (get) Token: 0x06001020 RID: 4128 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06001021 RID: 4129 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700024D")]
		public ResourceSet Price
		{
			[Token(Token = "0x6001020")]
			[Address(RVA = "0x622A", Offset = "0x622A", VA = "0x622A")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001021")]
			[Address(RVA = "0x622B", Offset = "0x622B", VA = "0x622B")]
			set
			{
			}
		}

		// Token: 0x06001022 RID: 4130 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001022")]
		[Address(RVA = "0x622C", Offset = "0x622C", VA = "0x622C")]
		public BuildingPriceView()
		{
		/* --- GHIDRA: .ctor ---
		undefined4 UI_Windows_Buildings_BuildingPriceView___ctor(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a58a9f == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_12583);
		    DAT_ram_00a58a9f = '\x01';
		  }
		  return StringLiteral_12583;
		}
		*/

		}

		// Token: 0x0400083F RID: 2111
		[Token(Token = "0x400083F")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Transform _container;

		// Token: 0x04000840 RID: 2112
		[Token(Token = "0x4000840")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private BuildingPriceItemView _priceItemPrefab;

		// Token: 0x04000841 RID: 2113
		[Token(Token = "0x4000841")]
		[FieldOffset(Offset = "0x18")]
		private ResourceSet _price;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Price ---
		void UI_Windows_Buildings_BuildingPriceView__get_Price
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 in_register_20000014;
		  undefined4 *puVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int *piVar4;
		  uint *puVar5;
		  double dVar6;
		  int iVar7;
		  undefined4 uVar8;
		  undefined4 uVar9;
		  int *piVar10;
		  uint uVar11;
		  int local_28;
		  int **local_24;
		  int *local_20;
		  undefined4 uStack_1c;
		  undefined8 local_18;
		  int *local_10;
		  undefined4 uStack_c;
		  int local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a58a9e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_Resources__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_Resources__MoveNext__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_Resources__get_Current__);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Resources__GetEnumerator__)
		    ;
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Object_Instantiate_BuildingPriceItemView___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Transform_TypeInfo);
		    DAT_ram_00a58a9e = '\x01';
		  }
		  local_8 = 0;
		  local_10 = (int *)0x0;
		  uStack_c = 0;
		  local_18 = 0;
		  *(undefined4 *)(param1 + 0x18) = param2;
		  local_4 = (int *)UnityEngine_Transform__set_hasChanged(*(undefined4 *)(param1 + 0x10),0);
		  local_20 = &local_8;
		  local_28 = 0;
		  local_24 = &local_4;
		  do {
		    piVar4 = local_4;
		    iVar7 = *local_4;
		    if (*(ushort *)(iVar7 + 0xb6) != 0) {
		      uVar11 = 0;
		      do {
		        piVar10 = (int *)(*(int *)(iVar7 + 0x58) + uVar11 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar10) {
		          puVar1 = (undefined4 *)(iVar7 + piVar10[1] * 8 + 0xc0);
		          goto code_r0x80f6dce9;
		        }
		        uVar11 = uVar11 + 1;
		      } while (*(ushort *)(iVar7 + 0xb6) != uVar11);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar1 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_IEnumerator_TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80f6df2c:
		      DAT_ram_009d3e38 = 0;
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80f6df34;
		    }
		code_r0x80f6dce9:
		    DAT_ram_009d3e38 = 0;
		    iVar7 = import::env::invoke_iii(*puVar1,piVar4,puVar1[1]);
		    piVar4 = local_4;
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80f6df2c;
		    if (iVar7 == 0) goto code_r0x80f6df7d;
		    iVar7 = *local_4;
		    if (*(ushort *)(iVar7 + 0xb6) != 0) {
		      uVar11 = 0;
		      do {
		        piVar10 = (int *)(*(int *)(iVar7 + 0x58) + uVar11 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar10) {
		          puVar1 = (undefined4 *)(piVar10[1] * 8 + iVar7 + 200);
		          goto code_r0x80f6ddc6;
		        }
		        uVar11 = uVar11 + 1;
		      } while (*(ushort *)(iVar7 + 0xb6) != uVar11);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar1 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_IEnumerator_TypeInfo,1);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80f6df0e:
		      DAT_ram_009d3e38 = 0;
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80f6df34;
		    }
		code_r0x80f6ddc6:
		    DAT_ram_009d3e38 = 0;
		    piVar4 = (int *)import::env::invoke_iii(*puVar1,piVar4,puVar1[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80f6df0e;
		    if (piVar4 != (int *)0x0) {
		      if (((uint)*(byte *)(*piVar4 + 0xb8) < (uint)*(byte *)(UnityEngine_Transform_TypeInfo + 0xb8))
		         || (*(int *)(*(int *)(*piVar4 + 100) +
		                      (uint)*(byte *)(UnityEngine_Transform_TypeInfo + 0xb8) * 4 + -4) !=
		             UnityEngine_Transform_TypeInfo)) {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vii
		                  (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x183,piVar4,
		                   UnityEngine_Transform_TypeInfo);
		        iVar7 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar7 != 1) {
		          do {
		            halt_trap();
		          } while( true );
		        }
		        uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x80f6df34;
		      }
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar2 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x25c,piVar4,0);
		    if (DAT_ram_009d3e38 == 1) break;
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi
		                (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,UnityEngine_Object_TypeInfo
		                );
		      if (DAT_ram_009d3e38 == 1) break;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_vii(s_struct_Uniforms___color__array<v_ram_00000aff + 0x274,uVar2,0);
		  } while (DAT_ram_009d3e38 != 1);
		  DAT_ram_009d3e38 = 0;
		  uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80f6df34:
		  iVar7 = global_1;
		  iVar3 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar7 == iVar3) {
		    piVar4 = (int *)import::env::__cxa_begin_catch(uVar2);
		    local_28 = *piVar4;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_v(0x123);
		    iVar7 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar7 != 1) {
		code_r0x80f6df7d:
		      DAT_ram_009d3e38 = 0;
		      local_8 = func_ii_1082(local_4,System_IDisposable_TypeInfo);
		      piVar4 = (int *)*local_20;
		      if (piVar4 != (int *)0x0) {
		        iVar7 = *piVar4;
		        if (*(ushort *)(iVar7 + 0xb6) != 0) {
		          uVar11 = 0;
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar11 * 8)) {
		              puVar5 = (uint *)(iVar7 + *(int *)(*(int *)(iVar7 + 0x58) + uVar11 * 8 + 4) * 8 + 0xc0
		                               );
		              goto code_r0x80f6e00d;
		            }
		            uVar11 = uVar11 + 1;
		          } while (*(ushort *)(iVar7 + 0xb6) != uVar11);
		        }
		        puVar5 = (uint *)func_ii_1080(piVar4,System_IDisposable_TypeInfo,0);
		code_r0x80f6e00d:
		        (**(code **)((ulonglong)*puVar5 * 4))(piVar4,CONCAT44(in_register_20000014,puVar5[1]));
		      }
		      if (local_28 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(local_28);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      uVar2 = Core_Extensions_Dict_ResourceSetExt__Less(*(undefined4 *)(param1 + 0x18),0.0,0);
		      System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		                (&local_28,uVar2,Method_System_Collections_Generic_List_Resources__GetEnumerator__);
		      local_10 = local_20;
		      uStack_c = uStack_1c;
		      local_18 = CONCAT44(local_24,local_28);
		      local_28 = 0;
		      local_24 = (int **)&local_18;
		      do {
		        DAT_ram_009d3e38 = 0;
		        iVar3 = import::env::invoke_iii
		                          (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x21f,&local_18,
		                           Method_System_Collections_Generic_List_Enumerator_Resources__MoveNext__);
		        uVar2 = uStack_c;
		        iVar7 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar7 == 1) {
		          uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80f6e4e2;
		        }
		        if (iVar3 == 0) {
		          DAT_ram_009d3e38 = 0;
		          return;
		        }
		        uVar8 = *(undefined4 *)(param1 + 0x10);
		        uVar9 = *(undefined4 *)(param1 + 0x14);
		        if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_vi
		                    (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                     UnityEngine_Object_TypeInfo);
		          iVar7 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar7 == 1) {
		            uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x80f6e4e2;
		          }
		        }
		        DAT_ram_009d3e38 = 0;
		        iVar3 = import::env::invoke_iiii
		                          (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x2ce,uVar9,uVar8,
		                           Method_UnityEngine_Object_Instantiate_BuildingPriceItemView___);
		        iVar7 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar7 == 1) {
		          uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80f6e4e2;
		        }
		        if (DAT_ram_00a6456f == '\0') {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_vi(0x7ff,&Core_Gameplay_Game_TypeInfo);
		          iVar7 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar7 == 1) {
		            uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x80f6e4e2;
		          }
		          DAT_ram_00a6456f = '\x01';
		        }
		        piVar4 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		        iVar7 = *piVar4;
		        if (*(ushort *)(iVar7 + 0xb6) != 0) {
		          uVar11 = 0;
		          do {
		            piVar10 = (int *)(*(int *)(iVar7 + 0x58) + uVar11 * 8);
		            if (Core_Gameplay_IGame_TypeInfo == *piVar10) {
		              puVar1 = (undefined4 *)(piVar10[1] * 8 + iVar7 + 0x178);
		              goto code_r0x80f6e270;
		            }
		            uVar11 = uVar11 + 1;
		          } while (*(ushort *)(iVar7 + 0xb6) != uVar11);
		        }
		        DAT_ram_009d3e38 = 0;
		        puVar1 = (undefined4 *)
		                 import::env::invoke_iiii
		                           (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar4,
		                            Core_Gameplay_IGame_TypeInfo,0x17);
		        if (DAT_ram_009d3e38 == 1) {
		code_r0x80f6e4b2:
		          DAT_ram_009d3e38 = 0;
		          uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80f6e4e2;
		        }
		code_r0x80f6e270:
		        DAT_ram_009d3e38 = 0;
		        uVar8 = import::env::invoke_iii(*puVar1,piVar4,puVar1[1]);
		        if (DAT_ram_009d3e38 == 1) goto code_r0x80f6e4b2;
		        DAT_ram_009d3e38 = 0;
		        uVar8 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar8,0);
		        iVar7 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar7 == 1) {
		          uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80f6e4e2;
		        }
		        DAT_ram_009d3e38 = 0;
		        uVar8 = import::env::invoke_iiii
		                          (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x334,uVar8,uVar2,0);
		        if (DAT_ram_009d3e38 == 1) {
		code_r0x80f6e4c6:
		          DAT_ram_009d3e38 = 0;
		          uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80f6e4e2;
		        }
		        if (DAT_ram_00a58a9d == '\0') {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_vi
		                    (0x7ff,&
		                           Method_AssetContent_Loaders_AbstractGameGraphicLoader_RawImage__Texture2D__set_AssetId__
		                    );
		          if (DAT_ram_009d3e38 == 1) goto code_r0x80f6e4c6;
		          DAT_ram_00a58a9d = '\x01';
		        }
		        *(undefined4 *)(iVar3 + 0x18) = uVar8;
		        uVar9 = *(undefined4 *)(iVar3 + 0x10);
		        DAT_ram_009d3e38 = 0;
		        uVar8 = import::env::invoke_iii
		                          (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x235,uVar8,0);
		        if (DAT_ram_009d3e38 == 1) goto code_r0x80f6e4c6;
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x396,uVar9,uVar8,
		                   Method_AssetContent_Loaders_AbstractGameGraphicLoader_RawImage__Texture2D__set_AssetId__
		                  );
		        if (DAT_ram_009d3e38 == 1) goto code_r0x80f6e4c6;
		        DAT_ram_009d3e38 = 0;
		        dVar6 = func_ii_6906(*(undefined4 *)(param1 + 0x18),uVar2,0);
		        if (DAT_ram_009d3e38 == 1) break;
		        *(double *)(iVar3 + 0x20) = dVar6;
		        piVar4 = *(int **)(iVar3 + 0x14);
		        DAT_ram_009d3e38 = 0;
		        uVar2 = import::env::invoke_iii
		                          (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x1d5,iVar3 + 0x20,0);
		        if (DAT_ram_009d3e38 == 1) break;
		        iVar7 = *piVar4;
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (*(undefined4 *)(iVar7 + 0x2d0),piVar4,uVar2,*(undefined4 *)(iVar7 + 0x2d4));
		      } while (DAT_ram_009d3e38 != 1);
		      DAT_ram_009d3e38 = 0;
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80f6e4e2:
		      iVar7 = global_1;
		      iVar3 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar7 == iVar3) {
		        piVar4 = (int *)import::env::__cxa_begin_catch(uVar2);
		        iVar3 = *piVar4;
		        DAT_ram_009d3e38 = 0;
		        local_28 = iVar3;
		        import::env::invoke_v(0x123);
		        iVar7 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar7 != 1) {
		          if (iVar3 == 0) {
		            DAT_ram_009d3e38 = 0;
		            return;
		          }
		          System_Data_DataSet__ValidateLocaleConstraint(iVar3);
		          do {
		            halt_trap();
		          } while( true );
		        }
		        uVar2 = import::env::__cxa_find_matching_catch_2();
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x236,&local_28);
		      goto joined_r0x80f6e574;
		    }
		    uVar2 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x234,&local_28);
		joined_r0x80f6e574:
		  if (DAT_ram_009d3e38 != 1) {
		    DAT_ram_009d3e38 = 0;
		    import::env::__resumeException(uVar2);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::__cxa_find_matching_catch_3(0);
		  unnamed_function_937();
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

}
