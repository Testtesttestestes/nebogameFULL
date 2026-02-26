using System;
using System.Collections.Generic;
using Core.Data;
using Il2CppDummyDll;
using MVC;
using Protocol.Dic;

namespace Core.Gameplay.Managers.Notifications.Model
{
	// Token: 0x020011AB RID: 4523
	[Token(Token = "0x20011AB")]
	public class GameNotificationsModel : AbstractModel
	{
		// Token: 0x06006B79 RID: 27513 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B79")]
		[Address(RVA = "0xB677", Offset = "0xB677", VA = "0xB677")]
		public GameNotificationsModel(UserData user, Dictionaries dictionaries)
		{
		/* --- GHIDRA: .ctor ---
		void Core_Gameplay_Managers_Notifications_Model_GameNotificationsModel___ctor
		               (int param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int iVar2;
		  undefined4 *puVar3;
		  undefined4 uVar4;
		  int iVar5;
		  int *piVar6;
		  undefined4 uVar7;
		  uint *puVar8;
		  int iVar9;
		  int iVar10;
		  int *piVar11;
		  undefined4 local_24;
		  undefined4 local_20;
		  int local_1c;
		  int **local_18;
		  int local_14;
		  int **local_10;
		  int *local_c;
		  int *local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a5a67b == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__uint__ContainsKey__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_Dictionary_uint__uint___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__uint__get_Item__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__uint__set_Item__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Dictionary_uint__uint__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_OrderBy_NotificationCategoryData__uint___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToList_NotificationCategoryData___);
		    Mono_Security_ASN1__get_Item(&System_Func_NotificationCategoryData__uint__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_IEnumerator_NotificationGroupDic__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerator_uint__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_IEnumerator_NotificationCategoryDic__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_uint__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_NotificationCategoryData__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_uint___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_NotificationCategoryData___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_List_NotificationCategoryData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_uint__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Core_Gameplay_Managers_Notifications_Model_NotificationCategoryData_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_uint__GetEnumerator__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Google_Protobuf_Collections_RepeatedField_NotificationGroupDic__GetEnumerator__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Google_Protobuf_Collections_RepeatedField_NotificationCategoryDic__GetEnumerator__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_Notifications_Model_GameNotificationsModel___c__Init_b__4_0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Core_Gameplay_Managers_Notifications_Model_GameNotificationsModel___c_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_8435);
		    DAT_ram_00a5a67b = '\x01';
		  }
		  local_8 = (int *)0x0;
		  local_c = (int *)0x0;
		  if (*(int *)(param1 + 0xc) != 0) {
		    return;
		  }
		  iVar2 = unnamed_function_1417(System_Collections_Generic_List_NotificationCategoryData__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (iVar2,Method_System_Collections_Generic_List_NotificationCategoryData___ctor__);
		  local_4 = (int *)Google_Protobuf_Collections_RepeatedField_float___Equals
		                             (*(undefined4 *)(param2 + 0x2ac),
		                              Method_Google_Protobuf_Collections_RepeatedField_NotificationCategoryDic__GetEnumerator__
		                             );
		  local_14 = 0;
		  local_10 = &local_4;
		code_r0x8124d27c:
		  do {
		    piVar6 = local_4;
		    iVar9 = *local_4;
		    if (*(ushort *)(iVar9 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar11 = (int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar11) {
		          puVar3 = (undefined4 *)(iVar9 + piVar11[1] * 8 + 0xc0);
		          goto code_r0x8124d310;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar9 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar3 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_IEnumerator_TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x8124d57f:
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x8124d587;
		    }
		code_r0x8124d310:
		    DAT_ram_009d3e38 = 0;
		    iVar9 = import::env::invoke_iii(*puVar3,piVar6,puVar3[1]);
		    piVar6 = local_4;
		    if (DAT_ram_009d3e38 == 1) goto code_r0x8124d57f;
		    if (iVar9 == 0) {
		      iVar9 = 5;
		      goto code_r0x8124d5d4;
		    }
		    iVar9 = *local_4;
		    if (*(ushort *)(iVar9 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar11 = (int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8);
		        if (System_Collections_Generic_IEnumerator_NotificationCategoryDic__TypeInfo == *piVar11) {
		          puVar3 = (undefined4 *)(iVar9 + piVar11[1] * 8 + 0xc0);
		          goto code_r0x8124d3ea;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar9 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar3 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_Generic_IEnumerator_NotificationCategoryDic__TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x8124d561:
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x8124d587;
		    }
		code_r0x8124d3ea:
		    DAT_ram_009d3e38 = 0;
		    iVar9 = import::env::invoke_iii(*puVar3,piVar6,puVar3[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x8124d561;
		    DAT_ram_009d3e38 = 0;
		    uVar4 = import::env::invoke_iiiii
		                      (s_struct_Uniforms___color__array<v_ram_00001f04 + 0x30b,iVar9,param2,
		                       *(undefined4 *)(iVar9 + 0xc),iVar9);
		    iVar5 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar5 == 1) {
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x8124d587;
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar7 = import::env::invoke_ii
		                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                       Core_Gameplay_Managers_Notifications_Model_NotificationCategoryData_TypeInfo)
		    ;
		    if (DAT_ram_009d3e38 == 1) break;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viiii
		              (s_struct_Uniforms___color__array<v_ram_00001f04 + 0x30c,uVar7,iVar9,uVar4,iVar9);
		    iVar9 = Method_System_Collections_Generic_List_NotificationCategoryData__Add__;
		    if (DAT_ram_009d3e38 == 1) break;
		    *(int *)(iVar2 + 0x10) = *(int *)(iVar2 + 0x10) + 1;
		    uVar1 = *(uint *)(iVar2 + 0xc);
		    if (uVar1 < *(uint *)(*(int *)(iVar2 + 8) + 0xc)) {
		      *(uint *)(iVar2 + 0xc) = uVar1 + 1;
		      *(undefined4 *)(*(int *)(iVar2 + 8) + uVar1 * 4 + 0x10) = uVar7;
		      goto code_r0x8124d27c;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,iVar2,uVar7,
		               *(undefined4 *)(*(int *)(*(int *)(iVar9 + 0x10) + 0x60) + 0x38));
		  } while (DAT_ram_009d3e38 != 1);
		  DAT_ram_009d3e38 = 0;
		  uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x8124d587:
		  iVar9 = global_1;
		  iVar5 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar9 == iVar5) {
		    piVar6 = (int *)import::env::__cxa_begin_catch(uVar4);
		    local_14 = *piVar6;
		    iVar9 = 0;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_v(0x123);
		    iVar5 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar5 != 1) {
		code_r0x8124d5d4:
		      DAT_ram_009d3e38 = 0;
		      piVar6 = *local_10;
		      if (piVar6 != (int *)0x0) {
		        uVar1 = 0;
		        iVar5 = *piVar6;
		        if (*(ushort *)(iVar5 + 0xb6) != 0) {
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		              puVar8 = (uint *)(iVar5 + *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0)
		              ;
		              goto code_r0x8124d64f;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		        }
		        puVar8 = (uint *)func_ii_1080(piVar6,System_IDisposable_TypeInfo,0);
		code_r0x8124d64f:
		        (**(code **)((ulonglong)*puVar8 * 4))(piVar6,puVar8[1]);
		      }
		      if (local_14 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(local_14);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      if ((iVar9 != 0) &&
		         ((((iVar9 == 1 || (iVar9 == 2)) || (iVar9 == 3)) || ((iVar9 == 4 || (iVar9 != 5)))))) {
		        return;
		      }
		      if (*(int *)(Core_Gameplay_Managers_Notifications_Model_GameNotificationsModel___c_TypeInfo +
		                  0x74) == 0) {
		        func_ii_306000(
		                      Core_Gameplay_Managers_Notifications_Model_GameNotificationsModel___c_TypeInfo
		                      );
		      }
		      puVar3 = *(undefined4 **)
		                (Core_Gameplay_Managers_Notifications_Model_GameNotificationsModel___c_TypeInfo +
		                0x5c);
		      iVar9 = puVar3[1];
		      if (iVar9 == 0) {
		        if (*(int *)(Core_Gameplay_Managers_Notifications_Model_GameNotificationsModel___c_TypeInfo
		                    + 0x74) == 0) {
		          func_ii_306000(
		                        Core_Gameplay_Managers_Notifications_Model_GameNotificationsModel___c_TypeInfo
		                        );
		          puVar3 = *(undefined4 **)
		                    (Core_Gameplay_Managers_Notifications_Model_GameNotificationsModel___c_TypeInfo
		                    + 0x5c);
		        }
		        uVar4 = *puVar3;
		        iVar9 = unnamed_function_1417(System_Func_NotificationCategoryData__uint__TypeInfo);
		        System_Collections_Generic_Dictionary_KeyCollection_uint__object___GetEnumerator
		                  (iVar9,uVar4,
		                   Method_Core_Gameplay_Managers_Notifications_Model_GameNotificationsModel___c__Init_b__4_0__
		                   ,0);
		        *(int *)(*(int *)(
		                         Core_Gameplay_Managers_Notifications_Model_GameNotificationsModel___c_TypeInfo
		                         + 0x5c) + 4) = iVar9;
		      }
		      uVar4 = System_Linq_Enumerable__Min___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType_
		                        (iVar2,iVar9,
		                         Method_System_Linq_Enumerable_OrderBy_NotificationCategoryData__uint___);
		      uVar4 = System_Linq_Enumerable__Select_object__object_
		                        (uVar4,Method_System_Linq_Enumerable_ToList_NotificationCategoryData___);
		      *(undefined4 *)(param1 + 0xc) = uVar4;
		      uVar4 = unnamed_function_1417(System_Collections_Generic_Dictionary_uint__uint__TypeInfo);
		      System_Collections_Generic_List_GAFAnimationAssetInternal_KeyFrame____ctor
		                (uVar4,Method_System_Collections_Generic_Dictionary_uint__uint___ctor__);
		      *(undefined4 *)(param1 + 0x10) = uVar4;
		      uVar4 = unnamed_function_1417(System_Collections_Generic_List_uint__TypeInfo);
		      GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		                (uVar4,Method_System_Collections_Generic_List_uint___ctor__);
		      *(undefined4 *)(param1 + 0x14) = uVar4;
		      local_8 = (int *)Google_Protobuf_Collections_RepeatedField_float___Equals
		                                 (*(undefined4 *)(param2 + 0x2b0),
		                                  Method_Google_Protobuf_Collections_RepeatedField_NotificationGroupDic__GetEnumerator__
		                                 );
		      local_14 = 0;
		      local_10 = &local_8;
		      while( true ) {
		        piVar6 = local_8;
		        iVar2 = *local_8;
		        if (*(ushort *)(iVar2 + 0xb6) != 0) {
		          uVar1 = 0;
		          do {
		            piVar11 = (int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8);
		            if (System_Collections_IEnumerator_TypeInfo == *piVar11) {
		              puVar3 = (undefined4 *)(iVar2 + piVar11[1] * 8 + 0xc0);
		              goto code_r0x8124d85b;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		        }
		        DAT_ram_009d3e38 = 0;
		        puVar3 = (undefined4 *)
		                 import::env::invoke_iiii
		                           (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_8,
		                            System_Collections_IEnumerator_TypeInfo,0);
		        if (DAT_ram_009d3e38 == 1) break;
		code_r0x8124d85b:
		        DAT_ram_009d3e38 = 0;
		        iVar2 = import::env::invoke_iii(*puVar3,piVar6,puVar3[1]);
		        piVar6 = local_8;
		        if (DAT_ram_009d3e38 == 1) break;
		        iVar9 = 0;
		        if (iVar2 == 0) goto code_r0x8124e06e;
		        iVar2 = *local_8;
		        if (*(ushort *)(iVar2 + 0xb6) != 0) {
		          uVar1 = 0;
		          do {
		            piVar11 = (int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8);
		            if (System_Collections_Generic_IEnumerator_NotificationGroupDic__TypeInfo == *piVar11) {
		              puVar3 = (undefined4 *)(iVar2 + piVar11[1] * 8 + 0xc0);
		              goto code_r0x8124d942;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		        }
		        DAT_ram_009d3e38 = 0;
		        puVar3 = (undefined4 *)
		                 import::env::invoke_iiii
		                           (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_8,
		                            System_Collections_Generic_IEnumerator_NotificationGroupDic__TypeInfo,0)
		        ;
		        if (DAT_ram_009d3e38 == 1) {
		code_r0x8124da68:
		          DAT_ram_009d3e38 = 0;
		          uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          iVar2 = global_1;
		          goto code_r0x8124e027;
		        }
		code_r0x8124d942:
		        DAT_ram_009d3e38 = 0;
		        iVar5 = import::env::invoke_iii(*puVar3,piVar6,puVar3[1]);
		        iVar2 = Method_System_Collections_Generic_List_uint__Add__;
		        if (DAT_ram_009d3e38 == 1) goto code_r0x8124da68;
		        uVar4 = *(undefined4 *)(iVar5 + 0xc);
		        iVar10 = *(int *)(param1 + 0x14);
		        *(int *)(iVar10 + 0x10) = *(int *)(iVar10 + 0x10) + 1;
		        uVar1 = *(uint *)(iVar10 + 0xc);
		        if (*(uint *)(*(int *)(iVar10 + 8) + 0xc) <= uVar1) {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_viii
		                    (s_struct_Uniforms___color__array<v_ram_00000aff + 0x37a,iVar10,uVar4,
		                     *(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x60) + 0x38));
		          iVar2 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar2 != 1) goto code_r0x8124da10;
		          uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          iVar2 = global_1;
		          goto code_r0x8124e027;
		        }
		        *(uint *)(iVar10 + 0xc) = uVar1 + 1;
		        *(undefined4 *)(*(int *)(iVar10 + 8) + uVar1 * 4 + 0x10) = uVar4;
		code_r0x8124da10:
		        DAT_ram_009d3e38 = 0;
		        piVar6 = (int *)import::env::invoke_iii
		                                  (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x55,
		                                   *(undefined4 *)(iVar5 + 0x1c),
		                                   Method_Google_Protobuf_Collections_RepeatedField_uint__GetEnumerator__
		                                  );
		        iVar2 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar2 == 1) {
		          uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          iVar2 = global_1;
		          goto code_r0x8124e027;
		        }
		        local_1c = 0;
		        local_18 = &local_c;
		        local_c = piVar6;
		code_r0x8124da8c:
		        do {
		          piVar6 = local_c;
		          iVar2 = *local_c;
		          if (*(ushort *)(iVar2 + 0xb6) != 0) {
		            uVar1 = 0;
		            do {
		              piVar11 = (int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8);
		              if (System_Collections_IEnumerator_TypeInfo == *piVar11) {
		                puVar3 = (undefined4 *)(iVar2 + piVar11[1] * 8 + 0xc0);
		                goto code_r0x8124db20;
		              }
		              uVar1 = uVar1 + 1;
		            } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		          }
		          DAT_ram_009d3e38 = 0;
		          puVar3 = (undefined4 *)
		                   import::env::invoke_iiii
		                             (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_c,
		                              System_Collections_IEnumerator_TypeInfo,0);
		          if (DAT_ram_009d3e38 == 1) break;
		code_r0x8124db20:
		          DAT_ram_009d3e38 = 0;
		          iVar2 = import::env::invoke_iii(*puVar3,piVar6,puVar3[1]);
		          piVar6 = local_c;
		          if (DAT_ram_009d3e38 == 1) break;
		          if (iVar2 == 0) {
		            iVar5 = 7;
		            iVar2 = 0;
		            goto code_r0x8124de9c;
		          }
		          iVar2 = *local_c;
		          if (*(ushort *)(iVar2 + 0xb6) != 0) {
		            uVar1 = 0;
		            do {
		              piVar11 = (int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8);
		              if (System_Collections_Generic_IEnumerator_uint__TypeInfo == *piVar11) {
		                puVar3 = (undefined4 *)(iVar2 + piVar11[1] * 8 + 0xc0);
		                goto code_r0x8124dbfe;
		              }
		              uVar1 = uVar1 + 1;
		            } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		          }
		          DAT_ram_009d3e38 = 0;
		          puVar3 = (undefined4 *)
		                   import::env::invoke_iiii
		                             (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_c,
		                              System_Collections_Generic_IEnumerator_uint__TypeInfo,0);
		          if (DAT_ram_009d3e38 == 1) break;
		code_r0x8124dbfe:
		          DAT_ram_009d3e38 = 0;
		          uVar4 = import::env::invoke_iii(*puVar3,piVar6,puVar3[1]);
		          if (DAT_ram_009d3e38 == 1) break;
		          DAT_ram_009d3e38 = 0;
		          iVar2 = import::env::invoke_iiii
		                            (s_struct_Uniforms___color__array<v_ram_00001b87 + 0xd2,
		                             *(undefined4 *)(param1 + 0x10),uVar4,
		                             Method_System_Collections_Generic_Dictionary_uint__uint__ContainsKey__)
		          ;
		          if (DAT_ram_009d3e38 == 1) break;
		          if (iVar2 == 0) {
		            DAT_ram_009d3e38 = 0;
		            import::env::invoke_viiii
		                      (s_struct_Uniforms___color__array<v_ram_00001b87 + 0xd0,
		                       *(undefined4 *)(param1 + 0x10),uVar4,*(undefined4 *)(iVar5 + 0xc),
		                       Method_System_Collections_Generic_Dictionary_uint__uint__set_Item__);
		            if (DAT_ram_009d3e38 == 1) break;
		            goto code_r0x8124da8c;
		          }
		          DAT_ram_009d3e38 = 0;
		          uVar4 = import::env::invoke_iiii
		                            (s_struct_Uniforms___color__array<v_ram_00001f04 + 0x30e,
		                             *(undefined4 *)(param1 + 0x10),uVar4,
		                             Method_System_Collections_Generic_Dictionary_uint__uint__get_Item__);
		          if (DAT_ram_009d3e38 == 1) break;
		          DAT_ram_009d3e38 = 0;
		          local_20 = uVar4;
		          uVar4 = import::env::invoke_iii
		                            (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x19,DAT_ram_00a66958
		                             ,&local_20);
		          if (DAT_ram_009d3e38 == 1) break;
		          local_24 = *(undefined4 *)(iVar5 + 0xc);
		          DAT_ram_009d3e38 = 0;
		          uVar7 = import::env::invoke_iii
		                            (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x19,DAT_ram_00a66958
		                             ,&local_24);
		          if (DAT_ram_009d3e38 == 1) break;
		          DAT_ram_009d3e38 = 0;
		          uVar4 = import::env::invoke_iiiii
		                            (s_struct_Uniforms___color__array<v_ram_00000aff + 0x261,
		                             StringLiteral_8435,uVar4,uVar7,0);
		          if (DAT_ram_009d3e38 == 1) break;
		          if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		            DAT_ram_009d3e38 = 0;
		            import::env::invoke_vi
		                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                       OKG_Logs_Debug_TypeInfo);
		            if (DAT_ram_009d3e38 == 1) break;
		          }
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_vii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x3f,uVar4,0);
		        } while (DAT_ram_009d3e38 != 1);
		        DAT_ram_009d3e38 = 0;
		        uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        iVar2 = global_1;
		        iVar5 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		        if (iVar2 != iVar5) {
		code_r0x8124dfe4:
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001f04 + 0x30f,&local_1c);
		          iVar9 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar9 != 1) goto code_r0x8124e027;
		          goto code_r0x8124e139;
		        }
		        piVar6 = (int *)import::env::__cxa_begin_catch(uVar4);
		        iVar2 = *piVar6;
		        iVar5 = 0;
		        DAT_ram_009d3e38 = 0;
		        local_1c = iVar2;
		        import::env::invoke_v(0x123);
		        iVar10 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar10 == 1) {
		          uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          iVar2 = global_1;
		          goto code_r0x8124dfe4;
		        }
		code_r0x8124de9c:
		        piVar6 = local_c;
		        if (local_c != (int *)0x0) {
		          iVar10 = *local_c;
		          if (*(ushort *)(iVar10 + 0xb6) != 0) {
		            uVar1 = 0;
		            do {
		              piVar11 = (int *)(*(int *)(iVar10 + 0x58) + uVar1 * 8);
		              if (System_IDisposable_TypeInfo == *piVar11) {
		                puVar3 = (undefined4 *)(iVar10 + piVar11[1] * 8 + 0xc0);
		                goto code_r0x8124df39;
		              }
		              uVar1 = uVar1 + 1;
		            } while (*(ushort *)(iVar10 + 0xb6) != uVar1);
		          }
		          DAT_ram_009d3e38 = 0;
		          puVar3 = (undefined4 *)
		                   import::env::invoke_iiii
		                             (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_c,
		                              System_IDisposable_TypeInfo,0);
		          if (DAT_ram_009d3e38 != 1) {
		code_r0x8124df39:
		            DAT_ram_009d3e38 = 0;
		            import::env::invoke_vii(*puVar3,piVar6,puVar3[1]);
		            if (DAT_ram_009d3e38 != 1) goto code_r0x8124df75;
		          }
		          DAT_ram_009d3e38 = 0;
		          uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          iVar2 = global_1;
		          goto code_r0x8124e027;
		        }
		code_r0x8124df75:
		        if (iVar2 != 0) {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_vi(s_var<private>_posTex__array<vec4<_ram_00000655 + 0x1d3,iVar2);
		          iVar2 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar2 != 1) {
		            do {
		              halt_trap();
		            } while( true );
		          }
		          uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          iVar2 = global_1;
		          goto code_r0x8124e027;
		        }
		        if ((iVar5 != 0) &&
		           ((((iVar5 == 1 || (iVar5 == 2)) ||
		             ((iVar5 == 3 || (((iVar5 == 4 || (iVar5 == 5)) || (iVar5 == 6)))))) || (iVar5 != 7))))
		        goto code_r0x8124e06e;
		      }
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      iVar2 = global_1;
		code_r0x8124e027:
		      iVar9 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar9 == iVar2) {
		        piVar6 = (int *)import::env::__cxa_begin_catch(uVar4);
		        iVar9 = *piVar6;
		        DAT_ram_009d3e38 = 0;
		        local_14 = iVar9;
		        import::env::invoke_v(0x123);
		        iVar2 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar2 != 1) {
		code_r0x8124e06e:
		          piVar6 = local_8;
		          DAT_ram_009d3e38 = 0;
		          if (local_8 != (int *)0x0) {
		            uVar1 = 0;
		            iVar2 = *local_8;
		            if (*(ushort *)(iVar2 + 0xb6) != 0) {
		              do {
		                if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		                  puVar8 = (uint *)(iVar2 + *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 +
		                                   0xc0);
		                  goto code_r0x8124e0e6;
		                }
		                uVar1 = uVar1 + 1;
		              } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		            }
		            puVar8 = (uint *)func_ii_1080(local_8,System_IDisposable_TypeInfo,0);
		code_r0x8124e0e6:
		            (**(code **)((ulonglong)*puVar8 * 4))(piVar6,puVar8[1]);
		          }
		          if (iVar9 == 0) {
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
		      import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001f04 + 0x310,&local_14);
		      goto joined_r0x8124d7b2;
		    }
		    uVar4 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001f04 + 0x30d,&local_14);
		joined_r0x8124d7b2:
		  if (DAT_ram_009d3e38 != 1) {
		    DAT_ram_009d3e38 = 0;
		    import::env::__resumeException(uVar4);
		    do {
		      halt_trap();
		    } while( true );
		  }
		code_r0x8124e139:
		  DAT_ram_009d3e38 = 0;
		  import::env::__cxa_find_matching_catch_3(0);
		  unnamed_function_937();
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06006B7A RID: 27514 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006B7A")]
		[Address(RVA = "0xB678", Offset = "0xB678", VA = "0xB678")]
		private void Init(Dictionaries dictionaries)
		{
		/* --- GHIDRA: Init ---
		uint Core_Gameplay_Managers_Notifications_Model_GameNotificationsModel__Init
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param2_00;
		  int iVar1;
		  
		  if (DAT_ram_00a5a67e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__uint__get_Item__);
		    DAT_ram_00a5a67e = '\x01';
		  }
		  param2_00 = System_Collections_Generic_List_object___get_Item
		                        (*(undefined4 *)(param1 + 0x10),param2,
		                         Method_System_Collections_Generic_Dictionary_uint__uint__get_Item__);
		  iVar1 = func_ii_8735(param1,param2_00,param1);
		  return (uint)*(byte *)(iVar1 + 0x10);
		}
		*/

		}

		// Token: 0x06006B7B RID: 27515 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006B7B")]
		[Address(RVA = "0x220F", Offset = "0x220F", VA = "0x220F")]
		private List<NotificationGroupData> GetNotificationGroups(Dictionaries dictionaries, uint categoryId)
		{
		/* --- GHIDRA: GetNotificationGroups ---
		void Core_Gameplay_Managers_Notifications_Model_GameNotificationsModel__GetNotificationGroups
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  undefined4 *puVar2;
		  int param1_00;
		  
		  if (DAT_ram_00a5a680 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_ToDictionary_NotificationGroupData__uint___);
		    Mono_Security_ASN1__get_Item(&System_Func_NotificationGroupData__uint__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_Notifications_Model_NotificationCategoryData___c___ctor_b__12_0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Core_Gameplay_Managers_Notifications_Model_NotificationCategoryData___c_TypeInfo);
		    DAT_ram_00a5a680 = '\x01';
		  }
		  *(undefined4 *)(param1 + 0xc) = param3;
		  *(undefined4 *)(param1 + 8) = param2;
		  if (*(int *)(Core_Gameplay_Managers_Notifications_Model_NotificationCategoryData___c_TypeInfo +
		              0x74) == 0) {
		    func_ii_306000(Core_Gameplay_Managers_Notifications_Model_NotificationCategoryData___c_TypeInfo)
		    ;
		  }
		  puVar2 = *(undefined4 **)
		            (Core_Gameplay_Managers_Notifications_Model_NotificationCategoryData___c_TypeInfo + 0x5c
		            );
		  param1_00 = puVar2[1];
		  if (param1_00 == 0) {
		    if (*(int *)(Core_Gameplay_Managers_Notifications_Model_NotificationCategoryData___c_TypeInfo +
		                0x74) == 0) {
		      func_ii_306000(
		                    Core_Gameplay_Managers_Notifications_Model_NotificationCategoryData___c_TypeInfo
		                    );
		      puVar2 = *(undefined4 **)
		                (Core_Gameplay_Managers_Notifications_Model_NotificationCategoryData___c_TypeInfo +
		                0x5c);
		    }
		    uVar1 = *puVar2;
		    param1_00 = unnamed_function_1417(System_Func_NotificationGroupData__uint__TypeInfo);
		    System_Collections_Generic_Dictionary_KeyCollection_uint__object___GetEnumerator
		              (param1_00,uVar1,
		               Method_Core_Gameplay_Managers_Notifications_Model_NotificationCategoryData___c___ctor_b__12_0__
		               ,0);
		    *(int *)(*(int *)(
		                     Core_Gameplay_Managers_Notifications_Model_NotificationCategoryData___c_TypeInfo
		                     + 0x5c) + 4) = param1_00;
		  }
		  uVar1 = System_Linq_Enumerable__ToDictionary_object__object_
		                    (param3,param1_00,
		                     Method_System_Linq_Enumerable_ToDictionary_NotificationGroupData__uint___);
		  *(undefined4 *)(param1 + 0x10) = uVar1;
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06006B7C RID: 27516 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006B7C")]
		[Address(RVA = "0x2220", Offset = "0x2220", VA = "0x2220")]
		public NotificationGroupData GetGroup(uint groupId)
		{
			return null;
		}

		// Token: 0x06006B7D RID: 27517 RVA: 0x00013D58 File Offset: 0x00011F58
		[Token(Token = "0x6006B7D")]
		[Address(RVA = "0x1EC1", Offset = "0x1EC1", VA = "0x1EC1")]
		public bool IsGroupEnabled(uint groupId)
		{
			return default(bool);
		}

		// Token: 0x06006B7E RID: 27518 RVA: 0x00013D70 File Offset: 0x00011F70
		[Token(Token = "0x6006B7E")]
		[Address(RVA = "0xB679", Offset = "0xB679", VA = "0xB679")]
		public bool IsNotificationEnabled(uint notificationId)
		{
		/* --- GHIDRA: IsNotificationEnabled ---
		void Core_Gameplay_Managers_Notifications_Model_GameNotificationsModel__IsNotificationEnabled
		               (undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5a67f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Core_Gameplay_Managers_Notifications_Model_GameNotificationsModel___c_TypeInfo);
		    DAT_ram_00a5a67f = '\x01';
		  }
		  uVar1 = unnamed_function_1417
		                    (Core_Gameplay_Managers_Notifications_Model_GameNotificationsModel___c_TypeInfo)
		  ;
		  **(undefined4 **)
		    (Core_Gameplay_Managers_Notifications_Model_GameNotificationsModel___c_TypeInfo + 0x5c) = uVar1;
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x040038BE RID: 14526
		[Token(Token = "0x40038BE")]
		[FieldOffset(Offset = "0xC")]
		public List<NotificationCategoryData> NotificationCategories;

		// Token: 0x040038BF RID: 14527
		[Token(Token = "0x40038BF")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<uint, uint> GroupByNotificationId;

		// Token: 0x040038C0 RID: 14528
		[Token(Token = "0x40038C0")]
		[FieldOffset(Offset = "0x14")]
		public List<uint> AllGroupIds;
	}
}
