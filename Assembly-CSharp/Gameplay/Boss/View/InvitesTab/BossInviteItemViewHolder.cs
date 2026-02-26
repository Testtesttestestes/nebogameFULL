using System;
using System.Runtime.CompilerServices;
using Com.TheFallenGames.OSA.Core;
using Il2CppDummyDll;

namespace Gameplay.Boss.View.InvitesTab
{
	// Token: 0x02000B6F RID: 2927
	[Token(Token = "0x2000B6F")]
	public class BossInviteItemViewHolder : BaseItemViewsHolder
	{
		// Token: 0x17000E27 RID: 3623
		// (get) Token: 0x0600471D RID: 18205 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600471E RID: 18206 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E27")]
		public BossInviteItemView BossInviteItemView
		{
			[Token(Token = "0x600471D")]
			[Address(RVA = "0x95B3", Offset = "0x95B3", VA = "0x95B3")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600471E")]
			[Address(RVA = "0x95B4", Offset = "0x95B4", VA = "0x95B4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600471F RID: 18207 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600471F")]
		[Address(RVA = "0x95B5", Offset = "0x95B5", VA = "0x95B5", Slot = "7")]
		public override void CollectViews()
		{
		}

		// Token: 0x06004720 RID: 18208 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004720")]
		[Address(RVA = "0x95B6", Offset = "0x95B6", VA = "0x95B6")]
		public BossInviteItemViewHolder()
		{
		/* --- GHIDRA: .ctor ---
		int Gameplay_Boss_View_InvitesTab_BossInviteItemViewHolder___ctor
		              (undefined4 param1,undefined4 param2)
		
		{
		  int iVar1;
		  int param1_00;
		  undefined4 uVar2;
		  uint uVar3;
		  
		  if (DAT_ram_00a57a21 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Sorting_BossInviteDataComparers_ByCult_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Sorting_BossInviteDataComparers_ByLevel_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Sorting_BossInviteDataComparers_ByNick_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_IGameDataComparer_BossInviteData___Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_IGameDataComparer_BossInviteData____ctor__);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_List_IGameDataComparer_BossInviteData___TypeInfo);
		    DAT_ram_00a57a21 = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (System_Collections_Generic_List_IGameDataComparer_BossInviteData___TypeInfo
		                        );
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_00,
		             Method_System_Collections_Generic_List_IGameDataComparer_BossInviteData____ctor__);
		  uVar2 = unnamed_function_1417(Core_Sorting_BossInviteDataComparers_ByLevel_TypeInfo);
		  Core_Sorting_BossInviteDataComparers_ByLevel__get_Title(uVar2,0);
		  iVar1 = Method_System_Collections_Generic_List_IGameDataComparer_BossInviteData___Add__;
		  *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		  uVar3 = *(uint *)(param1_00 + 0xc);
		  if (uVar3 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		    *(uint *)(param1_00 + 0xc) = uVar3 + 1;
		    *(undefined4 *)(*(int *)(param1_00 + 8) + uVar3 * 4 + 0x10) = uVar2;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (param1_00,uVar2,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  }
		  uVar2 = unnamed_function_1417(Core_Sorting_BossInviteDataComparers_ByCult_TypeInfo);
		  Core_Sorting_BossInviteDataComparers_ByCult__get_Title(uVar2,0);
		  iVar1 = Method_System_Collections_Generic_List_IGameDataComparer_BossInviteData___Add__;
		  *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		  uVar3 = *(uint *)(param1_00 + 0xc);
		  if (uVar3 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		    *(uint *)(param1_00 + 0xc) = uVar3 + 1;
		    *(undefined4 *)(*(int *)(param1_00 + 8) + uVar3 * 4 + 0x10) = uVar2;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (param1_00,uVar2,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  }
		  uVar2 = unnamed_function_1417(Core_Sorting_BossInviteDataComparers_ByNick_TypeInfo);
		  Core_Sorting_BossInviteDataComparers_ByNick__get_Title(uVar2,0);
		  iVar1 = Method_System_Collections_Generic_List_IGameDataComparer_BossInviteData___Add__;
		  *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		  uVar3 = *(uint *)(param1_00 + 0xc);
		  if (uVar3 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		    *(uint *)(param1_00 + 0xc) = uVar3 + 1;
		    *(undefined4 *)(*(int *)(param1_00 + 8) + uVar3 * 4 + 0x10) = uVar2;
		    return param1_00;
		  }
		  System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		            (param1_00,uVar2,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		  return param1_00;
		}
		*/

		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_BossInviteItemView ---
		void Gameplay_Boss_View_InvitesTab_BossInviteItemViewHolder__set_BossInviteItemView
		               (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a57a20 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Component_GetComponent_BossInviteItemView___);
		    DAT_ram_00a57a20 = '\x01';
		  }
		  uVar1 = func_ii_5677(*(undefined4 *)(param1 + 8),
		                       Method_UnityEngine_Component_GetComponent_BossInviteItemView___);
		  *(undefined4 *)(param1 + 0x14) = uVar1;
		  return;
		}
		*/

}
