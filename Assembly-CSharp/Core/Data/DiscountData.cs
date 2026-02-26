using System;
using System.Collections.Generic;
using Core.Gameplay.Managers;
using Core.Gameplay.Managers.GameActivityRouting;
using Gameplay.UserInfo.View;
using Il2CppDummyDll;
using Protocol.Consts;
using Protocol.Dic;
using Utils;

namespace Core.Data
{
	// Token: 0x020010BC RID: 4284
	[Token(Token = "0x20010BC")]
	public class DiscountData
	{
		// Token: 0x17001414 RID: 5140
		// (get) Token: 0x060063E2 RID: 25570 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001414")]
		private static GameFeatureRouterManager _routerManager
		{
			[Token(Token = "0x60063E2")]
			[Address(RVA = "0xAFDF", Offset = "0xAFDF", VA = "0xAFDF")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001415 RID: 5141
		// (get) Token: 0x060063E3 RID: 25571 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001415")]
		private static AccountsManager _accountsManager
		{
			[Token(Token = "0x60063E3")]
			[Address(RVA = "0xAFE0", Offset = "0xAFE0", VA = "0xAFE0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001416 RID: 5142
		// (get) Token: 0x060063E4 RID: 25572 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001416")]
		private static BankManager _bankManager
		{
			[Token(Token = "0x60063E4")]
			[Address(RVA = "0xAFE1", Offset = "0xAFE1", VA = "0xAFE1")]
			get
			{
				return null;
			}
		}

		// Token: 0x060063E5 RID: 25573 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60063E5")]
		[Address(RVA = "0xAFE2", Offset = "0xAFE2", VA = "0xAFE2")]
		private static void TryOpenBuilding(UserBuildingTypes type)
		{
		/* --- GHIDRA: TryOpenBuilding ---
		void Core_Data_DiscountData__TryOpenBuilding
		               (int param1,float param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a607b0 == '\0') {
		    Mono_Security_ASN1__get_Item(&Utils_BackTime_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_DiscountTargets__Action__TryGetValue__)
		    ;
		    Mono_Security_ASN1__get_Item(&Core_Data_DiscountData_TypeInfo);
		    DAT_ram_00a607b0 = '\x01';
		  }
		  local_4 = 0;
		  *(undefined4 *)(param1 + 8) = param3;
		  param1_00 = unnamed_function_1417(Utils_BackTime_TypeInfo);
		  Core_Extensions_Dict_DictExt__BinarySearch_object__uint_(param1_00,0.0,0);
		  Core_Extensions_Dict_DictExt__BinarySearch_object__uint_(param1_00,param2,0);
		  *(undefined4 *)(param1 + 0x10) = param1_00;
		  if (*(int *)(Core_Data_DiscountData_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Data_DiscountData_TypeInfo);
		  }
		  iVar1 = System_Collections_Generic_List_Enumerator_ValueTuple_object__double____MoveNext
		                    (**(undefined4 **)(Core_Data_DiscountData_TypeInfo + 0x5c),
		                     *(undefined4 *)(*(int *)(param1 + 8) + 0x10),&local_4,
		                     Method_System_Collections_Generic_Dictionary_DiscountTargets__Action__TryGetValue__
		                    );
		  if (iVar1 != 0) {
		    *(undefined4 *)(param1 + 0xc) = local_4;
		  }
		  return;
		}
		*/

		}

		// Token: 0x060063E6 RID: 25574 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60063E6")]
		[Address(RVA = "0xAFE3", Offset = "0xAFE3", VA = "0xAFE3")]
		private DiscountData(float backTime, DiscountsDic dic)
		{
		/* --- GHIDRA: .cctor ---
		void Core_Data_DiscountData___cctor(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a607b5 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Data_DiscountData___c_TypeInfo);
		    DAT_ram_00a607b5 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(Core_Data_DiscountData___c_TypeInfo);
		  **(undefined4 **)(Core_Data_DiscountData___c_TypeInfo + 0x5c) = uVar1;
		  return;
		}
		*/

		/* --- GHIDRA: .ctor ---
		undefined4
		Core_Data_DiscountData___ctor(undefined4 param1,float param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 param1_00;
		  int param3_00;
		  
		  param1_00 = 0;
		  if (DAT_ram_00a607b1 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Data_DiscountData_TypeInfo);
		    DAT_ram_00a607b1 = '\x01';
		  }
		  param3_00 = Core_Extensions_Dict_DictExt__GetProfessionDic(param3,param1,0);
		  if (param3_00 != 0) {
		    param1_00 = unnamed_function_1417(Core_Data_DiscountData_TypeInfo);
		    Core_Data_DiscountData__TryOpenBuilding(param1_00,param2,param3_00,param1_00);
		  }
		  return param1_00;
		}
		*/

		}

		// Token: 0x060063E7 RID: 25575 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60063E7")]
		[Address(RVA = "0xAFE4", Offset = "0xAFE4", VA = "0xAFE4")]
		public static DiscountData Create(uint discountId, float backTimer, Dictionaries dict)
		{
		/* --- GHIDRA: Create ---
		void Core_Data_DiscountData__Create(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  undefined4 param3;
		  
		  if (DAT_ram_00a607b2 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_7789);
		    DAT_ram_00a607b2 = '\x01';
		  }
		  uVar1 = System_Uri___ctor(0);
		  uVar1 = System_Globalization_TimeSpanFormat_FormatLiterals__get_DayHourSep(uVar1,0);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  param3 = func_ii_7508(StringLiteral_7789,1,0,1,0,0,0,0);
		  Core_Application_App__get_ToastController(uVar1,1,param3,0);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x060063E8 RID: 25576 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60063E8")]
		[Address(RVA = "0xAFE5", Offset = "0xAFE5", VA = "0xAFE5")]
		private static void ShowFeatureInDevelopmentToast()
		{
		/* --- GHIDRA: ShowFeatureInDevelopmentToast ---
		void Core_Data_DiscountData__ShowFeatureInDevelopmentToast(undefined4 param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined4 param1_00;
		  int *piVar4;
		  int iVar5;
		  
		  if (DAT_ram_00a607b3 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_UserInfo_View_UserInfoWindow_UserInfoWindowArgs_TypeInfo)
		    ;
		    DAT_ram_00a607b3 = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  piVar4 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x140);
		        goto code_r0x81ce2ab4;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x81ce2ab4:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		  uVar3 = func_ii_7112(uVar3,0);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar4 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x1b0);
		        goto code_r0x81ce2b66;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x1e);
		code_r0x81ce2b66:
		  param1_00 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		  iVar5 = unnamed_function_1417(Gameplay_UserInfo_View_UserInfoWindow_UserInfoWindowArgs_TypeInfo);
		  Core_Browser_BrowserWindow___ctor(iVar5,uVar3,0);
		  *(undefined4 *)(iVar5 + 0x1c) = param1;
		  Core_Gameplay_Managers_GameActivityRouting_GameFeatureRouterManager__ShowCraft(param1_00,iVar5,0);
		  return;
		}
		*/

		}

		// Token: 0x060063E9 RID: 25577 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60063E9")]
		[Address(RVA = "0xAFE6", Offset = "0xAFE6", VA = "0xAFE6")]
		private static void ShowUserWindow(UserInfoWindow.DependentView dependent = UserInfoWindow.DependentView.NOTHING)
		{
		/* --- GHIDRA: ShowUserWindow ---
		void Core_Data_DiscountData__ShowUserWindow(undefined4 param1)
		
		{
		  uint uVar1;
		  undefined4 param1_00;
		  undefined4 uVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  int *piVar5;
		  int iVar6;
		  
		  if (DAT_ram_00a607b4 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Gameplay_Managers_AprsManager_ShowAprsWindow__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_DiscountTargets__Action__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_DiscountTargets__Action___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_Dictionary_DiscountTargets__Action__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Data_DiscountData_ShowFeatureInDevelopmentToast__);
		    Mono_Security_ASN1__get_Item(&Core_Data_DiscountData_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Gameplay_Managers_GameActivityRouting_GameFeatureRouterManager_ShowAuchan__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Gameplay_Managers_MedalsManager_ShowMedalsWindow__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Data_DiscountData___c___cctor_b__15_0__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Data_DiscountData___c___cctor_b__15_10__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Data_DiscountData___c___cctor_b__15_11__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Data_DiscountData___c___cctor_b__15_12__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Data_DiscountData___c___cctor_b__15_13__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Data_DiscountData___c___cctor_b__15_14__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Data_DiscountData___c___cctor_b__15_15__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Data_DiscountData___c___cctor_b__15_1__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Data_DiscountData___c___cctor_b__15_2__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Data_DiscountData___c___cctor_b__15_3__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Data_DiscountData___c___cctor_b__15_4__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Data_DiscountData___c___cctor_b__15_5__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Data_DiscountData___c___cctor_b__15_6__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Data_DiscountData___c___cctor_b__15_7__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Data_DiscountData___c___cctor_b__15_8__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Data_DiscountData___c___cctor_b__15_9__);
		    Mono_Security_ASN1__get_Item(&Core_Data_DiscountData___c_TypeInfo);
		    DAT_ram_00a607b4 = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (System_Collections_Generic_Dictionary_DiscountTargets__Action__TypeInfo);
		  System_Collections_Generic_Dictionary_Int32Enum__Int32Enum___set_Item
		            (param1_00,Method_System_Collections_Generic_Dictionary_DiscountTargets__Action___ctor__
		            );
		  if (*(int *)(Core_Data_DiscountData___c_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Data_DiscountData___c_TypeInfo);
		  }
		  uVar4 = **(undefined4 **)(Core_Data_DiscountData___c_TypeInfo + 0x5c);
		  uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar2,uVar4,Method_Core_Data_DiscountData___c___cctor_b__15_0__,0);
		  func_ii_10812(param1_00,0,uVar2,
		                Method_System_Collections_Generic_Dictionary_DiscountTargets__Action__Add__);
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
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x130);
		        goto code_r0x81ce2d9c;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0xe);
		code_r0x81ce2d9c:
		  uVar2 = (**(code **)((ulonglong)*puVar3 * 4))(piVar5,puVar3[1]);
		  uVar4 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar4,uVar2,Method_Core_Gameplay_Managers_MedalsManager_ShowMedalsWindow__,0);
		  func_ii_10812(param1_00,1,uVar4,
		                Method_System_Collections_Generic_Dictionary_DiscountTargets__Action__Add__);
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
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x138);
		        goto code_r0x81ce2e77;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0xf);
		code_r0x81ce2e77:
		  uVar2 = (**(code **)((ulonglong)*puVar3 * 4))(piVar5,puVar3[1]);
		  uVar4 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar4,uVar2,Method_Core_Gameplay_Managers_AprsManager_ShowAprsWindow__,0);
		  func_ii_10812(param1_00,2,uVar4,
		                Method_System_Collections_Generic_Dictionary_DiscountTargets__Action__Add__);
		  uVar4 = **(undefined4 **)(Core_Data_DiscountData___c_TypeInfo + 0x5c);
		  uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar2,uVar4,Method_Core_Data_DiscountData___c___cctor_b__15_1__,0);
		  func_ii_10812(param1_00,3,uVar2,
		                Method_System_Collections_Generic_Dictionary_DiscountTargets__Action__Add__);
		  uVar4 = **(undefined4 **)(Core_Data_DiscountData___c_TypeInfo + 0x5c);
		  uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar2,uVar4,Method_Core_Data_DiscountData___c___cctor_b__15_2__,0);
		  func_ii_10812(param1_00,4,uVar2,
		                Method_System_Collections_Generic_Dictionary_DiscountTargets__Action__Add__);
		  uVar4 = **(undefined4 **)(Core_Data_DiscountData___c_TypeInfo + 0x5c);
		  uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar2,uVar4,Method_Core_Data_DiscountData___c___cctor_b__15_3__,0);
		  func_ii_10812(param1_00,5,uVar2,
		                Method_System_Collections_Generic_Dictionary_DiscountTargets__Action__Add__);
		  uVar4 = **(undefined4 **)(Core_Data_DiscountData___c_TypeInfo + 0x5c);
		  uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar2,uVar4,Method_Core_Data_DiscountData___c___cctor_b__15_4__,0);
		  func_ii_10812(param1_00,6,uVar2,
		                Method_System_Collections_Generic_Dictionary_DiscountTargets__Action__Add__);
		  if (DAT_ram_00a607ac == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a607ac = '\x01';
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
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x1b0);
		        goto code_r0x81ce306c;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x1e);
		code_r0x81ce306c:
		  uVar2 = (**(code **)((ulonglong)*puVar3 * 4))(piVar5,puVar3[1]);
		  uVar4 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar4,uVar2,
		             Method_Core_Gameplay_Managers_GameActivityRouting_GameFeatureRouterManager_ShowAuchan__
		             ,0);
		  func_ii_10812(param1_00,7,uVar4,
		                Method_System_Collections_Generic_Dictionary_DiscountTargets__Action__Add__);
		  uVar4 = **(undefined4 **)(Core_Data_DiscountData___c_TypeInfo + 0x5c);
		  uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar2,uVar4,Method_Core_Data_DiscountData___c___cctor_b__15_5__,0);
		  func_ii_10812(param1_00,9,uVar2,
		                Method_System_Collections_Generic_Dictionary_DiscountTargets__Action__Add__);
		  uVar4 = **(undefined4 **)(Core_Data_DiscountData___c_TypeInfo + 0x5c);
		  uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar2,uVar4,Method_Core_Data_DiscountData___c___cctor_b__15_6__,0);
		  func_ii_10812(param1_00,10,uVar2,
		                Method_System_Collections_Generic_Dictionary_DiscountTargets__Action__Add__);
		  uVar4 = **(undefined4 **)(Core_Data_DiscountData___c_TypeInfo + 0x5c);
		  uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar2,uVar4,Method_Core_Data_DiscountData___c___cctor_b__15_7__,0);
		  func_ii_10812(param1_00,0xb,uVar2,
		                Method_System_Collections_Generic_Dictionary_DiscountTargets__Action__Add__);
		  uVar4 = **(undefined4 **)(Core_Data_DiscountData___c_TypeInfo + 0x5c);
		  uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar2,uVar4,Method_Core_Data_DiscountData___c___cctor_b__15_8__,0);
		  func_ii_10812(param1_00,0xc,uVar2,
		                Method_System_Collections_Generic_Dictionary_DiscountTargets__Action__Add__);
		  uVar4 = **(undefined4 **)(Core_Data_DiscountData___c_TypeInfo + 0x5c);
		  uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar2,uVar4,Method_Core_Data_DiscountData___c___cctor_b__15_9__,0);
		  func_ii_10812(param1_00,0xd,uVar2,
		                Method_System_Collections_Generic_Dictionary_DiscountTargets__Action__Add__);
		  uVar4 = **(undefined4 **)(Core_Data_DiscountData___c_TypeInfo + 0x5c);
		  uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar2,uVar4,Method_Core_Data_DiscountData___c___cctor_b__15_10__,0);
		  func_ii_10812(param1_00,0xe,uVar2,
		                Method_System_Collections_Generic_Dictionary_DiscountTargets__Action__Add__);
		  uVar4 = **(undefined4 **)(Core_Data_DiscountData___c_TypeInfo + 0x5c);
		  uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar2,uVar4,Method_Core_Data_DiscountData___c___cctor_b__15_11__,0);
		  func_ii_10812(param1_00,0xf,uVar2,
		                Method_System_Collections_Generic_Dictionary_DiscountTargets__Action__Add__);
		  uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar2,0,Method_Core_Data_DiscountData_ShowFeatureInDevelopmentToast__,0);
		  func_ii_10812(param1_00,0x10,uVar2,
		                Method_System_Collections_Generic_Dictionary_DiscountTargets__Action__Add__);
		  uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar2,0,Method_Core_Data_DiscountData_ShowFeatureInDevelopmentToast__,0);
		  func_ii_10812(param1_00,0x11,uVar2,
		                Method_System_Collections_Generic_Dictionary_DiscountTargets__Action__Add__);
		  uVar4 = **(undefined4 **)(Core_Data_DiscountData___c_TypeInfo + 0x5c);
		  uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar2,uVar4,Method_Core_Data_DiscountData___c___cctor_b__15_12__,0);
		  func_ii_10812(param1_00,8,uVar2,
		                Method_System_Collections_Generic_Dictionary_DiscountTargets__Action__Add__);
		  uVar4 = **(undefined4 **)(Core_Data_DiscountData___c_TypeInfo + 0x5c);
		  uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar2,uVar4,Method_Core_Data_DiscountData___c___cctor_b__15_13__,0);
		  func_ii_10812(param1_00,0x12,uVar2,
		                Method_System_Collections_Generic_Dictionary_DiscountTargets__Action__Add__);
		  uVar4 = **(undefined4 **)(Core_Data_DiscountData___c_TypeInfo + 0x5c);
		  uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar2,uVar4,Method_Core_Data_DiscountData___c___cctor_b__15_14__,0);
		  func_ii_10812(param1_00,0x13,uVar2,
		                Method_System_Collections_Generic_Dictionary_DiscountTargets__Action__Add__);
		  uVar4 = **(undefined4 **)(Core_Data_DiscountData___c_TypeInfo + 0x5c);
		  uVar2 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar2,uVar4,Method_Core_Data_DiscountData___c___cctor_b__15_15__,0);
		  func_ii_10812(param1_00,0x14,uVar2,
		                Method_System_Collections_Generic_Dictionary_DiscountTargets__Action__Add__);
		  **(undefined4 **)(Core_Data_DiscountData_TypeInfo + 0x5c) = param1_00;
		  return;
		}
		*/

		}

		// Token: 0x04003572 RID: 13682
		[Token(Token = "0x4003572")]
		[FieldOffset(Offset = "0x8")]
		public readonly DiscountsDic Dic;

		// Token: 0x04003573 RID: 13683
		[Token(Token = "0x4003573")]
		[FieldOffset(Offset = "0xC")]
		public readonly Action Action;

		// Token: 0x04003574 RID: 13684
		[Token(Token = "0x4003574")]
		[FieldOffset(Offset = "0x10")]
		public BackTime BackTime;

		// Token: 0x04003575 RID: 13685
		[Token(Token = "0x4003575")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Dictionary<DiscountTargets, Action> _targetActions;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get__routerManager ---
		undefined4 Core_Data_DiscountData__get__routerManager(undefined4 param1)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int *param1_00;
		  int iVar4;
		  
		  if (DAT_ram_00a607ad == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a607ad = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar4 = *param1_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x1f8);
		        goto code_r0x81ce269e;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x27);
		code_r0x81ce269e:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  return uVar3;
		}
		*/


		/* --- GHIDRA: get__accountsManager ---
		undefined4 Core_Data_DiscountData__get__accountsManager(undefined4 param1)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int *param1_00;
		  int iVar4;
		  
		  if (DAT_ram_00a607ae == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a607ae = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar4 = *param1_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 400);
		        goto code_r0x81ce276c;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x1a);
		code_r0x81ce276c:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  return uVar3;
		}
		*/


		/* --- GHIDRA: get__bankManager ---
		void Core_Data_DiscountData__get__bankManager(undefined4 param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *param1_00;
		  int iVar3;
		  
		  if (DAT_ram_00a607af == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_UserIsleEvents__UserIsleModel__UserIsleController__UserBuildingTypes__TryOpenBuildingByType__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a607af = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar3 = *param1_00;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x110);
		        goto code_r0x81ce2842;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,10);
		code_r0x81ce2842:
		  iVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  Gameplay_Isles_Base_AbstractIsle_object__object__object__Int32Enum___SetIsCurrentIsle
		            (*(undefined4 *)(*(int *)(iVar3 + 0x14) + 0x20),param1,
		             Method_Gameplay_Isles_Base_AbstractIsle_UserIsleEvents__UserIsleModel__UserIsleController__UserBuildingTypes__TryOpenBuildingByType__
		            );
		  return;
		}
		*/

}
