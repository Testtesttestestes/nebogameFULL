using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Com.TheFallenGames.OSA.Core;
using Com.TheFallenGames.OSA.CustomParams;
using Com.TheFallenGames.OSA.DataHelpers;
using Gameplay.Bank.View;
using Il2CppDummyDll;

namespace Gameplay.SpecialOffers.View.Picker
{
	// Token: 0x02000501 RID: 1281
	[Token(Token = "0x2000501")]
	public class SpecialOfferPickerOsaSpinner : OSA<BaseParamsWithPrefab, BankOptionPickerOsaViewHolder>
	{
		// Token: 0x17000593 RID: 1427
		// (get) Token: 0x06001E91 RID: 7825 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06001E92 RID: 7826 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000593")]
		public SimpleDataHelper<BankOptionListElement.BankOptionListElementArgs> Data
		{
			[Token(Token = "0x6001E91")]
			[Address(RVA = "0x7004", Offset = "0x7004", VA = "0x7004")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001E92")]
			[Address(RVA = "0x7005", Offset = "0x7005", VA = "0x7005")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000594 RID: 1428
		// (get) Token: 0x06001E93 RID: 7827 RVA: 0x00006510 File Offset: 0x00004710
		// (set) Token: 0x06001E94 RID: 7828 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000594")]
		public int CurrentSelectedIndex
		{
			[Token(Token = "0x6001E93")]
			[Address(RVA = "0x7006", Offset = "0x7006", VA = "0x7006")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001E94")]
			[Address(RVA = "0x7007", Offset = "0x7007", VA = "0x7007")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x14000137 RID: 311
		// (add) Token: 0x06001E95 RID: 7829 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06001E96 RID: 7830 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000137")]
		public event Action<int> CurrentSelectedIndexChangedEvent
		{
			[Token(Token = "0x6001E95")]
			[Address(RVA = "0x7008", Offset = "0x7008", VA = "0x7008")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6001E96")]
			[Address(RVA = "0x7009", Offset = "0x7009", VA = "0x7009")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06001E97 RID: 7831 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E97")]
		[Address(RVA = "0x700A", Offset = "0x700A", VA = "0x700A", Slot = "67")]
		protected override void Awake()
		{
		/* --- GHIDRA: Awake ---
		void Gameplay_SpecialOffers_View_Picker_SpecialOfferPickerOsaSpinner__Awake
		               (int param1,undefined4 param2)
		
		{
		  int *piVar1;
		  int iVar2;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a58626 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_Core_OSAExtensions_GetVisibleItems_BaseParamsWithPrefab__BankOptionPickerOsaViewHolder___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_Core_OSA_BaseParamsWithPrefab__BankOptionPickerOsaViewHolder__Update__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_Core_OSA_BaseParamsWithPrefab__BankOptionPickerOsaViewHolder__get_IsInitialized__
		              );
		    DAT_ram_00a58626 = '\x01';
		  }
		  Com_TheFallenGames_OSA_Core_OSA_object__object___TryExtractRecyclableViewsHolderFrom
		            (param1,
		             Method_Com_TheFallenGames_OSA_Core_OSA_BaseParamsWithPrefab__BankOptionPickerOsaViewHolder__Update__
		            );
		  if ((*(char *)(param1 + 0x50) != '\0') && (*(int *)(param1 + 0x40) != 0)) {
		    piVar1 = (int *)Gameplay_SpecialOffers_View_Picker_SpecialOfferPickerOsaSpinner__Update
		                              (param1,*(undefined4 *)(param1 + 0x2c),param1);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*piVar1 + 0xe0) * 4))
		                      (piVar1,*(undefined4 *)(*piVar1 + 0xe4));
		    if (iVar2 != *(int *)(param1 + 0xa4)) {
		      param2_00 = (**(code **)((ulonglong)*(uint *)(*piVar1 + 0xe0) * 4))
		                            (piVar1,*(undefined4 *)(*piVar1 + 0xe4));
		      Gameplay_SpecialOffers_View_Picker_SpecialOfferPickerOsaSpinner__GetLargeItem
		                (param1,param2_00,param1);
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001E98 RID: 7832 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E98")]
		[Address(RVA = "0x700B", Offset = "0x700B", VA = "0x700B", Slot = "70")]
		protected override void Update()
		{
		/* --- GHIDRA: Update ---
		int Gameplay_SpecialOffers_View_Picker_SpecialOfferPickerOsaSpinner__Update
		              (undefined4 param1,int param2,undefined4 param3)
		
		{
		  float4 fVar1;
		  int param2_00;
		  float4 fVar2;
		  int iVar3;
		  undefined4 uVar4;
		  int iVar5;
		  undefined1 auStack_c [4];
		  float4 local_8;
		  
		  if (DAT_ram_00a58627 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_BankOptionPickerOsaViewHolder__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_BankOptionPickerOsaViewHolder__get_Item__);
		    DAT_ram_00a58627 = '\x01';
		  }
		  iVar3 = System_Linq_Enumerable__ToList_object_
		                    (param2,0,
		                     Method_System_Collections_Generic_List_BankOptionPickerOsaViewHolder__get_Item__
		                    );
		  uVar4 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                    (*(undefined4 *)(iVar3 + 0x14),0);
		  func_ii_20513(auStack_c,uVar4,0);
		  if (1 < *(int *)(param2 + 0xc)) {
		    param2_00 = 1;
		    fVar2 = local_8;
		    do {
		      iVar5 = System_Linq_Enumerable__ToList_object_
		                        (param2,param2_00,
		                         Method_System_Collections_Generic_List_BankOptionPickerOsaViewHolder__get_Item__
		                        );
		      uVar4 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                        (*(undefined4 *)(iVar5 + 0x14),0);
		      func_ii_20513(auStack_c,uVar4,0);
		      fVar1 = local_8;
		      if ((float)fVar2 <= (float)local_8) {
		        iVar3 = System_Linq_Enumerable__ToList_object_
		                          (param2,param2_00,
		                           Method_System_Collections_Generic_List_BankOptionPickerOsaViewHolder__get_Item__
		                          );
		        fVar2 = fVar1;
		      }
		      param2_00 = param2_00 + 1;
		    } while (param2_00 < *(int *)(param2 + 0xc));
		  }
		  return iVar3;
		}
		*/

		}

		// Token: 0x06001E99 RID: 7833 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001E99")]
		[Address(RVA = "0x700C", Offset = "0x700C", VA = "0x700C")]
		private BankOptionPickerOsaViewHolder GetLargeItem(List<BankOptionPickerOsaViewHolder> items)
		{
		/* --- GHIDRA: GetLargeItem ---
		void Gameplay_SpecialOffers_View_Picker_SpecialOfferPickerOsaSpinner__GetLargeItem
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  int *piVar2;
		  int param2_00;
		  int iVar3;
		  int local_18;
		  undefined8 *local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a58628 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_BankOptionPickerOsaViewHolder__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_BankOptionPickerOsaViewHolder__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_BankOptionPickerOsaViewHolder__get_Current__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_BankOptionPickerOsaViewHolder__GetEnumerator__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_Core_OSAExtensions_GetVisibleItems_BaseParamsWithPrefab__BankOptionPickerOsaViewHolder___
		              );
		    DAT_ram_00a58628 = '\x01';
		  }
		  local_8 = 0;
		  local_10 = 0;
		  *(undefined4 *)(param1 + 0xa4) = param2;
		  System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		            (&local_10,*(undefined4 *)(param1 + 0x2c),
		             Method_System_Collections_Generic_List_BankOptionPickerOsaViewHolder__GetEnumerator__);
		  local_18 = 0;
		  local_14 = &local_10;
		  while( true ) {
		    DAT_ram_009d3e38 = 0;
		    iVar1 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_10,
		                       Method_System_Collections_Generic_List_Enumerator_BankOptionPickerOsaViewHolder__MoveNext__
		                      );
		    iVar3 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar3 == 1) {
		      param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80f162ff;
		    }
		    if (iVar1 == 0) goto code_r0x80f16355;
		    param2_00 = local_8._4_4_[5];
		    DAT_ram_009d3e38 = 0;
		    iVar1 = import::env::invoke_iii
		                      (*(undefined4 *)(*local_8._4_4_ + 0xe0),local_8._4_4_,
		                       *(undefined4 *)(*local_8._4_4_ + 0xe4));
		    iVar3 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar3 == 1) break;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x18a,param2_00,
		               (uint)(*(int *)(param1 + 0xa4) == iVar1),0);
		    iVar3 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar3 == 1) {
		      param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80f162ff:
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
		code_r0x80f16355:
		          DAT_ram_009d3e38 = 0;
		          iVar3 = *(int *)(param1 + 0xa8);
		          if (iVar3 != 0) {
		            (**(code **)((ulonglong)*(uint *)(iVar3 + 0xc) * 4))
		                      (*(undefined4 *)(iVar3 + 0x20),*(undefined4 *)(param1 + 0xa4),
		                       *(undefined4 *)(iVar3 + 0x14));
		          }
		          return;
		        }
		        param1_00 = import::env::__cxa_find_matching_catch_2();
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x18b,&local_18);
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
		  }
		  param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		  goto code_r0x80f162ff;
		}
		*/

			return null;
		}

		// Token: 0x06001E9A RID: 7834 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E9A")]
		[Address(RVA = "0x700D", Offset = "0x700D", VA = "0x700D")]
		private void SelectItem(int index)
		{
		/* --- GHIDRA: SelectItem ---
		undefined4
		Gameplay_SpecialOffers_View_Picker_SpecialOfferPickerOsaSpinner__SelectItem
		          (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a58629 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_SpecialOffers_View_Picker_BankOptionPickerOsaViewHolder_TypeInfo);
		    DAT_ram_00a58629 = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (Gameplay_SpecialOffers_View_Picker_BankOptionPickerOsaViewHolder_TypeInfo);
		  Com_TheFallenGames_OSA_Core_AbstractViewsHolder__set_ItemIndex
		            (param1_00,*(undefined4 *)(*(int *)(param1 + 0x10) + 0x4c),
		             *(undefined4 *)(*(int *)(param1 + 0x10) + 8),param2,1,1,0);
		  return param1_00;
		}
		*/

		}

		// Token: 0x06001E9B RID: 7835 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001E9B")]
		[Address(RVA = "0x700E", Offset = "0x700E", VA = "0x700E", Slot = "99")]
		protected override BankOptionPickerOsaViewHolder CreateViewsHolder(int itemIndex)
		{
		/* --- GHIDRA: CreateViewsHolder ---
		void Gameplay_SpecialOffers_View_Picker_SpecialOfferPickerOsaSpinner__CreateViewsHolder
		               (int param1,int *param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5862a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_BankOptionListElement_BankOptionListElementArgs__get_Item__
		              );
		    DAT_ram_00a5862a = '\x01';
		  }
		  param1_00 = *(undefined4 *)(param1 + 0xa0);
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param2 + 0xe0) * 4))
		                    (param2,*(undefined4 *)(*param2 + 0xe4));
		  uVar1 = Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_object___System_Collections_IEnumerable_GetEnumerator
		                    (param1_00,uVar1,
		                     Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_BankOptionListElement_BankOptionListElementArgs__get_Item__
		                    );
		  Gameplay_Bank_View_BankOptionListElement__ButtonClickedEventHandler(param2[5],uVar1,0);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06001E9C RID: 7836 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E9C")]
		[Address(RVA = "0x700F", Offset = "0x700F", VA = "0x700F", Slot = "100")]
		protected override void UpdateViewsHolder(BankOptionPickerOsaViewHolder newOrRecycled)
		{
		/* --- GHIDRA: UpdateViewsHolder ---
		void Gameplay_SpecialOffers_View_Picker_SpecialOfferPickerOsaSpinner__UpdateViewsHolder
		               (int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5862b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_Core_OSA_BaseParamsWithPrefab__BankOptionPickerOsaViewHolder___ctor__
		              );
		    DAT_ram_00a5862b = '\x01';
		  }
		  *(undefined4 *)(param1 + 0xa4) = 0xffffffff;
		  UI_OSAGenericBase_object__object___set_Data
		            (param1,
		             Method_Com_TheFallenGames_OSA_Core_OSA_BaseParamsWithPrefab__BankOptionPickerOsaViewHolder___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06001E9D RID: 7837 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E9D")]
		[Address(RVA = "0x7010", Offset = "0x7010", VA = "0x7010")]
		public SpecialOfferPickerOsaSpinner()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_SpecialOffers_View_Picker_SpecialOfferPickerOsaSpinner___ctor
		               (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5862c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UnityEngine_Component_GetComponent_BankOptionListElement___);
		    DAT_ram_00a5862c = '\x01';
		  }
		  uVar1 = func_ii_5677(*(undefined4 *)(param1 + 8),
		                       Method_UnityEngine_Component_GetComponent_BankOptionListElement___);
		  *(undefined4 *)(param1 + 0x14) = uVar1;
		  return;
		}
		*/

		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_CurrentSelectedIndex ---
		void Gameplay_SpecialOffers_View_Picker_SpecialOfferPickerOsaSpinner__set_CurrentSelectedIndex
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a58623 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_int__TypeInfo);
		    DAT_ram_00a58623 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0xa8);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_int__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_int__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0xa8,iVar2,param1_00);
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


		/* --- GHIDRA: add_CurrentSelectedIndexChangedEvent ---
		void Gameplay_SpecialOffers_View_Picker_SpecialOfferPickerOsaSpinner__add_CurrentSelectedIndexChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a58624 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_int__TypeInfo);
		    DAT_ram_00a58624 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0xa8);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_int__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_int__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0xa8,iVar2,param1_00);
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


		/* --- GHIDRA: remove_CurrentSelectedIndexChangedEvent ---
		void Gameplay_SpecialOffers_View_Picker_SpecialOfferPickerOsaSpinner__remove_CurrentSelectedIndexChangedEvent
		               (int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a58625 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_Core_OSA_BaseParamsWithPrefab__BankOptionPickerOsaViewHolder__Start__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_BankOptionListElement_BankOptionListElementArgs___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_BankOptionListElement_BankOptionListElementArgs__TypeInfo
		              );
		    DAT_ram_00a58625 = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (
		                        Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_BankOptionListElement_BankOptionListElementArgs__TypeInfo
		                        );
		  System_Collections_Generic_ShortEnumEqualityComparer___Il2CppFullySharedGenericStructType___GetHashCode
		            (param1_00,param1,1,
		             Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_BankOptionListElement_BankOptionListElementArgs___ctor__
		            );
		  *(undefined4 *)(param1 + 0xa0) = param1_00;
		  Com_TheFallenGames_OSA_Core_OSA_object__object___SmoothScrollTo
		            (param1,
		             Method_Com_TheFallenGames_OSA_Core_OSA_BaseParamsWithPrefab__BankOptionPickerOsaViewHolder__Start__
		            );
		  return;
		}
		*/

}
