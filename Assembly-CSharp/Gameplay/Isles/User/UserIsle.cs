using System;
using Core.Data;
using Gameplay.Isles.Base;
using Gameplay.Isles.User.Controller;
using Gameplay.Isles.User.Events;
using Gameplay.Isles.User.Model;
using Il2CppDummyDll;
using Protocol.Consts;
using Protocol.World;

namespace Gameplay.Isles.User
{
	// Token: 0x02000D0C RID: 3340
	[Token(Token = "0x2000D0C")]
	public class UserIsle : AbstractIsle<UserIsleEvents, UserIsleModel, UserIsleController, UserBuildingTypes>
	{
		// Token: 0x06005179 RID: 20857 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005179")]
		[Address(RVA = "0x9F56", Offset = "0x9F56", VA = "0x9F56", Slot = "3")]
		public override string ToString()
		{
		/* --- GHIDRA: ToString ---
		void Gameplay_Isles_User_UserIsle__ToString
		               (int param1,undefined4 param2,undefined4 param3,int param4,undefined4 param5)
		
		{
		  float fVar1;
		  undefined8 param2_00;
		  double dVar2;
		  int iVar3;
		  int iVar4;
		  undefined1 auStack_20 [8];
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a58d11 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_UserIsleEvents__UserIsleModel__UserIsleController__UserBuildingTypes___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_UserIsleEvents__UserIsleModel__UserIsleController__UserBuildingTypes__get_Controller__
		              );
		    Mono_Security_ASN1__get_Item(&System_DateTime_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_TimeSpan_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Utils_TimeUtils_TypeInfo);
		    DAT_ram_00a58d11 = '\x01';
		  }
		  param2_00 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext(param2,0);
		  Facebook_Unity_Subscription__get_PeriodStartTime
		            (param1,param2_00,
		             Method_Gameplay_Isles_Base_AbstractIsle_UserIsleEvents__UserIsleModel__UserIsleController__UserBuildingTypes___ctor__
		            );
		  *(undefined4 *)(param1 + 0x28) = param3;
		  *(undefined4 *)(param1 + 0x24) = param2;
		  if (*(int *)(System_DateTime_TypeInfo + 0x74) == 0) {
		    func_ii_306000(System_DateTime_TypeInfo);
		  }
		  local_8 = System_Net_ServicePoint__get_HasTimedOut(0);
		  local_18 = 0;
		  System_DateTime___ctor(&local_18,s_var<private>_posTex__array<vec4<_ram_00000655 + 0x15d,1,1,0);
		  local_10 = System_DateTime__ParseExact(&local_8,local_18,0);
		  if (*(int *)(System_TimeSpan_TypeInfo + 0x74) == 0) {
		    func_ii_306000(System_TimeSpan_TypeInfo);
		  }
		  dVar2 = System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter__OkgAnalytics__ApplicationQuitHandler_d__39_
		                    (&local_10,0);
		  if (*(int *)(Utils_TimeUtils_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Utils_TimeUtils_TypeInfo);
		  }
		  fVar1 = func_ii_7331((longlong)param4,0);
		  if (ABS(fVar1) < 2.1474836e+09) {
		    iVar3 = (int)fVar1;
		  }
		  else {
		    iVar3 = -0x80000000;
		  }
		  if (ABS(dVar2) < 2147483648.0) {
		    iVar4 = (int)dVar2;
		  }
		  else {
		    iVar4 = -0x80000000;
		  }
		  *(int *)(param1 + 0x2c) = iVar3 + iVar4;
		  Gameplay_Isles_User_UserIsle___ctor(param1,auStack_20);
		  MVC_AbstractController__Dispose(*(undefined4 *)(param1 + 0x14),0);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x0600517A RID: 20858 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600517A")]
		[Address(RVA = "0x1CA1", Offset = "0x1CA1", VA = "0x1CA1")]
		public UserIsle(UserData userData, UserData loggedUser, ProtoGetUserIsleInfoAns.Types.IsleInformation isleInformation, int cacheTtl)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Isles_User_UserIsle___ctor(int param1,undefined4 param2,int param3)
		
		{
		  int iVar1;
		  int param1_00;
		  uint uVar2;
		  
		  iVar1 = *(int *)(*(int *)(*(int *)(param3 + 0x10) + 0x60) + 0x28);
		  param1_00 = *(int *)(param1 + 0x10);
		  *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		  uVar2 = *(uint *)(param1_00 + 0xc);
		  if (*(uint *)(*(int *)(param1_00 + 8) + 0xc) <= uVar2) {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (param1_00,param2,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		    return;
		  }
		  *(uint *)(param1_00 + 0xc) = uVar2 + 1;
		  *(undefined4 *)(*(int *)(param1_00 + 8) + uVar2 * 4 + 0x10) = param2;
		  return;
		}
		*/

		/* --- GHIDRA: .ctor ---
		void Gameplay_Isles_User_UserIsle___ctor(int param1,undefined4 param2,int param3)
		
		{
		  int iVar1;
		  int param1_00;
		  uint uVar2;
		  
		  iVar1 = *(int *)(*(int *)(*(int *)(param3 + 0x10) + 0x60) + 0x28);
		  param1_00 = *(int *)(param1 + 0x10);
		  *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		  uVar2 = *(uint *)(param1_00 + 0xc);
		  if (*(uint *)(*(int *)(param1_00 + 8) + 0xc) <= uVar2) {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (param1_00,param2,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		    return;
		  }
		  *(uint *)(param1_00 + 0xc) = uVar2 + 1;
		  *(undefined4 *)(*(int *)(param1_00 + 8) + uVar2 * 4 + 0x10) = param2;
		  return;
		}
		*/

		}

		// Token: 0x0600517B RID: 20859 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600517B")]
		[Address(RVA = "0x9F57", Offset = "0x9F57", VA = "0x9F57")]
		public UserIsle(UserData userData, UserData loggedUser, int cacheTtl)
		{
		}

		// Token: 0x0600517C RID: 20860 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600517C")]
		[Address(RVA = "0x9F58", Offset = "0x9F58", VA = "0x9F58")]
		private void CreateMvc()
		{
		/* --- GHIDRA: CreateMvc ---
		void Gameplay_Isles_User_UserIsle__CreateMvc(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  int iVar5;
		  uint uVar6;
		  
		  if (DAT_ram_00a58d13 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_UserIsleEvents__UserIsleModel__UserIsleController__UserBuildingTypes__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Isles_User_View_AttackMonsterWindowArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_PopupController_Show_IsleMonsterInfoWindow2___);
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_PopupController_Show_IsleMonsterInfoWindow___);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12645);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12646);
		    DAT_ram_00a58d13 = '\x01';
		  }
		  piVar4 = *(int **)(*(int *)(param1 + 0x10) + 0x28);
		  iVar5 = *piVar4;
		  uVar6 = (uint)*(ushort *)(iVar5 + 0xb6);
		  if (*(char *)(*(int *)(param1 + 0x10) + 0x44) != '\0') {
		    if (uVar6 != 0) {
		      uVar1 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xe0);
		          goto code_r0x80f9de1f;
		        }
		        uVar1 = uVar1 + 1;
		      } while (uVar6 != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x80f9de1f:
		    piVar4 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		    uVar6 = 0;
		    iVar5 = *piVar4;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      do {
		        if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar6 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar6 * 8 + 4) * 8 + iVar5 + 0xe8);
		          goto code_r0x80f9de9d;
		        }
		        uVar6 = uVar6 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar6);
		    }
		    puVar2 = (uint *)func_ii_1080(piVar4,Core_Application_IApp_TypeInfo,5);
		code_r0x80f9de9d:
		    uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		    iVar5 = unnamed_function_1417(Gameplay_Isles_User_View_AttackMonsterWindowArgs_TypeInfo);
		    UI_Windows_BaseWindowArgs__Dispose(iVar5,0);
		    *(int *)(iVar5 + 0x18) = param1;
		    Gameplay_Antiq_View_GroupReviewWindow_WindowArgs___ctor
		              (uVar3,StringLiteral_12645,iVar5,
		               Method_UI_Windows_PopupController_Show_IsleMonsterInfoWindow___);
		    return;
		  }
		  if (uVar6 != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0xe0);
		        goto code_r0x80f9df3b;
		      }
		      uVar1 = uVar1 + 1;
		    } while (uVar6 != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x80f9df3b:
		  piVar4 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		  uVar6 = 0;
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar6 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar6 * 8 + 4) * 8 + iVar5 + 0xe8);
		        goto code_r0x80f9dfb9;
		      }
		      uVar6 = uVar6 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar6);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar4,Core_Application_IApp_TypeInfo,5);
		code_r0x80f9dfb9:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		  iVar5 = unnamed_function_1417(Gameplay_Isles_User_View_AttackMonsterWindowArgs_TypeInfo);
		  UI_Windows_BaseWindowArgs__Dispose(iVar5,0);
		  *(int *)(iVar5 + 0x18) = param1;
		  Gameplay_Antiq_View_GroupReviewWindow_WindowArgs___ctor
		            (uVar3,StringLiteral_12646,iVar5,
		             Method_UI_Windows_PopupController_Show_IsleMonsterInfoWindow2___);
		  return;
		}
		*/

		}

		// Token: 0x0600517D RID: 20861 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600517D")]
		[Address(RVA = "0x9F59", Offset = "0x9F59", VA = "0x9F59")]
		public void ShowMonsterWindow()
		{
		/* --- GHIDRA: ShowMonsterWindow ---
		void Gameplay_Isles_User_UserIsle__ShowMonsterWindow(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  undefined4 param1_01;
		  int *piVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a58d14 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_UserIsleEvents__UserIsleModel__UserIsleController__UserBuildingTypes__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_PopupController_Show_PortalsWindow___);
		    Mono_Security_ASN1__get_Item(&Gameplay_Portals_View_PortalsWindow_PortalsWindowArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12659);
		    DAT_ram_00a58d14 = '\x01';
		  }
		  piVar3 = *(int **)(*(int *)(param1 + 0x10) + 0x28);
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xe0);
		        goto code_r0x80f9e0bc;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x80f9e0bc:
		  piVar3 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  uVar1 = 0;
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xe8);
		        goto code_r0x80f9e13e;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Application_IApp_TypeInfo,5);
		code_r0x80f9e13e:
		  param1_00 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  param1_01 = unnamed_function_1417(Gameplay_Portals_View_PortalsWindow_PortalsWindowArgs_TypeInfo);
		  Gameplay_AccountLinker_View_SelectUserWindow___ctor(param1_01,0);
		  Gameplay_Antiq_View_GroupReviewWindow_WindowArgs___ctor
		            (param1_00,StringLiteral_12659,param1_01,
		             Method_UI_Windows_PopupController_Show_PortalsWindow___);
		  return;
		}
		*/

		}

		// Token: 0x0600517E RID: 20862 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600517E")]
		[Address(RVA = "0x9F5A", Offset = "0x9F5A", VA = "0x9F5A")]
		public void ShowPortalWindow()
		{
		}

		// Token: 0x17001080 RID: 4224
		// (get) Token: 0x0600517F RID: 20863 RVA: 0x0000EDC0 File Offset: 0x0000CFC0
		[Token(Token = "0x17001080")]
		public override LocationTypes LocationType
		{
			[Token(Token = "0x600517F")]
			[Address(RVA = "0x9F5B", Offset = "0x9F5B", VA = "0x9F5B", Slot = "10")]
			get
			{
				return LocationTypes.UnknownLocationType;
			}
		}

		// Token: 0x06005180 RID: 20864 RVA: 0x0000EDD8 File Offset: 0x0000CFD8
		[Token(Token = "0x6005180")]
		[Address(RVA = "0x9F5C", Offset = "0x9F5C", VA = "0x9F5C", Slot = "11")]
		public override bool TryOpenBuildingByType(uint type)
		{
		/* --- GHIDRA: TryOpenBuildingByType ---
		uint Gameplay_Isles_User_UserIsle__TryOpenBuildingByType(int param1,undefined4 param2)
		
		{
		  double dVar1;
		  int iVar2;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a58d16 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_DateTime_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_TimeSpan_TypeInfo);
		    DAT_ram_00a58d16 = '\x01';
		  }
		  if (*(int *)(System_DateTime_TypeInfo + 0x74) == 0) {
		    func_ii_306000(System_DateTime_TypeInfo);
		  }
		  local_8 = System_Net_ServicePoint__get_HasTimedOut(0);
		  local_18 = 0;
		  System_DateTime___ctor(&local_18,s_var<private>_posTex__array<vec4<_ram_00000655 + 0x15d,1,1,0);
		  local_10 = System_DateTime__ParseExact(&local_8,local_18,0);
		  if (*(int *)(System_TimeSpan_TypeInfo + 0x74) == 0) {
		    func_ii_306000(System_TimeSpan_TypeInfo);
		  }
		  dVar1 = System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter__OkgAnalytics__ApplicationQuitHandler_d__39_
		                    (&local_10,0);
		  if (ABS(dVar1) < 2147483648.0) {
		    iVar2 = (int)dVar1;
		  }
		  else {
		    iVar2 = -0x80000000;
		  }
		  return (uint)(*(int *)(param1 + 0x2c) < iVar2);
		}
		*/

			return default(bool);
		}

		// Token: 0x17001081 RID: 4225
		// (get) Token: 0x06005181 RID: 20865 RVA: 0x0000EDF0 File Offset: 0x0000CFF0
		[Token(Token = "0x17001081")]
		public bool IsDeprecated
		{
			[Token(Token = "0x6005181")]
			[Address(RVA = "0x9F5D", Offset = "0x9F5D", VA = "0x9F5D")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x04002C54 RID: 11348
		[Token(Token = "0x4002C54")]
		[FieldOffset(Offset = "0x24")]
		private readonly UserData _userData;

		// Token: 0x04002C55 RID: 11349
		[Token(Token = "0x4002C55")]
		[FieldOffset(Offset = "0x28")]
		private readonly UserData _loggedUser;

		// Token: 0x04002C56 RID: 11350
		[Token(Token = "0x4002C56")]
		[FieldOffset(Offset = "0x2C")]
		private int _lifetimeEndTimestamp;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_LocationType ---
		uint Gameplay_Isles_User_UserIsle__get_LocationType(int param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  uint uVar4;
		  uint *puVar5;
		  undefined4 param1_00;
		  longlong lVar6;
		  int iVar7;
		  int *param1_01;
		  longlong lVar8;
		  uint uVar9;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a58d15 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_UserIsleEvents__UserIsleModel__UserIsleController__UserBuildingTypes__get_Id__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_UserIsleEvents__UserIsleModel__UserIsleController__UserBuildingTypes__get_Model__
		              );
		    Mono_Security_ASN1__get_Item(&UI_Windows_Buildings_CaveWindowArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_PopupController_Show_CaveWindow___);
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_PopupController_Show_SchoolWindow2___);
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_PopupController_Show_ShopWindow___);
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_PopupController_Show_TreeWindow2___);
		    Mono_Security_ASN1__get_Item(&UI_Windows_Buildings_MageSchoolWindow_SchoolWindowArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&UI_Windows_Buildings_ShopWindow_ShopWindow_ShopWindowArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&UI_Windows_Buildings_TreeWindow_TreeWindow2_TreeWindow2Args_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12583);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12664);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12679);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12647);
		    DAT_ram_00a58d15 = '\x01';
		  }
		  local_4 = 0;
		  lVar8 = *(longlong *)(param1 + 0x18);
		  lVar6 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext
		                    (*(undefined4 *)(*(int *)(param1 + 0x10) + 0x48),0);
		  iVar7 = *(int *)(param1 + 0x10);
		  if (DAT_ram_00a58cec == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__BaseBuildingData__TryGetValue__);
		    DAT_ram_00a58cec = '\x01';
		  }
		  uVar9 = 0;
		  uVar1 = 0;
		  iVar7 = UnityEngine_TextCore_LowLevel_LigatureSubstitutionRecord__get_componentGlyphIDs
		                    (*(undefined4 *)(iVar7 + 0x24),param2,&local_4,
		                     Method_System_Collections_Generic_Dictionary_uint__BaseBuildingData__TryGetValue__
		                    );
		  uVar4 = uVar9;
		  if ((iVar7 != 0) &&
		     (iVar7 = Newtonsoft_Json_Converters_XDeclarationWrapper__get_Encoding(local_4,0), uVar4 = uVar1
		     , iVar7 != 0)) {
		    if (param2 == 1) {
		      uVar2 = System_Uri___ctor(0);
		      uVar2 = System_Globalization_TimeSpanFormat_FormatLiterals__get_Start(uVar2,0);
		      uVar3 = unnamed_function_1417
		                        (UI_Windows_Buildings_TreeWindow_TreeWindow2_TreeWindow2Args_TypeInfo);
		      UI_Windows_Buildings_ShopWindow_ShopWindow___Init_g__SpawnShopItemInstance_25_0
		                (uVar3,param1,1,0);
		      uVar4 = Gameplay_Antiq_View_GroupReviewWindow_WindowArgs___ctor
		                        (uVar2,StringLiteral_12679,uVar3,
		                         Method_UI_Windows_PopupController_Show_TreeWindow2___);
		    }
		    else if (param2 != 2) {
		      if (param2 == 3) {
		        uVar2 = System_Uri___ctor(0);
		        uVar2 = System_Globalization_TimeSpanFormat_FormatLiterals__get_Start(uVar2,0);
		        uVar3 = unnamed_function_1417
		                          (UI_Windows_Buildings_ShopWindow_ShopWindow_ShopWindowArgs_TypeInfo);
		        UI_Windows_Buildings_ShopWindow_ShopWindow___Init_g__SpawnShopItemInstance_25_0
		                  (uVar3,param1,3,0);
		        uVar4 = Gameplay_Antiq_View_GroupReviewWindow_WindowArgs___ctor
		                          (uVar2,StringLiteral_12664,uVar3,
		                           Method_UI_Windows_PopupController_Show_ShopWindow___);
		      }
		      else if (param2 == 4) {
		        uVar2 = System_Uri___ctor(0);
		        uVar2 = System_Globalization_TimeSpanFormat_FormatLiterals__get_Start(uVar2,0);
		        param1_01 = *(int **)(*(int *)(param1 + 0x10) + 0x28);
		        iVar7 = *param1_01;
		        if (*(ushort *)(iVar7 + 0xb6) != 0) {
		          do {
		            if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar9 * 8)) {
		              puVar5 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar9 * 8 + 4) * 8 + iVar7 + 0x140
		                               );
		              goto code_r0x80f9e3eb;
		            }
		            uVar9 = uVar9 + 1;
		          } while (*(ushort *)(iVar7 + 0xb6) != uVar9);
		        }
		        puVar5 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x80f9e3eb:
		        uVar3 = (**(code **)((ulonglong)*puVar5 * 4))(param1_01,puVar5[1]);
		        uVar3 = func_ii_7112(uVar3,0);
		        param1_00 = unnamed_function_1417
		                              (UI_Windows_Buildings_MageSchoolWindow_SchoolWindowArgs_TypeInfo);
		        UI_Windows_Buildings_MageSchoolWindow_SchoolWindowArgs__set_LoggedUser
		                  (param1_00,param1,4,uVar3,0);
		        uVar4 = Gameplay_Antiq_View_GroupReviewWindow_WindowArgs___ctor
		                          (uVar2,StringLiteral_12647,param1_00,
		                           Method_UI_Windows_PopupController_Show_SchoolWindow2___);
		      }
		      else if ((param2 == 5) && (lVar8 == lVar6)) {
		        uVar2 = System_Uri___ctor(0);
		        uVar2 = System_Globalization_TimeSpanFormat_FormatLiterals__get_Start(uVar2,0);
		        uVar3 = unnamed_function_1417(UI_Windows_Buildings_CaveWindowArgs_TypeInfo);
		        UI_Windows_Buildings_ShopWindow_ShopWindow___Init_g__SpawnShopItemInstance_25_0
		                  (uVar3,param1,5,0);
		        uVar4 = Gameplay_Antiq_View_GroupReviewWindow_WindowArgs___ctor
		                          (uVar2,StringLiteral_12583,uVar3,
		                           Method_UI_Windows_PopupController_Show_CaveWindow___);
		      }
		    }
		  }
		  return (uint)(uVar4 != 0);
		}
		*/

}
