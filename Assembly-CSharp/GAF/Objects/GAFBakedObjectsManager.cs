using System;
using GAFInternal.Objects;
using Il2CppDummyDll;
using UnityEngine;

namespace GAF.Objects
{
	// Token: 0x020013DE RID: 5086
	[Token(Token = "0x20013DE")]
	[AddComponentMenu("")]
	[ExecuteInEditMode]
	[DisallowMultipleComponent]
	[Serializable]
	public class GAFBakedObjectsManager : GAFBakedObjectsManagerInternal<GAFBakedObject>
	{
		// Token: 0x06007974 RID: 31092 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007974")]
		[Address(RVA = "0xC253", Offset = "0xC253", VA = "0xC253", Slot = "8")]
		public override void reload()
		{
		/* --- GHIDRA: reload ---
		void GAF_Objects_GAFBakedObjectsManager__reload(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  int *piVar2;
		  int iVar3;
		  undefined1 auStack_20 [8];
		  int local_18;
		  undefined8 *local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a54ea4 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_GAFBakedObject__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_GAFBakedObject__MoveNext__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_GAFBakedObject__get_Current__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_GAFInternal_Objects_GAFBakedObjectsManagerInternal_GAFBakedObject__deepClear__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_GAFBakedObject__GetEnumerator__);
		    DAT_ram_00a54ea4 = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		            (&local_10,*(undefined4 *)(param1 + 0x28),
		             Method_System_Collections_Generic_List_GAFBakedObject__GetEnumerator__);
		  local_18 = 0;
		  local_14 = &local_10;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar1 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_10,
		                       Method_System_Collections_Generic_List_Enumerator_GAFBakedObject__MoveNext__)
		    ;
		    iVar3 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar3 == 1) {
		      param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80b2db6d;
		    }
		    iVar3 = local_18;
		    if (iVar1 == 0) goto code_r0x80b2dbb6;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_vii
		              (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x146,local_8._4_4_,auStack_20);
		    iVar3 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		  } while (iVar3 != 1);
		  param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80b2db6d:
		  iVar3 = global_1;
		  iVar1 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar3 == iVar1) {
		    piVar2 = (int *)import::env::__cxa_begin_catch(param1_00);
		    iVar3 = *piVar2;
		    DAT_ram_009d3e38 = 0;
		    local_18 = iVar3;
		    import::env::invoke_v(0x123);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 != 1) {
		code_r0x80b2dbb6:
		      DAT_ram_009d3e38 = 0;
		      if (iVar3 == 0) {
		        System_Xml_XmlNodeList__get_ItemOf
		                  (param1,
		                   Method_GAFInternal_Objects_GAFBakedObjectsManagerInternal_GAFBakedObject__deepClear__
		                  );
		        return;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(iVar3);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    param1_00 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_000017c8 + 0x147,&local_18);
		  iVar3 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar3 == 1) {
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  import::env::__resumeException(param1_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06007975 RID: 31093 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007975")]
		[Address(RVA = "0xC254", Offset = "0xC254", VA = "0xC254", Slot = "11")]
		public override void deepClear()
		{
		/* --- GHIDRA: deepClear ---
		void GAF_Objects_GAFBakedObjectsManager__deepClear(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a54ea5 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_GAFInternal_Objects_GAFBakedObjectsManagerInternal_GAFBakedObject___ctor__);
		    DAT_ram_00a54ea5 = '\x01';
		  }
		  Google_Future___Il2CppFullySharedGenericType___get_Status
		            (param1,
		             Method_GAFInternal_Objects_GAFBakedObjectsManagerInternal_GAFBakedObject___ctor__);
		  return;
		}
		*/

		}

		// Token: 0x06007976 RID: 31094 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007976")]
		[Address(RVA = "0xC255", Offset = "0xC255", VA = "0xC255")]
		public GAFBakedObjectsManager()
		{
		/* --- GHIDRA: .ctor ---
		void GAF_Objects_GAFBakedObjectsManager___ctor(undefined4 param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = GAFInternal_Core_GAFBehaviour__get_cachedTransform(param1,0);
		  UnityEngine_MaterialPropertyBlock_BindingsMarshaller__ConvertToNative(uVar1,0,0);
		  uVar1 = GAFInternal_Core_GAFBehaviour__get_cachedTransform(param1,0);
		  UnityEngine_Renderer__get_reflectionProbeUsage(uVar1,0,0);
		  uVar1 = GAFInternal_Core_GAFBehaviour__get_cachedTransform(param1,0);
		  UnityEngine_Renderer__get_shadowCastingMode(uVar1,0,0);
		  uVar1 = GAFInternal_Core_GAFBehaviour__get_cachedTransform(param1,0);
		  UnityEngine_Renderer__get_receiveShadows(uVar1,0,0);
		  GAFInternal_Objects_GAFObjectInternal__initialize(param1,0);
		  return;
		}
		*/

		}
	}
}
