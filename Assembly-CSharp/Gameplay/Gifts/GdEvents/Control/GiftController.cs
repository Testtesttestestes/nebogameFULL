using System;
using System.Collections.Generic;
using Core.Data;
using Cysharp.Threading.Tasks;
using Gameplay.Chat.Model;
using Gameplay.Gifts.Controller;
using Gameplay.Gifts.Events;
using Gameplay.Gifts.GdEvents.Model;
using Google.Protobuf;
using Il2CppDummyDll;
using Utils;

namespace Gameplay.Gifts.GdEvents.Control
{
	// Token: 0x02000714 RID: 1812
	[Token(Token = "0x2000714")]
	public class GiftController : GiftsController
	{
		// Token: 0x06002B5C RID: 11100 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B5C")]
		[Address(RVA = "0x7BF6", Offset = "0x7BF6", VA = "0x7BF6", Slot = "5")]
		public override void Dispose()
		{
		/* --- GHIDRA: <GetTargetUsers>b__3_0 ---
		void Gameplay_Gifts_GdEvents_Control_GiftController___GetTargetUsers_b__3_0
		               (int *param1,undefined4 param2)
		
		{
		  ushort uVar1;
		  uint uVar2;
		  undefined4 *puVar3;
		  undefined4 param2_00;
		  undefined4 uVar4;
		  int iVar5;
		  undefined4 *param2_01;
		  uint *puVar6;
		  int *piVar7;
		  int iVar8;
		  int iVar9;
		  int *piVar10;
		  int iVar11;
		  undefined4 uVar12;
		  int *piVar13;
		  undefined1 auStack_30 [4];
		  undefined8 local_2c;
		  int local_24;
		  undefined8 local_20;
		  int local_18;
		  undefined8 local_10;
		  ushort local_8;
		  
		  if (DAT_ram_00a5a23e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_UserIsleEvents__UserIsleModel__UserIsleController__UserBuildingTypes__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskMethodBuilder_IList_UserData___AwaitUnsafeOnCompleted_UniTask_Awaiter_IList_UserData____GiftController__GetTargetUsers_d__3___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskMethodBuilder_IList_UserData___SetResult__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Cysharp_Threading_Tasks_UniTask_Awaiter_IList_UserData___GetResult__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Cysharp_Threading_Tasks_UniTask_Awaiter_IList_UserData___get_IsCompleted__);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToHashSet_UserData___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Where_UserData___);
		    Mono_Security_ASN1__get_Item(&System_Func_UserData__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Gifts_GdEvents_Control_GiftController__GetTargetUsers_b__3_0__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_HashSet_UserData__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_HashSet_UserData__CopyTo__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_HashSet_UserData___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_HashSet_UserData__get_Count__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_HashSet_UserData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Chat_Model_IFavoriteUsersProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_World_Model_IsleHeap_UserIsle__GetNextIsle__);
		    Mono_Security_ASN1__get_Item(&Method_Sirenix_Utilities_LinqExtensions_AddRange_UserData___);
		    Mono_Security_ASN1__get_Item(&System_Math_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Cysharp_Threading_Tasks_UniTask_IList_UserData___GetAwaiter__);
		    Mono_Security_ASN1__get_Item(&Core_Data_UserData___TypeInfo);
		    DAT_ram_00a5a23e = '\x01';
		  }
		  _local_8 = 0;
		  local_10 = 0;
		  local_18 = 0;
		  local_20 = 0;
		  piVar7 = (int *)param1[4];
		  if (*param1 == 0) {
		    _local_8 = param1[8];
		    local_10 = *(undefined8 *)(param1 + 6);
		    param1[6] = 0;
		    param1[7] = 0;
		    param1[8] = 0;
		    *param1 = -1;
		    piVar10 = (int *)local_10;
		code_r0x811eb0c8:
		    if (piVar10 == (int *)0x0) {
		code_r0x811eb0cd:
		      uVar4 = local_10._4_4_;
		code_r0x811eb23b:
		      uVar2 = 0;
		      piVar10 = (int *)piVar7[7];
		      iVar8 = *piVar10;
		      if (*(ushort *)(iVar8 + 0xb6) != 0) {
		        do {
		          if (Gameplay_Chat_Model_IFavoriteUsersProvider_TypeInfo ==
		              *(int *)(*(int *)(iVar8 + 0x58) + uVar2 * 8)) {
		            puVar3 = (undefined4 *)
		                     (iVar8 + *(int *)(*(int *)(iVar8 + 0x58) + uVar2 * 8 + 4) * 8 + 0xc0);
		            goto code_r0x811eb2d8;
		          }
		          uVar2 = uVar2 + 1;
		        } while (*(ushort *)(iVar8 + 0xb6) != uVar2);
		      }
		      DAT_ram_009d3e38 = 0;
		      puVar3 = (undefined4 *)
		               import::env::invoke_iiii
		                         (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar10,
		                          Gameplay_Chat_Model_IFavoriteUsersProvider_TypeInfo,0);
		      if (DAT_ram_009d3e38 != 1) {
		code_r0x811eb2d8:
		        DAT_ram_009d3e38 = 0;
		        uVar12 = import::env::invoke_iii(*puVar3,piVar10,puVar3[1]);
		        if (DAT_ram_009d3e38 != 1) {
		          DAT_ram_009d3e38 = 0;
		          iVar9 = import::env::invoke_iii
		                            (*(undefined4 *)(*piVar7 + 0x100),piVar7,
		                             *(undefined4 *)(*piVar7 + 0x104));
		          iVar8 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar8 == 1) {
		            uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x811eba30;
		          }
		          uVar2 = 0;
		          piVar10 = *(int **)(iVar9 + 0x1c);
		          iVar8 = *piVar10;
		          if (*(ushort *)(iVar8 + 0xb6) != 0) {
		            do {
		              if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar2 * 8)) {
		                puVar3 = (undefined4 *)
		                         (*(int *)(*(int *)(iVar8 + 0x58) + uVar2 * 8 + 4) * 8 + iVar8 + 0x110);
		                goto code_r0x811eb3f6;
		              }
		              uVar2 = uVar2 + 1;
		            } while (*(ushort *)(iVar8 + 0xb6) != uVar2);
		          }
		          DAT_ram_009d3e38 = 0;
		          puVar3 = (undefined4 *)
		                   import::env::invoke_iiii
		                             (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar10,
		                              Core_Gameplay_IGame_TypeInfo,10);
		          if (DAT_ram_009d3e38 != 1) {
		code_r0x811eb3f6:
		            DAT_ram_009d3e38 = 0;
		            iVar8 = import::env::invoke_iii(*puVar3,piVar10,puVar3[1]);
		            if (DAT_ram_009d3e38 != 1) {
		              iVar8 = *(int *)(iVar8 + 0x14);
		              DAT_ram_009d3e38 = 0;
		              param2_00 = import::env::invoke_ii
		                                    (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                                     System_Collections_Generic_HashSet_UserData__TypeInfo);
		              if (DAT_ram_009d3e38 != 1) {
		                DAT_ram_009d3e38 = 0;
		                import::env::invoke_vii
		                          (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x45,param2_00,
		                           Method_System_Collections_Generic_HashSet_UserData___ctor__);
		                if (DAT_ram_009d3e38 != 1) {
		                  DAT_ram_009d3e38 = 0;
		                  import::env::invoke_viii
		                            (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x3b,param2_00,uVar4,
		                             Method_Sirenix_Utilities_LinqExtensions_AddRange_UserData___);
		                  iVar9 = DAT_ram_009d3e38;
		                  DAT_ram_009d3e38 = 0;
		                  if (iVar9 == 1) {
		                    uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                  }
		                  else {
		                    DAT_ram_009d3e38 = 0;
		                    import::env::invoke_viii
		                              (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x3b,param2_00,
		                               uVar12,Method_Sirenix_Utilities_LinqExtensions_AddRange_UserData___);
		                    iVar9 = DAT_ram_009d3e38;
		                    DAT_ram_009d3e38 = 0;
		                    if (iVar9 == 1) {
		                      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                    }
		                    else {
		                      if (*(int *)(iVar8 + 0x24) != 0) {
		                        iVar11 = *(int *)(*(int *)(*(int *)(iVar8 + 0x24) + 0x10) + 8);
		                        DAT_ram_009d3e38 = 0;
		                        iVar5 = import::env::invoke_iii
		                                          (*(undefined4 *)(*piVar7 + 0x100),piVar7,
		                                           *(undefined4 *)(*piVar7 + 0x104));
		                        iVar9 = DAT_ram_009d3e38;
		                        DAT_ram_009d3e38 = 0;
		                        if (iVar9 == 1) {
		                          uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                          goto code_r0x811eba30;
		                        }
		                        if (*(int *)(iVar5 + 8) != iVar11) {
		                          DAT_ram_009d3e38 = 0;
		                          import::env::invoke_iiii
		                                    (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x19d,
		                                     param2_00,
		                                     *(undefined4 *)(*(int *)(*(int *)(iVar8 + 0x24) + 0x10) + 8),
		                                     Method_System_Collections_Generic_HashSet_UserData__Add__);
		                          iVar9 = DAT_ram_009d3e38;
		                          DAT_ram_009d3e38 = 0;
		                          if (iVar9 == 1) {
		                            uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                            goto code_r0x811eba30;
		                          }
		                        }
		                        iVar9 = 0;
		                        if (0 < param1[5]) {
		                          do {
		                            DAT_ram_009d3e38 = 0;
		                            iVar11 = import::env::invoke_iii
		                                               (*(undefined4 *)(*piVar7 + 0x100),piVar7,
		                                                *(undefined4 *)(*piVar7 + 0x104));
		                            iVar5 = DAT_ram_009d3e38;
		                            DAT_ram_009d3e38 = 0;
		                            if (iVar5 == 1) {
		                              uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                              goto code_r0x811eba30;
		                            }
		                            piVar10 = *(int **)(iVar11 + 0x1c);
		                            iVar5 = *piVar10;
		                            if (*(ushort *)(iVar5 + 0xb6) != 0) {
		                              uVar2 = 0;
		                              do {
		                                piVar13 = (int *)(*(int *)(iVar5 + 0x58) + uVar2 * 8);
		                                if (Core_Gameplay_IGame_TypeInfo == *piVar13) {
		                                  puVar3 = (undefined4 *)(piVar13[1] * 8 + iVar5 + 0x110);
		                                  goto code_r0x811eb6f4;
		                                }
		                                uVar2 = uVar2 + 1;
		                              } while (*(ushort *)(iVar5 + 0xb6) != uVar2);
		                            }
		                            DAT_ram_009d3e38 = 0;
		                            puVar3 = (undefined4 *)
		                                     import::env::invoke_iiii
		                                               (s_Allocator__0___Blocksize__1__mus_ram_00000421 +
		                                                0x18,piVar10,Core_Gameplay_IGame_TypeInfo,10);
		                            if (DAT_ram_009d3e38 == 1) {
		code_r0x811eb7e0:
		                              DAT_ram_009d3e38 = 0;
		                              uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                              goto code_r0x811eba30;
		                            }
		code_r0x811eb6f4:
		                            DAT_ram_009d3e38 = 0;
		                            iVar5 = import::env::invoke_iii(*puVar3,piVar10,puVar3[1]);
		                            if (DAT_ram_009d3e38 == 1) goto code_r0x811eb7e0;
		                            DAT_ram_009d3e38 = 0;
		                            iVar9 = iVar9 + 1;
		                            iVar11 = import::env::invoke_iiiii
		                                               (s_struct_Uniforms___color__array<v_ram_00001f04 +
		                                                0x278,*(undefined4 *)(*(int *)(iVar5 + 0x14) + 0x30)
		                                                ,*(undefined4 *)(iVar8 + 0x24),iVar9,
		                                                Method_Gameplay_World_Model_IsleHeap_UserIsle__GetNextIsle__
		                                               );
		                            iVar5 = DAT_ram_009d3e38;
		                            DAT_ram_009d3e38 = 0;
		                            if (iVar5 == 1) {
		                              uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                              goto code_r0x811eba30;
		                            }
		                            if (iVar11 != 0) {
		                              DAT_ram_009d3e38 = 0;
		                              import::env::invoke_iiii
		                                        (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x19d,
		                                         param2_00,*(undefined4 *)(*(int *)(iVar11 + 0x10) + 8),
		                                         Method_System_Collections_Generic_HashSet_UserData__Add__);
		                              iVar5 = DAT_ram_009d3e38;
		                              DAT_ram_009d3e38 = 0;
		                              if (iVar5 == 1) {
		                                uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                                goto code_r0x811eba30;
		                              }
		                            }
		                          } while (iVar9 < param1[5]);
		                        }
		                      }
		                      DAT_ram_009d3e38 = 0;
		                      uVar4 = import::env::invoke_ii
		                                        (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                                         System_Func_UserData__bool__TypeInfo);
		                      if (DAT_ram_009d3e38 != 1) {
		                        DAT_ram_009d3e38 = 0;
		                        import::env::invoke_viiii
		                                  (s_struct_Uniforms___color__array<v_ram_00000aff + 0x21b,uVar4,
		                                   piVar7,
		                                   Method_Gameplay_Gifts_GdEvents_Control_GiftController__GetTargetUsers_b__3_0__
		                                   ,0);
		                        if (DAT_ram_009d3e38 != 1) {
		                          DAT_ram_009d3e38 = 0;
		                          uVar4 = import::env::invoke_iiii
		                                            (s_struct_Uniforms___color__array<v_ram_00000aff + 0x226
		                                             ,param2_00,uVar4,
		                                             Method_System_Linq_Enumerable_Where_UserData___);
		                          iVar8 = DAT_ram_009d3e38;
		                          DAT_ram_009d3e38 = 0;
		                          if (iVar8 == 1) {
		                            uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                          }
		                          else {
		                            DAT_ram_009d3e38 = 0;
		                            iVar9 = import::env::invoke_iii
		                                              (s_struct_Uniforms___color__array<v_ram_00001f04 +
		                                               0x279,uVar4,
		                                               Method_System_Linq_Enumerable_ToHashSet_UserData___);
		                            iVar8 = DAT_ram_009d3e38;
		                            DAT_ram_009d3e38 = 0;
		                            if (iVar8 == 1) {
		                              uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                            }
		                            else {
		                              iVar8 = param1[5];
		                              uVar4 = *(undefined4 *)(iVar9 + 0x10);
		                              if (*(int *)(System_Math_TypeInfo + 0x74) == 0) {
		                                DAT_ram_009d3e38 = 0;
		                                import::env::invoke_vi
		                                          (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                                           System_Math_TypeInfo);
		                                iVar5 = DAT_ram_009d3e38;
		                                DAT_ram_009d3e38 = 0;
		                                if (iVar5 == 1) {
		                                  uVar4 = import::env::__cxa_find_matching_catch_3
		                                                    (&DAT_ram_0072c9c8);
		                                  goto code_r0x811eba30;
		                                }
		                              }
		                              DAT_ram_009d3e38 = 0;
		                              uVar4 = UnityEngine_Mathf__Min(uVar4,iVar8,0);
		                              iVar8 = DAT_ram_009d3e38;
		                              DAT_ram_009d3e38 = 0;
		                              if (iVar8 == 1) {
		                                uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                              }
		                              else {
		                                DAT_ram_009d3e38 = 0;
		                                iVar5 = import::env::invoke_iii
		                                                  (s_var<private>_posTex__array<vec4<_ram_00000655 +
		                                                   0x1b1,Core_Data_UserData___TypeInfo,uVar4);
		                                iVar8 = DAT_ram_009d3e38;
		                                DAT_ram_009d3e38 = 0;
		                                if (iVar8 == 1) {
		                                  uVar4 = import::env::__cxa_find_matching_catch_3
		                                                    (&DAT_ram_0072c9c8);
		                                }
		                                else {
		                                  DAT_ram_009d3e38 = 0;
		                                  import::env::invoke_viiiii
		                                            (s_struct_Uniforms___color__array<v_ram_00001f04 + 0x27a
		                                             ,iVar9,iVar5,0,*(undefined4 *)(iVar5 + 0xc),
		                                             Method_System_Collections_Generic_HashSet_UserData__CopyTo__
		                                            );
		                                  iVar8 = DAT_ram_009d3e38;
		                                  DAT_ram_009d3e38 = 0;
		                                  if (iVar8 != 1) {
		                                    *param1 = -2;
		                                    piVar7 = (int *)param1[1];
		                                    if (piVar7 == (int *)0x0) {
		                                      param1[3] = iVar5;
		                                      return;
		                                    }
		                                    iVar8 = *(int *)(
		                                                  Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskMethodBuilder_IList_UserData___SetResult__
		                                                  + 0x10);
		                                    if ((*(byte *)(iVar8 + 0xbd) & 1) == 0) {
		                                      iVar8 = func_ii_1079(iVar8);
		                                    }
		                                    iVar8 = *(int *)(*(int *)(iVar8 + 0x60) + 4);
		                                    if ((*(byte *)(iVar8 + 0xbd) & 1) == 0) {
		                                      iVar8 = func_ii_1079(iVar8);
		                                    }
		                                    iVar9 = *piVar7;
		                                    if (*(ushort *)(iVar9 + 0xb6) != 0) {
		                                      uVar2 = 0;
		                                      do {
		                                        if (iVar8 == *(int *)(*(int *)(iVar9 + 0x58) + uVar2 * 8)) {
		                                          puVar6 = (uint *)(*(int *)(*(int *)(iVar9 + 0x58) +
		                                                                     uVar2 * 8 + 4) * 8 + iVar9 +
		                                                           0xd0);
		                                          goto code_r0x811ebc0e;
		                                        }
		                                        uVar2 = uVar2 + 1;
		                                      } while (*(ushort *)(iVar9 + 0xb6) != uVar2);
		                                    }
		                                    puVar6 = (uint *)func_ii_1080(piVar7,iVar8,2);
		code_r0x811ebc0e:
		                                    (**(code **)((ulonglong)*puVar6 * 4))(piVar7,iVar5,puVar6[1]);
		                                    return;
		                                  }
		                                  uVar4 = import::env::__cxa_find_matching_catch_3
		                                                    (&DAT_ram_0072c9c8);
		                                }
		                              }
		                            }
		                          }
		                          goto code_r0x811eba30;
		                        }
		                      }
		                      DAT_ram_009d3e38 = 0;
		                      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                    }
		                  }
		                  goto code_r0x811eba30;
		                }
		              }
		              DAT_ram_009d3e38 = 0;
		              uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		              goto code_r0x811eba30;
		            }
		          }
		          DAT_ram_009d3e38 = 0;
		          uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x811eba30;
		        }
		      }
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    }
		    else {
		      uVar1 = local_8;
		      iVar8 = *(int *)(Method_Cysharp_Threading_Tasks_UniTask_Awaiter_IList_UserData___GetResult__ +
		                      0x10);
		      if ((*(byte *)(iVar8 + 0xbd) & 1) == 0) {
		        DAT_ram_009d3e38 = 0;
		        iVar8 = import::env::invoke_ii(s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x17,iVar8)
		        ;
		        if (DAT_ram_009d3e38 != 1) goto code_r0x811eb124;
		      }
		      else {
		code_r0x811eb124:
		        iVar8 = *(int *)(*(int *)(iVar8 + 0x60) + 0x14);
		        if ((*(byte *)(iVar8 + 0xbd) & 1) == 0) {
		          DAT_ram_009d3e38 = 0;
		          iVar8 = import::env::invoke_ii
		                            (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x17,iVar8);
		          if (DAT_ram_009d3e38 == 1) goto code_r0x811eb51a;
		        }
		        iVar9 = *piVar10;
		        if (*(ushort *)(iVar9 + 0xb6) != 0) {
		          uVar2 = 0;
		          do {
		            if (iVar8 == *(int *)(*(int *)(iVar9 + 0x58) + uVar2 * 8)) {
		              puVar3 = (undefined4 *)
		                       (iVar9 + *(int *)(*(int *)(iVar9 + 0x58) + uVar2 * 8 + 4) * 8 + 0xc0);
		              goto code_r0x811eb1f5;
		            }
		            uVar2 = uVar2 + 1;
		          } while (*(ushort *)(iVar9 + 0xb6) != uVar2);
		        }
		        DAT_ram_009d3e38 = 0;
		        puVar3 = (undefined4 *)
		                 import::env::invoke_iiii
		                           (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar10,iVar8,0);
		        if (DAT_ram_009d3e38 != 1) {
		code_r0x811eb1f5:
		          DAT_ram_009d3e38 = 0;
		          uVar4 = import::env::invoke_iiii(*puVar3,piVar10,(int)(short)uVar1,puVar3[1]);
		          if (DAT_ram_009d3e38 != 1) goto code_r0x811eb23b;
		        }
		      }
		code_r0x811eb51a:
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    }
		  }
		  else {
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_00001f04 + 0x276,&local_2c,piVar7,auStack_30);
		    iVar8 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar8 == 1) {
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    }
		    else {
		      local_18 = local_24;
		      local_20 = local_2c;
		      if ((*(byte *)(*(int *)(Method_Cysharp_Threading_Tasks_UniTask_IList_UserData___GetAwaiter__ +
		                             0x10) + 0xbd) & 1) == 0) {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_ii
		                  (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x17,
		                   *(int *)(Method_Cysharp_Threading_Tasks_UniTask_IList_UserData___GetAwaiter__ +
		                           0x10));
		        iVar8 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar8 == 1) {
		          uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x811eba30;
		        }
		      }
		      _local_8 = local_18;
		      local_10 = local_20;
		      if ((*(byte *)(*(int *)(
		                             Method_Cysharp_Threading_Tasks_UniTask_Awaiter_IList_UserData___get_IsCompleted__
		                             + 0x10) + 0xbd) & 1) == 0) {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_ii
		                  (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x17,
		                   *(int *)(
		                           Method_Cysharp_Threading_Tasks_UniTask_Awaiter_IList_UserData___get_IsCompleted__
		                           + 0x10));
		        if (DAT_ram_009d3e38 != 1) goto code_r0x811eaed9;
		      }
		      else {
		code_r0x811eaed9:
		        if (DAT_ram_00a63c4a == '\0') {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_vi(0x7ff,&Cysharp_Threading_Tasks_IUniTaskSource_TypeInfo);
		          if (DAT_ram_009d3e38 == 1) goto code_r0x811eb088;
		          DAT_ram_00a63c4a = '\x01';
		        }
		        piVar10 = (int *)local_10;
		        if ((int *)local_10 == (int *)0x0) goto code_r0x811eb0cd;
		        uVar2 = 0;
		        uVar1 = local_8;
		        iVar8 = *(int *)local_10;
		        if (*(ushort *)(iVar8 + 0xb6) != 0) {
		          do {
		            if (Cysharp_Threading_Tasks_IUniTaskSource_TypeInfo ==
		                *(int *)(*(int *)(iVar8 + 0x58) + uVar2 * 8)) {
		              puVar3 = (undefined4 *)
		                       (iVar8 + *(int *)(*(int *)(iVar8 + 0x58) + uVar2 * 8 + 4) * 8 + 0xc0);
		              goto code_r0x811eafc7;
		            }
		            uVar2 = uVar2 + 1;
		          } while (*(ushort *)(iVar8 + 0xb6) != uVar2);
		        }
		        DAT_ram_009d3e38 = 0;
		        puVar3 = (undefined4 *)
		                 import::env::invoke_iiii
		                           (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,(int *)local_10,
		                            Cysharp_Threading_Tasks_IUniTaskSource_TypeInfo,0);
		        if (DAT_ram_009d3e38 != 1) {
		code_r0x811eafc7:
		          DAT_ram_009d3e38 = 0;
		          iVar8 = import::env::invoke_iiii(*puVar3,piVar10,(int)(short)uVar1,puVar3[1]);
		          if (DAT_ram_009d3e38 != 1) {
		            if (iVar8 != 0) goto code_r0x811eb0c8;
		            *param1 = 0;
		            *(undefined8 *)(param1 + 6) = local_10;
		            param1[8] = _local_8;
		            DAT_ram_009d3e38 = 0;
		            import::env::invoke_viiii
		                      (s_struct_Uniforms___color__array<v_ram_00001f04 + 0x277,param1 + 1,&local_10,
		                       param1,
		                       Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskMethodBuilder_IList_UserData___AwaitUnsafeOnCompleted_UniTask_Awaiter_IList_UserData____GiftController__GetTargetUsers_d__3___
		                      );
		            iVar8 = DAT_ram_009d3e38;
		            DAT_ram_009d3e38 = 0;
		            if (iVar8 != 1) {
		              DAT_ram_009d3e38 = 0;
		              return;
		            }
		            uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x811eba30;
		          }
		        }
		      }
		code_r0x811eb088:
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    }
		  }
		code_r0x811eba30:
		  iVar8 = global_1;
		  iVar9 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar8 == iVar9) {
		    puVar3 = (undefined4 *)import::env::__cxa_begin_catch(uVar4);
		    DAT_ram_009d3e38 = 0;
		    uVar4 = import::env::invoke_ii
		                      (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1c,
		                       &System_Exception_TypeInfo);
		    if (DAT_ram_009d3e38 != 1) {
		      DAT_ram_009d3e38 = 0;
		      iVar9 = import::env::invoke_iii
		                        (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1d,uVar4,
		                         *(undefined4 *)*puVar3);
		      iVar8 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar8 != 1) {
		        if (iVar9 != 0) {
		          uVar12 = *puVar3;
		          import::env::__cxa_end_catch();
		          *param1 = -2;
		          uVar4 = unnamed_function_2232
		                            (&
		                             Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskMethodBuilder_IList_UserData___SetException__
		                            );
		          Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskMethodBuilder_UniTask___Create
		                    (param1 + 1,uVar12,uVar4);
		          return;
		        }
		        param2_01 = (undefined4 *)unnamed_function_951(4);
		        *param2_01 = *puVar3;
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1e,param2_01,
		                   &DAT_ram_0072c9c8,0);
		        if (DAT_ram_009d3e38 != 1) goto code_r0x811ebc2e;
		      }
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar4 = import::env::__cxa_find_matching_catch_2();
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_v(0x123);
		    iVar8 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar8 == 1) {
		      import::env::__cxa_find_matching_catch_3(0);
		      unnamed_function_937();
		code_r0x811ebc2e:
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  import::env::__resumeException(uVar4);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		/* --- GHIDRA: Dispose ---
		void Gameplay_Gifts_GdEvents_Control_GiftController__Dispose
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5a251 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_MVC_AbstractController_GiftsModel__GiftsEvents___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_SocialService___);
		    Mono_Security_ASN1__get_Item(&Core_Net_ServiceFactory_TypeInfo);
		    DAT_ram_00a5a251 = '\x01';
		  }
		  Gameplay_Combat_AbstractCombat_object__object__object__object__object___set_User
		            (param1,param3,param4,Method_MVC_AbstractController_GiftsModel__GiftsEvents___ctor__);
		  if (*(int *)(Core_Net_ServiceFactory_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_ServiceFactory_TypeInfo);
		  }
		  uVar1 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                    (Method_Core_Net_ServiceFactory_GetService_SocialService___);
		  *(undefined4 *)(param1 + 0x1c) = param2;
		  *(undefined4 *)(param1 + 0x18) = uVar1;
		  return;
		}
		*/

		}

		// Token: 0x06002B5D RID: 11101 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B5D")]
		[Address(RVA = "0x7BF7", Offset = "0x7BF7", VA = "0x7BF7")]
		public GiftController(IFavoriteUsersProvider favoriteUsersProvider, GiftModel model, GiftsEvents events)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Gifts_GdEvents_Control_GiftController___ctor
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  int *param1_00;
		  
		  if (DAT_ram_00a5a23b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Cysharp_Threading_Tasks_UniTaskCompletionSource_IList_UserData___TrySetCanceled__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Cysharp_Threading_Tasks_UniTaskCompletionSource_IList_UserData___TypeInfo);
		    DAT_ram_00a5a23b = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  param1_00 = *(int **)(param2 + 0xc);
		  if (param1_00 != (int *)0x0) {
		    if (((uint)*(byte *)(*param1_00 + 0xb8) <
		         (uint)*(byte *)(Cysharp_Threading_Tasks_UniTaskCompletionSource_IList_UserData___TypeInfo +
		                        0xb8)) ||
		       (*(int *)(*(int *)(*param1_00 + 100) +
		                 (uint)*(byte *)(
		                                Cysharp_Threading_Tasks_UniTaskCompletionSource_IList_UserData___TypeInfo
		                                + 0xb8) * 4 + -4) !=
		        Cysharp_Threading_Tasks_UniTaskCompletionSource_IList_UserData___TypeInfo)) {
		      System_Activator__CreateInstance
		                (param1_00,Cysharp_Threading_Tasks_UniTaskCompletionSource_IList_UserData___TypeInfo
		                );
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  func_ii_17479(param1_00,0,
		                Method_Cysharp_Threading_Tasks_UniTaskCompletionSource_IList_UserData___TrySetCanceled__
		               );
		  return;
		}
		*/

		}

		// Token: 0x06002B5E RID: 11102 RVA: 0x00008718 File Offset: 0x00006918
		[Token(Token = "0x6002B5E")]
		[Address(RVA = "0x217F", Offset = "0x217F", VA = "0x217F")]
		public UniTask<IList<UserData>> GetTargetUsers(int limit)
		{
			return default(UniTask<IList<UserData>>);
		}

		// Token: 0x06002B5F RID: 11103 RVA: 0x00008730 File Offset: 0x00006930
		[Token(Token = "0x6002B5F")]
		[Address(RVA = "0x217A", Offset = "0x217A", VA = "0x217A")]
		public UniTask<IList<UserData>> GetClanMembers()
		{
			return default(UniTask<IList<UserData>>);
		}

		// Token: 0x06002B60 RID: 11104 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B60")]
		[Address(RVA = "0x7BF8", Offset = "0x7BF8", VA = "0x7BF8")]
		private void HandleGetMembersListFaultService(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: HandleGetMembersListFaultService ---
		void Gameplay_Gifts_GdEvents_Control_GiftController__HandleGetMembersListFaultService
		               (int *param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int *param1_00;
		  int *param2_00;
		  int iVar2;
		  uint *puVar3;
		  int iVar4;
		  int *param1_01;
		  int *param1_02;
		  int *param1_03;
		  undefined4 uVar5;
		  int param2_01;
		  int *piVar6;
		  
		  param2_01 = 0;
		  if (DAT_ram_00a5a23c == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Gifts_GdEvents_Model_GiftModel_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Cache_User_IUserInfoWrapper_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Clans_ProtoGetMembersListAns_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Google_Protobuf_Collections_RepeatedField_ProtoGetMembersListAns_Types_MemberInfo__get_Count__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Google_Protobuf_Collections_RepeatedField_ProtoGetMembersListAns_Types_MemberInfo__get_Item__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Cysharp_Threading_Tasks_UniTaskCompletionSource_IList_UserData___TrySetResult__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Cysharp_Threading_Tasks_UniTaskCompletionSource_IList_UserData___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Data_UserData___TypeInfo);
		    DAT_ram_00a5a23c = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  param1_01 = *(int **)(param2 + 0xc);
		  if (param1_01 != (int *)0x0) {
		    if (((uint)*(byte *)(*param1_01 + 0xb8) <
		         (uint)*(byte *)(Cysharp_Threading_Tasks_UniTaskCompletionSource_IList_UserData___TypeInfo +
		                        0xb8)) ||
		       (*(int *)(*(int *)(*param1_01 + 100) +
		                 (uint)*(byte *)(
		                                Cysharp_Threading_Tasks_UniTaskCompletionSource_IList_UserData___TypeInfo
		                                + 0xb8) * 4 + -4) !=
		        Cysharp_Threading_Tasks_UniTaskCompletionSource_IList_UserData___TypeInfo)) {
		      System_Activator__CreateInstance
		                (param1_01,Cysharp_Threading_Tasks_UniTaskCompletionSource_IList_UserData___TypeInfo
		                );
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  param1_02 = *(int **)(param2 + 0x20);
		  if ((param1_02 != (int *)0x0) && (Protocol_Clans_ProtoGetMembersListAns_TypeInfo != *param1_02)) {
		    System_Activator__CreateInstance(param1_02,Protocol_Clans_ProtoGetMembersListAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param1_00 = (int *)(**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                               (param1,*(undefined4 *)(*param1 + 0x104));
		  if (param1_00 != (int *)0x0) {
		    if (((uint)*(byte *)(*param1_00 + 0xb8) <
		         (uint)*(byte *)(Gameplay_Gifts_GdEvents_Model_GiftModel_TypeInfo + 0xb8)) ||
		       (*(int *)(*(int *)(*param1_00 + 100) +
		                 (uint)*(byte *)(Gameplay_Gifts_GdEvents_Model_GiftModel_TypeInfo + 0xb8) * 4 + -4)
		        != Gameplay_Gifts_GdEvents_Model_GiftModel_TypeInfo)) {
		      System_Activator__CreateInstance(param1_00,Gameplay_Gifts_GdEvents_Model_GiftModel_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  param2_00 = (int *)Mono_Security_ASN1Convert__ToOid
		                               (Core_Data_UserData___TypeInfo,*(undefined4 *)(param1_02[3] + 0xc));
		  if (0 < param2_00[3]) {
		    do {
		      param1_03 = (int *)param1_00[9];
		      iVar2 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                        (param1_02[3],param2_01,
		                         Method_Google_Protobuf_Collections_RepeatedField_ProtoGetMembersListAns_Types_MemberInfo__get_Item__
		                        );
		      uVar5 = *(undefined4 *)(iVar2 + 0xc);
		      iVar2 = *param1_03;
		      if (*(ushort *)(iVar2 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          piVar6 = (int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8);
		          if (Core_Cache_User_IUserInfoWrapper_TypeInfo == *piVar6) {
		            puVar3 = (uint *)(iVar2 + piVar6[1] * 8 + 0xc0);
		            goto code_r0x811ec0de;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		      }
		      puVar3 = (uint *)func_ii_1080(param1_03,Core_Cache_User_IUserInfoWrapper_TypeInfo,0);
		code_r0x811ec0de:
		      iVar2 = (**(code **)((ulonglong)*puVar3 * 4))(param1_03,uVar5,puVar3[1]);
		      if ((iVar2 != 0) &&
		         (iVar4 = func_ii_1082(iVar2,*(undefined4 *)(*param2_00 + 0x20)), iVar4 == 0)) {
		        uVar5 = func_ii_1083();
		        func_ii_1050(uVar5,0);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      param2_00[param2_01 + 4] = iVar2;
		      param2_01 = param2_01 + 1;
		    } while (param2_01 < param2_00[3]);
		  }
		  func_ii_5553(param1_01,param2_00,
		               Method_Cysharp_Threading_Tasks_UniTaskCompletionSource_IList_UserData___TrySetResult__
		              );
		  return;
		}
		*/

		}

		// Token: 0x06002B61 RID: 11105 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002B61")]
		[Address(RVA = "0x7BF9", Offset = "0x7BF9", VA = "0x7BF9")]
		private void HandleGetMembersListService(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: HandleGetMembersListService ---
		uint Gameplay_Gifts_GdEvents_Control_GiftController__HandleGetMembersListService
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 in_register_20000014;
		  undefined4 uVar1;
		  int iVar2;
		  uint *puVar3;
		  undefined8 uVar4;
		  longlong lVar5;
		  longlong lVar6;
		  int *param1_00;
		  uint uVar7;
		  
		  if (DAT_ram_00a5a23d == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_ICollection_ulong__TypeInfo);
		    DAT_ram_00a5a23d = '\x01';
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x104)));
		  param1_00 = *(int **)(iVar2 + 0x14);
		  uVar4 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext(param2,0);
		  iVar2 = *param1_00;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    uVar7 = 0;
		    do {
		      if (System_Collections_Generic_ICollection_ulong__TypeInfo ==
		          *(int *)(*(int *)(iVar2 + 0x58) + uVar7 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar7 * 8 + 4) * 8 + iVar2 + 0xe0);
		        goto code_r0x811ec20d;
		      }
		      uVar7 = uVar7 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar7);
		  }
		  puVar3 = (uint *)func_ii_1080(param1_00,System_Collections_Generic_ICollection_ulong__TypeInfo,4);
		code_r0x811ec20d:
		  iVar2 = (**(code **)((ulonglong)*puVar3 * 4))(param1_00,uVar4,puVar3[1]);
		  if (iVar2 == 0) {
		    uVar1 = (undefined4)((ulonglong)uVar4 >> 0x20);
		    lVar5 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext(param2,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,CONCAT44(uVar1,*(undefined4 *)(*param1 + 0x104)));
		    lVar6 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext
		                      (*(undefined4 *)(iVar2 + 8),0);
		    uVar7 = (uint)(lVar5 != lVar6);
		  }
		  else {
		    uVar7 = 0;
		  }
		  return uVar7;
		}
		*/

		}

		// Token: 0x040017C3 RID: 6083
		[Token(Token = "0x40017C3")]
		[FieldOffset(Offset = "0x1C")]
		private IFavoriteUsersProvider _favoriteUsersProvider;
	}
}
