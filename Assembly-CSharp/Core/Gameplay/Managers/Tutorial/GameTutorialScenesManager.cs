using System;
using System.Runtime.CompilerServices;
using DefaultNamespace;
using Il2CppDummyDll;

namespace Core.Gameplay.Managers.Tutorial
{
	// Token: 0x02001182 RID: 4482
	[Token(Token = "0x2001182")]
	public class GameTutorialScenesManager : IGameManager, IBaseManager
	{
		// Token: 0x170015CA RID: 5578
		// (get) Token: 0x06006A68 RID: 27240 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170015CA")]
		public string Name
		{
			[Token(Token = "0x6006A68")]
			[Address(RVA = "0xB587", Offset = "0xB587", VA = "0xB587", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x140002AE RID: 686
		// (add) Token: 0x06006A69 RID: 27241 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006A6A RID: 27242 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002AE")]
		public event Action<IBaseManager> InitCompleteEvent
		{
			[Token(Token = "0x6006A69")]
			[Address(RVA = "0xB588", Offset = "0xB588", VA = "0xB588", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006A6A")]
			[Address(RVA = "0xB589", Offset = "0xB589", VA = "0xB589", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140002AF RID: 687
		// (add) Token: 0x06006A6B RID: 27243 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006A6C RID: 27244 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002AF")]
		public event Action<IBaseManager> DeinitCompleteEvent
		{
			[Token(Token = "0x6006A6B")]
			[Address(RVA = "0xB58A", Offset = "0xB58A", VA = "0xB58A", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006A6C")]
			[Address(RVA = "0xB58B", Offset = "0xB58B", VA = "0xB58B", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06006A6D RID: 27245 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A6D")]
		[Address(RVA = "0xB58C", Offset = "0xB58C", VA = "0xB58C")]
		public GameTutorialScenesManager(IGame game, Scenes[] scenes)
		{
		/* --- GHIDRA: .ctor ---
		void Core_Gameplay_Managers_Tutorial_GameTutorialScenesManager___ctor
		               (undefined4 param1,undefined4 param2)
		
		{
		  Core_Gameplay_Managers_Tutorial_GameTutorialScenesManager__Deinit(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06006A6E RID: 27246 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A6E")]
		[Address(RVA = "0xB58D", Offset = "0xB58D", VA = "0xB58D", Slot = "8")]
		public void Init()
		{
		/* --- GHIDRA: Init ---
		void Core_Gameplay_Managers_Tutorial_GameTutorialScenesManager__Init
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  int iVar1;
		  
		  if (DAT_ram_00a63891 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_string__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_Tutorial_GameTutorialScenesManager_SceneManagerOnSceneLoadedEvent__
		              );
		    DAT_ram_00a63891 = '\x01';
		  }
		  param1_00 = UI_Windows_PopupController__get_OpenedWindowsCount(0);
		  param1_01 = unnamed_function_1417(System_Action_string__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_01,param1,
		             Method_Core_Gameplay_Managers_Tutorial_GameTutorialScenesManager_SceneManagerOnSceneLoadedEvent__
		             ,0);
		  DefaultNamespace_SceneAppManager__add_SceneLoadedEvent(param1_00,param1_01,0);
		  iVar1 = *(int *)(param1 + 8);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		            (*(undefined4 *)(iVar1 + 0x20),param1,*(undefined4 *)(iVar1 + 0x14));
		  return;
		}
		*/

		}

		// Token: 0x06006A6F RID: 27247 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A6F")]
		[Address(RVA = "0xB58E", Offset = "0xB58E", VA = "0xB58E")]
		private void SceneManagerOnSceneLoadedEvent(string obj)
		{
		/* --- GHIDRA: SceneManagerOnSceneLoadedEvent ---
		void Core_Gameplay_Managers_Tutorial_GameTutorialScenesManager__SceneManagerOnSceneLoadedEvent
		               (int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  undefined4 param1_01;
		  int *piVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a63892 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_Tutorial_GameTutorialScenesManager_PopupControllerOnOnChangeStateEvent__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UI_Windows_PopupController_StateChanged_TypeInfo);
		    DAT_ram_00a63892 = '\x01';
		  }
		  piVar3 = *(int **)(param1 + 0x14);
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xe0);
		        goto code_r0x8230c6a1;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x8230c6a1:
		  piVar3 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  uVar1 = 0;
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xe8);
		        goto code_r0x8230c721;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Application_IApp_TypeInfo,5);
		code_r0x8230c721:
		  uVar1 = 0;
		  param1_00 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  param1_01 = unnamed_function_1417(UI_Windows_PopupController_StateChanged_TypeInfo);
		  UI_Windows_PopupController___ctor
		            (param1_01,param1,
		             Method_Core_Gameplay_Managers_Tutorial_GameTutorialScenesManager_PopupControllerOnOnChangeStateEvent__
		             ,0);
		  UI_Windows_PopupController__add_OnChangeStateEvent(param1_00,param1_01,0);
		  piVar3 = *(int **)(param1 + 0x14);
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xe0);
		        goto code_r0x8230c7cd;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x8230c7cd:
		  piVar3 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  uVar1 = 0;
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x138);
		        goto code_r0x8230c84f;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Application_IApp_TypeInfo,0xf);
		code_r0x8230c84f:
		  iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  Core_Dev_DevMenuUnlocker__Validate(*(undefined4 *)(iVar4 + 0x1c),0);
		  Core_Gameplay_Managers_Tutorial_GameTutorialScenesManager__Load
		            (param1,*(undefined4 *)(param1 + 0x10),puVar2);
		  *(undefined4 *)(param1 + 0x14) = 0;
		  return;
		}
		*/

		}

		// Token: 0x06006A70 RID: 27248 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A70")]
		[Address(RVA = "0xB58F", Offset = "0xB58F", VA = "0xB58F", Slot = "9")]
		public void Deinit()
		{
		/* --- GHIDRA: Deinit ---
		void Core_Gameplay_Managers_Tutorial_GameTutorialScenesManager__Deinit(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined4 param1_00;
		  int *piVar4;
		  int iVar5;
		  
		  if (DAT_ram_00a63893 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_Tutorial_GameTutorialScenesManager_PopupControllerOnOnChangeStateEvent__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UI_Windows_PopupController_StateChanged_TypeInfo);
		    DAT_ram_00a63893 = '\x01';
		  }
		  piVar4 = *(int **)(param1 + 0x14);
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xe0);
		        goto code_r0x8230c347;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x8230c347:
		  piVar4 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		  uVar1 = 0;
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xe8);
		        goto code_r0x8230c3c9;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar4,Core_Application_IApp_TypeInfo,5);
		code_r0x8230c3c9:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		  iVar5 = Core_Application_App__get_PopupController(uVar3,0);
		  if (iVar5 < 1) {
		    Core_Gameplay_Managers_Tutorial_GameTutorialScenesManager__ResolveLaunch
		              (param1,*(undefined4 *)(param1 + 0x10),puVar2);
		    return;
		  }
		  piVar4 = *(int **)(param1 + 0x14);
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xe0);
		        goto code_r0x8230c453;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x8230c453:
		  piVar4 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		  uVar1 = 0;
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xe8);
		        goto code_r0x8230c4d5;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar4,Core_Application_IApp_TypeInfo,5);
		code_r0x8230c4d5:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		  param1_00 = unnamed_function_1417(UI_Windows_PopupController_StateChanged_TypeInfo);
		  UI_Windows_PopupController___ctor
		            (param1_00,param1,
		             Method_Core_Gameplay_Managers_Tutorial_GameTutorialScenesManager_PopupControllerOnOnChangeStateEvent__
		             ,0);
		  UI_Windows_Layer___ctor(uVar3,param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x06006A71 RID: 27249 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A71")]
		[Address(RVA = "0xB590", Offset = "0xB590", VA = "0xB590")]
		private void ResolveLaunch()
		{
		/* --- GHIDRA: ResolveLaunch ---
		void Core_Gameplay_Managers_Tutorial_GameTutorialScenesManager__ResolveLaunch
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a63894 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_string__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_Tutorial_GameTutorialScenesManager_SceneManagerOnSceneLoadedEvent__
		              );
		    DAT_ram_00a63894 = '\x01';
		  }
		  uVar1 = UI_Windows_PopupController__get_OpenedWindowsCount(0);
		  param1_00 = unnamed_function_1417(System_Action_string__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Core_Gameplay_Managers_Tutorial_GameTutorialScenesManager_SceneManagerOnSceneLoadedEvent__
		             ,0);
		  Test_TestCameraController___ctor(uVar1,param1_00,0);
		  uVar1 = UI_Windows_PopupController__get_OpenedWindowsCount(0);
		  DefaultNamespace_SceneAppManager__RemoveScene(uVar1,param2,0);
		  return;
		}
		*/

		}

		// Token: 0x06006A72 RID: 27250 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A72")]
		[Address(RVA = "0xB591", Offset = "0xB591", VA = "0xB591")]
		private void Load(Scenes[] scenes)
		{
		/* --- GHIDRA: Load ---
		void Core_Gameplay_Managers_Tutorial_GameTutorialScenesManager__Load
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a63895 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_string__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_Tutorial_GameTutorialScenesManager_SceneManagerOnSceneUnLoaded__
		              );
		    DAT_ram_00a63895 = '\x01';
		  }
		  uVar1 = UI_Windows_PopupController__get_OpenedWindowsCount(0);
		  param1_00 = unnamed_function_1417(System_Action_string__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Core_Gameplay_Managers_Tutorial_GameTutorialScenesManager_SceneManagerOnSceneUnLoaded__
		             ,0);
		  DefaultNamespace_SceneAppManager__remove_SceneLoadedEvent(uVar1,param1_00,0);
		  uVar1 = UI_Windows_PopupController__get_OpenedWindowsCount(0);
		  DefaultNamespace_SceneAppManager__UnloadScene(uVar1,param2,0);
		  return;
		}
		*/

		}

		// Token: 0x06006A73 RID: 27251 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A73")]
		[Address(RVA = "0xB592", Offset = "0xB592", VA = "0xB592")]
		private void Unload(Scenes[] scenes)
		{
		/* --- GHIDRA: Unload ---
		void Core_Gameplay_Managers_Tutorial_GameTutorialScenesManager__Unload
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  undefined4 param1_01;
		  int *piVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a63896 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_Tutorial_GameTutorialScenesManager_PopupControllerOnOnChangeStateEvent__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UI_Windows_PopupController_StateChanged_TypeInfo);
		    DAT_ram_00a63896 = '\x01';
		  }
		  piVar3 = *(int **)(param1 + 0x14);
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xe0);
		        goto code_r0x8230c98f;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x8230c98f:
		  piVar3 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  uVar1 = 0;
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xe8);
		        goto code_r0x8230ca11;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Application_IApp_TypeInfo,5);
		code_r0x8230ca11:
		  param1_00 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  param1_01 = unnamed_function_1417(UI_Windows_PopupController_StateChanged_TypeInfo);
		  UI_Windows_PopupController___ctor
		            (param1_01,param1,
		             Method_Core_Gameplay_Managers_Tutorial_GameTutorialScenesManager_PopupControllerOnOnChangeStateEvent__
		             ,0);
		  UI_Windows_PopupController__add_OnChangeStateEvent(param1_00,param1_01,0);
		  Core_Gameplay_Managers_Tutorial_GameTutorialScenesManager__Deinit(param1,param1_00);
		  return;
		}
		*/

		}

		// Token: 0x06006A74 RID: 27252 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A74")]
		[Address(RVA = "0xB593", Offset = "0xB593", VA = "0xB593")]
		private void PopupControllerOnOnChangeStateEvent(int visibleFullscreenWndCount)
		{
		/* --- GHIDRA: PopupControllerOnOnChangeStateEvent ---
		void Core_Gameplay_Managers_Tutorial_GameTutorialScenesManager__PopupControllerOnOnChangeStateEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  int iVar1;
		  
		  if (DAT_ram_00a63897 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_string__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_Tutorial_GameTutorialScenesManager_SceneManagerOnSceneUnLoaded__
		              );
		    DAT_ram_00a63897 = '\x01';
		  }
		  param1_00 = UI_Windows_PopupController__get_OpenedWindowsCount(0);
		  param1_01 = unnamed_function_1417(System_Action_string__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_01,param1,
		             Method_Core_Gameplay_Managers_Tutorial_GameTutorialScenesManager_SceneManagerOnSceneUnLoaded__
		             ,0);
		  DefaultNamespace_SceneAppManager__add_SceneUnloadedEvent(param1_00,param1_01,0);
		  iVar1 = *(int *)(param1 + 0xc);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		            (*(undefined4 *)(iVar1 + 0x20),param1,*(undefined4 *)(iVar1 + 0x14));
		  return;
		}
		*/

		}

		// Token: 0x06006A75 RID: 27253 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A75")]
		[Address(RVA = "0xB594", Offset = "0xB594", VA = "0xB594")]
		private void SceneManagerOnSceneUnLoaded(string obj)
		{
		}

		// Token: 0x0400384D RID: 14413
		[Token(Token = "0x400384D")]
		[FieldOffset(Offset = "0x10")]
		private Scenes[] _scenes;

		// Token: 0x0400384E RID: 14414
		[Token(Token = "0x400384E")]
		[FieldOffset(Offset = "0x14")]
		private IGame _game;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Name ---
		void Core_Gameplay_Managers_Tutorial_GameTutorialScenesManager__get_Name
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a6388d == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a6388d = '\x01';
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
		void Core_Gameplay_Managers_Tutorial_GameTutorialScenesManager__add_InitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a6388e == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a6388e = '\x01';
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
		void Core_Gameplay_Managers_Tutorial_GameTutorialScenesManager__remove_InitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a6388f == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a6388f = '\x01';
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
		void Core_Gameplay_Managers_Tutorial_GameTutorialScenesManager__add_DeinitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a63890 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a63890 = '\x01';
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


		/* --- GHIDRA: remove_DeinitCompleteEvent ---
		void Core_Gameplay_Managers_Tutorial_GameTutorialScenesManager__remove_DeinitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  *(undefined4 *)(param1 + 0x10) = param3;
		  *(undefined4 *)(param1 + 0x14) = param2;
		  return;
		}
		*/

}
