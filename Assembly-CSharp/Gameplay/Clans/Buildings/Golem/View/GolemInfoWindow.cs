using System;
using AssetContent;
using Core.Data;
using Gameplay.Clans.Buildings.Golem.Controller;
using Gameplay.Clans.Buildings.Golem.Events;
using Gameplay.Clans.Buildings.Golem.Model;
using Gameplay.Combat.View.Players;
using Gameplay.Isles.Clan;
using Gameplay.UserInfo.View;
using Gameplay.World.Model;
using Il2CppDummyDll;
using TMPro;
using UI;
using UI.Windows;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Clans.Buildings.Golem.View
{
	// Token: 0x02000AC3 RID: 2755
	[Token(Token = "0x2000AC3")]
	public class GolemInfoWindow : ClosableBaseWindow<GolemInfoWindow.GolemInfoWindowArgs>
	{
		// Token: 0x17000D0F RID: 3343
		// (get) Token: 0x0600426C RID: 17004 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000D0F")]
		public override string WindowId
		{
			[Token(Token = "0x600426C")]
			[Address(RVA = "0x9120", Offset = "0x9120", VA = "0x9120", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000D10 RID: 3344
		// (get) Token: 0x0600426D RID: 17005 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000D10")]
		public IndexButtonBasic WarStatusButton
		{
			[Token(Token = "0x600426D")]
			[Address(RVA = "0x9121", Offset = "0x9121", VA = "0x9121")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000D11 RID: 3345
		// (get) Token: 0x0600426E RID: 17006 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000D11")]
		public IndexButtonBasic UpgradeButton
		{
			[Token(Token = "0x600426E")]
			[Address(RVA = "0x9122", Offset = "0x9122", VA = "0x9122")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000D12 RID: 3346
		// (get) Token: 0x0600426F RID: 17007 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000D12")]
		public IndexButtonBasic ChestButton
		{
			[Token(Token = "0x600426F")]
			[Address(RVA = "0x9123", Offset = "0x9123", VA = "0x9123")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000D13 RID: 3347
		// (get) Token: 0x06004270 RID: 17008 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000D13")]
		public IndexButtonBasic ArmoryButton
		{
			[Token(Token = "0x6004270")]
			[Address(RVA = "0x9124", Offset = "0x9124", VA = "0x9124")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000D14 RID: 3348
		// (get) Token: 0x06004271 RID: 17009 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000D14")]
		public Button InfoButton
		{
			[Token(Token = "0x6004271")]
			[Address(RVA = "0x9125", Offset = "0x9125", VA = "0x9125")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000D15 RID: 3349
		// (get) Token: 0x06004272 RID: 17010 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000D15")]
		public SkillsInfoView SkillsInfoBox
		{
			[Token(Token = "0x6004272")]
			[Address(RVA = "0x9126", Offset = "0x9126", VA = "0x9126")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000D16 RID: 3350
		// (get) Token: 0x06004273 RID: 17011 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000D16")]
		public GolemEquipmentView GolemEquipmentView
		{
			[Token(Token = "0x6004273")]
			[Address(RVA = "0x9127", Offset = "0x9127", VA = "0x9127")]
			get
			{
				return null;
			}
		}

		// Token: 0x06004274 RID: 17012 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004274")]
		[Address(RVA = "0x9128", Offset = "0x9128", VA = "0x9128")]
		public void Init(UserData golemUserData, BaseBuildingData golemBuildingData)
		{
		/* --- GHIDRA: Init ---
		void Gameplay_Clans_Buildings_Golem_View_GolemInfoWindow__Init
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a57838 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_BaseWindow_GolemInfoWindow_GolemInfoWindowArgs__OnShow__);
		    DAT_ram_00a57838 = '\x01';
		  }
		  UI_Windows_BaseWindow_object____ctor
		            (param1,param2,
		             Method_UI_Windows_BaseWindow_GolemInfoWindow_GolemInfoWindowArgs__OnShow__);
		  Gameplay_Clans_Buildings_Golem_View_GolemInfoWindow__OnClose(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06004275 RID: 17013 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004275")]
		[Address(RVA = "0x9129", Offset = "0x9129", VA = "0x9129", Slot = "18")]
		protected override void OnShow(BaseWindowArgs args)
		{
		/* --- GHIDRA: OnShow ---
		void Gameplay_Clans_Buildings_Golem_View_GolemInfoWindow__OnShow(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a57839 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_ClosableBaseWindow_GolemInfoWindow_GolemInfoWindowArgs__OnClose__)
		    ;
		    DAT_ram_00a57839 = '\x01';
		  }
		  UI_Windows_ClosableBaseWindow_object___OnClickBack
		            (param1,
		             Method_UI_Windows_ClosableBaseWindow_GolemInfoWindow_GolemInfoWindowArgs__OnClose__);
		  MVC_AbstractController__Run(*(undefined4 *)(param1 + 0x6c),0);
		  iVar1 = **(int **)(param1 + 0x68);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x130) * 4))
		            (*(int **)(param1 + 0x68),*(undefined4 *)(iVar1 + 0x134));
		  iVar1 = **(int **)(param1 + 0x6c);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xe8) * 4))
		            (*(int **)(param1 + 0x6c),*(undefined4 *)(iVar1 + 0xec));
		  iVar1 = **(int **)(param1 + 0x70);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xe8) * 4))
		            (*(int **)(param1 + 0x70),*(undefined4 *)(iVar1 + 0xec));
		  *(undefined4 *)(param1 + 0x70) = 0;
		  *(undefined8 *)(param1 + 0x68) = 0;
		  return;
		}
		*/

		}

		// Token: 0x06004276 RID: 17014 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004276")]
		[Address(RVA = "0x912A", Offset = "0x912A", VA = "0x912A", Slot = "19")]
		protected override void OnClose()
		{
		/* --- GHIDRA: OnClose ---
		void Gameplay_Clans_Buildings_Golem_View_GolemInfoWindow__OnClose(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  int *piVar5;
		  int iVar6;
		  undefined4 uVar7;
		  undefined4 param5;
		  undefined4 param6;
		  int iVar8;
		  
		  if (DAT_ram_00a5783a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_BaseWindow_GolemInfoWindow_GolemInfoWindowArgs__get_WindowArgs__);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Clans_Buildings_Golem_Controller_GolemController_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Clans_Buildings_Golem_Events_GolemEvents_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Clans_Buildings_Golem_Controller_GolemInfoViewMediator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Clans_Buildings_Golem_Model_GolemModel_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a5783a = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  piVar5 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x178);
		        goto code_r0x80de66b2;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80de66b2:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar5 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x158);
		        goto code_r0x80de675e;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x13);
		code_r0x80de675e:
		  iVar6 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		  uVar7 = *(undefined4 *)(iVar6 + 0x14);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar5 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x140);
		        goto code_r0x80de680d;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x80de680d:
		  uVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		  uVar4 = func_ii_7112(uVar4,0);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar5 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x240);
		        goto code_r0x80de68bf;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x30);
		code_r0x80de68bf:
		  iVar6 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		  param5 = *(undefined4 *)(iVar6 + 0x10);
		  iVar6 = func_ii_8093(param1,
		                       Method_UI_Windows_BaseWindow_GolemInfoWindow_GolemInfoWindowArgs__get_WindowArgs__
		                      );
		  param6 = *(undefined4 *)(iVar6 + 0x18);
		  iVar6 = unnamed_function_1417(Gameplay_Clans_Buildings_Golem_Model_GolemModel_TypeInfo);
		  Gameplay_Clans_Buildings_Golem_Model_GolemModel__Dispose
		            (iVar6,uVar3,uVar7,uVar4,param5,param6,param5);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar5 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar8 = *piVar5;
		  if (*(ushort *)(iVar8 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + iVar8 + 0x248);
		        goto code_r0x80de699e;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x31);
		code_r0x80de699e:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		  *(undefined4 *)(iVar6 + 0x24) = uVar3;
		  *(int *)(param1 + 0x70) = iVar6;
		  uVar3 = unnamed_function_1417(Gameplay_Clans_Buildings_Golem_Events_GolemEvents_TypeInfo);
		  Gameplay_Clans_Buildings_Golem_Model_GolemModel___ctor(uVar3,uVar3);
		  *(undefined4 *)(param1 + 0x74) = uVar3;
		  uVar4 = *(undefined4 *)(param1 + 0x70);
		  uVar7 = unnamed_function_1417(Gameplay_Clans_Buildings_Golem_Controller_GolemController_TypeInfo);
		  Gameplay_Clans_Buildings_Golem_Controller_GolemArtifactActionViewMediator__InitRepairCostButton
		            (uVar7,uVar4,uVar3,0);
		  *(undefined4 *)(param1 + 0x6c) = uVar7;
		  uVar3 = *(undefined4 *)(param1 + 0x70);
		  uVar4 = *(undefined4 *)(param1 + 0x74);
		  piVar5 = (int *)unnamed_function_1417
		                            (
		                            Gameplay_Clans_Buildings_Golem_Controller_GolemInfoViewMediator_TypeInfo
		                            );
		  Gameplay_Clans_Buildings_Golem_Controller_GolemController__Dispose(piVar5,uVar3,uVar4,uVar7,0);
		  (**(code **)((ulonglong)*(uint *)(*piVar5 + 0x160) * 4))
		            (piVar5,param1,*(undefined4 *)(*piVar5 + 0x164));
		  *(int **)(param1 + 0x68) = piVar5;
		  MVC_AbstractController__Dispose(*(undefined4 *)(param1 + 0x6c),0);
		  return;
		}
		*/

		}

		// Token: 0x06004277 RID: 17015 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004277")]
		[Address(RVA = "0x912B", Offset = "0x912B", VA = "0x912B")]
		private void SetupMVC()
		{
		/* --- GHIDRA: SetupMVC ---
		void Gameplay_Clans_Buildings_Golem_View_GolemInfoWindow__SetupMVC(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  MVC_AbstractController__Run(*(undefined4 *)(param1 + 0x6c),0);
		  iVar1 = **(int **)(param1 + 0x68);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x130) * 4))
		            (*(int **)(param1 + 0x68),*(undefined4 *)(iVar1 + 0x134));
		  iVar1 = **(int **)(param1 + 0x6c);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xe8) * 4))
		            (*(int **)(param1 + 0x6c),*(undefined4 *)(iVar1 + 0xec));
		  iVar1 = **(int **)(param1 + 0x70);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xe8) * 4))
		            (*(int **)(param1 + 0x70),*(undefined4 *)(iVar1 + 0xec));
		  *(undefined4 *)(param1 + 0x70) = 0;
		  *(undefined8 *)(param1 + 0x68) = 0;
		  return;
		}
		*/

		}

		// Token: 0x06004278 RID: 17016 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004278")]
		[Address(RVA = "0x912C", Offset = "0x912C", VA = "0x912C")]
		private void DestroyMVC()
		{
		/* --- GHIDRA: DestroyMVC ---
		void Gameplay_Clans_Buildings_Golem_View_GolemInfoWindow__DestroyMVC
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5783b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_ClosableBaseWindow_GolemInfoWindow_GolemInfoWindowArgs___ctor__);
		    DAT_ram_00a5783b = '\x01';
		  }
		  UI_MonoBehaviourWithStates_ClientStateChangedDelegate___Il2CppFullySharedGenericStructType___Invoke
		            (param1,
		             Method_UI_Windows_ClosableBaseWindow_GolemInfoWindow_GolemInfoWindowArgs___ctor__);
		  return;
		}
		*/

		}

		// Token: 0x06004279 RID: 17017 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004279")]
		[Address(RVA = "0x912D", Offset = "0x912D", VA = "0x912D")]
		public GolemInfoWindow()
		{
		}

		// Token: 0x0400249C RID: 9372
		[Token(Token = "0x400249C")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/Clans/Golem/GolemInfoWindow";

		// Token: 0x0400249D RID: 9373
		[Token(Token = "0x400249D")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private GameAssetViewRawImage _avatar;

		// Token: 0x0400249E RID: 9374
		[Token(Token = "0x400249E")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GolemEquipmentView _equipmentView;

		// Token: 0x0400249F RID: 9375
		[Token(Token = "0x400249F")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private TextMeshProUGUI _nickField;

		// Token: 0x040024A0 RID: 9376
		[Token(Token = "0x40024A0")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private CombatPlayerLevelView _levelView;

		// Token: 0x040024A1 RID: 9377
		[Token(Token = "0x40024A1")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private CultWhitBackground _cultView;

		// Token: 0x040024A2 RID: 9378
		[Token(Token = "0x40024A2")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private SkillsInfoView _skillsInfoBox;

		// Token: 0x040024A3 RID: 9379
		[Token(Token = "0x40024A3")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private IndexButtonBasic _warStatusButton;

		// Token: 0x040024A4 RID: 9380
		[Token(Token = "0x40024A4")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private IndexButtonBasic _upgradeButton;

		// Token: 0x040024A5 RID: 9381
		[Token(Token = "0x40024A5")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private IndexButtonBasic _chestButton;

		// Token: 0x040024A6 RID: 9382
		[Token(Token = "0x40024A6")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private IndexButtonBasic _armory;

		// Token: 0x040024A7 RID: 9383
		[Token(Token = "0x40024A7")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		private Button _infoButton;

		// Token: 0x040024A8 RID: 9384
		[Token(Token = "0x40024A8")]
		[FieldOffset(Offset = "0x68")]
		private GolemInfoViewMediator _mediator;

		// Token: 0x040024A9 RID: 9385
		[Token(Token = "0x40024A9")]
		[FieldOffset(Offset = "0x6C")]
		private GolemController _controller;

		// Token: 0x040024AA RID: 9386
		[Token(Token = "0x40024AA")]
		[FieldOffset(Offset = "0x70")]
		private GolemModel _model;

		// Token: 0x040024AB RID: 9387
		[Token(Token = "0x40024AB")]
		[FieldOffset(Offset = "0x74")]
		private GolemEvents _events;

		// Token: 0x02000AC4 RID: 2756
		[Token(Token = "0x2000AC4")]
		public class GolemInfoWindowArgs : BaseWindowArgs
		{
			// Token: 0x0600427A RID: 17018 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600427A")]
			[Address(RVA = "0x912E", Offset = "0x912E", VA = "0x912E")]
			public GolemInfoWindowArgs()
			{
			}

			// Token: 0x040024AC RID: 9388
			[Token(Token = "0x40024AC")]
			[FieldOffset(Offset = "0x18")]
			public ClanIsle ClanIsle;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_GolemEquipmentView ---
		void Gameplay_Clans_Buildings_Golem_View_GolemInfoWindow__get_GolemEquipmentView
		               (int param1,int param2,int *param3,undefined4 param4)
		
		{
		  ulonglong uVar1;
		  float param2_00;
		  undefined4 uVar2;
		  undefined4 param1_00;
		  undefined4 uVar3;
		  int iVar4;
		  float fVar5;
		  undefined4 uVar6;
		  
		  if (DAT_ram_00a57837 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_AprDic__uint__get_Data__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__string__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__string___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Dictionary_string__string__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4293);
		    Mono_Security_ASN1__get_Item(&StringLiteral_22106);
		    Mono_Security_ASN1__get_Item(&StringLiteral_24213);
		    DAT_ram_00a57837 = '\x01';
		  }
		  uVar6 = *(undefined4 *)(param1 + 0x3c);
		  uVar2 = UI_Wiki_WikiUriRouter__SetData(*(undefined4 *)(*(int *)(param2 + 0x38) + 0x10),0);
		  Core_Extensions_Dict_AprDicExt__Get1024AssetId(uVar6,uVar2,0);
		  uVar2 = *(undefined4 *)(param1 + 0x44);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar6 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4293,1,0,1,0,0,0,0);
		  param1_00 = unnamed_function_1417(System_Collections_Generic_Dictionary_string__string__TypeInfo);
		  System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		            (param1_00,Method_System_Collections_Generic_Dictionary_string__string___ctor__);
		  uVar3 = Google_Protobuf_Collections_RepeatedField_object___GetEnumerator(param2,0);
		  System_Reflection_FieldInfo__get_IsStatic
		            (param1_00,StringLiteral_24213,uVar3,
		             Method_System_Collections_Generic_Dictionary_string__string__Add__);
		  uVar3 = System_Collections_Generic_Dictionary_object__object____ctor
		                    (*(undefined4 *)(param2 + 0x4c),0);
		  System_Reflection_FieldInfo__get_IsStatic
		            (param1_00,StringLiteral_22106,uVar3,
		             Method_System_Collections_Generic_Dictionary_string__string__Add__);
		  uVar6 = Core_GameLocalization__GetTranslation(uVar6,param1_00,0);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar2,uVar6,0);
		  if (param3[5] == 0) {
		    fVar5 = 0.0;
		  }
		  else {
		    fVar5 = func_ii_7103(param3[5],0);
		  }
		  param2_00 = 1.8446744e+19;
		  iVar4 = (**(code **)((ulonglong)*(uint *)(*param3 + 0x120) * 4))
		                    (param3,*(undefined4 *)(*param3 + 0x124));
		  if (iVar4 == 0) {
		    uVar1 = (**(code **)((ulonglong)*(uint *)(*param3 + 0x118) * 4))
		                      (param3,*(undefined4 *)(*param3 + 0x11c));
		    param2_00 = (float)uVar1;
		  }
		  uVar6 = *(undefined4 *)(param1 + 0x48);
		  uVar2 = Newtonsoft_Json_Converters_XDeclarationWrapper__get_Encoding(param3,0);
		  Gameplay_Combat_View_Players_CombatPlayerLevelView__HandleIsPreminumExpChanged(uVar6,uVar2,0);
		  uVar2 = *(undefined4 *)(param1 + 0x48);
		  fVar5 = UnityEngine_Camera__set_orthographicSize(fVar5,param2_00,0);
		  Gameplay_Combat_View_Players_CombatPlayerLevelView__SetRank(uVar2,1.0 - fVar5,0);
		  Gameplay_Combat_View_Players_CombatPlayerLevelView__get_IsPremiumExp
		            (*(undefined4 *)(param1 + 0x48),(uint)*(byte *)(param2 + 0x74),0);
		  Gameplay_UserInfo_View_CultView2__get_CultDic
		            (*(undefined4 *)(param1 + 0x4c),*(undefined4 *)(param2 + 0x4c),0);
		  return;
		}
		*/

}
