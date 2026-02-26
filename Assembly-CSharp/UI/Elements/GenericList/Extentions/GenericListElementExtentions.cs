using System;
using Il2CppDummyDll;

namespace UI.Elements.GenericList.Extentions
{
	// Token: 0x02000231 RID: 561
	[Token(Token = "0x2000231")]
	public static class GenericListElementExtentions
	{
		// Token: 0x06000DED RID: 3565 RVA: 0x00004188 File Offset: 0x00002388
		[Token(Token = "0x6000DED")]
		public static bool HasThisData<TElementArgs>(this GenericListElement<TElementArgs> element, TElementArgs data) where TElementArgs : GenericListElementArgs
		{
			return default(bool);
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: HasThisData<object> ---
		void UI_Elements_GenericList_Extentions_GenericListElementExtentions__HasThisData_object_
		               (undefined4 param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  int *param1_00;
		  uint *puVar3;
		  
		  if (DAT_ram_00a64b1b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_IGroupBoxOption__IGroupManager__ContainsKey__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_IGroupBoxOption__IGroupManager__get_Item__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_UIElements_GroupBoxUtility_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_UIElements_IGroupManager_TypeInfo);
		    DAT_ram_00a64b1b = '\x01';
		  }
		  if (*(int *)(UnityEngine_UIElements_GroupBoxUtility_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_UIElements_GroupBoxUtility_TypeInfo);
		  }
		  iVar2 = System_Xml_Schema_SchemaInfo__get_Notations
		                    (*(undefined4 *)
		                      (*(int *)(UnityEngine_UIElements_GroupBoxUtility_TypeInfo + 0x5c) + 4),param1,
		                     Method_System_Collections_Generic_Dictionary_IGroupBoxOption__IGroupManager__ContainsKey__
		                    );
		  if (iVar2 != 0) {
		    uVar1 = 0;
		    if (*(int *)(UnityEngine_UIElements_GroupBoxUtility_TypeInfo + 0x74) == 0) {
		      func_ii_306000(UnityEngine_UIElements_GroupBoxUtility_TypeInfo);
		    }
		    param1_00 = (int *)System_Data_DataRelationCollection__Add
		                                 (*(undefined4 *)
		                                   (*(int *)(UnityEngine_UIElements_GroupBoxUtility_TypeInfo + 0x5c)
		                                   + 4),param1,
		                                  Method_System_Collections_Generic_Dictionary_IGroupBoxOption__IGroupManager__get_Item__
		                                 );
		    iVar2 = *param1_00;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      do {
		        if (UnityEngine_UIElements_IGroupManager_TypeInfo ==
		            *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 200);
		          goto code_r0x82631319;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(param1_00,UnityEngine_UIElements_IGroupManager_TypeInfo,1);
		code_r0x82631319:
		    (**(code **)((ulonglong)*puVar3 * 4))(param1_00,param1,puVar3[1]);
		  }
		  return;
		}
		*/

}
