using System;
using System.Runtime.CompilerServices;
using Com.TheFallenGames.OSA.Core;
using Il2CppDummyDll;

namespace Gameplay.Boss.View.ListView
{
	// Token: 0x02000B69 RID: 2921
	[Token(Token = "0x2000B69")]
	public class BossListItemViewHolder : BaseItemViewsHolder
	{
		// Token: 0x17000E13 RID: 3603
		// (get) Token: 0x060046E5 RID: 18149 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060046E6 RID: 18150 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E13")]
		public BossListItemView BossListItemView
		{
			[Token(Token = "0x60046E5")]
			[Address(RVA = "0x957B", Offset = "0x957B", VA = "0x957B")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60046E6")]
			[Address(RVA = "0x957C", Offset = "0x957C", VA = "0x957C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060046E7 RID: 18151 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60046E7")]
		[Address(RVA = "0x957D", Offset = "0x957D", VA = "0x957D", Slot = "7")]
		public override void CollectViews()
		{
		}

		// Token: 0x060046E8 RID: 18152 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60046E8")]
		[Address(RVA = "0x957E", Offset = "0x957E", VA = "0x957E")]
		public BossListItemViewHolder()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Boss_View_ListView_BossListItemViewHolder___ctor
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a57a07 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_BossInstance__TypeInfo);
		    DAT_ram_00a57a07 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x50);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_BossInstance__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_BossInstance__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x50,iVar2,param1_00);
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

		/* --- GHIDRA: set_BossListItemView ---
		void Gameplay_Boss_View_ListView_BossListItemViewHolder__set_BossListItemView
		               (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a57a06 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_BossListItemView___);
		    DAT_ram_00a57a06 = '\x01';
		  }
		  uVar1 = func_ii_5677(*(undefined4 *)(param1 + 8),
		                       Method_UnityEngine_Component_GetComponent_BossListItemView___);
		  *(undefined4 *)(param1 + 0x14) = uVar1;
		  return;
		}
		*/

}
