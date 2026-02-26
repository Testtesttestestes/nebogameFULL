using System;
using System.Runtime.CompilerServices;
using Gameplay.Competition.Control;
using Il2CppDummyDll;

namespace Core.Gameplay.Managers
{
	// Token: 0x02001161 RID: 4449
	[Token(Token = "0x2001161")]
	public class CompetitionManager : IGameManager, IBaseManager
	{
		// Token: 0x1700156E RID: 5486
		// (get) Token: 0x060068BF RID: 26815 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700156E")]
		public string Name
		{
			[Token(Token = "0x60068BF")]
			[Address(RVA = "0xB3E5", Offset = "0xB3E5", VA = "0xB3E5", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x14000279 RID: 633
		// (add) Token: 0x060068C0 RID: 26816 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060068C1 RID: 26817 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000279")]
		public event Action<IBaseManager> InitCompleteEvent
		{
			[Token(Token = "0x60068C0")]
			[Address(RVA = "0xB3E6", Offset = "0xB3E6", VA = "0xB3E6", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60068C1")]
			[Address(RVA = "0xB3E7", Offset = "0xB3E7", VA = "0xB3E7", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400027A RID: 634
		// (add) Token: 0x060068C2 RID: 26818 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060068C3 RID: 26819 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400027A")]
		public event Action<IBaseManager> DeinitCompleteEvent
		{
			[Token(Token = "0x60068C2")]
			[Address(RVA = "0xB3E8", Offset = "0xB3E8", VA = "0xB3E8", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60068C3")]
			[Address(RVA = "0xB3E9", Offset = "0xB3E9", VA = "0xB3E9", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1700156F RID: 5487
		// (get) Token: 0x060068C4 RID: 26820 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060068C5 RID: 26821 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700156F")]
		public CompetitionController Controller
		{
			[Token(Token = "0x60068C4")]
			[Address(RVA = "0xB3EA", Offset = "0xB3EA", VA = "0xB3EA")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60068C5")]
			[Address(RVA = "0xB3EB", Offset = "0xB3EB", VA = "0xB3EB")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060068C6 RID: 26822 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60068C6")]
		[Address(RVA = "0xB3EC", Offset = "0xB3EC", VA = "0xB3EC")]
		public CompetitionManager(IGame game)
		{
		/* --- GHIDRA: .ctor ---
		void Core_Gameplay_Managers_CompetitionManager___ctor(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  MVC_AbstractController__Run(*(undefined4 *)(param1 + 0x14),0);
		  iVar1 = **(int **)(param1 + 0x14);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xe8) * 4))
		            (*(int **)(param1 + 0x14),*(undefined4 *)(iVar1 + 0xec));
		  *(undefined4 *)(param1 + 0x14) = 0;
		  iVar1 = *(int *)(param1 + 0xc);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		            (*(undefined4 *)(iVar1 + 0x20),param1,*(undefined4 *)(iVar1 + 0x14));
		  return;
		}
		*/

		}

		// Token: 0x060068C7 RID: 26823 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60068C7")]
		[Address(RVA = "0xB3ED", Offset = "0xB3ED", VA = "0xB3ED", Slot = "9")]
		public void Deinit()
		{
		/* --- GHIDRA: Deinit ---
		void Core_Gameplay_Managers_CompetitionManager__Deinit(int param1,undefined4 param2)
		
		{
		  undefined4 param10;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  int iVar4;
		  uint *puVar5;
		  undefined4 uVar6;
		  undefined4 param7;
		  undefined4 param8;
		  undefined4 param9;
		  uint uVar7;
		  int *piVar8;
		  undefined4 uVar9;
		  undefined4 uVar10;
		  undefined4 param6;
		  undefined4 param11;
		  
		  if (DAT_ram_00a637a2 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Competition_Control_CompetitionController_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Competition_Events_CompetitionEvents_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Gameplay_Managers_CompetitionManager_HandleControllerInitEvent__);
		    Mono_Security_ASN1__get_Item(&Gameplay_Competition_Model_CompetitionModel_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Competition_Model_Dependencies_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_EventState__Sections____Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_EventState__Sections_____ctor__);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_Dictionary_EventState__Sections____TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_TabBarItemData_Sections___Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_TabBarItemData_Sections____ctor__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_TabBarItemData_Sections___get_Item__);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_List_TabBarItemData_Sections___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Competition_Model_OwnerRating_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_ObjectModel_ReadOnlyCollection_TabBarItemData_Sections____ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_ObjectModel_ReadOnlyCollection_TabBarItemData_Sections___TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_ObjectModel_ReadOnlyDictionary_EventState__Sections_____ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_ObjectModel_ReadOnlyDictionary_EventState__Sections____TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Competition_Model_Sections___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_CompetitionService___);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_RatingService___);
		    Mono_Security_ASN1__get_Item(&Core_Net_ServiceFactory_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UI_Tabs_TabBarItemData_Sections___ctor__);
		    Mono_Security_ASN1__get_Item(&UI_Tabs_TabBarItemData_Sections__TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4387);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4389);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4388);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4390);
		    DAT_ram_00a637a2 = '\x01';
		  }
		  iVar1 = unnamed_function_1417(System_Collections_Generic_List_TabBarItemData_Sections___TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (iVar1,Method_System_Collections_Generic_List_TabBarItemData_Sections____ctor__);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar2 = func_ii_7508(StringLiteral_4388,1,0,1,0,0,0,0);
		  uVar3 = unnamed_function_1417(UI_Tabs_TabBarItemData_Sections__TypeInfo);
		  UI_Tabs_TabBarItemData_ByteEnum____ctor
		            (uVar3,uVar2,1,Method_UI_Tabs_TabBarItemData_Sections___ctor__);
		  iVar4 = Method_System_Collections_Generic_List_TabBarItemData_Sections___Add__;
		  *(int *)(iVar1 + 0x10) = *(int *)(iVar1 + 0x10) + 1;
		  uVar7 = *(uint *)(iVar1 + 0xc);
		  if (uVar7 < *(uint *)(*(int *)(iVar1 + 8) + 0xc)) {
		    *(uint *)(iVar1 + 0xc) = uVar7 + 1;
		    *(undefined4 *)(*(int *)(iVar1 + 8) + uVar7 * 4 + 0x10) = uVar3;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar1,uVar3,*(undefined4 *)(*(int *)(*(int *)(iVar4 + 0x10) + 0x60) + 0x38));
		  }
		  uVar2 = func_ii_7508(StringLiteral_4389,1,0,1,0,0,0,0);
		  uVar3 = unnamed_function_1417(UI_Tabs_TabBarItemData_Sections__TypeInfo);
		  UI_Tabs_TabBarItemData_ByteEnum____ctor
		            (uVar3,uVar2,2,Method_UI_Tabs_TabBarItemData_Sections___ctor__);
		  iVar4 = Method_System_Collections_Generic_List_TabBarItemData_Sections___Add__;
		  *(int *)(iVar1 + 0x10) = *(int *)(iVar1 + 0x10) + 1;
		  uVar7 = *(uint *)(iVar1 + 0xc);
		  if (uVar7 < *(uint *)(*(int *)(iVar1 + 8) + 0xc)) {
		    *(uint *)(iVar1 + 0xc) = uVar7 + 1;
		    *(undefined4 *)(*(int *)(iVar1 + 8) + uVar7 * 4 + 0x10) = uVar3;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar1,uVar3,*(undefined4 *)(*(int *)(*(int *)(iVar4 + 0x10) + 0x60) + 0x38));
		  }
		  uVar2 = func_ii_7508(StringLiteral_4387,1,0,1,0,0,0,0);
		  uVar3 = unnamed_function_1417(UI_Tabs_TabBarItemData_Sections__TypeInfo);
		  UI_Tabs_TabBarItemData_ByteEnum____ctor
		            (uVar3,uVar2,3,Method_UI_Tabs_TabBarItemData_Sections___ctor__);
		  iVar4 = Method_System_Collections_Generic_List_TabBarItemData_Sections___Add__;
		  *(int *)(iVar1 + 0x10) = *(int *)(iVar1 + 0x10) + 1;
		  uVar7 = *(uint *)(iVar1 + 0xc);
		  if (uVar7 < *(uint *)(*(int *)(iVar1 + 8) + 0xc)) {
		    *(uint *)(iVar1 + 0xc) = uVar7 + 1;
		    *(undefined4 *)(*(int *)(iVar1 + 8) + uVar7 * 4 + 0x10) = uVar3;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar1,uVar3,*(undefined4 *)(*(int *)(*(int *)(iVar4 + 0x10) + 0x60) + 0x38));
		  }
		  uVar2 = func_ii_7508(StringLiteral_4390,1,0,1,0,0,0,0);
		  uVar3 = unnamed_function_1417(UI_Tabs_TabBarItemData_Sections__TypeInfo);
		  UI_Tabs_TabBarItemData_ByteEnum____ctor
		            (uVar3,uVar2,4,Method_UI_Tabs_TabBarItemData_Sections___ctor__);
		  iVar4 = Method_System_Collections_Generic_List_TabBarItemData_Sections___Add__;
		  *(int *)(iVar1 + 0x10) = *(int *)(iVar1 + 0x10) + 1;
		  uVar7 = *(uint *)(iVar1 + 0xc);
		  if (uVar7 < *(uint *)(*(int *)(iVar1 + 8) + 0xc)) {
		    *(uint *)(iVar1 + 0xc) = uVar7 + 1;
		    *(undefined4 *)(*(int *)(iVar1 + 8) + uVar7 * 4 + 0x10) = uVar3;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar1,uVar3,*(undefined4 *)(*(int *)(*(int *)(iVar4 + 0x10) + 0x60) + 0x38));
		  }
		  uVar7 = 0;
		  uVar2 = unnamed_function_1417
		                    (System_Collections_Generic_Dictionary_EventState__Sections____TypeInfo);
		  System_Collections_Generic_Dictionary_Int32Enum__Int32Enum___set_Item
		            (uVar2,Method_System_Collections_Generic_Dictionary_EventState__Sections_____ctor__);
		  iVar4 = Mono_Security_ASN1Convert__ToOid(Gameplay_Competition_Model_Sections___TypeInfo,2);
		  *(undefined2 *)(iVar4 + 0x10) = 0x102;
		  func_ii_10812(uVar2,2,iVar4,
		                Method_System_Collections_Generic_Dictionary_EventState__Sections____Add__);
		  piVar8 = *(int **)(param1 + 0x10);
		  iVar4 = *piVar8;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar7 * 8)) {
		        puVar5 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar7 * 8 + 4) * 8 + iVar4 + 0x178);
		        goto code_r0x822fe05f;
		      }
		      uVar7 = uVar7 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar7);
		  }
		  puVar5 = (uint *)func_ii_1080(piVar8,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x822fe05f:
		  uVar7 = 0;
		  uVar3 = (**(code **)((ulonglong)*puVar5 * 4))(piVar8,puVar5[1]);
		  piVar8 = *(int **)(param1 + 0x10);
		  iVar4 = *piVar8;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar7 * 8)) {
		        puVar5 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar7 * 8 + 4) * 8 + iVar4 + 0x158);
		        goto code_r0x822fe0e4;
		      }
		      uVar7 = uVar7 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar7);
		  }
		  puVar5 = (uint *)func_ii_1080(piVar8,Core_Gameplay_IGame_TypeInfo,0x13);
		code_r0x822fe0e4:
		  iVar4 = (**(code **)((ulonglong)*puVar5 * 4))(piVar8,puVar5[1]);
		  uVar9 = *(undefined4 *)(iVar4 + 0x14);
		  uVar7 = 0;
		  piVar8 = *(int **)(param1 + 0x10);
		  iVar4 = *piVar8;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar7 * 8)) {
		        puVar5 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar7 * 8 + 4) * 8 + iVar4 + 0x170);
		        goto code_r0x822fe16c;
		      }
		      uVar7 = uVar7 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar7);
		  }
		  puVar5 = (uint *)func_ii_1080(piVar8,Core_Gameplay_IGame_TypeInfo,0x16);
		code_r0x822fe16c:
		  iVar4 = (**(code **)((ulonglong)*puVar5 * 4))(piVar8,puVar5[1]);
		  uVar10 = *(undefined4 *)(iVar4 + 0x14);
		  uVar7 = 0;
		  piVar8 = *(int **)(param1 + 0x10);
		  iVar4 = *piVar8;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar7 * 8)) {
		        puVar5 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar7 * 8 + 4) * 8 + iVar4 + 0x170);
		        goto code_r0x822fe1f4;
		      }
		      uVar7 = uVar7 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar7);
		  }
		  puVar5 = (uint *)func_ii_1080(piVar8,Core_Gameplay_IGame_TypeInfo,0x16);
		code_r0x822fe1f4:
		  uVar7 = 0;
		  uVar6 = (**(code **)((ulonglong)*puVar5 * 4))(piVar8,puVar5[1]);
		  piVar8 = *(int **)(param1 + 0x10);
		  iVar4 = *piVar8;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar7 * 8)) {
		        puVar5 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar7 * 8 + 4) * 8 + iVar4 + 400);
		        goto code_r0x822fe279;
		      }
		      uVar7 = uVar7 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar7);
		  }
		  puVar5 = (uint *)func_ii_1080(piVar8,Core_Gameplay_IGame_TypeInfo,0x1a);
		code_r0x822fe279:
		  iVar4 = (**(code **)((ulonglong)*puVar5 * 4))(piVar8,puVar5[1]);
		  param6 = *(undefined4 *)(iVar4 + 0x24);
		  uVar7 = 0;
		  piVar8 = *(int **)(param1 + 0x10);
		  iVar4 = *piVar8;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar7 * 8)) {
		        puVar5 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar7 * 8 + 4) * 8 + iVar4 + 0xe0);
		        goto code_r0x822fe301;
		      }
		      uVar7 = uVar7 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar7);
		  }
		  puVar5 = (uint *)func_ii_1080(piVar8,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x822fe301:
		  piVar8 = (int *)(**(code **)((ulonglong)*puVar5 * 4))(piVar8,puVar5[1]);
		  uVar7 = 0;
		  iVar4 = *piVar8;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar7 * 8)) {
		        puVar5 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar7 * 8 + 4) * 8 + iVar4 + 0xe8);
		        goto code_r0x822fe383;
		      }
		      uVar7 = uVar7 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar7);
		  }
		  puVar5 = (uint *)func_ii_1080(piVar8,Core_Application_IApp_TypeInfo,5);
		code_r0x822fe383:
		  param7 = (**(code **)((ulonglong)*puVar5 * 4))(piVar8,puVar5[1]);
		  if (*(int *)(Core_Net_ServiceFactory_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_ServiceFactory_TypeInfo);
		  }
		  param8 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                     (Method_Core_Net_ServiceFactory_GetService_RatingService___);
		  param9 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                     (Method_Core_Net_ServiceFactory_GetService_CompetitionService___);
		  piVar8 = *(int **)(param1 + 0x10);
		  iVar4 = *piVar8;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar7 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar7 * 8)) {
		        puVar5 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar7 * 8 + 4) * 8 + iVar4 + 0x140);
		        goto code_r0x822fe437;
		      }
		      uVar7 = uVar7 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar7);
		  }
		  puVar5 = (uint *)func_ii_1080(piVar8,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x822fe437:
		  param10 = 0;
		  iVar4 = (**(code **)((ulonglong)*puVar5 * 4))(piVar8,puVar5[1]);
		  if (*(int *)(iVar4 + 0x14) != 0) {
		    param10 = *(undefined4 *)(*(int *)(iVar4 + 0x14) + 8);
		  }
		  param11 = *(undefined4 *)(param1 + 0x10);
		  iVar4 = unnamed_function_1417(Gameplay_Competition_Model_Dependencies_TypeInfo);
		  Gameplay_Competition_Model_CompetitionModel___c__DisplayClass25_0___GetAvailSections_b__0
		            (iVar4,uVar3,uVar9,uVar10,uVar6,param6,param7,param8,param9,param10,param11,0);
		  uVar3 = unnamed_function_1417(Gameplay_Competition_Model_OwnerRating_TypeInfo);
		  Gameplay_Competition_Model_OwnerRating__Fill(uVar3,0);
		  uVar9 = unnamed_function_1417
		                    (
		                    System_Collections_ObjectModel_ReadOnlyCollection_TabBarItemData_Sections___TypeInfo
		                    );
		  System_Runtime_CompilerServices_ReadOnlyCollectionBuilder___Il2CppFullySharedGenericType___set_Item
		            (uVar9,iVar1,
		             Method_System_Collections_ObjectModel_ReadOnlyCollection_TabBarItemData_Sections____ctor__
		            );
		  uVar10 = unnamed_function_1417
		                     (
		                     System_Collections_ObjectModel_ReadOnlyDictionary_EventState__Sections____TypeInfo
		                     );
		  Google_Protobuf_Collections_ReadOnlyDictionary___Il2CppFullySharedGenericType____Il2CppFullySharedGenericType___set_Item
		            (uVar10,uVar2,
		             Method_System_Collections_ObjectModel_ReadOnlyDictionary_EventState__Sections_____ctor__
		            );
		  uVar2 = System_Linq_Enumerable__ToList_object_
		                    (iVar1,0,
		                     Method_System_Collections_Generic_List_TabBarItemData_Sections___get_Item__);
		  uVar6 = unnamed_function_1417(Gameplay_Competition_Model_CompetitionModel_TypeInfo);
		  Gameplay_Competition_Model_CompetitionModel__get_FireAnimationTimeUntilEnd
		            (uVar6,uVar3,uVar9,uVar10,uVar2,iVar4,0);
		  uVar2 = unnamed_function_1417(Gameplay_Competition_Events_CompetitionEvents_TypeInfo);
		  uVar3 = *(undefined4 *)(iVar4 + 0x20);
		  uVar9 = *(undefined4 *)(iVar4 + 0x24);
		  piVar8 = (int *)unnamed_function_1417(Gameplay_Competition_Control_CompetitionController_TypeInfo)
		  ;
		  Gameplay_Competition_Events_ShopEvents___ctor(piVar8,uVar9,uVar3,uVar6,uVar2,0);
		  *(int **)(param1 + 0x14) = piVar8;
		  iVar4 = (**(code **)((ulonglong)*(uint *)(*piVar8 + 0x110) * 4))
		                    (piVar8,*(undefined4 *)(*piVar8 + 0x114));
		  uVar3 = *(undefined4 *)(iVar4 + 8);
		  uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar2,param1,
		             Method_Core_Gameplay_Managers_CompetitionManager_HandleControllerInitEvent__,0);
		  piVar8 = (int *)UnityEngine_UI_Image__set_sprite(uVar3,uVar2,0);
		  iVar1 = System_Action_TypeInfo;
		  if (piVar8 == (int *)0x0) {
		    *(undefined4 *)(iVar4 + 8) = 0;
		  }
		  else if ((System_Action_TypeInfo != *piVar8) || (*(int **)(iVar4 + 8) = piVar8, *piVar8 != iVar1))
		  {
		    System_Activator__CreateInstance(piVar8,iVar1);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  MVC_AbstractController__Dispose(*(undefined4 *)(param1 + 0x14),0);
		  return;
		}
		*/

		}

		// Token: 0x060068C8 RID: 26824 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60068C8")]
		[Address(RVA = "0xB3EE", Offset = "0xB3EE", VA = "0xB3EE", Slot = "8")]
		public void Init()
		{
		/* --- GHIDRA: Init ---
		void Core_Gameplay_Managers_CompetitionManager__Init(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 param1_00;
		  int *param1_01;
		  undefined4 param1_02;
		  int iVar2;
		  
		  if (DAT_ram_00a637a3 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Gameplay_Managers_CompetitionManager_HandleControllerInitEvent__);
		    DAT_ram_00a637a3 = '\x01';
		  }
		  iVar2 = **(int **)(param1 + 0x14);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(iVar2 + 0x110) * 4))
		                    (*(int **)(param1 + 0x14),*(undefined4 *)(iVar2 + 0x114));
		  param1_02 = *(undefined4 *)(iVar1 + 8);
		  param1_00 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (param1_00,param1,
		             Method_Core_Gameplay_Managers_CompetitionManager_HandleControllerInitEvent__,0);
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
		  (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		            (*(undefined4 *)(iVar2 + 0x20),param1,*(undefined4 *)(iVar2 + 0x14));
		  return;
		}
		*/

		}

		// Token: 0x060068C9 RID: 26825 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60068C9")]
		[Address(RVA = "0xB3EF", Offset = "0xB3EF", VA = "0xB3EF")]
		private void HandleControllerInitEvent()
		{
		/* --- GHIDRA: HandleControllerInitEvent ---
		void Core_Gameplay_Managers_CompetitionManager__HandleControllerInitEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a637a4 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a637a4 = '\x01';
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

		// Token: 0x040037AA RID: 14250
		[Token(Token = "0x40037AA")]
		[FieldOffset(Offset = "0x10")]
		private readonly IGame _game;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Name ---
		void Core_Gameplay_Managers_CompetitionManager__get_Name
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a6379e == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a6379e = '\x01';
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
		void Core_Gameplay_Managers_CompetitionManager__add_InitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a6379f == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a6379f = '\x01';
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
		void Core_Gameplay_Managers_CompetitionManager__remove_InitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a637a0 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a637a0 = '\x01';
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
		void Core_Gameplay_Managers_CompetitionManager__add_DeinitCompleteEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a637a1 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBaseManager__TypeInfo);
		    DAT_ram_00a637a1 = '\x01';
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

}
