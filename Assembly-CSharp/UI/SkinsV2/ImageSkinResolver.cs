using System;
using System.Threading;
using Core.Gameplay.Managers.Skins;
using Cysharp.Threading.Tasks;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace UI.SkinsV2
{
	// Token: 0x02000185 RID: 389
	[Token(Token = "0x2000185")]
	[AddComponentMenu("SkinsV2/ImageSkin (Skin Resolver)")]
	[DisallowMultipleComponent]
	public class ImageSkinResolver : AbstractSkinResolver<Image, Sprite>
	{
		// Token: 0x06000AFA RID: 2810 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AFA")]
		[Address(RVA = "0x5E1C", Offset = "0x5E1C", VA = "0x5E1C", Slot = "4")]
		protected override void GetDefaultContent(Image component, out AbstractSkinResolver<Image, Sprite>.ContentInfo content)
		{
		/* --- GHIDRA: GetDefaultContent ---
		void UI_SkinsV2_ImageSkinResolver__GetDefaultContent
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  func_ii_8025(param2,0,0);
		  return;
		}
		*/

		}

		// Token: 0x06000AFB RID: 2811 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AFB")]
		[Address(RVA = "0x5E1D", Offset = "0x5E1D", VA = "0x5E1D", Slot = "5")]
		protected override void Rollback(Image component, Sprite content)
		{
		/* --- GHIDRA: Rollback ---
		void UI_SkinsV2_ImageSkinResolver__Rollback
		               (undefined8 *param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5,undefined4 param6)
		
		{
		  undefined1 auStack_40 [8];
		  undefined8 local_38;
		  undefined4 local_2c;
		  undefined8 local_28;
		  undefined4 local_20;
		  undefined4 local_1c;
		  undefined4 local_18;
		  undefined4 local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a599ea == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskMethodBuilder_bool__Create__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskMethodBuilder_bool__Start_ImageSkinResolver__TryResolve_d__2___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskMethodBuilder_bool__get_Task__
		              );
		    DAT_ram_00a599ea = '\x01';
		  }
		  local_8 = 0;
		  local_20 = 0;
		  local_10 = 0;
		  local_28 = 0;
		  local_2c = 0xffffffff;
		  local_1c = param4;
		  local_18 = param3;
		  local_14 = param5;
		  if (*(int *)(
		              Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskMethodBuilder_bool__Start_ImageSkinResolver__TryResolve_d__2___
		              + 0x1c) == 0) {
		    System_ReadOnlySpan_char___GetPinnableReference
		              (
		              Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskMethodBuilder_bool__Start_ImageSkinResolver__TryResolve_d__2___
		              );
		  }
		  UI_SkinsV2_ImageSkinResolver___ctor(&local_2c,auStack_40);
		  unnamed_function_62983
		            (&local_38,&local_28,
		             Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskMethodBuilder_bool__get_Task__
		            );
		  *param1 = local_38;
		  return;
		}
		*/

		}

		// Token: 0x06000AFC RID: 2812 RVA: 0x00003A68 File Offset: 0x00001C68
		[Token(Token = "0x6000AFC")]
		[Address(RVA = "0x5E1E", Offset = "0x5E1E", VA = "0x5E1E", Slot = "6")]
		protected override UniTask<bool> TryResolve(Image component, Skin skin, CancellationToken cancellationToken)
		{
		/* --- GHIDRA: TryResolve ---
		void UI_SkinsV2_ImageSkinResolver__TryResolve(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a599eb == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_SkinsV2_AbstractSkinResolver_Image__Sprite___ctor__);
		    DAT_ram_00a599eb = '\x01';
		  }
		  Gameplay_Combat_Model_SkillsChange_AbstractShortSpellInfo_object___Dispose
		            (param1,Method_UI_SkinsV2_AbstractSkinResolver_Image__Sprite___ctor__);
		  return;
		}
		*/

			return default(UniTask<bool>);
		}

		// Token: 0x06000AFD RID: 2813 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AFD")]
		[Address(RVA = "0x5E1F", Offset = "0x5E1F", VA = "0x5E1F")]
		public ImageSkinResolver()
		{
		/* --- GHIDRA: .ctor ---
		void UI_SkinsV2_ImageSkinResolver___ctor(int *param1,undefined4 param2)
		
		{
		  short sVar1;
		  uint uVar2;
		  undefined4 *puVar3;
		  uint *puVar4;
		  undefined4 uVar5;
		  undefined4 *param2_00;
		  int iVar6;
		  int iVar7;
		  uint uVar8;
		  int *piVar9;
		  undefined4 param2_01;
		  uint local_40;
		  undefined4 uStack_3c;
		  undefined4 local_38;
		  undefined4 uStack_34;
		  undefined8 local_30;
		  undefined8 local_28;
		  undefined8 local_20;
		  undefined4 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a599ec == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskMethodBuilder_bool__AwaitUnsafeOnCompleted_UniTask_Awaiter_ValueTuple_bool__Sprite____ImageSkinResolver__TryResolve_d__2___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskMethodBuilder_bool__SetResult__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Cysharp_Threading_Tasks_UniTask_Awaiter_ValueTuple_bool__Sprite___GetResult__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Cysharp_Threading_Tasks_UniTask_Awaiter_ValueTuple_bool__Sprite___get_IsCompleted__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Cysharp_Threading_Tasks_UniTask_ValueTuple_bool__Sprite___GetAwaiter__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Cysharp_Threading_Tasks_UniTask_Sprite__SuppressCancellationThrow__);
		    DAT_ram_00a599ec = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  local_18 = 0;
		  local_20 = 0;
		  if (*param1 == 0) {
		    piVar9 = param1 + 9;
		    local_8 = *(undefined8 *)piVar9;
		    local_10 = *(undefined8 *)(param1 + 7);
		    param1[7] = 0;
		    param1[8] = 0;
		    piVar9[0] = 0;
		    piVar9[1] = 0;
		    *param1 = -1;
		    piVar9 = (int *)local_10;
		code_r0x810a3e3f:
		    if (piVar9 == (int *)0x0) {
		code_r0x810a3e44:
		      uStack_3c = (undefined4)local_8;
		      local_40 = local_10._4_4_;
		code_r0x810a3fc3:
		      uVar8 = local_40 & 1;
		      if (uVar8 != 0) {
		code_r0x810a400b:
		        *param1 = -2;
		        piVar9 = (int *)param1[1];
		        if (piVar9 == (int *)0x0) {
		          *(bool *)(param1 + 3) = uVar8 == 0;
		          return;
		        }
		        iVar6 = *(int *)(
		                        Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskMethodBuilder_bool__SetResult__
		                        + 0x10);
		        if ((*(byte *)(iVar6 + 0xbd) & 1) == 0) {
		          iVar6 = func_ii_1079(iVar6);
		        }
		        iVar6 = *(int *)(*(int *)(iVar6 + 0x60) + 4);
		        if ((*(byte *)(iVar6 + 0xbd) & 1) == 0) {
		          iVar6 = func_ii_1079(iVar6);
		        }
		        iVar7 = *piVar9;
		        if (*(ushort *)(iVar7 + 0xb6) != 0) {
		          uVar2 = 0;
		          do {
		            if (iVar6 == *(int *)(*(int *)(iVar7 + 0x58) + uVar2 * 8)) {
		              puVar4 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar2 * 8 + 4) * 8 + iVar7 + 0xd0)
		              ;
		              goto code_r0x810a40c8;
		            }
		            uVar2 = uVar2 + 1;
		          } while (*(ushort *)(iVar7 + 0xb6) != uVar2);
		        }
		        puVar4 = (uint *)func_ii_1080(piVar9,iVar6,2);
		code_r0x810a40c8:
		        (**(code **)((ulonglong)*puVar4 * 4))(piVar9,uVar8 == 0,puVar4[1]);
		        return;
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_viii
		                (s_struct_Uniforms___color__array<v_ram_00001f04 + 0x56,param1[5],uStack_3c,0);
		      iVar6 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar6 != 1) goto code_r0x810a400b;
		      uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    }
		    else {
		      sVar1 = local_8._4_2_;
		      iVar6 = *(int *)(
		                      Method_Cysharp_Threading_Tasks_UniTask_Awaiter_ValueTuple_bool__Sprite___GetResult__
		                      + 0x10);
		      if ((*(byte *)(iVar6 + 0xbd) & 1) == 0) {
		        DAT_ram_009d3e38 = 0;
		        iVar6 = import::env::invoke_ii(s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x17,iVar6)
		        ;
		        if (DAT_ram_009d3e38 != 1) goto code_r0x810a3ea0;
		      }
		      else {
		code_r0x810a3ea0:
		        iVar6 = *(int *)(*(int *)(iVar6 + 0x60) + 0x14);
		        if ((*(byte *)(iVar6 + 0xbd) & 1) == 0) {
		          DAT_ram_009d3e38 = 0;
		          iVar6 = import::env::invoke_ii
		                            (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x17,iVar6);
		          if (DAT_ram_009d3e38 == 1) goto code_r0x810a40d8;
		        }
		        iVar7 = *piVar9;
		        if (*(ushort *)(iVar7 + 0xb6) != 0) {
		          uVar8 = 0;
		          do {
		            if (iVar6 == *(int *)(*(int *)(iVar7 + 0x58) + uVar8 * 8)) {
		              puVar3 = (undefined4 *)
		                       (iVar7 + *(int *)(*(int *)(iVar7 + 0x58) + uVar8 * 8 + 4) * 8 + 0xc0);
		              goto code_r0x810a3f71;
		            }
		            uVar8 = uVar8 + 1;
		          } while (*(ushort *)(iVar7 + 0xb6) != uVar8);
		        }
		        DAT_ram_009d3e38 = 0;
		        puVar3 = (undefined4 *)
		                 import::env::invoke_iiii
		                           (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar9,iVar6,0);
		        if (DAT_ram_009d3e38 != 1) {
		code_r0x810a3f71:
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_viiii(*puVar3,&local_40,piVar9,(int)sVar1,puVar3[1]);
		          iVar6 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar6 != 1) goto code_r0x810a3fc3;
		        }
		      }
		code_r0x810a40d8:
		      DAT_ram_009d3e38 = 0;
		      uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    }
		  }
		  else {
		    iVar7 = param1[4];
		    DAT_ram_009d3e38 = 0;
		    uVar5 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x215,
		                       *(undefined4 *)(param1[5] + 0x80),0);
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 == 1) {
		      uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    }
		    else {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_viiiii
		                (s_struct_Uniforms___color__array<v_ram_00001f04 + 0x54,&local_40,iVar7,uVar5,
		                 param1[6],0);
		      iVar6 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar6 == 1) {
		        uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      }
		      else {
		        local_18 = local_38;
		        local_20 = CONCAT44(uStack_3c,local_40);
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (s_struct_Uniforms___color__array<v_ram_00001f04 + 0x4f,&local_40,&local_20,
		                   Method_Cysharp_Threading_Tasks_UniTask_Sprite__SuppressCancellationThrow__);
		        iVar6 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar6 == 1) {
		          uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        }
		        else {
		          local_28 = CONCAT44(uStack_34,local_38);
		          local_30 = CONCAT44(uStack_3c,local_40);
		          if ((*(byte *)(*(int *)(
		                                 Method_Cysharp_Threading_Tasks_UniTask_ValueTuple_bool__Sprite___GetAwaiter__
		                                 + 0x10) + 0xbd) & 1) == 0) {
		            DAT_ram_009d3e38 = 0;
		            import::env::invoke_ii
		                      (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x17,
		                       *(int *)(
		                               Method_Cysharp_Threading_Tasks_UniTask_ValueTuple_bool__Sprite___GetAwaiter__
		                               + 0x10));
		            iVar6 = DAT_ram_009d3e38;
		            DAT_ram_009d3e38 = 0;
		            if (iVar6 == 1) {
		              uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		              goto code_r0x810a40e0;
		            }
		          }
		          local_8 = local_28;
		          local_10 = local_30;
		          if ((*(byte *)(*(int *)(
		                                 Method_Cysharp_Threading_Tasks_UniTask_Awaiter_ValueTuple_bool__Sprite___get_IsCompleted__
		                                 + 0x10) + 0xbd) & 1) == 0) {
		            DAT_ram_009d3e38 = 0;
		            import::env::invoke_ii
		                      (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x17,
		                       *(int *)(
		                               Method_Cysharp_Threading_Tasks_UniTask_Awaiter_ValueTuple_bool__Sprite___get_IsCompleted__
		                               + 0x10));
		            if (DAT_ram_009d3e38 != 1) goto code_r0x810a3c3d;
		          }
		          else {
		code_r0x810a3c3d:
		            if (DAT_ram_00a60081 == '\0') {
		              DAT_ram_009d3e38 = 0;
		              import::env::invoke_vi(0x7ff,&Cysharp_Threading_Tasks_IUniTaskSource_TypeInfo);
		              if (DAT_ram_009d3e38 == 1) goto code_r0x810a3dff;
		              DAT_ram_00a60081 = '\x01';
		            }
		            DAT_ram_009d3e38 = 0;
		            piVar9 = (int *)local_10;
		            if ((int *)local_10 == (int *)0x0) goto code_r0x810a3e44;
		            uVar8 = 0;
		            sVar1 = local_8._4_2_;
		            iVar6 = *(int *)local_10;
		            if (*(ushort *)(iVar6 + 0xb6) != 0) {
		              do {
		                if (Cysharp_Threading_Tasks_IUniTaskSource_TypeInfo ==
		                    *(int *)(*(int *)(iVar6 + 0x58) + uVar8 * 8)) {
		                  puVar3 = (undefined4 *)
		                           (iVar6 + *(int *)(*(int *)(iVar6 + 0x58) + uVar8 * 8 + 4) * 8 + 0xc0);
		                  goto code_r0x810a3d2b;
		                }
		                uVar8 = uVar8 + 1;
		              } while (*(ushort *)(iVar6 + 0xb6) != uVar8);
		            }
		            DAT_ram_009d3e38 = 0;
		            puVar3 = (undefined4 *)
		                     import::env::invoke_iiii
		                               (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,
		                                (int *)local_10,Cysharp_Threading_Tasks_IUniTaskSource_TypeInfo,0);
		            if (DAT_ram_009d3e38 != 1) {
		code_r0x810a3d2b:
		              DAT_ram_009d3e38 = 0;
		              iVar7 = import::env::invoke_iiii(*puVar3,piVar9,(int)sVar1,puVar3[1]);
		              iVar6 = DAT_ram_009d3e38;
		              DAT_ram_009d3e38 = 0;
		              if (iVar6 != 1) {
		                if (iVar7 != 0) goto code_r0x810a3e3f;
		                *param1 = 0;
		                *(undefined8 *)(param1 + 7) = local_10;
		                *(undefined8 *)(param1 + 9) = local_8;
		                DAT_ram_009d3e38 = 0;
		                import::env::invoke_viiii
		                          (s_struct_Uniforms___color__array<v_ram_00001f04 + 0x55,param1 + 1,
		                           &local_10,param1,
		                           Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskMethodBuilder_bool__AwaitUnsafeOnCompleted_UniTask_Awaiter_ValueTuple_bool__Sprite____ImageSkinResolver__TryResolve_d__2___
		                          );
		                iVar6 = DAT_ram_009d3e38;
		                DAT_ram_009d3e38 = 0;
		                if (iVar6 != 1) {
		                  DAT_ram_009d3e38 = 0;
		                  return;
		                }
		                uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                goto code_r0x810a40e0;
		              }
		            }
		          }
		code_r0x810a3dff:
		          DAT_ram_009d3e38 = 0;
		          uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        }
		      }
		    }
		  }
		code_r0x810a40e0:
		  iVar6 = global_1;
		  iVar7 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar6 == iVar7) {
		    puVar3 = (undefined4 *)import::env::__cxa_begin_catch(uVar5);
		    DAT_ram_009d3e38 = 0;
		    uVar5 = import::env::invoke_ii
		                      (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1c,
		                       &System_Exception_TypeInfo);
		    if (DAT_ram_009d3e38 != 1) {
		      DAT_ram_009d3e38 = 0;
		      iVar7 = import::env::invoke_iii
		                        (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1d,uVar5,
		                         *(undefined4 *)*puVar3);
		      iVar6 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar6 != 1) {
		        if (iVar7 != 0) {
		          param2_01 = *puVar3;
		          import::env::__cxa_end_catch();
		          *param1 = -2;
		          uVar5 = unnamed_function_2232
		                            (&
		                             Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskMethodBuilder_bool__SetException__
		                            );
		          Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskMethodBuilder_UniTask___Create
		                    (param1 + 1,param2_01,uVar5);
		          return;
		        }
		        param2_00 = (undefined4 *)unnamed_function_951(4);
		        *param2_00 = *puVar3;
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1e,param2_00,
		                   &DAT_ram_0072c9c8,0);
		        if (DAT_ram_009d3e38 != 1) goto code_r0x810a4215;
		      }
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar5 = import::env::__cxa_find_matching_catch_2();
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_v(0x123);
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 == 1) {
		      import::env::__cxa_find_matching_catch_3(0);
		      unnamed_function_937();
		code_r0x810a4215:
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  import::env::__resumeException(uVar5);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}
	}
}
