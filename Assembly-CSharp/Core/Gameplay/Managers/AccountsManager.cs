using System;
using System.Runtime.CompilerServices;
using Gameplay.Accounts.Control;
using Gameplay.Accounts.Model;
using Gameplay.Accounts.Model.Data;
using Il2CppDummyDll;

namespace Core.Gameplay.Managers
{
	// Token: 0x0200113A RID: 4410
	[Token(Token = "0x200113A")]
	public class AccountsManager : IGameManager, IBaseManager
	{
		// Token: 0x14000254 RID: 596
		// (add) Token: 0x06006752 RID: 26450 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006753 RID: 26451 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000254")]
		public event Action<IBaseManager> InitCompleteEvent
		{
			[Token(Token = "0x6006752")]
			[Address(RVA = "0xB27E", Offset = "0xB27E", VA = "0xB27E", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006753")]
			[Address(RVA = "0xB27F", Offset = "0xB27F", VA = "0xB27F", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000255 RID: 597
		// (add) Token: 0x06006754 RID: 26452 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006755 RID: 26453 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000255")]
		public event Action<IBaseManager> DeinitCompleteEvent
		{
			[Token(Token = "0x6006754")]
			[Address(RVA = "0xB280", Offset = "0xB280", VA = "0xB280", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006755")]
			[Address(RVA = "0xB281", Offset = "0xB281", VA = "0xB281", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17001528 RID: 5416
		// (get) Token: 0x06006756 RID: 26454 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001528")]
		public string Name
		{
			[Token(Token = "0x6006756")]
			[Address(RVA = "0xB282", Offset = "0xB282", VA = "0xB282", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001529 RID: 5417
		// (get) Token: 0x06006757 RID: 26455 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006758 RID: 26456 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001529")]
		public IGame Game
		{
			[Token(Token = "0x6006757")]
			[Address(RVA = "0xB283", Offset = "0xB283", VA = "0xB283")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006758")]
			[Address(RVA = "0xB284", Offset = "0xB284", VA = "0xB284")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700152A RID: 5418
		// (get) Token: 0x06006759 RID: 26457 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600675A RID: 26458 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700152A")]
		public AccountsController Controller
		{
			[Token(Token = "0x6006759")]
			[Address(RVA = "0xB285", Offset = "0xB285", VA = "0xB285")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600675A")]
			[Address(RVA = "0xB286", Offset = "0xB286", VA = "0xB286")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600675B RID: 26459 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600675B")]
		[Address(RVA = "0xB287", Offset = "0xB287", VA = "0xB287")]
		public AccountsManager(IGame game)
		{
		/* --- GHIDRA: .ctor ---
		void Core_Gameplay_Managers_AccountsManager___ctor(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  MVC_AbstractController__Run(*(undefined4 *)(param1 + 0x14),0);
		  iVar1 = **(int **)(param1 + 0x14);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xe8) * 4))
		            (*(int **)(param1 + 0x14),*(undefined4 *)(iVar1 + 0xec));
		  iVar1 = **(int **)(param1 + 0x18);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xe8) * 4))
		            (*(int **)(param1 + 0x18),*(undefined4 *)(iVar1 + 0xec));
		  *(undefined4 *)(param1 + 0x18) = 0;
		  *(undefined8 *)(param1 + 0x10) = 0;
		  iVar1 = *(int *)(param1 + 0xc);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		            (*(undefined4 *)(iVar1 + 0x20),param1,*(undefined4 *)(iVar1 + 0x14));
		  return;
		}
		*/

		}

		// Token: 0x0600675C RID: 26460 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600675C")]
		[Address(RVA = "0xB288", Offset = "0xB288", VA = "0xB288", Slot = "9")]
		public void Deinit()
		{
		/* --- GHIDRA: Deinit ---
		void Core_Gameplay_Managers_AccountsManager__Deinit(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  undefined4 uVar5;
		  undefined4 param6;
		  int *piVar6;
		  int iVar7;
		  undefined4 uVar8;
		  undefined4 *puVar9;
		  int param1_00;
		  
		  if (DAT_ram_00a5a95b == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Accounts_Control_AccountsController_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Accounts_AccountsEvents_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Accounts_Model_AccountsModel_GetAccount_BattleAccount___);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Accounts_Model_AccountsModel_GetAccount_ClanAccountGroup___);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Accounts_Model_AccountsModel_GetAccount_ManufactureAccount___);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Accounts_Model_AccountsModel_GetAccount_TradeAccount___);
		    Mono_Security_ASN1__get_Item(&Gameplay_Accounts_Model_AccountsModel_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Comparison_IAccountDataDecorator__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_FirstOrDefault_AccountDic___);
		    Mono_Security_ASN1__get_Item(&System_Func_AccountDic__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_IAccountDataDecorator__Sort__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_ServicesService___);
		    Mono_Security_ASN1__get_Item(&Core_Net_ServiceFactory_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Gameplay_Managers_AccountsManager___c__Init_b__19_0__)
		    ;
		    Mono_Security_ASN1__get_Item(&Method_Core_Gameplay_Managers_AccountsManager___c__Init_b__19_1__)
		    ;
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_AccountsManager___c_TypeInfo);
		    DAT_ram_00a5a95b = '\x01';
		  }
		  piVar6 = *(int **)(param1 + 0x10);
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x178);
		        goto code_r0x8129c54e;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x8129c54e:
		  uVar1 = 0;
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar6,puVar2[1]);
		  iVar7 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar3,0);
		  uVar3 = *(undefined4 *)(iVar7 + 0x134);
		  piVar6 = *(int **)(param1 + 0x10);
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x178);
		        goto code_r0x8129c5dd;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x8129c5dd:
		  uVar1 = 0;
		  uVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar6,puVar2[1]);
		  piVar6 = *(int **)(param1 + 0x10);
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x230);
		        goto code_r0x8129c662;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x2e);
		code_r0x8129c662:
		  iVar7 = (**(code **)((ulonglong)*puVar2 * 4))(piVar6,puVar2[1]);
		  uVar8 = *(undefined4 *)(iVar7 + 0x10);
		  uVar1 = 0;
		  piVar6 = *(int **)(param1 + 0x10);
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x140);
		        goto code_r0x8129c6ea;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x8129c6ea:
		  uVar1 = 0;
		  uVar5 = (**(code **)((ulonglong)*puVar2 * 4))(piVar6,puVar2[1]);
		  uVar5 = func_ii_7112(uVar5,0);
		  piVar6 = *(int **)(param1 + 0x10);
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 400);
		        goto code_r0x8129c775;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x1a);
		code_r0x8129c775:
		  uVar1 = 0;
		  param6 = (**(code **)((ulonglong)*puVar2 * 4))(piVar6,puVar2[1]);
		  iVar7 = unnamed_function_1417(Gameplay_Accounts_Model_AccountsModel_TypeInfo);
		  Gameplay_Accounts_Model_AccountsModel__Dispose(iVar7,uVar3,uVar4,uVar8,uVar5,param6,0);
		  *(int *)(param1 + 0x18) = iVar7;
		  uVar3 = Core_Net_AbstractService__LogEvent___Il2CppFullySharedGenericStructType_
		                    (iVar7,5,Method_Gameplay_Accounts_Model_AccountsModel_GetAccount_TradeAccount___
		                    );
		  *(undefined4 *)(iVar7 + 0x30) = uVar3;
		  iVar7 = *(int *)(param1 + 0x18);
		  uVar3 = Core_Net_AbstractService__LogEvent___Il2CppFullySharedGenericStructType_
		                    (iVar7,1,
		                     Method_Gameplay_Accounts_Model_AccountsModel_GetAccount_BattleAccount___);
		  *(undefined4 *)(iVar7 + 0x28) = uVar3;
		  iVar7 = *(int *)(param1 + 0x18);
		  uVar3 = Core_Net_AbstractService__LogEvent___Il2CppFullySharedGenericStructType_
		                    (iVar7,3,
		                     Method_Gameplay_Accounts_Model_AccountsModel_GetAccount_ManufactureAccount___);
		  *(undefined4 *)(iVar7 + 0x2c) = uVar3;
		  piVar6 = *(int **)(param1 + 0x10);
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x178);
		        goto code_r0x8129c867;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x8129c867:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar6,puVar2[1]);
		  iVar7 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar3,0);
		  uVar3 = *(undefined4 *)(iVar7 + 0x6c);
		  if (*(int *)(Core_Gameplay_Managers_AccountsManager___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Gameplay_Managers_AccountsManager___c_TypeInfo);
		  }
		  puVar9 = *(undefined4 **)(Core_Gameplay_Managers_AccountsManager___c_TypeInfo + 0x5c);
		  iVar7 = puVar9[1];
		  if (iVar7 == 0) {
		    if (*(int *)(Core_Gameplay_Managers_AccountsManager___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Gameplay_Managers_AccountsManager___c_TypeInfo);
		      puVar9 = *(undefined4 **)(Core_Gameplay_Managers_AccountsManager___c_TypeInfo + 0x5c);
		    }
		    uVar4 = *puVar9;
		    iVar7 = unnamed_function_1417(System_Func_AccountDic__bool__TypeInfo);
		    System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		              (iVar7,uVar4,Method_Core_Gameplay_Managers_AccountsManager___c__Init_b__19_0__,0);
		    *(int *)(*(int *)(Core_Gameplay_Managers_AccountsManager___c_TypeInfo + 0x5c) + 4) = iVar7;
		  }
		  iVar7 = System_Func_object__bool____ctor
		                    (uVar3,iVar7,Method_System_Linq_Enumerable_FirstOrDefault_AccountDic___);
		  if (iVar7 != 0) {
		    param1_00 = *(int *)(param1 + 0x18);
		    uVar3 = Core_Net_AbstractService__LogEvent___Il2CppFullySharedGenericStructType_
		                      (param1_00,*(undefined4 *)(iVar7 + 0xc),
		                       Method_Gameplay_Accounts_Model_AccountsModel_GetAccount_ClanAccountGroup___);
		    *(undefined4 *)(param1_00 + 0x34) = uVar3;
		  }
		  uVar3 = *(undefined4 *)(*(int *)(param1 + 0x18) + 0x18);
		  if (*(int *)(Core_Gameplay_Managers_AccountsManager___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Gameplay_Managers_AccountsManager___c_TypeInfo);
		  }
		  puVar9 = *(undefined4 **)(Core_Gameplay_Managers_AccountsManager___c_TypeInfo + 0x5c);
		  iVar7 = puVar9[2];
		  if (iVar7 == 0) {
		    if (*(int *)(Core_Gameplay_Managers_AccountsManager___c_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Gameplay_Managers_AccountsManager___c_TypeInfo);
		      puVar9 = *(undefined4 **)(Core_Gameplay_Managers_AccountsManager___c_TypeInfo + 0x5c);
		    }
		    uVar4 = *puVar9;
		    iVar7 = unnamed_function_1417(System_Comparison_IAccountDataDecorator__TypeInfo);
		    System_Collections_Generic_Comparer_object___get_Default
		              (iVar7,uVar4,Method_Core_Gameplay_Managers_AccountsManager___c__Init_b__19_1__,0);
		    *(int *)(*(int *)(Core_Gameplay_Managers_AccountsManager___c_TypeInfo + 0x5c) + 8) = iVar7;
		  }
		  Google_Protobuf_Collections_RepeatedField_uint___Contains
		            (uVar3,iVar7,Method_System_Collections_Generic_List_IAccountDataDecorator__Sort__);
		  if (*(int *)(Core_Net_ServiceFactory_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_ServiceFactory_TypeInfo);
		  }
		  uVar3 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                    (Method_Core_Net_ServiceFactory_GetService_ServicesService___);
		  uVar5 = *(undefined4 *)(param1 + 0x18);
		  uVar4 = unnamed_function_1417(Gameplay_Accounts_AccountsEvents_TypeInfo);
		  uVar8 = unnamed_function_1417(Gameplay_Accounts_Control_AccountsController_TypeInfo);
		  Gameplay_Accounts_Control_AccountsController__Dispose(uVar8,uVar3,uVar5,uVar4,0);
		  *(undefined4 *)(param1 + 0x14) = uVar8;
		  MVC_AbstractController__Dispose(uVar8,0);
		  iVar7 = *(int *)(param1 + 8);
		  (**(code **)((ulonglong)*(uint *)(iVar7 + 0xc) * 4))
		            (*(undefined4 *)(iVar7 + 0x20),param1,*(undefined4 *)(iVar7 + 0x14));
		  return;
		}
		*/

		}

		// Token: 0x0600675D RID: 26461 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600675D")]
		[Address(RVA = "0xB289", Offset = "0xB289", VA = "0xB289", Slot = "8")]
		public void Init()
		{
		/* --- GHIDRA: Init ---
		void Core_Gameplay_Managers_AccountsManager__Init(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int param1_00;
		  
		  if (DAT_ram_00a5a95c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Accounts_View_AccountsListWindow_AccountsListWindowsArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_PopupController_Show_AccountsListWindow___);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12554);
		    DAT_ram_00a5a95c = '\x01';
		  }
		  uVar1 = System_Uri___ctor(0);
		  uVar1 = System_Globalization_TimeSpanFormat_FormatLiterals__get_Start(uVar1,0);
		  param1_00 = unnamed_function_1417
		                        (Gameplay_Accounts_View_AccountsListWindow_AccountsListWindowsArgs_TypeInfo)
		  ;
		  Gameplay_AccountLinker_View_SelectUserWindow___ctor(param1_00,0);
		  *(undefined4 *)(param1_00 + 0x18) = *(undefined4 *)(param1 + 0x14);
		  Gameplay_Antiq_View_GroupReviewWindow_WindowArgs___ctor
		            (uVar1,StringLiteral_12554,param1_00,
		             Method_UI_Windows_PopupController_Show_AccountsListWindow___);
		  return;
		}
		*/

		}

		// Token: 0x0600675E RID: 26462 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600675E")]
		[Address(RVA = "0xB28A", Offset = "0xB28A", VA = "0xB28A")]
		public void ShowAccountsListWindow()
		{
		/* --- GHIDRA: ShowAccountsListWindow ---
		void Core_Gameplay_Managers_AccountsManager__ShowAccountsListWindow
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int param2_00;
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a5a95d == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_AccountsManager___c__DisplayClass21_0__ShowAccountWindow_b__0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Core_Gameplay_Managers_AccountsManager___c__DisplayClass21_0_TypeInfo);
		    DAT_ram_00a5a95d = '\x01';
		  }
		  param2_00 = unnamed_function_1417
		                        (Core_Gameplay_Managers_AccountsManager___c__DisplayClass21_0_TypeInfo);
		  *(undefined4 *)(param2_00 + 0xc) = param2;
		  *(int *)(param2_00 + 8) = param1;
		  param1_00 = Gameplay_Accounts_Control_AccountsController__UpdatePromotion
		                        (*(undefined4 *)(param1 + 0x14),0);
		  param1_01 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_01,param2_00,
		             Method_Core_Gameplay_Managers_AccountsManager___c__DisplayClass21_0__ShowAccountWindow_b__0__
		             ,0);
		  ServicesNamespace_MainService__GetUserStats
		            (param1_00,param1_01,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  return;
		}
		*/

		}

		// Token: 0x0600675F RID: 26463 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600675F")]
		[Address(RVA = "0xB28B", Offset = "0xB28B", VA = "0xB28B")]
		public void ShowAccountWindow(IAccountDataDecorator account)
		{
		/* --- GHIDRA: ShowAccountWindow ---
		uint Core_Gameplay_Managers_AccountsManager__ShowAccountWindow
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int *piVar1;
		  uint uVar2;
		  int iVar3;
		  uint *param3_00;
		  int *local_4;
		  
		  uVar2 = 0;
		  if (DAT_ram_00a5a95e == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Accounts_Model_Data_IAccountDataDecorator_TypeInfo);
		    DAT_ram_00a5a95e = '\x01';
		  }
		  local_4 = (int *)0x0;
		  iVar3 = func_ii_7485(*(undefined4 *)(param1 + 0x18),param2,&local_4,0);
		  piVar1 = local_4;
		  if (iVar3 != 0) {
		    iVar3 = *local_4;
		    if (*(ushort *)(iVar3 + 0xb6) != 0) {
		      do {
		        if (Gameplay_Accounts_Model_Data_IAccountDataDecorator_TypeInfo ==
		            *(int *)(*(int *)(iVar3 + 0x58) + uVar2 * 8)) {
		          param3_00 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar2 * 8 + 4) * 8 + iVar3 + 200);
		          goto code_r0x8129cc09;
		        }
		        uVar2 = uVar2 + 1;
		      } while (*(ushort *)(iVar3 + 0xb6) != uVar2);
		    }
		    param3_00 = (uint *)func_ii_1080(local_4,
		                                     Gameplay_Accounts_Model_Data_IAccountDataDecorator_TypeInfo,1);
		code_r0x8129cc09:
		    iVar3 = (**(code **)((ulonglong)*param3_00 * 4))(piVar1,param3_00[1]);
		    if (*(int *)(iVar3 + 0x10) == 2) {
		      iVar3 = *(int *)(*(int *)(param1 + 0x18) + 0x34);
		      if (iVar3 == 0) {
		        return 0;
		      }
		      Core_Gameplay_Managers_AccountsManager__ShowAccountsListWindow(param1,iVar3,iVar3);
		    }
		    else {
		      Core_Gameplay_Managers_AccountsManager__ShowAccountsListWindow(param1,local_4,param3_00);
		    }
		    uVar2 = 1;
		  }
		  return uVar2;
		}
		*/

		}

		// Token: 0x06006760 RID: 26464 RVA: 0x000137E8 File Offset: 0x000119E8
		[Token(Token = "0x6006760")]
		[Address(RVA = "0xB28C", Offset = "0xB28C", VA = "0xB28C")]
		public bool TryShowAccountWindow(uint accountId)
		{
		/* --- GHIDRA: TryShowAccountWindow ---
		uint Core_Gameplay_Managers_AccountsManager__TryShowAccountWindow(int param1,undefined4 param2)
		
		{
		  int param2_00;
		  
		  param2_00 = *(int *)(*(int *)(param1 + 0x18) + 0x34);
		  if (param2_00 != 0) {
		    Core_Gameplay_Managers_AccountsManager__ShowAccountsListWindow(param1,param2_00,param1);
		  }
		  return (uint)(param2_00 != 0);
		}
		*/

			return default(bool);
		}

		// Token: 0x06006761 RID: 26465 RVA: 0x00013800 File Offset: 0x00011A00
		[Token(Token = "0x6006761")]
		[Address(RVA = "0xB28D", Offset = "0xB28D", VA = "0xB28D")]
		public bool TryShowClanAccountsWindow()
		{
		/* --- GHIDRA: TryShowClanAccountsWindow ---
		void Core_Gameplay_Managers_AccountsManager__TryShowClanAccountsWindow(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5a95f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Managers_AccountsManager___c_TypeInfo);
		    DAT_ram_00a5a95f = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Core_Gameplay_Managers_AccountsManager___c_TypeInfo);
		  **(undefined4 **)(Core_Gameplay_Managers_AccountsManager___c_TypeInfo + 0x5c) = uVar1;
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x0400372F RID: 14127
		[Token(Token = "0x400372F")]
		[FieldOffset(Offset = "0x18")]
		private AccountsModel _model;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_InitCompleteEvent ---
		void Core_Gameplay_Managers_AccountsManager__add_InitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a957 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a5a957 = '\x01';
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
		void Core_Gameplay_Managers_AccountsManager__remove_InitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a958 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a5a958 = '\x01';
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
		void Core_Gameplay_Managers_AccountsManager__add_DeinitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a959 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a5a959 = '\x01';
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
		undefined4
		Core_Gameplay_Managers_AccountsManager__remove_DeinitCompleteEvent
		          (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5a95a == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_2869);
		    DAT_ram_00a5a95a = '\x01';
		  }
		  return StringLiteral_2869;
		}
		*/

}
