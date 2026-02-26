using System;
using System.Collections.Generic;
using Core.Data.Tournaments;
using Gameplay.BlitzTournament.Controller;
using Il2CppDummyDll;
using UI.Tabs;
using UI.Windows;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.BlitzTournament.View
{
	// Token: 0x02000BC9 RID: 3017
	[Token(Token = "0x2000BC9")]
	public class BlitzTournamentWindow : ClosableBaseWindow<BlitzTournamentWindow.BlitzTournamentWindowArgs>
	{
		// Token: 0x17000EF3 RID: 3827
		// (get) Token: 0x060049F4 RID: 18932 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000EF3")]
		public override string WindowId
		{
			[Token(Token = "0x60049F4")]
			[Address(RVA = "0x985E", Offset = "0x985E", VA = "0x985E", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000EF4 RID: 3828
		// (get) Token: 0x060049F5 RID: 18933 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000EF4")]
		public BlitzTournamentInfoBox InfoBox
		{
			[Token(Token = "0x60049F5")]
			[Address(RVA = "0x985F", Offset = "0x985F", VA = "0x985F")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000EF5 RID: 3829
		// (get) Token: 0x060049F6 RID: 18934 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000EF5")]
		public BlueTabBar TabBar
		{
			[Token(Token = "0x60049F6")]
			[Address(RVA = "0x9860", Offset = "0x9860", VA = "0x9860")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000EF6 RID: 3830
		// (get) Token: 0x060049F7 RID: 18935 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000EF6")]
		public Button RulesButton
		{
			[Token(Token = "0x60049F7")]
			[Address(RVA = "0x9861", Offset = "0x9861", VA = "0x9861")]
			get
			{
				return null;
			}
		}

		// Token: 0x060049F8 RID: 18936 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60049F8")]
		[Address(RVA = "0x9862", Offset = "0x9862", VA = "0x9862", Slot = "22")]
		protected override void OnShow(BlitzTournamentWindow.BlitzTournamentWindowArgs args)
		{
		/* --- GHIDRA: OnShow ---
		void Gameplay_BlitzTournament_View_BlitzTournamentWindow__OnShow(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a608a5 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_ClosableBaseWindow_BlitzTournamentWindow_BlitzTournamentWindowArgs__OnClose__
		              );
		    DAT_ram_00a608a5 = '\x01';
		  }
		  UI_Windows_ClosableBaseWindow_object___OnClickBack
		            (param1,
		             Method_UI_Windows_ClosableBaseWindow_BlitzTournamentWindow_BlitzTournamentWindowArgs__OnClose__
		            );
		  if (*(char *)(param1 + 0x58) != '\0') {
		    *(undefined1 *)(param1 + 0x58) = 0;
		    iVar1 = **(int **)(param1 + 0x54);
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0x130) * 4))
		              (*(int **)(param1 + 0x54),*(undefined4 *)(iVar1 + 0x134));
		    *(undefined4 *)(param1 + 0x54) = 0;
		  }
		  return;
		}
		*/

		}

		// Token: 0x060049F9 RID: 18937 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60049F9")]
		[Address(RVA = "0x9863", Offset = "0x9863", VA = "0x9863", Slot = "19")]
		protected override void OnClose()
		{
		/* --- GHIDRA: OnClose ---
		int * Gameplay_BlitzTournament_View_BlitzTournamentWindow__OnClose
		                (int param1,int *param2,undefined4 param3,undefined4 param4)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  int *piVar5;
		  int iVar6;
		  undefined4 param1_00;
		  int iVar7;
		  int *piVar8;
		  
		  uVar1 = 0;
		  if (DAT_ram_00a608a6 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_BlitzTournament_View_BlitzTournamentListElement___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_ICollection_BlitzTournamentData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IList_BlitzTournamentData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_UnityEngine_Object_Instantiate_BlitzTournamentListElement___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a608a6 = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar5 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x178);
		        goto code_r0x81cf35e4;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x81cf35e4:
		  uVar1 = 0;
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		  Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar3,0);
		  iVar6 = *param2;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (System_Collections_Generic_ICollection_BlitzTournamentData__TypeInfo ==
		          *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(iVar6 + *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x81cf366b;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,
		                                System_Collections_Generic_ICollection_BlitzTournamentData__TypeInfo
		                                ,0);
		code_r0x81cf366b:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		  piVar5 = (int *)Mono_Security_ASN1Convert__ToOid
		                            (Gameplay_BlitzTournament_View_BlitzTournamentListElement___TypeInfo,
		                             uVar3);
		  iVar6 = 0;
		  do {
		    iVar7 = *param2;
		    if (*(ushort *)(iVar7 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar4 = (int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8);
		        if (System_Collections_Generic_ICollection_BlitzTournamentData__TypeInfo == *piVar4) {
		          puVar2 = (uint *)(iVar7 + piVar4[1] * 8 + 0xc0);
		          goto code_r0x81cf36fc;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(param2,
		                                  System_Collections_Generic_ICollection_BlitzTournamentData__TypeInfo
		                                  ,0);
		code_r0x81cf36fc:
		    iVar7 = (**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		    if (iVar7 <= iVar6) {
		      return piVar5;
		    }
		    uVar3 = *(undefined4 *)(param1 + 0x40);
		    param1_00 = *(undefined4 *)(param1 + 0x3c);
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      func_ii_306000(UnityEngine_Object_TypeInfo);
		    }
		    piVar4 = (int *)func_ii_6805(param1_00,uVar3,
		                                 Method_UnityEngine_Object_Instantiate_BlitzTournamentListElement___
		                                );
		    iVar7 = *param2;
		    if (*(ushort *)(iVar7 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar8 = (int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8);
		        if (System_Collections_Generic_IList_BlitzTournamentData__TypeInfo == *piVar8) {
		          puVar2 = (uint *)(iVar7 + piVar8[1] * 8 + 0xc0);
		          goto code_r0x81cf37ae;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(param2,
		                                  System_Collections_Generic_IList_BlitzTournamentData__TypeInfo,0);
		code_r0x81cf37ae:
		    uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param2,iVar6,puVar2[1]);
		    (**(code **)((ulonglong)*(uint *)(*piVar4 + 0x100) * 4))
		              (piVar4,iVar6 + 1,uVar3,param3,*(undefined4 *)(*piVar4 + 0x104));
		    iVar7 = func_ii_1082(piVar4,*(undefined4 *)(*piVar5 + 0x20));
		    if (iVar7 == 0) {
		      uVar3 = func_ii_1083();
		      func_ii_1050(uVar3,0);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    piVar5[iVar6 + 4] = (int)piVar4;
		    iVar6 = iVar6 + 1;
		  } while( true );
		}
		*/

		}

		// Token: 0x060049FA RID: 18938 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60049FA")]
		[Address(RVA = "0x9864", Offset = "0x9864", VA = "0x9864")]
		public BlitzTournamentListElement[] Init(IList<BlitzTournamentData> tournaments, Action<TournamentListElementBase> onClick)
		{
		/* --- GHIDRA: Init ---
		undefined4 Gameplay_BlitzTournament_View_BlitzTournamentWindow__Init(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  
		  iVar2 = *(int *)(param1 + 0x50);
		  uVar1 = (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		                    (*(undefined4 *)(iVar2 + 0x20),*(undefined4 *)(iVar2 + 0x14));
		  return uVar1;
		}
		*/

			return null;
		}

		// Token: 0x060049FB RID: 18939 RVA: 0x0000D9F8 File Offset: 0x0000BBF8
		[Token(Token = "0x60049FB")]
		[Address(RVA = "0x9865", Offset = "0x9865", VA = "0x9865", Slot = "17")]
		public override bool CheckForClose()
		{
		/* --- GHIDRA: CheckForClose ---
		void Gameplay_BlitzTournament_View_BlitzTournamentWindow__CheckForClose
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param2_00;
		  undefined4 param3;
		  int *param1_00;
		  int *param4;
		  
		  if (DAT_ram_00a608a7 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseWindow_BlitzTournamentWindow_BlitzTournamentWindowArgs__get_WindowArgs__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_BlitzTournament_Controller_BlitzTournamentViewMediator_TypeInfo);
		    DAT_ram_00a608a7 = '\x01';
		  }
		  if (*(char *)(param1 + 0x58) == '\0') {
		    *(undefined1 *)(param1 + 0x58) = 1;
		    iVar1 = func_ii_8093(param1,
		                         Method_UI_Windows_BaseWindow_BlitzTournamentWindow_BlitzTournamentWindowArgs__get_WindowArgs__
		                        );
		    param4 = *(int **)(iVar1 + 0x18);
		    param2_00 = (**(code **)((ulonglong)*(uint *)(*param4 + 0x100) * 4))
		                          (param4,*(undefined4 *)(*param4 + 0x104));
		    param3 = (**(code **)((ulonglong)*(uint *)(*param4 + 0x110) * 4))
		                       (param4,*(undefined4 *)(*param4 + 0x114));
		    param1_00 = (int *)unnamed_function_1417
		                                 (
		                                 Gameplay_BlitzTournament_Controller_BlitzTournamentViewMediator_TypeInfo
		                                 );
		    if (DAT_ram_00a608e1 == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&
		                 Method_MVC_AbstractViewMediator_BlitzTournamentModel__BlitzTournamentEvents__BlitzTournamentController__BlitzTournamentWindow___ctor__
		                );
		      DAT_ram_00a608e1 = '\x01';
		    }
		    Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		              (param1_00,param2_00,param3,param4,
		               Method_MVC_AbstractViewMediator_BlitzTournamentModel__BlitzTournamentEvents__BlitzTournamentController__BlitzTournamentWindow___ctor__
		              );
		    (**(code **)((ulonglong)*(uint *)(*param1_00 + 0x160) * 4))
		              (param1_00,param1,*(undefined4 *)(*param1_00 + 0x164));
		    *(int **)(param1 + 0x54) = param1_00;
		  }
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x060049FC RID: 18940 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60049FC")]
		[Address(RVA = "0x9866", Offset = "0x9866", VA = "0x9866")]
		private void SetupMVC()
		{
		/* --- GHIDRA: SetupMVC ---
		void Gameplay_BlitzTournament_View_BlitzTournamentWindow__SetupMVC(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (*(char *)(param1 + 0x58) != '\0') {
		    *(undefined1 *)(param1 + 0x58) = 0;
		    iVar1 = **(int **)(param1 + 0x54);
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0x130) * 4))
		              (*(int **)(param1 + 0x54),*(undefined4 *)(iVar1 + 0x134));
		    *(undefined4 *)(param1 + 0x54) = 0;
		  }
		  return;
		}
		*/

		}

		// Token: 0x060049FD RID: 18941 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60049FD")]
		[Address(RVA = "0x9867", Offset = "0x9867", VA = "0x9867")]
		private void DestroyMVC()
		{
		/* --- GHIDRA: DestroyMVC ---
		void Gameplay_BlitzTournament_View_BlitzTournamentWindow__DestroyMVC(int param1,undefined4 param2)
		
		{
		  undefined4 *puVar1;
		  int param1_00;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a608a8 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_ClosableBaseWindow_BlitzTournamentWindow_BlitzTournamentWindowArgs___ctor__
		              );
		    Mono_Security_ASN1__get_Item(&System_Func_bool__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_BlitzTournament_View_BlitzTournamentWindow___c___ctor_b__25_0__);
		    Mono_Security_ASN1__get_Item(&Gameplay_BlitzTournament_View_BlitzTournamentWindow___c_TypeInfo);
		    DAT_ram_00a608a8 = '\x01';
		  }
		  if (*(int *)(Gameplay_BlitzTournament_View_BlitzTournamentWindow___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Gameplay_BlitzTournament_View_BlitzTournamentWindow___c_TypeInfo);
		  }
		  puVar1 = *(undefined4 **)(Gameplay_BlitzTournament_View_BlitzTournamentWindow___c_TypeInfo + 0x5c)
		  ;
		  param1_00 = puVar1[1];
		  if (param1_00 == 0) {
		    if (*(int *)(Gameplay_BlitzTournament_View_BlitzTournamentWindow___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Gameplay_BlitzTournament_View_BlitzTournamentWindow___c_TypeInfo);
		      puVar1 = *(undefined4 **)
		                (Gameplay_BlitzTournament_View_BlitzTournamentWindow___c_TypeInfo + 0x5c);
		    }
		    param2_00 = *puVar1;
		    param1_00 = unnamed_function_1417(System_Func_bool__TypeInfo);
		    System_Func_BackgroundSize___Invoke
		              (param1_00,param2_00,
		               Method_Gameplay_BlitzTournament_View_BlitzTournamentWindow___c___ctor_b__25_0__,0);
		    *(int *)(*(int *)(Gameplay_BlitzTournament_View_BlitzTournamentWindow___c_TypeInfo + 0x5c) + 4)
		         = param1_00;
		  }
		  *(int *)(param1 + 0x50) = param1_00;
		  UI_MonoBehaviourWithStates_ClientStateChangedDelegate___Il2CppFullySharedGenericStructType___Invoke
		            (param1,
		             Method_UI_Windows_ClosableBaseWindow_BlitzTournamentWindow_BlitzTournamentWindowArgs___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x060049FE RID: 18942 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60049FE")]
		[Address(RVA = "0x9868", Offset = "0x9868", VA = "0x9868")]
		public BlitzTournamentWindow()
		{
		}

		// Token: 0x04002840 RID: 10304
		[Token(Token = "0x4002840")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/BlitzTournament/BlitzTournamentWindow";

		// Token: 0x04002841 RID: 10305
		[Token(Token = "0x4002841")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private BlitzTournamentListElement _listElementPrefab;

		// Token: 0x04002842 RID: 10306
		[Token(Token = "0x4002842")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private RectTransform _scrollContentParent;

		// Token: 0x04002843 RID: 10307
		[Token(Token = "0x4002843")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private BlitzTournamentInfoBox _infoBox;

		// Token: 0x04002844 RID: 10308
		[Token(Token = "0x4002844")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private BlueTabBar _tabBar;

		// Token: 0x04002845 RID: 10309
		[Token(Token = "0x4002845")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private Button _rulesButton;

		// Token: 0x04002846 RID: 10310
		[Token(Token = "0x4002846")]
		[FieldOffset(Offset = "0x50")]
		public Func<bool> CheckForClosePermission;

		// Token: 0x04002847 RID: 10311
		[Token(Token = "0x4002847")]
		[FieldOffset(Offset = "0x54")]
		private BlitzTournamentViewMediator _mediator;

		// Token: 0x04002848 RID: 10312
		[Token(Token = "0x4002848")]
		[FieldOffset(Offset = "0x58")]
		private bool _mvcSetUp;

		// Token: 0x02000BCA RID: 3018
		[Token(Token = "0x2000BCA")]
		public class BlitzTournamentWindowArgs : BaseWindowArgs
		{
			// Token: 0x060049FF RID: 18943 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60049FF")]
			[Address(RVA = "0x9869", Offset = "0x9869", VA = "0x9869")]
			public BlitzTournamentWindowArgs()
			{
			}

			// Token: 0x04002849 RID: 10313
			[Token(Token = "0x4002849")]
			[FieldOffset(Offset = "0x18")]
			public BlitzTournamentController Controller;

			// Token: 0x0400284A RID: 10314
			[Token(Token = "0x400284A")]
			[FieldOffset(Offset = "0x1C")]
			public BlitzTournamentWindow.WindowState WindowState;
		}

		// Token: 0x02000BCB RID: 3019
		[Token(Token = "0x2000BCB")]
		public enum WindowState
		{
			// Token: 0x0400284C RID: 10316
			[Token(Token = "0x400284C")]
			Default,
			// Token: 0x0400284D RID: 10317
			[Token(Token = "0x400284D")]
			Win,
			// Token: 0x0400284E RID: 10318
			[Token(Token = "0x400284E")]
			Lose
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_RulesButton ---
		void Gameplay_BlitzTournament_View_BlitzTournamentWindow__get_RulesButton
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a608a4 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_ClosableBaseWindow_BlitzTournamentWindow_BlitzTournamentWindowArgs__OnShow__
		              );
		    DAT_ram_00a608a4 = '\x01';
		  }
		  func_ii_7769(param1,param2,
		               Method_UI_Windows_ClosableBaseWindow_BlitzTournamentWindow_BlitzTournamentWindowArgs__OnShow__
		              );
		  Gameplay_BlitzTournament_View_BlitzTournamentWindow__CheckForClose(param1,param1);
		  return;
		}
		*/

}
