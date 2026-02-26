using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Protocol.Boss;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Boss.View.Rewarding
{
	// Token: 0x02000B5C RID: 2908
	[Token(Token = "0x2000B5C")]
	public class BossRewardingAssistantSlotView : AbstractBossRewardingSlotView
	{
		// Token: 0x140001B4 RID: 436
		// (add) Token: 0x06004668 RID: 18024 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06004669 RID: 18025 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001B4")]
		public event Action<BossRewardingAssistantSlotView> ClickEvent
		{
			[Token(Token = "0x6004668")]
			[Address(RVA = "0x94FF", Offset = "0x94FF", VA = "0x94FF")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6004669")]
			[Address(RVA = "0x9500", Offset = "0x9500", VA = "0x9500")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000DE6 RID: 3558
		// (get) Token: 0x0600466A RID: 18026 RVA: 0x0000D200 File Offset: 0x0000B400
		// (set) Token: 0x0600466B RID: 18027 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000DE6")]
		public bool Editable
		{
			[Token(Token = "0x600466A")]
			[Address(RVA = "0x9501", Offset = "0x9501", VA = "0x9501")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600466B")]
			[Address(RVA = "0x9502", Offset = "0x9502", VA = "0x9502")]
			set
			{
			}
		}

		// Token: 0x17000DE7 RID: 3559
		// (get) Token: 0x0600466C RID: 18028 RVA: 0x0000D218 File Offset: 0x0000B418
		// (set) Token: 0x0600466D RID: 18029 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000DE7")]
		public bool Selected
		{
			[Token(Token = "0x600466C")]
			[Address(RVA = "0x9503", Offset = "0x9503", VA = "0x9503")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600466D")]
			[Address(RVA = "0x9504", Offset = "0x9504", VA = "0x9504")]
			set
			{
			}
		}

		// Token: 0x17000DE8 RID: 3560
		// (get) Token: 0x0600466E RID: 18030 RVA: 0x0000D230 File Offset: 0x0000B430
		// (set) Token: 0x0600466F RID: 18031 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000DE8")]
		public ulong OwnerId
		{
			[Token(Token = "0x600466E")]
			[Address(RVA = "0x9505", Offset = "0x9505", VA = "0x9505")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x600466F")]
			[Address(RVA = "0x9506", Offset = "0x9506", VA = "0x9506")]
			set
			{
			}
		}

		// Token: 0x17000DE9 RID: 3561
		// (set) Token: 0x06004670 RID: 18032 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000DE9")]
		public override bool Interactable
		{
			[Token(Token = "0x6004670")]
			[Address(RVA = "0x9507", Offset = "0x9507", VA = "0x9507", Slot = "8")]
			set
			{
			}
		}

		// Token: 0x17000DEA RID: 3562
		// (set) Token: 0x06004671 RID: 18033 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000DEA")]
		public override GetTeamRewardsAns.Types.BossRewardInfo BossRewardInfo
		{
			[Token(Token = "0x6004671")]
			[Address(RVA = "0x9508", Offset = "0x9508", VA = "0x9508", Slot = "5")]
			set
			{
			}
		}

		// Token: 0x06004672 RID: 18034 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004672")]
		[Address(RVA = "0x9509", Offset = "0x9509", VA = "0x9509")]
		private void ValidateInteractable()
		{
		}

		// Token: 0x06004673 RID: 18035 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004673")]
		[Address(RVA = "0x950A", Offset = "0x950A", VA = "0x950A", Slot = "6")]
		protected override void HandleClick()
		{
		}

		// Token: 0x06004674 RID: 18036 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004674")]
		[Address(RVA = "0x950B", Offset = "0x950B", VA = "0x950B")]
		public BossRewardingAssistantSlotView()
		{
		}

		// Token: 0x04002686 RID: 9862
		[Token(Token = "0x4002686")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private Image _plusIcon;

		// Token: 0x04002688 RID: 9864
		[Token(Token = "0x4002688")]
		[FieldOffset(Offset = "0x2C")]
		private bool _editable;

		// Token: 0x04002689 RID: 9865
		[Token(Token = "0x4002689")]
		[FieldOffset(Offset = "0x2D")]
		private bool _selected;

		// Token: 0x0400268A RID: 9866
		[Token(Token = "0x400268A")]
		[FieldOffset(Offset = "0x30")]
		private ulong _ownerId;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_ClickEvent ---
		void Gameplay_Boss_View_Rewarding_BossRewardingAssistantSlotView__add_ClickEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a579d2 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_BossRewardingAssistantSlotView__TypeInfo);
		    DAT_ram_00a579d2 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x28);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_BossRewardingAssistantSlotView__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_BossRewardingAssistantSlotView__TypeInfo),
		       iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x28,iVar2,param1_00);
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


		/* --- GHIDRA: get_Editable ---
		void Gameplay_Boss_View_Rewarding_BossRewardingAssistantSlotView__get_Editable
		               (int *param1,int param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int iVar2;
		  
		  *(char *)(param1 + 0xb) = (char)param2;
		  bVar1 = false;
		  if ((param2 != 0) &&
		     (iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0xe4)), bVar1 = false, iVar2 == 0)) {
		    bVar1 = *(longlong *)(param1 + 0xc) != 0;
		  }
		  (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		            (param1,bVar1,*(undefined4 *)(*param1 + 0x104));
		  return;
		}
		*/


		/* --- GHIDRA: get_Selected ---
		void Gameplay_Boss_View_Rewarding_BossRewardingAssistantSlotView__get_Selected
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  
		  *(undefined1 *)(param1 + 0x2d) = (undefined1)param2;
		  param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(param1 + 0x18),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (param1_00,(uint)*(byte *)(param1 + 0x2d),0);
		  return;
		}
		*/


		/* --- GHIDRA: get_OwnerId ---
		void Gameplay_Boss_View_Rewarding_BossRewardingAssistantSlotView__get_OwnerId
		               (int *param1,undefined8 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int iVar2;
		  
		  bVar1 = false;
		  *(undefined8 *)(param1 + 0xc) = param2;
		  if (((char)param1[0xb] != '\0') &&
		     (iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0xe4)), iVar2 == 0)) {
		    bVar1 = *(longlong *)(param1 + 0xc) != 0;
		  }
		  (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		            (param1,bVar1,*(undefined4 *)(*param1 + 0x104));
		  return;
		}
		*/


		/* --- GHIDRA: set_OwnerId ---
		void Gameplay_Boss_View_Rewarding_BossRewardingAssistantSlotView__set_OwnerId
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 param2_00;
		  
		  *(undefined1 *)(param1 + 8) = (undefined1)param2;
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (param1[5],0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,(uint)*(byte *)(param1 + 8),0);
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (param1[9],0);
		  if (*(longlong *)(param1 + 0xc) == 0) {
		    param2_00 = 0;
		  }
		  else {
		    param2_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xf8) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0xfc));
		  }
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,param2_00,0);
		  return;
		}
		*/


		/* --- GHIDRA: set_Interactable ---
		void Gameplay_Boss_View_Rewarding_BossRewardingAssistantSlotView__set_Interactable
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int iVar2;
		  
		  Gameplay_Boss_View_Rewarding_AbstractBossRewardingSlotView__get_BossRewardInfo
		            (param1,param2,param1);
		  bVar1 = false;
		  if (((char)param1[0xb] != '\0') &&
		     (iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0xe4)), bVar1 = false, iVar2 == 0)) {
		    bVar1 = *(longlong *)(param1 + 0xc) != 0;
		  }
		  (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		            (param1,bVar1,*(undefined4 *)(*param1 + 0x104));
		  return;
		}
		*/


		/* --- GHIDRA: set_BossRewardInfo ---
		void Gameplay_Boss_View_Rewarding_BossRewardingAssistantSlotView__set_BossRewardInfo
		               (int *param1,undefined4 param2)
		
		{
		  bool bVar1;
		  int iVar2;
		  
		  bVar1 = false;
		  if (((char)param1[0xb] != '\0') &&
		     (iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0xe4)), iVar2 == 0)) {
		    bVar1 = *(longlong *)(param1 + 0xc) != 0;
		  }
		  (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		            (param1,bVar1,*(undefined4 *)(*param1 + 0x104));
		  return;
		}
		*/

}
