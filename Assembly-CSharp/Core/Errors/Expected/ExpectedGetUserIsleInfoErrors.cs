using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Protocol.World;

namespace Core.Errors.Expected
{
	// Token: 0x0200105E RID: 4190
	[Token(Token = "0x200105E")]
	public class ExpectedGetUserIsleInfoErrors : ExpectedDefaultError
	{
		// Token: 0x0600624D RID: 25165 RVA: 0x000125D0 File Offset: 0x000107D0
		[Token(Token = "0x600624D")]
		[Address(RVA = "0xAE73", Offset = "0xAE73", VA = "0xAE73", Slot = "4")]
		public override bool Handle(int errorCode)
		{
		/* --- GHIDRA: Handle ---
		/* WARNING: Removing unreachable block (ram,0x8120edac) */
		/* WARNING: Removing unreachable block (ram,0x8120efbe) */
		/* WARNING: Removing unreachable block (ram,0x8120e8ae) */
		
		void Core_Errors_Expected_ExpectedGetUserIsleInfoErrors__Handle(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  int iVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 uVar5;
		  int iVar6;
		  uint *puVar7;
		  int *piVar8;
		  undefined4 *puVar9;
		  undefined8 uVar10;
		  uint uVar11;
		  int local_c;
		  int **local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a5a37f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_DialogWindow_DialogWindowArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_DialogWindow_DialogWindowArgs___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_DialogWindow_DialogWindowArgs__set_Callback__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_DialogWindow_DialogWindowArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&UI_Windows_DialogWindow_DialogWindowArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Core_Errors_Expected_ExpectedGetUserIsleInfoErrors_ExpectedGetUserIsleInfoErrorArgs_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___Add__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs____ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Google_Protobuf_Collections_RepeatedField_ProtoGetUserIsleInfoAns_Types_IsleInformation__get_Count__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Google_Protobuf_Collections_RepeatedField_ProtoGetUserIsleInfoAns_Types_IsleInformation__get_Item__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Errors_Expected_ExpectedGetUserIsleInfoErrors___c__ShowUsersOverLimitWindow_b__2_1__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Errors_Expected_ExpectedGetUserIsleInfoErrors___c__DisplayClass2_0__ShowUsersOverLimitWindow_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Core_Errors_Expected_ExpectedGetUserIsleInfoErrors___c__DisplayClass2_0_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Errors_Expected_ExpectedGetUserIsleInfoErrors___c_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_8362);
		    Mono_Security_ASN1__get_Item(&StringLiteral_8365);
		    Mono_Security_ASN1__get_Item(&StringLiteral_8363);
		    Mono_Security_ASN1__get_Item(&StringLiteral_8364);
		    DAT_ram_00a5a37f = '\x01';
		  }
		  local_4 = (int *)0x0;
		  piVar8 = *(int **)(param1 + 8);
		  if (piVar8 != (int *)0x0) {
		    if (((uint)*(byte *)(*piVar8 + 0xb8) <
		         (uint)*(byte *)(
		                        Core_Errors_Expected_ExpectedGetUserIsleInfoErrors_ExpectedGetUserIsleInfoErrorArgs_TypeInfo
		                        + 0xb8)) ||
		       (*(int *)(*(int *)(*piVar8 + 100) +
		                 (uint)*(byte *)(
		                                Core_Errors_Expected_ExpectedGetUserIsleInfoErrors_ExpectedGetUserIsleInfoErrorArgs_TypeInfo
		                                + 0xb8) * 4 + -4) !=
		        Core_Errors_Expected_ExpectedGetUserIsleInfoErrors_ExpectedGetUserIsleInfoErrorArgs_TypeInfo
		       )) {
		      System_Activator__CreateInstance
		                (piVar8,
		                 Core_Errors_Expected_ExpectedGetUserIsleInfoErrors_ExpectedGetUserIsleInfoErrorArgs_TypeInfo
		                );
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  DAT_ram_009d3e38 = 0;
		  local_c = 0;
		  local_8 = &local_4;
		  local_4 = piVar8;
		  iVar1 = import::env::invoke_ii
		                    (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                     Core_Errors_Expected_ExpectedGetUserIsleInfoErrors___c__DisplayClass2_0_TypeInfo
		                    );
		  if (DAT_ram_009d3e38 == 1) {
		    DAT_ram_009d3e38 = 0;
		    uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		  }
		  else if (*(int *)(*(int *)(local_4[2] + 0xc) + 0xc) < 2) {
		    if (DAT_ram_00a6456f == '\0') {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi(0x7ff,&Core_Gameplay_Game_TypeInfo);
		      iVar6 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar6 == 1) {
		        uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x8120f25e;
		      }
		      DAT_ram_00a6456f = '\x01';
		    }
		    uVar11 = 0;
		    piVar8 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar6 = *piVar8;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar11 * 8)) {
		          puVar9 = (undefined4 *)
		                   (*(int *)(*(int *)(iVar6 + 0x58) + uVar11 * 8 + 4) * 8 + iVar6 + 0x140);
		          goto code_r0x8120e9e1;
		        }
		        uVar11 = uVar11 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar11);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar9 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar8,
		                        Core_Gameplay_IGame_TypeInfo,0x10);
		    if (DAT_ram_009d3e38 != 1) {
		code_r0x8120e9e1:
		      DAT_ram_009d3e38 = 0;
		      uVar5 = import::env::invoke_iii(*puVar9,piVar8,puVar9[1]);
		      if (DAT_ram_009d3e38 != 1) {
		        DAT_ram_009d3e38 = 0;
		        uVar5 = func_ii_7112(uVar5,0);
		        iVar6 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar6 == 1) {
		          uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        }
		        else {
		          DAT_ram_009d3e38 = 0;
		          uVar10 = unnamed_function_184054
		                             (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x356,uVar5,0);
		          iVar6 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar6 != 1) goto code_r0x8120eaf6;
		          uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        }
		        goto code_r0x8120f25e;
		      }
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		  }
		  else {
		    DAT_ram_009d3e38 = 0;
		    iVar2 = import::env::invoke_iiii
		                      (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x2e0,
		                       *(int *)(local_4[2] + 0xc),1,
		                       Method_Google_Protobuf_Collections_RepeatedField_ProtoGetUserIsleInfoAns_Types_IsleInformation__get_Item__
		                      );
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 == 1) {
		      uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    }
		    else {
		      uVar10 = *(undefined8 *)(*(int *)(iVar2 + 0x30) + 0x10);
		code_r0x8120eaf6:
		      *(undefined8 *)(iVar1 + 8) = uVar10;
		      DAT_ram_009d3e38 = 0;
		      iVar6 = import::env::invoke_ii
		                        (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                         UI_Windows_DialogWindow_DialogWindowArgs_TypeInfo);
		      if (DAT_ram_009d3e38 != 1) {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vii(s_struct_Uniforms___color__array<v_ram_00001f04 + 0x2ae,iVar6,0);
		        if (DAT_ram_009d3e38 != 1) {
		          if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		            DAT_ram_009d3e38 = 0;
		            import::env::invoke_vi
		                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                       Core_GameLocalization_TypeInfo);
		            iVar2 = DAT_ram_009d3e38;
		            DAT_ram_009d3e38 = 0;
		            if (iVar2 == 1) {
		              uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		              goto code_r0x8120f25e;
		            }
		          }
		          DAT_ram_009d3e38 = 0;
		          uVar5 = import::env::invoke_iiiiiiiii
		                            (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x392,
		                             StringLiteral_8365,1,0,1,0,0,0,0);
		          iVar2 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar2 == 1) {
		            uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          }
		          else {
		            *(undefined4 *)(iVar6 + 0x18) = uVar5;
		            DAT_ram_009d3e38 = 0;
		            uVar5 = import::env::invoke_iiiiiiiii
		                              (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x392,
		                               StringLiteral_8362,1,0,1,0,0,0,0);
		            iVar2 = DAT_ram_009d3e38;
		            DAT_ram_009d3e38 = 0;
		            if (iVar2 == 1) {
		              uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            }
		            else {
		              *(undefined1 *)(iVar6 + 0x28) = 0;
		              *(undefined4 *)(iVar6 + 0x1c) = uVar5;
		              DAT_ram_009d3e38 = 0;
		              iVar2 = import::env::invoke_ii
		                                (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                                 System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___TypeInfo
		                                );
		              if (DAT_ram_009d3e38 != 1) {
		                DAT_ram_009d3e38 = 0;
		                import::env::invoke_vii
		                          (s_struct_Uniforms___color__array<v_ram_00000aff + 0x252,iVar2,
		                           Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs____ctor__
		                          );
		                if (DAT_ram_009d3e38 != 1) {
		                  DAT_ram_009d3e38 = 0;
		                  iVar3 = import::env::invoke_ii
		                                    (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                                     UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs__TypeInfo
		                                    );
		                  if (DAT_ram_009d3e38 != 1) {
		                    DAT_ram_009d3e38 = 0;
		                    UI_Windows_DialogWindow_DialogWindowArgs___ctor
		                              (iVar3,
		                               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___ctor__
		                              );
		                    if (DAT_ram_009d3e38 != 1) {
		                      DAT_ram_009d3e38 = 0;
		                      uVar5 = import::env::invoke_iiiiiiiii
		                                        (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x392,
		                                         StringLiteral_8364,1,0,1,0,0,0,0);
		                      iVar4 = DAT_ram_009d3e38;
		                      DAT_ram_009d3e38 = 0;
		                      if (iVar4 == 1) {
		                        uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                      }
		                      else {
		                        *(undefined4 *)(iVar3 + 8) = uVar5;
		                        DAT_ram_009d3e38 = 0;
		                        iVar4 = import::env::invoke_ii
		                                          (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                                           UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_DialogWindow_DialogWindowArgs__TypeInfo
		                                          );
		                        if (DAT_ram_009d3e38 == 1) {
		                          DAT_ram_009d3e38 = 0;
		                          uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                        }
		                        else {
		                          DAT_ram_009d3e38 = 0;
		                          uVar5 = import::env::invoke_ii
		                                            (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199
		                                             ,
		                                             UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_DialogWindow_DialogWindowArgs__TypeInfo
		                                            );
		                          if (DAT_ram_009d3e38 != 1) {
		                            DAT_ram_009d3e38 = 0;
		                            import::env::invoke_viiii
		                                      (s_struct_Uniforms___color__array<v_ram_00001f04 + 0x2b1,uVar5
		                                       ,iVar1,
		                                       Method_Core_Errors_Expected_ExpectedGetUserIsleInfoErrors___c__DisplayClass2_0__ShowUsersOverLimitWindow_b__0__
		                                       ,0);
		                            if (DAT_ram_009d3e38 != 1) {
		                              *(undefined4 *)(iVar4 + 8) = uVar5;
		                              *(int *)(iVar3 + 0x14) = iVar4;
		                              iVar1 = 
		                              Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___Add__
		                              ;
		                              *(int *)(iVar2 + 0x10) = *(int *)(iVar2 + 0x10) + 1;
		                              uVar11 = *(uint *)(iVar2 + 0xc);
		                              if (uVar11 < *(uint *)(*(int *)(iVar2 + 8) + 0xc)) {
		                                *(uint *)(iVar2 + 0xc) = uVar11 + 1;
		                                *(int *)(*(int *)(iVar2 + 8) + uVar11 * 4 + 0x10) = iVar3;
		                              }
		                              else {
		                                DAT_ram_009d3e38 = 0;
		                                import::env::invoke_viii
		                                          (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,
		                                           iVar2,iVar3,
		                                           *(undefined4 *)
		                                            (*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		                                if (DAT_ram_009d3e38 == 1) goto code_r0x8120f188;
		                              }
		                              DAT_ram_009d3e38 = 0;
		                              iVar1 = import::env::invoke_ii
		                                                (s_var<private>_posTex__array<vec4<_ram_00000655 +
		                                                 0x199,
		                                                 UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs__TypeInfo
		                                                );
		                              if (DAT_ram_009d3e38 != 1) {
		                                DAT_ram_009d3e38 = 0;
		                                UI_Windows_DialogWindow_DialogWindowArgs___ctor
		                                          (iVar1,
		                                           Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___ctor__
		                                          );
		                                if (DAT_ram_009d3e38 != 1) {
		                                  DAT_ram_009d3e38 = 0;
		                                  uVar5 = import::env::invoke_iiiiiiiii
		                                                    (s_struct_Uniforms___color__array<v_ram_000017c8
		                                                     + 0x392,StringLiteral_8363,1,0,1,0,0,0,0);
		                                  iVar3 = DAT_ram_009d3e38;
		                                  DAT_ram_009d3e38 = 0;
		                                  if (iVar3 == 1) {
		                                    uVar5 = import::env::__cxa_find_matching_catch_3
		                                                      (&DAT_ram_0072c9c8);
		                                  }
		                                  else {
		                                    *(undefined4 *)(iVar1 + 8) = uVar5;
		                                    DAT_ram_009d3e38 = 0;
		                                    iVar3 = import::env::invoke_ii
		                                                      (
		                                                  s_var<private>_posTex__array<vec4<_ram_00000655 +
		                                                  0x199,
		                                                  UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_DialogWindow_DialogWindowArgs__TypeInfo
		                                                  );
		                                    if (DAT_ram_009d3e38 == 1) {
		                                      DAT_ram_009d3e38 = 0;
		                                      uVar5 = import::env::__cxa_find_matching_catch_3
		                                                        (&DAT_ram_0072c9c8);
		                                    }
		                                    else {
		                                      if (*(int *)(
		                                                  Core_Errors_Expected_ExpectedGetUserIsleInfoErrors___c_TypeInfo
		                                                  + 0x74) == 0) {
		                                        DAT_ram_009d3e38 = 0;
		                                        import::env::invoke_vi
		                                                  (s_var<private>_posTex__array<vec4<_ram_00000655 +
		                                                   0x180,
		                                                  Core_Errors_Expected_ExpectedGetUserIsleInfoErrors___c_TypeInfo
		                                                  );
		                                        iVar4 = DAT_ram_009d3e38;
		                                        DAT_ram_009d3e38 = 0;
		                                        if (iVar4 == 1) {
		                                          uVar5 = import::env::__cxa_find_matching_catch_3
		                                                            (&DAT_ram_0072c9c8);
		                                          goto code_r0x8120f25e;
		                                        }
		                                      }
		                                      puVar9 = *(undefined4 **)
		                                                (
		                                                Core_Errors_Expected_ExpectedGetUserIsleInfoErrors___c_TypeInfo
		                                                + 0x5c);
		                                      iVar4 = puVar9[1];
		                                      if (iVar4 == 0) {
		                                        if (*(int *)(
		                                                  Core_Errors_Expected_ExpectedGetUserIsleInfoErrors___c_TypeInfo
		                                                  + 0x74) == 0) {
		                                          DAT_ram_009d3e38 = 0;
		                                          import::env::invoke_vi
		                                                    (s_var<private>_posTex__array<vec4<_ram_00000655
		                                                     + 0x180,
		                                                  Core_Errors_Expected_ExpectedGetUserIsleInfoErrors___c_TypeInfo
		                                                  );
		                                          if (DAT_ram_009d3e38 != 1) {
		                                            puVar9 = *(undefined4 **)
		                                                      (
		                                                  Core_Errors_Expected_ExpectedGetUserIsleInfoErrors___c_TypeInfo
		                                                  + 0x5c);
		                                            goto code_r0x8120f058;
		                                          }
		code_r0x8120f239:
		                                          DAT_ram_009d3e38 = 0;
		                                          uVar5 = import::env::__cxa_find_matching_catch_3
		                                                            (&DAT_ram_0072c9c8);
		                                        }
		                                        else {
		code_r0x8120f058:
		                                          uVar5 = *puVar9;
		                                          DAT_ram_009d3e38 = 0;
		                                          iVar4 = import::env::invoke_ii
		                                                            (
		                                                  s_var<private>_posTex__array<vec4<_ram_00000655 +
		                                                  0x199,
		                                                  UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_DialogWindow_DialogWindowArgs__TypeInfo
		                                                  );
		                                          if (DAT_ram_009d3e38 != 1) {
		                                            DAT_ram_009d3e38 = 0;
		                                            import::env::invoke_viiii
		                                                      (
		                                                  s_struct_Uniforms___color__array<v_ram_00001f04 +
		                                                  0x2b1,iVar4,uVar5,
		                                                  Method_Core_Errors_Expected_ExpectedGetUserIsleInfoErrors___c__ShowUsersOverLimitWindow_b__2_1__
		                                                  ,0);
		                                            if (DAT_ram_009d3e38 != 1) {
		                                              *(int *)(*(int *)(
		                                                  Core_Errors_Expected_ExpectedGetUserIsleInfoErrors___c_TypeInfo
		                                                  + 0x5c) + 4) = iVar4;
		                                              goto code_r0x8120f0db;
		                                            }
		                                          }
		                                          DAT_ram_009d3e38 = 0;
		                                          uVar5 = import::env::__cxa_find_matching_catch_3
		                                                            (&DAT_ram_0072c9c8);
		                                        }
		                                      }
		                                      else {
		code_r0x8120f0db:
		                                        *(int *)(iVar3 + 8) = iVar4;
		                                        *(int *)(iVar1 + 0x14) = iVar3;
		                                        iVar3 = 
		                                        Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_DialogWindow_DialogWindowArgs___Add__
		                                        ;
		                                        *(int *)(iVar2 + 0x10) = *(int *)(iVar2 + 0x10) + 1;
		                                        uVar11 = *(uint *)(iVar2 + 0xc);
		                                        if (uVar11 < *(uint *)(*(int *)(iVar2 + 8) + 0xc)) {
		                                          *(uint *)(iVar2 + 0xc) = uVar11 + 1;
		                                          *(int *)(*(int *)(iVar2 + 8) + uVar11 * 4 + 0x10) = iVar1;
		                                        }
		                                        else {
		                                          DAT_ram_009d3e38 = 0;
		                                          import::env::invoke_viii
		                                                    (s_struct_Uniforms___color__array<v_ram_00000aff
		                                                     + 0x6e,iVar2,iVar1,
		                                                     *(undefined4 *)
		                                                      (*(int *)(*(int *)(iVar3 + 0x10) + 0x60) +
		                                                      0x38));
		                                          if (DAT_ram_009d3e38 == 1) goto code_r0x8120f239;
		                                        }
		                                        *(int *)(iVar6 + 0x24) = iVar2;
		                                        DAT_ram_009d3e38 = 0;
		                                        import::env::invoke_iii
		                                                  (s_struct_Uniforms___color__array<v_ram_00001f04 +
		                                                   0x2b2,iVar6,0);
		                                        iVar1 = DAT_ram_009d3e38;
		                                        DAT_ram_009d3e38 = 0;
		                                        if (iVar1 != 1) goto code_r0x8120f2a7;
		                                        uVar5 = import::env::__cxa_find_matching_catch_3
		                                                          (&DAT_ram_0072c9c8);
		                                      }
		                                    }
		                                  }
		                                  goto code_r0x8120f25e;
		                                }
		                              }
		                              DAT_ram_009d3e38 = 0;
		                              uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                              goto code_r0x8120f25e;
		                            }
		                          }
		code_r0x8120f188:
		                          DAT_ram_009d3e38 = 0;
		                          uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                        }
		                      }
		                      goto code_r0x8120f25e;
		                    }
		                  }
		                  DAT_ram_009d3e38 = 0;
		                  uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                  goto code_r0x8120f25e;
		                }
		              }
		              DAT_ram_009d3e38 = 0;
		              uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            }
		          }
		          goto code_r0x8120f25e;
		        }
		      }
		      DAT_ram_009d3e38 = 0;
		      uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    }
		  }
		code_r0x8120f25e:
		  iVar1 = global_1;
		  iVar6 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar1 == iVar6) {
		    piVar8 = (int *)import::env::__cxa_begin_catch(uVar5);
		    local_c = *piVar8;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_v(0x123);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 != 1) {
		code_r0x8120f2a7:
		      DAT_ram_009d3e38 = 0;
		      piVar8 = *local_8;
		      if (piVar8 != (int *)0x0) {
		        uVar11 = 0;
		        iVar1 = *piVar8;
		        if (*(ushort *)(iVar1 + 0xb6) != 0) {
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar1 + 0x58) + uVar11 * 8)) {
		              puVar7 = (uint *)(iVar1 + *(int *)(*(int *)(iVar1 + 0x58) + uVar11 * 8 + 4) * 8 + 0xc0
		                               );
		              goto code_r0x8120f322;
		            }
		            uVar11 = uVar11 + 1;
		          } while (*(ushort *)(iVar1 + 0xb6) != uVar11);
		        }
		        puVar7 = (uint *)func_ii_1080(piVar8,System_IDisposable_TypeInfo,0);
		code_r0x8120f322:
		        (**(code **)((ulonglong)*puVar7 * 4))(piVar8,puVar7[1]);
		      }
		      if (local_c == 0) {
		        return;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(local_c);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar5 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001f04 + 0x2b3,&local_c);
		  iVar1 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar1 == 1) {
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  import::env::__resumeException(uVar5);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

			return default(bool);
		}

		// Token: 0x0600624E RID: 25166 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600624E")]
		[Address(RVA = "0xAE74", Offset = "0xAE74", VA = "0xAE74")]
		private void ShowUsersOverLimitWindow()
		{
		}

		// Token: 0x0600624F RID: 25167 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600624F")]
		[Address(RVA = "0xAE75", Offset = "0xAE75", VA = "0xAE75")]
		public ExpectedGetUserIsleInfoErrors()
		{
		}

		// Token: 0x0200105F RID: 4191
		[Token(Token = "0x200105F")]
		public class ExpectedGetUserIsleInfoErrorArgs : IDisposable
		{
			// Token: 0x170013A8 RID: 5032
			// (get) Token: 0x06006250 RID: 25168 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x06006251 RID: 25169 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170013A8")]
			public ProtoGetUserIsleInfoAns Msg
			{
				[Token(Token = "0x6006250")]
				[Address(RVA = "0xAE76", Offset = "0xAE76", VA = "0xAE76")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6006251")]
				[Address(RVA = "0xAE77", Offset = "0xAE77", VA = "0xAE77")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x06006252 RID: 25170 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006252")]
			[Address(RVA = "0xAE78", Offset = "0xAE78", VA = "0xAE78")]
			public ExpectedGetUserIsleInfoErrorArgs(ProtoGetUserIsleInfoAns msg)
			{
			}

			// Token: 0x06006253 RID: 25171 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006253")]
			[Address(RVA = "0xAE79", Offset = "0xAE79", VA = "0xAE79", Slot = "4")]
			public void Dispose()
			{
			}
		}
	}
}
