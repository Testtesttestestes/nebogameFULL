using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Gameplay.Managers.Ad.Providers;
using Gameplay.Bank.Model;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using Utils.Cache;

namespace Gameplay.Bank.View
{
	// Token: 0x02000C40 RID: 3136
	[Token(Token = "0x2000C40")]
	public class BankOptionsListView : MonoBehaviour
	{
		// Token: 0x140001DB RID: 475
		// (add) Token: 0x06004C7A RID: 19578 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06004C7B RID: 19579 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001DB")]
		public event Action<IBankOptionView> BuyButtonClickedEvent
		{
			[Token(Token = "0x6004C7A")]
			[Address(RVA = "0x9ABB", Offset = "0x9ABB", VA = "0x9ABB")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6004C7B")]
			[Address(RVA = "0x9ABC", Offset = "0x9ABC", VA = "0x9ABC")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140001DC RID: 476
		// (add) Token: 0x06004C7C RID: 19580 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06004C7D RID: 19581 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001DC")]
		public event Action<BankOptionView> FaqButtonClickedEvent
		{
			[Token(Token = "0x6004C7C")]
			[Address(RVA = "0x9ABD", Offset = "0x9ABD", VA = "0x9ABD")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6004C7D")]
			[Address(RVA = "0x9ABE", Offset = "0x9ABE", VA = "0x9ABE")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06004C7E RID: 19582 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C7E")]
		[Address(RVA = "0x9ABF", Offset = "0x9ABF", VA = "0x9ABF")]
		private void Awake()
		{
		/* --- GHIDRA: Awake ---
		void Gameplay_Bank_View_BankOptionsListView__Awake(undefined4 param1,int param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 uVar2;
		  int iVar3;
		  undefined4 uVar4;
		  int iVar5;
		  int iVar6;
		  
		  if (DAT_ram_00a59788 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBankOptionView__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_BankOptionView__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Bank_View_BankOptionsListView_ViewOnBuyButtonClickEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Bank_View_BankOptionsListView_ViewOnFaqButtonClickEvent__);
		    DAT_ram_00a59788 = '\x01';
		  }
		  iVar6 = *(int *)(param2 + 0x54);
		  if (*(char *)(iVar6 + 0x1c) != '\0') {
		    *(undefined1 *)(iVar6 + 0x1c) = 0;
		    iVar3 = **(int **)(iVar6 + 0x18);
		    (**(code **)((ulonglong)*(uint *)(iVar3 + 0x130) * 4))
		              (*(int **)(iVar6 + 0x18),*(undefined4 *)(iVar3 + 0x134));
		    *(undefined4 *)(iVar6 + 0x18) = 0;
		  }
		  uVar4 = unnamed_function_1417(System_Action_IBankOptionView__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar4,param1,Method_Gameplay_Bank_View_BankOptionsListView_ViewOnBuyButtonClickEvent__,
		             0);
		  if (DAT_ram_00a59772 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBankOptionView__TypeInfo);
		    DAT_ram_00a59772 = '\x01';
		  }
		  iVar6 = *(int *)(param2 + 0x5c);
		  while( true ) {
		    iVar3 = 0;
		    iVar5 = func_ii_7048(iVar6,uVar4,0);
		    uVar2 = System_Action_IBankOptionView__TypeInfo;
		    if ((iVar5 != 0) &&
		       (iVar3 = func_ii_1082(iVar5,System_Action_IBankOptionView__TypeInfo), iVar3 == 0)) break;
		    iVar3 = func_ii_4329(param2 + 0x5c,iVar3,iVar6);
		    bVar1 = iVar3 == iVar6;
		    iVar6 = iVar3;
		    if (bVar1) {
		      uVar4 = unnamed_function_1417(System_Action_BankOptionView__TypeInfo);
		      UnityEngine_UIElements_VisualElement__get_layout
		                (uVar4,param1,
		                 Method_Gameplay_Bank_View_BankOptionsListView_ViewOnFaqButtonClickEvent__,0);
		      if (DAT_ram_00a59774 == '\0') {
		        Mono_Security_ASN1__get_Item(&System_Action_BankOptionView__TypeInfo);
		        DAT_ram_00a59774 = '\x01';
		      }
		      iVar6 = *(int *)(param2 + 0x60);
		      while( true ) {
		        iVar3 = 0;
		        iVar5 = func_ii_7048(iVar6,uVar4,0);
		        uVar2 = System_Action_BankOptionView__TypeInfo;
		        if ((iVar5 != 0) &&
		           (iVar3 = func_ii_1082(iVar5,System_Action_BankOptionView__TypeInfo), iVar3 == 0)) break;
		        iVar3 = func_ii_4329(param2 + 0x60,iVar3,iVar6);
		        bVar1 = iVar3 == iVar6;
		        iVar6 = iVar3;
		        if (bVar1) {
		          uVar4 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                            (param2,0);
		          Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                    (uVar4,0,0);
		          return;
		        }
		      }
		      System_Activator__CreateInstance(iVar5,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  System_Activator__CreateInstance(iVar5,uVar2);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06004C7F RID: 19583 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C7F")]
		[Address(RVA = "0x9AC0", Offset = "0x9AC0", VA = "0x9AC0")]
		private void OnReleaseBankOptionView(BankOptionView pooledObject)
		{
		}

		// Token: 0x06004C80 RID: 19584 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C80")]
		[Address(RVA = "0x9AC1", Offset = "0x9AC1", VA = "0x9AC1")]
		public void Init(IOptionValidator optionValidator, IAdPlacementManagerProvider provider)
		{
		}

		// Token: 0x17000F6B RID: 3947
		// (get) Token: 0x06004C81 RID: 19585 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004C82 RID: 19586 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000F6B")]
		public IList<BankOptionData> Data
		{
			[Token(Token = "0x6004C81")]
			[Address(RVA = "0x9AC2", Offset = "0x9AC2", VA = "0x9AC2")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004C82")]
			[Address(RVA = "0x9AC3", Offset = "0x9AC3", VA = "0x9AC3")]
			set
			{
			}
		}

		// Token: 0x17000F6C RID: 3948
		// (get) Token: 0x06004C83 RID: 19587 RVA: 0x0000E100 File Offset: 0x0000C300
		// (set) Token: 0x06004C84 RID: 19588 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000F6C")]
		public Vector2 ScrollPosition
		{
			[Token(Token = "0x6004C83")]
			[Address(RVA = "0x9AC4", Offset = "0x9AC4", VA = "0x9AC4")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6004C84")]
			[Address(RVA = "0x9AC5", Offset = "0x9AC5", VA = "0x9AC5")]
			private set
			{
			}
		}

		// Token: 0x06004C85 RID: 19589 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C85")]
		[Address(RVA = "0x9AC6", Offset = "0x9AC6", VA = "0x9AC6")]
		public void SetScrollPosition(Vector2 position)
		{
		/* --- GHIDRA: SetScrollPosition ---
		void Gameplay_Bank_View_BankOptionsListView__SetScrollPosition
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = *(int *)(param1 + 0x34);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),param2,*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004C86 RID: 19590 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C86")]
		[Address(RVA = "0x9AC7", Offset = "0x9AC7", VA = "0x9AC7")]
		private void ViewOnFaqButtonClickEvent(BankOptionView target)
		{
		}

		// Token: 0x06004C87 RID: 19591 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C87")]
		[Address(RVA = "0x9AC8", Offset = "0x9AC8", VA = "0x9AC8")]
		private void ViewOnBuyButtonClickEvent(IBankOptionView target)
		{
		/* --- GHIDRA: ViewOnBuyButtonClickEvent ---
		void Gameplay_Bank_View_BankOptionsListView__ViewOnBuyButtonClickEvent(int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5978b == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Utils_Cache_ObjectPool_BankOptionView__Clear__);
		    DAT_ram_00a5978b = '\x01';
		  }
		  Gameplay_Bank_View_BankOptionsListView__get_Data(param1,0,param1);
		  Utils_Cache_ObjectPool_object____ctor
		            (*(undefined4 *)(param1 + 0x28),Method_Utils_Cache_ObjectPool_BankOptionView__Clear__);
		  return;
		}
		*/

		}

		// Token: 0x06004C88 RID: 19592 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C88")]
		[Address(RVA = "0x9AC9", Offset = "0x9AC9", VA = "0x9AC9")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void Gameplay_Bank_View_BankOptionsListView__OnDestroy(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5978c == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_BankOptionView___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_BankOptionView__TypeInfo);
		    DAT_ram_00a5978c = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_Collections_Generic_List_BankOptionView__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_00,Method_System_Collections_Generic_List_BankOptionView___ctor__);
		  *(undefined4 *)(param1 + 0x2c) = param1_00;
		  UnityEngine_RectTransform__GetParentSize(param1,0);
		  return;
		}
		*/

		}

		// Token: 0x06004C89 RID: 19593 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C89")]
		[Address(RVA = "0x9ACA", Offset = "0x9ACA", VA = "0x9ACA")]
		public BankOptionsListView()
		{
		}

		// Token: 0x040029BE RID: 10686
		[Token(Token = "0x40029BE")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Transform _container;

		// Token: 0x040029BF RID: 10687
		[Token(Token = "0x40029BF")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private ScrollRect _scrollRect;

		// Token: 0x040029C0 RID: 10688
		[Token(Token = "0x40029C0")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private BankOptionView _bankOptionViewPrefab;

		// Token: 0x040029C1 RID: 10689
		[Token(Token = "0x40029C1")]
		[FieldOffset(Offset = "0x1C")]
		private IList<BankOptionData> _data;

		// Token: 0x040029C2 RID: 10690
		[Token(Token = "0x40029C2")]
		[FieldOffset(Offset = "0x20")]
		private IOptionValidator _optionValidator;

		// Token: 0x040029C3 RID: 10691
		[Token(Token = "0x40029C3")]
		[FieldOffset(Offset = "0x24")]
		private IAdPlacementManagerProvider _placementManagerProvider;

		// Token: 0x040029C4 RID: 10692
		[Token(Token = "0x40029C4")]
		[FieldOffset(Offset = "0x28")]
		private GameObjectPool<BankOptionView> _bankOptionViewPool;

		// Token: 0x040029C5 RID: 10693
		[Token(Token = "0x40029C5")]
		[FieldOffset(Offset = "0x2C")]
		private List<BankOptionView> _currentViews;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_BuyButtonClickedEvent ---
		void Gameplay_Bank_View_BankOptionsListView__add_BuyButtonClickedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a59784 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBankOptionView__TypeInfo);
		    DAT_ram_00a59784 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x30);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_IBankOptionView__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IBankOptionView__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x30,iVar2,param1_00);
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


		/* --- GHIDRA: remove_BuyButtonClickedEvent ---
		void Gameplay_Bank_View_BankOptionsListView__remove_BuyButtonClickedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a59785 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_BankOptionView__TypeInfo);
		    DAT_ram_00a59785 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x34);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_BankOptionView__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_BankOptionView__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x34,iVar2,param1_00);
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


		/* --- GHIDRA: add_FaqButtonClickedEvent ---
		void Gameplay_Bank_View_BankOptionsListView__add_FaqButtonClickedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a59786 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_BankOptionView__TypeInfo);
		    DAT_ram_00a59786 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x34);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_BankOptionView__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_BankOptionView__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x34,iVar2,param1_00);
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


		/* --- GHIDRA: remove_FaqButtonClickedEvent ---
		void Gameplay_Bank_View_BankOptionsListView__remove_FaqButtonClickedEvent
		               (int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  undefined4 param3;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a59787 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Bank_View_BankOptionsListView_OnReleaseBankOptionView__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_Cache_GameObjectPool_BankOptionView___ctor__);
		    Mono_Security_ASN1__get_Item(&Utils_Cache_GameObjectPool_BankOptionView__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Utils_Cache_ObjectPool_ResetPoolObjectDelegate_BankOptionView__TypeInfo);
		    DAT_ram_00a59787 = '\x01';
		  }
		  param3 = *(undefined4 *)(param1 + 0x10);
		  param2_00 = *(undefined4 *)(param1 + 0x18);
		  param1_00 = unnamed_function_1417
		                        (Utils_Cache_ObjectPool_ResetPoolObjectDelegate_BankOptionView__TypeInfo);
		  Core_Cache_AbstractCache_RequestInvoker___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType____ctor
		            (param1_00,param1,
		             Method_Gameplay_Bank_View_BankOptionsListView_OnReleaseBankOptionView__,0);
		  param1_01 = unnamed_function_1417(Utils_Cache_GameObjectPool_BankOptionView__TypeInfo);
		  Utils_Cache_GameObjectPoolRestricted_object___CreateInstance
		            (param1_01,param2_00,param3,param1_00,
		             Method_Utils_Cache_GameObjectPool_BankOptionView___ctor__);
		  *(undefined4 *)(param1 + 0x28) = param1_01;
		  return;
		}
		*/


		/* --- GHIDRA: get_Data ---
		void Gameplay_Bank_View_BankOptionsListView__get_Data
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int *piVar2;
		  int iVar3;
		  undefined4 uVar4;
		  int *piVar5;
		  uint *puVar6;
		  undefined4 uVar7;
		  int iVar8;
		  int iVar9;
		  int *piVar10;
		  uint uVar11;
		  int iVar12;
		  undefined1 uVar13;
		  undefined1 local_25;
		  int local_24;
		  undefined1 *puStack_20;
		  undefined8 local_1c;
		  int *local_14;
		  undefined1 local_10 [8];
		  undefined8 local_8;
		  
		  iVar12 = 0;
		  if (DAT_ram_00a59789 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBankOptionView__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_BankOptionView__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Bank_Model_BankOptionViewArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Core_Gameplay_Managers_Ad_Placements_BankOptions_BankOptionsAdPlacementManager_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Bank_View_BankOptionsListView_ViewOnBuyButtonClickEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Bank_View_BankOptionsListView_ViewOnFaqButtonClickEvent__);
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_BankOptionView__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_BankOptionView__MoveNext__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_BankOptionView__get_Current__);
		    Mono_Security_ASN1__get_Item
		              (&Core_Gameplay_Managers_Ad_Providers_IAdPlacementManagerProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_ICollection_BankOptionData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IList_BankOptionData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Bank_Model_IOptionValidator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_BankOptionView__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_BankOptionView__Clear__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_BankOptionView__GetEnumerator__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_Cache_ObjectPool_BankOptionView__Get__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_Cache_ObjectPool_BankOptionView__Release__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3784);
		    DAT_ram_00a59789 = '\x01';
		  }
		  local_14 = (int *)0x0;
		  *(undefined4 *)(param1 + 0x1c) = param2;
		  System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		            (&local_24,*(undefined4 *)(param1 + 0x2c),
		             Method_System_Collections_Generic_List_BankOptionView__GetEnumerator__);
		  local_8 = local_1c;
		  local_24 = 0;
		  puStack_20 = local_10;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar3 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,local_10,
		                       Method_System_Collections_Generic_List_Enumerator_BankOptionView__MoveNext__)
		    ;
		    iVar9 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar9 == 1) {
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x810676ff;
		    }
		    if (iVar3 == 0) goto code_r0x81067755;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x18,*(undefined4 *)(param1 + 0x28)
		               ,local_8._4_4_,Method_Utils_Cache_ObjectPool_BankOptionView__Release__);
		    iVar9 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		  } while (iVar9 != 1);
		  uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x810676ff:
		  iVar9 = global_1;
		  iVar3 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar9 == iVar3) {
		    piVar5 = (int *)import::env::__cxa_begin_catch(uVar4);
		    iVar3 = *piVar5;
		    DAT_ram_009d3e38 = 0;
		    local_24 = iVar3;
		    import::env::invoke_v(0x123);
		    iVar9 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar9 != 1) {
		      if (iVar3 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(iVar3);
		        do {
		          halt_trap();
		        } while( true );
		      }
		code_r0x81067755:
		      DAT_ram_009d3e38 = 0;
		      iVar9 = *(int *)(param1 + 0x2c);
		      iVar3 = *(int *)(iVar9 + 0xc);
		      *(undefined4 *)(iVar9 + 0xc) = 0;
		      *(int *)(iVar9 + 0x10) = *(int *)(iVar9 + 0x10) + 1;
		      if (0 < iVar3) {
		        func_ii_2064(*(undefined4 *)(iVar9 + 8),0,iVar3,0);
		      }
		      piVar5 = *(int **)(param1 + 0x1c);
		      if (piVar5 == (int *)0x0) {
		        return;
		      }
		      do {
		        iVar9 = *piVar5;
		        if (*(ushort *)(iVar9 + 0xb6) != 0) {
		          uVar11 = 0;
		          do {
		            piVar10 = (int *)(*(int *)(iVar9 + 0x58) + uVar11 * 8);
		            if (System_Collections_Generic_ICollection_BankOptionData__TypeInfo == *piVar10) {
		              puVar6 = (uint *)(iVar9 + piVar10[1] * 8 + 0xc0);
		              goto code_r0x81067841;
		            }
		            uVar11 = uVar11 + 1;
		          } while (*(ushort *)(iVar9 + 0xb6) != uVar11);
		        }
		        puVar6 = (uint *)func_ii_1080(piVar5,
		                                      System_Collections_Generic_ICollection_BankOptionData__TypeInfo
		                                      ,0);
		code_r0x81067841:
		        iVar9 = (**(code **)((ulonglong)*puVar6 * 4))(piVar5,puVar6[1]);
		        if (iVar9 <= iVar12) {
		          return;
		        }
		        piVar5 = *(int **)(param1 + 0x1c);
		        iVar9 = *piVar5;
		        if (*(ushort *)(iVar9 + 0xb6) != 0) {
		          uVar11 = 0;
		          do {
		            piVar10 = (int *)(*(int *)(iVar9 + 0x58) + uVar11 * 8);
		            if (System_Collections_Generic_IList_BankOptionData__TypeInfo == *piVar10) {
		              puVar6 = (uint *)(iVar9 + piVar10[1] * 8 + 0xc0);
		              goto code_r0x810678c1;
		            }
		            uVar11 = uVar11 + 1;
		          } while (*(ushort *)(iVar9 + 0xb6) != uVar11);
		        }
		        puVar6 = (uint *)func_ii_1080(piVar5,
		                                      System_Collections_Generic_IList_BankOptionData__TypeInfo,0);
		code_r0x810678c1:
		        iVar9 = (**(code **)((ulonglong)*puVar6 * 4))(piVar5,iVar12,puVar6[1]);
		        piVar5 = *(int **)(param1 + 0x20);
		        iVar3 = *piVar5;
		        if (*(ushort *)(iVar3 + 0xb6) != 0) {
		          uVar11 = 0;
		          do {
		            piVar10 = (int *)(*(int *)(iVar3 + 0x58) + uVar11 * 8);
		            if (Gameplay_Bank_Model_IOptionValidator_TypeInfo == *piVar10) {
		              puVar6 = (uint *)(iVar3 + piVar10[1] * 8 + 0xc0);
		              goto code_r0x81067944;
		            }
		            uVar11 = uVar11 + 1;
		          } while (*(ushort *)(iVar3 + 0xb6) != uVar11);
		        }
		        puVar6 = (uint *)func_ii_1080(piVar5,Gameplay_Bank_Model_IOptionValidator_TypeInfo,0);
		code_r0x81067944:
		        iVar3 = (**(code **)((ulonglong)*puVar6 * 4))(piVar5,iVar9,puVar6[1]);
		        if (iVar3 != 0) {
		          if ((*(char *)(iVar9 + 0x6c) == '\0') || (*(char *)(iVar9 + 0x6d) == '\0')) {
		            piVar5 = (int *)Gameplay_Combat_View_VFX_StoneDestroyVFX__GetPool
		                                      (*(undefined4 *)(param1 + 0x28),
		                                       Method_Utils_Cache_ObjectPool_BankOptionView__Get__);
		            uVar4 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                              (piVar5,0);
		            UnityEngine_Transform__get_childCount(uVar4,0);
		            uVar4 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                              (piVar5,0);
		            Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                      (uVar4,1,0);
		            uVar4 = *(undefined4 *)(iVar9 + 0x28);
		            piVar10 = *(int **)(param1 + 0x24);
		            iVar3 = *piVar10;
		            if (*(ushort *)(iVar3 + 0xb6) != 0) {
		              uVar11 = 0;
		              do {
		                piVar2 = (int *)(*(int *)(iVar3 + 0x58) + uVar11 * 8);
		                if (Core_Gameplay_Managers_Ad_Providers_IAdPlacementManagerProvider_TypeInfo ==
		                    *piVar2) {
		                  puVar6 = (uint *)(iVar3 + piVar2[1] * 8 + 0xc0);
		                  goto code_r0x81067aae;
		                }
		                uVar11 = uVar11 + 1;
		              } while (*(ushort *)(iVar3 + 0xb6) != uVar11);
		            }
		            puVar6 = (uint *)func_ii_1080(piVar10,
		                                          Core_Gameplay_Managers_Ad_Providers_IAdPlacementManagerProvider_TypeInfo
		                                          ,0);
		code_r0x81067aae:
		            (**(code **)((ulonglong)*puVar6 * 4))(piVar10,uVar4,&local_14,puVar6[1]);
		            piVar10 = local_14;
		            piVar2 = (int *)0x0;
		            iVar3 = unnamed_function_1417(Gameplay_Bank_Model_BankOptionViewArgs_TypeInfo);
		            if (piVar10 != (int *)0x0) {
		              if (((uint)*(byte *)(
		                                  Core_Gameplay_Managers_Ad_Placements_BankOptions_BankOptionsAdPlacementManager_TypeInfo
		                                  + 0xb8) <= (uint)*(byte *)(*piVar10 + 0xb8)) &&
		                 (piVar2 = piVar10,
		                 *(int *)(*(int *)(*piVar10 + 100) +
		                          (uint)*(byte *)(
		                                         Core_Gameplay_Managers_Ad_Placements_BankOptions_BankOptionsAdPlacementManager_TypeInfo
		                                         + 0xb8) * 4 + -4) !=
		                 Core_Gameplay_Managers_Ad_Placements_BankOptions_BankOptionsAdPlacementManager_TypeInfo
		                 )) {
		                piVar2 = (int *)0x0;
		              }
		            }
		            *(int **)(iVar3 + 8) = piVar2;
		            *(int *)(iVar3 + 0xc) = iVar9;
		            (**(code **)((ulonglong)*(uint *)(*piVar5 + 0x138) * 4))
		                      (piVar5,iVar3,*(undefined4 *)(*piVar5 + 0x13c));
		            uVar4 = unnamed_function_1417(System_Action_IBankOptionView__TypeInfo);
		            UnityEngine_UIElements_VisualElement__get_layout
		                      (uVar4,param1,
		                       Method_Gameplay_Bank_View_BankOptionsListView_ViewOnBuyButtonClickEvent__,0);
		            if (DAT_ram_00a59771 == '\0') {
		              Mono_Security_ASN1__get_Item(&System_Action_IBankOptionView__TypeInfo);
		              DAT_ram_00a59771 = '\x01';
		            }
		            iVar9 = piVar5[0x17];
		            do {
		              iVar3 = 0;
		              iVar8 = UnityEngine_UI_Image__set_sprite(iVar9,uVar4,0);
		              uVar7 = System_Action_IBankOptionView__TypeInfo;
		              if ((iVar8 != 0) &&
		                 (iVar3 = func_ii_1082(iVar8,System_Action_IBankOptionView__TypeInfo), iVar3 == 0))
		              {
		                System_Activator__CreateInstance(iVar8,uVar7);
		                do {
		                  halt_trap();
		                } while( true );
		              }
		              iVar3 = func_ii_4329(piVar5 + 0x17,iVar3,iVar9);
		              bVar1 = iVar3 != iVar9;
		              iVar9 = iVar3;
		            } while (bVar1);
		            uVar4 = unnamed_function_1417(System_Action_BankOptionView__TypeInfo);
		            UnityEngine_UIElements_VisualElement__get_layout
		                      (uVar4,param1,
		                       Method_Gameplay_Bank_View_BankOptionsListView_ViewOnFaqButtonClickEvent__,0);
		            if (DAT_ram_00a59773 == '\0') {
		              Mono_Security_ASN1__get_Item(&System_Action_BankOptionView__TypeInfo);
		              DAT_ram_00a59773 = '\x01';
		            }
		            iVar9 = piVar5[0x18];
		            do {
		              iVar3 = 0;
		              iVar8 = UnityEngine_UI_Image__set_sprite(iVar9,uVar4,0);
		              uVar7 = System_Action_BankOptionView__TypeInfo;
		              if ((iVar8 != 0) &&
		                 (iVar3 = func_ii_1082(iVar8,System_Action_BankOptionView__TypeInfo), iVar3 == 0)) {
		                System_Activator__CreateInstance(iVar8,uVar7);
		                do {
		                  halt_trap();
		                } while( true );
		              }
		              iVar8 = func_ii_4329(piVar5 + 0x18,iVar3,iVar9);
		              iVar3 = Method_System_Collections_Generic_List_BankOptionView__Add__;
		              bVar1 = iVar8 != iVar9;
		              iVar9 = iVar8;
		            } while (bVar1);
		            iVar9 = *(int *)(param1 + 0x2c);
		            *(int *)(iVar9 + 0x10) = *(int *)(iVar9 + 0x10) + 1;
		            uVar11 = *(uint *)(iVar9 + 0xc);
		            if (uVar11 < *(uint *)(*(int *)(iVar9 + 8) + 0xc)) {
		              *(uint *)(iVar9 + 0xc) = uVar11 + 1;
		              *(int **)(*(int *)(iVar9 + 8) + uVar11 * 4 + 0x10) = piVar5;
		            }
		            else {
		              System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                        (iVar9,piVar5,
		                         *(undefined4 *)(*(int *)(*(int *)(iVar3 + 0x10) + 0x60) + 0x38));
		            }
		          }
		          else {
		            iVar3 = *(int *)(iVar9 + 0x30);
		            if (iVar3 == 0) {
		              local_24 = *(int *)(*(int *)(iVar9 + 0x38) + 0xc);
		              iVar3 = Protocol_Combat_ProtoPlayerActionEvt___ctor(&local_24,0);
		              *(int *)(iVar9 + 0x30) = iVar3;
		              uVar13 = *(undefined1 *)(iVar9 + 0x6c);
		            }
		            else {
		              uVar13 = 1;
		            }
		            local_24 = CONCAT31(local_24._1_3_,uVar13);
		            uVar4 = func_ii_1081(DAT_ram_00a66944,&local_24);
		            local_25 = *(undefined1 *)(iVar9 + 0x6d);
		            uVar7 = func_ii_1081(DAT_ram_00a66944,&local_25);
		            uVar4 = func_ii_8529(StringLiteral_3784,iVar3,uVar4,uVar7,0);
		            if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		              func_ii_306000(OKG_Logs_Debug_TypeInfo);
		            }
		            System_Collections_Generic_Dictionary_uint__object___get_Count(uVar4,0);
		          }
		        }
		        iVar12 = iVar12 + 1;
		        piVar5 = *(int **)(param1 + 0x1c);
		      } while( true );
		    }
		    uVar4 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x373,&local_24);
		  iVar12 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar12 == 1) {
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  import::env::__resumeException(uVar4);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: set_Data ---
		void Gameplay_Bank_View_BankOptionsListView__set_Data
		               (undefined8 *param1,int param2,undefined4 param3)
		
		{
		  undefined8 local_8;
		  
		  UnityEngine_UI_ScrollRect__UpdateScrollbars(&local_8,*(undefined4 *)(param2 + 0x14),0);
		  *param1 = local_8;
		  return;
		}
		*/


		/* --- GHIDRA: get_ScrollPosition ---
		void Gameplay_Bank_View_BankOptionsListView__get_ScrollPosition
		               (int param1,undefined8 *param2,undefined4 param3)
		
		{
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  local_10 = *param2;
		  local_8 = local_10;
		  UnityEngine_UI_ScrollRect__get_normalizedPosition(*(undefined4 *)(param1 + 0x14),&local_10,0);
		  return;
		}
		*/


		/* --- GHIDRA: set_ScrollPosition ---
		void Gameplay_Bank_View_BankOptionsListView__set_ScrollPosition
		               (undefined4 param1,undefined8 *param2,undefined4 param3)
		
		{
		  int param2_00;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5978a == '\0') {
		    Mono_Security_ASN1__get_Item(&DG_Tweening_TweenCallback_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Bank_View_BankOptionsListView___c__DisplayClass23_0__SetScrollPosition_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Bank_View_BankOptionsListView___c__DisplayClass23_0_TypeInfo);
		    DAT_ram_00a5978a = '\x01';
		  }
		  param2_00 = unnamed_function_1417
		                        (Gameplay_Bank_View_BankOptionsListView___c__DisplayClass23_0_TypeInfo);
		  *(undefined4 *)(param2_00 + 8) = param1;
		  *(undefined8 *)(param2_00 + 0xc) = *param2;
		  param1_00 = unnamed_function_1417(DG_Tweening_TweenCallback_TypeInfo);
		  DG_Tweening_Color2__op_Multiply
		            (param1_00,param2_00,
		             Method_Gameplay_Bank_View_BankOptionsListView___c__DisplayClass23_0__SetScrollPosition_b__0__
		             ,0);
		  DG_Tweening_DOVirtual__EasedValue(0.1,param1_00,1,0);
		  return;
		}
		*/

}
