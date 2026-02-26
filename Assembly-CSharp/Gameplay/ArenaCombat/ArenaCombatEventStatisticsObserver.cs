using System;
using Core.Application;
using Core.Gameplay;
using Il2CppDummyDll;
using Protocol.Combat;

namespace Gameplay.ArenaCombat
{
	// Token: 0x02000D41 RID: 3393
	[Token(Token = "0x2000D41")]
	public sealed class ArenaCombatEventStatisticsObserver : CombatEventStatisticsObserver<ArenaCombatEvents>
	{
		// Token: 0x0600531E RID: 21278 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600531E")]
		[Address(RVA = "0xA0F3", Offset = "0xA0F3", VA = "0xA0F3")]
		public ArenaCombatEventStatisticsObserver(ArenaCombatEvents events, IApp app, IGame game)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_ArenaCombat_ArenaCombatEventStatisticsObserver___ctor
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  int *param1_01;
		  int iVar3;
		  undefined4 param3_00;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a593c3 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Events_Scopes_CombatScope_ComboEventArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    DAT_ram_00a593c3 = '\x01';
		  }
		  param1_01 = *(int **)(param1 + 0x28);
		  iVar3 = *param1_01;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x100);
		        goto code_r0x80ff9499;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_01,Core_Application_IApp_TypeInfo,8);
		code_r0x80ff9499:
		  iVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_01,puVar2[1]);
		  iVar3 = *(int *)(*(int *)(*(int *)(iVar3 + 0x10) + 0x2c) + 0x18);
		  if (iVar3 != 0) {
		    param3_00 = *(undefined4 *)(param1 + 0x2c);
		    param2_00 = *(undefined4 *)(param1 + 0x28);
		    param1_00 = unnamed_function_1417(Core_Events_Scopes_CombatScope_ComboEventArgs_TypeInfo);
		    Core_Events_Scopes_CombatScope_ComboEventArgs__get_IsPlayersStep
		              (param1_00,param2_00,param3_00,param2,param3,param4,0);
		    (**(code **)((ulonglong)*(uint *)(iVar3 + 0xc) * 4))
		              (*(undefined4 *)(iVar3 + 0x20),param1_00,*(undefined4 *)(iVar3 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600531F RID: 21279 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600531F")]
		[Address(RVA = "0xA0F4", Offset = "0xA0F4", VA = "0xA0F4")]
		private void OnMatchStonesHandler(int numStones, StonesTypes stoneType, bool isPlayerStep)
		{
		/* --- GHIDRA: OnMatchStonesHandler ---
		void Gameplay_ArenaCombat_ArenaCombatEventStatisticsObserver__OnMatchStonesHandler
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  int *param1_01;
		  int iVar3;
		  undefined4 param3_00;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a593c4 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Events_Scopes_CombatScope_UseSpellArgs_TypeInfo);
		    DAT_ram_00a593c4 = '\x01';
		  }
		  param1_01 = *(int **)(param1 + 0x28);
		  iVar3 = *param1_01;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x100);
		        goto code_r0x80ff9595;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_01,Core_Application_IApp_TypeInfo,8);
		code_r0x80ff9595:
		  iVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_01,puVar2[1]);
		  iVar3 = *(int *)(*(int *)(*(int *)(iVar3 + 0x10) + 0x2c) + 0x20);
		  if (iVar3 != 0) {
		    param3_00 = *(undefined4 *)(param1 + 0x2c);
		    param2_00 = *(undefined4 *)(param1 + 0x28);
		    param1_00 = unnamed_function_1417(Core_Events_Scopes_CombatScope_UseSpellArgs_TypeInfo);
		    Core_Events_Scopes_UserScope_BaseUserEventArgs__set_UserData
		              (param1_00,param2_00,param3_00,param2,0);
		    (**(code **)((ulonglong)*(uint *)(iVar3 + 0xc) * 4))
		              (*(undefined4 *)(iVar3 + 0x20),param1_00,*(undefined4 *)(iVar3 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06005320 RID: 21280 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005320")]
		[Address(RVA = "0xA0F5", Offset = "0xA0F5", VA = "0xA0F5")]
		private void OnUseElixirHandler(uint elixirId)
		{
		/* --- GHIDRA: OnUseElixirHandler ---
		void Gameplay_ArenaCombat_ArenaCombatEventStatisticsObserver__OnUseElixirHandler
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  int *param1_01;
		  int iVar3;
		  undefined4 param3_00;
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a593c5 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Events_Scopes_CombatScope_UseSpellArgs_TypeInfo);
		    DAT_ram_00a593c5 = '\x01';
		  }
		  param1_01 = *(int **)(param1 + 0x28);
		  iVar3 = *param1_01;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x100);
		        goto code_r0x80ff968d;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_01,Core_Application_IApp_TypeInfo,8);
		code_r0x80ff968d:
		  iVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_01,puVar2[1]);
		  iVar3 = *(int *)(*(int *)(*(int *)(iVar3 + 0x10) + 0x2c) + 0x1c);
		  if (iVar3 != 0) {
		    param3_00 = *(undefined4 *)(param1 + 0x2c);
		    param2_00 = *(undefined4 *)(param1 + 0x28);
		    param1_00 = unnamed_function_1417(Core_Events_Scopes_CombatScope_UseSpellArgs_TypeInfo);
		    Core_Events_Scopes_UserScope_BaseUserEventArgs__set_UserData
		              (param1_00,param2_00,param3_00,param2,0);
		    (**(code **)((ulonglong)*(uint *)(iVar3 + 0xc) * 4))
		              (*(undefined4 *)(iVar3 + 0x20),param1_00,*(undefined4 *)(iVar3 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06005321 RID: 21281 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005321")]
		[Address(RVA = "0xA0F6", Offset = "0xA0F6", VA = "0xA0F6")]
		private void OnUseSpellHandler(uint spellId)
		{
		/* --- GHIDRA: OnUseSpellHandler ---
		void Gameplay_ArenaCombat_ArenaCombatEventStatisticsObserver__OnUseSpellHandler
		               (undefined4 param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a593c6 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_uint__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_int__StonesTypes__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_ArenaCombat_ArenaCombatEventStatisticsObserver_OnMatchStonesHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_ArenaCombat_ArenaCombatEventStatisticsObserver_OnUseElixirHandler__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_ArenaCombat_ArenaCombatEventStatisticsObserver_OnUseSpellHandler__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_ArenaCombat_CombatEventStatisticsObserver_ArenaCombatEvents__Dispose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_ArenaCombat_CombatEventStatisticsObserver_ArenaCombatEvents__remove_OnMatchStones__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_ArenaCombat_CombatEventStatisticsObserver_ArenaCombatEvents__remove_OnUseElixir__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_ArenaCombat_CombatEventStatisticsObserver_ArenaCombatEvents__remove_OnUseSpell__
		              );
		    DAT_ram_00a593c6 = '\x01';
		  }
		  uVar1 = unnamed_function_1417(System_Action_uint__TypeInfo);
		  func_ii_12322(uVar1,param1,
		                Method_Gameplay_ArenaCombat_ArenaCombatEventStatisticsObserver_OnUseSpellHandler__,0
		               );
		  Gameplay_ArenaCombat_CombatEventStatisticsObserver_object___remove_OnUseElixir
		            (param1,uVar1,
		             Method_Gameplay_ArenaCombat_CombatEventStatisticsObserver_ArenaCombatEvents__remove_OnUseSpell__
		            );
		  uVar1 = unnamed_function_1417(System_Action_uint__TypeInfo);
		  func_ii_12322(uVar1,param1,
		                Method_Gameplay_ArenaCombat_ArenaCombatEventStatisticsObserver_OnUseElixirHandler__,
		                0);
		  Gameplay_ArenaCombat_CombatEventStatisticsObserver_object___remove_OnTurn
		            (param1,uVar1,
		             Method_Gameplay_ArenaCombat_CombatEventStatisticsObserver_ArenaCombatEvents__remove_OnUseElixir__
		            );
		  uVar1 = unnamed_function_1417(System_Action_int__StonesTypes__bool__TypeInfo);
		  System_Action_InputUser__Int32Enum__object___Invoke
		            (uVar1,param1,
		             Method_Gameplay_ArenaCombat_ArenaCombatEventStatisticsObserver_OnMatchStonesHandler__,0
		            );
		  Gameplay_ArenaCombat_CombatEventStatisticsObserver_object___get_LogCorrupted
		            (param1,uVar1,
		             Method_Gameplay_ArenaCombat_CombatEventStatisticsObserver_ArenaCombatEvents__remove_OnMatchStones__
		            );
		  Gameplay_ArenaCombat_CombatEventStatisticsObserver_object___ClearField
		            (param1,
		             Method_Gameplay_ArenaCombat_CombatEventStatisticsObserver_ArenaCombatEvents__Dispose__)
		  ;
		  return;
		}
		*/

		}

		// Token: 0x06005322 RID: 21282 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005322")]
		[Address(RVA = "0xA0F7", Offset = "0xA0F7", VA = "0xA0F7", Slot = "7")]
		public override void Dispose()
		{
		}

		// Token: 0x04002D0F RID: 11535
		[Token(Token = "0x4002D0F")]
		[FieldOffset(Offset = "0x28")]
		private readonly IApp _app;

		// Token: 0x04002D10 RID: 11536
		[Token(Token = "0x4002D10")]
		[FieldOffset(Offset = "0x2C")]
		private readonly IGame _game;
	}
}
