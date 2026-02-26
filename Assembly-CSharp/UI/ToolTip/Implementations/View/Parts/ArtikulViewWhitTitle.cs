using System;
using Core.Data;
using Gameplay.Inventory.View;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace UI.ToolTip.Implementations.View.Parts
{
	// Token: 0x0200014F RID: 335
	[Token(Token = "0x200014F")]
	public class ArtikulViewWhitTitle : ArtikulView
	{
		// Token: 0x17000147 RID: 327
		// (get) Token: 0x060009BF RID: 2495 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060009C0 RID: 2496 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000147")]
		public override ArtikulData Data
		{
			[Token(Token = "0x60009BF")]
			[Address(RVA = "0x5D27", Offset = "0x5D27", VA = "0x5D27", Slot = "14")]
			get
			{
				return null;
			}
			[Token(Token = "0x60009C0")]
			[Address(RVA = "0x5D28", Offset = "0x5D28", VA = "0x5D28", Slot = "15")]
			set
			{
			}
		}

		// Token: 0x060009C1 RID: 2497 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009C1")]
		[Address(RVA = "0x5D29", Offset = "0x5D29", VA = "0x5D29", Slot = "19")]
		protected override void HandleDataChanged()
		{
		}

		// Token: 0x060009C2 RID: 2498 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009C2")]
		[Address(RVA = "0x5D2A", Offset = "0x5D2A", VA = "0x5D2A")]
		public ArtikulViewWhitTitle()
		{
		/* --- GHIDRA: .ctor ---
		void UI_ToolTip_Implementations_View_Parts_ArtikulViewWhitTitle___ctor
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  int *piVar3;
		  
		  if (DAT_ram_00a59976 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_MedalDic__uint__get_Data__);
		    DAT_ram_00a59976 = '\x01';
		  }
		  piVar3 = (int *)param1[0x15];
		  piVar3[0x10] = 2;
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x134));
		  (**(code **)((ulonglong)*(uint *)(*piVar3 + 0x138) * 4))
		            (piVar3,uVar1,*(undefined4 *)(*piVar3 + 0x13c));
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x134));
		  if (iVar2 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x134));
		    uVar1 = func_ii_14054(*(undefined4 *)(iVar2 + 0x10),0);
		    iVar2 = *(int *)param1[0x16];
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0x2d0) * 4))
		              ((int *)param1[0x16],uVar1,*(undefined4 *)(iVar2 + 0x2d4));
		  }
		  return;
		}
		*/

		}

		// Token: 0x040003E3 RID: 995
		[Token(Token = "0x40003E3")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private ArtikulView _artikulView;

		// Token: 0x040003E4 RID: 996
		[Token(Token = "0x40003E4")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private TextMeshProUGUI _title;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Data ---
		void UI_ToolTip_Implementations_View_Parts_ArtikulViewWhitTitle__get_Data
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = *(int *)param1[0x12];
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x138) * 4))
		            ((int *)param1[0x12],param2,*(undefined4 *)(iVar1 + 0x13c));
		  (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))(param1,*(undefined4 *)(*param1 + 0x15c));
		  return;
		}
		*/


		/* --- GHIDRA: set_Data ---
		void UI_ToolTip_Implementations_View_Parts_ArtikulViewWhitTitle__set_Data
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int *piVar3;
		  
		  if (DAT_ram_00a59975 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_ArtikulDic__uint__get_Data__)
		    ;
		    DAT_ram_00a59975 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x134));
		  if (iVar1 != 0) {
		    piVar3 = (int *)param1[0x13];
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x134));
		    uVar2 = Core_Extensions_Dict_DictExt__GetArtikul(*(undefined4 *)(*(int *)(iVar1 + 8) + 0x10),0);
		    iVar1 = *piVar3;
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0x2d0) * 4))
		              (piVar3,uVar2,*(undefined4 *)(iVar1 + 0x2d4));
		    iVar1 = param1[10];
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x134));
		    uVar2 = Core_Data_ArtikulData__get_CurrentDurability(uVar2,0);
		    Core_Extensions_Dict_PortalDicExt__GetCurrencyIcon60x66(iVar1,uVar2,0);
		  }
		  return;
		}
		*/

}
