using System;
using System.Collections.Generic;
using AssetContent;
using CloudsFly;
using Il2CppDummyDll;
using Protocol.Dic;
using UnityEngine;

namespace Gameplay.Isles.User.View
{
	// Token: 0x02000D1A RID: 3354
	[Token(Token = "0x2000D1A")]
	public class IsleDecorationsView : BaseWorldObjectRenderer
	{
		// Token: 0x060051EA RID: 20970 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60051EA")]
		[Address(RVA = "0x1E15", Offset = "0x1E15", VA = "0x1E15")]
		public void AddDecoration(IsleDecorationsDic decorationsDic)
		{
		}

		// Token: 0x060051EB RID: 20971 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60051EB")]
		[Address(RVA = "0x1E00", Offset = "0x1E00", VA = "0x1E00")]
		public void RemoveDecoration(uint decorationId)
		{
		}

		// Token: 0x060051EC RID: 20972 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60051EC")]
		[Address(RVA = "0x9FC3", Offset = "0x9FC3", VA = "0x9FC3")]
		public void Clear()
		{
		/* --- GHIDRA: Clear ---
		void Gameplay_Isles_User_View_IsleDecorationsView__Clear(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  undefined4 param3;
		  int *piVar4;
		  int local_18;
		  undefined8 *local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a58d59 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__GameAssetViewSpriteRenderer__get_Values__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__GameAssetViewSpriteRenderer__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__GameAssetViewSpriteRenderer__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__GameAssetViewSpriteRenderer__get_Current__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_uint__GameAssetViewSpriteRenderer__GetEnumerator__
		              );
		    DAT_ram_00a58d59 = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  uVar2 = System_Collections_Generic_Dictionary_int__object___TryAdd
		                    (*(undefined4 *)(param1 + 0x2c),
		                     Method_System_Collections_Generic_Dictionary_uint__GameAssetViewSpriteRenderer__get_Values__
		                    );
		  System_Collections_Generic_Dictionary_Int32Enum__object___get_Values
		            (&local_10,uVar2,
		             Method_System_Collections_Generic_Dictionary_ValueCollection_uint__GameAssetViewSpriteRenderer__GetEnumerator__
		            );
		  local_18 = 0;
		  local_14 = &local_10;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar3 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x25b,&local_10,
		                       Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__GameAssetViewSpriteRenderer__MoveNext__
		                      );
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80fa2842;
		    }
		    if (iVar3 == 0) {
		      DAT_ram_009d3e38 = 0;
		      return;
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar2 = local_8._4_4_;
		    param3 = func_ii_4075(param1,0);
		    if (DAT_ram_009d3e38 == 1) break;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x269,uVar2,param3,0)
		    ;
		  } while (DAT_ram_009d3e38 != 1);
		  DAT_ram_009d3e38 = 0;
		  uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80fa2842:
		  iVar1 = global_1;
		  iVar3 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar1 == iVar3) {
		    piVar4 = (int *)import::env::__cxa_begin_catch(uVar2);
		    iVar3 = *piVar4;
		    DAT_ram_009d3e38 = 0;
		    local_18 = iVar3;
		    import::env::invoke_v(0x123);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 != 1) {
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
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x27b,&local_18);
		  iVar1 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar1 != 1) {
		    import::env::__resumeException(uVar2);
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

		// Token: 0x060051ED RID: 20973 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60051ED")]
		[Address(RVA = "0x9FC4", Offset = "0x9FC4", VA = "0x9FC4", Slot = "8")]
		protected override void ApplySortingOrder()
		{
		/* --- GHIDRA: ApplySortingOrder ---
		void Gameplay_Isles_User_View_IsleDecorationsView__ApplySortingOrder(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int *piVar4;
		  int local_18;
		  undefined8 *local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a58d5a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__GameAssetViewSpriteRenderer__get_Values__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__GameAssetViewSpriteRenderer__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__GameAssetViewSpriteRenderer__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__GameAssetViewSpriteRenderer__get_Current__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_uint__GameAssetViewSpriteRenderer__GetEnumerator__
		              );
		    DAT_ram_00a58d5a = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  uVar2 = System_Collections_Generic_Dictionary_int__object___TryAdd
		                    (*(undefined4 *)(param1 + 0x2c),
		                     Method_System_Collections_Generic_Dictionary_uint__GameAssetViewSpriteRenderer__get_Values__
		                    );
		  System_Collections_Generic_Dictionary_Int32Enum__object___get_Values
		            (&local_10,uVar2,
		             Method_System_Collections_Generic_Dictionary_ValueCollection_uint__GameAssetViewSpriteRenderer__GetEnumerator__
		            );
		  local_18 = 0;
		  local_14 = &local_10;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar3 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x25b,&local_10,
		                       Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__GameAssetViewSpriteRenderer__MoveNext__
		                      );
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80fa2a4a;
		    }
		    if (iVar3 == 0) {
		      DAT_ram_009d3e38 = 0;
		      return;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x26b,local_8._4_4_,
		               *(undefined4 *)(param1 + 0x18),0);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		  } while (iVar1 != 1);
		  uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80fa2a4a:
		  iVar1 = global_1;
		  iVar3 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar1 == iVar3) {
		    piVar4 = (int *)import::env::__cxa_begin_catch(uVar2);
		    iVar3 = *piVar4;
		    DAT_ram_009d3e38 = 0;
		    local_18 = iVar3;
		    import::env::invoke_v(0x123);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 != 1) {
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
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x27c,&local_18);
		  iVar1 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar1 != 1) {
		    import::env::__resumeException(uVar2);
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

		// Token: 0x060051EE RID: 20974 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60051EE")]
		[Address(RVA = "0x9FC5", Offset = "0x9FC5", VA = "0x9FC5", Slot = "9")]
		protected override void ApplySortingLayerId()
		{
		/* --- GHIDRA: ApplySortingLayerId ---
		void Gameplay_Isles_User_View_IsleDecorationsView__ApplySortingLayerId(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a58d5b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__GameAssetViewSpriteRenderer___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_Dictionary_uint__GameAssetViewSpriteRenderer__TypeInfo);
		    DAT_ram_00a58d5b = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (
		                        System_Collections_Generic_Dictionary_uint__GameAssetViewSpriteRenderer__TypeInfo
		                        );
		  System_Collections_Generic_Dictionary_uint__object____ctor
		            (param1_00,1,
		             Method_System_Collections_Generic_Dictionary_uint__GameAssetViewSpriteRenderer___ctor__
		            );
		  *(undefined4 *)(param1 + 0x2c) = param1_00;
		  ScreenAdaptation_Common_AppSize__Update(param1,0);
		  return;
		}
		*/

		}

		// Token: 0x060051EF RID: 20975 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60051EF")]
		[Address(RVA = "0x9FC6", Offset = "0x9FC6", VA = "0x9FC6")]
		public IsleDecorationsView()
		{
		/* --- GHIDRA: .ctor ---
		undefined4 Gameplay_Isles_User_View_IsleDecorationsView___ctor(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a58d5c == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_12645);
		    DAT_ram_00a58d5c = '\x01';
		  }
		  return StringLiteral_12645;
		}
		*/

		}

		// Token: 0x04002C88 RID: 11400
		[Token(Token = "0x4002C88")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private Transform _container;

		// Token: 0x04002C89 RID: 11401
		[Token(Token = "0x4002C89")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameAssetViewSpriteRenderer _assetRendererPrefab;

		// Token: 0x04002C8A RID: 11402
		[Token(Token = "0x4002C8A")]
		[FieldOffset(Offset = "0x2C")]
		private Dictionary<uint, GameAssetViewSpriteRenderer> _decorationsById;
	}
}
