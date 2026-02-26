using System;
using System.Runtime.CompilerServices;
using Com.TheFallenGames.OSA.CustomAdapters.GridView;
using Gameplay.Antiq.Model;
using Il2CppDummyDll;

namespace Gameplay.Antiq.View.Grid
{
	// Token: 0x02000D88 RID: 3464
	[Token(Token = "0x2000D88")]
	internal class CellHolder : CellViewsHolder
	{
		// Token: 0x17001146 RID: 4422
		// (get) Token: 0x060054C4 RID: 21700 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060054C5 RID: 21701 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001146")]
		public GroupView View
		{
			[Token(Token = "0x60054C4")]
			[Address(RVA = "0xA270", Offset = "0xA270", VA = "0xA270")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60054C5")]
			[Address(RVA = "0xA271", Offset = "0xA271", VA = "0xA271")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060054C6 RID: 21702 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60054C6")]
		[Address(RVA = "0xA272", Offset = "0xA272", VA = "0xA272", Slot = "7")]
		public override void CollectViews()
		{
		}

		// Token: 0x060054C7 RID: 21703 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60054C7")]
		[Address(RVA = "0xA273", Offset = "0xA273", VA = "0xA273")]
		public void SetData(GroupData data)
		{
		}

		// Token: 0x060054C8 RID: 21704 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60054C8")]
		[Address(RVA = "0xA274", Offset = "0xA274", VA = "0xA274")]
		public CellHolder()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Antiq_View_Grid_CellHolder___ctor(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5948f == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_GroupData__TypeInfo);
		    DAT_ram_00a5948f = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0xb4);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_GroupData__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_GroupData__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0xb4,iVar2,param1_00);
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

		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_View ---
		void Gameplay_Antiq_View_Grid_CellHolder__set_View(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5948e == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_GroupView___);
		    DAT_ram_00a5948e = '\x01';
		  }
		  Com_TheFallenGames_OSA_CustomAdapters_GridView_CellViewsHolder__InitWithExistingRootPrefab
		            (param1,0);
		  uVar1 = func_ii_5677(*(undefined4 *)(param1 + 8),
		                       Method_UnityEngine_Component_GetComponent_GroupView___);
		  *(undefined4 *)(param1 + 0x18) = uVar1;
		  return;
		}
		*/

}
