using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace UI.Elements
{
	// Token: 0x020001F4 RID: 500
	[Token(Token = "0x20001F4")]
	public class MultilineTextList : MonoBehaviour
	{
		// Token: 0x06000CDD RID: 3293 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CDD")]
		[Address(RVA = "0x5FD7", Offset = "0x5FD7", VA = "0x5FD7")]
		public void ChangeLine(int lineIndex, string text, Color color)
		{
		/* --- GHIDRA: ChangeLine ---
		void UI_Elements_MultilineTextList__ChangeLine
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a6394f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_TextMeshProUGUI__get_Item__);
		    DAT_ram_00a6394f = '\x01';
		  }
		  uVar1 = System_Linq_Enumerable__ToList_object_
		                    (*(undefined4 *)(param1 + 0x10),param2,
		                     Method_System_Collections_Generic_List_TextMeshProUGUI__get_Item__);
		  uVar1 = TMPro_TMP_Text__set_isUsingLegacyAnimationComponent(uVar1,0);
		  uVar1 = UnityEngine_Transform__set_parent(uVar1,0);
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (uVar1,0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,param3,0);
		  return;
		}
		*/

		/* --- GHIDRA: ChangeLine ---
		void UI_Elements_MultilineTextList__ChangeLine
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a6394f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_TextMeshProUGUI__get_Item__);
		    DAT_ram_00a6394f = '\x01';
		  }
		  uVar1 = System_Linq_Enumerable__ToList_object_
		                    (*(undefined4 *)(param1 + 0x10),param2,
		                     Method_System_Collections_Generic_List_TextMeshProUGUI__get_Item__);
		  uVar1 = TMPro_TMP_Text__set_isUsingLegacyAnimationComponent(uVar1,0);
		  uVar1 = UnityEngine_Transform__set_parent(uVar1,0);
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (uVar1,0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,param3,0);
		  return;
		}
		*/

		}

		// Token: 0x06000CDE RID: 3294 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CDE")]
		[Address(RVA = "0x5FD8", Offset = "0x5FD8", VA = "0x5FD8")]
		public void ChangeLine(int lineIndex, string text)
		{
		}

		// Token: 0x06000CDF RID: 3295 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CDF")]
		[Address(RVA = "0x5FD9", Offset = "0x5FD9", VA = "0x5FD9")]
		public void SetLineActive(int lineIndex, bool enable)
		{
		/* --- GHIDRA: SetLineActive ---
		void UI_Elements_MultilineTextList__SetLineActive(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a63950 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_TextMeshProUGUI___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_TextMeshProUGUI__TypeInfo);
		    DAT_ram_00a63950 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_Collections_Generic_List_TextMeshProUGUI__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_00,Method_System_Collections_Generic_List_TextMeshProUGUI___ctor__);
		  *(undefined4 *)(param1 + 0x10) = param1_00;
		  UnityEngine_RectTransform__GetParentSize(param1,0);
		  return;
		}
		*/

		}

		// Token: 0x06000CE0 RID: 3296 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CE0")]
		[Address(RVA = "0x5FDA", Offset = "0x5FDA", VA = "0x5FDA")]
		public MultilineTextList()
		{
		/* --- GHIDRA: .ctor ---
		void UI_Elements_MultilineTextList___ctor(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a63951 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ShopItem__TypeInfo);
		    DAT_ram_00a63951 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x38);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_ShopItem__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ShopItem__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x38,iVar2,param1_00);
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

		// Token: 0x0400064E RID: 1614
		[Token(Token = "0x400064E")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private List<TextMeshProUGUI> _instances;
	}
}
