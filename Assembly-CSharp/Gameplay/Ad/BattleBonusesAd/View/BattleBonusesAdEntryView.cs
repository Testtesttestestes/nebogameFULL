using System;
using Gameplay.Ad.BattleBonusesAd.Controller;
using Il2CppDummyDll;
using UI;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Ad.BattleBonusesAd.View
{
	// Token: 0x02000DBB RID: 3515
	[Token(Token = "0x2000DBB")]
	public class BattleBonusesAdEntryView : MonoBehaviour
	{
		// Token: 0x1700116F RID: 4463
		// (get) Token: 0x060055C5 RID: 21957 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700116F")]
		public Button Button
		{
			[Token(Token = "0x60055C5")]
			[Address(RVA = "0xA365", Offset = "0xA365", VA = "0xA365")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001170 RID: 4464
		// (get) Token: 0x060055C6 RID: 21958 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001170")]
		public BacktimeViewUGUI BacktimeViewUGUI
		{
			[Token(Token = "0x60055C6")]
			[Address(RVA = "0xA366", Offset = "0xA366", VA = "0xA366")]
			get
			{
				return null;
			}
		}

		// Token: 0x060055C7 RID: 21959 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055C7")]
		[Address(RVA = "0xA367", Offset = "0xA367", VA = "0xA367")]
		private void Awake()
		{
		}

		// Token: 0x060055C8 RID: 21960 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055C8")]
		[Address(RVA = "0xA368", Offset = "0xA368", VA = "0xA368")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void Gameplay_Ad_BattleBonusesAd_View_BattleBonusesAdEntryView__OnDestroy
		               (int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *piVar3;
		  int iVar4;
		  int param3;
		  int param2_00;
		  int *local_4;
		  
		  if (DAT_ram_00a58863 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_Ad_Placements_AbstractAdPlacementManager_BattleBonusesAdModel__BattleBonusesAdController__BattleBonusesAdEvents__get_Controller__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_Ad_Placements_AbstractAdPlacementManager_BattleBonusesAdModel__BattleBonusesAdController__BattleBonusesAdEvents__get_Events__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_Ad_Placements_AbstractAdPlacementManager_BattleBonusesAdModel__BattleBonusesAdController__BattleBonusesAdEvents__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Ad_BattleBonusesAd_Controller_BattleBonusesAdMediator_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Core_Gameplay_Managers_Ad_Placements_BattleBonuses_BattleBonusesAdPlacementManager_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a58863 = '\x01';
		  }
		  local_4 = (int *)0x0;
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
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x268);
		        goto code_r0x80f361b3;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,0x35);
		code_r0x80f361b3:
		  iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  iVar4 = Core_Gameplay_Managers_Ad_Model_AbstractAdModel__TryGetAdPlacementData
		                    (*(undefined4 *)(iVar4 + 0x14),2,&local_4,0);
		  if (iVar4 != 0) {
		    if (local_4 != (int *)0x0) {
		      if (((uint)*(byte *)(*local_4 + 0xb8) <
		           (uint)*(byte *)(
		                          Core_Gameplay_Managers_Ad_Placements_BattleBonuses_BattleBonusesAdPlacementManager_TypeInfo
		                          + 0xb8)) ||
		         (*(int *)(*(int *)(*local_4 + 100) +
		                   (uint)*(byte *)(
		                                  Core_Gameplay_Managers_Ad_Placements_BattleBonuses_BattleBonusesAdPlacementManager_TypeInfo
		                                  + 0xb8) * 4 + -4) !=
		          Core_Gameplay_Managers_Ad_Placements_BattleBonuses_BattleBonusesAdPlacementManager_TypeInfo
		         )) {
		        System_Activator__CreateInstance
		                  (local_4,
		                   Core_Gameplay_Managers_Ad_Placements_BattleBonuses_BattleBonusesAdPlacementManager_TypeInfo
		                  );
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    iVar4 = local_4[6];
		    param3 = local_4[8];
		    param2_00 = local_4[7];
		    piVar3 = (int *)unnamed_function_1417
		                              (
		                              Gameplay_Ad_BattleBonusesAd_Controller_BattleBonusesAdMediator_TypeInfo
		                              );
		    if (DAT_ram_00a5886e == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&
		                 Method_MVC_AbstractViewMediator_BattleBonusesAdModel__BattleBonusesAdEvents__BattleBonusesAdController__BattleBonusesAdEntryView___ctor__
		                );
		      DAT_ram_00a5886e = '\x01';
		    }
		    Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		              (piVar3,param2_00,param3,iVar4,
		               Method_MVC_AbstractViewMediator_BattleBonusesAdModel__BattleBonusesAdEvents__BattleBonusesAdController__BattleBonusesAdEntryView___ctor__
		              );
		    *(int **)(param1 + 0x18) = piVar3;
		    (**(code **)((ulonglong)*(uint *)(*piVar3 + 0x160) * 4))
		              (piVar3,param1,*(undefined4 *)(*piVar3 + 0x164));
		  }
		  return;
		}
		*/

		}

		// Token: 0x060055C9 RID: 21961 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055C9")]
		[Address(RVA = "0xA369", Offset = "0xA369", VA = "0xA369")]
		private void Init()
		{
		/* --- GHIDRA: Init ---
		void Gameplay_Ad_BattleBonusesAd_View_BattleBonusesAdEntryView__Init(int param1,undefined4 param2)
		
		{
		  int *piVar1;
		  
		  piVar1 = *(int **)(param1 + 0x18);
		  if (piVar1 != (int *)0x0) {
		    (**(code **)((ulonglong)*(uint *)(*piVar1 + 0x130) * 4))
		              (piVar1,*(undefined4 *)(*piVar1 + 0x134));
		  }
		  *(undefined4 *)(param1 + 0x18) = 0;
		  return;
		}
		*/

		}

		// Token: 0x060055CA RID: 21962 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055CA")]
		[Address(RVA = "0xA36A", Offset = "0xA36A", VA = "0xA36A")]
		private void Deinit()
		{
		}

		// Token: 0x060055CB RID: 21963 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055CB")]
		[Address(RVA = "0xA36B", Offset = "0xA36B", VA = "0xA36B")]
		public BattleBonusesAdEntryView()
		{
		/* --- GHIDRA: .ctor ---
		undefined4
		Gameplay_Ad_BattleBonusesAd_View_BattleBonusesAdEntryView___ctor
		          (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a58864 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_12557);
		    DAT_ram_00a58864 = '\x01';
		  }
		  return StringLiteral_12557;
		}
		*/

		}

		// Token: 0x04002E78 RID: 11896
		[Token(Token = "0x4002E78")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Button _button;

		// Token: 0x04002E79 RID: 11897
		[Token(Token = "0x4002E79")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private BacktimeViewUGUI _backtimeViewUGUI;

		// Token: 0x04002E7A RID: 11898
		[Token(Token = "0x4002E7A")]
		[FieldOffset(Offset = "0x18")]
		private BattleBonusesAdMediator _mediator;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_BacktimeViewUGUI ---
		void Gameplay_Ad_BattleBonusesAd_View_BattleBonusesAdEntryView__get_BacktimeViewUGUI
		               (undefined4 param1,undefined4 param2)
		
		{
		  Gameplay_Ad_BattleBonusesAd_View_BattleBonusesAdEntryView__OnDestroy(param1,param1);
		  return;
		}
		*/

}
