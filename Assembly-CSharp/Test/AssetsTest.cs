using System;
using System.Collections;
using System.Collections.Generic;
using AssetContent.Loaders;
using Il2CppDummyDll;
using UnityEngine;

namespace Test
{
	// Token: 0x02000E45 RID: 3653
	[Token(Token = "0x2000E45")]
	public class AssetsTest : MonoBehaviour
	{
		// Token: 0x0600598E RID: 22926 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600598E")]
		[Address(RVA = "0xA6BA", Offset = "0xA6BA", VA = "0xA6BA")]
		public void StartTest()
		{
		/* --- GHIDRA: StartTest ---
		int Test_AssetsTest__StartTest(undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a63c29 == '\0') {
		    Mono_Security_ASN1__get_Item(&Test_AssetsTest__ChangeCoroutine_d__4_TypeInfo);
		    DAT_ram_00a63c29 = '\x01';
		  }
		  iVar1 = unnamed_function_1417(Test_AssetsTest__ChangeCoroutine_d__4_TypeInfo);
		  *(undefined4 *)(iVar1 + 0x10) = param1;
		  *(undefined4 *)(iVar1 + 8) = 0;
		  return iVar1;
		}
		*/

		}

		// Token: 0x0600598F RID: 22927 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600598F")]
		[Address(RVA = "0xA6BB", Offset = "0xA6BB", VA = "0xA6BB")]
		private IEnumerator ChangeCoroutine()
		{
		/* --- GHIDRA: ChangeCoroutine ---
		void Test_AssetsTest__ChangeCoroutine(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a63c2a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_GameRawImageLoader___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_GameRawImageLoader__TypeInfo);
		    DAT_ram_00a63c2a = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_Collections_Generic_List_GameRawImageLoader__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_00,Method_System_Collections_Generic_List_GameRawImageLoader___ctor__);
		  *(undefined4 *)(param1 + 0x18) = param1_00;
		  UnityEngine_RectTransform__GetParentSize(param1,0);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06005990 RID: 22928 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005990")]
		[Address(RVA = "0xA6BC", Offset = "0xA6BC", VA = "0xA6BC")]
		public AssetsTest()
		{
		}

		// Token: 0x04003053 RID: 12371
		[Token(Token = "0x4003053")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private GameObject _prefab;

		// Token: 0x04003054 RID: 12372
		[Token(Token = "0x4003054")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Transform _container;

		// Token: 0x04003055 RID: 12373
		[Token(Token = "0x4003055")]
		[FieldOffset(Offset = "0x18")]
		private List<GameRawImageLoader> _loaders;
	}
}
