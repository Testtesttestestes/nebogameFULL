using System;
using Com.TheFallenGames.OSA.CustomAdapters.GridView;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Inventory.View.Chest
{
	// Token: 0x0200068D RID: 1677
	[Token(Token = "0x200068D")]
	public class ArtifactCellGroupViewHolder : CellGroupViewsHolder<ArtifactCellViewHolder>
	{
		// Token: 0x06002886 RID: 10374 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002886")]
		[Address(RVA = "0x79A6", Offset = "0x79A6", VA = "0x79A6", Slot = "7")]
		public override void CollectViews()
		{
		}

		// Token: 0x06002887 RID: 10375 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002887")]
		[Address(RVA = "0x79A7", Offset = "0x79A7", VA = "0x79A7")]
		public void ShowHeader(string text)
		{
		}

		// Token: 0x06002888 RID: 10376 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002888")]
		[Address(RVA = "0x79A8", Offset = "0x79A8", VA = "0x79A8")]
		public void ClearHeader()
		{
		/* --- GHIDRA: ClearHeader ---
		void Gameplay_Inventory_View_Chest_ArtifactCellGroupViewHolder__ClearHeader
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5a105 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_CustomAdapters_GridView_CellGroupViewsHolder_ArtifactCellViewHolder___ctor__
		              );
		    DAT_ram_00a5a105 = '\x01';
		  }
		  System_Linq_Expressions_Interpreter_CastInstruction_CastInstructionT___Il2CppFullySharedGenericType___Run
		            (param1,
		             Method_Com_TheFallenGames_OSA_CustomAdapters_GridView_CellGroupViewsHolder_ArtifactCellViewHolder___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06002889 RID: 10377 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002889")]
		[Address(RVA = "0x79A9", Offset = "0x79A9", VA = "0x79A9")]
		public ArtifactCellGroupViewHolder()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Inventory_View_Chest_ArtifactCellGroupViewHolder___ctor
		               (int param1,undefined8 *param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = *(int *)(param1 + 0x14);
		  *(undefined8 *)(iVar1 + 0xc0) = *param2;
		  *(undefined4 *)(iVar1 + 200) = *(undefined4 *)(param2 + 1);
		  return;
		}
		*/

		}

		// Token: 0x0400165C RID: 5724
		[Token(Token = "0x400165C")]
		[FieldOffset(Offset = "0x24")]
		private ContentSizeFitter _contentSizeFitterComponent;

		// Token: 0x0400165D RID: 5725
		[Token(Token = "0x400165D")]
		[FieldOffset(Offset = "0x28")]
		private Transform _headerGroup;

		// Token: 0x0400165E RID: 5726
		[Token(Token = "0x400165E")]
		[FieldOffset(Offset = "0x2C")]
		private TextMeshProUGUI _headerLabel;
	}
}
