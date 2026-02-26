using System;
using System.Runtime.CompilerServices;
using Com.TheFallenGames.OSA.Core;
using Com.TheFallenGames.OSA.DataHelpers;
using Il2CppDummyDll;

namespace UI.ValuePicker
{
	// Token: 0x0200011C RID: 284
	[Token(Token = "0x200011C")]
	public class ValuePickerOsaSpinner : OSA<ValuePickerOsaParams, ValuePickerOsaViewHolder>
	{
		// Token: 0x17000120 RID: 288
		// (get) Token: 0x060008E3 RID: 2275 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060008E4 RID: 2276 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000120")]
		public SimpleDataHelper<string> Data
		{
			[Token(Token = "0x60008E3")]
			[Address(RVA = "0x5C62", Offset = "0x5C62", VA = "0x5C62")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60008E4")]
			[Address(RVA = "0x5C63", Offset = "0x5C63", VA = "0x5C63")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x060008E5 RID: 2277 RVA: 0x000035A0 File Offset: 0x000017A0
		// (set) Token: 0x060008E6 RID: 2278 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000121")]
		public int CurrentSelectedIndex
		{
			[Token(Token = "0x60008E5")]
			[Address(RVA = "0x5C64", Offset = "0x5C64", VA = "0x5C64")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60008E6")]
			[Address(RVA = "0x5C65", Offset = "0x5C65", VA = "0x5C65")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x140000CF RID: 207
		// (add) Token: 0x060008E7 RID: 2279 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060008E8 RID: 2280 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000CF")]
		public event Action<int> CurrentSelectedIndexChangedEvent
		{
			[Token(Token = "0x60008E7")]
			[Address(RVA = "0x5C66", Offset = "0x5C66", VA = "0x5C66")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60008E8")]
			[Address(RVA = "0x5C67", Offset = "0x5C67", VA = "0x5C67")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x060008E9 RID: 2281 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008E9")]
		[Address(RVA = "0x5C68", Offset = "0x5C68", VA = "0x5C68", Slot = "67")]
		protected override void Awake()
		{
		/* --- GHIDRA: Awake ---
		void UI_ValuePicker_ValuePickerOsaSpinner__Awake(int param1,undefined4 param2)
		
		{
		  int *piVar1;
		  int iVar2;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a5b8a9 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ValuePickerOsaViewHolder__get_Item__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_Core_OSAExtensions_GetVisibleItems_ValuePickerOsaParams__ValuePickerOsaViewHolder___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_Core_OSA_ValuePickerOsaParams__ValuePickerOsaViewHolder__Update__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_Core_OSA_ValuePickerOsaParams__ValuePickerOsaViewHolder__get_IsInitialized__
		              );
		    DAT_ram_00a5b8a9 = '\x01';
		  }
		  Com_TheFallenGames_OSA_Core_OSA_object__object___TryExtractRecyclableViewsHolderFrom
		            (param1,
		             Method_Com_TheFallenGames_OSA_Core_OSA_ValuePickerOsaParams__ValuePickerOsaViewHolder__Update__
		            );
		  if ((*(char *)(param1 + 0x50) != '\0') && (*(int *)(param1 + 0x40) != 0)) {
		    piVar1 = (int *)System_Linq_Enumerable__ToList_object_
		                              (*(undefined4 *)(param1 + 0x2c),1,
		                               Method_System_Collections_Generic_List_ValuePickerOsaViewHolder__get_Item__
		                              );
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*piVar1 + 0xe0) * 4))
		                      (piVar1,*(undefined4 *)(*piVar1 + 0xe4));
		    if (iVar2 != *(int *)(param1 + 0xa4)) {
		      param2_00 = (**(code **)((ulonglong)*(uint *)(*piVar1 + 0xe0) * 4))
		                            (piVar1,*(undefined4 *)(*piVar1 + 0xe4));
		      UI_ValuePicker_ValuePickerOsaSpinner__Update(param1,param2_00,param1);
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x060008EA RID: 2282 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008EA")]
		[Address(RVA = "0x5C69", Offset = "0x5C69", VA = "0x5C69", Slot = "70")]
		protected override void Update()
		{
		/* --- GHIDRA: Update ---
		void UI_ValuePicker_ValuePickerOsaSpinner__Update(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int iVar2;
		  undefined4 param1_00;
		  int *piVar3;
		  int iVar4;
		  int iVar5;
		  float param3_00;
		  undefined8 local_38;
		  undefined8 local_30;
		  int local_28;
		  undefined8 *local_24;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5b8aa == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_ValuePickerOsaViewHolder__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_ValuePickerOsaViewHolder__MoveNext__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_Enumerator_ValuePickerOsaViewHolder__get_Current__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_ValuePickerOsaViewHolder__GetEnumerator__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_Core_OSAExtensions_GetVisibleItems_ValuePickerOsaParams__ValuePickerOsaViewHolder___
		              );
		    DAT_ram_00a5b8aa = '\x01';
		  }
		  local_18 = 0;
		  local_20 = 0;
		  *(undefined4 *)(param1 + 0xa4) = param2;
		  System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		            (&local_20,*(undefined4 *)(param1 + 0x2c),
		             Method_System_Collections_Generic_List_ValuePickerOsaViewHolder__GetEnumerator__);
		  local_28 = 0;
		  local_24 = &local_20;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar2 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,&local_20,
		                       Method_System_Collections_Generic_List_Enumerator_ValuePickerOsaViewHolder__MoveNext__
		                      );
		    iVar5 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar5 == 1) {
		      param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x8138c1a0;
		    }
		    if (iVar2 == 0) goto code_r0x8138c1f6;
		    iVar4 = local_18._4_4_[5];
		    DAT_ram_009d3e38 = 0;
		    iVar2 = import::env::invoke_iii
		                      (*(undefined4 *)(*local_18._4_4_ + 0xe0),local_18._4_4_,
		                       *(undefined4 *)(*local_18._4_4_ + 0xe4));
		    iVar5 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar5 == 1) {
		      param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x8138c1a0;
		    }
		    iVar5 = *(int *)(param1 + 0xa4);
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_iiii
		              (s_struct_Uniforms___color__array<v_ram_00001f04 + 0x44,*(undefined4 *)(iVar4 + 0x10),
		               0,0);
		    if (DAT_ram_009d3e38 == 1) break;
		    DAT_ram_009d3e38 = 0;
		    param3_00 = 1.0;
		    bVar1 = iVar2 != iVar5;
		    if (bVar1) {
		      param3_00 = 0.0;
		    }
		    import::env::invoke_iiffi
		              (s_struct_Uniforms___color__array<v_ram_0000223f + 0x167,*(undefined4 *)(iVar4 + 0x10)
		               ,param3_00,0.3,0);
		    if (DAT_ram_009d3e38 == 1) break;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_iiii
		              (s_struct_Uniforms___color__array<v_ram_00001f04 + 0x44,*(undefined4 *)(iVar4 + 0x14),
		               0,0);
		    if (DAT_ram_009d3e38 == 1) break;
		    iVar5 = 0x18;
		    if (bVar1) {
		      iVar5 = 0x28;
		    }
		    local_30 = ((undefined8 *)(iVar4 + iVar5))[1];
		    local_38 = *(undefined8 *)(iVar4 + iVar5);
		    DAT_ram_009d3e38 = 0;
		    local_10 = local_38;
		    local_8 = local_30;
		    import::env::invoke_iiifi
		              (s_struct_Uniforms___color__array<v_ram_0000223f + 0x168,*(undefined4 *)(iVar4 + 0x14)
		               ,&local_38,0.3,0);
		  } while (DAT_ram_009d3e38 != 1);
		  DAT_ram_009d3e38 = 0;
		  param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x8138c1a0:
		  iVar5 = global_1;
		  iVar2 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar5 == iVar2) {
		    piVar3 = (int *)import::env::__cxa_begin_catch(param1_00);
		    iVar2 = *piVar3;
		    DAT_ram_009d3e38 = 0;
		    local_28 = iVar2;
		    import::env::invoke_v(0x123);
		    iVar5 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar5 != 1) {
		      if (iVar2 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(iVar2);
		        do {
		          halt_trap();
		        } while( true );
		      }
		code_r0x8138c1f6:
		      DAT_ram_009d3e38 = 0;
		      iVar5 = *(int *)(param1 + 0xa8);
		      if (iVar5 != 0) {
		        (**(code **)((ulonglong)*(uint *)(iVar5 + 0xc) * 4))
		                  (*(undefined4 *)(iVar5 + 0x20),*(undefined4 *)(param1 + 0xa4),
		                   *(undefined4 *)(iVar5 + 0x14));
		      }
		      return;
		    }
		    param1_00 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_0000223f + 0x169,&local_28);
		  iVar5 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar5 == 1) {
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

		}

		// Token: 0x060008EB RID: 2283 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008EB")]
		[Address(RVA = "0x5C6A", Offset = "0x5C6A", VA = "0x5C6A")]
		private void OnItemSelected(int index)
		{
		/* --- GHIDRA: OnItemSelected ---
		undefined4
		UI_ValuePicker_ValuePickerOsaSpinner__OnItemSelected(int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5b8ab == '\0') {
		    Mono_Security_ASN1__get_Item(&UI_ValuePicker_ValuePickerOsaViewHolder_TypeInfo);
		    DAT_ram_00a5b8ab = '\x01';
		  }
		  param1_00 = unnamed_function_1417(UI_ValuePicker_ValuePickerOsaViewHolder_TypeInfo);
		  Com_TheFallenGames_OSA_Core_AbstractViewsHolder__set_ItemIndex
		            (param1_00,*(undefined4 *)(*(int *)(param1 + 0x10) + 0x4c),
		             *(undefined4 *)(*(int *)(param1 + 0x10) + 8),param2,1,1,0);
		  return param1_00;
		}
		*/

		}

		// Token: 0x060008EC RID: 2284 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60008EC")]
		[Address(RVA = "0x5C6B", Offset = "0x5C6B", VA = "0x5C6B", Slot = "99")]
		protected override ValuePickerOsaViewHolder CreateViewsHolder(int itemIndex)
		{
		/* --- GHIDRA: CreateViewsHolder ---
		void UI_ValuePicker_ValuePickerOsaSpinner__CreateViewsHolder
		               (int param1,int *param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  int iVar2;
		  
		  if (DAT_ram_00a5b8ac == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_string__get_Item__);
		    DAT_ram_00a5b8ac = '\x01';
		  }
		  param1_00 = *(undefined4 *)(param1 + 0xa0);
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param2 + 0xe0) * 4))
		                    (param2,*(undefined4 *)(*param2 + 0xe4));
		  uVar1 = Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_object___System_Collections_IEnumerable_GetEnumerator
		                    (param1_00,uVar1,
		                     Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_string__get_Item__);
		  iVar2 = **(int **)(param2[5] + 0x14);
		  (**(code **)((ulonglong)*(uint *)(iVar2 + 0x2d0) * 4))
		            (*(int **)(param2[5] + 0x14),uVar1,*(undefined4 *)(iVar2 + 0x2d4));
		  return;
		}
		*/

			return null;
		}

		// Token: 0x060008ED RID: 2285 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008ED")]
		[Address(RVA = "0x5C6C", Offset = "0x5C6C", VA = "0x5C6C", Slot = "100")]
		protected override void UpdateViewsHolder(ValuePickerOsaViewHolder newOrRecycled)
		{
		/* --- GHIDRA: UpdateViewsHolder ---
		void UI_ValuePicker_ValuePickerOsaSpinner__UpdateViewsHolder(int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5b8ad == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_Core_OSA_ValuePickerOsaParams__ValuePickerOsaViewHolder___ctor__
		              );
		    DAT_ram_00a5b8ad = '\x01';
		  }
		  *(undefined4 *)(param1 + 0xa4) = 0xffffffff;
		  UI_OSAGenericBase_object__object___set_Data
		            (param1,
		             Method_Com_TheFallenGames_OSA_Core_OSA_ValuePickerOsaParams__ValuePickerOsaViewHolder___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x060008EE RID: 2286 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008EE")]
		[Address(RVA = "0x5C6D", Offset = "0x5C6D", VA = "0x5C6D")]
		public ValuePickerOsaSpinner()
		{
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_CurrentSelectedIndex ---
		void UI_ValuePicker_ValuePickerOsaSpinner__set_CurrentSelectedIndex
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5b8a6 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_int__TypeInfo);
		    DAT_ram_00a5b8a6 = '\x01';
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
		void UI_ValuePicker_ValuePickerOsaSpinner__add_CurrentSelectedIndexChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5b8a7 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_int__TypeInfo);
		    DAT_ram_00a5b8a7 = '\x01';
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
		void UI_ValuePicker_ValuePickerOsaSpinner__remove_CurrentSelectedIndexChangedEvent
		               (int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5b8a8 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_Core_OSA_ValuePickerOsaParams__ValuePickerOsaViewHolder__Start__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_string___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_string__TypeInfo);
		    DAT_ram_00a5b8a8 = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_string__TypeInfo);
		  System_Collections_Generic_ShortEnumEqualityComparer___Il2CppFullySharedGenericStructType___GetHashCode
		            (param1_00,param1,1,
		             Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_string___ctor__);
		  *(undefined4 *)(param1 + 0xa0) = param1_00;
		  Com_TheFallenGames_OSA_Core_OSA_object__object___SmoothScrollTo
		            (param1,
		             Method_Com_TheFallenGames_OSA_Core_OSA_ValuePickerOsaParams__ValuePickerOsaViewHolder__Start__
		            );
		  return;
		}
		*/

}
