using System;
using System.Runtime.CompilerServices;
using Gameplay.DailyQuests;
using Gameplay.DailyQuests.Controller;
using Gameplay.DailyQuests.Events;
using Gameplay.DailyQuests.Model;
using Gameplay.DailyQuests.View;
using Gameplay.UserInterface.View;
using Il2CppDummyDll;

namespace Core.Gameplay.Managers
{
	// Token: 0x02001162 RID: 4450
	[Token(Token = "0x2001162")]
	public class DailyQuestsManager : IGameManager, IBaseManager, IDailyQuestExtInfoPresenter
	{
		// Token: 0x1400027B RID: 635
		// (add) Token: 0x060068CA RID: 26826 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060068CB RID: 26827 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400027B")]
		public event Action<IBaseManager> InitCompleteEvent
		{
			[Token(Token = "0x60068CA")]
			[Address(RVA = "0xB3F0", Offset = "0xB3F0", VA = "0xB3F0", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60068CB")]
			[Address(RVA = "0xB3F1", Offset = "0xB3F1", VA = "0xB3F1", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400027C RID: 636
		// (add) Token: 0x060068CC RID: 26828 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060068CD RID: 26829 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400027C")]
		public event Action<IBaseManager> DeinitCompleteEvent
		{
			[Token(Token = "0x60068CC")]
			[Address(RVA = "0xB3F2", Offset = "0xB3F2", VA = "0xB3F2", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60068CD")]
			[Address(RVA = "0xB3F3", Offset = "0xB3F3", VA = "0xB3F3", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x060068CE RID: 26830 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60068CE")]
		[Address(RVA = "0xB3F4", Offset = "0xB3F4", VA = "0xB3F4", Slot = "8")]
		public void Init()
		{
		}

		// Token: 0x17001570 RID: 5488
		// (get) Token: 0x060068CF RID: 26831 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060068D0 RID: 26832 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001570")]
		public DailyQuestsController Controller
		{
			[Token(Token = "0x60068CF")]
			[Address(RVA = "0xB3F5", Offset = "0xB3F5", VA = "0xB3F5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60068D0")]
			[Address(RVA = "0xB3F6", Offset = "0xB3F6", VA = "0xB3F6")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001571 RID: 5489
		// (get) Token: 0x060068D1 RID: 26833 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060068D2 RID: 26834 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001571")]
		public DailyQuestEvents Events
		{
			[Token(Token = "0x60068D1")]
			[Address(RVA = "0xB3F7", Offset = "0xB3F7", VA = "0xB3F7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60068D2")]
			[Address(RVA = "0xB3F8", Offset = "0xB3F8", VA = "0xB3F8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001572 RID: 5490
		// (get) Token: 0x060068D3 RID: 26835 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060068D4 RID: 26836 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001572")]
		public DailyQuestsModel Model
		{
			[Token(Token = "0x60068D3")]
			[Address(RVA = "0xB3F9", Offset = "0xB3F9", VA = "0xB3F9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60068D4")]
			[Address(RVA = "0xB3FA", Offset = "0xB3FA", VA = "0xB3FA")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060068D5 RID: 26837 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60068D5")]
		[Address(RVA = "0xB3FB", Offset = "0xB3FB", VA = "0xB3FB", Slot = "9")]
		public void Deinit()
		{
		/* --- GHIDRA: Deinit ---
		void Core_Gameplay_Managers_DailyQuestsManager__Deinit
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = **(int **)(param1 + 0x10);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x160) * 4))
		            (*(int **)(param1 + 0x10),param2,*(undefined4 *)(iVar1 + 0x164));
		  return;
		}
		*/

		}

		// Token: 0x060068D6 RID: 26838 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60068D6")]
		[Address(RVA = "0xB3FC", Offset = "0xB3FC", VA = "0xB3FC")]
		public void SetView(UserInterfaceView view)
		{
		/* --- GHIDRA: SetView ---
		undefined4
		Core_Gameplay_Managers_DailyQuestsManager__SetView(int param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  int iVar5;
		  undefined4 uVar6;
		  
		  if (DAT_ram_00a637a9 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_DailyQuests_View_DailyQuestsWindowArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_PopupController_Show_DailyQuestsWindow___);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12608);
		    DAT_ram_00a637a9 = '\x01';
		  }
		  piVar4 = *(int **)(*(int *)(param1 + 0x1c) + 0x10);
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xe0);
		        goto code_r0x822fedd8;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x822fedd8:
		  piVar4 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		  uVar1 = 0;
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xe8);
		        goto code_r0x822fee5a;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar4,Core_Application_IApp_TypeInfo,5);
		code_r0x822fee5a:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		  iVar5 = unnamed_function_1417(Gameplay_DailyQuests_View_DailyQuestsWindowArgs_TypeInfo);
		  Gameplay_AccountLinker_View_SelectUserWindow___ctor(iVar5,0);
		  uVar6 = *(undefined4 *)(param1 + 0x14);
		  *(undefined4 *)(iVar5 + 0x1c) = param2;
		  *(undefined4 *)(iVar5 + 0x18) = uVar6;
		  uVar3 = Gameplay_Antiq_View_GroupReviewWindow_WindowArgs___ctor
		                    (uVar3,StringLiteral_12608,iVar5,
		                     Method_UI_Windows_PopupController_Show_DailyQuestsWindow___);
		  return uVar3;
		}
		*/

		}

		// Token: 0x060068D7 RID: 26839 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60068D7")]
		[Address(RVA = "0xB3FD", Offset = "0xB3FD", VA = "0xB3FD")]
		public DailyQuestsWindow ShowDailyQuestsWindow(uint categoryId = 0U)
		{
		/* --- GHIDRA: ShowDailyQuestsWindow ---
		undefined4
		Core_Gameplay_Managers_DailyQuestsManager__ShowDailyQuestsWindow
		          (int param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int *piVar5;
		  
		  if (DAT_ram_00a637aa == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_DailyQuests_View_DailyQuestReadViewWindowArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_PopupController_Show_DailyQuestReadViewWindow___);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12607);
		    DAT_ram_00a637aa = '\x01';
		  }
		  iVar4 = *(int *)(param1 + 0x1c);
		  *(undefined4 *)(iVar4 + 0x20) = param2;
		  piVar5 = *(int **)(iVar4 + 0x10);
		  iVar4 = *piVar5;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xe0);
		        goto code_r0x822fef6b;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x822fef6b:
		  piVar5 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		  uVar1 = 0;
		  iVar4 = *piVar5;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xe8);
		        goto code_r0x822fefed;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar5,Core_Application_IApp_TypeInfo,5);
		code_r0x822fefed:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		  iVar4 = unnamed_function_1417(Gameplay_DailyQuests_View_DailyQuestReadViewWindowArgs_TypeInfo);
		  Gameplay_AccountLinker_View_SelectUserWindow___ctor(iVar4,0);
		  *(undefined4 *)(iVar4 + 0x18) = *(undefined4 *)(param1 + 0x14);
		  uVar3 = Gameplay_Antiq_View_GroupReviewWindow_WindowArgs___ctor
		                    (uVar3,StringLiteral_12607,iVar4,
		                     Method_UI_Windows_PopupController_Show_DailyQuestReadViewWindow___);
		  return uVar3;
		}
		*/

			return null;
		}

		// Token: 0x060068D8 RID: 26840 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60068D8")]
		[Address(RVA = "0xB3FE", Offset = "0xB3FE", VA = "0xB3FE", Slot = "11")]
		public DailyQuestReadViewWindow ShowDailyQuestInfoWindow(IQuest quest)
		{
		/* --- GHIDRA: ShowDailyQuestInfoWindow ---
		undefined4
		Core_Gameplay_Managers_DailyQuestsManager__ShowDailyQuestInfoWindow
		          (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a637ab == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_6258);
		    DAT_ram_00a637ab = '\x01';
		  }
		  return StringLiteral_6258;
		}
		*/

			return null;
		}

		// Token: 0x17001573 RID: 5491
		// (get) Token: 0x060068D9 RID: 26841 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001573")]
		public string Name
		{
			[Token(Token = "0x60068D9")]
			[Address(RVA = "0xB3FF", Offset = "0xB3FF", VA = "0xB3FF", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x060068DA RID: 26842 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60068DA")]
		[Address(RVA = "0xB400", Offset = "0xB400", VA = "0xB400")]
		public DailyQuestsManager()
		{
		/* --- GHIDRA: .ctor ---
		void Core_Gameplay_Managers_DailyQuestsManager___ctor
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a637ac == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a637ac = '\x01';
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

		}

		// Token: 0x040037AE RID: 14254
		[Token(Token = "0x40037AE")]
		[FieldOffset(Offset = "0x10")]
		private DailyQuestsEnterPointViewMediator _mediator;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_InitCompleteEvent ---
		void Core_Gameplay_Managers_DailyQuestsManager__add_InitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a637a5 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a637a5 = '\x01';
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
		void Core_Gameplay_Managers_DailyQuestsManager__remove_InitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a637a6 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a637a6 = '\x01';
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
		void Core_Gameplay_Managers_DailyQuestsManager__add_DeinitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a637a7 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a637a7 = '\x01';
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
		void Core_Gameplay_Managers_DailyQuestsManager__remove_DeinitCompleteEvent
		               (int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  undefined4 uVar5;
		  int *piVar6;
		  int iVar7;
		  undefined4 uVar8;
		  undefined4 param4;
		  
		  if (DAT_ram_00a637a8 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_DailyQuests_Events_DailyQuestEvents_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_DailyQuests_Controller_DailyQuestsController_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_DailyQuests_Controller_DailyQuestsEnterPointViewMediator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_DailyQuests_Model_DailyQuestsModel_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_DailyQuests_Controller_QuestsTriggerObserver_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_DailyQuestsService___);
		    Mono_Security_ASN1__get_Item(&Core_Net_ServiceFactory_TypeInfo);
		    DAT_ram_00a637a8 = '\x01';
		  }
		  uVar2 = unnamed_function_1417(Gameplay_DailyQuests_Events_DailyQuestEvents_TypeInfo);
		  *(undefined4 *)(param1 + 0x18) = uVar2;
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  piVar6 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x140);
		        goto code_r0x822fe9a4;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x822fe9a4:
		  uVar2 = 0;
		  iVar7 = (**(code **)((ulonglong)*puVar3 * 4))(piVar6,puVar3[1]);
		  if (*(int *)(iVar7 + 0x14) != 0) {
		    uVar2 = *(undefined4 *)(*(int *)(iVar7 + 0x14) + 8);
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  piVar6 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x178);
		        goto code_r0x822fea61;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x822fea61:
		  uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(piVar6,puVar3[1]);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar8 = **(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar7 = unnamed_function_1417(Gameplay_DailyQuests_Model_DailyQuestsModel_TypeInfo);
		  Gameplay_DailyQuests_Model_DailyQuestsModel__Dispose(iVar7,uVar2,uVar4,uVar8,0);
		  *(int *)(param1 + 0x1c) = iVar7;
		  piVar6 = *(int **)(iVar7 + 0xc);
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0xd0);
		        goto code_r0x822feb34;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar6,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x822feb34:
		  uVar1 = 0;
		  uVar2 = (**(code **)((ulonglong)*puVar3 * 4))(piVar6,puVar3[1]);
		  uVar4 = *(undefined4 *)(*(int *)(param1 + 0x1c) + 8);
		  piVar6 = *(int **)(*(int *)(param1 + 0x1c) + 0x10);
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x160);
		        goto code_r0x822febc5;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x14);
		code_r0x822febc5:
		  uVar8 = (**(code **)((ulonglong)*puVar3 * 4))(piVar6,puVar3[1]);
		  uVar5 = unnamed_function_1417(Gameplay_DailyQuests_Controller_QuestsTriggerObserver_TypeInfo);
		  Gameplay_DailyQuests_Controller_QuestsTriggerObserver__ClearGoalsBlackList
		            (uVar5,uVar2,uVar4,uVar8,0);
		  if (*(int *)(Core_Net_ServiceFactory_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_ServiceFactory_TypeInfo);
		  }
		  uVar2 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                    (Method_Core_Net_ServiceFactory_GetService_DailyQuestsService___);
		  uVar8 = *(undefined4 *)(param1 + 0x18);
		  param4 = *(undefined4 *)(param1 + 0x1c);
		  uVar4 = unnamed_function_1417(Gameplay_DailyQuests_Controller_DailyQuestsController_TypeInfo);
		  Gameplay_DailyQuests_Controller_DailyQuestsController__Dispose(uVar4,uVar5,uVar2,param4,uVar8,0);
		  *(undefined4 *)(param1 + 0x14) = uVar4;
		  uVar8 = *(undefined4 *)(param1 + 0x1c);
		  uVar5 = *(undefined4 *)(param1 + 0x18);
		  uVar2 = unnamed_function_1417
		                    (Gameplay_DailyQuests_Controller_DailyQuestsEnterPointViewMediator_TypeInfo);
		  Gameplay_DailyQuests_Controller_DailyQuestsController___c___GetDailyQuestsServiceHandler_b__26_0
		            (uVar2,uVar8,uVar5,uVar4,0);
		  *(undefined4 *)(param1 + 0x10) = uVar2;
		  MVC_AbstractController__Dispose(*(undefined4 *)(param1 + 0x14),0);
		  iVar7 = *(int *)(param1 + 8);
		  (**(code **)((ulonglong)*(uint *)(iVar7 + 0xc) * 4))
		            (*(undefined4 *)(iVar7 + 0x20),param1,*(undefined4 *)(iVar7 + 0x14));
		  return;
		}
		*/


		/* --- GHIDRA: set_Model ---
		void Core_Gameplay_Managers_DailyQuestsManager__set_Model(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  MVC_AbstractController__Run(*(undefined4 *)(param1 + 0x14),0);
		  iVar1 = **(int **)(param1 + 0x1c);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xe8) * 4))
		            (*(int **)(param1 + 0x1c),*(undefined4 *)(iVar1 + 0xec));
		  iVar1 = **(int **)(param1 + 0x14);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xe8) * 4))
		            (*(int **)(param1 + 0x14),*(undefined4 *)(iVar1 + 0xec));
		  iVar1 = **(int **)(param1 + 0x10);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x130) * 4))
		            (*(int **)(param1 + 0x10),*(undefined4 *)(iVar1 + 0x134));
		  *(undefined8 *)(param1 + 0x18) = 0;
		  *(undefined8 *)(param1 + 0x10) = 0;
		  iVar1 = *(int *)(param1 + 0xc);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		            (*(undefined4 *)(iVar1 + 0x20),param1,*(undefined4 *)(iVar1 + 0x14));
		  return;
		}
		*/

}
