using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Test
{
	// Token: 0x02000E47 RID: 3655
	[Token(Token = "0x2000E47")]
	public class PointerClickTest : MonoBehaviour, IPointerClickHandler, IEventSystemHandler
	{
		// Token: 0x06005997 RID: 22935 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005997")]
		[Address(RVA = "0xA6C3", Offset = "0xA6C3", VA = "0xA6C3")]
		private void Awake()
		{
		/* --- GHIDRA: Awake ---
		void Test_PointerClickTest__Awake(undefined4 param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a63c2c == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_GameObject_AddComponent_PolygonCollider2D___);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_GameObject_GetComponent_PolygonCollider2D___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2928);
		    Mono_Security_ASN1__get_Item(&StringLiteral_13483);
		    DAT_ram_00a63c2c = '\x01';
		  }
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (param1,0);
		  uVar1 = func_ii_6601(uVar1,Method_UnityEngine_GameObject_GetComponent_PolygonCollider2D___);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar2 = UnityEngine_TextCore_Text_TextElement__get_textAsset(uVar1,0,0);
		  if (iVar2 != 0) {
		    uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (param1,0);
		    uVar1 = func_ii_6601(uVar1,Method_UnityEngine_GameObject_GetComponent_PolygonCollider2D___);
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      func_ii_306000(UnityEngine_Object_TypeInfo);
		    }
		    UnityEngine_Application__get_isPlaying(uVar1,0);
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    System_Collections_Generic_Dictionary_uint__object___get_Count(StringLiteral_13483,0);
		  }
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (param1,0);
		  UnityEngine_GameObject__GetComponent_object_
		            (uVar1,Method_UnityEngine_GameObject_AddComponent_PolygonCollider2D___);
		  if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		    func_ii_306000(OKG_Logs_Debug_TypeInfo);
		  }
		  System_Collections_Generic_Dictionary_uint__object___get_Count(StringLiteral_2928,0);
		  return;
		}
		*/

		}

		// Token: 0x06005998 RID: 22936 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005998")]
		[Address(RVA = "0xA6C4", Offset = "0xA6C4", VA = "0xA6C4")]
		public void UpdateArea()
		{
		/* --- GHIDRA: UpdateArea ---
		void Test_PointerClickTest__UpdateArea(undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a63c2d == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_21221);
		    DAT_ram_00a63c2d = '\x01';
		  }
		  if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		    func_ii_306000(OKG_Logs_Debug_TypeInfo);
		  }
		  System_Collections_Generic_Dictionary_uint__object___get_Count(StringLiteral_21221,0);
		  return;
		}
		*/

		}

		// Token: 0x06005999 RID: 22937 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005999")]
		[Address(RVA = "0xA6C5", Offset = "0xA6C5", VA = "0xA6C5", Slot = "4")]
		public void OnPointerClick(PointerEventData eventData)
		{
		/* --- GHIDRA: OnPointerClick ---
		void Test_PointerClickTest__OnPointerClick(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a63c2e == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_11889);
		    DAT_ram_00a63c2e = '\x01';
		  }
		  if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		    func_ii_306000(OKG_Logs_Debug_TypeInfo);
		  }
		  System_Collections_Generic_Dictionary_uint__object___get_Count(StringLiteral_11889,0);
		  return;
		}
		*/

		}

		// Token: 0x0600599A RID: 22938 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600599A")]
		[Address(RVA = "0xA6C6", Offset = "0xA6C6", VA = "0xA6C6")]
		private void OnMouseDown()
		{
		}

		// Token: 0x0600599B RID: 22939 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600599B")]
		[Address(RVA = "0xA6C7", Offset = "0xA6C7", VA = "0xA6C7")]
		public PointerClickTest()
		{
		/* --- GHIDRA: .ctor ---
		void Test_PointerClickTest___ctor(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a63c2f == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_Camera___);
		    DAT_ram_00a63c2f = '\x01';
		  }
		  uVar1 = func_ii_5677(param1,Method_UnityEngine_Component_GetComponent_Camera___);
		  *(undefined4 *)(param1 + 0x4c) = uVar1;
		  return;
		}
		*/

		}
	}
}
