using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data.Tournaments;
using Gameplay.BlitzTournament.View;
using Gameplay.Tournaments.Controller;
using Il2CppDummyDll;
using UI.Tabs;
using UI.Windows;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Tournaments.View
{
	// Token: 0x020004B4 RID: 1204
	[Token(Token = "0x20004B4")]
	public class TournamentsWindow : ClosableBaseWindow<TournamentsWindow.TournamentsWindowArgs>
	{
		// Token: 0x1700051A RID: 1306
		// (get) Token: 0x06001C70 RID: 7280 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700051A")]
		public override string WindowId
		{
			[Token(Token = "0x6001C70")]
			[Address(RVA = "0x6DEF", Offset = "0x6DEF", VA = "0x6DEF", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700051B RID: 1307
		// (get) Token: 0x06001C71 RID: 7281 RVA: 0x00005F28 File Offset: 0x00004128
		// (set) Token: 0x06001C72 RID: 7282 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700051B")]
		public bool AllowClose
		{
			[Token(Token = "0x6001C71")]
			[Address(RVA = "0x6DF0", Offset = "0x6DF0", VA = "0x6DF0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001C72")]
			[Address(RVA = "0x6DF1", Offset = "0x6DF1", VA = "0x6DF1")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700051C RID: 1308
		// (get) Token: 0x06001C73 RID: 7283 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700051C")]
		public Button HistoryButton
		{
			[Token(Token = "0x6001C73")]
			[Address(RVA = "0x6DF2", Offset = "0x6DF2", VA = "0x6DF2")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700051D RID: 1309
		// (get) Token: 0x06001C74 RID: 7284 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700051D")]
		public BlueTabBar TabBar
		{
			[Token(Token = "0x6001C74")]
			[Address(RVA = "0x6DF3", Offset = "0x6DF3", VA = "0x6DF3")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700051E RID: 1310
		// (get) Token: 0x06001C75 RID: 7285 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700051E")]
		public TournamentInfoBox InfoBox
		{
			[Token(Token = "0x6001C75")]
			[Address(RVA = "0x6DF4", Offset = "0x6DF4", VA = "0x6DF4")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700051F RID: 1311
		// (get) Token: 0x06001C76 RID: 7286 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700051F")]
		public Button RulesButton
		{
			[Token(Token = "0x6001C76")]
			[Address(RVA = "0x6DF5", Offset = "0x6DF5", VA = "0x6DF5")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000520 RID: 1312
		// (get) Token: 0x06001C77 RID: 7287 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000520")]
		public Button InTournamentButton
		{
			[Token(Token = "0x6001C77")]
			[Address(RVA = "0x6DF6", Offset = "0x6DF6", VA = "0x6DF6")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000521 RID: 1313
		// (get) Token: 0x06001C78 RID: 7288 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000521")]
		public Button QuitButton
		{
			[Token(Token = "0x6001C78")]
			[Address(RVA = "0x6DF7", Offset = "0x6DF7", VA = "0x6DF7")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001C79 RID: 7289 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C79")]
		[Address(RVA = "0x6DF8", Offset = "0x6DF8", VA = "0x6DF8", Slot = "19")]
		protected override void OnClose()
		{
		/* --- GHIDRA: OnClose ---
		void Gameplay_Tournaments_View_TournamentsWindow__OnClose
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a58509 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_ClosableBaseWindow_TournamentsWindow_TournamentsWindowArgs__OnShow__
		              );
		    DAT_ram_00a58509 = '\x01';
		  }
		  func_ii_7769(param1,param2,
		               Method_UI_Windows_ClosableBaseWindow_TournamentsWindow_TournamentsWindowArgs__OnShow__
		              );
		  Gameplay_Tournaments_View_TournamentsWindow__CheckForClose(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06001C7A RID: 7290 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C7A")]
		[Address(RVA = "0x6DF9", Offset = "0x6DF9", VA = "0x6DF9", Slot = "22")]
		protected override void OnShow(TournamentsWindow.TournamentsWindowArgs args)
		{
		/* --- GHIDRA: OnShow ---
		int * Gameplay_Tournaments_View_TournamentsWindow__OnShow
		                (int param1,int *param2,undefined4 param3,undefined4 param4)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  int *piVar5;
		  undefined4 param1_00;
		  int iVar6;
		  int iVar7;
		  int *piVar8;
		  
		  uVar1 = 0;
		  if (DAT_ram_00a5850a == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_ICollection_TournamentData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IList_TournamentData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Object_Instantiate_TournamentListElement___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Tournaments_View_TournamentListElement___TypeInfo);
		    DAT_ram_00a5850a = '\x01';
		  }
		  iVar6 = *param2;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (System_Collections_Generic_ICollection_TournamentData__TypeInfo ==
		          *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(iVar6 + *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80efd995;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,
		                                System_Collections_Generic_ICollection_TournamentData__TypeInfo,0);
		code_r0x80efd995:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		  piVar4 = (int *)Mono_Security_ASN1Convert__ToOid
		                            (Gameplay_Tournaments_View_TournamentListElement___TypeInfo,uVar3);
		  iVar6 = 0;
		  do {
		    iVar7 = *param2;
		    if (*(ushort *)(iVar7 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar5 = (int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8);
		        if (System_Collections_Generic_ICollection_TournamentData__TypeInfo == *piVar5) {
		          puVar2 = (uint *)(iVar7 + piVar5[1] * 8 + 0xc0);
		          goto code_r0x80efda22;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(param2,
		                                  System_Collections_Generic_ICollection_TournamentData__TypeInfo,0)
		    ;
		code_r0x80efda22:
		    iVar7 = (**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		    if (iVar7 <= iVar6) {
		      return piVar4;
		    }
		    uVar3 = *(undefined4 *)(param1 + 0x40);
		    param1_00 = *(undefined4 *)(param1 + 0x3c);
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      func_ii_306000(UnityEngine_Object_TypeInfo);
		    }
		    piVar5 = (int *)func_ii_6805(param1_00,uVar3,
		                                 Method_UnityEngine_Object_Instantiate_TournamentListElement___);
		    iVar7 = *param2;
		    if (*(ushort *)(iVar7 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar8 = (int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8);
		        if (System_Collections_Generic_IList_TournamentData__TypeInfo == *piVar8) {
		          puVar2 = (uint *)(iVar7 + piVar8[1] * 8 + 0xc0);
		          goto code_r0x80efdad4;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(param2,System_Collections_Generic_IList_TournamentData__TypeInfo,0
		                                 );
		code_r0x80efdad4:
		    uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param2,iVar6,puVar2[1]);
		    (**(code **)((ulonglong)*(uint *)(*piVar5 + 0x100) * 4))
		              (piVar5,iVar6 + 1,uVar3,param3,*(undefined4 *)(*piVar5 + 0x104));
		    iVar7 = func_ii_1082(piVar5,*(undefined4 *)(*piVar4 + 0x20));
		    if (iVar7 == 0) {
		      uVar3 = func_ii_1083();
		      func_ii_1050(uVar3,0);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    piVar4[iVar6 + 4] = (int)piVar5;
		    iVar6 = iVar6 + 1;
		  } while( true );
		}
		*/

		}

		// Token: 0x06001C7B RID: 7291 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001C7B")]
		[Address(RVA = "0x6DFA", Offset = "0x6DFA", VA = "0x6DFA")]
		public TournamentListElement[] Init(IList<TournamentData> tournaments, Action<TournamentListElementBase> onClick)
		{
			return null;
		}

		// Token: 0x06001C7C RID: 7292 RVA: 0x00005F40 File Offset: 0x00004140
		[Token(Token = "0x6001C7C")]
		[Address(RVA = "0x6DFB", Offset = "0x6DFB", VA = "0x6DFB", Slot = "17")]
		public override bool CheckForClose()
		{
		/* --- GHIDRA: CheckForClose ---
		void Gameplay_Tournaments_View_TournamentsWindow__CheckForClose(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param2_00;
		  undefined4 param3;
		  int *param1_00;
		  int *param4;
		  
		  if (DAT_ram_00a5850b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseWindow_TournamentsWindow_TournamentsWindowArgs__get_WindowArgs__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Tournaments_Controller_TournamentsViewMediator_TypeInfo);
		    DAT_ram_00a5850b = '\x01';
		  }
		  if (*(char *)(param1 + 100) == '\0') {
		    iVar1 = func_ii_8093(param1,
		                         Method_UI_Windows_BaseWindow_TournamentsWindow_TournamentsWindowArgs__get_WindowArgs__
		                        );
		    param4 = *(int **)(iVar1 + 0x18);
		    param2_00 = (**(code **)((ulonglong)*(uint *)(*param4 + 0x100) * 4))
		                          (param4,*(undefined4 *)(*param4 + 0x104));
		    param3 = (**(code **)((ulonglong)*(uint *)(*param4 + 0x110) * 4))
		                       (param4,*(undefined4 *)(*param4 + 0x114));
		    param1_00 = (int *)unnamed_function_1417
		                                 (Gameplay_Tournaments_Controller_TournamentsViewMediator_TypeInfo);
		    Gameplay_Tournaments_Controller_TournamentsViewMediator__set_TournamentProgressWindow
		              (param1_00,param2_00,param3,param4,0);
		    (**(code **)((ulonglong)*(uint *)(*param1_00 + 0x160) * 4))
		              (param1_00,param1,*(undefined4 *)(*param1_00 + 0x164));
		    *(undefined1 *)(param1 + 100) = 1;
		    *(int **)(param1 + 0x60) = param1_00;
		  }
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x06001C7D RID: 7293 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C7D")]
		[Address(RVA = "0x6DFC", Offset = "0x6DFC", VA = "0x6DFC")]
		private void SetupMVC()
		{
		/* --- GHIDRA: SetupMVC ---
		void Gameplay_Tournaments_View_TournamentsWindow__SetupMVC(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (*(char *)(param1 + 100) != '\0') {
		    iVar1 = **(int **)(param1 + 0x60);
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0x130) * 4))
		              (*(int **)(param1 + 0x60),*(undefined4 *)(iVar1 + 0x134));
		    *(undefined4 *)(param1 + 0x60) = 0;
		  }
		  return;
		}
		*/

		}

		// Token: 0x06001C7E RID: 7294 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C7E")]
		[Address(RVA = "0x6DFD", Offset = "0x6DFD", VA = "0x6DFD")]
		private void DestroyMVC()
		{
		/* --- GHIDRA: DestroyMVC ---
		void Gameplay_Tournaments_View_TournamentsWindow__DestroyMVC(int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5850c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_ClosableBaseWindow_TournamentsWindow_TournamentsWindowArgs___ctor__
		              );
		    DAT_ram_00a5850c = '\x01';
		  }
		  *(undefined1 *)(param1 + 0x5c) = 1;
		  UI_MonoBehaviourWithStates_ClientStateChangedDelegate___Il2CppFullySharedGenericStructType___Invoke
		            (param1,
		             Method_UI_Windows_ClosableBaseWindow_TournamentsWindow_TournamentsWindowArgs___ctor__);
		  return;
		}
		*/

		}

		// Token: 0x06001C7F RID: 7295 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C7F")]
		[Address(RVA = "0x6DFE", Offset = "0x6DFE", VA = "0x6DFE")]
		public TournamentsWindow()
		{
		}

		// Token: 0x04000F7A RID: 3962
		[Token(Token = "0x4000F7A")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/Tournaments/TournamentsWindow";

		// Token: 0x04000F7B RID: 3963
		[Token(Token = "0x4000F7B")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private TournamentListElement _listElementPrefab;

		// Token: 0x04000F7C RID: 3964
		[Token(Token = "0x4000F7C")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private RectTransform _scrollContentParent;

		// Token: 0x04000F7D RID: 3965
		[Token(Token = "0x4000F7D")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private BlueTabBar _tabBar;

		// Token: 0x04000F7E RID: 3966
		[Token(Token = "0x4000F7E")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Button _rulesButton;

		// Token: 0x04000F7F RID: 3967
		[Token(Token = "0x4000F7F")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private TournamentInfoBox _infoBox;

		// Token: 0x04000F80 RID: 3968
		[Token(Token = "0x4000F80")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Button _historyButton;

		// Token: 0x04000F81 RID: 3969
		[Token(Token = "0x4000F81")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private Button _inTournamentButton;

		// Token: 0x04000F82 RID: 3970
		[Token(Token = "0x4000F82")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Button _quitButton;

		// Token: 0x04000F84 RID: 3972
		[Token(Token = "0x4000F84")]
		[FieldOffset(Offset = "0x60")]
		private TournamentsViewMediator _mediator;

		// Token: 0x04000F85 RID: 3973
		[Token(Token = "0x4000F85")]
		[FieldOffset(Offset = "0x64")]
		private bool _mvcSetUp;

		// Token: 0x020004B5 RID: 1205
		[Token(Token = "0x20004B5")]
		public class TournamentsWindowArgs : BaseWindowArgs
		{
			// Token: 0x06001C80 RID: 7296 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001C80")]
			[Address(RVA = "0x6DFF", Offset = "0x6DFF", VA = "0x6DFF")]
			public TournamentsWindowArgs()
			{
			}

			// Token: 0x04000F86 RID: 3974
			[Token(Token = "0x4000F86")]
			[FieldOffset(Offset = "0x18")]
			public TournamentsController Controller;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_QuitButton ---
		void Gameplay_Tournaments_View_TournamentsWindow__get_QuitButton(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a58508 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_ClosableBaseWindow_TournamentsWindow_TournamentsWindowArgs__OnClose__
		              );
		    DAT_ram_00a58508 = '\x01';
		  }
		  UI_Windows_ClosableBaseWindow_object___OnClickBack
		            (param1,
		             Method_UI_Windows_ClosableBaseWindow_TournamentsWindow_TournamentsWindowArgs__OnClose__
		            );
		  if (*(char *)(param1 + 100) != '\0') {
		    iVar1 = **(int **)(param1 + 0x60);
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0x130) * 4))
		              (*(int **)(param1 + 0x60),*(undefined4 *)(iVar1 + 0x134));
		    *(undefined4 *)(param1 + 0x60) = 0;
		  }
		  return;
		}
		*/

}
