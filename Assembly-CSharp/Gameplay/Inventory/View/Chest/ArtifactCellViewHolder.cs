using System;
using System.Collections.Generic;
using Com.TheFallenGames.OSA.CustomAdapters.GridView;
using Core.Data;
using Il2CppDummyDll;

namespace Gameplay.Inventory.View.Chest
{
	// Token: 0x02000682 RID: 1666
	[Token(Token = "0x2000682")]
	public class ArtifactCellViewHolder : CellViewsHolder
	{
		// Token: 0x06002854 RID: 10324 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002854")]
		[Address(RVA = "0x7974", Offset = "0x7974", VA = "0x7974", Slot = "7")]
		public override void CollectViews()
		{
		/* --- GHIDRA: CollectViews ---
		void Gameplay_Inventory_View_Chest_ArtifactCellViewHolder__CollectViews
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5,
		               undefined8 *param6,undefined4 param7)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined8 local_10;
		  undefined4 local_8;
		  
		  if (DAT_ram_00a5a0e8 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_HashSet_ArtifactData__Contains__);
		    DAT_ram_00a5a0e8 = '\x01';
		  }
		  iVar1 = func_ii_10159(param4,param2,
		                        Method_System_Collections_Generic_HashSet_ArtifactData__Contains__);
		  if ((iVar1 == 0) &&
		     (iVar1 = func_ii_10159(param5,param2,
		                            Method_System_Collections_Generic_HashSet_ArtifactData__Contains__),
		     iVar1 == 0)) {
		    uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(param1 + 0x18),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar2,1,0);
		    iVar1 = **(int **)(param1 + 0x14);
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0x1a0) * 4))
		              (*(int **)(param1 + 0x14),0,*(undefined4 *)(iVar1 + 0x1a4));
		    iVar1 = **(int **)(param1 + 0x18);
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0x138) * 4))
		              (*(int **)(param1 + 0x18),param2,*(undefined4 *)(iVar1 + 0x13c));
		    local_8 = *(undefined4 *)(param6 + 1);
		    local_10 = *param6;
		    func_ii_7564(*(undefined4 *)(param1 + 0x18),&local_10,0);
		  }
		  else {
		    uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(param1 + 0x18),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar2,0,0);
		    iVar1 = **(int **)(param1 + 0x14);
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0x1a0) * 4))
		              (*(int **)(param1 + 0x14),1,*(undefined4 *)(iVar1 + 0x1a4));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002855 RID: 10325 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002855")]
		[Address(RVA = "0x7975", Offset = "0x7975", VA = "0x7975")]
		public void UpdateViews(ArtifactData model, InventoryGridWithCategoriesParams parameters, HashSet<ArtifactData> separatorItems, HashSet<ArtifactData> rowCompletionItems, ArtifactView.ArtifactViewArgs artifactViewArgs)
		{
		}

		// Token: 0x06002856 RID: 10326 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002856")]
		[Address(RVA = "0x7976", Offset = "0x7976", VA = "0x7976")]
		private void SetVisible(bool enabled)
		{
		}

		// Token: 0x06002857 RID: 10327 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002857")]
		[Address(RVA = "0x7977", Offset = "0x7977", VA = "0x7977")]
		public ArtifactCellViewHolder()
		{
		}

		// Token: 0x0400163F RID: 5695
		[Token(Token = "0x400163F")]
		[FieldOffset(Offset = "0x18")]
		private ArtifactView _itemView;
	}
}
