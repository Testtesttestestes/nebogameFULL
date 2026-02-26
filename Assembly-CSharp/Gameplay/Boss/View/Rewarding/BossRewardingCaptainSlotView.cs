using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Gameplay.Boss.View.Rewarding
{
	// Token: 0x02000B5E RID: 2910
	[Token(Token = "0x2000B5E")]
	public class BossRewardingCaptainSlotView : AbstractBossRewardingSlotView
	{
		// Token: 0x140001B6 RID: 438
		// (add) Token: 0x06004687 RID: 18055 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06004688 RID: 18056 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001B6")]
		public event Action<BossRewardingCaptainSlotView> ClickEvent
		{
			[Token(Token = "0x6004687")]
			[Address(RVA = "0x951D", Offset = "0x951D", VA = "0x951D")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6004688")]
			[Address(RVA = "0x951E", Offset = "0x951E", VA = "0x951E")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000DF2 RID: 3570
		// (set) Token: 0x06004689 RID: 18057 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000DF2")]
		public override bool Interactable
		{
			[Token(Token = "0x6004689")]
			[Address(RVA = "0x951F", Offset = "0x951F", VA = "0x951F", Slot = "8")]
			set
			{
			}
		}

		// Token: 0x0600468A RID: 18058 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600468A")]
		[Address(RVA = "0x9520", Offset = "0x9520", VA = "0x9520", Slot = "6")]
		protected override void HandleClick()
		{
		}

		// Token: 0x0600468B RID: 18059 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600468B")]
		[Address(RVA = "0x9521", Offset = "0x9521", VA = "0x9521")]
		public BossRewardingCaptainSlotView()
		{
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_ClickEvent ---
		void Gameplay_Boss_View_Rewarding_BossRewardingCaptainSlotView__add_ClickEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a579dc == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_BossRewardingCaptainSlotView__TypeInfo);
		    DAT_ram_00a579dc = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x24);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_BossRewardingCaptainSlotView__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_BossRewardingCaptainSlotView__TypeInfo),
		       iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x24,iVar2,param1_00);
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


		/* --- GHIDRA: remove_ClickEvent ---
		void Gameplay_Boss_View_Rewarding_BossRewardingCaptainSlotView__remove_ClickEvent
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  uint param2_00;
		  
		  *(undefined1 *)(param1 + 8) = (undefined1)param2;
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (param1[5],0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,(uint)*(byte *)(param1 + 8),0);
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (param1[6],0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf8) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xfc));
		  if (iVar2 == 0) {
		    param2_00 = 0;
		  }
		  else {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0xe4));
		    param2_00 = (uint)(iVar2 != 0);
		  }
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,param2_00,0);
		  return;
		}
		*/

}
