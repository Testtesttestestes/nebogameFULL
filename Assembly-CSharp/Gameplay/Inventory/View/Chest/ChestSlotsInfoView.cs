using System;
using Il2CppDummyDll;
using TMPro;
using UI.Elements.Buttons;
using UnityEngine;

namespace Gameplay.Inventory.View.Chest
{
	// Token: 0x02000683 RID: 1667
	[Token(Token = "0x2000683")]
	public class ChestSlotsInfoView : MonoBehaviour
	{
		// Token: 0x170007A5 RID: 1957
		// (get) Token: 0x06002858 RID: 10328 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170007A5")]
		public ButtonWithCost BuyButton
		{
			[Token(Token = "0x6002858")]
			[Address(RVA = "0x7978", Offset = "0x7978", VA = "0x7978")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002859 RID: 10329 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002859")]
		[Address(RVA = "0x7979", Offset = "0x7979", VA = "0x7979")]
		public void SetSlotsCount(long empty, long total)
		{
		}

		// Token: 0x0600285A RID: 10330 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600285A")]
		[Address(RVA = "0x797A", Offset = "0x797A", VA = "0x797A")]
		public ChestSlotsInfoView()
		{
		}

		// Token: 0x04001640 RID: 5696
		[Token(Token = "0x4001640")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TextMeshProUGUI _label;

		// Token: 0x04001641 RID: 5697
		[Token(Token = "0x4001641")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private ButtonWithCost _buyButton;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_BuyButton ---
		void Gameplay_Inventory_View_Chest_ChestSlotsInfoView__get_BuyButton
		               (int param1,undefined8 param2,undefined8 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  undefined4 param3_00;
		  int *piVar2;
		  int iVar3;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  local_10 = param3;
		  local_8 = param2;
		  if (DAT_ram_00a5a0e9 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_1618);
		    DAT_ram_00a5a0e9 = '\x01';
		  }
		  piVar2 = *(int **)(param1 + 0x10);
		  uVar1 = UnityEngine_GameObject__SetActive(&local_8,0);
		  param3_00 = UnityEngine_GameObject__SetActive(&local_10,0);
		  uVar1 = UnityEngine_AndroidJavaObject__FromJavaArray_Nullable_int__
		                    (uVar1,StringLiteral_1618,param3_00,0);
		  iVar3 = *piVar2;
		  (**(code **)((ulonglong)*(uint *)(iVar3 + 0x2d0) * 4))
		            (piVar2,uVar1,*(undefined4 *)(iVar3 + 0x2d4));
		  return;
		}
		*/

}
