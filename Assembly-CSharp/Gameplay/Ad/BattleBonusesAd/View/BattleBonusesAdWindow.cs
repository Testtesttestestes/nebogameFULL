using System;
using Core.Data;
using Core.Gameplay.Managers.Ad.Placements.BattleBonuses.Controller;
using Core.Gameplay.Managers.Ad.Placements.BattleBonuses.Events;
using Core.Gameplay.Managers.Ad.Placements.BattleBonuses.Model;
using Gameplay.Ad.BattleBonusesAd.Controller;
using Il2CppDummyDll;
using UI.Windows;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Ad.BattleBonusesAd.View
{
	// Token: 0x02000DBC RID: 3516
	[Token(Token = "0x2000DBC")]
	public class BattleBonusesAdWindow : BaseDialogWindow<BattleBonusesAdWindow.BattleBonusesAdWindowArgs>
	{
		// Token: 0x17001171 RID: 4465
		// (get) Token: 0x060055CC RID: 21964 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001171")]
		public override string WindowId
		{
			[Token(Token = "0x60055CC")]
			[Address(RVA = "0xA36C", Offset = "0xA36C", VA = "0xA36C", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001172 RID: 4466
		// (get) Token: 0x060055CD RID: 21965 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001172")]
		public Button WatchButton
		{
			[Token(Token = "0x60055CD")]
			[Address(RVA = "0xA36D", Offset = "0xA36D", VA = "0xA36D")]
			get
			{
				return null;
			}
		}

		// Token: 0x060055CE RID: 21966 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055CE")]
		[Address(RVA = "0xA36E", Offset = "0xA36E", VA = "0xA36E", Slot = "22")]
		protected override void OnShow(BattleBonusesAdWindow.BattleBonusesAdWindowArgs args)
		{
		/* --- GHIDRA: OnShow ---
		void Gameplay_Ad_BattleBonusesAd_View_BattleBonusesAdWindow__OnShow(int param1,undefined4 param2)
		
		{
		  int *piVar1;
		  
		  if (DAT_ram_00a58866 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BattleBonusesAdWindow_BattleBonusesAdWindowArgs__OnClose__
		              );
		    DAT_ram_00a58866 = '\x01';
		  }
		  UI_Windows_BaseDialogWindow_object___HandleTitle
		            (param1,
		             Method_UI_Windows_BaseDialogWindow_BattleBonusesAdWindow_BattleBonusesAdWindowArgs__OnClose__
		            );
		  piVar1 = *(int **)(param1 + 0x58);
		  if (piVar1 != (int *)0x0) {
		    (**(code **)((ulonglong)*(uint *)(*piVar1 + 0x130) * 4))
		              (piVar1,*(undefined4 *)(*piVar1 + 0x134));
		  }
		  *(undefined4 *)(param1 + 0x58) = 0;
		  return;
		}
		*/

		}

		// Token: 0x060055CF RID: 21967 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055CF")]
		[Address(RVA = "0xA36F", Offset = "0xA36F", VA = "0xA36F", Slot = "19")]
		protected override void OnClose()
		{
		/* --- GHIDRA: OnClose ---
		void Gameplay_Ad_BattleBonusesAd_View_BattleBonusesAdWindow__OnClose(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  int *piVar2;
		  int iVar3;
		  
		  if (DAT_ram_00a58867 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BattleBonusesAdWindow_BattleBonusesAdWindowArgs__HandleContent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseWindow_BattleBonusesAdWindow_BattleBonusesAdWindowArgs__get_WindowArgs__
		              );
		    DAT_ram_00a58867 = '\x01';
		  }
		  UI_Windows_BaseDialogWindow_object___HandleButtons
		            (param1,
		             Method_UI_Windows_BaseDialogWindow_BattleBonusesAdWindow_BattleBonusesAdWindowArgs__HandleContent__
		            );
		  piVar2 = *(int **)(param1 + 0x50);
		  iVar1 = func_ii_8093(param1,
		                       Method_UI_Windows_BaseWindow_BattleBonusesAdWindow_BattleBonusesAdWindowArgs__get_WindowArgs__
		                      );
		  iVar3 = *piVar2;
		  (**(code **)((ulonglong)*(uint *)(iVar3 + 0x138) * 4))
		            (piVar2,*(undefined4 *)(iVar1 + 0x2c),*(undefined4 *)(iVar3 + 0x13c));
		  return;
		}
		*/

		}

		// Token: 0x060055D0 RID: 21968 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055D0")]
		[Address(RVA = "0xA370", Offset = "0xA370", VA = "0xA370", Slot = "28")]
		protected override void HandleContent()
		{
		/* --- GHIDRA: HandleContent ---
		void Gameplay_Ad_BattleBonusesAd_View_BattleBonusesAdWindow__HandleContent
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a58868 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BattleBonusesAdWindow_BattleBonusesAdWindowArgs___ctor__
		              );
		    DAT_ram_00a58868 = '\x01';
		  }
		  UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_object____ctor
		            (param1,
		             Method_UI_Windows_BaseDialogWindow_BattleBonusesAdWindow_BattleBonusesAdWindowArgs___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x060055D1 RID: 21969 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055D1")]
		[Address(RVA = "0xA371", Offset = "0xA371", VA = "0xA371")]
		public BattleBonusesAdWindow()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Ad_BattleBonusesAd_View_BattleBonusesAdWindow___ctor
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a58869 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_BattleBonusesAdWindow_BattleBonusesAdWindowArgs___ctor__
		              );
		    DAT_ram_00a58869 = '\x01';
		  }
		  UnityEngine_UIElements_BaseCompositeField___Il2CppFullySharedGenericType__object____Il2CppFullySharedGenericType___UpdateMixedValueContent
		            (param1,
		             Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_BattleBonusesAdWindow_BattleBonusesAdWindowArgs___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x04002E7B RID: 11899
		[Token(Token = "0x4002E7B")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/Ad/BattleBonusesAdWindow";

		// Token: 0x04002E7C RID: 11900
		[Token(Token = "0x4002E7C")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private BattleBonusesBonusRenderer _battleBonusesBonusRenderer;

		// Token: 0x04002E7D RID: 11901
		[Token(Token = "0x4002E7D")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private Button _watchButton;

		// Token: 0x04002E7E RID: 11902
		[Token(Token = "0x4002E7E")]
		[FieldOffset(Offset = "0x58")]
		private BattleBonusesAdWindowMediator _mediator;

		// Token: 0x02000DBD RID: 3517
		[Token(Token = "0x2000DBD")]
		public class BattleBonusesAdWindowArgs : BaseDialogWindow<BattleBonusesAdWindow.BattleBonusesAdWindowArgs>.BaseDialogWindowArgs
		{
			// Token: 0x060055D2 RID: 21970 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60055D2")]
			[Address(RVA = "0xA372", Offset = "0xA372", VA = "0xA372")]
			public BattleBonusesAdWindowArgs()
			{
			}

			// Token: 0x04002E7F RID: 11903
			[Token(Token = "0x4002E7F")]
			[FieldOffset(Offset = "0x2C")]
			public MedalData BonusMedalData;

			// Token: 0x04002E80 RID: 11904
			[Token(Token = "0x4002E80")]
			[FieldOffset(Offset = "0x30")]
			public BattleBonusesAdController Controller;

			// Token: 0x04002E81 RID: 11905
			[Token(Token = "0x4002E81")]
			[FieldOffset(Offset = "0x34")]
			public BattleBonusesAdModel Model;

			// Token: 0x04002E82 RID: 11906
			[Token(Token = "0x4002E82")]
			[FieldOffset(Offset = "0x38")]
			public BattleBonusesAdEvents Events;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_WatchButton ---
		void Gameplay_Ad_BattleBonusesAd_View_BattleBonusesAdWindow__get_WatchButton
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  undefined4 param5;
		  undefined4 param4;
		  undefined4 param3_00;
		  
		  if (DAT_ram_00a58865 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BattleBonusesAdWindow_BattleBonusesAdWindowArgs__OnShow__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Ad_BattleBonusesAd_Controller_BattleBonusesAdWindowMediator_TypeInfo);
		    DAT_ram_00a58865 = '\x01';
		  }
		  UI_Windows_BaseDialogWindow_object___OnDestroy
		            (param1,param2,
		             Method_UI_Windows_BaseDialogWindow_BattleBonusesAdWindow_BattleBonusesAdWindowArgs__OnShow__
		            );
		  param5 = *(undefined4 *)(param2 + 0x30);
		  param4 = *(undefined4 *)(param2 + 0x38);
		  param3_00 = *(undefined4 *)(param2 + 0x34);
		  param1_00 = unnamed_function_1417
		                        (
		                        Gameplay_Ad_BattleBonusesAd_Controller_BattleBonusesAdWindowMediator_TypeInfo
		                        );
		  if (DAT_ram_00a58879 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractCozyViewMediator_BattleBonusesAdModel__BattleBonusesAdEvents__BattleBonusesAdController__BattleBonusesAdWindow___ctor__
		              );
		    DAT_ram_00a58879 = '\x01';
		  }
		  MVC_AbstractCozyViewMediator_object__object__object__object____ctor
		            (param1_00,param1,param3_00,param4,param5,
		             Method_MVC_AbstractCozyViewMediator_BattleBonusesAdModel__BattleBonusesAdEvents__BattleBonusesAdController__BattleBonusesAdWindow___ctor__
		            );
		  *(undefined4 *)(param1 + 0x58) = param1_00;
		  return;
		}
		*/

}
