using System;
using Il2CppDummyDll;
using TMPro;
using UI.Elements.Buildings;
using UnityEngine;

namespace Gameplay.Inventory.View.Info.InfoBox
{
	// Token: 0x0200067A RID: 1658
	[Token(Token = "0x200067A")]
	public class ModifierRowView : TitleRowView
	{
		// Token: 0x0600282B RID: 10283 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600282B")]
		[Address(RVA = "0x7950", Offset = "0x7950", VA = "0x7950", Slot = "5")]
		protected override void HandleDataChanged()
		{
		}

		// Token: 0x0600282C RID: 10284 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600282C")]
		[Address(RVA = "0x7951", Offset = "0x7951", VA = "0x7951")]
		public ModifierRowView()
		{
		/* --- GHIDRA: .ctor ---
		undefined4 Gameplay_Inventory_View_Info_InfoBox_ModifierRowView___ctor(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  
		  iVar2 = **(int **)(param1 + 0x28);
		  uVar1 = (**(code **)((ulonglong)*(uint *)(iVar2 + 0x2c8) * 4))
		                    (*(int **)(param1 + 0x28),*(undefined4 *)(iVar2 + 0x2cc));
		  return uVar1;
		}
		*/

		}

		// Token: 0x04001625 RID: 5669
		[Token(Token = "0x4001625")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private SpellItem _spellView;

		// Token: 0x04001626 RID: 5670
		[Token(Token = "0x4001626")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ArtikulView _artikulView;

		// Token: 0x04001627 RID: 5671
		[Token(Token = "0x4001627")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private TextMeshProUGUI _skillsTitleValueField;
	}
}
