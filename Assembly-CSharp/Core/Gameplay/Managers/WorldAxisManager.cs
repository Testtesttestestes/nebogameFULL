using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Gameplay.WorldAxis.Colossus.Combat;
using Gameplay.WorldAxis.Controller;
using Gameplay.WorldAxis.Events;
using Gameplay.WorldAxis.Model;
using Il2CppDummyDll;
using JetBrains.Annotations;
using Protocol.Common;

namespace Core.Gameplay.Managers
{
	// Token: 0x02001180 RID: 4480
	[Token(Token = "0x2001180")]
	public class WorldAxisManager : IGameManager, IBaseManager
	{
		// Token: 0x170015BC RID: 5564
		// (get) Token: 0x06006A3C RID: 27196 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170015BC")]
		public string Name
		{
			[Token(Token = "0x6006A3C")]
			[Address(RVA = "0xB55B", Offset = "0xB55B", VA = "0xB55B", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x140002AA RID: 682
		// (add) Token: 0x06006A3D RID: 27197 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006A3E RID: 27198 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002AA")]
		public event Action<IBaseManager> InitCompleteEvent
		{
			[Token(Token = "0x6006A3D")]
			[Address(RVA = "0xB55C", Offset = "0xB55C", VA = "0xB55C", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006A3E")]
			[Address(RVA = "0xB55D", Offset = "0xB55D", VA = "0xB55D", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140002AB RID: 683
		// (add) Token: 0x06006A3F RID: 27199 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006A40 RID: 27200 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002AB")]
		public event Action<IBaseManager> DeinitCompleteEvent
		{
			[Token(Token = "0x6006A3F")]
			[Address(RVA = "0xB55E", Offset = "0xB55E", VA = "0xB55E", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006A40")]
			[Address(RVA = "0xB55F", Offset = "0xB55F", VA = "0xB55F", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x170015BD RID: 5565
		// (get) Token: 0x06006A41 RID: 27201 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006A42 RID: 27202 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170015BD")]
		public IGame Game
		{
			[Token(Token = "0x6006A41")]
			[Address(RVA = "0xB560", Offset = "0xB560", VA = "0xB560")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006A42")]
			[Address(RVA = "0xB561", Offset = "0xB561", VA = "0xB561")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170015BE RID: 5566
		// (get) Token: 0x06006A43 RID: 27203 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006A44 RID: 27204 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170015BE")]
		public WorldAxisModel Model
		{
			[Token(Token = "0x6006A43")]
			[Address(RVA = "0xB562", Offset = "0xB562", VA = "0xB562")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006A44")]
			[Address(RVA = "0xB563", Offset = "0xB563", VA = "0xB563")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170015BF RID: 5567
		// (get) Token: 0x06006A45 RID: 27205 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006A46 RID: 27206 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170015BF")]
		public WorldAxisEvents Events
		{
			[Token(Token = "0x6006A45")]
			[Address(RVA = "0xB564", Offset = "0xB564", VA = "0xB564")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006A46")]
			[Address(RVA = "0xB565", Offset = "0xB565", VA = "0xB565")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170015C0 RID: 5568
		// (get) Token: 0x06006A47 RID: 27207 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006A48 RID: 27208 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170015C0")]
		public WorldAxisController Controller
		{
			[Token(Token = "0x6006A47")]
			[Address(RVA = "0xB566", Offset = "0xB566", VA = "0xB566")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006A48")]
			[Address(RVA = "0xB567", Offset = "0xB567", VA = "0xB567")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170015C1 RID: 5569
		// (get) Token: 0x06006A49 RID: 27209 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170015C1")]
		public ResourceSet AttackPrice
		{
			[Token(Token = "0x6006A49")]
			[Address(RVA = "0xB568", Offset = "0xB568", VA = "0xB568")]
			get
			{
				return null;
			}
		}

		// Token: 0x170015C2 RID: 5570
		// (get) Token: 0x06006A4A RID: 27210 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170015C2")]
		public ResourceSet DefencePrice
		{
			[Token(Token = "0x6006A4A")]
			[Address(RVA = "0xB569", Offset = "0xB569", VA = "0xB569")]
			get
			{
				return null;
			}
		}

		// Token: 0x06006A4B RID: 27211 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A4B")]
		[Address(RVA = "0xB56A", Offset = "0xB56A", VA = "0xB56A")]
		public WorldAxisManager([NotNull] IGame game)
		{
		/* --- GHIDRA: .ctor ---
		void Core_Gameplay_Managers_WorldAxisManager___ctor(undefined4 param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a63880 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_WorldAxis_Office_View_WorldAxisOfficeWindow_WorldAxisOfficeWindowArgs_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&StringLiteral_12687);
		    DAT_ram_00a63880 = '\x01';
		  }
		  uVar1 = System_Uri___ctor(0);
		  uVar1 = System_Globalization_TimeSpanFormat_FormatLiterals__get_Start(uVar1,0);
		  param1_00 = unnamed_function_1417
		                        (
		                        Gameplay_WorldAxis_Office_View_WorldAxisOfficeWindow_WorldAxisOfficeWindowArgs_TypeInfo
		                        );
		  Gameplay_AccountLinker_View_SelectUserWindow___ctor(param1_00,0);
		  UI_Windows_PopupController__set_TopWindow(uVar1,StringLiteral_12687,param1_00,0,0);
		  return;
		}
		*/

		}

		// Token: 0x06006A4C RID: 27212 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A4C")]
		[Address(RVA = "0xB56B", Offset = "0xB56B", VA = "0xB56B")]
		public void ShowWorldAxisWindow()
		{
		/* --- GHIDRA: ShowWorldAxisWindow ---
		void Core_Gameplay_Managers_WorldAxisManager__ShowWorldAxisWindow
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int param1_00;
		  
		  if (DAT_ram_00a63881 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_WorldAxis_ColossusInfo_View_ColossusInfoWindow_ColossusInfoWindowArgs_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&StringLiteral_12686);
		    DAT_ram_00a63881 = '\x01';
		  }
		  uVar1 = System_Uri___ctor(0);
		  uVar1 = System_Globalization_TimeSpanFormat_FormatLiterals__get_Start(uVar1,0);
		  param1_00 = unnamed_function_1417
		                        (
		                        Gameplay_WorldAxis_ColossusInfo_View_ColossusInfoWindow_ColossusInfoWindowArgs_TypeInfo
		                        );
		  Gameplay_AccountLinker_View_SelectUserWindow___ctor(param1_00,0);
		  *(undefined4 *)(param1_00 + 0x1c) = param2;
		  *(undefined4 *)(param1_00 + 0x20) = *(undefined4 *)(param1 + 0x1c);
		  UI_Windows_PopupController__set_TopWindow(uVar1,StringLiteral_12686,param1_00,0,0);
		  return;
		}
		*/

		}

		// Token: 0x06006A4D RID: 27213 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A4D")]
		[Address(RVA = "0xB56C", Offset = "0xB56C", VA = "0xB56C")]
		public void ShowColossusInfoWindow(ColossusBattleData data)
		{
		/* --- GHIDRA: ShowColossusInfoWindow ---
		void Core_Gameplay_Managers_WorldAxisManager__ShowColossusInfoWindow(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  Gameplay_WorldAxis_Colossus_Combat_ColossusCombatLauncher__Stop(*(undefined4 *)(param1 + 0x20),0);
		  MVC_AbstractController__Run(*(undefined4 *)(param1 + 0x1c),0);
		  iVar1 = **(int **)(param1 + 0x1c);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xe8) * 4))
		            (*(int **)(param1 + 0x1c),*(undefined4 *)(iVar1 + 0xec));
		  iVar1 = **(int **)(param1 + 0x14);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xe8) * 4))
		            (*(int **)(param1 + 0x14),*(undefined4 *)(iVar1 + 0xec));
		  *(undefined4 *)(param1 + 0x20) = 0;
		  *(undefined8 *)(param1 + 0x18) = 0;
		  *(undefined8 *)(param1 + 0x10) = 0;
		  iVar1 = *(int *)(param1 + 0xc);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),param1,*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06006A4E RID: 27214 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A4E")]
		[Address(RVA = "0xB56D", Offset = "0xB56D", VA = "0xB56D", Slot = "9")]
		public void Deinit()
		{
		/* --- GHIDRA: Deinit ---
		void Core_Gameplay_Managers_WorldAxisManager__Deinit(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  undefined4 uVar5;
		  undefined4 param1_00;
		  undefined4 uVar6;
		  int *piVar7;
		  int iVar8;
		  int iVar9;
		  
		  if (DAT_ram_00a63882 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_WorldAxis_Controller_WorldAxisController_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_WorldAxis_Events_WorldAxisEvents_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Gameplay_Managers_WorldAxisManager_InitEventHandler__)
		    ;
		    Mono_Security_ASN1__get_Item(&Gameplay_WorldAxis_Model_WorldAxisModel_TypeInfo);
		    DAT_ram_00a63882 = '\x01';
		  }
		  uVar6 = *(undefined4 *)(param1 + 0x20);
		  piVar7 = *(int **)(param1 + 0x10);
		  iVar8 = *piVar7;
		  if (*(ushort *)(iVar8 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + iVar8 + 0x140);
		        goto code_r0x8230b5f7;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar7,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x8230b5f7:
		  uVar2 = 0;
		  iVar8 = (**(code **)((ulonglong)*puVar3 * 4))(piVar7,puVar3[1]);
		  if (*(int *)(iVar8 + 0x14) != 0) {
		    uVar2 = *(undefined4 *)(*(int *)(iVar8 + 0x14) + 8);
		  }
		  piVar7 = *(int **)(param1 + 0x10);
		  iVar8 = *piVar7;
		  if (*(ushort *)(iVar8 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + iVar8 + 0x238);
		        goto code_r0x8230b68d;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar7,Core_Gameplay_IGame_TypeInfo,0x2f);
		code_r0x8230b68d:
		  uVar1 = 0;
		  uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(piVar7,puVar3[1]);
		  piVar7 = *(int **)(param1 + 0x10);
		  iVar8 = *piVar7;
		  if (*(ushort *)(iVar8 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + iVar8 + 0x178);
		        goto code_r0x8230b712;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar7,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x8230b712:
		  uVar1 = 0;
		  uVar5 = (**(code **)((ulonglong)*puVar3 * 4))(piVar7,puVar3[1]);
		  param1_00 = unnamed_function_1417(Gameplay_WorldAxis_Model_WorldAxisModel_TypeInfo);
		  Gameplay_WorldAxis_Model_WorldAxisModel__Dispose(param1_00,uVar6,uVar2,uVar4,uVar5,0);
		  *(undefined4 *)(param1 + 0x14) = param1_00;
		  uVar6 = unnamed_function_1417(Gameplay_WorldAxis_Events_WorldAxisEvents_TypeInfo);
		  *(undefined4 *)(param1 + 0x18) = uVar6;
		  uVar2 = *(undefined4 *)(param1 + 0x14);
		  piVar7 = *(int **)(param1 + 0x10);
		  iVar8 = *piVar7;
		  if (*(ushort *)(iVar8 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + iVar8 + 0x230);
		        goto code_r0x8230b7d2;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar7,Core_Gameplay_IGame_TypeInfo,0x2e);
		code_r0x8230b7d2:
		  iVar8 = (**(code **)((ulonglong)*puVar3 * 4))(piVar7,puVar3[1]);
		  uVar5 = *(undefined4 *)(iVar8 + 0x14);
		  uVar4 = unnamed_function_1417(Gameplay_WorldAxis_Controller_WorldAxisController_TypeInfo);
		  Gameplay_WorldAxis_Events_WorldAxisEvents___ctor(uVar4,uVar2,uVar6,uVar5,0);
		  *(undefined4 *)(param1 + 0x1c) = uVar4;
		  iVar9 = *(int *)(param1 + 0x18);
		  uVar2 = *(undefined4 *)(iVar9 + 8);
		  uVar6 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar6,param1,Method_Core_Gameplay_Managers_WorldAxisManager_InitEventHandler__,0);
		  piVar7 = (int *)UnityEngine_UI_Image__set_sprite(uVar2,uVar6,0);
		  iVar8 = System_Action_TypeInfo;
		  if (piVar7 == (int *)0x0) {
		    *(undefined4 *)(iVar9 + 8) = 0;
		  }
		  else if ((System_Action_TypeInfo != *piVar7) || (*(int **)(iVar9 + 8) = piVar7, *piVar7 != iVar8))
		  {
		    System_Activator__CreateInstance(piVar7,iVar8);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  MVC_AbstractController__Dispose(*(undefined4 *)(param1 + 0x1c),0);
		  Gameplay_WorldAxis_Colossus_Combat_ColossusCombatLauncher___ctor(*(undefined4 *)(param1 + 0x20),0)
		  ;
		  return;
		}
		*/

		}

		// Token: 0x06006A4F RID: 27215 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A4F")]
		[Address(RVA = "0xB56E", Offset = "0xB56E", VA = "0xB56E", Slot = "8")]
		public void Init()
		{
		/* --- GHIDRA: Init ---
		void Core_Gameplay_Managers_WorldAxisManager__Init(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  int *param1_01;
		  int iVar1;
		  undefined4 param1_02;
		  int iVar2;
		  
		  if (DAT_ram_00a63883 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Gameplay_Managers_WorldAxisManager_InitEventHandler__)
		    ;
		    DAT_ram_00a63883 = '\x01';
		  }
		  iVar1 = *(int *)(param1 + 0x18);
		  param1_02 = *(undefined4 *)(iVar1 + 8);
		  param1_00 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (param1_00,param1,Method_Core_Gameplay_Managers_WorldAxisManager_InitEventHandler__,0);
		  param1_01 = (int *)func_ii_7048(param1_02,param1_00,0);
		  iVar2 = System_Action_TypeInfo;
		  if (param1_01 == (int *)0x0) {
		    *(undefined4 *)(iVar1 + 8) = 0;
		  }
		  else if ((System_Action_TypeInfo != *param1_01) ||
		          (*(int **)(iVar1 + 8) = param1_01, *param1_01 != iVar2)) {
		    System_Activator__CreateInstance(param1_01,iVar2);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar2 = *(int *)(param1 + 8);
		  if (iVar2 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		              (*(undefined4 *)(iVar2 + 0x20),param1,*(undefined4 *)(iVar2 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06006A50 RID: 27216 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A50")]
		[Address(RVA = "0xB56F", Offset = "0xB56F", VA = "0xB56F")]
		private void InitEventHandler()
		{
		}

		// Token: 0x04003844 RID: 14404
		[Token(Token = "0x4003844")]
		[FieldOffset(Offset = "0x20")]
		private ColossusCombatLauncher _colossusCombatLauncher;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Name ---
		void Core_Gameplay_Managers_WorldAxisManager__get_Name
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a6387b == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a6387b = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 8);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_IBaseManager__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IBaseManager__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 8,iVar2,param1_00);
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


		/* --- GHIDRA: add_InitCompleteEvent ---
		void Core_Gameplay_Managers_WorldAxisManager__add_InitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a6387c == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a6387c = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 8);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_IBaseManager__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IBaseManager__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 8,iVar2,param1_00);
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


		/* --- GHIDRA: remove_InitCompleteEvent ---
		void Core_Gameplay_Managers_WorldAxisManager__remove_InitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a6387d == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a6387d = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0xc);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_IBaseManager__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IBaseManager__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0xc,iVar2,param1_00);
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


		/* --- GHIDRA: add_DeinitCompleteEvent ---
		void Core_Gameplay_Managers_WorldAxisManager__add_DeinitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a6387e == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a6387e = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0xc);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_IBaseManager__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IBaseManager__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0xc,iVar2,param1_00);
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


		/* --- GHIDRA: set_Controller ---
		undefined4 Core_Gameplay_Managers_WorldAxisManager__set_Controller(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = Gameplay_WorldAxis_Model_WorldAxisModel__set_SelectedParty
		                    (*(undefined4 *)(param1 + 0x14),0);
		  return uVar1;
		}
		*/


		/* --- GHIDRA: get_AttackPrice ---
		undefined4 Core_Gameplay_Managers_WorldAxisManager__get_AttackPrice(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  uVar1 = Gameplay_WorldAxis_Model_WorldAxisModel__get_AttackPrice(*(undefined4 *)(param1 + 0x14),0)
		  ;
		  return uVar1;
		}
		*/


		/* --- GHIDRA: get_DefencePrice ---
		void Core_Gameplay_Managers_WorldAxisManager__get_DefencePrice
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param3_00;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a6387f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_WorldAxis_Colossus_Combat_ColossusCombatLauncher_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_PartyCombatService___);
		    Mono_Security_ASN1__get_Item(&Core_Net_ServiceFactory_TypeInfo);
		    DAT_ram_00a6387f = '\x01';
		  }
		  *(undefined4 *)(param1 + 0x10) = param2;
		  if (*(int *)(Core_Net_ServiceFactory_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_ServiceFactory_TypeInfo);
		  }
		  param3_00 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                        (Method_Core_Net_ServiceFactory_GetService_PartyCombatService___);
		  param1_00 = unnamed_function_1417
		                        (Gameplay_WorldAxis_Colossus_Combat_ColossusCombatLauncher_TypeInfo);
		  UnityEngine_Purchasing_Default_Factory__Create(param1_00,param2,param3_00,0);
		  *(undefined4 *)(param1 + 0x20) = param1_00;
		  return;
		}
		*/

}
