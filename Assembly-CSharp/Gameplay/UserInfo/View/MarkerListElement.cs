using System;
using AssetContent;
using Il2CppDummyDll;
using Protocol.Dic;
using UI.ToolTip;
using UnityEngine;

namespace Gameplay.UserInfo.View
{
	// Token: 0x020003F8 RID: 1016
	[Token(Token = "0x20003F8")]
	public class MarkerListElement : MonoBehaviour, IToolTipDataProvider
	{
		// Token: 0x060017DA RID: 6106 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017DA")]
		[Address(RVA = "0x6995", Offset = "0x6995", VA = "0x6995")]
		public void Init(uint markerId, Dictionaries dict)
		{
		/* --- GHIDRA: Init ---
		int Gameplay_UserInfo_View_MarkerListElement__Init(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int param1_00;
		  
		  if (DAT_ram_00a598de == '\0') {
		    Mono_Security_ASN1__get_Item(&UI_ToolTip_Implementations_VO_AprMarkerToolTipVO_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UI_ToolTip_ToolTipData_AprMarkerToolTipVO___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_UI_ToolTip_ToolTipData_AprMarkerToolTipVO__set_Data__);
		    Mono_Security_ASN1__get_Item(&UI_ToolTip_ToolTipData_AprMarkerToolTipVO__TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12537);
		    DAT_ram_00a598de = '\x01';
		  }
		  iVar1 = unnamed_function_1417(UI_ToolTip_Implementations_VO_AprMarkerToolTipVO_TypeInfo);
		  uVar2 = Core_Gameplay_Managers_Requirements_RequirementsInfoProvider___c__DisplayClass17_0___ctor
		                    (*(undefined4 *)(param1 + 0x18),*(undefined4 *)(*(int *)(param1 + 0x14) + 0x18),
		                     0);
		  *(undefined4 *)(iVar1 + 8) = uVar2;
		  uVar2 = Core_Extensions_Dict_AprDicExt__Get256x128AssetId(*(undefined4 *)(param1 + 0x14),0);
		  *(undefined4 *)(iVar1 + 0xc) = uVar2;
		  param1_00 = unnamed_function_1417(UI_ToolTip_ToolTipData_AprMarkerToolTipVO__TypeInfo);
		  System_Buffers_TlsOverPerCoreLockedStacksArrayPool___Il2CppFullySharedGenericType___get_Id
		            (param1_00,StringLiteral_12537,Method_UI_ToolTip_ToolTipData_AprMarkerToolTipVO___ctor__
		            );
		  *(int *)(param1_00 + 0x1c) = iVar1;
		  return param1_00;
		}
		*/

		}

		// Token: 0x060017DB RID: 6107 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60017DB")]
		[Address(RVA = "0x6996", Offset = "0x6996", VA = "0x6996", Slot = "4")]
		public BaseToolTipData GetData()
		{
			return null;
		}

		// Token: 0x060017DC RID: 6108 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017DC")]
		[Address(RVA = "0x6997", Offset = "0x6997", VA = "0x6997")]
		public MarkerListElement()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_UserInfo_View_MarkerListElement___ctor
		               (int param1,int *param2,undefined4 param3,undefined4 param4)
		
		{
		  uint uVar1;
		  undefined4 *puVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int *piVar5;
		  uint *puVar6;
		  int iVar7;
		  undefined4 uVar8;
		  undefined4 param2_00;
		  int *piVar9;
		  int local_18;
		  int **local_14;
		  int *local_10;
		  int *local_c;
		  int local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a598df == '\0') {
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerable_uint__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerator_uint__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Object_Instantiate_MarkerListElement___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Transform_TypeInfo);
		    DAT_ram_00a598df = '\x01';
		  }
		  local_8 = 0;
		  local_c = (int *)0x0;
		  local_4 = (int *)UnityEngine_Transform__set_hasChanged(*(undefined4 *)(param1 + 0x14),0);
		  local_10 = &local_8;
		  local_18 = 0;
		  local_14 = &local_4;
		  do {
		    piVar5 = local_4;
		    iVar7 = *local_4;
		    if (*(ushort *)(iVar7 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar9 = (int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar9) {
		          puVar2 = (undefined4 *)(iVar7 + piVar9[1] * 8 + 0xc0);
		          goto code_r0x810895da;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar2 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_IEnumerator_TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x8108981d:
		      DAT_ram_009d3e38 = 0;
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81089825;
		    }
		code_r0x810895da:
		    DAT_ram_009d3e38 = 0;
		    iVar7 = import::env::invoke_iii(*puVar2,piVar5,puVar2[1]);
		    piVar5 = local_4;
		    if (DAT_ram_009d3e38 == 1) goto code_r0x8108981d;
		    if (iVar7 == 0) goto code_r0x8108986e;
		    iVar7 = *local_4;
		    if (*(ushort *)(iVar7 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar9 = (int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar9) {
		          puVar2 = (undefined4 *)(piVar9[1] * 8 + iVar7 + 200);
		          goto code_r0x810896b7;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar2 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_IEnumerator_TypeInfo,1);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x810897ff:
		      DAT_ram_009d3e38 = 0;
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81089825;
		    }
		code_r0x810896b7:
		    DAT_ram_009d3e38 = 0;
		    piVar5 = (int *)import::env::invoke_iii(*puVar2,piVar5,puVar2[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x810897ff;
		    if (piVar5 != (int *)0x0) {
		      if (((uint)*(byte *)(*piVar5 + 0xb8) < (uint)*(byte *)(UnityEngine_Transform_TypeInfo + 0xb8))
		         || (*(int *)(*(int *)(*piVar5 + 100) +
		                      (uint)*(byte *)(UnityEngine_Transform_TypeInfo + 0xb8) * 4 + -4) !=
		             UnityEngine_Transform_TypeInfo)) {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vii
		                  (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x183,piVar5,
		                   UnityEngine_Transform_TypeInfo);
		        iVar7 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar7 != 1) {
		          do {
		            halt_trap();
		          } while( true );
		        }
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x81089825;
		      }
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar3 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x25c,piVar5,0);
		    if (DAT_ram_009d3e38 == 1) break;
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi
		                (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,UnityEngine_Object_TypeInfo
		                );
		      if (DAT_ram_009d3e38 == 1) break;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_vii(s_struct_Uniforms___color__array<v_ram_00000aff + 0x274,uVar3,0);
		  } while (DAT_ram_009d3e38 != 1);
		  DAT_ram_009d3e38 = 0;
		  uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x81089825:
		  iVar7 = global_1;
		  iVar4 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar7 == iVar4) {
		    piVar5 = (int *)import::env::__cxa_begin_catch(uVar3);
		    local_18 = *piVar5;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_v(0x123);
		    iVar7 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar7 != 1) {
		code_r0x8108986e:
		      DAT_ram_009d3e38 = 0;
		      local_8 = func_ii_1082(local_4,System_IDisposable_TypeInfo);
		      piVar5 = (int *)*local_10;
		      if (piVar5 != (int *)0x0) {
		        iVar7 = *piVar5;
		        if (*(ushort *)(iVar7 + 0xb6) != 0) {
		          uVar1 = 0;
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		              puVar6 = (uint *)(iVar7 + *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0)
		              ;
		              goto code_r0x810898fe;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		        }
		        puVar6 = (uint *)func_ii_1080(piVar5,System_IDisposable_TypeInfo,0);
		code_r0x810898fe:
		        (**(code **)((ulonglong)*puVar6 * 4))(piVar5,puVar6[1]);
		      }
		      if (local_18 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(local_18);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      uVar1 = 0;
		      iVar7 = *param2;
		      if (*(ushort *)(iVar7 + 0xb6) != 0) {
		        do {
		          if (System_Collections_Generic_IEnumerable_uint__TypeInfo ==
		              *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		            puVar6 = (uint *)(iVar7 + *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		            goto code_r0x81089986;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		      }
		      puVar6 = (uint *)func_ii_1080(param2,System_Collections_Generic_IEnumerable_uint__TypeInfo,0);
		code_r0x81089986:
		      local_c = (int *)(**(code **)((ulonglong)*puVar6 * 4))(param2,puVar6[1]);
		      local_18 = 0;
		      local_14 = &local_c;
		      do {
		        piVar5 = local_c;
		        iVar7 = *local_c;
		        if (*(ushort *)(iVar7 + 0xb6) != 0) {
		          uVar1 = 0;
		          do {
		            piVar9 = (int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8);
		            if (System_Collections_IEnumerator_TypeInfo == *piVar9) {
		              puVar2 = (undefined4 *)(iVar7 + piVar9[1] * 8 + 0xc0);
		              goto code_r0x81089a8f;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		        }
		        DAT_ram_009d3e38 = 0;
		        puVar2 = (undefined4 *)
		                 import::env::invoke_iiii
		                           (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_c,
		                            System_Collections_IEnumerator_TypeInfo,0);
		        if (DAT_ram_009d3e38 == 1) {
		code_r0x81089d03:
		          DAT_ram_009d3e38 = 0;
		          uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x81089d0b;
		        }
		code_r0x81089a8f:
		        DAT_ram_009d3e38 = 0;
		        iVar7 = import::env::invoke_iii(*puVar2,piVar5,puVar2[1]);
		        piVar5 = local_c;
		        if (DAT_ram_009d3e38 == 1) goto code_r0x81089d03;
		        if (iVar7 == 0) {
		          iVar7 = 0;
		          goto code_r0x81089d54;
		        }
		        iVar7 = *local_c;
		        if (*(ushort *)(iVar7 + 0xb6) != 0) {
		          uVar1 = 0;
		          do {
		            piVar9 = (int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8);
		            if (System_Collections_Generic_IEnumerator_uint__TypeInfo == *piVar9) {
		              puVar2 = (undefined4 *)(iVar7 + piVar9[1] * 8 + 0xc0);
		              goto code_r0x81089b69;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		        }
		        DAT_ram_009d3e38 = 0;
		        puVar2 = (undefined4 *)
		                 import::env::invoke_iiii
		                           (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_c,
		                            System_Collections_Generic_IEnumerator_uint__TypeInfo,0);
		        if (DAT_ram_009d3e38 == 1) {
		code_r0x81089cdb:
		          DAT_ram_009d3e38 = 0;
		          uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x81089d0b;
		        }
		code_r0x81089b69:
		        DAT_ram_009d3e38 = 0;
		        uVar3 = import::env::invoke_iii(*puVar2,piVar5,puVar2[1]);
		        if (DAT_ram_009d3e38 == 1) goto code_r0x81089cdb;
		        uVar8 = *(undefined4 *)(param1 + 0x14);
		        param2_00 = *(undefined4 *)(param1 + 0x10);
		        if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_vi
		                    (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                     UnityEngine_Object_TypeInfo);
		          iVar7 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar7 == 1) {
		            uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x81089d0b;
		          }
		        }
		        DAT_ram_009d3e38 = 0;
		        iVar4 = import::env::invoke_iiii
		                          (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x2ce,param2_00,uVar8,
		                           Method_UnityEngine_Object_Instantiate_MarkerListElement___);
		        iVar7 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar7 == 1) {
		          uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x81089d0b;
		        }
		        *(undefined4 *)(iVar4 + 0x18) = param3;
		        DAT_ram_009d3e38 = 0;
		        uVar3 = import::env::invoke_iiii
		                          (s_struct_Uniforms___color__array<v_ram_00001f04 + 0x30,param3,uVar3,0);
		        if (DAT_ram_009d3e38 == 1) break;
		        *(undefined4 *)(iVar4 + 0x14) = uVar3;
		        uVar8 = *(undefined4 *)(iVar4 + 0x10);
		        DAT_ram_009d3e38 = 0;
		        uVar3 = import::env::invoke_iii
		                          (s_struct_Uniforms___color__array<v_ram_00001f04 + 0x31,uVar3,0);
		        if (DAT_ram_009d3e38 == 1) break;
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x62,uVar8,uVar3,0);
		      } while (DAT_ram_009d3e38 != 1);
		      DAT_ram_009d3e38 = 0;
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x81089d0b:
		      iVar7 = global_1;
		      iVar4 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar7 == iVar4) {
		        piVar5 = (int *)import::env::__cxa_begin_catch(uVar3);
		        iVar7 = *piVar5;
		        DAT_ram_009d3e38 = 0;
		        local_18 = iVar7;
		        import::env::invoke_v(0x123);
		        iVar4 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar4 != 1) {
		code_r0x81089d54:
		          piVar5 = local_c;
		          DAT_ram_009d3e38 = 0;
		          if (local_c != (int *)0x0) {
		            uVar1 = 0;
		            iVar4 = *local_c;
		            if (*(ushort *)(iVar4 + 0xb6) != 0) {
		              do {
		                if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		                  puVar6 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 +
		                                   0xc0);
		                  goto code_r0x81089dcc;
		                }
		                uVar1 = uVar1 + 1;
		              } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		            }
		            puVar6 = (uint *)func_ii_1080(local_c,System_IDisposable_TypeInfo,0);
		code_r0x81089dcc:
		            (**(code **)((ulonglong)*puVar6 * 4))(piVar5,puVar6[1]);
		          }
		          if (iVar7 != 0) {
		            System_Data_DataSet__ValidateLocaleConstraint(iVar7);
		            do {
		              halt_trap();
		            } while( true );
		          }
		          return;
		        }
		        uVar3 = import::env::__cxa_find_matching_catch_2();
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001f04 + 0x32,&local_18);
		      goto joined_r0x81089e1a;
		    }
		    uVar3 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001f04 + 0x2f,&local_18);
		joined_r0x81089e1a:
		  if (DAT_ram_009d3e38 == 1) {
		    DAT_ram_009d3e38 = 0;
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::__resumeException(uVar3);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x04000CA8 RID: 3240
		[Token(Token = "0x4000CA8")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private GameRawImage _icon;

		// Token: 0x04000CA9 RID: 3241
		[Token(Token = "0x4000CA9")]
		[FieldOffset(Offset = "0x14")]
		private AprMarkersDic _markerDic;

		// Token: 0x04000CAA RID: 3242
		[Token(Token = "0x4000CAA")]
		[FieldOffset(Offset = "0x18")]
		private Dictionaries _dict;
	}
}
