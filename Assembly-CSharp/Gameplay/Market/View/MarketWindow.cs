using System;
using System.Collections.Generic;
using Gameplay.Market.Controller;
using Gameplay.Market.Events;
using Gameplay.Market.Model;
using Il2CppDummyDll;
using UI.Filters;
using UI.Tabs;
using UI.Windows;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Market.View
{
	// Token: 0x0200061F RID: 1567
	[Token(Token = "0x200061F")]
	public class MarketWindow : ClosableBaseWindow<MarketWindow.MarketWindowArgs>
	{
		// Token: 0x17000723 RID: 1827
		// (get) Token: 0x06002604 RID: 9732 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000723")]
		public override string WindowId
		{
			[Token(Token = "0x6002604")]
			[Address(RVA = "0x7742", Offset = "0x7742", VA = "0x7742", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000724 RID: 1828
		// (get) Token: 0x06002605 RID: 9733 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000724")]
		public MarketLotInfoView InfoView
		{
			[Token(Token = "0x6002605")]
			[Address(RVA = "0x7743", Offset = "0x7743", VA = "0x7743")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000725 RID: 1829
		// (get) Token: 0x06002606 RID: 9734 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000725")]
		public BlueTabBar TabBar
		{
			[Token(Token = "0x6002606")]
			[Address(RVA = "0x7744", Offset = "0x7744", VA = "0x7744")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000726 RID: 1830
		// (get) Token: 0x06002607 RID: 9735 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000726")]
		public MarketLotDataOSAView OSAView
		{
			[Token(Token = "0x6002607")]
			[Address(RVA = "0x7745", Offset = "0x7745", VA = "0x7745")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000727 RID: 1831
		// (get) Token: 0x06002608 RID: 9736 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000727")]
		public MarketLotDataOSAView ExtraOSAView
		{
			[Token(Token = "0x6002608")]
			[Address(RVA = "0x7746", Offset = "0x7746", VA = "0x7746")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000728 RID: 1832
		// (get) Token: 0x06002609 RID: 9737 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000728")]
		public FiltersView FiltersView
		{
			[Token(Token = "0x6002609")]
			[Address(RVA = "0x7747", Offset = "0x7747", VA = "0x7747")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000729 RID: 1833
		// (get) Token: 0x0600260A RID: 9738 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000729")]
		public MetaFiltersView MetaFiltersView
		{
			[Token(Token = "0x600260A")]
			[Address(RVA = "0x7748", Offset = "0x7748", VA = "0x7748")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700072A RID: 1834
		// (get) Token: 0x0600260B RID: 9739 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700072A")]
		public SubFiltersDropdown SubFiltersView
		{
			[Token(Token = "0x600260B")]
			[Address(RVA = "0x7749", Offset = "0x7749", VA = "0x7749")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700072B RID: 1835
		// (get) Token: 0x0600260C RID: 9740 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700072B")]
		public TabBar ExtraTabs
		{
			[Token(Token = "0x600260C")]
			[Address(RVA = "0x774A", Offset = "0x774A", VA = "0x774A")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600260D RID: 9741 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600260D")]
		[Address(RVA = "0x774B", Offset = "0x774B", VA = "0x774B")]
		public void Init()
		{
		/* --- GHIDRA: Init ---
		void Gameplay_Market_View_MarketWindow__Init
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  int iVar5;
		  ulonglong uVar6;
		  int iVar7;
		  ulonglong local_10;
		  byte local_8;
		  
		  if (DAT_ram_00a59ff0 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_First_MarketLotViewsHolder___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToList_MarketLotViewsHolder___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Where_MarketLotViewsHolder___);
		    Mono_Security_ASN1__get_Item(&System_Func_MarketLotViewsHolder__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_MarketLotViewsHolder__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_MarketLotListElement_MarketLotListElementArgs__get_Count__
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_int__GetValueOrDefault__);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_int___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_int__get_HasValue__);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_int__get_Value__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_Core_OSAExtensions_GetVisibleItems_BaseParamsWithPrefab__MarketLotViewsHolder___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_Core_OSA_BaseParamsWithPrefab__MarketLotViewsHolder__get_IsInitialized__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Market_View_MarketWindow___c__DisplayClass38_0__SetMarketLots_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Market_View_MarketWindow___c__DisplayClass38_0__SetMarketLots_b__1__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Market_View_MarketWindow___c__DisplayClass38_0_TypeInfo);
		    DAT_ram_00a59ff0 = '\x01';
		  }
		  iVar1 = unnamed_function_1417(Gameplay_Market_View_MarketWindow___c__DisplayClass38_0_TypeInfo);
		  *(undefined4 *)(iVar1 + 0x10) = param2;
		  *(int *)(iVar1 + 0xc) = param1;
		  *(undefined4 *)(iVar1 + 8) = param4;
		  iVar7 = **(int **)(param1 + 0x3c);
		  (**(code **)((ulonglong)*(uint *)(iVar7 + 0x3b8) * 4))
		            (*(int **)(param1 + 0x3c),*(undefined4 *)(iVar7 + 0x3bc));
		  piVar4 = *(int **)(param1 + 0x3c);
		  if ((char)piVar4[0x14] == '\0') {
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,iVar1,
		               Method_Gameplay_Market_View_MarketWindow___c__DisplayClass38_0__SetMarketLots_b__0__,
		               0);
		    (**(code **)((ulonglong)*(uint *)(*piVar4 + 0x298) * 4))
		              (piVar4,uVar3,*(undefined4 *)(*piVar4 + 0x29c));
		    return;
		  }
		  _local_8 = 0;
		  if (*(int *)(iVar1 + 8) == 0) goto code_r0x811afb3e;
		  iVar5 = piVar4[0xb];
		  uVar3 = unnamed_function_1417(System_Func_MarketLotViewsHolder__bool__TypeInfo);
		  System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		            (uVar3,iVar1,
		             Method_Gameplay_Market_View_MarketWindow___c__DisplayClass38_0__SetMarketLots_b__1__,0)
		  ;
		  uVar3 = System_Linq_Enumerable__Where_PlayerLoopSystem_
		                    (iVar5,uVar3,Method_System_Linq_Enumerable_Where_MarketLotViewsHolder___);
		  iVar7 = System_Linq_Enumerable__Select_object__object_
		                    (uVar3,Method_System_Linq_Enumerable_ToList_MarketLotViewsHolder___);
		  if (*(int *)(iVar7 + 0xc) < 1) goto code_r0x811afb3e;
		  if (*(int *)(iVar7 + 0xc) == *(int *)(iVar5 + 0xc)) {
		    piVar4 = (int *)System_Linq_Enumerable__Count_object_
		                              (iVar5,Method_System_Linq_Enumerable_First_MarketLotViewsHolder___);
		code_r0x811afa8f:
		    iVar7 = (**(code **)((ulonglong)*(uint *)(*piVar4 + 0xe0) * 4))
		                      (piVar4,*(undefined4 *)(*piVar4 + 0xe4));
		    System_Data_SqlTypes_SqlInt32___ctor(&local_8,iVar7 + -1,Method_System_Nullable_int___ctor__);
		  }
		  else {
		    piVar4 = (int *)System_Linq_Enumerable__Count_object_
		                              (iVar7,Method_System_Linq_Enumerable_First_MarketLotViewsHolder___);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*piVar4 + 0xe0) * 4))
		                      (piVar4,*(undefined4 *)(*piVar4 + 0xe4));
		    piVar4 = (int *)System_Linq_Enumerable__Count_object_
		                              (iVar5,Method_System_Linq_Enumerable_First_MarketLotViewsHolder___);
		    iVar5 = (**(code **)((ulonglong)*(uint *)(*piVar4 + 0xe0) * 4))
		                      (piVar4,*(undefined4 *)(*piVar4 + 0xe4));
		    if (iVar2 == iVar5) {
		      piVar4 = (int *)System_Linq_Enumerable__Count_object_
		                                (iVar7,Method_System_Linq_Enumerable_First_MarketLotViewsHolder___);
		      goto code_r0x811afa8f;
		    }
		  }
		  uVar6 = _local_8 & 0xff;
		  if ((uVar6 != 0) &&
		     (iVar7 = *(int *)(*(int *)(iVar1 + 0x10) + 0xc) + -1, iVar7 < (int)(_local_8 >> 0x20))) {
		    local_10 = 0;
		    System_Data_SqlTypes_SqlInt32___ctor(&local_10,iVar7,Method_System_Nullable_int___ctor__);
		    uVar6 = local_10 & 0xff;
		    _local_8 = local_10;
		  }
		  if (((longlong)_local_8 < 0) && (uVar6 != 0)) {
		    local_10 = 0;
		    System_Data_SqlTypes_SqlInt32___ctor(&local_10,0,Method_System_Nullable_int___ctor__);
		    _local_8 = local_10;
		  }
		code_r0x811afb3e:
		  Gameplay_Market_View_MarketLotDataOSAView__RemoveItemsFrom
		            (*(undefined4 *)(param1 + 0x3c),*(undefined4 *)(iVar1 + 0x10),0);
		  if ((local_8 != 0) &&
		     (((_local_8 & 0xff) == 0 || (*(int *)(*(int *)(iVar1 + 0x10) + 0xc) != (int)(_local_8 >> 0x20))
		      ))) {
		    piVar4 = *(int **)(param1 + 0x3c);
		    uVar3 = System_Nullable_DefaultEventSystem_FocusBasedEventSequenceContext___get_HasValue
		                      (&local_8,Method_System_Nullable_int__get_Value__);
		    iVar1 = *piVar4;
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0x390) * 4))
		              (piVar4,uVar3,0,0,*(undefined4 *)(iVar1 + 0x394));
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600260E RID: 9742 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600260E")]
		[Address(RVA = "0x774C", Offset = "0x774C", VA = "0x774C")]
		public void SetMarketLots(List<MarketLotListElement.MarketLotListElementArgs> items, IEnumerable<MarketLotListElement.MarketLotListElementArgs> added, IEnumerable<MarketLotListElement.MarketLotListElementArgs> removed)
		{
		/* --- GHIDRA: SetMarketLots ---
		void Gameplay_Market_View_MarketWindow__SetMarketLots
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *puVar3;
		  undefined4 param1_00;
		  int *piVar4;
		  int iVar5;
		  
		  if (DAT_ram_00a59ff2 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_ICollection_MarketLotListElement_MarketLotListElementArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_Core_OSA_BaseParamsWithPrefab__MarketLotViewsHolder__get_IsInitialized__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Market_View_MarketWindow___c__DisplayClass40_0__UpdateExtraMarketLots_b__0__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Market_View_MarketWindow___c__DisplayClass40_0_TypeInfo);
		    DAT_ram_00a59ff2 = '\x01';
		  }
		  iVar2 = unnamed_function_1417(Gameplay_Market_View_MarketWindow___c__DisplayClass40_0_TypeInfo);
		  *(undefined4 *)(iVar2 + 0xc) = param2;
		  *(int *)(iVar2 + 8) = param1;
		  iVar5 = **(int **)(param1 + 0x40);
		  (**(code **)((ulonglong)*(uint *)(iVar5 + 0x3b8) * 4))
		            (*(int **)(param1 + 0x40),*(undefined4 *)(iVar5 + 0x3bc));
		  piVar4 = *(int **)(param1 + 0x40);
		  if ((char)piVar4[0x14] == '\0') {
		    param1_00 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (param1_00,iVar2,
		               Method_Gameplay_Market_View_MarketWindow___c__DisplayClass40_0__UpdateExtraMarketLots_b__0__
		               ,0);
		    (**(code **)((ulonglong)*(uint *)(*piVar4 + 0x298) * 4))
		              (piVar4,param1_00,*(undefined4 *)(*piVar4 + 0x29c));
		  }
		  else {
		    uVar1 = 0;
		    Gameplay_Market_View_MarketLotDataOSAView__RemoveItemsFrom
		              (piVar4,*(undefined4 *)(iVar2 + 0xc),0);
		    piVar4 = *(int **)(iVar2 + 0xc);
		    iVar2 = *piVar4;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      do {
		        if (System_Collections_Generic_ICollection_MarketLotListElement_MarketLotListElementArgs__TypeInfo
		            == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(iVar2 + *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x811afe6d;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar4,
		                                  System_Collections_Generic_ICollection_MarketLotListElement_MarketLotListElementArgs__TypeInfo
		                                  ,0);
		code_r0x811afe6d:
		    iVar2 = (**(code **)((ulonglong)*puVar3 * 4))(piVar4,puVar3[1]);
		    if (0 < iVar2) {
		      iVar2 = **(int **)(param1 + 0x40);
		      (**(code **)((ulonglong)*(uint *)(iVar2 + 0x390) * 4))
		                (*(int **)(param1 + 0x40),0,0,0,*(undefined4 *)(iVar2 + 0x394));
		      return;
		    }
		  }
		  return;
		}
		*/

		/* --- GHIDRA: SetMarketLots ---
		void Gameplay_Market_View_MarketWindow__SetMarketLots
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *puVar3;
		  undefined4 param1_00;
		  int *piVar4;
		  int iVar5;
		  
		  if (DAT_ram_00a59ff2 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_ICollection_MarketLotListElement_MarketLotListElementArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_Core_OSA_BaseParamsWithPrefab__MarketLotViewsHolder__get_IsInitialized__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Market_View_MarketWindow___c__DisplayClass40_0__UpdateExtraMarketLots_b__0__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Market_View_MarketWindow___c__DisplayClass40_0_TypeInfo);
		    DAT_ram_00a59ff2 = '\x01';
		  }
		  iVar2 = unnamed_function_1417(Gameplay_Market_View_MarketWindow___c__DisplayClass40_0_TypeInfo);
		  *(undefined4 *)(iVar2 + 0xc) = param2;
		  *(int *)(iVar2 + 8) = param1;
		  iVar5 = **(int **)(param1 + 0x40);
		  (**(code **)((ulonglong)*(uint *)(iVar5 + 0x3b8) * 4))
		            (*(int **)(param1 + 0x40),*(undefined4 *)(iVar5 + 0x3bc));
		  piVar4 = *(int **)(param1 + 0x40);
		  if ((char)piVar4[0x14] == '\0') {
		    param1_00 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (param1_00,iVar2,
		               Method_Gameplay_Market_View_MarketWindow___c__DisplayClass40_0__UpdateExtraMarketLots_b__0__
		               ,0);
		    (**(code **)((ulonglong)*(uint *)(*piVar4 + 0x298) * 4))
		              (piVar4,param1_00,*(undefined4 *)(*piVar4 + 0x29c));
		  }
		  else {
		    uVar1 = 0;
		    Gameplay_Market_View_MarketLotDataOSAView__RemoveItemsFrom
		              (piVar4,*(undefined4 *)(iVar2 + 0xc),0);
		    piVar4 = *(int **)(iVar2 + 0xc);
		    iVar2 = *piVar4;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      do {
		        if (System_Collections_Generic_ICollection_MarketLotListElement_MarketLotListElementArgs__TypeInfo
		            == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(iVar2 + *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x811afe6d;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar4,
		                                  System_Collections_Generic_ICollection_MarketLotListElement_MarketLotListElementArgs__TypeInfo
		                                  ,0);
		code_r0x811afe6d:
		    iVar2 = (**(code **)((ulonglong)*puVar3 * 4))(piVar4,puVar3[1]);
		    if (0 < iVar2) {
		      iVar2 = **(int **)(param1 + 0x40);
		      (**(code **)((ulonglong)*(uint *)(iVar2 + 0x390) * 4))
		                (*(int **)(param1 + 0x40),0,0,0,*(undefined4 *)(iVar2 + 0x394));
		      return;
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600260F RID: 9743 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600260F")]
		[Address(RVA = "0x774D", Offset = "0x774D", VA = "0x774D")]
		public void SetMarketLots(IList<MarketLotListElement.MarketLotListElementArgs> items)
		{
		}

		// Token: 0x06002610 RID: 9744 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002610")]
		[Address(RVA = "0x774E", Offset = "0x774E", VA = "0x774E")]
		public void UpdateExtraMarketLots(IList<MarketLotListElement.MarketLotListElementArgs> items)
		{
		/* --- GHIDRA: UpdateExtraMarketLots ---
		void Gameplay_Market_View_MarketWindow__UpdateExtraMarketLots
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int param1_00;
		  undefined4 uVar4;
		  
		  if (DAT_ram_00a59ff3 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_ClosableBaseWindow_MarketWindow_MarketWindowArgs__OnShow__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Market_View_MarketWindow_LeftArrowClickedEventHandler__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Market_View_MarketWindow_RightArrowClickedEventHandler__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a59ff3 = '\x01';
		  }
		  func_ii_7769(param1,param2,
		               Method_UI_Windows_ClosableBaseWindow_MarketWindow_MarketWindowArgs__OnShow__);
		  Gameplay_Market_View_MarketWindow__LeftArrowClickedEventHandler(param1,param2);
		  iVar3 = *(int *)(param1 + 0x44);
		  if (DAT_ram_00a59fe4 == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Dic_ArtikulMenuActionDic_Types_Actions___TypeInfo);
		    DAT_ram_00a59fe4 = '\x01';
		  }
		  param1_00 = *(int *)(iVar3 + 0x10);
		  iVar3 = 0;
		  iVar1 = Mono_Security_ASN1Convert__ToOid
		                    (Protocol_Dic_ArtikulMenuActionDic_Types_Actions___TypeInfo,2);
		  *(undefined8 *)(iVar1 + 0x10) = 0x1e00000005;
		  *(undefined4 *)(param1_00 + 0x58) = 0;
		  *(int *)(param1_00 + 0x54) = iVar1;
		  *(undefined4 *)(param1_00 + 0x50) = 0;
		  *(undefined1 *)(param1_00 + 0x45) = 1;
		  UI_AbstractDeferredRenderer__KillCoroutine(param1_00,0);
		  iVar1 = *(int *)(param1 + 0x5c);
		  if (0 < *(int *)(iVar1 + 0xc)) {
		    do {
		      Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                (*(undefined4 *)(iVar1 + iVar3 * 4 + 0x10),0,0);
		      iVar3 = iVar3 + 1;
		    } while (iVar3 < *(int *)(iVar1 + 0xc));
		  }
		  uVar4 = *(undefined4 *)(*(int *)(param1 + 0x60) + 0xb4);
		  uVar2 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar2,param1,Method_Gameplay_Market_View_MarketWindow_LeftArrowClickedEventHandler__,0)
		  ;
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar4,uVar2,0);
		  uVar4 = *(undefined4 *)(*(int *)(param1 + 100) + 0xb4);
		  uVar2 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar2,param1,Method_Gameplay_Market_View_MarketWindow_RightArrowClickedEventHandler__,0
		            );
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar4,uVar2,0);
		  return;
		}
		*/

		}

		// Token: 0x06002611 RID: 9745 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002611")]
		[Address(RVA = "0x774F", Offset = "0x774F", VA = "0x774F", Slot = "22")]
		protected override void OnShow(MarketWindow.MarketWindowArgs args)
		{
		/* --- GHIDRA: OnShow ---
		void Gameplay_Market_View_MarketWindow__OnShow(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  undefined8 *puVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a59ff4 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_ClosableBaseWindow_MarketWindow_MarketWindowArgs__OnClose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Market_View_MarketWindow_LeftArrowClickedEventHandler__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Market_View_MarketWindow_RightArrowClickedEventHandler__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a59ff4 = '\x01';
		  }
		  UI_Windows_ClosableBaseWindow_object___OnClickBack
		            (param1,Method_UI_Windows_ClosableBaseWindow_MarketWindow_MarketWindowArgs__OnClose__);
		  uVar2 = *(undefined4 *)(*(int *)(param1 + 0x60) + 0xb4);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar1,param1,Method_Gameplay_Market_View_MarketWindow_LeftArrowClickedEventHandler__,0)
		  ;
		  UnityEngine_Events_UnityAction___ctor(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(*(int *)(param1 + 100) + 0xb4);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar1,param1,Method_Gameplay_Market_View_MarketWindow_RightArrowClickedEventHandler__,0
		            );
		  UnityEngine_Events_UnityAction___ctor(uVar2,uVar1,0);
		  if (*(char *)(param1 + 0x78) != '\0') {
		    puVar3 = (undefined8 *)(param1 + 0x70);
		    MVC_AbstractController__Run(*(undefined4 *)puVar3,0);
		    iVar4 = **(int **)(param1 + 0x68);
		    (**(code **)((ulonglong)*(uint *)(iVar4 + 0xe8) * 4))
		              (*(int **)(param1 + 0x68),*(undefined4 *)(iVar4 + 0xec));
		    iVar4 = **(int **)(param1 + 0x74);
		    (**(code **)((ulonglong)*(uint *)(iVar4 + 0x130) * 4))
		              (*(int **)(param1 + 0x74),*(undefined4 *)(iVar4 + 0x134));
		    iVar4 = **(int **)puVar3;
		    (**(code **)((ulonglong)*(uint *)(iVar4 + 0xe8) * 4))
		              (*(int **)puVar3,*(undefined4 *)(iVar4 + 0xec));
		    *puVar3 = 0;
		    *(undefined8 *)(param1 + 0x68) = 0;
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002612 RID: 9746 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002612")]
		[Address(RVA = "0x7750", Offset = "0x7750", VA = "0x7750", Slot = "19")]
		protected override void OnClose()
		{
		/* --- GHIDRA: OnClose ---
		void Gameplay_Market_View_MarketWindow__OnClose(int param1,undefined4 param2)
		
		{
		  undefined4 local_8;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a59ff5 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_Core_OSAExtensions_SmoothScrollBy_BaseParamsWithPrefab__MarketLotViewsHolder___
		              );
		    DAT_ram_00a59ff5 = '\x01';
		  }
		  local_8 = 0x3e99999a;
		  local_4 = 5;
		  Com_TheFallenGames_OSA_Core_OSAExtensions__GetVisibleItems_object__object_
		            (*(undefined4 *)(param1 + 0x40),&local_4,&local_8,0,
		             Method_Com_TheFallenGames_OSA_Core_OSAExtensions_SmoothScrollBy_BaseParamsWithPrefab__MarketLotViewsHolder___
		            );
		  return;
		}
		*/

		}

		// Token: 0x06002613 RID: 9747 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002613")]
		[Address(RVA = "0x7751", Offset = "0x7751", VA = "0x7751")]
		private void RightArrowClickedEventHandler()
		{
		/* --- GHIDRA: RightArrowClickedEventHandler ---
		void Gameplay_Market_View_MarketWindow__RightArrowClickedEventHandler(int param1,undefined4 param2)
		
		{
		  undefined4 local_8;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a59ff6 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_Core_OSAExtensions_SmoothScrollBy_BaseParamsWithPrefab__MarketLotViewsHolder___
		              );
		    DAT_ram_00a59ff6 = '\x01';
		  }
		  local_8 = 0x3e99999a;
		  local_4 = 0xfffffffb;
		  Com_TheFallenGames_OSA_Core_OSAExtensions__GetVisibleItems_object__object_
		            (*(undefined4 *)(param1 + 0x40),&local_4,&local_8,0,
		             Method_Com_TheFallenGames_OSA_Core_OSAExtensions_SmoothScrollBy_BaseParamsWithPrefab__MarketLotViewsHolder___
		            );
		  return;
		}
		*/

		}

		// Token: 0x06002614 RID: 9748 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002614")]
		[Address(RVA = "0x7752", Offset = "0x7752", VA = "0x7752")]
		private void LeftArrowClickedEventHandler()
		{
		/* --- GHIDRA: LeftArrowClickedEventHandler ---
		void Gameplay_Market_View_MarketWindow__LeftArrowClickedEventHandler(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  undefined4 uVar5;
		  int *piVar6;
		  int iVar7;
		  
		  if (DAT_ram_00a59ff7 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Market_Controller_MarketController_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Market_Events_MarketEvents_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Market_Model_MarketModel_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Market_Controller_MarketViewMediator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_ShopService___);
		    Mono_Security_ASN1__get_Item(&Core_Net_ServiceFactory_TypeInfo);
		    DAT_ram_00a59ff7 = '\x01';
		  }
		  if (*(char *)(param1 + 0x78) == '\0') {
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    piVar6 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar7 = *piVar6;
		    if (*(ushort *)(iVar7 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x140);
		          goto code_r0x811b0131;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x811b0131:
		    uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar6,puVar2[1]);
		    uVar3 = func_ii_7112(uVar3,0);
		    uVar4 = unnamed_function_1417(Gameplay_Market_Model_MarketModel_TypeInfo);
		    Gameplay_Market_Model_MarketModel__set_ExtraArtifactsResult(uVar4,uVar3,uVar3);
		    *(undefined4 *)(param1 + 0x68) = uVar4;
		    uVar3 = unnamed_function_1417(Gameplay_Market_Events_MarketEvents_TypeInfo);
		    *(undefined4 *)(param1 + 0x6c) = uVar3;
		    uVar4 = *(undefined4 *)(param1 + 0x68);
		    if (*(int *)(Core_Net_ServiceFactory_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Net_ServiceFactory_TypeInfo);
		    }
		    uVar5 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                      (Method_Core_Net_ServiceFactory_GetService_ShopService___);
		    iVar7 = unnamed_function_1417(Gameplay_Market_Controller_MarketController_TypeInfo);
		    if (DAT_ram_00a5a017 == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&Method_MVC_AbstractController_MarketModel__MarketEvents___ctor__);
		      DAT_ram_00a5a017 = '\x01';
		    }
		    Gameplay_Combat_AbstractCombat_object__object__object__object__object___set_User
		              (iVar7,uVar4,uVar3,Method_MVC_AbstractController_MarketModel__MarketEvents___ctor__);
		    *(undefined4 *)(iVar7 + 0x18) = uVar5;
		    *(int *)(param1 + 0x70) = iVar7;
		    uVar3 = *(undefined4 *)(param1 + 0x68);
		    uVar4 = *(undefined4 *)(param1 + 0x6c);
		    piVar6 = (int *)unnamed_function_1417(Gameplay_Market_Controller_MarketViewMediator_TypeInfo);
		    Gameplay_Market_Controller_MarketViewMediator__get_CurrentTab(piVar6,uVar3,uVar4,iVar7,iVar7);
		    (**(code **)((ulonglong)*(uint *)(*piVar6 + 0x160) * 4))
		              (piVar6,param1,*(undefined4 *)(*piVar6 + 0x164));
		    *(int **)(param1 + 0x74) = piVar6;
		    MVC_AbstractController__Dispose(*(undefined4 *)(param1 + 0x70),0);
		    *(undefined1 *)(param1 + 0x78) = 1;
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002615 RID: 9749 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002615")]
		[Address(RVA = "0x7753", Offset = "0x7753", VA = "0x7753")]
		private void SetupMVC()
		{
		/* --- GHIDRA: SetupMVC ---
		void Gameplay_Market_View_MarketWindow__SetupMVC(int param1,undefined4 param2)
		
		{
		  undefined8 *puVar1;
		  int iVar2;
		  
		  if (*(char *)(param1 + 0x78) != '\0') {
		    puVar1 = (undefined8 *)(param1 + 0x70);
		    MVC_AbstractController__Run(*(undefined4 *)puVar1,0);
		    iVar2 = **(int **)(param1 + 0x68);
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0xe8) * 4))
		              (*(int **)(param1 + 0x68),*(undefined4 *)(iVar2 + 0xec));
		    iVar2 = **(int **)(param1 + 0x74);
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0x130) * 4))
		              (*(int **)(param1 + 0x74),*(undefined4 *)(iVar2 + 0x134));
		    iVar2 = **(int **)puVar1;
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0xe8) * 4))
		              (*(int **)puVar1,*(undefined4 *)(iVar2 + 0xec));
		    *puVar1 = 0;
		    *(undefined8 *)(param1 + 0x68) = 0;
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002616 RID: 9750 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002616")]
		[Address(RVA = "0x7754", Offset = "0x7754", VA = "0x7754")]
		private void DestroyMVC()
		{
		/* --- GHIDRA: DestroyMVC ---
		void Gameplay_Market_View_MarketWindow__DestroyMVC
		               (int param1,int param2,int param3,undefined4 param4)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  int param1_01;
		  int iVar2;
		  int param3_00;
		  undefined4 param1_02;
		  undefined4 param2_00;
		  uint uVar3;
		  
		  if (DAT_ram_00a59ff8 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_ToList_MarketLotListElement_MarketLotListElementArgs___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_MarketLotListElement_MarketLotListElementArgs__Add__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_MarketLotListElement_MarketLotListElementArgs__Remove__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_MarketLotListElement_MarketLotListElementArgs___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_MarketLotViewsHolder__get_Item__);
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_List_MarketLotListElement_MarketLotListElementArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_Core_OSAExtensions_GetVisibleItems_BaseParamsWithPrefab__MarketLotViewsHolder___
		              );
		    DAT_ram_00a59ff8 = '\x01';
		  }
		  param3_00 = *(int *)(param1 + 0x3c);
		  param1_02 = *(undefined4 *)(param3_00 + 0x2c);
		  param1_00 = System_Linq_Enumerable__Select_object__object_
		                        (*(undefined4 *)(param3_00 + 0xa0),
		                         Method_System_Linq_Enumerable_ToList_MarketLotListElement_MarketLotListElementArgs___
		                        );
		  param1_01 = unnamed_function_1417
		                        (
		                        System_Collections_Generic_List_MarketLotListElement_MarketLotListElementArgs__TypeInfo
		                        );
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_01,
		             Method_System_Collections_Generic_List_MarketLotListElement_MarketLotListElementArgs___ctor__
		            );
		  if (0 < param3) {
		    param3_00 = 0;
		    do {
		      iVar2 = System_Linq_Enumerable__ToList_object_
		                        (param1_02,param2 + param3_00,
		                         Method_System_Collections_Generic_List_MarketLotViewsHolder__get_Item__);
		      iVar2 = *(int *)(iVar2 + 0x14);
		      if (DAT_ram_00a59fe6 == '\0') {
		        Mono_Security_ASN1__get_Item
		                  (&
		                   Method_UI_Elements_GenericList_GenericListElement_MarketLotListElement_MarketLotListElementArgs__get_args__
		                  );
		        DAT_ram_00a59fe6 = '\x01';
		      }
		      iVar2 = func_ii_4876(param1_00,*(undefined4 *)(iVar2 + 0x18),
		                           Method_System_Collections_Generic_List_MarketLotListElement_MarketLotListElementArgs__Remove__
		                          );
		      if (iVar2 != 0) {
		        iVar2 = System_Linq_Enumerable__ToList_object_
		                          (param1_02,param2 + param3_00,
		                           Method_System_Collections_Generic_List_MarketLotViewsHolder__get_Item__);
		        iVar2 = *(int *)(iVar2 + 0x14);
		        if (DAT_ram_00a59fe6 == '\0') {
		          Mono_Security_ASN1__get_Item
		                    (&
		                     Method_UI_Elements_GenericList_GenericListElement_MarketLotListElement_MarketLotListElementArgs__get_args__
		                    );
		          DAT_ram_00a59fe6 = '\x01';
		        }
		        iVar1 = 
		        Method_System_Collections_Generic_List_MarketLotListElement_MarketLotListElementArgs__Add__;
		        param2_00 = *(undefined4 *)(iVar2 + 0x18);
		        *(int *)(param1_01 + 0x10) = *(int *)(param1_01 + 0x10) + 1;
		        uVar3 = *(uint *)(param1_01 + 0xc);
		        if (uVar3 < *(uint *)(*(int *)(param1_01 + 8) + 0xc)) {
		          *(uint *)(param1_01 + 0xc) = uVar3 + 1;
		          *(undefined4 *)(*(int *)(param1_01 + 8) + uVar3 * 4 + 0x10) = param2_00;
		        }
		        else {
		          System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                    (param1_01,param2_00,
		                     *(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		        }
		      }
		      param3_00 = param3_00 + 1;
		    } while (param3_00 != param3);
		  }
		  Gameplay_Market_View_MarketWindow__Init(param1,param1_00,param3_00,param1_01,param3_00);
		  return;
		}
		*/

		}

		// Token: 0x06002617 RID: 9751 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002617")]
		[Address(RVA = "0x7755", Offset = "0x7755", VA = "0x7755")]
		private void TestRemove(int startIndex, int count = 1)
		{
		/* --- GHIDRA: TestRemove ---
		void Gameplay_Market_View_MarketWindow__TestRemove(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a59ff9 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_ClosableBaseWindow_MarketWindow_MarketWindowArgs___ctor__);
		    DAT_ram_00a59ff9 = '\x01';
		  }
		  UI_MonoBehaviourWithStates_ClientStateChangedDelegate___Il2CppFullySharedGenericStructType___Invoke
		            (param1,Method_UI_Windows_ClosableBaseWindow_MarketWindow_MarketWindowArgs___ctor__);
		  return;
		}
		*/

		}

		// Token: 0x06002618 RID: 9752 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002618")]
		[Address(RVA = "0x7756", Offset = "0x7756", VA = "0x7756")]
		public MarketWindow()
		{
		}

		// Token: 0x040014C2 RID: 5314
		[Token(Token = "0x40014C2")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/Market/MarketWindow";

		// Token: 0x040014C3 RID: 5315
		[Token(Token = "0x40014C3")]
		public const int SCROLL_BY_AMOUNT = 5;

		// Token: 0x040014C4 RID: 5316
		[Token(Token = "0x40014C4")]
		public const float SCROLL_DURATION = 0.3f;

		// Token: 0x040014C5 RID: 5317
		[Token(Token = "0x40014C5")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private MarketLotDataOSAView _oSAView;

		// Token: 0x040014C6 RID: 5318
		[Token(Token = "0x40014C6")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private MarketLotDataOSAView _extraOSAView;

		// Token: 0x040014C7 RID: 5319
		[Token(Token = "0x40014C7")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private MarketLotInfoView _infoView;

		// Token: 0x040014C8 RID: 5320
		[Token(Token = "0x40014C8")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private BlueTabBar _tabBar;

		// Token: 0x040014C9 RID: 5321
		[Token(Token = "0x40014C9")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private FiltersView _filtersView;

		// Token: 0x040014CA RID: 5322
		[Token(Token = "0x40014CA")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private MetaFiltersView _metaFiltersView;

		// Token: 0x040014CB RID: 5323
		[Token(Token = "0x40014CB")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private SubFiltersDropdown _subFiltersView;

		// Token: 0x040014CC RID: 5324
		[Token(Token = "0x40014CC")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private TabBar _extraTabs;

		// Token: 0x040014CD RID: 5325
		[Token(Token = "0x40014CD")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private GameObject[] _enableOnInit;

		// Token: 0x040014CE RID: 5326
		[Token(Token = "0x40014CE")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Button _leftArrow;

		// Token: 0x040014CF RID: 5327
		[Token(Token = "0x40014CF")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		private Button _rightArrow;

		// Token: 0x040014D0 RID: 5328
		[Token(Token = "0x40014D0")]
		[FieldOffset(Offset = "0x68")]
		private MarketModel _model;

		// Token: 0x040014D1 RID: 5329
		[Token(Token = "0x40014D1")]
		[FieldOffset(Offset = "0x6C")]
		private MarketEvents _events;

		// Token: 0x040014D2 RID: 5330
		[Token(Token = "0x40014D2")]
		[FieldOffset(Offset = "0x70")]
		private MarketController _controller;

		// Token: 0x040014D3 RID: 5331
		[Token(Token = "0x40014D3")]
		[FieldOffset(Offset = "0x74")]
		private MarketViewMediator _mediator;

		// Token: 0x040014D4 RID: 5332
		[Token(Token = "0x40014D4")]
		[FieldOffset(Offset = "0x78")]
		private bool _mvcSetUp;

		// Token: 0x02000620 RID: 1568
		[Token(Token = "0x2000620")]
		public class MarketWindowArgs : BaseWindowArgs
		{
			// Token: 0x06002619 RID: 9753 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002619")]
			[Address(RVA = "0x7757", Offset = "0x7757", VA = "0x7757")]
			public MarketWindowArgs()
			{
			}

			// Token: 0x040014D5 RID: 5333
			[Token(Token = "0x40014D5")]
			[FieldOffset(Offset = "0x18")]
			public uint ArtikulId;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_ExtraTabs ---
		void Gameplay_Market_View_MarketWindow__get_ExtraTabs(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  int iVar2;
		  
		  iVar2 = *(int *)(param1 + 0x5c);
		  if (0 < *(int *)(iVar2 + 0xc)) {
		    iVar1 = 0;
		    do {
		      Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                (*(undefined4 *)(iVar2 + iVar1 * 4 + 0x10),1,0);
		      iVar1 = iVar1 + 1;
		    } while (iVar1 < *(int *)(iVar2 + 0xc));
		  }
		  return;
		}
		*/

}
