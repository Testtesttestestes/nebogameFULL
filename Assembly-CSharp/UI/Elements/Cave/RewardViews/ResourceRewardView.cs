using System;
using AssetContent;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace UI.Elements.Cave.RewardViews
{
	// Token: 0x0200023E RID: 574
	[Token(Token = "0x200023E")]
	public class ResourceRewardView : BaseRewardView
	{
		// Token: 0x170001E1 RID: 481
		// (set) Token: 0x06000E2A RID: 3626 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001E1")]
		public string ResourceImageURL
		{
			[Token(Token = "0x6000E2A")]
			[Address(RVA = "0x60BC", Offset = "0x60BC", VA = "0x60BC")]
			set
			{
			}
		}

		// Token: 0x170001E2 RID: 482
		// (set) Token: 0x06000E2B RID: 3627 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001E2")]
		public int Amount
		{
			[Token(Token = "0x6000E2B")]
			[Address(RVA = "0x60BD", Offset = "0x60BD", VA = "0x60BD")]
			set
			{
			}
		}

		// Token: 0x06000E2C RID: 3628 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E2C")]
		[Address(RVA = "0x60BE", Offset = "0x60BE", VA = "0x60BE")]
		public ResourceRewardView()
		{
		}

		// Token: 0x04000702 RID: 1794
		[Token(Token = "0x4000702")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private GameRawImage _resourceImage;

		// Token: 0x04000703 RID: 1795
		[Token(Token = "0x4000703")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private TextMeshProUGUI _amountText;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_ResourceImageURL ---
		void UI_Elements_Cave_RewardViews_ResourceRewardView__set_ResourceImageURL
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int *piVar2;
		  int iVar3;
		  int local_4;
		  
		  local_4 = param2;
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(param1 + 0x14),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,(uint)(0 < param2),0);
		  piVar2 = *(int **)(param1 + 0x14);
		  uVar1 = func_ii_4443(&local_4,0);
		  iVar3 = *piVar2;
		  (**(code **)((ulonglong)*(uint *)(iVar3 + 0x2d0) * 4))
		            (piVar2,uVar1,*(undefined4 *)(iVar3 + 0x2d4));
		  return;
		}
		*/

}
