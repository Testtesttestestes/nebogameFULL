using System;
using System.Collections.Generic;
using Gameplay.Bank.View;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.SpecialOffers.View.Picker
{
	// Token: 0x02000500 RID: 1280
	[Token(Token = "0x2000500")]
	public class SpecialOfferPicker : PrefabPicker<BankOptionListElement.BankOptionListElementArgs>
	{
		// Token: 0x06001E8B RID: 7819 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E8B")]
		[Address(RVA = "0x6FFE", Offset = "0x6FFE", VA = "0x6FFE")]
		private void Awake()
		{
		/* --- GHIDRA: Awake ---
		void Gameplay_SpecialOffers_View_Picker_SpecialOfferPicker__Awake(int param1,undefined4 param2)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  undefined4 param1_01;
		  int param1_02;
		  int iVar3;
		  
		  if (DAT_ram_00a5861f == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_int__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_SpecialOffers_View_Picker_PrefabPicker_BankOptionListElement_BankOptionListElementArgs__SpinnerOnCurrentSelectedIndexChangedEvent__
		              );
		    DAT_ram_00a5861f = '\x01';
		  }
		  iVar3 = *(int *)(param1 + 0x18);
		  param1_01 = unnamed_function_1417(System_Action_int__TypeInfo);
		  System_Action_short___Invoke
		            (param1_01,param1,
		             Method_Gameplay_SpecialOffers_View_Picker_PrefabPicker_BankOptionListElement_BankOptionListElementArgs__SpinnerOnCurrentSelectedIndexChangedEvent__
		             ,0);
		  if (DAT_ram_00a58624 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_int__TypeInfo);
		    DAT_ram_00a58624 = '\x01';
		  }
		  param1_00 = *(int *)(iVar3 + 0xa8);
		  while( true ) {
		    iVar2 = 0;
		    param1_02 = func_ii_7048(param1_00,param1_01,0);
		    param2_00 = System_Action_int__TypeInfo;
		    if ((param1_02 != 0) &&
		       (iVar2 = func_ii_1082(param1_02,System_Action_int__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(iVar3 + 0xa8,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_02,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06001E8C RID: 7820 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E8C")]
		[Address(RVA = "0x6FFF", Offset = "0x6FFF", VA = "0x6FFF")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void Gameplay_SpecialOffers_View_Picker_SpecialOfferPicker__OnDestroy
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int *param1_00;
		  int iVar4;
		  
		  if (DAT_ram_00a58620 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_IList_BankOptionListElement_BankOptionListElementArgs__TypeInfo
		              );
		    DAT_ram_00a58620 = '\x01';
		  }
		  param1_00 = *(int **)(param1 + 0x14);
		  iVar4 = *param1_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (System_Collections_Generic_IList_BankOptionListElement_BankOptionListElementArgs__TypeInfo
		          == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xd0);
		        goto code_r0x80f15dbc;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,
		                                System_Collections_Generic_IList_BankOptionListElement_BankOptionListElementArgs__TypeInfo
		                                ,2);
		code_r0x80f15dbc:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,param2,puVar2[1]);
		  iVar4 = **(int **)(param1 + 0x18);
		  (**(code **)((ulonglong)*(uint *)(iVar4 + 0x398) * 4))
		            (*(int **)(param1 + 0x18),uVar3,0x3e99999a,0,0xbf800000,0,0,0,
		             *(undefined4 *)(iVar4 + 0x39c));
		  return;
		}
		*/

		}

		// Token: 0x06001E8D RID: 7821 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E8D")]
		[Address(RVA = "0x7000", Offset = "0x7000", VA = "0x7000", Slot = "5")]
		public override void ScrollTo(BankOptionListElement.BankOptionListElementArgs item)
		{
		/* --- GHIDRA: ScrollTo ---
		void Gameplay_SpecialOffers_View_Picker_SpecialOfferPicker__ScrollTo
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = **(int **)(param1 + 0x18);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x398) * 4))
		            (*(int **)(param1 + 0x18),param2,0x3e99999a,0,0xbf800000,0,0,0,
		             *(undefined4 *)(iVar1 + 0x39c));
		  return;
		}
		*/

		}

		// Token: 0x06001E8E RID: 7822 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E8E")]
		[Address(RVA = "0x7001", Offset = "0x7001", VA = "0x7001")]
		public void ScrollToIndex(int index)
		{
		/* --- GHIDRA: ScrollToIndex ---
		void Gameplay_SpecialOffers_View_Picker_SpecialOfferPicker__ScrollToIndex
		               (int param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  int iVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a58621 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_ICollection_BankOptionListElement_BankOptionListElementArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_Core_OSA_BaseParamsWithPrefab__BankOptionPickerOsaViewHolder__ScheduleForceRebuildLayout__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_Core_OSA_BaseParamsWithPrefab__BankOptionPickerOsaViewHolder__get_Parameters__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_RectOffset_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_BankOptionListElement_BankOptionListElementArgs__ResetItems__
		              );
		    DAT_ram_00a58621 = '\x01';
		  }
		  *(int **)(param1 + 0x14) = param2;
		  iVar3 = *(int *)(*(int *)(*(int *)(param1 + 0x18) + 0x10) + 0x3c);
		  iVar4 = *param2;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (System_Collections_Generic_ICollection_BankOptionListElement_BankOptionListElementArgs__TypeInfo
		          == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80f15eff;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,
		                                System_Collections_Generic_ICollection_BankOptionListElement_BankOptionListElementArgs__TypeInfo
		                                ,0);
		code_r0x80f15eff:
		  iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		  *(bool *)(iVar3 + 0x29) = 3 < iVar4;
		  iVar3 = *(int *)(*(int *)(param1 + 0x18) + 0x10);
		  param1_00 = unnamed_function_1417(UnityEngine_RectOffset_TypeInfo);
		  UnityEngine_RectOffset__Finalize(param1_00,0xff,0xff,0,0,0);
		  *(undefined4 *)(iVar3 + 0x20) = param1_00;
		  Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_object___RemoveOneFromStart
		            (*(undefined4 *)(*(int *)(param1 + 0x18) + 0xa0),param2,0,
		             Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_BankOptionListElement_BankOptionListElementArgs__ResetItems__
		            );
		  Com_TheFallenGames_OSA_Core_OSA_object__object___ScheduleComputeVisibilityTwinPass
		            (*(undefined4 *)(param1 + 0x18),
		             Method_Com_TheFallenGames_OSA_Core_OSA_BaseParamsWithPrefab__BankOptionPickerOsaViewHolder__ScheduleForceRebuildLayout__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06001E8F RID: 7823 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E8F")]
		[Address(RVA = "0x7002", Offset = "0x7002", VA = "0x7002", Slot = "4")]
		public override void Init(IList<BankOptionListElement.BankOptionListElementArgs> args)
		{
		/* --- GHIDRA: Init ---
		void Gameplay_SpecialOffers_View_Picker_SpecialOfferPicker__Init
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a58622 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_SpecialOffers_View_Picker_PrefabPicker_BankOptionListElement_BankOptionListElementArgs___ctor__
		              );
		    DAT_ram_00a58622 = '\x01';
		  }
		  ScreenAdaptation_Common_AppSize__Update
		            (param1,
		             Method_Gameplay_SpecialOffers_View_Picker_PrefabPicker_BankOptionListElement_BankOptionListElementArgs___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06001E90 RID: 7824 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E90")]
		[Address(RVA = "0x7003", Offset = "0x7003", VA = "0x7003")]
		public SpecialOfferPicker()
		{
		}

		// Token: 0x0400109E RID: 4254
		[Token(Token = "0x400109E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SpecialOfferPickerOsaSpinner _spinner;
	}
}
