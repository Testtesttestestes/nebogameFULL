using System;
using System.Runtime.CompilerServices;
using Gameplay.Market.Model.Data;
using Il2CppDummyDll;
using Protocol.Dic;
using UI.Filters;

namespace Gameplay.Market.Controller.Filters
{
	// Token: 0x02000638 RID: 1592
	[Token(Token = "0x2000638")]
	public class MarketMetaFilter : IMarketFilter
	{
		// Token: 0x1700073E RID: 1854
		// (get) Token: 0x060026B1 RID: 9905 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060026B2 RID: 9906 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700073E")]
		public FilterInfo FilterInfo
		{
			[Token(Token = "0x60026B1")]
			[Address(RVA = "0x77E6", Offset = "0x77E6", VA = "0x77E6", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60026B2")]
			[Address(RVA = "0x77E7", Offset = "0x77E7", VA = "0x77E7", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060026B3 RID: 9907 RVA: 0x000076B0 File Offset: 0x000058B0
		[Token(Token = "0x60026B3")]
		[Address(RVA = "0x77E8", Offset = "0x77E8", VA = "0x77E8", Slot = "6")]
		public bool Filter(MarketLotData marketLotData)
		{
		/* --- GHIDRA: Filter ---
		void Gameplay_Market_Controller_Filters_MarketMetaFilter__Filter(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int param2_00;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined4 param1_00;
		  int *piVar4;
		  int iVar5;
		  undefined4 *puVar6;
		  
		  if (DAT_ram_00a5a03e == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Distinct_uint___);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_SelectMany_ArtikulTypeMetaFilterDic__uint___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Select_uint__ArtikulTypeFilters___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToArray_ArtikulTypeFilters___);
		    Mono_Security_ASN1__get_Item(&System_Func_uint__ArtikulTypeFilters__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Func_ArtikulTypeMetaFilterDic__IEnumerable_uint___TypeInfo)
		    ;
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_List_ArtikulTypeMetaFilterDic__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Market_Controller_Filters_MarketMetaFilter___c__Prepare_b__6_0__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Market_Controller_Filters_MarketMetaFilter___c__DisplayClass6_0__Prepare_b__1__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Market_Controller_Filters_MarketMetaFilter___c__DisplayClass6_0_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Market_Controller_Filters_MarketMetaFilter___c_TypeInfo);
		    DAT_ram_00a5a03e = '\x01';
		  }
		  param2_00 = unnamed_function_1417
		                        (
		                        Gameplay_Market_Controller_Filters_MarketMetaFilter___c__DisplayClass6_0_TypeInfo
		                        );
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  piVar4 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x178);
		        goto code_r0x811b7d50;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x811b7d50:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		  uVar3 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar3,0);
		  *(undefined4 *)(param2_00 + 8) = uVar3;
		  piVar4 = *(int **)(*(int *)(param1 + 0xc) + 0xc);
		  if (piVar4 != (int *)0x0) {
		    if (((uint)*(byte *)(*piVar4 + 0xb8) <
		         (uint)*(byte *)(System_Collections_Generic_List_ArtikulTypeMetaFilterDic__TypeInfo + 0xb8))
		       || (*(int *)(*(int *)(*piVar4 + 100) +
		                    (uint)*(byte *)(
		                                   System_Collections_Generic_List_ArtikulTypeMetaFilterDic__TypeInfo
		                                   + 0xb8) * 4 + -4) !=
		           System_Collections_Generic_List_ArtikulTypeMetaFilterDic__TypeInfo)) {
		      System_Activator__CreateInstance
		                (piVar4,System_Collections_Generic_List_ArtikulTypeMetaFilterDic__TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  if (*(int *)(Gameplay_Market_Controller_Filters_MarketMetaFilter___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_Market_Controller_Filters_MarketMetaFilter___c_TypeInfo);
		  }
		  puVar6 = *(undefined4 **)(Gameplay_Market_Controller_Filters_MarketMetaFilter___c_TypeInfo + 0x5c)
		  ;
		  iVar5 = puVar6[2];
		  if (iVar5 == 0) {
		    if (*(int *)(Gameplay_Market_Controller_Filters_MarketMetaFilter___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_Market_Controller_Filters_MarketMetaFilter___c_TypeInfo);
		      puVar6 = *(undefined4 **)
		                (Gameplay_Market_Controller_Filters_MarketMetaFilter___c_TypeInfo + 0x5c);
		    }
		    uVar3 = *puVar6;
		    iVar5 = unnamed_function_1417(System_Func_ArtikulTypeMetaFilterDic__IEnumerable_uint___TypeInfo)
		    ;
		    System_Linq_Enumerable__Where_object_
		              (iVar5,uVar3,
		               Method_Gameplay_Market_Controller_Filters_MarketMetaFilter___c__Prepare_b__6_0__,0);
		    *(int *)(*(int *)(Gameplay_Market_Controller_Filters_MarketMetaFilter___c_TypeInfo + 0x5c) + 8)
		         = iVar5;
		  }
		  uVar3 = System_Linq_Enumerable__SelectMany_ValueTuple_object__object___object_
		                    (piVar4,iVar5,
		                     Method_System_Linq_Enumerable_SelectMany_ArtikulTypeMetaFilterDic__uint___);
		  uVar3 = System_Linq_Enumerable__DefaultIfEmptyIterator___Il2CppFullySharedGenericType_
		                    (uVar3,Method_System_Linq_Enumerable_Distinct_uint___);
		  param1_00 = unnamed_function_1417(System_Func_uint__ArtikulTypeFilters__TypeInfo);
		  System_Linq_Enumerable__Distinct_uint_
		            (param1_00,param2_00,
		             Method_Gameplay_Market_Controller_Filters_MarketMetaFilter___c__DisplayClass6_0__Prepare_b__1__
		             ,0);
		  uVar3 = System_Linq_Enumerable__ReverseIterator___Il2CppFullySharedGenericType_
		                    (uVar3,param1_00,
		                     Method_System_Linq_Enumerable_Select_uint__ArtikulTypeFilters___);
		  uVar3 = func_ii_6295(uVar3,Method_System_Linq_Enumerable_ToArray_ArtikulTypeFilters___);
		  *(undefined4 *)(param1 + 8) = uVar3;
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x060026B4 RID: 9908 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026B4")]
		[Address(RVA = "0x77E9", Offset = "0x77E9", VA = "0x77E9", Slot = "7")]
		public void Prepare()
		{
		}

		// Token: 0x060026B5 RID: 9909 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026B5")]
		[Address(RVA = "0x77EA", Offset = "0x77EA", VA = "0x77EA")]
		public MarketMetaFilter()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Market_Controller_Filters_MarketMetaFilter___ctor(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5a03f == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Market_Controller_Filters_MarketMetaFilter___c_TypeInfo);
		    DAT_ram_00a5a03f = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Gameplay_Market_Controller_Filters_MarketMetaFilter___c_TypeInfo);
		  **(undefined4 **)(Gameplay_Market_Controller_Filters_MarketMetaFilter___c_TypeInfo + 0x5c) = uVar1
		  ;
		  return;
		}
		*/

		}

		// Token: 0x0400151F RID: 5407
		[Token(Token = "0x400151F")]
		[FieldOffset(Offset = "0x8")]
		private ArtikulTypeFilters[] _filters;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_FilterInfo ---
		uint Gameplay_Market_Controller_Filters_MarketMetaFilter__set_FilterInfo
		               (int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  undefined4 *puVar2;
		  int iVar3;
		  undefined4 param2_00;
		  int iVar4;
		  
		  iVar4 = 0;
		  if (DAT_ram_00a5a03d == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Func_uint__uint__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Extensions_IListExt_BinarySearch_uint__uint___);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Market_Controller_Filters_MarketMetaFilter___c__Filter_b__5_0__);
		    Mono_Security_ASN1__get_Item(&Gameplay_Market_Controller_Filters_MarketMetaFilter___c_TypeInfo);
		    DAT_ram_00a5a03d = '\x01';
		  }
		  if (*(char *)(*(int *)(param1 + 0xc) + 0x10) != '\0') {
		    iVar1 = *(int *)(param1 + 8);
		    if (0 < *(int *)(iVar1 + 0xc)) {
		      do {
		        param1_00 = *(undefined4 *)(*(int *)(iVar1 + iVar4 * 4 + 0x10) + 0x18);
		        if (*(int *)(Gameplay_Market_Controller_Filters_MarketMetaFilter___c_TypeInfo + 0x74) == 0)
		        {
		          func_ii_306000(Gameplay_Market_Controller_Filters_MarketMetaFilter___c_TypeInfo);
		        }
		        puVar2 = *(undefined4 **)
		                  (Gameplay_Market_Controller_Filters_MarketMetaFilter___c_TypeInfo + 0x5c);
		        iVar3 = puVar2[1];
		        if (iVar3 == 0) {
		          if (*(int *)(Gameplay_Market_Controller_Filters_MarketMetaFilter___c_TypeInfo + 0x74) == 0
		             ) {
		            func_ii_306000(Gameplay_Market_Controller_Filters_MarketMetaFilter___c_TypeInfo);
		            puVar2 = *(undefined4 **)
		                      (Gameplay_Market_Controller_Filters_MarketMetaFilter___c_TypeInfo + 0x5c);
		          }
		          param2_00 = *puVar2;
		          iVar3 = unnamed_function_1417(System_Func_uint__uint__TypeInfo);
		          func_ii_7246(iVar3,param2_00,
		                       Method_Gameplay_Market_Controller_Filters_MarketMetaFilter___c__Filter_b__5_0__
		                       ,0);
		          *(int *)(*(int *)(Gameplay_Market_Controller_Filters_MarketMetaFilter___c_TypeInfo + 0x5c)
		                  + 4) = iVar3;
		        }
		        iVar3 = Unity_Jobs_IJobParallelForExtensions__Run_UITKTextJobSystem_PrepareTextJobData_
		                          (param1_00,iVar3,
		                           *(undefined4 *)(*(int *)(*(int *)(param2 + 8) + 0xc) + 0xc),
		                           Method_Core_Extensions_IListExt_BinarySearch_uint__uint___);
		      } while ((iVar3 == 0) && (iVar4 = iVar4 + 1, iVar4 < *(int *)(iVar1 + 0xc)));
		      return (uint)(iVar3 != 0);
		    }
		    return 0;
		  }
		  return 1;
		}
		*/

}
