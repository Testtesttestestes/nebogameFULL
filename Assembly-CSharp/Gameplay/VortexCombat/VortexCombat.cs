using System;
using Core.Data;
using Core.Gameplay;
using Gameplay.Combat;
using Gameplay.VortexCombat.Control;
using Gameplay.VortexCombat.Model;
using Gameplay.VortexCombat.View;
using Il2CppDummyDll;
using Utils;

namespace Gameplay.VortexCombat
{
	// Token: 0x020003A3 RID: 931
	[Token(Token = "0x20003A3")]
	public class VortexCombat : AbstractCombat<VortexCombatModel, VortexCombatEvents, VortexCombatController, VortexCombatViewMediator, VortexCombatView>
	{
		// Token: 0x17000396 RID: 918
		// (get) Token: 0x060015BD RID: 5565 RVA: 0x00005268 File Offset: 0x00003468
		[Token(Token = "0x17000396")]
		public bool Avail
		{
			[Token(Token = "0x60015BD")]
			[Address(RVA = "0x677F", Offset = "0x677F", VA = "0x677F")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060015BE RID: 5566 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015BE")]
		[Address(RVA = "0x6780", Offset = "0x6780", VA = "0x6780", Slot = "13")]
		protected override void InitMVC()
		{
		/* --- GHIDRA: InitMVC ---
		uint Gameplay_VortexCombat_VortexCombat__InitMVC(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  int *piVar3;
		  undefined4 param3;
		  uint uVar4;
		  
		  if (DAT_ram_00a58208 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_VortexCombatModel__VortexCombatEvents__VortexCombatController__VortexCombatViewMediator__VortexCombatView__CheckRunRestrictions__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Errors_Expected_ExpectedVortexCombatErrors_TypeInfo);
		    DAT_ram_00a58208 = '\x01';
		  }
		  if (DAT_ram_00a58206 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_VortexCombatModel__VortexCombatEvents__VortexCombatController__VortexCombatViewMediator__VortexCombatView__get_User__
		              );
		    DAT_ram_00a58206 = '\x01';
		  }
		  uVar4 = 0;
		  uVar1 = Core_Data_UserData__set_LevelDic(*(undefined4 *)(param1 + 0xc),0);
		  if (((longlong)(ulonglong)uVar1 < (longlong)*(int *)(*(int *)(param1 + 0x28) + 0x10)) ||
		     (uVar1 = Core_Data_UserData__set_LevelDic(*(undefined4 *)(param1 + 0xc),0),
		     (longlong)*(int *)(*(int *)(param1 + 0x28) + 0x14) < (longlong)(ulonglong)uVar1)) {
		    uVar2 = System_Uri___ctor(0);
		    uVar2 = System_Globalization_TimeSpanFormat_FormatLiterals__get_DayHourSep(uVar2,0);
		    piVar3 = (int *)unnamed_function_1417(Core_Errors_Expected_ExpectedVortexCombatErrors_TypeInfo);
		    param3 = (**(code **)((ulonglong)*(uint *)(*piVar3 + 0xe8) * 4))
		                       (piVar3,param1,*(undefined4 *)(*piVar3 + 0xec));
		    Core_Application_App__get_ToastController(uVar2,2,param3,0);
		  }
		  if (DAT_ram_00a58206 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_VortexCombatModel__VortexCombatEvents__VortexCombatController__VortexCombatViewMediator__VortexCombatView__get_User__
		              );
		    DAT_ram_00a58206 = '\x01';
		  }
		  uVar1 = Core_Data_UserData__set_LevelDic(*(undefined4 *)(param1 + 0xc),0);
		  if ((longlong)*(int *)(*(int *)(param1 + 0x28) + 0x10) <= (longlong)(ulonglong)uVar1) {
		    uVar4 = Core_Data_UserData__set_LevelDic(*(undefined4 *)(param1 + 0xc),0);
		    uVar4 = (uint)((longlong)(ulonglong)uVar4 <= (longlong)*(int *)(*(int *)(param1 + 0x28) + 0x14))
		    ;
		  }
		  return uVar4;
		}
		*/

		}

		// Token: 0x060015BF RID: 5567 RVA: 0x00005280 File Offset: 0x00003480
		[Token(Token = "0x60015BF")]
		[Address(RVA = "0x6781", Offset = "0x6781", VA = "0x6781", Slot = "12")]
		protected override bool CheckRunRestrictions()
		{
		/* --- GHIDRA: CheckRunRestrictions ---
		void Gameplay_VortexCombat_VortexCombat__CheckRunRestrictions
		               (int param1,int *param2,undefined4 param3,undefined4 param4,undefined4 param5,
		               undefined4 param6)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a58209 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_VortexCombatModel__VortexCombatEvents__VortexCombatController__VortexCombatViewMediator__VortexCombatView___ctor__
		              );
		    Mono_Security_ASN1__get_Item(&Method_Core_Extensions_Dict_DictExt_GetArrayParameter_int___);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_26039);
		    DAT_ram_00a58209 = '\x01';
		  }
		  Gameplay_Combat_Control_AbstractCombatViewMediator_object__object__object__object___set_View
		            (param1,param2,param3,param4,param5,
		             Method_Gameplay_Combat_AbstractCombat_VortexCombatModel__VortexCombatEvents__VortexCombatController__VortexCombatViewMediator__VortexCombatView___ctor__
		            );
		  iVar4 = *param2;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x178);
		        goto code_r0x80eb720d;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80eb720d:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		  uVar3 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar3,0);
		  uVar3 = Core_Extensions_Dict_DictExt__BinarySearch_object____Il2CppFullySharedGenericType_
		                    (uVar3,StringLiteral_26039,
		                     Method_Core_Extensions_Dict_DictExt_GetArrayParameter_int___);
		  *(undefined4 *)(param1 + 0x28) = uVar3;
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x060015C0 RID: 5568 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015C0")]
		[Address(RVA = "0x6782", Offset = "0x6782", VA = "0x6782")]
		public VortexCombat(IGame game, UserData loggedUser, UserData user, BackTime awaitBackTime)
		{
		}

		// Token: 0x04000B7C RID: 2940
		[Token(Token = "0x4000B7C")]
		[FieldOffset(Offset = "0x28")]
		public readonly int[] LevelRangeForAvail;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Avail ---
		void Gameplay_VortexCombat_VortexCombat__get_Avail(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined4 param4;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  uint *puVar4;
		  undefined4 param6;
		  undefined4 param8;
		  undefined4 param9;
		  undefined4 param10;
		  undefined4 param11;
		  undefined4 param1_00;
		  int iVar5;
		  int *piVar6;
		  int iVar7;
		  undefined4 uVar8;
		  undefined4 param7;
		  undefined4 param12;
		  
		  if (DAT_ram_00a58207 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_VortexCombatModel__VortexCombatEvents__VortexCombatController__VortexCombatViewMediator__VortexCombatView__get_AwaitBackTime__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_VortexCombatModel__VortexCombatEvents__VortexCombatController__VortexCombatViewMediator__VortexCombatView__get_Game__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_VortexCombatModel__VortexCombatEvents__VortexCombatController__VortexCombatViewMediator__VortexCombatView__get_LoggedUser__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_VortexCombatModel__VortexCombatEvents__VortexCombatController__VortexCombatViewMediator__VortexCombatView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_VortexCombatModel__VortexCombatEvents__VortexCombatController__VortexCombatViewMediator__VortexCombatView__get_User__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_VortexCombatModel__VortexCombatEvents__VortexCombatController__VortexCombatViewMediator__VortexCombatView__set_Mediator__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_VortexCombatModel__VortexCombatEvents__VortexCombatController__VortexCombatViewMediator__VortexCombatView__set_Model__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_Model_CombatDependencies_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&DefaultNamespace_Scenes___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_PartyCombatService___);
		    Mono_Security_ASN1__get_Item(&Core_Net_ServiceFactory_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_VortexCombat_Control_VortexCombatController_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_VortexCombat_VortexCombatEvents_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_VortexCombat_Model_VortexCombatModel_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_VortexCombat_Factories_VortexCombatPlayerFactory_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_VortexCombat_Factories_VortexCombatSpellDataFactory_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_VortexCombat_Control_VortexCombatViewMediator_TypeInfo);
		    DAT_ram_00a58207 = '\x01';
		  }
		  param4 = unnamed_function_1417(Gameplay_VortexCombat_VortexCombatEvents_TypeInfo);
		  uVar2 = unnamed_function_1417(Gameplay_VortexCombat_Factories_VortexCombatPlayerFactory_TypeInfo);
		  uVar3 = unnamed_function_1417
		                    (Gameplay_VortexCombat_Factories_VortexCombatSpellDataFactory_TypeInfo);
		  piVar6 = *(int **)(param1 + 0x24);
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x158);
		        goto code_r0x80eb92d5;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x13);
		code_r0x80eb92d5:
		  iVar7 = (**(code **)((ulonglong)*puVar4 * 4))(piVar6,puVar4[1]);
		  uVar8 = *(undefined4 *)(iVar7 + 0x14);
		  uVar1 = 0;
		  piVar6 = *(int **)(param1 + 0x24);
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x178);
		        goto code_r0x80eb935d;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80eb935d:
		  uVar1 = 0;
		  param6 = (**(code **)((ulonglong)*puVar4 * 4))(piVar6,puVar4[1]);
		  piVar6 = *(int **)(param1 + 0x24);
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x220);
		        goto code_r0x80eb93e2;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x2c);
		code_r0x80eb93e2:
		  iVar7 = (**(code **)((ulonglong)*puVar4 * 4))(piVar6,puVar4[1]);
		  param7 = *(undefined4 *)(iVar7 + 0x18);
		  uVar1 = 0;
		  piVar6 = *(int **)(param1 + 0x24);
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x148);
		        goto code_r0x80eb946a;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x11);
		code_r0x80eb946a:
		  uVar1 = 0;
		  param8 = (**(code **)((ulonglong)*puVar4 * 4))(piVar6,puVar4[1]);
		  piVar6 = *(int **)(param1 + 0x24);
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x178);
		        goto code_r0x80eb94ef;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80eb94ef:
		  uVar1 = 0;
		  param9 = (**(code **)((ulonglong)*puVar4 * 4))(piVar6,puVar4[1]);
		  piVar6 = *(int **)(param1 + 0x24);
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x188);
		        goto code_r0x80eb9574;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x19);
		code_r0x80eb9574:
		  uVar1 = 0;
		  param10 = (**(code **)((ulonglong)*puVar4 * 4))(piVar6,puVar4[1]);
		  piVar6 = *(int **)(param1 + 0x24);
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0xe0);
		        goto code_r0x80eb95f9;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x80eb95f9:
		  piVar6 = (int *)(**(code **)((ulonglong)*puVar4 * 4))(piVar6,puVar4[1]);
		  uVar1 = 0;
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0xe8);
		        goto code_r0x80eb9679;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar6,Core_Application_IApp_TypeInfo,5);
		code_r0x80eb9679:
		  uVar1 = 0;
		  param11 = (**(code **)((ulonglong)*puVar4 * 4))(piVar6,puVar4[1]);
		  piVar6 = *(int **)(param1 + 0x24);
		  iVar7 = *piVar6;
		  if (*(ushort *)(iVar7 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar7 + 0x58) + uVar1 * 8 + 4) * 8 + iVar7 + 0x150);
		        goto code_r0x80eb96fe;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar7 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x12);
		code_r0x80eb96fe:
		  iVar7 = (**(code **)((ulonglong)*puVar4 * 4))(piVar6,puVar4[1]);
		  param12 = *(undefined4 *)(iVar7 + 0x10);
		  param1_00 = unnamed_function_1417(Gameplay_Combat_Model_CombatDependencies_TypeInfo);
		  Gameplay_Combat_Model_CombatDependencies__set_LocalProps
		            (param1_00,param1,uVar2,uVar3,uVar8,param6,param7,param8,param9,param10,param11,param12,
		             0);
		  uVar2 = *(undefined4 *)(param1 + 0xc);
		  uVar3 = *(undefined4 *)(param1 + 8);
		  uVar8 = *(undefined4 *)(param1 + 0x14);
		  iVar7 = unnamed_function_1417(Gameplay_VortexCombat_Model_VortexCombatModel_TypeInfo);
		  Gameplay_Combat_TeamCombat_TeamCombatEvents___ctor(iVar7,param1_00,uVar8,uVar3,uVar2,0);
		  *(undefined1 *)(iVar7 + 0x5c) = 1;
		  iVar5 = Mono_Security_ASN1Convert__ToOid(DefaultNamespace_Scenes___TypeInfo,1);
		  *(undefined4 *)(iVar5 + 0x10) = 2;
		  *(int *)(iVar7 + 0x50) = iVar5;
		  iVar5 = Mono_Security_ASN1Convert__ToOid(DefaultNamespace_Scenes___TypeInfo,1);
		  *(undefined4 *)(iVar5 + 0x10) = 0xb;
		  *(int *)(iVar7 + 0x54) = iVar5;
		  *(int *)(param1 + 0x18) = iVar7;
		  if (*(int *)(Core_Net_ServiceFactory_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_ServiceFactory_TypeInfo);
		  }
		  uVar2 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                    (Method_Core_Net_ServiceFactory_GetService_PartyCombatService___);
		  uVar8 = *(undefined4 *)(param1 + 0x18);
		  uVar3 = unnamed_function_1417(Gameplay_VortexCombat_Control_VortexCombatController_TypeInfo);
		  if (DAT_ram_00a58238 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_Control_CombatController_VortexCombatModel__VortexCombatEvents___ctor__
		              );
		    DAT_ram_00a58238 = '\x01';
		  }
		  Sirenix_Serialization_ColorBlockFormatter___Il2CppFullySharedGenericType___Write
		            (uVar3,uVar2,uVar8,param4,
		             Method_Gameplay_Combat_Control_CombatController_VortexCombatModel__VortexCombatEvents___ctor__
		            );
		  *(undefined4 *)(param1 + 0x10) = uVar3;
		  uVar8 = *(undefined4 *)(param1 + 0x18);
		  uVar2 = unnamed_function_1417(Gameplay_VortexCombat_Control_VortexCombatViewMediator_TypeInfo);
		  if (DAT_ram_00a58245 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_Control_AbstractCombatViewMediator_VortexCombatModel__VortexCombatEvents__VortexCombatController__VortexCombatView___ctor__
		              );
		    DAT_ram_00a58245 = '\x01';
		  }
		  UI_ToolTip_Implementations_View_Combat_AbstractCombatSpellToolTipView_object___HandleTitle
		            (uVar2,uVar8,param4,uVar3,
		             Method_Gameplay_Combat_Control_AbstractCombatViewMediator_VortexCombatModel__VortexCombatEvents__VortexCombatController__VortexCombatView___ctor__
		            );
		  *(undefined4 *)(param1 + 0x1c) = uVar2;
		  return;
		}
		*/

}
