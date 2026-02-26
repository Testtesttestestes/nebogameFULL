using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Core.Gameplay
{
	// Token: 0x02001121 RID: 4385
	[Token(Token = "0x2001121")]
	public class Game
	{
		// Token: 0x170014E6 RID: 5350
		// (get) Token: 0x060066B3 RID: 26291 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060066B4 RID: 26292 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170014E6")]
		public static IGame Instance
		{
			[Token(Token = "0x60066B3")]
			[Address(RVA = "0xB232", Offset = "0xB232", VA = "0xB232")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60066B4")]
			[Address(RVA = "0xB233", Offset = "0xB233", VA = "0xB233")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060066B5 RID: 26293 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60066B5")]
		[Address(RVA = "0xB234", Offset = "0xB234", VA = "0xB234")]
		public Game()
		{
		/* --- GHIDRA: .ctor ---
		void Core_Gameplay_Game___ctor(int param1,undefined4 param2)
		
		{
		  undefined4 in_register_20000004;
		  undefined4 uVar1;
		  int iVar2;
		  uint *puVar3;
		  float param4;
		  int iVar4;
		  uint uVar5;
		  undefined4 uVar6;
		  int iVar7;
		  int *param1_00;
		  
		  if (DAT_ram_00a5a922 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_AccountsManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_AdManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_AnnouncementsManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_AprsManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_ArtifactDropManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_Prefetch_AssetsPrefetchManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_AssistantsManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_Audio_AudioManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_BankManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_BattlesManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_Billing_BillingManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_BlitzTournamentManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_BossManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_CacheManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_ChatManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_ClanWarsManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_ClansManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_ClientStateManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_ClientStateResolver_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_CollectionsManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_CompetitionManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_DailyQuestsManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_DictManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_DiscountsManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_DuelManager_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Core_Gameplay_Managers_EndlessPaymentOptionsList_EndlessPaymentOptionsListManager_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_ExperimentsManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_Skins_Skin_Factory_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_FrescoManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_GameEventsManager_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Core_Gameplay_Managers_GameActivityRouting_GameFeatureRouterManager_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Core_Gameplay_Managers_Notifications_GameNotificationsManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_GdEvents_GdEventsManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_Inventory_GolemInventoryManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_Tutorial_Guide_GuideManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_InitCompleteManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_Inventory_InventoryManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_Location_LocationManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_MedalsManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_PopupScheduleManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_PortalsManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_ProgressSaverManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_PurchaseConsumeManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_RateGameManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_Requirements_RequirementsManager_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Core_Gameplay_Managers_GameActivityRouting_RoutingManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_SchoolManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_ServerTimeManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_ShopManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_Skins_SkinManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_SmallGamesManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_SpecialOffersManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_ThemeDuelStateManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Utils_TimeUtils_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_TournamentsManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_UserManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_WorldAxisManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_WorldManager_TypeInfo);
		    DAT_ram_00a5a922 = '\x01';
		  }
		  Core_Gameplay_AbstractGame__set_ExperimentsManager(param1,param1);
		  uVar1 = unnamed_function_1417(Core_Gameplay_Managers_ServerTimeManager_TypeInfo);
		  Core_Gameplay_Managers_ServerTimeManager__get_CurrentTime(uVar1,param1,0);
		  *(undefined4 *)(param1 + 0xd8) = uVar1;
		  if (DAT_ram_00a5a8fd == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IGameManager__Add__);
		    DAT_ram_00a5a8fd = '\x01';
		  }
		  iVar2 = Method_System_Collections_Generic_List_IGameManager__Add__;
		  iVar4 = *(int *)(param1 + 0x18);
		  *(int *)(iVar4 + 0x10) = *(int *)(iVar4 + 0x10) + 1;
		  uVar5 = *(uint *)(iVar4 + 0xc);
		  if (uVar5 < *(uint *)(*(int *)(iVar4 + 8) + 0xc)) {
		    *(uint *)(iVar4 + 0xc) = uVar5 + 1;
		    *(undefined4 *)(*(int *)(iVar4 + 8) + uVar5 * 4 + 0x10) = uVar1;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar4,uVar1,*(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x60) + 0x38));
		  }
		  uVar6 = *(undefined4 *)(param1 + 0x10);
		  uVar1 = unnamed_function_1417(Core_Gameplay_Managers_DictManager_TypeInfo);
		  Core_Gameplay_Managers_DictManager__set_WrappersStorage(uVar1,uVar6,0);
		  *(undefined4 *)(param1 + 0x54) = uVar1;
		  if (DAT_ram_00a5a8fd == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IGameManager__Add__);
		    DAT_ram_00a5a8fd = '\x01';
		  }
		  iVar2 = Method_System_Collections_Generic_List_IGameManager__Add__;
		  iVar4 = *(int *)(param1 + 0x18);
		  *(int *)(iVar4 + 0x10) = *(int *)(iVar4 + 0x10) + 1;
		  uVar5 = *(uint *)(iVar4 + 0xc);
		  if (uVar5 < *(uint *)(*(int *)(iVar4 + 8) + 0xc)) {
		    *(uint *)(iVar4 + 0xc) = uVar5 + 1;
		    *(undefined4 *)(*(int *)(iVar4 + 8) + uVar5 * 4 + 0x10) = uVar1;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar4,uVar1,*(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x60) + 0x38));
		  }
		  iVar2 = unnamed_function_1417(Core_Gameplay_Managers_CacheManager_TypeInfo);
		  *(int *)(iVar2 + 8) = param1;
		  *(int *)(param1 + 0x44) = iVar2;
		  if (DAT_ram_00a5a8fd == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IGameManager__Add__);
		    DAT_ram_00a5a8fd = '\x01';
		  }
		  iVar4 = Method_System_Collections_Generic_List_IGameManager__Add__;
		  iVar7 = *(int *)(param1 + 0x18);
		  *(int *)(iVar7 + 0x10) = *(int *)(iVar7 + 0x10) + 1;
		  uVar5 = *(uint *)(iVar7 + 0xc);
		  if (uVar5 < *(uint *)(*(int *)(iVar7 + 8) + 0xc)) {
		    *(uint *)(iVar7 + 0xc) = uVar5 + 1;
		    *(int *)(*(int *)(iVar7 + 8) + uVar5 * 4 + 0x10) = iVar2;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar7,iVar2,*(undefined4 *)(*(int *)(*(int *)(iVar4 + 0x10) + 0x60) + 0x38));
		  }
		  uVar1 = unnamed_function_1417(Core_Gameplay_Managers_UserManager_TypeInfo);
		  Unity_Services_Core_Registration_CorePackageInitializer__get_DiagnosticsFactory(uVar1,param1,0);
		  *(undefined4 *)(param1 + 0x38) = uVar1;
		  if (DAT_ram_00a5a8fd == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IGameManager__Add__);
		    DAT_ram_00a5a8fd = '\x01';
		  }
		  iVar2 = Method_System_Collections_Generic_List_IGameManager__Add__;
		  iVar4 = *(int *)(param1 + 0x18);
		  *(int *)(iVar4 + 0x10) = *(int *)(iVar4 + 0x10) + 1;
		  uVar5 = *(uint *)(iVar4 + 0xc);
		  if (uVar5 < *(uint *)(*(int *)(iVar4 + 8) + 0xc)) {
		    *(uint *)(iVar4 + 0xc) = uVar5 + 1;
		    *(undefined4 *)(*(int *)(iVar4 + 8) + uVar5 * 4 + 0x10) = uVar1;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar4,uVar1,*(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x60) + 0x38));
		  }
		  uVar1 = unnamed_function_1417(Core_Gameplay_Managers_DiscountsManager_TypeInfo);
		  Core_Gameplay_Managers_DiscountsManager__set_Events(uVar1,param1,0);
		  *(undefined4 *)(param1 + 200) = uVar1;
		  if (DAT_ram_00a5a8fd == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IGameManager__Add__);
		    DAT_ram_00a5a8fd = '\x01';
		  }
		  iVar2 = Method_System_Collections_Generic_List_IGameManager__Add__;
		  iVar4 = *(int *)(param1 + 0x18);
		  *(int *)(iVar4 + 0x10) = *(int *)(iVar4 + 0x10) + 1;
		  uVar5 = *(uint *)(iVar4 + 0xc);
		  if (uVar5 < *(uint *)(*(int *)(iVar4 + 8) + 0xc)) {
		    *(uint *)(iVar4 + 0xc) = uVar5 + 1;
		    *(undefined4 *)(*(int *)(iVar4 + 8) + uVar5 * 4 + 0x10) = uVar1;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar4,uVar1,*(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x60) + 0x38));
		  }
		  uVar1 = unnamed_function_1417(Core_Gameplay_Managers_ClansManager_TypeInfo);
		  *(undefined4 *)(param1 + 0xc0) = uVar1;
		  if (DAT_ram_00a5a8fd == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IGameManager__Add__);
		    DAT_ram_00a5a8fd = '\x01';
		  }
		  iVar2 = Method_System_Collections_Generic_List_IGameManager__Add__;
		  iVar4 = *(int *)(param1 + 0x18);
		  *(int *)(iVar4 + 0x10) = *(int *)(iVar4 + 0x10) + 1;
		  uVar5 = *(uint *)(iVar4 + 0xc);
		  if (uVar5 < *(uint *)(*(int *)(iVar4 + 8) + 0xc)) {
		    *(uint *)(iVar4 + 0xc) = uVar5 + 1;
		    *(undefined4 *)(*(int *)(iVar4 + 8) + uVar5 * 4 + 0x10) = uVar1;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar4,uVar1,*(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x60) + 0x38));
		  }
		  iVar2 = unnamed_function_1417(Core_Gameplay_Managers_AccountsManager_TypeInfo);
		  *(int *)(iVar2 + 0x10) = param1;
		  *(int *)(param1 + 0xa8) = iVar2;
		  if (DAT_ram_00a5a8fd == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IGameManager__Add__);
		    DAT_ram_00a5a8fd = '\x01';
		  }
		  iVar4 = Method_System_Collections_Generic_List_IGameManager__Add__;
		  iVar7 = *(int *)(param1 + 0x18);
		  *(int *)(iVar7 + 0x10) = *(int *)(iVar7 + 0x10) + 1;
		  uVar5 = *(uint *)(iVar7 + 0xc);
		  if (uVar5 < *(uint *)(*(int *)(iVar7 + 8) + 0xc)) {
		    *(uint *)(iVar7 + 0xc) = uVar5 + 1;
		    *(int *)(*(int *)(iVar7 + 8) + uVar5 * 4 + 0x10) = iVar2;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar7,iVar2,*(undefined4 *)(*(int *)(*(int *)(iVar4 + 0x10) + 0x60) + 0x38));
		  }
		  uVar5 = 0;
		  param1_00 = *(int **)(param1 + 0x10);
		  iVar2 = *param1_00;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar5 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar5 * 8 + 4) * 8 + iVar2 + 0x160);
		        goto code_r0x8129281f;
		      }
		      uVar5 = uVar5 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar5);
		  }
		  puVar3 = (uint *)func_ii_1080(param1_00,Core_Application_IApp_TypeInfo,0x14);
		code_r0x8129281f:
		  iVar2 = (**(code **)((ulonglong)*puVar3 * 4))(CONCAT44(in_register_20000004,param1_00),puVar3[1]);
		  uVar6 = *(undefined4 *)(iVar2 + 0x14);
		  uVar1 = unnamed_function_1417(Core_Gameplay_Managers_Billing_BillingManager_TypeInfo);
		  Core_Gameplay_Managers_Billing_BillingManager__set_Model(uVar1,param1,uVar6,0);
		  *(undefined4 *)(param1 + 0x60) = uVar1;
		  if (DAT_ram_00a5a8fd == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IGameManager__Add__);
		    DAT_ram_00a5a8fd = '\x01';
		  }
		  iVar2 = Method_System_Collections_Generic_List_IGameManager__Add__;
		  iVar4 = *(int *)(param1 + 0x18);
		  *(int *)(iVar4 + 0x10) = *(int *)(iVar4 + 0x10) + 1;
		  uVar5 = *(uint *)(iVar4 + 0xc);
		  if (uVar5 < *(uint *)(*(int *)(iVar4 + 8) + 0xc)) {
		    *(uint *)(iVar4 + 0xc) = uVar5 + 1;
		    *(undefined4 *)(*(int *)(iVar4 + 8) + uVar5 * 4 + 0x10) = uVar1;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar4,uVar1,*(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x60) + 0x38));
		  }
		  uVar1 = unnamed_function_1417(Core_Gameplay_Managers_Requirements_RequirementsManager_TypeInfo);
		  *(undefined4 *)(param1 + 0x48) = uVar1;
		  if (DAT_ram_00a5a8fd == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IGameManager__Add__);
		    DAT_ram_00a5a8fd = '\x01';
		  }
		  iVar2 = Method_System_Collections_Generic_List_IGameManager__Add__;
		  iVar4 = *(int *)(param1 + 0x18);
		  *(int *)(iVar4 + 0x10) = *(int *)(iVar4 + 0x10) + 1;
		  uVar5 = *(uint *)(iVar4 + 0xc);
		  if (uVar5 < *(uint *)(*(int *)(iVar4 + 8) + 0xc)) {
		    *(uint *)(iVar4 + 0xc) = uVar5 + 1;
		    *(undefined4 *)(*(int *)(iVar4 + 8) + uVar5 * 4 + 0x10) = uVar1;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar4,uVar1,*(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x60) + 0x38));
		  }
		  uVar1 = unnamed_function_1417(Core_Gameplay_Managers_Inventory_InventoryManager_TypeInfo);
		  Core_Gameplay_Managers_Inventory_InventoryManager__set_ComparerEvents(uVar1,param1,0);
		  *(undefined4 *)(param1 + 0x2c) = uVar1;
		  if (DAT_ram_00a5a8fd == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IGameManager__Add__);
		    DAT_ram_00a5a8fd = '\x01';
		  }
		  iVar2 = Method_System_Collections_Generic_List_IGameManager__Add__;
		  iVar4 = *(int *)(param1 + 0x18);
		  *(int *)(iVar4 + 0x10) = *(int *)(iVar4 + 0x10) + 1;
		  uVar5 = *(uint *)(iVar4 + 0xc);
		  if (uVar5 < *(uint *)(*(int *)(iVar4 + 8) + 0xc)) {
		    *(uint *)(iVar4 + 0xc) = uVar5 + 1;
		    *(undefined4 *)(*(int *)(iVar4 + 8) + uVar5 * 4 + 0x10) = uVar1;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar4,uVar1,*(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x60) + 0x38));
		  }
		  uVar1 = unnamed_function_1417(Core_Gameplay_Managers_ClanWarsManager_TypeInfo);
		  *(undefined4 *)(param1 + 0xc4) = uVar1;
		  if (DAT_ram_00a5a8fd == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IGameManager__Add__);
		    DAT_ram_00a5a8fd = '\x01';
		  }
		  iVar2 = Method_System_Collections_Generic_List_IGameManager__Add__;
		  iVar4 = *(int *)(param1 + 0x18);
		  *(int *)(iVar4 + 0x10) = *(int *)(iVar4 + 0x10) + 1;
		  uVar5 = *(uint *)(iVar4 + 0xc);
		  if (uVar5 < *(uint *)(*(int *)(iVar4 + 8) + 0xc)) {
		    *(uint *)(iVar4 + 0xc) = uVar5 + 1;
		    *(undefined4 *)(*(int *)(iVar4 + 8) + uVar5 * 4 + 0x10) = uVar1;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar4,uVar1,*(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x60) + 0x38));
		  }
		  uVar1 = unnamed_function_1417(Core_Gameplay_Managers_SchoolManager_TypeInfo);
		  *(undefined4 *)(param1 + 0x90) = uVar1;
		  if (DAT_ram_00a5a8fd == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IGameManager__Add__);
		    DAT_ram_00a5a8fd = '\x01';
		  }
		  iVar2 = Method_System_Collections_Generic_List_IGameManager__Add__;
		  iVar4 = *(int *)(param1 + 0x18);
		  *(int *)(iVar4 + 0x10) = *(int *)(iVar4 + 0x10) + 1;
		  uVar5 = *(uint *)(iVar4 + 0xc);
		  if (uVar5 < *(uint *)(*(int *)(iVar4 + 8) + 0xc)) {
		    *(uint *)(iVar4 + 0xc) = uVar5 + 1;
		    *(undefined4 *)(*(int *)(iVar4 + 8) + uVar5 * 4 + 0x10) = uVar1;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar4,uVar1,*(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x60) + 0x38));
		  }
		  uVar1 = unnamed_function_1417(Core_Gameplay_Managers_MedalsManager_TypeInfo);
		  *(undefined4 *)(param1 + 0x30) = uVar1;
		  if (DAT_ram_00a5a8fd == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IGameManager__Add__);
		    DAT_ram_00a5a8fd = '\x01';
		  }
		  iVar2 = Method_System_Collections_Generic_List_IGameManager__Add__;
		  iVar4 = *(int *)(param1 + 0x18);
		  *(int *)(iVar4 + 0x10) = *(int *)(iVar4 + 0x10) + 1;
		  uVar5 = *(uint *)(iVar4 + 0xc);
		  if (uVar5 < *(uint *)(*(int *)(iVar4 + 8) + 0xc)) {
		    *(uint *)(iVar4 + 0xc) = uVar5 + 1;
		    *(undefined4 *)(*(int *)(iVar4 + 8) + uVar5 * 4 + 0x10) = uVar1;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar4,uVar1,*(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x60) + 0x38));
		  }
		  uVar1 = unnamed_function_1417(Core_Gameplay_Managers_CollectionsManager_TypeInfo);
		  Unity_Services_Core_Environments_Internal_Environments__get_Current(uVar1,param1,0);
		  *(undefined4 *)(param1 + 0xe0) = uVar1;
		  if (DAT_ram_00a5a8fd == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IGameManager__Add__);
		    DAT_ram_00a5a8fd = '\x01';
		  }
		  iVar2 = Method_System_Collections_Generic_List_IGameManager__Add__;
		  iVar4 = *(int *)(param1 + 0x18);
		  *(int *)(iVar4 + 0x10) = *(int *)(iVar4 + 0x10) + 1;
		  uVar5 = *(uint *)(iVar4 + 0xc);
		  if (uVar5 < *(uint *)(*(int *)(iVar4 + 8) + 0xc)) {
		    *(uint *)(iVar4 + 0xc) = uVar5 + 1;
		    *(undefined4 *)(*(int *)(iVar4 + 8) + uVar5 * 4 + 0x10) = uVar1;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar4,uVar1,*(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x60) + 0x38));
		  }
		  iVar2 = unnamed_function_1417(Core_Gameplay_Managers_ChatManager_TypeInfo);
		  *(int *)(iVar2 + 0x14) = param1;
		  *(int *)(param1 + 0x78) = iVar2;
		  if (DAT_ram_00a5a8fd == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IGameManager__Add__);
		    DAT_ram_00a5a8fd = '\x01';
		  }
		  iVar4 = Method_System_Collections_Generic_List_IGameManager__Add__;
		  iVar7 = *(int *)(param1 + 0x18);
		  *(int *)(iVar7 + 0x10) = *(int *)(iVar7 + 0x10) + 1;
		  uVar5 = *(uint *)(iVar7 + 0xc);
		  if (uVar5 < *(uint *)(*(int *)(iVar7 + 8) + 0xc)) {
		    *(uint *)(iVar7 + 0xc) = uVar5 + 1;
		    *(int *)(*(int *)(iVar7 + 8) + uVar5 * 4 + 0x10) = iVar2;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar7,iVar2,*(undefined4 *)(*(int *)(*(int *)(iVar4 + 0x10) + 0x60) + 0x38));
		  }
		  uVar1 = unnamed_function_1417(Core_Gameplay_Managers_WorldManager_TypeInfo);
		  Core_Gameplay_Managers_WorldManager__get_ClanIslesWorldMovement(uVar1,0);
		  *(undefined4 *)(param1 + 0x24) = uVar1;
		  if (DAT_ram_00a5a8fd == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IGameManager__Add__);
		    DAT_ram_00a5a8fd = '\x01';
		  }
		  iVar2 = Method_System_Collections_Generic_List_IGameManager__Add__;
		  iVar4 = *(int *)(param1 + 0x18);
		  *(int *)(iVar4 + 0x10) = *(int *)(iVar4 + 0x10) + 1;
		  uVar5 = *(uint *)(iVar4 + 0xc);
		  if (uVar5 < *(uint *)(*(int *)(iVar4 + 8) + 0xc)) {
		    *(uint *)(iVar4 + 0xc) = uVar5 + 1;
		    *(undefined4 *)(*(int *)(iVar4 + 8) + uVar5 * 4 + 0x10) = uVar1;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar4,uVar1,*(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x60) + 0x38));
		  }
		  iVar2 = unnamed_function_1417(Core_Gameplay_Managers_AprsManager_TypeInfo);
		  *(int *)(iVar2 + 0x20) = param1;
		  *(int *)(param1 + 0x34) = iVar2;
		  if (DAT_ram_00a5a8fd == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IGameManager__Add__);
		    DAT_ram_00a5a8fd = '\x01';
		  }
		  iVar4 = Method_System_Collections_Generic_List_IGameManager__Add__;
		  iVar7 = *(int *)(param1 + 0x18);
		  *(int *)(iVar7 + 0x10) = *(int *)(iVar7 + 0x10) + 1;
		  uVar5 = *(uint *)(iVar7 + 0xc);
		  if (uVar5 < *(uint *)(*(int *)(iVar7 + 8) + 0xc)) {
		    *(uint *)(iVar7 + 0xc) = uVar5 + 1;
		    *(int *)(*(int *)(iVar7 + 8) + uVar5 * 4 + 0x10) = iVar2;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar7,iVar2,*(undefined4 *)(*(int *)(*(int *)(iVar4 + 0x10) + 0x60) + 0x38));
		  }
		  uVar1 = unnamed_function_1417(Core_Gameplay_Managers_Inventory_GolemInventoryManager_TypeInfo);
		  Core_Gameplay_Managers_Inventory_GolemInventoryManager__Core_Gameplay_Managers_Inventory_IInventoryManager_get_Events
		            (uVar1,param1,0);
		  *(undefined4 *)(param1 + 0xa0) = uVar1;
		  if (DAT_ram_00a5a8fd == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IGameManager__Add__);
		    DAT_ram_00a5a8fd = '\x01';
		  }
		  iVar2 = Method_System_Collections_Generic_List_IGameManager__Add__;
		  iVar4 = *(int *)(param1 + 0x18);
		  *(int *)(iVar4 + 0x10) = *(int *)(iVar4 + 0x10) + 1;
		  uVar5 = *(uint *)(iVar4 + 0xc);
		  if (uVar5 < *(uint *)(*(int *)(iVar4 + 8) + 0xc)) {
		    *(uint *)(iVar4 + 0xc) = uVar5 + 1;
		    *(undefined4 *)(*(int *)(iVar4 + 8) + uVar5 * 4 + 0x10) = uVar1;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar4,uVar1,*(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x60) + 0x38));
		  }
		  uVar1 = unnamed_function_1417(Core_Gameplay_Managers_WorldAxisManager_TypeInfo);
		  Core_Gameplay_Managers_WorldAxisManager__get_DefencePrice(uVar1,param1,0);
		  *(undefined4 *)(param1 + 0xd0) = uVar1;
		  if (DAT_ram_00a5a8fd == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IGameManager__Add__);
		    DAT_ram_00a5a8fd = '\x01';
		  }
		  iVar2 = Method_System_Collections_Generic_List_IGameManager__Add__;
		  iVar4 = *(int *)(param1 + 0x18);
		  *(int *)(iVar4 + 0x10) = *(int *)(iVar4 + 0x10) + 1;
		  uVar5 = *(uint *)(iVar4 + 0xc);
		  if (uVar5 < *(uint *)(*(int *)(iVar4 + 8) + 0xc)) {
		    *(uint *)(iVar4 + 0xc) = uVar5 + 1;
		    *(undefined4 *)(*(int *)(iVar4 + 8) + uVar5 * 4 + 0x10) = uVar1;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar4,uVar1,*(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x60) + 0x38));
		  }
		  uVar1 = unnamed_function_1417(Core_Gameplay_Managers_PopupScheduleManager_TypeInfo);
		  Core_Gameplay_Managers_PopupScheduleManager__remove_DeinitCompleteEvent(uVar1,param1,0);
		  *(undefined4 *)(param1 + 0x9c) = uVar1;
		  if (DAT_ram_00a5a8fd == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IGameManager__Add__);
		    DAT_ram_00a5a8fd = '\x01';
		  }
		  iVar2 = Method_System_Collections_Generic_List_IGameManager__Add__;
		  iVar4 = *(int *)(param1 + 0x18);
		  *(int *)(iVar4 + 0x10) = *(int *)(iVar4 + 0x10) + 1;
		  uVar5 = *(uint *)(iVar4 + 0xc);
		  if (uVar5 < *(uint *)(*(int *)(iVar4 + 8) + 0xc)) {
		    *(uint *)(iVar4 + 0xc) = uVar5 + 1;
		    *(undefined4 *)(*(int *)(iVar4 + 8) + uVar5 * 4 + 0x10) = uVar1;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar4,uVar1,*(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x60) + 0x38));
		  }
		  uVar1 = unnamed_function_1417(Core_Gameplay_Managers_Location_LocationManager_TypeInfo);
		  Core_Gameplay_Managers_Location_LocationManager__get_Name(uVar1,param1,0);
		  *(undefined4 *)(param1 + 0x28) = uVar1;
		  if (DAT_ram_00a5a8fd == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IGameManager__Add__);
		    DAT_ram_00a5a8fd = '\x01';
		  }
		  iVar2 = Method_System_Collections_Generic_List_IGameManager__Add__;
		  iVar4 = *(int *)(param1 + 0x18);
		  *(int *)(iVar4 + 0x10) = *(int *)(iVar4 + 0x10) + 1;
		  uVar5 = *(uint *)(iVar4 + 0xc);
		  if (uVar5 < *(uint *)(*(int *)(iVar4 + 8) + 0xc)) {
		    *(uint *)(iVar4 + 0xc) = uVar5 + 1;
		    *(undefined4 *)(*(int *)(iVar4 + 8) + uVar5 * 4 + 0x10) = uVar1;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar4,uVar1,*(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x60) + 0x38));
		  }
		  uVar1 = unnamed_function_1417(Core_Gameplay_Managers_ShopManager_TypeInfo);
		  *(undefined4 *)(param1 + 0x70) = uVar1;
		  if (DAT_ram_00a5a8fd == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IGameManager__Add__);
		    DAT_ram_00a5a8fd = '\x01';
		  }
		  iVar2 = Method_System_Collections_Generic_List_IGameManager__Add__;
		  iVar4 = *(int *)(param1 + 0x18);
		  *(int *)(iVar4 + 0x10) = *(int *)(iVar4 + 0x10) + 1;
		  uVar5 = *(uint *)(iVar4 + 0xc);
		  if (uVar5 < *(uint *)(*(int *)(iVar4 + 8) + 0xc)) {
		    *(uint *)(iVar4 + 0xc) = uVar5 + 1;
		    *(undefined4 *)(*(int *)(iVar4 + 8) + uVar5 * 4 + 0x10) = uVar1;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar4,uVar1,*(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x60) + 0x38));
		  }
		  uVar1 = unnamed_function_1417(Core_Gameplay_Managers_ArtifactDropManager_TypeInfo);
		  Core_Gameplay_Managers_ArtifactDropManager__Animations_IAnimationProvider_TryStartAnimation
		            (uVar1,param1);
		  *(undefined4 *)(param1 + 0x40) = uVar1;
		  if (DAT_ram_00a5a8fd == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IGameManager__Add__);
		    DAT_ram_00a5a8fd = '\x01';
		  }
		  iVar2 = Method_System_Collections_Generic_List_IGameManager__Add__;
		  iVar4 = *(int *)(param1 + 0x18);
		  *(int *)(iVar4 + 0x10) = *(int *)(iVar4 + 0x10) + 1;
		  uVar5 = *(uint *)(iVar4 + 0xc);
		  if (uVar5 < *(uint *)(*(int *)(iVar4 + 8) + 0xc)) {
		    *(uint *)(iVar4 + 0xc) = uVar5 + 1;
		    *(undefined4 *)(*(int *)(iVar4 + 8) + uVar5 * 4 + 0x10) = uVar1;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar4,uVar1,*(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x60) + 0x38));
		  }
		  uVar1 = unnamed_function_1417(Core_Gameplay_Managers_AdManager_TypeInfo);
		  *(undefined4 *)(param1 + 0xd4) = uVar1;
		  if (DAT_ram_00a5a8fd == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IGameManager__Add__);
		    DAT_ram_00a5a8fd = '\x01';
		  }
		  iVar2 = Method_System_Collections_Generic_List_IGameManager__Add__;
		  iVar4 = *(int *)(param1 + 0x18);
		  *(int *)(iVar4 + 0x10) = *(int *)(iVar4 + 0x10) + 1;
		  uVar5 = *(uint *)(iVar4 + 0xc);
		  if (uVar5 < *(uint *)(*(int *)(iVar4 + 8) + 0xc)) {
		    *(uint *)(iVar4 + 0xc) = uVar5 + 1;
		    *(undefined4 *)(*(int *)(iVar4 + 8) + uVar5 * 4 + 0x10) = uVar1;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar4,uVar1,*(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x60) + 0x38));
		  }
		  uVar1 = unnamed_function_1417(Core_Gameplay_Managers_DailyQuestsManager_TypeInfo);
		  *(undefined4 *)(param1 + 0x50) = uVar1;
		  if (DAT_ram_00a5a8fd == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IGameManager__Add__);
		    DAT_ram_00a5a8fd = '\x01';
		  }
		  iVar2 = Method_System_Collections_Generic_List_IGameManager__Add__;
		  iVar4 = *(int *)(param1 + 0x18);
		  *(int *)(iVar4 + 0x10) = *(int *)(iVar4 + 0x10) + 1;
		  uVar5 = *(uint *)(iVar4 + 0xc);
		  if (uVar5 < *(uint *)(*(int *)(iVar4 + 8) + 0xc)) {
		    *(uint *)(iVar4 + 0xc) = uVar5 + 1;
		    *(undefined4 *)(*(int *)(iVar4 + 8) + uVar5 * 4 + 0x10) = uVar1;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar4,uVar1,*(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x60) + 0x38));
		  }
		  iVar2 = unnamed_function_1417(Core_Gameplay_Managers_BankManager_TypeInfo);
		  *(int *)(iVar2 + 0x20) = param1;
		  *(int *)(param1 + 0x5c) = iVar2;
		  if (DAT_ram_00a5a8fd == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IGameManager__Add__);
		    DAT_ram_00a5a8fd = '\x01';
		  }
		  iVar4 = Method_System_Collections_Generic_List_IGameManager__Add__;
		  iVar7 = *(int *)(param1 + 0x18);
		  *(int *)(iVar7 + 0x10) = *(int *)(iVar7 + 0x10) + 1;
		  uVar5 = *(uint *)(iVar7 + 0xc);
		  if (uVar5 < *(uint *)(*(int *)(iVar7 + 8) + 0xc)) {
		    *(uint *)(iVar7 + 0xc) = uVar5 + 1;
		    *(int *)(*(int *)(iVar7 + 8) + uVar5 * 4 + 0x10) = iVar2;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar7,iVar2,*(undefined4 *)(*(int *)(*(int *)(iVar4 + 0x10) + 0x60) + 0x38));
		  }
		  uVar1 = unnamed_function_1417(Core_Gameplay_Managers_Skins_Skin_Factory_TypeInfo);
		  if (*(int *)(Utils_TimeUtils_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Utils_TimeUtils_TypeInfo);
		  }
		  param4 = Utils_TimeUtils__SecToMs(0x4b0,0);
		  uVar6 = unnamed_function_1417(Core_Gameplay_Managers_Skins_SkinManager_TypeInfo);
		  Core_Gameplay_Managers_Skins_SkinManager__set_IsDisposed(uVar6,param1,uVar1,param4,0);
		  *(undefined4 *)(param1 + 0x100) = uVar6;
		  if (DAT_ram_00a5a8fd == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IGameManager__Add__);
		    DAT_ram_00a5a8fd = '\x01';
		  }
		  iVar2 = Method_System_Collections_Generic_List_IGameManager__Add__;
		  iVar4 = *(int *)(param1 + 0x18);
		  *(int *)(iVar4 + 0x10) = *(int *)(iVar4 + 0x10) + 1;
		  uVar5 = *(uint *)(iVar4 + 0xc);
		  if (uVar5 < *(uint *)(*(int *)(iVar4 + 8) + 0xc)) {
		    *(uint *)(iVar4 + 0xc) = uVar5 + 1;
		    *(undefined4 *)(*(int *)(iVar4 + 8) + uVar5 * 4 + 0x10) = uVar6;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar4,uVar6,*(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x60) + 0x38));
		  }
		  uVar1 = unnamed_function_1417(Core_Gameplay_Managers_Prefetch_AssetsPrefetchManager_TypeInfo);
		  Core_Gameplay_Managers_Prefetch_TutorialAssetsPrefetchManager__get_Name(uVar1,param1,0);
		  *(undefined4 *)(param1 + 100) = uVar1;
		  if (DAT_ram_00a5a8fd == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IGameManager__Add__);
		    DAT_ram_00a5a8fd = '\x01';
		  }
		  iVar2 = Method_System_Collections_Generic_List_IGameManager__Add__;
		  iVar4 = *(int *)(param1 + 0x18);
		  *(int *)(iVar4 + 0x10) = *(int *)(iVar4 + 0x10) + 1;
		  uVar5 = *(uint *)(iVar4 + 0xc);
		  if (uVar5 < *(uint *)(*(int *)(iVar4 + 8) + 0xc)) {
		    *(uint *)(iVar4 + 0xc) = uVar5 + 1;
		    *(undefined4 *)(*(int *)(iVar4 + 8) + uVar5 * 4 + 0x10) = uVar1;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar4,uVar1,*(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x60) + 0x38));
		  }
		  uVar1 = unnamed_function_1417(Core_Gameplay_Managers_ProgressSaverManager_TypeInfo);
		  Unity_Services_Core_Registration_CorePackageInitializer__get_CloudProjectId(uVar1,param1,0);
		  *(undefined4 *)(param1 + 0x6c) = uVar1;
		  if (DAT_ram_00a5a8fd == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IGameManager__Add__);
		    DAT_ram_00a5a8fd = '\x01';
		  }
		  iVar2 = Method_System_Collections_Generic_List_IGameManager__Add__;
		  iVar4 = *(int *)(param1 + 0x18);
		  *(int *)(iVar4 + 0x10) = *(int *)(iVar4 + 0x10) + 1;
		  uVar5 = *(uint *)(iVar4 + 0xc);
		  if (uVar5 < *(uint *)(*(int *)(iVar4 + 8) + 0xc)) {
		    *(uint *)(iVar4 + 0xc) = uVar5 + 1;
		    *(undefined4 *)(*(int *)(iVar4 + 8) + uVar5 * 4 + 0x10) = uVar1;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar4,uVar1,*(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x60) + 0x38));
		  }
		  uVar1 = unnamed_function_1417
		                    (Core_Gameplay_Managers_GameActivityRouting_GameFeatureRouterManager_TypeInfo);
		  *(undefined4 *)(param1 + 0xb4) = uVar1;
		  if (DAT_ram_00a5a8fd == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IGameManager__Add__);
		    DAT_ram_00a5a8fd = '\x01';
		  }
		  iVar2 = Method_System_Collections_Generic_List_IGameManager__Add__;
		  iVar4 = *(int *)(param1 + 0x18);
		  *(int *)(iVar4 + 0x10) = *(int *)(iVar4 + 0x10) + 1;
		  uVar5 = *(uint *)(iVar4 + 0xc);
		  if (uVar5 < *(uint *)(*(int *)(iVar4 + 8) + 0xc)) {
		    *(uint *)(iVar4 + 0xc) = uVar5 + 1;
		    *(undefined4 *)(*(int *)(iVar4 + 8) + uVar5 * 4 + 0x10) = uVar1;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar4,uVar1,*(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x60) + 0x38));
		  }
		  uVar1 = unnamed_function_1417(Core_Gameplay_Managers_SmallGamesManager_TypeInfo);
		  *(undefined4 *)(param1 + 0x74) = uVar1;
		  if (DAT_ram_00a5a8fd == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IGameManager__Add__);
		    DAT_ram_00a5a8fd = '\x01';
		  }
		  iVar2 = Method_System_Collections_Generic_List_IGameManager__Add__;
		  iVar4 = *(int *)(param1 + 0x18);
		  *(int *)(iVar4 + 0x10) = *(int *)(iVar4 + 0x10) + 1;
		  uVar5 = *(uint *)(iVar4 + 0xc);
		  if (uVar5 < *(uint *)(*(int *)(iVar4 + 8) + 0xc)) {
		    *(uint *)(iVar4 + 0xc) = uVar5 + 1;
		    *(undefined4 *)(*(int *)(iVar4 + 8) + uVar5 * 4 + 0x10) = uVar1;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar4,uVar1,*(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x60) + 0x38));
		  }
		  uVar1 = unnamed_function_1417(Core_Gameplay_Managers_BlitzTournamentManager_TypeInfo);
		  *(undefined4 *)(param1 + 0x80) = uVar1;
		  if (DAT_ram_00a5a8fd == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IGameManager__Add__);
		    DAT_ram_00a5a8fd = '\x01';
		  }
		  iVar2 = Method_System_Collections_Generic_List_IGameManager__Add__;
		  iVar4 = *(int *)(param1 + 0x18);
		  *(int *)(iVar4 + 0x10) = *(int *)(iVar4 + 0x10) + 1;
		  uVar5 = *(uint *)(iVar4 + 0xc);
		  if (uVar5 < *(uint *)(*(int *)(iVar4 + 8) + 0xc)) {
		    *(uint *)(iVar4 + 0xc) = uVar5 + 1;
		    *(undefined4 *)(*(int *)(iVar4 + 8) + uVar5 * 4 + 0x10) = uVar1;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar4,uVar1,*(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x60) + 0x38));
		  }
		  uVar1 = unnamed_function_1417(Core_Gameplay_Managers_TournamentsManager_TypeInfo);
		  *(undefined4 *)(param1 + 0x84) = uVar1;
		  if (DAT_ram_00a5a8fd == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IGameManager__Add__);
		    DAT_ram_00a5a8fd = '\x01';
		  }
		  iVar2 = Method_System_Collections_Generic_List_IGameManager__Add__;
		  iVar4 = *(int *)(param1 + 0x18);
		  *(int *)(iVar4 + 0x10) = *(int *)(iVar4 + 0x10) + 1;
		  uVar5 = *(uint *)(iVar4 + 0xc);
		  if (uVar5 < *(uint *)(*(int *)(iVar4 + 8) + 0xc)) {
		    *(uint *)(iVar4 + 0xc) = uVar5 + 1;
		    *(undefined4 *)(*(int *)(iVar4 + 8) + uVar5 * 4 + 0x10) = uVar1;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar4,uVar1,*(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x60) + 0x38));
		  }
		  uVar1 = unnamed_function_1417(Core_Gameplay_Managers_BossManager_TypeInfo);
		  *(undefined4 *)(param1 + 0xa4) = uVar1;
		  if (DAT_ram_00a5a8fd == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IGameManager__Add__);
		    DAT_ram_00a5a8fd = '\x01';
		  }
		  iVar2 = Method_System_Collections_Generic_List_IGameManager__Add__;
		  iVar4 = *(int *)(param1 + 0x18);
		  *(int *)(iVar4 + 0x10) = *(int *)(iVar4 + 0x10) + 1;
		  uVar5 = *(uint *)(iVar4 + 0xc);
		  if (uVar5 < *(uint *)(*(int *)(iVar4 + 8) + 0xc)) {
		    *(uint *)(iVar4 + 0xc) = uVar5 + 1;
		    *(undefined4 *)(*(int *)(iVar4 + 8) + uVar5 * 4 + 0x10) = uVar1;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar4,uVar1,*(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x60) + 0x38));
		  }
		  uVar1 = unnamed_function_1417(Core_Gameplay_Managers_BattlesManager_TypeInfo);
		  *(undefined4 *)(param1 + 0x8c) = uVar1;
		  if (DAT_ram_00a5a8fd == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IGameManager__Add__);
		    DAT_ram_00a5a8fd = '\x01';
		  }
		  iVar2 = Method_System_Collections_Generic_List_IGameManager__Add__;
		  iVar4 = *(int *)(param1 + 0x18);
		  *(int *)(iVar4 + 0x10) = *(int *)(iVar4 + 0x10) + 1;
		  uVar5 = *(uint *)(iVar4 + 0xc);
		  if (uVar5 < *(uint *)(*(int *)(iVar4 + 8) + 0xc)) {
		    *(uint *)(iVar4 + 0xc) = uVar5 + 1;
		    *(undefined4 *)(*(int *)(iVar4 + 8) + uVar5 * 4 + 0x10) = uVar1;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar4,uVar1,*(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x60) + 0x38));
		  }
		  uVar1 = unnamed_function_1417(Core_Gameplay_Managers_AssistantsManager_TypeInfo);
		  *(undefined4 *)(param1 + 0xac) = uVar1;
		  if (DAT_ram_00a5a8fd == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IGameManager__Add__);
		    DAT_ram_00a5a8fd = '\x01';
		  }
		  iVar2 = Method_System_Collections_Generic_List_IGameManager__Add__;
		  iVar4 = *(int *)(param1 + 0x18);
		  *(int *)(iVar4 + 0x10) = *(int *)(iVar4 + 0x10) + 1;
		  uVar5 = *(uint *)(iVar4 + 0xc);
		  if (uVar5 < *(uint *)(*(int *)(iVar4 + 8) + 0xc)) {
		    *(uint *)(iVar4 + 0xc) = uVar5 + 1;
		    *(undefined4 *)(*(int *)(iVar4 + 8) + uVar5 * 4 + 0x10) = uVar1;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar4,uVar1,*(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x60) + 0x38));
		  }
		  uVar1 = unnamed_function_1417
		                    (
		                    Core_Gameplay_Managers_EndlessPaymentOptionsList_EndlessPaymentOptionsListManager_TypeInfo
		                    );
		  UnityEngine_Purchasing_Default_WinProductDescription__set_price(uVar1,param1,0);
		  *(undefined4 *)(param1 + 0xf0) = uVar1;
		  if (DAT_ram_00a5a8fd == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IGameManager__Add__);
		    DAT_ram_00a5a8fd = '\x01';
		  }
		  iVar2 = Method_System_Collections_Generic_List_IGameManager__Add__;
		  iVar4 = *(int *)(param1 + 0x18);
		  *(int *)(iVar4 + 0x10) = *(int *)(iVar4 + 0x10) + 1;
		  uVar5 = *(uint *)(iVar4 + 0xc);
		  if (uVar5 < *(uint *)(*(int *)(iVar4 + 8) + 0xc)) {
		    *(uint *)(iVar4 + 0xc) = uVar5 + 1;
		    *(undefined4 *)(*(int *)(iVar4 + 8) + uVar5 * 4 + 0x10) = uVar1;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar4,uVar1,*(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x60) + 0x38));
		  }
		  uVar1 = unnamed_function_1417(Core_Gameplay_Managers_SpecialOffersManager_TypeInfo);
		  Unity_Services_Core_Registration_CorePackageInitializer__get_CloudProjectId(uVar1,param1,0);
		  *(undefined4 *)(param1 + 0x94) = uVar1;
		  if (DAT_ram_00a5a8fd == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IGameManager__Add__);
		    DAT_ram_00a5a8fd = '\x01';
		  }
		  iVar2 = Method_System_Collections_Generic_List_IGameManager__Add__;
		  iVar4 = *(int *)(param1 + 0x18);
		  *(int *)(iVar4 + 0x10) = *(int *)(iVar4 + 0x10) + 1;
		  uVar5 = *(uint *)(iVar4 + 0xc);
		  if (uVar5 < *(uint *)(*(int *)(iVar4 + 8) + 0xc)) {
		    *(uint *)(iVar4 + 0xc) = uVar5 + 1;
		    *(undefined4 *)(*(int *)(iVar4 + 8) + uVar5 * 4 + 0x10) = uVar1;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar4,uVar1,*(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x60) + 0x38));
		  }
		  uVar1 = unnamed_function_1417(Core_Gameplay_Managers_RateGameManager_TypeInfo);
		  *(undefined4 *)(param1 + 0x98) = uVar1;
		  if (DAT_ram_00a5a8fd == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IGameManager__Add__);
		    DAT_ram_00a5a8fd = '\x01';
		  }
		  iVar2 = Method_System_Collections_Generic_List_IGameManager__Add__;
		  iVar4 = *(int *)(param1 + 0x18);
		  *(int *)(iVar4 + 0x10) = *(int *)(iVar4 + 0x10) + 1;
		  uVar5 = *(uint *)(iVar4 + 0xc);
		  if (uVar5 < *(uint *)(*(int *)(iVar4 + 8) + 0xc)) {
		    *(uint *)(iVar4 + 0xc) = uVar5 + 1;
		    *(undefined4 *)(*(int *)(iVar4 + 8) + uVar5 * 4 + 0x10) = uVar1;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar4,uVar1,*(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x60) + 0x38));
		  }
		  uVar1 = unnamed_function_1417(Core_Gameplay_Managers_InitCompleteManager_TypeInfo);
		  *(undefined4 *)(param1 + 0x3c) = uVar1;
		  if (DAT_ram_00a5a8fd == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IGameManager__Add__);
		    DAT_ram_00a5a8fd = '\x01';
		  }
		  iVar2 = Method_System_Collections_Generic_List_IGameManager__Add__;
		  iVar4 = *(int *)(param1 + 0x18);
		  *(int *)(iVar4 + 0x10) = *(int *)(iVar4 + 0x10) + 1;
		  uVar5 = *(uint *)(iVar4 + 0xc);
		  if (uVar5 < *(uint *)(*(int *)(iVar4 + 8) + 0xc)) {
		    *(uint *)(iVar4 + 0xc) = uVar5 + 1;
		    *(undefined4 *)(*(int *)(iVar4 + 8) + uVar5 * 4 + 0x10) = uVar1;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar4,uVar1,*(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x60) + 0x38));
		  }
		  uVar1 = unnamed_function_1417(Core_Gameplay_Managers_Audio_AudioManager_TypeInfo);
		  UnityEngine_Purchasing_Default_WinProductDescription__set_price(uVar1,param1,0);
		  *(undefined4 *)(param1 + 0xb8) = uVar1;
		  if (DAT_ram_00a5a8fd == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IGameManager__Add__);
		    DAT_ram_00a5a8fd = '\x01';
		  }
		  iVar2 = Method_System_Collections_Generic_List_IGameManager__Add__;
		  iVar4 = *(int *)(param1 + 0x18);
		  *(int *)(iVar4 + 0x10) = *(int *)(iVar4 + 0x10) + 1;
		  uVar5 = *(uint *)(iVar4 + 0xc);
		  if (uVar5 < *(uint *)(*(int *)(iVar4 + 8) + 0xc)) {
		    *(uint *)(iVar4 + 0xc) = uVar5 + 1;
		    *(undefined4 *)(*(int *)(iVar4 + 8) + uVar5 * 4 + 0x10) = uVar1;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar4,uVar1,*(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x60) + 0x38));
		  }
		  uVar1 = unnamed_function_1417(Core_Gameplay_Managers_DuelManager_TypeInfo);
		  *(undefined4 *)(param1 + 0xbc) = uVar1;
		  if (DAT_ram_00a5a8fd == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IGameManager__Add__);
		    DAT_ram_00a5a8fd = '\x01';
		  }
		  iVar2 = Method_System_Collections_Generic_List_IGameManager__Add__;
		  iVar4 = *(int *)(param1 + 0x18);
		  *(int *)(iVar4 + 0x10) = *(int *)(iVar4 + 0x10) + 1;
		  uVar5 = *(uint *)(iVar4 + 0xc);
		  if (uVar5 < *(uint *)(*(int *)(iVar4 + 8) + 0xc)) {
		    *(uint *)(iVar4 + 0xc) = uVar5 + 1;
		    *(undefined4 *)(*(int *)(iVar4 + 8) + uVar5 * 4 + 0x10) = uVar1;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar4,uVar1,*(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x60) + 0x38));
		  }
		  uVar1 = unnamed_function_1417(Core_Gameplay_Managers_GameEventsManager_TypeInfo);
		  UnityEngine_Purchasing_Default_WinProductDescription__set_price(uVar1,param1,0);
		  *(undefined4 *)(param1 + 0x4c) = uVar1;
		  if (DAT_ram_00a5a8fd == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IGameManager__Add__);
		    DAT_ram_00a5a8fd = '\x01';
		  }
		  iVar2 = Method_System_Collections_Generic_List_IGameManager__Add__;
		  iVar4 = *(int *)(param1 + 0x18);
		  *(int *)(iVar4 + 0x10) = *(int *)(iVar4 + 0x10) + 1;
		  uVar5 = *(uint *)(iVar4 + 0xc);
		  if (uVar5 < *(uint *)(*(int *)(iVar4 + 8) + 0xc)) {
		    *(uint *)(iVar4 + 0xc) = uVar5 + 1;
		    *(undefined4 *)(*(int *)(iVar4 + 8) + uVar5 * 4 + 0x10) = uVar1;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar4,uVar1,*(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x60) + 0x38));
		  }
		  uVar1 = unnamed_function_1417(Core_Gameplay_Managers_Tutorial_Guide_GuideManager_TypeInfo);
		  *(undefined4 *)(param1 + 0x7c) = uVar1;
		  if (DAT_ram_00a5a8fd == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IGameManager__Add__);
		    DAT_ram_00a5a8fd = '\x01';
		  }
		  iVar2 = Method_System_Collections_Generic_List_IGameManager__Add__;
		  iVar4 = *(int *)(param1 + 0x18);
		  *(int *)(iVar4 + 0x10) = *(int *)(iVar4 + 0x10) + 1;
		  uVar5 = *(uint *)(iVar4 + 0xc);
		  if (uVar5 < *(uint *)(*(int *)(iVar4 + 8) + 0xc)) {
		    *(uint *)(iVar4 + 0xc) = uVar5 + 1;
		    *(undefined4 *)(*(int *)(iVar4 + 8) + uVar5 * 4 + 0x10) = uVar1;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar4,uVar1,*(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x60) + 0x38));
		  }
		  uVar1 = unnamed_function_1417
		                    (Core_Gameplay_Managers_Notifications_GameNotificationsManager_TypeInfo);
		  *(undefined4 *)(param1 + 0xcc) = uVar1;
		  if (DAT_ram_00a5a8fd == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IGameManager__Add__);
		    DAT_ram_00a5a8fd = '\x01';
		  }
		  iVar2 = Method_System_Collections_Generic_List_IGameManager__Add__;
		  iVar4 = *(int *)(param1 + 0x18);
		  *(int *)(iVar4 + 0x10) = *(int *)(iVar4 + 0x10) + 1;
		  uVar5 = *(uint *)(iVar4 + 0xc);
		  if (uVar5 < *(uint *)(*(int *)(iVar4 + 8) + 0xc)) {
		    *(uint *)(iVar4 + 0xc) = uVar5 + 1;
		    *(undefined4 *)(*(int *)(iVar4 + 8) + uVar5 * 4 + 0x10) = uVar1;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar4,uVar1,*(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x60) + 0x38));
		  }
		  uVar1 = unnamed_function_1417(Core_Gameplay_Managers_GdEvents_GdEventsManager_TypeInfo);
		  UnityEngine_Purchasing_Default_WinProductDescription__set_title(uVar1,param1,0);
		  *(undefined4 *)(param1 + 0xdc) = uVar1;
		  if (DAT_ram_00a5a8fd == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IGameManager__Add__);
		    DAT_ram_00a5a8fd = '\x01';
		  }
		  iVar2 = Method_System_Collections_Generic_List_IGameManager__Add__;
		  iVar4 = *(int *)(param1 + 0x18);
		  *(int *)(iVar4 + 0x10) = *(int *)(iVar4 + 0x10) + 1;
		  uVar5 = *(uint *)(iVar4 + 0xc);
		  if (uVar5 < *(uint *)(*(int *)(iVar4 + 8) + 0xc)) {
		    *(uint *)(iVar4 + 0xc) = uVar5 + 1;
		    *(undefined4 *)(*(int *)(iVar4 + 8) + uVar5 * 4 + 0x10) = uVar1;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar4,uVar1,*(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x60) + 0x38));
		  }
		  iVar2 = unnamed_function_1417(Core_Gameplay_Managers_ClientStateManager_TypeInfo);
		  if (DAT_ram_00a5a9eb == '\0') {
		    Mono_Security_ASN1__get_Item(&Utils_OpTokenRepository_TypeInfo);
		    DAT_ram_00a5a9eb = '\x01';
		  }
		  *(int *)(iVar2 + 0x14) = param1;
		  uVar1 = unnamed_function_1417(Utils_OpTokenRepository_TypeInfo);
		  Utils_OpTokenRepository__Dispose(uVar1,0);
		  *(undefined4 *)(iVar2 + 0x10) = uVar1;
		  *(int *)(param1 + 0x58) = iVar2;
		  if (DAT_ram_00a5a8fd == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IGameManager__Add__);
		    DAT_ram_00a5a8fd = '\x01';
		  }
		  iVar4 = Method_System_Collections_Generic_List_IGameManager__Add__;
		  iVar7 = *(int *)(param1 + 0x18);
		  *(int *)(iVar7 + 0x10) = *(int *)(iVar7 + 0x10) + 1;
		  uVar5 = *(uint *)(iVar7 + 0xc);
		  if (uVar5 < *(uint *)(*(int *)(iVar7 + 8) + 0xc)) {
		    *(uint *)(iVar7 + 0xc) = uVar5 + 1;
		    *(int *)(*(int *)(iVar7 + 8) + uVar5 * 4 + 0x10) = iVar2;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar7,iVar2,*(undefined4 *)(*(int *)(*(int *)(iVar4 + 0x10) + 0x60) + 0x38));
		  }
		  uVar1 = unnamed_function_1417(Core_Gameplay_Managers_ThemeDuelStateManager_TypeInfo);
		  *(undefined4 *)(param1 + 0xe8) = uVar1;
		  if (DAT_ram_00a5a8fd == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IGameManager__Add__);
		    DAT_ram_00a5a8fd = '\x01';
		  }
		  iVar2 = Method_System_Collections_Generic_List_IGameManager__Add__;
		  iVar4 = *(int *)(param1 + 0x18);
		  *(int *)(iVar4 + 0x10) = *(int *)(iVar4 + 0x10) + 1;
		  uVar5 = *(uint *)(iVar4 + 0xc);
		  if (uVar5 < *(uint *)(*(int *)(iVar4 + 8) + 0xc)) {
		    *(uint *)(iVar4 + 0xc) = uVar5 + 1;
		    *(undefined4 *)(*(int *)(iVar4 + 8) + uVar5 * 4 + 0x10) = uVar1;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar4,uVar1,*(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x60) + 0x38));
		  }
		  uVar1 = unnamed_function_1417(Core_Gameplay_Managers_PortalsManager_TypeInfo);
		  Unity_Services_Core_Registration_CorePackageInitializer__get_CloudProjectId(uVar1,param1,0);
		  *(undefined4 *)(param1 + 0xec) = uVar1;
		  if (DAT_ram_00a5a8fd == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IGameManager__Add__);
		    DAT_ram_00a5a8fd = '\x01';
		  }
		  iVar2 = Method_System_Collections_Generic_List_IGameManager__Add__;
		  iVar4 = *(int *)(param1 + 0x18);
		  *(int *)(iVar4 + 0x10) = *(int *)(iVar4 + 0x10) + 1;
		  uVar5 = *(uint *)(iVar4 + 0xc);
		  if (uVar5 < *(uint *)(*(int *)(iVar4 + 8) + 0xc)) {
		    *(uint *)(iVar4 + 0xc) = uVar5 + 1;
		    *(undefined4 *)(*(int *)(iVar4 + 8) + uVar5 * 4 + 0x10) = uVar1;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar4,uVar1,*(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x60) + 0x38));
		  }
		  iVar2 = unnamed_function_1417(Core_Gameplay_Managers_AnnouncementsManager_TypeInfo);
		  *(int *)(iVar2 + 8) = param1;
		  if (DAT_ram_00a5a8fd == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IGameManager__Add__);
		    DAT_ram_00a5a8fd = '\x01';
		  }
		  iVar4 = Method_System_Collections_Generic_List_IGameManager__Add__;
		  iVar7 = *(int *)(param1 + 0x18);
		  *(int *)(iVar7 + 0x10) = *(int *)(iVar7 + 0x10) + 1;
		  uVar5 = *(uint *)(iVar7 + 0xc);
		  if (uVar5 < *(uint *)(*(int *)(iVar7 + 8) + 0xc)) {
		    *(uint *)(iVar7 + 0xc) = uVar5 + 1;
		    *(int *)(*(int *)(iVar7 + 8) + uVar5 * 4 + 0x10) = iVar2;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar7,iVar2,*(undefined4 *)(*(int *)(*(int *)(iVar4 + 0x10) + 0x60) + 0x38));
		  }
		  uVar1 = unnamed_function_1417(Core_Gameplay_Managers_PurchaseConsumeManager_TypeInfo);
		  UnityEngine_Purchasing_Default_WinProductDescription__set_price(uVar1,param1,0);
		  if (DAT_ram_00a5a8fd == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IGameManager__Add__);
		    DAT_ram_00a5a8fd = '\x01';
		  }
		  iVar2 = Method_System_Collections_Generic_List_IGameManager__Add__;
		  iVar4 = *(int *)(param1 + 0x18);
		  *(int *)(iVar4 + 0x10) = *(int *)(iVar4 + 0x10) + 1;
		  uVar5 = *(uint *)(iVar4 + 0xc);
		  if (uVar5 < *(uint *)(*(int *)(iVar4 + 8) + 0xc)) {
		    *(uint *)(iVar4 + 0xc) = uVar5 + 1;
		    *(undefined4 *)(*(int *)(iVar4 + 8) + uVar5 * 4 + 0x10) = uVar1;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar4,uVar1,*(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x60) + 0x38));
		  }
		  uVar1 = unnamed_function_1417(Core_Gameplay_Managers_CompetitionManager_TypeInfo);
		  UnityEngine_Purchasing_Default_WinProductDescription__set_price(uVar1,param1,0);
		  *(undefined4 *)(param1 + 0xf4) = uVar1;
		  if (DAT_ram_00a5a8fd == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IGameManager__Add__);
		    DAT_ram_00a5a8fd = '\x01';
		  }
		  iVar2 = Method_System_Collections_Generic_List_IGameManager__Add__;
		  iVar4 = *(int *)(param1 + 0x18);
		  *(int *)(iVar4 + 0x10) = *(int *)(iVar4 + 0x10) + 1;
		  uVar5 = *(uint *)(iVar4 + 0xc);
		  if (uVar5 < *(uint *)(*(int *)(iVar4 + 8) + 0xc)) {
		    *(uint *)(iVar4 + 0xc) = uVar5 + 1;
		    *(undefined4 *)(*(int *)(iVar4 + 8) + uVar5 * 4 + 0x10) = uVar1;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar4,uVar1,*(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x60) + 0x38));
		  }
		  uVar1 = unnamed_function_1417(Core_Gameplay_Managers_FrescoManager_TypeInfo);
		  UnityEngine_Purchasing_Default_WinProductDescription__set_title(uVar1,param1,0);
		  *(undefined4 *)(param1 + 0xf8) = uVar1;
		  if (DAT_ram_00a5a8fd == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IGameManager__Add__);
		    DAT_ram_00a5a8fd = '\x01';
		  }
		  iVar2 = Method_System_Collections_Generic_List_IGameManager__Add__;
		  iVar4 = *(int *)(param1 + 0x18);
		  *(int *)(iVar4 + 0x10) = *(int *)(iVar4 + 0x10) + 1;
		  uVar5 = *(uint *)(iVar4 + 0xc);
		  if (uVar5 < *(uint *)(*(int *)(iVar4 + 8) + 0xc)) {
		    *(uint *)(iVar4 + 0xc) = uVar5 + 1;
		    *(undefined4 *)(*(int *)(iVar4 + 8) + uVar5 * 4 + 0x10) = uVar1;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar4,uVar1,*(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x60) + 0x38));
		  }
		  uVar1 = unnamed_function_1417(Core_Gameplay_Managers_ExperimentsManager_TypeInfo);
		  Unity_Services_Core_Registration_CorePackageInitializer__get_CloudProjectId(uVar1,param1,0);
		  *(undefined4 *)(param1 + 0x104) = uVar1;
		  if (DAT_ram_00a5a8fd == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IGameManager__Add__);
		    DAT_ram_00a5a8fd = '\x01';
		  }
		  iVar2 = Method_System_Collections_Generic_List_IGameManager__Add__;
		  iVar4 = *(int *)(param1 + 0x18);
		  *(int *)(iVar4 + 0x10) = *(int *)(iVar4 + 0x10) + 1;
		  uVar5 = *(uint *)(iVar4 + 0xc);
		  if (uVar5 < *(uint *)(*(int *)(iVar4 + 8) + 0xc)) {
		    *(uint *)(iVar4 + 0xc) = uVar5 + 1;
		    *(undefined4 *)(*(int *)(iVar4 + 8) + uVar5 * 4 + 0x10) = uVar1;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar4,uVar1,*(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x60) + 0x38));
		  }
		  uVar1 = unnamed_function_1417(Core_Gameplay_Managers_ClientStateResolver_TypeInfo);
		  Core_Gameplay_Managers_ClientStateResolver__set_Game(uVar1,param1,param1);
		  *(undefined4 *)(param1 + 0x88) = uVar1;
		  if (DAT_ram_00a5a8fd == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IGameManager__Add__);
		    DAT_ram_00a5a8fd = '\x01';
		  }
		  iVar2 = Method_System_Collections_Generic_List_IGameManager__Add__;
		  iVar4 = *(int *)(param1 + 0x18);
		  *(int *)(iVar4 + 0x10) = *(int *)(iVar4 + 0x10) + 1;
		  uVar5 = *(uint *)(iVar4 + 0xc);
		  if (uVar5 < *(uint *)(*(int *)(iVar4 + 8) + 0xc)) {
		    *(uint *)(iVar4 + 0xc) = uVar5 + 1;
		    *(undefined4 *)(*(int *)(iVar4 + 8) + uVar5 * 4 + 0x10) = uVar1;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar4,uVar1,*(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x60) + 0x38));
		  }
		  uVar1 = unnamed_function_1417(Core_Gameplay_Managers_GameActivityRouting_RoutingManager_TypeInfo);
		  Core_Gameplay_Managers_GameActivityRouting_RoutingManager__set_Game(uVar1,param1,0);
		  *(undefined4 *)(param1 + 0xfc) = uVar1;
		  if (DAT_ram_00a5a8fd == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IGameManager__Add__);
		    DAT_ram_00a5a8fd = '\x01';
		  }
		  iVar2 = Method_System_Collections_Generic_List_IGameManager__Add__;
		  iVar4 = *(int *)(param1 + 0x18);
		  *(int *)(iVar4 + 0x10) = *(int *)(iVar4 + 0x10) + 1;
		  uVar5 = *(uint *)(iVar4 + 0xc);
		  if (uVar5 < *(uint *)(*(int *)(iVar4 + 8) + 0xc)) {
		    *(uint *)(iVar4 + 0xc) = uVar5 + 1;
		    *(undefined4 *)(*(int *)(iVar4 + 8) + uVar5 * 4 + 0x10) = uVar1;
		    return;
		  }
		  System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		            (iVar4,uVar1,*(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x60) + 0x38));
		  return;
		}
		*/

		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Instance ---
		void Core_Gameplay_Game__get_Instance(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5a921 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a5a921 = '\x01';
		  }
		  **(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c) = param1;
		  return;
		}
		*/

}
