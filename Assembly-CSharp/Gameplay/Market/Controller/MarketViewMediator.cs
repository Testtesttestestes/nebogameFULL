using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Gameplay.Market.Controller.Filters;
using Gameplay.Market.Events;
using Gameplay.Market.Model;
using Gameplay.Market.Model.Data;
using Gameplay.Market.View;
using Il2CppDummyDll;
using JetBrains.Annotations;
using MVC;
using UI.Filters;

namespace Gameplay.Market.Controller
{
	// Token: 0x02000635 RID: 1589
	[Token(Token = "0x2000635")]
	public class MarketViewMediator : AbstractViewMediator<MarketModel, MarketEvents, MarketController, MarketWindow>
	{
		// Token: 0x17000739 RID: 1849
		// (get) Token: 0x06002684 RID: 9860 RVA: 0x00007668 File Offset: 0x00005868
		[Token(Token = "0x17000739")]
		private MarketLotData.DataType CurrentTab
		{
			[Token(Token = "0x6002684")]
			[Address(RVA = "0x77BD", Offset = "0x77BD", VA = "0x77BD")]
			get
			{
				return MarketLotData.DataType.USER;
			}
		}

		// Token: 0x06002685 RID: 9861 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002685")]
		[Address(RVA = "0x77BE", Offset = "0x77BE", VA = "0x77BE")]
		public MarketViewMediator(MarketModel model, MarketEvents events, MarketController controller)
		{
		/* --- GHIDRA: <BuyButtonClickedEventHandler>g__HandleBuyUserLot|30_1 ---
		void Gameplay_Market_Controller_MarketViewMediator___BuyButtonClickedEventHandler_g__HandleBuyUserLot_30_1
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a5a03b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_MarketModel__MarketEvents__MarketController__MarketWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_MarketLotListElement_MarketLotListElementArgs__get_Count__
		              );
		    DAT_ram_00a5a03b = '\x01';
		  }
		  local_4 = *(undefined4 *)(param1[2] + 0x1c);
		  iVar1 = Gameplay_Market_Controller_MarketViewMediator__SetFiltersData(param1,&local_4,param1);
		  param1[8] = iVar1;
		  param1[9] = iVar1;
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_Market_View_MarketWindow__SetMarketLots(param1_00,param1[8],param1);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  UI_Filters_FiltersView__AchievedToggleOnChangedEvent
		            (*(undefined4 *)(iVar1 + 0x4c),*(undefined4 *)(param1[8] + 0xc),
		             *(undefined4 *)(*(int *)(param1[2] + 0x1c) + 0xc),0);
		  return;
		}
		*/

		/* --- GHIDRA: <BuyButtonClickedEventHandler>g__HandleBuyMarketOption|30_0 ---
		void Gameplay_Market_Controller_MarketViewMediator___BuyButtonClickedEventHandler_g__HandleBuyMarketOption_30_0
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 in_register_20000014;
		  undefined4 param1_00;
		  undefined8 param2_00;
		  
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                        (param1,CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x14c)));
		  param2_00 = func_ii_7957(*(undefined4 *)(param2 + 8),0);
		  Gameplay_Market_Controller_MarketController__GetUserOtherMarketArtifactsResultHandler
		            (param1_00,param2_00,param1);
		  return;
		}
		*/

		/* --- GHIDRA: <InitialSelect>b__18_0 ---
		void Gameplay_Market_Controller_MarketViewMediator___InitialSelect_b__18_0
		               (int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *param1_00;
		  int iVar3;
		  
		  if (DAT_ram_00a5a03a == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a5a03a = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar3 = *param1_00;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 400);
		        goto code_r0x811b78d0;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x1a);
		code_r0x811b78d0:
		  iVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  Gameplay_Bank_Controller_BankController__RequestActivePromotions
		            (*(undefined4 *)(iVar3 + 0x24),*(undefined4 *)(param1 + 0x14),0);
		  return;
		}
		*/

		/* --- GHIDRA: .ctor ---
		void Gameplay_Market_Controller_MarketViewMediator___ctor(int param1,undefined4 param2)
		
		{
		  undefined4 param2_00;
		  int param1_00;
		  
		  Gameplay_Market_Controller_MarketViewMediator__DrawCurrentTab(param1,param1);
		  if (DAT_ram_00a5a038 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_MarketModel__MarketEvents__MarketController__MarketWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_MarketLotListElement_MarketLotListElementArgs__get_Count__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_MarketLotListElement_MarketLotListElementArgs__get_Item__
		              );
		    DAT_ram_00a5a038 = '\x01';
		  }
		  *(undefined1 *)(param1 + 0x38) = 0;
		  param1_00 = *(int *)(*(int *)(param1 + 8) + 0x18);
		  if ((0 < *(int *)(param1_00 + 0xc)) ||
		     (param1_00 = *(int *)(*(int *)(param1 + 8) + 0x1c), 0 < *(int *)(param1_00 + 0xc))) {
		    param2_00 = System_Linq_Enumerable__ToList_object_
		                          (param1_00,0,
		                           Method_System_Collections_Generic_List_MarketLotListElement_MarketLotListElementArgs__get_Item__
		                          );
		    Gameplay_Market_Controller_MarketViewMediator__MarketLotButtonClickedEventHandler
		              (param1,param2_00,param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002686 RID: 9862 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002686")]
		[Address(RVA = "0x77BF", Offset = "0x77BF", VA = "0x77BF")]
		private void MarketLotsChangedEventHandler()
		{
		/* --- GHIDRA: MarketLotsChangedEventHandler ---
		void Gameplay_Market_Controller_MarketViewMediator__MarketLotsChangedEventHandler
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a5a025 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_MarketModel__MarketEvents__MarketController__MarketWindow__set_View__
		              );
		    DAT_ram_00a5a025 = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    Gameplay_Market_Controller_MarketViewMediator__ArtifactsListChangedEventHandler(param1,param1);
		  }
		  param1[5] = param2;
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    Gameplay_Market_Controller_MarketViewMediator__ResetView(param1,param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x1700073A RID: 1850
		// (set) Token: 0x06002687 RID: 9863 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700073A")]
		public override MarketWindow View
		{
			[Token(Token = "0x6002687")]
			[Address(RVA = "0x77C0", Offset = "0x77C0", VA = "0x77C0", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x1700073B RID: 1851
		// (set) Token: 0x06002688 RID: 9864 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700073B")]
		public override MarketEvents Events
		{
			[Token(Token = "0x6002688")]
			[Address(RVA = "0x77C1", Offset = "0x77C1", VA = "0x77C1", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x06002689 RID: 9865 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002689")]
		[Address(RVA = "0x77C2", Offset = "0x77C2", VA = "0x77C2")]
		private void MarketArtifactsRequestedEventHandler()
		{
		/* --- GHIDRA: MarketArtifactsRequestedEventHandler ---
		void Gameplay_Market_Controller_MarketViewMediator__MarketArtifactsRequestedEventHandler
		               (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5a028 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_MarketModel__MarketEvents__MarketController__MarketWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Linq_Enumerable_FirstOrDefault_MarketLotListElement_MarketLotListElementArgs___
		              );
		    Mono_Security_ASN1__get_Item
		              (&System_Func_MarketLotListElement_MarketLotListElementArgs__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Market_Controller_MarketViewMediator__InitialSelect_b__18_0__);
		    DAT_ram_00a5a028 = '\x01';
		  }
		  param1_00 = *(undefined4 *)(*(int *)(param1 + 8) + 0x1c);
		  uVar1 = unnamed_function_1417
		                    (System_Func_MarketLotListElement_MarketLotListElementArgs__bool__TypeInfo);
		  System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		            (uVar1,param1,
		             Method_Gameplay_Market_Controller_MarketViewMediator__InitialSelect_b__18_0__,0);
		  iVar2 = System_Func_object__bool____ctor
		                    (param1_00,uVar1,
		                     Method_System_Linq_Enumerable_FirstOrDefault_MarketLotListElement_MarketLotListElementArgs___
		                    );
		  if (iVar2 == 0) {
		    if (DAT_ram_00a5a038 == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&
		                 Method_MVC_AbstractViewMediator_MarketModel__MarketEvents__MarketController__MarketWindow__get_Model__
		                );
		      Mono_Security_ASN1__get_Item
		                (&
		                 Method_System_Collections_Generic_List_MarketLotListElement_MarketLotListElementArgs__get_Count__
		                );
		      Mono_Security_ASN1__get_Item
		                (&
		                 Method_System_Collections_Generic_List_MarketLotListElement_MarketLotListElementArgs__get_Item__
		                );
		      DAT_ram_00a5a038 = '\x01';
		    }
		    *(undefined1 *)(param1 + 0x38) = 0;
		    iVar2 = *(int *)(*(int *)(param1 + 8) + 0x18);
		    if ((0 < *(int *)(iVar2 + 0xc)) ||
		       (iVar2 = *(int *)(*(int *)(param1 + 8) + 0x1c), 0 < *(int *)(iVar2 + 0xc))) {
		      uVar1 = System_Linq_Enumerable__ToList_object_
		                        (iVar2,0,
		                         Method_System_Collections_Generic_List_MarketLotListElement_MarketLotListElementArgs__get_Item__
		                        );
		      Gameplay_Market_Controller_MarketViewMediator__MarketLotButtonClickedEventHandler
		                (param1,uVar1,param1);
		    }
		    return;
		  }
		  Gameplay_Market_Controller_MarketViewMediator__MarketLotButtonClickedEventHandler
		            (param1,iVar2,param1);
		  return;
		}
		*/

		}

		// Token: 0x0600268A RID: 9866 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600268A")]
		[Address(RVA = "0x77C3", Offset = "0x77C3", VA = "0x77C3")]
		private void InitialSelect()
		{
		/* --- GHIDRA: InitialSelect ---
		void Gameplay_Market_Controller_MarketViewMediator__InitialSelect(int *param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5a029 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_MarketModel__MarketEvents__MarketController__MarketWindow__get_Model__
		              );
		    DAT_ram_00a5a029 = '\x01';
		  }
		  if (*(int *)(param1[2] + 0x24) != param1[7]) {
		    param1[7] = *(int *)(param1[2] + 0x24);
		    param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0x15c));
		    Gameplay_Market_View_MarketWindow__SetMarketLots(param1_00,param1[7],param1);
		    Gameplay_Market_Controller_MarketViewMediator__HandleScroll(param1,param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600268B RID: 9867 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600268B")]
		[Address(RVA = "0x77C4", Offset = "0x77C4", VA = "0x77C4")]
		private void ExtraArtifactsRequestedEventHandler()
		{
		/* --- GHIDRA: ExtraArtifactsRequestedEventHandler ---
		void Gameplay_Market_Controller_MarketViewMediator__ExtraArtifactsRequestedEventHandler
		               (int *param1,int *param2,int *param3,undefined4 param4)
		
		{
		  uint uVar1;
		  undefined4 in_register_20000014;
		  int iVar2;
		  uint *puVar3;
		  undefined4 *puVar4;
		  undefined4 uVar5;
		  int *piVar6;
		  undefined8 uVar7;
		  undefined4 uVar8;
		  int iVar9;
		  int iVar10;
		  int *piVar11;
		  int local_c;
		  int **local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a5a02a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_MarketModel__MarketEvents__MarketController__MarketWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_MarketLotListElement__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_ulong__MarketLotListElement_MarketLotListElementArgs__ContainsKey__
		              );
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_IEnumerable_MarketLotListElement_MarketLotListElementArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_IEnumerator_MarketLotListElement_MarketLotListElementArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Market_Controller_MarketViewMediator_MarketLotButtonClickedEventHandler__
		              );
		    DAT_ram_00a5a02a = '\x01';
		  }
		  local_4 = (int *)0x0;
		  iVar9 = *param1;
		  iVar2 = (**(code **)((ulonglong)*(uint *)(iVar9 + 0x158) * 4))
		                    (param1,CONCAT44(in_register_20000014,*(undefined4 *)(iVar9 + 0x15c)));
		  if (*(int *)(*(int *)(iVar2 + 0x48) + 0x3c) != 0) {
		    return;
		  }
		  uVar8 = *(undefined4 *)(param1[2] + 0x20);
		  uVar7 = func_ii_7957(*(undefined4 *)(*(int *)(param1[6] + 0xc) + 8),0);
		  iVar2 = Google_Protobuf_Collections_RepeatedField_ulong___GetEnumerator
		                    (uVar8,uVar7,
		                     Method_System_Collections_Generic_Dictionary_ulong__MarketLotListElement_MarketLotListElementArgs__ContainsKey__
		                    );
		  uVar8 = (undefined4)((ulonglong)uVar7 >> 0x20);
		  if (iVar2 == 0) {
		    if (DAT_ram_00a5a038 == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&
		                 Method_MVC_AbstractViewMediator_MarketModel__MarketEvents__MarketController__MarketWindow__get_Model__
		                );
		      Mono_Security_ASN1__get_Item
		                (&
		                 Method_System_Collections_Generic_List_MarketLotListElement_MarketLotListElementArgs__get_Count__
		                );
		      Mono_Security_ASN1__get_Item
		                (&
		                 Method_System_Collections_Generic_List_MarketLotListElement_MarketLotListElementArgs__get_Item__
		                );
		      DAT_ram_00a5a038 = '\x01';
		    }
		    *(undefined1 *)(param1 + 0xe) = 0;
		    iVar9 = *(int *)(param1[2] + 0x18);
		    if ((0 < *(int *)(iVar9 + 0xc)) ||
		       (iVar9 = *(int *)(param1[2] + 0x1c), 0 < *(int *)(iVar9 + 0xc))) {
		      uVar5 = System_Linq_Enumerable__ToList_object_
		                        (iVar9,0,
		                         Method_System_Collections_Generic_List_MarketLotListElement_MarketLotListElementArgs__get_Item__
		                        );
		      Gameplay_Market_Controller_MarketViewMediator__MarketLotButtonClickedEventHandler
		                (param1,uVar5,iVar9);
		    }
		  }
		  Gameplay_Market_Controller_MarketViewMediator__HandleExtraScroll(param1,param2,param3,iVar9);
		  param1[7] = 0;
		  if (param1[6] != 0) {
		    uVar7 = CONCAT44(uVar8,*(undefined4 *)(*param1 + 0x15c));
		    iVar9 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))(param1,uVar7);
		    iVar2 = *(int *)(*(int *)(iVar9 + 0x58) + 0x3c);
		    iVar10 = 0x30;
		    iVar9 = **(int **)(param1[6] + 0xc);
		    uVar7 = CONCAT44((int)((ulonglong)uVar7 >> 0x20),*(undefined4 *)(iVar9 + 0xf4));
		    iVar9 = (**(code **)((ulonglong)*(uint *)(iVar9 + 0xf0) * 4))(*(int **)(param1[6] + 0xc),uVar7);
		    if (iVar9 == 0) {
		      iVar10 = 0x34;
		    }
		    iVar9 = *(int *)(*(int *)((int)param1 + iVar10) + iVar2 * 4 + 0x10);
		    uVar7 = CONCAT44((int)((ulonglong)uVar7 >> 0x20),*(undefined4 *)(iVar9 + 0x14));
		    (**(code **)((ulonglong)*(uint *)(iVar9 + 0xc) * 4))(*(undefined4 *)(iVar9 + 0x20),uVar7);
		    uVar8 = (undefined4)((ulonglong)uVar7 >> 0x20);
		  }
		  uVar1 = 0;
		  iVar9 = *param2;
		  if (*(ushort *)(iVar9 + 0xb6) != 0) {
		    do {
		      if (System_Collections_Generic_IEnumerable_MarketLotListElement_MarketLotListElementArgs__TypeInfo
		          == *(int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(iVar9 + *(int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x811b61f6;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar9 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param2,
		                                System_Collections_Generic_IEnumerable_MarketLotListElement_MarketLotListElementArgs__TypeInfo
		                                ,0);
		code_r0x811b61f6:
		  uVar7 = CONCAT44(uVar8,puVar3[1]);
		  local_4 = (int *)(**(code **)((ulonglong)*puVar3 * 4))(param2,uVar7);
		  local_c = 0;
		  local_8 = &local_4;
		  do {
		    piVar6 = local_4;
		    uVar8 = (undefined4)((ulonglong)uVar7 >> 0x20);
		    iVar9 = *local_4;
		    if (*(ushort *)(iVar9 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar11 = (int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar11) {
		          puVar4 = (undefined4 *)(iVar9 + piVar11[1] * 8 + 0xc0);
		          goto code_r0x811b62bf;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar9 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar4 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_IEnumerator_TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x811b6473:
		      DAT_ram_009d3e38 = 0;
		      uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x811b647b;
		    }
		code_r0x811b62bf:
		    DAT_ram_009d3e38 = 0;
		    iVar9 = import::env::invoke_iii(*puVar4,piVar6,puVar4[1]);
		    piVar6 = local_4;
		    if (DAT_ram_009d3e38 == 1) goto code_r0x811b6473;
		    if (iVar9 == 0) {
		      iVar2 = 6;
		      iVar9 = 0;
		      goto code_r0x811b64c8;
		    }
		    iVar9 = *local_4;
		    if (*(ushort *)(iVar9 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar11 = (int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8);
		        if (System_Collections_Generic_IEnumerator_MarketLotListElement_MarketLotListElementArgs__TypeInfo
		            == *piVar11) {
		          puVar4 = (undefined4 *)(iVar9 + piVar11[1] * 8 + 0xc0);
		          goto code_r0x811b6399;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar9 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar4 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_Generic_IEnumerator_MarketLotListElement_MarketLotListElementArgs__TypeInfo
		                        ,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x811b645f:
		      DAT_ram_009d3e38 = 0;
		      uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x811b647b;
		    }
		code_r0x811b6399:
		    DAT_ram_009d3e38 = 0;
		    iVar9 = import::env::invoke_iii(*puVar4,piVar6,puVar4[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x811b645f;
		    DAT_ram_009d3e38 = 0;
		    uVar5 = import::env::invoke_ii
		                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                       System_Action_MarketLotListElement__TypeInfo);
		    if (DAT_ram_009d3e38 == 1) break;
		    DAT_ram_009d3e38 = 0;
		    uVar7 = CONCAT44(uVar8,uVar5);
		    import::env::invoke_viiii
		              (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x241,uVar5,param1,
		               Method_Gameplay_Market_Controller_MarketViewMediator_MarketLotButtonClickedEventHandler__
		               ,0);
		    uVar8 = (undefined4)((ulonglong)uVar7 >> 0x20);
		    if (DAT_ram_009d3e38 == 1) break;
		    *(undefined4 *)(iVar9 + 0x14) = uVar5;
		  } while( true );
		  DAT_ram_009d3e38 = 0;
		  uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x811b647b:
		  iVar9 = global_1;
		  iVar2 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar9 == iVar2) {
		    piVar6 = (int *)import::env::__cxa_begin_catch(uVar5);
		    iVar9 = *piVar6;
		    iVar2 = 0;
		    DAT_ram_009d3e38 = 0;
		    local_c = iVar9;
		    import::env::invoke_v(0x123);
		    iVar10 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar10 != 1) {
		code_r0x811b64c8:
		      piVar6 = local_4;
		      DAT_ram_009d3e38 = 0;
		      if (local_4 != (int *)0x0) {
		        uVar1 = 0;
		        iVar10 = *local_4;
		        if (*(ushort *)(iVar10 + 0xb6) != 0) {
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar10 + 0x58) + uVar1 * 8)) {
		              puVar3 = (uint *)(iVar10 + *(int *)(*(int *)(iVar10 + 0x58) + uVar1 * 8 + 4) * 8 +
		                               0xc0);
		              goto code_r0x811b6540;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar10 + 0xb6) != uVar1);
		        }
		        puVar3 = (uint *)func_ii_1080(local_4,System_IDisposable_TypeInfo,0);
		code_r0x811b6540:
		        uVar7 = CONCAT44(uVar8,puVar3[1]);
		        (**(code **)((ulonglong)*puVar3 * 4))(piVar6,uVar7);
		        uVar8 = (undefined4)((ulonglong)uVar7 >> 0x20);
		      }
		      if (iVar9 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(iVar9);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      if (iVar2 != 0) {
		        if (iVar2 == 1) {
		          return;
		        }
		        if (iVar2 == 2) {
		          return;
		        }
		        if (iVar2 == 3) {
		          return;
		        }
		        if (iVar2 == 4) {
		          return;
		        }
		        if (iVar2 == 5) {
		          return;
		        }
		        if (iVar2 != 6) {
		          return;
		        }
		      }
		      uVar1 = 0;
		      iVar9 = *param3;
		      if (*(ushort *)(iVar9 + 0xb6) != 0) {
		        do {
		          if (System_Collections_Generic_IEnumerable_MarketLotListElement_MarketLotListElementArgs__TypeInfo
		              == *(int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8)) {
		            puVar3 = (uint *)(iVar9 + *(int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		            goto code_r0x811b65d2;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar9 + 0xb6) != uVar1);
		      }
		      puVar3 = (uint *)func_ii_1080(param3,
		                                    System_Collections_Generic_IEnumerable_MarketLotListElement_MarketLotListElementArgs__TypeInfo
		                                    ,0);
		code_r0x811b65d2:
		      uVar7 = CONCAT44(uVar8,puVar3[1]);
		      local_4 = (int *)(**(code **)((ulonglong)*puVar3 * 4))(param3,uVar7);
		      local_c = 0;
		      local_8 = &local_4;
		      do {
		        piVar6 = local_4;
		        uVar8 = (undefined4)((ulonglong)uVar7 >> 0x20);
		        iVar9 = *local_4;
		        if (*(ushort *)(iVar9 + 0xb6) != 0) {
		          uVar1 = 0;
		          do {
		            piVar11 = (int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8);
		            if (System_Collections_IEnumerator_TypeInfo == *piVar11) {
		              puVar4 = (undefined4 *)(iVar9 + piVar11[1] * 8 + 0xc0);
		              goto code_r0x811b66cf;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar9 + 0xb6) != uVar1);
		        }
		        DAT_ram_009d3e38 = 0;
		        puVar4 = (undefined4 *)
		                 import::env::invoke_iiii
		                           (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                            System_Collections_IEnumerator_TypeInfo,0);
		        if (DAT_ram_009d3e38 == 1) {
		code_r0x811b6809:
		          DAT_ram_009d3e38 = 0;
		          uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x811b6811;
		        }
		code_r0x811b66cf:
		        DAT_ram_009d3e38 = 0;
		        iVar9 = import::env::invoke_iii(*puVar4,piVar6,puVar4[1]);
		        piVar6 = local_4;
		        if (DAT_ram_009d3e38 == 1) goto code_r0x811b6809;
		        if (iVar9 == 0) {
		          iVar9 = 0;
		          goto code_r0x811b685a;
		        }
		        iVar9 = *local_4;
		        if (*(ushort *)(iVar9 + 0xb6) != 0) {
		          uVar1 = 0;
		          do {
		            piVar11 = (int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8);
		            if (System_Collections_Generic_IEnumerator_MarketLotListElement_MarketLotListElementArgs__TypeInfo
		                == *piVar11) {
		              puVar4 = (undefined4 *)(iVar9 + piVar11[1] * 8 + 0xc0);
		              goto code_r0x811b67a9;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar9 + 0xb6) != uVar1);
		        }
		        DAT_ram_009d3e38 = 0;
		        puVar4 = (undefined4 *)
		                 import::env::invoke_iiii
		                           (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                            System_Collections_Generic_IEnumerator_MarketLotListElement_MarketLotListElementArgs__TypeInfo
		                            ,0);
		        if (DAT_ram_009d3e38 == 1) goto code_r0x811b67ff;
		code_r0x811b67a9:
		        DAT_ram_009d3e38 = 0;
		        uVar7 = CONCAT44(uVar8,piVar6);
		        iVar9 = import::env::invoke_iii(*puVar4,piVar6,puVar4[1]);
		        uVar8 = (undefined4)((ulonglong)uVar7 >> 0x20);
		        if (DAT_ram_009d3e38 == 1) goto code_r0x811b67ff;
		        *(undefined4 *)(iVar9 + 0x14) = 0;
		      } while( true );
		    }
		    uVar5 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001f04 + 0x237,&local_c);
		  goto joined_r0x811b6922;
		code_r0x811b67ff:
		  DAT_ram_009d3e38 = 0;
		  uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x811b6811:
		  iVar9 = global_1;
		  iVar2 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar9 == iVar2) {
		    piVar6 = (int *)import::env::__cxa_begin_catch(uVar5);
		    iVar9 = *piVar6;
		    DAT_ram_009d3e38 = 0;
		    local_c = iVar9;
		    import::env::invoke_v(0x123);
		    iVar2 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar2 != 1) {
		code_r0x811b685a:
		      piVar6 = local_4;
		      DAT_ram_009d3e38 = 0;
		      if (local_4 != (int *)0x0) {
		        uVar1 = 0;
		        iVar2 = *local_4;
		        if (*(ushort *)(iVar2 + 0xb6) != 0) {
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		              puVar3 = (uint *)(iVar2 + *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0)
		              ;
		              goto code_r0x811b68d2;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		        }
		        puVar3 = (uint *)func_ii_1080(local_4,System_IDisposable_TypeInfo,0);
		code_r0x811b68d2:
		        (**(code **)((ulonglong)*puVar3 * 4))(piVar6,CONCAT44(uVar8,puVar3[1]));
		      }
		      if (iVar9 == 0) {
		        return;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(iVar9);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar5 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001f04 + 0x238,&local_c);
		joined_r0x811b6922:
		  if (DAT_ram_009d3e38 != 1) {
		    DAT_ram_009d3e38 = 0;
		    import::env::__resumeException(uVar5);
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

		// Token: 0x0600268C RID: 9868 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600268C")]
		[Address(RVA = "0x77C5", Offset = "0x77C5", VA = "0x77C5")]
		private void ArtifactsListChangedEventHandler(IEnumerable<MarketLotListElement.MarketLotListElementArgs> added, IEnumerable<MarketLotListElement.MarketLotListElementArgs> removed)
		{
		/* --- GHIDRA: ArtifactsListChangedEventHandler ---
		void Gameplay_Market_Controller_MarketViewMediator__ArtifactsListChangedEventHandler
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a5a02b == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Market_Controller_MarketViewMediator_BuyButtonClickedEventHandler__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Market_Controller_MarketViewMediator_ExtraTabChangedEventHandler__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Market_Controller_MarketViewMediator_FiltersViewChangedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Market_Controller_MarketViewMediator_TabChangedEventHandler__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a5a02b = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(iVar1 + 0x48);
		  uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar2,param1,
		             Method_Gameplay_Market_Controller_MarketViewMediator_TabChangedEventHandler__,0);
		  UI_Tabs_TabBar__add_ChangeEvent(uVar3,uVar2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(iVar1 + 0x58);
		  uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar2,param1,
		             Method_Gameplay_Market_Controller_MarketViewMediator_ExtraTabChangedEventHandler__,0);
		  UI_Tabs_TabBar__add_ChangeEvent(uVar3,uVar2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(iVar1 + 0x4c);
		  uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar2,param1,
		             Method_Gameplay_Market_Controller_MarketViewMediator_FiltersViewChangedEventHandler__,0
		            );
		  UI_Filters_FiltersView__add_ChangedEvent(uVar3,uVar2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(iVar1 + 0x54);
		  uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar2,param1,
		             Method_Gameplay_Market_Controller_MarketViewMediator_FiltersViewChangedEventHandler__,0
		            );
		  UI_Filters_SubFiltersDropdown__add_ChangedEvent(uVar3,uVar2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x44) + 0x14) + 0xb4);
		  uVar2 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar2,param1,
		             Method_Gameplay_Market_Controller_MarketViewMediator_BuyButtonClickedEventHandler__,0);
		  UnityEngine_Events_UnityAction___ctor(uVar3,uVar2,0);
		  return;
		}
		*/

		}

		// Token: 0x0600268D RID: 9869 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600268D")]
		[Address(RVA = "0x77C6", Offset = "0x77C6", VA = "0x77C6")]
		private void ResetView()
		{
		/* --- GHIDRA: ResetView ---
		void Gameplay_Market_Controller_MarketViewMediator__ResetView(int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  uint *puVar4;
		  undefined4 uVar5;
		  int *param1_00;
		  
		  if (DAT_ram_00a5a02c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_MarketModel__MarketEvents__MarketController__MarketWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Market_Controller_Filters_IMarketFilter_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Market_Controller_MarketViewMediator_BuyButtonClickedEventHandler__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Market_Controller_MarketViewMediator_ExtraTabChangedEventHandler__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Market_Controller_MarketViewMediator_FiltersViewChangedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Market_Controller_MarketViewMediator_TabChangedEventHandler__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a5a02c = '\x01';
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar5 = *(undefined4 *)(iVar2 + 0x50);
		  uVar3 = Gameplay_Market_Model_MarketModel__get_FilterType(param1[2],param1);
		  UI_Filters_MetaFiltersView__set_FilterType(uVar5,4,uVar3,0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = *(int *)(iVar2 + 0x54);
		  uVar3 = Gameplay_Market_Model_MarketModel__get_FilterType(param1[2],param1);
		  *(undefined4 *)(iVar2 + 0x30) = uVar3;
		  param1_00 = (int *)param1[0xb];
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x54) + 0x48);
		  iVar2 = *param1_00;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Gameplay_Market_Controller_Filters_IMarketFilter_TypeInfo ==
		          *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 200);
		        goto code_r0x811b4c8b;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(param1_00,Gameplay_Market_Controller_Filters_IMarketFilter_TypeInfo,
		                                1);
		code_r0x811b4c8b:
		  (**(code **)((ulonglong)*puVar4 * 4))(param1_00,uVar3,puVar4[1]);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar5 = *(undefined4 *)(iVar2 + 0x48);
		  uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar3,param1,
		             Method_Gameplay_Market_Controller_MarketViewMediator_TabChangedEventHandler__,0);
		  UI_Tabs_CategoryTabBarItemView___ctor(uVar5,uVar3,0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar5 = *(undefined4 *)(iVar2 + 0x58);
		  uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar3,param1,
		             Method_Gameplay_Market_Controller_MarketViewMediator_ExtraTabChangedEventHandler__,0);
		  UI_Tabs_CategoryTabBarItemView___ctor(uVar5,uVar3,0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar5 = *(undefined4 *)(iVar2 + 0x4c);
		  uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar3,param1,
		             Method_Gameplay_Market_Controller_MarketViewMediator_FiltersViewChangedEventHandler__,0
		            );
		  UI_Filters_FiltersView__get_PriceFilterButton(uVar5,uVar3,0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar5 = *(undefined4 *)(iVar2 + 0x54);
		  uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar3,param1,
		             Method_Gameplay_Market_Controller_MarketViewMediator_FiltersViewChangedEventHandler__,0
		            );
		  UI_Filters_SimpleToggleWithData___ctor(uVar5,uVar3,0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar5 = *(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x44) + 0x14) + 0xb4);
		  uVar3 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar3,param1,
		             Method_Gameplay_Market_Controller_MarketViewMediator_BuyButtonClickedEventHandler__,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar5,uVar3,0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  UI_Tabs_TabBar__HandleSelected(*(undefined4 *)(iVar2 + 0x48),*(undefined4 *)(param1[2] + 0x30),0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  UI_Tabs_TabBar__HandleSelected(*(undefined4 *)(iVar2 + 0x58),*(undefined4 *)(param1[2] + 0x34),0);
		  Gameplay_Market_Controller_MarketViewMediator__FiltersViewChangedEventHandler(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x0600268E RID: 9870 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600268E")]
		[Address(RVA = "0x77C7", Offset = "0x77C7", VA = "0x77C7")]
		private void SetupView()
		{
		/* --- GHIDRA: SetupView ---
		void Gameplay_Market_Controller_MarketViewMediator__SetupView(int *param1,undefined4 param2)
		
		{
		  undefined4 in_register_20000014;
		  undefined4 param1_00;
		  undefined8 param2_00;
		  
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                        (param1,CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x14c)));
		  param2_00 = func_ii_7957(*(undefined4 *)(*(int *)(param1[6] + 0xc) + 8),0);
		  Gameplay_Market_Controller_MarketController__GetMarketArtifactsResultHandler
		            (param1_00,param2_00,param1);
		  return;
		}
		*/

		}

		// Token: 0x0600268F RID: 9871 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600268F")]
		[Address(RVA = "0x77C8", Offset = "0x77C8", VA = "0x77C8")]
		private void GetOtherArtifacts()
		{
		/* --- GHIDRA: GetOtherArtifacts ---
		void Gameplay_Market_Controller_MarketViewMediator__GetOtherArtifacts(int *param1,undefined4 param2)
		
		{
		  int *param3;
		  undefined4 param1_00;
		  int iVar1;
		  int local_4;
		  
		  param3 = (int *)(**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                            (param1,*(undefined4 *)(*param1 + 0x14c));
		  local_4 = param1[9];
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param3 + 0x100) * 4))
		                        (param3,*(undefined4 *)(*param3 + 0x104));
		  Gameplay_Market_Model_MarketModel__GetSimilarArtifacts(param1_00,&local_4,param3);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param3 + 0x110) * 4))
		                    (param3,*(undefined4 *)(*param3 + 0x114));
		  iVar1 = *(int *)(iVar1 + 0x18);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002690 RID: 9872 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002690")]
		[Address(RVA = "0x77C9", Offset = "0x77C9", VA = "0x77C9")]
		private void GetOtherOptionsArtifacts()
		{
		/* --- GHIDRA: GetOtherOptionsArtifacts ---
		void Gameplay_Market_Controller_MarketViewMediator__GetOtherOptionsArtifacts
		               (int *param1,undefined4 param2)
		
		{
		  int *piVar1;
		  undefined4 param1_00;
		  int iVar2;
		  undefined1 auStack_10 [8];
		  int local_8;
		  int local_4;
		  
		  piVar1 = (int *)(**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                            (param1,*(undefined4 *)(*param1 + 0x14c));
		  local_8 = param1[8];
		  local_4 = param1[6];
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*piVar1 + 0x100) * 4))
		                        (piVar1,*(undefined4 *)(*piVar1 + 0x104));
		  Gameplay_Market_Model_MarketModel__GetOptionsLots(param1_00,&local_4,&local_8,auStack_10);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*piVar1 + 0x110) * 4))
		                    (piVar1,*(undefined4 *)(*piVar1 + 0x114));
		  iVar2 = *(int *)(iVar2 + 0x18);
		  if (iVar2 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		              (*(undefined4 *)(iVar2 + 0x20),*(undefined4 *)(iVar2 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002691 RID: 9873 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002691")]
		[Address(RVA = "0x77CA", Offset = "0x77CA", VA = "0x77CA")]
		private void GetSimilarArtifacts()
		{
		/* --- GHIDRA: GetSimilarArtifacts ---
		void Gameplay_Market_Controller_MarketViewMediator__GetSimilarArtifacts
		               (int *param1,undefined4 param2)
		
		{
		  int *piVar1;
		  undefined4 param1_00;
		  int iVar2;
		  undefined1 auStack_10 [8];
		  int local_8;
		  int local_4;
		  
		  piVar1 = (int *)(**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                            (param1,*(undefined4 *)(*param1 + 0x14c));
		  local_8 = param1[9];
		  local_4 = param1[6];
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*piVar1 + 0x100) * 4))
		                        (piVar1,*(undefined4 *)(*piVar1 + 0x104));
		  Gameplay_Market_Model_MarketModel__CacheOtherArtifacts(param1_00,&local_4,&local_8,auStack_10);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*piVar1 + 0x110) * 4))
		                    (piVar1,*(undefined4 *)(*piVar1 + 0x114));
		  iVar2 = *(int *)(iVar2 + 0x18);
		  if (iVar2 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		              (*(undefined4 *)(iVar2 + 0x20),*(undefined4 *)(iVar2 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002692 RID: 9874 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002692")]
		[Address(RVA = "0x77CB", Offset = "0x77CB", VA = "0x77CB")]
		private void GetOptionsLots()
		{
		/* --- GHIDRA: GetOptionsLots ---
		void Gameplay_Market_Controller_MarketViewMediator__GetOptionsLots(int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  int iVar3;
		  undefined4 *puVar4;
		  int *piVar5;
		  uint *param2_00;
		  int iVar6;
		  int *piVar7;
		  int iVar8;
		  int local_18;
		  undefined8 *local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5a02d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_FilterInfo_FilterType__IMarketFilter__get_Item__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_FilterInfo_FilterType__IMarketFilter__get_Keys__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_KeyCollection_Enumerator_FilterInfo_FilterType__IMarketFilter__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_KeyCollection_Enumerator_FilterInfo_FilterType__IMarketFilter__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_KeyCollection_Enumerator_FilterInfo_FilterType__IMarketFilter__get_Current__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Market_Controller_Filters_IMarketFilter_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_KeyCollection_FilterInfo_FilterType__IMarketFilter__GetEnumerator__
		              );
		    DAT_ram_00a5a02d = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  Gameplay_Market_Controller_MarketViewMediator__FiltersViewChangedEventHandler(param1,0);
		  uVar2 = System_Collections_Generic_Dictionary_TypeConverterRegistry_ConverterKey__object___System_Collections_Generic_ICollection_System_Collections_Generic_KeyValuePair_TKey_TValue___get_IsReadOnly
		                    (param1[10],
		                     Method_System_Collections_Generic_Dictionary_FilterInfo_FilterType__IMarketFilter__get_Keys__
		                    );
		  System_Collections_Generic_Dictionary_Int32Enum__object___get_Values
		            (&local_10,uVar2,
		             Method_System_Collections_Generic_Dictionary_KeyCollection_FilterInfo_FilterType__IMarketFilter__GetEnumerator__
		            );
		  local_18 = 0;
		  local_14 = &local_10;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar3 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x96,&local_10,
		                       Method_System_Collections_Generic_Dictionary_KeyCollection_Enumerator_FilterInfo_FilterType__IMarketFilter__MoveNext__
		                      );
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x811b6e9e;
		    }
		    if (iVar3 == 0) goto code_r0x811b6ef4;
		    DAT_ram_009d3e38 = 0;
		    piVar5 = (int *)import::env::invoke_iiii
		                              (s_struct_Uniforms___color__array<v_ram_00000aff + 0x151,param1[10],
		                               local_8._4_4_,
		                               Method_System_Collections_Generic_Dictionary_FilterInfo_FilterType__IMarketFilter__get_Item__
		                              );
		    if (DAT_ram_009d3e38 == 1) break;
		    iVar6 = *piVar5;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar7 = (int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8);
		        if (Gameplay_Market_Controller_Filters_IMarketFilter_TypeInfo == *piVar7) {
		          puVar4 = (undefined4 *)(piVar7[1] * 8 + iVar6 + 0xd8);
		          goto code_r0x811b6e41;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar4 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar5,
		                        Gameplay_Market_Controller_Filters_IMarketFilter_TypeInfo,3);
		    if (DAT_ram_009d3e38 == 1) break;
		code_r0x811b6e41:
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_vii(*puVar4,piVar5,puVar4[1]);
		  } while (DAT_ram_009d3e38 != 1);
		  DAT_ram_009d3e38 = 0;
		  uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x811b6e9e:
		  iVar6 = global_1;
		  iVar3 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar6 == iVar3) {
		    piVar5 = (int *)import::env::__cxa_begin_catch(uVar2);
		    iVar3 = *piVar5;
		    DAT_ram_009d3e38 = 0;
		    local_18 = iVar3;
		    import::env::invoke_v(0x123);
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 != 1) {
		      if (iVar3 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(iVar3);
		        do {
		          halt_trap();
		        } while( true );
		      }
		code_r0x811b6ef4:
		      DAT_ram_009d3e38 = 0;
		      uVar1 = 0;
		      piVar5 = (int *)param1[0xb];
		      iVar6 = *piVar5;
		      if (*(ushort *)(iVar6 + 0xb6) != 0) {
		        do {
		          if (Gameplay_Market_Controller_Filters_IMarketFilter_TypeInfo ==
		              *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		            param2_00 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0xd8
		                                );
		            goto code_r0x811b6f66;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		      }
		      param2_00 = (uint *)func_ii_1080(piVar5,
		                                       Gameplay_Market_Controller_Filters_IMarketFilter_TypeInfo,3);
		code_r0x811b6f66:
		      (**(code **)((ulonglong)*param2_00 * 4))(piVar5,param2_00[1]);
		      Gameplay_Market_Controller_MarketViewMediator__DrawCurrentTab(param1,param2_00);
		      if (param1[6] != 0) {
		        iVar6 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0x15c));
		        iVar3 = *(int *)(*(int *)(iVar6 + 0x58) + 0x3c);
		        iVar8 = 0x30;
		        iVar6 = **(int **)(param1[6] + 0xc);
		        iVar6 = (**(code **)((ulonglong)*(uint *)(iVar6 + 0xf0) * 4))
		                          (*(int **)(param1[6] + 0xc),*(undefined4 *)(iVar6 + 0xf4));
		        if (iVar6 == 0) {
		          iVar8 = 0x34;
		        }
		        iVar6 = *(int *)(*(int *)((int)param1 + iVar8) + iVar3 * 4 + 0x10);
		        (**(code **)((ulonglong)*(uint *)(iVar6 + 0xc) * 4))
		                  (*(undefined4 *)(iVar6 + 0x20),*(undefined4 *)(iVar6 + 0x14));
		      }
		      return;
		    }
		    uVar2 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001f04 + 0x239,&local_18);
		  iVar6 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar6 == 1) {
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

		// Token: 0x06002693 RID: 9875 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002693")]
		[Address(RVA = "0x77CC", Offset = "0x77CC", VA = "0x77CC")]
		private void FiltersViewChangedEventHandler()
		{
		/* --- GHIDRA: FiltersViewChangedEventHandler ---
		void Gameplay_Market_Controller_MarketViewMediator__FiltersViewChangedEventHandler
		               (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  int iVar3;
		  undefined4 *puVar4;
		  int *piVar5;
		  int iVar6;
		  int *piVar7;
		  int local_18;
		  undefined8 *local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5a02e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_FilterInfo_FilterType__IMarketFilter__get_Item__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_FilterInfo_FilterType__FilterInfo__get_Item__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_FilterInfo_FilterType__IMarketFilter__get_Keys__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_KeyCollection_Enumerator_FilterInfo_FilterType__IMarketFilter__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_KeyCollection_Enumerator_FilterInfo_FilterType__IMarketFilter__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_KeyCollection_Enumerator_FilterInfo_FilterType__IMarketFilter__get_Current__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Market_Controller_Filters_IMarketFilter_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_KeyCollection_FilterInfo_FilterType__IMarketFilter__GetEnumerator__
		              );
		    DAT_ram_00a5a02e = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  uVar2 = System_Collections_Generic_Dictionary_TypeConverterRegistry_ConverterKey__object___System_Collections_Generic_ICollection_System_Collections_Generic_KeyValuePair_TKey_TValue___get_IsReadOnly
		                    (param1[10],
		                     Method_System_Collections_Generic_Dictionary_FilterInfo_FilterType__IMarketFilter__get_Keys__
		                    );
		  System_Collections_Generic_Dictionary_Int32Enum__object___get_Values
		            (&local_10,uVar2,
		             Method_System_Collections_Generic_Dictionary_KeyCollection_FilterInfo_FilterType__IMarketFilter__GetEnumerator__
		            );
		  local_18 = 0;
		  local_14 = &local_10;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar3 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x96,&local_10,
		                       Method_System_Collections_Generic_Dictionary_KeyCollection_Enumerator_FilterInfo_FilterType__IMarketFilter__MoveNext__
		                      );
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x811b5108;
		    }
		    if (iVar3 == 0) {
		      DAT_ram_009d3e38 = 0;
		      return;
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar2 = local_8._4_4_;
		    piVar5 = (int *)import::env::invoke_iiii
		                              (s_struct_Uniforms___color__array<v_ram_00000aff + 0x151,param1[10],
		                               local_8._4_4_,
		                               Method_System_Collections_Generic_Dictionary_FilterInfo_FilterType__IMarketFilter__get_Item__
		                              );
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x811b5108;
		    }
		    DAT_ram_009d3e38 = 0;
		    iVar3 = import::env::invoke_iii
		                      (*(undefined4 *)(*param1 + 0x158),param1,*(undefined4 *)(*param1 + 0x15c));
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 == 1) {
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x811b5108;
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar2 = import::env::invoke_iiii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x151,
		                       *(undefined4 *)(*(int *)(iVar3 + 0x4c) + 0x38),uVar2,
		                       Method_System_Collections_Generic_Dictionary_FilterInfo_FilterType__FilterInfo__get_Item__
		                      );
		    if (DAT_ram_009d3e38 == 1) break;
		    iVar6 = *piVar5;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar7 = (int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8);
		        if (Gameplay_Market_Controller_Filters_IMarketFilter_TypeInfo == *piVar7) {
		          puVar4 = (undefined4 *)(piVar7[1] * 8 + iVar6 + 200);
		          goto code_r0x811b5095;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar4 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar5,
		                        Gameplay_Market_Controller_Filters_IMarketFilter_TypeInfo,1);
		    if (DAT_ram_009d3e38 == 1) break;
		code_r0x811b5095:
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii(*puVar4,piVar5,uVar2,puVar4[1]);
		  } while (DAT_ram_009d3e38 != 1);
		  DAT_ram_009d3e38 = 0;
		  uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x811b5108:
		  iVar6 = global_1;
		  iVar3 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar6 == iVar3) {
		    piVar5 = (int *)import::env::__cxa_begin_catch(uVar2);
		    iVar3 = *piVar5;
		    DAT_ram_009d3e38 = 0;
		    local_18 = iVar3;
		    import::env::invoke_v(0x123);
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 != 1) {
		      if (iVar3 == 0) {
		        DAT_ram_009d3e38 = 0;
		        return;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(iVar3);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar2 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001f04 + 0x234,&local_18);
		  iVar6 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar6 != 1) {
		    import::env::__resumeException(uVar2);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  import::env::__cxa_find_matching_catch_3(0);
		  unnamed_function_937();
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06002694 RID: 9876 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002694")]
		[Address(RVA = "0x77CD", Offset = "0x77CD", VA = "0x77CD")]
		private void SetFiltersData()
		{
		/* --- GHIDRA: SetFiltersData ---
		int Gameplay_Market_Controller_MarketViewMediator__SetFiltersData
		              (int param1,undefined4 *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int iVar4;
		  uint *puVar5;
		  undefined4 *puVar6;
		  int iVar7;
		  int *piVar8;
		  int iVar9;
		  int iVar10;
		  int *piVar11;
		  int local_c;
		  int **local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a5a02f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_FilterInfo_FilterType__IMarketFilter__get_Values__
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToArray_IMarketFilter___);
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_IEnumerable_MarketLotListElement_MarketLotListElementArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_IEnumerator_MarketLotListElement_MarketLotListElementArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Market_Controller_Filters_IMarketFilter_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_MarketLotListElement_MarketLotListElementArgs__Add__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_MarketLotListElement_MarketLotListElementArgs___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_List_MarketLotListElement_MarketLotListElementArgs__TypeInfo
		              );
		    DAT_ram_00a5a02f = '\x01';
		  }
		  iVar2 = unnamed_function_1417
		                    (
		                    System_Collections_Generic_List_MarketLotListElement_MarketLotListElementArgs__TypeInfo
		                    );
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (iVar2,
		             Method_System_Collections_Generic_List_MarketLotListElement_MarketLotListElementArgs___ctor__
		            );
		  uVar3 = System_Collections_Generic_Dictionary_int__object___TryAdd
		                    (*(undefined4 *)(param1 + 0x28),
		                     Method_System_Collections_Generic_Dictionary_FilterInfo_FilterType__IMarketFilter__get_Values__
		                    );
		  iVar4 = func_ii_6295(uVar3,Method_System_Linq_Enumerable_ToArray_IMarketFilter___);
		  piVar8 = (int *)*param2;
		  iVar9 = *piVar8;
		  if (*(ushort *)(iVar9 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (System_Collections_Generic_IEnumerable_MarketLotListElement_MarketLotListElementArgs__TypeInfo
		          == *(int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8)) {
		        puVar5 = (uint *)(iVar9 + *(int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x811b715b;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar9 + 0xb6) != uVar1);
		  }
		  puVar5 = (uint *)func_ii_1080(piVar8,
		                                System_Collections_Generic_IEnumerable_MarketLotListElement_MarketLotListElementArgs__TypeInfo
		                                ,0);
		code_r0x811b715b:
		  local_4 = (int *)(**(code **)((ulonglong)*puVar5 * 4))(piVar8,puVar5[1]);
		  local_c = 0;
		  local_8 = &local_4;
		code_r0x811b7186:
		  do {
		    do {
		      piVar8 = local_4;
		      iVar9 = *local_4;
		      if (*(ushort *)(iVar9 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          piVar11 = (int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8);
		          if (System_Collections_IEnumerator_TypeInfo == *piVar11) {
		            puVar6 = (undefined4 *)(iVar9 + piVar11[1] * 8 + 0xc0);
		            goto code_r0x811b722c;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar9 + 0xb6) != uVar1);
		      }
		      DAT_ram_009d3e38 = 0;
		      puVar6 = (undefined4 *)
		               import::env::invoke_iiii
		                         (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                          System_Collections_IEnumerator_TypeInfo,0);
		      if (DAT_ram_009d3e38 == 1) {
		code_r0x811b7270:
		        DAT_ram_009d3e38 = 0;
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x811b75f8;
		      }
		code_r0x811b722c:
		      DAT_ram_009d3e38 = 0;
		      iVar9 = import::env::invoke_iii(*puVar6,piVar8,puVar6[1]);
		      piVar8 = local_4;
		      if (DAT_ram_009d3e38 == 1) goto code_r0x811b7270;
		      if (iVar9 == 0) goto code_r0x811b7641;
		      iVar9 = *local_4;
		      if (*(ushort *)(iVar9 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          piVar11 = (int *)(*(int *)(iVar9 + 0x58) + uVar1 * 8);
		          if (System_Collections_Generic_IEnumerator_MarketLotListElement_MarketLotListElementArgs__TypeInfo
		              == *piVar11) {
		            puVar6 = (undefined4 *)(iVar9 + piVar11[1] * 8 + 0xc0);
		            goto code_r0x811b7317;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar9 + 0xb6) != uVar1);
		      }
		      DAT_ram_009d3e38 = 0;
		      puVar6 = (undefined4 *)
		               import::env::invoke_iiii
		                         (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                          System_Collections_Generic_IEnumerator_MarketLotListElement_MarketLotListElementArgs__TypeInfo
		                          ,0);
		      if (DAT_ram_009d3e38 == 1) {
		code_r0x811b75e6:
		        DAT_ram_009d3e38 = 0;
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x811b75f8;
		      }
		code_r0x811b7317:
		      DAT_ram_009d3e38 = 0;
		      iVar9 = import::env::invoke_iii(*puVar6,piVar8,puVar6[1]);
		      if (DAT_ram_009d3e38 == 1) goto code_r0x811b75e6;
		      if (0 < *(int *)(iVar4 + 0xc)) {
		        iVar10 = 0;
		        do {
		          uVar3 = *(undefined4 *)(iVar9 + 0xc);
		          piVar8 = *(int **)(iVar4 + iVar10 * 4 + 0x10);
		          iVar7 = *piVar8;
		          if (*(ushort *)(iVar7 + 0xb6) != 0) {
		            uVar1 = 0;
		            do {
		              piVar11 = (int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8);
		              if (Gameplay_Market_Controller_Filters_IMarketFilter_TypeInfo == *piVar11) {
		                puVar6 = (undefined4 *)(piVar11[1] * 8 + iVar7 + 0xd0);
		                goto code_r0x811b740a;
		              }
		              uVar1 = uVar1 + 1;
		            } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		          }
		          DAT_ram_009d3e38 = 0;
		          puVar6 = (undefined4 *)
		                   import::env::invoke_iiii
		                             (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar8,
		                              Gameplay_Market_Controller_Filters_IMarketFilter_TypeInfo,2);
		          if (DAT_ram_009d3e38 == 1) {
		code_r0x811b75f0:
		            DAT_ram_009d3e38 = 0;
		            uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x811b75f8;
		          }
		code_r0x811b740a:
		          DAT_ram_009d3e38 = 0;
		          iVar7 = import::env::invoke_iiii(*puVar6,piVar8,uVar3,puVar6[1]);
		          if (DAT_ram_009d3e38 == 1) goto code_r0x811b75f0;
		          if (iVar7 == 0) goto code_r0x811b7186;
		          iVar10 = iVar10 + 1;
		        } while (iVar10 < *(int *)(iVar4 + 0xc));
		      }
		      uVar3 = *(undefined4 *)(iVar9 + 0xc);
		      piVar8 = *(int **)(param1 + 0x2c);
		      iVar10 = *piVar8;
		      if (*(ushort *)(iVar10 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          piVar11 = (int *)(*(int *)(iVar10 + 0x58) + uVar1 * 8);
		          if (Gameplay_Market_Controller_Filters_IMarketFilter_TypeInfo == *piVar11) {
		            puVar6 = (undefined4 *)(piVar11[1] * 8 + iVar10 + 0xd0);
		            goto code_r0x811b7503;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar10 + 0xb6) != uVar1);
		      }
		      DAT_ram_009d3e38 = 0;
		      puVar6 = (undefined4 *)
		               import::env::invoke_iiii
		                         (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,piVar8,
		                          Gameplay_Market_Controller_Filters_IMarketFilter_TypeInfo,2);
		      if (DAT_ram_009d3e38 == 1) {
		code_r0x811b7549:
		        DAT_ram_009d3e38 = 0;
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x811b75f8;
		      }
		code_r0x811b7503:
		      DAT_ram_009d3e38 = 0;
		      iVar7 = import::env::invoke_iiii(*puVar6,piVar8,uVar3,puVar6[1]);
		      iVar10 = 
		      Method_System_Collections_Generic_List_MarketLotListElement_MarketLotListElementArgs__Add__;
		      if (DAT_ram_009d3e38 == 1) goto code_r0x811b7549;
		    } while (iVar7 == 0);
		    *(int *)(iVar2 + 0x10) = *(int *)(iVar2 + 0x10) + 1;
		    uVar1 = *(uint *)(iVar2 + 0xc);
		    if (uVar1 < *(uint *)(*(int *)(iVar2 + 8) + 0xc)) {
		      *(uint *)(iVar2 + 0xc) = uVar1 + 1;
		      *(int *)(*(int *)(iVar2 + 8) + uVar1 * 4 + 0x10) = iVar9;
		      goto code_r0x811b7186;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,iVar2,iVar9,
		               *(undefined4 *)(*(int *)(*(int *)(iVar10 + 0x10) + 0x60) + 0x38));
		    iVar9 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		  } while (iVar9 != 1);
		  uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x811b75f8:
		  iVar4 = global_1;
		  iVar9 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar4 == iVar9) {
		    piVar8 = (int *)import::env::__cxa_begin_catch(uVar3);
		    local_c = *piVar8;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_v(0x123);
		    iVar4 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar4 != 1) {
		code_r0x811b7641:
		      DAT_ram_009d3e38 = 0;
		      piVar8 = *local_8;
		      if (piVar8 != (int *)0x0) {
		        uVar1 = 0;
		        iVar4 = *piVar8;
		        if (*(ushort *)(iVar4 + 0xb6) != 0) {
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		              puVar5 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0)
		              ;
		              goto code_r0x811b76bc;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		        }
		        puVar5 = (uint *)func_ii_1080(piVar8,System_IDisposable_TypeInfo,0);
		code_r0x811b76bc:
		        (**(code **)((ulonglong)*puVar5 * 4))(piVar8,puVar5[1]);
		      }
		      if (local_c == 0) {
		        return iVar2;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(local_c);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar3 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001f04 + 0x23a,&local_c);
		  iVar2 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar2 == 1) {
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  import::env::__resumeException(uVar3);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06002695 RID: 9877 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002695")]
		[Address(RVA = "0x77CE", Offset = "0x77CE", VA = "0x77CE")]
		private List<MarketLotListElement.MarketLotListElementArgs> FilterLots(in IList<MarketLotListElement.MarketLotListElementArgs> rawData)
		{
		/* --- GHIDRA: FilterLots ---
		void Gameplay_Market_Controller_MarketViewMediator__FilterLots(int *param1,undefined4 param2)
		
		{
		  int *param1_00;
		  undefined4 in_register_20000014;
		  undefined4 param1_01;
		  undefined8 param2_00;
		  int *piVar1;
		  int iVar2;
		  
		  param1_00 = (int *)0x0;
		  if (DAT_ram_00a5a030 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Market_Model_Data_MarketOptionData_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Market_Model_Data_UserMarketLotData_TypeInfo);
		    DAT_ram_00a5a030 = '\x01';
		  }
		  piVar1 = *(int **)(param1[6] + 0xc);
		  if (piVar1 != (int *)0x0) {
		    iVar2 = *piVar1;
		    if (((uint)*(byte *)(Gameplay_Market_Model_Data_UserMarketLotData_TypeInfo + 0xb8) <=
		         (uint)*(byte *)(iVar2 + 0xb8)) &&
		       (*(int *)(*(int *)(iVar2 + 100) +
		                 (uint)*(byte *)(Gameplay_Market_Model_Data_UserMarketLotData_TypeInfo + 0xb8) * 4 +
		                -4) == Gameplay_Market_Model_Data_UserMarketLotData_TypeInfo)) {
		      iVar2 = *param1;
		      param1_01 = (**(code **)((ulonglong)*(uint *)(iVar2 + 0x148) * 4))
		                            (param1,CONCAT44(in_register_20000014,*(undefined4 *)(iVar2 + 0x14c)));
		      param2_00 = func_ii_7957(piVar1[2],0);
		      Gameplay_Market_Controller_MarketController__GetUserOtherMarketArtifactsResultHandler
		                (param1_01,param2_00,iVar2);
		      return;
		    }
		    param1_00 = (int *)0x0;
		    if (((uint)*(byte *)(Gameplay_Market_Model_Data_MarketOptionData_TypeInfo + 0xb8) <=
		         (uint)*(byte *)(iVar2 + 0xb8)) &&
		       (param1_00 = piVar1,
		       *(int *)(*(int *)(iVar2 + 100) +
		                (uint)*(byte *)(Gameplay_Market_Model_Data_MarketOptionData_TypeInfo + 0xb8) * 4 +
		               -4) != Gameplay_Market_Model_Data_MarketOptionData_TypeInfo)) {
		      param1_00 = (int *)0x0;
		    }
		  }
		  Gameplay_Market_Controller_MarketViewMediator___InitialSelect_b__18_0(param1_00,param1_00);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06002696 RID: 9878 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002696")]
		[Address(RVA = "0x77CF", Offset = "0x77CF", VA = "0x77CF")]
		private void BuyButtonClickedEventHandler()
		{
		/* --- GHIDRA: BuyButtonClickedEventHandler ---
		void Gameplay_Market_Controller_MarketViewMediator__BuyButtonClickedEventHandler
		               (undefined4 param1,undefined4 param2)
		
		{
		  Gameplay_Market_Controller_MarketViewMediator__DrawCurrentTab(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06002697 RID: 9879 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002697")]
		[Address(RVA = "0x77D0", Offset = "0x77D0", VA = "0x77D0")]
		private void TabChangedEventHandler()
		{
		}

		// Token: 0x06002698 RID: 9880 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002698")]
		[Address(RVA = "0x77D1", Offset = "0x77D1", VA = "0x77D1")]
		private void ExtraTabChangedEventHandler()
		{
		/* --- GHIDRA: ExtraTabChangedEventHandler ---
		void Gameplay_Market_Controller_MarketViewMediator__ExtraTabChangedEventHandler
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  int iVar2;
		  int iVar3;
		  
		  if (param1[6] != 0) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    iVar2 = *(int *)(*(int *)(iVar1 + 0x58) + 0x3c);
		    iVar3 = 0x30;
		    iVar1 = **(int **)(param1[6] + 0xc);
		    iVar1 = (**(code **)((ulonglong)*(uint *)(iVar1 + 0xf0) * 4))
		                      (*(int **)(param1[6] + 0xc),*(undefined4 *)(iVar1 + 0xf4));
		    if (iVar1 == 0) {
		      iVar3 = 0x34;
		    }
		    iVar1 = *(int *)(*(int *)((int)param1 + iVar3) + iVar2 * 4 + 0x10);
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002699 RID: 9881 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002699")]
		[Address(RVA = "0x77D2", Offset = "0x77D2", VA = "0x77D2")]
		private void UpdateExtraArtifacts()
		{
		/* --- GHIDRA: UpdateExtraArtifacts ---
		void Gameplay_Market_Controller_MarketViewMediator__UpdateExtraArtifacts
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  int iVar2;
		  int iVar3;
		  
		  param1[7] = 0;
		  if (param1[6] != 0) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    iVar2 = *(int *)(*(int *)(iVar1 + 0x58) + 0x3c);
		    iVar3 = 0x30;
		    iVar1 = **(int **)(param1[6] + 0xc);
		    iVar1 = (**(code **)((ulonglong)*(uint *)(iVar1 + 0xf0) * 4))
		                      (*(int **)(param1[6] + 0xc),*(undefined4 *)(iVar1 + 0xf4));
		    if (iVar1 == 0) {
		      iVar3 = 0x34;
		    }
		    iVar1 = *(int *)(*(int *)((int)param1 + iVar3) + iVar2 * 4 + 0x10);
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600269A RID: 9882 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600269A")]
		[Address(RVA = "0x77D3", Offset = "0x77D3", VA = "0x77D3")]
		private void ForceUpdateExtraArtifacts()
		{
		/* --- GHIDRA: ForceUpdateExtraArtifacts ---
		void Gameplay_Market_Controller_MarketViewMediator__ForceUpdateExtraArtifacts
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 param2_00;
		  int iVar1;
		  int iVar2;
		  int iVar3;
		  
		  if (DAT_ram_00a5a031 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_MarketLotListElement_MarketLotListElementArgs__IndexOf__
		              );
		    DAT_ram_00a5a031 = '\x01';
		  }
		  iVar2 = **(int **)(param1[6] + 0xc);
		  param2_00 = (**(code **)((ulonglong)*(uint *)(iVar2 + 0xf0) * 4))
		                        (*(int **)(param1[6] + 0xc),*(undefined4 *)(iVar2 + 0xf4));
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar1 = *(int *)(*(int *)(iVar2 + 0x48) + 0x3c);
		  iVar2 = **(int **)(param1[6] + 0xc);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(iVar2 + 0xf0) * 4))
		                    (*(int **)(param1[6] + 0xc),*(undefined4 *)(iVar2 + 0xf4));
		  if (iVar1 != iVar2) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    Gameplay_GameEvents_Model_GameEventData__get_ContainsArtifactRewards
		              (*(undefined4 *)(iVar2 + 0x48),param2_00,0,0);
		  }
		  iVar2 = **(int **)(param1[6] + 0xc);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(iVar2 + 0xf0) * 4))
		                    (*(int **)(param1[6] + 0xc),*(undefined4 *)(iVar2 + 0xf4));
		  if (iVar2 == 0) {
		    iVar2 = UnityEngine_UIElements_RadioButtonGroup__GetAllRadioButtons
		                      (param1[8],param1[6],
		                       Method_System_Collections_Generic_List_MarketLotListElement_MarketLotListElementArgs__IndexOf__
		                      );
		    if (-1 < iVar2) {
		      iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      iVar3 = **(int **)(iVar1 + 0x3c);
		      (**(code **)((ulonglong)*(uint *)(iVar3 + 0x390) * 4))
		                (*(int **)(iVar1 + 0x3c),iVar2,0,0,*(undefined4 *)(iVar3 + 0x394));
		      return;
		    }
		  }
		  else {
		    iVar2 = **(int **)(param1[6] + 0xc);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(iVar2 + 0xf0) * 4))
		                      (*(int **)(param1[6] + 0xc),*(undefined4 *)(iVar2 + 0xf4));
		    if ((iVar2 == 1) &&
		       (iVar2 = UnityEngine_UIElements_RadioButtonGroup__GetAllRadioButtons
		                          (param1[9],param1[6],
		                           Method_System_Collections_Generic_List_MarketLotListElement_MarketLotListElementArgs__IndexOf__
		                          ), -1 < iVar2)) {
		      iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      iVar3 = **(int **)(iVar1 + 0x3c);
		      (**(code **)((ulonglong)*(uint *)(iVar3 + 0x390) * 4))
		                (*(int **)(iVar1 + 0x3c),iVar2,0,0,*(undefined4 *)(iVar3 + 0x394));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600269B RID: 9883 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600269B")]
		[Address(RVA = "0x77D4", Offset = "0x77D4", VA = "0x77D4")]
		private void HandleScroll()
		{
		/* --- GHIDRA: HandleScroll ---
		void Gameplay_Market_Controller_MarketViewMediator__HandleScroll(int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int iVar3;
		  int *param1_00;
		  int iVar4;
		  int iVar5;
		  
		  if (DAT_ram_00a5a032 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_MarketModel__MarketEvents__MarketController__MarketWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_IList_MarketLotListElement_MarketLotListElementArgs__TypeInfo
		              );
		    DAT_ram_00a5a032 = '\x01';
		  }
		  iVar3 = param1[6];
		  param1_00 = *(int **)(param1[2] + 0x24);
		  iVar4 = *param1_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (System_Collections_Generic_IList_MarketLotListElement_MarketLotListElementArgs__TypeInfo
		          == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xd0);
		        goto code_r0x811b5f80;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,
		                                System_Collections_Generic_IList_MarketLotListElement_MarketLotListElementArgs__TypeInfo
		                                ,2);
		code_r0x811b5f80:
		  iVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,iVar3,puVar2[1]);
		  if (-1 < iVar3) {
		    iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    iVar5 = **(int **)(iVar4 + 0x40);
		    (**(code **)((ulonglong)*(uint *)(iVar5 + 0x390) * 4))
		              (*(int **)(iVar4 + 0x40),iVar3,0,0,*(undefined4 *)(iVar5 + 0x394));
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600269C RID: 9884 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600269C")]
		[Address(RVA = "0x77D5", Offset = "0x77D5", VA = "0x77D5")]
		private void HandleExtraScroll()
		{
		/* --- GHIDRA: HandleExtraScroll ---
		void Gameplay_Market_Controller_MarketViewMediator__HandleExtraScroll
		               (int *param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  int iVar1;
		  int *param1_00;
		  
		  if (DAT_ram_00a5a033 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_Tabs_TabBarItemData_MarketLotData_DataType__get_Data__);
		    Mono_Security_ASN1__get_Item(&UI_Tabs_TabBarItemData_MarketLotData_DataType__TypeInfo);
		    DAT_ram_00a5a033 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param1_00 = (int *)UI_Tabs_TabBar__get_SelectedIndex(*(undefined4 *)(iVar1 + 0x48),0);
		  if (param1_00 != (int *)0x0) {
		    if (((uint)*(byte *)(*param1_00 + 0xb8) <
		         (uint)*(byte *)(UI_Tabs_TabBarItemData_MarketLotData_DataType__TypeInfo + 0xb8)) ||
		       (*(int *)(*(int *)(*param1_00 + 100) +
		                 (uint)*(byte *)(UI_Tabs_TabBarItemData_MarketLotData_DataType__TypeInfo + 0xb8) * 4
		                + -4) != UI_Tabs_TabBarItemData_MarketLotData_DataType__TypeInfo)) {
		      System_Activator__CreateInstance
		                (param1_00,UI_Tabs_TabBarItemData_MarketLotData_DataType__TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  if (param1_00[8] == 0) {
		    Gameplay_Market_Controller_MarketViewMediator__DrawCurrentTab(param1,param1,param3,param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600269D RID: 9885 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600269D")]
		[Address(RVA = "0x77D6", Offset = "0x77D6", VA = "0x77D6")]
		private void DrawCurrentTab(IEnumerable<MarketLotListElement.MarketLotListElementArgs> added, IEnumerable<MarketLotListElement.MarketLotListElementArgs> removed)
		{
		/* --- GHIDRA: DrawCurrentTab ---
		void Gameplay_Market_Controller_MarketViewMediator__DrawCurrentTab
		               (int *param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a5a035 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_MarketModel__MarketEvents__MarketController__MarketWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_MarketLotListElement_MarketLotListElementArgs__get_Count__
		              );
		    DAT_ram_00a5a035 = '\x01';
		  }
		  local_4 = *(undefined4 *)(param1[2] + 0x1c);
		  iVar1 = Gameplay_Market_Controller_MarketViewMediator__SetFiltersData(param1,&local_4,param1);
		  param1[9] = iVar1;
		  local_4 = *(undefined4 *)(param1[2] + 0x18);
		  iVar1 = Gameplay_Market_Controller_MarketViewMediator__SetFiltersData(param1,&local_4,param1);
		  param1[8] = iVar1;
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_Market_View_MarketWindow__Init(param1_00,param1[8],param1,param3,param1);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  UI_Filters_FiltersView__AchievedToggleOnChangedEvent
		            (*(undefined4 *)(iVar1 + 0x4c),*(undefined4 *)(param1[8] + 0xc),
		             *(undefined4 *)(*(int *)(param1[2] + 0x18) + 0xc),0);
		  return;
		}
		*/

		/* --- GHIDRA: DrawCurrentTab ---
		void Gameplay_Market_Controller_MarketViewMediator__DrawCurrentTab
		               (int *param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a5a035 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_MarketModel__MarketEvents__MarketController__MarketWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_MarketLotListElement_MarketLotListElementArgs__get_Count__
		              );
		    DAT_ram_00a5a035 = '\x01';
		  }
		  local_4 = *(undefined4 *)(param1[2] + 0x1c);
		  iVar1 = Gameplay_Market_Controller_MarketViewMediator__SetFiltersData(param1,&local_4,param1);
		  param1[9] = iVar1;
		  local_4 = *(undefined4 *)(param1[2] + 0x18);
		  iVar1 = Gameplay_Market_Controller_MarketViewMediator__SetFiltersData(param1,&local_4,param1);
		  param1[8] = iVar1;
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_Market_View_MarketWindow__Init(param1_00,param1[8],param1,param3,param1);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  UI_Filters_FiltersView__AchievedToggleOnChangedEvent
		            (*(undefined4 *)(iVar1 + 0x4c),*(undefined4 *)(param1[8] + 0xc),
		             *(undefined4 *)(*(int *)(param1[2] + 0x18) + 0xc),0);
		  return;
		}
		*/

		}

		// Token: 0x0600269E RID: 9886 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600269E")]
		[Address(RVA = "0x77D7", Offset = "0x77D7", VA = "0x77D7")]
		private void DrawCurrentTab()
		{
		}

		// Token: 0x0600269F RID: 9887 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600269F")]
		[Address(RVA = "0x77D8", Offset = "0x77D8", VA = "0x77D8")]
		private void DrawUserLots([CanBeNull] IEnumerable<MarketLotListElement.MarketLotListElementArgs> added, [CanBeNull] IEnumerable<MarketLotListElement.MarketLotListElementArgs> removed)
		{
		/* --- GHIDRA: DrawUserLots ---
		void Gameplay_Market_Controller_MarketViewMediator__DrawUserLots
		               (int param1,int param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a5a036 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_GenericListElement_MarketLotListElement_MarketLotListElementArgs__get_args__
		              );
		    DAT_ram_00a5a036 = '\x01';
		  }
		  *(undefined1 *)(param1 + 0x38) = *(undefined1 *)(param2 + 0x34);
		  Gameplay_Market_Controller_MarketViewMediator__MarketLotButtonClickedEventHandler
		            (param1,*(undefined4 *)(param2 + 0x18),param2);
		  return;
		}
		*/

		}

		// Token: 0x060026A0 RID: 9888 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026A0")]
		[Address(RVA = "0x77D9", Offset = "0x77D9", VA = "0x77D9")]
		private void MarketLotButtonClickedEventHandler(MarketLotListElement element)
		{
		/* --- GHIDRA: MarketLotButtonClickedEventHandler ---
		void Gameplay_Market_Controller_MarketViewMediator__MarketLotButtonClickedEventHandler
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 param2_00;
		  int iVar2;
		  int iVar3;
		  
		  if ((param2 != 0) && (iVar1 = param1[6], iVar1 != param2)) {
		    if ((iVar1 != 0) && (*(char *)(iVar1 + 0x10) != '\0')) {
		      *(undefined1 *)(iVar1 + 0x10) = 0;
		      iVar1 = *(int *)(iVar1 + 0x18);
		      if (iVar1 != 0) {
		        (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                  (*(undefined4 *)(iVar1 + 0x20),0,*(undefined4 *)(iVar1 + 0x14));
		      }
		    }
		    param1[6] = param2;
		    if (*(char *)(param2 + 0x10) == '\0') {
		      *(undefined1 *)(param2 + 0x10) = 1;
		      iVar1 = *(int *)(param2 + 0x18);
		      if (iVar1 != 0) {
		        (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                  (*(undefined4 *)(iVar1 + 0x20),1,*(undefined4 *)(iVar1 + 0x14));
		      }
		    }
		    param2_00 = *(undefined4 *)(param2 + 0xc);
		    if (DAT_ram_00a5a037 == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&
		                 Method_MVC_AbstractViewMediator_MarketModel__MarketEvents__MarketController__MarketWindow__get_Model__
		                );
		      DAT_ram_00a5a037 = '\x01';
		    }
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    Gameplay_Market_View_MarketLotInfoView__Init
		              (*(undefined4 *)(iVar1 + 0x44),param2_00,*(undefined4 *)(param1[2] + 8),param1);
		    if ((char)param1[0xe] == '\0') {
		      Gameplay_Market_Controller_MarketViewMediator__ForceUpdateExtraArtifacts(param1,param1);
		    }
		    else if (param1[6] != 0) {
		      iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		      iVar2 = *(int *)(*(int *)(iVar1 + 0x58) + 0x3c);
		      iVar3 = 0x30;
		      iVar1 = **(int **)(param1[6] + 0xc);
		      iVar1 = (**(code **)((ulonglong)*(uint *)(iVar1 + 0xf0) * 4))
		                        (*(int **)(param1[6] + 0xc),*(undefined4 *)(iVar1 + 0xf4));
		      if (iVar1 == 0) {
		        iVar3 = 0x34;
		      }
		      iVar1 = *(int *)(*(int *)((int)param1 + iVar3) + iVar2 * 4 + 0x10);
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		      return;
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x060026A1 RID: 9889 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026A1")]
		[Address(RVA = "0x77DA", Offset = "0x77DA", VA = "0x77DA")]
		private void SelectMarketLotListElement(MarketLotListElement.MarketLotListElementArgs args)
		{
		/* --- GHIDRA: SelectMarketLotListElement ---
		void Gameplay_Market_Controller_MarketViewMediator__SelectMarketLotListElement
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a5a037 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_MarketModel__MarketEvents__MarketController__MarketWindow__get_Model__
		              );
		    DAT_ram_00a5a037 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_Market_View_MarketLotInfoView__Init
		            (*(undefined4 *)(iVar1 + 0x44),param2,*(undefined4 *)(param1[2] + 8),param1);
		  return;
		}
		*/

		}

		// Token: 0x060026A2 RID: 9890 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026A2")]
		[Address(RVA = "0x77DB", Offset = "0x77DB", VA = "0x77DB")]
		private void UpdateMarketLotInfo(MarketLotData data)
		{
		/* --- GHIDRA: UpdateMarketLotInfo ---
		void Gameplay_Market_Controller_MarketViewMediator__UpdateMarketLotInfo
		               (int param1,undefined4 param2)
		
		{
		  undefined4 param2_00;
		  int param1_00;
		  
		  if (DAT_ram_00a5a038 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_MarketModel__MarketEvents__MarketController__MarketWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_MarketLotListElement_MarketLotListElementArgs__get_Count__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_MarketLotListElement_MarketLotListElementArgs__get_Item__
		              );
		    DAT_ram_00a5a038 = '\x01';
		  }
		  *(undefined1 *)(param1 + 0x38) = 0;
		  param1_00 = *(int *)(*(int *)(param1 + 8) + 0x18);
		  if ((0 < *(int *)(param1_00 + 0xc)) ||
		     (param1_00 = *(int *)(*(int *)(param1 + 8) + 0x1c), 0 < *(int *)(param1_00 + 0xc))) {
		    param2_00 = System_Linq_Enumerable__ToList_object_
		                          (param1_00,0,
		                           Method_System_Collections_Generic_List_MarketLotListElement_MarketLotListElementArgs__get_Item__
		                          );
		    Gameplay_Market_Controller_MarketViewMediator__MarketLotButtonClickedEventHandler
		              (param1,param2_00,param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x060026A3 RID: 9891 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026A3")]
		[Address(RVA = "0x77DC", Offset = "0x77DC", VA = "0x77DC")]
		private void SelectFirstLot()
		{
		/* --- GHIDRA: SelectFirstLot ---
		uint Gameplay_Market_Controller_MarketViewMediator__SelectFirstLot
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a5a039 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_ArtikulDic__uint__get_Id__);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_BaseWindow_MarketWindow_MarketWindowArgs__get_WindowArgs__);
		    DAT_ram_00a5a039 = '\x01';
		  }
		  iVar2 = *(int *)(*(int *)(*(int *)(*(int *)(param2 + 0xc) + 8) + 8) + 0xc);
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar1 = func_ii_8093(param1_00,
		                       Method_UI_Windows_BaseWindow_MarketWindow_MarketWindowArgs__get_WindowArgs__)
		  ;
		  return (uint)(iVar2 == *(int *)(iVar1 + 0x18));
		}
		*/

		}

		// Token: 0x060026A5 RID: 9893 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026A5")]
		[Address(RVA = "0x77DE", Offset = "0x77DE", VA = "0x77DE")]
		[CompilerGenerated]
		internal static void <BuyButtonClickedEventHandler>g__HandleBuyMarketOption|30_0(MarketOptionData data)
		{
		}

		// Token: 0x060026A6 RID: 9894 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026A6")]
		[Address(RVA = "0x77DF", Offset = "0x77DF", VA = "0x77DF")]
		[CompilerGenerated]
		private void <BuyButtonClickedEventHandler>g__HandleBuyUserLot|30_1(UserMarketLotData data)
		{
		}

		// Token: 0x060026A7 RID: 9895 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026A7")]
		[Address(RVA = "0x77E0", Offset = "0x77E0", VA = "0x77E0")]
		[CompilerGenerated]
		private void <DrawCurrentTab>g__DrawOptions|38_0()
		{
		}

		// Token: 0x04001514 RID: 5396
		[Token(Token = "0x4001514")]
		[FieldOffset(Offset = "0x18")]
		private MarketLotListElement.MarketLotListElementArgs _selectedArgs;

		// Token: 0x04001515 RID: 5397
		[Token(Token = "0x4001515")]
		[FieldOffset(Offset = "0x1C")]
		private IList<MarketLotListElement.MarketLotListElementArgs> _extraArtifacts;

		// Token: 0x04001516 RID: 5398
		[Token(Token = "0x4001516")]
		[FieldOffset(Offset = "0x20")]
		private List<MarketLotListElement.MarketLotListElementArgs> _filteredArgs;

		// Token: 0x04001517 RID: 5399
		[Token(Token = "0x4001517")]
		[FieldOffset(Offset = "0x24")]
		private List<MarketLotListElement.MarketLotListElementArgs> _filteredOptions;

		// Token: 0x04001518 RID: 5400
		[Token(Token = "0x4001518")]
		[FieldOffset(Offset = "0x28")]
		private readonly Dictionary<FilterInfo.FilterType, IMarketFilter> _filters;

		// Token: 0x04001519 RID: 5401
		[Token(Token = "0x4001519")]
		[FieldOffset(Offset = "0x2C")]
		private readonly IMarketFilter _subFilter;

		// Token: 0x0400151A RID: 5402
		[Token(Token = "0x400151A")]
		[FieldOffset(Offset = "0x30")]
		private readonly Action[] _extraLotsOptionsRequests;

		// Token: 0x0400151B RID: 5403
		[Token(Token = "0x400151B")]
		[FieldOffset(Offset = "0x34")]
		private readonly Action[] _extraLotsUsersRequests;

		// Token: 0x0400151C RID: 5404
		[Token(Token = "0x400151C")]
		[FieldOffset(Offset = "0x38")]
		private bool _isMasterElement;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_CurrentTab ---
		void Gameplay_Market_Controller_MarketViewMediator__get_CurrentTab
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  int iVar3;
		  
		  if (DAT_ram_00a5a024 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_MarketModel__MarketEvents__MarketController__MarketWindow___ctor__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action___TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_FilterInfo_FilterType__IMarketFilter__Add__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_FilterInfo_FilterType__IMarketFilter___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_Dictionary_FilterInfo_FilterType__IMarketFilter__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Market_Controller_Filters_MarketAvailableFilter_TypeInfo)
		    ;
		    Mono_Security_ASN1__get_Item(&Gameplay_Market_Controller_Filters_MarketSubFilter_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Market_Controller_Filters_MarketTitleFilter_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Market_Controller_MarketViewMediator_GetOptionsLots__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Market_Controller_MarketViewMediator_GetOtherArtifacts__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Market_Controller_MarketViewMediator_GetOtherOptionsArtifacts__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Market_Controller_MarketViewMediator_GetSimilarArtifacts__);
		    DAT_ram_00a5a024 = '\x01';
		  }
		  Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		            (param1,param2,param3,param4,
		             Method_MVC_AbstractViewMediator_MarketModel__MarketEvents__MarketController__MarketWindow___ctor__
		            );
		  uVar1 = unnamed_function_1417
		                    (
		                    System_Collections_Generic_Dictionary_FilterInfo_FilterType__IMarketFilter__TypeInfo
		                    );
		  System_Collections_Generic_Dictionary_Int32Enum__Int32Enum___set_Item
		            (uVar1,
		             Method_System_Collections_Generic_Dictionary_FilterInfo_FilterType__IMarketFilter___ctor__
		            );
		  uVar2 = unnamed_function_1417(Gameplay_Market_Controller_Filters_MarketTitleFilter_TypeInfo);
		  func_ii_10812(uVar1,4,uVar2,
		                Method_System_Collections_Generic_Dictionary_FilterInfo_FilterType__IMarketFilter__Add__
		               );
		  uVar2 = unnamed_function_1417(Gameplay_Market_Controller_Filters_MarketAvailableFilter_TypeInfo);
		  func_ii_10812(uVar1,5,uVar2,
		                Method_System_Collections_Generic_Dictionary_FilterInfo_FilterType__IMarketFilter__Add__
		               );
		  *(undefined4 *)(param1 + 0x28) = uVar1;
		  uVar1 = unnamed_function_1417(Gameplay_Market_Controller_Filters_MarketSubFilter_TypeInfo);
		  *(undefined4 *)(param1 + 0x2c) = uVar1;
		  iVar3 = Mono_Security_ASN1Convert__ToOid(System_Action___TypeInfo,3);
		  uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar1,param1,Method_Gameplay_Market_Controller_MarketViewMediator_GetSimilarArtifacts__
		             ,0);
		  *(undefined4 *)(iVar3 + 0x10) = uVar1;
		  uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar1,param1,Method_Gameplay_Market_Controller_MarketViewMediator_GetOtherArtifacts__,0
		            );
		  *(undefined4 *)(iVar3 + 0x14) = uVar1;
		  uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar1,param1,Method_Gameplay_Market_Controller_MarketViewMediator_GetOptionsLots__,0);
		  *(undefined4 *)(iVar3 + 0x18) = uVar1;
		  *(int *)(param1 + 0x34) = iVar3;
		  iVar3 = Mono_Security_ASN1Convert__ToOid(System_Action___TypeInfo,3);
		  uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar1,param1,Method_Gameplay_Market_Controller_MarketViewMediator_GetSimilarArtifacts__
		             ,0);
		  *(undefined4 *)(iVar3 + 0x10) = uVar1;
		  uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar1,param1,
		             Method_Gameplay_Market_Controller_MarketViewMediator_GetOtherOptionsArtifacts__,0);
		  *(undefined4 *)(iVar3 + 0x14) = uVar1;
		  uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar1,param1,Method_Gameplay_Market_Controller_MarketViewMediator_GetOptionsLots__,0);
		  *(undefined4 *)(iVar3 + 0x18) = uVar1;
		  *(int *)(param1 + 0x30) = iVar3;
		  return;
		}
		*/


		/* --- GHIDRA: set_View ---
		void Gameplay_Market_Controller_MarketViewMediator__set_View
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  int iVar5;
		  undefined4 uVar6;
		  
		  if (DAT_ram_00a5a026 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_MarketModel__MarketEvents__MarketController__MarketWindow__set_Events__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Action_IEnumerable_MarketLotListElement_MarketLotListElementArgs___IEnumerable_MarketLotListElement_MarketLotListElementArgs___TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Market_Controller_MarketViewMediator_ArtifactsListChangedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Market_Controller_MarketViewMediator_ExtraArtifactsRequestedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Market_Controller_MarketViewMediator_MarketArtifactsRequestedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Market_Controller_MarketViewMediator_MarketLotsChangedEventHandler__
		              );
		    DAT_ram_00a5a026 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar2 + 0x14);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Market_Controller_MarketViewMediator_MarketArtifactsRequestedEventHandler__
		               ,0);
		    piVar4 = (int *)func_ii_7048(uVar6,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x14) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x14) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar2 + 0x18);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Market_Controller_MarketViewMediator_ExtraArtifactsRequestedEventHandler__
		               ,0);
		    piVar4 = (int *)func_ii_7048(uVar6,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x18) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x18) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar1 + 0x20);
		    uVar3 = unnamed_function_1417
		                      (
		                      System_Action_IEnumerable_MarketLotListElement_MarketLotListElementArgs___IEnumerable_MarketLotListElement_MarketLotListElementArgs___TypeInfo
		                      );
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar3,param1,
		               Method_Gameplay_Market_Controller_MarketViewMediator_ArtifactsListChangedEventHandler__
		               ,0);
		    iVar2 = func_ii_7048(uVar6,uVar3,0);
		    uVar3 = 
		    System_Action_IEnumerable_MarketLotListElement_MarketLotListElementArgs___IEnumerable_MarketLotListElement_MarketLotListElementArgs___TypeInfo
		    ;
		    if (iVar2 == 0) {
		      *(undefined4 *)(iVar1 + 0x20) = 0;
		    }
		    else {
		      iVar5 = func_ii_1082(iVar2,
		                           System_Action_IEnumerable_MarketLotListElement_MarketLotListElementArgs___IEnumerable_MarketLotListElement_MarketLotListElementArgs___TypeInfo
		                          );
		      if (iVar5 == 0) {
		        System_Activator__CreateInstance(iVar2,uVar3);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(iVar1 + 0x20) = iVar5;
		      uVar3 = 
		      System_Action_IEnumerable_MarketLotListElement_MarketLotListElementArgs___IEnumerable_MarketLotListElement_MarketLotListElementArgs___TypeInfo
		      ;
		      iVar1 = func_ii_1082(iVar2,
		                           System_Action_IEnumerable_MarketLotListElement_MarketLotListElementArgs___IEnumerable_MarketLotListElement_MarketLotListElementArgs___TypeInfo
		                          );
		      if (iVar1 == 0) {
		        System_Activator__CreateInstance(iVar2,uVar3);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar2 + 0x1c);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Market_Controller_MarketViewMediator_MarketLotsChangedEventHandler__,
		               0);
		    piVar4 = (int *)func_ii_7048(uVar6,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x1c) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x1c) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  param1[3] = param2;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar2 + 0x14);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Market_Controller_MarketViewMediator_MarketArtifactsRequestedEventHandler__
		               ,0);
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar6,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x14) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x14) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar2 + 0x18);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Market_Controller_MarketViewMediator_ExtraArtifactsRequestedEventHandler__
		               ,0);
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar6,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x18) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x18) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar1 + 0x20);
		    uVar3 = unnamed_function_1417
		                      (
		                      System_Action_IEnumerable_MarketLotListElement_MarketLotListElementArgs___IEnumerable_MarketLotListElement_MarketLotListElementArgs___TypeInfo
		                      );
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar3,param1,
		               Method_Gameplay_Market_Controller_MarketViewMediator_ArtifactsListChangedEventHandler__
		               ,0);
		    iVar2 = UnityEngine_UI_Image__set_sprite(uVar6,uVar3,0);
		    uVar3 = 
		    System_Action_IEnumerable_MarketLotListElement_MarketLotListElementArgs___IEnumerable_MarketLotListElement_MarketLotListElementArgs___TypeInfo
		    ;
		    if (iVar2 == 0) {
		      *(undefined4 *)(iVar1 + 0x20) = 0;
		    }
		    else {
		      iVar5 = func_ii_1082(iVar2,
		                           System_Action_IEnumerable_MarketLotListElement_MarketLotListElementArgs___IEnumerable_MarketLotListElement_MarketLotListElementArgs___TypeInfo
		                          );
		      if (iVar5 == 0) {
		        System_Activator__CreateInstance(iVar2,uVar3);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      *(int *)(iVar1 + 0x20) = iVar5;
		      uVar3 = 
		      System_Action_IEnumerable_MarketLotListElement_MarketLotListElementArgs___IEnumerable_MarketLotListElement_MarketLotListElementArgs___TypeInfo
		      ;
		      iVar1 = func_ii_1082(iVar2,
		                           System_Action_IEnumerable_MarketLotListElement_MarketLotListElementArgs___IEnumerable_MarketLotListElement_MarketLotListElementArgs___TypeInfo
		                          );
		      if (iVar1 == 0) {
		        System_Activator__CreateInstance(iVar2,uVar3);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar6 = *(undefined4 *)(iVar2 + 0x1c);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Market_Controller_MarketViewMediator_MarketLotsChangedEventHandler__,
		               0);
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar6,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x1c) = 0;
		      return;
		    }
		    if ((System_Action_TypeInfo != *piVar4) || (*(int **)(iVar2 + 0x1c) = piVar4, *piVar4 != iVar1))
		    {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_Events ---
		void Gameplay_Market_Controller_MarketViewMediator__set_Events(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int *piVar3;
		  int iVar4;
		  int iVar5;
		  int iVar6;
		  int local_20;
		  undefined8 *puStack_1c;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5a027 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_MarketModel__MarketEvents__MarketController__MarketWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_MarketLotListElement__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_MarketLotListElement_MarketLotListElementArgs__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_MarketLotListElement_MarketLotListElementArgs__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_MarketLotListElement_MarketLotListElementArgs__get_Current__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_MarketLotListElement_MarketLotListElementArgs__GetEnumerator__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Market_Controller_MarketViewMediator_MarketLotButtonClickedEventHandler__
		              );
		    DAT_ram_00a5a027 = '\x01';
		  }
		  System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		            (&local_20,*(undefined4 *)(param1[2] + 0x18),
		             Method_System_Collections_Generic_List_MarketLotListElement_MarketLotListElementArgs__GetEnumerator__
		            );
		  local_8 = local_18;
		  local_10 = CONCAT44(puStack_1c,local_20);
		  local_20 = 0;
		  puStack_1c = &local_10;
		  while( true ) {
		    DAT_ram_009d3e38 = 0;
		    iVar1 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_10,
		                       Method_System_Collections_Generic_List_Enumerator_MarketLotListElement_MarketLotListElementArgs__MoveNext__
		                      );
		    iVar4 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar4 == 1) break;
		    if (iVar1 == 0) goto code_r0x811b5865;
		    DAT_ram_009d3e38 = 0;
		    iVar4 = local_8._4_4_;
		    uVar2 = import::env::invoke_ii
		                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                       System_Action_MarketLotListElement__TypeInfo);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x811b57fd:
		      DAT_ram_009d3e38 = 0;
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x811b580f;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viiii
		              (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x241,uVar2,param1,
		               Method_Gameplay_Market_Controller_MarketViewMediator_MarketLotButtonClickedEventHandler__
		               ,0);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x811b57fd;
		    *(undefined4 *)(iVar4 + 0x14) = uVar2;
		  }
		  uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x811b580f:
		  iVar4 = global_1;
		  iVar1 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar4 == iVar1) {
		    piVar3 = (int *)import::env::__cxa_begin_catch(uVar2);
		    iVar1 = *piVar3;
		    DAT_ram_009d3e38 = 0;
		    local_20 = iVar1;
		    import::env::invoke_v(0x123);
		    iVar4 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar4 != 1) {
		      if (iVar1 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(iVar1);
		        do {
		          halt_trap();
		        } while( true );
		      }
		code_r0x811b5865:
		      DAT_ram_009d3e38 = 0;
		      System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		                (&local_20,*(undefined4 *)(param1[2] + 0x1c),
		                 Method_System_Collections_Generic_List_MarketLotListElement_MarketLotListElementArgs__GetEnumerator__
		                );
		      local_8 = local_18;
		      local_10 = CONCAT44(puStack_1c,local_20);
		      local_20 = 0;
		      puStack_1c = &local_10;
		      while( true ) {
		        DAT_ram_009d3e38 = 0;
		        iVar1 = import::env::invoke_iii
		                          (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_10,
		                           Method_System_Collections_Generic_List_Enumerator_MarketLotListElement_MarketLotListElementArgs__MoveNext__
		                          );
		        iVar4 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar4 == 1) break;
		        if (iVar1 == 0) goto code_r0x811b5a15;
		        DAT_ram_009d3e38 = 0;
		        iVar4 = local_8._4_4_;
		        uVar2 = import::env::invoke_ii
		                          (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                           System_Action_MarketLotListElement__TypeInfo);
		        if (DAT_ram_009d3e38 == 1) {
		code_r0x811b59ad:
		          DAT_ram_009d3e38 = 0;
		          uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x811b59bf;
		        }
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viiii
		                  (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x241,uVar2,param1,
		                   Method_Gameplay_Market_Controller_MarketViewMediator_MarketLotButtonClickedEventHandler__
		                   ,0);
		        if (DAT_ram_009d3e38 == 1) goto code_r0x811b59ad;
		        *(undefined4 *)(iVar4 + 0x14) = uVar2;
		      }
		      uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x811b59bf:
		      iVar4 = global_1;
		      iVar1 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar4 == iVar1) {
		        piVar3 = (int *)import::env::__cxa_begin_catch(uVar2);
		        iVar1 = *piVar3;
		        DAT_ram_009d3e38 = 0;
		        local_20 = iVar1;
		        import::env::invoke_v(0x123);
		        iVar4 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar4 != 1) {
		          if (iVar1 != 0) {
		            System_Data_DataSet__ValidateLocaleConstraint(iVar1);
		            do {
		              halt_trap();
		            } while( true );
		          }
		code_r0x811b5a15:
		          DAT_ram_009d3e38 = 0;
		          iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                            (param1,*(undefined4 *)(*param1 + 0x15c));
		          Gameplay_GameEvents_Model_GameEventData__get_ContainsArtifactRewards
		                    (*(undefined4 *)(iVar4 + 0x48),0,0,0);
		          iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                            (param1,*(undefined4 *)(*param1 + 0x15c));
		          Gameplay_GameEvents_Model_GameEventData__get_ContainsArtifactRewards
		                    (*(undefined4 *)(iVar4 + 0x58),0,0,0);
		          iVar4 = 0;
		          Gameplay_Market_Controller_MarketViewMediator__MarketArtifactsRequestedEventHandler
		                    (param1,0);
		          if (param1[6] != 0) {
		            iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                              (param1,*(undefined4 *)(*param1 + 0x15c));
		            iVar5 = *(int *)(*(int *)(iVar1 + 0x58) + 0x3c);
		            iVar6 = 0x30;
		            iVar1 = **(int **)(param1[6] + 0xc);
		            iVar1 = (**(code **)((ulonglong)*(uint *)(iVar1 + 0xf0) * 4))
		                              (*(int **)(param1[6] + 0xc),*(undefined4 *)(iVar1 + 0xf4));
		            if (iVar1 == 0) {
		              iVar6 = 0x34;
		            }
		            iVar1 = *(int *)(*(int *)((int)param1 + iVar6) + iVar5 * 4 + 0x10);
		            (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                      (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		          }
		          iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                            (param1,*(undefined4 *)(*param1 + 0x15c));
		          iVar1 = *(int *)(iVar1 + 0x5c);
		          if (0 < *(int *)(iVar1 + 0xc)) {
		            do {
		              Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                        (*(undefined4 *)(iVar1 + iVar4 * 4 + 0x10),1,0);
		              iVar4 = iVar4 + 1;
		            } while (iVar4 < *(int *)(iVar1 + 0xc));
		          }
		          return;
		        }
		        uVar2 = import::env::__cxa_find_matching_catch_2();
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001f04 + 0x236,&local_20);
		      goto joined_r0x811b5b52;
		    }
		    uVar2 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001f04 + 0x235,&local_20);
		joined_r0x811b5b52:
		  if (DAT_ram_009d3e38 == 1) {
		    DAT_ram_009d3e38 = 0;
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::__resumeException(uVar2);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

}
