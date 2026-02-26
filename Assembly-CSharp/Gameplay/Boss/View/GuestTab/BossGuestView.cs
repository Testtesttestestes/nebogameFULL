using System;
using Gameplay.Boss.Controller;
using Gameplay.Boss.View.CaptainTab;
using Il2CppDummyDll;
using UI.Requirements;
using UI.Wiki;
using UnityEngine;

namespace Gameplay.Boss.View.GuestTab
{
	// Token: 0x02000B72 RID: 2930
	[Token(Token = "0x2000B72")]
	public class BossGuestView : AbstractBossWindowView<BossGuestView, BossGuestViewMediator>
	{
		// Token: 0x17000E32 RID: 3634
		// (get) Token: 0x0600472F RID: 18223 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000E32")]
		public WikiUriRouter Wiki
		{
			[Token(Token = "0x600472F")]
			[Address(RVA = "0x95C5", Offset = "0x95C5", VA = "0x95C5")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000E33 RID: 3635
		// (get) Token: 0x06004730 RID: 18224 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000E33")]
		public BossInfoView BossInfoView
		{
			[Token(Token = "0x6004730")]
			[Address(RVA = "0x95C6", Offset = "0x95C6", VA = "0x95C6")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000E34 RID: 3636
		// (get) Token: 0x06004731 RID: 18225 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000E34")]
		public RequirementsView RequirementsView
		{
			[Token(Token = "0x6004731")]
			[Address(RVA = "0x95C7", Offset = "0x95C7", VA = "0x95C7")]
			get
			{
				return null;
			}
		}

		// Token: 0x06004732 RID: 18226 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004732")]
		[Address(RVA = "0x95C8", Offset = "0x95C8", VA = "0x95C8", Slot = "5")]
		protected override BossGuestViewMediator CreateMediator()
		{
		/* --- GHIDRA: CreateMediator ---
		void Gameplay_Boss_View_GuestTab_BossGuestView__CreateMediator(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a57a26 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Boss_View_AbstractBossWindowView_BossGuestView__BossGuestViewMediator___ctor__
		              );
		    DAT_ram_00a57a26 = '\x01';
		  }
		  ScreenAdaptation_Common_AppSize__Update
		            (param1,
		             Method_Gameplay_Boss_View_AbstractBossWindowView_BossGuestView__BossGuestViewMediator___ctor__
		            );
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06004733 RID: 18227 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004733")]
		[Address(RVA = "0x95C9", Offset = "0x95C9", VA = "0x95C9")]
		public BossGuestView()
		{
		/* --- GHIDRA: .ctor ---
		undefined4 Gameplay_Boss_View_GuestTab_BossGuestView___ctor(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a57a27 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_12577);
		    DAT_ram_00a57a27 = '\x01';
		  }
		  return StringLiteral_12577;
		}
		*/

		}

		// Token: 0x0400270A RID: 9994
		[Token(Token = "0x400270A")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private BossInfoView _bossInfoView;

		// Token: 0x0400270B RID: 9995
		[Token(Token = "0x400270B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RequirementsView _requirementsView;

		// Token: 0x0400270C RID: 9996
		[Token(Token = "0x400270C")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private WikiUriRouter _wiki;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_RequirementsView ---
		undefined4
		Gameplay_Boss_View_GuestTab_BossGuestView__get_RequirementsView(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param4;
		  undefined4 param3;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a57a25 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Boss_Controller_BossGuestViewMediator_TypeInfo);
		    DAT_ram_00a57a25 = '\x01';
		  }
		  param4 = *(undefined4 *)(param1 + 0x1c);
		  param3 = *(undefined4 *)(param1 + 0x18);
		  param2_00 = *(undefined4 *)(param1 + 0x14);
		  param1_00 = unnamed_function_1417(Gameplay_Boss_Controller_BossGuestViewMediator_TypeInfo);
		  Gameplay_Boss_Controller_BossController__BossServiceOnMinionAttackServerCancelationEvent
		            (param1_00,param2_00,param3,param4,0);
		  return param1_00;
		}
		*/

}
