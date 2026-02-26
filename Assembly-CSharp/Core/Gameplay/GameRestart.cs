using System;
using Core.Application;
using Cysharp.Threading.Tasks;
using Il2CppDummyDll;

namespace Core.Gameplay
{
	// Token: 0x02001124 RID: 4388
	[Token(Token = "0x2001124")]
	public class GameRestart : IGameRestart
	{
		// Token: 0x060066BC RID: 26300 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60066BC")]
		[Address(RVA = "0xB23B", Offset = "0xB23B", VA = "0xB23B")]
		public GameRestart(IApp app)
		{
		/* --- GHIDRA: <GameDeinitCompleteEvent>b__3_0 ---
		void Core_Gameplay_GameRestart___GameDeinitCompleteEvent_b__3_0(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  float param4;
		  int iVar3;
		  uint uVar4;
		  undefined4 uVar5;
		  int param1_00;
		  
		  if (DAT_ram_00a5a929 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_CacheManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_DictManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_ExperimentsManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_Skins_Skin_Factory_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Core_Gameplay_Managers_Tutorial_GameTutorialScenesManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGameManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&DefaultNamespace_Scenes___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_Skins_SkinManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Utils_TimeUtils_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Core_Gameplay_Managers_Prefetch_TutorialAssetsPrefetchManager_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_Audio_TutorialAudioManager_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Core_Gameplay_Managers_Tutorial_Guide_TutorialGuideManger_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_Tutorial_TutorialManagerV2_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_Tutorial_TutorialUserManager_TypeInfo);
		    DAT_ram_00a5a929 = '\x01';
		  }
		  Core_Gameplay_AbstractGame__set_ExperimentsManager(param1,param1);
		  uVar1 = unnamed_function_1417(Core_Gameplay_Managers_Tutorial_TutorialManagerV2_TypeInfo);
		  Unity_Services_Core_Environments_Internal_Environments__get_Current(uVar1,param1,0);
		  *(undefined4 *)(param1 + 0x68) = uVar1;
		  uVar1 = func_ii_1082(uVar1,Core_Gameplay_IGameManager_TypeInfo);
		  if (DAT_ram_00a5a8fd == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IGameManager__Add__);
		    DAT_ram_00a5a8fd = '\x01';
		  }
		  iVar2 = Method_System_Collections_Generic_List_IGameManager__Add__;
		  iVar3 = *(int *)(param1 + 0x18);
		  *(int *)(iVar3 + 0x10) = *(int *)(iVar3 + 0x10) + 1;
		  uVar4 = *(uint *)(iVar3 + 0xc);
		  if (uVar4 < *(uint *)(*(int *)(iVar3 + 8) + 0xc)) {
		    *(uint *)(iVar3 + 0xc) = uVar4 + 1;
		    *(undefined4 *)(*(int *)(iVar3 + 8) + uVar4 * 4 + 0x10) = uVar1;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar3,uVar1,*(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x60) + 0x38));
		  }
		  uVar5 = *(undefined4 *)(param1 + 0x10);
		  uVar1 = unnamed_function_1417(Core_Gameplay_Managers_DictManager_TypeInfo);
		  Core_Gameplay_Managers_DictManager__set_WrappersStorage(uVar1,uVar5,0);
		  *(undefined4 *)(param1 + 0x54) = uVar1;
		  if (DAT_ram_00a5a8fd == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IGameManager__Add__);
		    DAT_ram_00a5a8fd = '\x01';
		  }
		  iVar2 = Method_System_Collections_Generic_List_IGameManager__Add__;
		  iVar3 = *(int *)(param1 + 0x18);
		  *(int *)(iVar3 + 0x10) = *(int *)(iVar3 + 0x10) + 1;
		  uVar4 = *(uint *)(iVar3 + 0xc);
		  if (uVar4 < *(uint *)(*(int *)(iVar3 + 8) + 0xc)) {
		    *(uint *)(iVar3 + 0xc) = uVar4 + 1;
		    *(undefined4 *)(*(int *)(iVar3 + 8) + uVar4 * 4 + 0x10) = uVar1;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar3,uVar1,*(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x60) + 0x38));
		  }
		  iVar2 = unnamed_function_1417(Core_Gameplay_Managers_CacheManager_TypeInfo);
		  *(int *)(iVar2 + 8) = param1;
		  *(int *)(param1 + 0x44) = iVar2;
		  if (DAT_ram_00a5a8fd == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IGameManager__Add__);
		    DAT_ram_00a5a8fd = '\x01';
		  }
		  iVar3 = Method_System_Collections_Generic_List_IGameManager__Add__;
		  param1_00 = *(int *)(param1 + 0x18);
		  *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		  uVar4 = *(uint *)(param1_00 + 0xc);
		  if (uVar4 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		    *(uint *)(param1_00 + 0xc) = uVar4 + 1;
		    *(int *)(*(int *)(param1_00 + 8) + uVar4 * 4 + 0x10) = iVar2;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (param1_00,iVar2,*(undefined4 *)(*(int *)(*(int *)(iVar3 + 0x10) + 0x60) + 0x38));
		  }
		  uVar5 = *(undefined4 *)(param1 + 0x68);
		  uVar1 = unnamed_function_1417(Core_Gameplay_Managers_Tutorial_TutorialUserManager_TypeInfo);
		  Unity_Services_Core_Environments_Internal_Environments__get_Current(uVar1,uVar5,0);
		  if (DAT_ram_00a5a8fd == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IGameManager__Add__);
		    DAT_ram_00a5a8fd = '\x01';
		  }
		  iVar2 = Method_System_Collections_Generic_List_IGameManager__Add__;
		  iVar3 = *(int *)(param1 + 0x18);
		  *(int *)(iVar3 + 0x10) = *(int *)(iVar3 + 0x10) + 1;
		  uVar4 = *(uint *)(iVar3 + 0xc);
		  if (uVar4 < *(uint *)(*(int *)(iVar3 + 8) + 0xc)) {
		    *(uint *)(iVar3 + 0xc) = uVar4 + 1;
		    *(undefined4 *)(*(int *)(iVar3 + 8) + uVar4 * 4 + 0x10) = uVar1;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar3,uVar1,*(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x60) + 0x38));
		  }
		  uVar1 = unnamed_function_1417(Core_Gameplay_Managers_Skins_Skin_Factory_TypeInfo);
		  if (*(int *)(Utils_TimeUtils_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Utils_TimeUtils_TypeInfo);
		  }
		  param4 = Utils_TimeUtils__SecToMs(0x4b0,0);
		  uVar5 = unnamed_function_1417(Core_Gameplay_Managers_Skins_SkinManager_TypeInfo);
		  Core_Gameplay_Managers_Skins_SkinManager__set_IsDisposed(uVar5,param1,uVar1,param4,0);
		  *(undefined4 *)(param1 + 0x100) = uVar5;
		  if (DAT_ram_00a5a8fd == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IGameManager__Add__);
		    DAT_ram_00a5a8fd = '\x01';
		  }
		  iVar2 = Method_System_Collections_Generic_List_IGameManager__Add__;
		  iVar3 = *(int *)(param1 + 0x18);
		  *(int *)(iVar3 + 0x10) = *(int *)(iVar3 + 0x10) + 1;
		  uVar4 = *(uint *)(iVar3 + 0xc);
		  if (uVar4 < *(uint *)(*(int *)(iVar3 + 8) + 0xc)) {
		    *(uint *)(iVar3 + 0xc) = uVar4 + 1;
		    *(undefined4 *)(*(int *)(iVar3 + 8) + uVar4 * 4 + 0x10) = uVar5;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar3,uVar5,*(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x60) + 0x38));
		  }
		  uVar1 = unnamed_function_1417
		                    (Core_Gameplay_Managers_Prefetch_TutorialAssetsPrefetchManager_TypeInfo);
		  Core_Gameplay_Managers_Prefetch_TutorialAssetsPrefetchManager__get_Name(uVar1,param1,0);
		  *(undefined4 *)(param1 + 100) = uVar1;
		  if (DAT_ram_00a5a8fd == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IGameManager__Add__);
		    DAT_ram_00a5a8fd = '\x01';
		  }
		  iVar2 = Method_System_Collections_Generic_List_IGameManager__Add__;
		  iVar3 = *(int *)(param1 + 0x18);
		  *(int *)(iVar3 + 0x10) = *(int *)(iVar3 + 0x10) + 1;
		  uVar4 = *(uint *)(iVar3 + 0xc);
		  if (uVar4 < *(uint *)(*(int *)(iVar3 + 8) + 0xc)) {
		    *(uint *)(iVar3 + 0xc) = uVar4 + 1;
		    *(undefined4 *)(*(int *)(iVar3 + 8) + uVar4 * 4 + 0x10) = uVar1;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar3,uVar1,*(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x60) + 0x38));
		  }
		  uVar1 = unnamed_function_1417(Core_Gameplay_Managers_Audio_TutorialAudioManager_TypeInfo);
		  UnityEngine_Purchasing_Default_WinProductDescription__set_price(uVar1,param1,0);
		  *(undefined4 *)(param1 + 0xb8) = uVar1;
		  if (DAT_ram_00a5a8fd == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IGameManager__Add__);
		    DAT_ram_00a5a8fd = '\x01';
		  }
		  iVar2 = Method_System_Collections_Generic_List_IGameManager__Add__;
		  iVar3 = *(int *)(param1 + 0x18);
		  *(int *)(iVar3 + 0x10) = *(int *)(iVar3 + 0x10) + 1;
		  uVar4 = *(uint *)(iVar3 + 0xc);
		  if (uVar4 < *(uint *)(*(int *)(iVar3 + 8) + 0xc)) {
		    *(uint *)(iVar3 + 0xc) = uVar4 + 1;
		    *(undefined4 *)(*(int *)(iVar3 + 8) + uVar4 * 4 + 0x10) = uVar1;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar3,uVar1,*(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x60) + 0x38));
		  }
		  uVar1 = unnamed_function_1417(Core_Gameplay_Managers_Tutorial_Guide_TutorialGuideManger_TypeInfo);
		  *(undefined4 *)(param1 + 0x7c) = uVar1;
		  if (DAT_ram_00a5a8fd == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IGameManager__Add__);
		    DAT_ram_00a5a8fd = '\x01';
		  }
		  iVar2 = Method_System_Collections_Generic_List_IGameManager__Add__;
		  iVar3 = *(int *)(param1 + 0x18);
		  *(int *)(iVar3 + 0x10) = *(int *)(iVar3 + 0x10) + 1;
		  uVar4 = *(uint *)(iVar3 + 0xc);
		  if (uVar4 < *(uint *)(*(int *)(iVar3 + 8) + 0xc)) {
		    *(uint *)(iVar3 + 0xc) = uVar4 + 1;
		    *(undefined4 *)(*(int *)(iVar3 + 8) + uVar4 * 4 + 0x10) = uVar1;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar3,uVar1,*(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x60) + 0x38));
		  }
		  uVar1 = unnamed_function_1417(Core_Gameplay_Managers_ExperimentsManager_TypeInfo);
		  Unity_Services_Core_Registration_CorePackageInitializer__get_CloudProjectId(uVar1,param1,0);
		  *(undefined4 *)(param1 + 0x104) = uVar1;
		  if (DAT_ram_00a5a8fd == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IGameManager__Add__);
		    DAT_ram_00a5a8fd = '\x01';
		  }
		  iVar2 = Method_System_Collections_Generic_List_IGameManager__Add__;
		  iVar3 = *(int *)(param1 + 0x18);
		  *(int *)(iVar3 + 0x10) = *(int *)(iVar3 + 0x10) + 1;
		  uVar4 = *(uint *)(iVar3 + 0xc);
		  if (uVar4 < *(uint *)(*(int *)(iVar3 + 8) + 0xc)) {
		    *(uint *)(iVar3 + 0xc) = uVar4 + 1;
		    *(undefined4 *)(*(int *)(iVar3 + 8) + uVar4 * 4 + 0x10) = uVar1;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar3,uVar1,*(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x60) + 0x38));
		  }
		  iVar2 = Mono_Security_ASN1Convert__ToOid(DefaultNamespace_Scenes___TypeInfo,1);
		  *(undefined4 *)(iVar2 + 0x10) = 4;
		  uVar1 = unnamed_function_1417(Core_Gameplay_Managers_Tutorial_GameTutorialScenesManager_TypeInfo);
		  Core_Gameplay_Managers_Tutorial_GameTutorialScenesManager__remove_DeinitCompleteEvent
		            (uVar1,param1,iVar2,0);
		  if (DAT_ram_00a5a8fd == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_IGameManager__Add__);
		    DAT_ram_00a5a8fd = '\x01';
		  }
		  iVar2 = Method_System_Collections_Generic_List_IGameManager__Add__;
		  iVar3 = *(int *)(param1 + 0x18);
		  *(int *)(iVar3 + 0x10) = *(int *)(iVar3 + 0x10) + 1;
		  uVar4 = *(uint *)(iVar3 + 0xc);
		  if (uVar4 < *(uint *)(*(int *)(iVar3 + 8) + 0xc)) {
		    *(uint *)(iVar3 + 0xc) = uVar4 + 1;
		    *(undefined4 *)(*(int *)(iVar3 + 8) + uVar4 * 4 + 0x10) = uVar1;
		    return;
		  }
		  System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		            (iVar3,uVar1,*(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x60) + 0x38));
		  return;
		}
		*/

		/* --- GHIDRA: .ctor ---
		void Core_Gameplay_GameRestart___ctor(int param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  uint *puVar3;
		  undefined4 param1_00;
		  int *param1_01;
		  int iVar4;
		  
		  if (DAT_ram_00a5a926 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IGame__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Gameplay_GameRestart_GameDeinitCompleteEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Gameplay_GameRestart__GameDeinitCompleteEvent_b__3_0__);
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a5a926 = '\x01';
		  }
		  uVar2 = unnamed_function_1417(System_Action_IGame__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,Method_Core_Gameplay_GameRestart_GameDeinitCompleteEvent__,0);
		  iVar4 = *param2;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xd8);
		        goto code_r0x81294fca;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param2,Core_Gameplay_IGame_TypeInfo,3);
		code_r0x81294fca:
		  (**(code **)((ulonglong)*puVar3 * 4))(param2,uVar2,puVar3[1]);
		  uVar1 = 0;
		  iVar4 = UI_Windows_PopupController__get_OpenedWindowsCount(0);
		  *(undefined1 *)(iVar4 + 0x20) = 1;
		  param1_01 = *(int **)(param1 + 8);
		  iVar4 = *param1_01;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x120);
		        goto code_r0x81295054;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param1_01,Core_Application_IApp_TypeInfo,0xc);
		code_r0x81295054:
		  uVar2 = (**(code **)((ulonglong)*puVar3 * 4))(param1_01,puVar3[1]);
		  param1_00 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (param1_00,param1,Method_Core_Gameplay_GameRestart__GameDeinitCompleteEvent_b__3_0__,0);
		  Core_Application_Managers_Connection_ConnectionManager__ReConnect(uVar2,param1_00,0);
		  Cysharp_Threading_Tasks_UniTaskCompletionSource___ctor(*(undefined4 *)(param1 + 0xc),0);
		  return;
		}
		*/

		}

		// Token: 0x060066BD RID: 26301 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60066BD")]
		[Address(RVA = "0xB23C", Offset = "0xB23C", VA = "0xB23C")]
		private void GameDeinitCompleteEvent(IGame game)
		{
		/* --- GHIDRA: GameDeinitCompleteEvent ---
		void Core_Gameplay_GameRestart__GameDeinitCompleteEvent
		               (undefined8 *param1,int param2,int *param3,undefined4 param4)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  uint *puVar3;
		  int *piVar4;
		  int iVar5;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a5a927 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IGame__TypeInfo);
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Gameplay_GameRestart_GameDeinitCompleteEvent__);
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Cysharp_Threading_Tasks_UniTaskCompletionSource_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_8441);
		    DAT_ram_00a5a927 = '\x01';
		  }
		  uVar2 = unnamed_function_1417(Cysharp_Threading_Tasks_UniTaskCompletionSource_TypeInfo);
		  *(undefined4 *)(param2 + 0xc) = uVar2;
		  iVar5 = *param3;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xe8);
		        goto code_r0x81295178;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param3,Core_Gameplay_IGame_TypeInfo,5);
		code_r0x81295178:
		  iVar5 = (**(code **)((ulonglong)*puVar3 * 4))(param3,puVar3[1]);
		  if (iVar5 == 0) {
		    uVar1 = 0;
		    iVar5 = UI_Windows_PopupController__get_OpenedWindowsCount(0);
		    *(undefined1 *)(iVar5 + 0x20) = 0;
		    iVar5 = *param3;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xe0);
		          goto code_r0x81295202;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(param3,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x81295202:
		    piVar4 = (int *)(**(code **)((ulonglong)*puVar3 * 4))(param3,puVar3[1]);
		    uVar1 = 0;
		    iVar5 = *piVar4;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      do {
		        if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x138);
		          goto code_r0x8129527e;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar4,Core_Application_IApp_TypeInfo,0xf);
		code_r0x8129527e:
		    uVar1 = 0;
		    iVar5 = (**(code **)((ulonglong)*puVar3 * 4))(piVar4,puVar3[1]);
		    Core_Dev_DevMenuUnlocker__Validate(*(undefined4 *)(iVar5 + 0x1c),0);
		    iVar5 = *param3;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xe0);
		          goto code_r0x81295307;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(param3,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x81295307:
		    piVar4 = (int *)(**(code **)((ulonglong)*puVar3 * 4))(param3,puVar3[1]);
		    uVar1 = 0;
		    iVar5 = *piVar4;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      do {
		        if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xe8);
		          goto code_r0x81295383;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar4,Core_Application_IApp_TypeInfo,5);
		code_r0x81295383:
		    uVar1 = 0;
		    uVar2 = (**(code **)((ulonglong)*puVar3 * 4))(piVar4,puVar3[1]);
		    func_ii_8753(uVar2,0);
		    iVar5 = *param3;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xe0);
		          goto code_r0x81295409;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(param3,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x81295409:
		    piVar4 = (int *)(**(code **)((ulonglong)*puVar3 * 4))(param3,puVar3[1]);
		    uVar1 = 0;
		    iVar5 = *piVar4;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      do {
		        if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xd8);
		          goto code_r0x81295485;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar4,Core_Application_IApp_TypeInfo,3);
		code_r0x81295485:
		    uVar1 = 0;
		    iVar5 = (**(code **)((ulonglong)*puVar3 * 4))(piVar4,puVar3[1]);
		    uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(iVar5 + 0x3c),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar2,0,0);
		    iVar5 = *param3;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xe0);
		          goto code_r0x81295516;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(param3,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x81295516:
		    piVar4 = (int *)(**(code **)((ulonglong)*puVar3 * 4))(param3,puVar3[1]);
		    uVar1 = 0;
		    iVar5 = *piVar4;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      do {
		        if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xd8);
		          goto code_r0x81295592;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar4,Core_Application_IApp_TypeInfo,3);
		code_r0x81295592:
		    uVar1 = 0;
		    iVar5 = (**(code **)((ulonglong)*puVar3 * 4))(piVar4,puVar3[1]);
		    Gameplay_ResourceBar_View_ResourceBarView__TrySetupMVC(*(undefined4 *)(iVar5 + 0x3c),0);
		    uVar2 = unnamed_function_1417(System_Action_IGame__TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar2,param2,Method_Core_Gameplay_GameRestart_GameDeinitCompleteEvent__,0);
		    iVar5 = *param3;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xd0);
		          goto code_r0x8129563a;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(param3,Core_Gameplay_IGame_TypeInfo,2);
		code_r0x8129563a:
		    (**(code **)((ulonglong)*puVar3 * 4))(param3,uVar2,puVar3[1]);
		    uVar1 = 0;
		    iVar5 = *param3;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x100);
		          goto code_r0x812956b6;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(param3,Core_Gameplay_IGame_TypeInfo,8);
		code_r0x812956b6:
		    (**(code **)((ulonglong)*puVar3 * 4))(param3,puVar3[1]);
		  }
		  else {
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    func_ii_7830(StringLiteral_8441,0);
		    Cysharp_Threading_Tasks_UniTaskCompletionSource___ctor(*(undefined4 *)(param2 + 0xc),0);
		  }
		  Cysharp_Threading_Tasks_UniTaskCompletionSource__TrySetResult
		            (&local_8,*(undefined4 *)(param2 + 0xc),0);
		  *param1 = local_8;
		  return;
		}
		*/

		}

		// Token: 0x060066BE RID: 26302 RVA: 0x00013770 File Offset: 0x00011970
		[Token(Token = "0x60066BE")]
		[Address(RVA = "0xB23D", Offset = "0xB23D", VA = "0xB23D", Slot = "4")]
		public UniTask Restart(IGame game)
		{
		/* --- GHIDRA: Restart ---
		void Core_Gameplay_GameRestart__Restart(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  int *piVar3;
		  int iVar4;
		  int iVar5;
		  
		  if (DAT_ram_00a5a928 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Auth_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    DAT_ram_00a5a928 = '\x01';
		  }
		  piVar3 = *(int **)(param1 + 8);
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x160);
		        goto code_r0x812957b7;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Application_IApp_TypeInfo,0x14);
		code_r0x812957b7:
		  iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  piVar3 = *(int **)(param1 + 8);
		  param1_00 = unnamed_function_1417(Core_Gameplay_Auth_TypeInfo);
		  uVar1 = 0;
		  Core_Gameplay_Auth__Dispose(param1_00,piVar3,0);
		  iVar5 = *piVar3;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 400);
		        goto code_r0x81295855;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Application_IApp_TypeInfo,0x1a);
		code_r0x81295855:
		  (**(code **)((ulonglong)*puVar2 * 4))(piVar3,param1_00,puVar2[1]);
		  if (iVar4 != 0) {
		    Core_Gameplay_Auth__ToString(iVar4,puVar2);
		  }
		  return;
		}
		*/

			return default(UniTask);
		}

		// Token: 0x040036EA RID: 14058
		[Token(Token = "0x40036EA")]
		[FieldOffset(Offset = "0x8")]
		private readonly IApp _app;

		// Token: 0x040036EB RID: 14059
		[Token(Token = "0x40036EB")]
		[FieldOffset(Offset = "0xC")]
		private UniTaskCompletionSource _cs;
	}
}
