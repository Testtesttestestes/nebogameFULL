using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Gameplay;
using Gameplay.Combat;
using Gameplay.VortexCombat.Control;
using Gameplay.WorldAxis.Colossus.Combat.Control;
using Gameplay.WorldAxis.Colossus.Combat.Model;
using Gameplay.WorldAxis.Colossus.Combat.View;
using Il2CppDummyDll;
using JetBrains.Annotations;
using Protocol.Dic;
using Utils;

namespace Gameplay.WorldAxis.Colossus.Combat
{
	// Token: 0x02000334 RID: 820
	[Token(Token = "0x2000334")]
	public class ColossusCombat : AbstractCombat<ColossusCombatModel, ColossusCombatEvents, ColossusCombatController, ColossusCombatViewMediator, ColossusCombatView>
	{
		// Token: 0x060012E3 RID: 4835 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012E3")]
		[Address(RVA = "0x64DD", Offset = "0x64DD", VA = "0x64DD", Slot = "11")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Gameplay_WorldAxis_Colossus_Combat_ColossusCombat__Dispose
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5,
		               undefined4 param6,undefined4 param7)
		
		{
		  if (DAT_ram_00a58c11 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_ColossusCombatModel__ColossusCombatEvents__ColossusCombatController__ColossusCombatViewMediator__ColossusCombatView___ctor__
		              );
		    DAT_ram_00a58c11 = '\x01';
		  }
		  Gameplay_Combat_Control_AbstractCombatViewMediator_object__object__object__object___set_View
		            (param1,param3,param4,param5,param6,
		             Method_Gameplay_Combat_AbstractCombat_ColossusCombatModel__ColossusCombatEvents__ColossusCombatController__ColossusCombatViewMediator__ColossusCombatView___ctor__
		            );
		  *(undefined4 *)(param1 + 0x30) = param2;
		  return;
		}
		*/

		}

		// Token: 0x060012E4 RID: 4836 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012E4")]
		[Address(RVA = "0x64DE", Offset = "0x64DE", VA = "0x64DE")]
		public ColossusCombat(ColossusCombat.LaunchParams launchLaunchParams, IGame game, UserData loggedUser, UserData user, BackTime awaitBackTime)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_WorldAxis_Colossus_Combat_ColossusCombat___ctor(int param1,undefined4 param2)
		
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
		  undefined4 uVar6;
		  int *piVar7;
		  int iVar8;
		  undefined4 uVar9;
		  undefined4 param7;
		  undefined4 param12;
		  
		  if (DAT_ram_00a58c12 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_ColossusCombatModel__ColossusCombatEvents__ColossusCombatController__ColossusCombatViewMediator__ColossusCombatView__get_AwaitBackTime__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_ColossusCombatModel__ColossusCombatEvents__ColossusCombatController__ColossusCombatViewMediator__ColossusCombatView__get_Game__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_ColossusCombatModel__ColossusCombatEvents__ColossusCombatController__ColossusCombatViewMediator__ColossusCombatView__get_LoggedUser__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_ColossusCombatModel__ColossusCombatEvents__ColossusCombatController__ColossusCombatViewMediator__ColossusCombatView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_ColossusCombatModel__ColossusCombatEvents__ColossusCombatController__ColossusCombatViewMediator__ColossusCombatView__get_User__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_ColossusCombatModel__ColossusCombatEvents__ColossusCombatController__ColossusCombatViewMediator__ColossusCombatView__set_Mediator__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_AbstractCombat_ColossusCombatModel__ColossusCombatEvents__ColossusCombatController__ColossusCombatViewMediator__ColossusCombatView__set_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_WorldAxis_Colossus_Combat_Control_ColossusCombatController_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_WorldAxis_Colossus_Combat_ColossusCombatEvents_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_WorldAxis_Colossus_Combat_Model_ColossusCombatModel_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_WorldAxis_Colossus_Combat_Factories_ColossusCombatPlayerFactory_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_WorldAxis_Colossus_Combat_Factories_ColossusCombatSpellDataFactory_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_WorldAxis_Colossus_Combat_Control_ColossusCombatViewMediator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Combat_Model_CombatDependencies_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&DefaultNamespace_Scenes___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_CombatService___);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_PartyCombatService___);
		    Mono_Security_ASN1__get_Item(&Core_Net_ServiceFactory_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_VortexCombat_Control_VortexCombatController_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_VortexCombat_Control_VortexCombatViewMediator_TypeInfo);
		    DAT_ram_00a58c12 = '\x01';
		  }
		  param4 = unnamed_function_1417(Gameplay_WorldAxis_Colossus_Combat_ColossusCombatEvents_TypeInfo);
		  uVar6 = *(undefined4 *)(param1 + 0x30);
		  uVar2 = unnamed_function_1417
		                    (
		                    Gameplay_WorldAxis_Colossus_Combat_Factories_ColossusCombatPlayerFactory_TypeInfo
		                    );
		  uVar3 = unnamed_function_1417
		                    (
		                    Gameplay_WorldAxis_Colossus_Combat_Factories_ColossusCombatSpellDataFactory_TypeInfo
		                    );
		  piVar7 = *(int **)(param1 + 0x24);
		  iVar8 = *piVar7;
		  if (*(ushort *)(iVar8 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + iVar8 + 0x158);
		        goto code_r0x80f8ab48;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar7,Core_Gameplay_IGame_TypeInfo,0x13);
		code_r0x80f8ab48:
		  iVar8 = (**(code **)((ulonglong)*puVar4 * 4))(piVar7,puVar4[1]);
		  uVar9 = *(undefined4 *)(iVar8 + 0x14);
		  uVar1 = 0;
		  piVar7 = *(int **)(param1 + 0x24);
		  iVar8 = *piVar7;
		  if (*(ushort *)(iVar8 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + iVar8 + 0x178);
		        goto code_r0x80f8abd0;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar7,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80f8abd0:
		  uVar1 = 0;
		  param6 = (**(code **)((ulonglong)*puVar4 * 4))(piVar7,puVar4[1]);
		  piVar7 = *(int **)(param1 + 0x24);
		  iVar8 = *piVar7;
		  if (*(ushort *)(iVar8 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + iVar8 + 0x220);
		        goto code_r0x80f8ac55;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar7,Core_Gameplay_IGame_TypeInfo,0x2c);
		code_r0x80f8ac55:
		  iVar8 = (**(code **)((ulonglong)*puVar4 * 4))(piVar7,puVar4[1]);
		  param7 = *(undefined4 *)(iVar8 + 0x18);
		  uVar1 = 0;
		  piVar7 = *(int **)(param1 + 0x24);
		  iVar8 = *piVar7;
		  if (*(ushort *)(iVar8 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + iVar8 + 0x148);
		        goto code_r0x80f8acdd;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar7,Core_Gameplay_IGame_TypeInfo,0x11);
		code_r0x80f8acdd:
		  uVar1 = 0;
		  param8 = (**(code **)((ulonglong)*puVar4 * 4))(piVar7,puVar4[1]);
		  piVar7 = *(int **)(param1 + 0x24);
		  iVar8 = *piVar7;
		  if (*(ushort *)(iVar8 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + iVar8 + 0x178);
		        goto code_r0x80f8ad62;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar7,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80f8ad62:
		  uVar1 = 0;
		  param9 = (**(code **)((ulonglong)*puVar4 * 4))(piVar7,puVar4[1]);
		  piVar7 = *(int **)(param1 + 0x24);
		  iVar8 = *piVar7;
		  if (*(ushort *)(iVar8 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + iVar8 + 0x188);
		        goto code_r0x80f8ade7;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar7,Core_Gameplay_IGame_TypeInfo,0x19);
		code_r0x80f8ade7:
		  uVar1 = 0;
		  param10 = (**(code **)((ulonglong)*puVar4 * 4))(piVar7,puVar4[1]);
		  piVar7 = *(int **)(param1 + 0x24);
		  iVar8 = *piVar7;
		  if (*(ushort *)(iVar8 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + iVar8 + 0xe0);
		        goto code_r0x80f8ae6c;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar7,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x80f8ae6c:
		  piVar7 = (int *)(**(code **)((ulonglong)*puVar4 * 4))(piVar7,puVar4[1]);
		  uVar1 = 0;
		  iVar8 = *piVar7;
		  if (*(ushort *)(iVar8 + 0xb6) != 0) {
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + iVar8 + 0xe8);
		        goto code_r0x80f8aeec;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar7,Core_Application_IApp_TypeInfo,5);
		code_r0x80f8aeec:
		  uVar1 = 0;
		  param11 = (**(code **)((ulonglong)*puVar4 * 4))(piVar7,puVar4[1]);
		  piVar7 = *(int **)(param1 + 0x24);
		  iVar8 = *piVar7;
		  if (*(ushort *)(iVar8 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar1 * 8 + 4) * 8 + iVar8 + 0x150);
		        goto code_r0x80f8af71;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar8 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(piVar7,Core_Gameplay_IGame_TypeInfo,0x12);
		code_r0x80f8af71:
		  iVar8 = (**(code **)((ulonglong)*puVar4 * 4))(piVar7,puVar4[1]);
		  param12 = *(undefined4 *)(iVar8 + 0x10);
		  param1_00 = unnamed_function_1417(Gameplay_Combat_Model_CombatDependencies_TypeInfo);
		  Gameplay_Combat_Model_CombatDependencies__set_LocalProps
		            (param1_00,param1,uVar2,uVar3,uVar9,param6,param7,param8,param9,param10,param11,param12,
		             0);
		  uVar2 = *(undefined4 *)(param1 + 0xc);
		  uVar3 = *(undefined4 *)(param1 + 8);
		  uVar9 = *(undefined4 *)(param1 + 0x14);
		  iVar8 = unnamed_function_1417
		                    (Gameplay_WorldAxis_Colossus_Combat_Model_ColossusCombatModel_TypeInfo);
		  Gameplay_WorldAxis_Colossus_Combat_Model_ColossusCombatModel__Dispose
		            (iVar8,uVar6,param1_00,uVar9,uVar3,uVar2,iVar8);
		  *(undefined1 *)(iVar8 + 0x5c) = 1;
		  iVar5 = Mono_Security_ASN1Convert__ToOid(DefaultNamespace_Scenes___TypeInfo,1);
		  *(undefined4 *)(iVar5 + 0x10) = 2;
		  *(int *)(iVar8 + 0x50) = iVar5;
		  iVar5 = Mono_Security_ASN1Convert__ToOid(DefaultNamespace_Scenes___TypeInfo,1);
		  *(undefined4 *)(iVar5 + 0x10) = 0xd;
		  *(int *)(iVar8 + 0x54) = iVar5;
		  *(int *)(param1 + 0x18) = iVar8;
		  if (*(int *)(Core_Net_ServiceFactory_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_ServiceFactory_TypeInfo);
		  }
		  uVar2 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                    (Method_Core_Net_ServiceFactory_GetService_PartyCombatService___);
		  uVar6 = *(undefined4 *)(param1 + 0x18);
		  uVar3 = unnamed_function_1417(Gameplay_VortexCombat_Control_VortexCombatController_TypeInfo);
		  Gameplay_VortexCombat_Control_VortexCombatController__get_PartyCombatService
		            (uVar3,uVar2,uVar6,param4,0);
		  *(undefined4 *)(param1 + 0x28) = uVar3;
		  uVar6 = *(undefined4 *)(param1 + 0x18);
		  uVar2 = unnamed_function_1417(Gameplay_VortexCombat_Control_VortexCombatViewMediator_TypeInfo);
		  Gameplay_VortexCombat_Control_VortexCombatController__HandleJoinToCombatInfoChanged
		            (uVar2,uVar6,param4,uVar3,0);
		  *(undefined4 *)(param1 + 0x2c) = uVar2;
		  uVar3 = *(undefined4 *)(param1 + 0x28);
		  uVar2 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                    (Method_Core_Net_ServiceFactory_GetService_CombatService___);
		  uVar6 = *(undefined4 *)(param1 + 0x18);
		  iVar8 = unnamed_function_1417
		                    (Gameplay_WorldAxis_Colossus_Combat_Control_ColossusCombatController_TypeInfo);
		  if (DAT_ram_00a58c21 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_Control_CombatController_ColossusCombatModel__ColossusCombatEvents___ctor__
		              );
		    DAT_ram_00a58c21 = '\x01';
		  }
		  Sirenix_Serialization_ColorBlockFormatter___Il2CppFullySharedGenericType___Write
		            (iVar8,uVar2,uVar6,param4,
		             Method_Gameplay_Combat_Control_CombatController_ColossusCombatModel__ColossusCombatEvents___ctor__
		            );
		  *(undefined4 *)(iVar8 + 0x20) = uVar3;
		  *(int *)(param1 + 0x10) = iVar8;
		  uVar2 = *(undefined4 *)(param1 + 0x2c);
		  uVar3 = *(undefined4 *)(param1 + 0x18);
		  iVar5 = unnamed_function_1417
		                    (Gameplay_WorldAxis_Colossus_Combat_Control_ColossusCombatViewMediator_TypeInfo)
		  ;
		  if (DAT_ram_00a58c26 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Combat_Control_AbstractCombatViewMediator_ColossusCombatModel__ColossusCombatEvents__ColossusCombatController__ColossusCombatView___ctor__
		              );
		    DAT_ram_00a58c26 = '\x01';
		  }
		  UI_ToolTip_Implementations_View_Combat_AbstractCombatSpellToolTipView_object___HandleTitle
		            (iVar5,uVar3,param4,iVar8,
		             Method_Gameplay_Combat_Control_AbstractCombatViewMediator_ColossusCombatModel__ColossusCombatEvents__ColossusCombatController__ColossusCombatView___ctor__
		            );
		  *(undefined4 *)(iVar5 + 0x34) = uVar2;
		  *(int *)(param1 + 0x1c) = iVar5;
		  return;
		}
		*/

		}

		// Token: 0x060012E5 RID: 4837 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012E5")]
		[Address(RVA = "0x64DF", Offset = "0x64DF", VA = "0x64DF", Slot = "13")]
		protected override void InitMVC()
		{
		}

		// Token: 0x04000A27 RID: 2599
		[Token(Token = "0x4000A27")]
		[FieldOffset(Offset = "0x28")]
		private VortexCombatController _vortexController;

		// Token: 0x04000A28 RID: 2600
		[Token(Token = "0x4000A28")]
		[FieldOffset(Offset = "0x2C")]
		private VortexCombatViewMediator _vortexMediator;

		// Token: 0x04000A29 RID: 2601
		[Token(Token = "0x4000A29")]
		[FieldOffset(Offset = "0x30")]
		private ColossusCombat.LaunchParams _launchParams;

		// Token: 0x02000335 RID: 821
		[Token(Token = "0x2000335")]
		public class LaunchParams : IDisposable
		{
			// Token: 0x170002EB RID: 747
			// (get) Token: 0x060012E6 RID: 4838 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x060012E7 RID: 4839 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170002EB")]
			public IColossusCombatRewards ColossusCombatRewards
			{
				[Token(Token = "0x60012E6")]
				[Address(RVA = "0x64E0", Offset = "0x64E0", VA = "0x64E0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x60012E7")]
				[Address(RVA = "0x64E1", Offset = "0x64E1", VA = "0x64E1")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x170002EC RID: 748
			// (get) Token: 0x060012E8 RID: 4840 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x060012E9 RID: 4841 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170002EC")]
			public IColossusCombatLauncher Launcher
			{
				[Token(Token = "0x60012E8")]
				[Address(RVA = "0x64E2", Offset = "0x64E2", VA = "0x64E2")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x60012E9")]
				[Address(RVA = "0x64E3", Offset = "0x64E3", VA = "0x64E3")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x060012EA RID: 4842 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60012EA")]
			[Address(RVA = "0x64E4", Offset = "0x64E4", VA = "0x64E4")]
			public LaunchParams(IColossusCombatLauncher launcher, IColossusCombatRewards rewards)
			{
			}

			// Token: 0x060012EB RID: 4843 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60012EB")]
			[Address(RVA = "0x64E5", Offset = "0x64E5", VA = "0x64E5", Slot = "4")]
			public void Dispose()
			{
			}

			// Token: 0x04000A2C RID: 2604
			[Token(Token = "0x4000A2C")]
			[FieldOffset(Offset = "0x10")]
			[CanBeNull]
			public ColossusDic Colossus;
		}
	}
}
