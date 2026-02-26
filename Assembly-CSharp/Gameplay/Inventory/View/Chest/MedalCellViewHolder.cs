using System;
using System.Collections.Generic;
using Com.TheFallenGames.OSA.CustomAdapters.GridView;
using Core.Data;
using Gameplay.Medals.View;
using Il2CppDummyDll;

namespace Gameplay.Inventory.View.Chest
{
	// Token: 0x02000692 RID: 1682
	[Token(Token = "0x2000692")]
	public class MedalCellViewHolder : CellViewsHolder
	{
		// Token: 0x060028A2 RID: 10402 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028A2")]
		[Address(RVA = "0x79C1", Offset = "0x79C1", VA = "0x79C1", Slot = "7")]
		public override void CollectViews()
		{
		/* --- GHIDRA: CollectViews ---
		void Gameplay_Inventory_View_Chest_MedalCellViewHolder__CollectViews
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5,
		               undefined4 param6,undefined4 param7,undefined4 param8)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a5a110 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_HashSet_MedalData__Contains__);
		    DAT_ram_00a5a110 = '\x01';
		  }
		  iVar1 = func_ii_10159(param5,param2,
		                        Method_System_Collections_Generic_HashSet_MedalData__Contains__);
		  if ((iVar1 == 0) &&
		     (iVar1 = func_ii_10159(param6,param2,
		                            Method_System_Collections_Generic_HashSet_MedalData__Contains__),
		     iVar1 == 0)) {
		    uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(param1 + 0x18),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar2,1,0);
		    iVar1 = **(int **)(param1 + 0x14);
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0x1a0) * 4))
		              (*(int **)(param1 + 0x14),0,*(undefined4 *)(iVar1 + 0x1a4));
		    Gameplay_Medals_View_MedalGroupView__MedalViewOnClickEvent
		              (*(undefined4 *)(param1 + 0x18),param3,param4,0);
		    iVar1 = *(int *)(param1 + 0x18);
		    *(undefined4 *)(iVar1 + 0x20) = param7;
		    Gameplay_Medals_View_MedalGroupView__get_MedalData(iVar1,param2,0);
		    return;
		  }
		  uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x18),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar2,0,0);
		  iVar1 = **(int **)(param1 + 0x14);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x1a0) * 4))
		            (*(int **)(param1 + 0x14),1,*(undefined4 *)(iVar1 + 0x1a4));
		  return;
		}
		*/

		}

		// Token: 0x060028A3 RID: 10403 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028A3")]
		[Address(RVA = "0x79C2", Offset = "0x79C2", VA = "0x79C2")]
		public void UpdateViews(MedalData model, UserData user, UserData loggedUser, HashSet<MedalData> separatorItems, HashSet<MedalData> rowCompletionItems, Action<MedalView> clickCallback)
		{
		/* --- GHIDRA: UpdateViews ---
		uint Gameplay_Inventory_View_Chest_MedalCellViewHolder__UpdateViews
		               (undefined4 param1,undefined4 param2,uint param3,undefined4 param4)
		
		{
		  int iVar1;
		  uint uVar2;
		  
		  if (DAT_ram_00a5a112 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_MedalDic__uint__get_Data__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Resources__get_Count__);
		    DAT_ram_00a5a112 = '\x01';
		  }
		  iVar1 = Core_Data_MedalData__get_CurrentMedal(param2,0);
		  if (iVar1 == 0) {
		    uVar2 = 0;
		  }
		  else {
		    iVar1 = Core_Extensions_Dict_ResourceSetExt__GetResourcesIds
		                      (*(undefined4 *)(*(int *)(iVar1 + 0x10) + 0x24),0);
		    uVar2 = *(int *)(iVar1 + 0xc) != 0 & param3;
		  }
		  return uVar2;
		}
		*/

		/* --- GHIDRA: UpdateViews ---
		uint Gameplay_Inventory_View_Chest_MedalCellViewHolder__UpdateViews
		               (undefined4 param1,undefined4 param2,uint param3,undefined4 param4)
		
		{
		  int iVar1;
		  uint uVar2;
		  
		  if (DAT_ram_00a5a112 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_MedalDic__uint__get_Data__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Resources__get_Count__);
		    DAT_ram_00a5a112 = '\x01';
		  }
		  iVar1 = Core_Data_MedalData__get_CurrentMedal(param2,0);
		  if (iVar1 == 0) {
		    uVar2 = 0;
		  }
		  else {
		    iVar1 = Core_Extensions_Dict_ResourceSetExt__GetResourcesIds
		                      (*(undefined4 *)(*(int *)(iVar1 + 0x10) + 0x24),0);
		    uVar2 = *(int *)(iVar1 + 0xc) != 0 & param3;
		  }
		  return uVar2;
		}
		*/

		}

		// Token: 0x060028A4 RID: 10404 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028A4")]
		[Address(RVA = "0x79C3", Offset = "0x79C3", VA = "0x79C3")]
		public void UpdateViews(MedalData model, UserData user, UserData loggedUser, HashSet<MedalData> separatorItems, HashSet<MedalData> rowCompletionItems, Action<MedalView> clickCallback, bool hasSale)
		{
		}

		// Token: 0x060028A5 RID: 10405 RVA: 0x00007AE8 File Offset: 0x00005CE8
		[Token(Token = "0x60028A5")]
		[Address(RVA = "0x79C4", Offset = "0x79C4", VA = "0x79C4")]
		private bool HasSale(MedalData model, bool hasSale)
		{
			return default(bool);
		}

		// Token: 0x060028A6 RID: 10406 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028A6")]
		[Address(RVA = "0x79C5", Offset = "0x79C5", VA = "0x79C5")]
		private void SetVisible(bool enabled)
		{
		}

		// Token: 0x060028A7 RID: 10407 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028A7")]
		[Address(RVA = "0x79C6", Offset = "0x79C6", VA = "0x79C6")]
		public MedalCellViewHolder()
		{
		}

		// Token: 0x0400166E RID: 5742
		[Token(Token = "0x400166E")]
		[FieldOffset(Offset = "0x18")]
		private MedalGroupView _medalView;
	}
}
