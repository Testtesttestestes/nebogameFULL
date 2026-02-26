using System;
using System.Collections.Generic;
using Core.Data;
using Gameplay.Collections.Model;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.Collections.View
{
	// Token: 0x020009C5 RID: 2501
	[Token(Token = "0x20009C5")]
	public class CollectionRequirementsDisplay : MonoBehaviour
	{
		// Token: 0x06003BF0 RID: 15344 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BF0")]
		[Address(RVA = "0x8AC4", Offset = "0x8AC4", VA = "0x8AC4")]
		public void SetRequirements(IList<CollectionsModel.CollectionMaterial> materials, UserData user, bool sameUser)
		{
		/* --- GHIDRA: SetRequirements ---
		void Gameplay_Collections_View_CollectionRequirementsDisplay__SetRequirements
		               (int param1,int *param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *piVar3;
		  int *piVar4;
		  int param2_00;
		  int iVar5;
		  
		  param2_00 = 0;
		  if (DAT_ram_00a57e82 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Collections_Model_CollectionsModel_ArtikulMaterial_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Collections_View_CollectionAprView_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Collections_View_CollectionArtikulView_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Collections_View_CollectionMedalView_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_ICollection_CollectionsModel_CollectionMaterial__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_IList_CollectionsModel_CollectionMaterial__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_MonoBehaviour__get_Item__);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Collections_Model_CollectionsModel_MedalMaterial_TypeInfo);
		    DAT_ram_00a57e82 = '\x01';
		  }
		  do {
		    iVar5 = *param2;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar3 = (int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8);
		        if (System_Collections_Generic_ICollection_CollectionsModel_CollectionMaterial__TypeInfo ==
		            *piVar3) {
		          puVar2 = (uint *)(iVar5 + piVar3[1] * 8 + 0xc0);
		          goto code_r0x80e70340;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(param2,
		                                  System_Collections_Generic_ICollection_CollectionsModel_CollectionMaterial__TypeInfo
		                                  ,0);
		code_r0x80e70340:
		    iVar5 = (**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		    if (iVar5 <= param2_00) {
		      return;
		    }
		    iVar5 = *param2;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar3 = (int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8);
		        if (System_Collections_Generic_IList_CollectionsModel_CollectionMaterial__TypeInfo ==
		            *piVar3) {
		          puVar2 = (uint *)(iVar5 + piVar3[1] * 8 + 0xc0);
		          goto code_r0x80e703c7;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(param2,
		                                  System_Collections_Generic_IList_CollectionsModel_CollectionMaterial__TypeInfo
		                                  ,0);
		code_r0x80e703c7:
		    piVar3 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(param2,param2_00,puVar2[1]);
		    iVar5 = (**(code **)((ulonglong)*(uint *)(*piVar3 + 0xe0) * 4))
		                      (piVar3,*(undefined4 *)(*piVar3 + 0xe4));
		    if (iVar5 == 1) {
		      piVar4 = (int *)System_Linq_Enumerable__ToList_object_
		                                (*(undefined4 *)(param1 + 0x28),param2_00,
		                                 Method_System_Collections_Generic_List_MonoBehaviour__get_Item__);
		      if (((uint)*(byte *)(*piVar3 + 0xb8) <
		           (uint)*(byte *)(Gameplay_Collections_Model_CollectionsModel_ArtikulMaterial_TypeInfo +
		                          0xb8)) ||
		         (*(int *)(*(int *)(*piVar3 + 100) +
		                   (uint)*(byte *)(
		                                  Gameplay_Collections_Model_CollectionsModel_ArtikulMaterial_TypeInfo
		                                  + 0xb8) * 4 + -4) !=
		          Gameplay_Collections_Model_CollectionsModel_ArtikulMaterial_TypeInfo)) {
		        System_Activator__CreateInstance
		                  (piVar3,Gameplay_Collections_Model_CollectionsModel_ArtikulMaterial_TypeInfo);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      if (piVar4 != (int *)0x0) {
		        if (((uint)*(byte *)(*piVar4 + 0xb8) <
		             (uint)*(byte *)(Gameplay_Collections_View_CollectionArtikulView_TypeInfo + 0xb8)) ||
		           (*(int *)(*(int *)(*piVar4 + 100) +
		                     (uint)*(byte *)(Gameplay_Collections_View_CollectionArtikulView_TypeInfo + 0xb8
		                                    ) * 4 + -4) !=
		            Gameplay_Collections_View_CollectionArtikulView_TypeInfo)) {
		          System_Activator__CreateInstance
		                    (piVar4,Gameplay_Collections_View_CollectionArtikulView_TypeInfo);
		          do {
		            halt_trap();
		          } while( true );
		        }
		      }
		      Gameplay_Collections_View_CollectionAprView___ctor(piVar4,piVar3,param4,piVar3);
		    }
		    else if (iVar5 == 2) {
		      piVar4 = (int *)System_Linq_Enumerable__ToList_object_
		                                (*(undefined4 *)(param1 + 0x28),param2_00,
		                                 Method_System_Collections_Generic_List_MonoBehaviour__get_Item__);
		      if (((uint)*(byte *)(*piVar3 + 0xb8) <
		           (uint)*(byte *)(Gameplay_Collections_Model_CollectionsModel_MedalMaterial_TypeInfo + 0xb8
		                          )) ||
		         (*(int *)(*(int *)(*piVar3 + 100) +
		                   (uint)*(byte *)(
		                                  Gameplay_Collections_Model_CollectionsModel_MedalMaterial_TypeInfo
		                                  + 0xb8) * 4 + -4) !=
		          Gameplay_Collections_Model_CollectionsModel_MedalMaterial_TypeInfo)) {
		        System_Activator__CreateInstance
		                  (piVar3,Gameplay_Collections_Model_CollectionsModel_MedalMaterial_TypeInfo);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      if (piVar4 != (int *)0x0) {
		        if (((uint)*(byte *)(*piVar4 + 0xb8) <
		             (uint)*(byte *)(Gameplay_Collections_View_CollectionMedalView_TypeInfo + 0xb8)) ||
		           (*(int *)(*(int *)(*piVar4 + 100) +
		                     (uint)*(byte *)(Gameplay_Collections_View_CollectionMedalView_TypeInfo + 0xb8)
		                     * 4 + -4) != Gameplay_Collections_View_CollectionMedalView_TypeInfo)) {
		          System_Activator__CreateInstance
		                    (piVar4,Gameplay_Collections_View_CollectionMedalView_TypeInfo);
		          do {
		            halt_trap();
		          } while( true );
		        }
		      }
		      Gameplay_Collections_View_CollectionRequirementsDisplay__UpdateInstance
		                (param1,param3,param4,piVar3,piVar4,piVar3);
		    }
		    else if (iVar5 == 3) {
		      piVar4 = (int *)System_Linq_Enumerable__ToList_object_
		                                (*(undefined4 *)(param1 + 0x28),param2_00,
		                                 Method_System_Collections_Generic_List_MonoBehaviour__get_Item__);
		      if (piVar4 != (int *)0x0) {
		        if (((uint)*(byte *)(*piVar4 + 0xb8) <
		             (uint)*(byte *)(Gameplay_Collections_View_CollectionAprView_TypeInfo + 0xb8)) ||
		           (*(int *)(*(int *)(*piVar4 + 100) +
		                     (uint)*(byte *)(Gameplay_Collections_View_CollectionAprView_TypeInfo + 0xb8) *
		                     4 + -4) != Gameplay_Collections_View_CollectionAprView_TypeInfo)) {
		          System_Activator__CreateInstance
		                    (piVar4,Gameplay_Collections_View_CollectionAprView_TypeInfo);
		          do {
		            halt_trap();
		          } while( true );
		        }
		      }
		      if (DAT_ram_00a57e88 == '\0') {
		        Mono_Security_ASN1__get_Item
		                  (&Gameplay_Collections_Model_CollectionsModel_AprMaterial_TypeInfo);
		        DAT_ram_00a57e88 = '\x01';
		      }
		      if (((uint)*(byte *)(*piVar3 + 0xb8) <
		           (uint)*(byte *)(Gameplay_Collections_Model_CollectionsModel_AprMaterial_TypeInfo + 0xb8))
		         || (*(int *)(*(int *)(*piVar3 + 100) +
		                      (uint)*(byte *)(
		                                     Gameplay_Collections_Model_CollectionsModel_AprMaterial_TypeInfo
		                                     + 0xb8) * 4 + -4) !=
		             Gameplay_Collections_Model_CollectionsModel_AprMaterial_TypeInfo)) {
		        System_Activator__CreateInstance
		                  (piVar3,Gameplay_Collections_Model_CollectionsModel_AprMaterial_TypeInfo);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      Gameplay_Collections_View_CollectionAprView__get_View(piVar4,piVar3,param3,param4,piVar3);
		    }
		    param2_00 = param2_00 + 1;
		  } while( true );
		}
		*/

		}

		// Token: 0x06003BF1 RID: 15345 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BF1")]
		[Address(RVA = "0x8AC5", Offset = "0x8AC5", VA = "0x8AC5")]
		private void UpdateRequirements(IList<CollectionsModel.CollectionMaterial> materials, UserData user, bool sameUser)
		{
		/* --- GHIDRA: UpdateRequirements ---
		void Gameplay_Collections_View_CollectionRequirementsDisplay__UpdateRequirements
		               (int param1,int *param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  uint uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  uint *puVar5;
		  undefined4 *puVar6;
		  int iVar7;
		  int *piVar8;
		  int local_24;
		  int **ppiStack_20;
		  undefined8 local_1c;
		  int *local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a57e83 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_MonoBehaviour__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_MonoBehaviour__MoveNext__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_MonoBehaviour__get_Current__);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_IEnumerable_CollectionsModel_CollectionMaterial__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_IEnumerator_CollectionsModel_CollectionMaterial__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_MonoBehaviour__Clear__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_MonoBehaviour__GetEnumerator__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a57e83 = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  local_14 = (int *)0x0;
		  System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		            (&local_24,*(undefined4 *)(param1 + 0x28),
		             Method_System_Collections_Generic_List_MonoBehaviour__GetEnumerator__);
		  local_8 = local_1c;
		  local_24 = 0;
		  ppiStack_20 = (int **)&local_10;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar2 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_10,
		                       Method_System_Collections_Generic_List_Enumerator_MonoBehaviour__MoveNext__);
		    iVar7 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar7 == 1) {
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e707e0;
		    }
		    if (iVar2 == 0) goto code_r0x80e70836;
		    DAT_ram_009d3e38 = 0;
		    uVar3 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x25c,local_8._4_4_,0);
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
		code_r0x80e707e0:
		  iVar7 = global_1;
		  iVar2 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar7 == iVar2) {
		    piVar4 = (int *)import::env::__cxa_begin_catch(uVar3);
		    iVar2 = *piVar4;
		    DAT_ram_009d3e38 = 0;
		    local_24 = iVar2;
		    import::env::invoke_v(0x123);
		    iVar7 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar7 != 1) {
		      if (iVar2 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(iVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		code_r0x80e70836:
		      DAT_ram_009d3e38 = 0;
		      iVar7 = *(int *)(param1 + 0x28);
		      iVar2 = *(int *)(iVar7 + 0xc);
		      *(undefined4 *)(iVar7 + 0xc) = 0;
		      *(int *)(iVar7 + 0x10) = *(int *)(iVar7 + 0x10) + 1;
		      if (0 < iVar2) {
		        func_ii_2064(*(undefined4 *)(iVar7 + 8),0,iVar2,0);
		      }
		      iVar7 = *param2;
		      if (*(ushort *)(iVar7 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          if (System_Collections_Generic_IEnumerable_CollectionsModel_CollectionMaterial__TypeInfo
		              == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		            puVar5 = (uint *)(iVar7 + *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		            goto code_r0x80e708de;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		      }
		      puVar5 = (uint *)func_ii_1080(param2,
		                                    System_Collections_Generic_IEnumerable_CollectionsModel_CollectionMaterial__TypeInfo
		                                    ,0);
		code_r0x80e708de:
		      local_14 = (int *)(**(code **)((ulonglong)*puVar5 * 4))(param2,puVar5[1]);
		      local_24 = 0;
		      ppiStack_20 = &local_14;
		code_r0x80e70903:
		      do {
		        piVar4 = local_14;
		        iVar7 = *local_14;
		        if (*(ushort *)(iVar7 + 0xb6) != 0) {
		          uVar1 = 0;
		          do {
		            piVar8 = (int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8);
		            if (System_Collections_IEnumerator_TypeInfo == *piVar8) {
		              puVar6 = (undefined4 *)(iVar7 + piVar8[1] * 8 + 0xc0);
		              goto code_r0x80e709a7;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		        }
		        DAT_ram_009d3e38 = 0;
		        puVar6 = (undefined4 *)
		                 import::env::invoke_iiii
		                           (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_14,
		                            System_Collections_IEnumerator_TypeInfo,0);
		        if (DAT_ram_009d3e38 == 1) {
		code_r0x80e709ef:
		          DAT_ram_009d3e38 = 0;
		          uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80e70bf3;
		        }
		code_r0x80e709a7:
		        DAT_ram_009d3e38 = 0;
		        iVar7 = import::env::invoke_iii(*puVar6,piVar4,puVar6[1]);
		        piVar4 = local_14;
		        if (DAT_ram_009d3e38 == 1) goto code_r0x80e709ef;
		        if (iVar7 == 0) {
		          iVar7 = 0;
		          goto code_r0x80e70c3c;
		        }
		        iVar7 = *local_14;
		        if (*(ushort *)(iVar7 + 0xb6) != 0) {
		          uVar1 = 0;
		          do {
		            piVar8 = (int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8);
		            if (System_Collections_Generic_IEnumerator_CollectionsModel_CollectionMaterial__TypeInfo
		                == *piVar8) {
		              puVar6 = (undefined4 *)(iVar7 + piVar8[1] * 8 + 0xc0);
		              goto code_r0x80e70a9c;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		        }
		        DAT_ram_009d3e38 = 0;
		        puVar6 = (undefined4 *)
		                 import::env::invoke_iiii
		                           (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_14,
		                            System_Collections_Generic_IEnumerator_CollectionsModel_CollectionMaterial__TypeInfo
		                            ,0);
		        if (DAT_ram_009d3e38 == 1) {
		code_r0x80e70b29:
		          DAT_ram_009d3e38 = 0;
		          uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80e70bf3;
		        }
		code_r0x80e70a9c:
		        DAT_ram_009d3e38 = 0;
		        piVar4 = (int *)import::env::invoke_iii(*puVar6,piVar4,puVar6[1]);
		        if (DAT_ram_009d3e38 == 1) goto code_r0x80e70b29;
		        DAT_ram_009d3e38 = 0;
		        iVar2 = import::env::invoke_iii
		                          (*(undefined4 *)(*piVar4 + 0xe0),piVar4,*(undefined4 *)(*piVar4 + 0xe4));
		        iVar7 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar7 == 1) {
		          uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x80e70bf3;
		        }
		        if (iVar2 != 1) {
		          if (iVar2 == 2) {
		            DAT_ram_009d3e38 = 0;
		            import::env::invoke_viiiii
		                      (s_struct_Uniforms___color__array<v_ram_00001b87 + 0xbd,param1,piVar4,param3,
		                       param4,piVar4);
		            iVar7 = DAT_ram_009d3e38;
		            DAT_ram_009d3e38 = 0;
		            if (iVar7 == 1) {
		              uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		              goto code_r0x80e70bf3;
		            }
		          }
		          else if (iVar2 == 3) {
		            DAT_ram_009d3e38 = 0;
		            import::env::invoke_viiiii
		                      (s_struct_Uniforms___color__array<v_ram_00001b87 + 0xbc,param1,piVar4,param3,
		                       param4,piVar4);
		            iVar7 = DAT_ram_009d3e38;
		            DAT_ram_009d3e38 = 0;
		            if (iVar7 == 1) {
		              uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		              goto code_r0x80e70bf3;
		            }
		          }
		          goto code_r0x80e70903;
		        }
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viiii
		                  (s_struct_Uniforms___color__array<v_ram_00001b87 + 0xbe,param1,piVar4,param4,
		                   piVar4);
		        iVar7 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		      } while (iVar7 != 1);
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80e70bf3:
		      iVar7 = global_1;
		      iVar2 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar7 == iVar2) {
		        piVar4 = (int *)import::env::__cxa_begin_catch(uVar3);
		        iVar7 = *piVar4;
		        DAT_ram_009d3e38 = 0;
		        local_24 = iVar7;
		        import::env::invoke_v(0x123);
		        iVar2 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar2 != 1) {
		code_r0x80e70c3c:
		          piVar4 = local_14;
		          DAT_ram_009d3e38 = 0;
		          if (local_14 != (int *)0x0) {
		            uVar1 = 0;
		            iVar2 = *local_14;
		            if (*(ushort *)(iVar2 + 0xb6) != 0) {
		              do {
		                if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		                  puVar5 = (uint *)(iVar2 + *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 +
		                                   0xc0);
		                  goto code_r0x80e70cb4;
		                }
		                uVar1 = uVar1 + 1;
		              } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		            }
		            puVar5 = (uint *)func_ii_1080(local_14,System_IDisposable_TypeInfo,0);
		code_r0x80e70cb4:
		            (**(code **)((ulonglong)*puVar5 * 4))(piVar4,puVar5[1]);
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
		      import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0xbf,&local_24);
		      goto joined_r0x80e70d02;
		    }
		    uVar3 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0xc0,&local_24);
		joined_r0x80e70d02:
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

		// Token: 0x06003BF2 RID: 15346 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BF2")]
		[Address(RVA = "0x8AC6", Offset = "0x8AC6", VA = "0x8AC6")]
		private void CreateNewRequirements(IList<CollectionsModel.CollectionMaterial> materials, UserData user, bool sameUser)
		{
		/* --- GHIDRA: CreateNewRequirements ---
		void Gameplay_Collections_View_CollectionRequirementsDisplay__CreateNewRequirements
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5)
		
		{
		  Gameplay_Collections_View_CollectionAprView___ctor(param4,param3,param2,param2);
		  return;
		}
		*/

		}

		// Token: 0x06003BF3 RID: 15347 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BF3")]
		[Address(RVA = "0x1C45", Offset = "0x1C45", VA = "0x1C45")]
		private void HandleArtikul(CollectionsModel.CollectionMaterial material, bool sameUser)
		{
		}

		// Token: 0x06003BF4 RID: 15348 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BF4")]
		[Address(RVA = "0x8AC7", Offset = "0x8AC7", VA = "0x8AC7")]
		private void UpdateInstance(bool sameUser, CollectionsModel.ArtikulMaterial artikulMaterial, CollectionArtikulView instance)
		{
		/* --- GHIDRA: UpdateInstance ---
		void Gameplay_Collections_View_CollectionRequirementsDisplay__UpdateInstance
		               (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a57e89 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Collections_Model_CollectionsModel_CollectionMaterial___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_MonoBehaviour___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_MonoBehaviour__TypeInfo);
		    DAT_ram_00a57e89 = '\x01';
		  }
		  uVar1 = Mono_Security_ASN1Convert__ToOid
		                    (Gameplay_Collections_Model_CollectionsModel_CollectionMaterial___TypeInfo,0);
		  *(undefined4 *)(param1 + 0x24) = uVar1;
		  uVar1 = unnamed_function_1417(System_Collections_Generic_List_MonoBehaviour__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (uVar1,Method_System_Collections_Generic_List_MonoBehaviour___ctor__);
		  *(undefined4 *)(param1 + 0x28) = uVar1;
		  UnityEngine_RectTransform__GetParentSize(param1,0);
		  return;
		}
		*/

		/* --- GHIDRA: UpdateInstance ---
		void Gameplay_Collections_View_CollectionRequirementsDisplay__UpdateInstance
		               (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a57e89 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Collections_Model_CollectionsModel_CollectionMaterial___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_MonoBehaviour___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_MonoBehaviour__TypeInfo);
		    DAT_ram_00a57e89 = '\x01';
		  }
		  uVar1 = Mono_Security_ASN1Convert__ToOid
		                    (Gameplay_Collections_Model_CollectionsModel_CollectionMaterial___TypeInfo,0);
		  *(undefined4 *)(param1 + 0x24) = uVar1;
		  uVar1 = unnamed_function_1417(System_Collections_Generic_List_MonoBehaviour__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (uVar1,Method_System_Collections_Generic_List_MonoBehaviour___ctor__);
		  *(undefined4 *)(param1 + 0x28) = uVar1;
		  UnityEngine_RectTransform__GetParentSize(param1,0);
		  return;
		}
		*/

		/* --- GHIDRA: UpdateInstance ---
		void Gameplay_Collections_View_CollectionRequirementsDisplay__UpdateInstance
		               (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a57e89 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Collections_Model_CollectionsModel_CollectionMaterial___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_MonoBehaviour___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_MonoBehaviour__TypeInfo);
		    DAT_ram_00a57e89 = '\x01';
		  }
		  uVar1 = Mono_Security_ASN1Convert__ToOid
		                    (Gameplay_Collections_Model_CollectionsModel_CollectionMaterial___TypeInfo,0);
		  *(undefined4 *)(param1 + 0x24) = uVar1;
		  uVar1 = unnamed_function_1417(System_Collections_Generic_List_MonoBehaviour__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (uVar1,Method_System_Collections_Generic_List_MonoBehaviour___ctor__);
		  *(undefined4 *)(param1 + 0x28) = uVar1;
		  UnityEngine_RectTransform__GetParentSize(param1,0);
		  return;
		}
		*/

		}

		// Token: 0x06003BF5 RID: 15349 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BF5")]
		[Address(RVA = "0x1C44", Offset = "0x1C44", VA = "0x1C44")]
		private void HandleMedal(CollectionsModel.CollectionMaterial material, UserData user, bool sameUser)
		{
		/* --- GHIDRA: HandleMedal ---
		void Gameplay_Collections_View_CollectionRequirementsDisplay__HandleMedal
		               (int param1,int *param2,undefined4 param3,undefined4 param4)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param1_00;
		  int param4_00;
		  uint uVar3;
		  
		  if (DAT_ram_00a57e84 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Collections_Model_CollectionsModel_ArtikulMaterial_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_MonoBehaviour__Add__);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Object_Instantiate_CollectionArtikulView___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a57e84 = '\x01';
		  }
		  if (param2 != (int *)0x0) {
		    if (((uint)*(byte *)(*param2 + 0xb8) <
		         (uint)*(byte *)(Gameplay_Collections_Model_CollectionsModel_ArtikulMaterial_TypeInfo + 0xb8
		                        )) ||
		       (*(int *)(*(int *)(*param2 + 100) +
		                 (uint)*(byte *)(
		                                Gameplay_Collections_Model_CollectionsModel_ArtikulMaterial_TypeInfo
		                                + 0xb8) * 4 + -4) !=
		        Gameplay_Collections_Model_CollectionsModel_ArtikulMaterial_TypeInfo)) {
		      System_Activator__CreateInstance
		                (param2,Gameplay_Collections_Model_CollectionsModel_ArtikulMaterial_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  uVar2 = *(undefined4 *)(param1 + 0x1c);
		  param1_00 = *(undefined4 *)(param1 + 0x10);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  uVar2 = func_ii_6805(param1_00,uVar2,
		                       Method_UnityEngine_Object_Instantiate_CollectionArtikulView___);
		  iVar1 = Method_System_Collections_Generic_List_MonoBehaviour__Add__;
		  param4_00 = *(int *)(param1 + 0x28);
		  *(int *)(param4_00 + 0x10) = *(int *)(param4_00 + 0x10) + 1;
		  uVar3 = *(uint *)(param4_00 + 0xc);
		  if (uVar3 < *(uint *)(*(int *)(param4_00 + 8) + 0xc)) {
		    *(uint *)(param4_00 + 0xc) = uVar3 + 1;
		    *(undefined4 *)(*(int *)(param4_00 + 8) + uVar3 * 4 + 0x10) = uVar2;
		    Gameplay_Collections_View_CollectionAprView___ctor(uVar2,param2,param3,param4_00);
		    return;
		  }
		  System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		            (param4_00,uVar2,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  Gameplay_Collections_View_CollectionAprView___ctor(uVar2,param2,param3,param4_00);
		  return;
		}
		*/

		}

		// Token: 0x06003BF6 RID: 15350 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BF6")]
		[Address(RVA = "0x8AC8", Offset = "0x8AC8", VA = "0x8AC8")]
		private void UpdateInstance(UserData user, bool sameUser, CollectionsModel.MedalMaterial medalMaterial, CollectionMedalView instance)
		{
		}

		// Token: 0x06003BF7 RID: 15351 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BF7")]
		[Address(RVA = "0x1C43", Offset = "0x1C43", VA = "0x1C43")]
		private void HandleApr(CollectionsModel.CollectionMaterial material, UserData user, bool sameUser)
		{
		/* --- GHIDRA: HandleApr ---
		void Gameplay_Collections_View_CollectionRequirementsDisplay__HandleApr
		               (int param1,int *param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param1_00;
		  int param1_01;
		  uint uVar3;
		  
		  if (DAT_ram_00a57e85 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_MonoBehaviour__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Collections_Model_CollectionsModel_MedalMaterial_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Object_Instantiate_CollectionMedalView___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a57e85 = '\x01';
		  }
		  if (param2 != (int *)0x0) {
		    if (((uint)*(byte *)(*param2 + 0xb8) <
		         (uint)*(byte *)(Gameplay_Collections_Model_CollectionsModel_MedalMaterial_TypeInfo + 0xb8))
		       || (*(int *)(*(int *)(*param2 + 100) +
		                    (uint)*(byte *)(
		                                   Gameplay_Collections_Model_CollectionsModel_MedalMaterial_TypeInfo
		                                   + 0xb8) * 4 + -4) !=
		           Gameplay_Collections_Model_CollectionsModel_MedalMaterial_TypeInfo)) {
		      System_Activator__CreateInstance
		                (param2,Gameplay_Collections_Model_CollectionsModel_MedalMaterial_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  uVar2 = *(undefined4 *)(param1 + 0x1c);
		  param1_00 = *(undefined4 *)(param1 + 0x14);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  uVar2 = func_ii_6805(param1_00,uVar2,Method_UnityEngine_Object_Instantiate_CollectionMedalView___)
		  ;
		  iVar1 = Method_System_Collections_Generic_List_MonoBehaviour__Add__;
		  param1_01 = *(int *)(param1 + 0x28);
		  *(int *)(param1_01 + 0x10) = *(int *)(param1_01 + 0x10) + 1;
		  uVar3 = *(uint *)(param1_01 + 0xc);
		  if (uVar3 < *(uint *)(*(int *)(param1_01 + 8) + 0xc)) {
		    *(uint *)(param1_01 + 0xc) = uVar3 + 1;
		    *(undefined4 *)(*(int *)(param1_01 + 8) + uVar3 * 4 + 0x10) = uVar2;
		    Gameplay_Collections_View_CollectionRequirementsDisplay__UpdateInstance
		              (param1,param3,param4,param2,uVar2,param1);
		    return;
		  }
		  System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		            (param1_01,uVar2,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  Gameplay_Collections_View_CollectionRequirementsDisplay__UpdateInstance
		            (param1,param3,param4,param2,uVar2,param1);
		  return;
		}
		*/

		}

		// Token: 0x06003BF8 RID: 15352 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BF8")]
		[Address(RVA = "0x8AC9", Offset = "0x8AC9", VA = "0x8AC9")]
		private void UpdateInstance(CollectionsModel.CollectionMaterial material, UserData user, bool sameUser, CollectionAprView instance)
		{
		}

		// Token: 0x06003BF9 RID: 15353 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BF9")]
		[Address(RVA = "0x8ACA", Offset = "0x8ACA", VA = "0x8ACA")]
		public CollectionRequirementsDisplay()
		{
		}

		// Token: 0x04002114 RID: 8468
		[Token(Token = "0x4002114")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private CollectionArtikulView _collectionArtikulViewPrefab;

		// Token: 0x04002115 RID: 8469
		[Token(Token = "0x4002115")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private CollectionMedalView _collectionMedalViewPrefab;

		// Token: 0x04002116 RID: 8470
		[Token(Token = "0x4002116")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CollectionAprView _collectionAprViewPrefab;

		// Token: 0x04002117 RID: 8471
		[Token(Token = "0x4002117")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private RectTransform _contentParent;

		// Token: 0x04002118 RID: 8472
		[Token(Token = "0x4002118")]
		[FieldOffset(Offset = "0x20")]
		private bool _hasSale;

		// Token: 0x04002119 RID: 8473
		[Token(Token = "0x4002119")]
		[FieldOffset(Offset = "0x24")]
		private IList<CollectionsModel.CollectionMaterial> _materials;

		// Token: 0x0400211A RID: 8474
		[Token(Token = "0x400211A")]
		[FieldOffset(Offset = "0x28")]
		private List<MonoBehaviour> _instances;
	}
}
