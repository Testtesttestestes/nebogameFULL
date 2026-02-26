using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.InputSystem.LowLevel;

namespace Test
{
	// Token: 0x02000E48 RID: 3656
	[Token(Token = "0x2000E48")]
	[DisallowMultipleComponent]
	[RequireComponent(typeof(Camera))]
	public class TestCameraController : MonoBehaviour
	{
		// Token: 0x0600599C RID: 22940 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600599C")]
		[Address(RVA = "0xA6C8", Offset = "0xA6C8", VA = "0xA6C8")]
		private void Awake()
		{
		}

		// Token: 0x0600599D RID: 22941 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600599D")]
		[Address(RVA = "0xA6C9", Offset = "0xA6C9", VA = "0xA6C9")]
		public void Init(RectTransform contentContainer)
		{
		/* --- GHIDRA: Init ---
		void Test_TestCameraController__Init(undefined4 param1,undefined4 param2)
		
		{
		  UnityEngine_InputSystem_EnhancedTouch_TouchSimulation__get_instance(0);
		  return;
		}
		*/

		}

		// Token: 0x0600599E RID: 22942 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600599E")]
		[Address(RVA = "0xA6CA", Offset = "0xA6CA", VA = "0xA6CA")]
		private void OnEnable()
		{
		/* --- GHIDRA: OnEnable ---
		void Test_TestCameraController__OnEnable(undefined4 param1,undefined4 param2)
		
		{
		  UnityEngine_InputSystem_EnhancedTouch_TouchSimulation__Enable(0);
		  return;
		}
		*/

		}

		// Token: 0x0600599F RID: 22943 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600599F")]
		[Address(RVA = "0xA6CB", Offset = "0xA6CB", VA = "0xA6CB")]
		private void OnDisable()
		{
		/* --- GHIDRA: OnDisable ---
		void Test_TestCameraController__OnDisable(int param1,undefined4 param2)
		
		{
		  float4 fVar1;
		  float fVar2;
		  float4 fVar3;
		  float4 fVar4;
		  undefined4 uVar5;
		  int iVar6;
		  int iVar7;
		  undefined4 *puVar8;
		  int *piVar9;
		  uint *puVar10;
		  float fVar11;
		  float fVar12;
		  float fVar13;
		  float4 *pfVar14;
		  float fVar15;
		  float fVar16;
		  float fVar17;
		  int *piVar18;
		  uint uVar19;
		  float fVar20;
		  float fVar21;
		  float fVar22;
		  float4 local_8;
		  float4 local_10;
		  float4 local_60;
		  longlong local_f8;
		  float4 local_f0;
		  undefined8 local_e8;
		  float4 local_e0;
		  undefined8 local_d8;
		  float4 local_d0;
		  undefined8 local_c8;
		  float local_c0;
		  undefined8 local_b8;
		  float local_b0;
		  longlong local_a8;
		  float4 local_a0;
		  int local_9c;
		  int **local_98;
		  int *local_94;
		  undefined8 local_90;
		  float4 local_88;
		  undefined8 local_84;
		  float4 local_7c;
		  float4 local_78;
		  float4 local_74;
		  float4 local_70;
		  float4 local_6c;
		  float4 local_68;
		  float4 local_64;
		  float4 local_58;
		  undefined4 uStack_54;
		  undefined8 local_50;
		  undefined8 local_48;
		  byte local_40;
		  int local_28;
		  int *local_24;
		  longlong local_20;
		  float4 local_18;
		  undefined4 uStack_14;
		  
		  if (DAT_ram_00a63c30 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_Transform__Vector3__Clear__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_Transform__Vector3__GetEnumerator__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_Transform__Vector3__set_Item__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_Enumerator_Transform__Vector3__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_Enumerator_Transform__Vector3__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_Enumerator_Transform__Vector3__get_Current__
		              );
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_UnityEngine_InputSystem_InputControl_TouchState__ReadValue__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_KeyValuePair_Transform__Vector3__get_Key__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_KeyValuePair_Transform__Vector3__get_Value__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Transform_TypeInfo);
		    DAT_ram_00a63c30 = '\x01';
		  }
		  _local_8 = 0;
		  _local_10 = 0;
		  local_18 = 0.0;
		  uStack_14 = 0;
		  local_20 = 0;
		  local_24 = (int *)0x0;
		  local_28 = 0;
		  if (DAT_ram_00a63c4c == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_InputSystem_Touchscreen_TypeInfo);
		    DAT_ram_00a63c4c = '\x01';
		  }
		  if (**(int **)(UnityEngine_InputSystem_Touchscreen_TypeInfo + 0x5c) == 0) {
		    return;
		  }
		  UnityEngine_InputSystem_InputControl_TouchState___ReadUnprocessedValue
		            (&local_60,
		             *(undefined4 *)(**(int **)(UnityEngine_InputSystem_Touchscreen_TypeInfo + 0x5c) + 0xfc)
		             ,Method_UnityEngine_InputSystem_InputControl_TouchState__ReadValue__);
		  fVar3 = local_58;
		  if (1 < local_40 - 1) {
		    if (*(char *)(param1 + 0x10) == '\0') {
		      return;
		    }
		    *(undefined1 *)(param1 + 0x10) = 0;
		    System_Xml_XmlWellFormedWriter__PushNamespaceImplicit
		              (*(undefined4 *)(param1 + 0x48),
		               Method_System_Collections_Generic_Dictionary_Transform__Vector3__Clear__);
		    return;
		  }
		  fVar2 = (float)local_60;
		  if (*(char *)(param1 + 0x10) == '\0') {
		code_r0x82371248:
		    pfVar14 = (float4 *)(param1 + 0x1c);
		    local_d0 = *pfVar14;
		    local_84 = 0;
		    local_d8 = 0;
		    local_7c = local_d0;
		    UnityEngine_Camera__WorldToViewportPoint(&local_60,*(undefined4 *)(param1 + 0x4c),&local_d8,0);
		    fVar4 = local_58;
		    fVar1 = local_60;
		    fVar16 = (float)local_60;
		    local_e0 = *pfVar14;
		    local_90 = 0x3f8000003f800000;
		    local_e8 = 0x3f8000003f800000;
		    local_88 = local_e0;
		    UnityEngine_Camera__WorldToViewportPoint(&local_60,*(undefined4 *)(param1 + 0x4c),&local_e8,0);
		    fVar20 = (0.0 - (float)fVar4) * 0.5;
		    fVar20 = ((float)fVar4 + fVar20) - fVar20;
		    fVar15 = ((float)local_58 - fVar20) * 0.5;
		    *(float *)(param1 + 0x40) = fVar15;
		    fVar21 = (0.0 - fVar16) * 0.5;
		    fVar21 = (fVar16 + fVar21) - fVar21;
		    fVar16 = ((float)local_60 - fVar21) * 0.5;
		    *(float *)(param1 + 0x3c) = fVar16;
		    fVar22 = (0.0 - (float)fVar1) * 0.5;
		    fVar22 = ((float)fVar1 + fVar22) - fVar22;
		    fVar17 = ((float)local_60 - fVar22) * 0.5;
		    *(float *)(param1 + 0x38) = fVar17;
		    *(float *)(param1 + 0x34) = fVar20 + fVar15;
		    *(float *)(param1 + 0x30) = fVar21 + fVar16;
		    *(float *)(param1 + 0x2c) = fVar22 + fVar17;
		    uVar5 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                      (param1,0);
		    func_ii_7888(&local_60,uVar5,0);
		    *pfVar14 = local_58;
		    *(longlong *)(param1 + 0x14) = _local_60;
		    iVar6 = UnityEngine_RefreshRate__ToString(0);
		    iVar7 = UnityEngine_Screen__get_width(0);
		    *(float *)(param1 + 0x28) = (*(float *)(param1 + 0x34) - *(float *)(param1 + 0x40)) + 0.0;
		    fVar16 = *(float *)(param1 + 0x3c);
		    *(float *)(param1 + 0x24) =
		         (*(float *)(param1 + 0x30) - fVar16) + ((float)fVar3 / (float)iVar7) * (fVar16 + fVar16);
		    fVar16 = *(float *)(param1 + 0x38);
		    *(float *)(param1 + 0x20) =
		         (*(float *)(param1 + 0x2c) - fVar16) + (fVar2 / (float)iVar6) * (fVar16 + fVar16);
		    local_24 = (int *)UnityEngine_Transform__set_hasChanged(*(undefined4 *)(param1 + 0x44),0);
		    local_94 = &local_28;
		    local_9c = 0;
		    local_98 = &local_24;
		    do {
		      piVar9 = local_24;
		      iVar6 = *local_24;
		      if (*(ushort *)(iVar6 + 0xb6) != 0) {
		        uVar19 = 0;
		        do {
		          piVar18 = (int *)(*(int *)(iVar6 + 0x58) + uVar19 * 8);
		          if (System_Collections_IEnumerator_TypeInfo == *piVar18) {
		            puVar8 = (undefined4 *)(iVar6 + piVar18[1] * 8 + 0xc0);
		            goto code_r0x8237155f;
		          }
		          uVar19 = uVar19 + 1;
		        } while (*(ushort *)(iVar6 + 0xb6) != uVar19);
		      }
		      DAT_ram_009d3e38 = 0;
		      puVar8 = (undefined4 *)
		               import::env::invoke_iiii
		                         (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_24,
		                          System_Collections_IEnumerator_TypeInfo,0);
		      if (DAT_ram_009d3e38 == 1) {
		code_r0x823717bc:
		        DAT_ram_009d3e38 = 0;
		        uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x823717c4;
		      }
		code_r0x8237155f:
		      DAT_ram_009d3e38 = 0;
		      iVar6 = import::env::invoke_iii(*puVar8,piVar9,puVar8[1]);
		      piVar9 = local_24;
		      if (DAT_ram_009d3e38 == 1) goto code_r0x823717bc;
		      if (iVar6 == 0) {
		        iVar6 = 10;
		        goto code_r0x82371811;
		      }
		      iVar6 = *local_24;
		      if (*(ushort *)(iVar6 + 0xb6) != 0) {
		        uVar19 = 0;
		        do {
		          piVar18 = (int *)(*(int *)(iVar6 + 0x58) + uVar19 * 8);
		          if (System_Collections_IEnumerator_TypeInfo == *piVar18) {
		            puVar8 = (undefined4 *)(piVar18[1] * 8 + iVar6 + 200);
		            goto code_r0x8237163a;
		          }
		          uVar19 = uVar19 + 1;
		        } while (*(ushort *)(iVar6 + 0xb6) != uVar19);
		      }
		      DAT_ram_009d3e38 = 0;
		      puVar8 = (undefined4 *)
		               import::env::invoke_iiii
		                         (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_24,
		                          System_Collections_IEnumerator_TypeInfo,1);
		      if (DAT_ram_009d3e38 == 1) {
		code_r0x82371794:
		        DAT_ram_009d3e38 = 0;
		        uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x823717c4;
		      }
		code_r0x8237163a:
		      DAT_ram_009d3e38 = 0;
		      piVar9 = (int *)import::env::invoke_iii(*puVar8,piVar9,puVar8[1]);
		      if (DAT_ram_009d3e38 == 1) goto code_r0x82371794;
		      if (piVar9 != (int *)0x0) {
		        if (((uint)*(byte *)(*piVar9 + 0xb8) <
		             (uint)*(byte *)(UnityEngine_Transform_TypeInfo + 0xb8)) ||
		           (*(int *)(*(int *)(*piVar9 + 100) +
		                     (uint)*(byte *)(UnityEngine_Transform_TypeInfo + 0xb8) * 4 + -4) !=
		            UnityEngine_Transform_TypeInfo)) {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_vii
		                    (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x183,piVar9,
		                     UnityEngine_Transform_TypeInfo);
		          iVar6 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar6 != 1) {
		            do {
		              halt_trap();
		            } while( true );
		          }
		          uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x823717c4;
		        }
		      }
		      uVar5 = *(undefined4 *)(param1 + 0x48);
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_viii
		                (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x34a,&local_a8,piVar9,0);
		      iVar6 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar6 == 1) {
		        uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x823717c4;
		      }
		      local_58 = local_a0;
		      local_f0 = local_a0;
		      _local_60 = local_a8;
		      DAT_ram_009d3e38 = 0;
		      local_f8 = local_a8;
		      import::env::invoke_viiii
		                (s___Scripting__UnityEngine__Render_ram_00004866 + 0x36,uVar5,piVar9,&local_f8,
		                 Method_System_Collections_Generic_Dictionary_Transform__Vector3__set_Item__);
		      iVar6 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		    } while (iVar6 != 1);
		    uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x823717c4:
		    iVar6 = global_1;
		    iVar7 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		    if (iVar6 == iVar7) {
		      piVar9 = (int *)import::env::__cxa_begin_catch(uVar5);
		      local_9c = *piVar9;
		      iVar6 = 0;
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_v(0x123);
		      iVar7 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar7 != 1) {
		code_r0x82371811:
		        DAT_ram_009d3e38 = 0;
		        local_28 = func_ii_1082(local_24,System_IDisposable_TypeInfo);
		        piVar9 = (int *)*local_94;
		        if (piVar9 != (int *)0x0) {
		          iVar7 = *piVar9;
		          if (*(ushort *)(iVar7 + 0xb6) != 0) {
		            uVar19 = 0;
		            do {
		              if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar19 * 8)) {
		                puVar10 = (uint *)(iVar7 + *(int *)(*(int *)(iVar7 + 0x58) + uVar19 * 8 + 4) * 8 +
		                                  0xc0);
		                goto code_r0x823718a3;
		              }
		              uVar19 = uVar19 + 1;
		            } while (*(ushort *)(iVar7 + 0xb6) != uVar19);
		          }
		          puVar10 = (uint *)func_ii_1080(piVar9,System_IDisposable_TypeInfo,0);
		code_r0x823718a3:
		          (**(code **)((ulonglong)*puVar10 * 4))(piVar9,puVar10[1]);
		        }
		        if (local_9c == 0) {
		          if ((iVar6 == 0) ||
		             ((((((iVar6 != 1 && (iVar6 != 2)) && (iVar6 != 3)) && ((iVar6 != 4 && (iVar6 != 5))))
		               && ((iVar6 != 6 && ((iVar6 != 7 && (iVar6 != 8)))))) &&
		              ((iVar6 != 9 && (iVar6 == 10)))))) {
		            *(undefined1 *)(param1 + 0x10) = 1;
		          }
		          return;
		        }
		        System_Data_DataSet__ValidateLocaleConstraint(local_9c);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      uVar5 = import::env::__cxa_find_matching_catch_2();
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_ii(s___Scripting__UnityEngine__Render_ram_00004866 + 0x37,&local_9c);
		  }
		  else {
		    iVar6 = UnityEngine_RefreshRate__ToString(0);
		    iVar7 = UnityEngine_Screen__get_width(0);
		    fVar16 = *(float *)(param1 + 0x40);
		    fVar15 = *(float *)(param1 + 0x34);
		    fVar17 = *(float *)(param1 + 0x28);
		    fVar20 = *(float *)(param1 + 0x38);
		    fVar21 = *(float *)(param1 + 0x24);
		    fVar22 = *(float *)(param1 + 0x3c);
		    fVar11 = *(float *)(param1 + 0x30);
		    fVar12 = *(float *)(param1 + 0x20);
		    fVar13 = *(float *)(param1 + 0x2c);
		    uVar5 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                      (*(undefined4 *)(param1 + 0x4c),0);
		    fVar17 = fVar17 - ((fVar15 - fVar16) + 0.0);
		    local_b0 = fVar17 + *(float *)(param1 + 0x1c);
		    fVar21 = fVar21 - ((fVar11 - fVar22) + ((float)fVar3 / (float)iVar7) * (fVar22 + fVar22));
		    local_68 = (float4)(*(float *)(param1 + 0x18) + fVar21);
		    fVar12 = fVar12 - ((fVar13 - fVar20) + (fVar2 / (float)iVar6) * (fVar20 + fVar20));
		    local_6c = (float4)(*(float *)(param1 + 0x14) + fVar12);
		    local_b8 = CONCAT44(local_68,local_6c);
		    local_64 = (float4)local_b0;
		    UnityEngine_Transform__get_position(uVar5,&local_b8,0);
		    System_Collections_Generic_Dictionary_Regex_CachedCodeEntryKey__object___FindEntry
		              (&local_60,*(undefined4 *)(param1 + 0x48),
		               Method_System_Collections_Generic_Dictionary_Transform__Vector3__GetEnumerator__);
		    _local_8 = local_48;
		    _local_10 = local_50;
		    local_18 = local_58;
		    uStack_14 = uStack_54;
		    local_20 = _local_60;
		    _local_60 = ZEXT48(&local_20) << 0x20;
		    do {
		      DAT_ram_009d3e38 = 0;
		      iVar7 = import::env::invoke_iii
		                        (s___Scripting__UnityEngine__Render_ram_00004866 + 0x34,&local_20,
		                         Method_System_Collections_Generic_Dictionary_Enumerator_Transform__Vector3__MoveNext__
		                        );
		      iVar6 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar6 == 1) {
		        uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x823711f1;
		      }
		      if (iVar7 == 0) {
		        DAT_ram_009d3e38 = 0;
		        return;
		      }
		      local_c0 = (float)local_8 - fVar17;
		      local_74 = (float4)((float)local_10 - fVar21);
		      local_78 = (float4)((float)local_10 - fVar12);
		      DAT_ram_009d3e38 = 0;
		      local_c8 = CONCAT44(local_74,local_78);
		      local_70 = (float4)local_c0;
		      import::env::invoke_viii
		                (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x34b,uStack_14,&local_c8,0);
		      iVar6 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		    } while (iVar6 != 1);
		    uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x823711f1:
		    iVar6 = global_1;
		    iVar7 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		    if (iVar6 == iVar7) {
		      piVar9 = (int *)import::env::__cxa_begin_catch(uVar5);
		      iVar7 = *piVar9;
		      DAT_ram_009d3e38 = 0;
		      _local_60 = CONCAT44(local_60,iVar7);
		      import::env::invoke_v(0x123);
		      iVar6 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar6 != 1) {
		        if (iVar7 != 0) {
		          System_Data_DataSet__ValidateLocaleConstraint(iVar7);
		          do {
		            halt_trap();
		          } while( true );
		        }
		        goto code_r0x82371248;
		      }
		      uVar5 = import::env::__cxa_find_matching_catch_2();
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_ii(s___Scripting__UnityEngine__Render_ram_00004866 + 0x35,&local_60);
		  }
		  if (DAT_ram_009d3e38 == 1) {
		    DAT_ram_009d3e38 = 0;
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::__resumeException(uVar5);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x060059A0 RID: 22944 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60059A0")]
		[Address(RVA = "0xA6CC", Offset = "0xA6CC", VA = "0xA6CC")]
		private void Update()
		{
		/* --- GHIDRA: Update ---
		void Test_TestCameraController__Update(float *param1,int param2,int param3,undefined4 param4)
		
		{
		  int iVar1;
		  int iVar2;
		  float fVar3;
		  float fVar4;
		  float fVar5;
		  float fVar6;
		  float fVar7;
		  float fVar8;
		  
		  fVar3 = *(float *)(param3 + 4);
		  iVar1 = UnityEngine_RefreshRate__ToString(0);
		  fVar4 = *(float *)(param3 + 8);
		  iVar2 = UnityEngine_Screen__get_width(0);
		  fVar5 = *(float *)(param2 + 0x38);
		  fVar6 = *(float *)(param2 + 0x3c);
		  fVar7 = *(float *)(param2 + 0x30);
		  fVar8 = *(float *)(param2 + 0x2c);
		  param1[2] = (*(float *)(param2 + 0x34) - *(float *)(param2 + 0x40)) + 0.0;
		  param1[1] = (fVar7 - fVar6) + (fVar4 / (float)iVar2) * (fVar6 + fVar6);
		  *param1 = (fVar8 - fVar5) + (fVar3 / (float)iVar1) * (fVar5 + fVar5);
		  return;
		}
		*/

		}

		// Token: 0x060059A1 RID: 22945 RVA: 0x0000FE58 File Offset: 0x0000E058
		[Token(Token = "0x60059A1")]
		[Address(RVA = "0xA6CD", Offset = "0xA6CD", VA = "0xA6CD")]
		private Vector3 TouchToWorld(TouchState touch)
		{
		/* --- GHIDRA: TouchToWorld ---
		void Test_TestCameraController__TouchToWorld(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a63c31 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_Transform__Vector3___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_Dictionary_Transform__Vector3__TypeInfo);
		    DAT_ram_00a63c31 = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (System_Collections_Generic_Dictionary_Transform__Vector3__TypeInfo);
		  System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		            (param1_00,Method_System_Collections_Generic_Dictionary_Transform__Vector3___ctor__);
		  *(undefined4 *)(param1 + 0x48) = param1_00;
		  UnityEngine_RectTransform__GetParentSize(param1,0);
		  return;
		}
		*/

			return default(Vector3);
		}

		// Token: 0x060059A2 RID: 22946 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60059A2")]
		[Address(RVA = "0xA6CE", Offset = "0xA6CE", VA = "0xA6CE")]
		public TestCameraController()
		{
		/* --- GHIDRA: .ctor ---
		void Test_TestCameraController___ctor(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a63c33 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_string__TypeInfo);
		    DAT_ram_00a63c33 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 8);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_string__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_string__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 8,iVar2,param1_00);
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

		// Token: 0x0400305A RID: 12378
		[Token(Token = "0x400305A")]
		[FieldOffset(Offset = "0x10")]
		private bool _isDrag;

		// Token: 0x0400305B RID: 12379
		[Token(Token = "0x400305B")]
		[FieldOffset(Offset = "0x14")]
		private Vector3 _startCameraPosition;

		// Token: 0x0400305C RID: 12380
		[Token(Token = "0x400305C")]
		[FieldOffset(Offset = "0x20")]
		private Vector3 _startMousePosition;

		// Token: 0x0400305D RID: 12381
		[Token(Token = "0x400305D")]
		[FieldOffset(Offset = "0x2C")]
		private Bounds _viewBounds;

		// Token: 0x0400305E RID: 12382
		[Token(Token = "0x400305E")]
		[FieldOffset(Offset = "0x44")]
		private RectTransform _contentContainer;

		// Token: 0x0400305F RID: 12383
		[Token(Token = "0x400305F")]
		[FieldOffset(Offset = "0x48")]
		private readonly Dictionary<Transform, Vector3> _content;

		// Token: 0x04003060 RID: 12384
		[Token(Token = "0x4003060")]
		[FieldOffset(Offset = "0x4C")]
		private Camera _camera;
	}
}
