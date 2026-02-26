using System;
using AssetContent;
using Gameplay.Bank.Controller;
using Il2CppDummyDll;
using TMPro;
using UI;
using UI.Rewards;
using UnityEngine;

namespace Gameplay.Bank.View
{
	// Token: 0x02000C44 RID: 3140
	[Token(Token = "0x2000C44")]
	public class BankPaymentBonusView : MonoBehaviour
	{
		// Token: 0x17000F6F RID: 3951
		// (get) Token: 0x06004C98 RID: 19608 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000F6F")]
		public TextMeshProUGUI BonusDescription
		{
			[Token(Token = "0x6004C98")]
			[Address(RVA = "0x9AD9", Offset = "0x9AD9", VA = "0x9AD9")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000F70 RID: 3952
		// (get) Token: 0x06004C99 RID: 19609 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000F70")]
		public RewardsRender RewardsRender
		{
			[Token(Token = "0x6004C99")]
			[Address(RVA = "0x9ADA", Offset = "0x9ADA", VA = "0x9ADA")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000F71 RID: 3953
		// (get) Token: 0x06004C9A RID: 19610 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000F71")]
		public GameRawImage BannerView
		{
			[Token(Token = "0x6004C9A")]
			[Address(RVA = "0x9ADB", Offset = "0x9ADB", VA = "0x9ADB")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000F72 RID: 3954
		// (get) Token: 0x06004C9B RID: 19611 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000F72")]
		public BacktimeViewUGUI BacktimeView
		{
			[Token(Token = "0x6004C9B")]
			[Address(RVA = "0x9ADC", Offset = "0x9ADC", VA = "0x9ADC")]
			get
			{
				return null;
			}
		}

		// Token: 0x06004C9C RID: 19612 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C9C")]
		[Address(RVA = "0x9ADD", Offset = "0x9ADD", VA = "0x9ADD")]
		private void Start()
		{
		/* --- GHIDRA: Start ---
		void Gameplay_Bank_View_BankPaymentBonusView__Start(int param1,undefined4 param2)
		
		{
		  int *piVar1;
		  
		  piVar1 = *(int **)(param1 + 0x24);
		  if (piVar1 != (int *)0x0) {
		    (**(code **)((ulonglong)*(uint *)(*piVar1 + 0x130) * 4))
		              (piVar1,*(undefined4 *)(*piVar1 + 0x134));
		  }
		  *(undefined4 *)(param1 + 0x24) = 0;
		  return;
		}
		*/

		}

		// Token: 0x06004C9D RID: 19613 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C9D")]
		[Address(RVA = "0x9ADE", Offset = "0x9ADE", VA = "0x9ADE")]
		private void OnDestroy()
		{
		}

		// Token: 0x06004C9E RID: 19614 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C9E")]
		[Address(RVA = "0x9ADF", Offset = "0x9ADF", VA = "0x9ADF")]
		public BankPaymentBonusView()
		{
		/* --- GHIDRA: .ctor ---
		undefined4 Gameplay_Bank_View_BankPaymentBonusView___ctor(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a59796 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_12570);
		    DAT_ram_00a59796 = '\x01';
		  }
		  return StringLiteral_12570;
		}
		*/

		}

		// Token: 0x040029CC RID: 10700
		[Token(Token = "0x40029CC")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private BankGalleryView _bankGalleryView;

		// Token: 0x040029CD RID: 10701
		[Token(Token = "0x40029CD")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private GameRawImage _bannerView;

		// Token: 0x040029CE RID: 10702
		[Token(Token = "0x40029CE")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private BacktimeViewUGUI _backtimeView;

		// Token: 0x040029CF RID: 10703
		[Token(Token = "0x40029CF")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private RewardsRender _rewardsRender;

		// Token: 0x040029D0 RID: 10704
		[Token(Token = "0x40029D0")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TextMeshProUGUI _bonusDescription;

		// Token: 0x040029D1 RID: 10705
		[Token(Token = "0x40029D1")]
		[FieldOffset(Offset = "0x24")]
		private BankPaymentBonusViewMediator _mediator;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_BacktimeView ---
		void Gameplay_Bank_View_BankPaymentBonusView__get_BacktimeView(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *piVar3;
		  int iVar4;
		  undefined4 uVar5;
		  undefined4 uVar6;
		  undefined4 param4;
		  
		  if (DAT_ram_00a59795 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Bank_Controller_BankPaymentBonusViewMediator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a59795 = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  piVar3 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 400);
		        goto code_r0x810682b6;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,0x1a);
		code_r0x810682b6:
		  iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  uVar5 = *(undefined4 *)(iVar4 + 0x1c);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar3 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 400);
		        goto code_r0x81068365;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,0x1a);
		code_r0x81068365:
		  iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  uVar6 = *(undefined4 *)(iVar4 + 0x18);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar3 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 400);
		        goto code_r0x81068414;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,0x1a);
		code_r0x81068414:
		  iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  param4 = *(undefined4 *)(iVar4 + 0x14);
		  piVar3 = (int *)unnamed_function_1417
		                            (Gameplay_Bank_Controller_BankPaymentBonusViewMediator_TypeInfo);
		  if (DAT_ram_00a597fc == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_PaymentBonusModel__PaymentBonusEvents__PaymentBonusController__BankPaymentBonusView___ctor__
		              );
		    DAT_ram_00a597fc = '\x01';
		  }
		  Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		            (piVar3,uVar5,uVar6,param4,
		             Method_MVC_AbstractViewMediator_PaymentBonusModel__PaymentBonusEvents__PaymentBonusController__BankPaymentBonusView___ctor__
		            );
		  *(int **)(param1 + 0x24) = piVar3;
		  (**(code **)((ulonglong)*(uint *)(*piVar3 + 0x160) * 4))
		            (piVar3,param1,*(undefined4 *)(*piVar3 + 0x164));
		  uVar6 = *(undefined4 *)(param1 + 0x10);
		  uVar5 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (param1,0);
		  func_ii_7931(uVar6,uVar5,piVar3);
		  return;
		}
		*/

}
