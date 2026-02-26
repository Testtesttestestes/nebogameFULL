using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Gameplay;
using Gameplay.Clans.ClanWars;
using Gameplay.Clans.Combat.Control;
using Gameplay.Clans.Combat.Model;
using Gameplay.Clans.Combat.View;
using Gameplay.Combat;
using Il2CppDummyDll;

namespace Gameplay.Clans.Combat
{
	// Token: 0x02000A8E RID: 2702
	[Token(Token = "0x2000A8E")]
	public class ClanCombat : AbstractCombat<ClanCombatModel, ClanCombatEvents, ClanCombatController, ClanCombatViewMediator, ClanCombatView>
	{
		// Token: 0x060040CB RID: 16587 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040CB")]
		[Address(RVA = "0x8F82", Offset = "0x8F82", VA = "0x8F82", Slot = "11")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Gameplay_Clans_Combat_ClanCombat__Dispose
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5,
		               undefined4 param6)
		
		{
		  if (DAT_ram_00a57761 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_ClanCombatModel__ClanCombatEvents__ClanCombatController__ClanCombatViewMediator__ClanCombatView___ctor__
		              );
		    DAT_ram_00a57761 = '\x01';
		  }
		  Gameplay_Combat_Control_AbstractCombatViewMediator_object__object__object__object___set_View
		            (param1,param2,param4,param5,0,
		             Method_Gameplay_Combat_AbstractCombat_ClanCombatModel__ClanCombatEvents__ClanCombatController__ClanCombatViewMediator__ClanCombatView___ctor__
		            );
		  *(undefined4 *)(param1 + 0x28) = param3;
		  return;
		}
		*/

		}

		// Token: 0x060040CC RID: 16588 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040CC")]
		[Address(RVA = "0x8F83", Offset = "0x8F83", VA = "0x8F83")]
		public ClanCombat(IGame game, ClanCombat.ClanCombatArgs args, UserData loggedUser, UserData user)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Clans_Combat_ClanCombat___ctor(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 param4;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  uint *puVar4;
		  undefined4 uVar5;
		  undefined4 param8;
		  undefined4 param9;
		  undefined4 param10;
		  undefined4 param11;
		  undefined4 param1_00;
		  int iVar6;
		  int *piVar7;
		  int iVar8;
		  undefined4 uVar9;
		  undefined4 uVar10;
		  undefined4 param12;
		  
		  if (DAT_ram_00a57762 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_ClanCombatModel__ClanCombatEvents__ClanCombatController__ClanCombatViewMediator__ClanCombatView__get_AwaitBackTime__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_ClanCombatModel__ClanCombatEvents__ClanCombatController__ClanCombatViewMediator__ClanCombatView__get_Game__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_ClanCombatModel__ClanCombatEvents__ClanCombatController__ClanCombatViewMediator__ClanCombatView__get_LoggedUser__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_ClanCombatModel__ClanCombatEvents__ClanCombatController__ClanCombatViewMediator__ClanCombatView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_ClanCombatModel__ClanCombatEvents__ClanCombatController__ClanCombatViewMediator__ClanCombatView__get_User__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_ClanCombatModel__ClanCombatEvents__ClanCombatController__ClanCombatViewMediator__ClanCombatView__set_Mediator__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_ClanCombatModel__ClanCombatEvents__ClanCombatController__ClanCombatViewMediator__ClanCombatView__set_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Clans_Combat_Control_ClanCombatController_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Clans_Combat_ClanCombatEvents_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Clans_Combat_Model_ClanCombatModel_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Clans_Combat_Factories_ClanCombatPlayerFactory_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Clans_Combat_Factories_ClanCombatSpellDataFactory_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Clans_Combat_Control_ClanCombatViewMediator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_Model_CombatDependencies_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&DefaultNamespace_Scenes___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_ClanWarsService___);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_CombatService___);
		    Mono_Security_ASN1__get_Item(&Core_Net_ServiceFactory_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_24935);
		    DAT_ram_00a57762 = '\x01';
		  }
		  param4 = unnamed_function_1417(Gameplay_Clans_Combat_ClanCombatEvents_TypeInfo);
		  uVar2 = unnamed_function_1417(Gameplay_Clans_Combat_Factories_ClanCombatPlayerFactory_TypeInfo);
		  uVar3 = unnamed_function_1417(Gameplay_Clans_Combat_Factories_ClanCombatSpellDataFactory_TypeInfo)
		  ;
		  piVar7 = *(int **)(param1 + 0x24);
		  iVar8 = *piVar7;
		  if (*(ushort *)(iVar8 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + iVar8 + 0x158);
		        goto code_r0x80dd51de;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar7,Core_Gameplay_IGame_TypeInfo,0x13);
		code_r0x80dd51de:
		  iVar8 = (**(code **)((ulonglong)*puVar4 * 4))(piVar7,puVar4[1]);
		  uVar9 = *(undefined4 *)(iVar8 + 0x14);
		  uVar1 = 0;
		  piVar7 = *(int **)(param1 + 0x24);
		  iVar8 = *piVar7;
		  if (*(ushort *)(iVar8 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + iVar8 + 0x178);
		        goto code_r0x80dd5266;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar7,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80dd5266:
		  uVar1 = 0;
		  uVar5 = (**(code **)((ulonglong)*puVar4 * 4))(piVar7,puVar4[1]);
		  piVar7 = *(int **)(param1 + 0x24);
		  iVar8 = *piVar7;
		  if (*(ushort *)(iVar8 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + iVar8 + 0x220);
		        goto code_r0x80dd52eb;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar7,Core_Gameplay_IGame_TypeInfo,0x2c);
		code_r0x80dd52eb:
		  iVar8 = (**(code **)((ulonglong)*puVar4 * 4))(piVar7,puVar4[1]);
		  uVar10 = *(undefined4 *)(iVar8 + 0x18);
		  uVar1 = 0;
		  piVar7 = *(int **)(param1 + 0x24);
		  iVar8 = *piVar7;
		  if (*(ushort *)(iVar8 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + iVar8 + 0x148);
		        goto code_r0x80dd5373;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar7,Core_Gameplay_IGame_TypeInfo,0x11);
		code_r0x80dd5373:
		  uVar1 = 0;
		  param8 = (**(code **)((ulonglong)*puVar4 * 4))(piVar7,puVar4[1]);
		  piVar7 = *(int **)(param1 + 0x24);
		  iVar8 = *piVar7;
		  if (*(ushort *)(iVar8 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + iVar8 + 0x178);
		        goto code_r0x80dd53f8;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar7,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80dd53f8:
		  uVar1 = 0;
		  param9 = (**(code **)((ulonglong)*puVar4 * 4))(piVar7,puVar4[1]);
		  piVar7 = *(int **)(param1 + 0x24);
		  iVar8 = *piVar7;
		  if (*(ushort *)(iVar8 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + iVar8 + 0x188);
		        goto code_r0x80dd547d;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar7,Core_Gameplay_IGame_TypeInfo,0x19);
		code_r0x80dd547d:
		  uVar1 = 0;
		  param10 = (**(code **)((ulonglong)*puVar4 * 4))(piVar7,puVar4[1]);
		  piVar7 = *(int **)(param1 + 0x24);
		  iVar8 = *piVar7;
		  if (*(ushort *)(iVar8 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + iVar8 + 0xe0);
		        goto code_r0x80dd5502;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar7,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x80dd5502:
		  piVar7 = (int *)(**(code **)((ulonglong)*puVar4 * 4))(piVar7,puVar4[1]);
		  uVar1 = 0;
		  iVar8 = *piVar7;
		  if (*(ushort *)(iVar8 + 0xb6) != 0) {
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + iVar8 + 0xe8);
		        goto code_r0x80dd5582;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar7,Core_Application_IApp_TypeInfo,5);
		code_r0x80dd5582:
		  uVar1 = 0;
		  param11 = (**(code **)((ulonglong)*puVar4 * 4))(piVar7,puVar4[1]);
		  piVar7 = *(int **)(param1 + 0x24);
		  iVar8 = *piVar7;
		  if (*(ushort *)(iVar8 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + iVar8 + 0x150);
		        goto code_r0x80dd5607;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar7,Core_Gameplay_IGame_TypeInfo,0x12);
		code_r0x80dd5607:
		  iVar8 = (**(code **)((ulonglong)*puVar4 * 4))(piVar7,puVar4[1]);
		  param12 = *(undefined4 *)(iVar8 + 0x10);
		  uVar1 = 0;
		  param1_00 = unnamed_function_1417(Gameplay_Combat_Model_CombatDependencies_TypeInfo);
		  Gameplay_Combat_Model_CombatDependencies__set_LocalProps
		            (param1_00,param1,uVar2,uVar3,uVar9,uVar5,uVar10,param8,param9,param10,param11,param12,0
		            );
		  piVar7 = *(int **)(param1 + 0x24);
		  iVar8 = *piVar7;
		  if (*(ushort *)(iVar8 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + iVar8 + 0x178);
		        goto code_r0x80dd56b8;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar7,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80dd56b8:
		  uVar1 = 0;
		  uVar2 = (**(code **)((ulonglong)*puVar4 * 4))(piVar7,puVar4[1]);
		  uVar2 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar2,0);
		  uVar2 = Core_Extensions_Dict_DictExt__GetUserBuildingLevelDic(uVar2,StringLiteral_24935,0);
		  piVar7 = *(int **)(param1 + 0x24);
		  iVar8 = *piVar7;
		  if (*(ushort *)(iVar8 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + iVar8 + 0x160);
		        goto code_r0x80dd5751;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar7,Core_Gameplay_IGame_TypeInfo,0x14);
		code_r0x80dd5751:
		  uVar3 = (**(code **)((ulonglong)*puVar4 * 4))(piVar7,puVar4[1]);
		  uVar9 = *(undefined4 *)(param1 + 0xc);
		  uVar5 = *(undefined4 *)(param1 + 8);
		  uVar10 = *(undefined4 *)(param1 + 0x14);
		  iVar8 = unnamed_function_1417(Gameplay_Clans_Combat_Model_ClanCombatModel_TypeInfo);
		  Gameplay_Clans_Combat_Model_ClanCombatModel__Dispose
		            (iVar8,param1_00,uVar2,uVar3,uVar10,uVar5,uVar9,iVar8);
		  iVar6 = Mono_Security_ASN1Convert__ToOid(DefaultNamespace_Scenes___TypeInfo,1);
		  *(undefined4 *)(iVar6 + 0x10) = 2;
		  *(int *)(iVar8 + 0x50) = iVar6;
		  iVar6 = Mono_Security_ASN1Convert__ToOid(DefaultNamespace_Scenes___TypeInfo,1);
		  *(undefined4 *)(iVar6 + 0x10) = 0xc;
		  *(int *)(iVar8 + 0x54) = iVar6;
		  *(int *)(param1 + 0x18) = iVar8;
		  iVar6 = *(int *)(param1 + 0x28);
		  if (iVar6 != 0) {
		    *(undefined4 *)(iVar8 + 0x60) = *(undefined4 *)(iVar6 + 8);
		    *(undefined1 *)(iVar8 + 100) = *(undefined1 *)(iVar6 + 0xc);
		  }
		  if (*(int *)(Core_Net_ServiceFactory_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_ServiceFactory_TypeInfo);
		  }
		  uVar2 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                    (Method_Core_Net_ServiceFactory_GetService_ClanWarsService___);
		  uVar3 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                    (Method_Core_Net_ServiceFactory_GetService_CombatService___);
		  uVar9 = *(undefined4 *)(param1 + 0x18);
		  iVar8 = unnamed_function_1417(Gameplay_Clans_Combat_Control_ClanCombatController_TypeInfo);
		  if (DAT_ram_00a5779b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_Control_CombatController_ClanCombatModel__ClanCombatEvents___ctor__
		              );
		    DAT_ram_00a5779b = '\x01';
		  }
		  Sirenix_Serialization_ColorBlockFormatter___Il2CppFullySharedGenericType___Write
		            (iVar8,uVar3,uVar9,param4,
		             Method_Gameplay_Combat_Control_CombatController_ClanCombatModel__ClanCombatEvents___ctor__
		            );
		  *(undefined4 *)(iVar8 + 0x20) = uVar2;
		  *(int *)(param1 + 0x10) = iVar8;
		  uVar3 = *(undefined4 *)(param1 + 0x18);
		  uVar2 = unnamed_function_1417(Gameplay_Clans_Combat_Control_ClanCombatViewMediator_TypeInfo);
		  if (DAT_ram_00a577af == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_Control_AbstractCombatViewMediator_ClanCombatModel__ClanCombatEvents__ClanCombatController__ClanCombatView___ctor__
		              );
		    DAT_ram_00a577af = '\x01';
		  }
		  UI_ToolTip_Implementations_View_Combat_AbstractCombatSpellToolTipView_object___HandleTitle
		            (uVar2,uVar3,param4,iVar8,
		             Method_Gameplay_Combat_Control_AbstractCombatViewMediator_ClanCombatModel__ClanCombatEvents__ClanCombatController__ClanCombatView___ctor__
		            );
		  *(undefined4 *)(param1 + 0x1c) = uVar2;
		  return;
		}
		*/

		}

		// Token: 0x060040CD RID: 16589 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040CD")]
		[Address(RVA = "0x8F84", Offset = "0x8F84", VA = "0x8F84", Slot = "13")]
		protected override void InitMVC()
		{
		/* --- GHIDRA: InitMVC ---
		int Gameplay_Clans_Combat_ClanCombat__InitMVC(int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  int *param1_00;
		  int iVar5;
		  int iVar6;
		  
		  if (DAT_ram_00a57763 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_ClanCombatModel__ClanCombatEvents__ClanCombatController__ClanCombatViewMediator__ClanCombatView__Stop__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_ClanCombatModel__ClanCombatEvents__ClanCombatController__ClanCombatViewMediator__ClanCombatView__TryRun__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Clans_Combat_ClanCombat_ClanCombatArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Clans_Combat_ClanCombat_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a57763 = '\x01';
		  }
		  iVar5 = *param1;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x240);
		        goto code_r0x80dd5a85;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1,Core_Gameplay_IGame_TypeInfo,0x30);
		code_r0x80dd5a85:
		  uVar1 = 0;
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1,puVar2[1]);
		  iVar5 = unnamed_function_1417(Gameplay_Clans_Combat_ClanCombat_ClanCombatArgs_TypeInfo);
		  *(undefined1 *)(iVar5 + 0xc) = 1;
		  *(undefined4 *)(iVar5 + 8) = uVar3;
		  iVar6 = *param1;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x140);
		        goto code_r0x80dd5b1e;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x80dd5b1e:
		  uVar1 = 0;
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1,puVar2[1]);
		  uVar3 = func_ii_7112(uVar3,0);
		  iVar6 = *param1;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x140);
		        goto code_r0x80dd5ba6;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x80dd5ba6:
		  uVar4 = (**(code **)((ulonglong)*puVar2 * 4))(param1,puVar2[1]);
		  uVar4 = func_ii_7112(uVar4,0);
		  param1_00 = (int *)unnamed_function_1417(Gameplay_Clans_Combat_ClanCombat_TypeInfo);
		  if (DAT_ram_00a57761 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_ClanCombatModel__ClanCombatEvents__ClanCombatController__ClanCombatViewMediator__ClanCombatView___ctor__
		              );
		    DAT_ram_00a57761 = '\x01';
		  }
		  Gameplay_Combat_Control_AbstractCombatViewMediator_object__object__object__object___set_View
		            (param1_00,param1,uVar3,uVar4,0,
		             Method_Gameplay_Combat_AbstractCombat_ClanCombatModel__ClanCombatEvents__ClanCombatController__ClanCombatViewMediator__ClanCombatView___ctor__
		            );
		  param1_00[10] = iVar5;
		  iVar5 = Gameplay_Combat_AbstractCombat_object__object__object__object__object___Stop
		                    (param1_00,
		                     Method_Gameplay_Combat_AbstractCombat_ClanCombatModel__ClanCombatEvents__ClanCombatController__ClanCombatViewMediator__ClanCombatView__TryRun__
		                    );
		  if (iVar5 == 0) {
		    Gameplay_Combat_AbstractCombat_object__object__object__object__object___SetView
		              (param1_00,
		               Method_Gameplay_Combat_AbstractCombat_ClanCombatModel__ClanCombatEvents__ClanCombatController__ClanCombatViewMediator__ClanCombatView__Stop__
		              );
		    (**(code **)((ulonglong)*(uint *)(*param1_00 + 0x118) * 4))
		              (param1_00,*(undefined4 *)(*param1_00 + 0x11c));
		  }
		  return iVar5;
		}
		*/

		}

		// Token: 0x060040CE RID: 16590 RVA: 0x0000C7B0 File Offset: 0x0000A9B0
		[Token(Token = "0x60040CE")]
		[Address(RVA = "0x8F85", Offset = "0x8F85", VA = "0x8F85")]
		public static bool TryRunViewMode(IGame game)
		{
			return default(bool);
		}

		// Token: 0x040023F1 RID: 9201
		[Token(Token = "0x40023F1")]
		[FieldOffset(Offset = "0x28")]
		public ClanCombat.ClanCombatArgs Args;

		// Token: 0x02000A8F RID: 2703
		[Token(Token = "0x2000A8F")]
		public class ClanCombatArgs
		{
			// Token: 0x17000CC3 RID: 3267
			// (get) Token: 0x060040CF RID: 16591 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x060040D0 RID: 16592 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000CC3")]
			public IClanWars ClanWars
			{
				[Token(Token = "0x60040CF")]
				[Address(RVA = "0x8F86", Offset = "0x8F86", VA = "0x8F86")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x60040D0")]
				[Address(RVA = "0x8F87", Offset = "0x8F87", VA = "0x8F87")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x060040D1 RID: 16593 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60040D1")]
			[Address(RVA = "0x8F88", Offset = "0x8F88", VA = "0x8F88")]
			public ClanCombatArgs(IClanWars model, bool isViewMode)
			{
			}

			// Token: 0x060040D2 RID: 16594 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60040D2")]
			[Address(RVA = "0x8F89", Offset = "0x8F89", VA = "0x8F89")]
			public ClanCombatArgs(IClanWars model)
			{
			}

			// Token: 0x040023F3 RID: 9203
			[Token(Token = "0x40023F3")]
			[FieldOffset(Offset = "0xC")]
			public readonly bool IsViewMode;
		}
	}
}
