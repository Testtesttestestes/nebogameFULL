using System;
using System.Collections.Generic;
using Gameplay.Combat.View.Animations;
using Gameplay.Combat.View.GameField;
using Il2CppDummyDll;
using Protocol.Combat;
using UnityEngine;
using Utils.Cache;

namespace Gameplay.Combat.View.VFX
{
	// Token: 0x0200092C RID: 2348
	[Token(Token = "0x200092C")]
	public class StoneDestroyVFX : MonoBehaviour
	{
		// Token: 0x0600376D RID: 14189 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600376D")]
		[Address(RVA = "0x875B", Offset = "0x875B", VA = "0x875B")]
		private void UpdateElements()
		{
		/* --- GHIDRA: UpdateElements ---
		/* WARNING: Removing unreachable block (ram,0x80c6549a) */
		
		undefined4
		Gameplay_Combat_View_VFX_StoneDestroyVFX__UpdateElements
		          (int param1,int param2,undefined4 param3,undefined4 *param4,undefined4 param5)
		
		{
		  int iVar1;
		  int iVar2;
		  int iVar3;
		  undefined4 uVar4;
		  int *piVar5;
		  int iVar6;
		  undefined4 uVar7;
		  undefined4 *puVar8;
		  float fVar9;
		  float4 local_38;
		  float4 local_40;
		  undefined1 auStack_70 [8];
		  undefined8 local_68;
		  float local_60;
		  undefined8 local_58;
		  float4 local_50;
		  float4 local_4c;
		  float4 local_48;
		  float4 local_44;
		  undefined8 local_30;
		  float4 local_28;
		  undefined8 local_20;
		  float4 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a566ba == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Aggregate_Vector3__Vector3___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Any_StoneMono___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Select_StoneMono__Vector3___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToList_Vector3___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Where_StoneMono___);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_StoneDestroyElement__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_StoneDestroyElement__MoveNext__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_StoneDestroyElement__get_Current__
		              );
		    Mono_Security_ASN1__get_Item(&System_Func_StoneMono__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Func_StoneMono__Vector3__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Func_Vector3__Vector3__Vector3__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_StoneDestroyElement__GetEnumerator__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Vector3__get_Count__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_StoneMono__get_Count__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_Cache_ObjectPool_StoneDestroyElement__Get__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Combat_View_VFX_StoneDestroyVFX___c__TryGetVFX_b__4_1__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Combat_View_VFX_StoneDestroyVFX___c__TryGetVFX_b__4_2__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_View_VFX_StoneDestroyVFX___c__DisplayClass4_0__TryGetVFX_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Combat_View_VFX_StoneDestroyVFX___c__DisplayClass4_0_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_View_VFX_StoneDestroyVFX___c__DisplayClass4_1__TryGetVFX_b__3__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Combat_View_VFX_StoneDestroyVFX___c__DisplayClass4_1_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_View_VFX_StoneDestroyVFX___c_TypeInfo);
		    DAT_ram_00a566ba = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  local_28 = 0.0;
		  local_30 = 0;
		  iVar1 = unnamed_function_1417
		                    (Gameplay_Combat_View_VFX_StoneDestroyVFX___c__DisplayClass4_0_TypeInfo);
		  *(undefined4 *)(iVar1 + 8) = 0;
		  *param4 = 0;
		  if (param2 == 0) {
		    return 0;
		  }
		  if (*(int *)(param2 + 0xc) == 0) {
		    return 0;
		  }
		  System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		            (&local_40,*(undefined4 *)(param1 + 0x14),
		             Method_System_Collections_Generic_List_StoneDestroyElement__GetEnumerator__);
		  local_8 = (ulonglong)(uint)local_38 << 0x20;
		  local_10 = _local_40;
		  _local_40 = ZEXT48(&local_10) << 0x20;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar2 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_10,
		                       Method_System_Collections_Generic_List_Enumerator_StoneDestroyElement__MoveNext__
		                      );
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 == 1) {
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80c65682;
		    }
		    if (iVar2 == 0) goto code_r0x80c656d8;
		    DAT_ram_009d3e38 = 0;
		    iVar6 = import::env::invoke_ii
		                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                       Gameplay_Combat_View_VFX_StoneDestroyVFX___c__DisplayClass4_1_TypeInfo);
		    if (DAT_ram_009d3e38 == 1) {
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80c65682;
		    }
		    *(undefined4 *)(iVar6 + 8) = local_8._4_4_;
		    DAT_ram_009d3e38 = 0;
		    uVar4 = import::env::invoke_ii
		                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                       System_Func_StoneMono__bool__TypeInfo);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80c65648:
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80c65682;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viiii
		              (s_struct_Uniforms___color__array<v_ram_00000aff + 0x21b,uVar4,iVar6,
		               Method_Gameplay_Combat_View_VFX_StoneDestroyVFX___c__DisplayClass4_1__TryGetVFX_b__3__
		               ,0);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80c65648;
		    DAT_ram_009d3e38 = 0;
		    iVar3 = import::env::invoke_iiii
		                      (s_struct_Uniforms___color__array<v_ram_000017c8 + 0xf6,param2,uVar4,
		                       Method_System_Linq_Enumerable_Any_StoneMono___);
		    iVar2 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar2 == 1) {
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80c65682;
		    }
		  } while (iVar3 == 0);
		  DAT_ram_009d3e38 = 0;
		  uVar4 = import::env::invoke_iiii
		                    (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x1ff,param1,
		                     *(undefined4 *)(iVar6 + 8),auStack_70);
		  iVar6 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar6 == 1) {
		    uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		  }
		  else {
		    DAT_ram_009d3e38 = 0;
		    uVar7 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x200,uVar4,
		                       Method_Utils_Cache_ObjectPool_StoneDestroyElement__Get__);
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 == 1) {
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    }
		    else {
		      *(undefined4 *)(iVar1 + 8) = uVar7;
		      DAT_ram_009d3e38 = 0;
		      uVar7 = import::env::invoke_iii
		                        (s_struct_Uniforms___color__array<v_ram_00000aff + 0x25c,uVar7,0);
		      if (DAT_ram_009d3e38 != 1) {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii(s_struct_Uniforms___color__array<v_ram_000013c7 + 0x26d,uVar7,1,0);
		        iVar6 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar6 != 1) {
		          *(undefined4 *)(*(int *)(iVar1 + 8) + 0xa8) = uVar4;
		          goto code_r0x80c656d8;
		        }
		      }
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		    }
		  }
		code_r0x80c65682:
		  iVar6 = global_1;
		  iVar2 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar6 == iVar2) {
		    piVar5 = (int *)import::env::__cxa_begin_catch(uVar4);
		    iVar2 = *piVar5;
		    DAT_ram_009d3e38 = 0;
		    _local_40 = CONCAT44(local_40,iVar2);
		    import::env::invoke_v(0x123);
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 != 1) {
		      if (iVar2 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(iVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		code_r0x80c656d8:
		      uVar7 = *(undefined4 *)(iVar1 + 8);
		      uVar4 = 0;
		      if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		        func_ii_306000(UnityEngine_Object_TypeInfo);
		      }
		      iVar6 = func_ii_3812(uVar7,0,0);
		      if (iVar6 == 0) {
		        uVar4 = unnamed_function_1417(System_Func_StoneMono__bool__TypeInfo);
		        System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		                  (uVar4,iVar1,
		                   Method_Gameplay_Combat_View_VFX_StoneDestroyVFX___c__DisplayClass4_0__TryGetVFX_b__0__
		                   ,0);
		        uVar4 = System_Linq_Enumerable__Where_PlayerLoopSystem_
		                          (param2,uVar4,Method_System_Linq_Enumerable_Where_StoneMono___);
		        if (*(int *)(Gameplay_Combat_View_VFX_StoneDestroyVFX___c_TypeInfo + 0x74) == 0) {
		          func_ii_306000(Gameplay_Combat_View_VFX_StoneDestroyVFX___c_TypeInfo);
		        }
		        puVar8 = *(undefined4 **)(Gameplay_Combat_View_VFX_StoneDestroyVFX___c_TypeInfo + 0x5c);
		        iVar6 = puVar8[1];
		        if (iVar6 == 0) {
		          if (*(int *)(Gameplay_Combat_View_VFX_StoneDestroyVFX___c_TypeInfo + 0x74) == 0) {
		            func_ii_306000(Gameplay_Combat_View_VFX_StoneDestroyVFX___c_TypeInfo);
		            puVar8 = *(undefined4 **)(Gameplay_Combat_View_VFX_StoneDestroyVFX___c_TypeInfo + 0x5c);
		          }
		          uVar7 = *puVar8;
		          iVar6 = unnamed_function_1417(System_Func_StoneMono__Vector3__TypeInfo);
		          System_Func_object__Vector2___Invoke
		                    (iVar6,uVar7,
		                     Method_Gameplay_Combat_View_VFX_StoneDestroyVFX___c__TryGetVFX_b__4_1__,0);
		          *(int *)(*(int *)(Gameplay_Combat_View_VFX_StoneDestroyVFX___c_TypeInfo + 0x5c) + 4) =
		               iVar6;
		        }
		        uVar4 = System_Linq_Enumerable__Select_object__Vector2_
		                          (uVar4,iVar6,Method_System_Linq_Enumerable_Select_StoneMono__Vector3___);
		        iVar6 = System_Linq_Enumerable__ToList_ulong_
		                          (uVar4,Method_System_Linq_Enumerable_ToList_Vector3___);
		        if (DAT_ram_00a65020 == '\0') {
		          Mono_Security_ASN1__get_Item(&UnityEngine_Vector3_TypeInfo);
		          DAT_ram_00a65020 = '\x01';
		        }
		        local_38 = *(float4 *)(*(undefined8 **)(UnityEngine_Vector3_TypeInfo + 0x5c) + 1);
		        _local_40 = **(undefined8 **)(UnityEngine_Vector3_TypeInfo + 0x5c);
		        if (*(int *)(Gameplay_Combat_View_VFX_StoneDestroyVFX___c_TypeInfo + 0x74) == 0) {
		          func_ii_306000(Gameplay_Combat_View_VFX_StoneDestroyVFX___c_TypeInfo);
		        }
		        puVar8 = *(undefined4 **)(Gameplay_Combat_View_VFX_StoneDestroyVFX___c_TypeInfo + 0x5c);
		        iVar2 = puVar8[2];
		        if (iVar2 == 0) {
		          local_28 = local_38;
		          local_30 = _local_40;
		          if (*(int *)(Gameplay_Combat_View_VFX_StoneDestroyVFX___c_TypeInfo + 0x74) == 0) {
		            func_ii_306000(Gameplay_Combat_View_VFX_StoneDestroyVFX___c_TypeInfo);
		            puVar8 = *(undefined4 **)(Gameplay_Combat_View_VFX_StoneDestroyVFX___c_TypeInfo + 0x5c);
		          }
		          uVar4 = *puVar8;
		          iVar2 = unnamed_function_1417(System_Func_Vector3__Vector3__Vector3__TypeInfo);
		          System_Func_Translate__Translate__bool___Invoke
		                    (iVar2,uVar4,
		                     Method_Gameplay_Combat_View_VFX_StoneDestroyVFX___c__TryGetVFX_b__4_2__,0);
		          *(int *)(*(int *)(Gameplay_Combat_View_VFX_StoneDestroyVFX___c_TypeInfo + 0x5c) + 8) =
		               iVar2;
		          local_18 = local_28;
		          local_20 = local_30;
		        }
		        else {
		          local_18 = local_38;
		          local_20 = _local_40;
		        }
		        local_50 = local_18;
		        local_58 = local_20;
		        System_Linq_Enumerable__Aggregate___Il2CppFullySharedGenericType_
		                  (&local_40,iVar6,&local_58,iVar2,
		                   Method_System_Linq_Enumerable_Aggregate_Vector3__Vector3___);
		        fVar9 = (float)*(int *)(iVar6 + 0xc);
		        local_60 = (float)local_38 / fVar9;
		        local_48 = (float4)((float)local_40 / fVar9);
		        local_4c = (float4)((float)local_40 / fVar9);
		        local_68 = CONCAT44(local_48,local_4c);
		        local_44 = (float4)local_60;
		        UnityEngine_Camera__ScreenToWorldPoint(&local_40,*(undefined4 *)(param1 + 0x10),&local_68,0)
		        ;
		        iVar6 = *(int *)(iVar1 + 8);
		        *(longlong *)(iVar6 + 0x94) = _local_40;
		        *(undefined8 *)(iVar6 + 0xa0) = 0;
		        *(undefined1 *)(iVar6 + 0x8c) = (undefined1)param3;
		        *(float4 *)(iVar6 + 0x9c) = local_38;
		        *(undefined4 *)(iVar6 + 0x88) = *(undefined4 *)(iVar6 + 0x60);
		        *(float *)(iVar6 + 0x84) =
		             *(float *)(iVar6 + 100) + *(float *)(iVar6 + 0x68) + *(float *)(iVar6 + 0x70);
		        *param4 = *(undefined4 *)(iVar1 + 8);
		        uVar4 = 1;
		      }
		      return uVar4;
		    }
		    uVar4 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_000017c8 + 0x201,&local_40);
		  iVar1 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar1 != 1) {
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
		*/

		}

		// Token: 0x0600376E RID: 14190 RVA: 0x0000B1D8 File Offset: 0x000093D8
		[Token(Token = "0x600376E")]
		[Address(RVA = "0x875C", Offset = "0x875C", VA = "0x875C")]
		public bool TryGetVFX(List<StoneMono> stones, bool isMyTurn, out CombatAnimation.IContent content)
		{
		/* --- GHIDRA: TryGetVFX ---
		void Gameplay_Combat_View_VFX_StoneDestroyVFX__TryGetVFX
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  undefined4 *puVar2;
		  int iVar3;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a566bb == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_FirstOrDefault_StoneDestroyElement___);
		    Mono_Security_ASN1__get_Item(&System_Func_StoneDestroyElement__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Combat_View_VFX_StoneDestroyVFX___c__SetThemeSkin_b__5_0__);
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_View_VFX_StoneDestroyVFX___c_TypeInfo);
		    DAT_ram_00a566bb = '\x01';
		  }
		  uVar1 = *(undefined4 *)(param1 + 0x14);
		  if (*(int *)(Gameplay_Combat_View_VFX_StoneDestroyVFX___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_Combat_View_VFX_StoneDestroyVFX___c_TypeInfo);
		  }
		  puVar2 = *(undefined4 **)(Gameplay_Combat_View_VFX_StoneDestroyVFX___c_TypeInfo + 0x5c);
		  iVar3 = puVar2[3];
		  if (iVar3 == 0) {
		    if (*(int *)(Gameplay_Combat_View_VFX_StoneDestroyVFX___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_Combat_View_VFX_StoneDestroyVFX___c_TypeInfo);
		      puVar2 = *(undefined4 **)(Gameplay_Combat_View_VFX_StoneDestroyVFX___c_TypeInfo + 0x5c);
		    }
		    param2_00 = *puVar2;
		    iVar3 = unnamed_function_1417(System_Func_StoneDestroyElement__bool__TypeInfo);
		    System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		              (iVar3,param2_00,
		               Method_Gameplay_Combat_View_VFX_StoneDestroyVFX___c__SetThemeSkin_b__5_0__,0);
		    *(int *)(*(int *)(Gameplay_Combat_View_VFX_StoneDestroyVFX___c_TypeInfo + 0x5c) + 0xc) = iVar3;
		  }
		  uVar1 = System_Func_object__bool____ctor
		                    (uVar1,iVar3,Method_System_Linq_Enumerable_FirstOrDefault_StoneDestroyElement___
		                    );
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar3 = func_ii_3812(uVar1,0,0);
		  if (iVar3 == 0) {
		    Gameplay_Combat_View_VFX_StoneDestroyElement__Dispose(uVar1,param2,param3,uVar1);
		  }
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x0600376F RID: 14191 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600376F")]
		[Address(RVA = "0x875D", Offset = "0x875D", VA = "0x875D")]
		public void SetThemeSkin(Sprite skin, Sprite glow)
		{
		}

		// Token: 0x06003770 RID: 14192 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003770")]
		[Address(RVA = "0x19C7", Offset = "0x19C7", VA = "0x19C7")]
		private GameObjectPool<StoneDestroyElement> GetPool(StoneDestroyElement element)
		{
		/* --- GHIDRA: GetPool ---
		undefined4 Gameplay_Combat_View_VFX_StoneDestroyVFX__GetPool(int *param1,int param2)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  int iVar3;
		  
		  iVar2 = param1[2];
		  if (iVar2 == 0) {
		    iVar3 = *(int *)(*(int *)(*(int *)(param2 + 0x10) + 0x60) + 0x24);
		    iVar2 = *(int *)(*(int *)(*(int *)(iVar3 + 0x10) + 0x60) + 0x14);
		    if ((*(byte *)(iVar2 + 0xbd) & 1) == 0) {
		      iVar2 = func_ii_1079(iVar2);
		    }
		    iVar2 = unnamed_function_1417(iVar2);
		    Sirenix_Serialization_StackFormatter_object____Il2CppFullySharedGenericType___SerializeImplementation
		              (iVar2,*(undefined4 *)(*(int *)(*(int *)(iVar3 + 0x10) + 0x60) + 0x18));
		    param1[2] = iVar2;
		  }
		  if (0 < *(int *)(iVar2 + 0x14)) {
		    uVar1 = func_ii_7387(iVar2,*(undefined4 *)(*(int *)(*(int *)(param2 + 0x10) + 0x60) + 0x34));
		    return uVar1;
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x06003771 RID: 14193 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003771")]
		[Address(RVA = "0x875E", Offset = "0x875E", VA = "0x875E")]
		private void ResetPoolObjectDelegate(StoneDestroyElement pooledObject)
		{
		/* --- GHIDRA: ResetPoolObjectDelegate ---
		void Gameplay_Combat_View_VFX_StoneDestroyVFX__ResetPoolObjectDelegate(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a566bd == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_StonesTypes__GameObjectPool_StoneDestroyElement____ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_Dictionary_StonesTypes__GameObjectPool_StoneDestroyElement___TypeInfo
		              );
		    DAT_ram_00a566bd = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (
		                        System_Collections_Generic_Dictionary_StonesTypes__GameObjectPool_StoneDestroyElement___TypeInfo
		                        );
		  System_Collections_Generic_Dictionary_Int32Enum__Int32Enum___set_Item
		            (param1_00,
		             Method_System_Collections_Generic_Dictionary_StonesTypes__GameObjectPool_StoneDestroyElement____ctor__
		            );
		  *(undefined4 *)(param1 + 0x18) = param1_00;
		  UnityEngine_RectTransform__GetParentSize(param1,0);
		  return;
		}
		*/

		}

		// Token: 0x06003772 RID: 14194 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003772")]
		[Address(RVA = "0x875F", Offset = "0x875F", VA = "0x875F")]
		public StoneDestroyVFX()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Combat_View_VFX_StoneDestroyVFX___ctor(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a566be == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_View_VFX_StoneDestroyVFX___c_TypeInfo);
		    DAT_ram_00a566be = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Gameplay_Combat_View_VFX_StoneDestroyVFX___c_TypeInfo);
		  **(undefined4 **)(Gameplay_Combat_View_VFX_StoneDestroyVFX___c_TypeInfo + 0x5c) = uVar1;
		  return;
		}
		*/

		}

		// Token: 0x04001E94 RID: 7828
		[Token(Token = "0x4001E94")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Camera _camera;

		// Token: 0x04001E95 RID: 7829
		[Token(Token = "0x4001E95")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private List<StoneDestroyElement> _elements;

		// Token: 0x04001E96 RID: 7830
		[Token(Token = "0x4001E96")]
		[FieldOffset(Offset = "0x18")]
		private readonly Dictionary<StonesTypes, GameObjectPool<StoneDestroyElement>> _pools;
	}
}
