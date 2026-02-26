using System;
using System.Collections.Generic;
using Core.Data.Balance;
using Core.Money;
using Il2CppDummyDll;
using Protocol.Common;
using Protocol.Consts;
using UnityEngine;
using Utils.Cache;

namespace UI.Price
{
	// Token: 0x020001BB RID: 443
	[Token(Token = "0x20001BB")]
	public class Price : MonoBehaviour
	{
		// Token: 0x17000188 RID: 392
		// (get) Token: 0x06000BC4 RID: 3012 RVA: 0x00003CC0 File Offset: 0x00001EC0
		// (set) Token: 0x06000BC5 RID: 3013 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000188")]
		public Price.PriceMode Mode
		{
			[Token(Token = "0x6000BC4")]
			[Address(RVA = "0x5EDC", Offset = "0x5EDC", VA = "0x5EDC")]
			get
			{
				return Price.PriceMode.Default;
			}
			[Token(Token = "0x6000BC5")]
			[Address(RVA = "0x5EDD", Offset = "0x5EDD", VA = "0x5EDD")]
			set
			{
			}
		}

		// Token: 0x06000BC6 RID: 3014 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BC6")]
		[Address(RVA = "0x5EDE", Offset = "0x5EDE", VA = "0x5EDE", Slot = "4")]
		protected virtual void Awake()
		{
		/* --- GHIDRA: Awake ---
		void UI_Price_Price__Awake(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a59a41 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_PriceItemRenderer__Clear__)
		    ;
		    Mono_Security_ASN1__get_Item(&Method_Utils_Cache_ObjectPool_PriceItemRenderer__Clear__);
		    DAT_ram_00a59a41 = '\x01';
		  }
		  iVar1 = *(int *)(param1 + 0x24);
		  if (iVar1 != 0) {
		    *(undefined4 *)(param1 + 0x24) = 0;
		    iVar2 = func_ii_12174(param1,0);
		    if (iVar2 != 0) {
		      UI_Price_Price__StartListenEvents(param1,iVar1,param1);
		    }
		  }
		  if (*(int *)(param1 + 0x30) != 0) {
		    Utils_Cache_ObjectPool_object____ctor
		              (*(int *)(param1 + 0x30),Method_Utils_Cache_ObjectPool_PriceItemRenderer__Clear__);
		  }
		  iVar1 = *(int *)(param1 + 0x2c);
		  iVar2 = *(int *)(iVar1 + 0xc);
		  *(undefined4 *)(iVar1 + 0xc) = 0;
		  *(int *)(iVar1 + 0x10) = *(int *)(iVar1 + 0x10) + 1;
		  if (0 < iVar2) {
		    func_ii_2064(*(undefined4 *)(iVar1 + 8),0,iVar2,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06000BC7 RID: 3015 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BC7")]
		[Address(RVA = "0x5EDF", Offset = "0x5EDF", VA = "0x5EDF")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void UI_Price_Price__OnDestroy(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined4 param2_00;
		  undefined4 param2_01;
		  int iVar4;
		  int *param1_00;
		  int iVar5;
		  
		  if (DAT_ram_00a59a42 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Data_Balance_IBalanceSource_TypeInfo);
		    DAT_ram_00a59a42 = '\x01';
		  }
		  if (DAT_ram_00a59a43 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_PriceItemRenderer__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_PriceItemRenderer__get_Item__);
		    DAT_ram_00a59a43 = '\x01';
		  }
		  iVar4 = *(int *)(*(int *)(param1 + 0x2c) + 0xc);
		  if (0 < iVar4) {
		    iVar5 = 0;
		    do {
		      uVar3 = System_Linq_Enumerable__ToList_object_
		                        (*(undefined4 *)(param1 + 0x2c),iVar5,
		                         Method_System_Collections_Generic_List_PriceItemRenderer__get_Item__);
		      UI_Price_PriceItemRenderer__set_ResId(uVar3,param1 + 0x18,0);
		      iVar5 = iVar5 + 1;
		    } while (iVar5 != iVar4);
		  }
		  iVar4 = *(int *)(param1 + 0x24);
		  if (iVar4 != 0) {
		    UI_Price_Price__set_PriceValue(param1,iVar4,iVar4);
		    uVar1 = 0;
		    param1_00 = *(int **)(param1 + 0x24);
		    iVar4 = *param1_00;
		    if (*(ushort *)(iVar4 + 0xb6) != 0) {
		      do {
		        if (Core_Data_Balance_IBalanceSource_TypeInfo ==
		            *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xd0);
		          goto code_r0x810b3c4f;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(param1_00,Core_Data_Balance_IBalanceSource_TypeInfo,2);
		code_r0x810b3c4f:
		    iVar4 = 0;
		    uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		    if (DAT_ram_00a59a4b == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&Method_System_Collections_Generic_List_PriceItemRenderer__get_Count__);
		      Mono_Security_ASN1__get_Item
		                (&Method_System_Collections_Generic_List_PriceItemRenderer__get_Item__);
		      DAT_ram_00a59a4b = '\x01';
		    }
		    iVar5 = *(int *)(*(int *)(param1 + 0x2c) + 0xc);
		    if (0 < iVar5) {
		      do {
		        param2_00 = System_Linq_Enumerable__ToList_object_
		                              (*(undefined4 *)(param1 + 0x2c),iVar4,
		                               Method_System_Collections_Generic_List_PriceItemRenderer__get_Item__)
		        ;
		        param2_01 = UI_Price_Price__HandleMoneyValues(param1,param2_00,uVar3,iVar4);
		        UI_Price_PriceItemRenderer__set_TruncatePrice(param2_00,param2_01,0);
		        iVar4 = iVar4 + 1;
		      } while (iVar4 != iVar5);
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06000BC8 RID: 3016 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BC8")]
		[Address(RVA = "0x5EE0", Offset = "0x5EE0", VA = "0x5EE0")]
		private void OnEnable()
		{
		/* --- GHIDRA: OnEnable ---
		void UI_Price_Price__OnEnable(int param1,undefined4 param2)
		
		{
		  if (*(int *)(param1 + 0x24) != 0) {
		    UI_Price_Price__StartListenEvents(param1,*(int *)(param1 + 0x24),param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06000BC9 RID: 3017 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BC9")]
		[Address(RVA = "0x5EE1", Offset = "0x5EE1", VA = "0x5EE1")]
		private void OnDisable()
		{
		/* --- GHIDRA: OnDisable ---
		void UI_Price_Price__OnDisable(int param1,undefined4 *param2,undefined4 param3)
		
		{
		  int param2_00;
		  undefined4 param1_00;
		  int iVar1;
		  
		  param2_00 = 0;
		  if (DAT_ram_00a59a43 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_PriceItemRenderer__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_PriceItemRenderer__get_Item__);
		    DAT_ram_00a59a43 = '\x01';
		  }
		  *(undefined4 *)(param1 + 0x18) = *param2;
		  iVar1 = *(int *)(*(int *)(param1 + 0x2c) + 0xc);
		  if (0 < iVar1) {
		    do {
		      param1_00 = System_Linq_Enumerable__ToList_object_
		                            (*(undefined4 *)(param1 + 0x2c),param2_00,
		                             Method_System_Collections_Generic_List_PriceItemRenderer__get_Item__);
		      UI_Price_PriceItemRenderer__set_ResId(param1_00,param1 + 0x18,0);
		      param2_00 = param2_00 + 1;
		    } while (param2_00 != iVar1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06000BCA RID: 3018 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BCA")]
		[Address(RVA = "0x5EE2", Offset = "0x5EE2", VA = "0x5EE2")]
		public void SetColor(in Color32 color)
		{
		/* --- GHIDRA: SetColor ---
		void UI_Price_Price__SetColor(int param1,int param2,undefined4 param3,undefined4 param4)
		
		{
		  int iVar1;
		  int param2_00;
		  
		  param2_00 = *(int *)(param1 + 0x24);
		  if (param2_00 != param2) {
		    *(int *)(param1 + 0x24) = param2;
		    iVar1 = func_ii_12174(param1,0);
		    if (iVar1 != 0) {
		      if (param2_00 != 0) {
		        UI_Price_Price__StartListenEvents(param1,param2_00,param1);
		      }
		      if (param2 != 0) {
		        UI_Price_Price__set_PriceValue(param1,param2,param1);
		      }
		    }
		  }
		  UI_Price_Price__get_PriceValue(param1,param3,param1);
		  return;
		}
		*/

		}

		// Token: 0x06000BCB RID: 3019 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BCB")]
		[Address(RVA = "0x5EE3", Offset = "0x5EE3", VA = "0x5EE3")]
		public void Init(IBalanceSource source, Money price)
		{
		}

		// Token: 0x17000189 RID: 393
		// (get) Token: 0x06000BCC RID: 3020 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000BCD RID: 3021 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000189")]
		public IBalanceSource Source
		{
			[Token(Token = "0x6000BCC")]
			[Address(RVA = "0x5EE4", Offset = "0x5EE4", VA = "0x5EE4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BCD")]
			[Address(RVA = "0x5EE5", Offset = "0x5EE5", VA = "0x5EE5")]
			private set
			{
			}
		}

		// Token: 0x1700018A RID: 394
		// (get) Token: 0x06000BCE RID: 3022 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000BCF RID: 3023 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700018A")]
		public Money PriceValue
		{
			[Token(Token = "0x6000BCE")]
			[Address(RVA = "0x5EE6", Offset = "0x5EE6", VA = "0x5EE6")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BCF")]
			[Address(RVA = "0x5EE7", Offset = "0x5EE7", VA = "0x5EE7")]
			private set
			{
			}
		}

		// Token: 0x06000BD0 RID: 3024 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BD0")]
		[Address(RVA = "0x5EE8", Offset = "0x5EE8", VA = "0x5EE8")]
		private void StartListenEvents(IBalanceSource source)
		{
		/* --- GHIDRA: StartListenEvents ---
		void UI_Price_Price__StartListenEvents(undefined4 param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 param1_00;
		  uint *puVar2;
		  int iVar3;
		  
		  if (DAT_ram_00a59a46 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Data_Balance_IBalanceSource_BalanceChangedDelegate_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Data_Balance_IBalanceSource_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UI_Price_Price_HandleBalanceChangedEvent__);
		    DAT_ram_00a59a46 = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (Core_Data_Balance_IBalanceSource_BalanceChangedDelegate_TypeInfo);
		  Core_Data_InfoRows_CollectionRow___ctor
		            (param1_00,param1,Method_UI_Price_Price_HandleBalanceChangedEvent__,0);
		  iVar3 = *param2;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Data_Balance_IBalanceSource_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8))
		      {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 200);
		        goto code_r0x8109acd1;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,Core_Data_Balance_IBalanceSource_TypeInfo,1);
		code_r0x8109acd1:
		  (**(code **)((ulonglong)*puVar2 * 4))(param2,param1_00,puVar2[1]);
		  return;
		}
		*/

		}

		// Token: 0x06000BD1 RID: 3025 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BD1")]
		[Address(RVA = "0x5EE9", Offset = "0x5EE9", VA = "0x5EE9")]
		private void StopListenEvents(IBalanceSource source)
		{
		/* --- GHIDRA: StopListenEvents ---
		void UI_Price_Price__StopListenEvents
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  int param2_00;
		  undefined4 param2_01;
		  undefined4 param2_02;
		  int iVar1;
		  
		  param2_00 = 0;
		  if (DAT_ram_00a59a4b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_PriceItemRenderer__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_PriceItemRenderer__get_Item__);
		    DAT_ram_00a59a4b = '\x01';
		  }
		  iVar1 = *(int *)(*(int *)(param1 + 0x2c) + 0xc);
		  if (0 < iVar1) {
		    do {
		      param2_01 = System_Linq_Enumerable__ToList_object_
		                            (*(undefined4 *)(param1 + 0x2c),param2_00,
		                             Method_System_Collections_Generic_List_PriceItemRenderer__get_Item__);
		      param2_02 = UI_Price_Price__HandleMoneyValues(param1,param2_01,param2,param2_00);
		      UI_Price_PriceItemRenderer__set_TruncatePrice(param2_01,param2_02,0);
		      param2_00 = param2_00 + 1;
		    } while (param2_00 != iVar1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06000BD2 RID: 3026 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BD2")]
		[Address(RVA = "0x5EEA", Offset = "0x5EEA", VA = "0x5EEA")]
		private void HandleBalanceChangedEvent(ResourceSet balance, ResourceSet delta)
		{
		/* --- GHIDRA: HandleBalanceChangedEvent ---
		void UI_Price_Price__HandleBalanceChangedEvent
		               (undefined4 param1,int param2,int param3,undefined4 param4)
		
		{
		  int iVar1;
		  
		  iVar1 = func_ii_12174(param1,0);
		  if (iVar1 != 0) {
		    if (param2 != 0) {
		      UI_Price_Price__StartListenEvents(param1,param2,param1);
		    }
		    if (param3 != 0) {
		      UI_Price_Price__set_PriceValue(param1,param3,param1);
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06000BD3 RID: 3027 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BD3")]
		[Address(RVA = "0x5EEB", Offset = "0x5EEB", VA = "0x5EEB")]
		private void HandleSourceChanged(IBalanceSource fromSource, IBalanceSource toSource)
		{
		/* --- GHIDRA: HandleSourceChanged ---
		void UI_Price_Price__HandleSourceChanged(int *param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  int iVar3;
		  int *piVar4;
		  uint *puVar5;
		  undefined4 param2_00;
		  undefined4 param2_01;
		  int iVar6;
		  uint uVar7;
		  int local_20;
		  undefined8 *puStack_1c;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a59a47 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_Money__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_Money__MoveNext__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_Money__get_Current__);
		    Mono_Security_ASN1__get_Item(&System_Func_Money_MoneyType__string__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Func_Resources__string__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_Cache_GameObjectPool_PriceItemRenderer___ctor__);
		    Mono_Security_ASN1__get_Item(&Utils_Cache_GameObjectPool_PriceItemRenderer__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Data_Balance_IBalanceSource_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_PriceItemRenderer__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Money__GetEnumerator__);
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_MoneyType_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_Cache_ObjectPool_PriceItemRenderer__Get__);
		    Mono_Security_ASN1__get_Item(&Method_UI_Price_Price_PriceItemTdGetAssetIdHandler__);
		    Mono_Security_ASN1__get_Item(&Method_UI_Price_Price_PriceItemTdGetAssetIdHandler__);
		    Mono_Security_ASN1__get_Item(&Method_UI_Price_Price_ResetPoolObjectDelegate__);
		    Mono_Security_ASN1__get_Item
		              (&Utils_Cache_ObjectPool_ResetPoolObjectDelegate_PriceItemRenderer__TypeInfo);
		    DAT_ram_00a59a47 = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  UI_Price_Price__IsEnoughMoney(param1,param1);
		  iVar6 = param1[10];
		  if (*(int *)(Core_Money_Money_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Money_Money_TypeInfo);
		  }
		  iVar6 = Core_Money_Money__op_Inequality(iVar6,0,0);
		  if (iVar6 != 0) {
		    return;
		  }
		  if (param1[0xc] == 0) {
		    iVar3 = param1[4];
		    iVar2 = param1[5];
		    uVar1 = unnamed_function_1417
		                      (Utils_Cache_ObjectPool_ResetPoolObjectDelegate_PriceItemRenderer__TypeInfo);
		    Core_Cache_AbstractCache_RequestInvoker___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType____ctor
		              (uVar1,param1,Method_UI_Price_Price_ResetPoolObjectDelegate__,0);
		    iVar6 = unnamed_function_1417(Utils_Cache_GameObjectPool_PriceItemRenderer__TypeInfo);
		    Utils_Cache_GameObjectPoolRestricted_object___CreateInstance
		              (iVar6,iVar2,iVar3,uVar1,Method_Utils_Cache_GameObjectPool_PriceItemRenderer___ctor__)
		    ;
		    param1[0xc] = iVar6;
		  }
		  iVar6 = param1[9];
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xf4));
		  System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		            (&local_20,uVar1,Method_System_Collections_Generic_List_Money__GetEnumerator__);
		  local_8 = local_18;
		  local_20 = 0;
		  puStack_1c = &local_10;
		code_r0x810b425c:
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar2 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_10,
		                       Method_System_Collections_Generic_List_Enumerator_Money__MoveNext__);
		    iVar3 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar3 == 1) {
		      uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x810b4734;
		    }
		    iVar3 = local_20;
		    if (iVar2 == 0) goto code_r0x810b477d;
		    DAT_ram_009d3e38 = 0;
		    iVar2 = local_8._4_4_;
		    piVar4 = (int *)import::env::invoke_iii
		                              (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x200,param1[0xc],
		                               Method_Utils_Cache_ObjectPool_PriceItemRenderer__Get__);
		    iVar3 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar3 == 1) {
		      uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x810b4734;
		    }
		    if (param1[8] == 1) {
		      DAT_ram_009d3e38 = 0;
		      uVar1 = import::env::invoke_ii
		                        (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                         System_Func_Resources__string__TypeInfo);
		      if (DAT_ram_009d3e38 != 1) {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viiii
		                  (s_struct_Uniforms___color__array<v_ram_00001f04 + 0x83,uVar1,param1,
		                   Method_UI_Price_Price_PriceItemTdGetAssetIdHandler__,0);
		        if (DAT_ram_009d3e38 != 1) {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_viii
		                    (*(undefined4 *)(*piVar4 + 0xe8),piVar4,uVar1,*(undefined4 *)(*piVar4 + 0xec));
		          if (DAT_ram_009d3e38 != 1) {
		            DAT_ram_009d3e38 = 0;
		            uVar1 = import::env::invoke_ii
		                              (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                               System_Func_Money_MoneyType__string__TypeInfo);
		            if (DAT_ram_009d3e38 != 1) {
		              DAT_ram_009d3e38 = 0;
		              import::env::invoke_viiii
		                        (s_struct_Uniforms___color__array<v_ram_00000aff + 0x227,uVar1,param1,
		                         Method_UI_Price_Price_PriceItemTdGetAssetIdHandler__,0);
		              if (DAT_ram_009d3e38 != 1) {
		                DAT_ram_009d3e38 = 0;
		                import::env::invoke_viii
		                          (*(undefined4 *)(*piVar4 + 0xf8),piVar4,uVar1,
		                           *(undefined4 *)(*piVar4 + 0xfc));
		                if (DAT_ram_009d3e38 != 1) {
		                  DAT_ram_009d3e38 = 0;
		                  import::env::invoke_viii
		                            (s_struct_Uniforms___color__array<v_ram_00001f04 + 0x84,piVar4,
		                             *(undefined4 *)(iVar2 + 8),0);
		                  iVar3 = DAT_ram_009d3e38;
		                  DAT_ram_009d3e38 = 0;
		                  if (iVar3 != 1) goto code_r0x810b4546;
		                  uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		                  goto code_r0x810b4734;
		                }
		              }
		            }
		            DAT_ram_009d3e38 = 0;
		            uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x810b4734;
		          }
		        }
		      }
		      DAT_ram_009d3e38 = 0;
		      uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x810b4734;
		    }
		    uVar1 = *(undefined4 *)(iVar2 + 8);
		    if (*(int *)(Core_Money_Money_MoneyType_TypeInfo + 0x74) == 0) {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi
		                (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                 Core_Money_Money_MoneyType_TypeInfo);
		      iVar3 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar3 == 1) {
		        uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x810b4734;
		      }
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar1 = func_ii_7278(uVar1,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x810b46e6:
		      DAT_ram_009d3e38 = 0;
		      uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x810b4734;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii(s_struct_Uniforms___color__array<v_ram_00001f04 + 0x85,piVar4,uVar1,0);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x810b46e6;
		code_r0x810b4546:
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_00001f04 + 0x86,piVar4,param1 + 6,0);
		    iVar3 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar3 == 1) {
		      uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x810b4734;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_00001f04 + 0x87,piVar4,(uint)(iVar6 != 0),0);
		    iVar3 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar3 == 1) {
		      uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x810b4734;
		    }
		    *(char *)(piVar4 + 0x11) = (char)param1[7];
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_vidi
		              (s_struct_Uniforms___color__array<v_ram_00001f04 + 0x88,piVar4,
		               *(double *)(iVar2 + 0x10),0);
		    iVar3 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar3 == 1) {
		      uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x810b4734;
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar1 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x25c,piVar4,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x810b470e:
		      DAT_ram_009d3e38 = 0;
		      uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x810b4734;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii(s_struct_Uniforms___color__array<v_ram_000013c7 + 0x26d,uVar1,1,0);
		    iVar3 = Method_System_Collections_Generic_List_PriceItemRenderer__Add__;
		    if (DAT_ram_009d3e38 == 1) goto code_r0x810b470e;
		    iVar2 = param1[0xb];
		    *(int *)(iVar2 + 0x10) = *(int *)(iVar2 + 0x10) + 1;
		    uVar7 = *(uint *)(iVar2 + 0xc);
		    if (uVar7 < *(uint *)(*(int *)(iVar2 + 8) + 0xc)) {
		      *(uint *)(iVar2 + 0xc) = uVar7 + 1;
		      *(int **)(*(int *)(iVar2 + 8) + uVar7 * 4 + 0x10) = piVar4;
		      goto code_r0x810b425c;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,iVar2,piVar4,
		               *(undefined4 *)(*(int *)(*(int *)(iVar3 + 0x10) + 0x60) + 0x38));
		    iVar3 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		  } while (iVar3 != 1);
		  uVar1 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x810b4734:
		  iVar6 = global_1;
		  iVar3 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar6 == iVar3) {
		    piVar4 = (int *)import::env::__cxa_begin_catch(uVar1);
		    iVar3 = *piVar4;
		    DAT_ram_009d3e38 = 0;
		    local_20 = iVar3;
		    import::env::invoke_v(0x123);
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 != 1) {
		code_r0x810b477d:
		      DAT_ram_009d3e38 = 0;
		      uVar1 = 0;
		      if (iVar3 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(iVar3);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      piVar4 = (int *)param1[9];
		      if (piVar4 != (int *)0x0) {
		        uVar7 = 0;
		        iVar6 = *piVar4;
		        if (*(ushort *)(iVar6 + 0xb6) != 0) {
		          do {
		            if (Core_Data_Balance_IBalanceSource_TypeInfo ==
		                *(int *)(*(int *)(iVar6 + 0x58) + uVar7 * 8)) {
		              puVar5 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar7 * 8 + 4) * 8 + iVar6 + 0xd0)
		              ;
		              goto code_r0x810b4842;
		            }
		            uVar7 = uVar7 + 1;
		          } while (*(ushort *)(iVar6 + 0xb6) != uVar7);
		        }
		        puVar5 = (uint *)func_ii_1080(piVar4,Core_Data_Balance_IBalanceSource_TypeInfo,2);
		code_r0x810b4842:
		        if (piVar4 == (int *)0x0) {
		          param1 = (int *)0x0;
		        }
		        uVar1 = (**(code **)((ulonglong)*puVar5 * 4))(piVar4,puVar5[1]);
		      }
		      iVar6 = 0;
		      if (DAT_ram_00a59a4b == '\0') {
		        Mono_Security_ASN1__get_Item
		                  (&Method_System_Collections_Generic_List_PriceItemRenderer__get_Count__);
		        Mono_Security_ASN1__get_Item
		                  (&Method_System_Collections_Generic_List_PriceItemRenderer__get_Item__);
		        DAT_ram_00a59a4b = '\x01';
		      }
		      iVar3 = *(int *)(param1[0xb] + 0xc);
		      if (iVar3 < 1) {
		        return;
		      }
		      do {
		        param2_00 = System_Linq_Enumerable__ToList_object_
		                              (param1[0xb],iVar6,
		                               Method_System_Collections_Generic_List_PriceItemRenderer__get_Item__)
		        ;
		        param2_01 = UI_Price_Price__HandleMoneyValues(param1,param2_00,uVar1,param1);
		        UI_Price_PriceItemRenderer__set_TruncatePrice(param2_00,param2_01,0);
		        iVar6 = iVar6 + 1;
		      } while (iVar6 != iVar3);
		      return;
		    }
		    uVar1 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001f04 + 0x89,&local_20);
		  iVar6 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar6 == 1) {
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  import::env::__resumeException(uVar1);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06000BD4 RID: 3028 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BD4")]
		[Address(RVA = "0x5EEC", Offset = "0x5EEC", VA = "0x5EEC", Slot = "5")]
		protected virtual void HandleResourceSetChanged()
		{
		/* --- GHIDRA: HandleResourceSetChanged ---
		undefined4 UI_Price_Price__HandleResourceSetChanged(undefined4 param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  int iVar5;
		  
		  if (DAT_ram_00a59a48 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a59a48 = '\x01';
		  }
		  if (param2 == 4) {
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
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x288);
		          goto code_r0x810b4c1a;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x39);
		code_r0x810b4c1a:
		    iVar5 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		    uVar3 = Gameplay_ThemeDuelState_Model_ThemeDuelStateModel__get_HasCurrentThemeDuel
		                      (*(undefined4 *)(iVar5 + 0x14),0);
		    uVar3 = Core_Extensions_Dict_ThemeDuelDicExt__GetIconAssetId(uVar3,0);
		    return uVar3;
		  }
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
		        goto code_r0x810b4cd3;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x810b4cd3:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		  uVar3 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar3,0);
		  uVar3 = Core_Extensions_Dict_ResourceSetExt__GetValue(uVar3,param2,0);
		  uVar3 = func_ii_7611(uVar3,0);
		  return uVar3;
		}
		*/

		}

		// Token: 0x06000BD5 RID: 3029 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000BD5")]
		[Address(RVA = "0x5EED", Offset = "0x5EED", VA = "0x5EED")]
		private string PriceItemTdGetAssetIdHandler(Protocol.Consts.Resources resId)
		{
		/* --- GHIDRA: PriceItemTdGetAssetIdHandler ---
		int UI_Price_Price__PriceItemTdGetAssetIdHandler(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  int *param1_00;
		  undefined4 uVar2;
		  undefined4 *puVar3;
		  int iVar4;
		  undefined4 uVar5;
		  int iVar6;
		  
		  if (DAT_ram_00a59a4a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_Money_MoneyType__Money__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_Money_MoneyType__Money__get_Values__);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_SelectMany_List_Money___Money___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Select_Money_MoneyType__Money___);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_ToDictionary_Money__Money_MoneyType___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToList_Money___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Where_Money_MoneyType___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Where_Money___);
		    Mono_Security_ASN1__get_Item(&System_Func_Money_MoneyType__Money__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Func_Money__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Func_List_Money___IEnumerable_Money___TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Func_Money_MoneyType__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Func_Money__Money_MoneyType__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_Money____TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Money__get_Count__);
		    Mono_Security_ASN1__get_Item(&UI_Price_Price_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UI_Price_Price___c__GetGameResources_b__33_0__);
		    Mono_Security_ASN1__get_Item(&Method_UI_Price_Price___c__GetGameResources_b__33_4__);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Price_Price___c__DisplayClass33_0__GetGameResources_b__1__);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Price_Price___c__DisplayClass33_0__GetGameResources_b__2__);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Price_Price___c__DisplayClass33_0__GetGameResources_b__3__);
		    Mono_Security_ASN1__get_Item(&UI_Price_Price___c__DisplayClass33_0_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UI_Price_Price___c_TypeInfo);
		    DAT_ram_00a59a4a = '\x01';
		  }
		  iVar1 = unnamed_function_1417(UI_Price_Price___c__DisplayClass33_0_TypeInfo);
		  uVar2 = *(undefined4 *)(param1 + 0x28);
		  if (*(int *)(UI_Price_Price___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UI_Price_Price___c_TypeInfo);
		  }
		  puVar3 = *(undefined4 **)(UI_Price_Price___c_TypeInfo + 0x5c);
		  iVar4 = puVar3[1];
		  if (iVar4 == 0) {
		    if (*(int *)(UI_Price_Price___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(UI_Price_Price___c_TypeInfo);
		      puVar3 = *(undefined4 **)(UI_Price_Price___c_TypeInfo + 0x5c);
		    }
		    uVar5 = *puVar3;
		    iVar4 = unnamed_function_1417(System_Func_Money__Money_MoneyType__TypeInfo);
		    System_Linq_Enumerable__Where_object_
		              (iVar4,uVar5,Method_UI_Price_Price___c__GetGameResources_b__33_0__,0);
		    *(int *)(*(int *)(UI_Price_Price___c_TypeInfo + 0x5c) + 4) = iVar4;
		  }
		  uVar2 = System_Linq_Enumerable__ToDictionary_object__Int32Enum_
		                    (uVar2,iVar4,
		                     Method_System_Linq_Enumerable_ToDictionary_Money__Money_MoneyType___);
		  *(undefined4 *)(iVar1 + 8) = uVar2;
		  if (*(int *)(UI_Price_Price_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UI_Price_Price_TypeInfo);
		  }
		  uVar5 = **(undefined4 **)(UI_Price_Price_TypeInfo + 0x5c);
		  uVar2 = unnamed_function_1417(System_Func_Money_MoneyType__bool__TypeInfo);
		  System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		            (uVar2,iVar1,Method_UI_Price_Price___c__DisplayClass33_0__GetGameResources_b__1__,0);
		  uVar2 = System_Linq_Enumerable__Where_PlayerLoopSystem_
		                    (uVar5,uVar2,Method_System_Linq_Enumerable_Where_Money_MoneyType___);
		  uVar5 = unnamed_function_1417(System_Func_Money_MoneyType__Money__TypeInfo);
		  System_Linq_Enumerable__Where_object_
		            (uVar5,iVar1,Method_UI_Price_Price___c__DisplayClass33_0__GetGameResources_b__2__,0);
		  uVar2 = System_Linq_Enumerable__ReverseIterator___Il2CppFullySharedGenericType_
		                    (uVar2,uVar5,Method_System_Linq_Enumerable_Select_Money_MoneyType__Money___);
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
		              (uVar5,iVar1,Method_UI_Price_Price___c__DisplayClass33_0__GetGameResources_b__3__,0);
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
		    if (*(int *)(UI_Price_Price___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(UI_Price_Price___c_TypeInfo);
		    }
		    puVar3 = *(undefined4 **)(UI_Price_Price___c_TypeInfo + 0x5c);
		    iVar1 = puVar3[2];
		    if (iVar1 == 0) {
		      if (*(int *)(UI_Price_Price___c_TypeInfo + 0x74) == 0) {
		        func_ii_306000(UI_Price_Price___c_TypeInfo);
		        puVar3 = *(undefined4 **)(UI_Price_Price___c_TypeInfo + 0x5c);
		      }
		      uVar2 = *puVar3;
		      iVar1 = unnamed_function_1417(System_Func_List_Money___IEnumerable_Money___TypeInfo);
		      System_Linq_Enumerable__Where_object_
		                (iVar1,uVar2,Method_UI_Price_Price___c__GetGameResources_b__33_4__,0);
		      *(int *)(*(int *)(UI_Price_Price___c_TypeInfo + 0x5c) + 8) = iVar1;
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

		/* --- GHIDRA: PriceItemTdGetAssetIdHandler ---
		int UI_Price_Price__PriceItemTdGetAssetIdHandler(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  int *param1_00;
		  undefined4 uVar2;
		  undefined4 *puVar3;
		  int iVar4;
		  undefined4 uVar5;
		  int iVar6;
		  
		  if (DAT_ram_00a59a4a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_Money_MoneyType__Money__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_Money_MoneyType__Money__get_Values__);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_SelectMany_List_Money___Money___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Select_Money_MoneyType__Money___);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Linq_Enumerable_ToDictionary_Money__Money_MoneyType___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToList_Money___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Where_Money_MoneyType___);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Where_Money___);
		    Mono_Security_ASN1__get_Item(&System_Func_Money_MoneyType__Money__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Func_Money__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Func_List_Money___IEnumerable_Money___TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Func_Money_MoneyType__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Func_Money__Money_MoneyType__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_Money____TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Money__get_Count__);
		    Mono_Security_ASN1__get_Item(&UI_Price_Price_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UI_Price_Price___c__GetGameResources_b__33_0__);
		    Mono_Security_ASN1__get_Item(&Method_UI_Price_Price___c__GetGameResources_b__33_4__);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Price_Price___c__DisplayClass33_0__GetGameResources_b__1__);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Price_Price___c__DisplayClass33_0__GetGameResources_b__2__);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Price_Price___c__DisplayClass33_0__GetGameResources_b__3__);
		    Mono_Security_ASN1__get_Item(&UI_Price_Price___c__DisplayClass33_0_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UI_Price_Price___c_TypeInfo);
		    DAT_ram_00a59a4a = '\x01';
		  }
		  iVar1 = unnamed_function_1417(UI_Price_Price___c__DisplayClass33_0_TypeInfo);
		  uVar2 = *(undefined4 *)(param1 + 0x28);
		  if (*(int *)(UI_Price_Price___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UI_Price_Price___c_TypeInfo);
		  }
		  puVar3 = *(undefined4 **)(UI_Price_Price___c_TypeInfo + 0x5c);
		  iVar4 = puVar3[1];
		  if (iVar4 == 0) {
		    if (*(int *)(UI_Price_Price___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(UI_Price_Price___c_TypeInfo);
		      puVar3 = *(undefined4 **)(UI_Price_Price___c_TypeInfo + 0x5c);
		    }
		    uVar5 = *puVar3;
		    iVar4 = unnamed_function_1417(System_Func_Money__Money_MoneyType__TypeInfo);
		    System_Linq_Enumerable__Where_object_
		              (iVar4,uVar5,Method_UI_Price_Price___c__GetGameResources_b__33_0__,0);
		    *(int *)(*(int *)(UI_Price_Price___c_TypeInfo + 0x5c) + 4) = iVar4;
		  }
		  uVar2 = System_Linq_Enumerable__ToDictionary_object__Int32Enum_
		                    (uVar2,iVar4,
		                     Method_System_Linq_Enumerable_ToDictionary_Money__Money_MoneyType___);
		  *(undefined4 *)(iVar1 + 8) = uVar2;
		  if (*(int *)(UI_Price_Price_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UI_Price_Price_TypeInfo);
		  }
		  uVar5 = **(undefined4 **)(UI_Price_Price_TypeInfo + 0x5c);
		  uVar2 = unnamed_function_1417(System_Func_Money_MoneyType__bool__TypeInfo);
		  System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		            (uVar2,iVar1,Method_UI_Price_Price___c__DisplayClass33_0__GetGameResources_b__1__,0);
		  uVar2 = System_Linq_Enumerable__Where_PlayerLoopSystem_
		                    (uVar5,uVar2,Method_System_Linq_Enumerable_Where_Money_MoneyType___);
		  uVar5 = unnamed_function_1417(System_Func_Money_MoneyType__Money__TypeInfo);
		  System_Linq_Enumerable__Where_object_
		            (uVar5,iVar1,Method_UI_Price_Price___c__DisplayClass33_0__GetGameResources_b__2__,0);
		  uVar2 = System_Linq_Enumerable__ReverseIterator___Il2CppFullySharedGenericType_
		                    (uVar2,uVar5,Method_System_Linq_Enumerable_Select_Money_MoneyType__Money___);
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
		              (uVar5,iVar1,Method_UI_Price_Price___c__DisplayClass33_0__GetGameResources_b__3__,0);
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
		    if (*(int *)(UI_Price_Price___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(UI_Price_Price___c_TypeInfo);
		    }
		    puVar3 = *(undefined4 **)(UI_Price_Price___c_TypeInfo + 0x5c);
		    iVar1 = puVar3[2];
		    if (iVar1 == 0) {
		      if (*(int *)(UI_Price_Price___c_TypeInfo + 0x74) == 0) {
		        func_ii_306000(UI_Price_Price___c_TypeInfo);
		        puVar3 = *(undefined4 **)(UI_Price_Price___c_TypeInfo + 0x5c);
		      }
		      uVar2 = *puVar3;
		      iVar1 = unnamed_function_1417(System_Func_List_Money___IEnumerable_Money___TypeInfo);
		      System_Linq_Enumerable__Where_object_
		                (iVar1,uVar2,Method_UI_Price_Price___c__GetGameResources_b__33_4__,0);
		      *(int *)(*(int *)(UI_Price_Price___c_TypeInfo + 0x5c) + 8) = iVar1;
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

			return null;
		}

		// Token: 0x06000BD6 RID: 3030 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000BD6")]
		[Address(RVA = "0x5EEE", Offset = "0x5EEE", VA = "0x5EEE")]
		private string PriceItemTdGetAssetIdHandler(Money.MoneyType moneyType)
		{
			return null;
		}

		// Token: 0x06000BD7 RID: 3031 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000BD7")]
		[Address(RVA = "0x5EEF", Offset = "0x5EEF", VA = "0x5EEF", Slot = "6")]
		protected virtual List<Money> GetGameResources()
		{
			return null;
		}

		// Token: 0x06000BD8 RID: 3032 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BD8")]
		[Address(RVA = "0x5EF0", Offset = "0x5EF0", VA = "0x5EF0")]
		private void ResetPoolObjectDelegate(PriceItemRenderer pooledObject)
		{
		/* --- GHIDRA: ResetPoolObjectDelegate ---
		void UI_Price_Price__ResetPoolObjectDelegate(int param1,undefined4 param2,undefined4 param3)
		
		{
		  int param2_00;
		  undefined4 param2_01;
		  undefined4 param2_02;
		  int iVar1;
		  
		  param2_00 = 0;
		  if (DAT_ram_00a59a4b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_PriceItemRenderer__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_PriceItemRenderer__get_Item__);
		    DAT_ram_00a59a4b = '\x01';
		  }
		  iVar1 = *(int *)(*(int *)(param1 + 0x2c) + 0xc);
		  if (0 < iVar1) {
		    do {
		      param2_01 = System_Linq_Enumerable__ToList_object_
		                            (*(undefined4 *)(param1 + 0x2c),param2_00,
		                             Method_System_Collections_Generic_List_PriceItemRenderer__get_Item__);
		      param2_02 = UI_Price_Price__HandleMoneyValues(param1,param2_01,param2,param2_00);
		      UI_Price_PriceItemRenderer__set_TruncatePrice(param2_01,param2_02,0);
		      param2_00 = param2_00 + 1;
		    } while (param2_00 != iVar1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06000BD9 RID: 3033 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BD9")]
		[Address(RVA = "0x5EF1", Offset = "0x5EF1", VA = "0x5EF1")]
		private void HandleMoneyValues(ResourceSet balance)
		{
		/* --- GHIDRA: HandleMoneyValues ---
		uint UI_Price_Price__HandleMoneyValues(int param1,undefined4 param2,int param3,undefined4 param4)
		
		{
		  undefined4 in_register_20000014;
		  uint *puVar1;
		  undefined4 uVar2;
		  longlong lVar3;
		  double dVar4;
		  double dVar5;
		  int *param1_00;
		  int iVar6;
		  uint uVar7;
		  undefined4 param1_01;
		  byte local_10;
		  float8 local_8;
		  
		  if (DAT_ram_00a59a4c == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_MoneyType_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_double__GetValueOrDefault__);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_double___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_double__get_HasValue__);
		    DAT_ram_00a59a4c = '\x01';
		  }
		  if (*(int *)(param1 + 0x20) == 1) {
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar6 = *param1_00;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      uVar7 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar7 * 8)) {
		          puVar1 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar7 * 8 + 4) * 8 + iVar6 + 0x288);
		          goto code_r0x810b3dc7;
		        }
		        uVar7 = uVar7 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar7);
		    }
		    puVar1 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x39);
		code_r0x810b3dc7:
		    iVar6 = (**(code **)((ulonglong)*puVar1 * 4))
		                      (param1_00,CONCAT44(in_register_20000014,puVar1[1]));
		    uVar2 = *(undefined4 *)(iVar6 + 0x14);
		    iVar6 = Core_Extensions_Dict_ResourceSetExt__GetValue(*(undefined4 *)(param1 + 0x28),0);
		    lVar3 = Gameplay_ThemeDuelState_Model_ThemeDuelStateModel__set_EventBackTime(uVar2,0);
		    uVar2 = *(undefined4 *)(param1 + 0x28);
		    if (iVar6 == 0) {
		      dVar4 = Core_Extensions_Dict_ResourceSetExt__GetNonZeroResourcesesIds(uVar2,4,0);
		      if (ABS(dVar4) < 9.223372036854776e+18) {
		        uVar7 = (uint)((longlong)dVar4 <= lVar3);
		      }
		      else {
		        uVar7 = 1;
		      }
		    }
		    else {
		      if (*(int *)(Core_Money_Money_MoneyType_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_Money_Money_MoneyType_TypeInfo);
		      }
		      dVar4 = Core_Money_MoneyException___ctor
		                        (uVar2,*(undefined4 *)
		                                (*(int *)(Core_Money_Money_MoneyType_TypeInfo + 0x5c) + 0x18),0);
		      if (ABS(dVar4) < 9.223372036854776e+18) {
		        uVar7 = (uint)((longlong)dVar4 <= lVar3);
		      }
		      else {
		        uVar7 = 1;
		      }
		    }
		  }
		  else {
		    if (param3 == 0) {
		      uVar7 = 0;
		      dVar4 = 0.0;
		    }
		    else {
		      uVar2 = UI_Price_PriceItemRenderer__SetIconAssetId(param2,0);
		      dVar4 = func_ii_6906(param3,uVar2,0);
		      local_8 = 0.0;
		      _local_10 = 0;
		      System_Collections_Generic_Dictionary_ValueCollection_Enumerator_ulong__object___MoveNext
		                (&local_10,dVar4,Method_System_Nullable_double___ctor__);
		      uVar7 = (uint)(local_10 != 0);
		      dVar4 = (double)local_8;
		    }
		    param1_01 = *(undefined4 *)(param1 + 0x28);
		    uVar2 = UI_Price_PriceItemRenderer__SetIconAssetId(param2,0);
		    dVar5 = Core_Extensions_Dict_ResourceSetExt__GetNonZeroResourcesesIds(param1_01,uVar2,0);
		    uVar7 = uVar7 & dVar5 <= dVar4;
		  }
		  return uVar7;
		}
		*/

		}

		// Token: 0x06000BDA RID: 3034 RVA: 0x00003CD8 File Offset: 0x00001ED8
		[Token(Token = "0x6000BDA")]
		[Address(RVA = "0x5EF2", Offset = "0x5EF2", VA = "0x5EF2")]
		private bool IsEnoughMoney(PriceItemRenderer view, ResourceSet balance)
		{
		/* --- GHIDRA: IsEnoughMoney ---
		void UI_Price_Price__IsEnoughMoney(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  int *piVar2;
		  int iVar3;
		  int local_18;
		  undefined8 *local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a59a4d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_PriceItemRenderer__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_PriceItemRenderer__MoveNext__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_PriceItemRenderer__get_Current__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_PriceItemRenderer__Clear__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_PriceItemRenderer__GetEnumerator__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_Cache_ObjectPool_PriceItemRenderer__Release__);
		    DAT_ram_00a59a4d = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		            (&local_10,*(undefined4 *)(param1 + 0x2c),
		             Method_System_Collections_Generic_List_PriceItemRenderer__GetEnumerator__);
		  local_18 = 0;
		  local_14 = &local_10;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar1 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_10,
		                       Method_System_Collections_Generic_List_Enumerator_PriceItemRenderer__MoveNext__
		                      );
		    iVar3 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar3 == 1) {
		      param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x810b4a21;
		    }
		    if (iVar1 == 0) goto code_r0x810b4a77;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x18,*(undefined4 *)(param1 + 0x30)
		               ,local_8._4_4_,Method_Utils_Cache_ObjectPool_PriceItemRenderer__Release__);
		    iVar3 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		  } while (iVar3 != 1);
		  param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x810b4a21:
		  iVar3 = global_1;
		  iVar1 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar3 == iVar1) {
		    piVar2 = (int *)import::env::__cxa_begin_catch(param1_00);
		    iVar1 = *piVar2;
		    DAT_ram_009d3e38 = 0;
		    local_18 = iVar1;
		    import::env::invoke_v(0x123);
		    iVar3 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar3 != 1) {
		      if (iVar1 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(iVar1);
		        do {
		          halt_trap();
		        } while( true );
		      }
		code_r0x810b4a77:
		      DAT_ram_009d3e38 = 0;
		      iVar3 = *(int *)(param1 + 0x2c);
		      iVar1 = *(int *)(iVar3 + 0xc);
		      *(undefined4 *)(iVar3 + 0xc) = 0;
		      *(int *)(iVar3 + 0x10) = *(int *)(iVar3 + 0x10) + 1;
		      if (0 < iVar1) {
		        func_ii_2064(*(undefined4 *)(iVar3 + 8),0,iVar1,0);
		      }
		      return;
		    }
		    param1_00 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001f04 + 0x8a,&local_18);
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

			return default(bool);
		}

		// Token: 0x06000BDB RID: 3035 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BDB")]
		[Address(RVA = "0x5EF3", Offset = "0x5EF3", VA = "0x5EF3")]
		private void HidePrices()
		{
		/* --- GHIDRA: HidePrices ---
		void UI_Price_Price__HidePrices(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a59a4e == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_PriceItemRenderer___ctor__)
		    ;
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_PriceItemRenderer__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_TypeInfo);
		    DAT_ram_00a59a4e = '\x01';
		  }
		  *(undefined4 *)(param1 + 0x18) = 0xffffffff;
		  if (*(int *)(Core_Money_Money_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Money_Money_TypeInfo);
		  }
		  uVar1 = Core_Money_Money__FromMoney(0);
		  *(undefined4 *)(param1 + 0x28) = uVar1;
		  uVar1 = unnamed_function_1417(System_Collections_Generic_List_PriceItemRenderer__TypeInfo);
		  Unity_Services_Core_Internal_UnityServicesInternal___c__DisplayClass33_0___InitializeServicesAsync_g__FailServicesInitialization_2
		            (uVar1,5,Method_System_Collections_Generic_List_PriceItemRenderer___ctor__);
		  *(undefined4 *)(param1 + 0x2c) = uVar1;
		  UnityEngine_RectTransform__GetParentSize(param1,0);
		  return;
		}
		*/

		}

		// Token: 0x06000BDC RID: 3036 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BDC")]
		[Address(RVA = "0x5EF4", Offset = "0x5EF4", VA = "0x5EF4")]
		public Price()
		{
		/* --- GHIDRA: .cctor ---
		void UI_Price_Price___cctor(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a638df == '\0') {
		    Mono_Security_ASN1__get_Item(&UI_Price_Price___c_TypeInfo);
		    DAT_ram_00a638df = '\x01';
		  }
		  uVar1 = unnamed_function_1417(UI_Price_Price___c_TypeInfo);
		  **(undefined4 **)(UI_Price_Price___c_TypeInfo + 0x5c) = uVar1;
		  return;
		}
		*/

		/* --- GHIDRA: .ctor ---
		void UI_Price_Price___ctor(undefined4 param1)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a59a4f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_MoneyType___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_MoneyType_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UI_Price_Price_TypeInfo);
		    DAT_ram_00a59a4f = '\x01';
		  }
		  iVar1 = Mono_Security_ASN1Convert__ToOid(Core_Money_Money_MoneyType___TypeInfo,5);
		  if (*(int *)(Core_Money_Money_MoneyType_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Money_Money_MoneyType_TypeInfo);
		  }
		  *(undefined4 *)(iVar1 + 0x10) =
		       *(undefined4 *)(*(int *)(Core_Money_Money_MoneyType_TypeInfo + 0x5c) + 4);
		  *(undefined4 *)(iVar1 + 0x14) =
		       *(undefined4 *)(*(int *)(Core_Money_Money_MoneyType_TypeInfo + 0x5c) + 8);
		  *(undefined4 *)(iVar1 + 0x18) =
		       *(undefined4 *)(*(int *)(Core_Money_Money_MoneyType_TypeInfo + 0x5c) + 0xc);
		  *(undefined4 *)(iVar1 + 0x1c) =
		       *(undefined4 *)(*(int *)(Core_Money_Money_MoneyType_TypeInfo + 0x5c) + 0x10);
		  *(undefined4 *)(iVar1 + 0x20) =
		       *(undefined4 *)(*(int *)(Core_Money_Money_MoneyType_TypeInfo + 0x5c) + 0x14);
		  **(int **)(UI_Price_Price_TypeInfo + 0x5c) = iVar1;
		  return;
		}
		*/

		}

		// Token: 0x0400057B RID: 1403
		[Token(Token = "0x400057B")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		protected Transform _container;

		// Token: 0x0400057C RID: 1404
		[Token(Token = "0x400057C")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		protected PriceItemRenderer _priceItemPrefab;

		// Token: 0x0400057D RID: 1405
		[Token(Token = "0x400057D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		protected Color32 _currentTextColor;

		// Token: 0x0400057E RID: 1406
		[Token(Token = "0x400057E")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		protected bool _truncatePrice;

		// Token: 0x0400057F RID: 1407
		[Token(Token = "0x400057F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Price.PriceMode _mode;

		// Token: 0x04000580 RID: 1408
		[Token(Token = "0x4000580")]
		[FieldOffset(Offset = "0x0")]
		protected static readonly IReadOnlyList<Money.MoneyType> MoneyTypesDefaultSequence;

		// Token: 0x04000581 RID: 1409
		[Token(Token = "0x4000581")]
		[FieldOffset(Offset = "0x24")]
		private IBalanceSource _source;

		// Token: 0x04000582 RID: 1410
		[Token(Token = "0x4000582")]
		[FieldOffset(Offset = "0x28")]
		protected Money _priceValue;

		// Token: 0x04000583 RID: 1411
		[Token(Token = "0x4000583")]
		[FieldOffset(Offset = "0x2C")]
		private readonly List<PriceItemRenderer> _currentPrices;

		// Token: 0x04000584 RID: 1412
		[Token(Token = "0x4000584")]
		[FieldOffset(Offset = "0x30")]
		private GameObjectPool<PriceItemRenderer> _priceItemRenderPool;

		// Token: 0x020001BC RID: 444
		[Token(Token = "0x20001BC")]
		[Serializable]
		public enum PriceMode
		{
			// Token: 0x04000586 RID: 1414
			[Token(Token = "0x4000586")]
			Default,
			// Token: 0x04000587 RID: 1415
			[Token(Token = "0x4000587")]
			ThemeDuel
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Source ---
		void UI_Price_Price__get_Source(int param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int param2_00;
		  
		  param2_00 = *(int *)(param1 + 0x24);
		  if (param2_00 != param2) {
		    *(int *)(param1 + 0x24) = param2;
		    iVar1 = func_ii_12174(param1,0);
		    if (iVar1 != 0) {
		      if (param2_00 != 0) {
		        UI_Price_Price__StartListenEvents(param1,param2_00,param1);
		      }
		      if (param2 != 0) {
		        UI_Price_Price__set_PriceValue(param1,param2,param1);
		      }
		    }
		  }
		  return;
		}
		*/


		/* --- GHIDRA: get_PriceValue ---
		void UI_Price_Price__get_PriceValue(int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int *param1_00;
		  int iVar1;
		  uint uVar2;
		  
		  if (DAT_ram_00a59a44 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_TypeInfo);
		    DAT_ram_00a59a44 = '\x01';
		  }
		  iVar1 = param1[10];
		  if (*(int *)(Core_Money_Money_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Money_Money_TypeInfo);
		  }
		  iVar1 = Core_Money_Money__op_Inequality(iVar1,param2,0);
		  if (iVar1 == 0) {
		    param1_00 = (int *)Core_Money_Money__GetEnumerator(param2,0);
		    iVar1 = Core_Money_Money_TypeInfo;
		    if (param1_00 == (int *)0x0) {
		      param1[10] = 0;
		    }
		    else {
		      uVar2 = (uint)*(byte *)(Core_Money_Money_TypeInfo + 0xb8);
		      if ((*(byte *)(*param1_00 + 0xb8) < uVar2) ||
		         (*(int *)(*(int *)(*param1_00 + 100) + (uVar2 - 1) * 4) != Core_Money_Money_TypeInfo)) {
		code_r0x8109ae91:
		        System_Activator__CreateInstance(param1_00,iVar1);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      param1[10] = (int)param1_00;
		      if ((*(byte *)(*param1_00 + 0xb8) < uVar2) ||
		         (*(int *)(*(int *)(*param1_00 + 100) + (uVar2 - 1) * 4) != iVar1)) goto code_r0x8109ae91;
		    }
		    (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))(param1,*(undefined4 *)(*param1 + 0xec));
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_PriceValue ---
		void UI_Price_Price__set_PriceValue(undefined4 param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 param1_00;
		  uint *puVar2;
		  int iVar3;
		  
		  if (DAT_ram_00a59a45 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Data_Balance_IBalanceSource_BalanceChangedDelegate_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Data_Balance_IBalanceSource_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UI_Price_Price_HandleBalanceChangedEvent__);
		    DAT_ram_00a59a45 = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (Core_Data_Balance_IBalanceSource_BalanceChangedDelegate_TypeInfo);
		  Core_Data_InfoRows_CollectionRow___ctor
		            (param1_00,param1,Method_UI_Price_Price_HandleBalanceChangedEvent__,0);
		  iVar3 = *param2;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Data_Balance_IBalanceSource_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8))
		      {
		        puVar2 = (uint *)(iVar3 + *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x8109ada0;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,Core_Data_Balance_IBalanceSource_TypeInfo,0);
		code_r0x8109ada0:
		  (**(code **)((ulonglong)*puVar2 * 4))(param2,param1_00,puVar2[1]);
		  return;
		}
		*/

}
