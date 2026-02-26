using System;
using Gameplay.Battles.Events;
using Gameplay.Battles.Model;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Battles.Controller
{
	// Token: 0x02000C2F RID: 3119
	[Token(Token = "0x2000C2F")]
	public class BattlesController : AbstractController<BattlesModel, BattlesEvents>
	{
		// Token: 0x06004C00 RID: 19456 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C00")]
		[Address(RVA = "0x9A44", Offset = "0x9A44", VA = "0x9A44")]
		public BattlesController(BattlesModel model, BattlesEvents events)
		{
		/* --- GHIDRA: .ctor ---
		undefined4 Gameplay_Battles_Controller_BattlesController___ctor(int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  int *param1_00;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a60977 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_UserIsleEvents__UserIsleModel__UserIsleController__UserBuildingTypes__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__BaseBuildingData__TryGetValue__);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a60977 = '\x01';
		  }
		  local_4 = 0;
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  param1_00 = *(int **)(iVar2 + 0xc);
		  iVar2 = *param1_00;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x110);
		        goto code_r0x81d076d4;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,10);
		code_r0x81d076d4:
		  iVar2 = (**(code **)((ulonglong)*puVar3 * 4))(param1_00,puVar3[1]);
		  uVar4 = UnityEngine_TextCore_LowLevel_LigatureSubstitutionRecord__get_componentGlyphIDs
		                    (*(undefined4 *)
		                      (*(int *)(*(int *)(*(int *)(iVar2 + 0x14) + 0x20) + 0x10) + 0x24),2,&local_4,
		                     Method_System_Collections_Generic_Dictionary_uint__BaseBuildingData__TryGetValue__
		                    );
		  return uVar4;
		}
		*/

		}

		// Token: 0x17000F54 RID: 3924
		// (get) Token: 0x06004C01 RID: 19457 RVA: 0x0000E040 File Offset: 0x0000C240
		[Token(Token = "0x17000F54")]
		private bool ArenaBuilt
		{
			[Token(Token = "0x6004C01")]
			[Address(RVA = "0x9A45", Offset = "0x9A45", VA = "0x9A45")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06004C02 RID: 19458 RVA: 0x0000E058 File Offset: 0x0000C258
		[Token(Token = "0x6004C02")]
		[Address(RVA = "0x9A46", Offset = "0x9A46", VA = "0x9A46")]
		public bool TryRunArenaEqualLevel()
		{
		/* --- GHIDRA: TryRunArenaEqualLevel ---
		undefined4
		Gameplay_Battles_Controller_BattlesController__TryRunArenaEqualLevel(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar2 = Gameplay_ArenaCombat_ArenaCombat__TryRun(*(undefined4 *)(iVar1 + 0xc),2,1,0,0);
		  return uVar2;
		}
		*/

			return default(bool);
		}

		// Token: 0x06004C03 RID: 19459 RVA: 0x0000E070 File Offset: 0x0000C270
		[Token(Token = "0x6004C03")]
		[Address(RVA = "0x9A47", Offset = "0x9A47", VA = "0x9A47")]
		public bool TryRunArenaEqualPower()
		{
		/* --- GHIDRA: TryRunArenaEqualPower ---
		void Gameplay_Battles_Controller_BattlesController__TryRunArenaEqualPower
		               (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *puVar3;
		  undefined4 param1_00;
		  int *param1_01;
		  
		  if (DAT_ram_00a60978 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a60978 = '\x01';
		  }
		  iVar2 = Gameplay_Battles_Controller_BattlesController___ctor(param1,param1);
		  if (iVar2 == 0) {
		    Gameplay_Battles_Controller_BattlesController__ShowWorldAxis(param1,param1);
		    return;
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar1 = 0;
		  param1_01 = *(int **)(iVar2 + 0xc);
		  iVar2 = *param1_01;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x1c0);
		        goto code_r0x81d07816;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,0x20);
		code_r0x81d07816:
		  param1_00 = (**(code **)((ulonglong)*puVar3 * 4))(param1_01,puVar3[1]);
		  Core_Gameplay_Managers_BlitzTournamentManager__Init(param1_00,0,0);
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x06004C04 RID: 19460 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C04")]
		[Address(RVA = "0x9A48", Offset = "0x9A48", VA = "0x9A48")]
		public void ShowArenaTournamentAdepts()
		{
		/* --- GHIDRA: ShowArenaTournamentAdepts ---
		void Gameplay_Battles_Controller_BattlesController__ShowArenaTournamentAdepts
		               (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *puVar3;
		  undefined4 param1_00;
		  int *param1_01;
		  
		  if (DAT_ram_00a60979 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a60979 = '\x01';
		  }
		  iVar2 = Gameplay_Battles_Controller_BattlesController___ctor(param1,param1);
		  if (iVar2 == 0) {
		    Gameplay_Battles_Controller_BattlesController__ShowWorldAxis(param1,param1);
		    return;
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar1 = 0;
		  param1_01 = *(int **)(iVar2 + 0xc);
		  iVar2 = *param1_01;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x1c8);
		        goto code_r0x81d07964;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,0x21);
		code_r0x81d07964:
		  param1_00 = (**(code **)((ulonglong)*puVar3 * 4))(param1_01,puVar3[1]);
		  Core_Gameplay_Managers_TournamentsManager__Init(param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x06004C05 RID: 19461 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C05")]
		[Address(RVA = "0x9A49", Offset = "0x9A49", VA = "0x9A49")]
		public void ShowArenaTournamentGladiators()
		{
		/* --- GHIDRA: ShowArenaTournamentGladiators ---
		void Gameplay_Battles_Controller_BattlesController__ShowArenaTournamentGladiators
		               (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *puVar3;
		  undefined4 param1_00;
		  int *param1_01;
		  
		  if (DAT_ram_00a6097a == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Rating_View_RatingWindow_RatingWindowArgs_TypeInfo);
		    DAT_ram_00a6097a = '\x01';
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  param1_01 = *(int **)(iVar2 + 0xc);
		  iVar2 = *param1_01;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x1b0);
		        goto code_r0x81d07a3c;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,0x1e);
		code_r0x81d07a3c:
		  param1_00 = (**(code **)((ulonglong)*puVar3 * 4))(param1_01,puVar3[1]);
		  iVar2 = unnamed_function_1417(Gameplay_Rating_View_RatingWindow_RatingWindowArgs_TypeInfo);
		  Gameplay_Rating_View_RatingWindow___ctor(iVar2,0);
		  *(undefined4 *)(iVar2 + 0x1c) = 6;
		  Core_Gameplay_Managers_GameActivityRouting_GameFeatureRouterManager__ShowRatingWindow
		            (param1_00,iVar2,0);
		  return;
		}
		*/

		}

		// Token: 0x06004C06 RID: 19462 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C06")]
		[Address(RVA = "0x9A4A", Offset = "0x9A4A", VA = "0x9A4A")]
		public void ShowMarshals()
		{
		/* --- GHIDRA: ShowMarshals ---
		void Gameplay_Battles_Controller_BattlesController__ShowMarshals(int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *puVar3;
		  undefined4 param1_00;
		  int *param1_01;
		  
		  if (DAT_ram_00a6097b == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a6097b = '\x01';
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  param1_01 = *(int **)(iVar2 + 0xc);
		  iVar2 = *param1_01;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x1e0);
		        goto code_r0x81d07b22;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,0x24);
		code_r0x81d07b22:
		  param1_00 = (**(code **)((ulonglong)*puVar3 * 4))(param1_01,puVar3[1]);
		  Core_Gameplay_Managers_BossManager__get_Name(param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x06004C07 RID: 19463 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C07")]
		[Address(RVA = "0x9A4B", Offset = "0x9A4B", VA = "0x9A4B")]
		public void ShowBosses()
		{
		/* --- GHIDRA: ShowBosses ---
		void Gameplay_Battles_Controller_BattlesController__ShowBosses(undefined4 param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a6097c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_VortexRating_View_VortexRatingWindow_VortexWindowArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12684);
		    DAT_ram_00a6097c = '\x01';
		  }
		  uVar1 = System_Uri___ctor(0);
		  uVar1 = System_Globalization_TimeSpanFormat_FormatLiterals__get_Start(uVar1,0);
		  param1_00 = unnamed_function_1417
		                        (Gameplay_VortexRating_View_VortexRatingWindow_VortexWindowArgs_TypeInfo);
		  Gameplay_AccountLinker_View_SelectUserWindow___ctor(param1_00,0);
		  UI_Windows_PopupController__set_TopWindow(uVar1,StringLiteral_12684,param1_00,0,0);
		  return;
		}
		*/

		}

		// Token: 0x06004C08 RID: 19464 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C08")]
		[Address(RVA = "0x9A4C", Offset = "0x9A4C", VA = "0x9A4C")]
		public void ShowVortex()
		{
		/* --- GHIDRA: ShowVortex ---
		void Gameplay_Battles_Controller_BattlesController__ShowVortex(undefined4 param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int param1_00;
		  
		  if (DAT_ram_00a6097d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_ThemeDuel_View_ThemeDuelWindow_ThemeDuelWindowArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12672);
		    DAT_ram_00a6097d = '\x01';
		  }
		  uVar1 = System_Uri___ctor(0);
		  uVar1 = System_Globalization_TimeSpanFormat_FormatLiterals__get_Start(uVar1,0);
		  param1_00 = unnamed_function_1417
		                        (Gameplay_ThemeDuel_View_ThemeDuelWindow_ThemeDuelWindowArgs_TypeInfo);
		  Gameplay_AccountLinker_View_SelectUserWindow___ctor(param1_00,0);
		  *(undefined4 *)(param1_00 + 0x10) = 0xb;
		  UI_Windows_PopupController__set_TopWindow(uVar1,StringLiteral_12672,param1_00,0,0);
		  return;
		}
		*/

		}

		// Token: 0x06004C09 RID: 19465 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C09")]
		[Address(RVA = "0x9A4D", Offset = "0x9A4D", VA = "0x9A4D")]
		public void ShowThemeDuel()
		{
		/* --- GHIDRA: ShowThemeDuel ---
		void Gameplay_Battles_Controller_BattlesController__ShowThemeDuel(int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *puVar3;
		  undefined4 param1_00;
		  int *param1_01;
		  
		  if (DAT_ram_00a6097e == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a6097e = '\x01';
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  param1_01 = *(int **)(iVar2 + 0xc);
		  iVar2 = *param1_01;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 600);
		        goto code_r0x81d07cac;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,0x33);
		code_r0x81d07cac:
		  param1_00 = (**(code **)((ulonglong)*puVar3 * 4))(param1_01,puVar3[1]);
		  Core_Gameplay_Managers_WorldAxisManager___ctor(param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x06004C0A RID: 19466 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C0A")]
		[Address(RVA = "0x9A4E", Offset = "0x9A4E", VA = "0x9A4E")]
		public void ShowWorldAxis()
		{
		/* --- GHIDRA: ShowWorldAxis ---
		void Gameplay_Battles_Controller_BattlesController__ShowWorldAxis
		               (undefined4 param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 param3;
		  
		  if (DAT_ram_00a6097f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2593);
		    DAT_ram_00a6097f = '\x01';
		  }
		  uVar1 = System_Uri___ctor(0);
		  uVar1 = System_Globalization_TimeSpanFormat_FormatLiterals__get_DayHourSep(uVar1,0);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  param3 = func_ii_7508(StringLiteral_2593,1,0,1,0,0,0,0);
		  Core_Application_App__get_ToastController(uVar1,1,param3,0);
		  return;
		}
		*/

		}

		// Token: 0x06004C0B RID: 19467 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C0B")]
		[Address(RVA = "0x9A4F", Offset = "0x9A4F", VA = "0x9A4F")]
		private void ShowBuildArenaToast()
		{
		/* --- GHIDRA: ShowBuildArenaToast ---
		void Gameplay_Battles_Controller_BattlesController__ShowBuildArenaToast
		               (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  uint *puVar4;
		  undefined4 uVar5;
		  int *piVar6;
		  int iVar7;
		  
		  if (DAT_ram_00a60980 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Battles_Controller_BattlesController_HandleBossTotalNotificationNumChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Battles_Controller_BattlesController_HandleUserLevelChangedEvent__);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a60980 = '\x01';
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar5 = *(undefined4 *)(iVar2 + 8);
		  uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar3,param1,
		             Method_Gameplay_Battles_Controller_BattlesController_HandleUserLevelChangedEvent__,0);
		  Core_Data_UserData__add_OnUserLevelChangedEvent(uVar5,uVar3,0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  piVar6 = *(int **)(iVar2 + 0xc);
		  iVar2 = *piVar6;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x1e0);
		        goto code_r0x81d07dcb;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x24);
		code_r0x81d07dcb:
		  iVar2 = (**(code **)((ulonglong)*puVar4 * 4))(piVar6,puVar4[1]);
		  iVar7 = *(int *)(iVar2 + 0x14);
		  uVar5 = *(undefined4 *)(iVar7 + 0x20);
		  uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar3,param1,
		             Method_Gameplay_Battles_Controller_BattlesController_HandleBossTotalNotificationNumChangedEvent__
		             ,0);
		  piVar6 = (int *)func_ii_7048(uVar5,uVar3,0);
		  iVar2 = System_Action_TypeInfo;
		  if (piVar6 == (int *)0x0) {
		    *(undefined4 *)(iVar7 + 0x20) = 0;
		  }
		  else if ((System_Action_TypeInfo != *piVar6) ||
		          (*(int **)(iVar7 + 0x20) = piVar6, *piVar6 != iVar2)) {
		    System_Activator__CreateInstance(piVar6,iVar2);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar1 = 0;
		  piVar6 = *(int **)(iVar2 + 0xc);
		  iVar2 = *piVar6;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x1e0);
		        goto code_r0x81d07ece;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x24);
		code_r0x81d07ece:
		  iVar2 = (**(code **)((ulonglong)*puVar4 * 4))(piVar6,puVar4[1]);
		  iVar2 = Gameplay_Boss_Model_BossModel__set_CurrentMinion(*(undefined4 *)(iVar2 + 0x18),0);
		  if (0 < iVar2) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    iVar7 = *(int *)(iVar2 + 0x1c);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    *(undefined4 *)(iVar2 + 0x1c) = 1;
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    if (iVar7 != *(int *)(iVar2 + 0x1c)) {
		      iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x114));
		      iVar2 = *(int *)(iVar2 + 0x14);
		      if (iVar2 != 0) {
		        (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		                  (*(undefined4 *)(iVar2 + 0x20),*(undefined4 *)(iVar2 + 0x14));
		      }
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004C0C RID: 19468 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C0C")]
		[Address(RVA = "0x9A50", Offset = "0x9A50", VA = "0x9A50", Slot = "6")]
		protected override void HandleStop()
		{
		/* --- GHIDRA: HandleStop ---
		void Gameplay_Battles_Controller_BattlesController__HandleStop(int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  uint *puVar4;
		  undefined4 uVar5;
		  int *piVar6;
		  int iVar7;
		  
		  if (DAT_ram_00a60981 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Battles_Controller_BattlesController_HandleBossTotalNotificationNumChangedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Battles_Controller_BattlesController_HandleUserLevelChangedEvent__);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a60981 = '\x01';
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar5 = *(undefined4 *)(iVar2 + 8);
		  uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar3,param1,
		             Method_Gameplay_Battles_Controller_BattlesController_HandleUserLevelChangedEvent__,0);
		  Core_Data_UserData__remove_UserSkillsChangedEvent(uVar5,uVar3,0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  piVar6 = *(int **)(iVar2 + 0xc);
		  iVar2 = *piVar6;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x1e0);
		        goto code_r0x81d0811b;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x24);
		code_r0x81d0811b:
		  iVar2 = (**(code **)((ulonglong)*puVar4 * 4))(piVar6,puVar4[1]);
		  iVar7 = *(int *)(iVar2 + 0x14);
		  uVar5 = *(undefined4 *)(iVar7 + 0x20);
		  uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar3,param1,
		             Method_Gameplay_Battles_Controller_BattlesController_HandleBossTotalNotificationNumChangedEvent__
		             ,0);
		  piVar6 = (int *)UnityEngine_UI_Image__set_sprite(uVar5,uVar3,0);
		  iVar2 = System_Action_TypeInfo;
		  if (piVar6 == (int *)0x0) {
		    *(undefined4 *)(iVar7 + 0x20) = 0;
		  }
		  else if ((System_Action_TypeInfo != *piVar6) ||
		          (*(int **)(iVar7 + 0x20) = piVar6, *piVar6 != iVar2)) {
		    System_Activator__CreateInstance(piVar6,iVar2);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004C0D RID: 19469 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C0D")]
		[Address(RVA = "0x9A51", Offset = "0x9A51", VA = "0x9A51", Slot = "7")]
		protected override void HandleRun()
		{
		/* --- GHIDRA: HandleRun ---
		void Gameplay_Battles_Controller_BattlesController__HandleRun(int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *puVar3;
		  int *param1_00;
		  int iVar4;
		  
		  if (DAT_ram_00a60982 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a60982 = '\x01';
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  param1_00 = *(int **)(iVar2 + 0xc);
		  iVar2 = *param1_00;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x1e0);
		        goto code_r0x81d0824c;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x24);
		code_r0x81d0824c:
		  iVar2 = (**(code **)((ulonglong)*puVar3 * 4))(param1_00,puVar3[1]);
		  iVar2 = Gameplay_Boss_Model_BossModel__set_CurrentMinion(*(undefined4 *)(iVar2 + 0x18),0);
		  if (0 < iVar2) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    iVar4 = *(int *)(iVar2 + 0x1c);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    *(undefined4 *)(iVar2 + 0x1c) = 1;
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    if (iVar4 != *(int *)(iVar2 + 0x1c)) {
		      iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x114));
		      iVar2 = *(int *)(iVar2 + 0x14);
		      if (iVar2 != 0) {
		        (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		                  (*(undefined4 *)(iVar2 + 0x20),*(undefined4 *)(iVar2 + 0x14));
		      }
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004C0E RID: 19470 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C0E")]
		[Address(RVA = "0x9A52", Offset = "0x9A52", VA = "0x9A52")]
		private void HandleBossTotalNotificationNumChangedEvent()
		{
		/* --- GHIDRA: HandleBossTotalNotificationNumChangedEvent ---
		void Gameplay_Battles_Controller_BattlesController__HandleBossTotalNotificationNumChangedEvent
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param2_00;
		  undefined4 param1_00;
		  int iVar2;
		  
		  if (DAT_ram_00a60983 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Contains_uint___);
		    DAT_ram_00a60983 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  param1_00 = *(undefined4 *)(iVar1 + 0x18);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  param2_00 = Core_Data_UserData__set_LevelDic(*(undefined4 *)(iVar1 + 8),0);
		  iVar1 = System_Linq_Enumerable__Contains_int_
		                    (param1_00,param2_00,Method_System_Linq_Enumerable_Contains_uint___);
		  if (iVar1 != 0) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    iVar2 = *(int *)(iVar1 + 0x1c);
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    *(undefined4 *)(iVar1 + 0x1c) = 1;
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    if (iVar2 != *(int *)(iVar1 + 0x1c)) {
		      iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x114));
		      iVar1 = *(int *)(iVar1 + 0x14);
		      if (iVar1 != 0) {
		        (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                  (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		      }
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004C0F RID: 19471 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C0F")]
		[Address(RVA = "0x9A53", Offset = "0x9A53", VA = "0x9A53")]
		private void HandleUserLevelChangedEvent()
		{
		/* --- GHIDRA: HandleUserLevelChangedEvent ---
		void Gameplay_Battles_Controller_BattlesController__HandleUserLevelChangedEvent
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  iVar2 = *(int *)(iVar1 + 0x1c);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  if (param2 < 1) {
		    param2 = 0;
		  }
		  *(int *)(iVar1 + 0x1c) = param2;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  if (iVar2 != *(int *)(iVar1 + 0x1c)) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar1 = *(int *)(iVar1 + 0x14);
		    if (iVar1 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004C10 RID: 19472 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C10")]
		[Address(RVA = "0x9A54", Offset = "0x9A54", VA = "0x9A54")]
		public void SetNotificationCount(int value)
		{
		/* --- GHIDRA: SetNotificationCount ---
		void Gameplay_Battles_Controller_BattlesController__SetNotificationCount
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5)
		
		{
		  if (DAT_ram_00a60984 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_BattlesModel__BattlesEvents__BattlesController__UserInterfaceView___ctor__
		              );
		    DAT_ram_00a60984 = '\x01';
		  }
		  Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		            (param1,param2,param3,param4,
		             Method_MVC_AbstractViewMediator_BattlesModel__BattlesEvents__BattlesController__UserInterfaceView___ctor__
		            );
		  return;
		}
		*/

		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_ArenaBuilt ---
		undefined4
		Gameplay_Battles_Controller_BattlesController__get_ArenaBuilt(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  uVar2 = Gameplay_ArenaCombat_ArenaCombat__TryRun(*(undefined4 *)(iVar1 + 0xc),1,1,0,0);
		  return uVar2;
		}
		*/

}
