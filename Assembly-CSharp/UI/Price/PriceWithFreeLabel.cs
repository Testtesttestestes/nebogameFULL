using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace UI.Price
{
	// Token: 0x020001C1 RID: 449
	[Token(Token = "0x20001C1")]
	public class PriceWithFreeLabel : Price
	{
		// Token: 0x06000BFF RID: 3071 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BFF")]
		[Address(RVA = "0x5F12", Offset = "0x5F12", VA = "0x5F12", Slot = "4")]
		protected override void Awake()
		{
		/* --- GHIDRA: Awake ---
		void UI_Price_PriceWithFreeLabel__Awake(int param1,undefined4 param2)
		
		{
		  undefined4 param2_00;
		  undefined4 param1_00;
		  int iVar1;
		  undefined4 param1_01;
		  
		  param2_00 = 0;
		  if (DAT_ram_00a638ea == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_TypeInfo);
		    DAT_ram_00a638ea = '\x01';
		  }
		  UI_Price_Price__HandleSourceChanged(param1,0);
		  param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(param1 + 0x34),0);
		  if (*(char *)(param1 + 0x38) != '\0') {
		    param1_01 = *(undefined4 *)(param1 + 0x28);
		    if (*(int *)(Core_Money_Money_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Money_Money_TypeInfo);
		    }
		    param2_00 = 1;
		    iVar1 = Core_Money_Money__op_Inequality(param1_01,0,0);
		    if (iVar1 == 0) {
		      param2_00 = Core_Money_Money__op_Multiply(*(undefined4 *)(param1 + 0x28),0);
		    }
		  }
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (param1_00,param2_00,0);
		  return;
		}
		*/

		}

		// Token: 0x06000C00 RID: 3072 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C00")]
		[Address(RVA = "0x5F13", Offset = "0x5F13", VA = "0x5F13", Slot = "5")]
		protected override void HandleResourceSetChanged()
		{
		/* --- GHIDRA: HandleResourceSetChanged ---
		void UI_Price_PriceWithFreeLabel__HandleResourceSetChanged(int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a638eb == '\0') {
		    Mono_Security_ASN1__get_Item(&UI_Price_Price_TypeInfo);
		    DAT_ram_00a638eb = '\x01';
		  }
		  *(undefined1 *)(param1 + 0x38) = 1;
		  if (*(int *)(UI_Price_Price_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UI_Price_Price_TypeInfo);
		  }
		  UI_Price_Price__HidePrices(param1,0);
		  return;
		}
		*/

		}

		// Token: 0x06000C01 RID: 3073 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C01")]
		[Address(RVA = "0x5F14", Offset = "0x5F14", VA = "0x5F14")]
		public PriceWithFreeLabel()
		{
		/* --- GHIDRA: .ctor ---
		int UI_Price_PriceWithFreeLabel___ctor(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  int *param1_00;
		  undefined4 uVar2;
		  undefined4 *puVar3;
		  int iVar4;
		  undefined4 uVar5;
		  int iVar6;
		  
		  if (DAT_ram_00a638ec == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_Money_MoneyType__Money__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_Money_MoneyType__Money__get_Values__);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_SelectMany_List_Money___Money___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Select_Money_MoneyType__Money___);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_ToDictionary_Money__Money_MoneyType___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToList_Money___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Where_Money___);
		    Mono_Security_ASN1__get_Item(&System_Func_Money_MoneyType__Money__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Func_Money__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Func_List_Money___IEnumerable_Money___TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Func_Money__Money_MoneyType__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_Money____TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Money__get_Count__);
		    Mono_Security_ASN1__get_Item(&UI_Price_Price_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Price_PriceWithZeroResources___c__GetGameResources_b__0_0__);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Price_PriceWithZeroResources___c__GetGameResources_b__0_3__);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Price_PriceWithZeroResources___c__DisplayClass0_0__GetGameResources_b__1__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Price_PriceWithZeroResources___c__DisplayClass0_0__GetGameResources_b__2__
		              );
		    Mono_Security_ASN1__get_Item(&UI_Price_PriceWithZeroResources___c__DisplayClass0_0_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UI_Price_PriceWithZeroResources___c_TypeInfo);
		    DAT_ram_00a638ec = '\x01';
		  }
		  iVar1 = unnamed_function_1417(UI_Price_PriceWithZeroResources___c__DisplayClass0_0_TypeInfo);
		  uVar2 = *(undefined4 *)(param1 + 0x28);
		  if (*(int *)(UI_Price_PriceWithZeroResources___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UI_Price_PriceWithZeroResources___c_TypeInfo);
		  }
		  puVar3 = *(undefined4 **)(UI_Price_PriceWithZeroResources___c_TypeInfo + 0x5c);
		  iVar4 = puVar3[1];
		  if (iVar4 == 0) {
		    if (*(int *)(UI_Price_PriceWithZeroResources___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(UI_Price_PriceWithZeroResources___c_TypeInfo);
		      puVar3 = *(undefined4 **)(UI_Price_PriceWithZeroResources___c_TypeInfo + 0x5c);
		    }
		    uVar5 = *puVar3;
		    iVar4 = unnamed_function_1417(System_Func_Money__Money_MoneyType__TypeInfo);
		    System_Linq_Enumerable__Where_object_
		              (iVar4,uVar5,Method_UI_Price_PriceWithZeroResources___c__GetGameResources_b__0_0__,0);
		    *(int *)(*(int *)(UI_Price_PriceWithZeroResources___c_TypeInfo + 0x5c) + 4) = iVar4;
		  }
		  uVar2 = System_Linq_Enumerable__ToDictionary_object__Int32Enum_
		                    (uVar2,iVar4,
		                     Method_System_Linq_Enumerable_ToDictionary_Money__Money_MoneyType___);
		  *(undefined4 *)(iVar1 + 8) = uVar2;
		  if (*(int *)(UI_Price_Price_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UI_Price_Price_TypeInfo);
		  }
		  uVar5 = **(undefined4 **)(UI_Price_Price_TypeInfo + 0x5c);
		  uVar2 = unnamed_function_1417(System_Func_Money_MoneyType__Money__TypeInfo);
		  System_Linq_Enumerable__Where_object_
		            (uVar2,iVar1,
		             Method_UI_Price_PriceWithZeroResources___c__DisplayClass0_0__GetGameResources_b__1__,0)
		  ;
		  uVar2 = System_Linq_Enumerable__ReverseIterator___Il2CppFullySharedGenericType_
		                    (uVar5,uVar2,Method_System_Linq_Enumerable_Select_Money_MoneyType__Money___);
		  uVar2 = System_Linq_Enumerable__Select_object__object_
		                    (uVar2,Method_System_Linq_Enumerable_ToList_Money___);
		  *(undefined4 *)(iVar1 + 0xc) = uVar2;
		  iVar4 = System_Collections_Generic_HashSet_Enumerator_object___Dispose
		                    (*(undefined4 *)(iVar1 + 8),
		                     Method_System_Collections_Generic_Dictionary_Money_MoneyType__Money__get_Count__
		                    );
		  iVar6 = *(int *)(iVar1 + 0xc);
		  if (*(int *)(iVar6 + 0xc) < iVar4) {
		    uVar2 = System_Collections_Generic_Dictionary_int__object___TryAdd
		                      (*(undefined4 *)(iVar1 + 8),
		                       Method_System_Collections_Generic_Dictionary_Money_MoneyType__Money__get_Values__
		                      );
		    uVar5 = unnamed_function_1417(System_Func_Money__bool__TypeInfo);
		    System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		              (uVar5,iVar1,
		               Method_UI_Price_PriceWithZeroResources___c__DisplayClass0_0__GetGameResources_b__2__,
		               0);
		    uVar2 = System_Linq_Enumerable__Where_PlayerLoopSystem_
		                      (uVar2,uVar5,Method_System_Linq_Enumerable_Where_Money___);
		    iVar4 = System_Linq_Enumerable__Select_object__object_
		                      (uVar2,Method_System_Linq_Enumerable_ToList_Money___);
		    param1_00 = (int *)Mono_Security_ASN1Convert__ToOid
		                                 (System_Collections_Generic_List_Money____TypeInfo,2);
		    iVar1 = *(int *)(iVar1 + 0xc);
		    if ((iVar1 != 0) && (iVar6 = func_ii_1082(iVar1,*(undefined4 *)(*param1_00 + 0x20)), iVar6 == 0)
		       ) {
		      uVar2 = func_ii_1083();
		      func_ii_1050(uVar2,0);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    param1_00[4] = iVar1;
		    if ((iVar4 != 0) && (iVar1 = func_ii_1082(iVar4,*(undefined4 *)(*param1_00 + 0x20)), iVar1 == 0)
		       ) {
		      uVar2 = func_ii_1083();
		      func_ii_1050(uVar2,0);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    param1_00[5] = iVar4;
		    if (*(int *)(UI_Price_PriceWithZeroResources___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(UI_Price_PriceWithZeroResources___c_TypeInfo);
		    }
		    puVar3 = *(undefined4 **)(UI_Price_PriceWithZeroResources___c_TypeInfo + 0x5c);
		    iVar1 = puVar3[2];
		    if (iVar1 == 0) {
		      if (*(int *)(UI_Price_PriceWithZeroResources___c_TypeInfo + 0x74) == 0) {
		        func_ii_306000(UI_Price_PriceWithZeroResources___c_TypeInfo);
		        puVar3 = *(undefined4 **)(UI_Price_PriceWithZeroResources___c_TypeInfo + 0x5c);
		      }
		      uVar2 = *puVar3;
		      iVar1 = unnamed_function_1417(System_Func_List_Money___IEnumerable_Money___TypeInfo);
		      System_Linq_Enumerable__Where_object_
		                (iVar1,uVar2,Method_UI_Price_PriceWithZeroResources___c__GetGameResources_b__0_3__,0
		                );
		      *(int *)(*(int *)(UI_Price_PriceWithZeroResources___c_TypeInfo + 0x5c) + 8) = iVar1;
		    }
		    uVar2 = System_Linq_Enumerable__SelectMany_ValueTuple_object__object___object_
		                      (param1_00,iVar1,
		                       Method_System_Linq_Enumerable_SelectMany_List_Money___Money___);
		    iVar6 = System_Linq_Enumerable__Select_object__object_
		                      (uVar2,Method_System_Linq_Enumerable_ToList_Money___);
		  }
		  return iVar6;
		}
		*/

		}

		// Token: 0x0400059B RID: 1435
		[Token(Token = "0x400059B")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private TextMeshProUGUI _freeLabel;

		// Token: 0x0400059C RID: 1436
		[Token(Token = "0x400059C")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private bool _showFreeLabel;
	}
}
