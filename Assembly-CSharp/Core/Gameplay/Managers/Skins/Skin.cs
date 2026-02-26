using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using Il2CppDummyDll;
using JetBrains.Annotations;
using Protocol.Dic;
using UnityEngine;
using UnityEngine.U2D;

namespace Core.Gameplay.Managers.Skins
{
	// Token: 0x02001188 RID: 4488
	[Token(Token = "0x2001188")]
	public class Skin : IDisposable
	{
		// Token: 0x140002B6 RID: 694
		// (add) Token: 0x06006AAD RID: 27309 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006AAE RID: 27310 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002B6")]
		public event Action<Skin> StopEvent
		{
			[Token(Token = "0x6006AAD")]
			[Address(RVA = "0xB5C6", Offset = "0xB5C6", VA = "0xB5C6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006AAE")]
			[Address(RVA = "0xB5C7", Offset = "0xB5C7", VA = "0xB5C7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06006AAF RID: 27311 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006AAF")]
		[Address(RVA = "0x4455", Offset = "0x4455", VA = "0x4455", Slot = "4")]
		public void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		int * Core_Gameplay_Managers_Skins_Skin__Dispose(int *param1)
		
		{
		  if (*param1 == 0) {
		    return param1;
		  }
		  System_Data_DataSet__ValidateLocaleConstraint(*param1);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06006AB0 RID: 27312 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006AB0")]
		[Address(RVA = "0xB5C8", Offset = "0xB5C8", VA = "0xB5C8")]
		private Skin(SkinPackageDic.Types.Skin skin, AssetDic asset)
		{
		/* --- GHIDRA: .cctor ---
		void Protocol_Dic_SkinPackageDic_Types_Skin___cctor(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a59332 == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Dic_SkinPackageDic_Types_Skin___c_TypeInfo);
		    DAT_ram_00a59332 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Protocol_Dic_SkinPackageDic_Types_Skin___c_TypeInfo);
		  **(undefined4 **)(Protocol_Dic_SkinPackageDic_Types_Skin___c_TypeInfo + 0x5c) = uVar1;
		  return;
		}
		*/

		/* --- GHIDRA: .ctor ---
		undefined4 Protocol_Dic_SkinPackageDic_Types_Skin___ctor(undefined4 param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a59329 == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Dic_SkinPackageDic_Types_Skin_TypeInfo);
		    DAT_ram_00a59329 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(Protocol_Dic_SkinPackageDic_Types_Skin_TypeInfo);
		  Protocol_Dic_SkinPackageDic_Types_Skin___ctor(param1_00,param1,param1);
		  return param1_00;
		}
		*/

		/* --- GHIDRA: .ctor ---
		undefined4 Protocol_Dic_SkinPackageDic_Types_Skin___ctor(undefined4 param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a59329 == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Dic_SkinPackageDic_Types_Skin_TypeInfo);
		    DAT_ram_00a59329 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(Protocol_Dic_SkinPackageDic_Types_Skin_TypeInfo);
		  Protocol_Dic_SkinPackageDic_Types_Skin___ctor(param1_00,param1,param1);
		  return param1_00;
		}
		*/

		/* --- GHIDRA: .ctor ---
		void Core_Gameplay_Managers_Skins_Skin___ctor(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  undefined4 param2_00;
		  undefined4 local_4;
		  
		  local_4 = *(undefined4 *)(*(int *)(param1 + 0x1c) + 0xc);
		  uVar1 = func_ii_1081(DAT_ram_00a66958,&local_4);
		  uVar2 = unnamed_function_2232(&StringLiteral_28607);
		  param2_00 = unnamed_function_2232(&StringLiteral_14383);
		  uVar1 = System_Collections_Generic_Dictionary_int__object___ContainsKey(uVar2,param2_00,uVar1,0);
		  uVar2 = unnamed_function_2232(&System_ObjectDisposedException_TypeInfo);
		  uVar2 = unnamed_function_1417(uVar2);
		  func_ii_11454(uVar2,uVar1,0);
		  uVar1 = unnamed_function_2232(&Method_Core_Gameplay_Managers_Skins_Skin_ThrowDisposedEx__);
		  func_ii_1050(uVar2,uVar1);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06006AB1 RID: 27313 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006AB1")]
		[Address(RVA = "0xB5C9", Offset = "0xB5C9", VA = "0xB5C9")]
		private void ThrowDisposedEx()
		{
		/* --- GHIDRA: ThrowDisposedEx ---
		void Core_Gameplay_Managers_Skins_Skin__ThrowDisposedEx
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  undefined4 param3_00;
		  undefined4 local_4;
		  
		  local_4 = *(undefined4 *)(*(int *)(param1 + 0x20) + 0x10);
		  uVar1 = unnamed_function_2232(&Protocol_Dic_AssetDic_Types_Kind_TypeInfo);
		  uVar1 = func_ii_1081(uVar1,&local_4);
		  uVar2 = unnamed_function_2232(&StringLiteral_4021);
		  uVar1 = func_ii_4419(uVar2,uVar1,0);
		  uVar2 = unnamed_function_2232(&StringLiteral_14391);
		  param3_00 = unnamed_function_2232(&StringLiteral_305);
		  uVar1 = System_Int32__ToString(uVar2,param2,param3_00,uVar1,0);
		  uVar2 = unnamed_function_2232(&System_Exception_TypeInfo);
		  uVar2 = unnamed_function_1417(uVar2);
		  System_String__Concat(uVar2,uVar1,0);
		  uVar1 = unnamed_function_2232(&Method_Core_Gameplay_Managers_Skins_Skin_ThrowWrongAssetKind__);
		  func_ii_1050(uVar2,uVar1);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06006AB2 RID: 27314 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006AB2")]
		[Address(RVA = "0xB5CA", Offset = "0xB5CA", VA = "0xB5CA")]
		private void ThrowWrongAssetKind(string methodName)
		{
		/* --- GHIDRA: ThrowWrongAssetKind ---
		undefined4
		Core_Gameplay_Managers_Skins_Skin__ThrowWrongAssetKind
		          (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a638b6 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_string__Contains__);
		    DAT_ram_00a638b6 = '\x01';
		  }
		  uVar1 = Google_Protobuf_Collections_RepeatedField_object___Clear
		                    (*(undefined4 *)(*(int *)(param1 + 0x1c) + 0x10),param2,
		                     Method_Google_Protobuf_Collections_RepeatedField_string__Contains__);
		  return uVar1;
		}
		*/

		}

		// Token: 0x06006AB3 RID: 27315 RVA: 0x00013A28 File Offset: 0x00011C28
		[Token(Token = "0x6006AB3")]
		[Address(RVA = "0x444A", Offset = "0x444A", VA = "0x444A")]
		private UniTask<SpriteAtlas> GetAtlas(CancellationToken cancellationToken)
		{
			return default(UniTask<SpriteAtlas>);
		}

		// Token: 0x06006AB4 RID: 27316 RVA: 0x00013A40 File Offset: 0x00011C40
		[Token(Token = "0x6006AB4")]
		[Address(RVA = "0xB5CB", Offset = "0xB5CB", VA = "0xB5CB")]
		public bool IsFit(string assetName)
		{
		/* --- GHIDRA: IsFit ---
		int Core_Gameplay_Managers_Skins_Skin__IsFit
		              (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a638ba == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_Skins_Skin_TypeInfo);
		    DAT_ram_00a638ba = '\x01';
		  }
		  iVar1 = unnamed_function_1417(Core_Gameplay_Managers_Skins_Skin_TypeInfo);
		  if (DAT_ram_00a638b4 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_string__UniTaskCompletionSource_SpriteAtlas____ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_Dictionary_string__UniTaskCompletionSource_SpriteAtlas___TypeInfo
		              );
		    DAT_ram_00a638b4 = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (
		                        System_Collections_Generic_Dictionary_string__UniTaskCompletionSource_SpriteAtlas___TypeInfo
		                        );
		  System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		            (param1_00,
		             Method_System_Collections_Generic_Dictionary_string__UniTaskCompletionSource_SpriteAtlas____ctor__
		            );
		  *(undefined4 *)(iVar1 + 0x18) = param1_00;
		  *(undefined4 *)(iVar1 + 0x1c) = param2;
		  *(undefined4 *)(iVar1 + 0x20) = param3;
		  return iVar1;
		}
		*/

			return default(bool);
		}

		// Token: 0x06006AB5 RID: 27317 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006AB5")]
		[Address(RVA = "0x4454", Offset = "0x4454", VA = "0x4454")]
		public void RiseStop()
		{
		/* --- GHIDRA: RiseStop ---
		void Core_Gameplay_Managers_Skins_Skin__RiseStop(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  int iVar2;
		  int *piVar3;
		  undefined4 uVar4;
		  undefined4 uVar5;
		  undefined4 param2_00;
		  int local_30;
		  undefined8 *puStack_2c;
		  undefined8 local_28;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a638b3 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__Texture__Clear__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_string__UniTaskCompletionSource_SpriteAtlas___Clear__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__Texture__get_Values__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_string__UniTaskCompletionSource_SpriteAtlas___get_Values__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_string__Texture__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_string__UniTaskCompletionSource_SpriteAtlas___Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_string__UniTaskCompletionSource_SpriteAtlas___MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_string__Texture__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_string__Texture__get_Current__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_string__UniTaskCompletionSource_SpriteAtlas___get_Current__
		              );
		    Mono_Security_ASN1__get_Item(&Core_GameResources_GameResourcesManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Cysharp_Threading_Tasks_UniTaskCompletionSource_SpriteAtlas__TrySetCanceled__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_string__UniTaskCompletionSource_SpriteAtlas___GetEnumerator__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ValueCollection_string__Texture__GetEnumerator__
		              );
		    DAT_ram_00a638b3 = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  local_18 = 0;
		  local_20 = 0;
		  if (*(char *)(param1 + 0x14) != '\0') {
		    local_30 = *(int *)(*(int *)(param1 + 0x1c) + 0xc);
		    uVar4 = func_ii_1081(DAT_ram_00a66958,&local_30);
		    uVar5 = unnamed_function_2232(&StringLiteral_28607);
		    param2_00 = unnamed_function_2232(&StringLiteral_14383);
		    uVar4 = System_Collections_Generic_Dictionary_int__object___ContainsKey(uVar5,param2_00,uVar4,0)
		    ;
		    uVar5 = unnamed_function_2232(&System_ObjectDisposedException_TypeInfo);
		    uVar5 = unnamed_function_1417(uVar5);
		    func_ii_11454(uVar5,uVar4,0);
		    uVar4 = unnamed_function_2232(&Method_Core_Gameplay_Managers_Skins_Skin_ThrowDisposedEx__);
		    func_ii_1050(uVar5,uVar4);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  if (*(int *)(param1 + 0xc) == 0) {
		code_r0x8230e0e2:
		    if (*(int *)(*(int *)(param1 + 0x20) + 0x10) == 4) {
		      uVar4 = *(undefined4 *)(param1 + 0x10);
		      if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		        func_ii_306000(UnityEngine_Object_TypeInfo);
		      }
		      iVar1 = UnityEngine_Component__GetComponent_object_(uVar4,0);
		      if (iVar1 != 0) {
		        uVar4 = *(undefined4 *)(*(int *)(param1 + 0x20) + 0x14);
		        if (*(int *)(Core_GameResources_GameResourcesManager_TypeInfo + 0x74) == 0) {
		          func_ii_306000(Core_GameResources_GameResourcesManager_TypeInfo);
		        }
		        func_ii_7534(uVar4,0);
		      }
		    }
		    uVar4 = System_Collections_Generic_Dictionary_int__object___TryAdd
		                      (*(undefined4 *)(param1 + 0x18),
		                       Method_System_Collections_Generic_Dictionary_string__UniTaskCompletionSource_SpriteAtlas___get_Values__
		                      );
		    System_Collections_Generic_Dictionary_Int32Enum__object___get_Values
		              (&local_20,uVar4,
		               Method_System_Collections_Generic_Dictionary_ValueCollection_string__UniTaskCompletionSource_SpriteAtlas___GetEnumerator__
		              );
		    local_30 = 0;
		    puStack_2c = &local_20;
		    do {
		      DAT_ram_009d3e38 = 0;
		      iVar2 = import::env::invoke_iii
		                        (s_struct_Uniforms___color__array<v_ram_00000f84 + 0x1a2,&local_20,
		                         Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_string__UniTaskCompletionSource_SpriteAtlas___MoveNext__
		                        );
		      iVar1 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar1 == 1) {
		        uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x8230e24f;
		      }
		      if (iVar2 == 0) goto code_r0x8230e34b;
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_iiii
		                (s___Scripting__UnityEngine__XR__Me_ram_0000443a + 0xe,local_18._4_4_,0,
		                 Method_Cysharp_Threading_Tasks_UniTaskCompletionSource_SpriteAtlas__TrySetCanceled__
		                );
		      iVar1 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		    } while (iVar1 != 1);
		    uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x8230e24f:
		    iVar1 = global_1;
		    iVar2 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		    if (iVar1 == iVar2) {
		      piVar3 = (int *)import::env::__cxa_begin_catch(uVar4);
		      iVar2 = *piVar3;
		      DAT_ram_009d3e38 = 0;
		      local_30 = iVar2;
		      import::env::invoke_v(0x123);
		      iVar1 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar1 != 1) {
		        if (iVar2 != 0) {
		          System_Data_DataSet__ValidateLocaleConstraint(iVar2);
		          do {
		            halt_trap();
		          } while( true );
		        }
		code_r0x8230e34b:
		        DAT_ram_009d3e38 = 0;
		        System_Xml_XmlWellFormedWriter__PushNamespaceImplicit
		                  (*(undefined4 *)(param1 + 0x18),
		                   Method_System_Collections_Generic_Dictionary_string__UniTaskCompletionSource_SpriteAtlas___Clear__
		                  );
		        *(undefined1 *)(param1 + 0x14) = 1;
		        *(undefined4 *)(param1 + 8) = 0;
		        *(undefined4 *)(param1 + 0x10) = 0;
		        return;
		      }
		      uVar4 = import::env::__cxa_find_matching_catch_2();
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_ii(s___Scripting__UnityEngine__XR__Me_ram_0000443a + 0xf,&local_30);
		  }
		  else {
		    uVar4 = System_Collections_Generic_Dictionary_int__object___TryAdd
		                      (*(int *)(param1 + 0xc),
		                       Method_System_Collections_Generic_Dictionary_string__Texture__get_Values__);
		    System_Collections_Generic_Dictionary_Int32Enum__object___get_Values
		              (&local_30,uVar4,
		               Method_System_Collections_Generic_Dictionary_ValueCollection_string__Texture__GetEnumerator__
		              );
		    local_8 = local_28;
		    local_10 = CONCAT44(puStack_2c,local_30);
		    local_30 = 0;
		    puStack_2c = &local_10;
		    do {
		      DAT_ram_009d3e38 = 0;
		      iVar2 = import::env::invoke_iii
		                        (s_struct_Uniforms___color__array<v_ram_00000f84 + 0x1a2,&local_10,
		                         Method_System_Collections_Generic_Dictionary_ValueCollection_Enumerator_string__Texture__MoveNext__
		                        );
		      iVar1 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar1 == 1) {
		        uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x8230e079;
		      }
		      if (iVar2 == 0) goto code_r0x8230e0cf;
		      uVar4 = local_8._4_4_;
		      if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vi
		                  (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                   UnityEngine_Object_TypeInfo);
		        if (DAT_ram_009d3e38 == 1) break;
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vii(s_struct_Uniforms___color__array<v_ram_00000aff + 0x274,uVar4,0);
		    } while (DAT_ram_009d3e38 != 1);
		    DAT_ram_009d3e38 = 0;
		    uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x8230e079:
		    iVar1 = global_1;
		    iVar2 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		    if (iVar1 == iVar2) {
		      piVar3 = (int *)import::env::__cxa_begin_catch(uVar4);
		      iVar2 = *piVar3;
		      DAT_ram_009d3e38 = 0;
		      local_30 = iVar2;
		      import::env::invoke_v(0x123);
		      iVar1 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar1 != 1) {
		        if (iVar2 != 0) {
		          System_Data_DataSet__ValidateLocaleConstraint(iVar2);
		          do {
		            halt_trap();
		          } while( true );
		        }
		code_r0x8230e0cf:
		        DAT_ram_009d3e38 = 0;
		        System_Xml_XmlWellFormedWriter__PushNamespaceImplicit
		                  (*(undefined4 *)(param1 + 0xc),
		                   Method_System_Collections_Generic_Dictionary_string__Texture__Clear__);
		        goto code_r0x8230e0e2;
		      }
		      uVar4 = import::env::__cxa_find_matching_catch_2();
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_ii(s___Scripting__UnityEngine__XR__Me_ram_0000443a + 0xd,&local_30);
		  }
		  if (DAT_ram_009d3e38 != 1) {
		    DAT_ram_009d3e38 = 0;
		    import::env::__resumeException(uVar4);
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

		// Token: 0x06006AB6 RID: 27318 RVA: 0x00013A58 File Offset: 0x00011C58
		[Token(Token = "0x6006AB6")]
		[Address(RVA = "0x1F58", Offset = "0x1F58", VA = "0x1F58")]
		public UniTask<Sprite> GetSprite(string name, CancellationToken cancellationToken)
		{
			return default(UniTask<Sprite>);
		}

		// Token: 0x06006AB7 RID: 27319 RVA: 0x00013A70 File Offset: 0x00011C70
		[Token(Token = "0x6006AB7")]
		[Address(RVA = "0x1F52", Offset = "0x1F52", VA = "0x1F52")]
		public UniTask<string> GetAnimationAssetId(string name, CancellationToken cancellationToken)
		{
		/* --- GHIDRA: GetAnimationAssetId ---
		void Core_Gameplay_Managers_Skins_Skin__GetAnimationAssetId(int *param1,int *param2,int param3)
		
		{
		  undefined8 uVar1;
		  int iVar2;
		  int iVar3;
		  undefined8 local_8;
		  
		  iVar2 = *param2;
		  if (iVar2 == 0) {
		    iVar3 = param2[1];
		    local_8 = 0;
		    iVar2 = *(int *)(param3 + 0x10);
		    if ((*(byte *)(iVar2 + 0xbd) & 1) == 0) {
		      iVar2 = func_ii_1079(iVar2);
		    }
		    System_ValueTuple_bool__long___ToString
		              (&local_8,0,iVar3,*(undefined4 *)(*(int *)(iVar2 + 0x60) + 0x28));
		    uVar1 = local_8;
		    param1[2] = 0;
		    param1[3] = 0;
		    param1[0] = 0;
		    param1[1] = 0;
		    if ((*(byte *)(*(int *)(param3 + 0x10) + 0xbd) & 1) == 0) {
		      func_ii_1079(*(int *)(param3 + 0x10));
		    }
		    *(undefined2 *)(param1 + 3) = 0;
		    *param1 = 0;
		    *(undefined8 *)(param1 + 1) = uVar1;
		  }
		  else {
		    iVar3 = *(int *)(param3 + 0x10);
		    if ((*(byte *)(iVar3 + 0xbd) & 1) == 0) {
		      iVar3 = func_ii_1079(iVar3);
		    }
		    iVar3 = *(int *)(*(int *)(iVar3 + 0x60) + 0x34);
		    if ((*(byte *)(iVar3 + 0xbd) & 1) == 0) {
		      iVar3 = func_ii_1079(iVar3);
		    }
		    iVar3 = unnamed_function_1417(iVar3);
		    if ((*(byte *)(*(int *)(param3 + 0x10) + 0xbd) & 1) == 0) {
		      func_ii_1079(*(int *)(param3 + 0x10));
		    }
		    *(int *)(iVar3 + 8) = iVar2;
		    iVar2 = param2[2];
		    param1[2] = 0;
		    param1[3] = 0;
		    param1[0] = 0;
		    param1[1] = 0;
		    if ((*(byte *)(*(int *)(param3 + 0x10) + 0xbd) & 1) == 0) {
		      func_ii_1079(*(int *)(param3 + 0x10));
		    }
		    *(short *)(param1 + 3) = (short)iVar2;
		    *param1 = iVar3;
		    param1[1] = 0;
		    param1[2] = 0;
		  }
		  return;
		}
		*/

			return default(UniTask<string>);
		}

		// Token: 0x06006AB8 RID: 27320 RVA: 0x00013A88 File Offset: 0x00011C88
		[Token(Token = "0x6006AB8")]
		[Address(RVA = "0x1F5B", Offset = "0x1F5B", VA = "0x1F5B")]
		public UniTask<Texture> GetTexture(string name, CancellationToken cancellationToken)
		{
			return default(UniTask<Texture>);
		}

		// Token: 0x0400385D RID: 14429
		[Token(Token = "0x400385D")]
		[FieldOffset(Offset = "0xC")]
		[CanBeNull]
		private Dictionary<string, Texture> _textures;

		// Token: 0x0400385E RID: 14430
		[Token(Token = "0x400385E")]
		[FieldOffset(Offset = "0x10")]
		[CanBeNull]
		private SpriteAtlas _spriteAtlas;

		// Token: 0x0400385F RID: 14431
		[Token(Token = "0x400385F")]
		[FieldOffset(Offset = "0x14")]
		private bool _isDisposed;

		// Token: 0x04003860 RID: 14432
		[Token(Token = "0x4003860")]
		[FieldOffset(Offset = "0x18")]
		private readonly Dictionary<string, UniTaskCompletionSource<SpriteAtlas>> _completionSourcesByPath;

		// Token: 0x04003861 RID: 14433
		[Token(Token = "0x4003861")]
		[FieldOffset(Offset = "0x1C")]
		private readonly SkinPackageDic.Types.Skin _skin;

		// Token: 0x04003862 RID: 14434
		[Token(Token = "0x4003862")]
		[FieldOffset(Offset = "0x20")]
		public readonly AssetDic Asset;

		// Token: 0x02001189 RID: 4489
		[Token(Token = "0x2001189")]
		public class Factory
		{
			// Token: 0x06006AB9 RID: 27321 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6006AB9")]
			[Address(RVA = "0xB5CC", Offset = "0xB5CC", VA = "0xB5CC")]
			public Skin Create(SkinPackageDic.Types.Skin skin, AssetDic asset)
			{
				return null;
			}

			// Token: 0x06006ABA RID: 27322 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006ABA")]
			[Address(RVA = "0xB5CD", Offset = "0xB5CD", VA = "0xB5CD")]
			public Factory()
			{
			}
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_StopEvent ---
		void Core_Gameplay_Managers_Skins_Skin__add_StopEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a638b2 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_Skin__TypeInfo);
		    DAT_ram_00a638b2 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 8);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_Skin__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_Skin__TypeInfo), iVar2 == 0)) break;
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


		/* --- GHIDRA: remove_StopEvent ---
		void Core_Gameplay_Managers_Skins_Skin__remove_StopEvent
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a638b4 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_string__UniTaskCompletionSource_SpriteAtlas____ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_Dictionary_string__UniTaskCompletionSource_SpriteAtlas___TypeInfo
		              );
		    DAT_ram_00a638b4 = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (
		                        System_Collections_Generic_Dictionary_string__UniTaskCompletionSource_SpriteAtlas___TypeInfo
		                        );
		  System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		            (param1_00,
		             Method_System_Collections_Generic_Dictionary_string__UniTaskCompletionSource_SpriteAtlas____ctor__
		            );
		  *(undefined4 *)(param1 + 0x18) = param1_00;
		  *(undefined4 *)(param1 + 0x1c) = param2;
		  *(undefined4 *)(param1 + 0x20) = param3;
		  return;
		}
		*/


		/* --- GHIDRA: get_Parser ---
		undefined4 Protocol_Dic_SkinPackageDic_Types_Skin__get_Parser(undefined4 param1)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  int *param1_00;
		  
		  if (DAT_ram_00a59325 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IList_MessageDescriptor__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Dic_SkinPackageDic_TypeInfo);
		    DAT_ram_00a59325 = '\x01';
		  }
		  if (*(int *)(Protocol_Dic_SkinPackageDic_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Protocol_Dic_SkinPackageDic_TypeInfo);
		  }
		  uVar1 = 0;
		  iVar2 = Protocol_Dic_SkinPackageDic__get_Parser(0);
		  param1_00 = *(int **)(iVar2 + 0x34);
		  iVar2 = *param1_00;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    do {
		      if (System_Collections_Generic_IList_MessageDescriptor__TypeInfo ==
		          *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(iVar2 + *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80feaa23;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param1_00,
		                                System_Collections_Generic_IList_MessageDescriptor__TypeInfo,0);
		code_r0x80feaa23:
		  uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(param1_00,0,puVar3[1]);
		  return uVar4;
		}
		*/


		/* --- GHIDRA: get_Descriptor ---
		undefined4
		Protocol_Dic_SkinPackageDic_Types_Skin__get_Descriptor(undefined4 param1,undefined4 param2)
		
		{
		  int param1_00;
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a59326 == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Dic_SkinPackageDic_Types_Skin_TypeInfo);
		    DAT_ram_00a59326 = '\x01';
		  }
		  param1_00 = Protocol_Dic_SkinPackageDic_Types_Skin_TypeInfo;
		  if (*(int *)(Protocol_Dic_SkinPackageDic_Types_Skin_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Protocol_Dic_SkinPackageDic_Types_Skin_TypeInfo);
		  }
		  uVar1 = Protocol_Dic_SkinPackageDic_Types_Skin__get_Parser(param1_00);
		  return uVar1;
		}
		*/


		/* --- GHIDRA: pb::Google.Protobuf.IMessage.get_Descriptor ---
		void Protocol_Dic_SkinPackageDic_Types_Skin__pb__Google_Protobuf_IMessage_get_Descriptor
		               (int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a59327 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Google_Protobuf_Collections_RepeatedField_string___ctor__);
		    Mono_Security_ASN1__get_Item(&Google_Protobuf_Collections_RepeatedField_string__TypeInfo);
		    DAT_ram_00a59327 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(Google_Protobuf_Collections_RepeatedField_string__TypeInfo);
		  Google_Protobuf_Collections_RepeatedField___Il2CppFullySharedGenericType____cctor
		            (param1_00,Method_Google_Protobuf_Collections_RepeatedField_string___ctor__);
		  *(undefined4 *)(param1 + 0x10) = param1_00;
		  return;
		}
		*/


		/* --- GHIDRA: set_Asset ---
		undefined4
		Protocol_Dic_SkinPackageDic_Types_Skin__set_Asset(int *param1,int *param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int *piVar2;
		  int iVar3;
		  
		  piVar2 = (int *)0x0;
		  if (DAT_ram_00a5932a == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Dic_SkinPackageDic_Types_Skin_TypeInfo);
		    DAT_ram_00a5932a = '\x01';
		  }
		  if ((param2 != (int *)0x0) &&
		     (piVar2 = param2, *param2 != Protocol_Dic_SkinPackageDic_Types_Skin_TypeInfo)) {
		    piVar2 = (int *)0x0;
		  }
		  uVar1 = 0;
		  if (DAT_ram_00a5932b == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Google_Protobuf_Collections_RepeatedField_string__Equals__)
		    ;
		    DAT_ram_00a5932b = '\x01';
		  }
		  if (piVar2 != (int *)0x0) {
		    if (param1 == piVar2) {
		      return 1;
		    }
		    if (((param1[3] == piVar2[3]) &&
		        (iVar3 = Google_Protobuf_Collections_RepeatedField_uint___CopyTo
		                           (param1[4],piVar2[4],
		                            Method_Google_Protobuf_Collections_RepeatedField_string__Equals__),
		        iVar3 != 0)) &&
		       (iVar3 = Sirenix_Serialization_Utilities_TypeExtensions__GetNiceName(param1[5],piVar2[5],0),
		       iVar3 != 0)) {
		      uVar1 = Sirenix_Serialization_Utilities_TypeExtensions__GetNiceName(param1[2],piVar2[2],0);
		    }
		  }
		  return uVar1;
		}
		*/


		/* --- GHIDRA: Equals ---
		undefined4 Protocol_Dic_SkinPackageDic_Types_Skin__Equals(int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  
		  uVar1 = 0;
		  if (DAT_ram_00a5932b == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Google_Protobuf_Collections_RepeatedField_string__Equals__)
		    ;
		    DAT_ram_00a5932b = '\x01';
		  }
		  if (param2 != 0) {
		    if (param1 == param2) {
		      return 1;
		    }
		    if (((*(int *)(param1 + 0xc) == *(int *)(param2 + 0xc)) &&
		        (iVar2 = Google_Protobuf_Collections_RepeatedField_uint___CopyTo
		                           (*(undefined4 *)(param1 + 0x10),*(undefined4 *)(param2 + 0x10),
		                            Method_Google_Protobuf_Collections_RepeatedField_string__Equals__),
		        iVar2 != 0)) &&
		       (iVar2 = Sirenix_Serialization_Utilities_TypeExtensions__GetNiceName
		                          (*(undefined4 *)(param1 + 0x14),*(undefined4 *)(param2 + 0x14),0),
		       iVar2 != 0)) {
		      uVar1 = Sirenix_Serialization_Utilities_TypeExtensions__GetNiceName
		                        (*(undefined4 *)(param1 + 8),*(undefined4 *)(param2 + 8),0);
		    }
		  }
		  return uVar1;
		}
		*/


		/* --- GHIDRA: Equals ---
		undefined4 Protocol_Dic_SkinPackageDic_Types_Skin__Equals(int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  
		  uVar1 = 0;
		  if (DAT_ram_00a5932b == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Google_Protobuf_Collections_RepeatedField_string__Equals__)
		    ;
		    DAT_ram_00a5932b = '\x01';
		  }
		  if (param2 != 0) {
		    if (param1 == param2) {
		      return 1;
		    }
		    if (((*(int *)(param1 + 0xc) == *(int *)(param2 + 0xc)) &&
		        (iVar2 = Google_Protobuf_Collections_RepeatedField_uint___CopyTo
		                           (*(undefined4 *)(param1 + 0x10),*(undefined4 *)(param2 + 0x10),
		                            Method_Google_Protobuf_Collections_RepeatedField_string__Equals__),
		        iVar2 != 0)) &&
		       (iVar2 = Sirenix_Serialization_Utilities_TypeExtensions__GetNiceName
		                          (*(undefined4 *)(param1 + 0x14),*(undefined4 *)(param2 + 0x14),0),
		       iVar2 != 0)) {
		      uVar1 = Sirenix_Serialization_Utilities_TypeExtensions__GetNiceName
		                        (*(undefined4 *)(param1 + 8),*(undefined4 *)(param2 + 8),0);
		    }
		  }
		  return uVar1;
		}
		*/


		/* --- GHIDRA: GetHashCode ---
		undefined4 Protocol_Dic_SkinPackageDic_Types_Skin__GetHashCode(undefined4 param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5932c == '\0') {
		    Mono_Security_ASN1__get_Item(&Google_Protobuf_JsonFormatter_TypeInfo);
		    DAT_ram_00a5932c = '\x01';
		  }
		  if (*(int *)(Google_Protobuf_JsonFormatter_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Google_Protobuf_JsonFormatter_TypeInfo);
		  }
		  uVar1 = Google_Protobuf_JsonFormatter__Format(param1,0);
		  return uVar1;
		}
		*/


		/* --- GHIDRA: ToString ---
		void Protocol_Dic_SkinPackageDic_Types_Skin__ToString
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5932d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_string__WriteTo__);
		    Mono_Security_ASN1__get_Item(&Protocol_Dic_SkinPackageDic_Types_Skin_TypeInfo);
		    DAT_ram_00a5932d = '\x01';
		  }
		  if (*(int *)(param1 + 0xc) != 0) {
		    Google_Protobuf_CodedOutputStream__WriteLength(param2,8,0);
		    Google_Protobuf_CodedOutputStream__WriteRawTag(param2,*(undefined4 *)(param1 + 0xc),0);
		  }
		  param1_00 = *(undefined4 *)(param1 + 0x10);
		  if (*(int *)(Protocol_Dic_SkinPackageDic_Types_Skin_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Protocol_Dic_SkinPackageDic_Types_Skin_TypeInfo);
		  }
		  Google_Protobuf_Collections_RepeatedField_uint___ToString
		            (param1_00,param2,
		             *(undefined4 *)(*(int *)(Protocol_Dic_SkinPackageDic_Types_Skin_TypeInfo + 0x5c) + 4),
		             Method_Google_Protobuf_Collections_RepeatedField_string__WriteTo__);
		  if (*(int *)(param1 + 0x14) != 0) {
		    Google_Protobuf_CodedOutputStream__WriteLength(param2,0x1a,0);
		    Google_Protobuf_CodedOutputStream__WriteTag(param2,*(undefined4 *)(param1 + 0x14),0);
		  }
		  if (*(int *)(param1 + 8) != 0) {
		    Google_Protobuf_UnknownFieldSet__HasField(*(int *)(param1 + 8),param2,0);
		  }
		  return;
		}
		*/


		/* --- GHIDRA: WriteTo ---
		int Protocol_Dic_SkinPackageDic_Types_Skin__WriteTo(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  int iVar2;
		  
		  iVar2 = 0;
		  if (DAT_ram_00a5932e == '\0') {
		    Mono_Security_ASN1__get_Item(&Google_Protobuf_CodedOutputStream_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_string__CalculateSize__);
		    Mono_Security_ASN1__get_Item(&Protocol_Dic_SkinPackageDic_Types_Skin_TypeInfo);
		    DAT_ram_00a5932e = '\x01';
		  }
		  iVar1 = *(int *)(param1 + 0xc);
		  if (iVar1 != 0) {
		    if (*(int *)(Google_Protobuf_CodedOutputStream_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Google_Protobuf_CodedOutputStream_TypeInfo);
		    }
		    iVar2 = Google_Protobuf_CodedOutputStream__ComputeBytesSize(iVar1,0);
		    iVar2 = iVar2 + 1;
		  }
		  param1_00 = *(undefined4 *)(param1 + 0x10);
		  if (*(int *)(Protocol_Dic_SkinPackageDic_Types_Skin_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Protocol_Dic_SkinPackageDic_Types_Skin_TypeInfo);
		  }
		  iVar1 = Google_Protobuf_Collections_RepeatedField_object___CalculatePackedDataSize
		                    (param1_00,
		                     *(undefined4 *)
		                      (*(int *)(Protocol_Dic_SkinPackageDic_Types_Skin_TypeInfo + 0x5c) + 4),
		                     Method_Google_Protobuf_Collections_RepeatedField_string__CalculateSize__);
		  iVar1 = iVar1 + iVar2;
		  iVar2 = *(int *)(param1 + 0x14);
		  if (iVar2 != 0) {
		    if (*(int *)(Google_Protobuf_CodedOutputStream_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Google_Protobuf_CodedOutputStream_TypeInfo);
		    }
		    iVar2 = Google_Protobuf_CodedOutputStream__ComputeRawVarint32Size(iVar2,0);
		    iVar1 = iVar2 + iVar1 + 1;
		  }
		  if (*(int *)(param1 + 8) != 0) {
		    iVar2 = Google_Protobuf_UnknownFieldSet__WriteTo(*(int *)(param1 + 8),0);
		    iVar1 = iVar2 + iVar1;
		  }
		  return iVar1;
		}
		*/


		/* --- GHIDRA: CalculateSize ---
		void Protocol_Dic_SkinPackageDic_Types_Skin__CalculateSize(int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int param2_00;
		  int param1_00;
		  
		  if (DAT_ram_00a5932f == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Common_ContentResourceAsset_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Google_Protobuf_Collections_RepeatedField_string__Add__);
		    DAT_ram_00a5932f = '\x01';
		  }
		  if (param2 != 0) {
		    if (*(int *)(param2 + 0xc) != 0) {
		      *(int *)(param1 + 0xc) = *(int *)(param2 + 0xc);
		    }
		    Google_Protobuf_Collections_RepeatedField_object____ctor
		              (*(undefined4 *)(param1 + 0x10),*(undefined4 *)(param2 + 0x10),
		               Method_Google_Protobuf_Collections_RepeatedField_string__Add__);
		    param2_00 = *(int *)(param2 + 0x14);
		    if (param2_00 != 0) {
		      param1_00 = *(int *)(param1 + 0x14);
		      if (param1_00 == 0) {
		        param1_00 = unnamed_function_1417(Protocol_Common_ContentResourceAsset_TypeInfo);
		        Protocol_Common_ContentResourceAsset__pb__Google_Protobuf_IMessage_get_Descriptor
		                  (param1_00,0);
		        *(int *)(param1 + 0x14) = param1_00;
		        param2_00 = *(int *)(param2 + 0x14);
		      }
		      Protocol_Common_ContentResourceAsset__CalculateSize(param1_00,param2_00,0);
		    }
		    uVar1 = Google_Protobuf_UnknownFieldSet__MergeFrom
		                      (*(undefined4 *)(param1 + 8),*(undefined4 *)(param2 + 8),0);
		    *(undefined4 *)(param1 + 8) = uVar1;
		  }
		  return;
		}
		*/


		/* --- GHIDRA: MergeFrom ---
		void Protocol_Dic_SkinPackageDic_Types_Skin__MergeFrom(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a59331 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Func_SkinPackageDic_Types_Skin__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_MessageParser_SkinPackageDic_Types_Skin___ctor__);
		    Mono_Security_ASN1__get_Item(&Google_Protobuf_MessageParser_SkinPackageDic_Types_Skin__TypeInfo)
		    ;
		    Mono_Security_ASN1__get_Item(&Protocol_Dic_SkinPackageDic_Types_Skin_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Protocol_Dic_SkinPackageDic_Types_Skin___c___cctor_b__35_0__);
		    Mono_Security_ASN1__get_Item(&Protocol_Dic_SkinPackageDic_Types_Skin___c_TypeInfo);
		    DAT_ram_00a59331 = '\x01';
		  }
		  if (*(int *)(Protocol_Dic_SkinPackageDic_Types_Skin___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Protocol_Dic_SkinPackageDic_Types_Skin___c_TypeInfo);
		  }
		  uVar2 = **(undefined4 **)(Protocol_Dic_SkinPackageDic_Types_Skin___c_TypeInfo + 0x5c);
		  uVar1 = unnamed_function_1417(System_Func_SkinPackageDic_Types_Skin__TypeInfo);
		  func_ii_19797(uVar1,uVar2,Method_Protocol_Dic_SkinPackageDic_Types_Skin___c___cctor_b__35_0__,0);
		  uVar2 = unnamed_function_1417(Google_Protobuf_MessageParser_SkinPackageDic_Types_Skin__TypeInfo);
		  Google_Protobuf_Collections_MapField_Codec_MessageAdapter___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType___set_Value
		            (uVar2,uVar1,Method_Google_Protobuf_MessageParser_SkinPackageDic_Types_Skin___ctor__);
		  **(undefined4 **)(Protocol_Dic_SkinPackageDic_Types_Skin_TypeInfo + 0x5c) = uVar2;
		  uVar1 = Google_Protobuf_CodedOutputStream___cctor(0x12,0);
		  *(undefined4 *)(*(int *)(Protocol_Dic_SkinPackageDic_Types_Skin_TypeInfo + 0x5c) + 4) = uVar1;
		  return;
		}
		*/


		/* --- GHIDRA: MergeFrom ---
		void Protocol_Dic_SkinPackageDic_Types_Skin__MergeFrom(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a59331 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Func_SkinPackageDic_Types_Skin__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_MessageParser_SkinPackageDic_Types_Skin___ctor__);
		    Mono_Security_ASN1__get_Item(&Google_Protobuf_MessageParser_SkinPackageDic_Types_Skin__TypeInfo)
		    ;
		    Mono_Security_ASN1__get_Item(&Protocol_Dic_SkinPackageDic_Types_Skin_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Protocol_Dic_SkinPackageDic_Types_Skin___c___cctor_b__35_0__);
		    Mono_Security_ASN1__get_Item(&Protocol_Dic_SkinPackageDic_Types_Skin___c_TypeInfo);
		    DAT_ram_00a59331 = '\x01';
		  }
		  if (*(int *)(Protocol_Dic_SkinPackageDic_Types_Skin___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Protocol_Dic_SkinPackageDic_Types_Skin___c_TypeInfo);
		  }
		  uVar2 = **(undefined4 **)(Protocol_Dic_SkinPackageDic_Types_Skin___c_TypeInfo + 0x5c);
		  uVar1 = unnamed_function_1417(System_Func_SkinPackageDic_Types_Skin__TypeInfo);
		  func_ii_19797(uVar1,uVar2,Method_Protocol_Dic_SkinPackageDic_Types_Skin___c___cctor_b__35_0__,0);
		  uVar2 = unnamed_function_1417(Google_Protobuf_MessageParser_SkinPackageDic_Types_Skin__TypeInfo);
		  Google_Protobuf_Collections_MapField_Codec_MessageAdapter___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType___set_Value
		            (uVar2,uVar1,Method_Google_Protobuf_MessageParser_SkinPackageDic_Types_Skin___ctor__);
		  **(undefined4 **)(Protocol_Dic_SkinPackageDic_Types_Skin_TypeInfo + 0x5c) = uVar2;
		  uVar1 = Google_Protobuf_CodedOutputStream___cctor(0x12,0);
		  *(undefined4 *)(*(int *)(Protocol_Dic_SkinPackageDic_Types_Skin_TypeInfo + 0x5c) + 4) = uVar1;
		  return;
		}
		*/


		/* --- GHIDRA: get_Constraints ---
		void Spine_Skin__get_Constraints(int param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  undefined4 *puVar5;
		  uint *puVar6;
		  int iVar7;
		  int *piVar8;
		  int local_3c;
		  int **local_38;
		  int local_34;
		  undefined8 *puStack_30;
		  undefined4 local_2c;
		  undefined4 uStack_28;
		  int *local_24;
		  undefined8 local_20;
		  undefined4 local_18;
		  undefined4 uStack_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a54412 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Spine_ExposedList_Enumerator_ConstraintData__Dispose__);
		    Mono_Security_ASN1__get_Item(&Method_Spine_ExposedList_Enumerator_BoneData__Dispose__);
		    Mono_Security_ASN1__get_Item(&Method_Spine_ExposedList_Enumerator_BoneData__MoveNext__);
		    Mono_Security_ASN1__get_Item(&Method_Spine_ExposedList_Enumerator_ConstraintData__MoveNext__);
		    Mono_Security_ASN1__get_Item(&Method_Spine_ExposedList_Enumerator_ConstraintData__get_Current__)
		    ;
		    Mono_Security_ASN1__get_Item(&Method_Spine_ExposedList_Enumerator_BoneData__get_Current__);
		    Mono_Security_ASN1__get_Item(&Method_Spine_ExposedList_BoneData__Add__);
		    Mono_Security_ASN1__get_Item(&Method_Spine_ExposedList_ConstraintData__Add__);
		    Mono_Security_ASN1__get_Item(&Method_Spine_ExposedList_ConstraintData__Contains__);
		    Mono_Security_ASN1__get_Item(&Method_Spine_ExposedList_BoneData__Contains__);
		    Mono_Security_ASN1__get_Item(&Method_Spine_ExposedList_BoneData__GetEnumerator__);
		    Mono_Security_ASN1__get_Item(&Method_Spine_ExposedList_ConstraintData__GetEnumerator__);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerator_Skin_SkinEntry__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Spine_Collections_OrderedDictionary_KeyCollection_Skin_SkinEntry__Attachment__GetEnumerator__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Spine_Collections_OrderedDictionary_Skin_SkinEntry__Attachment__get_Keys__);
		    DAT_ram_00a54412 = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  local_18 = 0;
		  uStack_14 = 0;
		  local_20 = 0;
		  local_24 = (int *)0x0;
		  Spine_ExposedList_float___ForEach
		            (&local_34,*(undefined4 *)(param2 + 0x10),
		             Method_Spine_ExposedList_BoneData__GetEnumerator__);
		  local_8._4_4_ = uStack_28;
		  local_34 = 0;
		  puStack_30 = &local_10;
		  do {
		    do {
		      DAT_ram_009d3e38 = 0;
		      iVar2 = import::env::invoke_iii
		                        (s_struct_Uniforms___color__array<v_ram_000013c7 + 0x288,&local_10,
		                         Method_Spine_ExposedList_Enumerator_BoneData__MoveNext__);
		      uVar3 = local_8._4_4_;
		      iVar7 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar7 == 1) {
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x809b5259;
		      }
		      if (iVar2 == 0) {
		        Unity_Hierarchy_HierarchyPropertyId__get_Id
		                  (&local_10,Method_Spine_ExposedList_Enumerator_BoneData__Dispose__);
		        goto code_r0x809b52b6;
		      }
		      DAT_ram_009d3e38 = 0;
		      iVar2 = import::env::invoke_iiii
		                        (s_struct_Uniforms___color__array<v_ram_000013c7 + 0x2f8,
		                         *(undefined4 *)(param1 + 0x10),local_8._4_4_,
		                         Method_Spine_ExposedList_BoneData__Contains__);
		      iVar7 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar7 == 1) {
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x809b5259;
		      }
		    } while (iVar2 != 0);
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_000013c7 + 0x295,
		               *(undefined4 *)(param1 + 0x10),uVar3,Method_Spine_ExposedList_BoneData__Add__);
		    iVar7 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		  } while (iVar7 != 1);
		  uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x809b5259:
		  iVar7 = global_1;
		  iVar2 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar7 == iVar2) {
		    piVar4 = (int *)import::env::__cxa_begin_catch(uVar3);
		    iVar2 = *piVar4;
		    DAT_ram_009d3e38 = 0;
		    local_34 = iVar2;
		    import::env::invoke_v(0x123);
		    iVar7 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar7 != 1) {
		      Unity_Hierarchy_HierarchyPropertyId__get_Id
		                (&local_10,Method_Spine_ExposedList_Enumerator_BoneData__Dispose__);
		      if (iVar2 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(iVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		code_r0x809b52b6:
		      Spine_ExposedList_float___ForEach
		                (&local_34,*(undefined4 *)(param2 + 0x14),
		                 Method_Spine_ExposedList_ConstraintData__GetEnumerator__);
		      local_18 = local_2c;
		      uStack_14 = uStack_28;
		      local_20 = CONCAT44(puStack_30,local_34);
		      local_34 = 0;
		      puStack_30 = &local_20;
		      do {
		        do {
		          DAT_ram_009d3e38 = 0;
		          iVar2 = import::env::invoke_iii
		                            (s_struct_Uniforms___color__array<v_ram_000013c7 + 0x288,&local_20,
		                             Method_Spine_ExposedList_Enumerator_ConstraintData__MoveNext__);
		          uVar3 = uStack_14;
		          iVar7 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar7 == 1) {
		            uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x809b542e;
		          }
		          if (iVar2 == 0) {
		            Unity_Hierarchy_HierarchyPropertyId__get_Id
		                      (&local_20,Method_Spine_ExposedList_Enumerator_ConstraintData__Dispose__);
		            goto code_r0x809b548b;
		          }
		          DAT_ram_009d3e38 = 0;
		          iVar2 = import::env::invoke_iiii
		                            (s_struct_Uniforms___color__array<v_ram_000013c7 + 0x2f8,
		                             *(undefined4 *)(param1 + 0x14),uStack_14,
		                             Method_Spine_ExposedList_ConstraintData__Contains__);
		          iVar7 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar7 == 1) {
		            uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x809b542e;
		          }
		        } while (iVar2 != 0);
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (s_struct_Uniforms___color__array<v_ram_000013c7 + 0x295,
		                   *(undefined4 *)(param1 + 0x14),uVar3,
		                   Method_Spine_ExposedList_ConstraintData__Add__);
		        iVar7 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		      } while (iVar7 != 1);
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x809b542e:
		      iVar7 = global_1;
		      iVar2 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar7 == iVar2) {
		        piVar4 = (int *)import::env::__cxa_begin_catch(uVar3);
		        iVar2 = *piVar4;
		        DAT_ram_009d3e38 = 0;
		        local_34 = iVar2;
		        import::env::invoke_v(0x123);
		        iVar7 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar7 != 1) {
		          Unity_Hierarchy_HierarchyPropertyId__get_Id
		                    (&local_20,Method_Spine_ExposedList_Enumerator_ConstraintData__Dispose__);
		          if (iVar2 != 0) {
		            System_Data_DataSet__ValidateLocaleConstraint(iVar2);
		            do {
		              halt_trap();
		            } while( true );
		          }
		code_r0x809b548b:
		          uVar3 = Spine_Collections_OrderedDictionary_Skin_SkinEntry__object___get_Item
		                            (*(undefined4 *)(param2 + 0xc),
		                             Method_Spine_Collections_OrderedDictionary_Skin_SkinEntry__Attachment__get_Keys__
		                            );
		          local_24 = (int *)Spine_Collections_OrderedDictionary_KeyCollection_Skin_SkinEntry__object___CopyTo
		                                      (uVar3,
		                                       Method_Spine_Collections_OrderedDictionary_KeyCollection_Skin_SkinEntry__Attachment__GetEnumerator__
		                                      );
		          local_3c = 0;
		          local_38 = &local_24;
		          do {
		            piVar4 = local_24;
		            iVar7 = *local_24;
		            if (*(ushort *)(iVar7 + 0xb6) != 0) {
		              uVar1 = 0;
		              do {
		                piVar8 = (int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8);
		                if (System_Collections_IEnumerator_TypeInfo == *piVar8) {
		                  puVar5 = (undefined4 *)(iVar7 + piVar8[1] * 8 + 0xc0);
		                  goto code_r0x809b55a2;
		                }
		                uVar1 = uVar1 + 1;
		              } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		            }
		            DAT_ram_009d3e38 = 0;
		            puVar5 = (undefined4 *)
		                     import::env::invoke_iiii
		                               (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_24,
		                                System_Collections_IEnumerator_TypeInfo,0);
		            if (DAT_ram_009d3e38 == 1) {
		code_r0x809b5718:
		              DAT_ram_009d3e38 = 0;
		              uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		              goto code_r0x809b5720;
		            }
		code_r0x809b55a2:
		            DAT_ram_009d3e38 = 0;
		            iVar7 = import::env::invoke_iii(*puVar5,piVar4,puVar5[1]);
		            piVar4 = local_24;
		            if (DAT_ram_009d3e38 == 1) goto code_r0x809b5718;
		            if (iVar7 == 0) {
		              iVar7 = 0;
		              goto code_r0x809b5769;
		            }
		            iVar7 = *local_24;
		            if (*(ushort *)(iVar7 + 0xb6) != 0) {
		              uVar1 = 0;
		              do {
		                piVar8 = (int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8);
		                if (System_Collections_Generic_IEnumerator_Skin_SkinEntry__TypeInfo == *piVar8) {
		                  puVar5 = (undefined4 *)(iVar7 + piVar8[1] * 8 + 0xc0);
		                  goto code_r0x809b567c;
		                }
		                uVar1 = uVar1 + 1;
		              } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		            }
		            DAT_ram_009d3e38 = 0;
		            puVar5 = (undefined4 *)
		                     import::env::invoke_iiii
		                               (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_24,
		                                System_Collections_Generic_IEnumerator_Skin_SkinEntry__TypeInfo,0);
		            if (DAT_ram_009d3e38 == 1) {
		code_r0x809b5704:
		              DAT_ram_009d3e38 = 0;
		              uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		              goto code_r0x809b5720;
		            }
		code_r0x809b567c:
		            DAT_ram_009d3e38 = 0;
		            import::env::invoke_viii(*puVar5,&local_34,piVar4,puVar5[1]);
		            iVar7 = DAT_ram_009d3e38;
		            if (DAT_ram_009d3e38 == 1) goto code_r0x809b5704;
		            DAT_ram_009d3e38 = 0;
		            import::env::invoke_viiiii
		                      (s_struct_Uniforms___color__array<v_ram_000013c7 + 0x2b2,param1,local_34,
		                       puStack_30,local_2c,iVar7);
		            iVar7 = DAT_ram_009d3e38;
		            DAT_ram_009d3e38 = 0;
		          } while (iVar7 != 1);
		          uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x809b5720:
		          iVar7 = global_1;
		          iVar2 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		          if (iVar7 == iVar2) {
		            piVar4 = (int *)import::env::__cxa_begin_catch(uVar3);
		            iVar7 = *piVar4;
		            DAT_ram_009d3e38 = 0;
		            local_3c = iVar7;
		            import::env::invoke_v(0x123);
		            iVar2 = DAT_ram_009d3e38;
		            DAT_ram_009d3e38 = 0;
		            if (iVar2 != 1) {
		code_r0x809b5769:
		              piVar4 = local_24;
		              DAT_ram_009d3e38 = 0;
		              if (local_24 != (int *)0x0) {
		                uVar1 = 0;
		                iVar2 = *local_24;
		                if (*(ushort *)(iVar2 + 0xb6) != 0) {
		                  do {
		                    if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8))
		                    {
		                      puVar6 = (uint *)(iVar2 + *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8
		                                       + 0xc0);
		                      goto code_r0x809b57e1;
		                    }
		                    uVar1 = uVar1 + 1;
		                  } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		                }
		                puVar6 = (uint *)func_ii_1080(local_24,System_IDisposable_TypeInfo,0);
		code_r0x809b57e1:
		                (**(code **)((ulonglong)*puVar6 * 4))(piVar4,puVar6[1]);
		              }
		              if (iVar7 == 0) {
		                return;
		              }
		              System_Data_DataSet__ValidateLocaleConstraint(iVar7);
		              do {
		                halt_trap();
		              } while( true );
		            }
		            uVar3 = import::env::__cxa_find_matching_catch_2();
		          }
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_000013c7 + 0x2fb,&local_3c);
		          goto joined_r0x809b582e;
		        }
		        uVar3 = import::env::__cxa_find_matching_catch_2();
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_000013c7 + 0x2fa,&local_34);
		      goto joined_r0x809b582e;
		    }
		    uVar3 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_000013c7 + 0x2f9,&local_34);
		joined_r0x809b582e:
		  if (DAT_ram_009d3e38 != 1) {
		    DAT_ram_009d3e38 = 0;
		    import::env::__resumeException(uVar3);
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


		/* --- GHIDRA: SetAttachment ---
		void Spine_Skin__SetAttachment(int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a6652e == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Runtime_Serialization_SafeSerializationManager_TypeInfo);
		    DAT_ram_00a6652e = '\x01';
		  }
		  *(undefined8 *)(param1 + 0x2c) = 0x8013150000000000;
		  *(undefined4 *)(param1 + 0x1c) = 0;
		  *(undefined4 *)(param1 + 0xc) = 0;
		  uVar1 = unnamed_function_1417(System_Runtime_Serialization_SafeSerializationManager_TypeInfo);
		  *(undefined4 *)(param1 + 0x14) = param3;
		  *(undefined4 *)(param1 + 0xc) = param2;
		  *(undefined4 *)(param1 + 0x38) = uVar1;
		  return;
		}
		*/


		/* --- GHIDRA: AddSkin ---
		void Spine_Skin__AddSkin(int param1,int param2,undefined4 param3)
		
		{
		  undefined8 *param4;
		  uint uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  undefined4 *puVar5;
		  uint *puVar6;
		  int iVar7;
		  int *piVar8;
		  int local_3c;
		  int **local_38;
		  int local_34;
		  undefined8 *puStack_30;
		  int *local_2c;
		  undefined4 uStack_28;
		  int *local_24;
		  undefined8 local_20;
		  int *local_18;
		  undefined4 uStack_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a54413 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Spine_ExposedList_Enumerator_ConstraintData__Dispose__);
		    Mono_Security_ASN1__get_Item(&Method_Spine_ExposedList_Enumerator_BoneData__Dispose__);
		    Mono_Security_ASN1__get_Item(&Method_Spine_ExposedList_Enumerator_BoneData__MoveNext__);
		    Mono_Security_ASN1__get_Item(&Method_Spine_ExposedList_Enumerator_ConstraintData__MoveNext__);
		    Mono_Security_ASN1__get_Item(&Method_Spine_ExposedList_Enumerator_ConstraintData__get_Current__)
		    ;
		    Mono_Security_ASN1__get_Item(&Method_Spine_ExposedList_Enumerator_BoneData__get_Current__);
		    Mono_Security_ASN1__get_Item(&Method_Spine_ExposedList_BoneData__Add__);
		    Mono_Security_ASN1__get_Item(&Method_Spine_ExposedList_ConstraintData__Add__);
		    Mono_Security_ASN1__get_Item(&Method_Spine_ExposedList_ConstraintData__Contains__);
		    Mono_Security_ASN1__get_Item(&Method_Spine_ExposedList_BoneData__Contains__);
		    Mono_Security_ASN1__get_Item(&Method_Spine_ExposedList_BoneData__GetEnumerator__);
		    Mono_Security_ASN1__get_Item(&Method_Spine_ExposedList_ConstraintData__GetEnumerator__);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerator_Skin_SkinEntry__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Spine_Collections_OrderedDictionary_KeyCollection_Skin_SkinEntry__Attachment__GetEnumerator__
		              );
		    Mono_Security_ASN1__get_Item(&Spine_MeshAttachment_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Spine_Collections_OrderedDictionary_Skin_SkinEntry__Attachment__get_Keys__);
		    DAT_ram_00a54413 = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  local_18 = (int *)0x0;
		  uStack_14 = 0;
		  local_20 = 0;
		  local_24 = (int *)0x0;
		  Spine_ExposedList_float___ForEach
		            (&local_34,*(undefined4 *)(param2 + 0x10),
		             Method_Spine_ExposedList_BoneData__GetEnumerator__);
		  local_8._4_4_ = uStack_28;
		  local_34 = 0;
		  puStack_30 = &local_10;
		  do {
		    do {
		      DAT_ram_009d3e38 = 0;
		      iVar2 = import::env::invoke_iii
		                        (s_struct_Uniforms___color__array<v_ram_000013c7 + 0x288,&local_10,
		                         Method_Spine_ExposedList_Enumerator_BoneData__MoveNext__);
		      uVar3 = local_8._4_4_;
		      iVar7 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar7 == 1) {
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x809b5ae1;
		      }
		      if (iVar2 == 0) {
		        Unity_Hierarchy_HierarchyPropertyId__get_Id
		                  (&local_10,Method_Spine_ExposedList_Enumerator_BoneData__Dispose__);
		        goto code_r0x809b5b3e;
		      }
		      DAT_ram_009d3e38 = 0;
		      iVar2 = import::env::invoke_iiii
		                        (s_struct_Uniforms___color__array<v_ram_000013c7 + 0x2f8,
		                         *(undefined4 *)(param1 + 0x10),local_8._4_4_,
		                         Method_Spine_ExposedList_BoneData__Contains__);
		      iVar7 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar7 == 1) {
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x809b5ae1;
		      }
		    } while (iVar2 != 0);
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_000013c7 + 0x295,
		               *(undefined4 *)(param1 + 0x10),uVar3,Method_Spine_ExposedList_BoneData__Add__);
		    iVar7 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		  } while (iVar7 != 1);
		  uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x809b5ae1:
		  iVar7 = global_1;
		  iVar2 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar7 == iVar2) {
		    piVar4 = (int *)import::env::__cxa_begin_catch(uVar3);
		    iVar2 = *piVar4;
		    DAT_ram_009d3e38 = 0;
		    local_34 = iVar2;
		    import::env::invoke_v(0x123);
		    iVar7 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar7 != 1) {
		      Unity_Hierarchy_HierarchyPropertyId__get_Id
		                (&local_10,Method_Spine_ExposedList_Enumerator_BoneData__Dispose__);
		      if (iVar2 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(iVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		code_r0x809b5b3e:
		      Spine_ExposedList_float___ForEach
		                (&local_34,*(undefined4 *)(param2 + 0x14),
		                 Method_Spine_ExposedList_ConstraintData__GetEnumerator__);
		      local_18 = local_2c;
		      uStack_14 = uStack_28;
		      local_20 = CONCAT44(puStack_30,local_34);
		      local_34 = 0;
		      puStack_30 = &local_20;
		      do {
		        do {
		          DAT_ram_009d3e38 = 0;
		          iVar2 = import::env::invoke_iii
		                            (s_struct_Uniforms___color__array<v_ram_000013c7 + 0x288,&local_20,
		                             Method_Spine_ExposedList_Enumerator_ConstraintData__MoveNext__);
		          uVar3 = uStack_14;
		          iVar7 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar7 == 1) {
		            uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x809b5cb6;
		          }
		          if (iVar2 == 0) {
		            Unity_Hierarchy_HierarchyPropertyId__get_Id
		                      (&local_20,Method_Spine_ExposedList_Enumerator_ConstraintData__Dispose__);
		            goto code_r0x809b5d13;
		          }
		          DAT_ram_009d3e38 = 0;
		          iVar2 = import::env::invoke_iiii
		                            (s_struct_Uniforms___color__array<v_ram_000013c7 + 0x2f8,
		                             *(undefined4 *)(param1 + 0x14),uStack_14,
		                             Method_Spine_ExposedList_ConstraintData__Contains__);
		          iVar7 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar7 == 1) {
		            uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x809b5cb6;
		          }
		        } while (iVar2 != 0);
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viii
		                  (s_struct_Uniforms___color__array<v_ram_000013c7 + 0x295,
		                   *(undefined4 *)(param1 + 0x14),uVar3,
		                   Method_Spine_ExposedList_ConstraintData__Add__);
		        iVar7 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		      } while (iVar7 != 1);
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x809b5cb6:
		      iVar7 = global_1;
		      iVar2 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar7 == iVar2) {
		        piVar4 = (int *)import::env::__cxa_begin_catch(uVar3);
		        iVar2 = *piVar4;
		        DAT_ram_009d3e38 = 0;
		        local_34 = iVar2;
		        import::env::invoke_v(0x123);
		        iVar7 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar7 != 1) {
		          Unity_Hierarchy_HierarchyPropertyId__get_Id
		                    (&local_20,Method_Spine_ExposedList_Enumerator_ConstraintData__Dispose__);
		          if (iVar2 != 0) {
		            System_Data_DataSet__ValidateLocaleConstraint(iVar2);
		            do {
		              halt_trap();
		            } while( true );
		          }
		code_r0x809b5d13:
		          uVar3 = Spine_Collections_OrderedDictionary_Skin_SkinEntry__object___get_Item
		                            (*(undefined4 *)(param2 + 0xc),
		                             Method_Spine_Collections_OrderedDictionary_Skin_SkinEntry__Attachment__get_Keys__
		                            );
		          local_24 = (int *)Spine_Collections_OrderedDictionary_KeyCollection_Skin_SkinEntry__object___CopyTo
		                                      (uVar3,
		                                       Method_Spine_Collections_OrderedDictionary_KeyCollection_Skin_SkinEntry__Attachment__GetEnumerator__
		                                      );
		          local_3c = 0;
		          local_38 = &local_24;
		code_r0x809b5d87:
		          do {
		            piVar4 = local_24;
		            iVar7 = *local_24;
		            if (*(ushort *)(iVar7 + 0xb6) != 0) {
		              uVar1 = 0;
		              do {
		                piVar8 = (int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8);
		                if (System_Collections_IEnumerator_TypeInfo == *piVar8) {
		                  puVar5 = (undefined4 *)(iVar7 + piVar8[1] * 8 + 0xc0);
		                  goto code_r0x809b5e20;
		                }
		                uVar1 = uVar1 + 1;
		              } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		            }
		            DAT_ram_009d3e38 = 0;
		            puVar5 = (undefined4 *)
		                     import::env::invoke_iiii
		                               (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_24,
		                                System_Collections_IEnumerator_TypeInfo,0);
		            if (DAT_ram_009d3e38 == 1) {
		code_r0x809b6082:
		              DAT_ram_009d3e38 = 0;
		              uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		              goto code_r0x809b60af;
		            }
		code_r0x809b5e20:
		            DAT_ram_009d3e38 = 0;
		            iVar7 = import::env::invoke_iii(*puVar5,piVar4,puVar5[1]);
		            piVar4 = local_24;
		            if (DAT_ram_009d3e38 == 1) goto code_r0x809b6082;
		            if (iVar7 == 0) {
		              iVar7 = 0;
		              goto code_r0x809b60f8;
		            }
		            iVar7 = *local_24;
		            if (*(ushort *)(iVar7 + 0xb6) != 0) {
		              uVar1 = 0;
		              do {
		                piVar8 = (int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8);
		                if (System_Collections_Generic_IEnumerator_Skin_SkinEntry__TypeInfo == *piVar8) {
		                  puVar5 = (undefined4 *)(iVar7 + piVar8[1] * 8 + 0xc0);
		                  goto code_r0x809b5efa;
		                }
		                uVar1 = uVar1 + 1;
		              } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		            }
		            DAT_ram_009d3e38 = 0;
		            puVar5 = (undefined4 *)
		                     import::env::invoke_iiii
		                               (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_24,
		                                System_Collections_Generic_IEnumerator_Skin_SkinEntry__TypeInfo,0);
		            if (DAT_ram_009d3e38 == 1) {
		code_r0x809b6093:
		              DAT_ram_009d3e38 = 0;
		              uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		              goto code_r0x809b60af;
		            }
		code_r0x809b5efa:
		            DAT_ram_009d3e38 = 0;
		            import::env::invoke_viii(*puVar5,&local_34,piVar4,puVar5[1]);
		            param4 = puStack_30;
		            iVar7 = local_34;
		            if (DAT_ram_009d3e38 == 1) goto code_r0x809b6093;
		            uVar3 = 0;
		            if (local_2c == (int *)0x0) {
		code_r0x809b6039:
		              DAT_ram_009d3e38 = 0;
		              import::env::invoke_viiiii
		                        (s_struct_Uniforms___color__array<v_ram_000013c7 + 0x2b2,param1,iVar7,param4
		                         ,uVar3,uVar3);
		              iVar7 = DAT_ram_009d3e38;
		              DAT_ram_009d3e38 = 0;
		              if (iVar7 == 1) {
		                uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                goto code_r0x809b60af;
		              }
		              goto code_r0x809b5d87;
		            }
		            iVar2 = *local_2c;
		            if (((uint)*(byte *)(iVar2 + 0xb8) <
		                 (uint)*(byte *)(Spine_MeshAttachment_TypeInfo + 0xb8)) ||
		               (*(int *)(*(int *)(iVar2 + 100) +
		                         (uint)*(byte *)(Spine_MeshAttachment_TypeInfo + 0xb8) * 4 + -4) !=
		                Spine_MeshAttachment_TypeInfo)) {
		              DAT_ram_009d3e38 = 0;
		              uVar3 = import::env::invoke_iii
		                                (*(undefined4 *)(iVar2 + 0xe0),local_2c,
		                                 *(undefined4 *)(iVar2 + 0xe4));
		              iVar2 = DAT_ram_009d3e38;
		              DAT_ram_009d3e38 = 0;
		              if (iVar2 != 1) goto code_r0x809b6039;
		              uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		              goto code_r0x809b60af;
		            }
		            DAT_ram_009d3e38 = 0;
		            uVar3 = import::env::invoke_iii
		                              (s_struct_Uniforms___color__array<v_ram_000013c7 + 0x2fe,local_2c,0);
		            iVar2 = DAT_ram_009d3e38;
		            DAT_ram_009d3e38 = 0;
		            if (iVar2 == 1) {
		              uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		              goto code_r0x809b60af;
		            }
		            DAT_ram_009d3e38 = 0;
		            import::env::invoke_viiiii
		                      (s_struct_Uniforms___color__array<v_ram_000013c7 + 0x2b2,param1,iVar7,param4,
		                       uVar3,iVar2);
		            iVar7 = DAT_ram_009d3e38;
		            DAT_ram_009d3e38 = 0;
		          } while (iVar7 != 1);
		          uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x809b60af:
		          iVar7 = global_1;
		          iVar2 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		          if (iVar7 == iVar2) {
		            piVar4 = (int *)import::env::__cxa_begin_catch(uVar3);
		            iVar7 = *piVar4;
		            DAT_ram_009d3e38 = 0;
		            local_3c = iVar7;
		            import::env::invoke_v(0x123);
		            iVar2 = DAT_ram_009d3e38;
		            DAT_ram_009d3e38 = 0;
		            if (iVar2 != 1) {
		code_r0x809b60f8:
		              piVar4 = local_24;
		              DAT_ram_009d3e38 = 0;
		              if (local_24 != (int *)0x0) {
		                uVar1 = 0;
		                iVar2 = *local_24;
		                if (*(ushort *)(iVar2 + 0xb6) != 0) {
		                  do {
		                    if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8))
		                    {
		                      puVar6 = (uint *)(iVar2 + *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8
		                                       + 0xc0);
		                      goto code_r0x809b6170;
		                    }
		                    uVar1 = uVar1 + 1;
		                  } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		                }
		                puVar6 = (uint *)func_ii_1080(local_24,System_IDisposable_TypeInfo,0);
		code_r0x809b6170:
		                (**(code **)((ulonglong)*puVar6 * 4))(piVar4,puVar6[1]);
		              }
		              if (iVar7 == 0) {
		                return;
		              }
		              System_Data_DataSet__ValidateLocaleConstraint(iVar7);
		              do {
		                halt_trap();
		              } while( true );
		            }
		            uVar3 = import::env::__cxa_find_matching_catch_2();
		          }
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_000013c7 + 0x2ff,&local_3c);
		          goto joined_r0x809b61bd;
		        }
		        uVar3 = import::env::__cxa_find_matching_catch_2();
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_000013c7 + 0x2fd,&local_34);
		      goto joined_r0x809b61bd;
		    }
		    uVar3 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_000013c7 + 0x2fc,&local_34);
		joined_r0x809b61bd:
		  if (DAT_ram_009d3e38 != 1) {
		    DAT_ram_009d3e38 = 0;
		    import::env::__resumeException(uVar3);
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


		/* --- GHIDRA: CopySkin ---
		void Spine_Skin__CopySkin(int param1,int param2,int *param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  undefined4 param3_00;
		  int iVar3;
		  undefined8 local_20;
		  longlong local_18;
		  int local_10;
		  int *local_c;
		  undefined4 local_8;
		  uint local_4;
		  
		  if (DAT_ram_00a54415 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Spine_Collections_OrderedDictionary_Skin_SkinEntry__Attachment__Remove__);
		    DAT_ram_00a54415 = '\x01';
		  }
		  if (param2 < 0) {
		    uVar1 = unnamed_function_2232(&System_ArgumentOutOfRangeException_TypeInfo);
		    uVar1 = unnamed_function_1417(uVar1);
		    uVar2 = unnamed_function_2232(&StringLiteral_27272);
		    param3_00 = unnamed_function_2232(&StringLiteral_27273);
		    System_ArgumentOutOfRangeException___ctor(uVar1,uVar2,param3_00,0);
		    uVar2 = unnamed_function_2232(&Method_Spine_Skin_RemoveAttachment__);
		    func_ii_1050(uVar1,uVar2);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param3 + 0xd0) * 4))
		                    (param3,*(undefined4 *)(*param3 + 0xd4));
		  local_8 = 0;
		  local_4 = iVar3 + param2 * 0x25;
		  local_18 = (ulonglong)local_4 << 0x20;
		  local_20 = CONCAT44(param3,param2);
		  local_10 = param2;
		  local_c = param3;
		  Spine_Collections_OrderedDictionary_Skin_SkinEntry__object___Insert
		            (*(undefined4 *)(param1 + 0xc),&local_20,
		             Method_Spine_Collections_OrderedDictionary_Skin_SkinEntry__Attachment__Remove__);
		  return;
		}
		*/


		/* --- GHIDRA: GetAttachment ---
		void Spine_Skin__GetAttachment(undefined4 param1,undefined4 param2,int param3,undefined4 param4)
		
		{
		  int iVar1;
		  undefined4 param3_00;
		  
		  if (DAT_ram_00a59cc8 == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_17151);
		    DAT_ram_00a59cc8 = '\x01';
		  }
		  if (param3 != 0) {
		    iVar1 = GAFInternal_Objects_GAFMeshManager_MeshData__set_restObjects(param3,0);
		    if (iVar1 != 0) {
		      if (*(int *)(UnityEngine_Debug_TypeInfo + 0x74) == 0) {
		        func_ii_306000(UnityEngine_Debug_TypeInfo);
		      }
		      UnityEngine_AndroidJNISafe__CallBooleanMethod(StringLiteral_17151,0);
		    }
		    param3_00 = Spine_Unity_SkeletonExtensions__GetMaterial(param3,param2,0,param3);
		    UnityEngine_PolygonCollider2D__get_points(param1,0,param3_00,0);
		  }
		  return;
		}
		*/


		/* --- GHIDRA: RemoveAttachment ---
		undefined4 Spine_Skin__RemoveAttachment(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a54416 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Spine_Collections_OrderedDictionary_Skin_SkinEntry__Attachment__get_Keys__);
		    DAT_ram_00a54416 = '\x01';
		  }
		  uVar1 = Spine_Collections_OrderedDictionary_Skin_SkinEntry__object___get_Item
		                    (*(undefined4 *)(param1 + 0xc),
		                     Method_Spine_Collections_OrderedDictionary_Skin_SkinEntry__Attachment__get_Keys__
		                    );
		  return uVar1;
		}
		*/


		/* --- GHIDRA: GetAttachments ---
		void Spine_Skin__GetAttachments(int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a54418 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Spine_ExposedList_BoneData__Clear__);
		    Mono_Security_ASN1__get_Item(&Method_Spine_ExposedList_ConstraintData__Clear__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Spine_Collections_OrderedDictionary_Skin_SkinEntry__Attachment__Clear__);
		    DAT_ram_00a54418 = '\x01';
		  }
		  Spine_Collections_OrderedDictionary_Skin_SkinEntry__object____ctor
		            (*(undefined4 *)(param1 + 0xc),
		             Method_Spine_Collections_OrderedDictionary_Skin_SkinEntry__Attachment__Clear__);
		  Spine_ExposedList___Il2CppFullySharedGenericType___CheckRange
		            (*(undefined4 *)(param1 + 0x10),1,Method_Spine_ExposedList_BoneData__Clear__);
		  Spine_ExposedList___Il2CppFullySharedGenericType___CheckRange
		            (*(undefined4 *)(param1 + 0x14),1,Method_Spine_ExposedList_ConstraintData__Clear__);
		  return;
		}
		*/


		/* --- GHIDRA: GetAttachments ---
		void Spine_Skin__GetAttachments(int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a54418 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Spine_ExposedList_BoneData__Clear__);
		    Mono_Security_ASN1__get_Item(&Method_Spine_ExposedList_ConstraintData__Clear__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Spine_Collections_OrderedDictionary_Skin_SkinEntry__Attachment__Clear__);
		    DAT_ram_00a54418 = '\x01';
		  }
		  Spine_Collections_OrderedDictionary_Skin_SkinEntry__object____ctor
		            (*(undefined4 *)(param1 + 0xc),
		             Method_Spine_Collections_OrderedDictionary_Skin_SkinEntry__Attachment__Clear__);
		  Spine_ExposedList___Il2CppFullySharedGenericType___CheckRange
		            (*(undefined4 *)(param1 + 0x10),1,Method_Spine_ExposedList_BoneData__Clear__);
		  Spine_ExposedList___Il2CppFullySharedGenericType___CheckRange
		            (*(undefined4 *)(param1 + 0x14),1,Method_Spine_ExposedList_ConstraintData__Clear__);
		  return;
		}
		*/


		/* --- GHIDRA: ToString ---
		void Spine_Skin__ToString(int param1,int param2,int param3,undefined4 param4)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  undefined4 *puVar3;
		  int iVar4;
		  int *piVar5;
		  uint *puVar6;
		  int iVar7;
		  int *piVar8;
		  undefined1 local_30 [8];
		  longlong local_28;
		  int local_20;
		  int **local_1c;
		  int *local_18;
		  int local_14;
		  int local_10;
		  int *local_c;
		  int local_8;
		  uint local_4;
		  
		  if (DAT_ram_00a54419 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerator_Skin_SkinEntry__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Spine_Collections_OrderedDictionary_KeyCollection_Skin_SkinEntry__Attachment__GetEnumerator__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Spine_Collections_OrderedDictionary_Skin_SkinEntry__Attachment__get_Keys__);
		    DAT_ram_00a54419 = '\x01';
		  }
		  uVar2 = Spine_Collections_OrderedDictionary_Skin_SkinEntry__object___get_Item
		                    (*(undefined4 *)(param3 + 0xc),
		                     Method_Spine_Collections_OrderedDictionary_Skin_SkinEntry__Attachment__get_Keys__
		                    );
		  local_18 = (int *)Spine_Collections_OrderedDictionary_KeyCollection_Skin_SkinEntry__object___CopyTo
		                              (uVar2,
		                               Method_Spine_Collections_OrderedDictionary_KeyCollection_Skin_SkinEntry__Attachment__GetEnumerator__
		                              );
		  local_20 = 0;
		  local_1c = &local_18;
		  do {
		    do {
		      do {
		        do {
		          piVar5 = local_18;
		          iVar7 = *local_18;
		          if (*(ushort *)(iVar7 + 0xb6) != 0) {
		            uVar1 = 0;
		            do {
		              piVar8 = (int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8);
		              if (System_Collections_IEnumerator_TypeInfo == *piVar8) {
		                puVar3 = (undefined4 *)(iVar7 + piVar8[1] * 8 + 0xc0);
		                goto code_r0x809b6921;
		              }
		              uVar1 = uVar1 + 1;
		            } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		          }
		          DAT_ram_009d3e38 = 0;
		          puVar3 = (undefined4 *)
		                   import::env::invoke_iiii
		                             (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_18,
		                              System_Collections_IEnumerator_TypeInfo,0);
		          if (DAT_ram_009d3e38 == 1) {
		code_r0x809b6969:
		            DAT_ram_009d3e38 = 0;
		            uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x809b6c64;
		          }
		code_r0x809b6921:
		          DAT_ram_009d3e38 = 0;
		          iVar7 = import::env::invoke_iii(*puVar3,piVar5,puVar3[1]);
		          piVar5 = local_18;
		          if (DAT_ram_009d3e38 == 1) goto code_r0x809b6969;
		          if (iVar7 == 0) {
		            iVar7 = 0;
		            goto code_r0x809b6cad;
		          }
		          iVar7 = *local_18;
		          if (*(ushort *)(iVar7 + 0xb6) != 0) {
		            uVar1 = 0;
		            do {
		              piVar8 = (int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8);
		              if (System_Collections_Generic_IEnumerator_Skin_SkinEntry__TypeInfo == *piVar8) {
		                puVar3 = (undefined4 *)(iVar7 + piVar8[1] * 8 + 0xc0);
		                goto code_r0x809b6a10;
		              }
		              uVar1 = uVar1 + 1;
		            } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		          }
		          DAT_ram_009d3e38 = 0;
		          puVar3 = (undefined4 *)
		                   import::env::invoke_iiii
		                             (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_18,
		                              System_Collections_Generic_IEnumerator_Skin_SkinEntry__TypeInfo,0);
		          if (DAT_ram_009d3e38 == 1) {
		code_r0x809b6a76:
		            DAT_ram_009d3e38 = 0;
		            uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x809b6c64;
		          }
		code_r0x809b6a10:
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_viii(*puVar3,&local_10,piVar5,puVar3[1]);
		          if (DAT_ram_009d3e38 == 1) goto code_r0x809b6a76;
		          iVar7 = *(int *)(*(int *)(*(int *)(param2 + 0x10) + 8) + local_10 * 4 + 0x10);
		        } while (*(int *)(iVar7 + 0x30) != local_8);
		        if (DAT_ram_00a54414 == '\0') {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_vi
		                    (0x7ff,&
		                           Method_Spine_Collections_OrderedDictionary_Skin_SkinEntry__Attachment__TryGetValue__
		                    );
		          if (DAT_ram_009d3e38 != 1) {
		            DAT_ram_00a54414 = '\x01';
		            goto code_r0x809b6ace;
		          }
		code_r0x809b6c5c:
		          DAT_ram_009d3e38 = 0;
		          uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x809b6c64;
		        }
		code_r0x809b6ace:
		        DAT_ram_009d3e38 = 0;
		        iVar4 = import::env::invoke_iii
		                          (*(undefined4 *)(*local_c + 0xd0),local_c,*(undefined4 *)(*local_c + 0xd4)
		                          );
		        if (DAT_ram_009d3e38 == 1) goto code_r0x809b6c5c;
		        local_14 = 0;
		        local_8 = 0;
		        local_4 = iVar4 + local_10 * 0x25;
		        local_28 = (ulonglong)local_4 << 0x20;
		        DAT_ram_009d3e38 = 0;
		        uVar1 = import::env::invoke_iiiii
		                          (s_struct_Uniforms___color__array<v_ram_000013c7 + 0x2e9,
		                           *(undefined4 *)(param1 + 0xc),local_30,&local_14,
		                           Method_Spine_Collections_OrderedDictionary_Skin_SkinEntry__Attachment__TryGetValue__
		                          );
		        iVar4 = local_14;
		        if (DAT_ram_009d3e38 == 1) goto code_r0x809b6c5c;
		      } while ((uVar1 & local_14 != 0) == 0);
		      if (DAT_ram_00a54421 == '\0') {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vi(0x7ff,&Method_Spine_ExposedList_float__Clear__);
		        if (DAT_ram_009d3e38 == 1) goto code_r0x809b6c52;
		        DAT_ram_00a54421 = '\x01';
		      }
		    } while (*(int *)(iVar7 + 0x30) == iVar4);
		    *(int *)(iVar7 + 0x30) = iVar4;
		    *(undefined4 *)(iVar7 + 0x34) = *(undefined4 *)(*(int *)(*(int *)(iVar7 + 0xc) + 0xc) + 0x40);
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_000013c7 + 0x301,*(undefined4 *)(iVar7 + 0x38)
		               ,0,Method_Spine_ExposedList_float__Clear__);
		  } while (DAT_ram_009d3e38 != 1);
		code_r0x809b6c52:
		  DAT_ram_009d3e38 = 0;
		  uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x809b6c64:
		  iVar7 = global_1;
		  iVar4 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar7 == iVar4) {
		    piVar5 = (int *)import::env::__cxa_begin_catch(uVar2);
		    iVar7 = *piVar5;
		    DAT_ram_009d3e38 = 0;
		    local_20 = iVar7;
		    import::env::invoke_v(0x123);
		    iVar4 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar4 != 1) {
		code_r0x809b6cad:
		      piVar5 = local_18;
		      DAT_ram_009d3e38 = 0;
		      if (local_18 != (int *)0x0) {
		        uVar1 = 0;
		        iVar4 = *local_18;
		        if (*(ushort *)(iVar4 + 0xb6) != 0) {
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		              puVar6 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0)
		              ;
		              goto code_r0x809b6d25;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		        }
		        puVar6 = (uint *)func_ii_1080(local_18,System_IDisposable_TypeInfo,0);
		code_r0x809b6d25:
		        (**(code **)((ulonglong)*puVar6 * 4))(piVar5,puVar6[1]);
		      }
		      if (iVar7 == 0) {
		        return;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(iVar7);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar2 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_000013c7 + 0x302,&local_20);
		  iVar7 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar7 == 1) {
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  import::env::__resumeException(uVar2);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

}
