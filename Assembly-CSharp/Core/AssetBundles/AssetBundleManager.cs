using System;
using System.Collections.Generic;
using Core.AssetBundles.WebGL;
using Il2CppDummyDll;
using UnityEngine;

namespace Core.AssetBundles
{
	// Token: 0x02001113 RID: 4371
	[Token(Token = "0x2001113")]
	public static class AssetBundleManager
	{
		// Token: 0x060065F7 RID: 26103 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065F7")]
		[Address(RVA = "0xB17D", Offset = "0xB17D", VA = "0xB17D")]
		public static void LoadAssetBundle(string url, Action<AssetBundle> successCallback, Action failCallback, bool cacheOnDevice)
		{
		/* --- GHIDRA: LoadAssetBundle ---
		void Core_AssetBundles_AssetBundleManager__LoadAssetBundle(undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  int *piVar2;
		  
		  if (DAT_ram_00a5a8f3 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_string__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_AssetBundles_AssetBundleManager_DisposeCompleteEventHandler__);
		    Mono_Security_ASN1__get_Item(&Core_AssetBundles_AssetBundleManager_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_string__AssetBundleLoader__ContainsKey__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__AssetBundleLoader__get_Item__);
		    DAT_ram_00a5a8f3 = '\x01';
		  }
		  if (*(int *)(Core_AssetBundles_AssetBundleManager_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_AssetBundles_AssetBundleManager_TypeInfo);
		  }
		  iVar1 = System_Xml_Schema_SchemaInfo__get_Notations
		                    (**(undefined4 **)(Core_AssetBundles_AssetBundleManager_TypeInfo + 0x5c),param1,
		                     Method_System_Collections_Generic_Dictionary_string__AssetBundleLoader__ContainsKey__
		                    );
		  if (iVar1 != 0) {
		    if (*(int *)(Core_AssetBundles_AssetBundleManager_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_AssetBundles_AssetBundleManager_TypeInfo);
		    }
		    iVar1 = System_Data_DataRelationCollection__Add
		                      (**(undefined4 **)(Core_AssetBundles_AssetBundleManager_TypeInfo + 0x5c),
		                       param1,
		                       Method_System_Collections_Generic_Dictionary_string__AssetBundleLoader__get_Item__
		                      );
		    *(int *)(iVar1 + 0x20) = *(int *)(iVar1 + 0x20) + -1;
		    iVar1 = System_Data_DataRelationCollection__Add
		                      (**(undefined4 **)(Core_AssetBundles_AssetBundleManager_TypeInfo + 0x5c),
		                       param1,
		                       Method_System_Collections_Generic_Dictionary_string__AssetBundleLoader__get_Item__
		                      );
		    if (*(int *)(iVar1 + 0x20) == 0) {
		      if (*(int *)(Core_AssetBundles_AssetBundleManager_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_AssetBundles_AssetBundleManager_TypeInfo);
		      }
		      piVar2 = (int *)System_Data_DataRelationCollection__Add
		                                (**(undefined4 **)
		                                   (Core_AssetBundles_AssetBundleManager_TypeInfo + 0x5c),param1,
		                                 Method_System_Collections_Generic_Dictionary_string__AssetBundleLoader__get_Item__
		                                );
		      iVar1 = unnamed_function_1417(System_Action_string__TypeInfo);
		      UnityEngine_UIElements_VisualElement__get_layout
		                (iVar1,0,Method_Core_AssetBundles_AssetBundleManager_DisposeCompleteEventHandler__,0
		                );
		      *(undefined1 *)((int)piVar2 + 0x32) = 1;
		      piVar2[7] = iVar1;
		      if (*(char *)((int)piVar2 + 0x31) == '\0') {
		        (**(code **)((ulonglong)*(uint *)(*piVar2 + 0xf8) * 4))
		                  (piVar2,*(undefined4 *)(*piVar2 + 0xfc));
		      }
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x060065F8 RID: 26104 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065F8")]
		[Address(RVA = "0xB17E", Offset = "0xB17E", VA = "0xB17E")]
		public static void ReleaseAssetBundle(string url)
		{
		/* --- GHIDRA: ReleaseAssetBundle ---
		void Core_AssetBundles_AssetBundleManager__ReleaseAssetBundle(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5a8f4 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_AssetBundles_AssetBundleManager_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__AssetBundleLoader__Remove__);
		    DAT_ram_00a5a8f4 = '\x01';
		  }
		  if (*(int *)(Core_AssetBundles_AssetBundleManager_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_AssetBundles_AssetBundleManager_TypeInfo);
		  }
		  System_Linq_Enumerable__First_KeyValuePair_object__object__
		            (**(undefined4 **)(Core_AssetBundles_AssetBundleManager_TypeInfo + 0x5c),param1,
		             Method_System_Collections_Generic_Dictionary_string__AssetBundleLoader__Remove__);
		  return;
		}
		*/

		}

		// Token: 0x060065F9 RID: 26105 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065F9")]
		[Address(RVA = "0xB17F", Offset = "0xB17F", VA = "0xB17F")]
		private static void DisposeCompleteEventHandler(string url)
		{
		/* --- GHIDRA: DisposeCompleteEventHandler ---
		void Core_AssetBundles_AssetBundleManager__DisposeCompleteEventHandler(undefined4 param1)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5a8f5 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_AssetBundles_AssetBundleManager_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__AssetBundleLoader___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_Dictionary_string__AssetBundleLoader__TypeInfo);
		    DAT_ram_00a5a8f5 = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (System_Collections_Generic_Dictionary_string__AssetBundleLoader__TypeInfo);
		  System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		            (param1_00,
		             Method_System_Collections_Generic_Dictionary_string__AssetBundleLoader___ctor__);
		  **(undefined4 **)(Core_AssetBundles_AssetBundleManager_TypeInfo + 0x5c) = param1_00;
		  return;
		}
		*/

		}

		// Token: 0x04003689 RID: 13961
		[Token(Token = "0x4003689")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Dictionary<string, AssetBundleLoader> _storage;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: .cctor ---
		void Core_AssetBundles_AssetBundleManager___cctor
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5,undefined4 param6)
		
		{
		  if (DAT_ram_00a5a8f7 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_19810);
		    DAT_ram_00a5a8f7 = '\x01';
		  }
		  Core_AssetBundles_AbstractAssetBundleLoader__DontDisposeOnLoad
		            (param1,param2,param3,StringLiteral_19810,param4,param5,param5);
		  return;
		}
		*/

}
