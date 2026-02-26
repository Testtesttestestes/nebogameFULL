using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Inventory.View.Bag
{
	// Token: 0x02000699 RID: 1689
	[Token(Token = "0x2000699")]
	public class InventoryBagSlotView : MonoBehaviour, IInventoryBagSlotView
	{
		// Token: 0x170007B9 RID: 1977
		// (get) Token: 0x060028CB RID: 10443 RVA: 0x00007B00 File Offset: 0x00005D00
		// (set) Token: 0x060028CC RID: 10444 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007B9")]
		public int SlotId
		{
			[Token(Token = "0x60028CB")]
			[Address(RVA = "0x79E5", Offset = "0x79E5", VA = "0x79E5", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60028CC")]
			[Address(RVA = "0x79E6", Offset = "0x79E6", VA = "0x79E6", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170007BA RID: 1978
		// (get) Token: 0x060028CD RID: 10445 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170007BA")]
		public ArtifactView ArtifactView
		{
			[Token(Token = "0x60028CD")]
			[Address(RVA = "0x79E7", Offset = "0x79E7", VA = "0x79E7")]
			get
			{
				return null;
			}
		}

		// Token: 0x170007BB RID: 1979
		// (get) Token: 0x060028CE RID: 10446 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060028CF RID: 10447 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007BB")]
		public ArtifactData ArtifactData
		{
			[Token(Token = "0x60028CE")]
			[Address(RVA = "0x79E8", Offset = "0x79E8", VA = "0x79E8", Slot = "6")]
			get
			{
				return null;
			}
			[Token(Token = "0x60028CF")]
			[Address(RVA = "0x79E9", Offset = "0x79E9", VA = "0x79E9", Slot = "7")]
			set
			{
			}
		}

		// Token: 0x060028D0 RID: 10448 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028D0")]
		[Address(RVA = "0x79EA", Offset = "0x79EA", VA = "0x79EA")]
		public InventoryBagSlotView()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Inventory_View_Bag_InventoryBagSlotView___ctor
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a5a124 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a5a124 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x10);
		  while ((param1_01 = (int *)UnityEngine_UI_Image__set_sprite(param1_00,param2,0),
		         param1_01 == (int *)0x0 || (System_Action_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 0x10,param1_01,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,System_Action_TypeInfo);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x04001685 RID: 5765
		[Token(Token = "0x4001685")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Image _bg;

		// Token: 0x04001686 RID: 5766
		[Token(Token = "0x4001686")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private ArtifactView _artifactView;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_ArtifactData ---
		void Gameplay_Inventory_View_Bag_InventoryBagSlotView__get_ArtifactData
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  
		  iVar1 = **(int **)(param1 + 0x14);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x138) * 4))
		            (*(int **)(param1 + 0x14),param2,*(undefined4 *)(iVar1 + 0x13c));
		  param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(param1 + 0x14),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (param1_00,(uint)(param2 != 0),0);
		  return;
		}
		*/

}
